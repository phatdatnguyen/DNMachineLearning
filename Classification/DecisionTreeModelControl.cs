using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Pruning;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DNMachineLearning.Classification
{
    public partial class DecisionTreeModelControl : UserControl
    {
        // Fields
        private DecisionTree decisionTree = null;
        private string[] features = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private double[][] trainingInputColumns = null;
        private int[] trainingClassIndexColumn = null;

        // Constructor
        public DecisionTreeModelControl(DecisionTree decisionTree, double[][] trainingInputColumns, int[] trainingClassIndexColumn, string[] features, Dictionary<int, string> classes)
        {
            InitializeComponent();

            pruningMethodComboBox.SelectedIndex = 0;

            this.decisionTree = decisionTree;
            this.trainingInputColumns = trainingInputColumns;
            this.trainingClassIndexColumn = trainingClassIndexColumn;
            this.features = features;
            this.classes = classes;

            UpdateDecisionTreeView(decisionTree);
        }

        // Methods
        private void pruneButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                if (pruningMethodComboBox.SelectedItem.ToString() == "Error-Based Pruning")
                {
                    ErrorBasedPruning prune = new ErrorBasedPruning(decisionTree, trainingInputColumns, trainingClassIndexColumn)
                    {
                        Threshold = (double)pruningThresholdNumericUpDown.Value
                    };

                    double lastError;
                    double error = Double.PositiveInfinity;
                    do
                    {
                        lastError = error;
                        error = prune.Run();
                    }
                    while (error < lastError);
                }
                else //pruningMethodComboBox.SelectedItem.ToString() == "Reduced Error Pruning"
                {
                    ReducedErrorPruning prune = new ReducedErrorPruning(decisionTree, trainingInputColumns, trainingClassIndexColumn);

                    double lastError;
                    double error = Double.PositiveInfinity;
                    do
                    {
                        lastError = error;
                        error = prune.Run();
                    }
                    while (error < lastError);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Arrow;
                return;
            }

            UpdateDecisionTreeView(decisionTree);

            Cursor = Cursors.Arrow;
        }

        private void UpdateDecisionTreeView(DecisionTree decisionTree)
        {
            decisionTreeView.Nodes.Clear();

            if (decisionTree.Root.IsLeaf)
            {
                TreeNode treeNode = decisionTreeView.Nodes.Add("Root");
                int classIndex = (int)decisionTree.Root.Output;
                treeNode.Nodes.Add(new TreeNode(classes[classIndex]));
                treeNode.Nodes[0].NodeFont = new Font(Font, FontStyle.Bold);

                decisionTreeView.ExpandAll();
                return;
            }

            TreeNode rootNode = decisionTreeView.Nodes.Add("Root");
            foreach (DecisionNode decisionNode in decisionTree.Root.Branches)
                rootNode.Nodes.Add(convertToTreeNode(decisionNode));
            
            decisionTreeView.ExpandAll();
        }

        private TreeNode convertToTreeNode(DecisionNode decisionNode)
        {
            string feature = features[decisionNode.Parent.Branches.AttributeIndex];
            string comparison = "";
            switch (decisionNode.Comparison)
            {
                case ComparisonKind.Equal:
                    comparison = "=";
                    break;
                case ComparisonKind.NotEqual:
                    comparison = "<>";
                    break;
                case ComparisonKind.GreaterThan:
                    comparison = ">";
                    break;
                case ComparisonKind.GreaterThanOrEqual:
                    comparison = ">=";
                    break;
                case ComparisonKind.LessThan:
                    comparison = "<";
                    break;
                case ComparisonKind.LessThanOrEqual:
                    comparison = "<=";
                    break;
            }
            string decisionNodeString = feature + " " + comparison + " " + decisionNode.Value.ToString();
            TreeNode treeNode = new TreeNode(decisionNodeString);

            if (!decisionNode.IsLeaf)
            {
                foreach (DecisionNode childNode in decisionNode.Branches)
                    treeNode.Nodes.Add(convertToTreeNode(childNode));

                return treeNode;
            }
            else
            {
                int classIndex = (int)decisionNode.Output;
                treeNode.Nodes.Add(new TreeNode(classes[classIndex]));
                treeNode.Nodes[0].NodeFont = new Font(Font, FontStyle.Bold);
                return treeNode;
            }
        }
    }
}
