using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            NameLabel.Visible = false;
            IDLabel.Visible = false;
            BalanceLabel.Visible = false;
            TelLabel.Visible = false;
            NameLabel.Visible = false;
            IDLabel.Visible = false;

            NametextBox.Visible = false;
            IDtextBox.Visible = false;
            BalancetextBox.Visible = false;
            TeltextBox.Visible = false;
            NametextBox.Visible = false;
            IDtextBox.Visible = false;

            Applybtn2.Visible = false;
            NametextBox.MaxLength = 50;
        }

        private void Backbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browserbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (Addrbtn2.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                BalanceLabel.Visible = true;
                TelLabel.Visible = true;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                BalancetextBox.Visible = true;
                TeltextBox.Visible = true;

                Applybtn2.Visible = true;
                Applybtn2.Text = "اضافة";
            }

            else if (Searchrbtn2.Checked == true)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                BalanceLabel.Visible = false;
                TelLabel.Visible = false;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                BalancetextBox.Visible = false;
                TeltextBox.Visible = false;

                Applybtn2.Visible = true;
                Applybtn2.Text = "بحث";
            }

            else if (Updaterbtn2.Checked)
            {
                NameLabel.Visible = false;
                IDLabel.Visible = false;
                BalanceLabel.Visible = false;
                TelLabel.Visible = false;

                NametextBox.Visible = false;
                IDtextBox.Visible = false;
                BalancetextBox.Visible = false;
                TeltextBox.Visible = false;

                Applybtn2.Visible = true;
                Applybtn2.Text = "تعديل";
            }

            else
            {
                NameLabel.Visible = false;
                IDLabel.Visible = false;
                BalanceLabel.Visible = false;
                TelLabel.Visible = false;

                NametextBox.Visible = false;
                IDtextBox.Visible = false;
                BalancetextBox.Visible = false;
                TeltextBox.Visible = false;

                Applybtn2.Visible = true;
                Applybtn2.Text = "عرض";
            }
        }

        private void Applybtn2_Click(object sender, EventArgs e)
        {
            if (Addrbtn2.Checked)
            {
                
            }

            else if (Searchrbtn2.Checked == true)
            {
                
            }

            else if (Updaterbtn2.Checked)
            {
                
            }

            else
            {
                
            }
        }
    }
}
