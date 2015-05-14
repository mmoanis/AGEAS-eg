namespace AGEAS_iteration1
{
    partial class Clients
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BalanceText = new System.Windows.Forms.NumericUpDown();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.TelLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TeltextBox = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn2 = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.BalanceText);
            this.groupBox1.Controls.Add(this.BalanceLabel);
            this.groupBox1.Controls.Add(this.TelLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.TeltextBox);
            this.groupBox1.Location = new System.Drawing.Point(930, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 224);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(35, 45);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NametextBox.Size = new System.Drawing.Size(282, 20);
            this.NametextBox.TabIndex = 33;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(241, 172);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 33);
            this.AddButton.TabIndex = 38;
            this.AddButton.Text = "اضافة";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(35, 172);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(128, 33);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "تعديل";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BalanceText
            // 
            this.BalanceText.Location = new System.Drawing.Point(35, 83);
            this.BalanceText.Name = "BalanceText";
            this.BalanceText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BalanceText.Size = new System.Drawing.Size(282, 20);
            this.BalanceText.TabIndex = 35;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(325, 84);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(50, 19);
            this.BalanceLabel.TabIndex = 25;
            this.BalanceLabel.Text = ":الحساب";
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelLabel.Location = new System.Drawing.Point(326, 120);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(69, 19);
            this.TelLabel.TabIndex = 26;
            this.TelLabel.Text = ":رقم التليفون";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(331, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 19);
            this.NameLabel.TabIndex = 31;
            this.NameLabel.Text = ":الاسم";
            // 
            // TeltextBox
            // 
            this.TeltextBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeltextBox.Location = new System.Drawing.Point(35, 119);
            this.TeltextBox.Name = "TeltextBox";
            this.TeltextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TeltextBox.Size = new System.Drawing.Size(282, 20);
            this.TeltextBox.TabIndex = 29;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(42, 148);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(866, 369);
            this.DGV.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "عملاء";
            // 
            // Backbtn2
            // 
            this.Backbtn2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn2.Location = new System.Drawing.Point(42, 536);
            this.Backbtn2.Name = "Backbtn2";
            this.Backbtn2.Size = new System.Drawing.Size(128, 33);
            this.Backbtn2.TabIndex = 1;
            this.Backbtn2.Text = "رجوع";
            this.Backbtn2.UseVisualStyleBackColor = true;
            this.Backbtn2.Click += new System.EventHandler(this.Backbtn2_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(503, 94);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(128, 33);
            this.SearchButton.TabIndex = 39;
            this.SearchButton.Text = "بحث";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(637, 101);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchTextBox.Size = new System.Drawing.Size(222, 20);
            this.SearchTextBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(870, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = ":الاسم";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 604);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Backbtn2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "عملاء";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Click += new System.EventHandler(this.Form4_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.NumericUpDown BalanceText;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox TeltextBox;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;

    }
}