using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AGEAS_iteration1.Properties;

namespace AGEAS_iteration1.Forms
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
            this.tbAdminNewPassword.PasswordChar = '*';
            this.tbAdminOldPassword.PasswordChar = '*';
            this.tbUserNewPassword.PasswordChar = '*';
            this.tbUserOldPassword.PasswordChar = '*';
            ((Control)tabPage1).Enabled = false;
            //foreach (Control ctl in tabPage1.Controls) ctl.Enabled = false;
        }

        private void btChangeAdminSettings_Click(object sender, EventArgs e)
        {
            if (Settings.Default.adminPassword == tbAdminOldPassword.Text && !string.IsNullOrEmpty(tbAdminNewPassword.Text))
            {
                // set new password
                Settings.Default.adminPassword = tbAdminNewPassword.Text;
                Settings.Default.Save();
                MessageBox.Show("تم تغيير كلمة المرور");
            }
            else
            {
                MessageBox.Show("برجاء التاكد من كلمة المرور وكلمة المرور الجديدة");
            }
        }

        private void btChangeUserSettings_Click(object sender, EventArgs e)
        {
            if (Settings.Default.userPassword == tbUserOldPassword.Text && !string.IsNullOrEmpty(tbUserNewPassword.Text))
            {
                // set new password
                Settings.Default.userPassword = tbUserNewPassword.Text;
                Settings.Default.Save();
                MessageBox.Show("تم تغيير كلمة المرور");
            }
            else
            {
                MessageBox.Show("برجاء التاكد من كلمة المرور وكلمة المرور الجديدة");
            }
        }

        /// <summary>
        /// Perform back up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Program.myController.BackUpDatabase(dialog.SelectedPath))
                {
                    MessageBox.Show("تم اجراء العملية بنجاح");
                }
                else
                {
                    MessageBox.Show("فشلت العملية، برجاء ابلاغ فريق التطوير عن المشكلة");
                }
            }
        }
    }
}
