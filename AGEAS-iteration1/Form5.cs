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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            NameLabel.Visible = false;
            IDLabel.Visible = false;
            PhoneLabel.Visible = false;
            ByNameLabel.Visible = false;
            ByIDLabel.Visible = false;

            NametextBox.Visible = false;
            IDtextBox.Visible = false;
            PhonetextBox.Visible = false;
            ByNametextBox.Visible = false;
            ByIDtextBox.Visible = false;
        }

        private void Backbtn3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void Gobtn1_Click(object sender, EventArgs e)
        {
            if(Addrbtn3.Checked==true)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                PhoneLabel.Visible = true;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                PhonetextBox.Visible = true;
            
            }
            else
            {
                NameLabel.Visible = false;
                IDLabel.Visible = false;
                PhoneLabel.Visible = false;

                NametextBox.Visible = false;
                IDtextBox.Visible = false;
                PhonetextBox.Visible = false;
            
            }

            if(Searchrbtn3.Checked==true)
            {
                ByNameLabel.Visible = true;
                ByIDLabel.Visible = true;
                ByNametextBox.Visible = true;
                ByIDtextBox.Visible = true;

            }
            else
            {
                ByNameLabel.Visible = false;
                ByIDLabel.Visible = false;
                ByNametextBox.Visible = false;
                ByIDtextBox.Visible = false;

            }
        }
    }
}
