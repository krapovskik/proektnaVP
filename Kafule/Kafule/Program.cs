using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafule
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (SaveSystem.LoadData() == null)
            {
                FirstTimeAdminSave ftas = new FirstTimeAdminSave();
                if (ftas.ShowDialog() == DialogResult.OK)
                {
                    FirstTimeSave.SaveFirstTime(ftas.newAdmin);
                    Application.Run(new Login());
                }
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
