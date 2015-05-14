using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            NameLabel.Visible = true;

            BalanceLabel.Visible = true;
            TelLabel.Visible = true;
            NameLabel.Visible = true;
            TeltextBox.Visible = true;
            NametextBox.Visible = true;
            NametextBox.Visible = true;
            BalanceText.Visible = true;
            UpdateButton.Visible = true;

            BalanceText.Maximum = 999999999;
            BalanceText.DecimalPlaces = 3;
            NametextBox.MaxLength = 50;
            TeltextBox.MaxLength = 14;
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

        void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                NametextBox.Text = DGV.SelectedRows[0].Cells[1].Value.ToString();
                TeltextBox.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
                BalanceText.Text = DGV.SelectedRows[0].Cells[3].Value.ToString();
                AddButton.Enabled = false;
            }
            else
            {
                NametextBox.Text = "";
                TeltextBox.Text = "";
                BalanceText.Text = "";
                AddButton.Enabled = true;
            }
        }

        private void Backbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text.Length < 1)
            {
                MessageBox.Show("برجاء ادخال اسم العميل");
                return;
            }
            
            int telephonenumber;
            if (!Int32.TryParse(TeltextBox.Text, out telephonenumber) || !(TeltextBox.Text.Length == 8 || TeltextBox.Text.Length == 11))
            {
                MessageBox.Show("برجاء ادخال رقم  تليفون صحيح ");
                return;
            }

            Program.myController.InsertCustomer(NametextBox.Text, TeltextBox.Text, BalanceText.Value);
            Form4_Load(sender, e);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DGV.DataSource = Program.myController.GetCustomers();
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count != 0)
            {
                Program.myController.DeleteCustomer((int)DGV.SelectedRows[0].Cells[0].Value);
                Form4_Load(sender, e);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DGV.DataSource = Program.myController.GetCustomerByName(SearchTextBox.Text);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text.Length < 1)
            {
                MessageBox.Show("برجاء ادخال اسم العميل");
                return;
            }

            int telephonenumber;
            if (!Int32.TryParse(TeltextBox.Text, out telephonenumber) || !(TeltextBox.Text.Length == 8 || TeltextBox.Text.Length == 11))
            {
                MessageBox.Show("برجاء ادخال رقم  تليفون صحيح ");
                return;
            }
            if (DGV.SelectedRows.Count != 0)
            {
                Program.myController.UpdateCustomer(int.Parse(DGV.SelectedRows[0].Cells[0].Value.ToString()), NametextBox.Text, TeltextBox.Text, BalanceText.Value);
                Form4_Load(sender, e);
            }
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            DGV.ClearSelection();
        }
    }
}
