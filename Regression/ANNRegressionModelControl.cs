using Accord.Neuro;
using System.Windows.Forms;

namespace DNMachineLearning.Regression
{
    public partial class ANNRegressionModelControl : UserControl
    {
        // Constructor
        public ANNRegressionModelControl(ActivationNetwork ann, string[] features, string target)
        {
            InitializeComponent();

            networkTreeView.Nodes.Clear();
            TreeNode root = networkTreeView.Nodes.Add("Network");

            TreeNode inputLayerNode = root.Nodes.Add("Input Layer");
            for (int neuronIndex = 0; neuronIndex < features.Length; neuronIndex++)
                inputLayerNode.Nodes.Add(features[neuronIndex]);

            for (int hiddenLayerIndex = 0; hiddenLayerIndex < ann.Layers.Length - 1; hiddenLayerIndex++)
            {
                Layer hiddenLayer = ann.Layers[hiddenLayerIndex];
                TreeNode layerNode = root.Nodes.Add("Hidden Layer " + (hiddenLayerIndex + 1).ToString());
                for (int neuronIndex = 0; neuronIndex < hiddenLayer.Neurons.Length; neuronIndex++)
                {
                    TreeNode hiddenNeuronNode = layerNode.Nodes.Add("Neuron " + (neuronIndex + 1).ToString());
                    hiddenNeuronNode.Tag = hiddenLayer.Neurons[neuronIndex];
                }
            }

            Layer outputLayer = ann.Layers[ann.Layers.Length - 1];
            TreeNode outputLayerNode = root.Nodes.Add("Output Layer");
            TreeNode outputNeuronNode = outputLayerNode.Nodes.Add(target.ToString());
            outputNeuronNode.Tag = outputLayer.Neurons[0];

            networkTreeView.ExpandAll();
        }

        // Method
        private void networkTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            weightsListBox.Items.Clear();
            outputTextBox.Text = "";

            if (e.Node.Tag == null)
                return;

            if (e.Node.Tag.GetType() == typeof(ActivationNeuron))
            {
                ActivationNeuron neuron = (ActivationNeuron)e.Node.Tag;
                weightsListBox.Items.Clear();
                foreach (double weight in neuron.Weights)
                    weightsListBox.Items.Add(weight.ToString());
                biasTextBox.Text = neuron.Threshold.ToString();
                outputTextBox.Text = neuron.Output.ToString();
            }
        }
    }
}
