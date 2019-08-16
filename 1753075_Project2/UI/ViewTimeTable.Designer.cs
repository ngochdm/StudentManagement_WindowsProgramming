namespace UI
{
    partial class ViewTimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTimeTable));
            this.lv = new System.Windows.Forms.ListView();
            this.SubjectID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester_HK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoolYear_SC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_ClassID = new System.Windows.Forms.Label();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubjectID,
            this.subjectName,
            this.Semester_HK,
            this.SchoolYear_SC,
            this.RoomID});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 64);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(776, 555);
            this.lv.TabIndex = 5;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // SubjectID
            // 
            this.SubjectID.Text = "Mã Môn";
            this.SubjectID.Width = 100;
            // 
            // subjectName
            // 
            this.subjectName.Text = "Tên Môn Học";
            this.subjectName.Width = 150;
            // 
            // Semester_HK
            // 
            this.Semester_HK.Text = "Học Kỳ";
            this.Semester_HK.Width = 80;
            // 
            // SchoolYear_SC
            // 
            this.SchoolYear_SC.Text = "Năm Học";
            this.SchoolYear_SC.Width = 80;
            // 
            // RoomID
            // 
            this.RoomID.Text = "Phòng Học";
            this.RoomID.Width = 100;
            // 
            // lb_ClassID
            // 
            this.lb_ClassID.AutoSize = true;
            this.lb_ClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_ClassID.Location = new System.Drawing.Point(29, 21);
            this.lb_ClassID.Name = "lb_ClassID";
            this.lb_ClassID.Size = new System.Drawing.Size(292, 25);
            this.lb_ClassID.TabIndex = 4;
            this.lb_ClassID.Text = "Chọn lớp để xem thời khóa biểu:";
            // 
            // cbb_lop
            // 
            this.cbb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(351, 18);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(136, 33);
            this.cbb_lop.TabIndex = 3;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // ViewTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb_ClassID);
            this.Controls.Add(this.cbb_lop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewTimeTable";
            this.Text = "Xem thời khóa biểu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader SubjectID;
        private System.Windows.Forms.Label lb_ClassID;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.ColumnHeader subjectName;
        private System.Windows.Forms.ColumnHeader Semester_HK;
        private System.Windows.Forms.ColumnHeader SchoolYear_SC;
        private System.Windows.Forms.ColumnHeader RoomID;
    }
}