using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BLL;
using static DTO.DataTransferObject;

namespace UI
{
    public partial class ViewTimeTable : Form
    {
        static public List<LopHoc> classes;
        public ViewTimeTable()
        {
            InitializeComponent();
            classes = new BLL.BusinessLogicLayer().getAllInfoOfClasses();
            foreach (var aClass in classes)
            {
                cbb_lop.Items.Add(aClass.MaLop);
            }
            cbb_lop.SelectedIndex = 0;
        }

        public ViewTimeTable(string lop)
        {
            InitializeComponent();
            cbb_lop.Hide();
            lb_ClassID.Text = $"Thời khóa biểu lớp {lop}";
            BindListOfTimeTableIntoListView(lop);
        }

        private void BindListOfTimeTableIntoListView(string lop)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            var timetable = new BLL.BusinessLogicLayer().getTimeTableOfAClass(lop);
            foreach (var tkb in timetable)
            {
                ListViewItem item = new ListViewItem(tkb.MaMonHoc);
                //MaMonHoc,Tenmon,HocKy,NamHoc,PhongHoc
                item.SubItems.Add(tkb.TenMon);
                item.SubItems.Add(tkb.HocKy);
                item.SubItems.Add(tkb.NamHoc);
                item.SubItems.Add(tkb.PhongHoc);
                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindListOfTimeTableIntoListView(cbb_lop.SelectedItem.ToString());
        }
    }
}
