USE [master]
GO
/****** Object:  Database [MichalSurmackiLab06Zad01]    Script Date: 17/12/2018 23:45:20 ******/
CREATE DATABASE [MichalSurmackiLab06Zad01]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MichalSurmackiLab06Zad01', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MICHALSQL\MSSQL\DATA\MichalSurmackiLab06Zad01.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MichalSurmackiLab06Zad01_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MICHALSQL\MSSQL\DATA\MichalSurmackiLab06Zad01_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MichalSurmackiLab06Zad01].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET ARITHABORT OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET RECOVERY FULL 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET  MULTI_USER 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MichalSurmackiLab06Zad01', N'ON'
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET QUERY_STORE = OFF
GO
USE [MichalSurmackiLab06Zad01]
GO
/****** Object:  Table [dbo].[Films]    Script Date: 17/12/2018 23:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Films](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Director] [nvarchar](50) NOT NULL,
	[YearOfProduction] [decimal](18, 0) NOT NULL,
	[Photo] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marks]    Script Date: 17/12/2018 23:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Film] [nvarchar](50) NOT NULL,
	[Mark] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Marks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MichalSurmackiLab06Zad01] SET  READ_WRITE 
GO
