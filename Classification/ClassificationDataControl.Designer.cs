namespace DNMachineLearning.Classification
{
    partial class ClassificationDataControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassificationDataControl));
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.testDatasetDataGridView = new System.Windows.Forms.DataGridView();
            this.testDatasetPanel = new System.Windows.Forms.Panel();
            this.testDatasetHasHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.testDatasetLoadButton = new System.Windows.Forms.Button();
            this.testDatasetVisualizeButton = new System.Windows.Forms.Button();
            this.testDatasetLabel = new System.Windows.Forms.Label();
            this.trainingDatasetPanel = new System.Windows.Forms.Panel();
            this.trainingDatasetHasHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.trainingDatasetLoadButton = new System.Windows.Forms.Button();
            this.trainingDatasetVisualizeButton = new System.Windows.Forms.Button();
            this.trainingDatasetLabel = new System.Windows.Forms.Label();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            this.trainingDatasetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataHasHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.dataVisualizeButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.splitPanel = new System.Windows.Forms.Panel();
            this.splitLabel = new System.Windows.Forms.Label();
            this.splitButton = new System.Windows.Forms.Button();
            this.splitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataLabel = new System.Windows.Forms.Label();
            this.loadDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).BeginInit();
            this.testDatasetPanel.SuspendLayout();
            this.trainingDatasetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDatasetDataGridView)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.splitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableLayoutPanel
            // 
            this.dataTableLayoutPanel.ColumnCount = 3;
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.dataTableLayoutPanel.Controls.Add(this.testDatasetDataGridView, 2, 1);
            this.dataTableLayoutPanel.Controls.Add(this.testDatasetPanel, 2, 0);
            this.dataTableLayoutPanel.Controls.Add(this.trainingDatasetPanel, 1, 0);
            this.dataTableLayoutPanel.Controls.Add(this.dataDataGridView, 0, 1);
            this.dataTableLayoutPanel.Controls.Add(this.trainingDatasetDataGridView, 1, 1);
            this.dataTableLayoutPanel.Controls.Add(this.dataPanel, 0, 0);
            this.dataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.dataTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            this.dataTableLayoutPanel.RowCount = 2;
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(600, 325);
            this.dataTableLayoutPanel.TabIndex = 0;
            // 
            // testDatasetDataGridView
            // 
            this.testDatasetDataGridView.AllowUserToAddRows = false;
            this.testDatasetDataGridView.AllowUserToDeleteRows = false;
            this.testDatasetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDatasetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDatasetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.testDatasetDataGridView.Location = new System.Drawing.Point(405, 103);
            this.testDatasetDataGridView.Name = "testDatasetDataGridView";
            this.testDatasetDataGridView.ReadOnly = true;
            this.testDatasetDataGridView.RowHeadersWidth = 51;
            this.testDatasetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testDatasetDataGridView.Size = new System.Drawing.Size(192, 219);
            this.testDatasetDataGridView.TabIndex = 4;
            // 
            // testDatasetPanel
            // 
            this.testDatasetPanel.Controls.Add(this.testDatasetHasHeadersCheckBox);
            this.testDatasetPanel.Controls.Add(this.testDatasetLoadButton);
            this.testDatasetPanel.Controls.Add(this.testDatasetVisualizeButton);
            this.testDatasetPanel.Controls.Add(this.testDatasetLabel);
            this.testDatasetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDatasetPanel.Location = new System.Drawing.Point(404, 2);
            this.testDatasetPanel.Margin = new System.Windows.Forms.Padding(2);
            this.testDatasetPanel.Name = "testDatasetPanel";
            this.testDatasetPanel.Size = new System.Drawing.Size(194, 96);
            this.testDatasetPanel.TabIndex = 3;
            // 
            // testDatasetHasHeadersCheckBox
            // 
            this.testDatasetHasHeadersCheckBox.AutoSize = true;
            this.testDatasetHasHeadersCheckBox.Checked = true;
            this.testDatasetHasHeadersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testDatasetHasHeadersCheckBox.Location = new System.Drawing.Point(7, 43);
            this.testDatasetHasHeadersCheckBox.Name = "testDatasetHasHeadersCheckBox";
            this.testDatasetHasHeadersCheckBox.Size = new System.Drawing.Size(84, 17);
            this.testDatasetHasHeadersCheckBox.TabIndex = 0;
            this.testDatasetHasHeadersCheckBox.Text = "has headers";
            this.testDatasetHasHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // testDatasetLoadButton
            // 
            this.testDatasetLoadButton.Location = new System.Drawing.Point(7, 65);
            this.testDatasetLoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.testDatasetLoadButton.Name = "testDatasetLoadButton";
            this.testDatasetLoadButton.Size = new System.Drawing.Size(56, 23);
            this.testDatasetLoadButton.TabIndex = 1;
            this.testDatasetLoadButton.Text = "Load";
            this.toolTip.SetToolTip(this.testDatasetLoadButton, resources.GetString("testDatasetLoadButton.ToolTip"));
            this.testDatasetLoadButton.UseVisualStyleBackColor = true;
            this.testDatasetLoadButton.Click += new System.EventHandler(this.testDatasetLoadButton_Click);
            // 
            // testDatasetVisualizeButton
            // 
            this.testDatasetVisualizeButton.Enabled = false;
            this.testDatasetVisualizeButton.Location = new System.Drawing.Point(67, 65);
            this.testDatasetVisualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.testDatasetVisualizeButton.Name = "testDatasetVisualizeButton";
            this.testDatasetVisualizeButton.Size = new System.Drawing.Size(75, 23);
            this.testDatasetVisualizeButton.TabIndex = 2;
            this.testDatasetVisualizeButton.Text = "Visualize...";
            this.testDatasetVisualizeButton.UseVisualStyleBackColor = true;
            this.testDatasetVisualizeButton.Click += new System.EventHandler(this.testDatasetVisualizeButton_Click);
            // 
            // testDatasetLabel
            // 
            this.testDatasetLabel.AutoSize = true;
            this.testDatasetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testDatasetLabel.Location = new System.Drawing.Point(3, 7);
            this.testDatasetLabel.Name = "testDatasetLabel";
            this.testDatasetLabel.Size = new System.Drawing.Size(113, 20);
            this.testDatasetLabel.TabIndex = 2;
            this.testDatasetLabel.Text = "Test Dataset";
            // 
            // trainingDatasetPanel
            // 
            this.trainingDatasetPanel.Controls.Add(this.trainingDatasetHasHeadersCheckBox);
            this.trainingDatasetPanel.Controls.Add(this.trainingDatasetLoadButton);
            this.trainingDatasetPanel.Controls.Add(this.trainingDatasetVisualizeButton);
            this.trainingDatasetPanel.Controls.Add(this.trainingDatasetLabel);
            this.trainingDatasetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingDatasetPanel.Location = new System.Drawing.Point(206, 2);
            this.trainingDatasetPanel.Margin = new System.Windows.Forms.Padding(2);
            this.trainingDatasetPanel.Name = "trainingDatasetPanel";
            this.trainingDatasetPanel.Size = new System.Drawing.Size(194, 96);
            this.trainingDatasetPanel.TabIndex = 2;
            // 
            // trainingDatasetHasHeadersCheckBox
            // 
            this.trainingDatasetHasHeadersCheckBox.AutoSize = true;
            this.trainingDatasetHasHeadersCheckBox.Checked = true;
            this.trainingDatasetHasHeadersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trainingDatasetHasHeadersCheckBox.Location = new System.Drawing.Point(7, 43);
            this.trainingDatasetHasHeadersCheckBox.Name = "trainingDatasetHasHeadersCheckBox";
            this.trainingDatasetHasHeadersCheckBox.Size = new System.Drawing.Size(84, 17);
            this.trainingDatasetHasHeadersCheckBox.TabIndex = 3;
            this.trainingDatasetHasHeadersCheckBox.Text = "has headers";
            this.trainingDatasetHasHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // trainingDatasetLoadButton
            // 
            this.trainingDatasetLoadButton.Location = new System.Drawing.Point(7, 65);
            this.trainingDatasetLoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.trainingDatasetLoadButton.Name = "trainingDatasetLoadButton";
            this.trainingDatasetLoadButton.Size = new System.Drawing.Size(56, 23);
            this.trainingDatasetLoadButton.TabIndex = 0;
            this.trainingDatasetLoadButton.Text = "Load";
            this.toolTip.SetToolTip(this.trainingDatasetLoadButton, resources.GetString("trainingDatasetLoadButton.ToolTip"));
            this.trainingDatasetLoadButton.UseVisualStyleBackColor = true;
            this.trainingDatasetLoadButton.Click += new System.EventHandler(this.trainingDatasetLoadButton_Click);
            // 
            // trainingDatasetVisualizeButton
            // 
            this.trainingDatasetVisualizeButton.Enabled = false;
            this.trainingDatasetVisualizeButton.Location = new System.Drawing.Point(67, 65);
            this.trainingDatasetVisualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.trainingDatasetVisualizeButton.Name = "trainingDatasetVisualizeButton";
            this.trainingDatasetVisualizeButton.Size = new System.Drawing.Size(75, 23);
            this.trainingDatasetVisualizeButton.TabIndex = 1;
            this.trainingDatasetVisualizeButton.Text = "Visualize...";
            this.trainingDatasetVisualizeButton.UseVisualStyleBackColor = true;
            this.trainingDatasetVisualizeButton.Click += new System.EventHandler(this.trainingDatasetVisualizeButton_Click);
            // 
            // trainingDatasetLabel
            // 
            this.trainingDatasetLabel.AutoSize = true;
            this.trainingDatasetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingDatasetLabel.Location = new System.Drawing.Point(3, 7);
            this.trainingDatasetLabel.Name = "trainingDatasetLabel";
            this.trainingDatasetLabel.Size = new System.Drawing.Size(142, 20);
            this.trainingDatasetLabel.TabIndex = 2;
            this.trainingDatasetLabel.Text = "Training Dataset";
            // 
            // dataDataGridView
            // 
            this.dataDataGridView.AllowUserToAddRows = false;
            this.dataDataGridView.AllowUserToDeleteRows = false;
            this.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataDataGridView.Location = new System.Drawing.Point(3, 103);
            this.dataDataGridView.Name = "dataDataGridView";
            this.dataDataGridView.ReadOnly = true;
            this.dataDataGridView.RowHeadersWidth = 51;
            this.dataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDataGridView.Size = new System.Drawing.Size(198, 219);
            this.dataDataGridView.TabIndex = 1;
            // 
            // trainingDatasetDataGridView
            // 
            this.trainingDatasetDataGridView.AllowUserToAddRows = false;
            this.trainingDatasetDataGridView.AllowUserToDeleteRows = false;
            this.trainingDatasetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingDatasetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingDatasetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.trainingDatasetDataGridView.Location = new System.Drawing.Point(207, 103);
            this.trainingDatasetDataGridView.Name = "trainingDatasetDataGridView";
            this.trainingDatasetDataGridView.ReadOnly = true;
            this.trainingDatasetDataGridView.RowHeadersWidth = 51;
            this.trainingDatasetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainingDatasetDataGridView.Size = new System.Drawing.Size(192, 219);
            this.trainingDatasetDataGridView.TabIndex = 1;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataHasHeadersCheckBox);
            this.dataPanel.Controls.Add(this.dataVisualizeButton);
            this.dataPanel.Controls.Add(this.loadButton);
            this.dataPanel.Controls.Add(this.splitPanel);
            this.dataPanel.Controls.Add(this.dataLabel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(2, 2);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(200, 96);
            this.dataPanel.TabIndex = 1;
            // 
            // dataHasHeadersCheckBox
            // 
            this.dataHasHeadersCheckBox.AutoSize = true;
            this.dataHasHeadersCheckBox.Checked = true;
            this.dataHasHeadersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dataHasHeadersCheckBox.Location = new System.Drawing.Point(9, 43);
            this.dataHasHeadersCheckBox.Name = "dataHasHeadersCheckBox";
            this.dataHasHeadersCheckBox.Size = new System.Drawing.Size(84, 17);
            this.dataHasHeadersCheckBox.TabIndex = 0;
            this.dataHasHeadersCheckBox.Text = "has headers";
            this.dataHasHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataVisualizeButton
            // 
            this.dataVisualizeButton.Enabled = false;
            this.dataVisualizeButton.Location = new System.Drawing.Point(69, 65);
            this.dataVisualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.dataVisualizeButton.Name = "dataVisualizeButton";
            this.dataVisualizeButton.Size = new System.Drawing.Size(75, 23);
            this.dataVisualizeButton.TabIndex = 2;
            this.dataVisualizeButton.Text = "Visualize...";
            this.dataVisualizeButton.UseVisualStyleBackColor = true;
            this.dataVisualizeButton.Click += new System.EventHandler(this.dataVisualizeButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(9, 65);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(56, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.toolTip.SetToolTip(this.loadButton, resources.GetString("loadButton.ToolTip"));
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // splitPanel
            // 
            this.splitPanel.Controls.Add(this.splitLabel);
            this.splitPanel.Controls.Add(this.splitButton);
            this.splitPanel.Controls.Add(this.splitNumericUpDown);
            this.splitPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitPanel.Location = new System.Drawing.Point(50, 0);
            this.splitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.Size = new System.Drawing.Size(150, 96);
            this.splitPanel.TabIndex = 3;
            // 
            // splitLabel
            // 
            this.splitLabel.AutoSize = true;
            this.splitLabel.Location = new System.Drawing.Point(18, 10);
            this.splitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.splitLabel.Name = "splitLabel";
            this.splitLabel.Size = new System.Drawing.Size(79, 13);
            this.splitLabel.TabIndex = 3;
            this.splitLabel.Text = "test dataset (%)";
            // 
            // splitButton
            // 
            this.splitButton.Enabled = false;
            this.splitButton.Location = new System.Drawing.Point(83, 37);
            this.splitButton.Margin = new System.Windows.Forms.Padding(2);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(60, 23);
            this.splitButton.TabIndex = 1;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // splitNumericUpDown
            // 
            this.splitNumericUpDown.Enabled = false;
            this.splitNumericUpDown.Location = new System.Drawing.Point(98, 8);
            this.splitNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.splitNumericUpDown.Name = "splitNumericUpDown";
            this.splitNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.splitNumericUpDown.TabIndex = 0;
            this.splitNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(5, 7);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(48, 20);
            this.dataLabel.TabIndex = 0;
            this.dataLabel.Text = "Data";
            // 
            // loadDataFileDialog
            // 
            this.loadDataFileDialog.FileName = "*.csv";
            this.loadDataFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            // 
            // ClassificationDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClassificationDataControl";
            this.Size = new System.Drawing.Size(600, 325);
            this.dataTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).EndInit();
            this.testDatasetPanel.ResumeLayout(false);
            this.testDatasetPanel.PerformLayout();
            this.trainingDatasetPanel.ResumeLayout(false);
            this.trainingDatasetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDatasetDataGridView)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.splitPanel.ResumeLayout(false);
            this.splitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dataTableLayoutPanel;
        private System.Windows.Forms.DataGridView testDatasetDataGridView;
        private System.Windows.Forms.Panel testDatasetPanel;
        private System.Windows.Forms.Button testDatasetVisualizeButton;
        private System.Windows.Forms.Label testDatasetLabel;
        private System.Windows.Forms.Panel trainingDatasetPanel;
        private System.Windows.Forms.Button trainingDatasetVisualizeButton;
        private System.Windows.Forms.Label trainingDatasetLabel;
        private System.Windows.Forms.DataGridView dataDataGridView;
        private System.Windows.Forms.DataGridView trainingDatasetDataGridView;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button dataVisualizeButton;
        private System.Windows.Forms.Panel splitPanel;
        private System.Windows.Forms.Label splitLabel;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.NumericUpDown splitNumericUpDown;
        private System.Windows.Forms.Button trainingDatasetLoadButton;
        private System.Windows.Forms.Button testDatasetLoadButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog loadDataFileDialog;
        private System.Windows.Forms.CheckBox testDatasetHasHeadersCheckBox;
        private System.Windows.Forms.CheckBox trainingDatasetHasHeadersCheckBox;
        private System.Windows.Forms.CheckBox dataHasHeadersCheckBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
