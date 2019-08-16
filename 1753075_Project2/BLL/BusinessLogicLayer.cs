using System;
using System.Collections.Generic;
using System.IO;
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
        public bool importClass(LopHoc lop)
        {
            return new DAL.DataAccessLayer().importClass(lop);
        }
        public bool insertAStudent(SinhVien sv)
        {
            return new DAL.DataAccessLayer().insertAStudent(sv);
        }
        public List<SinhVien> readListStdFromCsvFile(string path)
        {
            var students = new List<SinhVien>();
            using (var rd = new StreamReader(path))
            {
                var malop = rd.ReadLine();
                var lop = new LopHoc(malop, malop);
                var dal = new DAL.DataAccessLayer();
                dal.importClass(lop);

                rd.ReadLine();
                string aline;
                while ((aline = rd.ReadLine()) != null) 
                {
                    var arr = aline.Split(',');
                    //STT,MSSV,Họ tên,Giới tính,CMND,Ngày sinh,Địa chỉ
                    var mssv = arr[1];
                    var hoten = arr[2];
                    var gioitinh = arr[3];
                    var cmnd = arr[4];
                    var ngsinh = arr[5];
                    var diachi = arr[6];
                    var student = new SinhVien(mssv, cmnd, hoten, ngsinh, diachi, gioitinh, malop);
                    students.Add(student);
                }
            }
            return students;
        }
        public bool addListMemsInClass(List<SinhVien> students)
        {
            try
            {
                bool check = false;
                var dal = new DAL.DataAccessLayer();
                foreach(var std in students)
                {
                    check = dal.insertAStudent(std);
                }
                return check;
            }
            catch
            {
                return false;
            }
        }
        public List<LopHoc> getAllInfoOfClasses()
        {
            return new DAL.DataAccessLayer().getAllInfoOfClasses();
        }
        public List<SinhVien> getAllStdsInAClass(string lop)
        {
            return new DAL.DataAccessLayer().getAllStdsInAClass(lop);
        }
    }
}
