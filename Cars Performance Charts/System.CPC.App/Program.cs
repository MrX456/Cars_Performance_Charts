using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace System.CPC.App
{
    static class Program
    {

        static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool init = false;
            mutex = new Mutex(true, Application.ProductName.ToString(), out init);

            if (init)
            {
                //Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmSplashScreen());
            }
            else
            {
                MessageBox.Show("Application already running. Can´t open another instance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
