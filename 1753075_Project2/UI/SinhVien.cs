﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        #region LogOut
        private void LogOut()
        {
            DialogResult drl = MessageBox.Show("Do you want to log out?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drl == DialogResult.Yes)
            {
                this.Hide();
                LoginApp lg = new LoginApp();
                lg.ShowDialog();
                this.Close();
            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        #endregion

        #region Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: HUYNH DOAN MINH NGOC\nID:1753075\nUniversity Of Science, VNU - HCMC", "About");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELP - STUDENT MANAGEMENT\n" +
                "1. View profile: view and edit profile, change password.\n" +
                "2. Kết quả học tập: only see your score board.\n" +
                "3. Thời khóa biểu: only see your time table.\n" +
                "4. Xem DS Lớp: check who is your classmate in some subjects\n" +
                "5. Log Out: log out your account and login again if you want.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        #endregion
    }
}
