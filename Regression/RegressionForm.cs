using Accord.IO;
using Accord.Math;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Accord.Statistics.Kernels;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.Neuro;
using Accord.Statistics.Models.Regression.Linear;
using Accord;
using System.Text;

namespace DNMachineLearning.Regression
{
    public partial class RegressionForm : Form
    {
        // Fields
        private object regressor = null;
        private string[] features;
        private string target;

        private DataTable data = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private double[] trainingOutputColumn = null;

        private DataTable testDataset = null;
        private double[][] testInputColumns = null;
        private double[] testOutputColumn = null;

        private string serializedLearningParameters = "";

        private bool modelTrained = false;

        // Property
        public bool IsModelTrained { get { return modelTrained; } }

        // Event
        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        // Constructors
        public RegressionForm()
        {
            InitializeComponent();

            ModelTrained += OnModelTrained;
        }

        public RegressionForm(object model, DataTable data, DataTable trainingDataset, DataTable testDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            ModelTrained += OnModelTrained;

            dataControl.LoadData(data, trainingDataset, testDataset);

            if (model.GetType() == typeof(MultipleLinearRegression))
            {
                modelPanel.Controls.Add(new LinearRegressionLearningControl());
                ((LinearRegressionLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(PolynomialRegression))
            {
                modelPanel.Controls.Add(new PolynomialRegressionLearningControl());
                ((PolynomialRegressionLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(SupportVectorMachine) || model.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                SVMRegressionLearningControl svmRegressionLearningControl = new SVMRegressionLearningControl();
                modelPanel.Controls.Add(svmRegressionLearningControl);

                if (trainingInputColumns != null)
                    svmRegressionLearningControl.InputColumns = trainingInputColumns;

                svmRegressionLearningControl.SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(ActivationNetwork))
            {
                ANNRegressionLearningControl annRegressionLearningControl = new ANNRegressionLearningControl();
                modelPanel.Controls.Add(annRegressionLearningControl);

                if (trainingInputColumns != null)
                {
                    annRegressionLearningControl.InputColumns = trainingInputColumns;
                    annRegressionLearningControl.OutputColumn = trainingOutputColumn;
                }

                annRegressionLearningControl.SetLearningParameters(serializedLearningParameters);

                annRegressionLearningControl.ModelConverged += OnANNConverged;
                annRegressionLearningControl.TrainingStarted += OnANNTrainingStarted;
                trainButton.Enabled = false;
            }

            modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
            regressionTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
            chooseModelButton.Text = "Change model...";

            ModelTrained(new ModelTrainedEventArgs() { Model = model });
        }

        // Form event handlers
        private void ClassificationForm_Resize(object sender, EventArgs e)
        {
            ResizeContents();
        }

        private void ResizeContents()
        {
            dataControl.Invalidate();
            if (modelPanel.Controls.Count > 0)
            {
                modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
                regressionTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
                modelPanel.Controls[0].Invalidate();
            }
            if (trainingPanel.Controls.Count > 0)
            {
                trainingPanel.Controls[0].Left = (trainingPanel.Width - trainingPanel.Controls[0].Width) / 2;
                regressionTableLayoutPanel.RowStyles[2].Height = trainingPanel.Controls[0].Height + 10;
                trainingPanel.Controls[0].Invalidate();
            }
            testRegressionControl.Invalidate();
            predictRegressionControl.Invalidate();
        }

        private void RegressionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (regressor != null && modelTrained)
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
            if (!modelTrained || regressor == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 2; // regression
                    byte modelIndex = 0;

                    byte[] serializedModel = null;
                    if (regressor.GetType() == typeof(MultipleLinearRegression))
                    {
                        modelIndex = 0;
                        ((MultipleLinearRegression)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(PolynomialRegression))
                    {
                        modelIndex = 1;
                        ((PolynomialRegression)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(SupportVectorMachine))
                    {
                        modelIndex = 2;
                        ((SupportVectorMachine)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                    {
                        modelIndex = 3;
                        ((SupportVectorMachine<IKernel>)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(ActivationNetwork))
                    {
                        modelIndex = 4;
                        ((ActivationNetwork)regressor).Save(out serializedModel);
                    }
                    int modelSize = serializedModel.Length;

                    byte[] serializedData = null;
                    int dataSize = 0;
                    if (data != null)
                    {
                        data.Save(out serializedData);
                        dataSize = serializedData.Length;
                    }

                    byte[] serializedTrainingDataset = null;
                    int trainingDatasetSize = 0;
                    if (trainingDataset != null)
                    {
                        trainingDataset.Save(out serializedTrainingDataset);
                        trainingDatasetSize = serializedTrainingDataset.Length;
                    }

                    byte[] serializedTestDataset = null;
                    int testDataSize = 0;
                    if (testDataset != null)
                    {
                        testDataset.Save(out serializedTestDataset);
                        testDataSize = serializedTestDataset.Length;
                    }

                    binaryWriter.Write(taskIndex);
                    binaryWriter.Write(modelIndex);
                    binaryWriter.Write(serializedLearningParameters);
                    binaryWriter.Write(modelSize);
                    binaryWriter.Write(serializedModel);
                    binaryWriter.Write(dataSize);
                    binaryWriter.Write(serializedData);
                    binaryWriter.Write(trainingDatasetSize);
                    binaryWriter.Write(serializedTrainingDataset);
                    binaryWriter.Write(testDataSize);
                    binaryWriter.Write(serializedTestDataset);
                }
            }
        }

        // Load data
        private void dataControl_DataLoaded(DataLoadedEventArgs e)
        {
            data = e.DataTable;
        }

        private void dataControl_TrainingDataLoaded(DataLoadedEventArgs e)
        {
            trainingDataset = e.DataTable;

            DataTable trainingDataTable = e.DataTable.DeepClone();
            trainingOutputColumn = trainingDataTable.Columns[trainingDataTable.Columns.Count - 1].ToArray<double>();
            trainingDataTable.Columns.RemoveAt(trainingDataTable.Columns.Count - 1);
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();

            features = e.Features;
            target = e.Target;

            if (modelPanel.Controls.Count == 1 && modelPanel.Controls[0].GetType() == typeof(SVMRegressionLearningControl))
            {
                SVMRegressionLearningControl svmRegressionLearningControl = (SVMRegressionLearningControl)modelPanel.Controls[0];
                svmRegressionLearningControl.InputColumns = trainingInputColumns;
            }
            if (modelPanel.Controls.Count == 1 && modelPanel.Controls[0].GetType() == typeof(ANNRegressionLearningControl))
            {
                ANNRegressionLearningControl annRegressionLearningControl = (ANNRegressionLearningControl)modelPanel.Controls[0];
                annRegressionLearningControl.InputColumns = trainingInputColumns;
                annRegressionLearningControl.OutputColumn = trainingOutputColumn;
            }
        }

        private void dataControl_TestDataLoaded(DataLoadedEventArgs e)
        {
            testDataset = e.DataTable;

            DataTable testDataTable = e.DataTable.DeepClone();
            testOutputColumn = testDataTable.Columns[testDataTable.Columns.Count - 1].ToArray<double>();
            testDataTable.Columns.RemoveAt(testDataTable.Columns.Count - 1);
            testInputColumns = testDataTable.ToMatrix().ToJagged();
        }

        // Model
        private void chooseModelButton_Click(object sender, EventArgs e)
        {
            ChooseRegressionModelDialog chooseRegressionModelDialog = new ChooseRegressionModelDialog();
            if (chooseRegressionModelDialog.ShowDialog() != DialogResult.OK)
                return;

            trainButton.Enabled = true;
            modelPanel.Controls.Clear();
            modelPanel.BackColor = SystemColors.Control;
            trainingPanel.Controls.Clear();
            regressionTableLayoutPanel.RowStyles[2].Height = 100f;
            trainingPanel.BackColor = SystemColors.Control;

            switch (chooseRegressionModelDialog.modelComboBox.SelectedIndex)
            {
                case 0:
                    LinearRegressionLearningControl linearRegressionLearningControl = new LinearRegressionLearningControl();
                    modelPanel.Controls.Add(linearRegressionLearningControl);

                    break;
                case 1:
                    PolynomialRegressionLearningControl polynomialRegressionLearningControl = new PolynomialRegressionLearningControl();
                    modelPanel.Controls.Add(polynomialRegressionLearningControl);

                    break;
                case 2:
                    SVMRegressionLearningControl svmRegressionLearningControl = new SVMRegressionLearningControl();
                    modelPanel.Controls.Add(svmRegressionLearningControl);

                    if (trainingInputColumns != null)
                        svmRegressionLearningControl.InputColumns = trainingInputColumns;

                    break;
                case 3:
                    ANNRegressionLearningControl annRegressionLearningControl = new ANNRegressionLearningControl();
                    modelPanel.Controls.Add(annRegressionLearningControl);

                    if (trainingInputColumns != null)
                    {
                        annRegressionLearningControl.InputColumns = trainingInputColumns;
                        annRegressionLearningControl.OutputColumn = trainingOutputColumn;
                    }

                    annRegressionLearningControl.ModelConverged += OnANNConverged;
                    annRegressionLearningControl.TrainingStarted += OnANNTrainingStarted;
                    trainButton.Enabled = false;
                    break;
            }

            modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
            regressionTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
            chooseModelButton.Text = "Change model...";

            modelTrained = false;
            regressor = null;

            testRegressionControl.Visible = false;
            testRegressionControl.Reset();
            predictRegressionControl.Visible = false;
            predictRegressionControl.Reset();
        }

        // Training
        private void trainButton_Click(object sender, EventArgs e)
        {
            if (trainingInputColumns == null)
            {
                MessageBox.Show(this, "Training dataset cannot be empty!", "Training dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (modelPanel.Controls.Count == 0)
            {
                MessageBox.Show(this, "You have to choose a model!", "Choose model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            trainingPanel.Controls.Clear();
            regressionTableLayoutPanel.RowStyles[2].Height = 100f;
            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            try
            {
                object regressor = null;

                if (modelPanel.Controls[0].GetType() == typeof(LinearRegressionLearningControl))
                {
                    LinearRegressionLearningControl linearRegressionControl = (LinearRegressionLearningControl)modelPanel.Controls[0];
                    OrdinaryLeastSquares ordinaryLeastSquares = new OrdinaryLeastSquares()
                    {
                        UseIntercept = !linearRegressionControl.InterceptCheckBox.Checked
                    };
                    regressor = ordinaryLeastSquares.Learn(trainingInputColumns, trainingOutputColumn);
                }
                else if (modelPanel.Controls[0].GetType() == typeof(PolynomialRegressionLearningControl))
                {
                    if (trainingInputColumns.Columns() != 1)
                        throw new Exception("You can only have 1 feature for polynomial regression!");

                    PolynomialRegressionLearningControl polynomialRegressionLearningControl = (PolynomialRegressionLearningControl)modelPanel.Controls[0];
                    PolynomialLeastSquares polynomialLeastSquares = new PolynomialLeastSquares()
                    {
                        Degree = Convert.ToInt32(polynomialRegressionLearningControl.DegreeNumericUpDown.Value)
                    };
                    regressor = polynomialLeastSquares.Learn(trainingInputColumns.GetColumn(0), trainingOutputColumn);
                }
                else if (modelPanel.Controls[0].GetType() == typeof(SVMRegressionLearningControl))
                {
                    SVMRegressionLearningControl svmRegressionLearningControl = (SVMRegressionLearningControl)modelPanel.Controls[0];
                    IKernel kernel = svmRegressionLearningControl.CreateKernel();
                    if (svmRegressionLearningControl.SequentialMinimalOptimizationRegressionRadioButton.Checked)
                    {
                        SequentialMinimalOptimizationRegression<IKernel> sequentialMinimalOptimizationRegression = new SequentialMinimalOptimizationRegression<IKernel>()
                        {
                            Complexity = Convert.ToDouble(svmRegressionLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmRegressionLearningControl.ToleranceNumericUpDown.Value),
                            Epsilon = Convert.ToDouble(svmRegressionLearningControl.EpsilonNumericUpDown.Value),
                            Kernel = kernel
                        };
                        regressor = sequentialMinimalOptimizationRegression.Learn(trainingInputColumns, trainingOutputColumn);
                    }
                    else if (svmRegressionLearningControl.LinearRegressionCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                        LinearRegressionCoordinateDescent linearRegressionCoordinateDescent = new LinearRegressionCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmRegressionLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmRegressionLearningControl.ToleranceNumericUpDown.Value),
                            Epsilon = Convert.ToDouble(svmRegressionLearningControl.EpsilonNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        regressor = linearRegressionCoordinateDescent.Learn(trainingInputColumns, trainingOutputColumn);
                    }
                    else if (svmRegressionLearningControl.LinearRegressionNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Newton method can only use linear kernel!");
                        LinearRegressionNewtonMethod linearRegressionNewtonMethod = new LinearRegressionNewtonMethod()
                        {
                            Complexity = Convert.ToDouble(svmRegressionLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmRegressionLearningControl.ToleranceNumericUpDown.Value),
                            Epsilon = Convert.ToDouble(svmRegressionLearningControl.EpsilonNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        regressor = linearRegressionNewtonMethod.Learn(trainingInputColumns, trainingOutputColumn);
                    }
                }

                ModelTrained(new ModelTrainedEventArgs() { Model = regressor });
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Status:";
                Cursor = Cursors.Default;
            }
        }

        private void OnModelTrained(ModelTrainedEventArgs e)
        {
            regressor = e.Model;
            trainingPanel.Controls.Clear();
            regressionTableLayoutPanel.RowStyles[2].Height = 100f;

            if (regressor.GetType() == typeof(MultipleLinearRegression))
            {
                serializedLearningParameters = ((LinearRegressionLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                trainingPanel.Controls.Add(new LinearRegressionModelControl((MultipleLinearRegression)regressor, features));
            }
            else if (regressor.GetType() == typeof(PolynomialRegression))
            {
                serializedLearningParameters = ((PolynomialRegressionLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                trainingPanel.Controls.Add(new PolynomialRegressionModelControl((PolynomialRegression)regressor));
            }
            else if (regressor.GetType() == typeof(SupportVectorMachine))
                serializedLearningParameters = ((SVMRegressionLearningControl)modelPanel.Controls[0]).GetLearningParameters();
            else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                serializedLearningParameters = ((SVMRegressionLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                SupportVectorMachine<IKernel> svm = (SupportVectorMachine<IKernel>)regressor;

                if (svm.SupportVectors != null && svm.SupportVectors.Length > 0)
                    trainingPanel.Controls.Add(new SVMRegressionModelControl(svm.SupportVectors, svm.Weights, features, target, trainingInputColumns, trainingOutputColumn));
            }
            else if (regressor.GetType() == typeof(ActivationNetwork))
            {
                serializedLearningParameters = ((ANNRegressionLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                trainingPanel.Controls.Add(new ANNRegressionModelControl((ActivationNetwork)regressor, features, target));
                predictRegressionControl.OutputRange = trainingOutputColumn.GetRange();
            }

            modelPanel.BackColor = Color.LightGreen;

            if (trainingPanel.Controls.Count > 0)
            {
                trainingPanel.Controls[0].Left = (trainingPanel.Width - trainingPanel.Controls[0].Width) / 2;
                regressionTableLayoutPanel.RowStyles[2].Height = trainingPanel.Controls[0].Height + 10;
                trainingPanel.BackColor = Color.LightGreen;
            }

            predictRegressionControl.Regressor = regressor;
            predictRegressionControl.ColumnNames = features.Concatenate(target);
            predictRegressionControl.Visible = true;

            modelTrained = true;
            statusLabel.Text = "Status: Model trained.";
            Cursor = Cursors.Default;
        }

        private void OnANNTrainingStarted(EventArgs e)
        {
            regressor = null;
            modelPanel.BackColor = SystemColors.Control;
            trainingPanel.Controls.Clear();
            regressionTableLayoutPanel.RowStyles[2].Height = 100f;
            trainingPanel.BackColor = SystemColors.Control;
        }

        private void OnANNConverged(ModelTrainedEventArgs e)
        {
            ModelTrained(new ModelTrainedEventArgs() { Model = e.Model });
        }

        // Testing
        private void testButton_Click(object sender, EventArgs e)
        {
            if (testInputColumns == null)
            {
                MessageBox.Show(this, "Test dataset cannot be empty!", "Test dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (testInputColumns.Columns() != features.Length)
            {
                MessageBox.Show(this, "Test dataset does not match training dataset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!modelTrained || regressor == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                double[] predictedOutputColumn = null;
                if (regressor.GetType() == typeof(MultipleLinearRegression))
                {
                    predictedOutputColumn = ((MultipleLinearRegression)regressor).Transform(testInputColumns);
                }
                else if (regressor.GetType() == typeof(PolynomialRegression))
                {
                    predictedOutputColumn = ((PolynomialRegression)regressor).Transform(testInputColumns.GetColumn(0));
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine))
                {
                    predictedOutputColumn = ((SupportVectorMachine)regressor).Score(testInputColumns);
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    predictedOutputColumn = ((SupportVectorMachine<IKernel>)regressor).Score(testInputColumns);
                }
                else if (regressor.GetType() == typeof(ActivationNetwork))
                {
                    ActivationNetwork ann = (ActivationNetwork)regressor;
                    DoubleRange unitRange = new DoubleRange(-1, 1);
                    DoubleRange outputRange = trainingOutputColumn.GetRange();
                    predictedOutputColumn = new double[testInputColumns.Length];
                    for (int i = 0; i < predictedOutputColumn.Length; i++)
                        predictedOutputColumn[i] = ann.Compute(testInputColumns[i])[0].Scale(unitRange, outputRange);
                }

                DataTable testDataTable = testInputColumns.ToTable(features);
                testDataTable.Columns.Add(target);
                testDataTable.Columns.Add(target + " (predicted)");

                for (int i = 0; i < testDataTable.Rows.Count; i++)
                {
                    testDataTable.Rows[i][target] = testOutputColumn[i];
                    testDataTable.Rows[i][target + " (predicted)"] = predictedOutputColumn[i];
                }

                for (int i = 0; i < testDataTable.Columns.Count; i++)
                    testDataTable.Columns[i].ReadOnly = false;

                testRegressionControl.Visible = true;
                testRegressionControl.TestDataTable = testDataTable;

                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }
    }
}
