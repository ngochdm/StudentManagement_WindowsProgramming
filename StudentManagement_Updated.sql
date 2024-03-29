﻿create database StudentManagement

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
	TenMonHoc nvarchar (100) not null,
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
    ('CTT006',N'Phương pháp lập trình hướng đối tượng'),
    ('CTT303',N'Cơ sở trí tuệ nhân tạo'),
    ('PHY005',N'Vật lý đại cương'),
    ('CTT102',N'Cơ sở dữ liệu'),
    ('CTT501',N'Lập trình Windows')


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


--create table TKB (
--	MaLop char(10) not null,	
--	MaMonHoc char(10) not null,
--	HocKy char(10) not null, --Fall/Spring/Summer
--	NamHoc char(9) not null,
--	PhongHoc char(10),
--	CongKhaiBangDiem char(1),
--	primary key (MaLop, MaMonHoc, HocKy)
--)


--TKB(MaLop,MaMonHoc,HocKy,NamHoc,PhongHoc,CongKhaiBangDiem)
Insert into TKB values ('18apcs1','TTH063','Spring','2018','I44','0')

--MaMonHoc,TENMON,HocKy,NamHoc,PhongHoc
SELECT T.MAMONHOC, MH.TENMONHOC, T.HOCKY, T.NAMHOC, T.PHONGHOC, T.CONGKHAIBANGDIEM
FROM TKB T INNER JOIN MONHOC MH
ON (T.MaMonHoc = MH.MaMonHoc)
WHERE T.MALOP = '17CLC2'

--TenMon,MSSV,HocKy,DiemGK,DiemCK,DiemKhac,DiemTong
SELECT MH.TENMONHOC, BD.MSSV, BD.HOCKY, BD.DIEMGIUAKY, BD.DIEMCUOIKY, BD.DIEMKHAC, BD.DIEMTONG
FROM BangDiem BD INNER JOIN MONHOC MH
ON (BD.MAMONHOC = MH.MAMONHOC)
WHERE BD.MAMONHOC = 'TTH063' AND BD.MALOP = '17CLC2'


--create table BangDiem (
--	MSSV char(10) not null,
--	MaLop char(10) not null,
--	MaMonHoc char(10) not null,
--	HocKy char(10) not null, --Fall/Spring/Summer
--	DiemGiuaKy float,
--	DiemCuoiKy float,
--	DiemKhac float,
--	DiemTong float,
--	primary key (MSSV, MaLop, MaMonHoc, HocKy)
--)

SELECT BD.MSSV, SV.HOTEN, SV.SoCMND, SV.NGAYSINH, SV.GIOITINH, SV.DIACHI
FROM SINHVIEN SV INNER JOIN BANGDIEM BD 
ON (BD.MSSV = SV.MSSV)
WHERE BD.MALOP = '18CLC5' AND BD.MaMonHoc = 'TTH063'

INSERT INTO BANGDIEM(MSSV, MALOP, MAMONHOC, HOCKY) VALUES
('1953075','18CLC5','CTT003','SPRING')

UPDATE BANGDIEM
SET DIEMGIUAKY = 6.5, DIEMCUOIKY = 7.5, DIEMKHAC = 5.0, DIEMTONG = 7.0
WHERE MSSV = '1853075' AND MALOP = '18CLC6' AND MAMONHOC = 'TTH063' AND HOCKY = 'SUMMER'


--TKB(MaLop,MaMonHoc,HocKy,NamHoc,PhongHoc,CongKhaiBangDiem)
UPDATE TKB
SET PHONGHOC = 'B44', CONGKHAIBANGDIEM = '1'
WHERE MALOP = '18CLC6' AND MAMONHOC = 'TTH063' AND HOCKY = 'SUMMER'

DELETE FROM SINHVIEN
WHERE MSSV = '1753005'

DELETE FROM BANGDIEM
WHERE MSSV = '1753075' AND MALOP = '17CLC2' AND MAMONHOC = 'TTH063' AND HOCKY = 'SUMMER'

SELECT HOCKY
FROM TKB 
WHERE MALOP = '18CLC6' AND MAMONHOC = 'TTH063'


SELECT CONGKHAIBANGDIEM
FROM TKB
WHERE MALOP = '17CLC2' AND MAMONHOC = 'TTH063' AND HOCKY = 'SUMMER'

SELECT DIEMGIUAKY, DIEMCUOIKY, DIEMKHAC, DIEMTONG
FROM BANGDIEM 
WHERE MSSV = '1753075' AND MALOP = '17CLC2' AND MAMONHOC = 'TTH063' AND HOCKY = 'SUMMER'


UPDATE SINHVIEN SET MATKHAU = 'NGOCHDM' WHERE MSSV = '1753075'

SELECT MATKHAU
FROM SINHVIEN 
WHERE MSSV = '1753075'

UPDATE GIAOVU SET MATKHAU = '9C5E8ED003D1CCEBD3674E7040F844D6' WHERE MAGIAOVU = 'GIAOVU1'

SELECT MATKHAU
FROM GIAOVU
WHERE MAGIAOVU = 'GIAOVU1'

UPDATE SINHVIEN SET MATKHAU = '2A6D233A0A3637BEC984A59AEF1D8F2A ' WHERE MSSV = '45612'
