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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasswordtextBox.PasswordChar='*';
            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernametextBox.Text))
            {
                MessageBox.Show("برجاء ادخال اسم المستخدم");
            }
            else
            {
                if (string.IsNullOrEmpty(PasswordtextBox.Text))
                {
                    MessageBox.Show("برجاء ادخال كلمة المرور");
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
