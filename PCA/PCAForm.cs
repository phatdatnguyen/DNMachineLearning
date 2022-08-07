using Accord;
using Accord.IO;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Kernels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DNMachineLearning.PCA
{
    public partial class PCAForm : Form
    {
        // Fields
        private KernelPrincipalComponentAnalysis kpca = null;
        private string[] features = null;
        private string[] pcs = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;

        private DataTable projectedTrainingDataset = null;

        private DataTable projectionInputDataTable = null;
        private DataTable projectionPCDataTable = null;

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
        public PCAForm()
        {
            InitializeComponent();

            DataLoaded += OnDataLoaded;
            ModelTrained += OnModelTrained;
        }

        public PCAForm(KernelPrincipalComponentAnalysis kpca, DataTable trainingDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            DataLoaded += OnDataLoaded;
            ModelTrained += OnModelTrained;

            LoadData(trainingDataset);

            SetLearningParameters(serializedLearningParameters);

            ModelTrained(new ModelTrainedEventArgs() { Model = kpca });
        }

        // Form event handlers
        private void PCAForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (kpca != null && modelTrained)
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
            if (!modelTrained || kpca == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 4; // pca
                    byte modelIndex = 0;

                    kpca.Save(out byte[] serializedModel);
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
            learningParameters.Add("method", methodComboBox.SelectedIndex.ToString());
            learningParameters.Add("number of components", numberOfComponentsNumericUpDown.Value.ToString());
            learningParameters.Add("centering", centeringCheckBox.Checked.ToString());
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
            methodComboBox.SelectedIndex = Convert.ToInt32(learningParameters["method"]);
            numberOfComponentsNumericUpDown.Value = Convert.ToDecimal(learningParameters["number of components"]);
            centeringCheckBox.Checked = Convert.ToBoolean(learningParameters["centering"]);
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

                    dataTable.ToMatrix(); // will throw an exception if any data is not numeric

                    string[] features = new string[dataTable.Columns.Count];
                    for (int i = 0; i < features.Length; i++)
                        features[i] = dataTable.Columns[i].ColumnName;

                    DataLoaded(new DataLoadedEventArgs() { DataTable = dataTable, Features = features });
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
                string[] features = new string[trainingDataset.Columns.Count];
                for (int i = 0; i < features.Length; i++)
                    features[i] = trainingDataset.Columns[i].ColumnName;

                DataLoaded(new DataLoadedEventArgs() { DataTable = trainingDataset, Features = features });
            }
        }

        private void OnDataLoaded(DataLoadedEventArgs e)
        {
            trainingDataset = e.DataTable;
            features = e.Features;
            trainingInputColumns = trainingDataset.ToMatrix().ToJagged();

            dataDataGridView.Columns.Clear();
            dataDataGridView.DataSource = trainingDataset;
            dataVisualizeButton.Enabled = true;

            numberOfComponentsNumericUpDown.Maximum = features.Length;
            numberOfComponentsNumericUpDown.Value = features.Length;
            methodComboBox.SelectedIndex = 0;
            analysisTableLayoutPanel.Visible = true;

            dataLoaded = true;
        }

        private void dataVisualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(trainingDataset, "Data");
            visualizeDataDialog.Show(this);
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

            KernelPrincipalComponentAnalysis kpca = null;
            IKernel kernel = CreateKernel();
            try
            {
                switch (methodComboBox.SelectedItem.ToString())
                {
                    case "Center":
                        kpca = new KernelPrincipalComponentAnalysis(kernel, PrincipalComponentMethod.Center);
                        break;
                    case "Standardize":
                        kpca = new KernelPrincipalComponentAnalysis(kernel, PrincipalComponentMethod.Standardize);
                        break;
                }
                kpca.NumberOfOutputs = Convert.ToInt32(numberOfComponentsNumericUpDown.Value);
                kpca.Center = centeringCheckBox.Checked;
                kpca.Learn(trainingInputColumns);

                ModelTrained(new ModelTrainedEventArgs() { Model = kpca });
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
            kpca = (KernelPrincipalComponentAnalysis)e.Model;

            serializedLearningParameters = GetLearningParameters();

            analysisParametersPanel.BackColor = Color.LightGreen;

            pcs = new string[kpca.Components.Count];
            principalComponentComboBox.Items.Clear();
            for (int i = 0; i < kpca.Components.Count; i++)
            {
                pcs[i] = "PC" + (i + 1).ToString();
                principalComponentComboBox.Items.Add("PC" + (i + 1).ToString());
            }

            double[][] projectionResult = kpca.Transform(trainingInputColumns);
            projectedDataDataGridView.Columns.Clear();
            projectedTrainingDataset = projectionResult.ToTable(pcs);
            projectedDataDataGridView.DataSource = projectedTrainingDataset;
            projectedDataTableLayoutPanel.Visible = true;

            singleProjectionInputDataGridView.Columns.Clear();
            foreach (string feature in features)
                singleProjectionInputDataGridView.Columns.Add(feature, feature);
            singleProjectionInputDataGridView.Rows.Add();

            singleProjectionPCDataGridView.Columns.Clear();
            foreach (string pc in pcs)
                singleProjectionPCDataGridView.Columns.Add(pc, pc);
            singleProjectionPCDataGridView.Rows.Add();

            projectionTabControl.Visible = true;

            modelTrained = true;
            principalComponentComboBox.SelectedIndex = 0;
            principalComponentsViewPanel.Visible = true;

            statusLabel.Text = "Status: Analysis complete.";
            Cursor = Cursors.Default;
        }

        // Projected data
        private void projectedDataVisualizedButton_Click(object sender, EventArgs e)
        {
            VisualizeDataDialog visualizePCADataDialog = new VisualizeDataDialog(projectedTrainingDataset, "Projected data");
            visualizePCADataDialog.Show(this);
        }

        // PCs
        private void principalComponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!modelTrained)
                return;

            PrincipalComponent component = kpca.Components[principalComponentComboBox.SelectedIndex];
            eigenvalueTextBox.Text = component.Eigenvalue.ToString();
            proportionTextBox.Text = component.Proportion.ToString();
            eigenvectorDataGridView.DataSource = component.Eigenvector.ToJagged().ToTable();
        }

        // Projection
        private void singleProjectionProjectButton_Click(object sender, EventArgs e)
        {
            if (kpca == null)
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

                double[] projectedData = kpca.Transform(inputs);
                for (int i = 0; i < pcs.Length; i++)
                    singleProjectionPCDataGridView.Rows[0].Cells[i].Value = projectedData[i].ToString();
                
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
            if (kpca == null)
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

                    double[][] projectedData = kpca.Transform(inputColumns);
                    projectionPCDataTable = projectedData.ToTable(pcs);
                    datasetProjectionPCDataGridView.Columns.Clear();
                    datasetProjectionPCDataGridView.DataSource = projectionPCDataTable;

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
            VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(projectionPCDataTable, "Data - Projected feature space");
            visualizeDataDialog.Show(this);
        }
    }
}
