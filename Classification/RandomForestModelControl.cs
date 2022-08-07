using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Pruning;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DNMachineLearning.Classification
{
    public partial class RandomForestModelControl : UserControl
    {
        // Fields
        private RandomForest randomForest = null;
        private string[] features = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private double[][] trainingInputColumns = null;
        private int[] trainingClassIndexColumn = null;

        // Constructor
        public RandomForestModelControl(RandomForest randomForest, double[][] trainingInputColumns, int[] trainingClassIndexColumn, string[] features, Dictionary<int, string> classes)
        {
            InitializeComponent();

            pruningMethodComboBox.SelectedIndex = 0;

            for (int i = 0; i < randomForest.Trees.Length; i++)
                treeComboBox.Items.Add("Tree " + (i + 1).ToString());
            treeComboBox.SelectedIndex = 0;
            
            this.randomForest = randomForest;
            this.trainingInputColumns = trainingInputColumns;
            this.trainingClassIndexColumn = trainingClassIndexColumn;
            this.features = features;
            this.classes = classes;

            UpdateDecisionTreeView(randomForest.Trees[0]);
        }

        // Methods
        private void pruneButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (selectedTreeRadioButton.Checked)
            {
                try
                {
                    if (pruningMethodComboBox.SelectedItem.ToString() == "Error-Based Pruning")
                    {
                        ErrorBasedPruning prune = new ErrorBasedPruning(randomForest.Trees[treeComboBox.SelectedIndex], trainingInputColumns, trainingClassIndexColumn)
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
                        ReducedErrorPruning prune = new ReducedErrorPruning(randomForest.Trees[treeComboBox.SelectedIndex], trainingInputColumns, trainingClassIndexColumn);

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
            }
            else // whole forest
            {
                try
                {
                    for (int i = 0; i < randomForest.Trees.Length; i++)
                        if (pruningMethodComboBox.SelectedItem.ToString() == "Error-Based Pruning")
                        {
                            ErrorBasedPruning prune = new ErrorBasedPruning(randomForest.Trees[i], trainingInputColumns, trainingClassIndexColumn)
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
                            ReducedErrorPruning prune = new ReducedErrorPruning(randomForest.Trees[i], trainingInputColumns, trainingClassIndexColumn);

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
            }

            UpdateDecisionTreeView(randomForest.Trees[treeComboBox.SelectedIndex]);

            Cursor = Cursors.Arrow;
        }

        private void treeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (randomForest == null)
                return;

            selectedTreeRadioButton.Text = "Selected tree (tree " + (treeComboBox.SelectedIndex + 1).ToString() + ")";
            UpdateDecisionTreeView(randomForest.Trees[treeComboBox.SelectedIndex]);
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
