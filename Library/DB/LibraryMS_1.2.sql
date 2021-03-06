USE [master]
GO
/****** Object:  Database [LibraryMS]    Script Date: 2021/1/2 3:15:47 ******/
CREATE DATABASE [LibraryMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LibraryMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LibraryMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LibraryMS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LibraryMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryMS] SET RECOVERY FULL 
GO
ALTER DATABASE [LibraryMS] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibraryMS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LibraryMS', N'ON'
GO
ALTER DATABASE [LibraryMS] SET QUERY_STORE = OFF
GO
USE [LibraryMS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
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
USE [LibraryMS]
GO
/****** Object:  Table [dbo].[book]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[b_isbn] [nvarchar](20) NOT NULL,
	[b_name] [nvarchar](50) NOT NULL,
	[t_id] [int] NULL,
	[b_author] [nvarchar](50) NOT NULL,
	[b_press] [nvarchar](50) NOT NULL,
	[b_time] [int] NOT NULL,
	[b_price] [decimal](6, 2) NOT NULL,
	[b_count] [int] NULL,
	[b_stocks] [int] NOT NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[b_isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[type]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type](
	[t_id] [int] IDENTITY(0,1) NOT NULL,
	[t_name] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_type] PRIMARY KEY CLUSTERED 
(
	[t_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_bookPage]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_bookPage]
AS
SELECT   dbo.book.b_isbn, dbo.book.b_name, dbo.type.t_name, dbo.book.b_author, dbo.book.b_press, dbo.book.b_time, 
                dbo.book.b_price, dbo.book.b_stocks
FROM      dbo.book INNER JOIN
                dbo.type ON dbo.book.t_id = dbo.type.t_id
GO
/****** Object:  View [dbo].[V_listBook]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_listBook]
AS
SELECT   dbo.book.b_isbn, dbo.book.b_name, dbo.type.t_name, dbo.book.b_author, dbo.book.b_press, dbo.book.b_time, 
                dbo.book.b_price, CASE b_stocks WHEN 0 THEN '不可借' ELSE '可借' END AS b_stocks
FROM      dbo.book INNER JOIN
                dbo.type ON dbo.book.t_id = dbo.type.t_id
GO
/****** Object:  Table [dbo].[books]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[b_id] [int] IDENTITY(0,1) NOT NULL,
	[b_isbn] [nvarchar](20) NOT NULL,
	[b_lend] [int] NOT NULL,
 CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
(
	[b_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[borrow]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[borrow](
	[bo_id] [int] IDENTITY(0,1) NOT NULL,
	[a_id] [int] NULL,
	[b_id] [int] NOT NULL,
	[b_isbn] [nvarchar](20) NOT NULL,
	[u_id] [int] NOT NULL,
	[bo_borrow] [date] NOT NULL,
	[bo_return] [date] NOT NULL,
	[bo_rtnatl] [date] NULL,
	[bo_day] [int] NOT NULL,
	[bo_renewday] [int] NOT NULL,
	[bo_renew] [int] NOT NULL,
	[bo_eme] [int] NOT NULL,
	[bo_dayover] [int] NOT NULL,
	[bo_emeover] [int] NOT NULL,
 CONSTRAINT [PK_borrow] PRIMARY KEY CLUSTERED 
(
	[bo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Borrow]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Borrow]
AS
SELECT   dbo.borrow.bo_id, dbo.book.b_name, dbo.borrow.bo_borrow, dbo.borrow.bo_return, dbo.borrow.bo_renewday, 
                CASE bo_renew WHEN 0 THEN '有' ELSE '无' END AS bo_renew, 
                CASE bo_emeover WHEN 0 THEN '未逾期' WHEN 1 THEN '已逾期' WHEN 2 THEN '缴费审核中' WHEN 3 THEN '已缴费' ELSE
                 '缴费未通过' END AS bo_emeover, 
                CASE bo_eme WHEN 0 THEN '未还书' WHEN 1 THEN '审核中' WHEN 2 THEN '还书成功' ELSE '还书失败' END AS bo_eme,
                 dbo.borrow.u_id
FROM      dbo.book INNER JOIN
                dbo.books ON dbo.book.b_isbn = dbo.books.b_isbn INNER JOIN
                dbo.borrow ON dbo.books.b_id = dbo.borrow.b_id
GO
/****** Object:  View [dbo].[V_Emeover]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Emeover]
AS
SELECT   dbo.borrow.bo_id, dbo.book.b_name, dbo.borrow.bo_borrow, dbo.borrow.bo_return, dbo.borrow.bo_dayover, 
                dbo.borrow.bo_dayover * 0.1 AS bo_money, 
                CASE bo_emeover WHEN 1 THEN '未缴费' WHEN 2 THEN '审核中' WHEN 3 THEN '已缴费' ELSE '审核不通过' END AS bo_emeover,
                 dbo.borrow.u_id
FROM      dbo.borrow INNER JOIN
                dbo.books ON dbo.borrow.b_id = dbo.books.b_id INNER JOIN
                dbo.book ON dbo.books.b_isbn = dbo.book.b_isbn
WHERE   (dbo.borrow.bo_emeover <> 0)
GO
/****** Object:  View [dbo].[V_Return]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Return]
AS
SELECT   dbo.borrow.bo_id, dbo.book.b_name, dbo.type.t_name, dbo.borrow.bo_borrow, dbo.borrow.bo_rtnatl, dbo.borrow.bo_day, 
                dbo.borrow.bo_renewday, CASE bo_renew WHEN 0 THEN '未续借' ELSE '已续借' END AS bo_renew, 
                CASE bo_eme WHEN 2 THEN '还书成功' END AS bo_eme, dbo.borrow.u_id
FROM      dbo.book INNER JOIN
                dbo.books ON dbo.book.b_isbn = dbo.books.b_isbn INNER JOIN
                dbo.borrow ON dbo.books.b_id = dbo.borrow.b_id INNER JOIN
                dbo.type ON dbo.book.t_id = dbo.type.t_id
WHERE   (dbo.borrow.bo_eme = 2)
GO
/****** Object:  Table [dbo].[user]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[u_id] [int] IDENTITY(100000,1) NOT NULL,
	[u_password] [nvarchar](16) NOT NULL,
	[u_name] [nvarchar](10) NOT NULL,
	[u_sex] [nvarchar](1) NOT NULL,
	[u_card] [nvarchar](18) NOT NULL,
	[c_id] [int] NOT NULL,
	[u_tel] [nvarchar](11) NULL,
	[u_position] [nvarchar](2) NOT NULL,
	[u_number] [int] NOT NULL,
	[u_book] [int] NOT NULL,
 CONSTRAINT [PK_readers] PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_AdminOver]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_AdminOver]
AS
SELECT   dbo.borrow.bo_id, dbo.[user].u_name, dbo.book.b_name, dbo.borrow.bo_borrow, dbo.borrow.bo_return, 
                dbo.borrow.bo_dayover, dbo.borrow.bo_dayover * 0.1 AS bo_money, 
                CASE bo_emeover WHEN 0 THEN '未逾期' WHEN 1 THEN '未缴费' WHEN 2 THEN '待审核' WHEN 3 THEN '已缴费' ELSE
                 '审核未通过' END AS bo_emeover
FROM      dbo.book INNER JOIN
                dbo.books ON dbo.book.b_isbn = dbo.books.b_isbn INNER JOIN
                dbo.borrow INNER JOIN
                dbo.[user] ON dbo.borrow.u_id = dbo.[user].u_id ON dbo.books.b_id = dbo.borrow.b_id
GO
/****** Object:  View [dbo].[V_AdminBorrow]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_AdminBorrow]
AS
SELECT   dbo.borrow.bo_id, dbo.[user].u_name, dbo.book.b_name, dbo.borrow.bo_borrow, dbo.borrow.bo_rtnatl, 
                dbo.borrow.bo_day, CASE bo_renew WHEN 0 THEN '有' ELSE '无' END AS bo_renew, 
                CASE bo_eme WHEN 1 THEN '待审核' WHEN 3 THEN '未通过' WHEN 2 THEN '2' ELSE '未申请' END AS bo_eme
FROM      dbo.[user] INNER JOIN
                dbo.borrow ON dbo.[user].u_id = dbo.borrow.u_id INNER JOIN
                dbo.book INNER JOIN
                dbo.books ON dbo.book.b_isbn = dbo.books.b_isbn ON dbo.borrow.b_id = dbo.books.b_id
WHERE   (dbo.borrow.bo_emeover = 0)
GO
/****** Object:  View [dbo].[V_AdminReturn]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_AdminReturn]
AS
SELECT   dbo.borrow.bo_id, dbo.[user].u_name, dbo.book.b_name, dbo.type.t_name, dbo.borrow.bo_borrow, dbo.borrow.bo_rtnatl, 
                dbo.borrow.bo_day, dbo.borrow.bo_renewday, 
                CASE bo_renew WHEN 0 THEN '未续借' ELSE '已续借' END AS bo_renew, 
                CASE bo_eme WHEN 2 THEN '还书成功' END AS bo_eme
FROM      dbo.borrow INNER JOIN
                dbo.[user] ON dbo.borrow.u_id = dbo.[user].u_id INNER JOIN
                dbo.book INNER JOIN
                dbo.books ON dbo.book.b_isbn = dbo.books.b_isbn ON dbo.borrow.b_id = dbo.books.b_id INNER JOIN
                dbo.type ON dbo.book.t_id = dbo.type.t_id
WHERE   (dbo.borrow.bo_eme = 2)
GO
/****** Object:  Table [dbo].[college]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[college](
	[c_id] [int] IDENTITY(0,1) NOT NULL,
	[c_college] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_college] PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Listuser]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Listuser]
AS
SELECT   dbo.[user].u_id, dbo.[user].u_name, dbo.[user].u_sex, dbo.[user].u_card, dbo.college.c_college, dbo.[user].u_tel, 
                dbo.[user].u_position, dbo.[user].u_book
FROM      dbo.[user] INNER JOIN
                dbo.college ON dbo.[user].c_id = dbo.college.c_id
GO
/****** Object:  Table [dbo].[operation]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[operation](
	[o_id] [int] IDENTITY(0,1) NOT NULL,
	[a_id] [int] NOT NULL,
	[o_ort] [nvarchar](50) NOT NULL,
	[o_time] [datetime] NOT NULL,
 CONSTRAINT [PK_operation] PRIMARY KEY CLUSTERED 
(
	[o_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Operation]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Operation]
AS
SELECT   dbo.operation.*
FROM      dbo.operation
GO
/****** Object:  View [dbo].[V_user]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_user]
AS
SELECT   u_id, u_password
FROM      dbo.[user]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[a_id] [int] IDENTITY(0,1) NOT NULL,
	[a_name] [nvarchar](5) NOT NULL,
	[a_password] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[a_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_admin]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_admin]
AS
SELECT   dbo.admin.*
FROM      dbo.admin
GO
/****** Object:  Table [dbo].[login]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[l_id] [int] IDENTITY(0,1) NOT NULL,
	[u_id] [int] NULL,
	[l_time] [datetime] NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[l_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_login]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_login]
AS
SELECT   dbo.login.*
FROM      dbo.login
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[feedback](
	[f_id] [int] IDENTITY(0,1) NOT NULL,
	[u_id] [int] NOT NULL,
	[f_title] [nvarchar](10) NOT NULL,
	[f_content] [nvarchar](100) NOT NULL,
	[f_asrcontent] [nvarchar](100) NULL,
	[f_smntime] [date] NOT NULL,
	[f_asrtime] [date] NULL,
	[f_solve] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_feedback] PRIMARY KEY CLUSTERED 
(
	[f_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([a_id], [a_name], [a_password]) VALUES (0, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[admin] OFF
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'1', N'12', 0, N'1', N'1', 1234, CAST(1.00 AS Decimal(6, 2)), 14, 13)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787506365437', N'活着', 9, N'余华', N'作家出版社', 2012, CAST(20.00 AS Decimal(6, 2)), 8, 8)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787514612479', N'志摩的诗', 6, N'徐志摩', N'中国画报出版社', 2016, CAST(24.00 AS Decimal(6, 2)), 2, 3)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787532174072', N'清明上河图密码6：醒世大结局', 3, N'冶文彪', N'上海文艺出版社', 2019, CAST(69.90 AS Decimal(6, 2)), 5, 5)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787536692930', N'三体', 1, N'刘慈欣', N'重庆出版集团图书发行有限公司', 2008, CAST(23.00 AS Decimal(6, 2)), 6, 6)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787540446765', N'十宗罪1', 4, N'蜘蛛', N'湖南文艺出版社', 2015, CAST(35.00 AS Decimal(6, 2)), 3, 3)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787544266222', N'放学后', 2, N'东野圭吾', N'南海出版公司', 2013, CAST(28.00 AS Decimal(6, 2)), 5, 5)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787550255791', N'三国演义', 5, N'罗贯中', N'北京联合出版公司', 2015, CAST(55.00 AS Decimal(6, 2)), 5, 6)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787556246366', N'终极斗罗9', 0, N'唐家三少', N'湖南少年儿童出版社', 2019, CAST(32.00 AS Decimal(6, 2)), 4, 5)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787559437778', N'一半星光一半蓝', 8, N'微酸袅袅', N'江苏凤凰文艺出版社', 2019, CAST(39.80 AS Decimal(6, 2)), 6, 7)
INSERT [dbo].[book] ([b_isbn], [b_name], [t_id], [b_author], [b_press], [b_time], [b_price], [b_count], [b_stocks]) VALUES (N'9787563383870', N'我执', 7, N'梁文道', N'广西师范大学出版社', 2010, CAST(35.00 AS Decimal(6, 2)), 4, 5)
SET IDENTITY_INSERT [dbo].[books] ON 

INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (0, N'9787556246366', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (1, N'9787556246366', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (2, N'9787556246366', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (3, N'9787556246366', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (4, N'9787536692930', 0)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (5, N'9787536692930', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (6, N'9787536692930', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (7, N'9787536692930', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (8, N'9787536692930', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (9, N'9787536692930', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (10, N'9787544266222', 0)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (11, N'9787544266222', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (12, N'9787544266222', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (13, N'9787544266222', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (14, N'9787544266222', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (15, N'9787532174072', 0)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (16, N'9787532174072', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (17, N'9787532174072', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (18, N'9787532174072', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (19, N'9787540446765', 0)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (20, N'9787540446765', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (21, N'9787540446765', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (22, N'9787550255791', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (23, N'9787550255791', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (24, N'9787550255791', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (25, N'9787550255791', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (26, N'9787550255791', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (27, N'9787514612479', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (28, N'9787514612479', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (29, N'9787563383870', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (30, N'9787563383870', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (31, N'9787563383870', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (32, N'9787563383870', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (33, N'9787559437778', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (34, N'9787559437778', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (35, N'9787559437778', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (36, N'9787559437778', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (37, N'9787559437778', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (38, N'9787559437778', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (39, N'9787506365437', 0)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (40, N'9787506365437', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (41, N'9787506365437', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (42, N'9787506365437', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (43, N'9787506365437', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (44, N'9787506365437', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (50, N'9787506365437', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (51, N'9787506365437', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (52, N'9787532174072', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (57, N'1', 0)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (58, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (62, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (63, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (64, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (65, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (66, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (67, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (68, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (69, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (70, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (71, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (72, N'1', 1)
INSERT [dbo].[books] ([b_id], [b_isbn], [b_lend]) VALUES (73, N'1', 1)
SET IDENTITY_INSERT [dbo].[books] OFF
SET IDENTITY_INSERT [dbo].[borrow] ON 

INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (0, NULL, 4, N'9787536692930', 100000, CAST(N'2019-11-05' AS Date), CAST(N'2019-11-20' AS Date), NULL, 15, 0, 0, 0, 409, 1)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (1, NULL, 19, N'9787540446765', 100000, CAST(N'2019-11-10' AS Date), CAST(N'2019-11-17' AS Date), NULL, 7, 0, 0, 0, 412, 1)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (2, 0, 0, N'9787556246366', 100000, CAST(N'2019-12-05' AS Date), CAST(N'2019-12-12' AS Date), CAST(N'2019-12-09' AS Date), 7, 0, 0, 2, 0, 0)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (3, 0, 10, N'9787544266222', 100000, CAST(N'2019-12-05' AS Date), CAST(N'2020-01-05' AS Date), NULL, 30, 0, 0, 3, 363, 1)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (4, 0, 15, N'9787532174072', 100000, CAST(N'2019-12-08' AS Date), CAST(N'2019-12-22' AS Date), NULL, 7, 7, 1, 0, 377, 1)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (5, 0, 22, N'9787550255791', 100000, CAST(N'2020-12-19' AS Date), CAST(N'2021-01-03' AS Date), CAST(N'2020-12-19' AS Date), 15, 0, 0, 0, 0, 2)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (6, 0, 57, N'1', 100000, CAST(N'2020-12-26' AS Date), CAST(N'2021-01-10' AS Date), CAST(N'2021-01-02' AS Date), 15, 0, 0, 2, 0, 0)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (7, NULL, 39, N'9787506365437', 100000, CAST(N'2021-01-02' AS Date), CAST(N'2021-01-17' AS Date), NULL, 15, 0, 0, 0, 0, 0)
INSERT [dbo].[borrow] ([bo_id], [a_id], [b_id], [b_isbn], [u_id], [bo_borrow], [bo_return], [bo_rtnatl], [bo_day], [bo_renewday], [bo_renew], [bo_eme], [bo_dayover], [bo_emeover]) VALUES (8, NULL, 57, N'1', 100000, CAST(N'2021-01-02' AS Date), CAST(N'2021-01-17' AS Date), NULL, 15, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[borrow] OFF
SET IDENTITY_INSERT [dbo].[college] ON 

INSERT [dbo].[college] ([c_id], [c_college]) VALUES (0, N'会计学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (1, N'汽车学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (2, N'护理学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (3, N'经济管理学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (4, N'文化传播学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (5, N'艺术设计学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (6, N'医药技术学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (7, N'机电工程学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (8, N'土木工程学院')
INSERT [dbo].[college] ([c_id], [c_college]) VALUES (9, N'电子信息工程学院')
SET IDENTITY_INSERT [dbo].[college] OFF
SET IDENTITY_INSERT [dbo].[feedback] ON 

INSERT [dbo].[feedback] ([f_id], [u_id], [f_title], [f_content], [f_asrcontent], [f_smntime], [f_asrtime], [f_solve]) VALUES (0, 100000, N'为什么界面这么差', N'为什么这个界面做的这么简陋', N'因为个人的能力有限，我们尽可能优化', CAST(N'2019-12-01' AS Date), CAST(N'2019-12-02' AS Date), N'已回复')
INSERT [dbo].[feedback] ([f_id], [u_id], [f_title], [f_content], [f_asrcontent], [f_smntime], [f_asrtime], [f_solve]) VALUES (1, 100000, N'图书太少', N'能不能图书更多点', NULL, CAST(N'2019-12-08' AS Date), NULL, N'未回复')
SET IDENTITY_INSERT [dbo].[feedback] OFF
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (0, 100000, CAST(N'2020-12-19T09:18:29.850' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (1, 100000, CAST(N'2020-12-19T09:29:27.423' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (2, 100000, CAST(N'2020-12-19T09:55:01.207' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (3, 100000, CAST(N'2020-12-26T19:17:37.130' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (4, 100000, CAST(N'2020-12-26T19:24:36.417' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (5, 100000, CAST(N'2020-12-26T19:25:56.420' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (6, 100000, CAST(N'2020-12-27T00:47:57.060' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (7, 100000, CAST(N'2020-12-27T00:53:22.100' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (8, 100000, CAST(N'2020-12-27T00:53:40.260' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (9, 100000, CAST(N'2020-12-27T00:55:22.123' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (10, 100000, CAST(N'2020-12-27T00:58:21.603' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (11, 100000, CAST(N'2020-12-27T01:01:14.800' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (12, 100000, CAST(N'2020-12-31T00:07:10.990' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (13, 100000, CAST(N'2020-12-31T02:06:55.430' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (14, 100000, CAST(N'2020-12-31T19:11:40.483' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (15, 100000, CAST(N'2020-12-31T19:13:46.960' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (16, 100000, CAST(N'2021-01-01T18:26:06.580' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (17, 100000, CAST(N'2021-01-01T18:53:09.997' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (18, 100000, CAST(N'2021-01-02T01:15:46.230' AS DateTime))
INSERT [dbo].[login] ([l_id], [u_id], [l_time]) VALUES (19, 100000, CAST(N'2021-01-02T01:38:33.247' AS DateTime))
SET IDENTITY_INSERT [dbo].[login] OFF
SET IDENTITY_INSERT [dbo].[operation] ON 

INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (0, 0, N'通过用户：李磊的还书申请', CAST(N'2020-12-19T09:57:42.610' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (1, 0, N'编辑用户：100006', CAST(N'2020-12-26T16:26:30.720' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (2, 0, N'成功图书：活着的数据', CAST(N'2020-12-26T19:06:21.810' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (3, 0, N'成功图书：活着的数据', CAST(N'2020-12-26T19:06:27.847' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (4, 0, N'成功图书：清明上河图密码6：醒世大结局的数据', CAST(N'2020-12-26T19:06:42.870' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (5, 0, N'添加新图书：1成功', CAST(N'2020-12-26T19:11:46.073' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (6, 0, N'图书：1的库存加1成功', CAST(N'2020-12-26T19:14:25.360' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (7, 0, N'删除图书名为：1的图书表与ISBN表及借书表的记录', CAST(N'2020-12-26T19:15:26.997' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (8, 0, N'添加新图书：1成功', CAST(N'2020-12-26T19:16:58.383' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (9, 0, N'删除图书名为：1的图书表与ISBN表及借书表的记录', CAST(N'2020-12-26T19:17:01.477' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (10, 0, N'添加新图书：12成功', CAST(N'2020-12-26T19:17:12.380' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (11, 0, N'查询未通过用户数据记录', CAST(N'2020-12-27T01:12:18.237' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (12, 0, N'查询已缴费用户数据记录', CAST(N'2020-12-27T01:12:18.623' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (13, 0, N'查询待审核用户数据记录', CAST(N'2020-12-27T01:12:19.163' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (14, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:12:19.690' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (15, 0, N'查询全部数据记录', CAST(N'2020-12-27T01:12:20.297' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (16, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:12:21.050' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (17, 0, N'查询全部数据记录', CAST(N'2020-12-27T01:12:21.587' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (18, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:12:22.553' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (19, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:12:23.140' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (20, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:12:23.300' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (21, 0, N'查询全部数据记录', CAST(N'2020-12-27T01:12:36.790' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (22, 0, N'查询已缴费用户数据记录', CAST(N'2020-12-27T01:16:05.673' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (23, 0, N'查询待审核用户数据记录', CAST(N'2020-12-27T01:16:06.190' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (24, 0, N'查询未通过用户数据记录', CAST(N'2020-12-27T01:16:06.720' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (25, 0, N'查询待审核用户数据记录', CAST(N'2020-12-27T01:16:07.433' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (26, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:16:07.733' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (27, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:16:08.833' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (28, 0, N'查询未通过用户数据记录', CAST(N'2020-12-27T01:16:09.503' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (29, 0, N'查询未通过用户数据记录', CAST(N'2020-12-27T01:16:34.287' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (30, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:16:39.210' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (31, 0, N'查询全部数据记录', CAST(N'2020-12-27T01:16:40.707' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (32, 0, N'查询未通过用户数据记录', CAST(N'2020-12-27T01:30:21.580' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (33, 0, N'查询已缴费用户数据记录', CAST(N'2020-12-27T01:30:22.223' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (34, 0, N'查询待审核用户数据记录', CAST(N'2020-12-27T01:30:22.757' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (35, 0, N'查询未缴费用户数据记录', CAST(N'2020-12-27T01:30:23.350' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (36, 0, N'查询全部数据记录', CAST(N'2020-12-27T01:30:24.230' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (37, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:30:47.427' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (38, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:30:47.833' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (39, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:30:48.140' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (40, 0, N'查询全部的借书记录', CAST(N'2020-12-27T01:30:48.520' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (41, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:31:21.720' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (42, 0, N'查询全部的借书记录', CAST(N'2020-12-27T01:31:22.277' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (43, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:31:22.923' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (44, 0, N'查询全部的借书记录', CAST(N'2020-12-27T01:31:23.407' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (45, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:31:25.197' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (46, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:31:32.383' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (47, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:31:32.903' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (48, 0, N'查询全部的借书记录', CAST(N'2020-12-27T01:31:33.367' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (49, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:31:35.653' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (50, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:31:36.500' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (51, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:31:36.983' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (52, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:31:47.450' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (53, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:31:48.520' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (54, 0, N'查询全部的借书记录', CAST(N'2020-12-27T01:31:49.540' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (55, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:34:33.513' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (56, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:34:35.437' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (57, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:34:48.937' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (58, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:34:49.543' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (59, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:34:49.830' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (60, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:34:50.160' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (61, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:34:50.650' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (62, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:34:50.970' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (63, 0, N'查询全部的借书记录', CAST(N'2020-12-27T01:34:51.343' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (64, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:34:52.433' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (65, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:34:52.683' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (66, 0, N'查询待审核的借书记录', CAST(N'2020-12-27T01:35:13.387' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (67, 0, N'查询未还书的借书记录', CAST(N'2020-12-27T01:35:13.847' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (68, 0, N'查询全部的借书记录', CAST(N'2020-12-27T01:35:14.300' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (69, 0, N'查询全部数据记录', CAST(N'2020-12-27T01:38:17.963' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (70, 0, N'查询全部数据记录', CAST(N'2020-12-27T01:39:08.547' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (71, 0, N'查询借书人：的记录', CAST(N'2020-12-27T01:39:09.133' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (72, 0, N'查询借书人：1的记录', CAST(N'2020-12-27T01:39:11.097' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (73, 0, N'查询借书人：的记录', CAST(N'2020-12-27T01:39:13.977' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (74, 0, N'编辑用户：100003', CAST(N'2021-01-01T18:42:48.337' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (75, 0, N'通过用户：李磊的还书申请', CAST(N'2021-01-02T00:07:56.097' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (76, 0, N'查询全部的登录记录', CAST(N'2021-01-02T00:56:51.963' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (77, 0, N'查询开始时间为:2021/1/13结束时间为:2021/1/30的登录记录', CAST(N'2021-01-02T00:56:53.760' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (78, 0, N'删除图书名为：12未成功', CAST(N'2021-01-02T01:23:16.960' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (79, 0, N'添加新图书：2成功', CAST(N'2021-01-02T01:23:36.400' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (80, 0, N'添加新图书：122成功', CAST(N'2021-01-02T01:33:32.353' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (81, 0, N'删除图书名为：122的图书表与ISBN表及借书表的记录', CAST(N'2021-01-02T01:33:36.640' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (82, 0, N'删除图书名为：12未成功', CAST(N'2021-01-02T01:33:39.767' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (83, 0, N'图书：12的库存加12成功', CAST(N'2021-01-02T01:35:20.903' AS DateTime))
INSERT [dbo].[operation] ([o_id], [a_id], [o_ort], [o_time]) VALUES (84, 0, N'添加新图书：1成功', CAST(N'2021-01-02T01:35:28.457' AS DateTime))
SET IDENTITY_INSERT [dbo].[operation] OFF
SET IDENTITY_INSERT [dbo].[type] ON 

INSERT [dbo].[type] ([t_id], [t_name]) VALUES (0, N'玄幻')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (1, N'科幻')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (2, N'悬疑')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (3, N'侦探')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (4, N'恐怖')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (5, N'经典')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (6, N'诗歌')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (7, N'散文')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (8, N'言情')
INSERT [dbo].[type] ([t_id], [t_name]) VALUES (9, N'哲学')
SET IDENTITY_INSERT [dbo].[type] OFF
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100000, N'020611', N'李磊', N'男', N'120107198507020611', 0, NULL, N'老师', 6, 3)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100001, N'138487', N'伏佳', N'女', N'350105199506138487', 1, NULL, N'学生', 5, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100002, N'112745', N'郎岩', N'女', N'235407195106112745', 2, NULL, N'老师', 8, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100003, N'121617', N'司空坚', N'男', N'235402199407121617', 3, NULL, N'学生', 5, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100004, N'202551', N'狄彪树', N'男', N'610729197408202551', 4, NULL, N'老师', 8, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100005, N'278829', N'常善勤', N'女', N'130821199103278829', 5, NULL, N'学生', 5, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100006, N'083264', N'孔姬宜', N'女', N'441623198701083264', 6, NULL, N'老师', 8, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100007, N'025899', N'古蕊会', N'男', N'610724199403025899', 7, NULL, N'学生', 5, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100008, N'049323', N'齐江娜', N'女', N'510682195211049323', 8, NULL, N'老师', 8, 0)
INSERT [dbo].[user] ([u_id], [u_password], [u_name], [u_sex], [u_card], [c_id], [u_tel], [u_position], [u_number], [u_book]) VALUES (100009, N'27967X', N'柳博文', N'女', N'22240219990527967X', 9, NULL, N'学生', 5, 0)
SET IDENTITY_INSERT [dbo].[user] OFF
ALTER TABLE [dbo].[books] ADD  CONSTRAINT [DF_books_b_lend]  DEFAULT ((1)) FOR [b_lend]
GO
ALTER TABLE [dbo].[borrow] ADD  CONSTRAINT [DF_borrow_bo_renewday]  DEFAULT ('0') FOR [bo_renewday]
GO
ALTER TABLE [dbo].[borrow] ADD  CONSTRAINT [CK_borrow_bo_renew_default]  DEFAULT ('0') FOR [bo_renew]
GO
ALTER TABLE [dbo].[borrow] ADD  CONSTRAINT [DF_borrow_bo_eme]  DEFAULT ('0') FOR [bo_eme]
GO
ALTER TABLE [dbo].[borrow] ADD  CONSTRAINT [DF_borrow_bo_dayover]  DEFAULT ('0') FOR [bo_dayover]
GO
ALTER TABLE [dbo].[borrow] ADD  CONSTRAINT [DF_borrow_bo_emeover]  DEFAULT ('0') FOR [bo_emeover]
GO
ALTER TABLE [dbo].[feedback] ADD  CONSTRAINT [DF_feedback_f_solve]  DEFAULT (N'未回复') FOR [f_solve]
GO
ALTER TABLE [dbo].[user] ADD  CONSTRAINT [CK_readers_r_book_default]  DEFAULT ((0)) FOR [u_book]
GO
ALTER TABLE [dbo].[book]  WITH CHECK ADD  CONSTRAINT [FK_book_type] FOREIGN KEY([t_id])
REFERENCES [dbo].[type] ([t_id])
GO
ALTER TABLE [dbo].[book] CHECK CONSTRAINT [FK_book_type]
GO
ALTER TABLE [dbo].[books]  WITH CHECK ADD  CONSTRAINT [FK_books_book] FOREIGN KEY([b_isbn])
REFERENCES [dbo].[book] ([b_isbn])
GO
ALTER TABLE [dbo].[books] CHECK CONSTRAINT [FK_books_book]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [FK_borrow_admin_id] FOREIGN KEY([a_id])
REFERENCES [dbo].[admin] ([a_id])
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [FK_borrow_admin_id]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [FK_borrow_books] FOREIGN KEY([b_id])
REFERENCES [dbo].[books] ([b_id])
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [FK_borrow_books]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [FK_borrow_borrow] FOREIGN KEY([b_isbn])
REFERENCES [dbo].[book] ([b_isbn])
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [FK_borrow_borrow]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [FK_borrow_readers] FOREIGN KEY([u_id])
REFERENCES [dbo].[user] ([u_id])
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [FK_borrow_readers]
GO
ALTER TABLE [dbo].[feedback]  WITH CHECK ADD  CONSTRAINT [FK_feedback_user_id] FOREIGN KEY([u_id])
REFERENCES [dbo].[user] ([u_id])
GO
ALTER TABLE [dbo].[feedback] CHECK CONSTRAINT [FK_feedback_user_id]
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD  CONSTRAINT [FK_login_user_id] FOREIGN KEY([u_id])
REFERENCES [dbo].[user] ([u_id])
GO
ALTER TABLE [dbo].[login] CHECK CONSTRAINT [FK_login_user_id]
GO
ALTER TABLE [dbo].[operation]  WITH CHECK ADD  CONSTRAINT [FK_operation_admin] FOREIGN KEY([a_id])
REFERENCES [dbo].[admin] ([a_id])
GO
ALTER TABLE [dbo].[operation] CHECK CONSTRAINT [FK_operation_admin]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_college_id] FOREIGN KEY([c_id])
REFERENCES [dbo].[college] ([c_id])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_college_id]
GO
ALTER TABLE [dbo].[books]  WITH CHECK ADD  CONSTRAINT [CK_books_b_lend_check] CHECK  (([b_lend]='0' OR [b_lend]='1'))
GO
ALTER TABLE [dbo].[books] CHECK CONSTRAINT [CK_books_b_lend_check]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [CK_borrow_bo_renew_check] CHECK  (([bo_renew]='0' OR [bo_renew]='1'))
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [CK_borrow_bo_renew_check]
GO
ALTER TABLE [dbo].[feedback]  WITH CHECK ADD  CONSTRAINT [CK_feedback] CHECK  (([f_solve]='未回复' OR [f_solve]='已回复'))
GO
ALTER TABLE [dbo].[feedback] CHECK CONSTRAINT [CK_feedback]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [CK_position] CHECK  (([u_position]='学生' OR [u_position]='老师'))
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [CK_position]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [CK_rsex] CHECK  (([u_sex]='女' OR [u_sex]='男'))
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [CK_rsex]
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_book_books_borrow]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delete_book_books_borrow]
@b_isbn nvarchar(20)
as 
delete from [borrow] where  b_isbn=@b_isbn
delete from [books] where b_isbn=@b_isbn
delete from [book] where b_isbn=@b_isbn
GO
/****** Object:  StoredProcedure [dbo].[sp_detele_user]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_detele_user]
@u_id int
as 
delete from [borrow] where u_id=@u_id
delete from [feedback] where u_id=@u_id
delete from [login] where u_id=@u_id
delete from [user] where u_id=@u_id
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_login]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insert_login]
@u_id int
as 
insert  into login values (@u_id,GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[sp_update_bo_id_borrow]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_update_bo_id_borrow]
@bo_id int
as update borrow set bo_emeover=2 where bo_id=@bo_id
GO
/****** Object:  StoredProcedure [dbo].[sp_update_u_id_borrow]    Script Date: 2021/1/2 3:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_update_u_id_borrow]
@u_id int
as update borrow set bo_emeover= 1 where bo_rtnatl is NULL and datediff(day,bo_return,getdate())>0 and u_id=@u_id

update borrow set bo_dayover=datediff(day,bo_return,getdate()) where bo_emeover=1 or bo_emeover=4 and bo_eme in (0,3)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'admin', @level2type=N'COLUMN',@level2name=N'a_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'admin', @level2type=N'COLUMN',@level2name=N'a_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员账号密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'admin', @level2type=N'COLUMN',@level2name=N'a_password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书籍ISBN号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_isbn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'总数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'该名称书籍的可借数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_stocks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'索引号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ISBN国际编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_isbn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否借出的标识符，0代表借出，1代表未借出' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_lend'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'a_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'b_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学号/工号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'u_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_borrow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应还书日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_return'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际还书日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_rtnatl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所借天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_day'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'续借天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_renewday'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否续借，0代表未续借，1代表续借' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_renew'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0代表未还书，1代表还书审核，2代表还书成功' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_eme'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逾期天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_dayover'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逾期状态，1代表已逾期未交付，0代表未逾期，2代表待审核，3代表已缴费，4代表审核未通过' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_emeover'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'CONSTRAINT',@level2name=N'FK_borrow_admin_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学院编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'college', @level2type=N'COLUMN',@level2name=N'c_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学院' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'college', @level2type=N'COLUMN',@level2name=N'c_college'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'f_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学号/工号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'u_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'反馈标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'f_title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'反馈内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'f_content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'回复内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'f_asrcontent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'提交时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'f_smntime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'问答时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'f_asrtime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否解决，-1为未解决，0为待解决，1为解决' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'COLUMN',@level2name=N'f_solve'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'反馈记录表中，用户id外键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'feedback', @level2type=N'CONSTRAINT',@level2name=N'FK_feedback_user_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'COLUMN',@level2name=N'l_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学号/工号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'COLUMN',@level2name=N'u_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'COLUMN',@level2name=N'l_time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户id外键约束' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'CONSTRAINT',@level2name=N'FK_login_user_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'operation', @level2type=N'COLUMN',@level2name=N'o_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'operation', @level2type=N'COLUMN',@level2name=N'a_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'operation', @level2type=N'COLUMN',@level2name=N'o_ort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'operation', @level2type=N'COLUMN',@level2name=N'o_time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书籍类别编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'type', @level2type=N'COLUMN',@level2name=N't_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书籍类别名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'type', @level2type=N'COLUMN',@level2name=N't_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学号/工号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_card'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学院编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'c_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_tel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位，0为学生，1为学生' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'可借数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'累计借书' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_book'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学院外键表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'CONSTRAINT',@level2name=N'FK_user_college_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "admin"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 127
               Right = 196
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_admin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_admin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "user"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 196
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "borrow"
            Begin Extent = 
               Top = 6
               Left = 234
               Bottom = 146
               Right = 400
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 438
               Bottom = 146
               Right = 580
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "books"
            Begin Extent = 
               Top = 6
               Left = 618
               Bottom = 127
               Right = 760
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminBorrow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminBorrow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "books"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 127
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "borrow"
            Begin Extent = 
               Top = 6
               Left = 398
               Bottom = 146
               Right = 564
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "user"
            Begin Extent = 
               Top = 132
               Left = 218
               Bottom = 272
               Right = 376
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminOver'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminOver'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminOver'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "borrow"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "user"
            Begin Extent = 
               Top = 6
               Left = 242
               Bottom = 146
               Right = 400
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 438
               Bottom = 146
               Right = 580
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "books"
            Begin Extent = 
               Top = 6
               Left = 618
               Bottom = 127
               Right = 760
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "type"
            Begin Extent = 
               Top = 6
               Left = 798
               Bottom = 108
               Right = 940
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_AdminReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "type"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 108
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_bookPage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_bookPage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "books"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 127
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "borrow"
            Begin Extent = 
               Top = 1
               Left = 424
               Bottom = 141
               Right = 590
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Borrow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Borrow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "borrow"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "books"
            Begin Extent = 
               Top = 6
               Left = 242
               Bottom = 127
               Right = 384
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 422
               Bottom = 146
               Right = 564
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Emeover'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Emeover'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "type"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 108
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_listBook'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_listBook'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "college"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 108
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "user"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 146
               Right = 376
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Listuser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Listuser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "login"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 127
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "operation"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Operation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Operation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "book"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "books"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 127
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "borrow"
            Begin Extent = 
               Top = 6
               Left = 398
               Bottom = 146
               Right = 564
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "type"
            Begin Extent = 
               Top = 6
               Left = 602
               Bottom = 108
               Right = 744
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Return'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Return'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "user"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 196
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_user'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_user'
GO
USE [master]
GO
ALTER DATABASE [LibraryMS] SET  READ_WRITE 
GO
