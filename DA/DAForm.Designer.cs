namespace DNMachineLearning.DA
{
    partial class DAForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAForm));
            this.clusteringTaskPanel = new System.Windows.Forms.Panel();
            this.clusteringTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.projectionTabControl = new System.Windows.Forms.TabControl();
            this.singleProjectionTabPage = new System.Windows.Forms.TabPage();
            this.singleProjectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.singleProjectionPCDataGridView = new System.Windows.Forms.DataGridView();
            this.singleProjectionInputDataGridView = new System.Windows.Forms.DataGridView();
            this.singleProjectionPanel = new System.Windows.Forms.Panel();
            this.singleProjectionProjectButton = new System.Windows.Forms.Button();
            this.datasetProjectionTabPage = new System.Windows.Forms.TabPage();
            this.datasetProjectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.datasetProjectionDDataGridView = new System.Windows.Forms.DataGridView();
            this.datasetProjectionPanel = new System.Windows.Forms.Panel();
            this.visualizeProjectedDataButton = new System.Windows.Forms.Button();
            this.visualizeDataButton = new System.Windows.Forms.Button();
            this.datasetProjectionHasHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.datasetProjectionLoadButton = new System.Windows.Forms.Button();
            this.datasetProjectionInputDataGridView = new System.Windows.Forms.DataGridView();
            this.projectedDataPanel = new System.Windows.Forms.Panel();
            this.projectedDataLabel = new System.Windows.Forms.Label();
            this.loadDataPanel = new System.Windows.Forms.Panel();
            this.loadDataLabel = new System.Windows.Forms.Label();
            this.analysisPanel = new System.Windows.Forms.Panel();
            this.analysisLabel = new System.Windows.Forms.Label();
            this.analysisParametersPanel = new System.Windows.Forms.Panel();
            this.analysisTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.kernelGroupBox = new System.Windows.Forms.GroupBox();
            this.sigmoidEstimateButton = new System.Windows.Forms.Button();
            this.laplacianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaLabel = new System.Windows.Forms.Label();
            this.gaussianSigmaLabel = new System.Windows.Forms.Label();
            this.sigmoidConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidAlphaLabel = new System.Windows.Forms.Label();
            this.sigmoidAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialConstantLabel = new System.Windows.Forms.Label();
            this.polynomialDegreeLabel = new System.Windows.Forms.Label();
            this.polynomialConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialDegreeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidConstantLabel = new System.Windows.Forms.Label();
            this.sigmoidKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.polynomialKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfDiscriminantsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfDiscriminantsLabel = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.DiscriminantsPanel = new System.Windows.Forms.Panel();
            this.DiscriminantsLabel = new System.Windows.Forms.Label();
            this.DiscriminantsViewPanel = new System.Windows.Forms.Panel();
            this.EigenvectorLabel = new System.Windows.Forms.Label();
            this.proportionTextBox = new System.Windows.Forms.TextBox();
            this.proportionLabel = new System.Windows.Forms.Label();
            this.eigenvalueTextBox = new System.Windows.Forms.TextBox();
            this.discriminantLabel = new System.Windows.Forms.Label();
            this.eigenvalueLabel = new System.Windows.Forms.Label();
            this.principalComponentComboBox = new System.Windows.Forms.ComboBox();
            this.eigenvectorDataGridView = new System.Windows.Forms.DataGridView();
            this.projectionPanel = new System.Windows.Forms.Panel();
            this.projectionLabel = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            this.loadInputDataPanel = new System.Windows.Forms.Panel();
            this.dataVisualizeButton = new System.Windows.Forms.Button();
            this.dataHasHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataLabel = new System.Windows.Forms.Label();
            this.projectedDataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.projectedDataVisualizePanel = new System.Windows.Forms.Panel();
            this.projectedDataVisualizedButton = new System.Windows.Forms.Button();
            this.projectedDataDataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loadDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.clusteringTaskPanel.SuspendLayout();
            this.clusteringTableLayoutPanel.SuspendLayout();
            this.projectionTabControl.SuspendLayout();
            this.singleProjectionTabPage.SuspendLayout();
            this.singleProjectionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionPCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionInputDataGridView)).BeginInit();
            this.singleProjectionPanel.SuspendLayout();
            this.datasetProjectionTabPage.SuspendLayout();
            this.datasetProjectionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProjectionDDataGridView)).BeginInit();
            this.datasetProjectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProjectionInputDataGridView)).BeginInit();
            this.projectedDataPanel.SuspendLayout();
            this.loadDataPanel.SuspendLayout();
            this.analysisPanel.SuspendLayout();
            this.analysisParametersPanel.SuspendLayout();
            this.analysisTableLayoutPanel.SuspendLayout();
            this.kernelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).BeginInit();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiscriminantsNumericUpDown)).BeginInit();
            this.DiscriminantsPanel.SuspendLayout();
            this.DiscriminantsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).BeginInit();
            this.projectionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.dataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            this.loadInputDataPanel.SuspendLayout();
            this.projectedDataTableLayoutPanel.SuspendLayout();
            this.projectedDataVisualizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectedDataDataGridView)).BeginInit();
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
            this.clusteringTaskPanel.TabIndex = 0;
            // 
            // clusteringTableLayoutPanel
            // 
            this.clusteringTableLayoutPanel.AutoSize = true;
            this.clusteringTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.clusteringTableLayoutPanel.ColumnCount = 2;
            this.clusteringTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.clusteringTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clusteringTableLayoutPanel.Controls.Add(this.projectionTabControl, 1, 4);
            this.clusteringTableLayoutPanel.Controls.Add(this.projectedDataPanel, 0, 2);
            this.clusteringTableLayoutPanel.Controls.Add(this.loadDataPanel, 0, 0);
            this.clusteringTableLayoutPanel.Controls.Add(this.analysisPanel, 0, 1);
            this.clusteringTableLayoutPanel.Controls.Add(this.analysisParametersPanel, 1, 1);
            this.clusteringTableLayoutPanel.Controls.Add(this.DiscriminantsPanel, 0, 3);
            this.clusteringTableLayoutPanel.Controls.Add(this.DiscriminantsViewPanel, 1, 3);
            this.clusteringTableLayoutPanel.Controls.Add(this.projectionPanel, 0, 4);
            this.clusteringTableLayoutPanel.Controls.Add(this.dataPanel, 1, 0);
            this.clusteringTableLayoutPanel.Controls.Add(this.projectedDataTableLayoutPanel, 1, 2);
            this.clusteringTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clusteringTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.clusteringTableLayoutPanel.Name = "clusteringTableLayoutPanel";
            this.clusteringTableLayoutPanel.RowCount = 5;
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.clusteringTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clusteringTableLayoutPanel.Size = new System.Drawing.Size(785, 1726);
            this.clusteringTableLayoutPanel.TabIndex = 0;
            // 
            // projectionTabControl
            // 
            this.projectionTabControl.Controls.Add(this.singleProjectionTabPage);
            this.projectionTabControl.Controls.Add(this.datasetProjectionTabPage);
            this.projectionTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectionTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectionTabControl.Location = new System.Drawing.Point(178, 1393);
            this.projectionTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.projectionTabControl.Name = "projectionTabControl";
            this.projectionTabControl.SelectedIndex = 0;
            this.projectionTabControl.Size = new System.Drawing.Size(602, 328);
            this.projectionTabControl.TabIndex = 9;
            this.projectionTabControl.Visible = false;
            // 
            // singleProjectionTabPage
            // 
            this.singleProjectionTabPage.Controls.Add(this.singleProjectionTableLayoutPanel);
            this.singleProjectionTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleProjectionTabPage.Location = new System.Drawing.Point(4, 29);
            this.singleProjectionTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.singleProjectionTabPage.Name = "singleProjectionTabPage";
            this.singleProjectionTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.singleProjectionTabPage.Size = new System.Drawing.Size(594, 295);
            this.singleProjectionTabPage.TabIndex = 0;
            this.singleProjectionTabPage.Text = "Single Projection";
            this.singleProjectionTabPage.UseVisualStyleBackColor = true;
            // 
            // singleProjectionTableLayoutPanel
            // 
            this.singleProjectionTableLayoutPanel.ColumnCount = 3;
            this.singleProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.singleProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.singleProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.singleProjectionTableLayoutPanel.Controls.Add(this.singleProjectionPCDataGridView, 2, 0);
            this.singleProjectionTableLayoutPanel.Controls.Add(this.singleProjectionInputDataGridView, 0, 0);
            this.singleProjectionTableLayoutPanel.Controls.Add(this.singleProjectionPanel, 1, 0);
            this.singleProjectionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.singleProjectionTableLayoutPanel.Name = "singleProjectionTableLayoutPanel";
            this.singleProjectionTableLayoutPanel.RowCount = 1;
            this.singleProjectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.singleProjectionTableLayoutPanel.Size = new System.Drawing.Size(590, 291);
            this.singleProjectionTableLayoutPanel.TabIndex = 0;
            // 
            // singleProjectionPCDataGridView
            // 
            this.singleProjectionPCDataGridView.AllowUserToAddRows = false;
            this.singleProjectionPCDataGridView.AllowUserToDeleteRows = false;
            this.singleProjectionPCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singleProjectionPCDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionPCDataGridView.Location = new System.Drawing.Point(337, 2);
            this.singleProjectionPCDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.singleProjectionPCDataGridView.Name = "singleProjectionPCDataGridView";
            this.singleProjectionPCDataGridView.ReadOnly = true;
            this.singleProjectionPCDataGridView.RowHeadersWidth = 51;
            this.singleProjectionPCDataGridView.RowTemplate.Height = 24;
            this.singleProjectionPCDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.singleProjectionPCDataGridView.Size = new System.Drawing.Size(251, 287);
            this.singleProjectionPCDataGridView.TabIndex = 2;
            // 
            // singleProjectionInputDataGridView
            // 
            this.singleProjectionInputDataGridView.AllowUserToAddRows = false;
            this.singleProjectionInputDataGridView.AllowUserToDeleteRows = false;
            this.singleProjectionInputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singleProjectionInputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionInputDataGridView.Location = new System.Drawing.Point(2, 2);
            this.singleProjectionInputDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.singleProjectionInputDataGridView.Name = "singleProjectionInputDataGridView";
            this.singleProjectionInputDataGridView.RowHeadersWidth = 51;
            this.singleProjectionInputDataGridView.RowTemplate.Height = 24;
            this.singleProjectionInputDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.singleProjectionInputDataGridView.Size = new System.Drawing.Size(251, 287);
            this.singleProjectionInputDataGridView.TabIndex = 0;
            // 
            // singleProjectionPanel
            // 
            this.singleProjectionPanel.Controls.Add(this.singleProjectionProjectButton);
            this.singleProjectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionPanel.Location = new System.Drawing.Point(258, 3);
            this.singleProjectionPanel.Name = "singleProjectionPanel";
            this.singleProjectionPanel.Size = new System.Drawing.Size(74, 285);
            this.singleProjectionPanel.TabIndex = 1;
            // 
            // singleProjectionProjectButton
            // 
            this.singleProjectionProjectButton.Location = new System.Drawing.Point(7, 2);
            this.singleProjectionProjectButton.Margin = new System.Windows.Forms.Padding(2);
            this.singleProjectionProjectButton.Name = "singleProjectionProjectButton";
            this.singleProjectionProjectButton.Size = new System.Drawing.Size(60, 23);
            this.singleProjectionProjectButton.TabIndex = 0;
            this.singleProjectionProjectButton.Text = "Project";
            this.singleProjectionProjectButton.UseVisualStyleBackColor = true;
            this.singleProjectionProjectButton.Click += new System.EventHandler(this.singleProjectionProjectButton_Click);
            // 
            // datasetProjectionTabPage
            // 
            this.datasetProjectionTabPage.Controls.Add(this.datasetProjectionTableLayoutPanel);
            this.datasetProjectionTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetProjectionTabPage.Location = new System.Drawing.Point(4, 29);
            this.datasetProjectionTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.datasetProjectionTabPage.Name = "datasetProjectionTabPage";
            this.datasetProjectionTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.datasetProjectionTabPage.Size = new System.Drawing.Size(594, 295);
            this.datasetProjectionTabPage.TabIndex = 1;
            this.datasetProjectionTabPage.Text = "Dataset Projection";
            this.datasetProjectionTabPage.UseVisualStyleBackColor = true;
            // 
            // datasetProjectionTableLayoutPanel
            // 
            this.datasetProjectionTableLayoutPanel.ColumnCount = 2;
            this.datasetProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datasetProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datasetProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.datasetProjectionTableLayoutPanel.Controls.Add(this.datasetProjectionDDataGridView, 1, 1);
            this.datasetProjectionTableLayoutPanel.Controls.Add(this.datasetProjectionPanel, 0, 0);
            this.datasetProjectionTableLayoutPanel.Controls.Add(this.datasetProjectionInputDataGridView, 0, 1);
            this.datasetProjectionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetProjectionTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.datasetProjectionTableLayoutPanel.Name = "datasetProjectionTableLayoutPanel";
            this.datasetProjectionTableLayoutPanel.RowCount = 2;
            this.datasetProjectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.datasetProjectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetProjectionTableLayoutPanel.Size = new System.Drawing.Size(590, 291);
            this.datasetProjectionTableLayoutPanel.TabIndex = 0;
            // 
            // datasetProjectionDDataGridView
            // 
            this.datasetProjectionDDataGridView.AllowUserToAddRows = false;
            this.datasetProjectionDDataGridView.AllowUserToDeleteRows = false;
            this.datasetProjectionDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetProjectionDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetProjectionDDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datasetProjectionDDataGridView.Location = new System.Drawing.Point(297, 42);
            this.datasetProjectionDDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.datasetProjectionDDataGridView.Name = "datasetProjectionDDataGridView";
            this.datasetProjectionDDataGridView.ReadOnly = true;
            this.datasetProjectionDDataGridView.RowHeadersWidth = 51;
            this.datasetProjectionDDataGridView.RowTemplate.Height = 24;
            this.datasetProjectionDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasetProjectionDDataGridView.Size = new System.Drawing.Size(291, 247);
            this.datasetProjectionDDataGridView.TabIndex = 2;
            // 
            // datasetProjectionPanel
            // 
            this.datasetProjectionTableLayoutPanel.SetColumnSpan(this.datasetProjectionPanel, 2);
            this.datasetProjectionPanel.Controls.Add(this.visualizeProjectedDataButton);
            this.datasetProjectionPanel.Controls.Add(this.visualizeDataButton);
            this.datasetProjectionPanel.Controls.Add(this.datasetProjectionHasHeadersCheckBox);
            this.datasetProjectionPanel.Controls.Add(this.datasetProjectionLoadButton);
            this.datasetProjectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetProjectionPanel.Location = new System.Drawing.Point(2, 2);
            this.datasetProjectionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.datasetProjectionPanel.Name = "datasetProjectionPanel";
            this.datasetProjectionPanel.Size = new System.Drawing.Size(586, 36);
            this.datasetProjectionPanel.TabIndex = 0;
            // 
            // visualizeProjectedDataButton
            // 
            this.visualizeProjectedDataButton.Enabled = false;
            this.visualizeProjectedDataButton.Location = new System.Drawing.Point(368, 5);
            this.visualizeProjectedDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeProjectedDataButton.Name = "visualizeProjectedDataButton";
            this.visualizeProjectedDataButton.Size = new System.Drawing.Size(150, 23);
            this.visualizeProjectedDataButton.TabIndex = 3;
            this.visualizeProjectedDataButton.Text = "Visualize projected data...";
            this.visualizeProjectedDataButton.UseVisualStyleBackColor = true;
            this.visualizeProjectedDataButton.Click += new System.EventHandler(this.visualizeProjectedDataButton_Click);
            // 
            // visualizeDataButton
            // 
            this.visualizeDataButton.Enabled = false;
            this.visualizeDataButton.Location = new System.Drawing.Point(244, 5);
            this.visualizeDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeDataButton.Name = "visualizeDataButton";
            this.visualizeDataButton.Size = new System.Drawing.Size(120, 23);
            this.visualizeDataButton.TabIndex = 2;
            this.visualizeDataButton.Text = "Visualize data...";
            this.visualizeDataButton.UseVisualStyleBackColor = true;
            this.visualizeDataButton.Click += new System.EventHandler(this.visualizeDataButton_Click);
            // 
            // datasetProjectionHasHeadersCheckBox
            // 
            this.datasetProjectionHasHeadersCheckBox.AutoSize = true;
            this.datasetProjectionHasHeadersCheckBox.Checked = true;
            this.datasetProjectionHasHeadersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.datasetProjectionHasHeadersCheckBox.Location = new System.Drawing.Point(7, 9);
            this.datasetProjectionHasHeadersCheckBox.Name = "datasetProjectionHasHeadersCheckBox";
            this.datasetProjectionHasHeadersCheckBox.Size = new System.Drawing.Size(84, 17);
            this.datasetProjectionHasHeadersCheckBox.TabIndex = 0;
            this.datasetProjectionHasHeadersCheckBox.Text = "has headers";
            this.datasetProjectionHasHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // datasetProjectionLoadButton
            // 
            this.datasetProjectionLoadButton.Location = new System.Drawing.Point(90, 5);
            this.datasetProjectionLoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.datasetProjectionLoadButton.Name = "datasetProjectionLoadButton";
            this.datasetProjectionLoadButton.Size = new System.Drawing.Size(150, 23);
            this.datasetProjectionLoadButton.TabIndex = 1;
            this.datasetProjectionLoadButton.Text = "Load dataset and project...";
            this.toolTip.SetToolTip(this.datasetProjectionLoadButton, "- Data must include one or more input columns and no output column.\r\n- The number" +
        " of input columns must match the training dataset.\r\n- All input columns must con" +
        "tain numerical data.");
            this.datasetProjectionLoadButton.UseVisualStyleBackColor = true;
            this.datasetProjectionLoadButton.Click += new System.EventHandler(this.datasetProjectionLoadButton_Click);
            // 
            // datasetProjectionInputDataGridView
            // 
            this.datasetProjectionInputDataGridView.AllowUserToAddRows = false;
            this.datasetProjectionInputDataGridView.AllowUserToDeleteRows = false;
            this.datasetProjectionInputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetProjectionInputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetProjectionInputDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datasetProjectionInputDataGridView.Location = new System.Drawing.Point(2, 42);
            this.datasetProjectionInputDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.datasetProjectionInputDataGridView.Name = "datasetProjectionInputDataGridView";
            this.datasetProjectionInputDataGridView.ReadOnly = true;
            this.datasetProjectionInputDataGridView.RowHeadersWidth = 51;
            this.datasetProjectionInputDataGridView.RowTemplate.Height = 24;
            this.datasetProjectionInputDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasetProjectionInputDataGridView.Size = new System.Drawing.Size(291, 247);
            this.datasetProjectionInputDataGridView.TabIndex = 0;
            // 
            // projectedDataPanel
            // 
            this.projectedDataPanel.Controls.Add(this.projectedDataLabel);
            this.projectedDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectedDataPanel.Location = new System.Drawing.Point(6, 724);
            this.projectedDataPanel.Name = "projectedDataPanel";
            this.projectedDataPanel.Size = new System.Drawing.Size(164, 326);
            this.projectedDataPanel.TabIndex = 4;
            // 
            // projectedDataLabel
            // 
            this.projectedDataLabel.AutoSize = true;
            this.projectedDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectedDataLabel.Location = new System.Drawing.Point(9, 9);
            this.projectedDataLabel.Name = "projectedDataLabel";
            this.projectedDataLabel.Size = new System.Drawing.Size(129, 20);
            this.projectedDataLabel.TabIndex = 1;
            this.projectedDataLabel.Text = "Projected Data";
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
            // analysisPanel
            // 
            this.analysisPanel.Controls.Add(this.analysisLabel);
            this.analysisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisPanel.Location = new System.Drawing.Point(6, 341);
            this.analysisPanel.Name = "analysisPanel";
            this.analysisPanel.Size = new System.Drawing.Size(164, 374);
            this.analysisPanel.TabIndex = 2;
            // 
            // analysisLabel
            // 
            this.analysisLabel.AutoSize = true;
            this.analysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisLabel.Location = new System.Drawing.Point(9, 9);
            this.analysisLabel.Name = "analysisLabel";
            this.analysisLabel.Size = new System.Drawing.Size(75, 20);
            this.analysisLabel.TabIndex = 1;
            this.analysisLabel.Text = "Analysis";
            // 
            // analysisParametersPanel
            // 
            this.analysisParametersPanel.Controls.Add(this.analysisTableLayoutPanel);
            this.analysisParametersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisParametersPanel.Location = new System.Drawing.Point(179, 341);
            this.analysisParametersPanel.Name = "analysisParametersPanel";
            this.analysisParametersPanel.Size = new System.Drawing.Size(600, 374);
            this.analysisParametersPanel.TabIndex = 3;
            // 
            // analysisTableLayoutPanel
            // 
            this.analysisTableLayoutPanel.ColumnCount = 2;
            this.analysisTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.analysisTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.analysisTableLayoutPanel.Controls.Add(this.kernelGroupBox, 0, 0);
            this.analysisTableLayoutPanel.Controls.Add(this.learningGroupBox, 1, 0);
            this.analysisTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.analysisTableLayoutPanel.Name = "analysisTableLayoutPanel";
            this.analysisTableLayoutPanel.RowCount = 1;
            this.analysisTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.analysisTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            this.analysisTableLayoutPanel.Size = new System.Drawing.Size(600, 374);
            this.analysisTableLayoutPanel.TabIndex = 0;
            this.analysisTableLayoutPanel.Visible = false;
            // 
            // kernelGroupBox
            // 
            this.kernelGroupBox.Controls.Add(this.sigmoidEstimateButton);
            this.kernelGroupBox.Controls.Add(this.laplacianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.gaussianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.gaussianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.polynomialKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaNumericUpDown);
            this.kernelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kernelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kernelGroupBox.Location = new System.Drawing.Point(2, 2);
            this.kernelGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.kernelGroupBox.Name = "kernelGroupBox";
            this.kernelGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.kernelGroupBox.Size = new System.Drawing.Size(296, 370);
            this.kernelGroupBox.TabIndex = 0;
            this.kernelGroupBox.TabStop = false;
            this.kernelGroupBox.Text = "Kernel";
            // 
            // sigmoidEstimateButton
            // 
            this.sigmoidEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidEstimateButton.Location = new System.Drawing.Point(192, 297);
            this.sigmoidEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidEstimateButton.Name = "sigmoidEstimateButton";
            this.sigmoidEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.sigmoidEstimateButton.TabIndex = 12;
            this.sigmoidEstimateButton.Text = "Estimate";
            this.sigmoidEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sigmoidEstimateButton.UseVisualStyleBackColor = true;
            this.sigmoidEstimateButton.Click += new System.EventHandler(this.sigmoidEstimateButton_Click);
            // 
            // laplacianEstimateButton
            // 
            this.laplacianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianEstimateButton.Location = new System.Drawing.Point(192, 225);
            this.laplacianEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianEstimateButton.Name = "laplacianEstimateButton";
            this.laplacianEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.laplacianEstimateButton.TabIndex = 8;
            this.laplacianEstimateButton.Text = "Estimate";
            this.laplacianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.laplacianEstimateButton.UseVisualStyleBackColor = true;
            this.laplacianEstimateButton.Click += new System.EventHandler(this.laplacianEstimateButton_Click);
            // 
            // gaussianEstimateButton
            // 
            this.gaussianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianEstimateButton.Location = new System.Drawing.Point(192, 148);
            this.gaussianEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianEstimateButton.Name = "gaussianEstimateButton";
            this.gaussianEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.gaussianEstimateButton.TabIndex = 5;
            this.gaussianEstimateButton.Text = "Estimate";
            this.gaussianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gaussianEstimateButton.UseVisualStyleBackColor = true;
            this.gaussianEstimateButton.Click += new System.EventHandler(this.gaussianEstimateButton_Click);
            // 
            // gaussianKernelRadioButton
            // 
            this.gaussianKernelRadioButton.AutoSize = true;
            this.gaussianKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianKernelRadioButton.Location = new System.Drawing.Point(27, 123);
            this.gaussianKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianKernelRadioButton.Name = "gaussianKernelRadioButton";
            this.gaussianKernelRadioButton.Size = new System.Drawing.Size(102, 17);
            this.gaussianKernelRadioButton.TabIndex = 3;
            this.gaussianKernelRadioButton.Text = "Gaussian Kernel";
            this.gaussianKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianSigmaLabel
            // 
            this.laplacianSigmaLabel.AutoSize = true;
            this.laplacianSigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianSigmaLabel.Location = new System.Drawing.Point(95, 230);
            this.laplacianSigmaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laplacianSigmaLabel.Name = "laplacianSigmaLabel";
            this.laplacianSigmaLabel.Size = new System.Drawing.Size(14, 13);
            this.laplacianSigmaLabel.TabIndex = 0;
            this.laplacianSigmaLabel.Text = "σ";
            // 
            // gaussianSigmaLabel
            // 
            this.gaussianSigmaLabel.AutoSize = true;
            this.gaussianSigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianSigmaLabel.Location = new System.Drawing.Point(95, 153);
            this.gaussianSigmaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gaussianSigmaLabel.Name = "gaussianSigmaLabel";
            this.gaussianSigmaLabel.Size = new System.Drawing.Size(14, 13);
            this.gaussianSigmaLabel.TabIndex = 0;
            this.gaussianSigmaLabel.Text = "σ";
            // 
            // sigmoidConstantNumericUpDown
            // 
            this.sigmoidConstantNumericUpDown.DecimalPlaces = 4;
            this.sigmoidConstantNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidConstantNumericUpDown.Location = new System.Drawing.Point(113, 323);
            this.sigmoidConstantNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidConstantNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sigmoidConstantNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.sigmoidConstantNumericUpDown.Name = "sigmoidConstantNumericUpDown";
            this.sigmoidConstantNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.sigmoidConstantNumericUpDown.TabIndex = 11;
            this.sigmoidConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sigmoidAlphaLabel
            // 
            this.sigmoidAlphaLabel.AutoSize = true;
            this.sigmoidAlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidAlphaLabel.Location = new System.Drawing.Point(95, 302);
            this.sigmoidAlphaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sigmoidAlphaLabel.Name = "sigmoidAlphaLabel";
            this.sigmoidAlphaLabel.Size = new System.Drawing.Size(14, 13);
            this.sigmoidAlphaLabel.TabIndex = 0;
            this.sigmoidAlphaLabel.Text = "α";
            // 
            // sigmoidAlphaNumericUpDown
            // 
            this.sigmoidAlphaNumericUpDown.DecimalPlaces = 4;
            this.sigmoidAlphaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidAlphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.sigmoidAlphaNumericUpDown.Location = new System.Drawing.Point(113, 300);
            this.sigmoidAlphaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidAlphaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sigmoidAlphaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.sigmoidAlphaNumericUpDown.Name = "sigmoidAlphaNumericUpDown";
            this.sigmoidAlphaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.sigmoidAlphaNumericUpDown.TabIndex = 10;
            this.sigmoidAlphaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sigmoidAlphaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // polynomialConstantLabel
            // 
            this.polynomialConstantLabel.AutoSize = true;
            this.polynomialConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialConstantLabel.Location = new System.Drawing.Point(60, 81);
            this.polynomialConstantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polynomialConstantLabel.Name = "polynomialConstantLabel";
            this.polynomialConstantLabel.Size = new System.Drawing.Size(49, 13);
            this.polynomialConstantLabel.TabIndex = 0;
            this.polynomialConstantLabel.Text = "Constant";
            // 
            // polynomialDegreeLabel
            // 
            this.polynomialDegreeLabel.AutoSize = true;
            this.polynomialDegreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialDegreeLabel.Location = new System.Drawing.Point(67, 58);
            this.polynomialDegreeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polynomialDegreeLabel.Name = "polynomialDegreeLabel";
            this.polynomialDegreeLabel.Size = new System.Drawing.Size(42, 13);
            this.polynomialDegreeLabel.TabIndex = 0;
            this.polynomialDegreeLabel.Text = "Degree";
            // 
            // polynomialConstantNumericUpDown
            // 
            this.polynomialConstantNumericUpDown.DecimalPlaces = 4;
            this.polynomialConstantNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialConstantNumericUpDown.Location = new System.Drawing.Point(113, 79);
            this.polynomialConstantNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialConstantNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.polynomialConstantNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.polynomialConstantNumericUpDown.Name = "polynomialConstantNumericUpDown";
            this.polynomialConstantNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.polynomialConstantNumericUpDown.TabIndex = 2;
            this.polynomialConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // polynomialDegreeNumericUpDown
            // 
            this.polynomialDegreeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialDegreeNumericUpDown.Location = new System.Drawing.Point(113, 56);
            this.polynomialDegreeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialDegreeNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Name = "polynomialDegreeNumericUpDown";
            this.polynomialDegreeNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.polynomialDegreeNumericUpDown.TabIndex = 1;
            this.polynomialDegreeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.polynomialDegreeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sigmoidConstantLabel
            // 
            this.sigmoidConstantLabel.AutoSize = true;
            this.sigmoidConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidConstantLabel.Location = new System.Drawing.Point(60, 325);
            this.sigmoidConstantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sigmoidConstantLabel.Name = "sigmoidConstantLabel";
            this.sigmoidConstantLabel.Size = new System.Drawing.Size(49, 13);
            this.sigmoidConstantLabel.TabIndex = 0;
            this.sigmoidConstantLabel.Text = "Constant";
            // 
            // sigmoidKernelRadioButton
            // 
            this.sigmoidKernelRadioButton.AutoSize = true;
            this.sigmoidKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidKernelRadioButton.Location = new System.Drawing.Point(27, 271);
            this.sigmoidKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidKernelRadioButton.Name = "sigmoidKernelRadioButton";
            this.sigmoidKernelRadioButton.Size = new System.Drawing.Size(95, 17);
            this.sigmoidKernelRadioButton.TabIndex = 9;
            this.sigmoidKernelRadioButton.Text = "Sigmoid Kernel";
            this.sigmoidKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianKernelRadioButton
            // 
            this.laplacianKernelRadioButton.AutoSize = true;
            this.laplacianKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianKernelRadioButton.Location = new System.Drawing.Point(27, 199);
            this.laplacianKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianKernelRadioButton.Name = "laplacianKernelRadioButton";
            this.laplacianKernelRadioButton.Size = new System.Drawing.Size(104, 17);
            this.laplacianKernelRadioButton.TabIndex = 6;
            this.laplacianKernelRadioButton.Text = "Laplacian Kernel";
            this.laplacianKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // polynomialKernelRadioButton
            // 
            this.polynomialKernelRadioButton.AutoSize = true;
            this.polynomialKernelRadioButton.Checked = true;
            this.polynomialKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialKernelRadioButton.Location = new System.Drawing.Point(27, 27);
            this.polynomialKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialKernelRadioButton.Name = "polynomialKernelRadioButton";
            this.polynomialKernelRadioButton.Size = new System.Drawing.Size(108, 17);
            this.polynomialKernelRadioButton.TabIndex = 0;
            this.polynomialKernelRadioButton.TabStop = true;
            this.polynomialKernelRadioButton.Text = "Polynomial Kernel";
            this.polynomialKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianSigmaNumericUpDown
            // 
            this.laplacianSigmaNumericUpDown.DecimalPlaces = 4;
            this.laplacianSigmaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.laplacianSigmaNumericUpDown.Location = new System.Drawing.Point(113, 228);
            this.laplacianSigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.laplacianSigmaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.laplacianSigmaNumericUpDown.Name = "laplacianSigmaNumericUpDown";
            this.laplacianSigmaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.laplacianSigmaNumericUpDown.TabIndex = 7;
            this.laplacianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.laplacianSigmaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // gaussianSigmaNumericUpDown
            // 
            this.gaussianSigmaNumericUpDown.DecimalPlaces = 4;
            this.gaussianSigmaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.gaussianSigmaNumericUpDown.Location = new System.Drawing.Point(113, 151);
            this.gaussianSigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.gaussianSigmaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.gaussianSigmaNumericUpDown.Name = "gaussianSigmaNumericUpDown";
            this.gaussianSigmaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.gaussianSigmaNumericUpDown.TabIndex = 4;
            this.gaussianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gaussianSigmaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.numberOfDiscriminantsNumericUpDown);
            this.learningGroupBox.Controls.Add(this.numberOfDiscriminantsLabel);
            this.learningGroupBox.Controls.Add(this.analyzeButton);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningGroupBox.Location = new System.Drawing.Point(303, 3);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Size = new System.Drawing.Size(294, 368);
            this.learningGroupBox.TabIndex = 1;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Analysis";
            // 
            // numberOfDiscriminantsNumericUpDown
            // 
            this.numberOfDiscriminantsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDiscriminantsNumericUpDown.Location = new System.Drawing.Point(169, 78);
            this.numberOfDiscriminantsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfDiscriminantsNumericUpDown.Name = "numberOfDiscriminantsNumericUpDown";
            this.numberOfDiscriminantsNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.numberOfDiscriminantsNumericUpDown.TabIndex = 0;
            this.numberOfDiscriminantsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfDiscriminantsLabel
            // 
            this.numberOfDiscriminantsLabel.AutoSize = true;
            this.numberOfDiscriminantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDiscriminantsLabel.Location = new System.Drawing.Point(42, 80);
            this.numberOfDiscriminantsLabel.Name = "numberOfDiscriminantsLabel";
            this.numberOfDiscriminantsLabel.Size = new System.Drawing.Size(121, 13);
            this.numberOfDiscriminantsLabel.TabIndex = 0;
            this.numberOfDiscriminantsLabel.Text = "Number of Discriminants";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeButton.Location = new System.Drawing.Point(118, 231);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 1;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // DiscriminantsPanel
            // 
            this.DiscriminantsPanel.Controls.Add(this.DiscriminantsLabel);
            this.DiscriminantsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscriminantsPanel.Location = new System.Drawing.Point(6, 1059);
            this.DiscriminantsPanel.Name = "DiscriminantsPanel";
            this.DiscriminantsPanel.Size = new System.Drawing.Size(164, 326);
            this.DiscriminantsPanel.TabIndex = 6;
            // 
            // DiscriminantsLabel
            // 
            this.DiscriminantsLabel.AutoSize = true;
            this.DiscriminantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscriminantsLabel.Location = new System.Drawing.Point(9, 10);
            this.DiscriminantsLabel.Name = "DiscriminantsLabel";
            this.DiscriminantsLabel.Size = new System.Drawing.Size(117, 20);
            this.DiscriminantsLabel.TabIndex = 0;
            this.DiscriminantsLabel.Text = "Discriminants";
            // 
            // DiscriminantsViewPanel
            // 
            this.DiscriminantsViewPanel.Controls.Add(this.EigenvectorLabel);
            this.DiscriminantsViewPanel.Controls.Add(this.proportionTextBox);
            this.DiscriminantsViewPanel.Controls.Add(this.proportionLabel);
            this.DiscriminantsViewPanel.Controls.Add(this.eigenvalueTextBox);
            this.DiscriminantsViewPanel.Controls.Add(this.discriminantLabel);
            this.DiscriminantsViewPanel.Controls.Add(this.eigenvalueLabel);
            this.DiscriminantsViewPanel.Controls.Add(this.principalComponentComboBox);
            this.DiscriminantsViewPanel.Controls.Add(this.eigenvectorDataGridView);
            this.DiscriminantsViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscriminantsViewPanel.Location = new System.Drawing.Point(179, 1059);
            this.DiscriminantsViewPanel.Name = "DiscriminantsViewPanel";
            this.DiscriminantsViewPanel.Size = new System.Drawing.Size(600, 326);
            this.DiscriminantsViewPanel.TabIndex = 7;
            this.DiscriminantsViewPanel.Visible = false;
            // 
            // EigenvectorLabel
            // 
            this.EigenvectorLabel.AutoSize = true;
            this.EigenvectorLabel.Location = new System.Drawing.Point(287, 67);
            this.EigenvectorLabel.Name = "EigenvectorLabel";
            this.EigenvectorLabel.Size = new System.Drawing.Size(64, 13);
            this.EigenvectorLabel.TabIndex = 0;
            this.EigenvectorLabel.Text = "Eigenvector";
            // 
            // proportionTextBox
            // 
            this.proportionTextBox.Location = new System.Drawing.Point(357, 15);
            this.proportionTextBox.Name = "proportionTextBox";
            this.proportionTextBox.Size = new System.Drawing.Size(100, 20);
            this.proportionTextBox.TabIndex = 17;
            // 
            // proportionLabel
            // 
            this.proportionLabel.AutoSize = true;
            this.proportionLabel.Location = new System.Drawing.Point(296, 18);
            this.proportionLabel.Name = "proportionLabel";
            this.proportionLabel.Size = new System.Drawing.Size(55, 13);
            this.proportionLabel.TabIndex = 12;
            this.proportionLabel.Text = "Proportion";
            // 
            // eigenvalueTextBox
            // 
            this.eigenvalueTextBox.Location = new System.Drawing.Point(357, 41);
            this.eigenvalueTextBox.Name = "eigenvalueTextBox";
            this.eigenvalueTextBox.Size = new System.Drawing.Size(100, 20);
            this.eigenvalueTextBox.TabIndex = 16;
            // 
            // discriminantLabel
            // 
            this.discriminantLabel.AutoSize = true;
            this.discriminantLabel.Location = new System.Drawing.Point(67, 18);
            this.discriminantLabel.Name = "discriminantLabel";
            this.discriminantLabel.Size = new System.Drawing.Size(64, 13);
            this.discriminantLabel.TabIndex = 13;
            this.discriminantLabel.Text = "Discriminant";
            // 
            // eigenvalueLabel
            // 
            this.eigenvalueLabel.AutoSize = true;
            this.eigenvalueLabel.Location = new System.Drawing.Point(291, 44);
            this.eigenvalueLabel.Name = "eigenvalueLabel";
            this.eigenvalueLabel.Size = new System.Drawing.Size(60, 13);
            this.eigenvalueLabel.TabIndex = 14;
            this.eigenvalueLabel.Text = "Eigenvalue";
            // 
            // principalComponentComboBox
            // 
            this.principalComponentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.principalComponentComboBox.FormattingEnabled = true;
            this.principalComponentComboBox.Location = new System.Drawing.Point(137, 15);
            this.principalComponentComboBox.Name = "principalComponentComboBox";
            this.principalComponentComboBox.Size = new System.Drawing.Size(100, 21);
            this.principalComponentComboBox.TabIndex = 15;
            this.principalComponentComboBox.SelectedIndexChanged += new System.EventHandler(this.principalComponentComboBox_SelectedIndexChanged);
            // 
            // eigenvectorDataGridView
            // 
            this.eigenvectorDataGridView.AllowUserToAddRows = false;
            this.eigenvectorDataGridView.AllowUserToDeleteRows = false;
            this.eigenvectorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eigenvectorDataGridView.ColumnHeadersVisible = false;
            this.eigenvectorDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.eigenvectorDataGridView.Location = new System.Drawing.Point(357, 67);
            this.eigenvectorDataGridView.Name = "eigenvectorDataGridView";
            this.eigenvectorDataGridView.ReadOnly = true;
            this.eigenvectorDataGridView.RowHeadersVisible = false;
            this.eigenvectorDataGridView.RowHeadersWidth = 51;
            this.eigenvectorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eigenvectorDataGridView.Size = new System.Drawing.Size(173, 240);
            this.eigenvectorDataGridView.TabIndex = 11;
            // 
            // projectionPanel
            // 
            this.projectionPanel.Controls.Add(this.projectionLabel);
            this.projectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectionPanel.Location = new System.Drawing.Point(6, 1394);
            this.projectionPanel.Name = "projectionPanel";
            this.projectionPanel.Size = new System.Drawing.Size(164, 326);
            this.projectionPanel.TabIndex = 8;
            // 
            // projectionLabel
            // 
            this.projectionLabel.AutoSize = true;
            this.projectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectionLabel.Location = new System.Drawing.Point(9, 8);
            this.projectionLabel.Name = "projectionLabel";
            this.projectionLabel.Size = new System.Drawing.Size(89, 20);
            this.projectionLabel.TabIndex = 0;
            this.projectionLabel.Text = "Projection";
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataTableLayoutPanel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(178, 5);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(602, 328);
            this.dataPanel.TabIndex = 1;
            // 
            // dataTableLayoutPanel
            // 
            this.dataTableLayoutPanel.ColumnCount = 1;
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.dataTableLayoutPanel.Controls.Add(this.dataDataGridView, 0, 1);
            this.dataTableLayoutPanel.Controls.Add(this.loadInputDataPanel, 0, 0);
            this.dataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.dataTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            this.dataTableLayoutPanel.RowCount = 2;
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(602, 328);
            this.dataTableLayoutPanel.TabIndex = 2;
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
            this.dataDataGridView.Size = new System.Drawing.Size(596, 222);
            this.dataDataGridView.TabIndex = 1;
            // 
            // loadInputDataPanel
            // 
            this.loadInputDataPanel.Controls.Add(this.dataVisualizeButton);
            this.loadInputDataPanel.Controls.Add(this.dataHasHeadersCheckBox);
            this.loadInputDataPanel.Controls.Add(this.loadButton);
            this.loadInputDataPanel.Controls.Add(this.dataLabel);
            this.loadInputDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadInputDataPanel.Location = new System.Drawing.Point(2, 2);
            this.loadInputDataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loadInputDataPanel.Name = "loadInputDataPanel";
            this.loadInputDataPanel.Size = new System.Drawing.Size(598, 96);
            this.loadInputDataPanel.TabIndex = 1;
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
            this.toolTip.SetToolTip(this.loadButton, resources.GetString("loadButton.ToolTip"));
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
            // projectedDataTableLayoutPanel
            // 
            this.projectedDataTableLayoutPanel.ColumnCount = 1;
            this.projectedDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.projectedDataTableLayoutPanel.Controls.Add(this.projectedDataVisualizePanel, 0, 0);
            this.projectedDataTableLayoutPanel.Controls.Add(this.projectedDataDataGridView, 0, 1);
            this.projectedDataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectedDataTableLayoutPanel.Location = new System.Drawing.Point(179, 724);
            this.projectedDataTableLayoutPanel.Name = "projectedDataTableLayoutPanel";
            this.projectedDataTableLayoutPanel.RowCount = 2;
            this.projectedDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.projectedDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.projectedDataTableLayoutPanel.Size = new System.Drawing.Size(600, 326);
            this.projectedDataTableLayoutPanel.TabIndex = 5;
            this.projectedDataTableLayoutPanel.Visible = false;
            // 
            // projectedDataVisualizePanel
            // 
            this.projectedDataTableLayoutPanel.SetColumnSpan(this.projectedDataVisualizePanel, 3);
            this.projectedDataVisualizePanel.Controls.Add(this.projectedDataVisualizedButton);
            this.projectedDataVisualizePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectedDataVisualizePanel.Location = new System.Drawing.Point(2, 2);
            this.projectedDataVisualizePanel.Margin = new System.Windows.Forms.Padding(2);
            this.projectedDataVisualizePanel.Name = "projectedDataVisualizePanel";
            this.projectedDataVisualizePanel.Size = new System.Drawing.Size(596, 36);
            this.projectedDataVisualizePanel.TabIndex = 0;
            // 
            // projectedDataVisualizedButton
            // 
            this.projectedDataVisualizedButton.Location = new System.Drawing.Point(2, 7);
            this.projectedDataVisualizedButton.Margin = new System.Windows.Forms.Padding(2);
            this.projectedDataVisualizedButton.Name = "projectedDataVisualizedButton";
            this.projectedDataVisualizedButton.Size = new System.Drawing.Size(75, 23);
            this.projectedDataVisualizedButton.TabIndex = 0;
            this.projectedDataVisualizedButton.Text = "Visualize...";
            this.projectedDataVisualizedButton.UseVisualStyleBackColor = true;
            this.projectedDataVisualizedButton.Click += new System.EventHandler(this.projectedDataVisualizedButton_Click);
            // 
            // projectedDataDataGridView
            // 
            this.projectedDataDataGridView.AllowUserToAddRows = false;
            this.projectedDataDataGridView.AllowUserToDeleteRows = false;
            this.projectedDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectedDataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectedDataDataGridView.Location = new System.Drawing.Point(3, 43);
            this.projectedDataDataGridView.Name = "projectedDataDataGridView";
            this.projectedDataDataGridView.ReadOnly = true;
            this.projectedDataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectedDataDataGridView.Size = new System.Drawing.Size(594, 280);
            this.projectedDataDataGridView.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(802, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Status:";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 10;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // loadDataFileDialog
            // 
            this.loadDataFileDialog.FileName = "*.csv";
            this.loadDataFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            // 
            // DAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 457);
            this.Controls.Add(this.clusteringTaskPanel);
            this.Controls.Add(this.statusStrip);
            this.Name = "DAForm";
            this.ShowIcon = false;
            this.Text = "Discriminant Analysis Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DAForm_FormClosing);
            this.clusteringTaskPanel.ResumeLayout(false);
            this.clusteringTaskPanel.PerformLayout();
            this.clusteringTableLayoutPanel.ResumeLayout(false);
            this.projectionTabControl.ResumeLayout(false);
            this.singleProjectionTabPage.ResumeLayout(false);
            this.singleProjectionTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionPCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionInputDataGridView)).EndInit();
            this.singleProjectionPanel.ResumeLayout(false);
            this.datasetProjectionTabPage.ResumeLayout(false);
            this.datasetProjectionTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasetProjectionDDataGridView)).EndInit();
            this.datasetProjectionPanel.ResumeLayout(false);
            this.datasetProjectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProjectionInputDataGridView)).EndInit();
            this.projectedDataPanel.ResumeLayout(false);
            this.projectedDataPanel.PerformLayout();
            this.loadDataPanel.ResumeLayout(false);
            this.loadDataPanel.PerformLayout();
            this.analysisPanel.ResumeLayout(false);
            this.analysisPanel.PerformLayout();
            this.analysisParametersPanel.ResumeLayout(false);
            this.analysisTableLayoutPanel.ResumeLayout(false);
            this.kernelGroupBox.ResumeLayout(false);
            this.kernelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).EndInit();
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiscriminantsNumericUpDown)).EndInit();
            this.DiscriminantsPanel.ResumeLayout(false);
            this.DiscriminantsPanel.PerformLayout();
            this.DiscriminantsViewPanel.ResumeLayout(false);
            this.DiscriminantsViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).EndInit();
            this.projectionPanel.ResumeLayout(false);
            this.projectionPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.dataTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            this.loadInputDataPanel.ResumeLayout(false);
            this.loadInputDataPanel.PerformLayout();
            this.projectedDataTableLayoutPanel.ResumeLayout(false);
            this.projectedDataVisualizePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectedDataDataGridView)).EndInit();
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
        private System.Windows.Forms.Panel analysisPanel;
        private System.Windows.Forms.Label analysisLabel;
        private System.Windows.Forms.Panel analysisParametersPanel;
        private System.Windows.Forms.Panel DiscriminantsPanel;
        private System.Windows.Forms.Label DiscriminantsLabel;
        private System.Windows.Forms.Panel DiscriminantsViewPanel;
        private System.Windows.Forms.Panel projectionPanel;
        private System.Windows.Forms.Label projectionLabel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel dataTableLayoutPanel;
        private System.Windows.Forms.DataGridView dataDataGridView;
        private System.Windows.Forms.Panel loadInputDataPanel;
        private System.Windows.Forms.Button dataVisualizeButton;
        private System.Windows.Forms.CheckBox dataHasHeadersCheckBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.TextBox proportionTextBox;
        private System.Windows.Forms.Label proportionLabel;
        private System.Windows.Forms.TextBox eigenvalueTextBox;
        private System.Windows.Forms.Label discriminantLabel;
        private System.Windows.Forms.Label eigenvalueLabel;
        private System.Windows.Forms.ComboBox principalComponentComboBox;
        private System.Windows.Forms.DataGridView eigenvectorDataGridView;
        private System.Windows.Forms.Label EigenvectorLabel;
        private System.Windows.Forms.TabControl projectionTabControl;
        private System.Windows.Forms.TabPage singleProjectionTabPage;
        private System.Windows.Forms.TableLayoutPanel singleProjectionTableLayoutPanel;
        private System.Windows.Forms.DataGridView singleProjectionInputDataGridView;
        private System.Windows.Forms.TabPage datasetProjectionTabPage;
        private System.Windows.Forms.TableLayoutPanel datasetProjectionTableLayoutPanel;
        private System.Windows.Forms.Panel datasetProjectionPanel;
        private System.Windows.Forms.CheckBox datasetProjectionHasHeadersCheckBox;
        private System.Windows.Forms.Button datasetProjectionLoadButton;
        private System.Windows.Forms.DataGridView datasetProjectionInputDataGridView;
        private System.Windows.Forms.Panel singleProjectionPanel;
        private System.Windows.Forms.Button singleProjectionProjectButton;
        private System.Windows.Forms.DataGridView datasetProjectionDDataGridView;
        private System.Windows.Forms.DataGridView singleProjectionPCDataGridView;
        private System.Windows.Forms.Button visualizeDataButton;
        private System.Windows.Forms.TableLayoutPanel analysisTableLayoutPanel;
        private System.Windows.Forms.GroupBox learningGroupBox;
        private System.Windows.Forms.NumericUpDown numberOfDiscriminantsNumericUpDown;
        private System.Windows.Forms.Label numberOfDiscriminantsLabel;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Panel projectedDataPanel;
        private System.Windows.Forms.Label projectedDataLabel;
        private System.Windows.Forms.TableLayoutPanel projectedDataTableLayoutPanel;
        private System.Windows.Forms.Panel projectedDataVisualizePanel;
        private System.Windows.Forms.Button projectedDataVisualizedButton;
        private System.Windows.Forms.DataGridView projectedDataDataGridView;
        private System.Windows.Forms.OpenFileDialog loadDataFileDialog;
        private System.Windows.Forms.GroupBox kernelGroupBox;
        private System.Windows.Forms.Button sigmoidEstimateButton;
        private System.Windows.Forms.Button laplacianEstimateButton;
        private System.Windows.Forms.Button gaussianEstimateButton;
        private System.Windows.Forms.RadioButton gaussianKernelRadioButton;
        private System.Windows.Forms.Label laplacianSigmaLabel;
        private System.Windows.Forms.Label gaussianSigmaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidConstantNumericUpDown;
        private System.Windows.Forms.Label sigmoidAlphaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidAlphaNumericUpDown;
        private System.Windows.Forms.Label polynomialConstantLabel;
        private System.Windows.Forms.Label polynomialDegreeLabel;
        private System.Windows.Forms.NumericUpDown polynomialConstantNumericUpDown;
        private System.Windows.Forms.NumericUpDown polynomialDegreeNumericUpDown;
        private System.Windows.Forms.Label sigmoidConstantLabel;
        private System.Windows.Forms.RadioButton sigmoidKernelRadioButton;
        private System.Windows.Forms.RadioButton laplacianKernelRadioButton;
        private System.Windows.Forms.RadioButton polynomialKernelRadioButton;
        private System.Windows.Forms.NumericUpDown laplacianSigmaNumericUpDown;
        private System.Windows.Forms.NumericUpDown gaussianSigmaNumericUpDown;
        private System.Windows.Forms.Button visualizeProjectedDataButton;
    }
}