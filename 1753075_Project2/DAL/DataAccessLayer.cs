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
            };
            var rd = cmd.ExecuteScalar();
            if (rd.ToString() == "1") 
            {
                cmd.CommandText = $"SELECT COUNT(MAGIAOVU) FROM GIAOVU WHERE MAGIAOVU = '{user}' AND MATKHAU = '{pwd}'";
                rd = cmd.ExecuteScalar();
                if (rd.ToString() == "1") return 1;
                else return 0;
            }
            else
            {
                cmd.CommandText = $"SELECT COUNT(MSSV) FROM SINHVIEN WHERE MSSV = '{user}'";
                rd = cmd.ExecuteScalar();
                if (rd.ToString() == "1")
                {
                    cmd.CommandText = $"SELECT COUNT(MSSV) FROM SINHVIEN WHERE MSSV = '{user}' AND MATKHAU = '{pwd}'";
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
                CommandText = $"SELECT MSSV, SOCMND, HOTEN, MALOP, NGAYSINH, DIACHI, GIOITINH FROM SINHVIEN WHERE MSSV = '{mssv}'"
            };
            var rd = cmd.ExecuteReader();

            if (!rd.IsDBNull(0)) sv.MaTV = rd.GetString(0).ToString();
            if (!rd.IsDBNull(1)) sv.SoCMND = rd.GetString(1).ToString();
            if (!rd.IsDBNull(2)) sv.HoTen = rd.GetString(2).ToString();
            if (!rd.IsDBNull(3)) sv.MaLop = rd.GetString(3).ToString();
            if (!rd.IsDBNull(4)) sv.NgaySinh = rd.GetString(4).ToString();
            if (!rd.IsDBNull(5)) sv.DiaChi = rd.GetString(5).ToString();
            if (!rd.IsDBNull(6)) sv.GioiTinh = rd.GetString(6).ToString();

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
                CommandText = $"SELECT MAGIAOVU, SOCMND, HOTEN, NGAYSINH, DIACHI, GIOITINH FROM GIAOVU WHERE MAGIAOVU = '{MaGV}'"
            };
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (!rd.IsDBNull(0)) gv.MaTV = rd.GetString(0);
                if (!rd.IsDBNull(1)) gv.SoCMND = rd.GetString(1);
                if (!rd.IsDBNull(2)) gv.HoTen = rd.GetString(2);
                if (!rd.IsDBNull(3)) gv.NgaySinh = rd.GetDateTime(3).ToLongDateString();
                if (!rd.IsDBNull(4)) gv.DiaChi = rd.GetString(4);
                if (!rd.IsDBNull(5)) gv.GioiTinh = rd.GetString(5);
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

    }
}
