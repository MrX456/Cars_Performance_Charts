/*
 * Information about app
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * CPC / App / FrmAbout
 * @author MRX
 * Version : 1.0.0
 */ 

namespace System.CPC.App
{
    partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
       
    }
}
