USE [master]
GO
/****** Object:  Database [dbVideo]    Script Date: 11/12/2018 10:03:12 PM ******/
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
/****** Object:  Table [dbo].[tbAdmin]    Script Date: 11/12/2018 10:03:13 PM ******/
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
/****** Object:  Table [dbo].[tbCustomer]    Script Date: 11/12/2018 10:03:13 PM ******/
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
/****** Object:  Table [dbo].[tbCustomerRentalCount]    Script Date: 11/12/2018 10:03:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomerRentalCount](
	[CID] [int] NULL,
	[CCount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRental]    Script Date: 11/12/2018 10:03:13 PM ******/
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
/****** Object:  Table [dbo].[tbReturn]    Script Date: 11/12/2018 10:03:13 PM ******/
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
/****** Object:  Table [dbo].[tbVideoCount]    Script Date: 11/12/2018 10:03:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbVideoCount](
	[VID] [int] NULL,
	[VCount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbVideos]    Script Date: 11/12/2018 10:03:13 PM ******/
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
USE [master]
GO
ALTER DATABASE [dbVideo] SET  READ_WRITE 
GO
