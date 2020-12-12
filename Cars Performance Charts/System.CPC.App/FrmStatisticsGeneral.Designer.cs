namespace System.CPC.App
{
    partial class FrmStatisticsGeneral
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
            this.chartCountries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMakers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panLoad = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panExpensivest = new System.Windows.Forms.Panel();
            this.lblExpensivestValue = new System.Windows.Forms.Label();
            this.picExpensivest = new System.Windows.Forms.PictureBox();
            this.lblExpensivest = new System.Windows.Forms.Label();
            this.panNewest = new System.Windows.Forms.Panel();
            this.lblNewestValue = new System.Windows.Forms.Label();
            this.picNewest = new System.Windows.Forms.PictureBox();
            this.lblNewest = new System.Windows.Forms.Label();
            this.panGarageSumValue = new System.Windows.Forms.Panel();
            this.picSum = new System.Windows.Forms.PictureBox();
            this.lblSumValue = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.panGarageAVGValue = new System.Windows.Forms.Panel();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.picAvg = new System.Windows.Forms.PictureBox();
            this.lblAvgGarage = new System.Windows.Forms.Label();
            this.panTotalCars = new System.Windows.Forms.Panel();
            this.picTotalCars = new System.Windows.Forms.PictureBox();
            this.lblTotalCarsValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.btnExportMakers = new System.Windows.Forms.Button();
            this.btnExportContries = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMakers)).BeginInit();
            this.panLoad.SuspendLayout();
            this.panExpensivest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpensivest)).BeginInit();
            this.panNewest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewest)).BeginInit();
            this.panGarageSumValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSum)).BeginInit();
            this.panGarageAVGValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).BeginInit();
            this.panTotalCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalCars)).BeginInit();
            this.panTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFields
            // 
            this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panFields.Controls.Add(this.btnExportContries);
            this.panFields.Controls.Add(this.btnExportMakers);
            this.panFields.Controls.Add(this.chartCountries);
            this.panFields.Controls.Add(this.chartMakers);
            this.panFields.Controls.Add(this.panLoad);
            this.panFields.Controls.Add(this.panExpensivest);
            this.panFields.Controls.Add(this.panNewest);
            this.panFields.Controls.Add(this.panGarageSumValue);
            this.panFields.Controls.Add(this.panGarageAVGValue);
            this.panFields.Controls.Add(this.panTotalCars);
            this.panFields.Location = new System.Drawing.Point(201, 103);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(863, 535);
            this.panFields.TabIndex = 1;
            // 
            // chartCountries
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCountries.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCountries.Legends.Add(legend1);
            this.chartCountries.Location = new System.Drawing.Point(451, 249);
            this.chartCountries.Name = "chartCountries";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.LegendText = "Cars by country top 5";
            series1.Name = "Countries";
            this.chartCountries.Series.Add(series1);
            this.chartCountries.Size = new System.Drawing.Size(412, 262);
            this.chartCountries.TabIndex = 9;
            this.chartCountries.Text = "chartCountries";
            this.chartCountries.Visible = false;
            // 
            // chartMakers
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMakers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMakers.Legends.Add(legend2);
            this.chartMakers.Location = new System.Drawing.Point(0, 249);
            this.chartMakers.Name = "chartMakers";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.LabelBorderWidth = 2;
            series2.Legend = "Legend1";
            series2.LegendText = "Cars by maker top 5";
            series2.Name = "Makers";
            this.chartMakers.Series.Add(series2);
            this.chartMakers.Size = new System.Drawing.Size(412, 262);
            this.chartMakers.TabIndex = 8;
            this.chartMakers.Text = "chartMakers";
            this.chartMakers.Visible = false;
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
            // panExpensivest
            // 
            this.panExpensivest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panExpensivest.Controls.Add(this.lblExpensivestValue);
            this.panExpensivest.Controls.Add(this.picExpensivest);
            this.panExpensivest.Controls.Add(this.lblExpensivest);
            this.panExpensivest.Location = new System.Drawing.Point(538, 25);
            this.panExpensivest.Name = "panExpensivest";
            this.panExpensivest.Size = new System.Drawing.Size(149, 154);
            this.panExpensivest.TabIndex = 4;
            this.panExpensivest.Visible = false;
            // 
            // lblExpensivestValue
            // 
            this.lblExpensivestValue.AutoSize = true;
            this.lblExpensivestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensivestValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblExpensivestValue.Location = new System.Drawing.Point(3, 102);
            this.lblExpensivestValue.Name = "lblExpensivestValue";
            this.lblExpensivestValue.Size = new System.Drawing.Size(43, 15);
            this.lblExpensivestValue.TabIndex = 6;
            this.lblExpensivestValue.Text = "Value";
            // 
            // picExpensivest
            // 
            this.picExpensivest.Image = global::System.CPC.App.Properties.Resources.expensive_64;
            this.picExpensivest.Location = new System.Drawing.Point(36, 12);
            this.picExpensivest.Name = "picExpensivest";
            this.picExpensivest.Size = new System.Drawing.Size(68, 68);
            this.picExpensivest.TabIndex = 3;
            this.picExpensivest.TabStop = false;
            // 
            // lblExpensivest
            // 
            this.lblExpensivest.AutoSize = true;
            this.lblExpensivest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensivest.Location = new System.Drawing.Point(12, 127);
            this.lblExpensivest.Name = "lblExpensivest";
            this.lblExpensivest.Size = new System.Drawing.Size(135, 16);
            this.lblExpensivest.TabIndex = 2;
            this.lblExpensivest.Text = "Most Valuable Car";
            // 
            // panNewest
            // 
            this.panNewest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panNewest.Controls.Add(this.lblNewestValue);
            this.panNewest.Controls.Add(this.picNewest);
            this.panNewest.Controls.Add(this.lblNewest);
            this.panNewest.Location = new System.Drawing.Point(714, 25);
            this.panNewest.Name = "panNewest";
            this.panNewest.Size = new System.Drawing.Size(149, 154);
            this.panNewest.TabIndex = 4;
            this.panNewest.Visible = false;
            // 
            // lblNewestValue
            // 
            this.lblNewestValue.AutoSize = true;
            this.lblNewestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewestValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNewestValue.Location = new System.Drawing.Point(3, 102);
            this.lblNewestValue.Name = "lblNewestValue";
            this.lblNewestValue.Size = new System.Drawing.Size(43, 15);
            this.lblNewestValue.TabIndex = 5;
            this.lblNewestValue.Text = "Value";
            // 
            // picNewest
            // 
            this.picNewest.Image = global::System.CPC.App.Properties.Resources.new_badge_64;
            this.picNewest.Location = new System.Drawing.Point(36, 12);
            this.picNewest.Name = "picNewest";
            this.picNewest.Size = new System.Drawing.Size(68, 68);
            this.picNewest.TabIndex = 3;
            this.picNewest.TabStop = false;
            // 
            // lblNewest
            // 
            this.lblNewest.AutoSize = true;
            this.lblNewest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewest.Location = new System.Drawing.Point(12, 127);
            this.lblNewest.Name = "lblNewest";
            this.lblNewest.Size = new System.Drawing.Size(87, 16);
            this.lblNewest.TabIndex = 2;
            this.lblNewest.Text = "Newest Car";
            // 
            // panGarageSumValue
            // 
            this.panGarageSumValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panGarageSumValue.Controls.Add(this.picSum);
            this.panGarageSumValue.Controls.Add(this.lblSumValue);
            this.panGarageSumValue.Controls.Add(this.lblSum);
            this.panGarageSumValue.Location = new System.Drawing.Point(180, 25);
            this.panGarageSumValue.Name = "panGarageSumValue";
            this.panGarageSumValue.Size = new System.Drawing.Size(149, 154);
            this.panGarageSumValue.TabIndex = 4;
            this.panGarageSumValue.Visible = false;
            // 
            // picSum
            // 
            this.picSum.Image = global::System.CPC.App.Properties.Resources.price_tag_64;
            this.picSum.Location = new System.Drawing.Point(36, 12);
            this.picSum.Name = "picSum";
            this.picSum.Size = new System.Drawing.Size(68, 68);
            this.picSum.TabIndex = 3;
            this.picSum.TabStop = false;
            // 
            // lblSumValue
            // 
            this.lblSumValue.AutoSize = true;
            this.lblSumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSumValue.Location = new System.Drawing.Point(3, 99);
            this.lblSumValue.Name = "lblSumValue";
            this.lblSumValue.Size = new System.Drawing.Size(43, 15);
            this.lblSumValue.TabIndex = 1;
            this.lblSumValue.Text = "Value";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(12, 127);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(104, 16);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Garage Value";
            // 
            // panGarageAVGValue
            // 
            this.panGarageAVGValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panGarageAVGValue.Controls.Add(this.lblAvgValue);
            this.panGarageAVGValue.Controls.Add(this.picAvg);
            this.panGarageAVGValue.Controls.Add(this.lblAvgGarage);
            this.panGarageAVGValue.Location = new System.Drawing.Point(360, 25);
            this.panGarageAVGValue.Name = "panGarageAVGValue";
            this.panGarageAVGValue.Size = new System.Drawing.Size(149, 154);
            this.panGarageAVGValue.TabIndex = 4;
            this.panGarageAVGValue.Visible = false;
            // 
            // lblAvgValue
            // 
            this.lblAvgValue.AutoSize = true;
            this.lblAvgValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAvgValue.Location = new System.Drawing.Point(3, 99);
            this.lblAvgValue.Name = "lblAvgValue";
            this.lblAvgValue.Size = new System.Drawing.Size(49, 18);
            this.lblAvgValue.TabIndex = 4;
            this.lblAvgValue.Text = "Value";
            // 
            // picAvg
            // 
            this.picAvg.Image = global::System.CPC.App.Properties.Resources.procent_badge_64;
            this.picAvg.Location = new System.Drawing.Point(36, 12);
            this.picAvg.Name = "picAvg";
            this.picAvg.Size = new System.Drawing.Size(68, 68);
            this.picAvg.TabIndex = 3;
            this.picAvg.TabStop = false;
            // 
            // lblAvgGarage
            // 
            this.lblAvgGarage.AutoSize = true;
            this.lblAvgGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGarage.Location = new System.Drawing.Point(11, 127);
            this.lblAvgGarage.Name = "lblAvgGarage";
            this.lblAvgGarage.Size = new System.Drawing.Size(135, 16);
            this.lblAvgGarage.TabIndex = 2;
            this.lblAvgGarage.Text = "Garage Value Avg";
            // 
            // panTotalCars
            // 
            this.panTotalCars.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panTotalCars.Controls.Add(this.picTotalCars);
            this.panTotalCars.Controls.Add(this.lblTotalCarsValue);
            this.panTotalCars.Controls.Add(this.lblTotal);
            this.panTotalCars.Location = new System.Drawing.Point(0, 25);
            this.panTotalCars.Name = "panTotalCars";
            this.panTotalCars.Size = new System.Drawing.Size(149, 154);
            this.panTotalCars.TabIndex = 0;
            this.panTotalCars.Visible = false;
            // 
            // picTotalCars
            // 
            this.picTotalCars.Image = global::System.CPC.App.Properties.Resources.car_4_64;
            this.picTotalCars.Location = new System.Drawing.Point(36, 12);
            this.picTotalCars.Name = "picTotalCars";
            this.picTotalCars.Size = new System.Drawing.Size(68, 68);
            this.picTotalCars.TabIndex = 3;
            this.picTotalCars.TabStop = false;
            // 
            // lblTotalCarsValue
            // 
            this.lblTotalCarsValue.AutoSize = true;
            this.lblTotalCarsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCarsValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTotalCarsValue.Location = new System.Drawing.Point(10, 92);
            this.lblTotalCarsValue.Name = "lblTotalCarsValue";
            this.lblTotalCarsValue.Size = new System.Drawing.Size(72, 25);
            this.lblTotalCarsValue.TabIndex = 1;
            this.lblTotalCarsValue.Text = "Value";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total Cars";
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(201, 26);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(863, 46);
            this.panTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(11, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "General Statistics";
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // btnExportMakers
            // 
            this.btnExportMakers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportMakers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportMakers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportMakers.Location = new System.Drawing.Point(299, 461);
            this.btnExportMakers.Name = "btnExportMakers";
            this.btnExportMakers.Size = new System.Drawing.Size(75, 23);
            this.btnExportMakers.TabIndex = 10;
            this.btnExportMakers.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportMakers, "Export chart");
            this.btnExportMakers.UseVisualStyleBackColor = false;
            this.btnExportMakers.Visible = false;
            this.btnExportMakers.Click += new System.EventHandler(this.btnExport1_Click);
            // 
            // btnExportContries
            // 
            this.btnExportContries.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExportContries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportContries.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportContries.Location = new System.Drawing.Point(759, 461);
            this.btnExportContries.Name = "btnExportContries";
            this.btnExportContries.Size = new System.Drawing.Size(75, 23);
            this.btnExportContries.TabIndex = 11;
            this.btnExportContries.Text = "Export";
            this.toolTip.SetToolTip(this.btnExportContries, "Export chart");
            this.btnExportContries.UseVisualStyleBackColor = false;
            this.btnExportContries.Visible = false;
            this.btnExportContries.Click += new System.EventHandler(this.btnExport2_Click);
            // 
            // FrmStatisticsGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.panFields);
            this.Name = "FrmStatisticsGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "General Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMakers)).EndInit();
            this.panLoad.ResumeLayout(false);
            this.panLoad.PerformLayout();
            this.panExpensivest.ResumeLayout(false);
            this.panExpensivest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpensivest)).EndInit();
            this.panNewest.ResumeLayout(false);
            this.panNewest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewest)).EndInit();
            this.panGarageSumValue.ResumeLayout(false);
            this.panGarageSumValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSum)).EndInit();
            this.panGarageAVGValue.ResumeLayout(false);
            this.panGarageAVGValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvg)).EndInit();
            this.panTotalCars.ResumeLayout(false);
            this.panTotalCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalCars)).EndInit();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panFields;
        private Windows.Forms.Panel panTotalCars;
        private Windows.Forms.Panel panTitle;
        private Windows.Forms.PictureBox picTotalCars;
        private Windows.Forms.Label lblTotalCarsValue;
        private Windows.Forms.Label lblTotal;
        private Windows.Forms.Label lblTitle;
        private Windows.Forms.Panel panExpensivest;
        private Windows.Forms.PictureBox picExpensivest;
        private Windows.Forms.Label lblExpensivest;
        private Windows.Forms.Panel panNewest;
        private Windows.Forms.PictureBox picNewest;
        private Windows.Forms.Label lblNewest;
        private Windows.Forms.Panel panGarageSumValue;
        private Windows.Forms.PictureBox picSum;
        private Windows.Forms.Label lblSumValue;
        private Windows.Forms.Label lblSum;
        private Windows.Forms.Panel panGarageAVGValue;
        private Windows.Forms.PictureBox picAvg;
        private Windows.Forms.Label lblAvgGarage;
        private Windows.Forms.Label lblAvgValue;
        private Windows.Forms.Label lblExpensivestValue;
        private Windows.Forms.Label lblNewestValue;
        private Windows.Forms.ProgressBar pbLoading;
        private Windows.Forms.Label lblLoading;
        private Windows.Forms.Panel panLoad;
        private Windows.Forms.Timer timerLoading;
        private Windows.Forms.DataVisualization.Charting.Chart chartMakers;
        private Windows.Forms.DataVisualization.Charting.Chart chartCountries;
        private Windows.Forms.Button btnExportContries;
        private Windows.Forms.Button btnExportMakers;
        private Windows.Forms.ToolTip toolTip;
    }
}