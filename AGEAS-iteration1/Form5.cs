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

            NametextBox.Visible = false;
            IDtextBox.Visible = false;
            PhonetextBox.Visible = false;
            NametextBox.Visible = false;
            IDtextBox.Visible = false;
        }

        private void Backbtn3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void Addrbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (Addrbtn3.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                PhoneLabel.Visible = true;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                PhonetextBox.Visible = true;

            }

            else if (Searchrbtn3.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                PhoneLabel.Visible = false;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                PhonetextBox.Visible = false;
            }

            else if (Browserbtn3.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                NametextBox.Visible = true;
                IDtextBox.Visible = true;

            }

            else
            {
                NameLabel.Visible = false;
                IDLabel.Visible = false;
                NametextBox.Visible = false;
                IDtextBox.Visible = false;

            }
        }
    }
}
