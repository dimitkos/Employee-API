USE [master]
GO
/****** Object:  Database [myTask]    Script Date: 2/10/2019 8:49:24 μμ ******/
CREATE DATABASE [myTask]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'myTask', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\myTask.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'myTask_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\myTask_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [myTask] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [myTask].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [myTask] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [myTask] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [myTask] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [myTask] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [myTask] SET ARITHABORT OFF 
GO
ALTER DATABASE [myTask] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [myTask] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [myTask] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [myTask] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [myTask] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [myTask] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [myTask] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [myTask] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [myTask] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [myTask] SET  DISABLE_BROKER 
GO
ALTER DATABASE [myTask] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [myTask] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [myTask] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [myTask] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [myTask] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [myTask] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [myTask] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [myTask] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [myTask] SET  MULTI_USER 
GO
ALTER DATABASE [myTask] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [myTask] SET DB_CHAINING OFF 
GO
ALTER DATABASE [myTask] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [myTask] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [myTask] SET DELAYED_DURABILITY = DISABLED 
GO
USE [myTask]
GO
/****** Object:  Table [dbo].[MyTasktbl]    Script Date: 2/10/2019 8:49:24 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MyTasktbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Salary] [numeric](18, 0) NULL,
	[Birthday] [datetime] NULL,
	[Job] [varchar](50) NULL,
 CONSTRAINT [PK_MyTasktbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MyTasktbl] ON 

INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1, N'Dimitris', CAST(7000 AS Numeric(18, 0)), CAST(N'1986-09-19 06:44:34.000' AS DateTime), N'Developer')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (19, N'Makis', CAST(12000 AS Numeric(18, 0)), CAST(N'1986-09-19 06:44:34.000' AS DateTime), N'Dev')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (20, N'nikos', CAST(6789 AS Numeric(18, 0)), CAST(N'1998-04-30 13:14:19.000' AS DateTime), N'HR')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (21, N'Maria', CAST(7777 AS Numeric(18, 0)), CAST(N'1986-09-19 06:44:34.000' AS DateTime), N'Developer')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (25, N'aaaaaaaaaa', CAST(7777 AS Numeric(18, 0)), CAST(N'1986-09-19 06:44:34.000' AS DateTime), N'Devops')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1021, N'proxy', CAST(10000 AS Numeric(18, 0)), CAST(N'2006-09-19 03:44:34.000' AS DateTime), N'Proxy')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1022, N'newproxy', CAST(10000 AS Numeric(18, 0)), CAST(N'2006-09-19 03:44:34.000' AS DateTime), N'nweProxy')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1023, N'TAKIS', CAST(100000 AS Numeric(18, 0)), CAST(N'2006-09-19 03:44:34.000' AS DateTime), N'consultant')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1024, N'newTAKIS', CAST(100000 AS Numeric(18, 0)), CAST(N'2006-09-19 03:44:34.000' AS DateTime), N'new consultant')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1025, N'alex', CAST(100000 AS Numeric(18, 0)), CAST(N'2006-09-19 03:44:34.000' AS DateTime), N'alex')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1026, N'dokimi', CAST(100000 AS Numeric(18, 0)), CAST(N'2006-09-19 03:44:34.000' AS DateTime), N'dokimi')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1027, N'ProxyEmployee', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1028, N'ProxyEmployee', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1029, N'ProxyEmployee', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1030, N'ProxyEmployee', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1031, N'ProxyEmployee', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1032, N'17', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1033, N'17', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1034, N'18', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1035, N'18', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1036, N'18', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1037, N'2222', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1038, N'neo test', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1039, N'test', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1040, N'test', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1041, N'test', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1042, N'pinelopi', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1043, N'pinelopi', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1044, N'pinelopi', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1045, N'pinelopi1', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1046, N'penny', CAST(9999 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1048, N'mitsos', CAST(12000 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1049, N'Dimitris', CAST(12000 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1050, N'Dimitris Kosmas', CAST(15000 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1051, N'Dimitris K. Kosmas', CAST(25000 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'ProxyEmployee')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (1054, N'Dimitris Kosmas', CAST(130000 AS Numeric(18, 0)), CAST(N'1998-04-30 10:14:19.000' AS DateTime), N'.net developer')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (2028, N'created status', CAST(12000 AS Numeric(18, 0)), CAST(N'1986-09-19 03:44:34.000' AS DateTime), N'Devops')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (2029, N'Aggeliki', CAST(12000 AS Numeric(18, 0)), CAST(N'1986-09-19 06:44:34.000' AS DateTime), N'Dev')
INSERT [dbo].[MyTasktbl] ([Id], [Name], [Salary], [Birthday], [Job]) VALUES (2030, N'Panos', CAST(12000 AS Numeric(18, 0)), CAST(N'1986-09-19 06:44:34.000' AS DateTime), N'Dev')
SET IDENTITY_INSERT [dbo].[MyTasktbl] OFF
USE [master]
GO
ALTER DATABASE [myTask] SET  READ_WRITE 
GO
