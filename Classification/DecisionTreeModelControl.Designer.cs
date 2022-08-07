namespace DNMachineLearning.Classification
{
    partial class DecisionTreeModelControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.modelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewGroupBox = new System.Windows.Forms.GroupBox();
            this.decisionTreeView = new System.Windows.Forms.TreeView();
            this.pruningGroupBox = new System.Windows.Forms.GroupBox();
            this.pruningMethodComboBox = new System.Windows.Forms.ComboBox();
            this.pruneButton = new System.Windows.Forms.Button();
            this.pruningThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pruningMethodLabel = new System.Windows.Forms.Label();
            this.pruningThresholdLabel = new System.Windows.Forms.Label();
            this.modelTableLayoutPanel.SuspendLayout();
            this.treeViewGroupBox.SuspendLayout();
            this.pruningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruningThresholdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.modelTableLayoutPanel.SetColumnSpan(this.titleLabel, 2);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(594, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Decision Tree Model";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 2;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.modelTableLayoutPanel.Controls.Add(this.treeViewGroupBox, 0, 1);
            this.modelTableLayoutPanel.Controls.Add(this.pruningGroupBox, 0, 1);
            this.modelTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.modelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.modelTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.modelTableLayoutPanel.Name = "modelTableLayoutPanel";
            this.modelTableLayoutPanel.RowCount = 2;
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.Size = new System.Drawing.Size(600, 244);
            this.modelTableLayoutPanel.TabIndex = 0;
            // 
            // treeViewGroupBox
            // 
            this.treeViewGroupBox.Controls.Add(this.decisionTreeView);
            this.treeViewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewGroupBox.Location = new System.Drawing.Point(2, 51);
            this.treeViewGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewGroupBox.Name = "treeViewGroupBox";
            this.treeViewGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.treeViewGroupBox.Size = new System.Drawing.Size(371, 191);
            this.treeViewGroupBox.TabIndex = 0;
            this.treeViewGroupBox.TabStop = false;
            this.treeViewGroupBox.Text = "Tree view";
            // 
            // decisionTreeView
            // 
            this.decisionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionTreeView.Location = new System.Drawing.Point(2, 18);
            this.decisionTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.decisionTreeView.Name = "decisionTreeView";
            this.decisionTreeView.Size = new System.Drawing.Size(367, 171);
            this.decisionTreeView.TabIndex = 0;
            // 
            // pruningGroupBox
            // 
            this.pruningGroupBox.Controls.Add(this.pruningMethodComboBox);
            this.pruningGroupBox.Controls.Add(this.pruneButton);
            this.pruningGroupBox.Controls.Add(this.pruningThresholdNumericUpDown);
            this.pruningGroupBox.Controls.Add(this.pruningMethodLabel);
            this.pruningGroupBox.Controls.Add(this.pruningThresholdLabel);
            this.pruningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pruningGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningGroupBox.Location = new System.Drawing.Point(377, 51);
            this.pruningGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.pruningGroupBox.Name = "pruningGroupBox";
            this.pruningGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.pruningGroupBox.Size = new System.Drawing.Size(221, 191);
            this.pruningGroupBox.TabIndex = 1;
            this.pruningGroupBox.TabStop = false;
            this.pruningGroupBox.Text = "Tree pruning";
            // 
            // pruningMethodComboBox
            // 
            this.pruningMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pruningMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningMethodComboBox.FormattingEnabled = true;
            this.pruningMethodComboBox.Items.AddRange(new object[] {
            "Error-Based Pruning",
            "Reduced Error Pruning"});
            this.pruningMethodComboBox.Location = new System.Drawing.Point(58, 66);
            this.pruningMethodComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pruningMethodComboBox.Name = "pruningMethodComboBox";
            this.pruningMethodComboBox.Size = new System.Drawing.Size(151, 21);
            this.pruningMethodComboBox.TabIndex = 0;
            // 
            // pruneButton
            // 
            this.pruneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruneButton.Location = new System.Drawing.Point(133, 113);
            this.pruneButton.Margin = new System.Windows.Forms.Padding(2);
            this.pruneButton.Name = "pruneButton";
            this.pruneButton.Size = new System.Drawing.Size(75, 23);
            this.pruneButton.TabIndex = 2;
            this.pruneButton.Text = "Prune";
            this.pruneButton.UseVisualStyleBackColor = true;
            this.pruneButton.Click += new System.EventHandler(this.pruneButton_Click);
            // 
            // pruningThresholdNumericUpDown
            // 
            this.pruningThresholdNumericUpDown.DecimalPlaces = 2;
            this.pruningThresholdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningThresholdNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pruningThresholdNumericUpDown.Location = new System.Drawing.Point(133, 90);
            this.pruningThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.pruningThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pruningThresholdNumericUpDown.Name = "pruningThresholdNumericUpDown";
            this.pruningThresholdNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.pruningThresholdNumericUpDown.TabIndex = 1;
            this.pruningThresholdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // pruningMethodLabel
            // 
            this.pruningMethodLabel.AutoSize = true;
            this.pruningMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningMethodLabel.Location = new System.Drawing.Point(11, 69);
            this.pruningMethodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pruningMethodLabel.Name = "pruningMethodLabel";
            this.pruningMethodLabel.Size = new System.Drawing.Size(43, 13);
            this.pruningMethodLabel.TabIndex = 0;
            this.pruningMethodLabel.Text = "Method";
            // 
            // pruningThresholdLabel
            // 
            this.pruningThresholdLabel.AutoSize = true;
            this.pruningThresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningThresholdLabel.Location = new System.Drawing.Point(75, 92);
            this.pruningThresholdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pruningThresholdLabel.Name = "pruningThresholdLabel";
            this.pruningThresholdLabel.Size = new System.Drawing.Size(54, 13);
            this.pruningThresholdLabel.TabIndex = 0;
            this.pruningThresholdLabel.Text = "Threshold";
            // 
            // DecisionTreeModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelTableLayoutPanel);
            this.Name = "DecisionTreeModelControl";
            this.Size = new System.Drawing.Size(600, 244);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.modelTableLayoutPanel.PerformLayout();
            this.treeViewGroupBox.ResumeLayout(false);
            this.pruningGroupBox.ResumeLayout(false);
            this.pruningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruningThresholdNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel modelTableLayoutPanel;
        private System.Windows.Forms.GroupBox pruningGroupBox;
        private System.Windows.Forms.ComboBox pruningMethodComboBox;
        private System.Windows.Forms.Button pruneButton;
        private System.Windows.Forms.NumericUpDown pruningThresholdNumericUpDown;
        private System.Windows.Forms.Label pruningMethodLabel;
        private System.Windows.Forms.Label pruningThresholdLabel;
        private System.Windows.Forms.GroupBox treeViewGroupBox;
        private System.Windows.Forms.TreeView decisionTreeView;
    }
}
