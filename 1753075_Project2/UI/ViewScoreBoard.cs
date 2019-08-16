using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DTO;
using static DTO.DataTransferObject;

namespace UI
{
    public partial class ViewScoreBoard : Form
    {
        public static string MaLop = "";
        public static string MaMon = "";
        public static List<LopHoc> classes;
        public static List<MonHoc> subjects;
        //public static BLL.BusinessLogicLayer bll = new BLL.BusinessLogicLayer();

        public ViewScoreBoard()
        {
            InitializeComponent();
        }

        private void ViewScoreBoard_Load(object sender, EventArgs e)
        {
            cbb_lop.Items.Clear();
            cbb_MonHoc.Items.Clear();

            classes = new BLL.BusinessLogicLayer().getAllInfoOfClasses();
            foreach (var aClass in classes)
            {
                cbb_lop.Items.Add(aClass.MaLop);
            }
            cbb_lop.SelectedIndex = 0;
            MaLop = cbb_lop.SelectedItem.ToString();

            subjects = new BLL.BusinessLogicLayer().getSubjectsOfClass(MaLop);
            foreach(var subject in subjects)
            {
                cbb_MonHoc.Items.Add(subject.MaMonHoc);
            }
            if (cbb_MonHoc.Items.Count > 0)
            {
                cbb_MonHoc.SelectedIndex = 0;
                MaMon = cbb_MonHoc.SelectedItem.ToString();
                lb_tenmon.Text = subjects.First().TenMonHoc;

                BindListOfScoreBoardStdsIntoListView(MaLop, MaMon);
            }
            else lb_tenmon.Text = "This class didn't learn any subject";
        }

        private void BindListOfScoreBoardStdsIntoListView(string malop, string mamon)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            var scores = new BLL.BusinessLogicLayer().getAllScoreBoardWithClassAndSubject(malop, mamon) ;
            foreach (var score in scores)
            {
                //MSSV,HocKy,DiemGK,DiemCK,DiemKhac,DiemTong
                ListViewItem item = new ListViewItem(score.MaSV);

                item.SubItems.Add(score.HocKy);
                item.SubItems.Add(score.DiemGK.ToString());
                item.SubItems.Add(score.DiemCK.ToString());
                item.SubItems.Add(score.DiemKhac.ToString());
                item.SubItems.Add(score.DiemTong.ToString());

                lv.Items.Add(item);
            }
            lv.EndUpdate();
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

                BindListOfScoreBoardStdsIntoListView(MaLop, MaMon);
            }
            else lb_tenmon.Text = "This class didn't learn any subject";
        }

        private void cbb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MonHoc.Items.Count > 0)
            {
                MaMon = cbb_MonHoc.SelectedItem.ToString();
                lb_tenmon.Text = subjects.Find(x => x.MaMonHoc.Contains(MaMon)).TenMonHoc;

                BindListOfScoreBoardStdsIntoListView(MaLop, MaMon);
            }
            else lb_tenmon.Text = "This class didn't learn any subject";
        }
    }
}
