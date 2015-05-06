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
            panelProfitSearchParameters.Visible = false;
        }

        private void Backbtn5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //reportViewer1.
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {

            // according to the selected type show the corresponding report
            switch (cbReportOptions.SelectedIndex)
            {
                case 0:
                    // the profit report
                    GenerateProfitReport();
                    break;
                case 1:
                    // products report
                    GenerateProductReport();
                    break;
                case 2:
                    // customers report
                    GenerateCustomerReport();
                    break;
                default:
                    break;
            }

            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// Get the customer report from the database.
        /// </summary>
        private void GenerateCustomerReport()
        {
            this.getCustomerTableAdapter.Fill(this.AGEASDataSet1.getCustomer);
        }

        /// <summary>
        /// Get the product report from the database
        /// </summary>
        private void GenerateProductReport()
        {
            this.getCustomerTableAdapter.Fill(this.AGEASDataSet1.getCustomer);
        }

        /// <summary>
        /// Get the profit report from the database, according to the date requirement.
        /// </summary>
        private void GenerateProfitReport()
        {
            switch (cbDate.SelectedIndex)
            {
                case 0:
                    // by year
                    this.getAnnualProfitReportTableAdapter.Fill(this.AGEASDataSet1.getAnnualProfitReport, dateTimePicker1.Value.Year);
                    break;
                case 1:
                    // By month
                    this.getMonthlyProfitReportTableAdapter.Fill(this.AGEASDataSet.getMonthlyProfitReport, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
                    break;
                case 2:
                    this.getDailyProfitReportTableAdapter.Fill(this.AGEASDataSet1.getDailyProfitReport, dateTimePicker1.Value.Date);
                    break;
                default:
                    break;
            }
            
        }

        private void cbReportOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelProfitSearchParameters.Visible = false;

            // show the parameters panel if only user choose the profits report
            if (cbReportOptions.SelectedIndex == 0)
            {
                panelProfitSearchParameters.Visible = true;
            }
        }
    }
}
