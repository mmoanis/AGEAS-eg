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
            
            PriceLabel.Visible= false;
            QuantityLabel.Visible = false;
            SupplierLabel.Visible = false;

            numericUpDown1.Visible = false;
            QuantitytextBox.Visible = false;
            
            TypetextBox.Visible = false;
            

            Applybtn1.Visible = false;
            TypetextBox.MaxLength = 50;
            comboBox1.Visible = false;

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
                
                PriceLabel.Visible = true;
                QuantityLabel.Visible = true;
                SupplierLabel.Visible = true;

                TypetextBox.Visible = true;

                numericUpDown1.Visible = true;
                QuantitytextBox.Visible = true;
                comboBox1.Visible = true;

                Applybtn1.Visible = true;
                comboBox1.Visible = true;
                Applybtn1.Text = "اضافة";

            }
            else if (Searchrbtn1.Checked == true)
            {
                TypeLabel.Visible = true;
                
                PriceLabel.Visible = false;
                QuantityLabel.Visible = false;
                SupplierLabel.Visible = false;

                TypetextBox.Visible = true;

                numericUpDown1.Visible = false;
                QuantitytextBox.Visible = false;
                comboBox1.Visible = false;

                Applybtn1.Visible = true;
                Applybtn1.Text = "بحث";
            }

            else if (Updaterbtn1.Checked == true)
            {
                TypetextBox.Visible = true;
                

                Applybtn1.Visible = true;
                Applybtn1.Text = "تعديل";
            }
            else
            {
                TypeLabel.Visible = false;
                
                PriceLabel.Visible = false;
                QuantityLabel.Visible = false;
                SupplierLabel.Visible = false;

                TypetextBox.Visible = false;
                
                numericUpDown1.Visible = false;
                QuantitytextBox.Visible = false;
                comboBox1.Visible = false;

                Applybtn1.Visible = true;
                Applybtn1.Text = "عرض";
            }
        }

        private void Applybtn1_Click(object sender, EventArgs e)
        {
            if (Addrbtn1.Checked)
            {
                Program.myController.InsertProduct(TypetextBox.Text, numericUpDown1.Value);
            }

            else if (Searchrbtn1.Checked)
            {

            }

            else if (Browserbtn1.Checked)
            {

            }

            else
            {

            }
        }

        internal void ShowMessage(string p)
        {
            MessageBox.Show(p);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            System.Data.Objects.ObjectQuery<Supplier> suppliers = Program.myController.GetSuppliers();

            comboBox1.DataSource = suppliers;
            comboBox1.ValueMember = "Supplier_ID";
            comboBox1.DisplayMember = "Name";
        }
    }
}
