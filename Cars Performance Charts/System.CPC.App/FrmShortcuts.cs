/*
 * Shortcut keys
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * CPC / App / FrmShortcuts
 * @author MRX
 * Version : 1.0.0
 */ 

namespace System.CPC.App
{
    partial class FrmShortcuts : Form
    {
        public FrmShortcuts()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save Shortcuts to File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Bitmap b = new Bitmap(Width, Height);
                DrawToBitmap(b, new Rectangle(0, 0, Width, Height));
                b.Save(saveFileDialog.FileName);
            }
        }

    }
}
