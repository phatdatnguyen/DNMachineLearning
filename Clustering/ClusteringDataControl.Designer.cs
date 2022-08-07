namespace DNMachineLearning.Clustering
{
    partial class ClusteringDataControl
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
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataVisualizeButton = new System.Windows.Forms.Button();
            this.dataHasHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataLabel = new System.Windows.Forms.Label();
            this.loadDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableLayoutPanel
            // 
            this.dataTableLayoutPanel.ColumnCount = 1;
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.dataTableLayoutPanel.Controls.Add(this.dataDataGridView, 0, 1);
            this.dataTableLayoutPanel.Controls.Add(this.dataPanel, 0, 0);
            this.dataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.dataTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            this.dataTableLayoutPanel.RowCount = 2;
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(600, 325);
            this.dataTableLayoutPanel.TabIndex = 1;
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
            this.dataDataGridView.Size = new System.Drawing.Size(594, 219);
            this.dataDataGridView.TabIndex = 1;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataVisualizeButton);
            this.dataPanel.Controls.Add(this.dataHasHeadersCheckBox);
            this.dataPanel.Controls.Add(this.loadButton);
            this.dataPanel.Controls.Add(this.dataLabel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(2, 2);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(596, 96);
            this.dataPanel.TabIndex = 1;
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
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(9, 65);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(56, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.toolTip.SetToolTip(this.loadButton, "- Data must include one or more columns.\r\n- All columns must contain numerical da" +
        "ta.");
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
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
            // ClusteringDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClusteringDataControl";
            this.Size = new System.Drawing.Size(600, 325);
            this.dataTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dataTableLayoutPanel;
        private System.Windows.Forms.DataGridView dataDataGridView;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button dataVisualizeButton;
        private System.Windows.Forms.CheckBox dataHasHeadersCheckBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.OpenFileDialog loadDataFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
