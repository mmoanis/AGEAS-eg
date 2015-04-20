namespace AGEAS_iteration1
{
    partial class Form3
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
            this.Backbtn1 = new System.Windows.Forms.Button();
            this.Addrbtn1 = new System.Windows.Forms.RadioButton();
            this.Searchrbtn1 = new System.Windows.Forms.RadioButton();
            this.Updaterbtn1 = new System.Windows.Forms.RadioButton();
            this.Browserbtn1 = new System.Windows.Forms.RadioButton();
            this.Applybtn1 = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.TypetextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "بضائع";
            // 
            // Backbtn1
            // 
            this.Backbtn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn1.Location = new System.Drawing.Point(53, 421);
            this.Backbtn1.Name = "Backbtn1";
            this.Backbtn1.Size = new System.Drawing.Size(128, 33);
            this.Backbtn1.TabIndex = 1;
            this.Backbtn1.Text = "الرجوع";
            this.Backbtn1.UseVisualStyleBackColor = true;
            this.Backbtn1.Click += new System.EventHandler(this.Backbtn1_Click);
            // 
            // Addrbtn1
            // 
            this.Addrbtn1.AutoSize = true;
            this.Addrbtn1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addrbtn1.Location = new System.Drawing.Point(428, 116);
            this.Addrbtn1.Name = "Addrbtn1";
            this.Addrbtn1.Size = new System.Drawing.Size(64, 25);
            this.Addrbtn1.TabIndex = 2;
            this.Addrbtn1.TabStop = true;
            this.Addrbtn1.Text = "اضافة";
            this.Addrbtn1.UseVisualStyleBackColor = true;
            this.Addrbtn1.CheckedChanged += new System.EventHandler(this.Browserbtn1_CheckedChanged);
            // 
            // Searchrbtn1
            // 
            this.Searchrbtn1.AutoSize = true;
            this.Searchrbtn1.Enabled = false;
            this.Searchrbtn1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchrbtn1.Location = new System.Drawing.Point(301, 116);
            this.Searchrbtn1.Name = "Searchrbtn1";
            this.Searchrbtn1.Size = new System.Drawing.Size(57, 25);
            this.Searchrbtn1.TabIndex = 3;
            this.Searchrbtn1.TabStop = true;
            this.Searchrbtn1.Text = "بحث";
            this.Searchrbtn1.UseVisualStyleBackColor = true;
            this.Searchrbtn1.CheckedChanged += new System.EventHandler(this.Browserbtn1_CheckedChanged);
            // 
            // Updaterbtn1
            // 
            this.Updaterbtn1.AutoSize = true;
            this.Updaterbtn1.Enabled = false;
            this.Updaterbtn1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updaterbtn1.Location = new System.Drawing.Point(164, 116);
            this.Updaterbtn1.Name = "Updaterbtn1";
            this.Updaterbtn1.Size = new System.Drawing.Size(61, 25);
            this.Updaterbtn1.TabIndex = 4;
            this.Updaterbtn1.TabStop = true;
            this.Updaterbtn1.Text = "تعديل";
            this.Updaterbtn1.UseVisualStyleBackColor = true;
            this.Updaterbtn1.CheckedChanged += new System.EventHandler(this.Browserbtn1_CheckedChanged);
            // 
            // Browserbtn1
            // 
            this.Browserbtn1.AutoSize = true;
            this.Browserbtn1.Enabled = false;
            this.Browserbtn1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browserbtn1.Location = new System.Drawing.Point(53, 116);
            this.Browserbtn1.Name = "Browserbtn1";
            this.Browserbtn1.Size = new System.Drawing.Size(68, 25);
            this.Browserbtn1.TabIndex = 5;
            this.Browserbtn1.TabStop = true;
            this.Browserbtn1.Text = "عرض";
            this.Browserbtn1.UseVisualStyleBackColor = true;
            this.Browserbtn1.CheckedChanged += new System.EventHandler(this.Browserbtn1_CheckedChanged);
            // 
            // Applybtn1
            // 
            this.Applybtn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applybtn1.Location = new System.Drawing.Point(53, 382);
            this.Applybtn1.Name = "Applybtn1";
            this.Applybtn1.Size = new System.Drawing.Size(128, 33);
            this.Applybtn1.TabIndex = 6;
            this.Applybtn1.Text = "تعديل";
            this.Applybtn1.UseVisualStyleBackColor = true;
            this.Applybtn1.Click += new System.EventHandler(this.Applybtn1_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(424, 170);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(43, 20);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = ":النوع";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(424, 203);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(47, 20);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = ":السعر\r\n";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(424, 233);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 20);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = ":الكمية";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLabel.Location = new System.Drawing.Point(424, 268);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(51, 20);
            this.SupplierLabel.TabIndex = 14;
            this.SupplierLabel.Text = ":المورد";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(179, 233);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(222, 20);
            this.QuantitytextBox.TabIndex = 18;
            // 
            // TypetextBox
            // 
            this.TypetextBox.Location = new System.Drawing.Point(179, 170);
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(222, 20);
            this.TypetextBox.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(222, 22);
            this.comboBox1.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(179, 205);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(222, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 486);
            this.ControlBox = false;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TypetextBox);
            this.Controls.Add(this.QuantitytextBox);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.Applybtn1);
            this.Controls.Add(this.Browserbtn1);
            this.Controls.Add(this.Updaterbtn1);
            this.Controls.Add(this.Searchrbtn1);
            this.Controls.Add(this.Addrbtn1);
            this.Controls.Add(this.Backbtn1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "بضائع";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn1;
        private System.Windows.Forms.RadioButton Addrbtn1;
        private System.Windows.Forms.RadioButton Searchrbtn1;
        private System.Windows.Forms.RadioButton Updaterbtn1;
        private System.Windows.Forms.RadioButton Browserbtn1;
        private System.Windows.Forms.Button Applybtn1;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.TextBox TypetextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}