namespace UI
{
    partial class EditLSiCaSSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLSiCaSSubForm));
            this.tb_Mssv = new System.Windows.Forms.TextBox();
            this.lb_Masv = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_Note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Mssv
            // 
            this.tb_Mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Mssv.Location = new System.Drawing.Point(198, 50);
            this.tb_Mssv.Name = "tb_Mssv";
            this.tb_Mssv.Size = new System.Drawing.Size(253, 35);
            this.tb_Mssv.TabIndex = 25;
            // 
            // lb_Masv
            // 
            this.lb_Masv.AutoSize = true;
            this.lb_Masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Masv.Location = new System.Drawing.Point(12, 53);
            this.lb_Masv.Name = "lb_Masv";
            this.lb_Masv.Size = new System.Drawing.Size(150, 29);
            this.lb_Masv.TabIndex = 26;
            this.lb_Masv.Text = "Nhập MSSV:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Add.Location = new System.Drawing.Point(337, 119);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(114, 57);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_Note
            // 
            this.lb_Note.AutoSize = true;
            this.lb_Note.Cursor = System.Windows.Forms.Cursors.Help;
            this.lb_Note.Location = new System.Drawing.Point(27, 142);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Size = new System.Drawing.Size(220, 20);
            this.lb_Note.TabIndex = 36;
            this.lb_Note.Text = "Ghi chú: MSSV tối đa 10 kí tự.";
            // 
            // EditLSiCaSSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 188);
            this.Controls.Add(this.lb_Note);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Mssv);
            this.Controls.Add(this.lb_Masv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditLSiCaSSubForm";
            this.Text = "Thêm SV vào DSSV từng môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Mssv;
        private System.Windows.Forms.Label lb_Masv;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_Note;
    }
}