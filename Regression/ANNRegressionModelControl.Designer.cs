namespace DNMachineLearning.Regression
{
    partial class ANNRegressionModelControl
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
            this.modelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.neuronInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.weightsListBox = new System.Windows.Forms.ListBox();
            this.biasTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.biasLabel = new System.Windows.Forms.Label();
            this.weightsLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.networkViewGroupBox = new System.Windows.Forms.GroupBox();
            this.networkTreeView = new System.Windows.Forms.TreeView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modelTableLayoutPanel.SuspendLayout();
            this.neuronInfoGroupBox.SuspendLayout();
            this.networkViewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 2;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.modelTableLayoutPanel.Controls.Add(this.neuronInfoGroupBox, 1, 1);
            this.modelTableLayoutPanel.Controls.Add(this.networkViewGroupBox, 0, 1);
            this.modelTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.modelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.modelTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelTableLayoutPanel.Name = "modelTableLayoutPanel";
            this.modelTableLayoutPanel.RowCount = 2;
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.Size = new System.Drawing.Size(600, 325);
            this.modelTableLayoutPanel.TabIndex = 0;
            // 
            // neuronInfoGroupBox
            // 
            this.neuronInfoGroupBox.Controls.Add(this.weightsListBox);
            this.neuronInfoGroupBox.Controls.Add(this.biasTextBox);
            this.neuronInfoGroupBox.Controls.Add(this.outputTextBox);
            this.neuronInfoGroupBox.Controls.Add(this.biasLabel);
            this.neuronInfoGroupBox.Controls.Add(this.weightsLabel);
            this.neuronInfoGroupBox.Controls.Add(this.outputLabel);
            this.neuronInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neuronInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuronInfoGroupBox.Location = new System.Drawing.Point(362, 51);
            this.neuronInfoGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.neuronInfoGroupBox.Name = "neuronInfoGroupBox";
            this.neuronInfoGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.neuronInfoGroupBox.Size = new System.Drawing.Size(236, 272);
            this.neuronInfoGroupBox.TabIndex = 1;
            this.neuronInfoGroupBox.TabStop = false;
            this.neuronInfoGroupBox.Text = "Neuron Info";
            // 
            // weightsListBox
            // 
            this.weightsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightsListBox.FormattingEnabled = true;
            this.weightsListBox.Location = new System.Drawing.Point(88, 21);
            this.weightsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightsListBox.Name = "weightsListBox";
            this.weightsListBox.Size = new System.Drawing.Size(114, 186);
            this.weightsListBox.TabIndex = 0;
            // 
            // biasTextBox
            // 
            this.biasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biasTextBox.Location = new System.Drawing.Point(88, 211);
            this.biasTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.biasTextBox.Name = "biasTextBox";
            this.biasTextBox.Size = new System.Drawing.Size(114, 19);
            this.biasTextBox.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(88, 234);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(114, 19);
            this.outputTextBox.TabIndex = 2;
            // 
            // biasLabel
            // 
            this.biasLabel.AutoSize = true;
            this.biasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biasLabel.Location = new System.Drawing.Point(57, 214);
            this.biasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.biasLabel.Name = "biasLabel";
            this.biasLabel.Size = new System.Drawing.Size(27, 13);
            this.biasLabel.TabIndex = 0;
            this.biasLabel.Text = "Bias";
            // 
            // weightsLabel
            // 
            this.weightsLabel.AutoSize = true;
            this.weightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightsLabel.Location = new System.Drawing.Point(38, 21);
            this.weightsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightsLabel.Name = "weightsLabel";
            this.weightsLabel.Size = new System.Drawing.Size(46, 13);
            this.weightsLabel.TabIndex = 0;
            this.weightsLabel.Text = "Weights";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(45, 237);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Output";
            // 
            // networkViewGroupBox
            // 
            this.networkViewGroupBox.Controls.Add(this.networkTreeView);
            this.networkViewGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkViewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkViewGroupBox.Location = new System.Drawing.Point(2, 51);
            this.networkViewGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.networkViewGroupBox.Name = "networkViewGroupBox";
            this.networkViewGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.networkViewGroupBox.Size = new System.Drawing.Size(356, 272);
            this.networkViewGroupBox.TabIndex = 0;
            this.networkViewGroupBox.TabStop = false;
            this.networkViewGroupBox.Text = "Network View";
            // 
            // networkTreeView
            // 
            this.networkTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkTreeView.Location = new System.Drawing.Point(2, 18);
            this.networkTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.networkTreeView.Name = "networkTreeView";
            this.networkTreeView.Size = new System.Drawing.Size(352, 252);
            this.networkTreeView.TabIndex = 0;
            this.networkTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.networkTreeView_NodeMouseClick);
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
            this.titleLabel.Text = "Artificial Neural Network Structure";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ANNClassificationModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ANNClassificationModelControl";
            this.Size = new System.Drawing.Size(600, 325);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.modelTableLayoutPanel.PerformLayout();
            this.neuronInfoGroupBox.ResumeLayout(false);
            this.neuronInfoGroupBox.PerformLayout();
            this.networkViewGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel modelTableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox neuronInfoGroupBox;
        private System.Windows.Forms.ListBox weightsListBox;
        private System.Windows.Forms.TextBox biasTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label biasLabel;
        private System.Windows.Forms.Label weightsLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox networkViewGroupBox;
        private System.Windows.Forms.TreeView networkTreeView;
    }
}
