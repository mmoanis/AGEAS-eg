namespace AGEAS_iteration1.Forms
{
    partial class Preferences
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btChangeUserSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserOldPassword = new System.Windows.Forms.TextBox();
            this.tbUserNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btChangeAdminSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdminNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdminOldPassword = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btBackUp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "المستخدمين";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btChangeUserSettings);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbUserOldPassword);
            this.groupBox3.Controls.Add(this.tbUserNewPassword);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(22, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 108);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المستخدم الثانوي";
            // 
            // btChangeUserSettings
            // 
            this.btChangeUserSettings.Location = new System.Drawing.Point(20, 63);
            this.btChangeUserSettings.Name = "btChangeUserSettings";
            this.btChangeUserSettings.Size = new System.Drawing.Size(109, 23);
            this.btChangeUserSettings.TabIndex = 9;
            this.btChangeUserSettings.Text = "تغيير كلمة المرور";
            this.btChangeUserSettings.UseVisualStyleBackColor = true;
            this.btChangeUserSettings.Click += new System.EventHandler(this.btChangeUserSettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "كلمة المرور الجديدة";
            // 
            // tbUserOldPassword
            // 
            this.tbUserOldPassword.Location = new System.Drawing.Point(243, 44);
            this.tbUserOldPassword.Name = "tbUserOldPassword";
            this.tbUserOldPassword.Size = new System.Drawing.Size(140, 20);
            this.tbUserOldPassword.TabIndex = 5;
            // 
            // tbUserNewPassword
            // 
            this.tbUserNewPassword.Location = new System.Drawing.Point(243, 70);
            this.tbUserNewPassword.Name = "tbUserNewPassword";
            this.tbUserNewPassword.Size = new System.Drawing.Size(140, 20);
            this.tbUserNewPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "كلمة المرور القديمة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 248);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btChangeAdminSettings);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbAdminNewPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbAdminOldPassword);
            this.groupBox2.Location = new System.Drawing.Point(16, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 113);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المستخدم الرئيسي";
            // 
            // btChangeAdminSettings
            // 
            this.btChangeAdminSettings.Location = new System.Drawing.Point(20, 73);
            this.btChangeAdminSettings.Name = "btChangeAdminSettings";
            this.btChangeAdminSettings.Size = new System.Drawing.Size(109, 23);
            this.btChangeAdminSettings.TabIndex = 4;
            this.btChangeAdminSettings.Text = "تغيير كلمة المرور";
            this.btChangeAdminSettings.UseVisualStyleBackColor = true;
            this.btChangeAdminSettings.Click += new System.EventHandler(this.btChangeAdminSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور الجديدة";
            // 
            // tbAdminNewPassword
            // 
            this.tbAdminNewPassword.Location = new System.Drawing.Point(243, 80);
            this.tbAdminNewPassword.Name = "tbAdminNewPassword";
            this.tbAdminNewPassword.Size = new System.Drawing.Size(140, 20);
            this.tbAdminNewPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "كلمة المرور القديمة";
            // 
            // tbAdminOldPassword
            // 
            this.tbAdminOldPassword.Location = new System.Drawing.Point(243, 54);
            this.tbAdminOldPassword.Name = "tbAdminOldPassword";
            this.tbAdminOldPassword.Size = new System.Drawing.Size(140, 20);
            this.tbAdminOldPassword.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "قاعدة البيانات";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btBackUp);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حفظ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "لابد من اجراء حفظ لقاعدة البيانات بشكل دوري لنتاكد انه كله في التمام";
            // 
            // btBackUp
            // 
            this.btBackUp.Location = new System.Drawing.Point(200, 32);
            this.btBackUp.Name = "btBackUp";
            this.btBackUp.Size = new System.Drawing.Size(75, 23);
            this.btBackUp.TabIndex = 0;
            this.btBackUp.Text = "back up";
            this.btBackUp.UseVisualStyleBackColor = true;
            this.btBackUp.Click += new System.EventHandler(this.btBackUp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 310);
            this.Controls.Add(this.tabControl1);
            this.Name = "Preferences";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الإعدادات";
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btChangeUserSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserOldPassword;
        private System.Windows.Forms.TextBox tbUserNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btChangeAdminSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdminNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdminOldPassword;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btBackUp;
        private System.Windows.Forms.TabControl tabControl1;

    }
}