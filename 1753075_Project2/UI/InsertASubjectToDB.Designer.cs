namespace UI
{
    partial class InsertASubjectToDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertASubjectToDB));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Tenmon = new System.Windows.Forms.TextBox();
            this.tb_Mamon = new System.Windows.Forms.TextBox();
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.lb_mamon = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ghi chú:\r\n- Mã môn học tối đa 10 kí tự.\r\n- Tên môn học tối đa 100 kí tự.";
            // 
            // tb_Tenmon
            // 
            this.tb_Tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Tenmon.Location = new System.Drawing.Point(173, 86);
            this.tb_Tenmon.Name = "tb_Tenmon";
            this.tb_Tenmon.Size = new System.Drawing.Size(350, 35);
            this.tb_Tenmon.TabIndex = 5;
            // 
            // tb_Mamon
            // 
            this.tb_Mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Mamon.Location = new System.Drawing.Point(173, 33);
            this.tb_Mamon.Name = "tb_Mamon";
            this.tb_Mamon.Size = new System.Drawing.Size(350, 35);
            this.tb_Mamon.TabIndex = 4;
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tenmon.Location = new System.Drawing.Point(21, 92);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(137, 25);
            this.lb_tenmon.TabIndex = 6;
            this.lb_tenmon.Text = "Tên Môn Học:";
            // 
            // lb_mamon
            // 
            this.lb_mamon.AutoSize = true;
            this.lb_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_mamon.Location = new System.Drawing.Point(21, 39);
            this.lb_mamon.Name = "lb_mamon";
            this.lb_mamon.Size = new System.Drawing.Size(130, 25);
            this.lb_mamon.TabIndex = 7;
            this.lb_mamon.Text = "Mã Môn Học:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Add.Location = new System.Drawing.Point(439, 162);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 68);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // InsertASubjectToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Tenmon);
            this.Controls.Add(this.tb_Mamon);
            this.Controls.Add(this.lb_tenmon);
            this.Controls.Add(this.lb_mamon);
            this.Controls.Add(this.btn_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertASubjectToDB";
            this.Text = "Add a subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Tenmon;
        private System.Windows.Forms.TextBox tb_Mamon;
        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.Label lb_mamon;
        private System.Windows.Forms.Button btn_Add;
    }
}