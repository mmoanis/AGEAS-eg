using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AGEAS_iteration1;

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
                    //Form2 f = new Form2();
                    //f.FormClosed += (s, args) => this.Show();

                    if (! Program.myController.Form1LoginButtonPressed(UsernametextBox.Text, PasswordtextBox.Text))
                    {
                        MessageBox.Show("معلومات الدخول خاطئة");
                    }
                    //this.Hide();

                    this.UsernametextBox.Clear();
                    this.PasswordtextBox.Clear();
                    //f.Show();
                    //else show incorrect username or password
                }
                
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
