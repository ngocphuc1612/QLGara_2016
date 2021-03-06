USE [master]
GO
/****** Object:  Database [QLGara]    Script Date: 12/1/2016 12:00:51 AM ******/
CREATE DATABASE [QLGara]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLGara', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLGara.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLGara_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLGara_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLGara].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLGara] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLGara] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLGara] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLGara] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLGara] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLGara] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLGara] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLGara] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLGara] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLGara] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLGara] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLGara] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLGara] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLGara] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLGara] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLGara] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLGara] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLGara] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLGara] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLGara] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLGara] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLGara] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLGara] SET RECOVERY FULL 
GO
ALTER DATABASE [QLGara] SET  MULTI_USER 
GO
ALTER DATABASE [QLGara] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLGara] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLGara] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLGara] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLGara', N'ON'
GO
USE [QLGara]
GO
/****** Object:  Table [dbo].[CACLOAIXE]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CACLOAIXE](
	[DONGXE_ID] [int] NOT NULL,
	[HIEU_XE] [int] NOT NULL,
	[SO_CUA] [tinyint] NULL,
	[SO_GHE] [tinyint] NULL,
	[HOP_SO] [varchar](50) NULL,
	[DAN_DONG] [varchar](50) NULL,
	[NHIEN_LIEU] [varchar](50) NULL,
	[KIEU_DANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_CACLOAIXE_1] PRIMARY KEY CLUSTERED 
(
	[DONGXE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[MAPN] [int] NOT NULL,
	[MAVT] [int] NOT NULL,
	[SLNHAP] [int] NULL,
	[TONGPHIEUNHAP] [money] NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUSUACHUA]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUSUACHUA](
	[MAPSC] [int] NOT NULL,
	[MAVT] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[NOIDUNG] [nvarchar](150) NULL,
	[DONGIA] [money] NULL,
 CONSTRAINT [PK_CT_PHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MAPSC] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ERROR]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ERROR](
	[ERROR_ID] [int] NOT NULL,
	[ERROR] [nvarchar](150) NULL,
	[MESSAGE] [nvarchar](150) NULL,
 CONSTRAINT [PK_ERROR] PRIMARY KEY CLUSTERED 
(
	[ERROR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HIEUXE]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIEUXE](
	[MAHX] [int] NOT NULL,
	[TENHX] [nvarchar](50) NULL,
 CONSTRAINT [PK_HIEUXE] PRIMARY KEY CLUSTERED 
(
	[MAHX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[KH_ID] [int] NOT NULL,
	[KH_TEN] [nvarchar](50) NULL,
	[KH_SDT] [varchar](50) NULL,
	[KH_EMAIL] [nvarchar](50) NULL,
	[KH_DIACHI] [nvarchar](50) NULL,
	[KH_NGAYSINH] [smalldatetime] NULL,
	[KH_GIOITINH] [bit] NULL,
	[KH_ROLE] [int] NULL,
	[KH_CONGNO] [money] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[KH_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[NCC_ID] [int] NOT NULL,
	[NCC_TEN] [nvarchar](50) NULL,
	[NCC_SDT] [nvarchar](50) NULL,
	[NCC_EMAIL] [nvarchar](50) NULL,
	[NCC_DIACHI] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[NCC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [int] NOT NULL,
	[NGAYNHAP] [smalldatetime] NULL,
	[TONGTIENNHAP] [money] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUSUACHUA]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUSUACHUA](
	[MAPSC] [int] NOT NULL,
	[BIENSO] [varchar](50) NULL,
	[USER_ID] [bigint] NULL,
	[NGAYSC] [smalldatetime] NULL,
	[MATC] [int] NULL,
	[TONGTT] [money] NULL,
 CONSTRAINT [PK_PHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MAPSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUTHANHTOAN]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHANHTOAN](
	[MAPTT] [int] NOT NULL,
	[MAPSC] [int] NOT NULL,
	[NGAYTT] [smalldatetime] NULL,
	[TONGTT] [money] NULL,
 CONSTRAINT [PK_PHIEUTHANHTOAN] PRIMARY KEY CLUSTERED 
(
	[MAPTT] ASC,
	[MAPSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PREFIX]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PREFIX](
	[PREFIX_ID] [int] NOT NULL,
	[VALUE] [int] NULL,
	[PREFIX] [varchar](50) NULL,
 CONSTRAINT [PK_PREFIX] PRIMARY KEY CLUSTERED 
(
	[PREFIX_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLES](
	[ROLE_ID] [tinyint] NOT NULL,
	[ROLE_NAME] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ROLE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIENCONG]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIENCONG](
	[MATC] [int] NOT NULL,
	[TENTC] [nvarchar](150) NULL,
	[GIATIEN] [money] NULL,
 CONSTRAINT [PK_TIENCONG] PRIMARY KEY CLUSTERED 
(
	[MATC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USERS]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[USER_ID] [bigint] NOT NULL,
	[USERNAME] [varchar](60) NULL,
	[EMAIL] [varchar](100) NULL,
	[PASS] [varchar](255) NULL,
	[ROLE_ID] [tinyint] NULL,
	[GENDER] [bit] NULL,
	[BIRTHDAY] [date] NULL,
	[FULL_NAME] [nvarchar](50) NULL,
	[PHONE] [varchar](15) NULL,
	[DIRECTION] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[USER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VATTU]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATTU](
	[MAVT] [int] NOT NULL,
	[TENVT] [nvarchar](50) NULL,
	[DONGIA] [money] NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_VATTU] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XE]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XE](
	[BIENSO] [varbinary](50) NOT NULL,
	[USER_ID] [bigint] NULL,
	[NGAYTN] [smalldatetime] NULL,
	[DONGXE_ID] [int] NULL,
	[MAU_XE] [int] NULL,
	[MOTA] [nvarchar](150) NULL,
	[MAU_NOI_THAT] [nvarchar](50) NULL,
	[NAM_XUAT_XU] [varchar](50) NULL,
	[XUAT_XU] [nvarchar](150) NULL,
 CONSTRAINT [PK_XE] PRIMARY KEY CLUSTERED 
(
	[BIENSO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME]) VALUES (1, N'Admin')
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME]) VALUES (2, N'Leader')
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME]) VALUES (3, N'Kế toán')
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME]) VALUES (4, N'Nhân viên')
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME]) VALUES (5, N'Khách hàng')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION]) VALUES (1, N'ngocphuc', N'ngocphuc@gmail.com', N'123456', 1, 1, CAST(N'1995-12-16' AS Date), N'Trần Ngọc Phúc', N'0123456789', N' KTX Khu B')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION]) VALUES (2, N'trinh', N'trinh@mail', N'123', 3, 1, CAST(N'2012-06-18' AS Date), N'Huu Trinh', N'012913123', N'BT')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION]) VALUES (3, N'ngocphuc3', N'12312', N'132', 1, 1, CAST(N'1995-12-20' AS Date), N'', N'', N'')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION]) VALUES (4, N'ngocphuc32', N'12312', N'132', 4, 1, CAST(N'1995-12-20' AS Date), N'', N'', N'')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION]) VALUES (5, N'ngo', N'feke', N'123', 3, 1, NULL, N'lsjfe', N'012312412', N'ktx')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION]) VALUES (6, N'ngocpjk', N'12312', N'132', 2, 1, CAST(N'1995-12-20' AS Date), N'', N'', N'')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DONGIA], [SL]) VALUES (1, N'Bánh', 200000.0000, 20)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DONGIA], [SL]) VALUES (2, N'Răng', 300000.0000, 30)
ALTER TABLE [dbo].[CACLOAIXE]  WITH CHECK ADD  CONSTRAINT [FK_CACLOAIXE_HIEUXE] FOREIGN KEY([HIEU_XE])
REFERENCES [dbo].[HIEUXE] ([MAHX])
GO
ALTER TABLE [dbo].[CACLOAIXE] CHECK CONSTRAINT [FK_CACLOAIXE_HIEUXE]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_VATTU] FOREIGN KEY([MAVT])
REFERENCES [dbo].[VATTU] ([MAVT])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_VATTU]
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUSUACHUA_PHIEUSUACHUA] FOREIGN KEY([MAPSC])
REFERENCES [dbo].[PHIEUSUACHUA] ([MAPSC])
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA] CHECK CONSTRAINT [FK_CT_PHIEUSUACHUA_PHIEUSUACHUA]
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUSUACHUA_VATTU] FOREIGN KEY([MAVT])
REFERENCES [dbo].[VATTU] ([MAVT])
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA] CHECK CONSTRAINT [FK_CT_PHIEUSUACHUA_VATTU]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHANHTOAN_PHIEUSUACHUA] FOREIGN KEY([MAPSC])
REFERENCES [dbo].[PHIEUSUACHUA] ([MAPSC])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN] CHECK CONSTRAINT [FK_PHIEUTHANHTOAN_PHIEUSUACHUA]
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD  CONSTRAINT [FK_USERS_ROLES] FOREIGN KEY([ROLE_ID])
REFERENCES [dbo].[ROLES] ([ROLE_ID])
GO
ALTER TABLE [dbo].[USERS] CHECK CONSTRAINT [FK_USERS_ROLES]
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD  CONSTRAINT [FK_XE_CACLOAIXE] FOREIGN KEY([DONGXE_ID])
REFERENCES [dbo].[CACLOAIXE] ([DONGXE_ID])
GO
ALTER TABLE [dbo].[XE] CHECK CONSTRAINT [FK_XE_CACLOAIXE]
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD  CONSTRAINT [FK_XE_USERS] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[USERS] ([USER_ID])
GO
ALTER TABLE [dbo].[XE] CHECK CONSTRAINT [FK_XE_USERS]
GO
/****** Object:  StoredProcedure [dbo].[SP_GETDATA]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GETDATA]
	@tableName varchar(128)
As
Begin
	Declare @sql nvarchar(max);
	Set @sql = N'Select * from ' + @tableName
	Exec sp_executesql @sql
End
GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOGIN]
	@username varchar(60),
	@pass varchar(255)
	AS
	BEGIN
		SELECT * FROM USERS WHERE (@username = USERNAME AND @pass = PASS)
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTER]    Script Date: 12/1/2016 12:00:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_REGISTER]
	@username varchar(60),
	@email varchar(100),
	@pass varchar(255),
	@role tinyint,
	@gender bit,
	@birthday date,
	@full_name nvarchar(50),
	@phone varchar(15),
	@direction text
	AS
	BEGIN
		DECLARE @count bigint
		set @count = (SELECT MAX(USER_ID) FROM USERS) + 1
		if (@username not in (select USERNAME FROM USERS))
		BEGIN
			insert into USERS values(@count, @username, @email, @pass, @role, @gender, @birthday, @full_name, @phone, @direction)
		END
		ELSE
		BEGIN
			rollback tran
			return -1
		END
	END
GO
USE [master]
GO
ALTER DATABASE [QLGara] SET  READ_WRITE 
GO
