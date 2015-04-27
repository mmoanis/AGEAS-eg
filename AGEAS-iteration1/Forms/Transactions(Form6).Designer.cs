namespace AGEAS_iteration1
{
    partial class Form6
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
            this.Backbtn4 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.CustomertextBox = new System.Windows.Forms.TextBox();
            this.DiscounttextBox = new System.Windows.Forms.TextBox();
            this.DatetextBox = new System.Windows.Forms.TextBox();
            this.ProducttextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعاملات";
            // 
            // Backbtn4
            // 
            this.Backbtn4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn4.Location = new System.Drawing.Point(12, 559);
            this.Backbtn4.Name = "Backbtn4";
            this.Backbtn4.Size = new System.Drawing.Size(128, 33);
            this.Backbtn4.TabIndex = 1;
            this.Backbtn4.Text = "رجوع";
            this.Backbtn4.UseVisualStyleBackColor = true;
            this.Backbtn4.Click += new System.EventHandler(this.Backbtn4_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(6, 159);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(128, 33);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "تعديل";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(250, 30);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(48, 20);
            this.CustomerLabel.TabIndex = 11;
            this.CustomerLabel.Text = ":العميل";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(251, 64);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(45, 20);
            this.ProductLabel.TabIndex = 12;
            this.ProductLabel.Text = ":المنتج";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(247, 99);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(51, 20);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = ":التاريخ";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(241, 133);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(64, 20);
            this.DiscountLabel.TabIndex = 14;
            this.DiscountLabel.Text = ":التخفيض";
            // 
            // CustomertextBox
            // 
            this.CustomertextBox.Location = new System.Drawing.Point(6, 30);
            this.CustomertextBox.Name = "CustomertextBox";
            this.CustomertextBox.Size = new System.Drawing.Size(220, 20);
            this.CustomertextBox.TabIndex = 15;
            // 
            // DiscounttextBox
            // 
            this.DiscounttextBox.Location = new System.Drawing.Point(6, 133);
            this.DiscounttextBox.Name = "DiscounttextBox";
            this.DiscounttextBox.Size = new System.Drawing.Size(220, 20);
            this.DiscounttextBox.TabIndex = 16;
            // 
            // DatetextBox
            // 
            this.DatetextBox.Location = new System.Drawing.Point(6, 99);
            this.DatetextBox.Name = "DatetextBox";
            this.DatetextBox.Size = new System.Drawing.Size(220, 20);
            this.DatetextBox.TabIndex = 17;
            // 
            // ProducttextBox
            // 
            this.ProducttextBox.Location = new System.Drawing.Point(6, 64);
            this.ProducttextBox.Name = "ProducttextBox";
            this.ProducttextBox.Size = new System.Drawing.Size(220, 20);
            this.ProducttextBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.CustomertextBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.ProducttextBox);
            this.groupBox1.Controls.Add(this.CustomerLabel);
            this.groupBox1.Controls.Add(this.DatetextBox);
            this.groupBox1.Controls.Add(this.ProductLabel);
            this.groupBox1.Controls.Add(this.DiscounttextBox);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.DiscountLabel);
            this.groupBox1.Location = new System.Drawing.Point(1030, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 240);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(78, 198);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 33);
            this.DeleteButton.TabIndex = 34;
            this.DeleteButton.Text = "مسح";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(140, 159);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 33);
            this.AddButton.TabIndex = 33;
            this.AddButton.Text = "اضافة";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 427);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 604);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Backbtn4);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "تعاملات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.TextBox CustomertextBox;
        private System.Windows.Forms.TextBox DiscounttextBox;
        private System.Windows.Forms.TextBox DatetextBox;
        private System.Windows.Forms.TextBox ProducttextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}