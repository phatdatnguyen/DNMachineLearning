using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Neuro;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DNMachineLearning.Classification
{
    public partial class PredictClassificationControl : UserControl
    {
        // Fields
        private object classifier = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private string[] columnNames = null;
        private DataTable predictDataTable = null;

        // Properties
        public object Classifier
        {
            set { classifier = value; }
        }

        public Dictionary<int, string> Classes
        { 
            set { classes = value; }
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

        // Constructor
        public PredictClassificationControl()
        {
            InitializeComponent();
        }

        // Methods
        private void predictButton_Click(object sender, EventArgs e)
        {
            if (classifier == null)
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

                int classIndex = -1;
                if (classifier.GetType() == typeof(LogisticRegression))
                {
                    bool predictedValue = ((LogisticRegression)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(MultinomialLogisticRegression))
                {
                    classIndex = ((MultinomialLogisticRegression)classifier).Decide(inputs);
                }
                else if(classifier.GetType() == typeof(KNearestNeighbors))
                {
                    classIndex = ((KNearestNeighbors)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                {
                    classIndex = ((MinimumMeanDistanceClassifier)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                {
                    classIndex = ((NaiveBayes<NormalDistribution>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(DecisionTree))
                {
                    classIndex = ((DecisionTree)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(RandomForest))
                {
                    classIndex = ((RandomForest)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    bool predictedValue = ((SupportVectorMachine<IKernel>)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    bool predictedValue = ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine))
                {
                    bool predictedValue = ((SupportVectorMachine)classifier).Decide(inputs);
                    classIndex = predictedValue ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
                {
                    classIndex = ((MulticlassSupportVectorMachine<IKernel>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    classIndex = ((MulticlassSupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<Linear>))
                {
                    classIndex = ((MulticlassSupportVectorMachine<Linear>)classifier).Decide(inputs);
                }
                else if (classifier.GetType() == typeof(ActivationNetwork))
                {
                    double[] output = ((ActivationNetwork)classifier).Compute(inputs);
                    classIndex = output.IndexOf(output.Max());
                }

                singlePredictionDataGridView.Rows[0].Cells[columnNames.Length - 1].Value = classes[classIndex];
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
            if (classifier == null)
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
                    int[] classIndexColumn = null;
                    if (classifier.GetType() == typeof(LogisticRegression))
                    {
                        bool[] predictedColumn = ((LogisticRegression)classifier).Decide(inputColumns);
                        classIndexColumn = new int[predictedColumn.Length];
                        for (int i = 0; i < predictedColumn.Length; i++)
                            classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                    }
                    else if (classifier.GetType() == typeof(MultinomialLogisticRegression))
                    {
                        classIndexColumn = ((MultinomialLogisticRegression)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(KNearestNeighbors))
                    {
                        classIndexColumn = ((KNearestNeighbors)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                    {
                        classIndexColumn = ((MinimumMeanDistanceClassifier)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                    {
                        classIndexColumn = ((NaiveBayes<NormalDistribution>)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(DecisionTree))
                    {
                        classIndexColumn = ((DecisionTree)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(RandomForest))
                    {
                        classIndexColumn = ((RandomForest)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                    {
                        bool[] predictedColumn = ((SupportVectorMachine<IKernel>)classifier).Decide(inputColumns);
                        classIndexColumn = new int[predictedColumn.Length];
                        for (int i = 0; i < predictedColumn.Length; i++)
                            classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                    {
                        bool[] predictedColumn = ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputColumns);
                        classIndexColumn = new int[predictedColumn.Length];
                        for (int i = 0; i < predictedColumn.Length; i++)
                            classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine))
                    {
                        bool[] predictedColumn = ((SupportVectorMachine)classifier).Decide(inputColumns);
                        classIndexColumn = new int[predictedColumn.Length];
                        for (int i = 0; i < predictedColumn.Length; i++)
                            classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                    }
                    else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
                    {
                        classIndexColumn = ((MulticlassSupportVectorMachine<IKernel>)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel<double[]>, double[]>))
                    {
                        classIndexColumn = ((MulticlassSupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<Linear>))
                    {
                        classIndexColumn = ((MulticlassSupportVectorMachine<Linear>)classifier).Decide(inputColumns);
                    }
                    else if (classifier.GetType() == typeof(ActivationNetwork))
                    {
                        ActivationNetwork ann = (ActivationNetwork)classifier;
                        classIndexColumn = new int[inputColumns.Length];
                        for (int i = 0; i < inputColumns.Length; i++)
                        {
                            double[] output = ann.Compute(inputColumns[i]);
                            classIndexColumn[i] = output.IndexOf(output.Max());
                        }
                    }

                    datasetPredictionDataGridView.Columns.Add(columnNames.Last(), columnNames.Last() + " (predicted)");
                    for (int i = 0; i < classIndexColumn.Length; i++)
                    {
                        datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Value = classes[classIndexColumn[i]];
                        datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Style.BackColor = Color.LightGreen;
                    }

                    this.predictDataTable = predictDataTable.DeepClone();
                    this.predictDataTable.Columns.Add(columnNames.Last(), typeof(string));
                    for (int i = 0; i < classIndexColumn.Length; i++)
                        this.predictDataTable.Rows[i][columnNames.Length - 1] = classes[classIndexColumn[i]];

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
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(predictDataTable, "Predicted dataset");
            visualizeClassificationDataDialog.Show(this);
        }

        public void Reset()
        {
            classifier = null;
            classes = new Dictionary<int, string>();
            columnNames = null;
            predictDataTable = null;

            singlePredictionDataGridView.Columns.Clear();
            datasetPredictionDataGridView.Columns.Clear();
            visualizeButton.Enabled = false;
        }
    }
}
