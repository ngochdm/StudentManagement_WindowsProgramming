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
    public partial class ViewListStdInClassSubject : Form
    {
        public static string MaLop = "";
        public static string MaMon = "";
        public static List<LopHoc> classes;
        public static List<MonHoc> subjects;

        public ViewListStdInClassSubject()
        {
            InitializeComponent();
        }

        private void ViewListStdInClassSubject_Load(object sender, EventArgs e)
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
            foreach (var subject in subjects)
            {
                cbb_MonHoc.Items.Add(subject.MaMonHoc);
            }
            if (cbb_MonHoc.Items.Count > 0)
            {
                cbb_MonHoc.SelectedIndex = 0;
                MaMon = cbb_MonHoc.SelectedItem.ToString();
                lb_tenmon.Text = subjects.First().TenMonHoc;

                BindListStdsInClassSubject(MaLop, MaMon);
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

                BindListStdsInClassSubject(MaLop, MaMon);
            }
            else lb_tenmon.Text = "This class didn't have any subject";
        }

        private void cbb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MonHoc.Items.Count > 0)
            {
                MaMon = cbb_MonHoc.SelectedItem.ToString();
                lb_tenmon.Text = subjects.Find(x => x.MaMonHoc.Contains(MaMon)).TenMonHoc;

                BindListStdsInClassSubject(MaLop, MaMon);
            }
            else lb_tenmon.Text = "This class didn't learn any subject";
        }

        private void BindListStdsInClassSubject(string malop, string mamon)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            var students = new BLL.BusinessLogicLayer().getAllStdsInClassAndSubject(malop, mamon);

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
    }
}
