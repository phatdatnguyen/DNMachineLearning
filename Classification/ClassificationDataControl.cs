using Accord.IO;
using Accord.Math;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DNMachineLearning.Classification
{
    public partial class ClassificationDataControl : UserControl
    {
        // Fields
        private DataTable dataTable = null;
        private DataTable trainingDataTable = null;
        private DataTable testDataTable = null;

        private string[] features = null;
        private string target = "";

        private bool dataLoaded = false;
        private bool trainingDataLoaded = false;
        private bool testDataLoaded = false;

        // Events
        public delegate void DataLoadedEventHandler(DataLoadedEventArgs e);
        public event DataLoadedEventHandler DataLoaded;

        public delegate void TrainingDataLoadedEventHandler(DataLoadedEventArgs e);
        public event TrainingDataLoadedEventHandler TrainingDataLoaded;

        public delegate void TestDataLoadedEventHandler(DataLoadedEventArgs e);
        public event TestDataLoadedEventHandler TestDataLoaded;

        // Constructor
        public ClassificationDataControl()
        {
            InitializeComponent();
        }

        // Methods
        public void LoadData(DataTable data, DataTable trainingDataset, DataTable testDataset)
        {
            if (data != null)
            {
                dataTable = data;

                dataDataGridView.DataSource = dataTable;
                dataVisualizeButton.Enabled = true;
                splitButton.Enabled = true;
                dataLoaded = true;

                DataLoaded(new DataLoadedEventArgs() { DataTable = dataTable });
            }

            if (trainingDataset != null)
            {
                trainingDataTable = trainingDataset;

                trainingDatasetDataGridView.DataSource = trainingDataTable;
                trainingDatasetVisualizeButton.Enabled = true;
                trainingDataLoaded = true;

                target = trainingDataset.Columns[dataTable.Columns.Count - 1].ColumnName;
                features = new string[trainingDataset.Columns.Count - 1];
                for (int i = 0; i < features.Length; i++)
                    features[i] = dataTable.Columns[i].ColumnName;

                TrainingDataLoaded(new DataLoadedEventArgs() { DataTable = trainingDataTable, Features = features, Target = target });
            }

            if (testDataset != null)
            {
                testDataTable = testDataset;

                testDatasetDataGridView.DataSource = testDataTable;
                testDatasetVisualizeButton.Enabled = true;
                testDataLoaded = true;

                TestDataLoaded(new DataLoadedEventArgs() { DataTable = testDataTable });
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

                    DataTable clonedDataTable = dataTable.DeepClone();
                    clonedDataTable.Columns.RemoveAt(dataTable.Columns.Count - 1);
                    clonedDataTable.ToMatrix(); // will throw an exception if any data is not numeric

                    string[] classLabels = dataTable.Columns[dataTable.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
                    if ((classLabels.Length > 2 && ParentForm.GetType() == typeof(BinaryClassificationForm)) || (classLabels.Length > 10 && ParentForm.GetType() == typeof(MulticlassClassificationForm)))
                        throw new Exception("Data contain too many classes!");

                    this.dataTable = dataTable;

                    target = dataTable.Columns[dataTable.Columns.Count - 1].ColumnName;
                    features = new string[dataTable.Columns.Count - 1];
                    for (int i = 0; i < features.Length; i++)
                        features[i] = dataTable.Columns[i].ColumnName;

                    dataDataGridView.Columns.Clear();
                    dataDataGridView.DataSource = dataTable;
                    dataVisualizeButton.Enabled = true;
                    splitNumericUpDown.Enabled = true;
                    splitButton.Enabled = true;
                    dataLoaded = true;

                    DataLoaded(new DataLoadedEventArgs() { DataTable = dataTable });
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

        private void trainingDatasetLoadButton_Click(object sender, EventArgs e)
        {
            if (trainingDataLoaded)
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
                    CsvReader csvReader = new CsvReader(filename, trainingDatasetHasHeadersCheckBox.Checked);
                    DataTable dataTable = csvReader.ToTable();

                    if (dataTable.Columns.Count <= 1 || dataTable.Rows.Count == 0)
                        throw new Exception("Invalid data!");

                    DataTable clonedDataTable = dataTable.DeepClone();
                    clonedDataTable.Columns.RemoveAt(dataTable.Columns.Count - 1);
                    clonedDataTable.ToMatrix(); // will throw an exception if any data is not numeric

                    string[] classLabels = dataTable.Columns[dataTable.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
                    if ((classLabels.Length > 2 && ParentForm.GetType() == typeof(BinaryClassificationForm)) || (classLabels.Length > 10 && ParentForm.GetType() == typeof(MulticlassClassificationForm)))
                        throw new Exception("Data contain too many classes!");

                    trainingDataTable = dataTable;

                    target = dataTable.Columns[dataTable.Columns.Count - 1].ColumnName;
                    features = new string[dataTable.Columns.Count - 1];
                    for (int i = 0; i < features.Length; i++)
                        features[i] = dataTable.Columns[i].ColumnName;

                    trainingDatasetDataGridView.Columns.Clear();
                    trainingDatasetDataGridView.DataSource = trainingDataTable;
                    trainingDatasetVisualizeButton.Enabled = true;
                    trainingDataLoaded = true;

                    TrainingDataLoaded(new DataLoadedEventArgs() { DataTable = trainingDataTable, Features = features, Target = target });
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

        private void testDatasetLoadButton_Click(object sender, EventArgs e)
        {
            if (testDataLoaded)
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
                    CsvReader csvReader = new CsvReader(filename, testDatasetHasHeadersCheckBox.Checked);
                    DataTable dataTable = csvReader.ToTable();

                    if (dataTable.Columns.Count <= 1 || dataTable.Rows.Count == 0)
                        throw new Exception("Invalid data!");

                    DataTable clonedDataTable = dataTable.DeepClone();
                    clonedDataTable.Columns.RemoveAt(dataTable.Columns.Count - 1);
                    clonedDataTable.ToMatrix(); // will throw an exception if any data is not numeric

                    string[] classLabels = dataTable.Columns[dataTable.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
                    if ((classLabels.Length > 2 && ParentForm.GetType() == typeof(BinaryClassificationForm)) || (classLabels.Length > 10 && ParentForm.GetType() == typeof(MulticlassClassificationForm)))
                        throw new Exception("Data contain too many classes!");

                    testDataTable = dataTable;
                    testDatasetDataGridView.Columns.Clear();
                    testDatasetDataGridView.DataSource = testDataTable;
                    testDatasetVisualizeButton.Enabled = true;
                    testDataLoaded = true;

                    TestDataLoaded(new DataLoadedEventArgs() { DataTable = testDataTable });
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

        private void splitButton_Click(object sender, EventArgs e)
        {
            int[] rowIndexes = new int[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
                rowIndexes[i] = i;

            int numberOfRowsInTrainingDataset = Convert.ToInt32(dataTable.Rows.Count * (1f - Convert.ToSingle(splitNumericUpDown.Value) / 100f));
            int numberOfRowsInTestDataset = dataTable.Rows.Count - numberOfRowsInTrainingDataset;

            if (numberOfRowsInTrainingDataset == 0 || numberOfRowsInTestDataset == 0)
            {
                MessageBox.Show(this, "Cannot split data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            rowIndexes = rowIndexes.OrderBy(i => random.Next()).ToArray();
            int[] trainingRowIndexes = rowIndexes.Take(numberOfRowsInTrainingDataset).ToArray();
            int[] testRowIndexes = rowIndexes.Skip(numberOfRowsInTrainingDataset).Take(numberOfRowsInTestDataset).ToArray();

            trainingDataTable = dataTable.DeepClone();
            for (int i = trainingDataTable.Rows.Count - 1; i >= 0; i--)
                if (testRowIndexes.Contains(i))
                    trainingDataTable.Rows.RemoveAt(i);
            trainingDatasetDataGridView.DataSource = trainingDataTable;

            testDataTable = dataTable.DeepClone();
            for (int i = testDataTable.Rows.Count - 1; i >= 0; i--)
                if (trainingRowIndexes.Contains(i))
                    testDataTable.Rows.RemoveAt(i);
            testDatasetDataGridView.DataSource = testDataTable;

            trainingDatasetVisualizeButton.Enabled = true;
            testDatasetVisualizeButton.Enabled = true;
            trainingDataLoaded = true;
            testDataLoaded = true;

            TrainingDataLoaded(new DataLoadedEventArgs() { DataTable = trainingDataTable, Features = features, Target = target });
            TestDataLoaded(new DataLoadedEventArgs() { DataTable = testDataTable });
        }

        private void dataVisualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(dataTable, "Data");
            visualizeClassificationDataDialog.Show(this);
        }

        private void trainingDatasetVisualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(trainingDataTable, "Training dataset");
            visualizeClassificationDataDialog.Show(this);
        }

        private void testDatasetVisualizeButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(testDataTable, "Test dataset");
            visualizeClassificationDataDialog.Show(this);
        }

        public void Reset()
        {
            dataTable = null;
            trainingDataTable = null;
            testDataTable = null;
            features = null;
            target = "";

            dataVisualizeButton.Enabled = false;
            splitNumericUpDown.Value = 30;
            splitButton.Enabled = false;
            dataDataGridView.Columns.Clear();

            trainingDatasetVisualizeButton.Enabled = false;
            trainingDatasetDataGridView.Columns.Clear();

            testDatasetVisualizeButton.Enabled = false;
            testDatasetDataGridView.Columns.Clear();
        }
    }
}
