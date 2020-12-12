/*
 * Splash screen
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * CPC / App / SplashScreen
 * @author MRX
 * Version : 1.0.0
 */

namespace System.CPC.App
{
    public partial class FrmSplashScreen : Form
    {
        
        public FrmSplashScreen()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private void StartProgram() 
        {
            if (pbLoading.Value < 100)
            {
                pbLoading.Value += 2;
            }
            else
            {
                timerLoading.Enabled = false;

                Window.StartApp();
                this.Close();
            }
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            this.StartProgram();
        }
    }
}
