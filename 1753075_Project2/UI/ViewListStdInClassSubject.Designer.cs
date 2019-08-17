namespace UI
{
    partial class ViewListStdInClassSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewListStdInClassSubject));
            this.lb_tenmon = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoCmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_mamon = new System.Windows.Forms.Label();
            this.lb_ClassID = new System.Windows.Forms.Label();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_tenmon
            // 
            this.lb_tenmon.AutoSize = true;
            this.lb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tenmon.Location = new System.Drawing.Point(390, 67);
            this.lb_tenmon.Name = "lb_tenmon";
            this.lb_tenmon.Size = new System.Drawing.Size(91, 25);
            this.lb_tenmon.TabIndex = 12;
            this.lb_tenmon.Text = "Tên Môn";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MSSV,
            this.FullName,
            this.SoCmnd,
            this.DoB,
            this.Sex,
            this.Address});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 110);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(776, 566);
            this.lv.TabIndex = 11;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 40;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // FullName
            // 
            this.FullName.Text = "Họ và Tên";
            this.FullName.Width = 160;
            // 
            // SoCmnd
            // 
            this.SoCmnd.Text = "Số CMND";
            this.SoCmnd.Width = 80;
            // 
            // DoB
            // 
            this.DoB.Text = "Ngày Sinh";
            this.DoB.Width = 80;
            // 
            // Sex
            // 
            this.Sex.Text = "Giới Tính";
            this.Sex.Width = 50;
            // 
            // Address
            // 
            this.Address.Text = "Địa Chỉ";
            this.Address.Width = 200;
            // 
            // lb_mamon
            // 
            this.lb_mamon.AutoSize = true;
            this.lb_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_mamon.Location = new System.Drawing.Point(23, 67);
            this.lb_mamon.Name = "lb_mamon";
            this.lb_mamon.Size = new System.Drawing.Size(146, 25);
            this.lb_mamon.TabIndex = 9;
            this.lb_mamon.Text = "Chọn môn học:";
            // 
            // lb_ClassID
            // 
            this.lb_ClassID.AutoSize = true;
            this.lb_ClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_ClassID.Location = new System.Drawing.Point(23, 19);
            this.lb_ClassID.Name = "lb_ClassID";
            this.lb_ClassID.Size = new System.Drawing.Size(262, 25);
            this.lb_ClassID.TabIndex = 10;
            this.lb_ClassID.Text = "Chọn lớp để xem bảng điểm:";
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(223, 64);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(136, 33);
            this.cbb_MonHoc.TabIndex = 7;
            this.cbb_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_MonHoc_SelectedIndexChanged);
            // 
            // cbb_lop
            // 
            this.cbb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(337, 16);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(136, 33);
            this.cbb_lop.TabIndex = 8;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // ViewListStdInClassSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.lb_tenmon);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb_mamon);
            this.Controls.Add(this.lb_ClassID);
            this.Controls.Add(this.cbb_MonHoc);
            this.Controls.Add(this.cbb_lop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewListStdInClassSubject";
            this.Text = "Xem Danh Sách Lớp Từng Môn";
            this.Load += new System.EventHandler(this.ViewListStdInClassSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tenmon;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.Label lb_mamon;
        private System.Windows.Forms.Label lb_ClassID;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader SoCmnd;
        private System.Windows.Forms.ColumnHeader DoB;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader STT;
    }
}