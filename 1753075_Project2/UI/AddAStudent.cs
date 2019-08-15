using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using static DTO.DataTransferObject;

namespace UI
{
    public partial class AddAStudent : Form
    {
        static public SinhVien sv;
        public AddAStudent()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //SinhVien(MSSV,SoCMND,HoTen,MatKhau,MaLop,NgaySinh,DiaChi,GioiTinh)
            if (tb_Mssv.TextLength > 10 || tb_cmndsv.TextLength > 11 || tb_hotensv.TextLength > 100 || tb_lopsv.TextLength > 10 || tb_Dchisv.TextLength > 255 || tb_year.TextLength != 4)
            {
                MessageBox.Show("Có ít nhất một nội dung vượt quá số kí tự cho phép.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(tb_year.Text) > 2020 || int.Parse(tb_year.Text) < 1800)
                {
                    MessageBox.Show("Năm sinh không hợp lệ!");
                }
                else
                {
                    string nsinh = $"{cbb_day.SelectedItem.ToString()}/{cbb_month.SelectedItem.ToString()}/{tb_year.Text}";
                    string sex = "";
                    if (btn_Male.Checked) sex = "Nam";
                    if (btn_Female.Checked) sex = "Nữ";
                    sv = new SinhVien(tb_Mssv.Text, tb_cmndsv.Text, tb_hotensv.Text, nsinh, tb_Dchisv.Text, sex, tb_lopsv.Text);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        public SinhVien getInfoNewStd()
        {
            return sv;
        }

        private void AddAStudent_Load(object sender, EventArgs e)
        {
            cbb_day.SelectedIndex = 0;
            cbb_month.SelectedIndex = 0;
        }
    }
}
