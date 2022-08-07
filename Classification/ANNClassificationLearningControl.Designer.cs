namespace DNMachineLearning.Classification
{
    partial class ANNClassificationLearningControl
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
            this.learningTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.currentIterationGroupBox = new System.Windows.Forms.GroupBox();
            this.toleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.maxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.elapsedTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.maxIterationLabel = new System.Windows.Forms.Label();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.iterationTextBox = new System.Windows.Forms.TextBox();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.nguyenWidrowCheckBox = new System.Windows.Forms.CheckBox();
            this.bayesianRegularizationCheckBox = new System.Windows.Forms.CheckBox();
            this.sameWeightsCheckBox = new System.Windows.Forms.CheckBox();
            this.learningRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningRateLabel = new System.Windows.Forms.Label();
            this.learningMethodComboBox = new System.Windows.Forms.ComboBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.networkLabel = new System.Windows.Forms.Label();
            this.trainingLabel = new System.Windows.Forms.Label();
            this.networkStructureGroupBox = new System.Windows.Forms.GroupBox();
            this.networkStructurePanel = new System.Windows.Forms.Panel();
            this.deleteLayerButton = new System.Windows.Forms.Button();
            this.addLayerButton = new System.Windows.Forms.Button();
            this.networkStructureDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activationFuncionGroupBox = new System.Windows.Forms.GroupBox();
            this.upperLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.upperLimitLabel = new System.Windows.Forms.Label();
            this.lowerLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowerLimitLabel = new System.Windows.Forms.Label();
            this.activationFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.alphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activationFunctionLabel = new System.Windows.Forms.Label();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.workerThreadTimer = new System.Windows.Forms.Timer(this.components);
            this.learningTableLayoutPanel.SuspendLayout();
            this.currentIterationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumericUpDown)).BeginInit();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNumericUpDown)).BeginInit();
            this.networkStructureGroupBox.SuspendLayout();
            this.networkStructurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkStructureDataGridView)).BeginInit();
            this.activationFuncionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // learningTableLayoutPanel
            // 
            this.learningTableLayoutPanel.ColumnCount = 2;
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.learningTableLayoutPanel.Controls.Add(this.currentIterationGroupBox, 1, 3);
            this.learningTableLayoutPanel.Controls.Add(this.learningGroupBox, 0, 3);
            this.learningTableLayoutPanel.Controls.Add(this.networkLabel, 0, 0);
            this.learningTableLayoutPanel.Controls.Add(this.trainingLabel, 0, 2);
            this.learningTableLayoutPanel.Controls.Add(this.networkStructureGroupBox, 0, 1);
            this.learningTableLayoutPanel.Controls.Add(this.activationFuncionGroupBox, 1, 1);
            this.learningTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.learningTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.learningTableLayoutPanel.Name = "learningTableLayoutPanel";
            this.learningTableLayoutPanel.RowCount = 4;
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.learningTableLayoutPanel.Size = new System.Drawing.Size(800, 601);
            this.learningTableLayoutPanel.TabIndex = 0;
            // 
            // currentIterationGroupBox
            // 
            this.currentIterationGroupBox.Controls.Add(this.toleranceNumericUpDown);
            this.currentIterationGroupBox.Controls.Add(this.toleranceLabel);
            this.currentIterationGroupBox.Controls.Add(this.maxIterationNumericUpDown);
            this.currentIterationGroupBox.Controls.Add(this.elapsedTextBox);
            this.currentIterationGroupBox.Controls.Add(this.startButton);
            this.currentIterationGroupBox.Controls.Add(this.maxIterationLabel);
            this.currentIterationGroupBox.Controls.Add(this.errorTextBox);
            this.currentIterationGroupBox.Controls.Add(this.stopButton);
            this.currentIterationGroupBox.Controls.Add(this.iterationTextBox);
            this.currentIterationGroupBox.Controls.Add(this.elapsedLabel);
            this.currentIterationGroupBox.Controls.Add(this.errorLabel);
            this.currentIterationGroupBox.Controls.Add(this.iterationLabel);
            this.currentIterationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentIterationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIterationGroupBox.Location = new System.Drawing.Point(483, 338);
            this.currentIterationGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentIterationGroupBox.Name = "currentIterationGroupBox";
            this.currentIterationGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentIterationGroupBox.Size = new System.Drawing.Size(314, 261);
            this.currentIterationGroupBox.TabIndex = 3;
            this.currentIterationGroupBox.TabStop = false;
            this.currentIterationGroupBox.Text = "Training";
            // 
            // toleranceNumericUpDown
            // 
            this.toleranceNumericUpDown.DecimalPlaces = 4;
            this.toleranceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.toleranceNumericUpDown.Location = new System.Drawing.Point(196, 36);
            this.toleranceNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            this.toleranceNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.toleranceNumericUpDown.TabIndex = 0;
            this.toleranceNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceLabel.Location = new System.Drawing.Point(117, 38);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(69, 16);
            this.toleranceLabel.TabIndex = 0;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // maxIterationNumericUpDown
            // 
            this.maxIterationNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxIterationNumericUpDown.Location = new System.Drawing.Point(196, 64);
            this.maxIterationNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxIterationNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIterationNumericUpDown.Name = "maxIterationNumericUpDown";
            this.maxIterationNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.maxIterationNumericUpDown.TabIndex = 1;
            this.maxIterationNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // elapsedTextBox
            // 
            this.elapsedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTextBox.Location = new System.Drawing.Point(163, 208);
            this.elapsedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elapsedTextBox.Name = "elapsedTextBox";
            this.elapsedTextBox.ReadOnly = true;
            this.elapsedTextBox.Size = new System.Drawing.Size(132, 22);
            this.elapsedTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(132, 96);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 28);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // maxIterationLabel
            // 
            this.maxIterationLabel.AutoSize = true;
            this.maxIterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxIterationLabel.Location = new System.Drawing.Point(101, 66);
            this.maxIterationLabel.Name = "maxIterationLabel";
            this.maxIterationLabel.Size = new System.Drawing.Size(82, 16);
            this.maxIterationLabel.TabIndex = 0;
            this.maxIterationLabel.Text = "Max iteration";
            // 
            // errorTextBox
            // 
            this.errorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTextBox.Location = new System.Drawing.Point(163, 177);
            this.errorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.Size = new System.Drawing.Size(132, 22);
            this.errorTextBox.TabIndex = 5;
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(217, 96);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(80, 28);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // iterationTextBox
            // 
            this.iterationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationTextBox.Location = new System.Drawing.Point(163, 145);
            this.iterationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterationTextBox.Name = "iterationTextBox";
            this.iterationTextBox.ReadOnly = true;
            this.iterationTextBox.Size = new System.Drawing.Size(132, 22);
            this.iterationTextBox.TabIndex = 4;
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedLabel.Location = new System.Drawing.Point(97, 212);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(58, 16);
            this.elapsedLabel.TabIndex = 0;
            this.elapsedLabel.Text = "Elapsed";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(119, 181);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(36, 16);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "Error";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationLabel.Location = new System.Drawing.Point(97, 149);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(54, 16);
            this.iterationLabel.TabIndex = 0;
            this.iterationLabel.Text = "Iteration";
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.nguyenWidrowCheckBox);
            this.learningGroupBox.Controls.Add(this.bayesianRegularizationCheckBox);
            this.learningGroupBox.Controls.Add(this.sameWeightsCheckBox);
            this.learningGroupBox.Controls.Add(this.learningRateNumericUpDown);
            this.learningGroupBox.Controls.Add(this.learningRateLabel);
            this.learningGroupBox.Controls.Add(this.learningMethodComboBox);
            this.learningGroupBox.Controls.Add(this.methodLabel);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningGroupBox.Location = new System.Drawing.Point(3, 338);
            this.learningGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.learningGroupBox.Size = new System.Drawing.Size(474, 261);
            this.learningGroupBox.TabIndex = 2;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning Parameters";
            // 
            // nguyenWidrowCheckBox
            // 
            this.nguyenWidrowCheckBox.AutoSize = true;
            this.nguyenWidrowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguyenWidrowCheckBox.Location = new System.Drawing.Point(200, 180);
            this.nguyenWidrowCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nguyenWidrowCheckBox.Name = "nguyenWidrowCheckBox";
            this.nguyenWidrowCheckBox.Size = new System.Drawing.Size(201, 20);
            this.nguyenWidrowCheckBox.TabIndex = 3;
            this.nguyenWidrowCheckBox.Text = "Use Nguyen-Widrow weights";
            this.nguyenWidrowCheckBox.UseVisualStyleBackColor = true;
            // 
            // bayesianRegularizationCheckBox
            // 
            this.bayesianRegularizationCheckBox.AutoSize = true;
            this.bayesianRegularizationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayesianRegularizationCheckBox.Location = new System.Drawing.Point(200, 150);
            this.bayesianRegularizationCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bayesianRegularizationCheckBox.Name = "bayesianRegularizationCheckBox";
            this.bayesianRegularizationCheckBox.Size = new System.Drawing.Size(197, 20);
            this.bayesianRegularizationCheckBox.TabIndex = 2;
            this.bayesianRegularizationCheckBox.Text = "Use Bayesian regularization";
            this.bayesianRegularizationCheckBox.UseVisualStyleBackColor = true;
            // 
            // sameWeightsCheckBox
            // 
            this.sameWeightsCheckBox.AutoSize = true;
            this.sameWeightsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameWeightsCheckBox.Location = new System.Drawing.Point(200, 210);
            this.sameWeightsCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sameWeightsCheckBox.Name = "sameWeightsCheckBox";
            this.sameWeightsCheckBox.Size = new System.Drawing.Size(207, 20);
            this.sameWeightsCheckBox.TabIndex = 4;
            this.sameWeightsCheckBox.Text = "Use always same initialization";
            this.sameWeightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // learningRateNumericUpDown
            // 
            this.learningRateNumericUpDown.DecimalPlaces = 4;
            this.learningRateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningRateNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.learningRateNumericUpDown.Location = new System.Drawing.Point(137, 89);
            this.learningRateNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.learningRateNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.learningRateNumericUpDown.Name = "learningRateNumericUpDown";
            this.learningRateNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.learningRateNumericUpDown.TabIndex = 1;
            this.learningRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // learningRateLabel
            // 
            this.learningRateLabel.AutoSize = true;
            this.learningRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningRateLabel.Location = new System.Drawing.Point(40, 91);
            this.learningRateLabel.Name = "learningRateLabel";
            this.learningRateLabel.Size = new System.Drawing.Size(85, 16);
            this.learningRateLabel.TabIndex = 0;
            this.learningRateLabel.Text = "Learning rate";
            // 
            // learningMethodComboBox
            // 
            this.learningMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.learningMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningMethodComboBox.FormattingEnabled = true;
            this.learningMethodComboBox.Items.AddRange(new object[] {
            "Levenberg-Marquardt",
            "Backpropagation",
            "Resilient Backpropagation",
            "Parallel Resilient Backpropagation",
            "Perceptron",
            "Delta Rule"});
            this.learningMethodComboBox.Location = new System.Drawing.Point(137, 57);
            this.learningMethodComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.learningMethodComboBox.Name = "learningMethodComboBox";
            this.learningMethodComboBox.Size = new System.Drawing.Size(271, 24);
            this.learningMethodComboBox.TabIndex = 0;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLabel.Location = new System.Drawing.Point(75, 60);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(52, 16);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "Method";
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.learningTableLayoutPanel.SetColumnSpan(this.networkLabel, 2);
            this.networkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkLabel.Location = new System.Drawing.Point(4, 0);
            this.networkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(792, 60);
            this.networkLabel.TabIndex = 0;
            this.networkLabel.Text = "Artificial Neural Network - Build Network";
            this.networkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.learningTableLayoutPanel.SetColumnSpan(this.trainingLabel, 2);
            this.trainingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingLabel.Location = new System.Drawing.Point(4, 276);
            this.trainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(792, 60);
            this.trainingLabel.TabIndex = 0;
            this.trainingLabel.Text = "Artificial Neural Network - Training";
            this.trainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkStructureGroupBox
            // 
            this.networkStructureGroupBox.Controls.Add(this.networkStructurePanel);
            this.networkStructureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkStructureGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkStructureGroupBox.Location = new System.Drawing.Point(3, 62);
            this.networkStructureGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.networkStructureGroupBox.Name = "networkStructureGroupBox";
            this.networkStructureGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.networkStructureGroupBox.Size = new System.Drawing.Size(474, 212);
            this.networkStructureGroupBox.TabIndex = 0;
            this.networkStructureGroupBox.TabStop = false;
            this.networkStructureGroupBox.Text = "Network Structure";
            // 
            // networkStructurePanel
            // 
            this.networkStructurePanel.Controls.Add(this.deleteLayerButton);
            this.networkStructurePanel.Controls.Add(this.addLayerButton);
            this.networkStructurePanel.Controls.Add(this.networkStructureDataGridView);
            this.networkStructurePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkStructurePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkStructurePanel.Location = new System.Drawing.Point(3, 22);
            this.networkStructurePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.networkStructurePanel.Name = "networkStructurePanel";
            this.networkStructurePanel.Size = new System.Drawing.Size(468, 188);
            this.networkStructurePanel.TabIndex = 0;
            // 
            // deleteLayerButton
            // 
            this.deleteLayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLayerButton.Location = new System.Drawing.Point(385, 36);
            this.deleteLayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteLayerButton.Name = "deleteLayerButton";
            this.deleteLayerButton.Size = new System.Drawing.Size(80, 28);
            this.deleteLayerButton.TabIndex = 2;
            this.deleteLayerButton.Text = "Delete";
            this.deleteLayerButton.UseVisualStyleBackColor = true;
            this.deleteLayerButton.Click += new System.EventHandler(this.deleteLayerButton_Click);
            // 
            // addLayerButton
            // 
            this.addLayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLayerButton.Location = new System.Drawing.Point(385, 2);
            this.addLayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLayerButton.Name = "addLayerButton";
            this.addLayerButton.Size = new System.Drawing.Size(80, 28);
            this.addLayerButton.TabIndex = 1;
            this.addLayerButton.Text = "Add";
            this.addLayerButton.UseVisualStyleBackColor = true;
            this.addLayerButton.Click += new System.EventHandler(this.addLayerButton_Click);
            // 
            // networkStructureDataGridView
            // 
            this.networkStructureDataGridView.AllowUserToAddRows = false;
            this.networkStructureDataGridView.AllowUserToDeleteRows = false;
            this.networkStructureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.networkStructureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.networkStructureDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkStructureDataGridView.Location = new System.Drawing.Point(0, 0);
            this.networkStructureDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.networkStructureDataGridView.Name = "networkStructureDataGridView";
            this.networkStructureDataGridView.RowHeadersVisible = false;
            this.networkStructureDataGridView.RowHeadersWidth = 51;
            this.networkStructureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.networkStructureDataGridView.Size = new System.Drawing.Size(379, 188);
            this.networkStructureDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hidden layer";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number of neurons";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // activationFuncionGroupBox
            // 
            this.activationFuncionGroupBox.Controls.Add(this.upperLimitNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.upperLimitLabel);
            this.activationFuncionGroupBox.Controls.Add(this.lowerLimitNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.lowerLimitLabel);
            this.activationFuncionGroupBox.Controls.Add(this.activationFunctionComboBox);
            this.activationFuncionGroupBox.Controls.Add(this.alphaNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.activationFunctionLabel);
            this.activationFuncionGroupBox.Controls.Add(this.alphaLabel);
            this.activationFuncionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activationFuncionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationFuncionGroupBox.Location = new System.Drawing.Point(483, 62);
            this.activationFuncionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activationFuncionGroupBox.Name = "activationFuncionGroupBox";
            this.activationFuncionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activationFuncionGroupBox.Size = new System.Drawing.Size(314, 212);
            this.activationFuncionGroupBox.TabIndex = 1;
            this.activationFuncionGroupBox.TabStop = false;
            this.activationFuncionGroupBox.Text = "Activation Function";
            // 
            // upperLimitNumericUpDown
            // 
            this.upperLimitNumericUpDown.DecimalPlaces = 1;
            this.upperLimitNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperLimitNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.upperLimitNumericUpDown.Location = new System.Drawing.Point(196, 146);
            this.upperLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upperLimitNumericUpDown.Name = "upperLimitNumericUpDown";
            this.upperLimitNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.upperLimitNumericUpDown.TabIndex = 3;
            this.upperLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upperLimitLabel
            // 
            this.upperLimitLabel.AutoSize = true;
            this.upperLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperLimitLabel.Location = new System.Drawing.Point(67, 149);
            this.upperLimitLabel.Name = "upperLimitLabel";
            this.upperLimitLabel.Size = new System.Drawing.Size(118, 16);
            this.upperLimitLabel.TabIndex = 0;
            this.upperLimitLabel.Text = "Linear\'s upper limit";
            // 
            // lowerLimitNumericUpDown
            // 
            this.lowerLimitNumericUpDown.DecimalPlaces = 1;
            this.lowerLimitNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLimitNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lowerLimitNumericUpDown.Location = new System.Drawing.Point(196, 114);
            this.lowerLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowerLimitNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lowerLimitNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lowerLimitNumericUpDown.Name = "lowerLimitNumericUpDown";
            this.lowerLimitNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.lowerLimitNumericUpDown.TabIndex = 2;
            this.lowerLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lowerLimitLabel
            // 
            this.lowerLimitLabel.AutoSize = true;
            this.lowerLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLimitLabel.Location = new System.Drawing.Point(69, 117);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(115, 16);
            this.lowerLimitLabel.TabIndex = 0;
            this.lowerLimitLabel.Text = "Linear\'s lower limit";
            // 
            // activationFunctionComboBox
            // 
            this.activationFunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activationFunctionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationFunctionComboBox.FormattingEnabled = true;
            this.activationFunctionComboBox.Items.AddRange(new object[] {
            "Rectified Linear",
            "Sigmoid",
            "Bipolar Sigmoid",
            "Linear",
            "Threshold",
            "Identity"});
            this.activationFunctionComboBox.Location = new System.Drawing.Point(96, 48);
            this.activationFunctionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activationFunctionComboBox.Name = "activationFunctionComboBox";
            this.activationFunctionComboBox.Size = new System.Drawing.Size(200, 24);
            this.activationFunctionComboBox.TabIndex = 0;
            // 
            // alphaNumericUpDown
            // 
            this.alphaNumericUpDown.DecimalPlaces = 1;
            this.alphaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphaNumericUpDown.Location = new System.Drawing.Point(196, 82);
            this.alphaNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alphaNumericUpDown.Name = "alphaNumericUpDown";
            this.alphaNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.alphaNumericUpDown.TabIndex = 1;
            this.alphaNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // activationFunctionLabel
            // 
            this.activationFunctionLabel.AutoSize = true;
            this.activationFunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationFunctionLabel.Location = new System.Drawing.Point(27, 52);
            this.activationFunctionLabel.Name = "activationFunctionLabel";
            this.activationFunctionLabel.Size = new System.Drawing.Size(57, 16);
            this.activationFunctionLabel.TabIndex = 0;
            this.activationFunctionLabel.Text = "Function";
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaLabel.Location = new System.Drawing.Point(109, 85);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(77, 16);
            this.alphaLabel.TabIndex = 0;
            this.alphaLabel.Text = "Sigmoid\'s α";
            // 
            // workerThreadTimer
            // 
            this.workerThreadTimer.Tick += new System.EventHandler(this.workerThreadTimer_Tick);
            // 
            // ANNClassificationLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.learningTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ANNClassificationLearningControl";
            this.Size = new System.Drawing.Size(800, 601);
            this.learningTableLayoutPanel.ResumeLayout(false);
            this.learningTableLayoutPanel.PerformLayout();
            this.currentIterationGroupBox.ResumeLayout(false);
            this.currentIterationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumericUpDown)).EndInit();
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNumericUpDown)).EndInit();
            this.networkStructureGroupBox.ResumeLayout(false);
            this.networkStructurePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.networkStructureDataGridView)).EndInit();
            this.activationFuncionGroupBox.ResumeLayout(false);
            this.activationFuncionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel learningTableLayoutPanel;
        private System.Windows.Forms.GroupBox currentIterationGroupBox;
        private System.Windows.Forms.NumericUpDown maxIterationNumericUpDown;
        private System.Windows.Forms.TextBox elapsedTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label maxIterationLabel;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox iterationTextBox;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.GroupBox learningGroupBox;
        private System.Windows.Forms.CheckBox nguyenWidrowCheckBox;
        private System.Windows.Forms.CheckBox bayesianRegularizationCheckBox;
        private System.Windows.Forms.CheckBox sameWeightsCheckBox;
        private System.Windows.Forms.NumericUpDown learningRateNumericUpDown;
        private System.Windows.Forms.Label learningRateLabel;
        private System.Windows.Forms.ComboBox learningMethodComboBox;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Label trainingLabel;
        private System.Windows.Forms.GroupBox networkStructureGroupBox;
        private System.Windows.Forms.GroupBox activationFuncionGroupBox;
        private System.Windows.Forms.NumericUpDown upperLimitNumericUpDown;
        private System.Windows.Forms.Label upperLimitLabel;
        private System.Windows.Forms.NumericUpDown lowerLimitNumericUpDown;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.ComboBox activationFunctionComboBox;
        private System.Windows.Forms.NumericUpDown alphaNumericUpDown;
        private System.Windows.Forms.Label activationFunctionLabel;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.NumericUpDown toleranceNumericUpDown;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.Timer workerThreadTimer;
        private System.Windows.Forms.Panel networkStructurePanel;
        private System.Windows.Forms.Button deleteLayerButton;
        private System.Windows.Forms.Button addLayerButton;
        private System.Windows.Forms.DataGridView networkStructureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
