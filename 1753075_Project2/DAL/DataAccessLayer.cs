using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using DTO;

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
    }
}
