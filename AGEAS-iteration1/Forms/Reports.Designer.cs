namespace AGEAS_iteration1
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AGEASDataSet1 = new AGEAS_iteration1.AGEASDataSet1();
            this.getMonthlyProfitReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AGEASDataSet = new AGEAS_iteration1.AGEASDataSet();
            this.Backbtn5 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getMonthlyProfitReportTableAdapter = new AGEAS_iteration1.AGEASDataSetTableAdapters.getMonthlyProfitReportTableAdapter();
            this.cbReportOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelProfitSearchParameters = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.getCustomerTableAdapter = new AGEAS_iteration1.AGEASDataSet1TableAdapters.getCustomerTableAdapter();
            this.getAnnualProfitReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAnnualProfitReportTableAdapter = new AGEAS_iteration1.AGEASDataSet1TableAdapters.getAnnualProfitReportTableAdapter();
            this.getDailyProfitReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDailyProfitReportTableAdapter = new AGEAS_iteration1.AGEASDataSet1TableAdapters.getDailyProfitReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGEASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMonthlyProfitReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGEASDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelProfitSearchParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAnnualProfitReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDailyProfitReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getCustomerBindingSource
            // 
            this.getCustomerBindingSource.DataMember = "getCustomer";
            this.getCustomerBindingSource.DataSource = this.AGEASDataSet1;
            // 
            // AGEASDataSet1
            // 
            this.AGEASDataSet1.DataSetName = "AGEASDataSet1";
            this.AGEASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMonthlyProfitReportBindingSource
            // 
            this.getMonthlyProfitReportBindingSource.DataMember = "getMonthlyProfitReport";
            this.getMonthlyProfitReportBindingSource.DataSource = this.AGEASDataSet;
            // 
            // AGEASDataSet
            // 
            this.AGEASDataSet.DataSetName = "AGEASDataSet";
            this.AGEASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Backbtn5
            // 
            this.Backbtn5.Location = new System.Drawing.Point(12, 15);
            this.Backbtn5.Name = "Backbtn5";
            this.Backbtn5.Size = new System.Drawing.Size(143, 26);
            this.Backbtn5.TabIndex = 1;
            this.Backbtn5.Text = "الرجوع";
            this.Backbtn5.UseVisualStyleBackColor = true;
            this.Backbtn5.Click += new System.EventHandler(this.Backbtn5_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getCustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AGEAS_iteration1.Forms.CustomerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportViewer1.Size = new System.Drawing.Size(1018, 379);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // getMonthlyProfitReportTableAdapter
            // 
            this.getMonthlyProfitReportTableAdapter.ClearBeforeFill = true;
            // 
            // cbReportOptions
            // 
            this.cbReportOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportOptions.FormattingEnabled = true;
            this.cbReportOptions.Items.AddRange(new object[] {
            "الارباح",
            "العملاء"});
            this.cbReportOptions.Location = new System.Drawing.Point(611, 22);
            this.cbReportOptions.Name = "cbReportOptions";
            this.cbReportOptions.Size = new System.Drawing.Size(121, 21);
            this.cbReportOptions.TabIndex = 3;
            this.cbReportOptions.SelectedIndexChanged += new System.EventHandler(this.cbReportOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تقرير عن";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelProfitSearchParameters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbReportOptions);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(846, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الخيارات";
            // 
            // panelProfitSearchParameters
            // 
            this.panelProfitSearchParameters.Controls.Add(this.label2);
            this.panelProfitSearchParameters.Controls.Add(this.dateTimePicker1);
            this.panelProfitSearchParameters.Controls.Add(this.cbDate);
            this.panelProfitSearchParameters.Location = new System.Drawing.Point(165, 20);
            this.panelProfitSearchParameters.Name = "panelProfitSearchParameters";
            this.panelProfitSearchParameters.Size = new System.Drawing.Size(440, 31);
            this.panelProfitSearchParameters.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "الفترة الزمنية";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cbDate
            // 
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Items.AddRange(new object[] {
            "سنوي",
            "شهري",
            "يومي"});
            this.cbDate.Location = new System.Drawing.Point(215, 2);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(121, 21);
            this.cbDate.TabIndex = 5;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(12, 43);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(143, 26);
            this.buttonGenerateReport.TabIndex = 6;
            this.buttonGenerateReport.Text = "التقرير";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // getCustomerTableAdapter
            // 
            this.getCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // getAnnualProfitReportBindingSource
            // 
            this.getAnnualProfitReportBindingSource.DataMember = "getAnnualProfitReport";
            this.getAnnualProfitReportBindingSource.DataSource = this.AGEASDataSet1;
            // 
            // getAnnualProfitReportTableAdapter
            // 
            this.getAnnualProfitReportTableAdapter.ClearBeforeFill = true;
            // 
            // getDailyProfitReportBindingSource
            // 
            this.getDailyProfitReportBindingSource.DataMember = "getDailyProfitReport";
            this.getDailyProfitReportBindingSource.DataSource = this.AGEASDataSet1;
            // 
            // getDailyProfitReportTableAdapter
            // 
            this.getDailyProfitReportTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 466);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Backbtn5);
            this.Name = "Reports";
            this.Text = "تقارير";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGEASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMonthlyProfitReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGEASDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelProfitSearchParameters.ResumeLayout(false);
            this.panelProfitSearchParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAnnualProfitReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDailyProfitReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbtn5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getMonthlyProfitReportBindingSource;
        private AGEASDataSet AGEASDataSet;
        private AGEASDataSetTableAdapters.getMonthlyProfitReportTableAdapter getMonthlyProfitReportTableAdapter;
        private System.Windows.Forms.ComboBox cbReportOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelProfitSearchParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.BindingSource getCustomerBindingSource;
        private AGEASDataSet1 AGEASDataSet1;
        private AGEASDataSet1TableAdapters.getCustomerTableAdapter getCustomerTableAdapter;
        private System.Windows.Forms.BindingSource getAnnualProfitReportBindingSource;
        private AGEASDataSet1TableAdapters.getAnnualProfitReportTableAdapter getAnnualProfitReportTableAdapter;
        private System.Windows.Forms.BindingSource getDailyProfitReportBindingSource;
        private AGEASDataSet1TableAdapters.getDailyProfitReportTableAdapter getDailyProfitReportTableAdapter;
    }
}