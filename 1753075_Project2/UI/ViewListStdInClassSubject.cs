﻿using System;
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
    public partial class ViewListStdInClassSubject : Form
    {
        public static string MaLop = "";
        public static string MaMon = "";
        public static string HocKy = "";

        public static List<string> semesters;
        public static List<LopHoc> classes;
        public static List<MonHoc> subjects;

        public ViewListStdInClassSubject()
        {
            InitializeComponent();
        }

        private void ViewListStdInClassSubject_Load(object sender, EventArgs e)
        {
            lv.Items.Clear();

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

            #region Draft (After edit _ avoid duplicate in cbb subject and semester)
            /*subjects = new BLL.BusinessLogicLayer().getSubjectsOfClass(MaLop);
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

                BindListStdsInClassSubject(MaLop, MaMon, HocKy);
            }
            else lb_tenmon.Text = "This class didn't have any subject";*/
            #endregion
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv.Items.Clear();

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

                #region Draft (After edit - avoid duplicate in cbb semester)
                /*semesters = new BLL.BusinessLogicLayer().getAllSemesterOfSubjectInClass(MaLop, MaMon);
                foreach (var semester in semesters)
                {
                    cbb_hocky.Items.Add(semester);
                }
                cbb_hocky.SelectedIndex = 0;
                HocKy = cbb_hocky.SelectedItem.ToString();

                BindListStdsInClassSubject(MaLop, MaMon, HocKy);*/
                #endregion
            }
            else lb_tenmon.Text = "This class didn't have any subject";
        }

        private void cbb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv.Items.Clear();

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

            BindListStdsInClassSubject(MaLop, MaMon, HocKy);
        }

        private void BindListStdsInClassSubject(string malop, string mamon, string hocky)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            var students = new BLL.BusinessLogicLayer().getAllStdsInClassAndSubject(malop, mamon, hocky);

            int count = 1;
            foreach (var std in students)
            {
                ListViewItem item = new ListViewItem(count.ToString());
                count++;

                //stt,mssv,hoten,socmnd,ngaysinh,gioitinh,diachi

                item.SubItems.Add(std.MaTV);
                item.SubItems.Add(std.HoTen);
                item.SubItems.Add(std.SoCMND);
                item.SubItems.Add(std.NgaySinh);
                item.SubItems.Add(std.GioiTinh);
                item.SubItems.Add(std.DiaChi);

                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }

        private void cbb_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv.Items.Clear();

            HocKy = cbb_hocky.SelectedItem.ToString();
            BindListStdsInClassSubject(MaLop, MaMon, HocKy);
        }
    }
}
