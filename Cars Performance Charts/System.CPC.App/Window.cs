/*
 * Class responsible for instatntiate new forms
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

/*
 * CPC / App / Window
 * @author MRX
 * Version : 1.0.0
 */

namespace System.CPC.App
{
    public static class Window
    {
        public static void StartApp()
        {
            Thread strApp;
            strApp = new Thread(OpenHome);
            strApp.SetApartmentState(ApartmentState.STA);
            strApp.Start();
        }

        private static void OpenHome()
        {
            Application.Run(new FrmHome());
        }

        public static void OpenNewCar(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmCarsNew))
                {
                    form.Activate();
                    return;
                }
            }

            FrmCarsNew u = new FrmCarsNew();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void OpenSearchCar(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmCarsSearch))
                {
                    form.Activate();
                    return;
                }
            }

            FrmCarsSearch u = new FrmCarsSearch();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void OpenStatisticsGeneral(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmStatisticsGeneral))
                {
                    form.Activate();
                    return;
                }
            }

            FrmStatisticsGeneral u = new FrmStatisticsGeneral();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void OpenStatisticsEngine(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmStatisticsEngine))
                {
                    form.Activate();
                    return;
                }
            }

            FrmStatisticsEngine u = new FrmStatisticsEngine();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void OpenStatisticsPower(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmStatisticsPower))
                {
                    form.Activate();
                    return;
                }
            }

            FrmStatisticsPower u = new FrmStatisticsPower();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void OpenStatisticsTorque(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmStatisticsTorque))
                {
                    form.Activate();
                    return;
                }
            }

            FrmStatisticsTorque u = new FrmStatisticsTorque();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void OpenStatisticsSpeed(Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmStatisticsSpeed))
                {
                    form.Activate();
                    return;
                }
            }

            FrmStatisticsSpeed u = new FrmStatisticsSpeed();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void OpenAbout(Form f) 
        {
            using (FrmAbout box = new FrmAbout())
            {
                box.ShowDialog(f);
            }
        }

        public static void OpenShortcuts(Form f)
        {
            using (FrmShortcuts box = new FrmShortcuts())
            {
                box.ShowDialog(f);
            }
        }
    }
}
