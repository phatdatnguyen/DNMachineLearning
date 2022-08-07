using Accord.IO;
using Accord.Math;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DNMachineLearning.Clustering
{
    public partial class ClusteringDataControl : UserControl
    {
        // Fields
        private DataTable dataTable = null;

        private string[] features = null;
        private string target = "Cluster";

        private bool dataLoaded = false;

        // Events
        public delegate void DataLoadedEventHandler(DataLoadedEventArgs e);
        public event DataLoadedEventHandler DataLoaded;

        // Constructor
        public ClusteringDataControl()
        {
            InitializeComponent();
        }

        // Methods
        public void LoadData(DataTable trainingDataset)
        {
            if (trainingDataset != null)
            {
                dataTable = trainingDataset;

                dataDataGridView.DataSource = dataTable;
                dataVisualizeButton.Enabled = true;
                dataLoaded = true;

                target = "Cluster";
                features = new string[trainingDataset.Columns.Count];
                for (int i = 0; i < features.Length; i++)
                    features[i] = dataTable.Columns[i].ColumnName;

                DataLoaded(new DataLoadedEventArgs() { DataTable = dataTable, Features = features, Target = target });
            }
        }

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

                    this.dataTable = dataTable;

                    features = new string[dataTable.Columns.Count];
                    for (int i = 0; i < features.Length; i++)
                        features[i] = dataTable.Columns[i].ColumnName;

                    dataDataGridView.Columns.Clear();
                    dataDataGridView.DataSource = dataTable;
                    dataVisualizeButton.Enabled = true;
                    dataLoaded = true;

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

        private void dataVisualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClusteringDataDialog visualizeClusteringDataDialog = new VisualizeClusteringDataDialog(dataTable, "Data", false);
            visualizeClusteringDataDialog.Show(this);
        }
    }
}
