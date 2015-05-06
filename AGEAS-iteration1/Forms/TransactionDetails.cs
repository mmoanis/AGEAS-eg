using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1.Forms
{
    public partial class TransactionDetails : Form
    {
        private int transaction_ID;
        private bool addedItems;
        public TransactionDetails(bool viewNewPurchaseDetail, int transaction_id)
        {
            InitializeComponent();
            addedItems = false;
            groupBox2.Visible = viewNewPurchaseDetail;
            transaction_ID = transaction_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("لابد من اختيار منتج");
                return;
            }

            Program.myController.AddProductPurchase((int)comboBox2.SelectedValue, transaction_ID, (int)numericUpDown1.Value);
            addedItems = true;

            loadDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: fix application navigation
        }

        private void TransactionDetails_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = Program.myController.GetProductsList();
            comboBox2.DisplayMember = "الاسم";
            comboBox2.ValueMember = "الرقم";

            loadDetails();
        }

        private void loadDetails()
        {
            dataGridView1.DataSource = Program.myController.GetProductsPurchase(transaction_ID);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TransactionDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (groupBox2.Visible && !addedItems)
            {
                e.Cancel = true;
                MessageBox.Show("يجب ادخال علي الاقل منتج واحد في الفاتورة");
            }
        }
    }
}
