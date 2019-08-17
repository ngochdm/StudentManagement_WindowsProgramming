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
    public partial class EditTimeTable : Form
    {
        public static ThoiKhoaBieu timetable;
        public static List<LopHoc> classes;
        public static List<MonHoc> subjects;

        public static string MaLop = "";
        public static string MaMon = "";
        public static string HocKy = "";

        public EditTimeTable()
        {
            InitializeComponent();
        }

        private void EditTimeTable_Load(object sender, EventArgs e)
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
            if (tb_ckbd.Text.Trim() == string.Empty || tb_phong.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ nội dung để cập nhật", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (tb_ckbd.Text.Length > 1)
                {
                    MessageBox.Show("Công khai bảng điểm chỉ được nhập MỘT kí tự 0 hoặc 1", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bool ckbd = false;
                if (tb_ckbd.Text == "1")
                    ckbd = true;
                else if (tb_ckbd.Text == "0")
                    ckbd = false;
                else
                {
                    MessageBox.Show("Công khai bảng điểm chỉ nhận giá trị 0 hoặc 1");
                }

                if (tb_ckbd.Text == "1" || tb_ckbd.Text == "0")
                {
                    var phong = tb_phong.Text;

                    timetable = new ThoiKhoaBieu(MaLop, MaMon, HocKy, "", phong, ckbd, "");
                    var check = new BLL.BusinessLogicLayer().editTimeTable(timetable);

                    if (check == true)
                        MessageBox.Show("Edit successfully");
                    else
                        MessageBox.Show("Edit UNsuccessfully");
                }
            }
        }
    }
}