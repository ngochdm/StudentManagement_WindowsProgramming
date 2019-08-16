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
    public partial class ViewListStdsOfClass : Form
    {
        public static List<LopHoc> classes;
        public ViewListStdsOfClass()
        {
            InitializeComponent();
        }
        public ViewListStdsOfClass(string lop)
        {
            InitializeComponent();
            cbb_lop.Hide();
            lb_ClassID.Text = $"Danh sách sinh viên lớp {lop}";
            lv.Items.Clear();
            BindListOfStdsIntoListView(lop);
        }

        private void ViewListStdsOfClass_Load(object sender, EventArgs e)
        {
            classes = new BLL.BusinessLogicLayer().getAllInfoOfClasses();
            foreach(var aClass in classes)
            {
                cbb_lop.Items.Add(aClass.MaLop);
            }
            cbb_lop.SelectedIndex = 0;
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindListOfStdsIntoListView(cbb_lop.SelectedItem.ToString());
        }

        private void BindListOfStdsIntoListView(string malop)
        {
            lv.Items.Clear();
            lv.BeginUpdate();
            lv.Items.Clear();
            var stds = new BLL.BusinessLogicLayer().getAllStdsInAClass(malop);
            foreach (var std in stds)
            {
                ListViewItem item = new ListViewItem(std.MaTV);
                //mssv,hoten,cmnd,ngaysinh,gt,diachi
                //item.SubItems.Add(std.MaTV);
                item.SubItems.Add(std.HoTen);
                item.SubItems.Add(std.SoCMND);
                item.SubItems.Add(std.NgaySinh);
                item.SubItems.Add(std.GioiTinh);
                item.SubItems.Add(std.DiaChi);
                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }

        private void ViewListStdsOfClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            //lv.Items.Clear();
            //classes.Clear();
        }
    }
}
