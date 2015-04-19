using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            NameLabel.Visible = false;
            IDLabel.Visible = false;
            PhoneLabel.Visible = false;
            NameLabel.Visible = false;
            IDLabel.Visible = false;
            AddressLabel.Visible = false;

            NametextBox.Visible = false;
            IDtextBox.Visible = false;
            PhonetextBox.Visible = false;
            NametextBox.Visible = false;
            IDtextBox.Visible = false;
            AddresstextBox.Visible = false;

            Applybtn3.Visible = false;

            NametextBox.MaxLength = 50;
            PhonetextBox.MaxLength = 50;
            AddresstextBox.MaxLength = 100;
        }

        private void Backbtn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addrbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (Addrbtn3.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                PhoneLabel.Visible = true;
                AddressLabel.Visible = true;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                PhonetextBox.Visible = true;
                AddresstextBox.Visible = true;

                Applybtn3.Visible = true;
                Applybtn3.Text = "اضافة";

            }

            else if (Searchrbtn3.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                PhoneLabel.Visible = false;
                AddressLabel.Visible = false;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                PhonetextBox.Visible = false;
                AddresstextBox.Visible = false;

                Applybtn3.Visible = true;
                Applybtn3.Text = "بحث";
            }

            else if (Browserbtn3.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                AddressLabel.Visible = true;

                NametextBox.Visible = true;
                AddresstextBox.Visible = false;
                IDtextBox.Visible = true;
                

                Applybtn3.Visible = true;
                Applybtn3.Text = "تعديل";

            }

            else
            {
                NameLabel.Visible = false;
                IDLabel.Visible = false;
                PhoneLabel.Visible = false;
                AddressLabel.Visible = false;

                NametextBox.Visible = false;
                IDtextBox.Visible = false;
                PhonetextBox.Visible = false;
                AddresstextBox.Visible = false;

                Applybtn3.Visible = true;
                Applybtn3.Text = "عرض";

            }
        }
    }
}
