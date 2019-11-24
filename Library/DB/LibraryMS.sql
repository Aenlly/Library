USE [master]
GO
/****** Object:  Database [LibraryMS]    Script Date: 2019/11/24 18:23:57 ******/
CREATE DATABASE [LibraryMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LibraryMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LibraryMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LibraryMS] SET COMPATIBILITY_LEVEL = 130
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
ALTER DATABASE [LibraryMS] SET  DISABLE_BROKER 
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
/****** Object:  Table [dbo].[admin]    Script Date: 2019/11/24 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[a_id] [int] IDENTITY(0,1) NOT NULL,
	[a_name] [nvarchar](5) NOT NULL,
	[a_password] [nvarchar](5) NOT NULL,
	[a_tel] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[a_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book]    Script Date: 2019/11/24 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[b_isbn] [nvarchar](10) NOT NULL,
	[b_name] [nvarchar](50) NOT NULL,
	[b_stocks] [int] NOT NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[b_isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[books]    Script Date: 2019/11/24 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[b_id] [int] IDENTITY(0,1) NOT NULL,
	[b_isbn] [nvarchar](10) NOT NULL,
	[b_name] [nvarchar](50) NOT NULL,
	[t_id] [int] NOT NULL,
	[b_author] [nvarchar](50) NOT NULL,
	[b_press] [nvarchar](50) NOT NULL,
	[b_time] [int] NOT NULL,
	[b_price] [decimal](6, 2) NOT NULL,
	[b_lend] [int] NOT NULL,
 CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
(
	[b_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[borrow]    Script Date: 2019/11/24 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[borrow](
	[bo_id] [int] IDENTITY(0,1) NOT NULL,
	[b_id] [int] NOT NULL,
	[b_isbn] [nvarchar](10) NOT NULL,
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
/****** Object:  Table [dbo].[feedback]    Script Date: 2019/11/24 18:23:57 ******/
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
/****** Object:  Table [dbo].[login]    Script Date: 2019/11/24 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[l_id] [int] IDENTITY(0,1) NOT NULL,
	[u_id] [int] NULL,
	[l_time] [datetime] NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[l_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[operation]    Script Date: 2019/11/24 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[operation](
	[o_id] [int] IDENTITY(0,1) NOT NULL,
	[o_ort] [varchar](100) NOT NULL,
	[o_time] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[type]    Script Date: 2019/11/24 18:23:57 ******/
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
/****** Object:  Table [dbo].[user]    Script Date: 2019/11/24 18:23:57 ******/
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
	[u_college] [nvarchar](20) NULL,
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
ALTER TABLE [dbo].[books]  WITH CHECK ADD  CONSTRAINT [FK_books_books] FOREIGN KEY([b_isbn])
REFERENCES [dbo].[book] ([b_isbn])
GO
ALTER TABLE [dbo].[books] CHECK CONSTRAINT [FK_books_books]
GO
ALTER TABLE [dbo].[books]  WITH CHECK ADD  CONSTRAINT [FK_books_type] FOREIGN KEY([t_id])
REFERENCES [dbo].[type] ([t_id])
GO
ALTER TABLE [dbo].[books] CHECK CONSTRAINT [FK_books_type]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [FK_borrow_book] FOREIGN KEY([b_isbn])
REFERENCES [dbo].[book] ([b_isbn])
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [FK_borrow_book]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [FK_borrow_books] FOREIGN KEY([b_id])
REFERENCES [dbo].[books] ([b_id])
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [FK_borrow_books]
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'admin', @level2type=N'COLUMN',@level2name=N'a_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'admin', @level2type=N'COLUMN',@level2name=N'a_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员账号密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'admin', @level2type=N'COLUMN',@level2name=N'a_password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'admin', @level2type=N'COLUMN',@level2name=N'a_tel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书ISBN号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_isbn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'该图书名称的总数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_stocks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ISBN国际编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_isbn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书类型，外键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N't_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_author'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版社' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_press'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'价格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否借出的标识符，0代表借出，1代表未借出' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'COLUMN',@level2name=N'b_lend'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书类型外键约束' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'books', @level2type=N'CONSTRAINT',@level2name=N'FK_books_type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_id'
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0代表未逾期，1代表逾期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_emeover'
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'operation', @level2type=N'COLUMN',@level2name=N'o_ort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'operation', @level2type=N'COLUMN',@level2name=N'o_time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书类别编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'type', @level2type=N'COLUMN',@level2name=N't_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书类别名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'type', @level2type=N'COLUMN',@level2name=N't_name'
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学院' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_college'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_tel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位，0为学生，1为学生' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'可借数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'累计借书' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user', @level2type=N'COLUMN',@level2name=N'u_book'
GO
USE [master]
GO
ALTER DATABASE [LibraryMS] SET  READ_WRITE 
GO
