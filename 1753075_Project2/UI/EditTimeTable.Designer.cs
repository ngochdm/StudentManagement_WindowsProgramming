namespace UI
{
    partial class EditTimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTimeTable));
            this.tb_ckbd = new System.Windows.Forms.TextBox();
            this.tb_phong = new System.Windows.Forms.TextBox();
            this.lb_ckbd = new System.Windows.Forms.Label();
            this.lb_phong = new System.Windows.Forms.Label();
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.lb_Hocky = new System.Windows.Forms.Label();
            this.lb_mamon = new System.Windows.Forms.Label();
            this.lb_ClassID = new System.Windows.Forms.Label();
            this.cbb_hocky = new System.Windows.Forms.ComboBox();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ckbd
            // 
            this.tb_ckbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_ckbd.Location = new System.Drawing.Point(570, 146);
            this.tb_ckbd.Name = "tb_ckbd";
            this.tb_ckbd.Size = new System.Drawing.Size(62, 30);
            this.tb_ckbd.TabIndex = 23;
            // 
            // tb_phong
            // 
            this.tb_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_phong.Location = new System.Drawing.Point(120, 146);
            this.tb_phong.Name = "tb_phong";
            this.tb_phong.Size = new System.Drawing.Size(142, 30);
            this.tb_phong.TabIndex = 22;
            // 
            // lb_ckbd
            // 
            this.lb_ckbd.AutoSize = true;
            this.lb_ckbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ckbd.Location = new System.Drawing.Point(337, 149);
            this.lb_ckbd.Name = "lb_ckbd";
            this.lb_ckbd.Size = new System.Drawing.Size(212, 25);
            this.lb_ckbd.TabIndex = 28;
            this.lb_ckbd.Text = "Công Khai Bảng Điểm:";
            // 
            // lb_phong
            // 
            this.lb_phong.AutoSize = true;
            this.lb_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phong.Location = new System.Drawing.Point(39, 149);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(75, 25);
            this.lb_phong.TabIndex = 29;
            this.lb_phong.Text = "Phòng:";
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tenmon.Location = new System.Drawing.Point(350, 87);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(91, 25);
            this.lb_tenmon.TabIndex = 27;
            this.lb_tenmon.Text = "Tên Môn";
            // 
            // lb_Hocky
            // 
            this.lb_Hocky.AutoSize = true;
            this.lb_Hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Hocky.Location = new System.Drawing.Point(357, 37);
            this.lb_Hocky.Name = "lb_Hocky";
            this.lb_Hocky.Size = new System.Drawing.Size(78, 25);
            this.lb_Hocky.TabIndex = 24;
            this.lb_Hocky.Text = "Học kỳ:";
            // 
            // lb_mamon
            // 
            this.lb_mamon.AutoSize = true;
            this.lb_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_mamon.Location = new System.Drawing.Point(39, 82);
            this.lb_mamon.Name = "lb_mamon";
            this.lb_mamon.Size = new System.Drawing.Size(94, 25);
            this.lb_mamon.TabIndex = 25;
            this.lb_mamon.Text = "Môn học:";
            // 
            // lb_ClassID
            // 
            this.lb_ClassID.AutoSize = true;
            this.lb_ClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_ClassID.Location = new System.Drawing.Point(39, 34);
            this.lb_ClassID.Name = "lb_ClassID";
            this.lb_ClassID.Size = new System.Drawing.Size(51, 25);
            this.lb_ClassID.TabIndex = 26;
            this.lb_ClassID.Text = "Lớp:";
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_hocky.FormattingEnabled = true;
            this.cbb_hocky.Location = new System.Drawing.Point(497, 34);
            this.cbb_hocky.Name = "cbb_hocky";
            this.cbb_hocky.Size = new System.Drawing.Size(136, 33);
            this.cbb_hocky.TabIndex = 21;
            this.cbb_hocky.SelectedIndexChanged += new System.EventHandler(this.cbb_hocky_SelectedIndexChanged);
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(179, 79);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(136, 33);
            this.cbb_MonHoc.TabIndex = 20;
            this.cbb_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_MonHoc_SelectedIndexChanged);
            // 
            // cbb_lop
            // 
            this.cbb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(179, 31);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(136, 33);
            this.cbb_lop.TabIndex = 19;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 100);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ghi chú: \r\n- Mã phòng tối đa 10 kí tự.\r\n- Công Khai Bảng Điểm chỉ nhập 0 hoặc 1\r\n" +
    "   + 0: Chưa hiện bảng điểm cho Sinh Viên\r\n   + 1: Hiện bảng điểm cho Sinh Viên";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(534, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 30;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_ckbd);
            this.Controls.Add(this.tb_phong);
            this.Controls.Add(this.lb_ckbd);
            this.Controls.Add(this.lb_phong);
            this.Controls.Add(this.lb_tenmon);
            this.Controls.Add(this.lb_Hocky);
            this.Controls.Add(this.lb_mamon);
            this.Controls.Add(this.lb_ClassID);
            this.Controls.Add(this.cbb_hocky);
            this.Controls.Add(this.cbb_MonHoc);
            this.Controls.Add(this.cbb_lop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTimeTable";
            this.Text = "Sửa Thời Khóa Biểu";
            this.Load += new System.EventHandler(this.EditTimeTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ckbd;
        private System.Windows.Forms.TextBox tb_phong;
        private System.Windows.Forms.Label lb_ckbd;
        private System.Windows.Forms.Label lb_phong;
        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.Label lb_Hocky;
        private System.Windows.Forms.Label lb_mamon;
        private System.Windows.Forms.Label lb_ClassID;
        private System.Windows.Forms.ComboBox cbb_hocky;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}