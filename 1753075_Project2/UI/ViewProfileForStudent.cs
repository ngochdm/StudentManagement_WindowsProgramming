using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;

namespace UI
{
    public partial class ViewProfileForStudent : Form
    {
        public static string MSSV;
        public ViewProfileForStudent()
        {
            InitializeComponent();
        }
        public ViewProfileForStudent(string mssv)
        {
            MSSV = mssv;
            InitializeComponent();
        }

        private void ViewProfileForStudent_Load(object sender, EventArgs e)
        {
            //MSSV,SoCMND,HoTen,MaLop,NgaySinh,DiaChi,GioiTinh
            var std = new BLL.BusinessLogicLayer().getInfoOneStd(MSSV);
            tb_cmndsv.Text = std.SoCMND;
            tb_Dchisv.Text = std.DiaChi;
            tb_GTsv.Text = std.GioiTinh;
            tb_hotensv.Text = std.HoTen;
            tb_lopsv.Text = std.MaLop;
            tb_Mssv.Text = MSSV;
            tb_ngsinhsv.Text = std.NgaySinh;
        }
    }
}
