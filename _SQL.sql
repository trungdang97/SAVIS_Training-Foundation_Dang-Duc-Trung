USE [master]
GO
/****** Object:  Database [QuanLySinhVien]    Script Date: 3/29/2019 9:09:41 PM ******/
CREATE DATABASE [QuanLySinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySinhVien', FILENAME = N'E:\SQLServerMS\MSSQL13.SQLEXPRESS\MSSQL\DATA\QuanLySinhVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLySinhVien_log', FILENAME = N'E:\SQLServerMS\MSSQL13.SQLEXPRESS\MSSQL\DATA\QuanLySinhVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLySinhVien] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLySinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySinhVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLySinhVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLySinhVien] SET QUERY_STORE = OFF
GO
USE [QuanLySinhVien]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuanLySinhVien]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 3/29/2019 9:09:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](10) NULL,
	[AcademicYear] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/29/2019 9:09:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NULL,
	[Name] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[ClassId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ClassId], [Code], [AcademicYear], [Name], [Quantity]) VALUES (1, N'CNTT', 14, N'Công nghệ thông tin', NULL)
INSERT [dbo].[Class] ([ClassId], [Code], [AcademicYear], [Name], [Quantity]) VALUES (2, N'HTTT', 14, N'Hệ thống thông tin', NULL)
INSERT [dbo].[Class] ([ClassId], [Code], [AcademicYear], [Name], [Quantity]) VALUES (3, N'MMT', 14, N'Mạng máy tính', NULL)
INSERT [dbo].[Class] ([ClassId], [Code], [AcademicYear], [Name], [Quantity]) VALUES (4, N'CNPM', 14, N'Công nghệ phần mềm', NULL)
SET IDENTITY_INSERT [dbo].[Class] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (5, N'15150419', N'Đặng Đức Trung', CAST(N'1997-04-05' AS Date), 4)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (6, N'15152345', N'Đặng Đức Trung', CAST(N'1996-04-05' AS Date), 4)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (7, N'15152342', N'Đặng Văn Đức', CAST(N'1995-04-05' AS Date), 4)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (8, N'15159798', N'Nguyễn Thế An', CAST(N'1991-04-05' AS Date), 4)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (9, N'15157648', N'Đỗ Đình Hưng', CAST(N'1997-04-05' AS Date), 1)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (10, N'15157897', N'Phạm Hồng Sơn', CAST(N'1997-04-05' AS Date), 4)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (11, N'15151234', N'Nguyễn Văn An', CAST(N'1995-04-05' AS Date), 2)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (12, N'15159879', N'Phạm Mạnh Cường', CAST(N'1995-04-05' AS Date), 3)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (13, N'15153445', N'Bùi Đăng Cường', CAST(N'1998-04-05' AS Date), 2)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (14, N'15158988', N'Nguyễn Đức Thịnh', CAST(N'1999-04-05' AS Date), 2)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (15, N'15154534', N'Nguyễn Trung Kiên', CAST(N'1998-04-05' AS Date), 3)
INSERT [dbo].[Student] ([StudentId], [Code], [Name], [Birthday], [ClassId]) VALUES (16, N'15158979', N'Nguyễn Đăng Hiếu', CAST(N'1998-04-05' AS Date), 3)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [MalopKhoa]    Script Date: 3/29/2019 9:09:42 PM ******/
ALTER TABLE [dbo].[Class] ADD  CONSTRAINT [MalopKhoa] UNIQUE NONCLUSTERED 
(
	[Code] ASC,
	[AcademicYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SinhVien__939AE77474EFBB0E]    Script Date: 3/29/2019 9:09:42 PM ******/
ALTER TABLE [dbo].[Student] ADD UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Class]
GO
USE [master]
GO
ALTER DATABASE [QuanLySinhVien] SET  READ_WRITE 
GO
