using System;
using System.Collections.Generic;
using System.Linq;
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
            public ThanhVienTruong() { }
            public ThanhVienTruong(string tvid, string cmnd, string hoten, string pwd, string ngsinh, string dchi, string gt)
            {
                MaTV = tvid;
                SoCMND = cmnd;
                HoTen = hoten;
                MatKhau = pwd;
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

            public GiaoVu() { }
            /* public GiaoVu(string gv_id, string cmnd, string hoten, string pwd, string ngsinh, string dchi, string gt)
             {
                 MaGV = gv_id;
                 SoCMND = cmnd;
                 HoTen = hoten;
                 MatKhau = pwd;
                 NgaySinh = ngsinh;
                 DiaChi = dchi;
                 GioiTinh = gt;
             }*/

            public GiaoVu(string gv_id, string cmnd, string hoten, string pwd, string ngsinh, string dchi, string gt): base(gv_id, cmnd, hoten, pwd, ngsinh, dchi, gt) { }
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

            public SinhVien() { }
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
            public SinhVien(string sv_id, string cmnd, string hoten, string pwd, string ngsinh, string dchi, string gt, string classId) : base(sv_id, cmnd, hoten, pwd, ngsinh, dchi, gt)
            {
                MaLop = classId;
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

            public ThoiKhoaBieu() { }
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
            public BangDiem() { }
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
    }
}
