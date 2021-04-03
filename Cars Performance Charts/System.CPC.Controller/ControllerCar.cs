/*
 * Class responsible for implementation of Car table control  methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CPC.Model.Bean;
using System.Windows.Forms;

/*
 * CPC / Controller / Car
 * @author MRX
 * Version : 1.0.1
 */

namespace System.CPC.Controller
{
    public class ControllerCar : IControllerCar
    {
        public bool Validate(Car car)
        {
            if (car.Maker.Trim() == String.Empty || car.Maker.Length > 30) 
            {
                MessageBox.Show(null, "Invalid maker ! Maker must have 30 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (car.Model.Trim() == String.Empty || car.Model.Length > 30)
            {
                MessageBox.Show(null, "Invalid model ! Model must have 30 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (car.Country.Trim() == String.Empty || car.Country.Length > 20)
            {
                MessageBox.Show(null, "Invalid country ! Country must have 20 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (car.Engine_size == 0)
            {
                MessageBox.Show(null, "Invalid engine size ! Engine size must have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (car.Power == 0)
            {
                MessageBox.Show(null, "Invalid power ! Power must have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (car.Torque == 0)
            {
                MessageBox.Show(null, "Invalid torque ! Torque must have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (car.Max_speed == 0)
            {
                MessageBox.Show(null, "Invalid max speed ! Max speed must have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
