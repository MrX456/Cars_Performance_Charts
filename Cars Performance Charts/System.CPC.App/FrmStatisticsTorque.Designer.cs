namespace System.CPC.App
{
    partial class FrmStatisticsTorque
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
            this.lblTopTorqueChart = new System.Windows.Forms.Label();
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
            this.btnExportCustomTorque = new System.Windows.Forms.Button();
            this.btnExportTorque = new System.Windows.Forms.Button();
            this.chartCustomTorque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTorque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panAvgTorque = new System.Windows.Forms.Panel();
            this.picAvg = new System.Windows.Forms.PictureBox();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.panTorqueCar = new System.Windows.Forms.Panel();
            this.lblTorqueCarTitle = new System.Windows.Forms.Label();
            this.picTorqueCar = new System.Windows.Forms.PictureBox();
            this.lblTorqueCarValue = new System.Windows.Forms.Label();
            this.lblTorqueCar = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTorque)).BeginInit();
            this.panAvgTorque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).BeginInit();
            this.panTorqueCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTorqueCar)).BeginInit();
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
            this.panFields.Controls.Add(this.lblTopTorqueChart);
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
            this.panFields.Controls.Add(this.btnExportCustomTorque);
            this.panFields.Controls.Add(this.btnExportTorque);
            this.panFields.Controls.Add(this.chartCustomTorque);
            this.panFields.Controls.Add(this.chartTorque);
            this.panFields.Controls.Add(this.panAvgTorque);
            this.panFields.Controls.Add(this.panTorqueCar);
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
            this.lblTopCustomChart.Location = new System.Drawing.Point(578, 249);
            this.lblTopCustomChart.Name = "lblTopCustomChart";
            this.lblTopCustomChart.Size = new System.Drawing.Size(145, 16);
            this.lblTopCustomChart.TabIndex = 47;
            this.lblTopCustomChart.Text = "Torque Comparison";
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
            // lblTopTorqueChart
            // 
            this.lblTopTorqueChart.AutoSize = true;
            this.lblTopTorqueChart.BackColor = System.Drawing.Color.White;
            this.lblTopTorqueChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTorqueChart.Location = new System.Drawing.Point(155, 249);
            this.lblTopTorqueChart.Name = "lblTopTorqueChart";
            this.lblTopTorqueChart.Size = new System.Drawing.Size(102, 16);
            this.lblTopTorqueChart.TabIndex = 4;
            this.lblTopTorqueChart.Text = "Top 5 Torque";
            this.lblTopTorqueChart.Visible = false;
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
            // btnExportCustomTorque
            // 
            this.btnExportCustomTorque.BackColor = System.Drawing.Color.Crimson;
            this.btnExportCustomTorque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCustomTorque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportCustomTorque.Location = new System.Drawing.Point(759, 461);
            this.btnExportCustomTorque.Name = "btnExportCustomTorque";
            this.btnExportCustomTorque.Size = new System.Drawing.Size(75, 23);
            this.btnExportCustomTorque.TabIndex = 11;
            this.btnExportCustomTorque.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportCustomTorque, "Export chart");
            this.btnExportCustomTorque.UseVisualStyleBackColor = false;
            this.btnExportCustomTorque.Visible = false;
            this.btnExportCustomTorque.Click += new System.EventHandler(this.btnExportCustomTorque_Click);
            // 
            // btnExportTorque
            // 
            this.btnExportTorque.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportTorque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportTorque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportTorque.Location = new System.Drawing.Point(309, 461);
            this.btnExportTorque.Name = "btnExportTorque";
            this.btnExportTorque.Size = new System.Drawing.Size(75, 23);
            this.btnExportTorque.TabIndex = 10;
            this.btnExportTorque.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportTorque, "Export chart");
            this.btnExportTorque.UseVisualStyleBackColor = false;
            this.btnExportTorque.Visible = false;
            this.btnExportTorque.Click += new System.EventHandler(this.btnExportTorque_Click);
            // 
            // chartCustomTorque
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCustomTorque.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCustomTorque.Legends.Add(legend1);
            this.chartCustomTorque.Location = new System.Drawing.Point(451, 249);
            this.chartCustomTorque.Name = "chartCustomTorque";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.LegendText = "Torque Nm";
            series1.Name = "Torque";
            this.chartCustomTorque.Series.Add(series1);
            this.chartCustomTorque.Size = new System.Drawing.Size(412, 262);
            this.chartCustomTorque.TabIndex = 9;
            this.chartCustomTorque.Text = "chartCustomTorque";
            this.chartCustomTorque.Visible = false;
            // 
            // chartTorque
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTorque.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTorque.Legends.Add(legend2);
            this.chartTorque.Location = new System.Drawing.Point(0, 249);
            this.chartTorque.Name = "chartTorque";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.LabelBorderWidth = 2;
            series2.Legend = "Legend1";
            series2.LegendText = "Torque Nm";
            series2.Name = "Torque";
            this.chartTorque.Series.Add(series2);
            this.chartTorque.Size = new System.Drawing.Size(412, 262);
            this.chartTorque.TabIndex = 8;
            this.chartTorque.Text = "chartPower";
            this.chartTorque.Visible = false;
            // 
            // panAvgTorque
            // 
            this.panAvgTorque.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panAvgTorque.Controls.Add(this.picAvg);
            this.panAvgTorque.Controls.Add(this.lblAvgValue);
            this.panAvgTorque.Controls.Add(this.lblAvg);
            this.panAvgTorque.Location = new System.Drawing.Point(180, 25);
            this.panAvgTorque.Name = "panAvgTorque";
            this.panAvgTorque.Size = new System.Drawing.Size(149, 154);
            this.panAvgTorque.TabIndex = 4;
            this.panAvgTorque.Visible = false;
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
            this.lblAvg.Size = new System.Drawing.Size(89, 16);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "Torque Avg";
            // 
            // panTorqueCar
            // 
            this.panTorqueCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panTorqueCar.Controls.Add(this.lblTorqueCarTitle);
            this.panTorqueCar.Controls.Add(this.picTorqueCar);
            this.panTorqueCar.Controls.Add(this.lblTorqueCarValue);
            this.panTorqueCar.Controls.Add(this.lblTorqueCar);
            this.panTorqueCar.Location = new System.Drawing.Point(0, 25);
            this.panTorqueCar.Name = "panTorqueCar";
            this.panTorqueCar.Size = new System.Drawing.Size(149, 154);
            this.panTorqueCar.TabIndex = 0;
            this.panTorqueCar.Visible = false;
            // 
            // lblTorqueCarTitle
            // 
            this.lblTorqueCarTitle.AutoSize = true;
            this.lblTorqueCarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorqueCarTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTorqueCarTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTorqueCarTitle.Name = "lblTorqueCarTitle";
            this.lblTorqueCarTitle.Size = new System.Drawing.Size(123, 16);
            this.lblTorqueCarTitle.TabIndex = 4;
            this.lblTorqueCarTitle.Text = "Most Torque Car";
            // 
            // picTorqueCar
            // 
            this.picTorqueCar.Image = global::System.CPC.App.Properties.Resources.color_vector_icon_auto_moto_260nw_1631276833;
            this.picTorqueCar.Location = new System.Drawing.Point(40, 28);
            this.picTorqueCar.Name = "picTorqueCar";
            this.picTorqueCar.Size = new System.Drawing.Size(68, 68);
            this.picTorqueCar.TabIndex = 3;
            this.picTorqueCar.TabStop = false;
            // 
            // lblTorqueCarValue
            // 
            this.lblTorqueCarValue.AutoSize = true;
            this.lblTorqueCarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorqueCarValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTorqueCarValue.Location = new System.Drawing.Point(10, 99);
            this.lblTorqueCarValue.Name = "lblTorqueCarValue";
            this.lblTorqueCarValue.Size = new System.Drawing.Size(72, 25);
            this.lblTorqueCarValue.TabIndex = 1;
            this.lblTorqueCarValue.Text = "Value";
            // 
            // lblTorqueCar
            // 
            this.lblTorqueCar.AutoSize = true;
            this.lblTorqueCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorqueCar.Location = new System.Drawing.Point(12, 127);
            this.lblTorqueCar.Name = "lblTorqueCar";
            this.lblTorqueCar.Size = new System.Drawing.Size(29, 15);
            this.lblTorqueCar.TabIndex = 2;
            this.lblTorqueCar.Text = "Car";
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
            this.lblTitle.Size = new System.Drawing.Size(164, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Torque Statistics";
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
            // FrmStatisticsTorque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.panFields);
            this.Controls.Add(this.panTitle);
            this.Name = "FrmStatisticsTorque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Torque Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panFields.ResumeLayout(false);
            this.panFields.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTorque)).EndInit();
            this.panAvgTorque.ResumeLayout(false);
            this.panAvgTorque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).EndInit();
            this.panTorqueCar.ResumeLayout(false);
            this.panTorqueCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTorqueCar)).EndInit();
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
        private Windows.Forms.Label lblTopTorqueChart;
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
        private Windows.Forms.Button btnExportCustomTorque;
        private Windows.Forms.Button btnExportTorque;
        private Windows.Forms.DataVisualization.Charting.Chart chartCustomTorque;
        private Windows.Forms.DataVisualization.Charting.Chart chartTorque;
        private Windows.Forms.Panel panAvgTorque;
        private Windows.Forms.PictureBox picAvg;
        private Windows.Forms.Label lblAvgValue;
        private Windows.Forms.Label lblAvg;
        private Windows.Forms.Panel panTorqueCar;
        private Windows.Forms.Label lblTorqueCarTitle;
        private Windows.Forms.PictureBox picTorqueCar;
        private Windows.Forms.Label lblTorqueCarValue;
        private Windows.Forms.Label lblTorqueCar;
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