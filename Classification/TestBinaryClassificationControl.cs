using Accord.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DNMachineLearning.Classification
{
    public partial class TestBinaryClassificationControl : UserControl
    {
        // Fields
        private DataTable testDataTable = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        
        // Event
        public delegate void ModelTestedEventHandler(ModelTestedEventArgs e);
        public event ModelTestedEventHandler ModelTested;

        // Property
        public DataTable TestDataTable
        {
            set
            {
                testDataTable = value;

                ModelTested(new ModelTestedEventArgs { TestDataTable = value });
            }
        }

        // Event handler
        protected virtual void OnModelTested(ModelTestedEventArgs e)
        {
            testDataTable = e.TestDataTable;

            int outputColumnIndex = testDataTable.Columns.Count - 2;
            int predictedOutputColumnIndex = testDataTable.Columns.Count - 1;
            string[] outputColumn = testDataTable.Columns[outputColumnIndex].ToArray<string>();
            string[] classLabels = outputColumn.Distinct().OrderBy(x => x).ToArray();
            classes = new Dictionary<int, string>();
            for (int i = 0; i < classLabels.Length; i++)
                classes.Add(i, classLabels[i]);

            testDatasetDataGridView.DataSource = testDataTable;
            foreach (DataGridViewRow dataGridViewRow in testDatasetDataGridView.Rows)
                if (dataGridViewRow.Cells[outputColumnIndex].Value.ToString() == dataGridViewRow.Cells[predictedOutputColumnIndex].Value.ToString())
                    dataGridViewRow.Cells[predictedOutputColumnIndex].Style.BackColor = Color.LightGreen;
                else
                    dataGridViewRow.Cells[predictedOutputColumnIndex].Style.BackColor = Color.Red;

            class1RadioButton.Text = classes[0];
            class2RadioButton.Text = classes[1];

            CalculateMetrics();
        }

        // Constructor
        public TestBinaryClassificationControl()
        {
            InitializeComponent();

            ModelTested += OnModelTested;
        }

        // Methods
        private void positiveClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (testDataTable == null)
                return;

            CalculateMetrics();
        }

        private void CalculateMetrics()
        {
            int truePositive = 0;
            int trueNegative = 0;
            int falsePositive = 0;
            int falseNegative = 0;

            int outputColumnIndex = testDataTable.Columns.Count - 2;
            int predictedOutputColumnIndex = testDataTable.Columns.Count - 1;

            string positiveClass = classes[0];
            if (class2RadioButton.Checked)
                positiveClass = classes[1];

            foreach (DataRow dataRow in testDataTable.Rows)
                if (dataRow[predictedOutputColumnIndex].ToString() == dataRow[outputColumnIndex].ToString() && dataRow[predictedOutputColumnIndex].ToString() == positiveClass) // true positive
                    truePositive += 1;
                else if (dataRow[predictedOutputColumnIndex].ToString() != dataRow[outputColumnIndex].ToString() && dataRow[predictedOutputColumnIndex].ToString() == positiveClass) // false positive
                    falsePositive += 1;
                else if (dataRow[predictedOutputColumnIndex].ToString() == dataRow[outputColumnIndex].ToString() && dataRow[predictedOutputColumnIndex].ToString() != positiveClass) // true negative
                    trueNegative += 1;
                else // false nagative
                    falseNegative += 1;

            truePositiveLabel.Text = "TP = " + truePositive.ToString();
            falsePositiveLabel.Text = "FP = " + falsePositive.ToString();
            trueNegativeLabel.Text = "TN = " + trueNegative.ToString();
            falseNegativeLabel.Text = "FN = " + falseNegative.ToString();

            float accuracy = (truePositive + trueNegative + 0f) / (truePositive + falsePositive + trueNegative + falseNegative);
            accuracyValueLabel.Text = accuracy.ToString("p2");
            float precision = (truePositive + 0f) / (truePositive + falsePositive);
            precisionValueLabel.Text = precision.ToString("p2");
            float recall = (truePositive + 0f) / (truePositive + falseNegative);
            recallValueLabel.Text = recall.ToString("p2");
            float specificity = (trueNegative + 0f) / (trueNegative + falsePositive);
            specificityValueLabel.Text = specificity.ToString("p2");
            float f1Score = 2f * (precision * recall) / (precision + recall);
            f1ScoreValueLabel.Text = f1Score.ToString("f2");
        }

        public void Reset()
        {
            testDataTable = null;
            classes = null;

            class1RadioButton.Checked = true;
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationTestResultDialog visualizeClassificationTestResultDialog = new VisualizeClassificationTestResultDialog(testDataTable, "Classification test result");
            visualizeClassificationTestResultDialog.Show(this);
        }
    }
}
