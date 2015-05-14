namespace AGEAS_iteration1
{
    partial class Login
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
            this.Usernamebtn = new System.Windows.Forms.Label();
            this.Passwordbtn = new System.Windows.Forms.Label();
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usernamebtn
            // 
            this.Usernamebtn.AutoSize = true;
            this.Usernamebtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamebtn.Location = new System.Drawing.Point(333, 182);
            this.Usernamebtn.Name = "Usernamebtn";
            this.Usernamebtn.Size = new System.Drawing.Size(128, 26);
            this.Usernamebtn.TabIndex = 0;
            this.Usernamebtn.Text = ":اسم المستخدم";
            // 
            // Passwordbtn
            // 
            this.Passwordbtn.AutoSize = true;
            this.Passwordbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordbtn.Location = new System.Drawing.Point(354, 217);
            this.Passwordbtn.Name = "Passwordbtn";
            this.Passwordbtn.Size = new System.Drawing.Size(113, 26);
            this.Passwordbtn.TabIndex = 1;
            this.Passwordbtn.Text = ":كلمة المرور";
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Location = new System.Drawing.Point(140, 182);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UsernametextBox.Size = new System.Drawing.Size(169, 20);
            this.UsernametextBox.TabIndex = 2;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(140, 223);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PasswordtextBox.Size = new System.Drawing.Size(169, 20);
            this.PasswordtextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "احمد جمال للأجهزة الكهربائية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "تسجيل الدخول";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loginbtn.Location = new System.Drawing.Point(457, 383);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(92, 40);
            this.Loginbtn.TabIndex = 6;
            this.Loginbtn.Text = "تسجيل";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(62, 383);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(92, 40);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "خروج";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 481);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UsernametextBox);
            this.Controls.Add(this.Passwordbtn);
            this.Controls.Add(this.Usernamebtn);
            this.Name = "Form1";
            this.Text = "تسجيل الدخول";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernamebtn;
        private System.Windows.Forms.Label Passwordbtn;
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button CloseButton;
    }
}

