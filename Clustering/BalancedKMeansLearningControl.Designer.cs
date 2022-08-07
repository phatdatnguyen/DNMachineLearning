namespace DNMachineLearning.Clustering
{
    partial class BalancedKMeansLearningControl
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
            this.KNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.MaxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxIterationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // KNumericUpDown
            // 
            this.KNumericUpDown.Location = new System.Drawing.Point(104, 55);
            this.KNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KNumericUpDown.Name = "KNumericUpDown";
            this.KNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.KNumericUpDown.TabIndex = 0;
            this.KNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(76, 58);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(22, 13);
            this.kLabel.TabIndex = 0;
            this.kLabel.Text = "k =";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(31, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(148, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Balanced k-Mean";
            // 
            // MaxIterationNumericUpDown
            // 
            this.MaxIterationNumericUpDown.Location = new System.Drawing.Point(104, 81);
            this.MaxIterationNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Name = "MaxIterationNumericUpDown";
            this.MaxIterationNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxIterationNumericUpDown.TabIndex = 1;
            this.MaxIterationNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // maxIterationLabel
            // 
            this.maxIterationLabel.AutoSize = true;
            this.maxIterationLabel.Location = new System.Drawing.Point(31, 83);
            this.maxIterationLabel.Name = "maxIterationLabel";
            this.maxIterationLabel.Size = new System.Drawing.Size(67, 13);
            this.maxIterationLabel.TabIndex = 0;
            this.maxIterationLabel.Text = "Max iteration";
            // 
            // BalancedKMeansLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaxIterationNumericUpDown);
            this.Controls.Add(this.maxIterationLabel);
            this.Controls.Add(this.KNumericUpDown);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BalancedKMeansLearningControl";
            this.Size = new System.Drawing.Size(210, 124);
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown KNumericUpDown;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.NumericUpDown MaxIterationNumericUpDown;
        private System.Windows.Forms.Label maxIterationLabel;
    }
}
