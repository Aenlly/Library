CREATE DATABASE [LibraryMS]
GO
USE [LibraryMS]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 2019/12/8 19:33:52 ******/
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
/****** Object:  Table [dbo].[book]    Script Date: 2019/12/8 19:33:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[b_isbn] [nvarchar](20) NOT NULL,
	[b_name] [nvarchar](50) NOT NULL,
	[b_stocks] [int] NOT NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[b_isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[books]    Script Date: 2019/12/8 19:33:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[b_id] [int] IDENTITY(0,1) NOT NULL,
	[b_isbn] [nvarchar](20) NOT NULL,
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
/****** Object:  Table [dbo].[borrow]    Script Date: 2019/12/8 19:33:52 ******/
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
/****** Object:  Table [dbo].[college]    Script Date: 2019/12/8 19:33:52 ******/
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
/****** Object:  Table [dbo].[feedback]    Script Date: 2019/12/8 19:33:53 ******/
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
/****** Object:  Table [dbo].[login]    Script Date: 2019/12/8 19:33:53 ******/
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
/****** Object:  Table [dbo].[operation]    Script Date: 2019/12/8 19:33:53 ******/
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
/****** Object:  Table [dbo].[type]    Script Date: 2019/12/8 19:33:53 ******/
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
/****** Object:  Table [dbo].[user]    Script Date: 2019/12/8 19:33:53 ******/
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
ALTER TABLE [dbo].[books]  WITH CHECK ADD  CONSTRAINT [FK_books_type] FOREIGN KEY([t_id])
REFERENCES [dbo].[type] ([t_id])
GO
ALTER TABLE [dbo].[books] CHECK CONSTRAINT [FK_books_type]
GO
ALTER TABLE [dbo].[borrow]  WITH CHECK ADD  CONSTRAINT [FK_borrow_admin_id] FOREIGN KEY([a_id])
REFERENCES [dbo].[admin] ([a_id])
GO
ALTER TABLE [dbo].[borrow] CHECK CONSTRAINT [FK_borrow_admin_id]
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'该名称书籍的总数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'book', @level2type=N'COLUMN',@level2name=N'b_stocks'
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0代表未逾期，1代表逾期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'borrow', @level2type=N'COLUMN',@level2name=N'bo_emeover'
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

insert into admin(a_name,a_password) values ('admin','admin')--管理员

insert into [type] (t_name) values ('玄幻') --类别表
insert into [type] (t_name) values ('科幻') 
insert into [type] (t_name) values ('悬疑') 
insert into [type] (t_name) values ('侦探') 
insert into [type] (t_name) values ('恐怖') 
insert into [type] (t_name) values ('经典') 
insert into [type] (t_name) values ('诗歌') 
insert into [type] (t_name) values ('散文') 
insert into [type] (t_name) values ('言情') 
insert into [type] (t_name) values ('哲学') 

insert into [book] values ('9787556246366','终极斗罗9','4') --图书表
insert into [book] values ('9787536692930','三体','5') 
insert into [book] values ('9787544266222','放学后','4') 
insert into [book] values ('9787532174072','清明上河图密码6：醒世大结局','3') 
insert into [book] values ('9787540446765','十宗罪1','2') 
insert into [book] values ('9787550255791','三国演义','5') 
insert into [book] values ('9787514612479','志摩的诗','2') 
insert into [book] values ('9787563383870','我执','4')
insert into [book] values ('9787559437778','一半星光一半蓝','6') 
insert into [book] values ('9787506365437','活着','7') 

insert into [books] values ('9787556246366','终极斗罗9','0','唐家三少','湖南少年儿童出版社','2019','32.00','1') 
insert into [books] values ('9787556246366','终极斗罗9','0','唐家三少','湖南少年儿童出版社','2019','32.00','1') 
insert into [books] values ('9787556246366','终极斗罗9','0','唐家三少','湖南少年儿童出版社','2019','32.00','1') 
insert into [books] values ('9787556246366','终极斗罗9','0','唐家三少','湖南少年儿童出版社','2019','32.00','1') 

insert into [books] values ('9787536692930','三体','1','刘慈欣','重庆出版集团图书发行有限公司','2008','23.00','0') 
insert into [books] values ('9787536692930','三体','1','刘慈欣','重庆出版集团图书发行有限公司','2008','23.00','1') 
insert into [books] values ('9787536692930','三体','1','刘慈欣','重庆出版集团图书发行有限公司','2008','23.00','1') 
insert into [books] values ('9787536692930','三体','1','刘慈欣','重庆出版集团图书发行有限公司','2008','23.00','1') 
insert into [books] values ('9787536692930','三体','1','刘慈欣','重庆出版集团图书发行有限公司','2008','23.00','1') 
insert into [books] values ('9787536692930','三体','1','刘慈欣','重庆出版集团图书发行有限公司','2008','23.00','1') 

insert into [books] values ('9787544266222','放学后','2','东野圭吾','南海出版公司','2013','28.00','0') 
insert into [books] values ('9787544266222','放学后','2','东野圭吾','南海出版公司','2013','28.00','1') 
insert into [books] values ('9787544266222','放学后','2','东野圭吾','南海出版公司','2013','28.00','1') 
insert into [books] values ('9787544266222','放学后','2','东野圭吾','南海出版公司','2013','28.00','1') 
insert into [books] values ('9787544266222','放学后','2','东野圭吾','南海出版公司','2013','28.00','1') 

insert into [books] values ('9787532174072','清明上河图密码6：醒世大结局','3','冶文彪','上海文艺出版社','2019','69.90','0') 
insert into [books] values ('9787532174072','清明上河图密码6：醒世大结局','3','冶文彪','上海文艺出版社','2019','69.90','1') 
insert into [books] values ('9787532174072','清明上河图密码6：醒世大结局','3','冶文彪','上海文艺出版社','2019','69.90','1') 
insert into [books] values ('9787532174072','清明上河图密码6：醒世大结局','3','冶文彪','上海文艺出版社','2019','69.90','1') 

insert into [books] values ('9787540446765','十宗罪1','4','蜘蛛','湖南文艺出版社','2015','35.00','0') 
insert into [books] values ('9787540446765','十宗罪1','4','蜘蛛','湖南文艺出版社','2015','35.00','1') 
insert into [books] values ('9787540446765','十宗罪1','4','蜘蛛','湖南文艺出版社','2015','35.00','1') 

insert into [books] values ('9787550255791','三国演义','5','罗贯中','北京联合出版公司','2015','55.00','1')
insert into [books] values ('9787550255791','三国演义','5','罗贯中','北京联合出版公司','2015','55.00','1') 
insert into [books] values ('9787550255791','三国演义','5','罗贯中','北京联合出版公司','2015','55.00','1') 
insert into [books] values ('9787550255791','三国演义','5','罗贯中','北京联合出版公司','2015','55.00','1') 
insert into [books] values ('9787550255791','三国演义','5','罗贯中','北京联合出版公司','2015','55.00','1')  

insert into [books] values ('9787514612479','志摩的诗','6','徐志摩','中国画报出版社','2016','24.00','1') 
insert into [books] values ('9787514612479','志摩的诗','6','徐志摩','中国画报出版社','2016','24.00','1') 

insert into [books] values ('9787563383870','我执','7','梁文道','广西师范大学出版社','2010','35.00','1')
insert into [books] values ('9787563383870','我执','7','梁文道','广西师范大学出版社','2010','35.00','1')
insert into [books] values ('9787563383870','我执','7','梁文道','广西师范大学出版社','2010','35.00','1')
insert into [books] values ('9787563383870','我执','7','梁文道','广西师范大学出版社','2010','35.00','1')

insert into [books] values ('9787559437778','一半星光一半蓝','8','微酸袅袅','江苏凤凰文艺出版社','2019','39.80','1') 
insert into [books] values ('9787559437778','一半星光一半蓝','8','微酸袅袅','江苏凤凰文艺出版社','2019','39.80','1')
insert into [books] values ('9787559437778','一半星光一半蓝','8','微酸袅袅','江苏凤凰文艺出版社','2019','39.80','1')
insert into [books] values ('9787559437778','一半星光一半蓝','8','微酸袅袅','江苏凤凰文艺出版社','2019','39.80','1')
insert into [books] values ('9787559437778','一半星光一半蓝','8','微酸袅袅','江苏凤凰文艺出版社','2019','39.80','1')
insert into [books] values ('9787559437778','一半星光一半蓝','8','微酸袅袅','江苏凤凰文艺出版社','2019','39.80','1')

insert into [books] values ('9787506365437','活着','9','余华','作家出版社','2012','20.00','1') 
insert into [books] values ('9787506365437','活着','9','余华','作家出版社','2012','20.00','1') 
insert into [books] values ('9787506365437','活着','9','余华','作家出版社','2012','20.00','1') 
insert into [books] values ('9787506365437','活着','9','余华','作家出版社','2012','20.00','1') 
insert into [books] values ('9787506365437','活着','9','余华','作家出版社','2012','20.00','1') 
insert into [books] values ('9787506365437','活着','9','余华','作家出版社','2012','20.00','1') 
insert into [books] values ('9787506365437','活着','9','余华','作家出版社','2012','20.00','1')

insert into [college](c_college) values ('会计学院') --学院
insert into [college](c_college) values ('汽车学院') 
insert into [college](c_college) values ('护理学院') 
insert into [college](c_college) values ('经济管理学院') 
insert into [college](c_college) values ('文化传播学院') 
insert into [college](c_college) values ('艺术设计学院') 
insert into [college](c_college) values ('医药技术学院') 
insert into [college](c_college) values ('机电工程学院') 
insert into [college](c_college) values ('土木工程学院') 
insert into [college](c_college) values ('电子信息工程学院') 

insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number,u_book) values ('020611','李磊','男','120107198507020611','0','老师','8','1')--用户表
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('138487','伏佳','女','350105199506138487','1','学生','5')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('112745','郎岩','女','235407195106112745','2','老师','8')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('121617','司空坚','男','235402199407121617','3','学生','5')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('202551','狄彪树','男','610729197408202551','4','老师','8')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('278829','常善勤','女','130821199103278829','5','学生','5')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('083264','孔姬宜','女','441623198701083264','6','老师','8')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('025899','古蕊会','男','610724199403025899','7','学生','5')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('049323','齐江娜','女','510682195211049323','8','老师','8')
insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('27967X','柳博文','女','22240219990527967X','9','学生','5')

--反馈表
insert into [feedback] (u_id,f_title,f_content,f_asrcontent,f_smntime,f_asrtime,f_solve) values ('100000','为什么界面这么差','为什么这个界面做的这么简陋','因为个人的能力有限，我们尽可能优化','2019-12-1','2019-12-2','已回复')
insert into [feedback] (u_id,f_title,f_content,f_smntime,f_solve) values ('100000','图书太少','能不能图书更多点','2019-12-8','未回复')

insert into borrow(b_id,b_isbn,u_id,bo_borrow,bo_return,bo_day) values ('4','9787536692930','100000','2019-11-5','2019-11-20','15')--逾期
insert into borrow(b_id,b_isbn,u_id,bo_borrow,bo_return,bo_day) values ('19','9787540446765','100000','2019-11-10','2019-11-17','7')--逾期
insert into borrow(a_id,b_id,b_isbn,u_id,bo_borrow,bo_return,bo_rtnatl,bo_day,bo_eme) values ('0','0','9787556246366','100000','2019-12-5','2019-12-12','2019-12-9','7','2')--还书成功
insert into borrow(a_id,b_id,b_isbn,u_id,bo_borrow,bo_return,bo_day,bo_eme) values ('0','10','9787544266222','100000','2019-12-5','2020-1-5','30','3')--还书失败
insert into borrow(a_id,b_id,b_isbn,u_id,bo_borrow,bo_return,bo_day,bo_renewday,bo_renew) values ('0','15','9787532174072','100000','2019-12-8','2019-12-22','7','7','1')--审核中