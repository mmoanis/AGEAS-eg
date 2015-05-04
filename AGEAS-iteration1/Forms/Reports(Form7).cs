using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Backbtn5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AGEASDataSet.getMonthlyProfitReport' table. You can move, or remove it, as needed.
            this.getMonthlyProfitReportTableAdapter.Fill(this.AGEASDataSet.getMonthlyProfitReport, 5, 2015);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //reportViewer1.
        }
    }
}
