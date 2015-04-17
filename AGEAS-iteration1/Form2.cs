using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            //Form3 f = new Form3();
            //f.FormClosed += (s, args) => this.Show();
            //this.Hide();
            //f.Show();
            Program.myController.Form2ProductsButtonPressed();
        }

        private void Customersbtn_Click(object sender, EventArgs e)
        {
            //Form4 f = new Form4();
            //f.FormClosed += (s, args) => this.Show();
            //this.Hide();
            //f.Show();
            Program.myController.Form2CustomersButtonPressed();
        }

        private void Suppliersbtn_Click(object sender, EventArgs e)
        {
            //Form5 f = new Form5();
            //f.FormClosed += (s, args) => this.Show();
            //this.Hide();
            //f.Show();
            Program.myController.Form2SuppliersButtonPressed();
        }

        private void Transactionsbtn_Click(object sender, EventArgs e)
        {
            //Form6 f = new Form6();
            //f.FormClosed += (s, args) => this.Show();
            //this.Hide();
            //f.Show();
            Program.myController.Form2TransactionsButtonPressed();
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.FormClosed += (s, args) => this.Show();
            this.Hide();
            f.Show();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Program.myController.Form2LogoutButtonPressed();
        }
    }
}
