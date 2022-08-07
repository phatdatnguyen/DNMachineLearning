using Accord.IO;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Statistics.Distributions.DensityKernels;
using Accord.Statistics.Distributions.Fitting;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DNMachineLearning.Clustering
{
    public partial class ClusteringForm : Form
    {
        // Fields
        private object clusterer = null;
        private string[] features = null;
        private string target = "Cluster";

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private int[] clusterIndexColumn = null;

        private string serializedLearningParameters = "";

        private bool modelTrained = false;

        // Property
        public bool IsModelTrained { get { return modelTrained; } }

        public bool IsModelSavable {
            get
            {
                if (clusterer == null)
                    return false;
                return !(clusterer.GetType() == typeof(BalancedKMeans));
            }
        }

        // Event
        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        // Constructors
        public ClusteringForm()
        {
            InitializeComponent();

            ModelTrained += OnModelTrained;
        }

        public ClusteringForm(object model, DataTable trainingDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            dataControl.LoadData(trainingDataset);

            ModelTrained += OnModelTrained;

            if (model.GetType() == typeof(KMeans))
            {
                modelPanel.Controls.Add(new KMeansLearningControl());
                ((KMeansLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(KMedoids))
            {
                modelPanel.Controls.Add(new KMedoidsLearningControl());
                ((KMedoidsLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(BinarySplit))
            {
                modelPanel.Controls.Add(new BinarySplitLearningControl());
                ((BinarySplitLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(GaussianMixtureModel))
            {
                modelPanel.Controls.Add(new GaussianMixtureLearningControl());
                ((GaussianMixtureLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(MeanShift))
            {
                modelPanel.Controls.Add(new MeanShiftLearningControl());
                ((MeanShiftLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }

            modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
            clusteringTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
            chooseModelButton.Text = "Change model...";

            ModelTrained(new ModelTrainedEventArgs() { Model = model });
        }

        // Form event handlers
        private void ClusteringForm_Resize(object sender, EventArgs e)
        {
            ResizeContents();
        }

        private void ResizeContents()
        {
            dataControl.Invalidate();
            if (modelPanel.Controls.Count > 0)
            {
                modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
                clusteringTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
                modelPanel.Controls[0].Invalidate();
            }
            if (trainingPanel.Controls.Count > 0)
            {
                trainingPanel.Controls[0].Left = (trainingPanel.Width - trainingPanel.Controls[0].Width) / 2;
                clusteringTableLayoutPanel.RowStyles[2].Height = trainingPanel.Controls[0].Height + 10;
                trainingPanel.Controls[0].Invalidate();
            }
            predictClusteringControl.Invalidate();
        }

        private void ClusteringForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (clusterer != null && modelTrained)
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
            if (!modelTrained || clusterer == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 3; // clustering
                    byte modelIndex = 0;

                    byte[] serializedModel = null;
                    if (clusterer.GetType() == typeof(KMeans))
                    {
                        modelIndex = 0;
                        ((KMeans)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(KMedoids))
                    {
                        modelIndex = 2;
                        ((KMedoids)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(BinarySplit))
                    {
                        modelIndex = 3;
                        ((BinarySplit)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(GaussianMixtureModel))
                    {
                        modelIndex = 4;
                        ((GaussianMixtureModel)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(MeanShift))
                    {
                        modelIndex = 5;
                        ((MeanShift)clusterer).Save(out serializedModel);
                    }
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

        // Load data
        private void dataControl_DataLoaded(DataLoadedEventArgs e)
        {
            trainingDataset = e.DataTable;

            DataTable trainingDataTable = e.DataTable.DeepClone();
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();

            features = e.Features;
            target = e.Target;
        }

        // Model
        private void chooseModelButton_Click(object sender, EventArgs e)
        {
            ChooseClusteringModelDialog chooseClusteringModelDialog = new ChooseClusteringModelDialog();
            if (chooseClusteringModelDialog.ShowDialog() != DialogResult.OK)
                return;

            trainButton.Enabled = true;
            modelPanel.Controls.Clear();
            modelPanel.BackColor = SystemColors.Control;
            trainingPanel.Controls.Clear();
            clusteringTableLayoutPanel.RowStyles[2].Height = 100f;
            trainingPanel.BackColor = SystemColors.Control;

            switch (chooseClusteringModelDialog.modelComboBox.SelectedIndex)
            {
                case 0:
                    modelPanel.Controls.Add(new KMeansLearningControl());

                    break;
                case 1:
                    modelPanel.Controls.Add(new BalancedKMeansLearningControl());

                    break;
                case 2:
                    modelPanel.Controls.Add(new KMedoidsLearningControl());

                    break;
                case 3:
                    modelPanel.Controls.Add(new BinarySplitLearningControl());

                    break;
                case 4:
                    modelPanel.Controls.Add(new GaussianMixtureLearningControl());

                    break;
                case 5:
                    modelPanel.Controls.Add(new MeanShiftLearningControl());

                    break;
            }

            modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
            clusteringTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
            chooseModelButton.Text = "Change model...";

            modelTrained = false;
            clusterer = null;

            predictClusteringControl.Visible = false;
            predictClusteringControl.Reset();
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
            clusteringTableLayoutPanel.RowStyles[2].Height = 100f;
            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            try
            {
                object clusterer = null;

                if (modelPanel.Controls[0].GetType() == typeof(KMeansLearningControl))
                {
                    KMeans kMeans = new KMeans(Convert.ToInt32(((KMeansLearningControl)modelPanel.Controls[0]).KNumericUpDown.Value));
                    kMeans.Learn(trainingInputColumns);
                    clusterer = kMeans;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(BalancedKMeansLearningControl))
                {
                    BalancedKMeans balancedKMeans = new BalancedKMeans(Convert.ToInt32(((BalancedKMeansLearningControl)modelPanel.Controls[0]).KNumericUpDown.Value))
                    {
                        MaxIterations = Convert.ToInt32(((BalancedKMeansLearningControl)modelPanel.Controls[0]).KNumericUpDown.Value)
                    };
                    balancedKMeans.Learn(trainingInputColumns);
                    clusterer = balancedKMeans;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(KMedoidsLearningControl))
                {
                    KMedoids kMedoids = new KMedoids(Convert.ToInt32(((KMedoidsLearningControl)modelPanel.Controls[0]).KNumericUpDown.Value));
                    kMedoids.Learn(trainingInputColumns);
                    clusterer = kMedoids;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(BinarySplitLearningControl))
                {
                    BinarySplit binarySplit = new BinarySplit(Convert.ToInt32(((BinarySplitLearningControl)modelPanel.Controls[0]).KNumericUpDown.Value));
                    binarySplit.Learn(trainingInputColumns);
                    clusterer = binarySplit;
                } 
                else if (modelPanel.Controls[0].GetType() == typeof(GaussianMixtureLearningControl))
                {
                    GaussianMixtureModel gaussianMixtureModel = new GaussianMixtureModel(Convert.ToInt32(((GaussianMixtureLearningControl)modelPanel.Controls[0]).KNumericUpDown.Value))
                    {
                        Options = new NormalOptions()
                        {
                            Regularization = 1e-10
                        }
                    };
                    gaussianMixtureModel.Learn(trainingInputColumns);
                    clusterer = gaussianMixtureModel;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(MeanShiftLearningControl))
                {
                    GaussianKernel kernel = new GaussianKernel(2);
                    MeanShift meanShift = new MeanShift()
                    {
                        Kernel = kernel,
                        Bandwidth = Convert.ToDouble(((MeanShiftLearningControl)modelPanel.Controls[0]).RadiusNumericUpDown.Value)
                    };
                    meanShift.Learn(trainingInputColumns);
                    clusterer = meanShift;
                } 

                ModelTrained(new ModelTrainedEventArgs() { Model = clusterer });
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
            clusterer = e.Model;
            trainingPanel.Controls.Clear();
            clusteringTableLayoutPanel.RowStyles[2].Height = 100f;
            
            modelPanel.BackColor = Color.LightGreen;

            if (clusterer.GetType() == typeof(KMeans))
            {
                serializedLearningParameters = ((KMeansLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((KMeans)clusterer).Clusters.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(BalancedKMeans))
                clusterIndexColumn = ((BalancedKMeans)clusterer).Clusters.Decide(trainingInputColumns);
            else if (clusterer.GetType() == typeof(KMedoids))
            {
                serializedLearningParameters = ((KMedoidsLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((KMedoids)clusterer).Clusters.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(BinarySplit))
            {
                serializedLearningParameters = ((BinarySplitLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((BinarySplit)clusterer).Clusters.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(GaussianMixtureModel))
            {
                serializedLearningParameters = ((GaussianMixtureLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((GaussianMixtureModel)clusterer).Gaussians.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(MeanShift))
            {
                serializedLearningParameters = ((MeanShiftLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((MeanShift)clusterer).Clusters.Decide(trainingInputColumns);
            }

            ClustersControl clustersControl = new ClustersControl(trainingInputColumns, clusterIndexColumn, features);
            trainingPanel.Controls.Add(clustersControl);
            clustersControl.Left = (trainingPanel.Width - clustersControl.Width) / 2;
            clusteringTableLayoutPanel.RowStyles[2].Height = clustersControl.Height + 10;
            trainingPanel.BackColor = Color.LightGreen;

            predictClusteringControl.Clusterer = clusterer;
            predictClusteringControl.ColumnNames = features.Concatenate(target);
            predictClusteringControl.Visible = true;

            modelTrained = true;
            statusLabel.Text = "Status: Model trained.";
            Cursor = Cursors.Default;
        }
    }
}
