using System;
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
    public partial class GiaoVu : Form
    {
        static public string MaGV;
        public GiaoVu()
        {
            InitializeComponent();
        }

        public GiaoVu(string magv)
        {
            MaGV = magv;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
                "2. Thêm lớp: add one class (id and name) into database.\n" +
                "3. Thêm sinh viên: add one student in classes.\n" +
                "4. Thêm bảng điểm: import one/more score board into database.\n" +
                "5. Xem DS Lớp: view all of lists of members in classes learning some subjects.\n" +
                "6. Sửa DS Lớp: edit lists of members in classes learning some subjects.\n" +
                "7. Sửa điểm: edit scores of one student.\n" +
                "8. Xem bảng điểm: view all score board.\n" +
                "9. Xem thời khóa biểu: view all time tables.\n" +
                "10.Thêm thời khóa biểu: insert time and place for one class to learn any subject in the semester and school year.\n" +
                "11.Sửa thời khóa biểu: edit time table.\n" +
                "12. Log Out: log out your account and login again if you want.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        #endregion

        private void btn_profile_Click(object sender, EventArgs e)
        {
            ViewProfileForGV vp = new ViewProfileForGV(MaGV);
            vp.ShowDialog();
        }
    }
}
