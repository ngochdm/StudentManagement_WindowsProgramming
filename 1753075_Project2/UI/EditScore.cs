using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DTO.DataTransferObject;

namespace UI
{
    public partial class EditScore : Form
    {
        public static BangDiem scoreboard;
        public static List<LopHoc> classes;
        public static List<MonHoc> subjects;

        public static string MaLop = "";
        public static string MaMon = "";
        public static string HocKy = "";

        public EditScore()
        {
            InitializeComponent();
        }

        private void EditScore_Load(object sender, EventArgs e)
        {
            cbb_lop.Items.Clear();
            cbb_MonHoc.Items.Clear();
            cbb_hocky.SelectedIndex = 0;

            classes = new BLL.BusinessLogicLayer().getAllInfoOfClasses();
            foreach (var aClass in classes)
            {
                cbb_lop.Items.Add(aClass.MaLop);
            }
            cbb_lop.SelectedIndex = 0;
            MaLop = cbb_lop.SelectedItem.ToString();

            subjects = new BLL.BusinessLogicLayer().getSubjectsOfClass(MaLop);
            foreach (var subject in subjects)
            {
                cbb_MonHoc.Items.Add(subject.MaMonHoc);
            }
            if (cbb_MonHoc.Items.Count > 0)
            {
                cbb_MonHoc.SelectedIndex = 0;
                MaMon = cbb_MonHoc.SelectedItem.ToString();
                lb_tenmon.Text = subjects.First().TenMonHoc;
            }
            else lb_tenmon.Text = "This class didn't have any subject";
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaLop = cbb_lop.SelectedItem.ToString();
            cbb_MonHoc.Items.Clear();

            subjects = new BLL.BusinessLogicLayer().getSubjectsOfClass(MaLop);
            foreach (var subject in subjects)
            {
                cbb_MonHoc.Items.Add(subject.MaMonHoc);
            }
            if (cbb_MonHoc.Items.Count > 0)
            {
                cbb_MonHoc.SelectedIndex = 0;
                MaMon = cbb_MonHoc.SelectedItem.ToString();
                lb_tenmon.Text = subjects.First().TenMonHoc;
            }
            else lb_tenmon.Text = "This class didn't have any subject";
        }

        private void cbb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaMon = cbb_MonHoc.SelectedItem.ToString();
            lb_tenmon.Text = subjects.Find(x => x.MaMonHoc.Contains(MaMon)).TenMonHoc;
        }

        private void cbb_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            HocKy = cbb_hocky.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_ck.Text.Trim() == string.Empty || tb_gk.Text.Trim() == string.Empty || tb_khac.Text.Trim() == string.Empty || tb_MSSV.Text.Trim() == string.Empty || tb_tong.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ nội dung để cập nhật điểm", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var mssv = tb_MSSV.Text;

                var gk = (float)double.Parse(tb_gk.Text);
                var ck = (float)double.Parse(tb_ck.Text);
                var khac = (float)double.Parse(tb_khac.Text);
                var tong = (float)double.Parse(tb_tong.Text);

                scoreboard = new BangDiem(mssv, MaLop, MaMon, HocKy, "", gk, ck, khac, tong);
                var check = new BLL.BusinessLogicLayer().updateScoreBoard(scoreboard);

                if (check == true)
                    MessageBox.Show("Edit successfully");
                else
                    MessageBox.Show("Edit UNsuccessfully");
            }
            //this.DialogResult = DialogResult.OK;
        }
    }
}
