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
            
            NameLabel.Visible = true;

            PhoneLabel.Visible = true;
            NameLabel.Visible = true;
            AddressLabel.Visible = true;
            NametextBox.Visible = true;
            PhonetextBox.Visible = true;
            NametextBox.Visible = true;
            AddresstextBox.Visible = true;
            UpdateButton.Visible = true;

            NametextBox.MaxLength = 50;
            PhonetextBox.MaxLength = 14;
            AddresstextBox.MaxLength = 100;
            CompanyTextBox.MaxLength = 50;
            SearchNameTextBox.MaxLength = 50;

            
            DGV.AutoSize = false;
            DGV.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            DGV.MultiSelect = false;
            DGV.SelectionChanged += DGV_SelectionChanged;
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToOrderColumns = false;
            DGV.ReadOnly = true;
            DGV.ReadOnly = true;
            DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }

        void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                NametextBox.Text = DGV.SelectedRows[0].Cells[1].Value.ToString();
                PhonetextBox.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
                AddresstextBox.Text = DGV.SelectedRows[0].Cells[3].Value.ToString();
                CompanyTextBox.Text = DGV.SelectedRows[0].Cells[4].Value.ToString();
                AddButton.Enabled = false;
            }
            else
            {
                NametextBox.Text = "";
                PhonetextBox.Text = "";
                AddresstextBox.Text = "";
                CompanyTextBox.Text = "";
                AddButton.Enabled = true;
            }
        }

        private void Backbtn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void ShowMessage(string p)
        {
            MessageBox.Show(p);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Program.myController.AddSuppliers(NametextBox.Text, PhonetextBox.Text, AddresstextBox.Text, CompanyTextBox.Text);
            Form5_Load(sender,e);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DGV.DataSource = Program.myController.GetSuppliers();
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DGV.DataSource = Program.myController.GetSupplierbyName(SearchNameTextBox.Text,SearchCompanyTextBox.Text);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Program.myController.updateSupplier(int.Parse(DGV.SelectedRows[0].Cells[0].Value.ToString()), NametextBox.Text,
                PhonetextBox.Text, AddresstextBox.Text, CompanyTextBox.Text);
            Form5_Load(sender, e);
        }

        private void Form5_Click(object sender, EventArgs e)
        {
            DGV.ClearSelection();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Program.myController.DeleteSupplier(int.Parse(DGV.SelectedRows[0].Cells[0].Value.ToString()));
            Form5_Load(sender,e);
        }
      
    }
}
