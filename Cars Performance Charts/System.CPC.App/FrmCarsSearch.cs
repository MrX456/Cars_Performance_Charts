/*
 * Form responsible for update, read and delete car from database
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CPC.Controller;
using System.CPC.Model.Bean;
using System.CPC.Model.DAO;
using System.Globalization;

/*
 * CPC / App / FrmCarsSearch
 * @author MRX
 * Version : 1.0.1
 */ 

namespace System.CPC.App
{
    public partial class FrmCarsSearch : Form
    {
        public FrmCarsSearch()
        {
            InitializeComponent();
        }

        #region - My methods

        private void ShowData() 
        {
            DataTable dt = new DataTable();
            CarDAO dao = new CarDAO();
            dt = dao.FindAll();

            dgvCars.DataSource = dt;

            //Format currency cell
            dgvCars.Columns[9].DefaultCellStyle.Format = "c2";
            dgvCars.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        private void FilterData() 
        {
            DataTable dt = new DataTable();
            CarDAO dao = new CarDAO();
            dt = dao.FindModelLike(txtFilterModel.Text);

            dgvCars.DataSource = dt;

            //Format currency cell
            dgvCars.Columns[9].DefaultCellStyle.Format = "c2";
            dgvCars.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        private void SetFields(DataGridViewCellEventArgs e) 
        {
            try
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];

                txtID.Text = row.Cells["id"].Value.ToString();
                txtMaker.Text = row.Cells["maker"].Value.ToString();
                txtModel.Text = row.Cells["model"].Value.ToString();
                txtCountry.Text = row.Cells["country"].Value.ToString();
                txtYear.Text = row.Cells["year"].Value.ToString();
                txtEngine.Text = row.Cells["engine_size"].Value.ToString();
                txtPower.Text = row.Cells["power"].Value.ToString();
                txtTorque.Text = row.Cells["torque"].Value.ToString();
                txtMaxSpeed.Text = row.Cells["max_speed"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();

                btnUpdateCar.Enabled = true;
                btnDeleteCar.Enabled = true;
            }
            catch(Exception){ }
        }

        private void SetDefaultState()
        {
            txtID.Text = "";
            txtMaker.Text = "";
            txtModel.Text = "";
            txtCountry.Text = "";
            txtYear.Text = "";
            txtEngine.Text = "";
            txtPower.Text = "";
            txtTorque.Text = "";
            txtMaxSpeed.Text = "";
            txtPrice.Text = "";

            txtFilterModel.Text = "";

            btnUpdateCar.Enabled = false;
            btnDeleteCar.Enabled = false;

            this.ShowData();
        }

        #endregion

        private void FrmCarsSearch_Load(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetFields(e);
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            try
            {
                car.Id = Convert.ToInt32(txtID.Text);
                car.Maker = txtMaker.Text;
                car.Model = txtModel.Text;
                car.Country = txtCountry.Text;
                car.Year = Convert.ToInt32(txtYear.Text);
                car.Engine_size = Convert.ToInt32(txtEngine.Text);
                car.Power = Convert.ToInt32(txtPower.Text);
                car.Torque = Convert.ToInt32(txtTorque.Text);
                car.Max_speed = Convert.ToInt32(txtMaxSpeed.Text);
                car.Price = Convert.ToDecimal(string.Format("{0:0.00}", txtPrice.Text));
            }
            catch (FormatException) { }
            finally
            {
                CarDAO dao = new CarDAO();
                ControllerCar ctr = new ControllerCar();

                if (ctr.Validate(car))
                {
                    dao.Save(car);
                    MessageBox.Show(null, "Car successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.SetDefaultState();
                    this.ShowData();
                }
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Would you like to delete this car? " , "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choose == DialogResult.Yes)
            {
                CarDAO dao = new CarDAO();
                dao.Remove(Convert.ToInt32(txtID.Text));
                MessageBox.Show(null, "Car successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.SetDefaultState();
            this.ShowData();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.SetDefaultState();
        }

        private void txtFilterModel_KeyUp(object sender, KeyEventArgs e)
        {
            this.FilterData();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtEngine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtTorque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtMaxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8)) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }
    }
}
