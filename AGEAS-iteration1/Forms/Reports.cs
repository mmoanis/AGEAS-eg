using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using AGEAS_iteration1.Properties;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            panelProfitSearchParameters.Visible = false;
            string connectionString = Settings.Default.ServerName + Settings.Default.ConnectionString; ;
            getAnnualProfitReportTableAdapter.Connection.ConnectionString = connectionString;
            getCustomerTableAdapter.Connection.ConnectionString = connectionString;
            getDailyProfitReportTableAdapter.Connection.ConnectionString = connectionString;
            getMonthlyProfitReportTableAdapter.Connection.ConnectionString = connectionString;
        
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getCustomerBindingSource;
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AGEAS_iteration1.Forms.CustomerReport.rdlc";
        }

        /// <summary>
        /// Get the product report from the database
        /// </summary>
        private void GenerateProductReport()
        {
            // TODO: add the product reports
        }

        /// <summary>
        /// Get the profit report from the database, according to the date requirement.
        /// </summary>
        private void GenerateProfitReport()
        {
            this.reportViewer1.Reset();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            
            switch (cbDate.SelectedIndex)
            {
                case 0:
                    // by year
                    this.getAnnualProfitReportTableAdapter.Fill(this.AGEASDataSet1.getAnnualProfitReport, dateTimePicker1.Value.Year);
                    reportDataSource1.Name = "DataSet1";
                    reportDataSource1.Value = this.getAnnualProfitReportBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "AGEAS_iteration1.Forms.ProfitReportAnnual.rdlc";
                    break;
                case 1:
                    // By month
                    this.getMonthlyProfitReportTableAdapter.Fill(this.AGEASDataSet.getMonthlyProfitReport, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
                    reportDataSource1.Name = "DataSet1";
                    reportDataSource1.Value = this.getMonthlyProfitReportBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "AGEAS_iteration1.Forms.ProfitReport.rdlc";
                    break;
                case 2:
                    this.getDailyProfitReportTableAdapter.Fill(this.AGEASDataSet1.getDailyProfitReport, dateTimePicker1.Value.Date);
                    reportDataSource1.Name = "DataSet1";
                    reportDataSource1.Value = this.getDailyProfitReportBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "AGEAS_iteration1.Forms.ProfitReportDaily.rdlc";
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
