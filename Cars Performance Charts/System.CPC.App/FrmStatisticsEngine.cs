/*
 * Form responsible for show engine statistics
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
using System.CPC.Model.Bean;
using System.Windows.Forms.DataVisualization.Charting;

/*
 * CPC / App / FrmStatisticsEngine
 * @author MRX
 * Version : 1.0.0
 */ 

namespace System.CPC.App
{
    public partial class FrmStatisticsEngine : Form
    {
        public FrmStatisticsEngine()
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

                    this.ShowData();

                else if (pbLoading.Value == 20)
                {
                    Car car = dao.BiggestEngine();

                    lblBiggestEngineCar.Text = car.Model;
                    lblBiggestEngineValue.Text = car.Engine_size + "cc";
                }
                else if (pbLoading.Value == 30)
               
                    lblAvgValue.Text = Math.Round(dao.AvgEngineSize(), 2).ToString() + "cc";
                
                else if (pbLoading.Value == 50)

                    this.TopEngineSizeChart(); 
                
            }
            else 
            {
                timerLoading.Enabled = false;

                panLoad.Visible = false;

                panBiggestEngine.Visible = true;
                panAvgEngineSize.Visible = true;
                panSearch.Visible = true;

                btnExportEngine.Visible = true;
                lblTopEngineChart.Visible = true;
                chartEngines.Visible = true;

                btnCompare.Visible = true;
                
            }
        }

        private void ShowData() 
        {
            DataTable dt = new DataTable();
            CarDAO dao = new CarDAO();
            dt = dao.FindAll();

            dgvCars.DataSource = dt;

            this.dgvCars.Columns["country"].Visible = false;
            this.dgvCars.Columns["year"].Visible = false;
            this.dgvCars.Columns["engine_size"].Visible = false;
            this.dgvCars.Columns["power"].Visible = false;
            this.dgvCars.Columns["torque"].Visible = false;
            this.dgvCars.Columns["max_speed"].Visible = false;
            this.dgvCars.Columns["price"].Visible = false;

            this.dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void FilterData()
        {
            DataTable dt = new DataTable();
            CarDAO dao = new CarDAO();
            dt = dao.FindModelLike(txtFilterModel.Text);

            dgvCars.DataSource = dt;

            this.dgvCars.Columns["country"].Visible = false;
            this.dgvCars.Columns["year"].Visible = false;
            this.dgvCars.Columns["engine_size"].Visible = false;
            this.dgvCars.Columns["power"].Visible = false;
            this.dgvCars.Columns["torque"].Visible = false;
            this.dgvCars.Columns["max_speed"].Visible = false;
            this.dgvCars.Columns["price"].Visible = false;

            this.dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }

        private void SelectCar(DataGridViewCellEventArgs e) 
        {
            try
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];

                if (lblCarOneID.Visible == false)
                {
                    lblCarOneID.Text = row.Cells["id"].Value.ToString();
                    lblCarOneModel.Text = row.Cells["model"].Value.ToString();
                    lblCarOneID.Visible = true;
                    lblCarOneModel.Visible = true;
                }
                else if (lblCarOneID.Visible == true && lblCarTwoID.Visible == false) 
                {
                    lblCarTwoID.Text = row.Cells["id"].Value.ToString();
                    lblCarTwoModel.Text = row.Cells["model"].Value.ToString();
                    lblCarTwoID.Visible = true;
                    lblCarTwoModel.Visible = true;
                }
                else if (lblCarTwoID.Visible == true && lblCarThreeID.Visible == false)
                {
                    lblCarThreeID.Text = row.Cells["id"].Value.ToString();
                    lblCarThreeModel.Text = row.Cells["model"].Value.ToString();
                    lblCarThreeID.Visible = true;
                    lblCarThreeModel.Visible = true;
                }
                else if (lblCarThreeID.Visible == true && lblCarFourID.Visible == false)
                {
                    lblCarFourID.Text = row.Cells["id"].Value.ToString();
                    lblCarFourModel.Text = row.Cells["model"].Value.ToString();
                    lblCarFourID.Visible = true;
                    lblCarFourModel.Visible = true;
                }
                else if (lblCarFourID.Visible == true && lblCarFiveID.Visible == false)
                {
                    lblCarFiveID.Text = row.Cells["id"].Value.ToString();
                    lblCarFiveModel.Text = row.Cells["model"].Value.ToString();
                    lblCarFiveID.Visible = true;
                    lblCarFiveModel.Visible = true;

                    dgvCars.DataSource = null;
                    txtFilterModel.Text = "";
                    txtFilterModel.Visible = false;
                    btnCompare.Enabled = true;
                }
            }
            catch(Exception){ }
        }

        private void TopEngineSizeChart() 
        {
            CarDAO dao = new CarDAO();

            Dictionary<string, int> cars = dao.TopFiveEngineSize();

            //Chart values
            foreach (KeyValuePair<string, int> entry in cars)
            {
                this.chartEngines.Series["Size"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        private void CustomEngineSizeChart() 
        {
            int[] ids = new int[5];

            ids[0] = Convert.ToInt16(lblCarOneID.Text);
            ids[1] = Convert.ToInt16(lblCarTwoID.Text);
            ids[2] = Convert.ToInt16(lblCarThreeID.Text);
            ids[3] = Convert.ToInt16(lblCarFourID.Text);
            ids[4] = Convert.ToInt16(lblCarFiveID.Text);

            CarDAO dao = new CarDAO();

            Dictionary<string, int> cars = dao.CustomEngineSizeComparison(ids);

            //Chart values
            foreach (KeyValuePair<string, int> entry in cars)
            {
                this.chartCustomEngine.Series["Size"].Points.AddXY(entry.Key, entry.Value);
            }

            btnExportCustomEngine.Visible = true;
            lblTopCustomChart.Visible = true;
            chartCustomEngine.Visible = true;

        }

        private void SetDefaultState() 
        {
            this.ShowData();

            txtFilterModel.Visible = true;
            btnCompare.Enabled = false;

            lblCarOneID.Text = lblCarOneModel.Text = null; 
            lblCarOneID.Visible = lblCarOneModel.Visible = false;
            lblCarTwoID.Text = lblCarTwoModel.Text = null;
            lblCarTwoID.Visible = lblCarTwoModel.Visible = false;
            lblCarThreeID.Text = lblCarThreeModel.Text = null;
            lblCarThreeID.Visible = lblCarThreeModel.Visible = false;
            lblCarFourID.Text = lblCarFourModel.Text = null;
            lblCarFourID.Visible = lblCarFourModel.Visible = false;
            lblCarFiveID.Text = lblCarFiveModel.Text = null;
            lblCarFiveID.Visible = lblCarFiveModel.Visible = false;
        }

        #endregion

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            this.LoadingData();
        }

        private void txtFilterModel_KeyUp(object sender, KeyEventArgs e)
        {
            this.FilterData();
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectCar(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.SetDefaultState();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            this.CustomEngineSizeChart();
            this.SetDefaultState();
        }

        private void btnExportEngine_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CPC Documents\\my_charts\\top5engines" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";
                this.chartEngines.SaveImage(path, ChartImageFormat.Png);

                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Can´t export chart. Path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportCustomEngine_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CPC Documents\\my_charts\\engine_comparison" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";
                this.chartCustomEngine.SaveImage(path, ChartImageFormat.Png);

                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Can´t export chart. Path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
