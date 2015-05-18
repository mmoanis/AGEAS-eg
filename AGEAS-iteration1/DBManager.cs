using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using AGEAS_iteration1.Properties;

namespace AGEAS_iteration1
{
    class DBManager
    {
        private string connectionString = string.Empty;
        private SqlConnection Conn;

        private static DBManager dbManager;

        /// <summary>
        /// probably initialize the connection string to a sql server.
        /// </summary>
        private bool Initialize()
        {
            // try the dot
            try
            {
                connectionString = "Server=.;" + Settings.Default.ConnectionString;
                Conn = new SqlConnection(connectionString);
                Conn.Open();
                Settings.Default.ServerName = "Server=.;";
                Settings.Default.Save();
                return true;
            }
            catch (Exception)
            {
                
            }

            // try the SQLEXPRESS
            string server = "Server=" + System.Environment.MachineName + "\\SQLEXPRESS;";
            
            try
            {
                connectionString = server + Settings.Default.ConnectionString;
                Conn = new SqlConnection(connectionString);
                Conn.Open();
                Settings.Default.ServerName = server;
                Settings.Default.Save();
                return true;
            }
            catch (SqlException)
            {
                // need to attach the database
                Settings.Default.ServerName = server;
                Settings.Default.Save();
                return false;
            }
            catch (Exception e)
            {
                Conn = null;
                throw e;

            }
        }

        /// <summary>
        /// Attach the database to the server.
        /// </summary>
        private void AttachDatabaseToSqlServer()
        {
            string connection = Settings.Default.ServerName + "Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = " CREATE DATABASE AGEAS ON" + 
               " (FILENAME = '" + System.IO.Path.GetDirectoryName( System.Reflection.Assembly.GetEntryAssembly().Location) + "\\AGEAS.mdf" + "') "+
               //" (FILENAME = '" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\AGEAS_log.ldf" + "')" +
               " FOR ATTACH;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    try
                    {
                        command.CommandType = CommandType.Text;
                        //command.Parameters.AddWithValue("@dbname", "AGEAS");
                        //command.Parameters.AddWithValue("@filename1",
                        //    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\AGEAS.mdf");
                        //command.Parameters.AddWithValue("@filename2",
                        //    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\AGEAS_log.ldf");
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// Constructs the signal instance of the class.
        /// </summary>
        private DBManager()
        {
            if (string.IsNullOrEmpty(Settings.Default.ServerName))
            {
                if(!Initialize())
                    AttachDatabaseToSqlServer();
            }
            else
            {
                try
                {
                    Conn = new SqlConnection(Settings.Default.ServerName + Settings.Default.ConnectionString);
                    Conn.Open();
                }
                catch (Exception)
                {
                    // exit the program safely
                    throw new Exception("failed to initailize program");
                }
            }
        }

        /// <summary>
        /// Gets the instance of the class
        /// </summary>
        public static DBManager Instance
        {
            get
            {
                if (dbManager == null)
                    dbManager = new DBManager();
                return dbManager;
            }
        }

        public void backUPDatabase(string path)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("backUpDatabase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Path", path);
                adapter.Fill(Table);
            }
            catch (Exception EX)
            {
                throw (EX);
            }
        }
    
    
        public void Open()
        {
            try
            {
                Conn.Open();
            }
            catch (Exception EX)
            {
                throw (EX);
            }
        }
        public void Close()
        {
            Conn.Close();
        }

        public DataTable deletecustomer(int Customer_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deletecustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }

        public DataTable deleteProduct(int Product_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleteProduct", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable deleteProductPurchase(int Product_Purchase_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleteProductPurchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Product_Purchase_ID", Product_Purchase_ID);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable deletePurchase(int Purchase_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deletePurchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Purchase_ID", Purchase_ID);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable deletesupplier(int Supplier_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deletesupplier", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getCustomer()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                SqlCommand cmd = new SqlCommand("getCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable Table = new DataTable();
                //adapter.Fill(Table);
                Table.BeginLoadData();
                if (reader.HasRows)
                {
                    Table.Load(reader);
                }
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getCustomerByName(string Name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getCustomerByName", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Name", Name);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getProduct()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getProduct", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getProduct_Purchase(int purchase_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getProduct_Purchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@purchase_id", purchase_id);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getProductByName(string Name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getProductByName", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Name", Name);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getPurchase()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getPurchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getPurchaseByCustomer(int Customer_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getPurchaseByCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getPurchaseByDateExact(DateTime begin)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getPurchaseByDateExact", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@begin", begin);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getPurchaseByDateInterval(DateTime begin, DateTime end)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getPurchaseByDateInterval", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@begin", begin);
                cmd.Parameters.AddWithValue("@end", end);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getSupplierByNameCompany(string Name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getSupplierByNameCompany", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Name", Name);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable getSuppliers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getSuppliers", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable Insertcustomer(string Name, string Phone, decimal Balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insertcustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Balance", Balance);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable InsertProduct(int Supplier_ID, string Name, decimal Price, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertProduct", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable InsertProductPurchase(int Product_ID, int Purchase_ID, int Quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertProductPurchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
                cmd.Parameters.AddWithValue("@Purchase_ID", Purchase_ID);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable InsertPurchase(int Customer_ID, bool Is_On_Installment, decimal Discount, decimal Value, decimal Recieved_Value)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertPurchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                cmd.Parameters.AddWithValue("@Is_On_Installment", Is_On_Installment);
                cmd.Parameters.AddWithValue("@Discount", Discount);
                cmd.Parameters.AddWithValue("@Value", Value);
                cmd.Parameters.AddWithValue("@Recieved_Value", Recieved_Value);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable InsertSupplier(string Name, string Phone, string Address, string Company)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertSupplier", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Company", Company);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable UpdateCustomer(int Customer_ID, string Name, string Phone, decimal Balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateCustomer", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Balance", Balance);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable UpdateProduct(int Product_ID, int Supplier_ID, string Name, decimal Price, int Quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateProduct", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
                cmd.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable UpdateProductPurchase(int Product_Purchase_ID, int Product_ID, int Purchase_ID, int Quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateProductPurchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Product_Purchase_ID", Product_Purchase_ID);
                cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
                cmd.Parameters.AddWithValue("@Purchase_ID", Purchase_ID);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                adapter.Fill(Table);
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable UpdatePurchase(int Purchase_ID, bool Is_On_Installment, decimal Discount, decimal Value, decimal Recieved_Value)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdatePurchase", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Purchase_ID", Purchase_ID);
                cmd.Parameters.AddWithValue("@Is_On_Installment", Is_On_Installment);
                cmd.Parameters.AddWithValue("@Discount", Discount);
                cmd.Parameters.AddWithValue("@Value", Value);
                cmd.Parameters.AddWithValue("@Recieved_Value", Recieved_Value);
                adapter.Fill(Table);
                
                return Table;
            }
            catch(Exception EX)
            {
                throw(EX);
            }
        }
        public DataTable UpdateSupplier(int Supplier_ID, string Name, string Phone, string Address, string Company)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateSupplier", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable();
                cmd.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Company", Company);
                adapter.Fill(Table);
                return Table;
            }
            catch (Exception EX)
            {
                throw (EX);
            }
        }
    }
}
