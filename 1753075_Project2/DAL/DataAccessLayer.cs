using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using DTO;
using static DTO.DataTransferObject;

namespace DAL
{
    public class DataAccessLayer
    {
        public int checkUserPwd(string user, string pwd)
        {
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = $"SELECT COUNT(MAGIAOVU) FROM GIAOVU WHERE MAGIAOVU = '{user}'"
                //CommandText = $"SELECT COUNT(MAGIAOVU) FROM GIAOVU WHERE MAGIAOVU = '?'",
            };
            //cmd.Parameters.AddWithValue("?", user);
            var rd = cmd.ExecuteScalar();
            if (rd.ToString() == "1")
            {
                //cmd.Parameters.Clear();
                cmd.CommandText = $"SELECT COUNT(MAGIAOVU) FROM GIAOVU WHERE MAGIAOVU = '{user}' AND MATKHAU = '{pwd}'";
                //cmd.Parameters.AddWithValue("?", user);
                //cmd.Parameters.AddWithValue("?", pwd);
                rd = cmd.ExecuteScalar();
                if (rd.ToString() == "1") return 1;
                else return 0;
            }
            else
            {
                cmd.CommandText = $"SELECT COUNT(MSSV) FROM SINHVIEN WHERE MSSV = '{user}'";
                //cmd.Parameters.AddWithValue("?", user);
                rd = cmd.ExecuteScalar();
                if (rd.ToString() == "1")
                {
                    cmd.CommandText = $"SELECT COUNT(MSSV) FROM SINHVIEN WHERE MSSV = '{user}' AND MATKHAU = '{pwd}'";
                    //cmd.Parameters.AddWithValue("?", user);
                    //cmd.Parameters.AddWithValue("?", pwd);
                    rd = cmd.ExecuteScalar();
                    if (rd.ToString() == "1") return -1;
                    else return 0;
                }
            }
            cnn.Close();
            return 0;
        }
        public SinhVien getInfoOneStudent(string mssv)
        {
            SinhVien sv = new SinhVien();
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = $"SELECT MSSV, SOCMND, HOTEN, MALOP, NGAYSINH, DIACHI, GIOITINH, MATKHAU FROM SINHVIEN WHERE MSSV = '{mssv}'"
            };
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (!rd.IsDBNull(0)) sv.MaTV = rd.GetString(0);
                if (!rd.IsDBNull(1)) sv.SoCMND = rd.GetString(1);
                if (!rd.IsDBNull(2)) sv.HoTen = rd.GetString(2);
                if (!rd.IsDBNull(3)) sv.MaLop = rd.GetString(3);
                if (!rd.IsDBNull(4)) sv.NgaySinh = rd.GetDateTime(4).ToShortDateString();
                if (!rd.IsDBNull(5)) sv.DiaChi = rd.GetString(5);
                if (!rd.IsDBNull(6)) sv.GioiTinh = rd.GetString(6);
                if (!rd.IsDBNull(7)) sv.MatKhau = rd.GetString(7);
            }
            cnn.Close();
            return sv;
        }
        public GiaoVu getInfoOneGiaoVu(string MaGV)
        {
            GiaoVu gv = new GiaoVu();
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = $"SELECT MAGIAOVU, SOCMND, HOTEN, NGAYSINH, DIACHI, GIOITINH, MATKHAU FROM GIAOVU WHERE MAGIAOVU = '{MaGV}'"
            };
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (!rd.IsDBNull(0)) gv.MaTV = rd.GetString(0);
                if (!rd.IsDBNull(1)) gv.SoCMND = rd.GetString(1);
                if (!rd.IsDBNull(2)) gv.HoTen = rd.GetString(2);
                if (!rd.IsDBNull(3)) gv.NgaySinh = rd.GetDateTime(3).ToShortDateString();
                if (!rd.IsDBNull(4)) gv.DiaChi = rd.GetString(4);
                if (!rd.IsDBNull(5)) gv.GioiTinh = rd.GetString(5);
                if (!rd.IsDBNull(6)) gv.MatKhau = rd.GetString(6).ToString();
            }

            /*gv.MaTV = rd.GetString(0).ToString();
            gv.SoCMND = rd.GetString(1).ToString();
            gv.HoTen = rd.GetString(2).ToString();
            gv.NgaySinh = rd.GetString(3).ToString();
            gv.DiaChi = rd.GetString(4).ToString();
            gv.GioiTinh = rd.GetString(5).ToString();*/

                cnn.Close();
            return gv;
        }
        public bool importClass(LopHoc lop)
        {
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                //
                CommandText = $"SELECT COUNT(*) FROM LOPHOC WHERE MALOP = '{lop.MaLop}'"
            };
            var rd = cmd.ExecuteScalar();
            if (rd.ToString() == "0")
            {
                cmd.CommandText = "INSERT INTO LOPHOC VALUES (?, ?)";
                cmd.Parameters.AddWithValue("?", lop.MaLop);
                cmd.Parameters.AddWithValue("?", lop.TenLop);
                rd = cmd.ExecuteNonQuery();
                return rd.ToString() == "1";
            }
            else
                return false;
            cnn.Close();
        }
        public bool insertAStudent(SinhVien sv)
        {
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = $"SELECT COUNT(*) FROM SINHVIEN WHERE MSSV = '{sv.MaTV}'"
            };
            var rd = cmd.ExecuteScalar();
            if (rd.ToString() == "1")
            {
                return false;
            }
            else
            {
                cmd.CommandText = $"SELECT COUNT(*) FROM LOPHOC WHERE MALOP = '{sv.MaLop}'";
                rd = cmd.ExecuteScalar();
                if (rd.ToString() == "0") return false;
                else
                {
                    //SinhVien(MSSV,SoCMND,HoTen,MatKhau,MaLop,NgaySinh,DiaChi,GioiTinh)
                    cmd.CommandText = "INSERT INTO SINHVIEN VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                    cmd.Parameters.AddWithValue("?", sv.MaTV);
                    cmd.Parameters.AddWithValue("?", sv.SoCMND);
                    cmd.Parameters.AddWithValue("?", sv.HoTen);
                    cmd.Parameters.AddWithValue("?", sv.MatKhau);
                    cmd.Parameters.AddWithValue("?", sv.MaLop);
                    //cmd.Parameters.AddWithValue("?", sv.NgaySinh);
                    var ngsinh = sv.NgaySinh.Split('/');
                    DateTime dob = new DateTime(int.Parse(ngsinh[2]), int.Parse(ngsinh[1]), int.Parse(ngsinh[0]));
                    cmd.Parameters.AddWithValue("?", dob);
                    cmd.Parameters.AddWithValue("?", sv.DiaChi);
                    cmd.Parameters.AddWithValue("?", sv.GioiTinh);
                    rd = cmd.ExecuteNonQuery();
                    return rd.ToString() == "1";
                }
            }
            cnn.Close();
        }
        public List<LopHoc> getAllInfoOfClasses()
        {
            var classes = new List<LopHoc>();
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = $"SELECT MALOP, TENLOP FROM LOPHOC"
            };
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string malop = "", tenlop = "";
                if (!rd.IsDBNull(0)) malop = rd.GetString(0);
                if (!rd.IsDBNull(1)) tenlop = rd.GetString(1);
                else tenlop = malop;
                var aClass = new LopHoc(malop, tenlop);
                classes.Add(aClass);
            }
            cnn.Close();
            return classes;
        }
        public List<SinhVien> getAllStdsInAClass(string lop)
        {
            var students = new List<SinhVien>();
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = $"SELECT MSSV, SOCMND, HOTEN, NGAYSINH, DIACHI, GIOITINH FROM SINHVIEN WHERE MALOP = '{lop}'"
            };
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string mssv = "", socmnd = "", hoten = "", ngaysinh = "", diachi = "", gioitinh = "";
                if (!rd.IsDBNull(0)) mssv = rd.GetString(0);
                if (!rd.IsDBNull(1)) socmnd = rd.GetString(1);
                if (!rd.IsDBNull(2)) hoten = rd.GetString(2);
                if (!rd.IsDBNull(3)) ngaysinh = rd.GetDateTime(3).ToShortDateString();
                if (!rd.IsDBNull(4)) diachi = rd.GetString(4);
                if (!rd.IsDBNull(5)) gioitinh = rd.GetString(5);
                var std = new SinhVien(mssv, socmnd, hoten, ngaysinh, diachi, gioitinh, lop);
                students.Add(std);
            }
            cnn.Close();
            return students;
        }
        public bool importTimeTable(ThoiKhoaBieu tkb)
        {
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                //TKB(MaLop,MaMonHoc,HocKy,NamHoc,PhongHoc,CongKhaiBangDiem)
                CommandText = $"SELECT COUNT(*) FROM TKB WHERE MALOP = '{tkb.MaLop}' AND MAMONHOC = '{tkb.MaMonHoc}' AND HOCKY = '{tkb.HocKy}'"
            };
            var rd = cmd.ExecuteScalar();
            if (rd.ToString() == "0")
            {
                //Check Class is in database or not...
                cmd.CommandText = $"SELECT COUNT(*) FROM LOPHOC WHERE MALOP = '{tkb.MaLop}'";
                rd = cmd.ExecuteScalar();
                if (rd.ToString() == "0") return false;

                //Check subject is in database or not...
                cmd.CommandText = $"SELECT COUNT(*) FROM MONHOC WHERE MAMONHOC = '{tkb.MaMonHoc}'";
                rd = cmd.ExecuteScalar();
                if (rd.ToString() == "0") return false;

                cmd.CommandText = "INSERT INTO TKB VALUES (?, ?, ?, ?, ?, ?)";
                cmd.Parameters.AddWithValue("?", tkb.MaLop);
                cmd.Parameters.AddWithValue("?", tkb.MaMonHoc);
                cmd.Parameters.AddWithValue("?", tkb.HocKy);
                cmd.Parameters.AddWithValue("?", tkb.NamHoc);
                cmd.Parameters.AddWithValue("?", tkb.PhongHoc);
                cmd.Parameters.AddWithValue("?", tkb.CongKhaiBangDiem);

                rd = cmd.ExecuteNonQuery();
                return rd.ToString() == "1";
            }
            else
                return false;
            cnn.Close();

        }
        public List<ThoiKhoaBieu> getTimeTableOfAClass(string lop)
        {
            var timetable = new List<ThoiKhoaBieu>();
            var cnn = new OleDbConnection()
            {
                ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
            };
            cnn.Open();
            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = $"SELECT T.MAMONHOC, MH.TENMONHOC, T.HOCKY, T.NAMHOC, T.PHONGHOC, T.CONGKHAIBANGDIEM FROM TKB T INNER JOIN MONHOC MH ON(T.MaMonHoc = MH.MaMonHoc) WHERE T.MALOP = '{lop}'"
            };
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string mamon = "", tenmon = "", hocky = "", namhoc = "", phonghoc = "", ckbd = "";
                if (!rd.IsDBNull(0)) mamon = rd.GetString(0);
                if (!rd.IsDBNull(1)) tenmon = rd.GetString(1);
                if (!rd.IsDBNull(2)) hocky = rd.GetString(2);
                if (!rd.IsDBNull(3)) namhoc = rd.GetString(3);
                if (!rd.IsDBNull(4)) phonghoc = rd.GetString(4);
                if (!rd.IsDBNull(5)) ckbd = rd.GetString(5);
                bool ckhaibd = false;
                if (ckbd == "1") ckhaibd = true;
                var tt = new ThoiKhoaBieu(lop, mamon, hocky, namhoc, phonghoc, ckhaibd, tenmon);
                timetable.Add(tt);
            }
            cnn.Close();
            return timetable;

        }
    }
}
