namespace UI
{
    partial class ChangePassword
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_Oldpassword = new System.Windows.Forms.TextBox();
            this.lb_oldPassword = new System.Windows.Forms.Label();
            this.lb_newPass = new System.Windows.Forms.Label();
            this.tb_newPass = new System.Windows.Forms.TextBox();
            this.lb_Confirmpass = new System.Windows.Forms.Label();
            this.tb_confirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(629, 266);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(86, 40);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Done";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_Oldpassword
            // 
            this.tb_Oldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Oldpassword.Location = new System.Drawing.Point(347, 60);
            this.tb_Oldpassword.Name = "tb_Oldpassword";
            this.tb_Oldpassword.PasswordChar = '*';
            this.tb_Oldpassword.Size = new System.Drawing.Size(368, 35);
            this.tb_Oldpassword.TabIndex = 0;
            // 
            // lb_oldPassword
            // 
            this.lb_oldPassword.AutoSize = true;
            this.lb_oldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_oldPassword.Location = new System.Drawing.Point(22, 63);
            this.lb_oldPassword.Name = "lb_oldPassword";
            this.lb_oldPassword.Size = new System.Drawing.Size(209, 29);
            this.lb_oldPassword.TabIndex = 4;
            this.lb_oldPassword.Text = "Password hiện tại:";
            // 
            // lb_newPass
            // 
            this.lb_newPass.AutoSize = true;
            this.lb_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_newPass.Location = new System.Drawing.Point(22, 126);
            this.lb_newPass.Name = "lb_newPass";
            this.lb_newPass.Size = new System.Drawing.Size(172, 29);
            this.lb_newPass.TabIndex = 4;
            this.lb_newPass.Text = "Password mới:";
            // 
            // tb_newPass
            // 
            this.tb_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_newPass.Location = new System.Drawing.Point(347, 123);
            this.tb_newPass.Name = "tb_newPass";
            this.tb_newPass.PasswordChar = '*';
            this.tb_newPass.Size = new System.Drawing.Size(368, 35);
            this.tb_newPass.TabIndex = 1;
            // 
            // lb_Confirmpass
            // 
            this.lb_Confirmpass.AutoSize = true;
            this.lb_Confirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Confirmpass.Location = new System.Drawing.Point(22, 193);
            this.lb_Confirmpass.Name = "lb_Confirmpass";
            this.lb_Confirmpass.Size = new System.Drawing.Size(230, 29);
            this.lb_Confirmpass.TabIndex = 4;
            this.lb_Confirmpass.Text = "Xác nhận password:";
            // 
            // tb_confirmPass
            // 
            this.tb_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_confirmPass.Location = new System.Drawing.Point(347, 190);
            this.tb_confirmPass.Name = "tb_confirmPass";
            this.tb_confirmPass.PasswordChar = '*';
            this.tb_confirmPass.Size = new System.Drawing.Size(368, 35);
            this.tb_confirmPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ghi chú: Mật khẩu phải chứa ít nhất 6 kí tự";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_confirmPass);
            this.Controls.Add(this.tb_newPass);
            this.Controls.Add(this.tb_Oldpassword);
            this.Controls.Add(this.lb_Confirmpass);
            this.Controls.Add(this.lb_newPass);
            this.Controls.Add(this.lb_oldPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_Oldpassword;
        private System.Windows.Forms.Label lb_oldPassword;
        private System.Windows.Forms.Label lb_newPass;
        private System.Windows.Forms.TextBox tb_newPass;
        private System.Windows.Forms.Label lb_Confirmpass;
        private System.Windows.Forms.TextBox tb_confirmPass;
        private System.Windows.Forms.Label label1;
    }
}