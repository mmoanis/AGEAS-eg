using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AGEAS_iteration1;
namespace AGEAS_iteration1
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
            Application.Run(Controller.StartForm1());
        }
    }
}
