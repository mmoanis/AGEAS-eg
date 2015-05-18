using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Objects;

namespace AGEAS_iteration1
{
    public class Controller
    {
        #region Fields
        public Login F1;
        public FunctionChoice F2;
        public Products F3;
        public Clients F4;
        public Suppliers F5;
        public Transactions F6;
        public Reports F7;
        public bool Admin;

        private static Controller controller;

        private DBManager dbManager;
        #endregion Fields

        #region PrivateMethods
        /// <summary>
        /// 
        /// </summary>
        private Controller()
        {
            try
            {
                dbManager = DBManager.Instance;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion PrivateMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product_id"></param>
        /// <param name="purchase_id"></param>
        /// <param name="quantity"></param>
        public void AddProductPurchase(int product_id, int purchase_id, int quantity)
        {
            try
            {
                dbManager.InsertProductPurchase(product_id, purchase_id, quantity);
                F6.ShowMessage("تم  ادخال بيانات المعاملة بنجاح");
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
            }
        }

        /// <summary>
        /// Add a supplier to the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="company"></param>
        public void AddSuppliers(string name, string phone, string address, string company)
        {
            try
            {
                dbManager.InsertSupplier(name, phone, address, company);
                F5.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                F5.ShowMessage("رقم التليفون / اسم الشركة مكرر");
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="supplier_id"></param>
        /// <param name="discount"></param>
        /// <param name="value"></param>
        /// <param name="paid"></param>
        /// <param name="onInstallment"></param>
        public void AddTransaction(int supplier_id, decimal discount, decimal value, decimal paid, bool onInstallment)
        {
            if (supplier_id <= 0 || discount < 0 || value <= 0 || paid < 0)
            {
                throw new ArgumentException("Invalid monetary value!");
            }

            try
            {
                dbManager.InsertPurchase(supplier_id, onInstallment, discount, value, paid);
                F6.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
            }
        }

        public bool BackUpDatabase(string path)
        {
            try
            {
                // FIXME: run as admin may be
                path += "\\AGEAS.BAK";
                System.IO.File.Create(path);
                dbManager.backUPDatabase(path);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes a specific customer
        /// </summary>
        /// <param name="customer_id"></param>
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

        /// <summary>
        /// Delete product from the database
        /// </summary>
        /// <param name="product_id"></param>
        public void DeleteProduct(int product_id)
        {

            try
            {
                dbManager.deleteProduct(product_id);
                F3.ShowMessage("تم مسح البيانات بنجاح");
            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
            }
        }

        public void DeleteProductPurchase(int product_purchase_id)
        {
            try
            {
                dbManager.deleteProductPurchase(product_purchase_id);
                F6.ShowMessage("تم حذف البيانات بنجاح");
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
            }
        }

        /// <summary>
        /// Delete Supplier from database
        /// </summary>
        /// <param name="Supplier_ID"></param>
        /// <returns></returns>
        public DataTable DeleteSupplier(int Supplier_ID)
        {
            try
            {
                return dbManager.deletesupplier(Supplier_ID);
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="purchase_id"></param>
        public void DeleteTransaction(int purchase_id)
        {
            try
            {
                dbManager.deletePurchase(purchase_id);
                F6.ShowMessage("تم حذف البيانات بنجاح");
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        public bool Form1LoginButtonPressed(string name, string pw)
        {
            F2 = new FunctionChoice();
            F2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;


            if (name == AGEAS_iteration1.Properties.Settings.Default.adminUserName.TrimEnd() && pw == AGEAS_iteration1.Properties.Settings.Default.adminPassword)
            {
                Admin = true;
                F1.Hide();
                F2.Show();
                return true;
            }
            else if (name == AGEAS_iteration1.Properties.Settings.Default.username.TrimEnd() && pw == AGEAS_iteration1.Properties.Settings.Default.userPassword)
            {
                Admin = false;
                F1.Hide();
                F2.Show();
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void Form2CustomersButtonPressed()
        {
            F4 = new Clients();
            F4.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F4.FormClosed += (s, args) => F2.Show();
            F4.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Form2LogoutButtonPressed()
        {
            F2.Close();
            F1.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Form2ProductsButtonPressed()
        {
            F3 = new Products();
            F3.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F3.FormClosed += (s, args) => F2.Show();
            F3.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Form2SuppliersButtonPressed()
        {
            F5 = new Suppliers();
            F5.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F5.FormClosed += (s, args) => F2.Show();
            F5.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Form2TransactionsButtonPressed()
        {
            F6 = new Transactions();
            F6.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F6.FormClosed += (s, args) => F2.Show();
            F6.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Form2ReportsButtonPressed()
        {
            F7 = new Reports();
            F7.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            F7.FormClosed += (s, args) => F2.Show();
            F7.ShowDialog();
        }

        /// <summary>
        /// Search for a specific customer
        /// </summary>
        /// <param name="Customer_Name"></param>
        /// <returns></returns>
        public DataTable GetCustomerByName(string Customer_Name)
        {
            try
            {
                return dbManager.getCustomerByName(Customer_Name);
            }
            catch (Exception e)
            {
                F4.ShowMessage("فشلت عملية البحث");
                return new DataTable();
            }
        }

        /// <summary>
        /// Return table of existing customers in database
        /// </summary>
        /// <returns></returns>
        public DataTable GetCustomers()
        {
            try
            {
                return dbManager.getCustomer();
            }
            catch (Exception e)
            {
                F4.ShowMessage(e.Message);
                return new DataTable();
            }
        }

        /// <summary>
        /// Get a table of products in the database
        /// </summary>
        /// <returns></returns>
        public DataTable GetProductsList()
        {
            try
            {
                return dbManager.getProduct();

            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Get the purchase details for a specific purchase
        /// </summary>
        /// <param name="purchase_id"></param>
        /// <returns></returns>
        public DataTable GetProductsPurchase(int purchase_id)
        {
            try
            {
                return dbManager.getProduct_Purchase(purchase_id);
            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
                return null;
            }
        } 

        /// <summary>
        /// Get all purchases.
        /// </summary>
        /// <returns></returns>
        public DataTable GetPurchases()
        {
            try
            {
                return dbManager.getPurchase();
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
                return new DataTable();
            }
        }

        public DataTable GetPurchasesByCustomer(int customer_id)
        {
            try
            {
                return dbManager.getPurchaseByCustomer(customer_id);
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
                return new DataTable();
            }
        }

        /// <summary>
        /// Search for supplier inside the database
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Company"></param>
        /// <returns></returns>
        public DataTable GetSupplierbyName(string Name, string Company)
        {
            try
            {
                return dbManager.getSupplierByNameCompany(Name, Company);
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
                return new DataTable();
            }
        }

        /// <summary>
        /// Returns a table of the suppliers in the database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Creates a customer entity and save it to the database.
        /// </summary>
        /// <param name="name">customer name.</param>
        /// <param name="phone">customer phone.</param>
        /// <param name="balance">customer balance.</param>
        public void InsertCustomer(string name, string phone, decimal balance)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                throw new ArgumentException("Arguments are either null or empty");
            }

            try
            {
                dbManager.Insertcustomer(name, phone, balance);
                F4.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                if (e.Number == 2627)
                {
                    F4.ShowMessage("رقم التليفون مكرر");
                }
            }
            catch (Exception e)
            {
                F4.ShowMessage(e.Message);
            }
        }

        /// <summary>
        /// Insert a product to the database
        /// </summary>
        /// <param name="supplier_id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public void InsertProduct(int supplier_id, string name, decimal price, int quantity)
        {
            if (string.IsNullOrEmpty(name) || quantity <= 0 || price <= 0 || supplier_id <= 0)
            {
                throw new ArgumentException("arguemnts are either null, or not valid money values");
            }

            try
            {
                dbManager.InsertProduct(supplier_id, name, price, quantity);
                F3.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
            }
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

        /// <summary>
        /// Search for a certain product inside the database
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public DataTable SearchProductbyName(string Name)
        {
            try
            {
                return dbManager.getProductByName(Name);
            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable SearchPurchaseByDateExact(DateTime date)
        {
            try
            {
                return dbManager.getPurchaseByDateExact(date);
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
                return new DataTable();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable SearchPurchaseByDateInterval(DateTime begin, DateTime end)
        {
            try
            {
                return dbManager.getPurchaseByDateInterval(begin, end);
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
                return new DataTable();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Login StartForm1()
        {
            F1 = new Login();
            F1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            return F1;
        }

        /// <summary>
        /// Updates the data of an exisiting customer
        /// </summary>
        /// <param name="customer_id"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="balance"></param>
        public void UpdateCustomer(int customer_id, string name, string phone, decimal balance)
        {
            try
            {
                dbManager.UpdateCustomer(customer_id, name, phone, balance);
                F4.ShowMessage("تم ادخال البيانات بنجاح");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                if (e.Number == 2627)
                {
                    F4.ShowMessage("رقم التليفون مكرر");
                }
            }
            catch (Exception e)
            {
                F4.ShowMessage(e.Message);
            }
        }

        /// <summary>
        /// Update the information
        /// </summary>
        /// <param name="product_purchase_id"></param>
        /// <param name="product_id"></param>
        /// <param name="purchase_id"></param>
        /// <param name="quantity"></param>
        public void UpdateProductPurchase(int product_purchase_id, int product_id, int purchase_id, int quantity)
        {
            try
            {
                dbManager.UpdateProductPurchase(product_purchase_id, product_id, purchase_id, quantity);
                F6.ShowMessage("تم تحديث بيانات المعاملة بنجاح");
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
            }
        }

        /// <summary>
        /// updates the current information of a selcted product
        /// </summary>
        /// <param name="Product_ID"></param>
        /// <param name="Supplier_ID"></param>
        /// <param name="Name"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        public DataTable UpdateProuct(int Product_ID, int Supplier_ID, string Name, decimal Price, int Quantity)
        {
            try
            {
                return dbManager.UpdateProduct(Product_ID, Supplier_ID, Name, Price, Quantity);
            }
            catch (Exception e)
            {
                F3.ShowMessage(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Update the data of a supplier currently in the database
        /// </summary>
        /// <param name="Supplier_ID"></param>
        /// <param name="Name"></param>
        /// <param name="Phone"></param>
        /// <param name="Address"></param>
        /// <param name="Company"></param>
        /// <returns></returns>
        public DataTable updateSupplier(int Supplier_ID, string Name, string Phone, string Address, string Company)
        {
            try
            {
                return dbManager.UpdateSupplier(Supplier_ID, Name, Phone, Address, Company);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                F5.ShowMessage("رقم التليفون / اسم الشركة مكرر");
                return null;
            }
            catch (Exception e)
            {
                F5.ShowMessage(e.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="purchase_id"></param>
        /// <param name="discount"></param>
        /// <param name="value"></param>
        /// <param name="paid"></param>
        /// <param name="onInstallment"></param>
        public void UpdateTransaction(int purchase_id, decimal discount, decimal value, decimal paid, bool onInstallment)
        {
            try
            {
                dbManager.UpdatePurchase(purchase_id, onInstallment, discount, value, paid);
                F6.ShowMessage("تم تحديث بيانات المعاملة بنجاح");
            }
            catch (Exception e)
            {
                F6.ShowMessage(e.Message);
            }
        }
    }
}
