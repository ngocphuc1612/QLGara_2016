USE [QLGara]
GO
/****** Object:  Table [dbo].[CACLOAIXE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CACLOAIXE](
	[DONGXE_ID] [varchar](50) NOT NULL,
	[HIEU_XE] [varchar](50) NOT NULL,
	[THONG_SO_KY_THUAT] [nvarchar](max) NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_CACLOAIXE_1] PRIMARY KEY CLUSTERED 
(
	[DONGXE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[MAPN] [int] NOT NULL,
	[MAVT] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [money] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUSUACHUA]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUSUACHUA](
	[MAPSC] [int] NOT NULL,
	[MAVT] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [money] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_CT_PHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MAPSC] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[KH_ID] [int] NOT NULL,
	[KH_TEN] [nvarchar](50) NULL,
	[KH_SDT] [varchar](15) NULL,
	[KH_EMAIL] [nvarchar](50) NULL,
	[KH_DIACHI] [nvarchar](200) NULL,
	[KH_NGAYSINH] [smalldatetime] NULL,
	[KH_GIOITINH] [bit] NULL,
	[KH_CONGNO] [money] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[KH_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[NCC_ID] [int] NOT NULL,
	[NCC_TEN] [nvarchar](50) NULL,
	[NCC_SDT] [nvarchar](15) NULL,
	[NCC_EMAIL] [nvarchar](50) NULL,
	[NCC_DIACHI] [nvarchar](200) NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[NCC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [int] NOT NULL,
	[NGAYNHAP] [smalldatetime] NULL,
	[TONGTIENNHAP] [money] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUSUACHUA]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUSUACHUA](
	[MAPSC] [int] NOT NULL,
	[BIENSO] [varchar](50) NULL,
	[USER_ID] [int] NULL,
	[NGAYSC] [smalldatetime] NULL,
	[TONGTIEN] [money] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_PHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[MAPSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUTHANHTOAN]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUTHANHTOAN](
	[MAPTT] [int] NOT NULL,
	[MAPSC] [int] NOT NULL,
	[NGAYTT] [smalldatetime] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_PHIEUTHANHTOAN] PRIMARY KEY CLUSTERED 
(
	[MAPTT] ASC,
	[MAPSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROLES](
	[ROLE_ID] [tinyint] NOT NULL,
	[ROLE_NAME] [nvarchar](50) NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ROLE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[USER_ID] [bigint] NOT NULL,
	[USERNAME] [varchar](60) NULL,
	[EMAIL] [varchar](50) NULL,
	[PASS] [varchar](255) NULL,
	[ROLE_ID] [tinyint] NULL,
	[GENDER] [bit] NULL,
	[BIRTHDAY] [date] NULL,
	[FULL_NAME] [nvarchar](50) NULL,
	[PHONE] [varchar](15) NULL,
	[DIRECTION] [text] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK__USERS__F3BEEBFF720782A7] PRIMARY KEY CLUSTERED 
(
	[USER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VATTU]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VATTU](
	[MAVT] [int] NOT NULL,
	[TENVT] [nvarchar](50) NULL,
	[DONGIA] [money] NULL,
	[SL] [int] NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_VATTU] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XE](
	[BIENSO] [varchar](50) NOT NULL,
	[USER_ID] [int] NULL,
	[NGAYTN] [smalldatetime] NULL,
	[DONGXE_ID] [varchar](50) NULL,
	[MAU_XE] [nvarchar](50) NULL,
	[MOTA] [nvarchar](1000) NULL,
	[MAU_NOI_THAT] [nvarchar](50) NULL,
	[NAM_XUAT_XU] [varchar](50) NULL,
	[XUAT_XU] [nvarchar](150) NULL,
	[NGAY_TAO] [smalldatetime] NULL,
	[NGAY_CN_CUOI] [smalldatetime] NULL,
	[TRANG_THAI] [char](10) NULL,
 CONSTRAINT [PK_XE] PRIMARY KEY CLUSTERED 
(
	[BIENSO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CACLOAIXE] ([DONGXE_ID], [HIEU_XE], [THONG_SO_KY_THUAT], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (N'DIao', N'Audi', N'23 mã lực', NULL, CAST(N'2017-01-03 22:27:00' AS SmallDateTime), NULL)
INSERT [dbo].[CACLOAIXE] ([DONGXE_ID], [HIEU_XE], [THONG_SO_KY_THUAT], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (N'SIA', N'Mercedes', N'mã lực 999', CAST(N'2017-01-03 21:41:00' AS SmallDateTime), CAST(N'2017-01-03 22:27:00' AS SmallDateTime), N'active    ')
INSERT [dbo].[CACLOAIXE] ([DONGXE_ID], [HIEU_XE], [THONG_SO_KY_THUAT], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (N'Xiao', N'1', N'2 mã lực', NULL, NULL, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, 1, 2, 400000.0000, NULL, NULL, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([MAPN], [MAVT], [SOLUONG], [DONGIA], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, 2, 3, 600000.0000, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_TEN], [KH_SDT], [KH_EMAIL], [KH_DIACHI], [KH_NGAYSINH], [KH_GIOITINH], [KH_CONGNO], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, N'PPh', N'0123011', N'th@gmail.com', N'Hàm liêm', CAST(N'1995-09-02 00:00:00' AS SmallDateTime), 1, 0.0000, NULL, NULL, NULL)
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_TEN], [KH_SDT], [KH_EMAIL], [KH_DIACHI], [KH_NGAYSINH], [KH_GIOITINH], [KH_CONGNO], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (2222, N'Hkkd', N'0121312', N'kt@gmail.com', N'Bắc Bình', CAST(N'1994-09-02 00:00:00' AS SmallDateTime), 1, 0.0000, NULL, NULL, NULL)
INSERT [dbo].[NHACUNGCAP] ([NCC_ID], [NCC_TEN], [NCC_SDT], [NCC_EMAIL], [NCC_DIACHI], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1001, N'TOYOTA', N'65498292', N'contact@toyota.com', N'HCM', NULL, NULL, N'active    ')
INSERT [dbo].[NHACUNGCAP] ([NCC_ID], [NCC_TEN], [NCC_SDT], [NCC_EMAIL], [NCC_DIACHI], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1002, N'LEXUS', N'23484665', N'contact@lexus.com', N'HCM', NULL, NULL, N'active    ')
INSERT [dbo].[NHACUNGCAP] ([NCC_ID], [NCC_TEN], [NCC_SDT], [NCC_EMAIL], [NCC_DIACHI], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1003, N'NISSAN', N'26541234', N'contact@nissan.com', N'HCM', NULL, NULL, N'active    ')
INSERT [dbo].[NHACUNGCAP] ([NCC_ID], [NCC_TEN], [NCC_SDT], [NCC_EMAIL], [NCC_DIACHI], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1004, N'HONDA', N'241890210', N'contact@honda.com.vn', N'Hồ Chí Minh', NULL, NULL, N'active    ')
INSERT [dbo].[NHACUNGCAP] ([NCC_ID], [NCC_TEN], [NCC_SDT], [NCC_EMAIL], [NCC_DIACHI], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1005, N'MAZDA', N'128319023', N'contact@mazda.com', N'Bình Dương', NULL, NULL, N'active    ')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [NGAYNHAP], [TONGTIENNHAP], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, CAST(N'2016-05-12 00:00:00' AS SmallDateTime), 1000000.0000, NULL, NULL, NULL)
INSERT [dbo].[PHIEUSUACHUA] ([MAPSC], [BIENSO], [USER_ID], [NGAYSC], [TONGTIEN], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, N'87-b12122', 2222, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), 1000000.0000, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[PHIEUSUACHUA] ([MAPSC], [BIENSO], [USER_ID], [NGAYSC], [TONGTIEN], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (2, N'87-b12122', 1, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), 200000000.0000, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), NULL, NULL)
INSERT [dbo].[PHIEUTHANHTOAN] ([MAPTT], [MAPSC], [NGAYTT], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, 2, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), CAST(N'2017-01-04 00:00:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[PHIEUTHANHTOAN] ([MAPTT], [MAPSC], [NGAYTT], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (2, 1, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), CAST(N'2017-01-04 00:00:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, N'Admin', NULL, NULL, NULL)
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (2, N'Leader', NULL, NULL, NULL)
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (3, N'Kế toán', NULL, NULL, NULL)
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (4, N'Nhân viên', NULL, NULL, NULL)
INSERT [dbo].[ROLES] ([ROLE_ID], [ROLE_NAME], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (5, N'Khách hàng', NULL, NULL, NULL)
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, N'ngocphuc', N'ngocphuc@gmail.com', N'1', 1, 1, CAST(N'1995-12-16' AS Date), N'Trần Ngọc Phúc', N'0123456789', N' KTX Khu B', NULL, NULL, NULL)
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (2, N'trinh', N'trinh@mail', N'1', 3, 1, CAST(N'2012-06-18' AS Date), N'Huu Trinh', N'012913123', N'BT', NULL, NULL, NULL)
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (3, N'ngocphuc3', N'12312', N'132', 1, 1, CAST(N'1995-12-20' AS Date), N'', N'', N'', NULL, NULL, NULL)
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (4, N'ngocpjk', N'12312', N'132', 2, 0, CAST(N'1995-12-20' AS Date), N'', N'', N'', NULL, NULL, NULL)
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (5, N'ngocphuc1', N'12@gmail.com', N'1', 5, 1, CAST(N'2017-01-04' AS Date), N'Phúc', N'012312231', N'Phan Thi?t', CAST(N'2017-01-04 20:32:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (6, N'phuc', N'ngocphuc@gmail.com', N'1', 1, 1, CAST(N'1992-12-16' AS Date), N'Ngọc Phúc', N'01212421', N'Phan Thi?t', CAST(N'2017-01-04 20:36:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[USERS] ([USER_ID], [USERNAME], [EMAIL], [PASS], [ROLE_ID], [GENDER], [BIRTHDAY], [FULL_NAME], [PHONE], [DIRECTION], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (7, N'cuong', N'cuong@gmail.com', N'1', 1, 1, CAST(N'2017-01-04' AS Date), N'Cường', N'10012031020', N'Phan Thi?t', CAST(N'2017-01-04 21:22:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DONGIA], [SL], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (1, N'Bánh', 300000.0000, 20, NULL, NULL, NULL)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DONGIA], [SL], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (2, N'Răng', 300000.0000, 30, NULL, NULL, NULL)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DONGIA], [SL], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (3, N'Má phanh', 5000000.0000, 20, NULL, CAST(N'2017-01-04 21:28:00' AS SmallDateTime), NULL)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DONGIA], [SL], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (4, N'Lọc gió', 400000.0000, 20, NULL, NULL, NULL)
INSERT [dbo].[VATTU] ([MAVT], [TENVT], [DONGIA], [SL], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (5, N'Phanh trước', 300000.0000, 20, CAST(N'2017-01-04 21:32:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[XE] ([BIENSO], [USER_ID], [NGAYTN], [DONGXE_ID], [MAU_XE], [MOTA], [MAU_NOI_THAT], [NAM_XUAT_XU], [XUAT_XU], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (N'47l1-15347', 1, CAST(N'2017-01-05 02:17:00' AS SmallDateTime), N'SIA', N'Black', N'good', N'255, 255, 0', N'2014', N'VietNam', CAST(N'2017-01-05 02:17:00' AS SmallDateTime), NULL, N'active    ')
INSERT [dbo].[XE] ([BIENSO], [USER_ID], [NGAYTN], [DONGXE_ID], [MAU_XE], [MOTA], [MAU_NOI_THAT], [NAM_XUAT_XU], [XUAT_XU], [NGAY_TAO], [NGAY_CN_CUOI], [TRANG_THAI]) VALUES (N'87-b12122', 2222, CAST(N'2017-01-05 02:23:00' AS SmallDateTime), N'DIao', N'95, 73, 122', N'Nothing', N'36, 64, 97', N'2001', N'Hàn Quốc', CAST(N'2017-01-04 23:03:00' AS SmallDateTime), CAST(N'2017-01-05 02:23:00' AS SmallDateTime), N'active    ')
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
ALTER TABLE [dbo].[PHIEUSUACHUA]  WITH CHECK ADD  CONSTRAINT [FK_PSC_XE] FOREIGN KEY([BIENSO])
REFERENCES [dbo].[XE] ([BIENSO])
GO
ALTER TABLE [dbo].[PHIEUSUACHUA] CHECK CONSTRAINT [FK_PSC_XE]
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
/****** Object:  StoredProcedure [dbo].[SP_DEL_DONGXE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DEL_DONGXE]
	@id varchar(50)
	AS
	BEGIN
		DELETE FROM CACLOAIXE WHERE DONGXE_ID = @id
	END

GO
/****** Object:  StoredProcedure [dbo].[SP_DEL_HIEUXE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DEL_HIEUXE]
	@maHx int
	as
	begin
		delete from HIEUXE where MAHX = @maHx
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_DEL_KHACHHANG]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DEL_KHACHHANG]
	@id int
	AS
	BEGIN
		DELETE FROM KHACHHANG WHERE KH_ID = @id
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_DEL_USER]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DEL_USER]
	@username varchar(50)
	as
	begin
		DELETE FROM USERS WHERE USERNAME = @username
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_DEL_VATTU]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DEL_VATTU]
	@maVt int
	AS
	BEGIN
		DELETE FROM VATTU WHERE MAVT = @maVt
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_DEL_XE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DEL_XE]
	@bs varchar(50)
	AS
	BEGIN
		DELETE FROM XE WHERE BIENSO = @bs
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETALL_PHIEUTT]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GETALL_PHIEUTT]
	@content varchar(10)
	as
	begin
		select B.MAPTT, A.MAPSC, B.NGAYTT, A.BIENSO, A.TONGTIEN
		from PHIEUSUACHUA A, PHIEUTHANHTOAN B
		where A.MAPSC = B.MAPSC
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_GETDATA]    Script Date: 05/01/2017 5:15:37 SA ******/
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
/****** Object:  StoredProcedure [dbo].[SP_INSERT_DONGXE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_DONGXE]
	@id varchar(50),
	@hieuXe int,
	@tskt nvarchar(max)
	AS
	BEGIN
		INSERT INTO CACLOAIXE VALUES(@id, @hieuXe, @tskt, GETDATE(), null, 'active')
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_HIEUXE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_HIEUXE]
	@maHx int,
	@tenHx nvarchar(50)
	as
	begin
		DECLARE @date smalldatetime
		set @date = GETDATE()
		insert into HIEUXE values(@maHx, @tenHx, @date, null, 'active')
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_KHACHHANG]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_KHACHHANG]
	@id int,
	@ten nvarchar(50),
	@sdt varchar(15),
	@email nvarchar(50),
	@diaChi nvarchar(200),
	@ngaySinh smalldatetime,
	@gender bit,
	@congNo money
	AS
	BEGIN
		INSERT INTO KHACHHANG VALUES(@id, @ten, @sdt, @email, @diaChi, @ngaySinh, @gender, @congNo, GETDATE(), null, 'active')
	END

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_VATTU]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_VATTU]
	@maVt int,
	@tenVt nvarchar(50),
	@donGia money,
	@sl int
	AS
	BEGIN
		INSERT INTO VATTU VALUES(@maVt, @tenVt, @donGia, @sl, GETDATE(), null, 'active')
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_XE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_XE]
	@bs varchar(50),
	@userId int,
	@ngayTN smalldatetime,
	@dongXeId varchar(50),
	@mau nvarchar(50),
	@mota nvarchar(1000),
	@mauTrong nvarchar(50),
	@namXX varchar(50),
	@xuatXu nvarchar(50)
	AS
	BEGIN
		INSERT INTO XE VALUES(@bs, @userId, @ngayTN, @dongXeId, @mau, @mota, @mauTrong, @namXX, @xuatXu, GETDATE(), null, 'active')
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 05/01/2017 5:15:37 SA ******/
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
/****** Object:  StoredProcedure [dbo].[SP_REGISTER]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_REGISTER]
	@username varchar(60),
	@email varchar(50),
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
			insert into USERS values(@count, @username, @email, @pass, @role, @gender, @birthday, @full_name, @phone, @direction, GETDATE(), null, 'active')
		END
		ELSE
		BEGIN
			rollback tran
			return -1
		END
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_SEARCH_USER]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SEARCH_USER]
	@content varchar(20)
	as
	begin
		declare @searchString varchar(22)
		set @searchString = '%' + @content + '%'
		select * from USERS
		where (USERNAME like @searchString) or (EMAIL like @searchString)
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_SEARCH_VATTU]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_SEARCH_VATTU]
	@content nvarchar(20)
	as
	begin
		declare @search nvarchar(30)
		set @search = N'%' + @content +N'%'
		print(@search)
		begin
			select * from VATTU 
			where TENVT like @search
		end
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_SEARCH_XE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SEARCH_XE]
	@content nvarchar(20)
	as
	begin
		declare @searchString nvarchar(23)
		set @searchString = N'%' + @content + N'%'
		select * from XE
		where (BIENSO like @searchString) or (XUAT_XU like @searchString) or (MOTA like @searchString)
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_KHACHHANG]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SELECT_KHACHHANG]
	@id int
	AS
	BEGIN
		SELECT * FROM KHACHHANG WHERE (@id = KH_ID )
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_SELECT_PHIEUSUACHUA]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SELECT_PHIEUSUACHUA]
	@id int
	AS
	BEGIN
		SELECT * FROM PHIEUSUACHUA WHERE (@id = MAPSC )
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_DONGXE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_DONGXE]
	@id varchar(50),
	@hieuXe varchar(50),
	@tskt nvarchar(max)
	AS
	BEGIN
		UPDATE CACLOAIXE
		SET HIEU_XE = @hieuXe, THONG_SO_KY_THUAT = @tskt, NGAY_CN_CUOI = GETDATE()
		WHERE DONGXE_ID = @id
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_HIEUXE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_HIEUXE]
	@maHx int,
	@tenHx nvarchar(50)
	AS
	BEGIN
		UPDATE HIEUXE
		set TENHX = @tenHx, NGAY_CN_CUOI = GETDATE()
		WHERE MAHX = @maHx
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_KHACHHANG]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_KHACHHANG]
	@id int,
	@ten nvarchar(50),
	@sdt varchar(15),
	@email nvarchar(50),
	@diaChi nvarchar(200),
	@ngaySinh smalldatetime,
	@gender bit,
	@congNo money
	AS
	BEGIN
		UPDATE KHACHHANG
		SET KH_TEN = @ten, KH_SDT = @sdt, KH_EMAIL = @email, KH_DIACHI = @diaChi, KH_NGAYSINH = @ngaySinh, KH_GIOITINH = @gender, KH_CONGNO = @congNo, NGAY_CN_CUOI = GETDATE()
		WHERE KH_ID = @id
	END

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_VATTU]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_VATTU]
	@maVt int,
	@tenVt nvarchar(50),
	@donGia money,
	@sl int
	AS
	BEGIN
		UPDATE VATTU
		SET TENVT = @tenVt, DONGIA = @donGia, SL = @sl, NGAY_CN_CUOI = GETDATE()
		WHERE MAVT = @maVt
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_XE]    Script Date: 05/01/2017 5:15:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_XE]
	@bs varchar(50),
	@userId int,
	@ngayTN smalldatetime,
	@dongXeId varchar(50),
	@mau nvarchar(50),
	@mota nvarchar(1000),
	@mauTrong nvarchar(50),
	@namXX varchar(50),
	@xuatXu nvarchar(50)
	AS
	BEGIN
		UPDATE XE
		SET USER_ID = @userId, NGAYTN = @ngayTN, DONGXE_ID = @dongXeId, MAU_XE = @mau, MOTA = @mota, MAU_NOI_THAT = @mauTrong, NAM_XUAT_XU = @namXX, XUAT_XU = @xuatXu, NGAY_CN_CUOI = GETDATE()
		WHERE BIENSO = @bs
	END
GO
