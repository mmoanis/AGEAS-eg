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
        public static Controller myController;
        static void Main()
        {
            Controller myController = new Controller();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Controller.StartForm1());
        }
    }
}
