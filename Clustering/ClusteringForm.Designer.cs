namespace DNMachineLearning.Clustering
{
    partial class ClusteringForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clusteringTaskPanel = new System.Windows.Forms.Panel();
            this.clusteringTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loadDataPanel = new System.Windows.Forms.Panel();
            this.loadDataLabel = new System.Windows.Forms.Label();
            this.chooseModelPanel = new System.Windows.Forms.Panel();
            this.chooseModelButton = new System.Windows.Forms.Button();
            this.chooseModelLabel = new System.Windows.Forms.Label();
            this.modelPanel = new System.Windows.Forms.Panel();
            this.modelTrainingPanel = new System.Windows.Forms.Panel();
            this.trainButton = new System.Windows.Forms.Button();
            this.modelTrainingLabel = new System.Windows.Forms.Label();
            this.trainingPanel = new System.Windows.Forms.Panel();
            this.makePredictionPanel = new System.Windows.Forms.Panel();
            this.makePredictionLabel = new System.Windows.Forms.Label();
            this.predictionPanel = new System.Windows.Forms.Panel();
            this.predictClusteringControl = new DNMachineLearning.Clustering.PredictClusteringControl();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataControl = new DNMachineLearning.Clustering.ClusteringDataControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clusteringTaskPanel.SuspendLayout();
            this.clusteringTableLayoutPanel.SuspendLayout();
            this.loadDataPanel.SuspendLayout();
            this.chooseModelPanel.SuspendLayout();
            this.modelTrainingPanel.SuspendLayout();
            this.makePredictionPanel.SuspendLayout();
            this.predictionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clusteringTaskPanel
            // 
            this.clusteringTaskPanel.AutoScroll = true;
            this.clusteringTaskPanel.AutoSize = true;
            this.clusteringTaskPanel.Controls.Add(this.clusteringTableLayoutPanel);
            this.clusteringTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clusteringTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.clusteringTaskPanel.Name = "clusteringTaskPanel";
            this.clusteringTaskPanel.Size = new System.Drawing.Size(802, 435);
            this.clusteringTaskPanel.TabIndex = 1;
            // 
            // clusteringTableLayoutPanel
            // 
            this.clusteringTableLayoutPanel.AutoSize = true;
            this.clusteringTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.clusteringTableLayoutPanel.ColumnCount = 2;
            this.clusteringTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.clusteringTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clusteringTableLayoutPanel.Controls.Add(this.loadDataPanel, 0, 0);
            this.clusteringTableLayoutPanel.Controls.Add(this.chooseModelPanel, 0, 1);
            this.clusteringTableLayoutPanel.Controls.Add(this.modelPanel, 1, 1);
            this.clusteringTableLayoutPanel.Controls.Add(this.modelTrainingPanel, 0, 2);
            this.clusteringTableLayoutPanel.Controls.Add(this.trainingPanel, 1, 2);
            this.clusteringTableLayoutPanel.Controls.Add(this.makePredictionPanel, 0, 3);
            this.clusteringTableLayoutPanel.Controls.Add(this.predictionPanel, 1, 3);
            this.clusteringTableLayoutPanel.Controls.Add(this.dataPanel, 1, 0);
            this.clusteringTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clusteringTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.clusteringTableLayoutPanel.Name = "clusteringTableLayoutPanel";
            this.clusteringTableLayoutPanel.RowCount = 4;
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.clusteringTableLayoutPanel.Size = new System.Drawing.Size(785, 879);
            this.clusteringTableLayoutPanel.TabIndex = 0;
            // 
            // loadDataPanel
            // 
            this.loadDataPanel.Controls.Add(this.loadDataLabel);
            this.loadDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadDataPanel.Location = new System.Drawing.Point(6, 6);
            this.loadDataPanel.Name = "loadDataPanel";
            this.loadDataPanel.Size = new System.Drawing.Size(164, 326);
            this.loadDataPanel.TabIndex = 0;
            // 
            // loadDataLabel
            // 
            this.loadDataLabel.AutoSize = true;
            this.loadDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataLabel.Location = new System.Drawing.Point(9, 6);
            this.loadDataLabel.Name = "loadDataLabel";
            this.loadDataLabel.Size = new System.Drawing.Size(93, 20);
            this.loadDataLabel.TabIndex = 0;
            this.loadDataLabel.Text = "Load Data";
            // 
            // chooseModelPanel
            // 
            this.chooseModelPanel.Controls.Add(this.chooseModelButton);
            this.chooseModelPanel.Controls.Add(this.chooseModelLabel);
            this.chooseModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseModelPanel.Location = new System.Drawing.Point(6, 341);
            this.chooseModelPanel.Name = "chooseModelPanel";
            this.chooseModelPanel.Size = new System.Drawing.Size(164, 94);
            this.chooseModelPanel.TabIndex = 2;
            // 
            // chooseModelButton
            // 
            this.chooseModelButton.Location = new System.Drawing.Point(20, 42);
            this.chooseModelButton.Name = "chooseModelButton";
            this.chooseModelButton.Size = new System.Drawing.Size(120, 23);
            this.chooseModelButton.TabIndex = 2;
            this.chooseModelButton.Text = "Choose model...";
            this.chooseModelButton.UseVisualStyleBackColor = true;
            this.chooseModelButton.Click += new System.EventHandler(this.chooseModelButton_Click);
            // 
            // chooseModelLabel
            // 
            this.chooseModelLabel.AutoSize = true;
            this.chooseModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseModelLabel.Location = new System.Drawing.Point(9, 9);
            this.chooseModelLabel.Name = "chooseModelLabel";
            this.chooseModelLabel.Size = new System.Drawing.Size(57, 20);
            this.chooseModelLabel.TabIndex = 1;
            this.chooseModelLabel.Text = "Model";
            // 
            // modelPanel
            // 
            this.modelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelPanel.Location = new System.Drawing.Point(179, 341);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(600, 94);
            this.modelPanel.TabIndex = 3;
            // 
            // modelTrainingPanel
            // 
            this.modelTrainingPanel.Controls.Add(this.trainButton);
            this.modelTrainingPanel.Controls.Add(this.modelTrainingLabel);
            this.modelTrainingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTrainingPanel.Location = new System.Drawing.Point(6, 444);
            this.modelTrainingPanel.Name = "modelTrainingPanel";
            this.modelTrainingPanel.Size = new System.Drawing.Size(164, 94);
            this.modelTrainingPanel.TabIndex = 4;
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(20, 45);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(120, 23);
            this.trainButton.TabIndex = 1;
            this.trainButton.Text = "Train model";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // modelTrainingLabel
            // 
            this.modelTrainingLabel.AutoSize = true;
            this.modelTrainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTrainingLabel.Location = new System.Drawing.Point(9, 10);
            this.modelTrainingLabel.Name = "modelTrainingLabel";
            this.modelTrainingLabel.Size = new System.Drawing.Size(126, 20);
            this.modelTrainingLabel.TabIndex = 0;
            this.modelTrainingLabel.Text = "Model Training";
            // 
            // trainingPanel
            // 
            this.trainingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingPanel.Location = new System.Drawing.Point(179, 444);
            this.trainingPanel.Name = "trainingPanel";
            this.trainingPanel.Size = new System.Drawing.Size(600, 94);
            this.trainingPanel.TabIndex = 5;
            // 
            // makePredictionPanel
            // 
            this.makePredictionPanel.Controls.Add(this.makePredictionLabel);
            this.makePredictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makePredictionPanel.Location = new System.Drawing.Point(6, 547);
            this.makePredictionPanel.Name = "makePredictionPanel";
            this.makePredictionPanel.Size = new System.Drawing.Size(164, 326);
            this.makePredictionPanel.TabIndex = 6;
            // 
            // makePredictionLabel
            // 
            this.makePredictionLabel.AutoSize = true;
            this.makePredictionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePredictionLabel.Location = new System.Drawing.Point(9, 8);
            this.makePredictionLabel.Name = "makePredictionLabel";
            this.makePredictionLabel.Size = new System.Drawing.Size(137, 20);
            this.makePredictionLabel.TabIndex = 0;
            this.makePredictionLabel.Text = "Make Prediction";
            // 
            // predictionPanel
            // 
            this.predictionPanel.Controls.Add(this.predictClusteringControl);
            this.predictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictionPanel.Location = new System.Drawing.Point(179, 547);
            this.predictionPanel.Name = "predictionPanel";
            this.predictionPanel.Size = new System.Drawing.Size(600, 326);
            this.predictionPanel.TabIndex = 7;
            // 
            // predictClusteringControl
            // 
            this.predictClusteringControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictClusteringControl.Location = new System.Drawing.Point(0, 0);
            this.predictClusteringControl.Margin = new System.Windows.Forms.Padding(2);
            this.predictClusteringControl.Name = "predictClusteringControl";
            this.predictClusteringControl.Size = new System.Drawing.Size(600, 326);
            this.predictClusteringControl.TabIndex = 0;
            this.predictClusteringControl.Visible = false;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataControl);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(178, 5);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(602, 328);
            this.dataPanel.TabIndex = 1;
            // 
            // dataControl
            // 
            this.dataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataControl.Location = new System.Drawing.Point(0, 0);
            this.dataControl.Margin = new System.Windows.Forms.Padding(2);
            this.dataControl.Name = "dataControl";
            this.dataControl.Size = new System.Drawing.Size(602, 328);
            this.dataControl.TabIndex = 0;
            this.dataControl.DataLoaded += new DNMachineLearning.Clustering.ClusteringDataControl.DataLoadedEventHandler(this.dataControl_DataLoaded);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(802, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Status:";
            // 
            // ClusteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 457);
            this.Controls.Add(this.clusteringTaskPanel);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClusteringForm";
            this.ShowIcon = false;
            this.Text = "Clustering Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClusteringForm_FormClosing);
            this.Resize += new System.EventHandler(this.ClusteringForm_Resize);
            this.clusteringTaskPanel.ResumeLayout(false);
            this.clusteringTaskPanel.PerformLayout();
            this.clusteringTableLayoutPanel.ResumeLayout(false);
            this.loadDataPanel.ResumeLayout(false);
            this.loadDataPanel.PerformLayout();
            this.chooseModelPanel.ResumeLayout(false);
            this.chooseModelPanel.PerformLayout();
            this.modelTrainingPanel.ResumeLayout(false);
            this.modelTrainingPanel.PerformLayout();
            this.makePredictionPanel.ResumeLayout(false);
            this.makePredictionPanel.PerformLayout();
            this.predictionPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel clusteringTaskPanel;
        private System.Windows.Forms.TableLayoutPanel clusteringTableLayoutPanel;
        private System.Windows.Forms.Panel loadDataPanel;
        private System.Windows.Forms.Label loadDataLabel;
        private System.Windows.Forms.Panel chooseModelPanel;
        private System.Windows.Forms.Button chooseModelButton;
        private System.Windows.Forms.Label chooseModelLabel;
        private System.Windows.Forms.Panel modelPanel;
        private System.Windows.Forms.Panel modelTrainingPanel;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Label modelTrainingLabel;
        private System.Windows.Forms.Panel trainingPanel;
        private System.Windows.Forms.Panel makePredictionPanel;
        private System.Windows.Forms.Label makePredictionLabel;
        private System.Windows.Forms.Panel predictionPanel;
        private System.Windows.Forms.Panel dataPanel;
        private ClusteringDataControl dataControl;
        private PredictClusteringControl predictClusteringControl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}