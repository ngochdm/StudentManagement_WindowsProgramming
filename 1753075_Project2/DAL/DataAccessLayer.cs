﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using DTO;
using static DTO.DataTransferObject;

namespace DAL
{
    public class DataAccessLayer
    {
        #region Dynamic Connection String
        private string ConnectionString { get; set; }
        public DataAccessLayer()
        {
            string path = @"set_connection.txt";
            ConnectionString = GetConnectionString(path);
            //ConnectionString = GetConnectionString("set_connection.txt");
        }
        public string GetConnectionString(string path)
        {
            string connectionstring = "";
            using (var rd = new StreamReader(path))
            {
                connectionstring = rd.ReadLine();
                /*var server = rd.ReadLine().Replace("_", "-");
                var db = rd.ReadLine();
                connectionstring = $"Provider=SQLNCLI11;Server={server};Database={db};Trusted_Connection=Yes";*/
                rd.Close();
            }
            return connectionstring;
        }
        #endregion

        public int checkUserPwd(string user, string pwd)
        {
            try
            {
                string pass = new DTO.DataTransferObject().hashPass(pwd); 
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };

                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(MAGIAOVU) FROM GIAOVU WHERE MAGIAOVU = ?",
                };
                cmd.Parameters.AddWithValue("?", user);

                var rd = cmd.ExecuteScalar();
                if (rd.ToString() == "1")
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT COUNT(MAGIAOVU) FROM GIAOVU WHERE MAGIAOVU = ? AND MATKHAU = ?";
                    cmd.Parameters.AddWithValue("?", user);
                    cmd.Parameters.AddWithValue("?", pass);
                    rd = cmd.ExecuteScalar();
                    if (rd.ToString() == "1")
                    {
                        cnn.Close();
                        return 1;
                    }
                    else
                    {
                        cnn.Close();
                        return 0;
                    }
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT COUNT(MSSV) FROM SINHVIEN WHERE MSSV = ?";
                    cmd.Parameters.AddWithValue("?", user);
                    rd = cmd.ExecuteScalar();
                    if (rd.ToString() == "1")
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT COUNT(MSSV) FROM SINHVIEN WHERE MSSV = ? AND MATKHAU = ?";
                        cmd.Parameters.AddWithValue("?", user);
                        cmd.Parameters.AddWithValue("?", pass);
                        rd = cmd.ExecuteScalar();
                        if (rd.ToString() == "1")
                        {
                            cnn.Close();
                            return -1;
                        }
                        else
                        {
                            cnn.Close();
                            return 0;
                        }
                    }
                }
                cnn.Close();
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        public SinhVien getInfoOneStudent(string mssv)
        {
            try
            {
                SinhVien sv = new SinhVien();
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT MSSV, SOCMND, HOTEN, MALOP, NGAYSINH, DIACHI, GIOITINH FROM SINHVIEN WHERE MSSV = ?"
                };
                cmd.Parameters.AddWithValue("?", mssv);
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
                    sv.MatKhau = "";
                }

                cnn.Close();
                return sv;
            }
            catch
            {
                return new SinhVien();
            }
        }
        public GiaoVu getInfoOneGiaoVu(string MaGV)
        {
            try
            {
                GiaoVu gv = new GiaoVu();
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT MAGIAOVU, SOCMND, HOTEN, NGAYSINH, DIACHI, GIOITINH FROM GIAOVU WHERE MAGIAOVU = ?"
                };

                cmd.Parameters.AddWithValue("?", MaGV);
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (!rd.IsDBNull(0)) gv.MaTV = rd.GetString(0);
                    if (!rd.IsDBNull(1)) gv.SoCMND = rd.GetString(1);
                    if (!rd.IsDBNull(2)) gv.HoTen = rd.GetString(2);
                    if (!rd.IsDBNull(3)) gv.NgaySinh = rd.GetDateTime(3).ToShortDateString();
                    if (!rd.IsDBNull(4)) gv.DiaChi = rd.GetString(4);
                    if (!rd.IsDBNull(5)) gv.GioiTinh = rd.GetString(5);
                    gv.MatKhau = "";
                }
                cnn.Close();
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
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(*) FROM LOPHOC WHERE MALOP = ?"
                };

                cmd.Parameters.AddWithValue("?", lop.MaLop);
                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "0")
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO LOPHOC VALUES (?, ?)";

                    cmd.Parameters.AddWithValue("?", lop.MaLop);
                    cmd.Parameters.AddWithValue("?", lop.TenLop);
                    rd = cmd.ExecuteNonQuery();

                    cnn.Close();
                    return rd.ToString() == "1";
                }
                else
                {
                    cnn.Close();
                    return false;
                }
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
                //SinhVien(MSSV,SoCMND,HoTen,MatKhau,MaLop,NgaySinh,DiaChi,GioiTinh)
                sv.MaTV = sv.MaTV.Replace("\"", string.Empty);
                sv.SoCMND = sv.SoCMND.Replace("\"", string.Empty);
                sv.HoTen = sv.HoTen.Replace("\"", string.Empty);
                sv.MaLop = sv.MaLop.Replace("\"", string.Empty);
                sv.NgaySinh = sv.NgaySinh.Replace("\"", string.Empty);
                sv.DiaChi = sv.DiaChi.Replace("\"", string.Empty);
                sv.GioiTinh = sv.GioiTinh.Replace("\"", string.Empty);

                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(*) FROM SINHVIEN WHERE MSSV = ?"
                };

                cmd.Parameters.AddWithValue("?", sv.MaTV);
                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "1")
                {
                    cnn.Close();
                    return false;
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT COUNT(*) FROM LOPHOC WHERE MALOP = ?";
                    cmd.Parameters.AddWithValue("?", sv.MaLop);

                    rd = cmd.ExecuteScalar();
                    if (rd.ToString() == "0") { cnn.Close(); return false; }
                    else
                    {
                        //SinhVien(MSSV,SoCMND,HoTen,MatKhau,MaLop,NgaySinh,DiaChi,GioiTinh)
                        cmd.Parameters.Clear();
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
                        cnn.Close();
                        return rd.ToString() == "1";
                    }
                }
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
                var classes = new List<LopHoc>();
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT MALOP, TENLOP FROM LOPHOC"
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
            catch
            {
                return new List<LopHoc>();
            }
        }
        public List<SinhVien> getAllStdsInAClass(string lop)
        {
            try
            {
                var students = new List<SinhVien>();
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT MSSV, SOCMND, HOTEN, NGAYSINH, DIACHI, GIOITINH FROM SINHVIEN WHERE MALOP = ?"
                };

                cmd.Parameters.AddWithValue("?", lop);
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
            catch
            {
                return new List<SinhVien>();
            }
        }
        public bool importTimeTable(ThoiKhoaBieu tkb)
        {
            try
            {
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    //TKB(MaLop,MaMonHoc,HocKy,NamHoc,PhongHoc,CongKhaiBangDiem)
                    CommandText = "SELECT COUNT(*) FROM TKB WHERE MALOP = ? AND MAMONHOC = ? AND HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", tkb.MaLop);
                cmd.Parameters.AddWithValue("?", tkb.MaMonHoc);
                cmd.Parameters.AddWithValue("?", tkb.HocKy);
                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "0")
                {
                    cmd.Parameters.Clear();

                    //Check Class is in database or not...
                    cmd.CommandText = "SELECT COUNT(*) FROM LOPHOC WHERE MALOP = ?";
                    cmd.Parameters.AddWithValue("?", tkb.MaLop);
                    rd = cmd.ExecuteScalar();
                    if (rd.ToString() == "0")
                    {
                        cnn.Close();
                        return false;
                    }

                    cmd.Parameters.Clear();

                    //Check subject is in database or not...
                    cmd.CommandText = "SELECT COUNT(*) FROM MONHOC WHERE MAMONHOC = ?";
                    cmd.Parameters.AddWithValue("?", tkb.MaMonHoc);
                    rd = cmd.ExecuteScalar();
                    if (rd.ToString() == "0")
                    {
                        cnn.Close();
                        addASubjectToDatabase(new MonHoc(tkb.MaMonHoc, tkb.TenMon));
                    }

                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO TKB VALUES (?, ?, ?, ?, ?, ?)";

                    cmd.Parameters.AddWithValue("?", tkb.MaLop);
                    cmd.Parameters.AddWithValue("?", tkb.MaMonHoc);
                    cmd.Parameters.AddWithValue("?", tkb.HocKy);
                    cmd.Parameters.AddWithValue("?", tkb.NamHoc);
                    cmd.Parameters.AddWithValue("?", tkb.PhongHoc);
                    cmd.Parameters.AddWithValue("?", tkb.CongKhaiBangDiem);

                    rd = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rd.ToString() == "1";
                }
                else
                { cnn.Close(); return false; }
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
                var timetable = new List<ThoiKhoaBieu>();
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT T.MAMONHOC, MH.TENMONHOC, T.HOCKY, T.NAMHOC, T.PHONGHOC, T.CONGKHAIBANGDIEM FROM TKB T INNER JOIN MONHOC MH ON(T.MaMonHoc = MH.MaMonHoc) WHERE T.MALOP = ?"
                };

                cmd.Parameters.AddWithValue("?", lop);
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
            catch
            {
                return new List<ThoiKhoaBieu>();
            }
        }
        public bool addASubjectToDatabase(MonHoc subject)
        {
            try
            {
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(*) FROM MONHOC WHERE MAMONHOC = ?"
                };

                cmd.Parameters.AddWithValue("?", subject.MaMonHoc);
                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "0")
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO MONHOC VALUES (?, ?)";
                    cmd.Parameters.AddWithValue("?", subject.MaMonHoc);
                    cmd.Parameters.AddWithValue("?", subject.TenMonHoc);
                    rd = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rd.ToString() == "1";
                }
                else
                {
                    cnn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public List<BangDiem> getScoreBoardWithClassAndSubject(string malop, string mamon, string hocky)
        {
            try
            {
                var scoreboard = new List<BangDiem>();

                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT MH.TENMONHOC, BD.MSSV, BD.DIEMGIUAKY, BD.DIEMCUOIKY, BD.DIEMKHAC, BD.DIEMTONG FROM BANGDIEM BD INNER JOIN MONHOC MH ON(BD.MAMONHOC = MH.MAMONHOC) WHERE BD.MAMONHOC = ? AND BD.MALOP = ? AND BD.HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", mamon);
                cmd.Parameters.AddWithValue("?", malop);
                cmd.Parameters.AddWithValue("?", hocky);
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string tenmon = "", mssv = "";
                    float diemgk = 0, diemkhac = 0, diemck = 0, diemtong = 0;

                    if (!rd.IsDBNull(0)) tenmon = rd.GetString(0);
                    if (!rd.IsDBNull(1)) mssv = rd.GetString(1);

                    if (!rd.IsDBNull(2))
                        //diemgk = rd.GetFloat(3);
                        diemgk = (float)rd.GetDouble(2);
                    if (!rd.IsDBNull(3))
                        //diemck = rd.GetFloat(4);
                        diemck = (float)rd.GetDouble(3);
                    if (!rd.IsDBNull(4))
                        //diemkhac = rd.GetFloat(5);
                        diemkhac = (float)rd.GetDouble(4);
                    if (!rd.IsDBNull(5))
                        //diemtong = rd.GetFloat(6);
                        diemtong = (float)rd.GetDouble(5);

                    var score = new BangDiem(mssv, malop, mamon, hocky, tenmon, diemgk, diemck, diemkhac, diemtong);
                    scoreboard.Add(score);
                }
                cnn.Close();

                return scoreboard;
            }
            catch
            {
                return new List<BangDiem>();
            }
        }
        public List<MonHoc> getInfoAllSubject()
        {
            try
            {
                var subjects = new List<MonHoc>();

                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT MAMONHOC, TENMONHOC FROM MONHOC"
                };
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string mamon = "", tenmon = "";

                    if (!rd.IsDBNull(0)) mamon = rd.GetString(0);
                    if (!rd.IsDBNull(1)) tenmon = rd.GetString(1);

                    else tenmon = mamon;
                    var subject = new MonHoc(mamon, tenmon);

                    subjects.Add(subject);
                }
                cnn.Close();
                return subjects;
            }
            catch
            {
                return new List<MonHoc>();
            }
        }
        public List<MonHoc> getAllSubjectOfClass(string malop)
        {
            try
            {
                var timetable = getTimeTableOfAClass(malop);

                var subjects = new List<MonHoc>();
                foreach (var tb in timetable)
                {
                    subjects.Add(new MonHoc(tb.MaMonHoc, tb.TenMon));
                }

                return subjects;
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
                var students = new List<SinhVien>();

                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT BD.MSSV, SV.HOTEN, SV.SoCMND, SV.NGAYSINH, SV.GIOITINH, SV.DIACHI FROM SINHVIEN SV INNER JOIN BANGDIEM BD ON(BD.MSSV = SV.MSSV) WHERE BD.MALOP = ? AND BD.MaMonHoc = ? AND BD.HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", malop);
                cmd.Parameters.AddWithValue("?", mamon);
                cmd.Parameters.AddWithValue("?", hocky);
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string mssv = "", socmnd = "", hoten = "", ngaysinh = "", diachi = "", gioitinh = "";

                    if (!rd.IsDBNull(0)) mssv = rd.GetString(0);
                    if (!rd.IsDBNull(2)) socmnd = rd.GetString(2);
                    if (!rd.IsDBNull(1)) hoten = rd.GetString(1);
                    if (!rd.IsDBNull(3)) ngaysinh = rd.GetDateTime(3).ToShortDateString();
                    if (!rd.IsDBNull(5)) diachi = rd.GetString(5);
                    if (!rd.IsDBNull(4)) gioitinh = rd.GetString(4);

                    var std = new SinhVien(mssv, socmnd, hoten, ngaysinh, diachi, gioitinh, malop);
                    students.Add(std);
                }
                cnn.Close();
                return students;
            }
            catch
            {
                return new List<SinhVien>();
            }
        }
        public List<string> getAllStdIDinAClass(string malop)
        {
            try
            {
                var stdID = new List<string>();

                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT MSSV FROM SINHVIEN WHERE MALOP = ?"
                };

                cmd.Parameters.AddWithValue("?", malop);
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string mssv = "";
                    if (!rd.IsDBNull(0))
                    {
                        mssv = rd.GetString(0);
                        stdID.Add(mssv);
                    }
                }
                cnn.Close();

                return stdID;
            }
            catch
            {
                return new List<string>();
            }
        }
        public bool addAStdToScoreBoardWhenImportTimeTable(string mssv, ThoiKhoaBieu tkb)
        {
            try
            {
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                //BangDiem(MSSV, MaLop, MaMonHoc, HocKy, DiemGK, DiemCK, DiemKhac, DiemTong)
                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "INSERT INTO BANGDIEM(MSSV, MALOP, MAMONHOC, HOCKY) VALUES (?, ?, ?, ?)"
                };

                cmd.Parameters.AddWithValue("?", mssv);
                cmd.Parameters.AddWithValue("?", tkb.MaLop);
                cmd.Parameters.AddWithValue("?", tkb.MaMonHoc);
                cmd.Parameters.AddWithValue("?", tkb.HocKy);

                var rd = cmd.ExecuteNonQuery();

                cnn.Close();
                return rd == 1;
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
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(*) FROM BANGDIEM WHERE MSSV = ? AND MALOP = ? AND MAMONHOC = ? AND HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", scoreboard.MaSV);
                cmd.Parameters.AddWithValue("?", scoreboard.MaLop);
                cmd.Parameters.AddWithValue("?", scoreboard.MaMonHoc);
                cmd.Parameters.AddWithValue("?", scoreboard.HocKy);

                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "1")
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE BANGDIEM SET DIEMGIUAKY = ?, DIEMCUOIKY = ?, DIEMKHAC = ?, DIEMTONG = ? WHERE MSSV = ? AND MALOP = ? AND MAMONHOC = ? AND HOCKY = ?";

                    cmd.Parameters.AddWithValue("?", scoreboard.DiemGK);
                    cmd.Parameters.AddWithValue("?", scoreboard.DiemCK);
                    cmd.Parameters.AddWithValue("?", scoreboard.DiemKhac);
                    cmd.Parameters.AddWithValue("?", scoreboard.DiemTong);
                    cmd.Parameters.AddWithValue("?", scoreboard.MaSV);
                    cmd.Parameters.AddWithValue("?", scoreboard.MaLop);
                    cmd.Parameters.AddWithValue("?", scoreboard.MaMonHoc);
                    cmd.Parameters.AddWithValue("?", scoreboard.HocKy);

                    rd = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rd.ToString() == "1";
                }
                else
                {
                    cnn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool updateTimeTable(ThoiKhoaBieu timetable)
        {
            var cnn = new OleDbConnection()
            {
                //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                ConnectionString = this.ConnectionString
            };
            cnn.Open();

            var cmd = new OleDbCommand()
            {
                Connection = cnn,
                CommandText = "SELECT COUNT(*) FROM TKB WHERE MALOP = ? AND MAMONHOC = ? AND HOCKY = ?"
            };

            cmd.Parameters.AddWithValue("?", timetable.MaLop);
            cmd.Parameters.AddWithValue("?", timetable.MaMonHoc);
            cmd.Parameters.AddWithValue("?", timetable.HocKy);
            var rd = cmd.ExecuteScalar();

            if (rd.ToString() == "1")
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE TKB SET PHONGHOC = ?, CONGKHAIBANGDIEM = ? WHERE MALOP = ? AND MAMONHOC = ? AND HOCKY = ?";

                cmd.Parameters.AddWithValue("?", timetable.PhongHoc);
                cmd.Parameters.AddWithValue("?", timetable.CongKhaiBangDiem);
                cmd.Parameters.AddWithValue("?", timetable.MaLop);
                cmd.Parameters.AddWithValue("?", timetable.MaMonHoc);
                cmd.Parameters.AddWithValue("?", timetable.HocKy);

                rd = cmd.ExecuteNonQuery();
                cnn.Close();
                return rd.ToString() == "1";
            }
            else
            {
                cnn.Close();
                return false;
            }
        }
        public bool insertAStdToListStdInClassAndSubject(string mssv, string malop, string mamon, string hocky)
        {
            try
            {
                //MSSV,MaLop,MaMonHoc,HocKy
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(*) FROM BANGDIEM WHERE MSSV = ? AND MALOP = ? AND MAMONHOC = ? AND HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", mssv);
                cmd.Parameters.AddWithValue("?", malop);
                cmd.Parameters.AddWithValue("?", mamon);
                cmd.Parameters.AddWithValue("?", hocky);
                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "0")
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO BANGDIEM(MSSV, MALOP, MAMONHOC, HOCKY) VALUES (?, ?, ?, ?)";

                    cmd.Parameters.AddWithValue("?", mssv);
                    cmd.Parameters.AddWithValue("?", malop);
                    cmd.Parameters.AddWithValue("?", mamon);
                    cmd.Parameters.AddWithValue("?", hocky);

                    rd = cmd.ExecuteNonQuery();

                    cnn.Close();
                    return rd.ToString() == "1";
                }
                else
                {
                    cnn.Close();
                    return false;
                }
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
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "DELETE FROM BANGDIEM WHERE MSSV = ? AND MALOP = ? AND MAMONHOC = ? AND HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", mssv);
                cmd.Parameters.AddWithValue("?", malop);
                cmd.Parameters.AddWithValue("?", mamon);
                cmd.Parameters.AddWithValue("?", hocky);
                var rd = cmd.ExecuteNonQuery();

                cnn.Close();
                return rd.ToString() == "1";
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
                var semesters = new List<string>();

                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT HOCKY FROM TKB WHERE MALOP = ? AND MAMONHOC = ?"
                };

                cmd.Parameters.AddWithValue("?", malop);
                cmd.Parameters.AddWithValue("?", mamon);

                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (!rd.IsDBNull(0))
                    {
                        var semester = rd.GetString(0);
                        semesters.Add(semester);
                    }
                }

                cnn.Close();
                return semesters;
            }
            catch
            {
                return new List<string>();
            }
        }
        public bool checkScoreBoardIsPublicOrNot(string malop, string mamon, string hocky)
        {
            try
            {
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT CONGKHAIBANGDIEM FROM TKB WHERE MALOP = ? AND MAMONHOC = ? AND HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", malop);
                cmd.Parameters.AddWithValue("?", mamon);
                cmd.Parameters.AddWithValue("?", hocky);
                var rd = cmd.ExecuteReader();

                string ckbd = "0";
                while (rd.Read())
                {
                    ckbd = rd.GetString(0);
                }
                cnn.Close();

                if (ckbd == "1") return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
        public BangDiem getScoreFromDatabase(string mssv, string malop, string mamon, string hocky)
        {
            try
            {
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT DIEMGIUAKY, DIEMCUOIKY, DIEMKHAC, DIEMTONG FROM BANGDIEM WHERE MSSV = ? AND MALOP = ? AND MAMONHOC = ? AND HOCKY = ?"
                };

                cmd.Parameters.AddWithValue("?", mssv);
                cmd.Parameters.AddWithValue("?", malop);
                cmd.Parameters.AddWithValue("?", mamon);
                cmd.Parameters.AddWithValue("?", hocky);
                var rd = cmd.ExecuteReader();

                BangDiem scoreboard = new BangDiem(mssv, malop, mamon, hocky, "", 0, 0, 0, 0);
                while (rd.Read())
                {
                    float gk = 0, ck = 0, khac = 0, tong = 0;
                    if (!rd.IsDBNull(0))
                        gk = (float)rd.GetDouble(0);
                    if (!rd.IsDBNull(1))
                        ck = (float)rd.GetDouble(1);
                    if (!rd.IsDBNull(2))
                        khac = (float)rd.GetDouble(2);
                    if (!rd.IsDBNull(3))
                        tong = (float)rd.GetDouble(3);

                    //scoreboard = new BangDiem(mssv, malop, mamon, hocky, "", gk, ck, khac, tong);
                    scoreboard.DiemGK = gk;
                    scoreboard.DiemCK = ck;
                    scoreboard.DiemKhac = khac;
                    scoreboard.DiemTong = tong;
                }
                cnn.Close();

                return scoreboard;
            }
            catch
            {
                return new BangDiem();
            }
        }
        public bool changePasswordForGiaoVu(string magv, string newpass)
        {
            try
            {
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(*) FROM GIAOVU WHERE MAGIAOVU = ? "
                };

                cmd.Parameters.AddWithValue("?", magv);
                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "1")
                {
                    var NewPass = new DTO.DataTransferObject().hashPass(newpass);

                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE GIAOVU SET MATKHAU = ? WHERE MAGIAOVU = ?";

                    cmd.Parameters.AddWithValue("?", NewPass);
                    cmd.Parameters.AddWithValue("?", magv);

                    rd = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rd.ToString() == "1";
                }
                else
                {
                    cnn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool changePasswordForStudent(string mssv, string newpass)
        {
            try
            {
                var cnn = new OleDbConnection()
                {
                    //ConnectionString = "Provider=SQLNCLI11;Server=LAPTOP-KM8USCIO;Database=StudentManagement;Trusted_Connection=Yes"
                    ConnectionString = this.ConnectionString
                };
                cnn.Open();

                var cmd = new OleDbCommand()
                {
                    Connection = cnn,
                    CommandText = "SELECT COUNT(*) FROM SINHVIEN WHERE MSSV = ? "
                };

                cmd.Parameters.AddWithValue("?", mssv);
                var rd = cmd.ExecuteScalar();

                if (rd.ToString() == "1")
                {
                    var NewPass = new DTO.DataTransferObject().hashPass(newpass);

                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE SINHVIEN SET MATKHAU = ? WHERE MSSV = ?";

                    cmd.Parameters.AddWithValue("?", NewPass);
                    cmd.Parameters.AddWithValue("?", mssv);

                    rd = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rd.ToString() == "1";
                }
                else
                {
                    cnn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
