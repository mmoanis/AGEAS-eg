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
        DataGridView DGV = new DataGridView();

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
            PhonetextBox.MaxLength = 50;
            AddresstextBox.MaxLength = 100;
            
            DGV.AutoSize = false;
            DGV.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            DGV.MultiSelect = false;
            DGV.SelectionChanged += DGV_SelectionChanged;
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToOrderColumns = false;
        }

        void DGV_SelectionChanged(object sender, EventArgs e)
        {
            NametextBox.Text = DGV.SelectedRows[0].Cells[1].Value.ToString(); 
            PhonetextBox.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
            AddresstextBox.Text = DGV.SelectedRows[0].Cells[3].Value.ToString();
            CompanyTextBox.Text = DGV.SelectedRows[0].Cells[4].Value.ToString();
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
        }
      
    }
}
