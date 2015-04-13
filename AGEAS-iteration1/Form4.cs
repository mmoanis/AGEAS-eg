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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            NameLabel.Visible = false;
            IDLabel.Visible = false;
            BalanceLabel.Visible = false;
            TelLabel.Visible = false;
            ByNameLabel.Visible = false;
            ByIDLabel.Visible = false;

            NametextBox.Visible = false;
            IDtextBox.Visible = false;
            BalancetextBox.Visible = false;
            TeltextBox.Visible = false;
            ByNametextBox.Visible = false;
            ByIDtextBox.Visible = false;
        }

        private void Backbtn2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void ByTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Gobtn1_Click(object sender, EventArgs e)
        {
            if(Addrbtn2.Checked)
            {
                NameLabel.Visible = true;
                IDLabel.Visible = true;
                BalanceLabel.Visible = true;
                TelLabel.Visible = true;

                NametextBox.Visible = true;
                IDtextBox.Visible = true;
                BalancetextBox.Visible = true;
                TeltextBox.Visible = true;
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
            }

            if(Searchrbtn2.Checked==true)
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
