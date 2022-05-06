
CREATE DATABASE [LTTQ_2]
 
USE [LTTQ_2]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG](
	[MaHang] [nvarchar](10) NOT NULL,
	[TenHang] [nvarchar](30) NOT NULL,
	[Loai] [nvarchar](16) NOT NULL,
	[ChatLuong] [nvarchar](16) NULL,
	[GiaNhap] [money] NOT NULL,
	[GiaBan] [money] NOT NULL,
	[Anh] [nvarchar](20) NULL,
 CONSTRAINT [pk_HANG] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONNHAP]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONNHAP](
	[SoHDN] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NULL,
	[MaNCC] [nvarchar](10) NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [pk_HOADONNHAP] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_NHAP]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_NHAP](
	[SoHDN] [nvarchar](10) NOT NULL,
	[MaHang] [nvarchar](10) NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[KhuyenMai] [tinyint] NULL,
 CONSTRAINT [PK_CT_NHAP] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DanhSachHang]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DanhSachHang]
as
SELECT        dbo.HANG.MaHang, dbo.HANG.TenHang, dbo.HANG.ChatLuong, dbo.HANG.Loai, dbo.HANG.GiaNhap, dbo.HANG.GiaBan, dbo.HOADONNHAP.NgayNhap
FROM            dbo.HANG LEFT OUTER JOIN
                         dbo.CT_NHAP ON dbo.CT_NHAP.MaHang = dbo.HANG.MaHang LEFT OUTER JOIN
                         dbo.HOADONNHAP ON dbo.HOADONNHAP.SoHDN = dbo.CT_NHAP.SoHDN
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](30) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](40) NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[Luong] [money] NULL,
	[SoNgayNghi/Thang] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [pk_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTK] [nvarchar](255) NOT NULL,
	[MaNV] [nvarchar](10) NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[PhanQuyen] [nvarchar](20) NULL,
 CONSTRAINT [pk_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[thongTinNV]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[thongTinNV] as
SELECT        dbo.NHANVIEN.MaNV, dbo.NHANVIEN.TenNV, dbo.NHANVIEN.NgaySinh, dbo.NHANVIEN.GioiTinh, dbo.NHANVIEN.SDT, dbo.NHANVIEN.DiaChi, dbo.TAIKHOAN.MaTK, dbo.TAIKHOAN.MatKhau, dbo.TAIKHOAN.PhanQuyen
FROM            dbo.NHANVIEN INNER JOIN
                         dbo.TAIKHOAN ON dbo.NHANVIEN.MaNV = dbo.TAIKHOAN.MaNV
GO
/****** Object:  Table [dbo].[CT_BAN]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BAN](
	[SoHDB] [nvarchar](10) NOT NULL,
	[MaHang] [nvarchar](10) NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[KhuyenMai] [tinyint] NULL,
 CONSTRAINT [PK_CT_BAN] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONBAN]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONBAN](
	[SoHDB] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NULL,
	[MaKH] [nvarchar](10) NULL,
	[NgayBan] [date] NULL,
 CONSTRAINT [pk_HOADONBAN] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](40) NULL,
	[SDT] [nvarchar](15) NULL,
	[PhanLoai] [nvarchar](10) NULL,
 CONSTRAINT [pk_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 11/23/21 10:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](40) NULL,
	[SDT] [nvarchar](15) NOT NULL,
 CONSTRAINT [pk_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'1', N'H11', 2, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'2', N'H1', 3, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'3', N'H11', 1, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'3', N'H5', 1, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'4', N'H7', 2, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'5', N'H6', 1, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'6', N'H11', 2, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'6', N'H2', 5, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'7', N'H10', 2, NULL)
GO
INSERT [dbo].[CT_BAN] ([SoHDB], [MaHang], [SoLuongBan], [KhuyenMai]) VALUES (N'7', N'H3', 1, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'1', N'H3', 10, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'2', N'H1', 15, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'2', N'H4', 3, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'2', N'H7', 12, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'2', N'H9', 12, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'3', N'H10', 16, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'3', N'H8', 16, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'4', N'H5', 2, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'5', N'H4', 2, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'6', N'H11', 8, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'7', N'H6', 10, NULL)
GO
INSERT [dbo].[CT_NHAP] ([SoHDN], [MaHang], [SoLuongNhap], [KhuyenMai]) VALUES (N'8', N'H2', 10, NULL)
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H1', N'Ví da Louis Vuiton', N'Ví', N'Tốt', 1000000.0000, 1500000.0000, N'ViDaCaSau.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H10', N'Quần da Renekton', N'Quần', N'Tốt', 4000000.0000, 5000000.0000, N'QuanDaNam.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H11', N'Mũ da', N'Mũ', N'Bình thường', 500000.0000, 700000.0000, N'MuDa.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H2', N'Ví da Fashion', N'Ví', N'Tốt', 10000.0000, 20000.0000, N'ViDa.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H3', N'Ví da Yasuo', N'Ví', N'Tốt', 2000000.0000, 2700000.0000, N'ViDaCaoCap.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H4', N'Túi xách da cá sấu LV', N'Túi xách', N'Tốt', 10000000.0000, 13000000.0000, N'TuiXachDaCaSau1.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H5', N'Túi xách da Yone', N'Túi xách', N'Tốt', 5000000.0000, 6500000.0000, N'TuiXachDa.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H6', N'Túi xách da Sasuke', N'Túi xách', N'Tốt', 10000000.0000, 12000000.0000, N'TuiXachDaCaSau2.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H7', N'Áo da Louis Vuiton', N'Áo', N'Tốt', 2000000.0000, 3000000.0000, N'AoDa.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H8', N'Áo da Renekton', N'Áo', N'Tốt', 3000000.0000, 4000000.0000, N'AoDaCaoCap.jpg')
GO
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Loai], [ChatLuong], [GiaNhap], [GiaBan], [Anh]) VALUES (N'H9', N'Quần da Louis Vuiton', N'Quần', N'Tốt', 3000000.0000, 4000000.0000, N'QuanDaNu.jpg')
GO
INSERT [dbo].[HOADONBAN] ([SoHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'1', N'NV3', N'1', CAST(N'2019-10-03' AS Date))
GO
INSERT [dbo].[HOADONBAN] ([SoHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'2', N'NV2', N'2', CAST(N'2020-10-03' AS Date))
GO
INSERT [dbo].[HOADONBAN] ([SoHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'3', N'NV4', N'3', CAST(N'2020-11-13' AS Date))
GO
INSERT [dbo].[HOADONBAN] ([SoHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'4', N'NV1', N'1', CAST(N'2021-11-22' AS Date))
GO
INSERT [dbo].[HOADONBAN] ([SoHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'5', N'NV3', N'4', CAST(N'2021-11-23' AS Date))
GO
INSERT [dbo].[HOADONBAN] ([SoHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'6', N'NV1', N'2', CAST(N'2021-12-01' AS Date))
GO
INSERT [dbo].[HOADONBAN] ([SoHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'7', N'NV2', N'6', CAST(N'2021-11-23' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'1', N'NV3', N'N2', CAST(N'2021-04-01' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'2', N'NV1', N'N1', CAST(N'2021-04-01' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'3', N'NV2', N'N3', CAST(N'2021-06-01' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'4', N'NV1', N'N5', CAST(N'2021-07-01' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'5', N'NV4', N'N2', CAST(N'2021-10-01' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'6', N'NV2', N'N7', CAST(N'2021-10-01' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'7', N'NV3', N'N6', CAST(N'2021-11-01' AS Date))
GO
INSERT [dbo].[HOADONNHAP] ([SoHDN], [MaNV], [MaNCC], [NgayNhap]) VALUES (N'8', N'NV1', N'N4', CAST(N'2021-11-01' AS Date))
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [PhanLoai]) VALUES (N'1', N'Văn A', N'Hồ Gươm', N'911', NULL)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [PhanLoai]) VALUES (N'2', N'Thị B', N'Hồ Hoàn Kiếm', N'912', NULL)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [PhanLoai]) VALUES (N'3', N'Hữu C', N'Hồ Tây', N'913', NULL)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [PhanLoai]) VALUES (N'4', N'Cao T', N'Chùa Bà Đanh', N'914', NULL)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [PhanLoai]) VALUES (N'5', N'gdf', NULL, NULL, NULL)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [PhanLoai]) VALUES (N'6', N'gdf', NULL, NULL, NULL)
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'N1', N'Louis Vuiton', N'Califonia,Mỹ', N'113')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'N2', N'Yasuo', N'Gần Bệnh Viên Trung Ương Hà Nội', N'114')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'N3', N'Renekton', N'Số 9, Dương Quảng Hàm, Hà Nội', N'115')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'N4', N'Fashion', N'Nam Đàn, Nghệ An', N'116')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'N5', N'Yone', N'Hoàng Sa', N'117')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'N6', N'Sasuke', N'Làng lá', N'118')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'N7', N'Chợ', N'Rải rác khắp nước', N'119')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Luong], [SoNgayNghi/Thang], [GhiChu]) VALUES (N'NV1', N'Nguyễn Văn Hoàng', N'Nam', CAST(N'2001-11-13' AS Date), N'Nghệ An', N'0799062547', 50000000.0000, NULL, N'')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Luong], [SoNgayNghi/Thang], [GhiChu]) VALUES (N'NV2', N'Nguyễn Thế Duyệt', N'Nam', CAST(N'2001-11-03' AS Date), N'Hà Nội', N'0123456789', 51000000.0000, NULL, NULL)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Luong], [SoNgayNghi/Thang], [GhiChu]) VALUES (N'NV3', N'Đỗ Thu Phương', N'Nữ', CAST(N'2001-03-11' AS Date), N'Hà Nội', N'0987654321', 5000.0000, NULL, NULL)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Luong], [SoNgayNghi/Thang], [GhiChu]) VALUES (N'NV4', N'Nguyễn Tất Thành', N'Nam', CAST(N'1990-05-19' AS Date), N'Nghệ An', N'0112345678', NULL, NULL, N'')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Luong], [SoNgayNghi/Thang], [GhiChu]) VALUES (N'NV5', N'Nguyễn Thu Hường', N'N?', CAST(N'1979-11-23' AS Date), N'Hà Nội', N'0102030405', 20000000.0000, NULL, N'')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [MaNV], [MatKhau], [PhanQuyen]) VALUES (N'0102030405', N'NV5', N'4l53vesT6fU=', N'employee')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [MaNV], [MatKhau], [PhanQuyen]) VALUES (N'admin', N'NV1', N'UPn6lHTgTbU=', N'admin')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [MaNV], [MatKhau], [PhanQuyen]) VALUES (N'duyet', N'NV2', N'5ME4IzYdZeU=', N'admin')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [MaNV], [MatKhau], [PhanQuyen]) VALUES (N'phuong', N'NV3', N'sRM+fWsn18o=', N'admin')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [MaNV], [MatKhau], [PhanQuyen]) VALUES (N'thanh', N'NV4', N'4l53vesT6fU=', N'employee')
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD  CONSTRAINT [fk_HOADONBAN_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADONBAN] CHECK CONSTRAINT [fk_HOADONBAN_MaKH]
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD  CONSTRAINT [fk_HOADONBAN_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONBAN] CHECK CONSTRAINT [fk_HOADONBAN_MaNV]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [fk_HOADONNHAP_MaNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [fk_HOADONNHAP_MaNCC]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [fk_HOADONNHAP_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [fk_HOADONNHAP_MaNV]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [fk_TAIKHOAN_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [fk_TAIKHOAN_MaNV]
GO
GO
ALTER DATABASE [LTTQ_2] SET  READ_WRITE 
GO
