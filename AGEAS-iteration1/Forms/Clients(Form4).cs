using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form4 : Form
    {
        public DataGridView DGV = new DataGridView();
        public Form4()
        {
            InitializeComponent();
            NameLabel.Visible = true;

            BalanceLabel.Visible = true;
            TelLabel.Visible = true;
            NameLabel.Visible = true;


            NametextBox.Visible = true;

            BalanceText.Visible = true;
            BalanceText.Maximum = 10000000;
            TeltextBox.Visible = true;
            NametextBox.Visible = true;


            UpdateButton.Visible = true;
            NametextBox.MaxLength = 50;

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
            NametextBox.Text = DGV.SelectedRows[0].Cells[1].ToString();
            TeltextBox.Text = DGV.SelectedRows[0].Cells[2].ToString();
            BalanceText.Text = DGV.SelectedRows[0].Cells[3].ToString();
        }

        private void Backbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browserbtn2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void Applybtn2_Click(object sender, EventArgs e)
        {
            
                
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Program.myController.InsertCustomer(NametextBox.Text, TeltextBox.Text, BalanceText.Value);
        }
    }
}
