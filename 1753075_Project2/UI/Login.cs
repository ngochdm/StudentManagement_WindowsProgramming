using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class LoginApp : Form
    {
        public LoginApp()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Enter usename and password to login.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int check = new BLL.BusinessLogicLayer().checkingUserPwd(username, password);
                if (check == 0)
                    MessageBox.Show("Incorrect account!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (check == 1)
                {
                    this.Hide();
                    var giaovu = new GiaoVu(username);
                    giaovu.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    var sv = new SVStudent(username);
                    sv.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
