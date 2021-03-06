USE [master]
GO
/****** Object:  Database [CourseProject]    Script Date: 16.12.2020 0:58:23 ******/
CREATE DATABASE [CourseProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CourseProject', FILENAME = N'D:\Новая папка (2)\MSSQL14.SQLEXPRESS\MSSQL\DATA\CourseProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CourseProject_log', FILENAME = N'D:\Новая папка (2)\MSSQL14.SQLEXPRESS\MSSQL\DATA\CourseProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CourseProject] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CourseProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CourseProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CourseProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CourseProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CourseProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CourseProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [CourseProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CourseProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CourseProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CourseProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CourseProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CourseProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CourseProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CourseProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CourseProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CourseProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CourseProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CourseProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CourseProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CourseProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CourseProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CourseProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CourseProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CourseProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CourseProject] SET  MULTI_USER 
GO
ALTER DATABASE [CourseProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CourseProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CourseProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CourseProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CourseProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CourseProject] SET QUERY_STORE = OFF
GO
USE [CourseProject]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 16.12.2020 0:58:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Логин] [nvarchar](30) NOT NULL,
	[Город] [nvarchar](30) NOT NULL,
	[НомерТелефона] [decimal](11, 0) NOT NULL,
	[ФИО] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Роль] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Логин] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 16.12.2020 0:58:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[НомерЗаказа] [int] IDENTITY(1,1) NOT NULL,
	[Дата] [datetime] NOT NULL,
	[ТипЗаказа] [nvarchar](30) NOT NULL,
	[СтатусЗаказа] [nvarchar](30) NOT NULL,
	[АртикулТовара] [int] NOT NULL,
	[Клиент] [nvarchar](30) NOT NULL,
	[Стоимость] [decimal](18, 0) NOT NULL,
	[Исполнитель] [nvarchar](30) NULL,
	[Комментарий] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[НомерЗаказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 16.12.2020 0:58:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[АртикулТовара] [int] NOT NULL,
	[НазваниеТовара] [nvarchar](100) NOT NULL,
	[ТипТовара] [nvarchar](100) NOT NULL,
	[Производитель] [nvarchar](100) NOT NULL,
	[Стоимость] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[АртикулТовара] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16.12.2020 0:58:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Логин] [nvarchar](30) NOT NULL,
	[Пароль] [nvarchar](30) NOT NULL,
	[Роль] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Логин] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_Users] FOREIGN KEY([Логин])
REFERENCES [dbo].[Users] ([Логин])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_Users]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([Клиент])
REFERENCES [dbo].[Clients] ([Логин])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Product] FOREIGN KEY([АртикулТовара])
REFERENCES [dbo].[Product] ([АртикулТовара])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Product]
GO
USE [master]
GO
ALTER DATABASE [CourseProject] SET  READ_WRITE 
GO
