USE [master]
GO
/****** Object:  Database [SakuraData]    Script Date: 20/07/2020 19:54:29 ******/
CREATE DATABASE [SakuraData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SakuraData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SakuraData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SakuraData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SakuraData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SakuraData] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SakuraData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SakuraData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SakuraData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SakuraData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SakuraData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SakuraData] SET ARITHABORT OFF 
GO
ALTER DATABASE [SakuraData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SakuraData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SakuraData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SakuraData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SakuraData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SakuraData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SakuraData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SakuraData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SakuraData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SakuraData] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SakuraData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SakuraData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SakuraData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SakuraData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SakuraData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SakuraData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SakuraData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SakuraData] SET RECOVERY FULL 
GO
ALTER DATABASE [SakuraData] SET  MULTI_USER 
GO
ALTER DATABASE [SakuraData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SakuraData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SakuraData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SakuraData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SakuraData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SakuraData] SET QUERY_STORE = OFF
GO
USE [SakuraData]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [SakuraData]
GO
/****** Object:  Table [dbo].[trestockkomponen]    Script Date: 20/07/2020 19:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trestockkomponen](
	[no_pembelian_komponen] [char](9) NOT NULL,
	[id_pelayan] [char](8) NOT NULL,
	[tanggal_pembelian] [date] NULL,
	[total_jenis] [int] NULL,
	[jumlah_komponen] [int] NULL,
	[total_harga] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[no_pembelian_komponen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tdetailrestock]    Script Date: 20/07/2020 19:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdetailrestock](
	[no_pembelian_komponen] [char](9) NULL,
	[id_komponen] [char](9) NULL,
	[id_supplier] [char](9) NULL,
	[jumlah] [int] NULL,
	[total_harga] [money] NULL,
	[status] [varchar](6) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mssupplier]    Script Date: 20/07/2020 19:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mssupplier](
	[id_supplier] [char](9) NOT NULL,
	[nama_supplier] [varchar](25) NULL,
	[contact_person] [varchar](25) NULL,
	[no_telepon] [varchar](15) NULL,
	[alamat] [varchar](100) NULL,
	[keterangan] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[msalatelektronik]    Script Date: 20/07/2020 19:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msalatelektronik](
	[id_alat] [char](8) NOT NULL,
	[nama_alat] [varchar](30) NOT NULL,
	[id_jenis] [char](8) NOT NULL,
 CONSTRAINT [PK_msalatelektronik] PRIMARY KEY CLUSTERED 
(
	[id_alat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[msbagianpelayan]    Script Date: 20/07/2020 19:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msbagianpelayan](
	[id_pelayan] [char](8) NOT NULL,
	[nama_pelayan] [varchar](50) NOT NULL,
	[jenis_kelamin] [varchar](9) NULL,
	[alamat] [varchar](100) NOT NULL,
	[email] [varchar](30) NOT NULL,
	[no_telepon] [varchar](15) NOT NULL,
	[status] [varchar](11) NOT NULL,
	[username] [varchar](25) NULL,
	[password] [varchar](30) NULL,
 CONSTRAINT [PK_msbagianpelayan] PRIMARY KEY CLUSTERED 
(
	[id_pelayan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[msjeniselektronik]    Script Date: 20/07/2020 19:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msjeniselektronik](
	[id_jenis] [char](8) NOT NULL,
	[nama_jenis] [varchar](30) NOT NULL,
 CONSTRAINT [PK_msjeniselektronik] PRIMARY KEY CLUSTERED 
(
	[id_jenis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mskomponen]    Script Date: 20/07/2020 19:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mskomponen](
	[id_komponen] [char](8) NOT NULL,
	[nama_komponen] [varchar](30) NOT NULL,
	[jumlah] [int] NOT NULL,
	[harga_jual] [money] NOT NULL,
	[id_alat] [char](8) NOT NULL,
	[tempat] [varchar](4) NOT NULL,
 CONSTRAINT [PK_mskomponen] PRIMARY KEY CLUSTERED 
(
	[id_komponen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[lrestock]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[lrestock] as 
(select ROW_NUMBER() over(order by trk.no_pembelian_komponen) No, trk.no_pembelian_komponen, mk.nama_komponen, ma.nama_alat, mj.nama_jenis, tdr.jumlah, tdr.total_harga, msp.nama_supplier, mp.nama_pelayan, trk.tanggal_pembelian from trestockkomponen trk 
inner join msbagianpelayan mp on mp.id_pelayan = trk.id_pelayan
inner join tdetailrestock tdr on tdr.no_pembelian_komponen = trk.no_pembelian_komponen
inner join mssupplier msp on msp.id_supplier = tdr.id_supplier
inner join mskomponen mk on mk.id_komponen = tdr.id_komponen
inner join msalatelektronik ma on ma.id_alat = mk.id_alat
inner join msjeniselektronik mj on mj.id_jenis = ma.id_jenis)
GO
/****** Object:  View [dbo].[lrestock1]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[lrestock1] as 
(select trk.no_pembelian_komponen, mk.nama_komponen, ma.nama_alat, mj.nama_jenis, tdr.jumlah, cast(tdr.total_harga as decimal) total_harga , msp.nama_supplier, mp.nama_pelayan, trk.tanggal_pembelian from trestockkomponen trk 
inner join msbagianpelayan mp on mp.id_pelayan = trk.id_pelayan
inner join tdetailrestock tdr on tdr.no_pembelian_komponen = trk.no_pembelian_komponen
inner join mssupplier msp on msp.id_supplier = tdr.id_supplier
inner join mskomponen mk on mk.id_komponen = tdr.id_komponen
inner join msalatelektronik ma on ma.id_alat = mk.id_alat
inner join msjeniselektronik mj on mj.id_jenis = ma.id_jenis where tdr.status = 'Sukses')
GO
/****** Object:  Table [dbo].[mscustomer]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mscustomer](
	[id_customer] [char](9) NOT NULL,
	[nama_customer] [varchar](50) NULL,
	[total_transaksi] [int] NULL,
	[path] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbelikomponen]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbelikomponen](
	[no_transaksi_pembelian] [varchar](9) NOT NULL,
	[tanggal_transaksi] [date] NULL,
	[jumlah_komponen] [int] NULL,
	[jumlah_jenis] [int] NULL,
	[total_harga] [money] NULL,
	[id_pelayan] [char](8) NULL,
	[id_customer] [char](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[no_transaksi_pembelian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tdetailbelikomponen]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdetailbelikomponen](
	[no_transaksi_pembelian] [varchar](9) NULL,
	[id_komponen] [char](8) NULL,
	[jumlah] [int] NULL,
	[total_harga] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[lbelikomponen]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[lbelikomponen] as
select tbk.no_transaksi_pembelian, mk.nama_komponen, ma.nama_alat, mj.nama_jenis, mc.nama_customer, bp.nama_pelayan, tbk.tanggal_transaksi, tdk.jumlah, tdk.total_harga  from tbelikomponen tbk
inner join tdetailbelikomponen tdk on tdk.no_transaksi_pembelian = tbk.no_transaksi_pembelian
inner join mskomponen mk on mk.id_komponen = tdk.id_komponen
inner join msalatelektronik ma on ma.id_alat = mk.id_alat
inner join msjeniselektronik mj on mj.id_jenis = ma.id_jenis
inner join mscustomer mc on mc.id_customer = tbk.id_customer
inner join msbagianpelayan bp on bp.id_pelayan = tbk.id_pelayan
GO
/****** Object:  Table [dbo].[treparasialat]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[treparasialat](
	[no_transaksi_reparasi] [char](8) NOT NULL,
	[id_pelayan] [char](8) NOT NULL,
	[id_customer] [char](9) NOT NULL,
	[tanggal_reparasi] [date] NOT NULL,
	[total] [money] NOT NULL,
	[keluhan] [varchar](100) NULL,
	[id_gudang] [char](8) NULL,
	[id_jenis] [char](8) NULL,
	[alat_elektronik] [varchar](30) NULL,
	[status] [varchar](10) NULL,
	[biaya] [int] NULL,
	[status_pembayaran] [varchar](10) NULL,
 CONSTRAINT [PK_treparasialat] PRIMARY KEY CLUSTERED 
(
	[no_transaksi_reparasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tdetailreparasialat]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdetailreparasialat](
	[no_transaksi_reparasi] [char](8) NULL,
	[id_komponen] [char](8) NULL,
	[jumlah_komponen] [int] NULL,
	[harga] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[msbagiangudang]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msbagiangudang](
	[id_gudang] [char](8) NOT NULL,
	[nama_gudang] [varchar](50) NOT NULL,
	[jenis_kelamin] [varchar](9) NULL,
	[alamat] [varchar](100) NOT NULL,
	[email] [varchar](30) NOT NULL,
	[no_telepon] [varchar](15) NOT NULL,
	[status] [varchar](11) NOT NULL,
 CONSTRAINT [PK_msbagiangudang] PRIMARY KEY CLUSTERED 
(
	[id_gudang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[lreparasialat]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[lreparasialat] as
select tba.no_transaksi_reparasi, mc.nama_customer, ma.nama_alat, mj.nama_jenis, tba.tanggal_reparasi, mp.nama_pelayan, mg.nama_gudang, tdr.harga  from treparasialat tba
inner join msbagianpelayan mp on mp.id_pelayan = tba.id_pelayan
inner join mscustomer mc on mc.id_customer = tba.id_customer
inner join tdetailreparasialat tdr on tdr.no_transaksi_reparasi = tba.no_transaksi_reparasi
inner join msalatelektronik ma on ma.id_alat =  tdr.id_alat
inner join msbagiangudang mg on mg.id_gudang = tdr.id_gudang
inner join msjeniselektronik mj on mj.id_jenis = ma.id_jenis
GO
/****** Object:  Table [dbo].[trestockalatkerja]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trestockalatkerja](
	[no_transaksi_pembelian] [varchar](8) NOT NULL,
	[id_pelayan] [char](8) NOT NULL,
	[tanggal_pembelian] [date] NOT NULL,
	[total] [money] NOT NULL,
	[jumlah_jenis] [int] NULL,
	[jumlah_alat] [int] NULL,
 CONSTRAINT [PK_trestockalatkerja] PRIMARY KEY CLUSTERED 
(
	[no_transaksi_pembelian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tdrestockalatkerja]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdrestockalatkerja](
	[no_transaksi_pembelian] [varchar](8) NOT NULL,
	[id_supplier] [char](9) NOT NULL,
	[id_alat] [char](9) NOT NULL,
	[jumlah] [int] NOT NULL,
	[harga] [money] NOT NULL,
	[status] [varchar](10) NULL,
 CONSTRAINT [PK_tdrestockalatkerja] PRIMARY KEY CLUSTERED 
(
	[no_transaksi_pembelian] ASC,
	[id_supplier] ASC,
	[id_alat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[msalatkerja]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msalatkerja](
	[id_alat] [char](9) NOT NULL,
	[nama_alat] [varchar](50) NULL,
	[jumlah] [int] NULL,
	[rusak] [int] NULL,
	[bagus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_alat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[lrestockalat]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[lrestockalat] as
select tra.no_transaksi_pembelian, ma.nama_alat, mpr.nama_supplier, mp.nama_pelayan, tra.tanggal_pembelian, tdr.jumlah, tdr.harga from trestockalatkerja tra
inner join msbagianpelayan mp on mp.id_pelayan = tra.id_pelayan
inner join tdrestockalatkerja tdr on tdr.no_transaksi_pembelian = tra.no_transaksi_pembelian
inner join mssupplier mpr on mpr.id_supplier = tdr.id_supplier
inner join msalatkerja ma on ma.id_alat =  tdr.id_alat
GO
/****** Object:  View [dbo].[viewprosesreparasialat]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[viewprosesreparasialat] as
select ROW_NUMBER() over(order by tda.no_transaksi_reparasi asc) No, tda.no_transaksi_reparasi Kode, mc.nama_customer Pelanggan, mj.nama_jenis Jenis, mk.nama_alat [Alat Elektronik], tda.keluhan [Keluhan], tda.status [Status] ,tda.tanggal_reparasi [ Tanggal Transaksi ] from treparasialat tda
inner join mscustomer mc on mc.id_customer = tda.id_customer
inner join msjeniselektronik mj on mj.id_jenis = tda.id_jenis
inner join msalatelektronik mk on mk.id_alat = tda.alat_elektronik
GO
/****** Object:  View [dbo].[viewselesaireparasialat]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[viewselesaireparasialat] as
SELECT        ROW_NUMBER() OVER (ORDER BY tda.no_transaksi_reparasi ASC) No, tda.no_transaksi_reparasi Kode, mc.nama_customer Pelanggan, mj.nama_jenis Jenis, mk.nama_alat[Alat Elektronik], tda.keluhan[Keluhan], 
tda.biaya Biaya, tda.total Total, tda.status[Status], tda.tanggal_reparasi[ Tanggal Transaksi ], tda.status_pembayaran Pembayaran
FROM            treparasialat tda INNER JOIN
                         mscustomer mc ON mc.id_customer = tda.id_customer INNER JOIN
                         msjeniselektronik mj ON mj.id_jenis = tda.id_jenis INNER JOIN
                         msalatelektronik mk ON mk.id_alat = tda.alat_elektronik
GO
/****** Object:  View [dbo].[viewbayardetailreparasi]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[viewbayardetailreparasi] as
select tdr.no_transaksi_reparasi, mk.nama_komponen, tdr.jumlah_komponen, mk.harga_jual, tdr.harga from tdetailreparasialat tdr
inner join mskomponen mk on mk.id_komponen = tdr.id_komponen
GO
/****** Object:  Table [dbo].[msalatsupplier]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msalatsupplier](
	[id_alat] [char](9) NOT NULL,
	[id_supplier] [char](9) NOT NULL,
	[harga] [money] NULL,
	[total_transaksi] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mskomponensupplier]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mskomponensupplier](
	[id_komponen] [char](9) NOT NULL,
	[id_supplier] [char](9) NOT NULL,
	[harga] [money] NULL,
	[total_transaksi] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mspenyimpananx]    Script Date: 20/07/2020 19:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mspenyimpananx](
	[id_komponen] [char](9) NOT NULL,
	[nama_komponen] [varchar](50) NULL,
	[jumlah] [int] NULL,
	[harga_jual] [money] NULL,
	[tempat] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_komponen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[msalatelektronik] ([id_alat], [nama_alat], [id_jenis]) VALUES (N'ALE-0001', N'Asus ROG', N'JAL-0001')
INSERT [dbo].[msalatelektronik] ([id_alat], [nama_alat], [id_jenis]) VALUES (N'ALE-0002', N'Asus TUF1', N'JAL-0001')
INSERT [dbo].[msalatelektronik] ([id_alat], [nama_alat], [id_jenis]) VALUES (N'ALE-0003', N'Toshiba', N'JAL-0001')
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0001', N'Solder', 10, 1, 9)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0002', N'Obeng', 52, 2, 50)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0003', N'Tang Kombinasi', 3, 0, 3)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0004', N'Tang Lancip', 5, 1, 4)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0005', N'Pinset', 6, 0, 6)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0006', N'Penyedot Timah', 5, 0, 5)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0007', N'Meja Putar', 4, 0, 4)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0008', N'Gergaji Besi', 4, 0, 4)
INSERT [dbo].[msalatkerja] ([id_alat], [nama_alat], [jumlah], [rusak], [bagus]) VALUES (N'AKRJ-0009', N'Palu', 4, 2, 2)
INSERT [dbo].[msalatsupplier] ([id_alat], [id_supplier], [harga], [total_transaksi]) VALUES (N'AKRJ-0001', N'SUPP-0005', 10000.0000, 0)
INSERT [dbo].[msalatsupplier] ([id_alat], [id_supplier], [harga], [total_transaksi]) VALUES (N'AKRJ-0001', N'SUPP-0011', 12500.0000, 0)
INSERT [dbo].[msalatsupplier] ([id_alat], [id_supplier], [harga], [total_transaksi]) VALUES (N'AKRJ-0005', N'SUPP-0011', 12000.0000, 0)
INSERT [dbo].[msalatsupplier] ([id_alat], [id_supplier], [harga], [total_transaksi]) VALUES (N'AKRJ-0006', N'SUPP-0011', 23000.0000, 0)
INSERT [dbo].[msalatsupplier] ([id_alat], [id_supplier], [harga], [total_transaksi]) VALUES (N'AKRJ-0006', N'SUPP-0010', 25000.0000, 0)
INSERT [dbo].[msalatsupplier] ([id_alat], [id_supplier], [harga], [total_transaksi]) VALUES (N'AKRJ-0006', N'SUPP-0001', 25000.0000, 0)
INSERT [dbo].[msalatsupplier] ([id_alat], [id_supplier], [harga], [total_transaksi]) VALUES (N'AKRJ-0002', N'SUPP-0001', 15000.0000, 1)
INSERT [dbo].[msbagiangudang] ([id_gudang], [nama_gudang], [jenis_kelamin], [alamat], [email], [no_telepon], [status]) VALUES (N'GDG-0001', N'Fiorenta Jihad Wibowo', N'Laki-laki', N'Aaa', N'Aaa', N'3333', N'Tidak Aktif')
INSERT [dbo].[msbagiangudang] ([id_gudang], [nama_gudang], [jenis_kelamin], [alamat], [email], [no_telepon], [status]) VALUES (N'GDG-0002', N'Henri Anto', N'Laki-laki', N'Jalan Merak 9 Jakarta Utara', N'Hen@gmail.com', N'0895066001231', N'Aktif')
INSERT [dbo].[msbagiangudang] ([id_gudang], [nama_gudang], [jenis_kelamin], [alamat], [email], [no_telepon], [status]) VALUES (N'GDG-0003', N'Dummy ', N'Laki-laki', N'Kauman Comal', N'Dum@gmail.com', N'0812675125121', N'Aktif')
INSERT [dbo].[msbagiangudang] ([id_gudang], [nama_gudang], [jenis_kelamin], [alamat], [email], [no_telepon], [status]) VALUES (N'GDG-0004', N'Dumm', N'Laki-laki', N'Pademangan', N'Dam@gmail.com', N'0891724124124', N'Aktif')
INSERT [dbo].[msbagianpelayan] ([id_pelayan], [nama_pelayan], [jenis_kelamin], [alamat], [email], [no_telepon], [status], [username], [password]) VALUES (N'PLY-0001', N'Jessica Rich Girl', N'Perempuan', N'Jalan Jati 9', N'email@gmail.com', N'0851515151515', N'Aktif', N'Jess', N'Jess123')
INSERT [dbo].[msbagianpelayan] ([id_pelayan], [nama_pelayan], [jenis_kelamin], [alamat], [email], [no_telepon], [status], [username], [password]) VALUES (N'PLY-0002', N'Paleka', N'Laki-laki', N'Unknown', N'Cek@salah.input', N'0897392827420', N'Tidak Aktif', N'', N'')
INSERT [dbo].[msbagianpelayan] ([id_pelayan], [nama_pelayan], [jenis_kelamin], [alamat], [email], [no_telepon], [status], [username], [password]) VALUES (N'PLY-0003', N'Paleka', N'Laki-laki', N'Di suatu tempat', N'coek@salah.input', N'0823137843749', N'Aktif', N'', N'')
INSERT [dbo].[msbagianpelayan] ([id_pelayan], [nama_pelayan], [jenis_kelamin], [alamat], [email], [no_telepon], [status], [username], [password]) VALUES (N'PLY-0004', N'Mr.X', N'Perempuan', N'Jalan Boga boga Jogja', N'asd@gmail', N'111111111', N'Aktif', N'', N'')
INSERT [dbo].[msbagianpelayan] ([id_pelayan], [nama_pelayan], [jenis_kelamin], [alamat], [email], [no_telepon], [status], [username], [password]) VALUES (N'PLY-0005', N'Hendra', N'Laki-laki', N'Jalan Imam Bonjol', N'abc', N'08888888888', N'Aktif', N'', N'')
INSERT [dbo].[mscustomer] ([id_customer], [nama_customer], [total_transaksi], [path]) VALUES (N'CUST-0001', N'Fiorenta Jihad Widodo', 0, NULL)
INSERT [dbo].[mscustomer] ([id_customer], [nama_customer], [total_transaksi], [path]) VALUES (N'CUST-0002', N'Teddyanto Idrus Jamallulail', 0, NULL)
INSERT [dbo].[mscustomer] ([id_customer], [nama_customer], [total_transaksi], [path]) VALUES (N'CUST-0003', N'Fikri Adriansyah', 0, NULL)
INSERT [dbo].[mscustomer] ([id_customer], [nama_customer], [total_transaksi], [path]) VALUES (N'CUST-0004', N'Habibah Shiba Zahidah', 3, N'C:\Users\Polman\Downloads\Teddy\IMG_9658.JPG')
INSERT [dbo].[mscustomer] ([id_customer], [nama_customer], [total_transaksi], [path]) VALUES (N'CUST-0005', N'Teddyanto Idrus Jamalludin', 2, N'C:\Users\Polman\Downloads\Teddy\IMG_9657.JPG')
INSERT [dbo].[mscustomer] ([id_customer], [nama_customer], [total_transaksi], [path]) VALUES (N'CUST-0006', N'Aqilah Rahma Tsabitah', 22, N'C:\Users\Polman\Downloads\Teddy\sholat ringankan beban.jpg')
INSERT [dbo].[mscustomer] ([id_customer], [nama_customer], [total_transaksi], [path]) VALUES (N'CUST-0007', N'Hanum Salsa', 0, N'')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0001', N'Laptop')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0002', N'SmartPhone')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0003', N'Blender')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0004', N'Televisi')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0005', N'As')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0006', N'A')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0007', N'A')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0008', N'A')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0009', N'A')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0010', N'asda')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0011', N'asdas')
INSERT [dbo].[msjeniselektronik] ([id_jenis], [nama_jenis]) VALUES (N'JAL-0012', N'Kulkas')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0001', N'Baterai', 17, 500000.0000, N'ALE-0001', N'A2')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0002', N'Baut Mini', 15, 300000.0000, N'ALE-0002', N'A2')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0003', N'Baut Sedang', 32, 4000.0000, N'ALE-0002', N'A2')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0004', N'Kabel Kecil', 42, 7000.0000, N'ALE-0002', N'A3')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0005', N'Kabel Sedang', 19, 9500.0000, N'ALE-0002', N'A3')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0006', N'Baut Kecil', 40, 2000.0000, N'ALE-0001', N'A3')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0007', N'Mur', 1, 1000.0000, N'ALE-0001', N'A3')
INSERT [dbo].[mskomponen] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [id_alat], [tempat]) VALUES (N'KMP-0008', N'Mur', 0, 4000.0000, N'ALE-0002', N'A3')
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0002 ', N'SUPP-0011', 2000.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0002 ', N'SUPP-0010', 2200.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0005 ', N'SUPP-0002', 20000.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0001 ', N'SUPP-0005', 2000.0000, 2)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0001 ', N'SUPP-0011', 2300.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0001 ', N'SUPP-0007', 2500.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0002 ', N'SUPP-0005', 400.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0003 ', N'SUPP-0001', 600.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0004 ', N'SUPP-0012', 6000.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0004 ', N'SUPP-0003', 6500.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0005 ', N'SUPP-0001', 7500.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0005 ', N'SUPP-0010', 7700.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0007 ', N'SUPP-0010', 1500.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0007 ', N'SUPP-0009', 2000.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0001 ', N'SUPP-0010', 2700.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0004 ', N'SUPP-0011', 5000.0000, 3)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0006 ', N'SUPP-0010', 700.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0006 ', N'SUPP-0003', 750.0000, 1)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0006 ', N'SUPP-0002', 800.0000, 1)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0006 ', N'SUPP-0004', 750.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0002 ', N'SUPP-0004', 500.0000, 2)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0003 ', N'SUPP-0012', 650.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0003 ', N'SUPP-0009', 700.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0003 ', N'SUPP-0006', 750.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0004 ', N'SUPP-0005', 5500.0000, 1)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0002 ', N'SUPP-0002', 500.0000, 0)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0005 ', N'SUPP-0003', 7000.0000, 1)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0007 ', N'SUPP-0005', 1700.0000, 2)
INSERT [dbo].[mskomponensupplier] ([id_komponen], [id_supplier], [harga], [total_transaksi]) VALUES (N'KMP-0007 ', N'SUPP-0013', 2500.0000, 0)
INSERT [dbo].[mspenyimpananx] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [tempat]) VALUES (N'KOMP-0001', N'BAUT EUY', 10, 2000.0000, N'JAUH DI SANA')
INSERT [dbo].[mspenyimpananx] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [tempat]) VALUES (N'KOMP-0002', N'POASK EUY', 10, 2000.0000, N'JAUH DI SANA')
INSERT [dbo].[mspenyimpananx] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [tempat]) VALUES (N'KOMP-0003', N'BATU EUY', 10, 2000.0000, N'JAUH DI SANA')
INSERT [dbo].[mspenyimpananx] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [tempat]) VALUES (N'KOMP-0004', N'JIWT EUY', 10, 2000.0000, N'JAUH DI SANA')
INSERT [dbo].[mspenyimpananx] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [tempat]) VALUES (N'KOMP-0005', N'BASZXT EUY', 10, 2000.0000, N'JAUH DI SANA')
INSERT [dbo].[mspenyimpananx] ([id_komponen], [nama_komponen], [jumlah], [harga_jual], [tempat]) VALUES (N'KOMP-0006', N'SARW EUY', 10, 2000.0000, N'JAUH DI SANA')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0001', N'Lucky Elektronik Storexxx', N'Lucky', N'0818932369', N'East Jakarta City, Jakarta', N'Closes 6PM')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0002', N'Glodok Elektronik K.Gding', N'Bagus', N'0214528378', N'North Jakarta City, Jakarta', N'Closes 10PM')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0003', N'Gembira Electronk', N'Noni', N'0216310728', N'West Jakarta City, Jakarta', N'Closes 5PM')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0004', N'Jualelektronik.com', N'Munir', N'02180682299', N'Harco - Central Jakarta City, Jakarta.', N'Closes 4.30PM, in store pick-up')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0005', N'Arjuna Elektronik', N'Arjuna', N'02155952760', N'Ruko Taman Palem Lestari, Blok B17, Harco', N'Closes 8PM')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0006', N'Sinar Lestari Elektronik', N'Lestari', N'082227000222', N'Jl. Utama Raya Np. 11', N'Closes 7PM')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0007', N'Electronic City', N'Jon', N'02129045442', N'Jl. Boulevard Bintari Jaya Blok 7', N'Closes 10PM')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0008', N'Toko Jaya Audio Teknik', N'Jaya', N'0217453924', N'Jalan Raya No 7, Bintaro', N'Closes 8.30PM')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0009', N'PT LG Electronics Jakarta', N'Gilang', N'081315841683', N'Plaza Maspion Lt. 5 Kav 18, Jalan Gunung, Jakarta', N'Closes 10PM, on Reparation')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0010', N'Electronic City Pamulang', N'Faikar', N'0217444017', N'Jl. Pamulang Raya No 1', N'Closes 10PM, In-Store, Pick-up, Delivery')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0011', N'AVODAMITRA INDOTECH, CV', N'Robert', N'081923881349', N'Sidoarjo, Jawa Timur', N'Semua Ada')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0012', N'PT Adaro', N'Budi', N'089566666666666', N'Jalan Jendral Sudirman', N'Bisa Delivery Closed 9Pm')
INSERT [dbo].[mssupplier] ([id_supplier], [nama_supplier], [contact_person], [no_telepon], [alamat], [keterangan]) VALUES (N'SUPP-0013', N'AT Corps', N'Galih AS', N'0285444222111', N'Kauman Comal', N'Buka 24Jam, Delivery Only')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0001 ', CAST(N'2020-07-09' AS Date), 2, 2, 504000.0000, N'PLY-0001', N'CUST-0005')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0002 ', CAST(N'2020-07-09' AS Date), 6, 2, 35000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0003 ', CAST(N'2020-07-09' AS Date), 6, 2, 912000.0000, N'PLY-0001', N'CUST-0004')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0004 ', CAST(N'2020-07-09' AS Date), 7, 2, 37000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0005 ', CAST(N'2020-07-09' AS Date), 4, 1, 28000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0006 ', CAST(N'2020-07-09' AS Date), 1, 1, 500000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0007 ', CAST(N'2020-07-09' AS Date), 2, 1, 14000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0008 ', CAST(N'2020-07-09' AS Date), 1, 1, 500000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0009 ', CAST(N'2020-07-09' AS Date), 2, 2, 509500.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0010 ', CAST(N'2020-07-09' AS Date), 2, 2, 5000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0011 ', CAST(N'2020-07-09' AS Date), 5, 2, 8000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0012 ', CAST(N'2020-07-09' AS Date), 23, 2, 47000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0013 ', CAST(N'2020-07-09' AS Date), 10, 2, 13000.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0014 ', CAST(N'2020-07-09' AS Date), 3, 1, 3000.0000, N'PLY-0001', N'CUST-0004')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0015 ', CAST(N'2020-07-09' AS Date), 5, 1, 47500.0000, N'PLY-0001', N'CUST-0004')
INSERT [dbo].[tbelikomponen] ([no_transaksi_pembelian], [tanggal_transaksi], [jumlah_komponen], [jumlah_jenis], [total_harga], [id_pelayan], [id_customer]) VALUES (N'tbk-0016 ', CAST(N'2020-07-09' AS Date), 7, 7, 823500.0000, N'PLY-0001', N'CUST-0006')
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0001 ', N'KMP-0001', 1, 500000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0001 ', N'KMP-0002', 1, 4000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0002 ', N'KMP-0002', 2, 19000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0002 ', N'KMP-0002', 4, 16000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0004 ', N'KMP-0002', 4, 16000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0004 ', N'KMP-0002', 3, 21000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0005 ', N'KMP-0002', 4, 28000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0006 ', N'KMP-0001', 1, 500000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0010 ', N'KMP-0002', 1, 4000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0010 ', N'KMP-0001', 1, 1000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0011 ', N'KMP-0008', 1, 4000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0011 ', N'KMP-0007', 4, 4000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0013 ', N'KMP-0008', 1, 4000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0013 ', N'KMP-0007', 9, 9000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0014 ', N'KMP-0007', 3, 3000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0003 ', N'KMP-0002', 3, 900000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0003 ', N'KMP-0002', 3, 12000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0012 ', N'KMP-0008', 8, 32000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0012 ', N'KMP-0007', 15, 15000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0015 ', N'KMP-0005', 5, 47500.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0007 ', N'KMP-0002', 2, 14000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0009 ', N'KMP-0001', 1, 500000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0009 ', N'KMP-0002', 1, 9500.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0008 ', N'KMP-0001', 1, 500000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0016 ', N'KMP-0007', 1, 1000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0016 ', N'KMP-0001', 1, 500000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0016 ', N'KMP-0002', 1, 300000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0016 ', N'KMP-0005', 1, 9500.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0016 ', N'KMP-0003', 1, 4000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0016 ', N'KMP-0004', 1, 7000.0000)
INSERT [dbo].[tdetailbelikomponen] ([no_transaksi_pembelian], [id_komponen], [jumlah], [total_harga]) VALUES (N'tbk-0016 ', N'KMP-0006', 1, 2000.0000)
INSERT [dbo].[tdetailreparasialat] ([no_transaksi_reparasi], [id_komponen], [jumlah_komponen], [harga]) VALUES (N'TBA-0007', N'KMP-0001', 2, 1000000.0000)
INSERT [dbo].[tdetailreparasialat] ([no_transaksi_reparasi], [id_komponen], [jumlah_komponen], [harga]) VALUES (N'TBA-0007', N'KMP-0007', 3, 3000.0000)
INSERT [dbo].[tdetailreparasialat] ([no_transaksi_reparasi], [id_komponen], [jumlah_komponen], [harga]) VALUES (N'TBA-0007', N'KMP-0007', 4, 4000.0000)
INSERT [dbo].[tdetailreparasialat] ([no_transaksi_reparasi], [id_komponen], [jumlah_komponen], [harga]) VALUES (N'TBA-0007', N'KMP-0007', 4, 4000.0000)
INSERT [dbo].[tdetailreparasialat] ([no_transaksi_reparasi], [id_komponen], [jumlah_komponen], [harga]) VALUES (N'TBA-0008', N'KMP-0006', 5, 10000.0000)
INSERT [dbo].[tdetailreparasialat] ([no_transaksi_reparasi], [id_komponen], [jumlah_komponen], [harga]) VALUES (N'TBA-0008', N'KMP-0001', 4, 2000000.0000)
INSERT [dbo].[tdetailrestock] ([no_pembelian_komponen], [id_komponen], [id_supplier], [jumlah], [total_harga], [status]) VALUES (N'trk-0001 ', N'KMP-0005 ', N'SUPP-0003', 1, 700.0000, N'Proses')
INSERT [dbo].[tdetailrestock] ([no_pembelian_komponen], [id_komponen], [id_supplier], [jumlah], [total_harga], [status]) VALUES (N'trk-0002 ', N'KMP-0002 ', N'SUPP-0004', 3, 1200.0000, N'Sukses')
INSERT [dbo].[tdetailrestock] ([no_pembelian_komponen], [id_komponen], [id_supplier], [jumlah], [total_harga], [status]) VALUES (N'trk-0003 ', N'KMP-0003 ', N'SUPP-0001', 1, 780.0000, N'Proses')
INSERT [dbo].[tdetailrestock] ([no_pembelian_komponen], [id_komponen], [id_supplier], [jumlah], [total_harga], [status]) VALUES (N'trk-0004 ', N'KMP-0001 ', N'SUPP-0005', 4, 8000.0000, N'Sukses')
INSERT [dbo].[tdetailrestock] ([no_pembelian_komponen], [id_komponen], [id_supplier], [jumlah], [total_harga], [status]) VALUES (N'trk-0004 ', N'KMP-0004 ', N'SUPP-0011', 4, 20000.0000, N'Proses')
INSERT [dbo].[tdetailrestock] ([no_pembelian_komponen], [id_komponen], [id_supplier], [jumlah], [total_harga], [status]) VALUES (N'trk-0004 ', N'KMP-0006 ', N'SUPP-0004', 5, 3500.0000, N'Proses')
INSERT [dbo].[tdrestockalatkerja] ([no_transaksi_pembelian], [id_supplier], [id_alat], [jumlah], [harga], [status]) VALUES (N'TRA-0001', N'SUPP-0001', N'AKRJ-0002', 4, 60000.0000, N'Proses')
INSERT [dbo].[tdrestockalatkerja] ([no_transaksi_pembelian], [id_supplier], [id_alat], [jumlah], [harga], [status]) VALUES (N'TRA-0001', N'SUPP-0011', N'AKRJ-0006', 3, 69000.0000, N'Proses')
INSERT [dbo].[tdrestockalatkerja] ([no_transaksi_pembelian], [id_supplier], [id_alat], [jumlah], [harga], [status]) VALUES (N'TRA-0002', N'SUPP-0001', N'AKRJ-0002', 3, 45.0000, N'Proses')
INSERT [dbo].[tdrestockalatkerja] ([no_transaksi_pembelian], [id_supplier], [id_alat], [jumlah], [harga], [status]) VALUES (N'TRA-0003', N'SUPP-0001', N'AKRJ-0002', 10, 150.0000, N'Gagal')
INSERT [dbo].[tdrestockalatkerja] ([no_transaksi_pembelian], [id_supplier], [id_alat], [jumlah], [harga], [status]) VALUES (N'TRA-0004', N'SUPP-0001', N'AKRJ-0002', 1, 15.0000, N'Proses')
INSERT [dbo].[tdrestockalatkerja] ([no_transaksi_pembelian], [id_supplier], [id_alat], [jumlah], [harga], [status]) VALUES (N'TRA-0005', N'SUPP-0001', N'AKRJ-0002', 4, 60000.0000, N'Sukses')
INSERT [dbo].[tdrestockalatkerja] ([no_transaksi_pembelian], [id_supplier], [id_alat], [jumlah], [harga], [status]) VALUES (N'TRA-0005', N'SUPP-0011', N'AKRJ-0005', 1, 12000.0000, N'Proses')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0001', N'PLY-0001', N'CUST-0005', CAST(N'2020-07-17' AS Date), 0.0000, N'Mati Total', N'-       ', N'JAL-0002', N'Oppo', N'Diproses', NULL, N'Belum')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0002', N'PLY-0001', N'CUST-0005', CAST(N'2020-07-17' AS Date), 0.0000, N'Mati Total', N'-       ', N'JAL-0002', N'Oppo', N'Diproses', NULL, N'Belum')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0003', N'PLY-0001', N'CUST-0006', CAST(N'2020-07-17' AS Date), 0.0000, N'AAA', N'-       ', N'JAL-0002', N'AA', N'Diproses', NULL, N'Belum')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0004', N'PLY-0001', N'CUST-0006', CAST(N'2020-07-17' AS Date), 0.0000, N'AAAAAA', N'-       ', N'JAL-0002', N'AA', N'Diproses', NULL, N'Belum')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0005', N'PLY-0001', N'CUST-0005', CAST(N'2020-07-17' AS Date), 0.0000, N'Mati Total', N'-       ', N'JAL-0001', N'Asus ROG', N'Diproses', NULL, N'Belum')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0006', N'PLY-0001', N'CUST-0006', CAST(N'2020-07-17' AS Date), 0.0000, N'AAA', N'-       ', N'JAL-0001', N'ALE-0002', N'Diproses', NULL, N'Belum')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0007', N'PLY-0001', N'CUST-0005', CAST(N'2020-07-18' AS Date), 0.0000, N'Mati Total', N'GDG-0001', N'JAL-0001', N'ALE-0001', N'Diproses', NULL, N'Belum')
INSERT [dbo].[treparasialat] ([no_transaksi_reparasi], [id_pelayan], [id_customer], [tanggal_reparasi], [total], [keluhan], [id_gudang], [id_jenis], [alat_elektronik], [status], [biaya], [status_pembayaran]) VALUES (N'TBA-0008', N'PLY-0001', N'CUST-0006', CAST(N'2020-07-18' AS Date), 2100000.0000, N'Mati Total V2', N'GDG-0001', N'JAL-0001', N'ALE-0001', N'Selesai', 100000, N'Lunas')
INSERT [dbo].[trestockalatkerja] ([no_transaksi_pembelian], [id_pelayan], [tanggal_pembelian], [total], [jumlah_jenis], [jumlah_alat]) VALUES (N'TRA-0001', N'PLY-0001', CAST(N'2020-07-02' AS Date), 129000.0000, NULL, NULL)
INSERT [dbo].[trestockalatkerja] ([no_transaksi_pembelian], [id_pelayan], [tanggal_pembelian], [total], [jumlah_jenis], [jumlah_alat]) VALUES (N'TRA-0002', N'PLY-0001', CAST(N'2020-07-19' AS Date), 45.0000, NULL, NULL)
INSERT [dbo].[trestockalatkerja] ([no_transaksi_pembelian], [id_pelayan], [tanggal_pembelian], [total], [jumlah_jenis], [jumlah_alat]) VALUES (N'TRA-0003', N'PLY-0001', CAST(N'2020-07-19' AS Date), 150000.0000, NULL, NULL)
INSERT [dbo].[trestockalatkerja] ([no_transaksi_pembelian], [id_pelayan], [tanggal_pembelian], [total], [jumlah_jenis], [jumlah_alat]) VALUES (N'TRA-0004', N'PLY-0001', CAST(N'2020-07-19' AS Date), 15000.0000, NULL, NULL)
INSERT [dbo].[trestockalatkerja] ([no_transaksi_pembelian], [id_pelayan], [tanggal_pembelian], [total], [jumlah_jenis], [jumlah_alat]) VALUES (N'TRA-0005', N'PLY-0001', CAST(N'2020-07-19' AS Date), 72000.0000, 2, 5)
INSERT [dbo].[trestockkomponen] ([no_pembelian_komponen], [id_pelayan], [tanggal_pembelian], [total_jenis], [jumlah_komponen], [total_harga]) VALUES (N'trk-0001 ', N'PLY-0001', CAST(N'2020-07-09' AS Date), 1, 1, 7000.0000)
INSERT [dbo].[trestockkomponen] ([no_pembelian_komponen], [id_pelayan], [tanggal_pembelian], [total_jenis], [jumlah_komponen], [total_harga]) VALUES (N'trk-0002 ', N'PLY-0001', CAST(N'2020-07-09' AS Date), 3, 3, 1200.0000)
INSERT [dbo].[trestockkomponen] ([no_pembelian_komponen], [id_pelayan], [tanggal_pembelian], [total_jenis], [jumlah_komponen], [total_harga]) VALUES (N'trk-0003 ', N'PLY-0001', CAST(N'2020-07-09' AS Date), 1, 1, 600.0000)
INSERT [dbo].[trestockkomponen] ([no_pembelian_komponen], [id_pelayan], [tanggal_pembelian], [total_jenis], [jumlah_komponen], [total_harga]) VALUES (N'trk-0004 ', N'PLY-0001', CAST(N'2020-07-09' AS Date), 13, 13, 31500.0000)
ALTER TABLE [dbo].[msalatelektronik]  WITH CHECK ADD  CONSTRAINT [FK_msalatelektronik_msjeniselektronik] FOREIGN KEY([id_jenis])
REFERENCES [dbo].[msjeniselektronik] ([id_jenis])
GO
ALTER TABLE [dbo].[msalatelektronik] CHECK CONSTRAINT [FK_msalatelektronik_msjeniselektronik]
GO
ALTER TABLE [dbo].[msalatsupplier]  WITH CHECK ADD FOREIGN KEY([id_alat])
REFERENCES [dbo].[msalatkerja] ([id_alat])
GO
ALTER TABLE [dbo].[msalatsupplier]  WITH CHECK ADD FOREIGN KEY([id_supplier])
REFERENCES [dbo].[mssupplier] ([id_supplier])
GO
ALTER TABLE [dbo].[mskomponen]  WITH CHECK ADD  CONSTRAINT [FK_mskomponen_msalatelektronik] FOREIGN KEY([id_alat])
REFERENCES [dbo].[msalatelektronik] ([id_alat])
GO
ALTER TABLE [dbo].[mskomponen] CHECK CONSTRAINT [FK_mskomponen_msalatelektronik]
GO
ALTER TABLE [dbo].[mskomponensupplier]  WITH CHECK ADD FOREIGN KEY([id_supplier])
REFERENCES [dbo].[mssupplier] ([id_supplier])
GO
ALTER TABLE [dbo].[tbelikomponen]  WITH CHECK ADD FOREIGN KEY([id_customer])
REFERENCES [dbo].[mscustomer] ([id_customer])
GO
ALTER TABLE [dbo].[tbelikomponen]  WITH CHECK ADD FOREIGN KEY([id_pelayan])
REFERENCES [dbo].[msbagianpelayan] ([id_pelayan])
GO
ALTER TABLE [dbo].[tdetailbelikomponen]  WITH CHECK ADD FOREIGN KEY([id_komponen])
REFERENCES [dbo].[mskomponen] ([id_komponen])
GO
ALTER TABLE [dbo].[tdetailreparasialat]  WITH CHECK ADD FOREIGN KEY([id_komponen])
REFERENCES [dbo].[mskomponen] ([id_komponen])
GO
ALTER TABLE [dbo].[tdetailreparasialat]  WITH CHECK ADD FOREIGN KEY([no_transaksi_reparasi])
REFERENCES [dbo].[treparasialat] ([no_transaksi_reparasi])
GO
ALTER TABLE [dbo].[tdetailrestock]  WITH CHECK ADD FOREIGN KEY([no_pembelian_komponen])
REFERENCES [dbo].[trestockkomponen] ([no_pembelian_komponen])
GO
ALTER TABLE [dbo].[tdrestockalatkerja]  WITH CHECK ADD  CONSTRAINT [FK_tdrestockalatkerja_msalatkerja] FOREIGN KEY([id_alat])
REFERENCES [dbo].[msalatkerja] ([id_alat])
GO
ALTER TABLE [dbo].[tdrestockalatkerja] CHECK CONSTRAINT [FK_tdrestockalatkerja_msalatkerja]
GO
ALTER TABLE [dbo].[tdrestockalatkerja]  WITH CHECK ADD  CONSTRAINT [FK_tdrestockalatkerja_mssupplier] FOREIGN KEY([id_supplier])
REFERENCES [dbo].[mssupplier] ([id_supplier])
GO
ALTER TABLE [dbo].[tdrestockalatkerja] CHECK CONSTRAINT [FK_tdrestockalatkerja_mssupplier]
GO
ALTER TABLE [dbo].[tdrestockalatkerja]  WITH CHECK ADD  CONSTRAINT [FK_tdrestockalatkerja_trestockalatkerja] FOREIGN KEY([no_transaksi_pembelian])
REFERENCES [dbo].[trestockalatkerja] ([no_transaksi_pembelian])
GO
ALTER TABLE [dbo].[tdrestockalatkerja] CHECK CONSTRAINT [FK_tdrestockalatkerja_trestockalatkerja]
GO
ALTER TABLE [dbo].[treparasialat]  WITH CHECK ADD FOREIGN KEY([id_jenis])
REFERENCES [dbo].[msjeniselektronik] ([id_jenis])
GO
ALTER TABLE [dbo].[treparasialat]  WITH CHECK ADD FOREIGN KEY([id_jenis])
REFERENCES [dbo].[msjeniselektronik] ([id_jenis])
GO
ALTER TABLE [dbo].[treparasialat]  WITH CHECK ADD  CONSTRAINT [FK_treparasialat_mscustomer] FOREIGN KEY([id_customer])
REFERENCES [dbo].[mscustomer] ([id_customer])
GO
ALTER TABLE [dbo].[treparasialat] CHECK CONSTRAINT [FK_treparasialat_mscustomer]
GO
ALTER TABLE [dbo].[trestockkomponen]  WITH CHECK ADD FOREIGN KEY([id_pelayan])
REFERENCES [dbo].[msbagianpelayan] ([id_pelayan])
GO
/****** Object:  StoredProcedure [dbo].[sp_cariAkunPelayan]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariAkunPelayan]
		@username char(25),
		@password char(30)
as
begin
	select * from msbagianpelayan
	where username = @username and password = @password
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariAlatElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariAlatElektronik]
		@id_alat char(8),
		@nama_alat varchar(30),
		@id_jenis char(8)
as
begin
	select * from msalatelektronik
	where id_alat = @id_alat or 
	nama_alat = @nama_alat or
	id_jenis = @id_jenis
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariAlatKerja]
		@id_alat	char(9),
		@nama_alat	varchar(25),
		@jumlah int,
		@rusak int,
		@bagus int
as
begin
	select * from msalatkerja
	where id_alat = @id_alat or 
	@nama_alat = nama_alat or
	@jumlah = jumlah or
	@rusak = rusak or
	@bagus = bagus
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariCustomer]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_cariCustomer]
		@id_customer	char(9),
		@nama_customer	varchar(50)

as
begin
	select * from mscustomer
	where id_customer = @id_customer or 
	@nama_customer = nama_customer
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariGudang]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariGudang]
		@id_gudang char(8),
		@nama_gudang varchar(30),
		@jenis_kelamin varchar(9),
		@alamat varchar(100),
		@email varchar(30),
		@no_telepon varchar(15),
		@status varchar(11)
as
begin
	select * from msbagiangudang
	where id_gudang = @id_gudang or 
	nama_gudang = @nama_gudang or
	jenis_kelamin = @jenis_kelamin or
	alamat = @alamat or
	email = @email or
	no_telepon = @no_telepon or
	status = @status
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariJenisElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariJenisElektronik]
		@id_jenis char(8),
		@nama_jenis varchar(30)
as
begin
	select * from msjeniselektronik
	where id_jenis = @id_jenis or 
	nama_jenis = @nama_jenis
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariKomponen]
		@id_komponen char(8),
		@nama_komponen varchar(30),
		@jumlah int,
		@harga_jual money,
		@id_alat char(8),
		@tempat varchar(4)
as
begin
	select * from mskomponen
	where id_komponen = @id_komponen or 
	nama_komponen = @nama_komponen or
	jumlah = @jumlah or
	harga_jual = @harga_jual or
	id_alat = @id_alat or
	tempat = @tempat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariKomponenByIDAlat]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariKomponenByIDAlat]
		@nama_komponen varchar(30),
		@id_alat char(8)
as
begin
	select * from mskomponen
	where 
	nama_komponen = @nama_komponen and
	id_alat = @id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariKomponenByNamaSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_cariKomponenByNamaSupplier]
		@nama_komponen varchar(30),
		@nama_supplier varchar(50)
as
begin
	select mks.id_komponen from mskomponensupplier mks
	inner join mssupplier ms on ms.id_supplier = mks.id_supplier
	inner join mskomponen mk on mk.id_komponen = mks.id_komponen
	where ms.nama_supplier = @nama_supplier and mk.nama_komponen = @nama_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariPelayan]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_cariPelayan]
		@id_pelayan char(8),
		@nama_pelayan varchar(50),
		@jenis_kelamin varchar(9),
		@alamat varchar(100),
		@email varchar(30),
		@no_telepon varchar(15),
		@status varchar(11)
as
begin
	select * from msbagianpelayan
	where id_pelayan = @id_pelayan or 
	nama_pelayan = @nama_pelayan or
	jenis_kelamin = @jenis_kelamin or
	alamat = @alamat or
	email = @email or
	no_telepon = @no_telepon or
	status = @status
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariPenyimpananx]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariPenyimpananx]
		@nama_komponen	varchar(50)
as
begin
	select * from mspenyimpananx
	where @nama_komponen = nama_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariSamaAlatKerjaSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariSamaAlatKerjaSupplier]
		@id_alat	char(9),
		@id_supplier	char(9)
as
begin
	select * from msalatsupplier
	where id_alat = @id_alat and 
	@id_supplier = id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariSamaKomponenSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cariSamaKomponenSupplier]
		@id_komponen	char(9),
		@id_supplier char(9)
as
begin
	select * from mskomponensupplier
	where id_komponen = @id_komponen and
	@id_supplier = id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cariSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_cariSupplier]
		@id_supplier	char(9),
		@nama_supplier	varchar(25),
		@contact_person	varchar(25),
		@no_telepon		varchar(15),
		@alamat			varchar(100),
		@keterangan		varchar(100)
as
begin
	select * from mssupplier
	where id_supplier = @id_supplier or 
	@nama_supplier = nama_supplier or
	@contact_person = contact_person or
	@no_telepon = no_telepon or
	@alamat = alamat or
	@keterangan = keterangan
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteAlatElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_deleteAlatElektronik]
	@id_alat char (8)
as
begin
	delete from msalatelektronik where id_alat = @id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[sp_deleteAlatKerja]
	@id_alat char(9)
as
begin
	delete from msalatkerja where id_alat = @id_alat
end


set ansi_nulls on

GO
/****** Object:  StoredProcedure [dbo].[sp_deleteAlatSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_deleteAlatSupplier]
	@id_alat char(9)
as
begin
	delete from msalatsupplier where id_alat = @id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteCustomer]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[sp_deleteCustomer]
	@id_customer char(9)
as
begin
	delete from mscustomer where id_customer = @id_customer
end


set ansi_nulls on

GO
/****** Object:  StoredProcedure [dbo].[sp_deleteGudang]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_deleteGudang]
	@id_gudang char(8)
as
begin
	delete from msbagiangudang where id_gudang = @id_gudang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteJenisElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_deleteJenisElektronik]
	@id_jenis char (8)
as
begin
	delete from msjeniselektronik where id_jenis = @id_jenis
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_deleteKomponen]
	@id_komponen char (8)
as
begin
	delete from mskomponen where id_komponen = @id_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteKomponenSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[sp_deleteKomponenSupplier]
	@id_komponen char(9)
as
begin
	delete from mskomponensupplier where id_komponen = @id_komponen
end


set ansi_nulls on

GO
/****** Object:  StoredProcedure [dbo].[sp_deletePelayan]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_deletePelayan]
	@id_pelayan char(8)
as
begin
	delete from msbagianpelayan where id_pelayan = @id_pelayan
end
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[sp_deleteSupplier]
	@id_supplier char(9)
as
begin
	delete from mssupplier where id_supplier = @id_supplier
end


set ansi_nulls on

GO
/****** Object:  StoredProcedure [dbo].[sp_getAllAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getAllAlatKerja]
as
begin
	select nama_alat as AlatKerja, 
	jumlah as Jumlah, rusak as [Jumlah Rusak], bagus as [Jumlah Bagus] from msalatkerja
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllDetailRestockAlat]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAllDetailRestockAlat]
as
begin
select distinct(tra.no_transaksi_pembelian), tra.jumlah_jenis, tra.jumlah_alat,tra.total,tra.tanggal_pembelian from trestockalatkerja tra
inner join tdrestockalatkerja tdr on tdr.no_transaksi_pembelian = tra.no_transaksi_pembelian
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllDetailRestockAlatByKode]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAllDetailRestockAlatByKode]
	@no_transaksi_pembelian char(8)
as
begin
	select mk.nama_alat, ms.nama_supplier, tdr.jumlah, tdr.harga, tdr.status from tdrestockalatkerja tdr
	inner join msalatkerja mk on mk.id_alat = tdr.id_alat
	inner join mssupplier ms on ms.id_supplier = tdr.id_supplier
	where tdr.no_transaksi_pembelian = @no_transaksi_pembelian
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllDetailRestockAlatbyStatus]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAllDetailRestockAlatbyStatus]
@status varchar(10)
as
	
begin
select distinct(tra.no_transaksi_pembelian), tra.jumlah_jenis, tra.jumlah_alat,tra.total,tra.tanggal_pembelian from trestockalatkerja tra
inner join tdrestockalatkerja tdr on tdr.no_transaksi_pembelian = tra.no_transaksi_pembelian
where tdr.status = @status
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAllKomponen]	
as
begin
	select ROW_NUMBER() over(order by k.jumlah asc) No, k.nama_komponen as Komponen, ma.nama_alat as Barang, convert(numeric(10,2), k.harga_jual) as [Harga satuan], k.jumlah as Jumlah from mskomponen k
inner join msalatelektronik ma on k.id_alat = ma.id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllKomponenByNama]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAllKomponenByNama]	
	@Komponen varchar(50)
as
begin
	select ROW_NUMBER() over(order by k.jumlah asc) No, k.nama_komponen as Komponen, ma.nama_alat as Barang, convert(numeric(10,2), k.harga_jual) as [Harga satuan], k.jumlah as Jumlah from mskomponen k
inner join msalatelektronik ma on k.id_alat = ma.id_alat where k.nama_komponen = @Komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAlltdetailrestock]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getAlltdetailrestock]
	@no_pembelian_komponen char(9)
as
begin
select k.nama_komponen as Komponen, s.nama_supplier as Supplier, tdr.jumlah as Jumlah, convert(numeric(10,2), tdr.total_harga) as [Harga], tdr.status from tdetailrestock tdr
 inner join mskomponen k on tdr.id_komponen = k.id_komponen
 inner join mssupplier s on tdr.id_supplier = s.id_supplier where tdr.no_pembelian_komponen = @no_pembelian_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getAlltrestockkomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getAlltrestockkomponen]
	
as
begin
	select no_pembelian_komponen as [Kode], total_jenis as [Macam barang], jumlah_komponen as [Jumlah komponen], convert(numeric(10,2), total_harga) as [Total harga],tanggal_pembelian as Tanggal from trestockkomponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getDetailReparasi]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getDetailReparasi]
	@no_transaksi_reparasi char(8)
as
begin
	select * from viewbayardetailreparasi
	where no_transaksi_reparasi = @no_transaksi_reparasi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getRestockByStatus]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getRestockByStatus]
	@status varchar(6)
as
begin
	select * from
	(select distinct trk.no_pembelian_komponen as [Kode], trk.total_jenis as [Macam barang], trk.jumlah_komponen as [Jumlah komponen], convert(numeric(10,2), trk.total_harga) as [Total harga],trk.tanggal_pembelian as Tanggal from trestockkomponen trk inner join
	tdetailrestock tdr on trk.no_pembelian_komponen = tdr.no_pembelian_komponen where tdr.status = @status) Base
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getSupplierAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getSupplierAlatKerja]
	@nama_alat varchar(30)
as
begin
	select distinct [mssupplier].nama_supplier,
                    convert(numeric(10, 2), harga) as [Harga(Rp)] from[msalatsupplier] aks inner join[msalatkerja] ak 
                    on aks.id_alat = ak.id_alat inner join[mssupplier] on[mssupplier].id_supplier = aks.id_supplier where ak.nama_alat = @nama_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputAlatElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputAlatElektronik]
	@id_alat char (8),
	@nama_alat varchar(30),
	@id_jenis char(8)
as
begin
	insert into msalatelektronik values(
		@id_alat,
		@nama_alat,
		@id_jenis
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputAlatKerja]
		@id_alat	char(9),
		@nama_alat	varchar(50),
		@jumlah		integer,
		@rusak		integer,
		@bagus		integer
as
begin
	insert into msalatkerja values(
		@id_alat,
		@nama_alat,
		@jumlah,
		@rusak,
		@bagus)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputAlatSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputAlatSupplier]
		@id_alat	char(9),
		@id_supplier char(9),
		@harga	money,
		@total_transaksi integer
as
begin
	insert into msalatsupplier values(
		@id_alat,
		@id_supplier,
		@harga,
		@total_transaksi)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputCustomer]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_inputCustomer]
		@id_customer	char(9),
		@nama_customer	varchar(50),
		@path		varchar(100)
as
begin
	insert into mscustomer values(
		@id_customer,
		@nama_customer,
		0,
		@path)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_inputGudang]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputGudang]
	@id_gudang char (8),
	@nama_gudang varchar(50),
	@jenis_kelamin varchar(9),
	@alamat varchar(100),
	@email varchar(30),
	@no_telepon varchar(15),
	@status varchar(11)
as
begin
	insert into msbagiangudang values(
		@id_gudang,
		@nama_gudang,
		@jenis_kelamin,
		@alamat,
		@email,
		@no_telepon,
		@status
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputJenisElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputJenisElektronik]
	@id_jenis char (8),
	@nama_jenis	varchar(30)
as
begin
	insert into msjeniselektronik values(
		@id_jenis,
		@nama_jenis
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputKomponen]
	@id_komponen char (8),
	@nama_komponen varchar(30),
	@jumlah int,
	@harga_jual money,
	@id_alat char(8),
	@tempat varchar(4)
as
begin
	insert into mskomponen values(
		@id_komponen,
		@nama_komponen,
		@jumlah,
		@harga_jual,
		@id_alat,
		@tempat
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputKomponenSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputKomponenSupplier]
		@id_komponen	char(9),
		@id_supplier char(9),
		@harga	money,
		@total_transaksi integer
as
begin
	insert into mskomponensupplier values(
		@id_komponen,
		@id_supplier,
		@harga,
		@total_transaksi)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputPelayan]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputPelayan]
	@id_pelayan char (8),
	@nama_pelayan varchar(50),
	@jenis_kelamin varchar(9),
	@alamat varchar(100),
	@email varchar(30),
	@no_telepon varchar(15),
	@status varchar(11)
as
begin
	insert into msbagianpelayan values(
		@id_pelayan,
		@nama_pelayan,
		@jenis_kelamin,
		@alamat,
		@email,
		@no_telepon,
		@status
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputSupplier]
		@id_supplier	char(9),
		@nama_supplier	varchar(25),
		@contact_person	varchar(25),
		@no_telepon		varchar(15),
		@alamat			varchar(100),
		@keterangan		varchar(100)
as
begin
	insert into mssupplier values(
		@id_supplier	,
		@nama_supplier	,
		@contact_person	,
		@no_telepon		,
		@alamat			,
		@keterangan		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTBeliKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputTBeliKomponen]
		@no_transaksi_pembelian	char(9),
		@tanggal_transaksi	date,
		@jumlah_komponen int,
		@total_jenis	int,
		@total_harga money,
		@id_pelayan char(9),
		@id_customer char(9)
as
begin
	insert into tbelikomponen values(
		@no_transaksi_pembelian,
		@tanggal_transaksi,
		@jumlah_komponen,
		@total_jenis,
		@total_harga,
		@id_pelayan,
		@id_customer
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTDetailBeliKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputTDetailBeliKomponen]
		@no_transaksi_pembelian	char(9),
		@id_komponen char(9),
		@jumlah int,
		@total_harga money		
as
begin
	insert into tdetailbelikomponen values(
		@no_transaksi_pembelian,
		@id_komponen,
		@jumlah,
		@total_harga
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTDetailReparasi]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_inputTDetailReparasi]
	@no_transaksi_reparasi char(8),
	@id_komponen char(8),
	@jumlah_komponen int,
	@harga money
as
begin
	insert into tdetailreparasialat values(
	@no_transaksi_reparasi,
	@id_komponen,
	@jumlah_komponen, 
	@harga
	)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTDetailStock]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_inputTDetailStock]
		@no_pembelian_komponen	char(9),
		@id_komponen	char(9),
		@id_supplier char(9),
		@jumlah	int,
		@total_harga money
as
begin
	insert into tdetailrestock values(
		@no_pembelian_komponen,
		@id_komponen,
		@id_supplier,
		@jumlah,
		@total_harga,
		'Proses'
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTDRestockAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_inputTDRestockAlatKerja]
		@no_transaksi_pembelian	varchar(8),
		@id_supplier char(9),
		@id_alat char(9),
		@jumlah int,
		@harga money
as
begin
	insert into tdrestockalatkerja values(
		@no_transaksi_pembelian,
		@id_supplier,
		@id_alat,
		@jumlah,
		@harga,
		'Proses'
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTransaksiBeliKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inputTransaksiBeliKomponen]	
	@no_transaksi_pembelian char(9),
	@tanggal_transaksi char(9),
	@jumlah_komponen int,
	@jumlah_jenis int,
	@total_harga money,
	@id_pelayan char(9),
	@id_customer char(9)
as
begin
	insert into tbelikomponen values(
	@no_transaksi_pembelian, @tanggal_transaksi, @jumlah_komponen, @jumlah_jenis, @total_harga, @id_pelayan, @id_pelayan
	)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTransaksiReparasiAlat]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_inputTransaksiReparasiAlat]
	@no_transaksi_reparasi char(8),
	@id_pelayan char(8),
	@id_customer char(9),
	@tanggal_reparasi date,
	@keluhan varchar(100),
	@id_gudang char(8),
	@id_jenis char(8),
	@alat_elektronik varchar(30)
as
begin
	insert into treparasialat values(
	@no_transaksi_reparasi,
	@id_pelayan,
	@id_customer, 
	@tanggal_reparasi,
	0,
	@keluhan,
	@id_gudang,
	@id_jenis,
	@alat_elektronik,
	'Diproses',
	0,
	'Belum'
	)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTRestockAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_inputTRestockAlatKerja]
		@no_transaksi_pembelian	varchar(8),
		@id_pelayan char(8),
		@tanggal_pembelian date,
		@total money,
		@jenis int,
		@jumlah int
as
begin
	insert into trestockalatkerja values(
		@no_transaksi_pembelian,
		@id_pelayan,
		@tanggal_pembelian,
		@total,
		@jenis,
		@jumlah
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_inputTRestockKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_inputTRestockKomponen]
		@no_pembelian_komponen	char(9),
		@id_pelayan char(8),
		@tanggal_pembelian	date,
		@total_jenis	int,
		@jumlah_komponen int,
		@total_harga money
as
begin
	insert into trestockkomponen values(
		@no_pembelian_komponen,
		@id_pelayan,
		@tanggal_pembelian,
		@total_jenis,
		@jumlah_komponen,
		@total_harga
		)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_reparasiselesai]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_reparasiselesai]
	@no_transaksi_reparasi char(8),
	@id_gudang char(8),
	@total int,
	@biaya int,
	@status varchar(10)
as
begin
	update treparasialat
	set id_gudang = @id_gudang, status = @status, total = @total, biaya = @biaya
	where no_transaksi_reparasi = @no_transaksi_reparasi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_setJumlahKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_setJumlahKomponen]
	@id_komponen char(9),
	@jumlah int
as
begin
	update mskomponen
	set jumlah = jumlah+@jumlah where id_komponen = @id_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_setStatusDetailRestock]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_setStatusDetailRestock]
	@status varchar(6),
	@id_komponen char(9),
	@no_pembelian_komponen char(9)
as
begin
	update tdetailrestock
	set status = @status where no_pembelian_komponen = @no_pembelian_komponen and id_komponen = @id_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_setTotalTransaksiAlat]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_setTotalTransaksiAlat]
	@id_alat char(10),
	@id_supplier char(10)
	as
	begin
update msalatsupplier
set total_transaksi = total_transaksi + 1
where id_alat = @id_alat and id_supplier = @id_supplier
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_setTotalTransaksiKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_setTotalTransaksiKomponen]	
	@id_komponen char(9),
	@id_supplier char(9)
as
begin
	update mskomponensupplier
	set total_transaksi = total_transaksi+1 where id_komponen = @id_komponen and id_supplier = @id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summsalatelektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summsalatelektronik]
as
begin
	select count(id_alat) total from msalatelektronik -- = id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summsalatkerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summsalatkerja]
as
begin
	select count (id_alat) total from msalatkerja -- = id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summsalatsupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summsalatsupplier]
as
begin
	select count(id_alat) total from (select id_alat, id_supplier from msalatsupplier) base -- = (id_alat & id_supplier)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summsbagiangudang]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summsbagiangudang]
as
begin
	select count(id_gudang) total from msbagiangudang --= id_gudang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summsbagianpelayan]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summsbagianpelayan]
as
begin
	select count(id_pelayan) total from msbagianpelayan --= id_pelayan
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summscustomer]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summscustomer]
as
begin
	select count(id_customer) total from mscustomer-- = id_customer
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summsjeniselektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summsjeniselektronik]
as
begin
	select count(id_jenis) total from msjeniselektronik --= id_jenis
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summskomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summskomponen]
as
begin
	select count(id_komponen) total from mskomponen --= id_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summskomponensupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summskomponensupplier]
as
begin
	select count(id_komponen) total from (select id_komponen, id_supplier from mskomponensupplier) base-- = id_komponen & id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_summssupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_summssupplier]
as
begin
	select count(id_supplier) total from mssupplier --= id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateAlatElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateAlatElektronik]
	@id_alat char (8),
	@nama_alat varchar(30),
	@id_jenis char(8)
as
begin
	update msalatelektronik set
		nama_alat = @nama_alat,
		id_jenis = @id_jenis
	where id_alat = @id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateAlatKerja]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateAlatKerja]
		@id_alat	char(9),
		@nama_alat	varchar(50),
		@jumlah		integer,
		@rusak		integer,
		@bagus		integer
as
begin
	update msalatkerja set
		nama_alat = @nama_alat,
		jumlah = @jumlah,
		rusak = @rusak,
		bagus = @bagus
	where id_alat = @id_alat
end

set ansi_nulls on

GO
/****** Object:  StoredProcedure [dbo].[sp_updateAlatKerja1]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateAlatKerja1]
		@id_alat	char(9),
		@jumlah		integer,
		@bagus		integer
as
begin
	update msalatkerja set
		jumlah = jumlah + @jumlah,
		bagus = bagus + @bagus
	where id_alat = @id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateAlatSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateAlatSupplier]
		@id_alat	char(9),
		@id_supplier char(9),
		@harga	money,
		@total_transaksi integer
as
begin
	update msalatsupplier set
		id_supplier = @id_supplier,
		harga = @harga,
		total_transaksi = @total_transaksi
	where id_alat = @id_alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateAlatSupplierHarga]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateAlatSupplierHarga]
		@id_alat	char(9),
		@id_supplier char(9),
		@harga	money
as
begin
	update msalatsupplier set
		harga = @harga
	where id_alat = @id_alat and id_supplier = @id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateAlatSupplierTransaksi]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateAlatSupplierTransaksi]
		@id_alat	char(9),
		@id_supplier char(9),
		@total_transaksi integer
as
begin
	update msalatsupplier set
		total_transaksi = @total_transaksi
	where id_alat = @id_alat and id_supplier = @id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCustomer]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateCustomer]
		@id_customer char(9),
		@nama_customer varchar(50),
		@total_transaksi integer
as
begin
	update mscustomer set
		nama_customer = @nama_customer,
		total_transaksi = @total_transaksi
	where id_customer = @id_customer
end

set ansi_nulls on

GO
/****** Object:  StoredProcedure [dbo].[sp_updateGudang]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateGudang]
	@id_gudang char (8),
	@nama_gudang varchar(50),
	@jenis_kelamin varchar(9),
	@alamat varchar(100),
	@email varchar(30),
	@no_telepon varchar(15),
	@status varchar(11)
as
begin
	update msbagiangudang set
		nama_gudang = @nama_gudang,
		jenis_kelamin = @jenis_kelamin,
		alamat = @alamat,
		email = @email,
		no_telepon = @no_telepon,
		status = @status
	where id_gudang = @id_gudang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateJenisElektronik]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateJenisElektronik]
	@id_jenis char (8),
	@nama_jenis	varchar(30)
as
begin
	update msjeniselektronik set
		nama_jenis = @nama_jenis
	where id_jenis = @id_jenis
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateJumlahKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateJumlahKomponen]
	@id_komponen char (8),
	@jumlah int
as
begin
	update mskomponen set
		jumlah = jumlah - @jumlah
	where id_komponen = @id_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateKomponen]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateKomponen]
	@id_komponen char (8),
	@nama_komponen varchar(30),
	@jumlah int,
	@harga_jual money,
	@id_alat char(8),
	@tempat varchar(4)
as
begin
	update mskomponen set
		nama_komponen = @nama_komponen,
		jumlah = @jumlah,
		harga_jual = @harga_jual,
		id_alat = @id_alat,
		tempat = @tempat
	where id_komponen = @id_komponen
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateKomponenSupplierHarga]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateKomponenSupplierHarga]
		@id_komponen	char(9),
		@id_supplier char(9),
		@harga	money
as
begin
	update mskomponensupplier set
		harga = @harga
	where id_komponen = @id_komponen and id_supplier = @id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateKomponenSupplierTransaksi]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateKomponenSupplierTransaksi]
		@id_komponen	char(9),
		@id_supplier char(9),
		@total_transaksi integer
as
begin
	update mskomponensupplier set
		total_transaksi = @total_transaksi
	where id_komponen = @id_komponen and id_supplier = @id_supplier
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updatePelayan]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updatePelayan]
	@id_pelayan char (8),
	@nama_pelayan varchar(50),
	@jenis_kelamin varchar(9),
	@alamat varchar(100),
	@email varchar(30),
	@no_telepon varchar(15),
	@status varchar(11)
as
begin
	update msbagianpelayan set
		nama_pelayan = @nama_pelayan,
		jenis_kelamin = @jenis_kelamin,
		alamat = @alamat,
		email = @email,
		no_telepon = @no_telepon,
		status = @status
	where id_pelayan = @id_pelayan
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updatestatuspembayaranreparasi]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updatestatuspembayaranreparasi]	
	@no_transaksi_reparasi char(8)
as
begin
	update treparasialat
	set status_pembayaran = 'Lunas'
	where no_transaksi_reparasi = @no_transaksi_reparasi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateStatusTRA]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateStatusTRA]
	@kode char(8),
	@supplier char(10),
	@alat char(10),
	@status varchar(10)
as
begin
update tdrestockalatkerja
set status = @status
where no_transaksi_pembelian = @kode
and id_supplier = @supplier
and id_alat = @alat
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateSupplier]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateSupplier]
		@id_supplier	char(9),
		@nama_supplier	varchar(25),
		@contact_person	varchar(25),
		@no_telepon		varchar(15),
		@alamat			varchar(100),
		@keterangan		varchar(100)
as
begin
	update mssupplier set
		nama_supplier = @nama_supplier,
		contact_person = @contact_person,
		no_telepon = @no_telepon,
		alamat = @alamat,
		keterangan = @keterangan
	where id_supplier = @id_supplier
end

set ansi_nulls on

GO
/****** Object:  StoredProcedure [dbo].[sp_updateTransaksiCustomer]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateTransaksiCustomer]
		@id_customer char(9)
as
begin
	update mscustomer
		set total_transaksi = total_transaksi + 1
	where id_customer = @id_customer
end
GO
/****** Object:  StoredProcedure [dbo].[sp_viewprosesreparasialat]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_viewprosesreparasialat]	
	@status varchar(10)
as
begin
	select * from viewprosesreparasialat
	where Status = @status

end
GO
/****** Object:  StoredProcedure [dbo].[sp_viewprosesreparasialat1]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_viewprosesreparasialat1]	
	
as
begin
	select * from viewprosesreparasialat

end
GO
/****** Object:  StoredProcedure [dbo].[sp_viewselesaireparasialat]    Script Date: 20/07/2020 19:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_viewselesaireparasialat]	
	@nama varchar(50)
as
begin
	select * from viewselesaireparasialat
	where Pelanggan = @nama

end
GO
USE [master]
GO
ALTER DATABASE [SakuraData] SET  READ_WRITE 
GO
