using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    public class BusinessLogicLayer
    {
        public int checkingUserPwd(string user,string pwd)
        {
            //-1: Student, 0: False, 1: GiaoVu
            int check = new DAL.DataAccessLayer().checkUserPwd(user, pwd);
            return check;
        }
    }
}
