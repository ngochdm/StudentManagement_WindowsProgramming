namespace UI
{
    partial class AddAClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAClass));
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_malop = new System.Windows.Forms.Label();
            this.lb_tenlop = new System.Windows.Forms.Label();
            this.tb_Malop = new System.Windows.Forms.TextBox();
            this.tb_Tenlop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Add.Location = new System.Drawing.Point(386, 174);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 68);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_malop
            // 
            this.lb_malop.AutoSize = true;
            this.lb_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_malop.Location = new System.Drawing.Point(40, 55);
            this.lb_malop.Name = "lb_malop";
            this.lb_malop.Size = new System.Drawing.Size(84, 25);
            this.lb_malop.TabIndex = 1;
            this.lb_malop.Text = "Mã Lớp:";
            // 
            // lb_tenlop
            // 
            this.lb_tenlop.AutoSize = true;
            this.lb_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tenlop.Location = new System.Drawing.Point(40, 108);
            this.lb_tenlop.Name = "lb_tenlop";
            this.lb_tenlop.Size = new System.Drawing.Size(91, 25);
            this.lb_tenlop.TabIndex = 1;
            this.lb_tenlop.Text = "Tên Lớp:";
            // 
            // tb_Malop
            // 
            this.tb_Malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Malop.Location = new System.Drawing.Point(143, 49);
            this.tb_Malop.Name = "tb_Malop";
            this.tb_Malop.Size = new System.Drawing.Size(350, 35);
            this.tb_Malop.TabIndex = 0;
            // 
            // tb_Tenlop
            // 
            this.tb_Tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Tenlop.Location = new System.Drawing.Point(143, 102);
            this.tb_Tenlop.Name = "tb_Tenlop";
            this.tb_Tenlop.Size = new System.Drawing.Size(350, 35);
            this.tb_Tenlop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ghi chú:\r\n- Mã lớp tối đa 10 kí tự.\r\n- Tên lớp tối đa 30 kí tự.";
            // 
            // AddAClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Tenlop);
            this.Controls.Add(this.tb_Malop);
            this.Controls.Add(this.lb_tenlop);
            this.Controls.Add(this.lb_malop);
            this.Controls.Add(this.btn_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAClass";
            this.Text = "AddAClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_malop;
        private System.Windows.Forms.Label lb_tenlop;
        private System.Windows.Forms.TextBox tb_Malop;
        private System.Windows.Forms.TextBox tb_Tenlop;
        private System.Windows.Forms.Label label1;
    }
}