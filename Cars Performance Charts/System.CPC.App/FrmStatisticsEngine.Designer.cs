namespace System.CPC.App
{
    partial class FrmStatisticsEngine
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panFields = new System.Windows.Forms.Panel();
            this.lblTopCustomChart = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblTopEngineChart = new System.Windows.Forms.Label();
            this.panSearch = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFilterModel = new System.Windows.Forms.Label();
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.txtFilterModel = new System.Windows.Forms.TextBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.lblCarFiveModel = new System.Windows.Forms.Label();
            this.lblCarFiveID = new System.Windows.Forms.Label();
            this.lblCarFourModel = new System.Windows.Forms.Label();
            this.lblCarFourID = new System.Windows.Forms.Label();
            this.lblCarThreeModel = new System.Windows.Forms.Label();
            this.lblCarThreeID = new System.Windows.Forms.Label();
            this.lblCarTwoModel = new System.Windows.Forms.Label();
            this.lblCarTwoID = new System.Windows.Forms.Label();
            this.lblCarOneModel = new System.Windows.Forms.Label();
            this.lblCarOneID = new System.Windows.Forms.Label();
            this.btnExportCustomEngine = new System.Windows.Forms.Button();
            this.btnExportEngine = new System.Windows.Forms.Button();
            this.chartCustomEngine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEngines = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panLoad = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panAvgEngineSize = new System.Windows.Forms.Panel();
            this.picAvg = new System.Windows.Forms.PictureBox();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.panBiggestEngine = new System.Windows.Forms.Panel();
            this.lblBiggestEngineTitle = new System.Windows.Forms.Label();
            this.picBiggestEngine = new System.Windows.Forms.PictureBox();
            this.lblBiggestEngineValue = new System.Windows.Forms.Label();
            this.lblBiggestEngineCar = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panTitle.SuspendLayout();
            this.panFields.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEngines)).BeginInit();
            this.panLoad.SuspendLayout();
            this.panAvgEngineSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).BeginInit();
            this.panBiggestEngine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBiggestEngine)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(201, 26);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(863, 46);
            this.panTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(11, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Engine Statistics";
            // 
            // panFields
            // 
            this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panFields.Controls.Add(this.lblTopCustomChart);
            this.panFields.Controls.Add(this.btnCompare);
            this.panFields.Controls.Add(this.lblTopEngineChart);
            this.panFields.Controls.Add(this.panSearch);
            this.panFields.Controls.Add(this.lblCarFiveModel);
            this.panFields.Controls.Add(this.lblCarFiveID);
            this.panFields.Controls.Add(this.lblCarFourModel);
            this.panFields.Controls.Add(this.lblCarFourID);
            this.panFields.Controls.Add(this.lblCarThreeModel);
            this.panFields.Controls.Add(this.lblCarThreeID);
            this.panFields.Controls.Add(this.lblCarTwoModel);
            this.panFields.Controls.Add(this.lblCarTwoID);
            this.panFields.Controls.Add(this.lblCarOneModel);
            this.panFields.Controls.Add(this.lblCarOneID);
            this.panFields.Controls.Add(this.btnExportCustomEngine);
            this.panFields.Controls.Add(this.btnExportEngine);
            this.panFields.Controls.Add(this.chartCustomEngine);
            this.panFields.Controls.Add(this.chartEngines);
            this.panFields.Controls.Add(this.panLoad);
            this.panFields.Controls.Add(this.panAvgEngineSize);
            this.panFields.Controls.Add(this.panBiggestEngine);
            this.panFields.Location = new System.Drawing.Point(201, 103);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(863, 535);
            this.panFields.TabIndex = 3;
            // 
            // lblTopCustomChart
            // 
            this.lblTopCustomChart.AutoSize = true;
            this.lblTopCustomChart.BackColor = System.Drawing.Color.White;
            this.lblTopCustomChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopCustomChart.Location = new System.Drawing.Point(557, 249);
            this.lblTopCustomChart.Name = "lblTopCustomChart";
            this.lblTopCustomChart.Size = new System.Drawing.Size(198, 16);
            this.lblTopCustomChart.TabIndex = 47;
            this.lblTopCustomChart.Text = "Displacements Comparison";
            this.lblTopCustomChart.Visible = false;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.Navy;
            this.btnCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompare.Enabled = false;
            this.btnCompare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompare.Location = new System.Drawing.Point(685, 158);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(176, 23);
            this.btnCompare.TabIndex = 46;
            this.btnCompare.Text = "Compare models";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Visible = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblTopEngineChart
            // 
            this.lblTopEngineChart.AutoSize = true;
            this.lblTopEngineChart.BackColor = System.Drawing.Color.White;
            this.lblTopEngineChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopEngineChart.Location = new System.Drawing.Point(132, 249);
            this.lblTopEngineChart.Name = "lblTopEngineChart";
            this.lblTopEngineChart.Size = new System.Drawing.Size(155, 16);
            this.lblTopEngineChart.TabIndex = 4;
            this.lblTopEngineChart.Text = "Top 5 Displacements";
            this.lblTopEngineChart.Visible = false;
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.btnClear);
            this.panSearch.Controls.Add(this.lblFilterModel);
            this.panSearch.Controls.Add(this.picFilter);
            this.panSearch.Controls.Add(this.txtFilterModel);
            this.panSearch.Controls.Add(this.dgvCars);
            this.panSearch.Location = new System.Drawing.Point(369, 14);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(494, 125);
            this.panSearch.TabIndex = 45;
            this.panSearch.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(411, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.toolTip.SetToolTip(this.btnClear, "Clear all selection");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFilterModel
            // 
            this.lblFilterModel.AutoSize = true;
            this.lblFilterModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterModel.Location = new System.Drawing.Point(2, 7);
            this.lblFilterModel.Name = "lblFilterModel";
            this.lblFilterModel.Size = new System.Drawing.Size(98, 16);
            this.lblFilterModel.TabIndex = 38;
            this.lblFilterModel.Text = "Search Model :";
            this.toolTip.SetToolTip(this.lblFilterModel, "Type model to filter results");
            // 
            // picFilter
            // 
            this.picFilter.Image = global::System.CPC.App.Properties.Resources.search;
            this.picFilter.Location = new System.Drawing.Point(369, 17);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(36, 31);
            this.picFilter.TabIndex = 37;
            this.picFilter.TabStop = false;
            // 
            // txtFilterModel
            // 
            this.txtFilterModel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilterModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterModel.Location = new System.Drawing.Point(1, 26);
            this.txtFilterModel.MaxLength = 30;
            this.txtFilterModel.Name = "txtFilterModel";
            this.txtFilterModel.Size = new System.Drawing.Size(362, 22);
            this.txtFilterModel.TabIndex = 36;
            this.toolTip.SetToolTip(this.txtFilterModel, "Search model. Click over the desired model to select.");
            this.txtFilterModel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterModel_KeyUp);
            // 
            // dgvCars
            // 
            this.dgvCars.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(3, 54);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(462, 71);
            this.dgvCars.TabIndex = 35;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // lblCarFiveModel
            // 
            this.lblCarFiveModel.AutoSize = true;
            this.lblCarFiveModel.Location = new System.Drawing.Point(682, 142);
            this.lblCarFiveModel.Name = "lblCarFiveModel";
            this.lblCarFiveModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarFiveModel.TabIndex = 44;
            this.lblCarFiveModel.Text = "Skyline R33 GTR";
            this.lblCarFiveModel.Visible = false;
            // 
            // lblCarFiveID
            // 
            this.lblCarFiveID.AutoSize = true;
            this.lblCarFiveID.Location = new System.Drawing.Point(654, 142);
            this.lblCarFiveID.Name = "lblCarFiveID";
            this.lblCarFiveID.Size = new System.Drawing.Size(13, 13);
            this.lblCarFiveID.TabIndex = 43;
            this.lblCarFiveID.Text = "1";
            this.lblCarFiveID.Visible = false;
            // 
            // lblCarFourModel
            // 
            this.lblCarFourModel.AutoSize = true;
            this.lblCarFourModel.Location = new System.Drawing.Point(534, 155);
            this.lblCarFourModel.Name = "lblCarFourModel";
            this.lblCarFourModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarFourModel.TabIndex = 42;
            this.lblCarFourModel.Text = "Skyline R33 GTR";
            this.lblCarFourModel.Visible = false;
            // 
            // lblCarFourID
            // 
            this.lblCarFourID.AutoSize = true;
            this.lblCarFourID.Location = new System.Drawing.Point(506, 155);
            this.lblCarFourID.Name = "lblCarFourID";
            this.lblCarFourID.Size = new System.Drawing.Size(13, 13);
            this.lblCarFourID.TabIndex = 41;
            this.lblCarFourID.Text = "1";
            this.lblCarFourID.Visible = false;
            // 
            // lblCarThreeModel
            // 
            this.lblCarThreeModel.AutoSize = true;
            this.lblCarThreeModel.Location = new System.Drawing.Point(534, 142);
            this.lblCarThreeModel.Name = "lblCarThreeModel";
            this.lblCarThreeModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarThreeModel.TabIndex = 40;
            this.lblCarThreeModel.Text = "Skyline R33 GTR";
            this.lblCarThreeModel.Visible = false;
            // 
            // lblCarThreeID
            // 
            this.lblCarThreeID.AutoSize = true;
            this.lblCarThreeID.Location = new System.Drawing.Point(506, 142);
            this.lblCarThreeID.Name = "lblCarThreeID";
            this.lblCarThreeID.Size = new System.Drawing.Size(13, 13);
            this.lblCarThreeID.TabIndex = 39;
            this.lblCarThreeID.Text = "1";
            this.lblCarThreeID.Visible = false;
            // 
            // lblCarTwoModel
            // 
            this.lblCarTwoModel.AutoSize = true;
            this.lblCarTwoModel.Location = new System.Drawing.Point(395, 155);
            this.lblCarTwoModel.Name = "lblCarTwoModel";
            this.lblCarTwoModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarTwoModel.TabIndex = 38;
            this.lblCarTwoModel.Text = "Skyline R33 GTR";
            this.lblCarTwoModel.Visible = false;
            // 
            // lblCarTwoID
            // 
            this.lblCarTwoID.AutoSize = true;
            this.lblCarTwoID.Location = new System.Drawing.Point(367, 155);
            this.lblCarTwoID.Name = "lblCarTwoID";
            this.lblCarTwoID.Size = new System.Drawing.Size(13, 13);
            this.lblCarTwoID.TabIndex = 37;
            this.lblCarTwoID.Text = "1";
            this.lblCarTwoID.Visible = false;
            // 
            // lblCarOneModel
            // 
            this.lblCarOneModel.AutoSize = true;
            this.lblCarOneModel.Location = new System.Drawing.Point(395, 142);
            this.lblCarOneModel.Name = "lblCarOneModel";
            this.lblCarOneModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarOneModel.TabIndex = 36;
            this.lblCarOneModel.Text = "Skyline R33 GTR";
            this.lblCarOneModel.Visible = false;
            // 
            // lblCarOneID
            // 
            this.lblCarOneID.AutoSize = true;
            this.lblCarOneID.Location = new System.Drawing.Point(367, 142);
            this.lblCarOneID.Name = "lblCarOneID";
            this.lblCarOneID.Size = new System.Drawing.Size(13, 13);
            this.lblCarOneID.TabIndex = 35;
            this.lblCarOneID.Text = "1";
            this.lblCarOneID.Visible = false;
            // 
            // btnExportCustomEngine
            // 
            this.btnExportCustomEngine.BackColor = System.Drawing.Color.Crimson;
            this.btnExportCustomEngine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCustomEngine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportCustomEngine.Location = new System.Drawing.Point(759, 461);
            this.btnExportCustomEngine.Name = "btnExportCustomEngine";
            this.btnExportCustomEngine.Size = new System.Drawing.Size(75, 23);
            this.btnExportCustomEngine.TabIndex = 11;
            this.btnExportCustomEngine.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportCustomEngine, "Export chart");
            this.btnExportCustomEngine.UseVisualStyleBackColor = false;
            this.btnExportCustomEngine.Visible = false;
            this.btnExportCustomEngine.Click += new System.EventHandler(this.btnExportCustomEngine_Click);
            // 
            // btnExportEngine
            // 
            this.btnExportEngine.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportEngine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportEngine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportEngine.Location = new System.Drawing.Point(309, 461);
            this.btnExportEngine.Name = "btnExportEngine";
            this.btnExportEngine.Size = new System.Drawing.Size(75, 23);
            this.btnExportEngine.TabIndex = 10;
            this.btnExportEngine.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportEngine, "Export chart");
            this.btnExportEngine.UseVisualStyleBackColor = false;
            this.btnExportEngine.Visible = false;
            this.btnExportEngine.Click += new System.EventHandler(this.btnExportEngine_Click);
            // 
            // chartCustomEngine
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCustomEngine.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCustomEngine.Legends.Add(legend1);
            this.chartCustomEngine.Location = new System.Drawing.Point(451, 249);
            this.chartCustomEngine.Name = "chartCustomEngine";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.LegendText = "Size CC";
            series1.Name = "Size";
            this.chartCustomEngine.Series.Add(series1);
            this.chartCustomEngine.Size = new System.Drawing.Size(412, 262);
            this.chartCustomEngine.TabIndex = 9;
            this.chartCustomEngine.Text = "chartCustomEngine";
            this.chartCustomEngine.Visible = false;
            // 
            // chartEngines
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEngines.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEngines.Legends.Add(legend2);
            this.chartEngines.Location = new System.Drawing.Point(0, 249);
            this.chartEngines.Name = "chartEngines";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.LabelBorderWidth = 2;
            series2.Legend = "Legend1";
            series2.LegendText = "Size CC";
            series2.Name = "Size";
            this.chartEngines.Series.Add(series2);
            this.chartEngines.Size = new System.Drawing.Size(412, 262);
            this.chartEngines.TabIndex = 8;
            this.chartEngines.Text = "chartEngine";
            this.chartEngines.Visible = false;
            // 
            // panLoad
            // 
            this.panLoad.Controls.Add(this.pbLoading);
            this.panLoad.Controls.Add(this.lblLoading);
            this.panLoad.Location = new System.Drawing.Point(219, 185);
            this.panLoad.Name = "panLoad";
            this.panLoad.Size = new System.Drawing.Size(468, 58);
            this.panLoad.TabIndex = 7;
            // 
            // pbLoading
            // 
            this.pbLoading.ForeColor = System.Drawing.Color.MediumBlue;
            this.pbLoading.Location = new System.Drawing.Point(18, 24);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(426, 23);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLoading.TabIndex = 5;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLoading.Location = new System.Drawing.Point(18, 5);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(97, 13);
            this.lblLoading.TabIndex = 6;
            this.lblLoading.Text = "Loading statistics...";
            // 
            // panAvgEngineSize
            // 
            this.panAvgEngineSize.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panAvgEngineSize.Controls.Add(this.picAvg);
            this.panAvgEngineSize.Controls.Add(this.lblAvgValue);
            this.panAvgEngineSize.Controls.Add(this.lblAvg);
            this.panAvgEngineSize.Location = new System.Drawing.Point(180, 25);
            this.panAvgEngineSize.Name = "panAvgEngineSize";
            this.panAvgEngineSize.Size = new System.Drawing.Size(149, 154);
            this.panAvgEngineSize.TabIndex = 4;
            this.panAvgEngineSize.Visible = false;
            // 
            // picAvg
            // 
            this.picAvg.Image = global::System.CPC.App.Properties.Resources.procent_badge_64;
            this.picAvg.Location = new System.Drawing.Point(39, 28);
            this.picAvg.Name = "picAvg";
            this.picAvg.Size = new System.Drawing.Size(68, 68);
            this.picAvg.TabIndex = 3;
            this.picAvg.TabStop = false;
            // 
            // lblAvgValue
            // 
            this.lblAvgValue.AutoSize = true;
            this.lblAvgValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAvgValue.Location = new System.Drawing.Point(3, 100);
            this.lblAvgValue.Name = "lblAvgValue";
            this.lblAvgValue.Size = new System.Drawing.Size(64, 24);
            this.lblAvgValue.TabIndex = 1;
            this.lblAvgValue.Text = "Value";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(12, 127);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(121, 16);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "Engine Size Avg";
            // 
            // panBiggestEngine
            // 
            this.panBiggestEngine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panBiggestEngine.Controls.Add(this.lblBiggestEngineTitle);
            this.panBiggestEngine.Controls.Add(this.picBiggestEngine);
            this.panBiggestEngine.Controls.Add(this.lblBiggestEngineValue);
            this.panBiggestEngine.Controls.Add(this.lblBiggestEngineCar);
            this.panBiggestEngine.Location = new System.Drawing.Point(0, 25);
            this.panBiggestEngine.Name = "panBiggestEngine";
            this.panBiggestEngine.Size = new System.Drawing.Size(149, 154);
            this.panBiggestEngine.TabIndex = 0;
            this.panBiggestEngine.Visible = false;
            // 
            // lblBiggestEngineTitle
            // 
            this.lblBiggestEngineTitle.AutoSize = true;
            this.lblBiggestEngineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiggestEngineTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblBiggestEngineTitle.Location = new System.Drawing.Point(12, 9);
            this.lblBiggestEngineTitle.Name = "lblBiggestEngineTitle";
            this.lblBiggestEngineTitle.Size = new System.Drawing.Size(113, 16);
            this.lblBiggestEngineTitle.TabIndex = 4;
            this.lblBiggestEngineTitle.Text = "Biggest Engine";
            // 
            // picBiggestEngine
            // 
            this.picBiggestEngine.Image = global::System.CPC.App.Properties.Resources.engine_64;
            this.picBiggestEngine.Location = new System.Drawing.Point(40, 28);
            this.picBiggestEngine.Name = "picBiggestEngine";
            this.picBiggestEngine.Size = new System.Drawing.Size(68, 68);
            this.picBiggestEngine.TabIndex = 3;
            this.picBiggestEngine.TabStop = false;
            // 
            // lblBiggestEngineValue
            // 
            this.lblBiggestEngineValue.AutoSize = true;
            this.lblBiggestEngineValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiggestEngineValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBiggestEngineValue.Location = new System.Drawing.Point(10, 99);
            this.lblBiggestEngineValue.Name = "lblBiggestEngineValue";
            this.lblBiggestEngineValue.Size = new System.Drawing.Size(72, 25);
            this.lblBiggestEngineValue.TabIndex = 1;
            this.lblBiggestEngineValue.Text = "Value";
            // 
            // lblBiggestEngineCar
            // 
            this.lblBiggestEngineCar.AutoSize = true;
            this.lblBiggestEngineCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiggestEngineCar.Location = new System.Drawing.Point(12, 127);
            this.lblBiggestEngineCar.Name = "lblBiggestEngineCar";
            this.lblBiggestEngineCar.Size = new System.Drawing.Size(29, 15);
            this.lblBiggestEngineCar.TabIndex = 2;
            this.lblBiggestEngineCar.Text = "Car";
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // FrmStatisticsEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.panFields);
            this.Controls.Add(this.panTitle);
            this.Name = "FrmStatisticsEngine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Engine Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.panFields.ResumeLayout(false);
            this.panFields.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEngines)).EndInit();
            this.panLoad.ResumeLayout(false);
            this.panLoad.PerformLayout();
            this.panAvgEngineSize.ResumeLayout(false);
            this.panAvgEngineSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).EndInit();
            this.panBiggestEngine.ResumeLayout(false);
            this.panBiggestEngine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBiggestEngine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panTitle;
        private Windows.Forms.Label lblTitle;
        private Windows.Forms.Panel panFields;
        private Windows.Forms.Button btnExportCustomEngine;
        private Windows.Forms.Button btnExportEngine;
        private Windows.Forms.DataVisualization.Charting.Chart chartCustomEngine;
        private Windows.Forms.DataVisualization.Charting.Chart chartEngines;
        private Windows.Forms.Panel panLoad;
        private Windows.Forms.ProgressBar pbLoading;
        private Windows.Forms.Label lblLoading;
        private Windows.Forms.Panel panAvgEngineSize;
        private Windows.Forms.PictureBox picAvg;
        private Windows.Forms.Panel panBiggestEngine;
        private Windows.Forms.PictureBox picBiggestEngine;
        private Windows.Forms.Label lblBiggestEngineValue;
        private Windows.Forms.Label lblBiggestEngineCar;
        private Windows.Forms.Label lblBiggestEngineTitle;
        private Windows.Forms.Label lblAvgValue;
        private Windows.Forms.Label lblAvg;
        private Windows.Forms.Timer timerLoading;
        private Windows.Forms.ToolTip toolTip;
        private Windows.Forms.Label lblCarFiveModel;
        private Windows.Forms.Label lblCarFiveID;
        private Windows.Forms.Label lblCarFourModel;
        private Windows.Forms.Label lblCarFourID;
        private Windows.Forms.Label lblCarThreeModel;
        private Windows.Forms.Label lblCarThreeID;
        private Windows.Forms.Label lblCarTwoModel;
        private Windows.Forms.Label lblCarTwoID;
        private Windows.Forms.Label lblCarOneModel;
        private Windows.Forms.Label lblCarOneID;
        private Windows.Forms.Panel panSearch;
        private Windows.Forms.Button btnClear;
        private Windows.Forms.Label lblFilterModel;
        private Windows.Forms.PictureBox picFilter;
        private Windows.Forms.TextBox txtFilterModel;
        private Windows.Forms.DataGridView dgvCars;
        private Windows.Forms.Label lblTopEngineChart;
        private Windows.Forms.Button btnCompare;
        private Windows.Forms.Label lblTopCustomChart;
    }
}