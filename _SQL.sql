USE [master]
GO
/****** Object:  Database [QuanLySinhVien]    Script Date: 3/29/2019 9:09:41 PM ******/
CREATE DATABASE [QuanLySinhVien]
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
