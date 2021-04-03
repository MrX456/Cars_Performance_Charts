/*
 * Home form
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CPC.Misc;

/*
 * CPC / App / Home
 * @author MRX
 * Version : 1.0.1
 */

namespace System.CPC.App
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenNewCar(this);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenSearchCar(this);
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenStatisticsGeneral(this);
        }

        private void engineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenStatisticsEngine(this);
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenStatisticsPower(this);
        }

        private void torqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenStatisticsTorque(this);
        }

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenStatisticsSpeed(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenAbout(this);
        }

        private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.OpenShortcuts(this);
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Explorer.OpenDocumentation();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Would you like to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
