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
    public partial class InsertASubjectToDB : Form
    {
        public static MonHoc subject;
        public InsertASubjectToDB()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Mamon.TextLength > 10 || tb_Tenmon.TextLength > 30)
            {
                MessageBox.Show("Mã lớp hoặc Tên lớp vượt quá số kí tự cho phép.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                subject = new MonHoc(tb_Mamon.Text, tb_Tenmon.Text);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

        public MonHoc getInfoNewSubject()
        {
            return new MonHoc(tb_Mamon.Text, tb_Tenmon.Text);
        }
    }
}
