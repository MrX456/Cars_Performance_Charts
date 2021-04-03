/*
 * Misc methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

/*
 * CPC / Misc / Explorer
 * @author MRX
 * Version : 1.0.1
 */

namespace System.CPC.Misc
{
    public static class Explorer
    {

        public static void OpenDocumentation() 
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CPC Documents\\CPC_Documentation.pdf";
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Can´t open the file. Path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
