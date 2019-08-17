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
    public partial class ViewScoreBoardFromStudent : Form
    {
        static public SinhVien student;
        static public List<MonHoc> subjects;
        static public List<string> semesters;

        static public string MSSV = "";
        static public string MaMon = "";
        static public string HocKy = "";

        public ViewScoreBoardFromStudent()
        {
            InitializeComponent();
        }

        public ViewScoreBoardFromStudent(string mssv)
        {
            MSSV = mssv;
            InitializeComponent();
            student = new BLL.BusinessLogicLayer().getInfoOneStd(mssv);
            subjects = new BLL.BusinessLogicLayer().getSubjectsOfClass(student.MaLop);
        }

        private void ViewScoreBoardFromStudent_Load(object sender, EventArgs e)
        {
            cbb_MonHoc.Items.Clear();
            cbb_hocky.Items.Clear();
            cbb_MonHoc.Items.Add("All subjects");
            foreach (var subject in subjects)
            {
                cbb_MonHoc.Items.Add(subject.MaMonHoc);
            }
            cbb_MonHoc.SelectedIndex = 0;

            BindScoreToListView();
        }

        private void cbb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bll = new BLL.BusinessLogicLayer();
            cbb_hocky.Items.Clear();
            if (cbb_MonHoc.SelectedIndex > 0) 
            {
                MaMon = cbb_MonHoc.SelectedItem.ToString();
                semesters = bll.getAllSemesterOfSubjectInClass(student.MaLop, MaMon);

                foreach (var semester in semesters) 
                {
                    cbb_hocky.Items.Add(semester);
                }
                cbb_hocky.SelectedIndex = 0;
                HocKy = cbb_hocky.SelectedItem.ToString();

                lb_tenmon.Text = subjects.Find(x => x.MaMonHoc.Contains(MaMon)).TenMonHoc;

                BindScoreToCBB(MaMon, HocKy);
            }
            else //if students choose view all subjects
            {
                BindScoreToListView();
            }
        }

        private void cbb_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            HocKy = cbb_hocky.SelectedItem.ToString();
            BindScoreToCBB(MaMon, HocKy);
        }

        private void BindScoreToCBB(string mamon, string hocky)
        {
            lb_ck.Show(); lb_gk.Show(); lb_khac.Show(); lb_tong.Show(); lb_result.Show();
            tb_ck.Show(); tb_gk.Show(); tb_khac.Show(); tb_tong.Show();

            lv.Hide();
            tb_ck.Text = ""; tb_gk.Text = ""; tb_khac.Text = ""; tb_tong.Text = "";
            lb_result.Text = "";
            var scoreboard = new BLL.BusinessLogicLayer().getScoreBoardForStudent(MSSV, student.MaLop, mamon, hocky);
            if (scoreboard.MaSV == "0")
                lb_result.Text = "Môn học này chưa có điểm.";
            else
            {
                tb_ck.Text = scoreboard.DiemCK.ToString();
                tb_gk.Text = scoreboard.DiemGK.ToString();
                tb_khac.Text = scoreboard.DiemKhac.ToString();
                tb_tong.Text = scoreboard.DiemTong.ToString();

                if (scoreboard.DiemTong > 5.0)
                    lb_result.Text = "Chúc mừng bạn đã qua môn ^^";
                else
                    lb_result.Text = "Môn này bạn không đạt điểm yêu cầu. :(";
            }
        }

        private void BindScoreToListView()
        {
            lb_ck.Hide(); lb_gk.Hide(); lb_khac.Hide(); lb_tong.Hide(); lb_result.Hide();
            tb_ck.Hide(); tb_gk.Hide(); tb_khac.Hide(); tb_tong.Hide();
            lv.Show();

            var bll = new BLL.BusinessLogicLayer();

            var scoreboard = new List<BangDiem>();

            foreach (var subject in subjects)
            {
                var cachocky = bll.getAllSemesterOfSubjectInClass(student.MaLop, subject.MaMonHoc);

                foreach (var semester in cachocky)
                {
                    var score = bll.getScoreBoardForStudent(MSSV, student.MaLop, subject.MaMonHoc, semester);

                    if (score.MaSV != "0") scoreboard.Add(score);
                }
            }

            lv.BeginUpdate();
            lv.Items.Clear();

            int count = 1;
            foreach (var score in scoreboard)
            {
                //MaMon,TenMon,HocKy,DiemGK,DiemCK,DiemKhac,DiemTong,STT
                ListViewItem item = new ListViewItem(score.MaMonHoc);

                item.SubItems.Add(subjects.Find(x => x.MaMonHoc.Contains(MaMon)).TenMonHoc);
                item.SubItems.Add(score.HocKy);
                item.SubItems.Add(score.DiemGK.ToString());
                item.SubItems.Add(score.DiemCK.ToString());
                item.SubItems.Add(score.DiemKhac.ToString());
                item.SubItems.Add(score.DiemTong.ToString());

                item.SubItems.Add(count.ToString());
                count++;

                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }
    }
}
