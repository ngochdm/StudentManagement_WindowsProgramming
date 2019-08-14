namespace UI
{
    partial class LoginApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginApp));
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_stdmanagement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_username.Location = new System.Drawing.Point(55, 135);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(130, 29);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Password.Location = new System.Drawing.Point(56, 195);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(126, 29);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_username.Location = new System.Drawing.Point(202, 135);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(368, 35);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_password.Location = new System.Drawing.Point(202, 192);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(368, 35);
            this.tb_password.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(514, 266);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(86, 40);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // lb_stdmanagement
            // 
            this.lb_stdmanagement.AutoSize = true;
            this.lb_stdmanagement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_stdmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lb_stdmanagement.Location = new System.Drawing.Point(143, 51);
            this.lb_stdmanagement.Name = "lb_stdmanagement";
            this.lb_stdmanagement.Size = new System.Drawing.Size(457, 42);
            this.lb_stdmanagement.TabIndex = 4;
            this.lb_stdmanagement.Text = "STUDENT MANAGEMENT";
            // 
            // LoginApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 343);
            this.Controls.Add(this.lb_stdmanagement);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginApp";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_stdmanagement;
    }
}

