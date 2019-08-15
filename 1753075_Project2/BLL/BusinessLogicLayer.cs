using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using static DTO.DataTransferObject;

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
        public SinhVien getInfoOneStd(string mssv)
        {
            SinhVien sv = new SinhVien();
            sv = new DAL.DataAccessLayer().getInfoOneStudent(mssv);
            return sv;
        }
        public GiaoVu getInfoGiaoVu(string magv)
        {
            GiaoVu gv = new GiaoVu();
            gv = new DAL.DataAccessLayer().getInfoOneGiaoVu(magv);
            return gv;
        }
    }
}
