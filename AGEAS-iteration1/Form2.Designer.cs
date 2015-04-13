namespace AGEAS_iteration1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Productsbtn = new System.Windows.Forms.Button();
            this.Customersbtn = new System.Windows.Forms.Button();
            this.Transactionsbtn = new System.Windows.Forms.Button();
            this.Suppliersbtn = new System.Windows.Forms.Button();
            this.Reportsbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to AGEAS Database!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose a category:";
            // 
            // Productsbtn
            // 
            this.Productsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productsbtn.Location = new System.Drawing.Point(45, 175);
            this.Productsbtn.Name = "Productsbtn";
            this.Productsbtn.Size = new System.Drawing.Size(91, 40);
            this.Productsbtn.TabIndex = 3;
            this.Productsbtn.Text = "Products";
            this.Productsbtn.UseVisualStyleBackColor = true;
            this.Productsbtn.Click += new System.EventHandler(this.Productsbtn_Click);
            // 
            // Customersbtn
            // 
            this.Customersbtn.Location = new System.Drawing.Point(168, 175);
            this.Customersbtn.Name = "Customersbtn";
            this.Customersbtn.Size = new System.Drawing.Size(91, 38);
            this.Customersbtn.TabIndex = 4;
            this.Customersbtn.Text = "Customers";
            this.Customersbtn.UseVisualStyleBackColor = true;
            this.Customersbtn.Click += new System.EventHandler(this.Customersbtn_Click);
            // 
            // Transactionsbtn
            // 
            this.Transactionsbtn.Location = new System.Drawing.Point(414, 175);
            this.Transactionsbtn.Name = "Transactionsbtn";
            this.Transactionsbtn.Size = new System.Drawing.Size(91, 38);
            this.Transactionsbtn.TabIndex = 5;
            this.Transactionsbtn.Text = "Transactions";
            this.Transactionsbtn.UseVisualStyleBackColor = true;
            this.Transactionsbtn.Click += new System.EventHandler(this.Transactionsbtn_Click);
            // 
            // Suppliersbtn
            // 
            this.Suppliersbtn.Location = new System.Drawing.Point(297, 175);
            this.Suppliersbtn.Name = "Suppliersbtn";
            this.Suppliersbtn.Size = new System.Drawing.Size(91, 38);
            this.Suppliersbtn.TabIndex = 6;
            this.Suppliersbtn.Text = "Suppliers";
            this.Suppliersbtn.UseVisualStyleBackColor = true;
            this.Suppliersbtn.Click += new System.EventHandler(this.Suppliersbtn_Click);
            // 
            // Reportsbtn
            // 
            this.Reportsbtn.Location = new System.Drawing.Point(45, 258);
            this.Reportsbtn.Name = "Reportsbtn";
            this.Reportsbtn.Size = new System.Drawing.Size(91, 38);
            this.Reportsbtn.TabIndex = 7;
            this.Reportsbtn.Text = "Reports";
            this.Reportsbtn.UseVisualStyleBackColor = true;
            this.Reportsbtn.Click += new System.EventHandler(this.Reportsbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Location = new System.Drawing.Point(414, 378);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(91, 24);
            this.Logoutbtn.TabIndex = 8;
            this.Logoutbtn.Text = "Log out";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 456);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Reportsbtn);
            this.Controls.Add(this.Suppliersbtn);
            this.Controls.Add(this.Transactionsbtn);
            this.Controls.Add(this.Customersbtn);
            this.Controls.Add(this.Productsbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Productsbtn;
        private System.Windows.Forms.Button Customersbtn;
        private System.Windows.Forms.Button Transactionsbtn;
        private System.Windows.Forms.Button Suppliersbtn;
        private System.Windows.Forms.Button Reportsbtn;
        private System.Windows.Forms.Button Logoutbtn;
    }
}