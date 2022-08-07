using Accord.IO;
using Accord.MachineLearning;
using Accord.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNMachineLearning.Clustering
{
    public partial class PredictClusteringControl : UserControl
    {
        // Fields
        private object clusterer = null;
        private string[] columnNames = null;
        private DataTable predictDataTable = null;

        private int numberOfCluster = 0;

        // Properties
        public object Clusterer
        {
            set { clusterer = value; }
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

        public PredictClusteringControl()
        {
            InitializeComponent();
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            if (clusterer == null)
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

                double predictedClusterIndex = 0;
                if (clusterer.GetType() == typeof(KMeans))
                    predictedClusterIndex = ((KMeans)clusterer).Clusters.Decide(inputs);
                else if (clusterer.GetType() == typeof(BalancedKMeans))
                    predictedClusterIndex = ((BalancedKMeans)clusterer).Clusters.Decide(inputs);
                else if (clusterer.GetType() == typeof(KMedoids))
                    predictedClusterIndex = ((KMedoids)clusterer).Clusters.Decide(inputs);
                else if (clusterer.GetType() == typeof(BinarySplit))
                    predictedClusterIndex = ((BinarySplit)clusterer).Clusters.Decide(inputs);
                else if (clusterer.GetType() == typeof(GaussianMixtureModel))
                    predictedClusterIndex = ((GaussianMixtureModel)clusterer).Gaussians.Decide(inputs);
                else if (clusterer.GetType() == typeof(MeanShift))
                    predictedClusterIndex = ((MeanShift)clusterer).Clusters.Decide(inputs);

                singlePredictionDataGridView.Rows[0].Cells[columnNames.Length - 1].Value = "Cluster " + (predictedClusterIndex + 1).ToString();
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
            if (clusterer == null)
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
                    int[] clusterIndexColumn = new int[inputColumns.Length];
                    if (clusterer.GetType() == typeof(KMeans))
                    {
                        clusterIndexColumn = ((KMeans)clusterer).Clusters.Decide(inputColumns);
                        numberOfCluster = ((KMeans)clusterer).Clusters.Count;
                    }
                    else if (clusterer.GetType() == typeof(BalancedKMeans))
                    {
                        clusterIndexColumn = ((BalancedKMeans)clusterer).Clusters.Decide(inputColumns);
                        numberOfCluster = ((BalancedKMeans)clusterer).Clusters.Count;
                    }
                    else if (clusterer.GetType() == typeof(KMedoids))
                    {
                        clusterIndexColumn = ((KMedoids)clusterer).Clusters.Decide(inputColumns);
                        numberOfCluster = ((KMedoids)clusterer).Clusters.Count;
                    }
                    else if (clusterer.GetType() == typeof(BinarySplit))
                    {
                        clusterIndexColumn = ((BinarySplit)clusterer).Clusters.Decide(inputColumns);
                        numberOfCluster = ((BinarySplit)clusterer).Clusters.Count;
                    }
                    else if (clusterer.GetType() == typeof(GaussianMixtureModel))
                    {
                        clusterIndexColumn = ((GaussianMixtureModel)clusterer).Gaussians.Decide(inputColumns);
                        numberOfCluster = ((GaussianMixtureModel)clusterer).Gaussians.Count;
                    }
                    else if (clusterer.GetType() == typeof(MeanShift))
                    {
                        clusterIndexColumn = ((MeanShift)clusterer).Clusters.Decide(inputColumns);
                        numberOfCluster = ((MeanShift)clusterer).Clusters.Count;
                    }

                    datasetPredictionDataGridView.Columns.Add(columnNames.Last(), columnNames.Last() + " (predicted)");
                    for (int i = 0; i < clusterIndexColumn.Length; i++)
                    {
                        datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Value = "Cluster " + (clusterIndexColumn[i] + 1).ToString();
                        datasetPredictionDataGridView.Rows[i].Cells[columnNames.Length - 1].Style.BackColor = Color.LightGreen;
                    }

                    this.predictDataTable = predictDataTable.DeepClone();
                    this.predictDataTable.Columns.Add(columnNames.Last(), typeof(string));
                    for (int i = 0; i < clusterIndexColumn.Length; i++)
                        this.predictDataTable.Rows[i][columnNames.Length - 1] = "Cluster " + (clusterIndexColumn[i] + 1).ToString();

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
            if (numberOfCluster > 10)
            {
                MessageBox.Show(this, "Cannot visualize data with too many clusters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VisualizeClusteringDataDialog visualizeClusteringDataDialog = new VisualizeClusteringDataDialog(predictDataTable, "Predicted dataset", true);
            visualizeClusteringDataDialog.Show(this);
        }

        public void Reset()
        {
            clusterer = null;
            columnNames = null;
            predictDataTable = null;

            singlePredictionDataGridView.Columns.Clear();
            datasetPredictionDataGridView.Columns.Clear();
            visualizeButton.Enabled = false;
        }
    }
}
