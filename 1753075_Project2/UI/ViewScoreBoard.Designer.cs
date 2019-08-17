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
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.semester,
            this.midterm,
            this.final,
            this.others,
            this.average,
            this.STT});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 110);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(776, 584);
            this.lv.TabIndex = 5;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.DisplayIndex = 1;
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 90;
            // 
            // semester
            // 
            this.semester.DisplayIndex = 2;
            this.semester.Text = "Học Kỳ";
            this.semester.Width = 80;
            // 
            // midterm
            // 
            this.midterm.DisplayIndex = 3;
            this.midterm.Text = "Giữa Kỳ";
            this.midterm.Width = 70;
            // 
            // final
            // 
            this.final.DisplayIndex = 4;
            this.final.Text = "Cuối Kỳ";
            this.final.Width = 70;
            // 
            // others
            // 
            this.others.DisplayIndex = 5;
            this.others.Text = "Điểm khác";
            this.others.Width = 70;
            // 
            // average
            // 
            this.average.DisplayIndex = 6;
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
            // ViewScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
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
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.ColumnHeader midterm;
        private System.Windows.Forms.ColumnHeader final;
        private System.Windows.Forms.ColumnHeader others;
        private System.Windows.Forms.ColumnHeader average;
        private System.Windows.Forms.Label lb_mamon;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.ColumnHeader STT;
    }
}