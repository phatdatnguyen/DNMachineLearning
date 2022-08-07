using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Accord.Statistics.Models.Regression.Fitting;
using Accord.Statistics.Models.Regression;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Statistics.Kernels;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.Neuro;
using System.Text;

namespace DNMachineLearning.Classification
{
    public partial class BinaryClassificationForm : Form
    {
        // Fields
        private object classifier = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private string[] features;
        private string target;

        private DataTable data = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private string[] trainingOutputColumn = null;
        private int[] trainingClassIndexColumn = null;

        private DataTable testDataset = null;
        private double[][] testInputColumns = null;
        private string[] testOutputColumn = null;

        private string serializedLearningParameters = "";

        private bool modelTrained = false;

        // Property
        public bool IsModelTrained { get { return modelTrained; } }

        // Event
        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        // Constructors
        public BinaryClassificationForm()
        {
            InitializeComponent();

            ModelTrained += OnModelTrained;
        }

        public BinaryClassificationForm(object model, DataTable data, DataTable trainingDataset, DataTable testDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            ModelTrained += OnModelTrained;

            dataControl.LoadData(data, trainingDataset, testDataset);

            if (model.GetType() == typeof(LogisticRegression))
            {
                modelPanel.Controls.Add(new LogisticRegressionLearningControl());
                ((LogisticRegressionLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(KNearestNeighbors))
            {
                modelPanel.Controls.Add(new KNearestNeighborsLearningControl());
                ((KNearestNeighborsLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if(model.GetType() == typeof(MinimumMeanDistanceClassifier))
            {
                modelPanel.Controls.Add(new MinimumMeanDistanceLearningControl());
            }
            else if (model.GetType() == typeof(NaiveBayes<NormalDistribution>))
            {
                modelPanel.Controls.Add(new NaiveBayesLearningControl());
            }
            else if (model.GetType() == typeof(DecisionTree))
            {
                modelPanel.Controls.Add(new DecisionTreeLearningControl());
                ((DecisionTreeLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(RandomForest))
            {
                modelPanel.Controls.Add(new RandomForestLearningControl());
                ((RandomForestLearningControl)modelPanel.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(SupportVectorMachine) || model.GetType() == typeof(SupportVectorMachine<IKernel>) || model.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
            {
                SVMClassificationLearningControl svmClassificationLearningControl = new SVMClassificationLearningControl();
                modelPanel.Controls.Add(svmClassificationLearningControl);

                if (trainingInputColumns != null)
                    svmClassificationLearningControl.InputColumns = trainingInputColumns;

                svmClassificationLearningControl.SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(ActivationNetwork))
            {
                ANNClassificationLearningControl annClassificationLearningControl = new ANNClassificationLearningControl();
                modelPanel.Controls.Add(annClassificationLearningControl);

                if (trainingInputColumns != null)
                {
                    annClassificationLearningControl.InputColumns = trainingInputColumns;
                    annClassificationLearningControl.ClassIndexColumn = trainingClassIndexColumn;
                }

                annClassificationLearningControl.SetLearningParameters(serializedLearningParameters);

                annClassificationLearningControl.ModelConverged += OnANNConverged;
                annClassificationLearningControl.TrainingStarted += OnANNTrainingStarted;
                trainButton.Enabled = false;
            }

            modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
            classificationTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
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
                classificationTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
                modelPanel.Controls[0].Invalidate();
            }
            if (trainingPanel.Controls.Count > 0)
            {
                trainingPanel.Controls[0].Left = (trainingPanel.Width - trainingPanel.Controls[0].Width) / 2;
                classificationTableLayoutPanel.RowStyles[2].Height = trainingPanel.Controls[0].Height + 10;
                trainingPanel.Controls[0].Invalidate();
            }
            testBinaryClassificationControl.Invalidate();
            predictClassificationControl.Invalidate();
        }
        
        private void BinaryClassificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (classifier != null && modelTrained)
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
            if (!modelTrained || classifier == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 0; // binary classification
                    byte modelIndex = 0;

                    byte[] serializedModel = null;
                    if (classifier.GetType() == typeof(LogisticRegression))
                    {
                        modelIndex = 0;
                        ((LogisticRegression)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(KNearestNeighbors))
                    {
                        modelIndex = 1;
                        ((KNearestNeighbors)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                    {
                        modelIndex = 2;
                        ((MinimumMeanDistanceClassifier)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                    {
                        modelIndex = 3;
                        ((NaiveBayes<NormalDistribution>)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(DecisionTree))
                    {
                        modelIndex = 4;
                        ((DecisionTree)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(RandomForest))
                    {
                        modelIndex = 5;
                        ((RandomForest)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine))
                    {
                        modelIndex = 6;
                        ((SupportVectorMachine)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                    {
                        modelIndex = 7;
                        ((SupportVectorMachine<IKernel>)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                    {
                        modelIndex = 8;
                        ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(ActivationNetwork))
                    {
                        modelIndex = 9;
                        ((ActivationNetwork)classifier).Save(out serializedModel);
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
            trainingOutputColumn = trainingDataTable.Columns[trainingDataTable.Columns.Count - 1].ToArray<string>();
            trainingDataTable.Columns.RemoveAt(trainingDataTable.Columns.Count - 1);
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();
            
            features = e.Features;
            target = e.Target;

            string[] classLabels = trainingOutputColumn.Distinct().OrderBy(x => x).ToArray();
            classes = new Dictionary<int, string>();
            for (int i = 0; i < classLabels.Length; i++)
                classes.Add(i, classLabels[i]);

            trainingClassIndexColumn = new int[trainingOutputColumn.Length];
            for (int i = 0; i < trainingOutputColumn.Length; i++)
                trainingClassIndexColumn[i] = classes.FirstOrDefault(x => x.Value == trainingOutputColumn[i]).Key;

            if (modelPanel.Controls.Count == 1 && modelPanel.Controls[0].GetType() == typeof(SVMClassificationLearningControl))
            {
                SVMClassificationLearningControl svmClassificationLearningControl = (SVMClassificationLearningControl)modelPanel.Controls[0];
                svmClassificationLearningControl.InputColumns = trainingInputColumns;
            }
            if (modelPanel.Controls.Count == 1 && modelPanel.Controls[0].GetType() == typeof(ANNClassificationLearningControl))
            {
                ANNClassificationLearningControl annClassificationLearningControl = (ANNClassificationLearningControl)modelPanel.Controls[0];
                annClassificationLearningControl.InputColumns = trainingInputColumns;
                annClassificationLearningControl.ClassIndexColumn = trainingClassIndexColumn;
            }
        }

        private void dataControl_TestDataLoaded(DataLoadedEventArgs e)
        {
            testDataset = e.DataTable;

            DataTable testDataTable = e.DataTable.DeepClone();
            testOutputColumn = testDataTable.Columns[testDataTable.Columns.Count - 1].ToArray<string>(); 
            testDataTable.Columns.RemoveAt(testDataTable.Columns.Count - 1);
            testInputColumns = testDataTable.ToMatrix().ToJagged();
        }

        // Model
        private void chooseModelButton_Click(object sender, EventArgs e)
        {
            ChooseBinaryClassificationModelDialog chooseBinaryClassificationModelDialog = new ChooseBinaryClassificationModelDialog();
            if (chooseBinaryClassificationModelDialog.ShowDialog() != DialogResult.OK)
                return;

            trainButton.Enabled = true;
            modelPanel.Controls.Clear();
            modelPanel.BackColor = SystemColors.Control;
            trainingPanel.Controls.Clear();
            classificationTableLayoutPanel.RowStyles[2].Height = 100f;
            trainingPanel.BackColor = SystemColors.Control;

            switch (chooseBinaryClassificationModelDialog.modelComboBox.SelectedIndex)
            {
                case 0:
                    LogisticRegressionLearningControl logisticRegressionLearningControl = new LogisticRegressionLearningControl();
                    modelPanel.Controls.Add(logisticRegressionLearningControl);

                    break;
                case 1:
                    KNearestNeighborsLearningControl kNearestNeighborsLearningControl = new KNearestNeighborsLearningControl();
                    modelPanel.Controls.Add(kNearestNeighborsLearningControl);

                    break;
                case 2:
                    MinimumMeanDistanceLearningControl minimumMeanDistanceLearningControl = new MinimumMeanDistanceLearningControl();
                    modelPanel.Controls.Add(minimumMeanDistanceLearningControl);

                    break;
                case 3:
                    NaiveBayesLearningControl naiveBayesLearningControl = new NaiveBayesLearningControl();
                    modelPanel.Controls.Add(naiveBayesLearningControl);

                    break;
                case 4:
                    DecisionTreeLearningControl decisionTreeLearningControl = new DecisionTreeLearningControl();
                    modelPanel.Controls.Add(decisionTreeLearningControl);

                    break;
                case 5:
                    RandomForestLearningControl randomForestLearningControl = new RandomForestLearningControl();
                    modelPanel.Controls.Add(randomForestLearningControl);

                    break;
                case 6:
                    SVMClassificationLearningControl svmBinaryClassificationLearningControl = new SVMClassificationLearningControl();
                    modelPanel.Controls.Add(svmBinaryClassificationLearningControl);
                    
                    if (trainingInputColumns != null)
                        svmBinaryClassificationLearningControl.InputColumns = trainingInputColumns;

                    break;
                case 7:
                    ANNClassificationLearningControl annClassificationLearningControl = new ANNClassificationLearningControl();
                    modelPanel.Controls.Add(annClassificationLearningControl);

                    if (trainingInputColumns != null)
                    {
                        annClassificationLearningControl.InputColumns = trainingInputColumns;
                        annClassificationLearningControl.ClassIndexColumn = trainingClassIndexColumn;
                    }
                    annClassificationLearningControl.ModelConverged += OnANNConverged;
                    annClassificationLearningControl.TrainingStarted += OnANNTrainingStarted;
                    trainButton.Enabled = false;

                    break;
            }

            modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
            classificationTableLayoutPanel.RowStyles[1].Height = modelPanel.Controls[0].Height + 10;
            chooseModelButton.Text = "Change model...";

            classifier = null;
            modelTrained = false;
            serializedLearningParameters = "";

            testBinaryClassificationControl.Visible = false;
            testBinaryClassificationControl.Reset();
            predictClassificationControl.Visible = false;
            predictClassificationControl.Reset();
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
            classificationTableLayoutPanel.RowStyles[2].Height = 100f;
            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            try
            {
                object classifier = null;

                if (modelPanel.Controls[0].GetType() == typeof(LogisticRegressionLearningControl))
                {
                    LogisticRegressionLearningControl logisticRegressionLearningControl = (LogisticRegressionLearningControl)modelPanel.Controls[0];
                    if (logisticRegressionLearningControl.IterativeReweightedLeastSquaresRadioButton.Checked)
                    {
                        IterativeReweightedLeastSquares<LogisticRegression> iterativeReweightedLeastSquares = new IterativeReweightedLeastSquares<LogisticRegression>()
                        {
                            Tolerance = Convert.ToDouble(logisticRegressionLearningControl.ToleranceNumericUpDown.Value),
                            MaxIterations = Convert.ToInt32(logisticRegressionLearningControl.MaxIterationNumericUpDown.Value),
                            Regularization = Convert.ToDouble(logisticRegressionLearningControl.RegularizationNumericUpDown.Value)
                        };
                        classifier = iterativeReweightedLeastSquares.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else // LogisticGradientDescentRadioButton.Checked
                    {
                        LogisticGradientDescent logisticGradientDescent = new LogisticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(logisticRegressionLearningControl.ToleranceNumericUpDown.Value),
                            MaxIterations = Convert.ToInt32(logisticRegressionLearningControl.MaxIterationNumericUpDown.Value),
                            LearningRate = Convert.ToDouble(logisticRegressionLearningControl.LearningRateNumericUpDown.Value),
                            Stochastic = logisticRegressionLearningControl.StochasticCheckBox.Checked
                        };
                        classifier = logisticGradientDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                }
                else if (modelPanel.Controls[0].GetType() == typeof(KNearestNeighborsLearningControl))
                {
                    KNearestNeighborsLearningControl kNearestNeighborsLearningControl = (KNearestNeighborsLearningControl)modelPanel.Controls[0];
                    classifier = new KNearestNeighbors(Convert.ToInt32(kNearestNeighborsLearningControl.KNumericUpDown.Value));
                    ((KNearestNeighbors)classifier).Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelPanel.Controls[0].GetType() == typeof(MinimumMeanDistanceLearningControl))
                {
                    classifier = new MinimumMeanDistanceClassifier();
                    ((MinimumMeanDistanceClassifier)classifier).Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelPanel.Controls[0].GetType() == typeof(NaiveBayesLearningControl))
                {
                    NaiveBayesLearning<NormalDistribution> naiveBayesLearning = new NaiveBayesLearning<NormalDistribution>();
                    classifier = naiveBayesLearning.Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelPanel.Controls[0].GetType() == typeof(DecisionTreeLearningControl))
                {
                    DecisionTreeLearningControl decisionTreeLearningControl = (DecisionTreeLearningControl)modelPanel.Controls[0];
                    if (decisionTreeLearningControl.MethodComboBox.SelectedItem.ToString() == "C4.5")
                    {
                        DecisionVariable[] decisionVariables = new DecisionVariable[features.Length];
                        for (int columnIndex = 0; columnIndex < features.Length; columnIndex++)
                            decisionVariables[columnIndex] = new DecisionVariable(features[columnIndex], DecisionVariableKind.Continuous);
                        C45Learning c45Learning = new C45Learning(decisionVariables);
                        classifier = c45Learning.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else // MethodComboBox.SelectedItem.ToString() == "ID3"
                    {
                        DecisionVariable[] decisionVariables = new DecisionVariable[features.Length];
                        for (int columnIndex = 0; columnIndex < features.Length; columnIndex++)
                            decisionVariables[columnIndex] = new DecisionVariable(features[columnIndex], DecisionVariableKind.Discrete);
                        ID3Learning id3Learning = new ID3Learning(decisionVariables);
                        classifier = id3Learning.Learn(trainingInputColumns.ToInt32(), trainingClassIndexColumn);
                    }
                }
                else if (modelPanel.Controls[0].GetType() == typeof(RandomForestLearningControl))
                {
                    RandomForestLearningControl randomForestLearningControl = (RandomForestLearningControl)modelPanel.Controls[0];
                    RandomForestLearning randomForestLearning = new RandomForestLearning()
                    {
                        NumberOfTrees = Convert.ToInt32(randomForestLearningControl.NumberOfTreesNumericUpDown.Value),
                        SampleRatio = Convert.ToDouble(randomForestLearningControl.SampleRatioNumericUpDown.Value)
                    };
                    classifier = randomForestLearning.Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelPanel.Controls[0].GetType() == typeof(SVMClassificationLearningControl))
                {
                    SVMClassificationLearningControl svmBinaryClassificationLearningControl = (SVMClassificationLearningControl)modelPanel.Controls[0];
                    IKernel kernel = svmBinaryClassificationLearningControl.CreateKernel();
                    if (svmBinaryClassificationLearningControl.SequentialMinimalOptimizationRadioButton.Checked)
                    {
                        SequentialMinimalOptimization<IKernel> sequentialMinimalOptimization = new SequentialMinimalOptimization<IKernel>()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = kernel
                        };
                        classifier = sequentialMinimalOptimization.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LeastSquaresRadioButton.Checked)
                    {
                        LeastSquaresLearning leastSquaresLearning = new LeastSquaresLearning()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = kernel
                        };
                        classifier = leastSquaresLearning.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LinearCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                        LinearCoordinateDescent linearCoordinateDescent = new LinearCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = linearCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LinearDualCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Dual Coordinate Descent method can only use linear kernel!");
                        LinearDualCoordinateDescent linearDualCoordinateDescent = new LinearDualCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = linearDualCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LinearNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Newton method can only use linear kernel!");
                        LinearNewtonMethod linearNewtonMethod = new LinearNewtonMethod()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = linearNewtonMethod.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.ProbabilisticCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Coordinate Descent method can only use linear kernel!");
                        ProbabilisticCoordinateDescent probabilisticCoordinateDescent = new ProbabilisticCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = probabilisticCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.ProbabilisticDualCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Dual Coordinate Descent method can only use linear kernel!");
                        ProbabilisticDualCoordinateDescent probabilisticDualCoordinateDescent = new ProbabilisticDualCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = probabilisticDualCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.ProbabilisticNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Newton method can only use linear kernel!");
                        ProbabilisticNewtonMethod probabilisticNewtonMethod = new ProbabilisticNewtonMethod()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = probabilisticNewtonMethod.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.StochasticGradientDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Stochastic Gradient Descent method can only use linear kernel!");
                        StochasticGradientDescent stochasticGradientDescent = new StochasticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = stochasticGradientDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else // svmBinaryClassificationLearningControl.StochasticGradientDescentRadioButton.Checked
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Averaged Stochastic Gradient Descent method can only use linear kernel!");
                        AveragedStochasticGradientDescent averagedStochasticGradientDescent = new AveragedStochasticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = averagedStochasticGradientDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                }

                ModelTrained(new ModelTrainedEventArgs() { Model = classifier });
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
            classifier = e.Model;
            trainingPanel.Controls.Clear();
            classificationTableLayoutPanel.RowStyles[2].Height = 100f;

            if (classifier.GetType() == typeof(LogisticRegression))
            {
                serializedLearningParameters = ((LogisticRegressionLearningControl)modelPanel.Controls[0]).GetLearningParameters(); 
                trainingPanel.Controls.Add(new LogisticRegressionModelControl((LogisticRegression)classifier, features));
            }
            if (classifier.GetType() == typeof(KNearestNeighbors))
            {
                serializedLearningParameters = ((KNearestNeighborsLearningControl)modelPanel.Controls[0]).GetLearningParameters();
            }
            else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
            {
                trainingPanel.Controls.Add(new NaiveBayesModelControl((NaiveBayes<NormalDistribution>)classifier, features, target, classes.Values.ToArray()));
            }
            else if (classifier.GetType() == typeof(DecisionTree))
            {
                serializedLearningParameters = ((DecisionTreeLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                trainingPanel.Controls.Add(new DecisionTreeModelControl((DecisionTree)classifier, trainingInputColumns, trainingClassIndexColumn, features, classes));
            }
            else if (classifier.GetType() == typeof(RandomForest))
            {
                serializedLearningParameters = ((RandomForestLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                trainingPanel.Controls.Add(new RandomForestModelControl((RandomForest)classifier, trainingInputColumns, trainingClassIndexColumn, features, classes));
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine))
            {
                serializedLearningParameters = ((SVMClassificationLearningControl)modelPanel.Controls[0]).GetLearningParameters();
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                serializedLearningParameters = ((SVMClassificationLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                SupportVectorMachine<IKernel> svm = (SupportVectorMachine<IKernel>)classifier;
                if (svm.SupportVectors != null && svm.SupportVectors.Length > 0)
                    trainingPanel.Controls.Add(new SVMClassificationModelControl(svm.SupportVectors, svm.Weights, features, target, trainingInputColumns, trainingOutputColumn));
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
            {
                serializedLearningParameters = ((SVMClassificationLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                SupportVectorMachine<IKernel<double[]>, double[]> svm = (SupportVectorMachine<IKernel<double[]>, double[]>)classifier;
                if (svm.SupportVectors != null && svm.SupportVectors.Length > 0)
                    trainingPanel.Controls.Add(new SVMClassificationModelControl(svm.SupportVectors, svm.Weights, features, target, trainingInputColumns, trainingOutputColumn));
            }
            else if (classifier.GetType() == typeof(ActivationNetwork))
            {
                serializedLearningParameters = ((ANNClassificationLearningControl)modelPanel.Controls[0]).GetLearningParameters();
                trainingPanel.Controls.Add(new ANNClassificationModelControl((ActivationNetwork)classifier, features, classes.Values.ToArray()));
            }

            modelPanel.BackColor = Color.LightGreen;

            if (trainingPanel.Controls.Count > 0)
            {
                trainingPanel.Controls[0].Left = (trainingPanel.Width - trainingPanel.Controls[0].Width) / 2;
                classificationTableLayoutPanel.RowStyles[2].Height = trainingPanel.Controls[0].Height + 10;
                trainingPanel.BackColor = Color.LightGreen;
            }

            predictClassificationControl.Classifier = classifier;
            predictClassificationControl.Classes = classes;
            predictClassificationControl.ColumnNames = features.Concatenate(target);
            predictClassificationControl.Visible = true;

            modelTrained = true;
            statusLabel.Text = "Status: Model trained.";
            Cursor = Cursors.Default;
        }

        private void OnANNTrainingStarted(EventArgs e)
        {
            classifier = null;
            modelTrained = false;
            serializedLearningParameters = "";

            modelPanel.BackColor = SystemColors.Control;
            trainingPanel.Controls.Clear();
            classificationTableLayoutPanel.RowStyles[2].Height = 100f;
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

            if (!modelTrained || classifier == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                int[] predictedClassIndexColumn = null;
                if (classifier.GetType() == typeof(LogisticRegression))
                {
                    bool[] predictedColumn = ((LogisticRegression)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(KNearestNeighbors))
                {
                    predictedClassIndexColumn = ((KNearestNeighbors)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                {
                    predictedClassIndexColumn = ((MinimumMeanDistanceClassifier)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                {
                    predictedClassIndexColumn = ((NaiveBayes<NormalDistribution>)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(DecisionTree))
                {
                    predictedClassIndexColumn = ((DecisionTree)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(RandomForest))
                {
                    predictedClassIndexColumn = ((RandomForest)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    bool[] predictedColumn = ((SupportVectorMachine<IKernel>)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    bool[] predictedColumn = ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine))
                {
                    bool[] predictedColumn = ((SupportVectorMachine)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(ActivationNetwork))
                {
                    ActivationNetwork ann = (ActivationNetwork)classifier;

                    predictedClassIndexColumn = new int[testInputColumns.Length];
                    for (int i = 0; i < testInputColumns.Length; i++)
                    {
                        double[] output = ann.Compute(testInputColumns[i]);
                        predictedClassIndexColumn[i] = output.IndexOf(output.Max());
                    }
                }

                DataTable testDataTable = testInputColumns.ToTable(features);
                testDataTable.Columns.Add(target);
                testDataTable.Columns.Add(target + " (predicted)");

                for (int i = 0; i < testDataTable.Rows.Count; i++)
                {
                    testDataTable.Rows[i][target] = testOutputColumn[i];
                    testDataTable.Rows[i][target + " (predicted)"] = classes[predictedClassIndexColumn[i]];
                }

                for (int i = 0; i < testDataTable.Columns.Count; i++)
                    testDataTable.Columns[i].ReadOnly = false;

                testBinaryClassificationControl.Visible = true;
                testBinaryClassificationControl.TestDataTable = testDataTable;

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
