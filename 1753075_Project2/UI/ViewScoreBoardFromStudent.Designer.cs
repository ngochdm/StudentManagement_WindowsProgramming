namespace UI
{
    partial class ViewScoreBoardFromStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewScoreBoardFromStudent));
            this.lb_Hocky = new System.Windows.Forms.Label();
            this.cbb_hocky = new System.Windows.Forms.ComboBox();
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.midterm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.final = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.others = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_mamon = new System.Windows.Forms.Label();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_khac = new System.Windows.Forms.TextBox();
            this.tb_gk = new System.Windows.Forms.TextBox();
            this.tb_tong = new System.Windows.Forms.TextBox();
            this.tb_ck = new System.Windows.Forms.TextBox();
            this.lb_tong = new System.Windows.Forms.Label();
            this.lb_khac = new System.Windows.Forms.Label();
            this.lb_ck = new System.Windows.Forms.Label();
            this.lb_gk = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Hocky
            // 
            this.lb_Hocky.AutoSize = true;
            this.lb_Hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Hocky.Location = new System.Drawing.Point(38, 97);
            this.lb_Hocky.Name = "lb_Hocky";
            this.lb_Hocky.Size = new System.Drawing.Size(78, 25);
            this.lb_Hocky.TabIndex = 34;
            this.lb_Hocky.Text = "Học kỳ:";
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_hocky.FormattingEnabled = true;
            this.cbb_hocky.Location = new System.Drawing.Point(238, 94);
            this.cbb_hocky.Name = "cbb_hocky";
            this.cbb_hocky.Size = new System.Drawing.Size(136, 33);
            this.cbb_hocky.TabIndex = 33;
            this.cbb_hocky.SelectedIndexChanged += new System.EventHandler(this.cbb_hocky_SelectedIndexChanged);
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tenmon.Location = new System.Drawing.Point(405, 32);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(146, 25);
            this.lb_tenmon.TabIndex = 32;
            this.lb_tenmon.Text = "Tất cả các môn";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubjectID,
            this.SubjectName,
            this.semester,
            this.midterm,
            this.final,
            this.others,
            this.average,
            this.STT});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 156);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(776, 457);
            this.lv.TabIndex = 31;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // semester
            // 
            this.semester.DisplayIndex = 3;
            this.semester.Text = "Học Kỳ";
            this.semester.Width = 80;
            // 
            // midterm
            // 
            this.midterm.DisplayIndex = 4;
            this.midterm.Text = "Giữa Kỳ";
            this.midterm.Width = 70;
            // 
            // final
            // 
            this.final.DisplayIndex = 5;
            this.final.Text = "Cuối Kỳ";
            this.final.Width = 70;
            // 
            // others
            // 
            this.others.DisplayIndex = 6;
            this.others.Text = "Điểm khác";
            this.others.Width = 70;
            // 
            // average
            // 
            this.average.DisplayIndex = 7;
            this.average.Text = "Điểm Tổng";
            this.average.Width = 70;
            // 
            // STT
            // 
            this.STT.DisplayIndex = 0;
            this.STT.Text = "STT";
            this.STT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STT.Width = 40;
            // 
            // lb_mamon
            // 
            this.lb_mamon.AutoSize = true;
            this.lb_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_mamon.Location = new System.Drawing.Point(38, 32);
            this.lb_mamon.Name = "lb_mamon";
            this.lb_mamon.Size = new System.Drawing.Size(146, 25);
            this.lb_mamon.TabIndex = 30;
            this.lb_mamon.Text = "Chọn môn học:";
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(238, 29);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(136, 33);
            this.cbb_MonHoc.TabIndex = 29;
            this.cbb_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_MonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(406, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nếu xem tất cả bảng điểm thì không chọn học kỳ";
            // 
            // SubjectID
            // 
            this.SubjectID.DisplayIndex = 1;
            this.SubjectID.Text = "Mã Môn";
            // 
            // SubjectName
            // 
            this.SubjectName.DisplayIndex = 2;
            this.SubjectName.Text = "Tên Môn";
            this.SubjectName.Width = 100;
            // 
            // tb_khac
            // 
            this.tb_khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_khac.Location = new System.Drawing.Point(381, 339);
            this.tb_khac.Name = "tb_khac";
            this.tb_khac.ReadOnly = true;
            this.tb_khac.Size = new System.Drawing.Size(155, 35);
            this.tb_khac.TabIndex = 37;
            // 
            // tb_gk
            // 
            this.tb_gk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_gk.Location = new System.Drawing.Point(381, 202);
            this.tb_gk.Name = "tb_gk";
            this.tb_gk.ReadOnly = true;
            this.tb_gk.Size = new System.Drawing.Size(155, 35);
            this.tb_gk.TabIndex = 35;
            // 
            // tb_tong
            // 
            this.tb_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tong.Location = new System.Drawing.Point(381, 409);
            this.tb_tong.Name = "tb_tong";
            this.tb_tong.ReadOnly = true;
            this.tb_tong.Size = new System.Drawing.Size(155, 35);
            this.tb_tong.TabIndex = 38;
            // 
            // tb_ck
            // 
            this.tb_ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_ck.Location = new System.Drawing.Point(381, 273);
            this.tb_ck.Name = "tb_ck";
            this.tb_ck.ReadOnly = true;
            this.tb_ck.Size = new System.Drawing.Size(155, 35);
            this.tb_ck.TabIndex = 36;
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong.Location = new System.Drawing.Point(194, 412);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(158, 29);
            this.lb_tong.TabIndex = 39;
            this.lb_tong.Text = "ĐIỂM TỔNG";
            // 
            // lb_khac
            // 
            this.lb_khac.AutoSize = true;
            this.lb_khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_khac.Location = new System.Drawing.Point(196, 342);
            this.lb_khac.Name = "lb_khac";
            this.lb_khac.Size = new System.Drawing.Size(132, 29);
            this.lb_khac.TabIndex = 40;
            this.lb_khac.Text = "Điểm khác:";
            // 
            // lb_ck
            // 
            this.lb_ck.AutoSize = true;
            this.lb_ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_ck.Location = new System.Drawing.Point(196, 276);
            this.lb_ck.Name = "lb_ck";
            this.lb_ck.Size = new System.Drawing.Size(156, 29);
            this.lb_ck.TabIndex = 41;
            this.lb_ck.Text = "Điểm cuối kỳ:";
            // 
            // lb_gk
            // 
            this.lb_gk.AutoSize = true;
            this.lb_gk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_gk.Location = new System.Drawing.Point(196, 205);
            this.lb_gk.Name = "lb_gk";
            this.lb_gk.Size = new System.Drawing.Size(157, 29);
            this.lb_gk.TabIndex = 42;
            this.lb_gk.Text = "Điểm giữa kỳ:";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_result.Location = new System.Drawing.Point(105, 497);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(79, 29);
            this.lb_result.TabIndex = 43;
            this.lb_result.Text = "label2";
            // 
            // ViewScoreBoardFromStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.tb_khac);
            this.Controls.Add(this.tb_gk);
            this.Controls.Add(this.tb_tong);
            this.Controls.Add(this.tb_ck);
            this.Controls.Add(this.lb_tong);
            this.Controls.Add(this.lb_khac);
            this.Controls.Add(this.lb_ck);
            this.Controls.Add(this.lb_gk);
            this.Controls.Add(this.lb_Hocky);
            this.Controls.Add(this.cbb_hocky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_tenmon);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb_mamon);
            this.Controls.Add(this.cbb_MonHoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewScoreBoardFromStudent";
            this.Text = "Xem bảng điểm";
            this.Load += new System.EventHandler(this.ViewScoreBoardFromStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Hocky;
        private System.Windows.Forms.ComboBox cbb_hocky;
        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader SubjectID;
        private System.Windows.Forms.ColumnHeader SubjectName;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.ColumnHeader midterm;
        private System.Windows.Forms.ColumnHeader final;
        private System.Windows.Forms.ColumnHeader others;
        private System.Windows.Forms.ColumnHeader average;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.Label lb_mamon;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_khac;
        private System.Windows.Forms.TextBox tb_gk;
        private System.Windows.Forms.TextBox tb_tong;
        private System.Windows.Forms.TextBox tb_ck;
        private System.Windows.Forms.Label lb_tong;
        private System.Windows.Forms.Label lb_khac;
        private System.Windows.Forms.Label lb_ck;
        private System.Windows.Forms.Label lb_gk;
        private System.Windows.Forms.Label lb_result;
    }
}