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
    public partial class AddAClass : Form
    {
        static public string malop { get; set; }
        static public string tenlop { get; set; }
        public AddAClass()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Malop.TextLength > 10 || tb_Tenlop.TextLength > 30) 
            {
                MessageBox.Show("Mã lớp hoặc Tên lớp vượt quá số kí tự cho phép.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                malop = tb_Malop.Text; 
                tenlop = tb_Tenlop.Text;
                this.Close();
                //this.DialogResult = DialogResult.OK;
            }
        }

        public LopHoc getInfoNewClass()
        {
            LopHoc lop = new LopHoc(malop, tenlop);
            return lop;
        }
    }
}
