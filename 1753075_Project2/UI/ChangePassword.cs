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
    public partial class ChangePassword : Form
    {
        public static string Username = "";

        public ChangePassword(string username)
        {
            Username = username;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_confirmPass.Text.Trim() == string.Empty || tb_newPass.Text.Trim() == string.Empty || tb_Oldpassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ nội dung để đổi mật khẩu");
            }

            else if (tb_newPass.Text.Trim().Length < 6) 
            {
                MessageBox.Show("Mật khẩu mới phải ít nhất 6 kí tự");
            }

            else
            {
                if (tb_newPass.Text.Trim() != tb_confirmPass.Text.Trim())
                {
                    MessageBox.Show("Xác nhận mật khẩu không trùng với mật khẩu mới");
                }

                else if(tb_newPass.Text.Trim()==tb_Oldpassword.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ");
                }

                else
                {
                    var bll = new BLL.BusinessLogicLayer();
                    int checkOldPass = bll.checkingUserPwd(Username, tb_Oldpassword.Text);

                    //-1: Student, 0: False, 1: GiaoVu
                    if (checkOldPass == 0)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không chính xác. Vui lòng nhập lại.");
                    }
                    else
                    {
                        if (checkOldPass == 1) 
                        {
                            var isChange = bll.changePwdForGiaovu(Username, tb_newPass.Text);
                            if (isChange == true)
                            {
                                MessageBox.Show("Change password successfully");
                            }
                            else
                            {
                                MessageBox.Show("Change password UNsuccessfully");
                            }
                            this.Close();
                        }
                        else
                        {
                            var isChange = bll.changePwdForStudent(Username, tb_newPass.Text);
                            if (isChange == true)
                            {
                                MessageBox.Show("Change password successfully");
                            }
                            else
                            {
                                MessageBox.Show("Change password UNsuccessfully");
                            }
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
