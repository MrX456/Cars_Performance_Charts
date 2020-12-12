/*
 * Form responsible for add cars to database
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

/*
 * CPC / App / FrmCarsNew
 * @author MRX
 * Version : 1.0.0
 */ 

namespace System.CPC.App
{
    public partial class FrmCarsNew : Form
    {
        public FrmCarsNew()
        {
            InitializeComponent();
        }

        #region - My methods

        private void SetDefaultState() 
        {
            txtMaker.Text = "";
            txtModel.Text = "";
            txtCountry.Text = "";
            txtYear.Text = "";
            txtEngine.Text = "";
            txtPower.Text = "";
            txtTorque.Text = "";
            txtMaxSpeed.Text = "";
            txtPrice.Text = "";
        }

        #endregion

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            try
            {
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
                    MessageBox.Show(null, "Car successfully added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.SetDefaultState();
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.SetDefaultState();
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
