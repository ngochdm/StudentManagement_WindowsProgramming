USE [master]
GO
/****** Object:  Database [StudentManagement]    Script Date: 8/18/2019 8:01:08 PM ******/
CREATE DATABASE [StudentManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentManagement', FILENAME = N'D:\LEARNING\CLC2\Year 2\Term 3\LT Window\Project\Project 2_SM\StudentManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentManagement_log', FILENAME = N'D:\LEARNING\CLC2\Year 2\Term 3\LT Window\Project\Project 2_SM\StudentManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StudentManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StudentManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StudentManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentManagement] SET QUERY_STORE = OFF
GO
USE [StudentManagement]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 8/18/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[MSSV] [char](10) NOT NULL,
	[MaLop] [char](10) NOT NULL,
	[MaMonHoc] [char](10) NOT NULL,
	[HocKy] [char](10) NOT NULL,
	[DiemGiuaKy] [float] NULL,
	[DiemCuoiKy] [float] NULL,
	[DiemKhac] [float] NULL,
	[DiemTong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC,
	[MaLop] ASC,
	[MaMonHoc] ASC,
	[HocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVu]    Script Date: 8/18/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVu](
	[MaGiaoVu] [char](10) NOT NULL,
	[SoCMND] [char](11) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[GioiTinh] [nchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaoVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 8/18/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[MaLop] [char](10) NOT NULL,
	[TenLop] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 8/18/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [char](10) NOT NULL,
	[TenMonHoc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 8/18/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MSSV] [char](10) NOT NULL,
	[SoCMND] [char](11) NOT NULL,
	[HoTen] [nchar](100) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
	[MaLop] [char](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[GioiTinh] [nchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TKB]    Script Date: 8/18/2019 8:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TKB](
	[MaLop] [char](10) NOT NULL,
	[MaMonHoc] [char](10) NOT NULL,
	[HocKy] [char](10) NOT NULL,
	[NamHoc] [char](9) NOT NULL,
	[PhongHoc] [char](10) NULL,
	[CongKhaiBangDiem] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[MaMonHoc] ASC,
	[HocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753005   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 4)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753005   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753005   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753008   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753008   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753008   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753008   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753023   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753023   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 4)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753023   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753023   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753063   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753063   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753063   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753063   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753064   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753064   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753064   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753064   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753065   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753065   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753065   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753065   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753067   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753067   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753067   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753067   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753068   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753068   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753068   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753068   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753069   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753069   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 4)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753069   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753069   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753070   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753070   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753070   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753070   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753071   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753071   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753071   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753071   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753072   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753072   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753072   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753072   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753073   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753073   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753073   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753073   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753074   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753074   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753074   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753074   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753075   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', 7, 7, 7, 7)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753075   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753075   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753075   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753076   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753076   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753076   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753076   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753077   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753077   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753077   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753077   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753078   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753078   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753078   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753078   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753079   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753079   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753079   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753079   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753081   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753081   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753081   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753081   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753082   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753082   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753082   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753082   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753083   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753083   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753083   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753083   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753084   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753084   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753084   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753084   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753085   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753085   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753085   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753085   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753086   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753086   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753086   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753086   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753087   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753087   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753087   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753087   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753089   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753089   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753089   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753089   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753090   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753090   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753090   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753090   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753091   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753091   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 4)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753091   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753091   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753093   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753093   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753093   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753093   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753094   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753094   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753094   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753094   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753095   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753095   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 4)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753095   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753095   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753096   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753096   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753096   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753096   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753134   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753134   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753134   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753134   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753135   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753135   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753135   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753135   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753136   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753136   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 4)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753136   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753136   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753137   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753137   ', N'17CLC2    ', N'CTT303    ', N'Spring    ', 0, 0, 0, 10)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753137   ', N'17CLC2    ', N'CTT501    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1753137   ', N'17CLC2    ', N'PHY00005  ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1853075   ', N'17CLC2    ', N'CTT102    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1853075   ', N'18CLC5    ', N'CTT003    ', N'Spring    ', 5, 5, 5, 5)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1853075   ', N'18CLC6    ', N'CTT003    ', N'Spring    ', 1, 2, 3, 4)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1853075   ', N'18CLC6    ', N'TTH063    ', N'Summer    ', 8, 8, 9, 8.5)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1863045   ', N'18CLC5    ', N'CTT003    ', N'Spring    ', 6, 6, 6, 6)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1863045   ', N'18CLC6    ', N'CTT003    ', N'Spring    ', 5, 6, 7, 8)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1863045   ', N'18CLC6    ', N'CTT008    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1863045   ', N'18CLC6    ', N'CTT009    ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1863045   ', N'18CLC6    ', N'TTH063    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953075   ', N'18APCS1   ', N'CTT001    ', N'Spring    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953075   ', N'18APCS1   ', N'CTT001    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953075   ', N'18APCS1   ', N'CTT003    ', N'Spring    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953075   ', N'18APCS1   ', N'CTT009    ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953075   ', N'18CLC5    ', N'CTT003    ', N'SPRING    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953075   ', N'18CLC5    ', N'TTH063    ', N'Summer    ', 9, 9, 9, 9)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953095   ', N'18APCS1   ', N'CTT001    ', N'Spring    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953095   ', N'18APCS1   ', N'CTT001    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953095   ', N'18APCS1   ', N'CTT003    ', N'Spring    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953095   ', N'18APCS1   ', N'CTT009    ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'1953095   ', N'18CLC5    ', N'CTT003    ', N'Spring    ', 7, 7, 7, 7)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'45612     ', N'18APCS1   ', N'CTT001    ', N'Spring    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'45612     ', N'18APCS1   ', N'CTT001    ', N'Summer    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'45612     ', N'18APCS1   ', N'CTT003    ', N'Spring    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'45612     ', N'18APCS1   ', N'CTT009    ', N'Fall      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MSSV], [MaLop], [MaMonHoc], [HocKy], [DiemGiuaKy], [DiemCuoiKy], [DiemKhac], [DiemTong]) VALUES (N'45612     ', N'18CLC5    ', N'CTT003    ', N'Spring    ', 1, 2, 5, 3)
INSERT [dbo].[GiaoVu] ([MaGiaoVu], [SoCMND], [HoTen], [MatKhau], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'giaovu    ', N'12346578   ', N'Đây là Giáo Vụ', N'9C5E8ED003D1CCEBD3674E7040F844D6', CAST(N'1980-01-10' AS Date), N'Địa chỉ Giáo Vụ', N'Nữ ')
INSERT [dbo].[GiaoVu] ([MaGiaoVu], [SoCMND], [HoTen], [MatKhau], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'giaovu1   ', N'45678912   ', N'Tôi là Giáo Vụ', N'9C5E8ED003D1CCEBD3674E7040F844D6', CAST(N'1970-10-01' AS Date), N'Đây là địa chỉ của tôi', N'Nam')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop]) VALUES (N'17CLC2    ', N'17CLC2')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop]) VALUES (N'17CLC3    ', N'17CLC3')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop]) VALUES (N'18apcs1   ', N'K18 Tiên tiến 1')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop]) VALUES (N'18CLC5    ', N'18CLC5')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop]) VALUES (N'18CLC6    ', N'K18 Chất lượng cao 6')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop]) VALUES (N'18VP1     ', N'K18 Việt Pháp 1')
INSERT [dbo].[LopHoc] ([MaLop], [TenLop]) VALUES (N'19CLC1    ', N'K19 Chất lượng cao 1')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT001    ', N'Những nguyên lí cơ bản của chủ nghĩa Mác-Lênin')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT003    ', N'Nhập môn lập trình')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT006    ', N'Phương pháp lập trình hướng đối tượng')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT008    ', N'Kỹ thuật lập trình')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT009    ', N'Nhập môn công nghệ thông tin 1')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT102    ', N'Cơ sở dữ liệu')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT123    ', N'Kỹ năng mềm')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT303    ', N'Cơ sở trí tuệ nhân tạo')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'CTT501    ', N'Lập trình Windows')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'KTH001    ', N'Kinh tế đại cương')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'PHY00005  ', N'Vật lý đại cương')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'PHY005    ', N'Vật lý đại cương')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'TTH026    ', N'Giải tích B1')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'TTH030    ', N'Giải tích B2')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'TTH063    ', N'Toán rời rạc')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753005   ', N'000000000  ', N'Bùi Minh Khoa                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753008   ', N'000000001  ', N'Phạm Huỳnh Nhật                                                                                     ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753012   ', N'000000037  ', N'"Nguyễn Phi Thăng"                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753014   ', N'000000038  ', N'"Cao Trọng Tín"                                                                                     ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753016   ', N'000000039  ', N'"Nguyễn Hoàng Ngọc Trân"                                                                            ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753017   ', N'000000040  ', N'"Nguyễn Hữu Tuấn"                                                                                   ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753020   ', N'000000041  ', N'"Nguyễn Dương Trí"                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753023   ', N'000000002  ', N'Tạ Thiện Phúc                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753063   ', N'000000003  ', N'Cao Duy Khiêm                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753064   ', N'000000004  ', N'Chu Bách Khoa                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753065   ', N'000000005  ', N'Nguyễn Nhật Khoa                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753067   ', N'000000006  ', N'Nguyễn Trung Kiên                                                                                   ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753068   ', N'000000007  ', N'Nguyễn Tuấn Long                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753069   ', N'000000008  ', N'Hoàng Hùng Mạnh                                                                                     ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753070   ', N'000000009  ', N'Hứa Anh Minh                                                                                        ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753071   ', N'000000010  ', N'Hương Đạt Minh                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753072   ', N'000000011  ', N'Trương Nhật Minh                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753073   ', N'000000012  ', N'Trương Thuận Nam                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753074   ', N'000000013  ', N'Nguyễn Kim Ngân                                                                                     ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753075   ', N'000000014  ', N'Huỳnh Đoàn Minh Ngọc                                                                                ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753076   ', N'000000015  ', N'Bùi Khánh Nguyên                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753077   ', N'000000016  ', N'Bùi Minh Nguyên                                                                                     ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753078   ', N'000000017  ', N'Nguyễn Khôi Nguyên                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753079   ', N'000000018  ', N'Nguyễn Võ Nhân                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753081   ', N'000000019  ', N'Trần Lê Hồng Nhi                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753082   ', N'000000020  ', N'Ngô Văn Phát                                                                                        ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753083   ', N'000000021  ', N'Nguyễn Hưng Phát                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753084   ', N'000000022  ', N'Võ Quang Phú                                                                                        ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753085   ', N'000000023  ', N'Nguyễn Công Phúc                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753086   ', N'000000024  ', N'Tống Lê Thiên Phúc                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753087   ', N'000000025  ', N'Nguyễn Tuấn Phùng                                                                                   ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753089   ', N'000000026  ', N'Nguyễn Lý Nhật Phương                                                                               ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753090   ', N'000000027  ', N'Lê Văn Pôn                                                                                          ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753091   ', N'000000028  ', N'Võ Duy Quan                                                                                         ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753093   ', N'000000029  ', N'Hồ Bùi Văn Quang                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753094   ', N'000000030  ', N'Vũ Phùng Quang                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753095   ', N'000000031  ', N'Tăng Nhân Quí                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753096   ', N'000000032  ', N'Phùng Thanh Sang                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753097   ', N'000000042  ', N'"Lê Nguyễn Minh Tâm"                                                                                ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753098   ', N'000000043  ', N'"Lương Minh Tâm"                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753099   ', N'000000044  ', N'"Nguyễn Duy Tân"                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753101   ', N'000000045  ', N'"Lê Hồng Thái"                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753102   ', N'000000046  ', N'"Bùi Quang Thắng"                                                                                   ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753103   ', N'000000047  ', N'"Ngô Việt Thắng"                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753104   ', N'000000048  ', N'"Trần Thuận Thành"                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753105   ', N'000000049  ', N'"Lê Tấn Thịnh"                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753107   ', N'000000050  ', N'"Nguyễn Đức Thông"                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753109   ', N'000000051  ', N'"Phùng Trần Minh Thương"                                                                            ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753110   ', N'000000052  ', N'"Nguyễn Hữu  Tiến"                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753111   ', N'000000053  ', N'"Nguyễn Thị Hoàng Trang"                                                                            ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753113   ', N'000000054  ', N'"Nguyễn Trọng Triết"                                                                                ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753114   ', N'000000055  ', N'"Nhan Minh Triết"                                                                                   ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753115   ', N'000000056  ', N'"Ngô Thanh Trúc"                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753116   ', N'000000057  ', N'"Đặng Đức Trung"                                                                                    ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753118   ', N'000000058  ', N'"Nguyễn Thanh Trường"                                                                               ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753120   ', N'000000059  ', N'"Phạm Thanh Tú"                                                                                     ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753121   ', N'000000060  ', N'"Lê Hữu Minh Tuấn"                                                                                  ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753123   ', N'000000061  ', N'"Phạm Hoàng Anh Tuấn"                                                                               ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753124   ', N'000000062  ', N'"Nguyễn Nhật Tường"                                                                                 ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753125   ', N'000000063  ', N'"Nguyễn Quốc Ngọc Tường"                                                                            ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753126   ', N'000000064  ', N'"Nguyễn Ngọc Bích Uyên"                                                                             ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753127   ', N'000000065  ', N'"Cao Đình Vĩ"                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753128   ', N'000000066  ', N'"Lê Quốc Việt"                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753129   ', N'000000067  ', N'"Nguyễn Hoàng Việt"                                                                                 ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753130   ', N'000000068  ', N'"Đoàn Triệu Vĩnh"                                                                                   ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753131   ', N'000000069  ', N'"Nguyễn Vương Đạt Vũ"                                                                               ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753132   ', N'000000070  ', N'"Võ Khánh Vy"                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753133   ', N'000000071  ', N'"Mai Bảo Trân"                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753134   ', N'000000033  ', N'Nguyễn Ngọc Đăng Khanh                                                                              ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753135   ', N'000000034  ', N'Lý Thanh Long                                                                                       ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753136   ', N'000000035  ', N'Trần Vĩnh Phúc                                                                                      ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753137   ', N'000000036  ', N'Lê Minh Quân                                                                                        ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC2    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1753139   ', N'000000072  ', N'"Trương Trần Hải Yến"                                                                               ', N'38B7F4ECEE85BCDFE60CAC7A1998FB33', N'17CLC3    ', CAST(N'1999-01-01' AS Date), N'Address', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1853075   ', N'100110     ', N'Thiago Messi                                                                                        ', N'F9EC9D60BB6A5C3A4CE5C54A28DDC499', N'18CLC6    ', CAST(N'2003-03-20' AS Date), N'Thành phố Barcelona, xứ Cataluyna, Tây Ban Nha.', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1853085   ', N'258963147  ', N'Mateo Messi                                                                                         ', N'07F9282006344E8144044D45AC237F48', N'18clc6    ', CAST(N'2005-02-28' AS Date), N'Barcelona, Spain', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1853965   ', N'46523      ', N'HelloWorld ABC                                                                                      ', N'2A6D233A0A3637BEC984A59AEF1D8F2A', N'18VP1     ', CAST(N'2001-01-30' AS Date), N'The Earth', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1863045   ', N'5623145    ', N'Ciro Messi                                                                                          ', N'02907AA200093AFD3EDD56D81A050B31', N'18CLC6    ', CAST(N'2010-10-30' AS Date), N'Barcelona, Catalunya, Spain', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1913075   ', N'123456     ', N'Nobi Nobita                                                                                         ', N'BDD7F5483457F996A76BE6DF8DECA6C3', N'19CLC1    ', CAST(N'2000-08-16' AS Date), N'Thủ đô Tokyo, Nhật Bản', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1953075   ', N'4512456    ', N'Doraemon DoReMon                                                                                    ', N'27BFB93713F4440CC23F3CB32C4327CB', N'18APCS1   ', CAST(N'2000-05-20' AS Date), N'Thủ đô ToKyo, Nhật Bản', N'Nam')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1953095   ', N'123465     ', N'Ahihi                                                                                               ', N'87445A96EEEB501F1AF90DAA0ACB5CC8', N'18apcs1   ', CAST(N'2001-01-20' AS Date), N'Trai Dat', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'1957421   ', N'45678912   ', N'Shizuka                                                                                             ', N'29860042E15E50F6CF3D7E0C0B52D2A4', N'19CLC1    ', CAST(N'1999-07-14' AS Date), N'Nhật Bản', N'Nữ ')
INSERT [dbo].[SinhVien] ([MSSV], [SoCMND], [HoTen], [MatKhau], [MaLop], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (N'45612     ', N'123456     ', N'Hello World                                                                                         ', N'2A6D233A0A3637BEC984A59AEF1D8F2A ', N'18apcs1   ', CAST(N'2001-01-30' AS Date), N'Trái Đất, Hệ Mặt Trời', N'Nữ ')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'17CLC2    ', N'CTT102    ', N'Summer    ', N'2019     ', N'B11A      ', N'1')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'17CLC2    ', N'CTT303    ', N'Spring    ', N'2019     ', N'F203      ', N'1')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'17CLC2    ', N'CTT501    ', N'Summer    ', N'2019     ', N'I.42      ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'17CLC2    ', N'PHY00005  ', N'Fall      ', N'2019     ', N'I.32      ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18APCS1   ', N'CTT001    ', N'Spring    ', N'2019     ', N'B.11A     ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18APCS1   ', N'CTT001    ', N'Summer    ', N'2019     ', N'I.42      ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18APCS1   ', N'CTT003    ', N'Spring    ', N'2019     ', N'F203      ', N'1')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18APCS1   ', N'CTT009    ', N'Fall      ', N'2019     ', N'I.32      ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18apcs1   ', N'TTH063    ', N'Spring    ', N'2018     ', N'I44       ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC5    ', N'CTT003    ', N'Spring    ', N'2019     ', N'F203      ', N'1')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC5    ', N'CTT008    ', N'Summer    ', N'2019     ', N'B.11A     ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC5    ', N'CTT009    ', N'Fall      ', N'2019     ', N'I.32      ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC5    ', N'CTT123    ', N'Summer    ', N'2019     ', N'I71       ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC5    ', N'TTH063    ', N'Summer    ', N'2019     ', N'I.42      ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC6    ', N'CTT003    ', N'Spring    ', N'2019     ', N'F203      ', N'1')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC6    ', N'CTT008    ', N'Summer    ', N'2019     ', N'B.11A     ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC6    ', N'CTT009    ', N'Fall      ', N'2019     ', N'I.32      ', N'0')
INSERT [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy], [NamHoc], [PhongHoc], [CongKhaiBangDiem]) VALUES (N'18CLC6    ', N'TTH063    ', N'Summer    ', N'2019     ', N'B44       ', N'1')
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD FOREIGN KEY([MaLop], [MaMonHoc], [HocKy])
REFERENCES [dbo].[TKB] ([MaLop], [MaMonHoc], [HocKy])
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD FOREIGN KEY([MSSV])
REFERENCES [dbo].[SinhVien] ([MSSV])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[TKB]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[TKB]  WITH CHECK ADD FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
USE [master]
GO
ALTER DATABASE [StudentManagement] SET  READ_WRITE 
GO
