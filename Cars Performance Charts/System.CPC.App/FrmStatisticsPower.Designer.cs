namespace System.CPC.App
{
    partial class FrmStatisticsPower
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
            this.panFields = new System.Windows.Forms.Panel();
            this.lblTopCustomChart = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblTopPowerChart = new System.Windows.Forms.Label();
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
            this.btnExportCustomPower = new System.Windows.Forms.Button();
            this.btnExportPower = new System.Windows.Forms.Button();
            this.chartCustomPower = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPower = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panLoad = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panAvgPower = new System.Windows.Forms.Panel();
            this.picAvg = new System.Windows.Forms.PictureBox();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.panPowerfulCar = new System.Windows.Forms.Panel();
            this.lblPowerfulCarTitle = new System.Windows.Forms.Label();
            this.picPowerfulCar = new System.Windows.Forms.PictureBox();
            this.lblPowerfulCarValue = new System.Windows.Forms.Label();
            this.lblPowerfulCar = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panFields.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).BeginInit();
            this.panLoad.SuspendLayout();
            this.panAvgPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).BeginInit();
            this.panPowerfulCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerfulCar)).BeginInit();
            this.panTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFields
            // 
            this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panFields.Controls.Add(this.lblTopCustomChart);
            this.panFields.Controls.Add(this.btnCompare);
            this.panFields.Controls.Add(this.lblTopPowerChart);
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
            this.panFields.Controls.Add(this.btnExportCustomPower);
            this.panFields.Controls.Add(this.btnExportPower);
            this.panFields.Controls.Add(this.chartCustomPower);
            this.panFields.Controls.Add(this.chartPower);
            this.panFields.Controls.Add(this.panLoad);
            this.panFields.Controls.Add(this.panAvgPower);
            this.panFields.Controls.Add(this.panPowerfulCar);
            this.panFields.Location = new System.Drawing.Point(201, 103);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(863, 535);
            this.panFields.TabIndex = 5;
            // 
            // lblTopCustomChart
            // 
            this.lblTopCustomChart.AutoSize = true;
            this.lblTopCustomChart.BackColor = System.Drawing.Color.White;
            this.lblTopCustomChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopCustomChart.Location = new System.Drawing.Point(584, 249);
            this.lblTopCustomChart.Name = "lblTopCustomChart";
            this.lblTopCustomChart.Size = new System.Drawing.Size(138, 16);
            this.lblTopCustomChart.TabIndex = 47;
            this.lblTopCustomChart.Text = "Power Comparison";
            this.lblTopCustomChart.Visible = false;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.Navy;
            this.btnCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompare.Enabled = false;
            this.btnCompare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompare.Location = new System.Drawing.Point(687, 158);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(176, 23);
            this.btnCompare.TabIndex = 46;
            this.btnCompare.Text = "Compare models";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Visible = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblTopPowerChart
            // 
            this.lblTopPowerChart.AutoSize = true;
            this.lblTopPowerChart.BackColor = System.Drawing.Color.White;
            this.lblTopPowerChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPowerChart.Location = new System.Drawing.Point(127, 249);
            this.lblTopPowerChart.Name = "lblTopPowerChart";
            this.lblTopPowerChart.Size = new System.Drawing.Size(147, 16);
            this.lblTopPowerChart.TabIndex = 4;
            this.lblTopPowerChart.Text = "Top 5 Powerful Cars";
            this.lblTopPowerChart.Visible = false;
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
            this.lblCarFiveModel.Location = new System.Drawing.Point(684, 142);
            this.lblCarFiveModel.Name = "lblCarFiveModel";
            this.lblCarFiveModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarFiveModel.TabIndex = 44;
            this.lblCarFiveModel.Text = "Skyline R33 GTR";
            this.lblCarFiveModel.Visible = false;
            // 
            // lblCarFiveID
            // 
            this.lblCarFiveID.AutoSize = true;
            this.lblCarFiveID.Location = new System.Drawing.Point(656, 142);
            this.lblCarFiveID.Name = "lblCarFiveID";
            this.lblCarFiveID.Size = new System.Drawing.Size(13, 13);
            this.lblCarFiveID.TabIndex = 43;
            this.lblCarFiveID.Text = "1";
            this.lblCarFiveID.Visible = false;
            // 
            // lblCarFourModel
            // 
            this.lblCarFourModel.AutoSize = true;
            this.lblCarFourModel.Location = new System.Drawing.Point(536, 155);
            this.lblCarFourModel.Name = "lblCarFourModel";
            this.lblCarFourModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarFourModel.TabIndex = 42;
            this.lblCarFourModel.Text = "Skyline R33 GTR";
            this.lblCarFourModel.Visible = false;
            // 
            // lblCarFourID
            // 
            this.lblCarFourID.AutoSize = true;
            this.lblCarFourID.Location = new System.Drawing.Point(508, 155);
            this.lblCarFourID.Name = "lblCarFourID";
            this.lblCarFourID.Size = new System.Drawing.Size(13, 13);
            this.lblCarFourID.TabIndex = 41;
            this.lblCarFourID.Text = "1";
            this.lblCarFourID.Visible = false;
            // 
            // lblCarThreeModel
            // 
            this.lblCarThreeModel.AutoSize = true;
            this.lblCarThreeModel.Location = new System.Drawing.Point(536, 142);
            this.lblCarThreeModel.Name = "lblCarThreeModel";
            this.lblCarThreeModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarThreeModel.TabIndex = 40;
            this.lblCarThreeModel.Text = "Skyline R33 GTR";
            this.lblCarThreeModel.Visible = false;
            // 
            // lblCarThreeID
            // 
            this.lblCarThreeID.AutoSize = true;
            this.lblCarThreeID.Location = new System.Drawing.Point(508, 142);
            this.lblCarThreeID.Name = "lblCarThreeID";
            this.lblCarThreeID.Size = new System.Drawing.Size(13, 13);
            this.lblCarThreeID.TabIndex = 39;
            this.lblCarThreeID.Text = "1";
            this.lblCarThreeID.Visible = false;
            // 
            // lblCarTwoModel
            // 
            this.lblCarTwoModel.AutoSize = true;
            this.lblCarTwoModel.Location = new System.Drawing.Point(397, 155);
            this.lblCarTwoModel.Name = "lblCarTwoModel";
            this.lblCarTwoModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarTwoModel.TabIndex = 38;
            this.lblCarTwoModel.Text = "Skyline R33 GTR";
            this.lblCarTwoModel.Visible = false;
            // 
            // lblCarTwoID
            // 
            this.lblCarTwoID.AutoSize = true;
            this.lblCarTwoID.Location = new System.Drawing.Point(369, 155);
            this.lblCarTwoID.Name = "lblCarTwoID";
            this.lblCarTwoID.Size = new System.Drawing.Size(13, 13);
            this.lblCarTwoID.TabIndex = 37;
            this.lblCarTwoID.Text = "1";
            this.lblCarTwoID.Visible = false;
            // 
            // lblCarOneModel
            // 
            this.lblCarOneModel.AutoSize = true;
            this.lblCarOneModel.Location = new System.Drawing.Point(397, 142);
            this.lblCarOneModel.Name = "lblCarOneModel";
            this.lblCarOneModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarOneModel.TabIndex = 36;
            this.lblCarOneModel.Text = "Skyline R33 GTR";
            this.lblCarOneModel.Visible = false;
            // 
            // lblCarOneID
            // 
            this.lblCarOneID.AutoSize = true;
            this.lblCarOneID.Location = new System.Drawing.Point(369, 142);
            this.lblCarOneID.Name = "lblCarOneID";
            this.lblCarOneID.Size = new System.Drawing.Size(13, 13);
            this.lblCarOneID.TabIndex = 35;
            this.lblCarOneID.Text = "1";
            this.lblCarOneID.Visible = false;
            // 
            // btnExportCustomPower
            // 
            this.btnExportCustomPower.BackColor = System.Drawing.Color.Crimson;
            this.btnExportCustomPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCustomPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportCustomPower.Location = new System.Drawing.Point(759, 461);
            this.btnExportCustomPower.Name = "btnExportCustomPower";
            this.btnExportCustomPower.Size = new System.Drawing.Size(75, 23);
            this.btnExportCustomPower.TabIndex = 11;
            this.btnExportCustomPower.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportCustomPower, "Export chart");
            this.btnExportCustomPower.UseVisualStyleBackColor = false;
            this.btnExportCustomPower.Visible = false;
            this.btnExportCustomPower.Click += new System.EventHandler(this.btnExportCustomPower_Click);
            // 
            // btnExportPower
            // 
            this.btnExportPower.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportPower.Location = new System.Drawing.Point(309, 461);
            this.btnExportPower.Name = "btnExportPower";
            this.btnExportPower.Size = new System.Drawing.Size(75, 23);
            this.btnExportPower.TabIndex = 10;
            this.btnExportPower.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportPower, "Export chart");
            this.btnExportPower.UseVisualStyleBackColor = false;
            this.btnExportPower.Visible = false;
            this.btnExportPower.Click += new System.EventHandler(this.btnExportPower_Click);
            // 
            // chartCustomPower
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCustomPower.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCustomPower.Legends.Add(legend1);
            this.chartCustomPower.Location = new System.Drawing.Point(451, 249);
            this.chartCustomPower.Name = "chartCustomPower";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.LegendText = "Power HP";
            series1.Name = "Power";
            this.chartCustomPower.Series.Add(series1);
            this.chartCustomPower.Size = new System.Drawing.Size(412, 262);
            this.chartCustomPower.TabIndex = 9;
            this.chartCustomPower.Text = "chartCustomPower";
            this.chartCustomPower.Visible = false;
            // 
            // chartPower
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPower.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPower.Legends.Add(legend2);
            this.chartPower.Location = new System.Drawing.Point(0, 249);
            this.chartPower.Name = "chartPower";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.LabelBorderWidth = 2;
            series2.Legend = "Legend1";
            series2.LegendText = "Power HP";
            series2.Name = "Power";
            this.chartPower.Series.Add(series2);
            this.chartPower.Size = new System.Drawing.Size(412, 262);
            this.chartPower.TabIndex = 8;
            this.chartPower.Text = "chartPower";
            this.chartPower.Visible = false;
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
            // panAvgPower
            // 
            this.panAvgPower.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panAvgPower.Controls.Add(this.picAvg);
            this.panAvgPower.Controls.Add(this.lblAvgValue);
            this.panAvgPower.Controls.Add(this.lblAvg);
            this.panAvgPower.Location = new System.Drawing.Point(180, 25);
            this.panAvgPower.Name = "panAvgPower";
            this.panAvgPower.Size = new System.Drawing.Size(149, 154);
            this.panAvgPower.TabIndex = 4;
            this.panAvgPower.Visible = false;
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
            this.lblAvg.Size = new System.Drawing.Size(82, 16);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "Power Avg";
            // 
            // panPowerfulCar
            // 
            this.panPowerfulCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panPowerfulCar.Controls.Add(this.lblPowerfulCarTitle);
            this.panPowerfulCar.Controls.Add(this.picPowerfulCar);
            this.panPowerfulCar.Controls.Add(this.lblPowerfulCarValue);
            this.panPowerfulCar.Controls.Add(this.lblPowerfulCar);
            this.panPowerfulCar.Location = new System.Drawing.Point(0, 25);
            this.panPowerfulCar.Name = "panPowerfulCar";
            this.panPowerfulCar.Size = new System.Drawing.Size(149, 154);
            this.panPowerfulCar.TabIndex = 0;
            this.panPowerfulCar.Visible = false;
            // 
            // lblPowerfulCarTitle
            // 
            this.lblPowerfulCarTitle.AutoSize = true;
            this.lblPowerfulCarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerfulCarTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPowerfulCarTitle.Location = new System.Drawing.Point(12, 9);
            this.lblPowerfulCarTitle.Name = "lblPowerfulCarTitle";
            this.lblPowerfulCarTitle.Size = new System.Drawing.Size(132, 16);
            this.lblPowerfulCarTitle.TabIndex = 4;
            this.lblPowerfulCarTitle.Text = "Most Powerful Car";
            // 
            // picPowerfulCar
            // 
            this.picPowerfulCar.Image = global::System.CPC.App.Properties.Resources.turbo_icon_sticker_1568147604_1651447;
            this.picPowerfulCar.Location = new System.Drawing.Point(40, 28);
            this.picPowerfulCar.Name = "picPowerfulCar";
            this.picPowerfulCar.Size = new System.Drawing.Size(68, 68);
            this.picPowerfulCar.TabIndex = 3;
            this.picPowerfulCar.TabStop = false;
            // 
            // lblPowerfulCarValue
            // 
            this.lblPowerfulCarValue.AutoSize = true;
            this.lblPowerfulCarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerfulCarValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPowerfulCarValue.Location = new System.Drawing.Point(10, 99);
            this.lblPowerfulCarValue.Name = "lblPowerfulCarValue";
            this.lblPowerfulCarValue.Size = new System.Drawing.Size(72, 25);
            this.lblPowerfulCarValue.TabIndex = 1;
            this.lblPowerfulCarValue.Text = "Value";
            // 
            // lblPowerfulCar
            // 
            this.lblPowerfulCar.AutoSize = true;
            this.lblPowerfulCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerfulCar.Location = new System.Drawing.Point(12, 127);
            this.lblPowerfulCar.Name = "lblPowerfulCar";
            this.lblPowerfulCar.Size = new System.Drawing.Size(29, 15);
            this.lblPowerfulCar.TabIndex = 2;
            this.lblPowerfulCar.Text = "Car";
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(201, 26);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(863, 46);
            this.panTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(11, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Power Statistics";
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // FrmStatisticsPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.panFields);
            this.Controls.Add(this.panTitle);
            this.Name = "FrmStatisticsPower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Power Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panFields.ResumeLayout(false);
            this.panFields.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).EndInit();
            this.panLoad.ResumeLayout(false);
            this.panLoad.PerformLayout();
            this.panAvgPower.ResumeLayout(false);
            this.panAvgPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).EndInit();
            this.panPowerfulCar.ResumeLayout(false);
            this.panPowerfulCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerfulCar)).EndInit();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panFields;
        private Windows.Forms.Label lblTopCustomChart;
        private Windows.Forms.Button btnCompare;
        private Windows.Forms.Label lblTopPowerChart;
        private Windows.Forms.Panel panSearch;
        private Windows.Forms.Button btnClear;
        private Windows.Forms.Label lblFilterModel;
        private Windows.Forms.PictureBox picFilter;
        private Windows.Forms.TextBox txtFilterModel;
        private Windows.Forms.DataGridView dgvCars;
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
        private Windows.Forms.Button btnExportCustomPower;
        private Windows.Forms.Button btnExportPower;
        private Windows.Forms.DataVisualization.Charting.Chart chartCustomPower;
        private Windows.Forms.DataVisualization.Charting.Chart chartPower;
        private Windows.Forms.Panel panLoad;
        private Windows.Forms.ProgressBar pbLoading;
        private Windows.Forms.Label lblLoading;
        private Windows.Forms.Panel panAvgPower;
        private Windows.Forms.PictureBox picAvg;
        private Windows.Forms.Label lblAvgValue;
        private Windows.Forms.Label lblAvg;
        private Windows.Forms.Panel panPowerfulCar;
        private Windows.Forms.Label lblPowerfulCarTitle;
        private Windows.Forms.PictureBox picPowerfulCar;
        private Windows.Forms.Label lblPowerfulCarValue;
        private Windows.Forms.Label lblPowerfulCar;
        private Windows.Forms.Panel panTitle;
        private Windows.Forms.Label lblTitle;
        private Windows.Forms.Timer timerLoading;
        private Windows.Forms.ToolTip toolTip;
    }
}