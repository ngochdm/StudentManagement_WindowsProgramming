﻿using System;
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
        public static string HocKy = "";

        public static List<LopHoc> classes;
        public static List<MonHoc> subjects;
        public static List<string> semesters;

        //public static BLL.BusinessLogicLayer bll = new BLL.BusinessLogicLayer();

        public ViewScoreBoard()
        {
            InitializeComponent();
        }

        private void ViewScoreBoard_Load(object sender, EventArgs e)
        {
            cbb_lop.Items.Clear();
            cbb_MonHoc.Items.Clear();
            cbb_hocky.Items.Clear();

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

                semesters = new BLL.BusinessLogicLayer().getAllSemesterOfSubjectInClass(MaLop, MaMon);
                foreach (var semester in semesters)
                {
                    cbb_hocky.Items.Add(semester);
                }
                cbb_hocky.SelectedIndex = 0;
                HocKy = cbb_hocky.SelectedItem.ToString();

                BindListOfScoreBoardStdsIntoListView(MaLop, MaMon, HocKy);
            }
            else lb_tenmon.Text = "This class didn't have any subject";
        }

        private void BindListOfScoreBoardStdsIntoListView(string malop, string mamon, string hocky)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            var scores = new BLL.BusinessLogicLayer().getAllScoreBoardWithClassAndSubject(malop, mamon, hocky) ;

            int count = 1;
            foreach (var score in scores)
            {
                //MSSV,HocKy,DiemGK,DiemCK,DiemKhac,DiemTong
                ListViewItem item = new ListViewItem(score.MaSV);

                item.SubItems.Add(score.HocKy);
                item.SubItems.Add(score.DiemGK.ToString());
                item.SubItems.Add(score.DiemCK.ToString());
                item.SubItems.Add(score.DiemKhac.ToString());
                item.SubItems.Add(score.DiemTong.ToString());
                item.SubItems.Add(count.ToString());

                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaLop = cbb_lop.SelectedItem.ToString();
            cbb_MonHoc.Items.Clear();
            cbb_hocky.Items.Clear();

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

                semesters = new BLL.BusinessLogicLayer().getAllSemesterOfSubjectInClass(MaLop, MaMon);
                foreach (var semester in semesters)
                {
                    cbb_hocky.Items.Add(semester);
                }
                cbb_hocky.SelectedIndex = 0;
                HocKy = cbb_hocky.SelectedItem.ToString();

                BindListOfScoreBoardStdsIntoListView(MaLop, MaMon, HocKy);
            }
            else lb_tenmon.Text = "This class didn't have any subject";
        }

        private void cbb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaMon = cbb_MonHoc.SelectedItem.ToString();
            lb_tenmon.Text = subjects.Find(x => x.MaMonHoc.Contains(MaMon)).TenMonHoc;
            cbb_hocky.Items.Clear();

            semesters = new BLL.BusinessLogicLayer().getAllSemesterOfSubjectInClass(MaLop, MaMon);
            foreach (var semester in semesters)
            {
                cbb_hocky.Items.Add(semester);
            }
            cbb_hocky.SelectedIndex = 0;
            HocKy = cbb_hocky.SelectedItem.ToString();

            BindListOfScoreBoardStdsIntoListView(MaLop, MaMon, HocKy);
        }

        private void cbb_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            HocKy = cbb_hocky.SelectedItem.ToString();
        }
    }
}
