using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Objects;

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

        private static Controller controller;

        private DBManager dbManager;

        /// <summary>
        /// 
        /// </summary>
        private Controller()
        {
            dbManager = DBManager.Instance;
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
        
        public bool Form1LoginButtonPressed(string name, string pw)
        {
            F2 = new Form2();
            F2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            

            if (name == AGEAS_iteration1.Properties.Settings.Default.adminUserName && pw == AGEAS_iteration1.Properties.Settings.Default.adminPassword)
            {
                F1.Hide();
                F2.Show();
                return true;
            }
            else if (name == AGEAS_iteration1.Properties.Settings.Default.username && pw == AGEAS_iteration1.Properties.Settings.Default.userPassword)
            {
                F1.Hide();
                F2.Show();
                return true;
            }
            else
            {
                return false;
            }
            
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
            try
            {
                dbManager.Insertcustomer(name, phone, balance);
                F4.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F4.ShowMessage(e.Message);
            }
        }

        public void InsertProduct(int supplier_id, string name, decimal price)
        {
            try
            {
                dbManager.InsertProduct(supplier_id, name, price);
                F3.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
            }
        }

        public void AddSuppliers(string name, string phone, string address, string company)
        {
            try
            {
                dbManager.InsertSupplier(name, phone, address, company);
                F5.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
            }
        }

        public void AddTransactions(string p1, string p2, string p3)
        {
            try
            {
                //dbManager.InsertProduct(supplier_id, name, price);
                //F6.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                //F3.ShowMessage(e.Message);
            }
        }

        public void DeleteProduct(int product_id)
        {

            try
            {
                dbManager.deleteProduct(product_id);
                F3.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
            }

        }

        public void DeleteCustomer(int customer_id)
        {

            try
            {
                dbManager.deletecustomer(customer_id);
                F4.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F4.ShowMessage(e.Message);
            }

        }

        public DataTable GetCustomers()
        {
            try
            {
                return dbManager.getCustomer();
            }
            catch (Exception e)
            {
                F4.ShowMessage(e.Message);
                return null;
            }
        }

        public DataTable GetCustomerByName(string Customer_Name)
        {
            try
            {
                return dbManager.getCustomerByName(Customer_Name);
            }
            catch (Exception e)
            {
                F4.ShowMessage("فشلت عملية البحث");
                return null;
            }
        }



        public DataTable GetSuppliers()
        {
            try
            {
                return dbManager.getSuppliers();
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
                return null;
            }
        }

        public void UpdateCustomer(int customer_id, string name, string phone, decimal balance)
        {
            try
            {
                dbManager.UpdateCustomer(customer_id, name, phone, balance);
                F4.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F4.ShowMessage(e.Message);
            }
        }
    }
}
