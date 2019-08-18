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
        public int checkingUserPwd(string user, string pwd)
        {
            //-1: Student, 0: False, 1: GiaoVu
            try
            {
                int check = new DAL.DataAccessLayer().checkUserPwd(user, pwd);
                return check;
            }
            catch
            {
                return 0;
            }
        }
        public SinhVien getInfoOneStd(string mssv)
        {
            try
            {
                SinhVien sv = new SinhVien();
                sv = new DAL.DataAccessLayer().getInfoOneStudent(mssv);
                return sv;
            }
            catch
            {
                return new SinhVien();
            }
        }
        public GiaoVu getInfoGiaoVu(string magv)
        {
            try
            {
                GiaoVu gv = new GiaoVu();
                gv = new DAL.DataAccessLayer().getInfoOneGiaoVu(magv);
                return gv;
            }
            catch
            {
                return new GiaoVu();
            }
        }
        public bool importClass(LopHoc lop)
        {
            try
            {
                return new DAL.DataAccessLayer().importClass(lop);
            }
            catch
            {
                return false;
            }
        }
        public bool insertAStudent(SinhVien sv)
        {
            try
            {
                return new DAL.DataAccessLayer().insertAStudent(sv);
            }
            catch
            {
                return false;
            }
        }
        public List<SinhVien> readListStdFromCsvFile(string path)
        {
            try
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
            catch
            {
                return new List<SinhVien>();
            }
        }
        public bool addListMemsInClass(List<SinhVien> students)
        {
            try
            {
                bool check = false;
                var dal = new DAL.DataAccessLayer();
                foreach (var std in students)
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
            try
            {
                return new DAL.DataAccessLayer().getAllInfoOfClasses();
            }
            catch
            {
                return new List<LopHoc>();
            }
        }
        public List<SinhVien> getAllStdsInAClass(string lop)
        {
            try
            {
                if (lop.Length > 10) return new List<SinhVien>();
                return new DAL.DataAccessLayer().getAllStdsInAClass(lop);
            }
            catch
            {
                return new List<SinhVien>();
            }
        }
        public List<ThoiKhoaBieu> readListTimeTableFromCSVFile(string path)
        {
                var tt = new List<ThoiKhoaBieu>();
            try
            {
                using (var rd = new StreamReader(path))
                {
                    var malop = rd.ReadLine();
                    rd.ReadLine();

                    string aline;
                    while ((aline = rd.ReadLine()) != null)
                    {
                        var arr = aline.Split(',');
                        //TKB(MaLop,MaMonHoc,HocKy,NamHoc,PhongHoc,CongKhaiBangDiem)
                        //STT,Mã môn,Tên môn,Học kỳ,Năm học,Phòng học,Công Khai Bảng Điểm
                        var mamon = arr[1];
                        var tenmon = arr[2];
                        var hocky = arr[3];
                        var namhoc = arr[4];
                        var phonghoc = arr[5];
                        var congkhaibangdiem = int.Parse(arr[6]);
                        bool ckbd = false;
                        if (congkhaibangdiem == 1) ckbd = true;
                        var tkb = new ThoiKhoaBieu(malop, mamon, hocky, namhoc, phonghoc, ckbd, tenmon);
                        tt.Add(tkb);
                    }
                }
                return tt;
            }
            catch
            {
                return tt;
            }
        }
        public bool addListTimeTable(List<ThoiKhoaBieu> tt)
        {
            try
            {
                bool check = false;
                var dal = new DAL.DataAccessLayer();
                foreach (var tkb in tt)
                {
                    check = dal.importTimeTable(tkb);
                }
                return check;
            }
           catch
            {
                return false;
            }
        }
        public List<ThoiKhoaBieu> getTimeTableOfAClass(string lop)
        {
            try
            {
                if (lop.Length > 10) return new List<ThoiKhoaBieu>();
                return new DAL.DataAccessLayer().getTimeTableOfAClass(lop);
            }
            catch
            {
                return new List<ThoiKhoaBieu>();
            }
        }
        public bool insertASubject(MonHoc subject)
        {
            try
            {
                if (subject.MaMonHoc.Length > 10) return false;
                return new DAL.DataAccessLayer().addASubjectToDatabase(subject);
            }
            catch
            {
                return false;
            }
        }
        public List<BangDiem> getAllScoreBoardWithClassAndSubject(string malop,string mamon, string hocky)
        {
            try
            {
                if (malop.Length > 10 || mamon.Length > 10) return new List<BangDiem>();
                return new DAL.DataAccessLayer().getScoreBoardWithClassAndSubject(malop, mamon, hocky);
            }
            catch
            {
                return new List<BangDiem>();
            }
        }
        public List<MonHoc> getSubjectsOfClass(string malop)
        {
            try
            {
                if (malop.Length > 10) return new List<MonHoc>();
                return new DAL.DataAccessLayer().getAllSubjectOfClass(malop);
            }
            catch
            {
                return new List<MonHoc>();
            }
        }
        public List<SinhVien> getAllStdsInClassAndSubject(string malop, string mamon, string hocky)
        {
            try
            {
                if (malop.Length > 10 || mamon.Length > 10) return new List<SinhVien>();
                return new DAL.DataAccessLayer().getAllStdsInClassAndSubject(malop, mamon, hocky);
            }
            catch
            {
                return new List<SinhVien>();
            }
        }
        public bool addAStdIntoScoreBoard(List<ThoiKhoaBieu> timetable)
        {
            try
            {
                bool check = false;
                foreach (var tkb in timetable)
                {
                    var dal = new DAL.DataAccessLayer();
                    List<string> stdID = dal.getAllStdIDinAClass(tkb.MaLop);
                    
                    foreach (var std in stdID)
                    {
                        check = dal.addAStdToScoreBoardWhenImportTimeTable(std, tkb);
                    }
                }
                return check;
            }
            catch
            {
                return false;
            }
        }
        public bool updateScoreBoard(BangDiem scoreboard)
        {
            try
            {
                if (scoreboard.MaSV.Length > 10)
                    return false;
                if ((scoreboard.DiemCK > 10 && scoreboard.DiemCK < 0) || (scoreboard.DiemGK > 10 && scoreboard.DiemGK < 0) || (scoreboard.DiemKhac > 10 && scoreboard.DiemKhac < 0) || (scoreboard.DiemTong > 10 && scoreboard.DiemTong < 10))
                {
                    return false;
                }
                else
                    return new DAL.DataAccessLayer().updateScoreBoard(scoreboard);
            }
            catch
            {
                return false;
            }
        }
        public bool updateListScoreBoard(List<BangDiem> scoreboard)
        {
            try
            {
                bool check = false;
                foreach (var sc in scoreboard)
                {
                    check = updateScoreBoard(sc);
                }
                return check;
            }
            catch
            {
                return false;
            }
        }
        public List<BangDiem> readScoreBoardFromCSVFile(string path)
        {
            try
            {
                var scoreboard = new List<BangDiem>();
                using (var rd = new StreamReader(path))
                {
                    //malop,mamon,hocky
                    var firstline = rd.ReadLine();
                    var fl = firstline.Split(',');

                    var malop = fl[0];
                    var mamon = fl[1];
                    var hocky = fl[2];

                    rd.ReadLine();

                    string aline;

                    while ((aline = rd.ReadLine()) != null)
                    {
                        var arr = aline.Split(',');

                        //BangDiem(MSSV,MaLop,MaMonHoc,HocKy,DiemGK,DiemCK,DiemKhac,DiemTong)
                        //STT,MSSV,Họ tên,Điểm giữa kỳ,Điểm cuối kỳ,Điểm khác,Điểm tổng

                        var mssv = arr[1];
                        var diemgk = (float)double.Parse(arr[3]);
                        var diemck = (float)double.Parse(arr[4]);
                        var diemkhac = (float)double.Parse(arr[5]);
                        var diemtong = (float)double.Parse(arr[6]);

                        var sc = new BangDiem(mssv, malop, mamon, hocky, "", diemgk, diemck, diemkhac, diemtong);
                        scoreboard.Add(sc);
                    }
                }
                return scoreboard;
            }
            catch
            {
                return new List<BangDiem>();
            }
        }
        public bool editTimeTable(ThoiKhoaBieu timetable)
        {
            try
            {
                if (timetable.PhongHoc.Length > 10) return false;
                else return new DAL.DataAccessLayer().updateTimeTable(timetable);
            }
            catch
            {
                return false;
            }
        }
        public bool insertAStdToListStdInClassAndSubject(string mssv, string malop, string mamon, string hocky)
        {
            try
            {
                if (mssv.Length > 10)
                    return false;
                else
                    return new DAL.DataAccessLayer().insertAStdToListStdInClassAndSubject(mssv, malop, mamon, hocky);
            }
            catch
            {
                return false;
            }
        }
        public bool deleteAStdFromListStdInClassAndSubject(string mssv, string malop, string mamon, string hocky)
        {
            try
            {
                if (mssv.Length > 10)
                    return false;
                else
                    return new DAL.DataAccessLayer().deleteAStdFromListStdInClassAndSubject(mssv, malop, mamon, hocky);
            }
            catch
            {
                return false;
            }
        }
        public List<string> getAllSemesterOfSubjectInClass(string malop, string mamon)
        {
            try
            {
                if (malop.Length > 10 || mamon.Length > 10) return new List<string>();
                return new DAL.DataAccessLayer().getAllSemesterOfSubjectInClass(malop, mamon);
            }
            catch
            {
                return new List<string>();
            }
        }
        public bool checkScorePublic(string malop,string mamon,string hocky)
        {
            try
            {
                if (malop.Length > 10 || mamon.Length > 10) return false;
                return new DAL.DataAccessLayer().checkScoreBoardIsPublicOrNot(malop, mamon, hocky);
            }
            catch
            {
                return false;
            }
        }
        public BangDiem getScoreBoardForStudent(string mssv,string malop,string mamon,string hocky)
        {
            try
            {
                var dal = new DAL.DataAccessLayer();
                var congkhai = checkScorePublic(malop, mamon, hocky);
                if (congkhai == true)
                {
                    return dal.getScoreFromDatabase(mssv, malop, mamon, hocky);
                }
                else
                {
                    return new BangDiem();
                }
            }
            catch
            {
                return new BangDiem();
            }
        }
        public bool changePwdForGiaovu(string magv,string newpass)
        {
            try
            {
                if (newpass.Length > 255) return false;
                else return new DAL.DataAccessLayer().changePasswordForGiaoVu(magv, newpass);
            }
            catch
            {
                return false;
            }
        }
        public bool changePwdForStudent(string mssv, string newpass)
        {
            try
            {
                if (newpass.Length > 255) return false;
                else return new DAL.DataAccessLayer().changePasswordForStudent(mssv, newpass);
            }
            catch
            {
                return false;
            }
        }
    }
}
