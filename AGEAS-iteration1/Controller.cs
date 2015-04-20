using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
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
        public DataGridViewForm DGV;

        private static Controller controller;

        Database1Entities e = new Database1Entities();

        /// <summary>
        /// 
        /// </summary>
        private Controller()
        {
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
            Customer c = new Customer();
            c.Name = name;
            c.Phone = phone;
            c.Balance = balance;

            using (var e = new Database1Entities())
            {
                e.AddToCustomers(c);

                try
                {
                    if (e.SaveChanges() == 1)
                        F4.ShowMessage("تم ادخال البيانات");
                }
                catch (InvalidOperationException ex)
                {
                    F4.ShowMessage(" لم يتم ادخال البيانات");
                }
            }
        }

        public void InsertProduct(string name, decimal price)
        {
            Product p = new Product();
            p.Name = name;
            p.Price = price;

            using (var e = new Database1Entities())
            {
                e.AddToProducts(p);

                try
                {
                    if (e.SaveChanges() == 1)
                        F3.ShowMessage("تم ادخال البيانات");
                }
                catch (InvalidOperationException ex)
                {
                    F3.ShowMessage(" لم يتم ادخال البيانات");
                }
            }
        }

        internal void AddSuppliers(string p1, string p2, string p3, string company)
        {
            Supplier s = new Supplier();
            s.Name = p1;
            s.Phone = p2;
            s.Address = p3;
            s.Company = company;

            using (var e = new Database1Entities())
            {
                e.AddToSuppliers(s);

                try
                {
                    if (e.SaveChanges() == 1)
                        F5.ShowMessage("تم ادخال البيانات");
                }
                catch (InvalidOperationException ex)
                {
                    F5.ShowMessage(" لم يتم ادخال البيانات");
                }
            }
        }

        //internal void AddTransactions(string p1, string p2, string p3)
        //{
        //    Product p = new Product();
        //    p.Name = name;
        //    p.Price = price;

        //    using (var e = new Database1Entities())
        //    {
        //        e.AddToProducts(p);

        //        try
        //        {
        //            if (e.SaveChanges() == 1)
        //                F4.ShowMessage("تم ادخال البيانات");
        //        }
        //        catch (InvalidOperationException ex)
        //        {
        //            F4.ShowMessage(" لم يتم ادخال البيانات");
        //        }
        //    }
        //}

        internal ObjectQuery<Supplier> GetSuppliers()
        {
                return e.Suppliers;
        }
    }
}
