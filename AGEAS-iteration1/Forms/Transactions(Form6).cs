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
        DataGridView DGV = new DataGridView();

        public Form6()
        {
            InitializeComponent();
            CustomerLabel.Visible = true;
            ProductLabel.Visible = true;
            DateLabel.Visible = true;
            DiscountLabel.Visible = true;


            CustomertextBox.Visible = true;
            ProducttextBox.Visible = true;
            DatetextBox.Visible = true;
            DiscounttextBox.Visible = true;

            UpdateButton.Visible = true;

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
            
        }

        private void Backbtn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browserbtn4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

    }
}
