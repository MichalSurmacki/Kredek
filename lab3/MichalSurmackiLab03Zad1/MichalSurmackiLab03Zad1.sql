USE [master]
GO
/****** Object:  Database [MichalSurmackiLab03Zad01]    Script Date: 26/11/2018 22:34:13 ******/
CREATE DATABASE [MichalSurmackiLab03Zad01]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MichalSurmackiLab03Zad01', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MICHALSQL\MSSQL\DATA\MichalSurmackiLab03Zad01.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MichalSurmackiLab03Zad01_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MICHALSQL\MSSQL\DATA\MichalSurmackiLab03Zad01_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MichalSurmackiLab03Zad01].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET ARITHABORT OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET RECOVERY FULL 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET  MULTI_USER 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MichalSurmackiLab03Zad01', N'ON'
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET QUERY_STORE = OFF
GO
USE [MichalSurmackiLab03Zad01]
GO
/****** Object:  Table [dbo].[CompanyDebt]    Script Date: 26/11/2018 22:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyDebt](
	[idCompany] [int] IDENTITY(1,1) NOT NULL,
	[companyNumber] [bigint] NULL,
	[name] [nvarchar](255) NULL,
	[owner] [nvarchar](255) NULL,
	[debt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCompany] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyTransaction]    Script Date: 26/11/2018 22:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyTransaction](
	[idCompanyTransaction] [int] IDENTITY(1,1) NOT NULL,
	[companyNumber] [bigint] NULL,
	[companyPayment] [int] NULL,
	[companyTransactionDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCompanyTransaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GivenCredits]    Script Date: 26/11/2018 22:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GivenCredits](
	[idCretit] [int] IDENTITY(1,1) NOT NULL,
	[creditAmount] [nvarchar](255) NULL,
	[creditRecipient] [nvarchar](255) NULL,
	[creditDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCretit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonDebt]    Script Date: 26/11/2018 22:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonDebt](
	[idPerson] [int] IDENTITY(1,1) NOT NULL,
	[personalNumber] [bigint] NULL,
	[name] [nvarchar](255) NULL,
	[surname] [nvarchar](255) NULL,
	[debt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPerson] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonTransaction]    Script Date: 26/11/2018 22:34:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonTransaction](
	[idPersonTransaction] [int] IDENTITY(1,1) NOT NULL,
	[personalNumber] [bigint] NULL,
	[personPayment] [int] NULL,
	[personTransactionDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersonTransaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MichalSurmackiLab03Zad01] SET  READ_WRITE 
GO
