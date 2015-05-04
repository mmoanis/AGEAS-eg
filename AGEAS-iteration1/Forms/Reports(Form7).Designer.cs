namespace AGEAS_iteration1
{
    partial class Form7
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
            this.Backbtn5 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AGEASDataSet = new AGEAS_iteration1.AGEASDataSet();
            this.getMonthlyProfitReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMonthlyProfitReportTableAdapter = new AGEAS_iteration1.AGEASDataSetTableAdapters.getMonthlyProfitReportTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AGEASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMonthlyProfitReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn5
            // 
            this.Backbtn5.Location = new System.Drawing.Point(12, 431);
            this.Backbtn5.Name = "Backbtn5";
            this.Backbtn5.Size = new System.Drawing.Size(75, 23);
            this.Backbtn5.TabIndex = 1;
            this.Backbtn5.Text = "Back";
            this.Backbtn5.UseVisualStyleBackColor = true;
            this.Backbtn5.Click += new System.EventHandler(this.Backbtn5_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getMonthlyProfitReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AGEAS_iteration1.Forms.ProfitReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1018, 413);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // AGEASDataSet
            // 
            this.AGEASDataSet.DataSetName = "AGEASDataSet";
            this.AGEASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMonthlyProfitReportBindingSource
            // 
            this.getMonthlyProfitReportBindingSource.DataMember = "getMonthlyProfitReport";
            this.getMonthlyProfitReportBindingSource.DataSource = this.AGEASDataSet;
            // 
            // getMonthlyProfitReportTableAdapter
            // 
            this.getMonthlyProfitReportTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(680, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(808, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 466);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Backbtn5);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AGEASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMonthlyProfitReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbtn5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getMonthlyProfitReportBindingSource;
        private AGEASDataSet AGEASDataSet;
        private AGEASDataSetTableAdapters.getMonthlyProfitReportTableAdapter getMonthlyProfitReportTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}