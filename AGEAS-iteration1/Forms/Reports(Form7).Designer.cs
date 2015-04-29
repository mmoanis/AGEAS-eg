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
            this.Backbtn5 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1018, 413);
            this.reportViewer1.TabIndex = 2;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 466);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Backbtn5);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbtn5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}