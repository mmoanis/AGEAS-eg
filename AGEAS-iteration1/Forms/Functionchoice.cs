using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AGEAS_iteration1.Forms;

namespace AGEAS_iteration1
{
    public partial class FunctionChoice : Form
    {
        
        public FunctionChoice()
        {
            InitializeComponent();
            
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            Program.myController.Form2ProductsButtonPressed();
        }

        private void Customersbtn_Click(object sender, EventArgs e)
        {
            Program.myController.Form2CustomersButtonPressed();
        }

        private void Suppliersbtn_Click(object sender, EventArgs e)
        {
            Program.myController.Form2SuppliersButtonPressed();
        }

        private void Transactionsbtn_Click(object sender, EventArgs e)
        {   
            Program.myController.Form2TransactionsButtonPressed();
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            Program.myController.Form2ReportsButtonPressed();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Program.myController.Form2LogoutButtonPressed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preferences preferences = new Preferences();
            preferences.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!Program.myController.Admin)
            {
                SetupButton.Enabled = false;
                Reportsbtn.Enabled = false;
            }
        }
    }
}
