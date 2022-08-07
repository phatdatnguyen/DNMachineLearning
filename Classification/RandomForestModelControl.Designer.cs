namespace DNMachineLearning.Classification
{
    partial class RandomForestModelControl
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
            this.treeViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.treePanel = new System.Windows.Forms.Panel();
            this.treeComboBox = new System.Windows.Forms.ComboBox();
            this.treeLabel = new System.Windows.Forms.Label();
            this.decisionTreeView = new System.Windows.Forms.TreeView();
            this.pruningGroupBox = new System.Windows.Forms.GroupBox();
            this.wholeForestRadioButton = new System.Windows.Forms.RadioButton();
            this.selectedTreeRadioButton = new System.Windows.Forms.RadioButton();
            this.pruningMethodComboBox = new System.Windows.Forms.ComboBox();
            this.pruneButton = new System.Windows.Forms.Button();
            this.pruningThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pruningMethodLabel = new System.Windows.Forms.Label();
            this.pruningThresholdLabel = new System.Windows.Forms.Label();
            this.modelTableLayoutPanel.SuspendLayout();
            this.treeViewGroupBox.SuspendLayout();
            this.treeViewTableLayoutPanel.SuspendLayout();
            this.treePanel.SuspendLayout();
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
            this.titleLabel.Text = "Random Forest Model";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 2;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
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
            this.treeViewGroupBox.Controls.Add(this.treeViewTableLayoutPanel);
            this.treeViewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewGroupBox.Location = new System.Drawing.Point(2, 51);
            this.treeViewGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewGroupBox.Name = "treeViewGroupBox";
            this.treeViewGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.treeViewGroupBox.Size = new System.Drawing.Size(334, 191);
            this.treeViewGroupBox.TabIndex = 0;
            this.treeViewGroupBox.TabStop = false;
            this.treeViewGroupBox.Text = "Tree view";
            // 
            // treeViewTableLayoutPanel
            // 
            this.treeViewTableLayoutPanel.ColumnCount = 1;
            this.treeViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.treeViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.treeViewTableLayoutPanel.Controls.Add(this.treePanel, 0, 0);
            this.treeViewTableLayoutPanel.Controls.Add(this.decisionTreeView, 0, 1);
            this.treeViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTableLayoutPanel.Location = new System.Drawing.Point(2, 18);
            this.treeViewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewTableLayoutPanel.Name = "treeViewTableLayoutPanel";
            this.treeViewTableLayoutPanel.RowCount = 2;
            this.treeViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.treeViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.treeViewTableLayoutPanel.Size = new System.Drawing.Size(330, 171);
            this.treeViewTableLayoutPanel.TabIndex = 0;
            // 
            // treePanel
            // 
            this.treePanel.Controls.Add(this.treeComboBox);
            this.treePanel.Controls.Add(this.treeLabel);
            this.treePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePanel.Location = new System.Drawing.Point(2, 2);
            this.treePanel.Margin = new System.Windows.Forms.Padding(2);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(326, 28);
            this.treePanel.TabIndex = 0;
            // 
            // treeComboBox
            // 
            this.treeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeComboBox.FormattingEnabled = true;
            this.treeComboBox.Location = new System.Drawing.Point(35, 2);
            this.treeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.treeComboBox.Name = "treeComboBox";
            this.treeComboBox.Size = new System.Drawing.Size(114, 21);
            this.treeComboBox.TabIndex = 0;
            this.treeComboBox.SelectedIndexChanged += new System.EventHandler(this.treeComboBox_SelectedIndexChanged);
            // 
            // treeLabel
            // 
            this.treeLabel.AutoSize = true;
            this.treeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeLabel.Location = new System.Drawing.Point(2, 5);
            this.treeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.treeLabel.Name = "treeLabel";
            this.treeLabel.Size = new System.Drawing.Size(29, 13);
            this.treeLabel.TabIndex = 0;
            this.treeLabel.Text = "Tree";
            // 
            // decisionTreeView
            // 
            this.decisionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionTreeView.Location = new System.Drawing.Point(2, 34);
            this.decisionTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.decisionTreeView.Name = "decisionTreeView";
            this.decisionTreeView.Size = new System.Drawing.Size(326, 135);
            this.decisionTreeView.TabIndex = 1;
            // 
            // pruningGroupBox
            // 
            this.pruningGroupBox.Controls.Add(this.wholeForestRadioButton);
            this.pruningGroupBox.Controls.Add(this.selectedTreeRadioButton);
            this.pruningGroupBox.Controls.Add(this.pruningMethodComboBox);
            this.pruningGroupBox.Controls.Add(this.pruneButton);
            this.pruningGroupBox.Controls.Add(this.pruningThresholdNumericUpDown);
            this.pruningGroupBox.Controls.Add(this.pruningMethodLabel);
            this.pruningGroupBox.Controls.Add(this.pruningThresholdLabel);
            this.pruningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pruningGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningGroupBox.Location = new System.Drawing.Point(340, 51);
            this.pruningGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.pruningGroupBox.Name = "pruningGroupBox";
            this.pruningGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.pruningGroupBox.Size = new System.Drawing.Size(258, 191);
            this.pruningGroupBox.TabIndex = 1;
            this.pruningGroupBox.TabStop = false;
            this.pruningGroupBox.Text = "Tree pruning";
            // 
            // wholeForestRadioButton
            // 
            this.wholeForestRadioButton.AutoSize = true;
            this.wholeForestRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeForestRadioButton.Location = new System.Drawing.Point(158, 43);
            this.wholeForestRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.wholeForestRadioButton.Name = "wholeForestRadioButton";
            this.wholeForestRadioButton.Size = new System.Drawing.Size(85, 17);
            this.wholeForestRadioButton.TabIndex = 1;
            this.wholeForestRadioButton.Text = "Whole forest";
            this.wholeForestRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectedTreeRadioButton
            // 
            this.selectedTreeRadioButton.AutoSize = true;
            this.selectedTreeRadioButton.Checked = true;
            this.selectedTreeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTreeRadioButton.Location = new System.Drawing.Point(17, 43);
            this.selectedTreeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectedTreeRadioButton.Name = "selectedTreeRadioButton";
            this.selectedTreeRadioButton.Size = new System.Drawing.Size(124, 17);
            this.selectedTreeRadioButton.TabIndex = 0;
            this.selectedTreeRadioButton.TabStop = true;
            this.selectedTreeRadioButton.Text = "Selected tree (tree 1)";
            this.selectedTreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // pruningMethodComboBox
            // 
            this.pruningMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pruningMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningMethodComboBox.FormattingEnabled = true;
            this.pruningMethodComboBox.Items.AddRange(new object[] {
            "Error-Based Pruning",
            "Reduced Error Pruning"});
            this.pruningMethodComboBox.Location = new System.Drawing.Point(70, 84);
            this.pruningMethodComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pruningMethodComboBox.Name = "pruningMethodComboBox";
            this.pruningMethodComboBox.Size = new System.Drawing.Size(151, 21);
            this.pruningMethodComboBox.TabIndex = 2;
            // 
            // pruneButton
            // 
            this.pruneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruneButton.Location = new System.Drawing.Point(146, 132);
            this.pruneButton.Margin = new System.Windows.Forms.Padding(2);
            this.pruneButton.Name = "pruneButton";
            this.pruneButton.Size = new System.Drawing.Size(75, 23);
            this.pruneButton.TabIndex = 4;
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
            this.pruningThresholdNumericUpDown.Location = new System.Drawing.Point(146, 109);
            this.pruningThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.pruningThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pruningThresholdNumericUpDown.Name = "pruningThresholdNumericUpDown";
            this.pruningThresholdNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.pruningThresholdNumericUpDown.TabIndex = 3;
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
            this.pruningMethodLabel.Location = new System.Drawing.Point(23, 87);
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
            this.pruningThresholdLabel.Location = new System.Drawing.Point(88, 111);
            this.pruningThresholdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pruningThresholdLabel.Name = "pruningThresholdLabel";
            this.pruningThresholdLabel.Size = new System.Drawing.Size(54, 13);
            this.pruningThresholdLabel.TabIndex = 0;
            this.pruningThresholdLabel.Text = "Threshold";
            // 
            // RandomForestModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelTableLayoutPanel);
            this.Name = "RandomForestModelControl";
            this.Size = new System.Drawing.Size(600, 244);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.modelTableLayoutPanel.PerformLayout();
            this.treeViewGroupBox.ResumeLayout(false);
            this.treeViewTableLayoutPanel.ResumeLayout(false);
            this.treePanel.ResumeLayout(false);
            this.treePanel.PerformLayout();
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
        private System.Windows.Forms.RadioButton wholeForestRadioButton;
        private System.Windows.Forms.RadioButton selectedTreeRadioButton;
        private System.Windows.Forms.TableLayoutPanel treeViewTableLayoutPanel;
        private System.Windows.Forms.Panel treePanel;
        private System.Windows.Forms.ComboBox treeComboBox;
        private System.Windows.Forms.Label treeLabel;
        private System.Windows.Forms.TreeView decisionTreeView;
    }
}
