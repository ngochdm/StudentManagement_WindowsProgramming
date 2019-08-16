namespace UI
{
    partial class ViewListStdsOfClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewListStdsOfClass));
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.lb_ClassID = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoCmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbb_lop
            // 
            this.cbb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(350, 22);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(136, 33);
            this.cbb_lop.TabIndex = 0;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // lb_ClassID
            // 
            this.lb_ClassID.AutoSize = true;
            this.lb_ClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_ClassID.Location = new System.Drawing.Point(29, 25);
            this.lb_ClassID.Name = "lb_ClassID";
            this.lb_ClassID.Size = new System.Drawing.Size(262, 25);
            this.lb_ClassID.TabIndex = 1;
            this.lb_ClassID.Text = "Chọn lớp để xem danh sách:";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.FullName,
            this.SoCmnd,
            this.DoB,
            this.Sex,
            this.DiaChi});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 68);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(776, 587);
            this.lv.TabIndex = 2;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // FullName
            // 
            this.FullName.Text = "Họ Và Tên";
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
            this.Sex.Text = "GT";
            this.Sex.Width = 50;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa Chỉ";
            this.DiaChi.Width = 120;
            // 
            // ViewListStdsOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb_ClassID);
            this.Controls.Add(this.cbb_lop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewListStdsOfClass";
            this.Text = "Xem Danh Sách Lớp";
            this.Load += new System.EventHandler(this.ViewListStdsOfClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.Label lb_ClassID;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader SoCmnd;
        private System.Windows.Forms.ColumnHeader DoB;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader DiaChi;
    }
}