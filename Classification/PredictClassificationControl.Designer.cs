namespace DNMachineLearning.Classification
{
    partial class PredictClassificationControl
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
            this.predictTabControl = new System.Windows.Forms.TabControl();
            this.singlePredictionTabPage = new System.Windows.Forms.TabPage();
            this.singlePredictionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.singlePredictionPanel = new System.Windows.Forms.Panel();
            this.predictButton = new System.Windows.Forms.Button();
            this.singlePredictionDataGridView = new System.Windows.Forms.DataGridView();
            this.datasetPredictionTabPage = new System.Windows.Forms.TabPage();
            this.datasetPredictionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.datasetPredictionPanel = new System.Windows.Forms.Panel();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.dataHasHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.datasetPredictionDataGridView = new System.Windows.Forms.DataGridView();
            this.loadPredictDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.predictTabControl.SuspendLayout();
            this.singlePredictionTabPage.SuspendLayout();
            this.singlePredictionTableLayoutPanel.SuspendLayout();
            this.singlePredictionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singlePredictionDataGridView)).BeginInit();
            this.datasetPredictionTabPage.SuspendLayout();
            this.datasetPredictionTableLayoutPanel.SuspendLayout();
            this.datasetPredictionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPredictionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // predictTabControl
            // 
            this.predictTabControl.Controls.Add(this.singlePredictionTabPage);
            this.predictTabControl.Controls.Add(this.datasetPredictionTabPage);
            this.predictTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictTabControl.Location = new System.Drawing.Point(0, 0);
            this.predictTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.predictTabControl.Name = "predictTabControl";
            this.predictTabControl.SelectedIndex = 0;
            this.predictTabControl.Size = new System.Drawing.Size(600, 325);
            this.predictTabControl.TabIndex = 0;
            // 
            // singlePredictionTabPage
            // 
            this.singlePredictionTabPage.Controls.Add(this.singlePredictionTableLayoutPanel);
            this.singlePredictionTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePredictionTabPage.Location = new System.Drawing.Point(4, 29);
            this.singlePredictionTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.singlePredictionTabPage.Name = "singlePredictionTabPage";
            this.singlePredictionTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.singlePredictionTabPage.Size = new System.Drawing.Size(592, 292);
            this.singlePredictionTabPage.TabIndex = 0;
            this.singlePredictionTabPage.Text = "Single Prediction";
            this.singlePredictionTabPage.UseVisualStyleBackColor = true;
            // 
            // singlePredictionTableLayoutPanel
            // 
            this.singlePredictionTableLayoutPanel.ColumnCount = 1;
            this.singlePredictionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.singlePredictionTableLayoutPanel.Controls.Add(this.singlePredictionPanel, 0, 0);
            this.singlePredictionTableLayoutPanel.Controls.Add(this.singlePredictionDataGridView, 0, 1);
            this.singlePredictionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singlePredictionTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.singlePredictionTableLayoutPanel.Name = "singlePredictionTableLayoutPanel";
            this.singlePredictionTableLayoutPanel.RowCount = 2;
            this.singlePredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.singlePredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.singlePredictionTableLayoutPanel.Size = new System.Drawing.Size(588, 288);
            this.singlePredictionTableLayoutPanel.TabIndex = 0;
            // 
            // singlePredictionPanel
            // 
            this.singlePredictionPanel.Controls.Add(this.predictButton);
            this.singlePredictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singlePredictionPanel.Location = new System.Drawing.Point(2, 2);
            this.singlePredictionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.singlePredictionPanel.Name = "singlePredictionPanel";
            this.singlePredictionPanel.Size = new System.Drawing.Size(584, 36);
            this.singlePredictionPanel.TabIndex = 0;
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(5, 5);
            this.predictButton.Margin = new System.Windows.Forms.Padding(2);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(60, 23);
            this.predictButton.TabIndex = 0;
            this.predictButton.Text = "Predict";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // singlePredictionDataGridView
            // 
            this.singlePredictionDataGridView.AllowUserToAddRows = false;
            this.singlePredictionDataGridView.AllowUserToDeleteRows = false;
            this.singlePredictionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singlePredictionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singlePredictionDataGridView.Location = new System.Drawing.Point(2, 42);
            this.singlePredictionDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.singlePredictionDataGridView.Name = "singlePredictionDataGridView";
            this.singlePredictionDataGridView.RowHeadersWidth = 51;
            this.singlePredictionDataGridView.RowTemplate.Height = 24;
            this.singlePredictionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.singlePredictionDataGridView.Size = new System.Drawing.Size(584, 244);
            this.singlePredictionDataGridView.TabIndex = 1;
            // 
            // datasetPredictionTabPage
            // 
            this.datasetPredictionTabPage.Controls.Add(this.datasetPredictionTableLayoutPanel);
            this.datasetPredictionTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetPredictionTabPage.Location = new System.Drawing.Point(4, 29);
            this.datasetPredictionTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.datasetPredictionTabPage.Name = "datasetPredictionTabPage";
            this.datasetPredictionTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.datasetPredictionTabPage.Size = new System.Drawing.Size(592, 292);
            this.datasetPredictionTabPage.TabIndex = 1;
            this.datasetPredictionTabPage.Text = "Dataset Prediction";
            this.datasetPredictionTabPage.UseVisualStyleBackColor = true;
            // 
            // datasetPredictionTableLayoutPanel
            // 
            this.datasetPredictionTableLayoutPanel.ColumnCount = 1;
            this.datasetPredictionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetPredictionTableLayoutPanel.Controls.Add(this.datasetPredictionPanel, 0, 0);
            this.datasetPredictionTableLayoutPanel.Controls.Add(this.datasetPredictionDataGridView, 0, 1);
            this.datasetPredictionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPredictionTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.datasetPredictionTableLayoutPanel.Name = "datasetPredictionTableLayoutPanel";
            this.datasetPredictionTableLayoutPanel.RowCount = 2;
            this.datasetPredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.datasetPredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetPredictionTableLayoutPanel.Size = new System.Drawing.Size(588, 288);
            this.datasetPredictionTableLayoutPanel.TabIndex = 1;
            // 
            // datasetPredictionPanel
            // 
            this.datasetPredictionPanel.Controls.Add(this.visualizeButton);
            this.datasetPredictionPanel.Controls.Add(this.dataHasHeadersCheckBox);
            this.datasetPredictionPanel.Controls.Add(this.loadButton);
            this.datasetPredictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPredictionPanel.Location = new System.Drawing.Point(2, 2);
            this.datasetPredictionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.datasetPredictionPanel.Name = "datasetPredictionPanel";
            this.datasetPredictionPanel.Size = new System.Drawing.Size(584, 36);
            this.datasetPredictionPanel.TabIndex = 0;
            // 
            // visualizeButton
            // 
            this.visualizeButton.Enabled = false;
            this.visualizeButton.Location = new System.Drawing.Point(295, 5);
            this.visualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(75, 23);
            this.visualizeButton.TabIndex = 2;
            this.visualizeButton.Text = "Visualize...";
            this.visualizeButton.UseVisualStyleBackColor = true;
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // dataHasHeadersCheckBox
            // 
            this.dataHasHeadersCheckBox.AutoSize = true;
            this.dataHasHeadersCheckBox.Checked = true;
            this.dataHasHeadersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dataHasHeadersCheckBox.Location = new System.Drawing.Point(7, 9);
            this.dataHasHeadersCheckBox.Name = "dataHasHeadersCheckBox";
            this.dataHasHeadersCheckBox.Size = new System.Drawing.Size(84, 17);
            this.dataHasHeadersCheckBox.TabIndex = 0;
            this.dataHasHeadersCheckBox.Text = "has headers";
            this.dataHasHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(90, 5);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(200, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load dataset and make prediction...";
            this.toolTip.SetToolTip(this.loadButton, "- Data must include one or more input columns and no output column.\r\n- The number" +
        " of input columns must match the training dataset.\r\n- All input columns must con" +
        "tain numerical data.");
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // datasetPredictionDataGridView
            // 
            this.datasetPredictionDataGridView.AllowUserToAddRows = false;
            this.datasetPredictionDataGridView.AllowUserToDeleteRows = false;
            this.datasetPredictionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetPredictionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPredictionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datasetPredictionDataGridView.Location = new System.Drawing.Point(2, 42);
            this.datasetPredictionDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.datasetPredictionDataGridView.Name = "datasetPredictionDataGridView";
            this.datasetPredictionDataGridView.ReadOnly = true;
            this.datasetPredictionDataGridView.RowHeadersWidth = 51;
            this.datasetPredictionDataGridView.RowTemplate.Height = 24;
            this.datasetPredictionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasetPredictionDataGridView.Size = new System.Drawing.Size(584, 244);
            this.datasetPredictionDataGridView.TabIndex = 1;
            // 
            // loadPredictDataFileDialog
            // 
            this.loadPredictDataFileDialog.FileName = "*.csv";
            this.loadPredictDataFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            this.loadPredictDataFileDialog.Title = "Load Predict Data";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 10;
            this.toolTip.ReshowDelay = 100;
            // 
            // PredictClassificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.predictTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PredictClassificationControl";
            this.Size = new System.Drawing.Size(600, 325);
            this.predictTabControl.ResumeLayout(false);
            this.singlePredictionTabPage.ResumeLayout(false);
            this.singlePredictionTableLayoutPanel.ResumeLayout(false);
            this.singlePredictionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.singlePredictionDataGridView)).EndInit();
            this.datasetPredictionTabPage.ResumeLayout(false);
            this.datasetPredictionTableLayoutPanel.ResumeLayout(false);
            this.datasetPredictionPanel.ResumeLayout(false);
            this.datasetPredictionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPredictionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl predictTabControl;
        private System.Windows.Forms.TabPage singlePredictionTabPage;
        private System.Windows.Forms.TabPage datasetPredictionTabPage;
        private System.Windows.Forms.TableLayoutPanel singlePredictionTableLayoutPanel;
        private System.Windows.Forms.Panel singlePredictionPanel;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.DataGridView singlePredictionDataGridView;
        private System.Windows.Forms.TableLayoutPanel datasetPredictionTableLayoutPanel;
        private System.Windows.Forms.Panel datasetPredictionPanel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView datasetPredictionDataGridView;
        private System.Windows.Forms.OpenFileDialog loadPredictDataFileDialog;
        private System.Windows.Forms.CheckBox dataHasHeadersCheckBox;
        private System.Windows.Forms.Button visualizeButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
