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
    public partial class ViewProfileForGV : Form
    {
        static public string MaGV;
        public ViewProfileForGV()
        {
            InitializeComponent();
        }

        public ViewProfileForGV(string magv)
        {
            MaGV = magv;
            InitializeComponent();
        }

        private void ViewProfileForGV_Load(object sender, EventArgs e)
        {
            var gv = new BLL.BusinessLogicLayer().getInfoGiaoVu(MaGV);
            tb_MaGV.Text = MaGV;
            tb_cmndGv.Text = gv.SoCMND;
            tb_DchiGv.Text = gv.DiaChi;
            tb_GTgv.Text = gv.GioiTinh;
            tb_hotenGV.Text = gv.HoTen;
            tb_ngsinhGv.Text = gv.NgaySinh;
        }

        private void btn_changePwdGv_Click(object sender, EventArgs e)
        {
            var changePass = new ChangePassword(MaGV);
            changePass.ShowDialog();
        }
    }
}
