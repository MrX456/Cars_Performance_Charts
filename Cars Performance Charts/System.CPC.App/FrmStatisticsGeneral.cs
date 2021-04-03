/*
 * Form responsible for show general statistics
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CPC.Model.DAO;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

/*
 * CPC / App / FrmStatisticsGeneral
 * @author MRX
 * Version : 1.0.1
 */ 

namespace System.CPC.App
{
    public partial class FrmStatisticsGeneral : Form
    {
        public FrmStatisticsGeneral()
        {
            InitializeComponent();
        }

        #region - My methods

        private void LoadingData() 
        {
            CarDAO dao = new CarDAO();

            if (pbLoading.Value < 100)
            {
                pbLoading.Value += 1;

                if (pbLoading.Value == 5)

                    lblTotalCarsValue.Text = dao.TotalCars().ToString();

                else if (pbLoading.Value == 10)

                    lblSumValue.Text = dao.SumValueTotalCars().ToString("C", CultureInfo.GetCultureInfo("en-US"));

                else if (pbLoading.Value == 20)

                    lblAvgValue.Text = dao.AvgValueCars().ToString("C", CultureInfo.GetCultureInfo("en-US"));

                else if (pbLoading.Value == 30)

                    lblExpensivestValue.Text = dao.ExpensivestCar();

                else if (pbLoading.Value == 45)

                    lblNewestValue.Text = dao.NewestCar();

                else if (pbLoading.Value == 55)

                    this.TopMakersChart();

                else if (pbLoading.Value == 80)

                    this.TopCountriesChart();
                    
            }
            else
            {
                timerLoading.Enabled = false;

                panLoad.Visible = false;

                panTotalCars.Visible = true;
                panGarageSumValue.Visible = true;
                panGarageAVGValue.Visible = true;
                panExpensivest.Visible = true;
                panNewest.Visible = true;
                btnExportMakers.Visible = true;
                btnExportContries.Visible = true;
                chartMakers.Visible = true;
                chartCountries.Visible = true;
                
            }
        }

        private void TopMakersChart() 
        {
            CarDAO dao = new CarDAO();

            Dictionary<string, int> makers = dao.TopFiveCarMakers();

            //Chart values
            foreach (KeyValuePair<string, int> entry in makers) 
            {
                this.chartMakers.Series["Makers"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        private void TopCountriesChart()
        {
            CarDAO dao = new CarDAO();

            Dictionary<string, int> countries = dao.TopFiveCarCountries();

            //Chart values
            foreach (KeyValuePair<string, int> entry in countries)
            {
                this.chartCountries.Series["Countries"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        #endregion

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            this.LoadingData();
        }

        private void btnExport1_Click(object sender, EventArgs e)
        {
            try 
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CPC Documents\\my_charts\\top5makers" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";
                this.chartMakers.SaveImage(path, ChartImageFormat.Png);

                System.Diagnostics.Process.Start(path);
            }
            catch (Exception) 
            {
                MessageBox.Show(null, "Can´t export chart. Path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            try 
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CPC Documents\\my_charts\\top5countries" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";
                this.chartCountries.SaveImage(path, ChartImageFormat.Png);

                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Can´t export chart. Path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
