namespace DNMachineLearning.Regression
{
    partial class RegressionForm
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
            this.regressionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
            this.modelTestingPanel = new System.Windows.Forms.Panel();
            this.modelTestingLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.makePredictionPanel = new System.Windows.Forms.Panel();
            this.makePredictionLabel = new System.Windows.Forms.Label();
            this.predictionPanel = new System.Windows.Forms.Panel();
            this.predictRegressionControl = new DNMachineLearning.Regression.PredictRegressionControl();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataControl = new DNMachineLearning.Regression.RegressionDataControl();
            this.testPanel = new System.Windows.Forms.Panel();
            this.testRegressionControl = new DNMachineLearning.Regression.TestRegressionControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.regressionTaskPanel = new System.Windows.Forms.Panel();
            this.regressionTableLayoutPanel.SuspendLayout();
            this.loadDataPanel.SuspendLayout();
            this.chooseModelPanel.SuspendLayout();
            this.modelTrainingPanel.SuspendLayout();
            this.modelTestingPanel.SuspendLayout();
            this.makePredictionPanel.SuspendLayout();
            this.predictionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.testPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.regressionTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regressionTableLayoutPanel
            // 
            this.regressionTableLayoutPanel.AutoSize = true;
            this.regressionTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.regressionTableLayoutPanel.ColumnCount = 2;
            this.regressionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.regressionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.regressionTableLayoutPanel.Controls.Add(this.loadDataPanel, 0, 0);
            this.regressionTableLayoutPanel.Controls.Add(this.chooseModelPanel, 0, 1);
            this.regressionTableLayoutPanel.Controls.Add(this.modelPanel, 1, 1);
            this.regressionTableLayoutPanel.Controls.Add(this.modelTrainingPanel, 0, 2);
            this.regressionTableLayoutPanel.Controls.Add(this.trainingPanel, 1, 2);
            this.regressionTableLayoutPanel.Controls.Add(this.modelTestingPanel, 0, 3);
            this.regressionTableLayoutPanel.Controls.Add(this.makePredictionPanel, 0, 4);
            this.regressionTableLayoutPanel.Controls.Add(this.predictionPanel, 1, 4);
            this.regressionTableLayoutPanel.Controls.Add(this.dataPanel, 1, 0);
            this.regressionTableLayoutPanel.Controls.Add(this.testPanel, 1, 3);
            this.regressionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.regressionTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.regressionTableLayoutPanel.Name = "regressionTableLayoutPanel";
            this.regressionTableLayoutPanel.RowCount = 5;
            this.regressionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.regressionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.regressionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.regressionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.regressionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.regressionTableLayoutPanel.Size = new System.Drawing.Size(785, 1214);
            this.regressionTableLayoutPanel.TabIndex = 0;
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
            // modelTestingPanel
            // 
            this.modelTestingPanel.Controls.Add(this.modelTestingLabel);
            this.modelTestingPanel.Controls.Add(this.testButton);
            this.modelTestingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTestingPanel.Location = new System.Drawing.Point(6, 547);
            this.modelTestingPanel.Name = "modelTestingPanel";
            this.modelTestingPanel.Size = new System.Drawing.Size(164, 326);
            this.modelTestingPanel.TabIndex = 6;
            // 
            // modelTestingLabel
            // 
            this.modelTestingLabel.AutoSize = true;
            this.modelTestingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTestingLabel.Location = new System.Drawing.Point(9, 9);
            this.modelTestingLabel.Name = "modelTestingLabel";
            this.modelTestingLabel.Size = new System.Drawing.Size(121, 20);
            this.modelTestingLabel.TabIndex = 1;
            this.modelTestingLabel.Text = "Model Testing";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(20, 148);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(120, 23);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test model";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // makePredictionPanel
            // 
            this.makePredictionPanel.Controls.Add(this.makePredictionLabel);
            this.makePredictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makePredictionPanel.Location = new System.Drawing.Point(6, 882);
            this.makePredictionPanel.Name = "makePredictionPanel";
            this.makePredictionPanel.Size = new System.Drawing.Size(164, 326);
            this.makePredictionPanel.TabIndex = 8;
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
            this.predictionPanel.Controls.Add(this.predictRegressionControl);
            this.predictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictionPanel.Location = new System.Drawing.Point(179, 882);
            this.predictionPanel.Name = "predictionPanel";
            this.predictionPanel.Size = new System.Drawing.Size(600, 326);
            this.predictionPanel.TabIndex = 9;
            // 
            // predictRegressionControl
            // 
            this.predictRegressionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictRegressionControl.Location = new System.Drawing.Point(0, 0);
            this.predictRegressionControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.predictRegressionControl.Name = "predictRegressionControl";
            this.predictRegressionControl.Size = new System.Drawing.Size(600, 326);
            this.predictRegressionControl.TabIndex = 0;
            this.predictRegressionControl.Visible = false;
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
            this.dataControl.DataLoaded += new DNMachineLearning.Regression.RegressionDataControl.DataLoadedEventHandler(this.dataControl_DataLoaded);
            this.dataControl.TrainingDataLoaded += new DNMachineLearning.Regression.RegressionDataControl.TrainingDataLoadedEventHandler(this.dataControl_TrainingDataLoaded);
            this.dataControl.TestDataLoaded += new DNMachineLearning.Regression.RegressionDataControl.TestDataLoadedEventHandler(this.dataControl_TestDataLoaded);
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.testRegressionControl);
            this.testPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testPanel.Location = new System.Drawing.Point(178, 546);
            this.testPanel.Margin = new System.Windows.Forms.Padding(2);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(602, 328);
            this.testPanel.TabIndex = 7;
            // 
            // testRegressionControl
            // 
            this.testRegressionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testRegressionControl.Location = new System.Drawing.Point(0, 0);
            this.testRegressionControl.Margin = new System.Windows.Forms.Padding(2);
            this.testRegressionControl.Name = "testRegressionControl";
            this.testRegressionControl.Size = new System.Drawing.Size(602, 328);
            this.testRegressionControl.TabIndex = 0;
            this.testRegressionControl.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(802, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Status:";
            // 
            // regressionTaskPanel
            // 
            this.regressionTaskPanel.AutoScroll = true;
            this.regressionTaskPanel.AutoSize = true;
            this.regressionTaskPanel.Controls.Add(this.regressionTableLayoutPanel);
            this.regressionTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regressionTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.regressionTaskPanel.Name = "regressionTaskPanel";
            this.regressionTaskPanel.Size = new System.Drawing.Size(802, 435);
            this.regressionTaskPanel.TabIndex = 0;
            // 
            // RegressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(802, 457);
            this.Controls.Add(this.regressionTaskPanel);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(818, 493);
            this.Name = "RegressionForm";
            this.ShowIcon = false;
            this.Text = "Regression Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegressionForm_FormClosing);
            this.Resize += new System.EventHandler(this.ClassificationForm_Resize);
            this.regressionTableLayoutPanel.ResumeLayout(false);
            this.loadDataPanel.ResumeLayout(false);
            this.loadDataPanel.PerformLayout();
            this.chooseModelPanel.ResumeLayout(false);
            this.chooseModelPanel.PerformLayout();
            this.modelTrainingPanel.ResumeLayout(false);
            this.modelTrainingPanel.PerformLayout();
            this.modelTestingPanel.ResumeLayout(false);
            this.modelTestingPanel.PerformLayout();
            this.makePredictionPanel.ResumeLayout(false);
            this.makePredictionPanel.PerformLayout();
            this.predictionPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.testPanel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.regressionTaskPanel.ResumeLayout(false);
            this.regressionTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel regressionTableLayoutPanel;
        private System.Windows.Forms.Panel loadDataPanel;
        private System.Windows.Forms.Label loadDataLabel;
        private System.Windows.Forms.Panel chooseModelPanel;
        private System.Windows.Forms.Panel modelPanel;
        private System.Windows.Forms.Label chooseModelLabel;
        private System.Windows.Forms.Button chooseModelButton;
        private System.Windows.Forms.Panel modelTrainingPanel;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Label modelTrainingLabel;
        private System.Windows.Forms.Panel trainingPanel;
        private System.Windows.Forms.Panel modelTestingPanel;
        private System.Windows.Forms.Label modelTestingLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Panel makePredictionPanel;
        private System.Windows.Forms.Label makePredictionLabel;
        private System.Windows.Forms.Panel predictionPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel regressionTaskPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Panel testPanel;
        private PredictRegressionControl predictRegressionControl;
        private RegressionDataControl dataControl;
        private TestRegressionControl testRegressionControl;
    }
}