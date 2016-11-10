USE [master]
GO
/****** Object:  Database [RPG]    Script Date: 10/11/2016 18:41:34 ******/
CREATE DATABASE [RPG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RPG', FILENAME = N'D:\Sql Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RPG.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RPG_log', FILENAME = N'D:\Sql Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RPG_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RPG] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RPG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RPG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RPG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RPG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RPG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RPG] SET ARITHABORT OFF 
GO
ALTER DATABASE [RPG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RPG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RPG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RPG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RPG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RPG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RPG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RPG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RPG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RPG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RPG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RPG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RPG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RPG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RPG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RPG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RPG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RPG] SET RECOVERY FULL 
GO
ALTER DATABASE [RPG] SET  MULTI_USER 
GO
ALTER DATABASE [RPG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RPG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RPG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RPG] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RPG] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RPG]
GO
/****** Object:  Table [dbo].[Personagens]    Script Date: 10/11/2016 18:41:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personagens](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](6) NULL,
	[Classe] [varchar](30) NULL,
	[Vida] [int] NULL,
	[XP] [int] NULL,
 CONSTRAINT [PK_Personagens] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [RPG] SET  READ_WRITE 
GO