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
            TypeLabel.Visible = true; 
            PriceLabel.Visible= true;
            QuantityLabel.Visible = true;
            SupplierLabel.Visible = true;
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            TypetextBox.Visible = true;
            comboBox1.Visible = true;
            UpdateButton.Visible = true;
            
            TypetextBox.MaxLength = 50;
            numericUpDown1.Maximum = 999999999;
            numericUpDown1.DecimalPlaces = 3;
            SearchTextBox.MaxLength = 50;
            

            DGV.AutoSize = false;
            DGV.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            DGV.MultiSelect = false;
            DGV.SelectionChanged += DGV_SelectionChanged;
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToOrderColumns = false;
            DGV.ReadOnly = true;
            DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                comboBox1.Text = DGV.SelectedRows[0].Cells[1].Value.ToString();
                numericUpDown1.Value = decimal.Parse(DGV.SelectedRows[0].Cells[3].Value.ToString());
                TypetextBox.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
                AddButton.Enabled = false;
            }
            else
            {
                comboBox1.Text = "";
                numericUpDown1.Value = 0;
                TypetextBox.Text = "";
                AddButton.Enabled = true;
            }
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
            DGV.DataSource = Program.myController.GetProductsList();
            comboBox1.DataSource = Program.myController.GetSuppliers();
            comboBox1.ValueMember = "الرقم";
            comboBox1.DisplayMember = "الاسم";
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int supplier_ID = (int) comboBox1.SelectedValue;
            Program.myController.InsertProduct(supplier_ID, TypetextBox.Text, numericUpDown1.Value);
            Form3_Load(sender, e);
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int supplier_ID = (int)comboBox1.SelectedValue;
            int product_ID = int.Parse(DGV.SelectedRows[0].Cells[0].Value.ToString());
            Program.myController.InsertProduct(supplier_ID, TypetextBox.Text, numericUpDown1.Value);
            Form3_Load(sender, e);
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            DGV.ClearSelection();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Program.myController.DeleteProduct(int.Parse(DGV.SelectedRows[0].Cells[0].Value.ToString()));
            Form3_Load(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DGV.DataSource = Program.myController.SearchProductbyName(SearchTextBox.Text);
        }

    }
}
