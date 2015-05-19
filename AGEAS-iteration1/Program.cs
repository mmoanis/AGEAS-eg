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
        public static Controller myController;
        [STAThread]
        static void Main()
        {
            try
            {

                myController = Controller.Instance;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(myController.StartForm1());
            }
            catch (Exception e)
            {
                if (e is SetupException)
                    MessageBox.Show(e.Message);
                else
                    MessageBox.Show("لقد تعرض البرنامج لمشكلة تقنية ولابد من الاغلاق، برجاء اعادة فتح البرنامج");
            }
            finally
            {
                if (myController != null)
                {
                    myController.CloseDatabase();
                }
            }
        }
    }
}
