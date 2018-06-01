/****** Object:  Database [dbNews]    Script Date: 12/04/2015 10:23:11 ******/
--CREATE DATABASE [dbNews] ON  PRIMARY 
--( NAME = N'dbNews', FILENAME = N'C:\Users\Virtual\source\repos\NewsOnline\NewsOnline\App_Data\dbNews.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'dbNews_log', FILENAME = N'C:\Users\Virtual\source\repos\NewsOnline\NewsOnline\App_Data\dbNews_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
--GO
--ALTER DATABASE [dbNews] SET COMPATIBILITY_LEVEL = 100
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [dbNews].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [dbNews] SET ANSI_NULL_DEFAULT OFF
--GO
--ALTER DATABASE [dbNews] SET ANSI_NULLS OFF
--GO
--ALTER DATABASE [dbNews] SET ANSI_PADDING OFF
--GO
--ALTER DATABASE [dbNews] SET ANSI_WARNINGS OFF
--GO
--ALTER DATABASE [dbNews] SET ARITHABORT OFF
--GO
--ALTER DATABASE [dbNews] SET AUTO_CLOSE OFF
--GO
--ALTER DATABASE [dbNews] SET AUTO_CREATE_STATISTICS ON
--GO
--ALTER DATABASE [dbNews] SET AUTO_SHRINK OFF
--GO
--ALTER DATABASE [dbNews] SET AUTO_UPDATE_STATISTICS ON
--GO
--ALTER DATABASE [dbNews] SET CURSOR_CLOSE_ON_COMMIT OFF
--GO
--ALTER DATABASE [dbNews] SET CURSOR_DEFAULT  GLOBAL
--GO
--ALTER DATABASE [dbNews] SET CONCAT_NULL_YIELDS_NULL OFF
--GO
--ALTER DATABASE [dbNews] SET NUMERIC_ROUNDABORT OFF
--GO
--ALTER DATABASE [dbNews] SET QUOTED_IDENTIFIER OFF
--GO
--ALTER DATABASE [dbNews] SET RECURSIVE_TRIGGERS OFF
--GO
--ALTER DATABASE [dbNews] SET  DISABLE_BROKER
--GO
--ALTER DATABASE [dbNews] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
--GO
--ALTER DATABASE [dbNews] SET DATE_CORRELATION_OPTIMIZATION OFF
--GO
--ALTER DATABASE [dbNews] SET TRUSTWORTHY OFF
--GO
--ALTER DATABASE [dbNews] SET ALLOW_SNAPSHOT_ISOLATION OFF
--GO
--ALTER DATABASE [dbNews] SET PARAMETERIZATION SIMPLE
--GO
--ALTER DATABASE [dbNews] SET READ_COMMITTED_SNAPSHOT OFF
--GO
--ALTER DATABASE [dbNews] SET HONOR_BROKER_PRIORITY OFF
--GO
--ALTER DATABASE [dbNews] SET  READ_WRITE
--GO
--ALTER DATABASE [dbNews] SET RECOVERY SIMPLE
--GO
--ALTER DATABASE [dbNews] SET  MULTI_USER
--GO
--ALTER DATABASE [dbNews] SET PAGE_VERIFY CHECKSUM
--GO
--ALTER DATABASE [dbNews] SET DB_CHAINING OFF
--GO
/****** Object:  Table [dbo].[tblContact]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblContact](
	[fldFirmName] [varchar](150) NULL,
	[fldAddress] [varchar](150) NULL,
	[fldPostNummer] [varchar](6) NULL,
	[fldBy] [varchar](50) NULL,
	[fldTelePhone] [varchar](16) NULL,
	[fldEmail] [varchar](70) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblContact] ([fldFirmName], [fldAddress], [fldPostNummer], [fldBy], [fldTelePhone], [fldEmail]) VALUES (N'School Of Distance Education Shaanxi Normal University', N'Shaanxi Xi An Changan Roade 199', N'710062', N'***', N'029-85303711', N'newssite@newssite.com')
/****** Object:  Table [dbo].[tblNewsType]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNewsType](
	[fldTypeID] [int] IDENTITY(1,1) NOT NULL,
	[fldType] [varchar](50) NULL,
	[fldTypeImage] [varchar](150) NULL,
 CONSTRAINT [PK_tblNewsType] PRIMARY KEY CLUSTERED 
(
	[fldTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblNewsType] ON
INSERT [dbo].[tblNewsType] ([fldTypeID], [fldType], [fldTypeImage]) VALUES (1, N'SchoolOffice', N'SchoolOffice.png')
INSERT [dbo].[tblNewsType] ([fldTypeID], [fldType], [fldTypeImage]) VALUES (2, N'EducationManage', N'EducationManage.png')
INSERT [dbo].[tblNewsType] ([fldTypeID], [fldType], [fldTypeImage]) VALUES (3, N'ScienceManage', N'ScienceManage.png')
INSERT [dbo].[tblNewsType] ([fldTypeID], [fldType], [fldTypeImage]) VALUES (4, N'Student', N'Student.png')
INSERT [dbo].[tblNewsType] ([fldTypeID], [fldType], [fldTypeImage]) VALUES (5, N'International', N'International.png')
SET IDENTITY_INSERT [dbo].[tblNewsType] OFF
/****** Object:  Table [dbo].[tblUser]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[fldID] [int] IDENTITY(1,1) NOT NULL,
	[fldUserName] [varchar](50) NULL,
	[fldPassword] [varchar](20) NULL,
	[fldEmail] [varchar](50) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[fldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON
INSERT [dbo].[tblUser] ([fldID], [fldUserName], [fldPassword], [fldEmail]) VALUES (1, N'admin', N'abc123', N'admin@admin.dk')
INSERT [dbo].[tblUser] ([fldID], [fldUserName], [fldPassword], [fldEmail]) VALUES (2, N'admin', N'admin', N'admin2@admin2.dk')
SET IDENTITY_INSERT [dbo].[tblUser] OFF

/****** Object:  Table [dbo].[tblNews]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNews](
	[fldID] [int] IDENTITY(1,1) NOT NULL,
	[fldTitle] [varchar](150) NULL,
	[fldPreview] [varchar](250) NULL,
	[fldText] [varchar](max) NULL,
	[fldDateTime] [datetime] NULL,
	[fldImage] [varchar](150) NULL,
	[fldTypeID_fk] [int] NOT NULL,
 CONSTRAINT [PK_tblNews] PRIMARY KEY CLUSTERED 
(
	[fldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblNews] ON
INSERT [dbo].[tblNews] ([fldID], [fldTitle], [fldPreview], [fldText], [fldDateTime], [fldImage], [fldTypeID_fk]) VALUES (1, N'Frederik og Mary på hemmelig rejse', N'Kronprins Frederik og kronprinsesse Mary er taget på uofficiel rejse. De skal angiveligt på privat slædetur i den storslåede grønlandske natur.', N'Grønlands Lufthavne har tirsdag afsløret billeder fra en lille lufthavn på Østgrønland, hvor Kronprinsparret pludselig dukkede op tirsdag.', CAST(0x0000A41E00000000 AS DateTime), N'royal.jpg', 1)
SET IDENTITY_INSERT [dbo].[tblNews] OFF
/****** Object:  ForeignKey [FK_tblNyheder_tblKategorier]    Script Date: 12/04/2015 10:23:14 ******/
ALTER TABLE [dbo].[tblNews]  WITH CHECK ADD  CONSTRAINT [FK_tblNews_tblNewsType] FOREIGN KEY([fldTypeID_fk])
REFERENCES [dbo].[tblNewsType] ([fldTypeID])
GO
ALTER TABLE [dbo].[tblNews] CHECK CONSTRAINT [FK_tblNews_tblNewsType]
GO
