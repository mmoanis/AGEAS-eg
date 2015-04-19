using System;
using System.Collections.Generic;
using System.Text;

namespace AGEAS_iteration1
{
    public class Controller
    {
        public Form1 F1;
        public Form2 F2;
        public Form3 F3;
        public Form4 F4;
        public Form5 F5;
        public Form6 F6;
        public Form7 F7;
        public DataGridViewForm DGV;

        private Model1Container dataModel;
        private static Controller controller;

        /// <summary>
        /// 
        /// </summary>
        private Controller()
        {
            dataModel = new Model1Container();
        }

        /// <summary>
        /// Gets the instance of the controller
        /// </summary>
        public static Controller Instance
        {
            get
            {
                if (controller == null)
                    controller = new Controller();

                return controller;
            }
        }

        public Form1 StartForm1()
        {
            F1 = new Form1();
            F1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            return F1;
        }
        
        public void Form1LoginButtonPressed()
        {
            F2 = new Form2();
            F2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F1.Hide();
            F2.Show();
        }

        public void Form2LogoutButtonPressed()
        {
            F2.Close();
            F1.Show();
        }

        public void Form2ProductsButtonPressed()
        {
            F3 = new Form3();
            F3.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F3.FormClosed += (s, args) => F2.Show();
            F3.ShowDialog();
        }

        public void Form2CustomersButtonPressed()
        {
            F4 = new Form4();
            F4.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F4.FormClosed += (s, args) => F2.Show();
            F4.ShowDialog();
        }

        public void Form2SuppliersButtonPressed()
        {
            F5 = new Form5();
            F5.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F5.FormClosed += (s, args) => F2.Show();
            F5.ShowDialog();
        }

        public void Form2TransactionsButtonPressed()
        {
            F6 = new Form6();
            F6.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F6.FormClosed += (s, args) => F2.Show();
            F6.ShowDialog();
        }

        /// <summary>
        /// Creates a customer entity and save it to the database.
        /// </summary>
        /// <param name="name">customer name.</param>
        /// <param name="phone">customer phone.</param>
        /// <param name="balance">customer balance.</param>
        public void InsertCustomer(string name, string phone, decimal balance)
        {
            Customer c = new Customer();
            c.Name = name;
            c.Phone = phone;
            c.Balance = balance;

            
            dataModel.AddToCustomers(c);
            dataModel.SaveChanges();
            F4.ShowMessage("Mabrooooooooooooooooooook");

            
        }

        public void InsertProduct()
        {
        }
    }
}
