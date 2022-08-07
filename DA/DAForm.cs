using Accord;
using Accord.IO;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Kernels;
using DNMachineLearning.Classification;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNMachineLearning.DA
{
    public partial class DAForm : Form
    {
        // Fields
        private KernelDiscriminantAnalysis kda = null;
        private KernelDiscriminantAnalysis.Pipeline kdaPipeline = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private string[] features = null;
        private string target = "";
        private string[] discriminants = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private string[] trainingOutputColumn = null;
        private int[] trainingClassIndexColumn = null;

        private DataTable projectedTrainingDataset = null;

        private DataTable projectionInputDataTable = null;
        private DataTable projectionDiscriminantDataTable = null;

        private string serializedLearningParameters = "";

        private bool dataLoaded = false;
        private bool modelTrained = false;

        // Property
        public bool IsModelTrained { get { return modelTrained; } }

        // Events
        public delegate void DataLoadedEventHandler(DataLoadedEventArgs e);
        public event DataLoadedEventHandler DataLoaded;

        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        // Constructors
        public DAForm()
        {
            InitializeComponent();

            DataLoaded += OnDataLoaded;
            ModelTrained += OnModelTrained;
        }

        public DAForm(KernelDiscriminantAnalysis kda, DataTable trainingDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            DataLoaded += OnDataLoaded;
            ModelTrained += OnModelTrained;

            LoadData(trainingDataset);

            SetLearningParameters(serializedLearningParameters);

            ModelTrained(new ModelTrainedEventArgs() { Model = kda });
        }

        // Form event handlers
        private void DAForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (kda != null && modelTrained)
            {
                switch (MessageBox.Show(mainForm, "Do you want to save this task?", "Save task", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        mainForm.SaveCurrentModel();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
        }

        public void SaveModel(string filePath)
        {
            if (!modelTrained || kda == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 5; // da
                    byte modelIndex = 0;

                    kda.Save(out byte[] serializedModel);
                    int modelSize = serializedModel.Length;

                    int dataSize = 0;

                    byte[] serializedTrainingDataset = null;
                    int trainingDatasetSize = 0;
                    if (trainingDataset != null)
                    {
                        trainingDataset.Save(out serializedTrainingDataset);
                        trainingDatasetSize = serializedTrainingDataset.Length;
                    }

                    int testDataSize = 0;

                    binaryWriter.Write(taskIndex);
                    binaryWriter.Write(modelIndex);
                    binaryWriter.Write(serializedLearningParameters);
                    binaryWriter.Write(modelSize);
                    binaryWriter.Write(serializedModel);
                    binaryWriter.Write(dataSize);
                    binaryWriter.Write(trainingDatasetSize);
                    binaryWriter.Write(serializedTrainingDataset);
                    binaryWriter.Write(testDataSize);
                }
            }
        }

        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            int kernel = 0;
            if (gaussianKernelRadioButton.Checked)
                kernel = 1;
            else if (laplacianKernelRadioButton.Checked)
                kernel = 2;
            else if (sigmoidKernelRadioButton.Checked)
                kernel = 3;
            learningParameters.Add("kernel", kernel.ToString());
            learningParameters.Add("polynomial degree", polynomialDegreeNumericUpDown.Value.ToString());
            learningParameters.Add("polynomial constant", polynomialConstantNumericUpDown.Value.ToString());
            learningParameters.Add("gaussian sigma", gaussianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("laplacian sigma", laplacianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid alpha", sigmoidAlphaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid constant", sigmoidConstantNumericUpDown.Value.ToString());
            learningParameters.Add("number of discriminants", numberOfDiscriminantsNumericUpDown.Value.ToString());
            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);

            int kernel = Convert.ToInt32(learningParameters["kernel"]);
            if (kernel == 1)
                gaussianKernelRadioButton.Checked = true;
            else if (kernel == 2)
                laplacianKernelRadioButton.Checked = true;
            else if (kernel == 3)
                sigmoidKernelRadioButton.Checked = true;
            polynomialDegreeNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial degree"]);
            polynomialConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial constant"]);
            gaussianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["gaussian sigma"]);
            laplacianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["laplacian sigma"]);
            sigmoidAlphaNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid alpha"]);
            sigmoidConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid constant"]);
            numberOfDiscriminantsNumericUpDown.Value = Convert.ToDecimal(learningParameters["number of discriminants"]);
        }

        // Load data
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (dataLoaded)
            {
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            if (loadDataFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string filename = loadDataFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".csv")
                {
                    CsvReader csvReader = new CsvReader(filename, dataHasHeadersCheckBox.Checked);
                    DataTable dataTable = csvReader.ToTable();

                    if (dataTable.Columns.Count <= 1 || dataTable.Rows.Count == 0)
                        throw new Exception("Invalid data!");

                    DataTable clonedDataTable = dataTable.DeepClone();
                    clonedDataTable.Columns.RemoveAt(dataTable.Columns.Count - 1);
                    clonedDataTable.ToMatrix(); // will throw an exception if any data is not numeric

                    string[] classLabels = dataTable.Columns[dataTable.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
                    if (classLabels.Length > 10)
                        throw new Exception("Data contain too many classes!");

                    string target = dataTable.Columns[dataTable.Columns.Count - 1].ColumnName;
                    string[] features = new string[dataTable.Columns.Count - 1];
                    for (int i = 0; i < features.Length; i++)
                        features[i] = dataTable.Columns[i].ColumnName;

                    DataLoaded(new DataLoadedEventArgs() { DataTable = dataTable, Features = features, Target = target });
                }
                else
                {
                    throw new Exception("Cannot open the selected file!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData(DataTable trainingDataset)
        {
            if (trainingDataset != null)
            {
                string target = trainingDataset.Columns[trainingDataset.Columns.Count - 1].ColumnName;
                string[] features = new string[trainingDataset.Columns.Count - 1];
                for (int i = 0; i < features.Length; i++)
                    features[i] = trainingDataset.Columns[i].ColumnName;

                DataLoaded(new DataLoadedEventArgs() { DataTable = trainingDataset, Features = features, Target = target });
            }
        }

        private void OnDataLoaded(DataLoadedEventArgs e)
        {
            trainingDataset = e.DataTable;

            DataTable trainingDataTable = e.DataTable.DeepClone();
            trainingOutputColumn = trainingDataTable.Columns[trainingDataTable.Columns.Count - 1].ToArray<string>();
            trainingDataTable.Columns.RemoveAt(trainingDataTable.Columns.Count - 1);
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();

            features = e.Features;
            target = e.Target;

            string[] classLabels = trainingOutputColumn.Distinct().OrderBy(x => x).ToArray();
            classes = new Dictionary<int, string>();
            for (int i = 0; i < classLabels.Length; i++)
                classes.Add(i, classLabels[i]);

            trainingClassIndexColumn = new int[trainingOutputColumn.Length];
            for (int i = 0; i < trainingOutputColumn.Length; i++)
                trainingClassIndexColumn[i] = classes.FirstOrDefault(x => x.Value == trainingOutputColumn[i]).Key;

            dataDataGridView.Columns.Clear();
            dataDataGridView.DataSource = trainingDataset;
            dataVisualizeButton.Enabled = true;

            numberOfDiscriminantsNumericUpDown.Maximum = features.Length;
            numberOfDiscriminantsNumericUpDown.Value = features.Length;
            
            analysisTableLayoutPanel.Visible = true;
            dataLoaded = true;
        }

        private void dataVisualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(trainingDataset, "Data");
            visualizeClassificationDataDialog.Show(this);
        }

        // Kernel
        public IKernel CreateKernel()
        {
            if (gaussianKernelRadioButton.Checked)
                return new Gaussian((double)gaussianSigmaNumericUpDown.Value);
            else if (polynomialKernelRadioButton.Checked)
            {
                if (polynomialDegreeNumericUpDown.Value == 1)
                    return new Linear((double)polynomialConstantNumericUpDown.Value);
                return new Polynomial((int)polynomialDegreeNumericUpDown.Value, (double)polynomialConstantNumericUpDown.Value);
            }
            else if (laplacianKernelRadioButton.Checked)
                return new Laplacian((double)laplacianSigmaNumericUpDown.Value);
            else // sigmoidKernelRadioButton.Checked
                return new Sigmoid((double)sigmoidAlphaNumericUpDown.Value, (double)sigmoidConstantNumericUpDown.Value);
        }

        private void gaussianEstimateButton_Click(object sender, EventArgs e)
        {
            Gaussian gaussian = Gaussian.Estimate(trainingInputColumns, trainingInputColumns.Length);
            gaussianSigmaNumericUpDown.Value = (decimal)gaussian.Sigma;
        }

        private void laplacianEstimateButton_Click(object sender, EventArgs e)
        {
            Laplacian laplacian = Laplacian.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);
            laplacianSigmaNumericUpDown.Value = (decimal)laplacian.Sigma;
        }

        private void sigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            Sigmoid sigmoid = Sigmoid.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                sigmoidAlphaNumericUpDown.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                sigmoidConstantNumericUpDown.Value = (decimal)sigmoid.Constant;
        }

        // Analysis
        private void analyzeButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Status: Analyzing...";
            Cursor = Cursors.WaitCursor;

            KernelDiscriminantAnalysis kda = null;
            IKernel kernel = CreateKernel();
            try
            {
                kda = new KernelDiscriminantAnalysis(kernel)
                {
                    NumberOfOutputs = Convert.ToInt32(numberOfDiscriminantsNumericUpDown.Value)
                };
                kda.Learn(trainingInputColumns, trainingClassIndexColumn);
                
                ModelTrained(new ModelTrainedEventArgs() { Model = kda });
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Status:";
                Cursor = Cursors.Arrow;
                return;
            }
        }

        private void OnModelTrained(ModelTrainedEventArgs e)
        {
            kda = (KernelDiscriminantAnalysis)e.Model;
            kdaPipeline = kda.Learn(trainingInputColumns, trainingClassIndexColumn);
            int[] predictedClassIndexColumn = kdaPipeline.Decide(trainingInputColumns);

            serializedLearningParameters = GetLearningParameters();

            analysisParametersPanel.BackColor = Color.LightGreen;
            
            discriminants = new string[kda.Discriminants.Count];
            principalComponentComboBox.Items.Clear();
            for (int i = 0; i < kda.Discriminants.Count; i++)
            {
                discriminants[i] = "Discriminant " + (i + 1).ToString();
                principalComponentComboBox.Items.Add("Discriminant " + (i + 1).ToString());
            }

            double[][] projectionResult = kda.Transform(trainingInputColumns);
            int outputColumnIndex = discriminants.Length;
            projectedTrainingDataset = projectionResult.ToTable(discriminants);
            projectedTrainingDataset.Columns.Add(target);
            for (int i = 0; i < predictedClassIndexColumn.Length; i++)
                projectedTrainingDataset.Rows[i][outputColumnIndex] = classes[predictedClassIndexColumn[i]];

            projectedDataTableLayoutPanel.Visible = true;
            projectedDataDataGridView.Columns.Clear();
            projectedDataDataGridView.DataSource = projectedTrainingDataset;
            foreach (DataGridViewRow dataGridViewRow in projectedDataDataGridView.Rows)
            {
                int rowIndex = dataGridViewRow.Index;
                if (dataGridViewRow.Cells[outputColumnIndex].Value.ToString() == trainingOutputColumn[rowIndex])
                    dataGridViewRow.Cells[outputColumnIndex].Style.BackColor = Color.LightGreen;
                else
                    dataGridViewRow.Cells[outputColumnIndex].Style.BackColor = Color.Red;
            }

            singleProjectionInputDataGridView.Columns.Clear();
            foreach (string feature in features)
                singleProjectionInputDataGridView.Columns.Add(feature, feature);
            singleProjectionInputDataGridView.Rows.Add();

            singleProjectionPCDataGridView.Columns.Clear();
            foreach (string discriminant in discriminants)
                singleProjectionPCDataGridView.Columns.Add(discriminant, discriminant);
            singleProjectionPCDataGridView.Columns.Add(target, target);
            singleProjectionPCDataGridView.Rows.Add();

            projectionTabControl.Visible = true;

            modelTrained = true;
            principalComponentComboBox.SelectedIndex = 0;
            DiscriminantsViewPanel.Visible = true;

            statusLabel.Text = "Status: Analysis complete.";
            Cursor = Cursors.Default;
        }

        // Projected data
        private void projectedDataVisualizedButton_Click(object sender, EventArgs e)
        {
            VisualizeDataDialog visualizePCADataDialog = new VisualizeDataDialog(projectedTrainingDataset, "Projected data");
            visualizePCADataDialog.Show(this);
        }

        // Discriminants
        private void principalComponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!modelTrained)
                return;

            Discriminant discriminant = kda.Discriminants[principalComponentComboBox.SelectedIndex];
            eigenvalueTextBox.Text = discriminant.Eigenvalue.ToString();
            proportionTextBox.Text = discriminant.Proportion.ToString();
            eigenvectorDataGridView.DataSource = discriminant.Eigenvector.ToJagged().ToTable();
        }

        // Projection
        private void singleProjectionProjectButton_Click(object sender, EventArgs e)
        {
            if (kda == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                double[] inputs = new double[features.Length];
                for (int i = 0; i < features.Length; i++)
                    inputs[i] = Convert.ToDouble(singleProjectionInputDataGridView.Rows[0].Cells[i].Value);

                double[] projectedData = kda.Transform(inputs);
                for (int i = 0; i < discriminants.Length; i++)
                    singleProjectionPCDataGridView.Rows[0].Cells[i].Value = projectedData[i].ToString();

                int predictedClassIndex = kdaPipeline.Decide(inputs);
                singleProjectionPCDataGridView.Rows[0].Cells[singleProjectionPCDataGridView.Columns.Count - 1].Value = classes[predictedClassIndex];

                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        private void datasetProjectionLoadButton_Click(object sender, EventArgs e)
        {
            if (kda == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loadDataFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                string filename = loadDataFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".csv")
                {
                    CsvReader csvReader = new CsvReader(filename, dataHasHeadersCheckBox.Checked);
                    DataTable projectionDataTable = csvReader.ToTable();
                    if (projectionDataTable.Columns.Count != features.Length)
                        throw new Exception("Projection dataset does not match training dataset!");

                    projectionInputDataTable = projectionDataTable;
                    datasetProjectionInputDataGridView.Columns.Clear();
                    datasetProjectionInputDataGridView.DataSource = projectionInputDataTable;

                    double[][] inputColumns = projectionDataTable.ToMatrix().ToJagged();

                    double[][] projectedData = kda.Transform(inputColumns);
                    int[] predictedIndexColumn = kdaPipeline.Decide(inputColumns);
                    int outputColumnIndex = discriminants.Length;

                    projectionDiscriminantDataTable = projectedData.ToTable(discriminants);
                    projectionDiscriminantDataTable.Columns.Add(target);
                    for (int i = 0; i < predictedIndexColumn.Length; i++)
                        projectionDiscriminantDataTable.Rows[i][outputColumnIndex] = classes[predictedIndexColumn[i]];
                    datasetProjectionDDataGridView.Columns.Clear();
                    datasetProjectionDDataGridView.DataSource = projectionDiscriminantDataTable;

                    visualizeDataButton.Enabled = true;
                    visualizeProjectedDataButton.Enabled = true;
                    Cursor = Cursors.Default;
                }
                else
                {
                    throw new Exception("Cannot open the selected file!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        private void visualizeDataButton_Click(object sender, EventArgs e)
        {
            VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(projectionInputDataTable, "Data - Input feature space");
            visualizeDataDialog.Show(this);
        }

        private void visualizeProjectedDataButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(projectionDiscriminantDataTable, "Data");
            visualizeClassificationDataDialog.Show(this);
        }
    }
}
