﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DTO
{
    public class DataTransferObject
    {
        public class ThanhVienTruong
        {
            public string MaTV { get; set; }
            public string SoCMND { get; set; }
            public string HoTen { get; set; }
            public string MatKhau { get; set; }
            public string NgaySinh { get; set; }
            public string DiaChi { get; set; }
            public string GioiTinh { get; set; }
            public ThanhVienTruong()
            {
                MaTV = "0";
            }
            public ThanhVienTruong(string tvid, string cmnd, string hoten, string ngsinh, string dchi, string gt)
            {
                MaTV = tvid;
                SoCMND = cmnd;
                HoTen = hoten;
                //MatKhau = pwd;
                NgaySinh = ngsinh;
                DiaChi = dchi;
                GioiTinh = gt;
            }

        }

        public class GiaoVu : ThanhVienTruong
        {
            //GiaoVu(-MaGiaoVu-,SoCMND,HoTen,MatKhau,NgaySinh,DiaChi,GioiTinh)
            /*#region KhaiBaoBien
            public string MaGV { get; set; }
            public string SoCMND { get; set; }
            public string HoTen { get; set; }
            public string MatKhau { get; set; }
            public string NgaySinh { get; set; }
            public string DiaChi { get; set; }
            public string GioiTinh { get; set; }
            #endregion*/

            public GiaoVu()
            {
                MaTV = "0";
            }
             public GiaoVu(string gv_id, string cmnd, string hoten, string pwd, string ngsinh, string dchi, string gt) : base(gv_id, cmnd, hoten, ngsinh, dchi, gt)
            {
                MatKhau = new DataTransferObject().hashPass(pwd);
            }

            public GiaoVu(string gv_id, string cmnd, string hoten, string ngsinh, string dchi, string gt) : base(gv_id, cmnd, hoten, ngsinh, dchi, gt) { }
        }

        public class SinhVien:ThanhVienTruong
        {
            //SinhVien(-MSSV-,SoCMND,HoTen,MatKhau,MaLop,NgaySinh,DiaChi,GioiTinh)
            /*#region KhaiBaoBien
            public string MaSV { get; set; }
            public string SoCMND { get; set; }
            public string HoTen { get; set; }
            public string MatKhau { get; set; }
            public string NgaySinh { get; set; }
            public string DiaChi { get; set; }
            public string GioiTinh { get; set; }
            public string MaLop { get; set; }
            #endregion*/

            public string MaLop { get; set; }

            public SinhVien()
            {
                MaTV = "0";
            }
            /*public SinhVien(string sv_id, string cmnd, string hoten, string pwd, string ngsinh, string dchi, string gt)
            {
                MaSV = sv_id;
                SoCMND = cmnd;
                HoTen = hoten;
                MatKhau = pwd;
                NgaySinh = ngsinh;
                DiaChi = dchi;
                GioiTinh = gt;
            }*/
            public SinhVien(string sv_id, string cmnd, string hoten, string ngsinh, string dchi, string gt, string classId) : base(sv_id, cmnd, hoten, ngsinh, dchi, gt)
            {
                MaLop = classId;
                var nsinh = ngsinh.Split('/');
                var day = int.Parse(nsinh[0]).ToString("00");
                var month = int.Parse(nsinh[1]).ToString("00");
                var year = nsinh[2];
                var matkhau = $"{day}{month}{year}";
                MatKhau = new DTO.DataTransferObject().hashPass(matkhau);
            }
        }

        public class ThoiKhoaBieu
        {
            //TKB(-MaLop,MaMonHoc,HocKy-,NamHoc,PhongHoc,CongKhaiBangDiem) + TenMon
            #region KhaiBaoBien
            public string MaLop { get; set; }
            public string MaMonHoc { get; set; }
            public string HocKy { get; set; }
            public string NamHoc { get; set; }
            public string PhongHoc { get; set; }
            public bool CongKhaiBangDiem { get; set; }
            public string TenMon { get; set; }
            #endregion

            public ThoiKhoaBieu()
            {
                MaLop = "0";MaMonHoc = "0";HocKy = "0";
            }
            //cid:class id, sid: subject id, syear: school year, sname: school name
            public ThoiKhoaBieu(string cid, string sid, string semester, string syear, string room, bool publicScore, string sname)
            {
                MaLop = cid;
                MaMonHoc = sid;
                HocKy = semester;
                NamHoc = syear;
                PhongHoc = room;
                CongKhaiBangDiem = publicScore;
                TenMon = sname;
            }
        }

        public class BangDiem
        {
            //BangDiem(-MSSV,MaLop,MaMonHoc,HocKy-,DiemGK,DiemCK,DiemKhac,DiemTong) + TenMon
            #region KhaiBaoBien
            public string MaSV { get; set; }
            public string MaLop { get; set; }
            public string MaMonHoc { get; set; }
            public string HocKy { get; set; }
            public string TenMon { get; set; }
            public float DiemGK { get; set; }
            public float DiemCK { get; set; }
            public float DiemKhac{ get; set; }
            public float DiemTong { get; set; }
            #endregion

            //cid:class id, sid: subject id, sname: school name
            public BangDiem()
            {
                MaSV = "0";
                    MaLop = "0"; MaMonHoc = "0"; HocKy = "0";
            }
            public BangDiem(string stdid, string cid, string sid, string semester, string sname, float gk, float ck, float khac, float tong)
            {
                MaSV = stdid;
                MaLop = cid;
                MaMonHoc = sid;
                HocKy = semester;
                DiemGK = gk;
                DiemCK = ck;
                DiemKhac = khac;
                DiemTong = tong;
            }
        }

        public class LopHoc
        {
            public string MaLop { get; set; }
            public string TenLop { get; set; }

            public LopHoc()
            {
                MaLop = "0";
            }
            public LopHoc(string malop, string tenlop)
            {
                MaLop = malop;
                TenLop = tenlop;
            }
        }

        public class MonHoc
        {
            public string MaMonHoc { get; set; }
            public string TenMonHoc { get; set; }

            public MonHoc()
            {
                MaMonHoc = "0";
            }
            public MonHoc(string mamon,string tenmon)
            {
                MaMonHoc = mamon;
                TenMonHoc = tenmon;
            }
        }

        public string hashPass(string pass)
        {
            string passAfterHash = "";
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            passAfterHash = sb.ToString();
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa             trong "X2" thành "x"

            return passAfterHash;
        }
    }
}
