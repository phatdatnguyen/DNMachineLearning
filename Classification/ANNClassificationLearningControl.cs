using Accord;
using Accord.Math;
using Accord.Math.Random;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DNMachineLearning.Classification
{
    public partial class ANNClassificationLearningControl : UserControl
    {
        // Fields
        private double[][] inputColumns = null;
        private int[] classIndexColumn = null;
        private int[] classIndexes = null;
        private int[][] outputIntegerColumns;

        private bool useRegularization = false;
        private bool useNguyenWidrow = false;
        private bool useSameWeights = false;
        private double learningRate = 0.1;
        private int maxIteration = 1000;

        private IActivationFunction activationFunction = null;
        private ActivationNetwork ann = null;
        private LearningMethod learningMethod;

        private Thread workerThread = null;
        private int iteration = 0;
        private double error = 0;
        private TimeSpan elapsed = TimeSpan.Zero;
        private volatile bool needToStop = false;
        private double tolerance = 0;
        private bool isConverged = false;

        // Events
        public delegate void TrainingStartedEventHandler(EventArgs e);
        public event TrainingStartedEventHandler TrainingStarted;

        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelConverged;

        // Delegate
        private delegate void EnableCallback(bool enable);

        // Enum
        private enum LearningMethod
        {
            LevenbergMarquardt, Backpropagation, ResilientBackpropagation, ParallelResilientBackpropagation,
            Perceptron, DeltaRule
        }

        // Properties
        public double[][] InputColumns
        {
            set
            {
                inputColumns = value;

                startButton.Enabled = true;
            }
        }

        public int[] ClassIndexColumn
        {
            set
            {
                classIndexColumn = value;

                classIndexes = classIndexColumn.Distinct().OrderBy(i => i).ToArray();
                outputIntegerColumns = new int[classIndexColumn.Length][];
                for (int rowIndex = 0; rowIndex < classIndexColumn.Length; rowIndex++)
                {
                    outputIntegerColumns[rowIndex] = new int[classIndexes.Length];
                    for (int columnIndex = 0; columnIndex < classIndexes.Length; columnIndex++)
                        if (classIndexColumn[rowIndex] == classIndexes[columnIndex])
                            outputIntegerColumns[rowIndex][columnIndex] = 1;
                        else
                            outputIntegerColumns[rowIndex][columnIndex] = -1;
                }
            }
        }

        public bool IsConverged { get { return isConverged; } }

        // Constructor
        public ANNClassificationLearningControl()
        {
            InitializeComponent();

            networkStructureDataGridView.Rows.Add(new string[] { "Hidden 1", "3" });
            activationFunctionComboBox.SelectedIndex = 2;
            learningMethodComboBox.SelectedIndex = 0;
        }

        // Methods
        private void addLayerButton_Click(object sender, EventArgs e)
        {
            int currentNumberOfLayers = networkStructureDataGridView.Rows.Count;
            networkStructureDataGridView.Rows.Add(new string[] { "Hidden " + (currentNumberOfLayers + 1).ToString(), "3" });
        }

        private void deleteLayerButton_Click(object sender, EventArgs e)
        {
            if (networkStructureDataGridView.Rows.Count == 0)
                return;

            networkStructureDataGridView.Rows.RemoveAt(networkStructureDataGridView.Rows.Count - 1);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            isConverged = false;
            TrainingStarted(EventArgs.Empty);

            useRegularization = bayesianRegularizationCheckBox.Checked;
            useNguyenWidrow = nguyenWidrowCheckBox.Checked;
            useSameWeights = sameWeightsCheckBox.Checked;
            learningRate = (double)learningRateNumericUpDown.Value;
            tolerance = (double)toleranceNumericUpDown.Value;
            maxIteration = (int)maxIterationNumericUpDown.Value;
            activationFunction = CreateActivationFunction();

            //Create multi-layer neural network
            int numberOfInputs = inputColumns[0].Length;
            int[] layers = new int[networkStructureDataGridView.Rows.Count + 1]; // hidden layers + output layer
            try
            {
                for (int layerIndex = 0; layerIndex < networkStructureDataGridView.Rows.Count; layerIndex++)  // hidden layer
                    layers[layerIndex] = Convert.ToInt32(networkStructureDataGridView.Rows[layerIndex].Cells[1].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            layers[layers.Length - 1] = classIndexes.Length; // output layer
            ann = new ActivationNetwork(activationFunction, numberOfInputs, layers);

            if (useNguyenWidrow)
            {
                if (useSameWeights)
                    Generator.Seed = 1;

                NguyenWidrow initializer = new NguyenWidrow(ann);
                initializer.Randomize();
            }

            switch (learningMethodComboBox.SelectedItem.ToString())
            {
                case "Levenberg-Marquardt":
                    learningMethod = LearningMethod.LevenbergMarquardt;
                    break;
                case "Backpropagation":
                    learningMethod = LearningMethod.Backpropagation;
                    break;
                case "Resilient Backpropagation":
                    learningMethod = LearningMethod.ResilientBackpropagation;
                    break;
                case "Parallel Resilient Backpropagation":
                    learningMethod = LearningMethod.ParallelResilientBackpropagation;
                    break;
                case "Perceptron":
                    if (layers.Length >= 2)
                    {
                        MessageBox.Show(this, "Perceptron learning can only be applied to perceptron!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    learningMethod = LearningMethod.Perceptron;
                    break;
                case "Delta Rule":
                    if (layers.Length >= 2)
                    {
                        MessageBox.Show(this, "Delta Rule learning can only be applied to perceptron!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    learningMethod = LearningMethod.DeltaRule;
                    break;
            }

            EnableControls(false);

            //Run worker thread
            workerThreadTimer.Start();
            needToStop = false;
            workerThread = new Thread(new ThreadStart(SearchSolution));
            workerThread.Start();
        }

        private void SearchSolution() // On worker thread
        {
            int numberOfEntries = inputColumns.Length;

            try
            {
                //Create learner
                object annLearning = null;
                switch (learningMethod)
                {
                    case LearningMethod.LevenbergMarquardt:
                        annLearning = new LevenbergMarquardtLearning(ann, useRegularization)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.Backpropagation:
                        annLearning = new BackPropagationLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.ResilientBackpropagation:
                        annLearning = new ResilientBackpropagationLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.ParallelResilientBackpropagation:
                        annLearning = new ParallelResilientBackpropagationLearning(ann);
                        break;
                    case LearningMethod.Perceptron:
                        annLearning = new PerceptronLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.DeltaRule:
                        annLearning = new DeltaRuleLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                }

                //Iterations
                iteration = 1;
                Stopwatch stopwatch = Stopwatch.StartNew();

                //Loop
                while (!needToStop)
                {
                    //Run epoch of learning procedure
                    switch (learningMethod)
                    {
                        case LearningMethod.LevenbergMarquardt:
                            error = ((LevenbergMarquardtLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.Backpropagation:
                            error = ((BackPropagationLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.ResilientBackpropagation:
                            error = ((ResilientBackpropagationLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.ParallelResilientBackpropagation:
                            error = ((ParallelResilientBackpropagationLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.Perceptron:
                            error = ((PerceptronLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.DeltaRule:
                            error = ((DeltaRuleLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                    }

                    //Increase current iteration
                    iteration++;
                    elapsed = stopwatch.Elapsed;
                    UpdateStatus();

                    //Check if model converged
                    if (iteration > maxIteration)
                    {
                        if (error <= tolerance)
                            isConverged = true;

                        break;
                    }
                }

                stopwatch.Stop();
                EnableControls(true);
            }
            catch
            {
                isConverged = false;
                EnableControls(true);
            }
        }

        private IActivationFunction CreateActivationFunction()
        {
            switch (activationFunctionComboBox.SelectedItem.ToString())
            {
                case "Bipolar Sigmoid":
                    return new BipolarSigmoidFunction((double)alphaNumericUpDown.Value);
                case "Sigmoid":
                    return new SigmoidFunction((double)alphaNumericUpDown.Value);
                case "Linear":
                    return new LinearFunction(new DoubleRange((double)lowerLimitNumericUpDown.Value, (double)upperLimitNumericUpDown.Value));
                case "Rectified Linear":
                    return new RectifiedLinearFunction();
                case "Threshold":
                    return new ThresholdFunction();
                case "Identity":
                    return new IdentityFunction();
                default:
                    throw new Exception("No function selected!");
            }
        }

        private void EnableControls(bool enable)
        {
            if (InvokeRequired)
            {
                EnableCallback d = new EnableCallback(EnableControls);
                Invoke(d, new object[] { enable });
            }
            else
            {
                startButton.Enabled = enable;
                stopButton.Enabled = !enable;
            }
        }

        private void UpdateStatus()
        {
            if (!iterationTextBox.InvokeRequired)
            {
                iterationTextBox.Text = iteration.ToString();
                errorTextBox.Text = error.ToString("N10");
                elapsedTextBox.Text = elapsed.ToString();
            }
            else
            {
                iterationTextBox.BeginInvoke(new Action(UpdateStatus));
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            needToStop = true;
            while (!workerThread.Join(100))
                Application.DoEvents();
            workerThread = null;

            if (error <= tolerance)
                isConverged = true;
        }

        private void workerThreadTimer_Tick(object sender, EventArgs e)
        {
            if (isConverged)
            {
                ModelConverged(new ModelTrainedEventArgs() { Model = ann });

                workerThreadTimer.Stop();
            }
        }

        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();
            string[][] hiddenLayers = new string[networkStructureDataGridView.Rows.Count][];
            for (int i = 0; i < networkStructureDataGridView.Rows.Count; i++)
            {
                hiddenLayers[i] = new string[2];
                hiddenLayers[i][0] = networkStructureDataGridView.Rows[i].Cells[0].Value.ToString();
                hiddenLayers[i][1] = networkStructureDataGridView.Rows[i].Cells[1].Value.ToString();
            }
            learningParameters.Add("hidden layers", JsonConvert.SerializeObject(hiddenLayers));
            learningParameters.Add("activation function", activationFunctionComboBox.SelectedIndex.ToString());
            learningParameters.Add("alpha", alphaNumericUpDown.Value.ToString());
            learningParameters.Add("lower limit", lowerLimitNumericUpDown.Value.ToString());
            learningParameters.Add("upper limit", upperLimitNumericUpDown.Value.ToString());
            learningParameters.Add("method", learningMethodComboBox.SelectedIndex.ToString());
            learningParameters.Add("bayesian regularization", bayesianRegularizationCheckBox.Checked.ToString());
            learningParameters.Add("nguyen-widrow", nguyenWidrowCheckBox.Checked.ToString());
            learningParameters.Add("same weights", sameWeightsCheckBox.Checked.ToString());
            learningParameters.Add("tolerance", toleranceNumericUpDown.Value.ToString());
            learningParameters.Add("max iteration", maxIterationNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            string[][] hiddenLayers = JsonConvert.DeserializeObject<string[][]>(learningParameters["hidden layers"]);
            networkStructureDataGridView.Rows.Clear();
            for (int i = 0;i < hiddenLayers.Length; i++)
                networkStructureDataGridView.Rows.Add(hiddenLayers[i][0], hiddenLayers[i][1]);
            activationFunctionComboBox.SelectedIndex = Convert.ToInt32(learningParameters["activation function"]);
            alphaNumericUpDown.Value = Convert.ToDecimal(learningParameters["alpha"]);
            lowerLimitNumericUpDown.Value = Convert.ToDecimal(learningParameters["lower limit"]);
            upperLimitNumericUpDown.Value = Convert.ToDecimal(learningParameters["upper limit"]);
            learningMethodComboBox.SelectedIndex = Convert.ToInt32(learningParameters["method"]);
            bayesianRegularizationCheckBox.Checked = Convert.ToBoolean(learningParameters["bayesian regularization"]);
            nguyenWidrowCheckBox.Checked = Convert.ToBoolean(learningParameters["nguyen-widrow"]);
            sameWeightsCheckBox.Checked = Convert.ToBoolean(learningParameters["same weights"]);
            toleranceNumericUpDown.Value = Convert.ToDecimal(learningParameters["tolerance"]);
            maxIterationNumericUpDown.Value = Convert.ToDecimal(learningParameters["max iteration"]);
        }
    }
}
