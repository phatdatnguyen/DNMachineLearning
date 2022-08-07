using Accord;
using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Neuro;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression.Linear;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DNMachineLearning.Regression
{
    public partial class PredictRegressionControl : UserControl
    {
        // Fields
        private object regressor = null;
        private string[] columnNames = null;
        private DataTable predictDataTable = null;
        private DoubleRange outputRange = new DoubleRange(-1, 1);

        // Properties
        public object Regressor
        {
            set { regressor = value; }
        }

        public string[] ColumnNames
        {
            set
            {
                columnNames = value;
                singlePredictionDataGridView.Columns.Clear();
                foreach (string columnName in columnNames)
                    singlePredictionDataGridView.Columns.Add(columnName, columnName);
                singlePredictionDataGridView.Columns[singlePredictionDataGridView.Columns.Count - 1].Name += " (predicted)";
                singlePredictionDataGridView.Columns[singlePredictionDataGridView.Columns.Count - 1].ReadOnly = true;
                singlePredictionDataGridView.Rows.Add();
                singlePredictionDataGridView.Rows[0].Cells[singlePredictionDataGridView.Columns.Count - 1].Style.BackColor = Color.LightGreen;
            }
        }

        public DoubleRange OutputRange { set { outputRange = value; } }

        // Constructor
        public PredictRegressionControl()
        {
            InitializeComponent();
        }

        // Methods
        private void predictButton_Click(object sender, EventArgs e)
        {
            if (regressor == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                double[] inputs = new double[columnNames.Length - 1];
                for (int i = 0; i < columnNames.Length - 1; i++)
                    inputs[i] = Convert.ToDouble(singlePredictionDataGridView.Rows[0].Cells[i].Value);

                double predictedValue = 0;
                if (regressor.GetType() == typeof(MultipleLinearRegression))
                {
                    predictedValue = ((MultipleLinearRegression)regressor).Transform(inputs);
                }
                else if (regressor.GetType() == typeof(PolynomialRegression))
                {
                    predictedValue = ((PolynomialRegression)regressor).Transform(inputs[0]);
                }
                else if(regressor.GetType() == typeof(SupportVectorMachine))
                {
                    predictedValue = ((SupportVectorMachine)regressor).Score(inputs);
                }
                else if(regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    predictedValue = ((SupportVectorMachine<IKernel>)regressor).Score(inputs);
                }
                else if (regressor.GetType() == typeof(ActivationNetwork))
                {
                    DoubleRange unitRange = new DoubleRange(-1, 1);
                    predictedValue = ((ActivationNetwork)regressor).Compute(inputs)[0].Scale(unitRange, outputRange);
                }

                singlePredictionDataGridView.Rows[0].Cells[columnNames.Length - 1].Value = predictedValue;
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (regressor == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loadPredictDataFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                string filename = loadPredictDataFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".csv")
                {
                    CsvReader csvReader = new CsvReader(filename, dataHasHeadersCheckBox.Checked);
                    DataTable predictDataTable = csvReader.ToTable();
                    if (predictDataTable.Columns.Count != columnNames.Length - 1)
                        throw new Exception("Prediction dataset does not match training dataset!");

                    datasetPredictionDataGridView.Columns.Clear();
                    datasetPredictionDataGridView.DataSource = predictDataTable;
                    
                    double[][] inputColumns = predictDataTable.ToMatrix().ToJagged();
                    double[] outputColumn = null;
                    if (regressor.GetType() == typeof(MultipleLinearRegression))
                    {
                        outputColumn = ((MultipleLinearRegression)regressor).Transform(inputColumns);
                    }
                    else if (regressor.GetType() == typeof(PolynomialRegression))
                    {
                        outputColumn = ((PolynomialRegression)regressor).Transform(inputColumns.GetColumn(0));
                    }
                    else if (regressor.GetType() == typeof(SupportVectorMachine))
                    {
                        outputColumn = ((SupportVectorMachine)regressor).Score(inputColumns);
                    }
                    else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                    {
                        outputColumn = ((SupportVectorMachine<IKernel>)regressor).Score(inputColumns);
                    }
                    else if (regressor.GetType() == typeof(ActivationNetwork))
                    {
                        outputColumn = new double[inputColumns.Length];
                        DoubleRange unitRange = new DoubleRange(-1, 1);
                        for (int i = 0; i < inputColumns.Length; i++)
                            outputColumn[i] = ((ActivationNetwork)regressor).Compute(inputColumns[i])[0].Scale(unitRange, outputRange);
                    }

                    datasetPredictionDataGridView.Columns.Add(columnNames.Last(), columnNames.Last() + " (predicted)");
                    for (int i = 0; i < outputColumn.Length; i++)
                    {
                        datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Value = outputColumn[i];
                        datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Style.BackColor = Color.LightGreen;
                    }

                    this.predictDataTable = predictDataTable.DeepClone();
                    this.predictDataTable.Columns.Add(columnNames.Last(), typeof(string));
                    for (int i = 0; i < outputColumn.Length; i++)
                        this.predictDataTable.Rows[i][columnNames.Length - 1] = outputColumn[i];

                    visualizeButton.Enabled = true;
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

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeRegressionDataDialog visualizeRegressionDataDialog = new VisualizeRegressionDataDialog(predictDataTable, "Predicted dataset");
            visualizeRegressionDataDialog.Show(this);
        }

        public void Reset()
        {
            regressor = null;
            columnNames = null;
            predictDataTable = null;

            singlePredictionDataGridView.Columns.Clear();
            datasetPredictionDataGridView.Columns.Clear();
            visualizeButton.Enabled = false;
        }
    }
}
