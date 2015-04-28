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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.TypetextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "بضائع";
            // 
            // Backbtn1
            // 
            this.Backbtn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn1.Location = new System.Drawing.Point(12, 559);
            this.Backbtn1.Name = "Backbtn1";
            this.Backbtn1.Size = new System.Drawing.Size(128, 33);
            this.Backbtn1.TabIndex = 1;
            this.Backbtn1.Text = "الرجوع";
            this.Backbtn1.UseVisualStyleBackColor = true;
            this.Backbtn1.Click += new System.EventHandler(this.Backbtn1_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(37, 147);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(128, 33);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "تعديل";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(282, 20);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(43, 20);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = ":النوع";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(282, 53);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(47, 20);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = ":السعر\r\n";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(282, 83);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 20);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = ":الكمية";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLabel.Location = new System.Drawing.Point(282, 118);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(51, 20);
            this.SupplierLabel.TabIndex = 14;
            this.SupplierLabel.Text = ":المورد";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(37, 83);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(222, 20);
            this.QuantitytextBox.TabIndex = 18;
            // 
            // TypetextBox
            // 
            this.TypetextBox.Location = new System.Drawing.Point(37, 20);
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(222, 20);
            this.TypetextBox.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(222, 22);
            this.comboBox1.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(37, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(222, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.QuantitytextBox);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.TypeLabel);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.PriceLabel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.QuantityLabel);
            this.groupBox1.Controls.Add(this.TypetextBox);
            this.groupBox1.Controls.Add(this.SupplierLabel);
            this.groupBox1.Location = new System.Drawing.Point(986, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 235);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(116, 186);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 33);
            this.DeleteButton.TabIndex = 32;
            this.DeleteButton.Text = "مسح";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(205, 147);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 33);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "اضافة";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 164);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(947, 370);
            this.DGV.TabIndex = 27;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(688, 90);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(222, 20);
            this.SearchTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(554, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(916, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = ":النوع";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 604);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Backbtn1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "بضائع";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.TextBox TypetextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}