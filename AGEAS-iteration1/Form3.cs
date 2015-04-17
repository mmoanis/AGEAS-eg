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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            TypeLabel.Visible = false; 
            BrandLabel.Visible = false;
            PriceLabel.Visible= false;
            QuantityLabel.Visible = false;
            SupplierLabel.Visible = false;

            PricetextBox.Visible = false;
            QuantitytextBox.Visible = false;
            SuppliertextBox.Visible = false;
            TypetextBox.Visible = false;
            BrandtextBox.Visible = false;

            Applybtn1.Visible = false;
            TypetextBox.MaxLength = 50;

        }

        private void Backbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browserbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (Addrbtn1.Checked == true)
            {
                TypeLabel.Visible = true;
                BrandLabel.Visible = true;
                PriceLabel.Visible = true;
                QuantityLabel.Visible = true;
                SupplierLabel.Visible = true;

                TypetextBox.Visible = true;
                BrandtextBox.Visible = true;
                PricetextBox.Visible = true;
                QuantitytextBox.Visible = true;
                SuppliertextBox.Visible = true;

                Applybtn1.Visible = true;
                Applybtn1.Text = "اضافة";

            }
            else if (Searchrbtn1.Checked == true)
            {
                TypeLabel.Visible = true;
                BrandLabel.Visible = true;
                PriceLabel.Visible = false;
                QuantityLabel.Visible = false;
                SupplierLabel.Visible = false;

                TypetextBox.Visible = true;
                BrandtextBox.Visible = true;
                PricetextBox.Visible = false;
                QuantitytextBox.Visible = false;
                SuppliertextBox.Visible = false;

                Applybtn1.Visible = true;
                Applybtn1.Text = "بحث";
            }

            else if (Updaterbtn1.Checked == true)
            {
                TypetextBox.Visible = true;
                BrandtextBox.Visible = true;

                Applybtn1.Visible = true;
                Applybtn1.Text = "تعديل";
            }
            else
            {
                TypeLabel.Visible = false;
                BrandLabel.Visible = false;
                PriceLabel.Visible = false;
                QuantityLabel.Visible = false;
                SupplierLabel.Visible = false;

                TypetextBox.Visible = false;
                BrandtextBox.Visible = false;
                PricetextBox.Visible = false;
                QuantitytextBox.Visible = false;
                SuppliertextBox.Visible = false;

                Applybtn1.Visible = true;
                Applybtn1.Text = "عرض";
            }
        }
    }
}
