USE [master]
GO
/****** Object:  Database [CurrencyDB]    Script Date: 19/05/2016 20:56:46 ******/
CREATE DATABASE [CurrencyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CurrencyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CurrencyDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CurrencyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CurrencyDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CurrencyDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CurrencyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CurrencyDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CurrencyDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CurrencyDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CurrencyDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CurrencyDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CurrencyDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CurrencyDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CurrencyDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CurrencyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CurrencyDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CurrencyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CurrencyDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CurrencyDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CurrencyDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CurrencyDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CurrencyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CurrencyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CurrencyDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CurrencyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CurrencyDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CurrencyDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CurrencyDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CurrencyDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CurrencyDB] SET  MULTI_USER 
GO
ALTER DATABASE [CurrencyDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CurrencyDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CurrencyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CurrencyDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CurrencyDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CurrencyDB]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 19/05/2016 20:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Currency](
	[CurrencyName] [varchar](100) NOT NULL,
	[CurrencyRate] [float] NOT NULL,
 CONSTRAINT [PK_Currency_1] PRIMARY KEY CLUSTERED 
(
	[CurrencyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'BGN Bulgaria Lev', 1.9558)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'BRL Brazil Real', 3.9891)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'CAD Canada Dollar', 1.4637)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'CHF Switzerland Franc', 1.1086)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'CNY China Yuan Renminbi', 7.3714)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'CZK Czech Republic Koruna', 27.022)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'DKK Denmark Krone', 7.4373)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'GBP United Kingdom Pound', 0.7749)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'guhub', 1.5521)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'HKD Hong Kong Dollar', 8.7575)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'HRK Croatia Kuna', 7.488)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'HUF Hungary Forint', 316.05)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'IDR Indonesia Rupiah', 15101.45)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'ILS Israel Shekel', 4.3277)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'INR India Rupee', 75.546)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'JPY Japan Yen', 123.38)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'KRW Korea (South) Won', 1340.31)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'MXN Mexico Peso', 20.7883)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'MYR Malaysia Ringgit', 4.5697)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'NOK Norway Krone', 9.2785)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'NZD New Zealand Dollar', 1.6666)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'PHP Philippines Peso', 52.624)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'PLN Poland Zloty', 4.3885)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'RON Romania New Leur', 4.499)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'RUB Russia Ruble', 73.7809)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'SEK Sweden Krona', 9.3525)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'SGD Singapore Dollar', 1.5539)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'THB Thailand Baht', 40.165)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'TRY Turkey Lira', 3.3659)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'USD United States Dollar', 1.1279)
INSERT [dbo].[Currency] ([CurrencyName], [CurrencyRate]) VALUES (N'ZAR South Africa Rand', 17.9156)
USE [master]
GO
ALTER DATABASE [CurrencyDB] SET  READ_WRITE 
GO
