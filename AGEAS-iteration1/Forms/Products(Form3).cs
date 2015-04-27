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
        public DataGridView DGV = new DataGridView();


        public Form3()
        {
            InitializeComponent();
            TypeLabel.Visible = true; 
            
            PriceLabel.Visible= true;
            QuantityLabel.Visible = true;
            SupplierLabel.Visible = true;

            numericUpDown1.Visible = true;
            numericUpDown1.Maximum = 1000000;
            QuantitytextBox.Visible = true;
            
            TypetextBox.Visible = true;
            

            UpdateButton.Visible = true;
            TypetextBox.MaxLength = 50;
            comboBox1.Visible = true;

            DGV.AutoSize = false;
            DGV.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            DGV.MultiSelect = false;
            DGV.SelectionChanged += DGV_SelectionChanged;
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToOrderColumns = false;
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            comboBox1.Text = DGV.SelectedRows[0].Cells[1].ToString();
            numericUpDown1.Value = decimal.Parse(DGV.SelectedRows[0].Cells[3].ToString());
            TypetextBox.Text = DGV.SelectedRows[0].Cells[2].ToString();
        }

        private void Backbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            Program.myController.InsertProduct(TypetextBox.Text,(decimal) numericUpDown1.Value);
        }
    }
}
