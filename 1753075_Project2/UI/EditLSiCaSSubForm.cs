using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class EditLSiCaSSubForm : Form
    {
        static public string mssv = "";

        public EditLSiCaSSubForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Mssv.Text.Length > 10) 
            {
                MessageBox.Show("MSSV tối đa 10 kí tự");
            }
            else
            {
                mssv = tb_Mssv.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        public string getMSSV()
        {
            return mssv;
        }
    }
}
