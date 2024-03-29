﻿namespace UI
{
    partial class SVStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVStudent));
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_score = new System.Windows.Forms.Button();
            this.btn_timetable = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thờiKhóaBiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_viewDSLop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_profile
            // 
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_profile.Location = new System.Drawing.Point(82, 82);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(140, 165);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "View Profile";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_score
            // 
            this.btn_score.Image = ((System.Drawing.Image)(resources.GetObject("btn_score.Image")));
            this.btn_score.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_score.Location = new System.Drawing.Point(274, 82);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(140, 165);
            this.btn_score.TabIndex = 1;
            this.btn_score.Text = "Kết Quả Học Tập";
            this.btn_score.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // btn_timetable
            // 
            this.btn_timetable.Image = ((System.Drawing.Image)(resources.GetObject("btn_timetable.Image")));
            this.btn_timetable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_timetable.Location = new System.Drawing.Point(469, 82);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(140, 165);
            this.btn_timetable.TabIndex = 2;
            this.btn_timetable.Text = "Thời Khóa Biểu";
            this.btn_timetable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_timetable.UseVisualStyleBackColor = true;
            this.btn_timetable.Click += new System.EventHandler(this.btn_timetable_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.kếtQuảHọcTậpToolStripMenuItem,
            this.thờiKhóaBiểuToolStripMenuItem,
            this.xemDanhSáchLớpToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // kếtQuảHọcTậpToolStripMenuItem
            // 
            this.kếtQuảHọcTậpToolStripMenuItem.Name = "kếtQuảHọcTậpToolStripMenuItem";
            this.kếtQuảHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.kếtQuảHọcTậpToolStripMenuItem.Text = "Kết Quả Học Tập";
            this.kếtQuảHọcTậpToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảHọcTậpToolStripMenuItem_Click);
            // 
            // thờiKhóaBiểuToolStripMenuItem
            // 
            this.thờiKhóaBiểuToolStripMenuItem.Name = "thờiKhóaBiểuToolStripMenuItem";
            this.thờiKhóaBiểuToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.thờiKhóaBiểuToolStripMenuItem.Text = "Thời Khóa Biểu";
            this.thờiKhóaBiểuToolStripMenuItem.Click += new System.EventHandler(this.thờiKhóaBiểuToolStripMenuItem_Click);
            // 
            // xemDanhSáchLớpToolStripMenuItem
            // 
            this.xemDanhSáchLớpToolStripMenuItem.Name = "xemDanhSáchLớpToolStripMenuItem";
            this.xemDanhSáchLớpToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.xemDanhSáchLớpToolStripMenuItem.Text = "Xem Danh Sách Lớp";
            this.xemDanhSáchLớpToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchLớpToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(146, 30);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_logout.Location = new System.Drawing.Point(274, 292);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(140, 165);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_viewDSLop
            // 
            this.btn_viewDSLop.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewDSLop.Image")));
            this.btn_viewDSLop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_viewDSLop.Location = new System.Drawing.Point(82, 292);
            this.btn_viewDSLop.Name = "btn_viewDSLop";
            this.btn_viewDSLop.Size = new System.Drawing.Size(140, 165);
            this.btn_viewDSLop.TabIndex = 3;
            this.btn_viewDSLop.Text = "Xem DS Lớp";
            this.btn_viewDSLop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_viewDSLop.UseVisualStyleBackColor = true;
            this.btn_viewDSLop.Click += new System.EventHandler(this.btn_viewDSLop_Click);
            // 
            // SVStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 499);
            this.Controls.Add(this.btn_viewDSLop);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_timetable);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SVStudent";
            this.Text = "Student Management - SinhVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.Button btn_timetable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảHọcTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thờiKhóaBiểuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_viewDSLop;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}