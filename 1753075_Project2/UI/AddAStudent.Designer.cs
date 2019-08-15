namespace UI
{
    partial class AddAStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAStudent));
            this.tb_lopsv = new System.Windows.Forms.TextBox();
            this.tb_cmndsv = new System.Windows.Forms.TextBox();
            this.tb_hotensv = new System.Windows.Forms.TextBox();
            this.tb_Mssv = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_hotensv = new System.Windows.Forms.Label();
            this.lb_LopSv = new System.Windows.Forms.Label();
            this.lb_gtsv = new System.Windows.Forms.Label();
            this.lb_ngsinhsv = new System.Windows.Forms.Label();
            this.lb_dchisv = new System.Windows.Forms.Label();
            this.lb_SoCMNDsv = new System.Windows.Forms.Label();
            this.lb_Masv = new System.Windows.Forms.Label();
            this.btn_Male = new System.Windows.Forms.RadioButton();
            this.btn_Female = new System.Windows.Forms.RadioButton();
            this.gb_sex = new System.Windows.Forms.GroupBox();
            this.lb_Note = new System.Windows.Forms.Label();
            this.tb_Dchisv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_day = new System.Windows.Forms.ComboBox();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.gb_sex.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_lopsv
            // 
            this.tb_lopsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_lopsv.Location = new System.Drawing.Point(477, 133);
            this.tb_lopsv.Name = "tb_lopsv";
            this.tb_lopsv.Size = new System.Drawing.Size(182, 30);
            this.tb_lopsv.TabIndex = 3;
            // 
            // tb_cmndsv
            // 
            this.tb_cmndsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_cmndsv.Location = new System.Drawing.Point(170, 133);
            this.tb_cmndsv.Name = "tb_cmndsv";
            this.tb_cmndsv.Size = new System.Drawing.Size(230, 30);
            this.tb_cmndsv.TabIndex = 2;
            // 
            // tb_hotensv
            // 
            this.tb_hotensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_hotensv.Location = new System.Drawing.Point(170, 86);
            this.tb_hotensv.Name = "tb_hotensv";
            this.tb_hotensv.Size = new System.Drawing.Size(489, 30);
            this.tb_hotensv.TabIndex = 1;
            // 
            // tb_Mssv
            // 
            this.tb_Mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_Mssv.Location = new System.Drawing.Point(170, 41);
            this.tb_Mssv.Name = "tb_Mssv";
            this.tb_Mssv.Size = new System.Drawing.Size(489, 30);
            this.tb_Mssv.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Add.Location = new System.Drawing.Point(539, 388);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(114, 57);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_hotensv
            // 
            this.lb_hotensv.AutoSize = true;
            this.lb_hotensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_hotensv.Location = new System.Drawing.Point(48, 93);
            this.lb_hotensv.Name = "lb_hotensv";
            this.lb_hotensv.Size = new System.Drawing.Size(85, 20);
            this.lb_hotensv.TabIndex = 18;
            this.lb_hotensv.Text = "Họ và Tên:";
            // 
            // lb_LopSv
            // 
            this.lb_LopSv.AutoSize = true;
            this.lb_LopSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_LopSv.Location = new System.Drawing.Point(431, 140);
            this.lb_LopSv.Name = "lb_LopSv";
            this.lb_LopSv.Size = new System.Drawing.Size(40, 20);
            this.lb_LopSv.TabIndex = 19;
            this.lb_LopSv.Text = "Lớp:";
            // 
            // lb_gtsv
            // 
            this.lb_gtsv.AutoSize = true;
            this.lb_gtsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_gtsv.Location = new System.Drawing.Point(431, 189);
            this.lb_gtsv.Name = "lb_gtsv";
            this.lb_gtsv.Size = new System.Drawing.Size(75, 20);
            this.lb_gtsv.TabIndex = 20;
            this.lb_gtsv.Text = "Giới Tính:";
            // 
            // lb_ngsinhsv
            // 
            this.lb_ngsinhsv.AutoSize = true;
            this.lb_ngsinhsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_ngsinhsv.Location = new System.Drawing.Point(48, 189);
            this.lb_ngsinhsv.Name = "lb_ngsinhsv";
            this.lb_ngsinhsv.Size = new System.Drawing.Size(85, 20);
            this.lb_ngsinhsv.TabIndex = 21;
            this.lb_ngsinhsv.Text = "Ngày Sinh:";
            // 
            // lb_dchisv
            // 
            this.lb_dchisv.AutoSize = true;
            this.lb_dchisv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_dchisv.Location = new System.Drawing.Point(48, 236);
            this.lb_dchisv.Name = "lb_dchisv";
            this.lb_dchisv.Size = new System.Drawing.Size(64, 20);
            this.lb_dchisv.TabIndex = 22;
            this.lb_dchisv.Text = "Địa Chỉ:";
            // 
            // lb_SoCMNDsv
            // 
            this.lb_SoCMNDsv.AutoSize = true;
            this.lb_SoCMNDsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_SoCMNDsv.Location = new System.Drawing.Point(48, 140);
            this.lb_SoCMNDsv.Name = "lb_SoCMNDsv";
            this.lb_SoCMNDsv.Size = new System.Drawing.Size(84, 20);
            this.lb_SoCMNDsv.TabIndex = 23;
            this.lb_SoCMNDsv.Text = "Số CMND:";
            // 
            // lb_Masv
            // 
            this.lb_Masv.AutoSize = true;
            this.lb_Masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_Masv.Location = new System.Drawing.Point(48, 48);
            this.lb_Masv.Name = "lb_Masv";
            this.lb_Masv.Size = new System.Drawing.Size(59, 20);
            this.lb_Masv.TabIndex = 24;
            this.lb_Masv.Text = "MSSV:";
            // 
            // btn_Male
            // 
            this.btn_Male.AutoSize = true;
            this.btn_Male.Location = new System.Drawing.Point(0, 11);
            this.btn_Male.Name = "btn_Male";
            this.btn_Male.Size = new System.Drawing.Size(67, 24);
            this.btn_Male.TabIndex = 7;
            this.btn_Male.TabStop = true;
            this.btn_Male.Text = "Nam";
            this.btn_Male.UseVisualStyleBackColor = true;
            // 
            // btn_Female
            // 
            this.btn_Female.AutoSize = true;
            this.btn_Female.Location = new System.Drawing.Point(87, 11);
            this.btn_Female.Name = "btn_Female";
            this.btn_Female.Size = new System.Drawing.Size(54, 24);
            this.btn_Female.TabIndex = 8;
            this.btn_Female.TabStop = true;
            this.btn_Female.Text = "Nữ";
            this.btn_Female.UseVisualStyleBackColor = true;
            // 
            // gb_sex
            // 
            this.gb_sex.Controls.Add(this.btn_Male);
            this.gb_sex.Controls.Add(this.btn_Female);
            this.gb_sex.Location = new System.Drawing.Point(512, 175);
            this.gb_sex.Name = "gb_sex";
            this.gb_sex.Size = new System.Drawing.Size(147, 44);
            this.gb_sex.TabIndex = 34;
            this.gb_sex.TabStop = false;
            // 
            // lb_Note
            // 
            this.lb_Note.AutoSize = true;
            this.lb_Note.Cursor = System.Windows.Forms.Cursors.Help;
            this.lb_Note.Location = new System.Drawing.Point(48, 326);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Size = new System.Drawing.Size(272, 160);
            this.lb_Note.TabIndex = 35;
            this.lb_Note.Text = resources.GetString("lb_Note.Text");
            // 
            // tb_Dchisv
            // 
            this.tb_Dchisv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_Dchisv.Location = new System.Drawing.Point(170, 229);
            this.tb_Dchisv.Multiline = true;
            this.tb_Dchisv.Name = "tb_Dchisv";
            this.tb_Dchisv.Size = new System.Drawing.Size(489, 105);
            this.tb_Dchisv.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(228, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(306, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "/";
            // 
            // cbb_day
            // 
            this.cbb_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_day.FormattingEnabled = true;
            this.cbb_day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbb_day.Location = new System.Drawing.Point(170, 186);
            this.cbb_day.Name = "cbb_day";
            this.cbb_day.Size = new System.Drawing.Size(57, 28);
            this.cbb_day.TabIndex = 4;
            // 
            // cbb_month
            // 
            this.cbb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbb_month.Location = new System.Drawing.Point(247, 187);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(57, 28);
            this.cbb_month.TabIndex = 5;
            // 
            // tb_year
            // 
            this.tb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_year.Location = new System.Drawing.Point(327, 187);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(73, 30);
            this.tb_year.TabIndex = 6;
            // 
            // AddAStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 495);
            this.Controls.Add(this.cbb_month);
            this.Controls.Add(this.cbb_day);
            this.Controls.Add(this.gb_sex);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_lopsv);
            this.Controls.Add(this.tb_Dchisv);
            this.Controls.Add(this.tb_cmndsv);
            this.Controls.Add(this.tb_hotensv);
            this.Controls.Add(this.tb_Mssv);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_hotensv);
            this.Controls.Add(this.lb_LopSv);
            this.Controls.Add(this.lb_gtsv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ngsinhsv);
            this.Controls.Add(this.lb_dchisv);
            this.Controls.Add(this.lb_SoCMNDsv);
            this.Controls.Add(this.lb_Masv);
            this.Controls.Add(this.lb_Note);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddAStudent";
            this.Text = "Adding One Student";
            this.Load += new System.EventHandler(this.AddAStudent_Load);
            this.gb_sex.ResumeLayout(false);
            this.gb_sex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_lopsv;
        private System.Windows.Forms.TextBox tb_cmndsv;
        private System.Windows.Forms.TextBox tb_hotensv;
        private System.Windows.Forms.TextBox tb_Mssv;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_hotensv;
        private System.Windows.Forms.Label lb_LopSv;
        private System.Windows.Forms.Label lb_gtsv;
        private System.Windows.Forms.Label lb_ngsinhsv;
        private System.Windows.Forms.Label lb_dchisv;
        private System.Windows.Forms.Label lb_SoCMNDsv;
        private System.Windows.Forms.Label lb_Masv;
        private System.Windows.Forms.RadioButton btn_Male;
        private System.Windows.Forms.RadioButton btn_Female;
        private System.Windows.Forms.GroupBox gb_sex;
        private System.Windows.Forms.Label lb_Note;
        private System.Windows.Forms.TextBox tb_Dchisv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_day;
        private System.Windows.Forms.ComboBox cbb_month;
        private System.Windows.Forms.TextBox tb_year;
    }
}