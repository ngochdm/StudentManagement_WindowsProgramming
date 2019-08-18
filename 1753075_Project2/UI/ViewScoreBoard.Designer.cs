namespace UI
{
    partial class ViewScoreBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewScoreBoard));
            this.lv = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.midterm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.final = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.others = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_ClassID = new System.Windows.Forms.Label();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.lb_mamon = new System.Windows.Forms.Label();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.lb_Hocky = new System.Windows.Forms.Label();
            this.cbb_hocky = new System.Windows.Forms.ComboBox();
            this.lb_statistic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.midterm,
            this.final,
            this.others,
            this.average,
            this.STT});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 143);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(776, 551);
            this.lv.TabIndex = 5;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.DisplayIndex = 1;
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 100;
            // 
            // midterm
            // 
            this.midterm.DisplayIndex = 2;
            this.midterm.Text = "Giữa Kỳ";
            this.midterm.Width = 80;
            // 
            // final
            // 
            this.final.DisplayIndex = 3;
            this.final.Text = "Cuối Kỳ";
            this.final.Width = 80;
            // 
            // others
            // 
            this.others.DisplayIndex = 4;
            this.others.Text = "Điểm khác";
            this.others.Width = 80;
            // 
            // average
            // 
            this.average.DisplayIndex = 5;
            this.average.Text = "Điểm Tổng";
            this.average.Width = 80;
            // 
            // STT
            // 
            this.STT.DisplayIndex = 0;
            this.STT.Text = "STT";
            this.STT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STT.Width = 50;
            // 
            // lb_ClassID
            // 
            this.lb_ClassID.AutoSize = true;
            this.lb_ClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_ClassID.Location = new System.Drawing.Point(23, 19);
            this.lb_ClassID.Name = "lb_ClassID";
            this.lb_ClassID.Size = new System.Drawing.Size(262, 25);
            this.lb_ClassID.TabIndex = 4;
            this.lb_ClassID.Text = "Chọn lớp để xem bảng điểm:";
            // 
            // cbb_lop
            // 
            this.cbb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(337, 16);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(136, 33);
            this.cbb_lop.TabIndex = 3;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // lb_mamon
            // 
            this.lb_mamon.AutoSize = true;
            this.lb_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_mamon.Location = new System.Drawing.Point(23, 67);
            this.lb_mamon.Name = "lb_mamon";
            this.lb_mamon.Size = new System.Drawing.Size(146, 25);
            this.lb_mamon.TabIndex = 4;
            this.lb_mamon.Text = "Chọn môn học:";
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(223, 64);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(136, 33);
            this.cbb_MonHoc.TabIndex = 3;
            this.cbb_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_MonHoc_SelectedIndexChanged);
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tenmon.Location = new System.Drawing.Point(390, 67);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(91, 25);
            this.lb_tenmon.TabIndex = 6;
            this.lb_tenmon.Text = "Tên Môn";
            // 
            // lb_Hocky
            // 
            this.lb_Hocky.AutoSize = true;
            this.lb_Hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Hocky.Location = new System.Drawing.Point(512, 19);
            this.lb_Hocky.Name = "lb_Hocky";
            this.lb_Hocky.Size = new System.Drawing.Size(78, 25);
            this.lb_Hocky.TabIndex = 28;
            this.lb_Hocky.Text = "Học kỳ:";
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_hocky.FormattingEnabled = true;
            this.cbb_hocky.Location = new System.Drawing.Point(615, 16);
            this.cbb_hocky.Name = "cbb_hocky";
            this.cbb_hocky.Size = new System.Drawing.Size(136, 33);
            this.cbb_hocky.TabIndex = 27;
            this.cbb_hocky.SelectedIndexChanged += new System.EventHandler(this.cbb_hocky_SelectedIndexChanged);
            // 
            // lb_statistic
            // 
            this.lb_statistic.AutoSize = true;
            this.lb_statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statistic.ForeColor = System.Drawing.Color.Red;
            this.lb_statistic.Location = new System.Drawing.Point(28, 113);
            this.lb_statistic.Name = "lb_statistic";
            this.lb_statistic.Size = new System.Drawing.Size(78, 22);
            this.lb_statistic.TabIndex = 29;
            this.lb_statistic.Text = "Statistic:";
            // 
            // ViewScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.lb_statistic);
            this.Controls.Add(this.lb_Hocky);
            this.Controls.Add(this.cbb_hocky);
            this.Controls.Add(this.lb_tenmon);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb_mamon);
            this.Controls.Add(this.lb_ClassID);
            this.Controls.Add(this.cbb_MonHoc);
            this.Controls.Add(this.cbb_lop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewScoreBoard";
            this.Text = "Xem bảng điểm";
            this.Load += new System.EventHandler(this.ViewScoreBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.Label lb_ClassID;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.ColumnHeader midterm;
        private System.Windows.Forms.ColumnHeader final;
        private System.Windows.Forms.ColumnHeader others;
        private System.Windows.Forms.ColumnHeader average;
        private System.Windows.Forms.Label lb_mamon;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.Label lb_Hocky;
        private System.Windows.Forms.ComboBox cbb_hocky;
        private System.Windows.Forms.Label lb_statistic;
    }
}