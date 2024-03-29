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
    public partial class ViewListStdsOfClass : Form
    {
        public static List<LopHoc> classes;
        public ViewListStdsOfClass()
        {
            InitializeComponent();
            classes = new BLL.BusinessLogicLayer().getAllInfoOfClasses();
            foreach (var aClass in classes)
            {
                cbb_lop.Items.Add(aClass.MaLop);
            }
            cbb_lop.SelectedIndex = 0;
        }
        public ViewListStdsOfClass(string lop)
        {
            InitializeComponent();
            cbb_lop.Hide();
            lb_ClassID.Text = $"Danh sách sinh viên lớp {lop}";
            BindListOfStdsIntoListView(lop);
        }


        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindListOfStdsIntoListView(cbb_lop.SelectedItem.ToString());
        }

        private void BindListOfStdsIntoListView(string malop)
        {
            //lv.Items.Clear();
            lv.BeginUpdate();
            lv.Items.Clear();
            var stds = new BLL.BusinessLogicLayer().getAllStdsInAClass(malop);
            int count = 1;
            foreach (var std in stds)
            {
                ListViewItem item = new ListViewItem(std.MaTV);
                //count++;
                //mssv,hoten,cmnd,ngaysinh,gt,diachi
                //item.SubItems.Add(std.MaTV);
                item.SubItems.Add(std.HoTen);
                item.SubItems.Add(std.SoCMND);
                item.SubItems.Add(std.NgaySinh);
                item.SubItems.Add(std.GioiTinh);
                item.SubItems.Add(std.DiaChi);
                item.SubItems.Add(count.ToString()); count++;
                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }
    }
}
