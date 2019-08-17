namespace UI
{
    partial class EditScore
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
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.lb_mamon = new System.Windows.Forms.Label();
            this.lb_ClassID = new System.Windows.Forms.Label();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.lb_mssv = new System.Windows.Forms.Label();
            this.tb_MSSV = new System.Windows.Forms.TextBox();
            this.lb_gk = new System.Windows.Forms.Label();
            this.tb_gk = new System.Windows.Forms.TextBox();
            this.lb_ck = new System.Windows.Forms.Label();
            this.lb_khac = new System.Windows.Forms.Label();
            this.tb_ck = new System.Windows.Forms.TextBox();
            this.tb_khac = new System.Windows.Forms.TextBox();
            this.lb_tong = new System.Windows.Forms.Label();
            this.tb_tong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Hocky = new System.Windows.Forms.Label();
            this.cbb_hocky = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tenmon.Location = new System.Drawing.Point(341, 88);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(91, 25);
            this.lb_tenmon.TabIndex = 17;
            this.lb_tenmon.Text = "Tên Môn";
            // 
            // lb_mamon
            // 
            this.lb_mamon.AutoSize = true;
            this.lb_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_mamon.Location = new System.Drawing.Point(30, 83);
            this.lb_mamon.Name = "lb_mamon";
            this.lb_mamon.Size = new System.Drawing.Size(94, 25);
            this.lb_mamon.TabIndex = 15;
            this.lb_mamon.Text = "Môn học:";
            // 
            // lb_ClassID
            // 
            this.lb_ClassID.AutoSize = true;
            this.lb_ClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_ClassID.Location = new System.Drawing.Point(30, 35);
            this.lb_ClassID.Name = "lb_ClassID";
            this.lb_ClassID.Size = new System.Drawing.Size(51, 25);
            this.lb_ClassID.TabIndex = 16;
            this.lb_ClassID.Text = "Lớp:";
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(170, 80);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(136, 33);
            this.cbb_MonHoc.TabIndex = 1;
            this.cbb_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_MonHoc_SelectedIndexChanged);
            // 
            // cbb_lop
            // 
            this.cbb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(170, 32);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(136, 33);
            this.cbb_lop.TabIndex = 0;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // lb_mssv
            // 
            this.lb_mssv.AutoSize = true;
            this.lb_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mssv.Location = new System.Drawing.Point(30, 150);
            this.lb_mssv.Name = "lb_mssv";
            this.lb_mssv.Size = new System.Drawing.Size(77, 25);
            this.lb_mssv.TabIndex = 18;
            this.lb_mssv.Text = "MSSV:";
            // 
            // tb_MSSV
            // 
            this.tb_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_MSSV.Location = new System.Drawing.Point(215, 147);
            this.tb_MSSV.Name = "tb_MSSV";
            this.tb_MSSV.Size = new System.Drawing.Size(409, 30);
            this.tb_MSSV.TabIndex = 3;
            // 
            // lb_gk
            // 
            this.lb_gk.AutoSize = true;
            this.lb_gk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gk.Location = new System.Drawing.Point(30, 204);
            this.lb_gk.Name = "lb_gk";
            this.lb_gk.Size = new System.Drawing.Size(130, 25);
            this.lb_gk.TabIndex = 18;
            this.lb_gk.Text = "Điểm giữa kỳ:";
            // 
            // tb_gk
            // 
            this.tb_gk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_gk.Location = new System.Drawing.Point(215, 201);
            this.tb_gk.Name = "tb_gk";
            this.tb_gk.Size = new System.Drawing.Size(409, 30);
            this.tb_gk.TabIndex = 4;
            // 
            // lb_ck
            // 
            this.lb_ck.AutoSize = true;
            this.lb_ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ck.Location = new System.Drawing.Point(30, 260);
            this.lb_ck.Name = "lb_ck";
            this.lb_ck.Size = new System.Drawing.Size(129, 25);
            this.lb_ck.TabIndex = 18;
            this.lb_ck.Text = "Điểm cuối kỳ:";
            // 
            // lb_khac
            // 
            this.lb_khac.AutoSize = true;
            this.lb_khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khac.Location = new System.Drawing.Point(30, 314);
            this.lb_khac.Name = "lb_khac";
            this.lb_khac.Size = new System.Drawing.Size(110, 25);
            this.lb_khac.TabIndex = 18;
            this.lb_khac.Text = "Điểm khác:";
            // 
            // tb_ck
            // 
            this.tb_ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_ck.Location = new System.Drawing.Point(215, 257);
            this.tb_ck.Name = "tb_ck";
            this.tb_ck.Size = new System.Drawing.Size(409, 30);
            this.tb_ck.TabIndex = 5;
            // 
            // tb_khac
            // 
            this.tb_khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_khac.Location = new System.Drawing.Point(215, 311);
            this.tb_khac.Name = "tb_khac";
            this.tb_khac.Size = new System.Drawing.Size(409, 30);
            this.tb_khac.TabIndex = 6;
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong.Location = new System.Drawing.Point(30, 371);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(106, 25);
            this.lb_tong.TabIndex = 18;
            this.lb_tong.Text = "Điểm tổng:";
            // 
            // tb_tong
            // 
            this.tb_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_tong.Location = new System.Drawing.Point(215, 368);
            this.tb_tong.Name = "tb_tong";
            this.tb_tong.Size = new System.Drawing.Size(409, 30);
            this.tb_tong.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(526, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Hocky
            // 
            this.lb_Hocky.AutoSize = true;
            this.lb_Hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Hocky.Location = new System.Drawing.Point(348, 38);
            this.lb_Hocky.Name = "lb_Hocky";
            this.lb_Hocky.Size = new System.Drawing.Size(78, 25);
            this.lb_Hocky.TabIndex = 15;
            this.lb_Hocky.Text = "Học kỳ:";
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_hocky.FormattingEnabled = true;
            this.cbb_hocky.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.cbb_hocky.Location = new System.Drawing.Point(488, 35);
            this.cbb_hocky.Name = "cbb_hocky";
            this.cbb_hocky.Size = new System.Drawing.Size(136, 33);
            this.cbb_hocky.TabIndex = 2;
            this.cbb_hocky.SelectedIndexChanged += new System.EventHandler(this.cbb_hocky_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 60);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ghi chú: \r\n- Mã số sinh viên tối đa 10 kí tự.\r\n- Các cột điểm phải nằm trong khoả" +
    "ng từ 0 đến 10.";
            // 
            // EditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_khac);
            this.Controls.Add(this.tb_gk);
            this.Controls.Add(this.tb_tong);
            this.Controls.Add(this.tb_ck);
            this.Controls.Add(this.tb_MSSV);
            this.Controls.Add(this.lb_tong);
            this.Controls.Add(this.lb_khac);
            this.Controls.Add(this.lb_ck);
            this.Controls.Add(this.lb_gk);
            this.Controls.Add(this.lb_mssv);
            this.Controls.Add(this.lb_tenmon);
            this.Controls.Add(this.lb_Hocky);
            this.Controls.Add(this.lb_mamon);
            this.Controls.Add(this.lb_ClassID);
            this.Controls.Add(this.cbb_hocky);
            this.Controls.Add(this.cbb_MonHoc);
            this.Controls.Add(this.cbb_lop);
            this.Name = "EditScore";
            this.Text = "EditScore";
            this.Load += new System.EventHandler(this.EditScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.Label lb_mamon;
        private System.Windows.Forms.Label lb_ClassID;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.Label lb_mssv;
        private System.Windows.Forms.TextBox tb_MSSV;
        private System.Windows.Forms.Label lb_gk;
        private System.Windows.Forms.TextBox tb_gk;
        private System.Windows.Forms.Label lb_ck;
        private System.Windows.Forms.Label lb_khac;
        private System.Windows.Forms.TextBox tb_ck;
        private System.Windows.Forms.TextBox tb_khac;
        private System.Windows.Forms.Label lb_tong;
        private System.Windows.Forms.TextBox tb_tong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Hocky;
        private System.Windows.Forms.ComboBox cbb_hocky;
        private System.Windows.Forms.Label label1;
    }
}