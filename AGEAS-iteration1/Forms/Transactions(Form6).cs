using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AGEAS_iteration1.Forms;

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
                dateTimePicker3.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
                DiscounttextBox.Value = (decimal) DGV.SelectedRows[0].Cells[4].Value;
                ValueTextBox.Value = (decimal)DGV.SelectedRows[0].Cells[5].Value;
                ReceivedValueTextBox.Value = (decimal)DGV.SelectedRows[0].Cells[6].Value;
                AddButton.Enabled = false;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                dateTimePicker3.Text = "";
                DiscounttextBox.Value = 0;
                ValueTextBox.Value = 0;
                ReceivedValueTextBox.Value = 0;
                AddButton.Enabled = true;
            }
        }

        private void Backbtn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // TODO: add the checks for the input fields used

            Program.myController.AddTransaction((int)comboBox1.SelectedValue, DiscounttextBox.Value, ValueTextBox.Value, ReceivedValueTextBox.Value, checkBox1.Checked);
            Form6_Load(sender, e);

            // show the add transaction details
            TransactionDetails detailsForm = new TransactionDetails(true, (int)DGV.Rows[DGV.RowCount - 1].Cells[0].Value);
            detailsForm.ShowDialog(this);

            DGV.ClearSelection();
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
        }

        private void Form6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Delete a transaction button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count != 0)
                Program.myController.DeleteTransaction((int)DGV.SelectedRows[0].Cells[0].Value);
        }

        /// <summary>
        /// Update a transaction button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Program.myController.UpdateTransaction(Convert.ToInt32(DGV.SelectedRows[0].Cells[0].Value), DiscounttextBox.Value, ValueTextBox.Value, ReceivedValueTextBox.Value, checkBox1.Checked);
            Form6_Load(sender, e);
        }

        /// <summary>
        /// Search for a transaction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    // customer name
                    DGV.DataSource = Program.myController.GetPurchasesByCustomer((int)ClientSearchTextBox.SelectedValue);
                    break;
                case 1:
                    // date
                    DGV.DataSource = Program.myController.SearchPurchaseByDateInterval(dateTimePicker1.Value, dateTimePicker2.Value);
                    break;
                case 3:
                    //Program.myController.SearchPurchaseByDateInterval(dateTimePicker1.Value, dateTimePicker2.Value).AsEnumerable().Where(o => o in Program.myController.GetPurchasesByCustomer((int)ClientSearchTextBox.SelectedValue).AsEnumerable());
                    break;
                default:
                    MessageBox.Show("لابد من اختيار طريقة البحث");
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

        private void DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // moved to double click
        }

        private void DGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TransactionDetails details = new TransactionDetails(false, (int)DGV.SelectedRows[0].Cells[0].Value);
            details.ShowDialog(this);
        }
    }
}
