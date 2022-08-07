namespace DNMachineLearning
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryClassificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiclassClassificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.regressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.clusteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.principalComponentAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discriminantAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(1312, 28);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskTrainingToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "&Task";
            // 
            // newTaskTrainingToolStripMenuItem
            // 
            this.newTaskTrainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryClassificationToolStripMenuItem,
            this.multiclassClassificationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.regressionToolStripMenuItem,
            this.toolStripMenuItem4,
            this.clusteringToolStripMenuItem,
            this.toolStripMenuItem5,
            this.principalComponentAnalysisToolStripMenuItem,
            this.discriminantAnalysisToolStripMenuItem});
            this.newTaskTrainingToolStripMenuItem.Name = "newTaskTrainingToolStripMenuItem";
            this.newTaskTrainingToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.newTaskTrainingToolStripMenuItem.Text = "&New task";
            // 
            // binaryClassificationToolStripMenuItem
            // 
            this.binaryClassificationToolStripMenuItem.Name = "binaryClassificationToolStripMenuItem";
            this.binaryClassificationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.binaryClassificationToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.binaryClassificationToolStripMenuItem.Text = "&Binary Classification";
            this.binaryClassificationToolStripMenuItem.Click += new System.EventHandler(this.binaryClassificationToolStripMenuItem_Click);
            // 
            // multiclassClassificationToolStripMenuItem
            // 
            this.multiclassClassificationToolStripMenuItem.Name = "multiclassClassificationToolStripMenuItem";
            this.multiclassClassificationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.multiclassClassificationToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.multiclassClassificationToolStripMenuItem.Text = "&Multiclass Classification";
            this.multiclassClassificationToolStripMenuItem.Click += new System.EventHandler(this.multiclassClassificationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(335, 6);
            // 
            // regressionToolStripMenuItem
            // 
            this.regressionToolStripMenuItem.Name = "regressionToolStripMenuItem";
            this.regressionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.regressionToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.regressionToolStripMenuItem.Text = "&Regression";
            this.regressionToolStripMenuItem.Click += new System.EventHandler(this.regressionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(335, 6);
            // 
            // clusteringToolStripMenuItem
            // 
            this.clusteringToolStripMenuItem.Name = "clusteringToolStripMenuItem";
            this.clusteringToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.clusteringToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.clusteringToolStripMenuItem.Text = "Cl&ustering";
            this.clusteringToolStripMenuItem.Click += new System.EventHandler(this.clusteringToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(335, 6);
            // 
            // principalComponentAnalysisToolStripMenuItem
            // 
            this.principalComponentAnalysisToolStripMenuItem.Name = "principalComponentAnalysisToolStripMenuItem";
            this.principalComponentAnalysisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.principalComponentAnalysisToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.principalComponentAnalysisToolStripMenuItem.Text = "&Principal Component Analysis";
            this.principalComponentAnalysisToolStripMenuItem.Click += new System.EventHandler(this.principalComponentAnalysisToolStripMenuItem_Click);
            // 
            // discriminantAnalysisToolStripMenuItem
            // 
            this.discriminantAnalysisToolStripMenuItem.Name = "discriminantAnalysisToolStripMenuItem";
            this.discriminantAnalysisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.discriminantAnalysisToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.discriminantAnalysisToolStripMenuItem.Text = "&Discriminant Analysis";
            this.discriminantAnalysisToolStripMenuItem.Click += new System.EventHandler(this.discriminantAnalysisToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.loadToolStripMenuItem.Text = "&Load trained model...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.saveToolStripMenuItem.Text = "&Save trained model...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(282, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "*.mlm";
            this.saveFileDialog.Filter = "Machine learning model (*.mlm)|*.mlm";
            this.saveFileDialog.Title = "Save task";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.mlm";
            this.openFileDialog.Filter = "Machine learning model (*.mlm)|*.mlm";
            this.openFileDialog.Title = "Open task";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 713);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Machine Learning";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiclassClassificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clusteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryClassificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem principalComponentAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discriminantAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

