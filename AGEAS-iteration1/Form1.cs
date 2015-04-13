using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PasswordtextBox.PasswordChar='*';

            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(UsernametextBox.Text))
            {
                MessageBox.Show("Please enter a Username!");
            }
            else
            {
                if (string.IsNullOrEmpty(PasswordtextBox.Text))
                {
                    MessageBox.Show("Please enter a Password!");
                }
                else
                {
                    //check if username and password exist in db
                    Form2 f = new Form2();
                    this.Hide();
                    f.Show();
                    //else show incorrect username or password
                }
                
            }




            

        }
    }
}
