USE [master]
GO
/****** Object:  Database [dbVideo]    Script Date: 17/12/2018 8:59:08 AM ******/
CREATE DATABASE [dbVideo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbVideo_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS02\MSSQL\DATA\dbVideo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbVideo_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS02\MSSQL\DATA\dbVideo.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbVideo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbVideo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbVideo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbVideo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbVideo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbVideo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbVideo] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbVideo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbVideo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbVideo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbVideo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbVideo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbVideo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbVideo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbVideo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbVideo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbVideo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbVideo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbVideo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbVideo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbVideo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbVideo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbVideo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbVideo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbVideo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbVideo] SET  MULTI_USER 
GO
ALTER DATABASE [dbVideo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbVideo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbVideo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbVideo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbVideo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbVideo] SET QUERY_STORE = OFF
GO
USE [dbVideo]
GO
/****** Object:  Table [dbo].[tbAdmin]    Script Date: 17/12/2018 8:59:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAdmin](
	[AName] [varchar](50) NULL,
	[AAge] [varchar](50) NULL,
	[AUsrName] [varchar](50) NULL,
	[APassword] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCustomer]    Script Date: 17/12/2018 8:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomer](
	[ID] [int] NULL,
	[CustName] [varchar](50) NULL,
	[CustAdr] [varchar](50) NULL,
	[CustPhone] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCustomerRentalCount]    Script Date: 17/12/2018 8:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomerRentalCount](
	[CID] [int] NULL,
	[CCount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRental]    Script Date: 17/12/2018 8:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRental](
	[id] [int] NOT NULL,
	[MID] [int] NULL,
	[CID] [int] NULL,
	[IssueDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_tbRental] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbReturn]    Script Date: 17/12/2018 8:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbReturn](
	[ID] [int] NULL,
	[MID] [int] NULL,
	[CID] [int] NULL,
	[DateofReturn] [varchar](50) NULL,
	[Amount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbVideoCount]    Script Date: 17/12/2018 8:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbVideoCount](
	[VID] [int] NULL,
	[VCount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbVideos]    Script Date: 17/12/2018 8:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbVideos](
	[id] [int] NULL,
	[Rating] [int] NULL,
	[VTitle] [varchar](50) NULL,
	[VYear] [varchar](50) NULL,
	[VCost] [int] NULL,
	[VCopy] [int] NULL,
	[VPlot] [varchar](50) NULL,
	[VGenre] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbAdmin] ([AName], [AAge], [AUsrName], [APassword]) VALUES (N'as', N'12', N'cm', N'12')
INSERT [dbo].[tbAdmin] ([AName], [AAge], [AUsrName], [APassword]) VALUES (N'husan', N'21', N'hs', N'12')
INSERT [dbo].[tbAdmin] ([AName], [AAge], [AUsrName], [APassword]) VALUES (N'husan', N'21', N'hayer', N'12')
INSERT [dbo].[tbAdmin] ([AName], [AAge], [AUsrName], [APassword]) VALUES (N'husan', N'21', N'hs', N'12')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (5, N'husan hayer', N'22 plunket avenue papatoetoe', N'02102010155')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (2, N'sumeer sharma', N'88 gray road', N'0210456128')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (3, N'lakshy mahajan', N'auckland', N'1234256')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (4, N'jati mahajan', N'12  jetts road', N'09897899')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (5, N'husan hayer', N'22 plunket avenue papatoetoe', N'02102010155')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (6, N'kala moga', N'chugii punjab', N'9471158961')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (14, N'jagmohn jagroan', N'west street pukekohe', N'02041561235')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (8, N'teji  pagal', N'66 temp road', N'0204156412')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (9, N'shiv chaluu', N'4 pak avenue', N'0226229264')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (10, N'kala jagroan', N'jetts  punjab india', N'02041561235')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (11, N'jatinder mahajan', N'666 jetts road', N'0989789849')
INSERT [dbo].[tbCustomer] ([ID], [CustName], [CustAdr], [CustPhone]) VALUES (13, N'sukh dhaliwal', N'reding street', N'020145641380')
INSERT [dbo].[tbCustomerRentalCount] ([CID], [CCount]) VALUES (1, 9)
INSERT [dbo].[tbCustomerRentalCount] ([CID], [CCount]) VALUES (1, 2)
INSERT [dbo].[tbCustomerRentalCount] ([CID], [CCount]) VALUES (1, 5)
INSERT [dbo].[tbCustomerRentalCount] ([CID], [CCount]) VALUES (1, 3)
INSERT [dbo].[tbCustomerRentalCount] ([CID], [CCount]) VALUES (1, 3)
INSERT [dbo].[tbCustomerRentalCount] ([CID], [CCount]) VALUES (1, 5)
INSERT [dbo].[tbCustomerRentalCount] ([CID], [CCount]) VALUES (1, 3)
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (2, 1, 5, N'1/10/2018', N'3/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (5, 1, 2, N'10/10/2018', N'3/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (9, 1, 5, N'5/12/2018', N'29/11/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (10, 1, 5, N'4/12/2018', N'5/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (11, 1, 4, N'4/12/2018', N'5/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (12, 1, 4, N'11/12/2018', N'5/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (13, 1, 4, N'11/12/2018', N'20/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (14, 1, 4, N'11/12/2018', N'20/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (15, 4, 9, N'5/12/2018', N'29/11/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (16, 1, 5, N'4/12/2018', N'5/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (17, 2, 5, N'4/12/2018', N'5/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (18, 3, 3, N'1/12/2018', N'3/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (19, 3, 3, N'1/12/2018', N'3/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (20, 3, 3, N'1/12/2018', N'3/12/2018')
INSERT [dbo].[tbRental] ([id], [MID], [CID], [IssueDate], [ReturnDate]) VALUES (21, 3, 5, N'1/12/2018', N'3/12/2018')
INSERT [dbo].[tbReturn] ([ID], [MID], [CID], [DateofReturn], [Amount]) VALUES (1, 1, 3, N'3/12/2018 4:39:30 PM', 15)
INSERT [dbo].[tbReturn] ([ID], [MID], [CID], [DateofReturn], [Amount]) VALUES (2, 4, 2, N'4/12/2018 9:30:16 AM', 148)
INSERT [dbo].[tbReturn] ([ID], [MID], [CID], [DateofReturn], [Amount]) VALUES (3, 6, 5, N'4/12/2018 12:05:48 PM', 5)
INSERT [dbo].[tbVideoCount] ([VID], [VCount]) VALUES (1, 4)
INSERT [dbo].[tbVideoCount] ([VID], [VCount]) VALUES (1, 2)
INSERT [dbo].[tbVideoCount] ([VID], [VCount]) VALUES (1, 6)
INSERT [dbo].[tbVideoCount] ([VID], [VCount]) VALUES (1, 3)
INSERT [dbo].[tbVideoCount] ([VID], [VCount]) VALUES (1, 3)
INSERT [dbo].[tbVideoCount] ([VID], [VCount]) VALUES (1, 3)
INSERT [dbo].[tbVideoCount] ([VID], [VCount]) VALUES (1, 3)
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (18, 5, N'superman 2', N'2017', 2, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (18, 5, N'superman 3', N'2018', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (18, 5, N'superman 4', N'2018', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (5, 5, N'vastav', N'2015', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (6, 5, N'vastav 2', N'2015', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (7, 5, N'banjara', N'2005', 2, 3, N'babbu mann', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (8, 5, N'hashar', N'2014', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (9, 5, N'nikka zaildar', N'2013', 5, 2, N'comedy', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (10, 5, N'tik tik tik', N'2015', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (11, 5, N'avengers', N'2011', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (12, 5, N'superman', N'2017', 2, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (13, 5, N'sholay', N'1999', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (14, 5, N'robert', N'2011', 2, 26, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (15, 5, N'skyscaoer', N'2018', 5, 1, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (16, 5, N'pink panter', N'2017', 5, 2, N'action', N'pop')
INSERT [dbo].[tbVideos] ([id], [Rating], [VTitle], [VYear], [VCost], [VCopy], [VPlot], [VGenre]) VALUES (17, 5, N'hulk', N'2017', 5, 25, N'action', N'pop')
USE [master]
GO
ALTER DATABASE [dbVideo] SET  READ_WRITE 
GO
