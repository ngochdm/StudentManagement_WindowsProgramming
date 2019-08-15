create database StudentManagement

ON (NAME='StudentManagement', FILENAME='D:\LEARNING\CLC2\Year 2\Term 3\LT Window\Project\Project 2_SM\StudentManagement.mdf')
LOG ON(NAME='StudentManagement_log', FILENAME='D:\LEARNING\CLC2\Year 2\Term 3\LT Window\Project\Project 2_SM\StudentManagement_log.ldf')
GO

use StudentManagement
go

create table GiaoVu (
    MaGiaoVu char(10) not null,
	SoCMND char(11) not null,
	HoTen nvarchar(100) not null,
	MatKhau varchar(255) not null,
	NgaySinh Date not null,
	DiaChi nvarchar(255) not null,
	GioiTinh nchar(3) not null,
	primary key (MaGiaoVu)
)

create table SinhVien (
	MSSV char(10) not null,
	SoCMND char(11) not null,
	HoTen nchar(100) not null,
	MatKhau varchar(255) not null,
	MaLop char(10),
	NgaySinh Date,
	DiaChi nvarchar(255),
	GioiTinh nchar(3) not null,
	primary key (MSSV)
)

create table LopHoc (
	MaLop char(10) not null,
	TenLop nvarchar(30) not null,
	primary key (MaLop)
)

create table TKB (
	MaLop char(10) not null,	
	MaMonHoc char(10) not null,
	HocKy char(10) not null, --Fall/Spring/Summer
	NamHoc char(9) not null,
	PhongHoc char(10),
	CongKhaiBangDiem char(1),
	primary key (MaLop, MaMonHoc, HocKy)
)

create table BangDiem (
	MSSV char(10) not null,
	MaLop char(10) not null,
	MaMonHoc char(10) not null,
	HocKy char(10) not null, --Fall/Spring/Summer
	DiemGiuaKy float,
	DiemCuoiKy float,
	DiemKhac float,
	DiemTong float,
	primary key (MSSV, MaLop, MaMonHoc, HocKy)
)
create table MonHoc (
	MaMonHoc char(10) not null,
	TenMonHoc char (100) not null,
	primary key (MaMonHoc)
)
go


alter table SinhVien
	add foreign key (MaLop) references LopHoc(MaLop)

alter table TKB
	add foreign key (MaLop) references LopHoc(MaLop)
alter table TKB
	add foreign key (MaMonHoc) references MonHoc(MaMonHoc)

alter table BangDiem
	add foreign key (MSSV) references SinhVien(MSSV)
alter table BangDiem
	add foreign key (MaLop, MaMonHoc, HocKy) references TKB(MaLop, MaMonHoc, HocKy)

go

INSERT INTO MONHOC VALUES
    ('CTT003',N'Nhập môn lập trình'),
    ('CTT009',N'Nhập môn công nghệ thông tin 1'),
    ('CTT123',N'Kỹ năng mềm'),
    ('TTH063',N'Toán rời rạc'),
    ('CTT008',N'Kỹ thuật lập trình'),
    ('KTH001',N'Kinh tế đại cương'),
    ('TTH026',N'Giải tích B1'),
    ('CTT001',N'Những nguyên lí cơ bản của chủ nghĩa Mác-Lênin'),
    ('CTT006',N'Phương pháp lập trình hướng đối tượng')


SELECT COUNT(MAGIAOVU)
FROM GIAOVU 
WHERE MAGIAOVU='giaovu1'

SELECT COUNT(MAGIAOVU)
FROM GIAOVU
WHERE MAGIAOVU='giaovu' AND MATKHAU='giaovu'

SELECT COUNT(MSSV) FROM SINHVIEN WHERE MSSV = '1753075' AND MATKHAU = '123'


SELECT MAGIAOVU, SOCMND, HOTEN, NGAYSINH, DIACHI, GIOITINH FROM GIAOVU WHERE MAGIAOVU = 'giaovu'

SELECT COUNT(*)
FROM SINHVIEN
WHERE MSSV='1753075' AND MATKHAU='01011999'

INSERT INTO LOPHOC VALUES ('17CLC2','17CLC2')