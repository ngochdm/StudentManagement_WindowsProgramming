create database StudentManagement

ON (NAME='StudentManagement', FILENAME='D:\LEARNING\CLC2\Year 2\Term 3\LT Window\Project\Project 2_SM\Source Code\StudentManagement.mdf')
LOG ON(NAME='StudentManagement_log', FILENAME='D:\LEARNING\CLC2\Year 2\Term 3\LT Window\Project\Project 2_SM\Source Code\StudentManagement_log.ldf')
GO

use StudentManagement
go

create table GiaoVu (
    MaGiaoVu char(11) not null,
	SoCMND char(11) not null,
	HoTen nvarchar(100) not null,
	MatKhau char(255) not null,
	NgaySinh Date not null,
	DiaChi nvarchar(255) not null,
	GioiTinh varchar(1) not null,
	primary key (MaGiaoVu)
)

create table SinhVien (
	MSSV int not null,
	SoCMND char(11) not null,
	HoTen nchar(100) not null,
	MatKhau char(255) not null,
	MaLop char(10),
	NgaySinh Date,
	DiaChi nvarchar(255),
	GioiTinh varchar(1) not null,
	primary key (MSSV)
)

create table LopHoc (
	MaLop char(10) not null,
	TenLop nvarchar(30) not null,
	primary key (MaLop)
)

create table MonHoc (
	MaLop char(10) not null,	
	MaMonHoc char(10) not null,
	HocKy char(10) not null, --Fall/Spring/Summer
	NamHoc char(9) not null,
	CongKhaiBangDiem char(1),
	primary key (MaLop, MaMonHoc, HocKy)
)

create table BangDiem (
	MSSV int not null,
	MaLop char(10) not null,
	MaMonHoc char(10) not null,
	HocKy char(10) not null, --Fall/Spring/Summer
	DiemGiuaKy float,
	DiemCuoiKy float,
	DiemKhac float,
	DiemTong float,
	primary key (MSSV, MaLop, MaMonHoc, HocKy)
)
create table DanhSachPhong (
	MaLop char(10) not null,
	MaMonHoc char(10) not null,
	HocKy char(10) not null, --Fall/Spring/Summer
	PhongHoc char(10),
	primary key (MaLop,MaMonHoc)
)
create table DanhSachMon (
	MaMonHoc char(10) not null,
	TenMonHoc char (100) not null,
	primary key (MaMonHoc)
)
go


alter table SinhVien
	add foreign key (MaLop) references LopHoc(MaLop)

alter table MonHoc
	add foreign key (MaLop) references LopHoc(MaLop)
alter table MonHoc
	add foreign key (MaMonHoc) references DanhSachMon(MaMonHoc)

alter table DanhSachPhong
	add foreign key (MaLop, MaMonHoc, HocKy) references MonHoc(MaLop, MaMonHoc, HocKy)

alter table BangDiem
	add foreign key (MSSV) references SinhVien(MSSV)
alter table BangDiem
	add foreign key (MaLop, MaMonHoc, HocKy) references MonHoc(MaLop, MaMonHoc, HocKy)

go