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
            CustomerLabel.Visible = true;
            DateLabel.Visible = true;
            DiscountLabel.Visible = true;
            DiscounttextBox.Visible = true;
            UpdateButton.Visible = true;

            DiscounttextBox.Maximum = 100;
            DiscounttextBox.DecimalPlaces = 3;
            ReceivedValueTextBox.Maximum = 999999999;
            ValueTextBox.Maximum = 999999999;
            ReceivedValueTextBox.DecimalPlaces = 3;
            ValueTextBox.DecimalPlaces = 3;
            comboBox3.SelectedIndex = 0;


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
                comboBox1.SelectedValue = DGV.SelectedRows[0].Cells[0].Value.ToString();
                dateTimePicker3.Text = DGV.SelectedRows[0].Cells[3].Value.ToString();
                DiscounttextBox.Value = (decimal) DGV.SelectedRows[0].Cells[4].Value;
                ValueTextBox.Value = (decimal)DGV.SelectedRows[0].Cells[5].Value;
                ReceivedValueTextBox.Value = (decimal)DGV.SelectedRows[0].Cells[6].Value;
                AddButton.Enabled = false;
                groupBox2.Visible = true;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                dateTimePicker3.Text = "";
                DiscounttextBox.Value = 0;
                ValueTextBox.Value = 0;
                ReceivedValueTextBox.Value = 0;
                AddButton.Enabled = true;
                groupBox2.Visible = false;
            }
        }

        private void Backbtn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Program.myController.AddTransaction((int)comboBox2.SelectedValue, DiscounttextBox.Value, ValueTextBox.Value, ReceivedValueTextBox.Value, checkBox1.Checked);
            Form6_Load(sender, e);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DGV.DataSource = Program.myController.GetPurchases();
            DataTable customers = Program.myController.GetCustomers();
            comboBox1.DataSource = customers;
            comboBox1.ValueMember = "الرقم";
            comboBox1.DisplayMember = "الاسم";
            ClientSearchTextBox.DataSource = customers;
            ClientSearchTextBox.ValueMember = "الرقم";
            ClientSearchTextBox.DisplayMember = "الاسم";
            comboBox2.DataSource = Program.myController.GetProductsList();
            comboBox2.ValueMember = "الرقم";
            comboBox2.DisplayMember = "الاسم";
        }

        private void Form6_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Program.myController.UpdateTransaction(Convert.ToInt32(DGV.SelectedRows[0].Cells[0].Value), DiscounttextBox.Value, ValueTextBox.Value, ReceivedValueTextBox.Value, checkBox1.Checked);
            Form6_Load(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal void ShowMessage(string p)
        {
            MessageBox.Show(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.myController.AddProductPurchase((int) comboBox2.SelectedValue, (int) DGV.SelectedRows[0].Cells[0].Value, (int) numericUpDown1.Value);
        }
    }
}
