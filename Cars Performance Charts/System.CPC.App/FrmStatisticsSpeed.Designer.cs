namespace System.CPC.App
{
    partial class FrmStatisticsSpeed
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panFields = new System.Windows.Forms.Panel();
            this.lblTopCustomChart = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblTopSpeedChart = new System.Windows.Forms.Label();
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
            this.btnExportCustomSpeed = new System.Windows.Forms.Button();
            this.btnExportSpeed = new System.Windows.Forms.Button();
            this.chartCustomSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panAvgSpeed = new System.Windows.Forms.Panel();
            this.picAvg = new System.Windows.Forms.PictureBox();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.panFastestCar = new System.Windows.Forms.Panel();
            this.lblFastestCarTitle = new System.Windows.Forms.Label();
            this.picFastestCar = new System.Windows.Forms.PictureBox();
            this.lblFastestCarValue = new System.Windows.Forms.Label();
            this.lblFastestCar = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panLoad = new System.Windows.Forms.Panel();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panFields.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            this.panAvgSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).BeginInit();
            this.panFastestCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFastestCar)).BeginInit();
            this.panTitle.SuspendLayout();
            this.panLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panFields
            // 
            this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panFields.Controls.Add(this.panLoad);
            this.panFields.Controls.Add(this.lblTopCustomChart);
            this.panFields.Controls.Add(this.btnCompare);
            this.panFields.Controls.Add(this.lblTopSpeedChart);
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
            this.panFields.Controls.Add(this.btnExportCustomSpeed);
            this.panFields.Controls.Add(this.btnExportSpeed);
            this.panFields.Controls.Add(this.chartCustomSpeed);
            this.panFields.Controls.Add(this.chartSpeed);
            this.panFields.Controls.Add(this.panAvgSpeed);
            this.panFields.Controls.Add(this.panFastestCar);
            this.panFields.Location = new System.Drawing.Point(201, 103);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(863, 535);
            this.panFields.TabIndex = 7;
            // 
            // lblTopCustomChart
            // 
            this.lblTopCustomChart.AutoSize = true;
            this.lblTopCustomChart.BackColor = System.Drawing.Color.White;
            this.lblTopCustomChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopCustomChart.Location = new System.Drawing.Point(559, 249);
            this.lblTopCustomChart.Name = "lblTopCustomChart";
            this.lblTopCustomChart.Size = new System.Drawing.Size(173, 16);
            this.lblTopCustomChart.TabIndex = 47;
            this.lblTopCustomChart.Text = "Max Speed Comparison";
            this.lblTopCustomChart.Visible = false;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.Navy;
            this.btnCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompare.Enabled = false;
            this.btnCompare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompare.Location = new System.Drawing.Point(684, 158);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(176, 23);
            this.btnCompare.TabIndex = 46;
            this.btnCompare.Text = "Compare models";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Visible = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblTopSpeedChart
            // 
            this.lblTopSpeedChart.AutoSize = true;
            this.lblTopSpeedChart.BackColor = System.Drawing.Color.White;
            this.lblTopSpeedChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSpeedChart.Location = new System.Drawing.Point(132, 249);
            this.lblTopSpeedChart.Name = "lblTopSpeedChart";
            this.lblTopSpeedChart.Size = new System.Drawing.Size(130, 16);
            this.lblTopSpeedChart.TabIndex = 4;
            this.lblTopSpeedChart.Text = "Top 5 Max Speed";
            this.lblTopSpeedChart.Visible = false;
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
            this.lblCarFiveModel.Location = new System.Drawing.Point(681, 142);
            this.lblCarFiveModel.Name = "lblCarFiveModel";
            this.lblCarFiveModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarFiveModel.TabIndex = 44;
            this.lblCarFiveModel.Text = "Skyline R33 GTR";
            this.lblCarFiveModel.Visible = false;
            // 
            // lblCarFiveID
            // 
            this.lblCarFiveID.AutoSize = true;
            this.lblCarFiveID.Location = new System.Drawing.Point(653, 142);
            this.lblCarFiveID.Name = "lblCarFiveID";
            this.lblCarFiveID.Size = new System.Drawing.Size(13, 13);
            this.lblCarFiveID.TabIndex = 43;
            this.lblCarFiveID.Text = "1";
            this.lblCarFiveID.Visible = false;
            // 
            // lblCarFourModel
            // 
            this.lblCarFourModel.AutoSize = true;
            this.lblCarFourModel.Location = new System.Drawing.Point(533, 155);
            this.lblCarFourModel.Name = "lblCarFourModel";
            this.lblCarFourModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarFourModel.TabIndex = 42;
            this.lblCarFourModel.Text = "Skyline R33 GTR";
            this.lblCarFourModel.Visible = false;
            // 
            // lblCarFourID
            // 
            this.lblCarFourID.AutoSize = true;
            this.lblCarFourID.Location = new System.Drawing.Point(505, 155);
            this.lblCarFourID.Name = "lblCarFourID";
            this.lblCarFourID.Size = new System.Drawing.Size(13, 13);
            this.lblCarFourID.TabIndex = 41;
            this.lblCarFourID.Text = "1";
            this.lblCarFourID.Visible = false;
            // 
            // lblCarThreeModel
            // 
            this.lblCarThreeModel.AutoSize = true;
            this.lblCarThreeModel.Location = new System.Drawing.Point(533, 142);
            this.lblCarThreeModel.Name = "lblCarThreeModel";
            this.lblCarThreeModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarThreeModel.TabIndex = 40;
            this.lblCarThreeModel.Text = "Skyline R33 GTR";
            this.lblCarThreeModel.Visible = false;
            // 
            // lblCarThreeID
            // 
            this.lblCarThreeID.AutoSize = true;
            this.lblCarThreeID.Location = new System.Drawing.Point(505, 142);
            this.lblCarThreeID.Name = "lblCarThreeID";
            this.lblCarThreeID.Size = new System.Drawing.Size(13, 13);
            this.lblCarThreeID.TabIndex = 39;
            this.lblCarThreeID.Text = "1";
            this.lblCarThreeID.Visible = false;
            // 
            // lblCarTwoModel
            // 
            this.lblCarTwoModel.AutoSize = true;
            this.lblCarTwoModel.Location = new System.Drawing.Point(394, 155);
            this.lblCarTwoModel.Name = "lblCarTwoModel";
            this.lblCarTwoModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarTwoModel.TabIndex = 38;
            this.lblCarTwoModel.Text = "Skyline R33 GTR";
            this.lblCarTwoModel.Visible = false;
            // 
            // lblCarTwoID
            // 
            this.lblCarTwoID.AutoSize = true;
            this.lblCarTwoID.Location = new System.Drawing.Point(366, 155);
            this.lblCarTwoID.Name = "lblCarTwoID";
            this.lblCarTwoID.Size = new System.Drawing.Size(13, 13);
            this.lblCarTwoID.TabIndex = 37;
            this.lblCarTwoID.Text = "1";
            this.lblCarTwoID.Visible = false;
            // 
            // lblCarOneModel
            // 
            this.lblCarOneModel.AutoSize = true;
            this.lblCarOneModel.Location = new System.Drawing.Point(394, 142);
            this.lblCarOneModel.Name = "lblCarOneModel";
            this.lblCarOneModel.Size = new System.Drawing.Size(90, 13);
            this.lblCarOneModel.TabIndex = 36;
            this.lblCarOneModel.Text = "Skyline R33 GTR";
            this.lblCarOneModel.Visible = false;
            // 
            // lblCarOneID
            // 
            this.lblCarOneID.AutoSize = true;
            this.lblCarOneID.Location = new System.Drawing.Point(366, 142);
            this.lblCarOneID.Name = "lblCarOneID";
            this.lblCarOneID.Size = new System.Drawing.Size(13, 13);
            this.lblCarOneID.TabIndex = 35;
            this.lblCarOneID.Text = "1";
            this.lblCarOneID.Visible = false;
            // 
            // btnExportCustomSpeed
            // 
            this.btnExportCustomSpeed.BackColor = System.Drawing.Color.Crimson;
            this.btnExportCustomSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCustomSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportCustomSpeed.Location = new System.Drawing.Point(759, 461);
            this.btnExportCustomSpeed.Name = "btnExportCustomSpeed";
            this.btnExportCustomSpeed.Size = new System.Drawing.Size(75, 23);
            this.btnExportCustomSpeed.TabIndex = 11;
            this.btnExportCustomSpeed.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportCustomSpeed, "Export chart");
            this.btnExportCustomSpeed.UseVisualStyleBackColor = false;
            this.btnExportCustomSpeed.Visible = false;
            this.btnExportCustomSpeed.Click += new System.EventHandler(this.btnExportCustomSpeed_Click);
            // 
            // btnExportSpeed
            // 
            this.btnExportSpeed.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportSpeed.Location = new System.Drawing.Point(309, 461);
            this.btnExportSpeed.Name = "btnExportSpeed";
            this.btnExportSpeed.Size = new System.Drawing.Size(75, 23);
            this.btnExportSpeed.TabIndex = 10;
            this.btnExportSpeed.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportSpeed, "Export chart");
            this.btnExportSpeed.UseVisualStyleBackColor = false;
            this.btnExportSpeed.Visible = false;
            this.btnExportSpeed.Click += new System.EventHandler(this.btnExportSpeed_Click);
            // 
            // chartCustomSpeed
            // 
            chartArea5.Name = "ChartArea1";
            this.chartCustomSpeed.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartCustomSpeed.Legends.Add(legend5);
            this.chartCustomSpeed.Location = new System.Drawing.Point(451, 249);
            this.chartCustomSpeed.Name = "chartCustomSpeed";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.IsValueShownAsLabel = true;
            series5.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series5.LabelBorderWidth = 2;
            series5.Legend = "Legend1";
            series5.LegendText = "Speed mph";
            series5.Name = "Speed";
            this.chartCustomSpeed.Series.Add(series5);
            this.chartCustomSpeed.Size = new System.Drawing.Size(412, 262);
            this.chartCustomSpeed.TabIndex = 9;
            this.chartCustomSpeed.Text = "chartCustomSpeed";
            this.chartCustomSpeed.Visible = false;
            // 
            // chartSpeed
            // 
            chartArea6.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend6);
            this.chartSpeed.Location = new System.Drawing.Point(0, 249);
            this.chartSpeed.Name = "chartSpeed";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsValueShownAsLabel = true;
            series6.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series6.LabelBorderWidth = 2;
            series6.Legend = "Legend1";
            series6.LegendText = "Speed mph";
            series6.Name = "Speed";
            this.chartSpeed.Series.Add(series6);
            this.chartSpeed.Size = new System.Drawing.Size(412, 262);
            this.chartSpeed.TabIndex = 8;
            this.chartSpeed.Text = "chartSpeed";
            this.chartSpeed.Visible = false;
            // 
            // panAvgSpeed
            // 
            this.panAvgSpeed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panAvgSpeed.Controls.Add(this.picAvg);
            this.panAvgSpeed.Controls.Add(this.lblAvgValue);
            this.panAvgSpeed.Controls.Add(this.lblAvg);
            this.panAvgSpeed.Location = new System.Drawing.Point(180, 25);
            this.panAvgSpeed.Name = "panAvgSpeed";
            this.panAvgSpeed.Size = new System.Drawing.Size(149, 154);
            this.panAvgSpeed.TabIndex = 4;
            this.panAvgSpeed.Visible = false;
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
            this.lblAvg.Size = new System.Drawing.Size(117, 16);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "Max Speed Avg";
            // 
            // panFastestCar
            // 
            this.panFastestCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFastestCar.Controls.Add(this.lblFastestCarTitle);
            this.panFastestCar.Controls.Add(this.picFastestCar);
            this.panFastestCar.Controls.Add(this.lblFastestCarValue);
            this.panFastestCar.Controls.Add(this.lblFastestCar);
            this.panFastestCar.Location = new System.Drawing.Point(0, 25);
            this.panFastestCar.Name = "panFastestCar";
            this.panFastestCar.Size = new System.Drawing.Size(149, 154);
            this.panFastestCar.TabIndex = 0;
            this.panFastestCar.Visible = false;
            // 
            // lblFastestCarTitle
            // 
            this.lblFastestCarTitle.AutoSize = true;
            this.lblFastestCarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastestCarTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblFastestCarTitle.Location = new System.Drawing.Point(12, 9);
            this.lblFastestCarTitle.Name = "lblFastestCarTitle";
            this.lblFastestCarTitle.Size = new System.Drawing.Size(87, 16);
            this.lblFastestCarTitle.TabIndex = 4;
            this.lblFastestCarTitle.Text = "Fastest Car";
            // 
            // picFastestCar
            // 
            this.picFastestCar.Image = global::System.CPC.App.Properties.Resources.speed_64;
            this.picFastestCar.Location = new System.Drawing.Point(40, 28);
            this.picFastestCar.Name = "picFastestCar";
            this.picFastestCar.Size = new System.Drawing.Size(68, 68);
            this.picFastestCar.TabIndex = 3;
            this.picFastestCar.TabStop = false;
            // 
            // lblFastestCarValue
            // 
            this.lblFastestCarValue.AutoSize = true;
            this.lblFastestCarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastestCarValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFastestCarValue.Location = new System.Drawing.Point(10, 99);
            this.lblFastestCarValue.Name = "lblFastestCarValue";
            this.lblFastestCarValue.Size = new System.Drawing.Size(72, 25);
            this.lblFastestCarValue.TabIndex = 1;
            this.lblFastestCarValue.Text = "Value";
            // 
            // lblFastestCar
            // 
            this.lblFastestCar.AutoSize = true;
            this.lblFastestCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastestCar.Location = new System.Drawing.Point(12, 127);
            this.lblFastestCar.Name = "lblFastestCar";
            this.lblFastestCar.Size = new System.Drawing.Size(29, 15);
            this.lblFastestCar.TabIndex = 2;
            this.lblFastestCar.Text = "Car";
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(201, 26);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(863, 46);
            this.panTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(11, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Max Speed Statistics";
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // panLoad
            // 
            this.panLoad.Controls.Add(this.picStatus);
            this.panLoad.Controls.Add(this.pbLoading);
            this.panLoad.Controls.Add(this.lblLoading);
            this.panLoad.Location = new System.Drawing.Point(198, 185);
            this.panLoad.Name = "panLoad";
            this.panLoad.Size = new System.Drawing.Size(468, 68);
            this.panLoad.TabIndex = 48;
            // 
            // picStatus
            // 
            this.picStatus.Image = global::System.CPC.App.Properties.Resources.speedometer1;
            this.picStatus.Location = new System.Drawing.Point(206, 3);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(50, 50);
            this.picStatus.TabIndex = 2;
            this.picStatus.TabStop = false;
            // 
            // pbLoading
            // 
            this.pbLoading.ForeColor = System.Drawing.Color.MediumBlue;
            this.pbLoading.Location = new System.Drawing.Point(271, 24);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(173, 23);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLoading.TabIndex = 5;
            this.pbLoading.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLoading.Location = new System.Drawing.Point(190, 50);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(97, 13);
            this.lblLoading.TabIndex = 6;
            this.lblLoading.Text = "Loading statistics...";
            // 
            // FrmStatisticsSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.panFields);
            this.Controls.Add(this.panTitle);
            this.Name = "FrmStatisticsSpeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Speed Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panFields.ResumeLayout(false);
            this.panFields.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            this.panAvgSpeed.ResumeLayout(false);
            this.panAvgSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).EndInit();
            this.panFastestCar.ResumeLayout(false);
            this.panFastestCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFastestCar)).EndInit();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.panLoad.ResumeLayout(false);
            this.panLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panFields;
        private Windows.Forms.Label lblTopCustomChart;
        private Windows.Forms.Button btnCompare;
        private Windows.Forms.Label lblTopSpeedChart;
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
        private Windows.Forms.Button btnExportCustomSpeed;
        private Windows.Forms.Button btnExportSpeed;
        private Windows.Forms.DataVisualization.Charting.Chart chartCustomSpeed;
        private Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private Windows.Forms.Panel panAvgSpeed;
        private Windows.Forms.PictureBox picAvg;
        private Windows.Forms.Label lblAvgValue;
        private Windows.Forms.Label lblAvg;
        private Windows.Forms.Panel panFastestCar;
        private Windows.Forms.Label lblFastestCarTitle;
        private Windows.Forms.PictureBox picFastestCar;
        private Windows.Forms.Label lblFastestCarValue;
        private Windows.Forms.Label lblFastestCar;
        private Windows.Forms.Panel panTitle;
        private Windows.Forms.Label lblTitle;
        private Windows.Forms.Timer timerLoading;
        private Windows.Forms.ToolTip toolTip;
        private Windows.Forms.Panel panLoad;
        private Windows.Forms.PictureBox picStatus;
        private Windows.Forms.ProgressBar pbLoading;
        private Windows.Forms.Label lblLoading;
    }
}