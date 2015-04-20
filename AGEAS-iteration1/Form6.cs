using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            CustomerLabel.Visible = false;
            ProductLabel.Visible = false;
            DateLabel.Visible = false;
            DiscountLabel.Visible = false;
           

            CustomertextBox.Visible = false;
            ProducttextBox.Visible = false;
            DatetextBox.Visible = false;
            DiscounttextBox.Visible = false;

            Applybtn4.Visible = false;
        }

        private void Backbtn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browserbtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (Addrbtn4.Checked == true)
            {
                CustomerLabel.Visible = true;
                ProductLabel.Visible = true;
                DateLabel.Visible = true;
                DiscountLabel.Visible = true;

                CustomertextBox.Visible = true;
                ProducttextBox.Visible = true;
                DatetextBox.Visible = true;
                DiscounttextBox.Visible = true;

                Applybtn4.Visible = true;
                Applybtn4.Text = "اضافة";
            }
            else if (Searchrbtn4.Checked == true)
            {
                CustomerLabel.Visible = true;
                ProductLabel.Visible = true;
                DateLabel.Visible = true;
                DiscountLabel.Visible = true;

                CustomertextBox.Visible = true;
                ProducttextBox.Visible = true;
                DatetextBox.Visible = true;
                DiscounttextBox.Visible = true;

                Applybtn4.Visible = true;
                Applybtn4.Text = "بحث";
            }

            else if (Updaterbtn4.Checked == true)
            {
                DateLabel.Visible = true;
                DatetextBox.Visible = true;

                Applybtn4.Visible = true;
                Applybtn4.Text = "تعديل";
            }
            else
            {
                CustomerLabel.Visible = false;
                ProductLabel.Visible = false;
                DateLabel.Visible = false;
                DiscountLabel.Visible = false;

                CustomertextBox.Visible = false;
                ProducttextBox.Visible = false;
                DatetextBox.Visible = false;
                DiscounttextBox.Visible = false;

                Applybtn4.Visible = true;
                Applybtn4.Text = "عرض";
            }
        }

        private void Applybtn4_Click(object sender, EventArgs e)
        {
            if (Addrbtn4.Checked)
            {
                //Program.myController.AddTransactions(CustomertextBox.Text, ProducttextBox.Text, DiscounttextBox.Text);
            }

            else if (Searchrbtn4.Checked)
            {

            }

            else if (Browserbtn4.Checked)
            {

            }

            else
            {

            }
        }
    }
}
