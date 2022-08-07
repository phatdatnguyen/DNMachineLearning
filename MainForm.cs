using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.VectorMachines;
using Accord.Neuro;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Linear;
using DNMachineLearning.Classification;
using DNMachineLearning.Clustering;
using DNMachineLearning.DA;
using DNMachineLearning.PCA;
using DNMachineLearning.Regression;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNMachineLearning
{
    public partial class MainForm : Form
    {
        // Constructor
        public MainForm()
        {
            InitializeComponent();
        }

        // Methods
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;
            if (!File.Exists(filePath))
                return;

            try
            {
                byte taskIndex = 0;
                byte modelIndex = 0;
                string serializedLearningParameters = "";
                int modelSize = 0;
                byte[] serializedModel = null;
                int dataSize = 0;
                byte[] serializedData = null;
                int trainingDatasetSize = 0;
                byte[] serializedTrainingDataset = null;
                int testDatasetSize = 0;
                byte[] serializedTestDataset = null;
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.UTF8, false))
                    {
                        taskIndex = binaryReader.ReadByte();
                        modelIndex = binaryReader.ReadByte();
                        serializedLearningParameters = binaryReader.ReadString();
                        modelSize = binaryReader.ReadInt32();
                        serializedModel = binaryReader.ReadBytes(modelSize);
                        dataSize = binaryReader.ReadInt32();
                        serializedData = binaryReader.ReadBytes(dataSize);
                        trainingDatasetSize = binaryReader.ReadInt32();
                        serializedTrainingDataset = binaryReader.ReadBytes(trainingDatasetSize);
                        testDatasetSize = binaryReader.ReadInt32();
                        serializedTestDataset = binaryReader.ReadBytes(testDatasetSize);
                    }
                }

                DataTable data = null;
                DataTable trainingDataset = null;
                DataTable testDataset = null;
                if (dataSize > 0)
                    data = Serializer.Load<DataTable>(serializedData);
                if (trainingDatasetSize > 0)
                    trainingDataset = Serializer.Load<DataTable>(serializedTrainingDataset);
                if (testDatasetSize > 0)
                    testDataset = Serializer.Load<DataTable>(serializedTestDataset);

                object model = null;
                switch (taskIndex)
                {
                    case 0: // binary classification
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<LogisticRegression>(serializedModel);
                                
                                break;
                            case 1:
                                model = Serializer.Load<KNearestNeighbors>(serializedModel);

                                break;
                            case 2:
                                model = Serializer.Load<MinimumMeanDistanceClassifier>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<NaiveBayes<NormalDistribution>>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<DecisionTree>(serializedModel);

                                break;
                            case 5:
                                model = Serializer.Load<RandomForest>(serializedModel);

                                break;
                            case 6:
                                model = Serializer.Load<SupportVectorMachine>(serializedModel);

                                break;
                            case 7:
                                model = Serializer.Load<SupportVectorMachine<IKernel>>(serializedModel);

                                break;
                            case 8:
                                model = Serializer.Load<SupportVectorMachine<IKernel<double[]>, double[]>>(serializedModel);

                                break;
                            case 9:
                                model = Serializer.Load<ActivationNetwork>(serializedModel);

                                break;
                        }

                        BinaryClassificationForm binaryClassificationForm = new BinaryClassificationForm(model, data, trainingDataset, testDataset, serializedLearningParameters) {
                            MdiParent = this
                        };
                        binaryClassificationForm.FormClosed += MdiChildClosed;
                        binaryClassificationForm.Show();
                        binaryClassificationForm.Activate();

                        saveToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;

                        break;
                    case 1: // multiclass classification
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<MultinomialLogisticRegression>(serializedModel);

                                break;
                            case 1:
                                model = Serializer.Load<KNearestNeighbors>(serializedModel);

                                break;
                            case 2:
                                model = Serializer.Load<MinimumMeanDistanceClassifier>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<NaiveBayes<NormalDistribution>>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<DecisionTree>(serializedModel);

                                break;
                            case 5:
                                model = Serializer.Load<RandomForest>(serializedModel);

                                break;
                            case 6:
                                model = Serializer.Load<MulticlassSupportVectorMachine<Linear>>(serializedModel);

                                break;
                            case 7:
                                model = Serializer.Load<MulticlassSupportVectorMachine<IKernel>>(serializedModel);

                                break;
                            case 8:
                                model = Serializer.Load<MulticlassSupportVectorMachine<IKernel<double[]>, double[]>>(serializedModel);

                                break;
                            case 9:
                                model = Serializer.Load<ActivationNetwork>(serializedModel);

                                break;
                        }

                        MulticlassClassificationForm multiclassClassificationForm = new MulticlassClassificationForm(model, data, trainingDataset, testDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        multiclassClassificationForm.FormClosed += MdiChildClosed;
                        multiclassClassificationForm.Show();
                        multiclassClassificationForm.Activate();

                        saveToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;

                        break;
                    case 2: // regression
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<MultipleLinearRegression>(serializedModel);

                                break;
                            case 1:
                                model = Serializer.Load<PolynomialRegression>(serializedModel);

                                break;
                            case 2:
                                model = Serializer.Load<SupportVectorMachine>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<SupportVectorMachine<IKernel>>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<ActivationNetwork>(serializedModel);

                                break;
                        }

                        RegressionForm regressionForm = new RegressionForm(model, data, trainingDataset, testDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        regressionForm.FormClosed += MdiChildClosed;
                        regressionForm.Show();
                        regressionForm.Activate();

                        saveToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;

                        break;
                    case 3: // clustering
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<KMeans>(serializedModel);

                                break;
                            case 1: // Saving is not supported for balanced k-means model
                                break;
                            case 2:
                                model = Serializer.Load<KMedoids>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<BinarySplit>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<GaussianMixtureModel>(serializedModel);

                                break;
                            case 5:
                                model = Serializer.Load<MeanShift>(serializedModel);

                                break;
                        }

                        ClusteringForm clusteringForm = new ClusteringForm(model, trainingDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        clusteringForm.FormClosed += MdiChildClosed;
                        clusteringForm.Show();
                        clusteringForm.Activate();

                        saveToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;

                        break;
                    case 4: // PCA
                        model = Serializer.Load<KernelPrincipalComponentAnalysis>(serializedModel);

                        PCAForm pcaForm = new PCAForm((KernelPrincipalComponentAnalysis)model, trainingDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        pcaForm.FormClosed += MdiChildClosed;
                        pcaForm.Show();
                        pcaForm.Activate();

                        saveToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;

                        break;
                    case 5: // DA
                        model = Serializer.Load<KernelDiscriminantAnalysis>(serializedModel);

                        DAForm daForm = new DAForm((KernelDiscriminantAnalysis)model, trainingDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        daForm.FormClosed += MdiChildClosed;
                        daForm.Show();
                        daForm.Activate();

                        saveToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;

                        break;
                }
            }
            catch
            {
                MessageBox.Show(this, "Cannot open file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
                return;

            bool modelTrained = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationForm))
                modelTrained = ((BinaryClassificationForm)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationForm))
                modelTrained = ((MulticlassClassificationForm)ActiveMdiChild).IsModelTrained;
            else if(ActiveMdiChild.GetType() == typeof(RegressionForm))
                modelTrained = ((RegressionForm)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringForm))
            {
                modelTrained = ((ClusteringForm)ActiveMdiChild).IsModelTrained;
                if (modelTrained && !((ClusteringForm)ActiveMdiChild).IsModelSavable)
                {
                    MessageBox.Show(this, "Saving is not supported for this model!", "Cannot save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (ActiveMdiChild.GetType() == typeof(PCAForm))
                modelTrained = ((PCAForm)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(DAForm))
                modelTrained = ((DAForm)ActiveMdiChild).IsModelTrained;

            if (!modelTrained)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveCurrentModel();
        }

        public void SaveCurrentModel()
        {
            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string filePath = saveFileDialog.FileName;

            Control currentMdiChild = ActiveMdiChild;
            try
            {
                if (currentMdiChild.GetType() == typeof(BinaryClassificationForm))
                    ((BinaryClassificationForm)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(MulticlassClassificationForm))
                    ((MulticlassClassificationForm)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(RegressionForm))
                    ((RegressionForm)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(ClusteringForm))
                    ((ClusteringForm)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(PCAForm))
                    ((PCAForm)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(DAForm))
                    ((DAForm)currentMdiChild).SaveModel(filePath);
            }
            catch
            {
                MessageBox.Show(this, "Cannot save model!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
                return;

            ActiveMdiChild.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void binaryClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryClassificationForm binaryClassificationForm = new BinaryClassificationForm
            {
                MdiParent = this
            };
            binaryClassificationForm.FormClosed += MdiChildClosed;
            binaryClassificationForm.Show();
            binaryClassificationForm.Activate();
            saveToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;
        }

        private void multiclassClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MulticlassClassificationForm multiclassClassificationForm = new MulticlassClassificationForm
            {
                MdiParent = this
            };
            multiclassClassificationForm.FormClosed += MdiChildClosed;
            multiclassClassificationForm.Show();
            multiclassClassificationForm.Activate();
            saveToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;
        }

        private void regressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegressionForm regressionForm = new RegressionForm
            {
                MdiParent = this
            };
            regressionForm.FormClosed += MdiChildClosed;
            regressionForm.Show();
            regressionForm.Activate();
            saveToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;
        }

        private void clusteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClusteringForm clusteringForm = new ClusteringForm
            {
                MdiParent = this
            };
            clusteringForm.FormClosed += MdiChildClosed;
            clusteringForm.Show();
            clusteringForm.Activate();
            saveToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;
        }

        private void principalComponentAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCAForm pcaForm = new PCAForm
            {
                MdiParent = this
            };
            pcaForm.FormClosed += MdiChildClosed;
            pcaForm.Show();
            pcaForm.Activate();
            saveToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;
        }

        private void discriminantAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAForm daForm = new DAForm
            {
                MdiParent = this
            };
            daForm.FormClosed += MdiChildClosed;
            daForm.Show();
            daForm.Activate();
            saveToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show(this);
        }

        private void MdiChildClosed(object sender, FormClosedEventArgs e)
        {
            if (MdiChildren.Length == 1)
            {
                saveToolStripMenuItem.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
            }
        }
    }
}
