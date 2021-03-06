USE [master]
GO
/****** Object:  Database [ChangKePower]    Script Date: 12/28/2016 14:49:43 ******/
CREATE DATABASE [ChangKePower] ON  PRIMARY 
( NAME = N'ChangKePower', FILENAME = N'd:\DataBase\ChangKePower.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ChangKePower_log', FILENAME = N'd:\DataBase\ChangKePower_log.ldf' , SIZE = 6272KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ChangKePower] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChangKePower].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChangKePower] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ChangKePower] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ChangKePower] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ChangKePower] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ChangKePower] SET ARITHABORT OFF
GO
ALTER DATABASE [ChangKePower] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ChangKePower] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ChangKePower] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ChangKePower] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ChangKePower] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ChangKePower] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ChangKePower] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ChangKePower] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ChangKePower] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ChangKePower] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ChangKePower] SET  DISABLE_BROKER
GO
ALTER DATABASE [ChangKePower] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ChangKePower] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ChangKePower] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ChangKePower] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ChangKePower] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ChangKePower] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ChangKePower] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ChangKePower] SET  READ_WRITE
GO
ALTER DATABASE [ChangKePower] SET RECOVERY FULL
GO
ALTER DATABASE [ChangKePower] SET  MULTI_USER
GO
ALTER DATABASE [ChangKePower] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ChangKePower] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'ChangKePower', N'ON'
GO
USE [ChangKePower]
GO
/****** Object:  Table [dbo].[TS_ROLE_POWER]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_ROLE_POWER](
	[UID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleCode] [nvarchar](50) NOT NULL,
	[MenuCode] [nvarchar](50) NOT NULL,
	[PortalCode] [nvarchar](50) NOT NULL,
	[IsVisible] [bit] NOT NULL,
	[IsReadOnly] [bit] NOT NULL,
 CONSTRAINT [PK_TA_Power2] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_POWER', @level2type=N'COLUMN',@level2name=N'RoleCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_POWER', @level2type=N'COLUMN',@level2name=N'MenuCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_POWER', @level2type=N'COLUMN',@level2name=N'PortalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否可见' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_POWER', @level2type=N'COLUMN',@level2name=N'IsVisible'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否只读' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_POWER', @level2type=N'COLUMN',@level2name=N'IsReadOnly'
GO
SET IDENTITY_INSERT [dbo].[TS_ROLE_POWER] ON
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (1, N'01', N'A', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (2, N'01', N'AB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (3, N'01', N'AB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (4, N'01', N'AB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (5, N'01', N'AB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (6, N'01', N'AB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (7, N'01', N'AB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (8, N'01', N'B', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (9, N'01', N'BA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (10, N'01', N'BA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (11, N'01', N'BA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (12, N'01', N'BA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (13, N'01', N'BA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (14, N'01', N'BB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (15, N'01', N'BB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (16, N'01', N'BB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (17, N'01', N'BB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (18, N'01', N'BC', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (19, N'01', N'BC10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20, N'01', N'BC20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (21, N'01', N'BC30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (22, N'01', N'BC40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (23, N'01', N'BD', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (24, N'01', N'BD10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (25, N'01', N'BD20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (26, N'01', N'BD30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (27, N'01', N'C', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (28, N'01', N'CA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (29, N'01', N'CA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30, N'01', N'CA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (31, N'01', N'CA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (32, N'01', N'CA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (33, N'01', N'CA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (34, N'01', N'CA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (35, N'01', N'CB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (36, N'01', N'CB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (37, N'01', N'CB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (38, N'01', N'CB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (39, N'01', N'CB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (40, N'01', N'CB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (41, N'01', N'CB60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (42, N'01', N'CC', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (43, N'01', N'CC10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (44, N'01', N'CC20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (45, N'01', N'CC30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (46, N'01', N'CC40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (47, N'01', N'CD', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (48, N'01', N'CD10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (49, N'01', N'CD20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (50, N'01', N'CE', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (51, N'01', N'CE10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (52, N'01', N'CE20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (53, N'01', N'CE30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (54, N'01', N'D', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (55, N'01', N'DA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (56, N'01', N'DA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (57, N'01', N'DA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (58, N'01', N'DA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (59, N'01', N'DA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (60, N'01', N'DA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (61, N'01', N'DA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (62, N'01', N'DA70', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (63, N'01', N'DA80', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (64, N'01', N'DB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (65, N'01', N'DB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (66, N'01', N'DB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (67, N'01', N'DB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (68, N'01', N'DB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (69, N'01', N'DB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (70, N'01', N'DB60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (71, N'01', N'E', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (72, N'01', N'EA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (73, N'01', N'EA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (74, N'01', N'EA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (75, N'01', N'EA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (76, N'01', N'EA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (77, N'01', N'EA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (78, N'01', N'F', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (79, N'01', N'FA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (80, N'01', N'FA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (81, N'01', N'FA20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (82, N'01', N'FA30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (83, N'01', N'FB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (84, N'01', N'FB10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (85, N'01', N'FB20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (86, N'01', N'FB30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (87, N'01', N'FB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (88, N'01', N'FB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (89, N'01', N'FC', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (90, N'01', N'FC10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (91, N'01', N'FC20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (92, N'01', N'FC30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (93, N'01', N'FC40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (94, N'01', N'FC50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (95, N'01', N'FC60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (96, N'01', N'FC70', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (97, N'01', N'FC80', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (98, N'01', N'G', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (99, N'01', N'GA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (100, N'01', N'GA10', N'WMSPC', 1, 0)
GO
print 'Processed 100 total records'
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (101, N'01', N'GA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (102, N'01', N'GA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (103, N'01', N'GA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (104, N'01', N'Z', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (105, N'01', N'ZA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (106, N'01', N'ZA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (107, N'01', N'A', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (108, N'01', N'AA', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (109, N'01', N'AB', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (110, N'01', N'AC', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (111, N'01', N'AD', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (112, N'01', N'AE', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (113, N'01', N'AF', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (114, N'01', N'B', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (115, N'01', N'BA', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (116, N'01', N'BB', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (117, N'01', N'BC', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (118, N'01', N'BD', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (119, N'01', N'BE', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (120, N'01', N'BF', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (121, N'01', N'BG', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (122, N'01', N'BH', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (123, N'01', N'BI', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (124, N'01', N'C', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (125, N'01', N'CA', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (126, N'01', N'CB', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (127, N'01', N'CC', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (128, N'01', N'CD', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (129, N'01', N'CE', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (130, N'01', N'CF', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (131, N'01', N'CG', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (10107, N'01', N'DA90', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20107, N'01', N'GA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20108, N'01', N'FC90', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20109, N'02', N'A', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20110, N'02', N'AB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20111, N'02', N'AB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20112, N'02', N'AB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20113, N'02', N'AB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20114, N'02', N'AB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20115, N'02', N'AB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20116, N'02', N'B', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20117, N'02', N'BA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20118, N'02', N'BA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20119, N'02', N'BA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20120, N'02', N'BA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20121, N'02', N'BA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20122, N'02', N'BB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20123, N'02', N'BB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20124, N'02', N'BB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20125, N'02', N'BB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20126, N'02', N'BC', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20127, N'02', N'BC10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20128, N'02', N'BC20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20129, N'02', N'BC30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20130, N'02', N'BC40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20131, N'02', N'BD', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20132, N'02', N'BD10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20133, N'02', N'BD20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20134, N'02', N'BD30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20135, N'02', N'C', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20136, N'02', N'CA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20137, N'02', N'CA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20138, N'02', N'CA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20139, N'02', N'CA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20140, N'02', N'CA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20141, N'02', N'CA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20142, N'02', N'CA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20143, N'02', N'CB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20144, N'02', N'CB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20145, N'02', N'CB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20146, N'02', N'CB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20147, N'02', N'CB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20148, N'02', N'CB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20149, N'02', N'CB60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20150, N'02', N'CC', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20151, N'02', N'CC10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20152, N'02', N'CC20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20153, N'02', N'CC30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20154, N'02', N'CC40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20155, N'02', N'CD', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20156, N'02', N'CD10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20157, N'02', N'CD20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20158, N'02', N'CE', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20159, N'02', N'CE10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20160, N'02', N'CE20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20161, N'02', N'CE30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20162, N'02', N'D', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20163, N'02', N'DA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20164, N'02', N'DA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20165, N'02', N'DA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20166, N'02', N'DA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20167, N'02', N'DA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20168, N'02', N'DA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20169, N'02', N'DA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20170, N'02', N'DA70', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20171, N'02', N'DA80', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20172, N'02', N'DA90', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20173, N'02', N'DB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20174, N'02', N'DB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20175, N'02', N'DB20', N'WMSPC', 1, 0)
GO
print 'Processed 200 total records'
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20176, N'02', N'DB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20177, N'02', N'DB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20178, N'02', N'DB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20179, N'02', N'DB60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20180, N'02', N'E', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20181, N'02', N'EA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20182, N'02', N'EA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20183, N'02', N'EA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20184, N'02', N'EA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20185, N'02', N'EA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20186, N'02', N'EA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20187, N'02', N'F', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20188, N'02', N'FA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20189, N'02', N'FA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20190, N'02', N'FA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20191, N'02', N'FA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20192, N'02', N'FB', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20193, N'02', N'FB10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20194, N'02', N'FB20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20195, N'02', N'FB30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20196, N'02', N'FB40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20197, N'02', N'FB50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20198, N'02', N'FC', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20199, N'02', N'FC10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20200, N'02', N'FC20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20201, N'02', N'FC30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20202, N'02', N'FC40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20203, N'02', N'FC50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20204, N'02', N'FC60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20205, N'02', N'FC70', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20206, N'02', N'FC80', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20207, N'02', N'FC90', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20208, N'02', N'G', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20209, N'02', N'GA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20210, N'02', N'GA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20211, N'02', N'GA20', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20212, N'02', N'GA30', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20213, N'02', N'GA40', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20214, N'02', N'GA50', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20215, N'02', N'GA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20216, N'02', N'Z', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20217, N'02', N'ZA', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20218, N'02', N'ZA10', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20219, N'02', N'A', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20220, N'02', N'AA', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20221, N'02', N'AB', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20222, N'02', N'AC', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20223, N'02', N'AD', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20224, N'02', N'AE', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20225, N'02', N'AF', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20226, N'02', N'B', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20227, N'02', N'BA', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20228, N'02', N'BB', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20229, N'02', N'BC', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20230, N'02', N'BD', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20231, N'02', N'BE', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20232, N'02', N'BF', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20233, N'02', N'BG', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20234, N'02', N'BH', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20235, N'02', N'BI', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20236, N'02', N'C', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20237, N'02', N'CA', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20238, N'02', N'CB', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20239, N'02', N'CC', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20240, N'02', N'CD', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20241, N'02', N'CE', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20242, N'02', N'CF', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20243, N'02', N'CG', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20244, N'03', N'A', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20245, N'03', N'AB', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20246, N'03', N'AB10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20247, N'03', N'AB20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20248, N'03', N'AB30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20249, N'03', N'AB40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20250, N'03', N'AB50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20251, N'03', N'B', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20252, N'03', N'BA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20253, N'03', N'BA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20254, N'03', N'BA20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20255, N'03', N'BA30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20256, N'03', N'BA40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20257, N'03', N'BB', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20258, N'03', N'BB10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20259, N'03', N'BB20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20260, N'03', N'BB30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20261, N'03', N'BC', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20262, N'03', N'BC10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20263, N'03', N'BC20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20264, N'03', N'BC30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20265, N'03', N'BC40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20266, N'03', N'BD', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20267, N'03', N'BD10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20268, N'03', N'BD20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20269, N'03', N'BD30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20270, N'03', N'C', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20271, N'03', N'CA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20272, N'03', N'CA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20273, N'03', N'CA20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20274, N'03', N'CA30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20275, N'03', N'CA40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20276, N'03', N'CA50', N'WMSPC', 0, 0)
GO
print 'Processed 300 total records'
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20277, N'03', N'CA60', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20278, N'03', N'CB', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20279, N'03', N'CB10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20280, N'03', N'CB20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20281, N'03', N'CB30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20282, N'03', N'CB40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20283, N'03', N'CB50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20284, N'03', N'CB60', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20285, N'03', N'CC', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20286, N'03', N'CC10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20287, N'03', N'CC20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20288, N'03', N'CC30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20289, N'03', N'CC40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20290, N'03', N'CD', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20291, N'03', N'CD10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20292, N'03', N'CD20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20293, N'03', N'CE', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20294, N'03', N'CE10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20295, N'03', N'CE20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20296, N'03', N'CE30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20297, N'03', N'D', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20298, N'03', N'DA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20299, N'03', N'DA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20300, N'03', N'DA20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20301, N'03', N'DA30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20302, N'03', N'DA40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20303, N'03', N'DA50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20304, N'03', N'DA60', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20305, N'03', N'DA70', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20306, N'03', N'DA80', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20307, N'03', N'DA90', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20308, N'03', N'DB', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20309, N'03', N'DB10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20310, N'03', N'DB20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20311, N'03', N'DB30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20312, N'03', N'DB40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20313, N'03', N'DB50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20314, N'03', N'DB60', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20315, N'03', N'E', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20316, N'03', N'EA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20317, N'03', N'EA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20318, N'03', N'EA20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20319, N'03', N'EA30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20320, N'03', N'EA40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20321, N'03', N'EA50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20322, N'03', N'F', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20323, N'03', N'FA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20324, N'03', N'FA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20325, N'03', N'FA20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20326, N'03', N'FA30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20327, N'03', N'FB', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20328, N'03', N'FB10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20329, N'03', N'FB20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20330, N'03', N'FB30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20331, N'03', N'FB40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20332, N'03', N'FB50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20333, N'03', N'FC', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20334, N'03', N'FC10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20335, N'03', N'FC20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20336, N'03', N'FC30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20337, N'03', N'FC40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20338, N'03', N'FC50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20339, N'03', N'FC60', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20340, N'03', N'FC70', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20341, N'03', N'FC80', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20342, N'03', N'FC90', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20343, N'03', N'G', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20344, N'03', N'GA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20345, N'03', N'GA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20346, N'03', N'GA20', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20347, N'03', N'GA30', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20348, N'03', N'GA40', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20349, N'03', N'GA50', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20350, N'03', N'GA60', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20351, N'03', N'Z', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20352, N'03', N'ZA', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20353, N'03', N'ZA10', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20354, N'03', N'A', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20355, N'03', N'AA', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20356, N'03', N'AB', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20357, N'03', N'AC', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20358, N'03', N'AD', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20359, N'03', N'AE', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20360, N'03', N'AF', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20361, N'03', N'B', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20362, N'03', N'BA', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20363, N'03', N'BB', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20364, N'03', N'BC', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20365, N'03', N'BD', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20366, N'03', N'BE', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20367, N'03', N'BF', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20368, N'03', N'BG', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20369, N'03', N'BH', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20370, N'03', N'BI', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20371, N'03', N'C', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20372, N'03', N'CA', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20373, N'03', N'CB', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20374, N'03', N'CC', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20375, N'03', N'CD', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20376, N'03', N'CE', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20377, N'03', N'CF', N'WMSPDA', 1, 0)
GO
print 'Processed 400 total records'
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20378, N'03', N'CG', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20379, N'01', N'CB70', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20380, N'01', N'GA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20381, N'01', N'AG', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20382, N'01', N'AH', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20383, N'01', N'BJ', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20384, N'01', N'BK', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20385, N'03', N'CB70', N'WMSPC', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20386, N'03', N'AG', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20387, N'03', N'AH', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20388, N'03', N'BJ', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20389, N'03', N'BK', N'WMSPDA', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20390, N'02', N'CB70', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20391, N'02', N'AG', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20392, N'02', N'AH', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20393, N'02', N'BJ', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20394, N'02', N'BK', N'WMSPDA', 0, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20395, N'01', N'EA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (20396, N'02', N'EA60', N'WMSPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30395, N'01', N'A', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30396, N'01', N'AB', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30397, N'01', N'AB10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30398, N'01', N'AB20', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30399, N'01', N'AB30', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30400, N'01', N'B', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30401, N'01', N'BA', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30402, N'01', N'BA10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30403, N'01', N'BA30', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30404, N'01', N'BA40', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30405, N'01', N'BB', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30406, N'01', N'BB10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30407, N'01', N'BB20', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30408, N'01', N'BB30', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30409, N'01', N'BB40', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30410, N'01', N'BC', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30411, N'01', N'BC10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30412, N'01', N'BC20', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30413, N'01', N'BC30', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30414, N'01', N'BC40', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30415, N'01', N'BC50', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30416, N'01', N'C', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30417, N'01', N'CA', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30418, N'01', N'CA10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30419, N'01', N'CA20', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30420, N'01', N'CB', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30421, N'01', N'CB10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30422, N'01', N'CB20', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30423, N'01', N'CB30', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30424, N'01', N'D', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30425, N'01', N'DA', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30426, N'01', N'DA10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30427, N'01', N'DB', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30428, N'01', N'DB10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30429, N'01', N'DB40', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30430, N'01', N'DB50', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30431, N'01', N'DB60', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30432, N'01', N'E', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30433, N'01', N'EA', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30434, N'01', N'EA10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30435, N'01', N'EA20', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30436, N'01', N'EA30', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30437, N'01', N'EA40', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30438, N'01', N'EA50', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30439, N'01', N'F', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30440, N'01', N'FA', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30441, N'01', N'FA10', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30442, N'01', N'FA20', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30443, N'01', N'FA30', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30444, N'01', N'FA40', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30445, N'01', N'FA50', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30446, N'01', N'FA60', N'SPAREPC', 1, 0)
INSERT [dbo].[TS_ROLE_POWER] ([UID], [RoleCode], [MenuCode], [PortalCode], [IsVisible], [IsReadOnly]) VALUES (30447, N'01', N'FC90', N'SPAREPC', 1, 0)
SET IDENTITY_INSERT [dbo].[TS_ROLE_POWER] OFF
/****** Object:  Table [dbo].[TS_ROLE_NOTIFYTYPE]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_ROLE_NOTIFYTYPE](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[RoleCode] [nvarchar](50) NOT NULL,
	[PortalCode] [nvarchar](50) NOT NULL,
	[NotifyType] [int] NOT NULL,
	[IsVisible] [bit] NOT NULL,
 CONSTRAINT [PK_TS_ROLE_NOTIFY] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_NOTIFYTYPE', @level2type=N'COLUMN',@level2name=N'RoleCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_NOTIFYTYPE', @level2type=N'COLUMN',@level2name=N'PortalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'警报类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_NOTIFYTYPE', @level2type=N'COLUMN',@level2name=N'NotifyType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否可见' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE_NOTIFYTYPE', @level2type=N'COLUMN',@level2name=N'IsVisible'
GO
SET IDENTITY_INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ON
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (2, N'01', N'SPAREPC', 0, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (3, N'01', N'SPAREPC', 1, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (4, N'01', N'SPAREPC', 2, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (5, N'01', N'SPAREPC', 3, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (6, N'01', N'SPAREPC', 4, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (7, N'01', N'SPAREPC', 5, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (8, N'01', N'SPAREPC', 6, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (9, N'01', N'SPAREPC', 7, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (10, N'01', N'SPAREPC', 8, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (11, N'01', N'SPAREPC', 9, 1)
INSERT [dbo].[TS_ROLE_NOTIFYTYPE] ([UID], [RoleCode], [PortalCode], [NotifyType], [IsVisible]) VALUES (12, N'01', N'SPAREPC', 10, 1)
SET IDENTITY_INSERT [dbo].[TS_ROLE_NOTIFYTYPE] OFF
/****** Object:  Table [dbo].[TS_ROLE]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_ROLE](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[RoleCode] [nvarchar](50) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[PowerString] [nvarchar](max) NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_TA_Role] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE', @level2type=N'COLUMN',@level2name=N'RoleCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_ROLE', @level2type=N'COLUMN',@level2name=N'Remark'
GO
SET IDENTITY_INSERT [dbo].[TS_ROLE] ON
INSERT [dbo].[TS_ROLE] ([UID], [RoleCode], [RoleName], [PowerString], [Remark]) VALUES (1, N'01', N'全功能角色', N'WMSPC:1,t1:1,t1g1:1,t1g1b1:1,t1g1b2:1,t1g1b3:1,t1g1b4:1,t1g1b5:1,t1g1b6:1,t1g1b7:1,t1g2:1,t1g2b1:1,t1g2b2:1,t1g2b3:1,t1g3:1,t1g3b1:1,t1g3b2:1,t1g3b3:1,t2:0,t2g1:0,t2g1b1:0,t2g1b2:0,t2g1b3:0,t2g2:0,t2g2b1:0,t2g2b2:0,t2g2b3:0,t2g3:0,t2g3b1:0,t2g3b2:0,t2g3b3:0,t3:1,t3g1:1,t3g1b1:1,t3g1b2:1,t3g1b3:1,t3g1b4:0,t3g2:0,t3g2b1:0,t3g2b2:0,t3g3b3:0,t3g3b4:0,t3g3b5:0,t4:1,t4g1:1,t4g1b1:0,t4g1b2:0,t4g1b3:0,t4g1b4:1,t4g1b5:1,t5:1,t5g1:0,t5g1b1:0,t5g1b2:0,t5g1b3:0,t5g2:1,t5g2b1:0,t5g2b2:0,t5g2b3:0,t5g2b4:1,t5g2b5:1,t5g3:0,t5g3b1:0,t5g3b2:0,t5g3b3:0,t6:1,t6g1:1,t6g1b1:1,WMSPDA:0', NULL)
INSERT [dbo].[TS_ROLE] ([UID], [RoleCode], [RoleName], [PowerString], [Remark]) VALUES (3, N'02', N'PC客户端全功能', NULL, NULL)
INSERT [dbo].[TS_ROLE] ([UID], [RoleCode], [RoleName], [PowerString], [Remark]) VALUES (4, N'03', N'PDA客户端全功能', NULL, NULL)
SET IDENTITY_INSERT [dbo].[TS_ROLE] OFF
/****** Object:  Table [dbo].[TS_PORTAL]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_PORTAL](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[PortalCode] [nvarchar](50) NOT NULL,
	[PortalName] [nvarchar](50) NOT NULL,
	[PortalType] [nvarchar](50) NOT NULL,
	[PortalUrl] [nvarchar](200) NULL,
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_TA_Portal] PRIMARY KEY CLUSTERED 
(
	[PortalCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_PORTAL', @level2type=N'COLUMN',@level2name=N'PortalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_PORTAL', @level2type=N'COLUMN',@level2name=N'PortalName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_PORTAL', @level2type=N'COLUMN',@level2name=N'PortalType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_PORTAL', @level2type=N'COLUMN',@level2name=N'PortalUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_PORTAL', @level2type=N'COLUMN',@level2name=N'Remark'
GO
SET IDENTITY_INSERT [dbo].[TS_PORTAL] ON
INSERT [dbo].[TS_PORTAL] ([UID], [PortalCode], [PortalName], [PortalType], [PortalUrl], [Remark]) VALUES (1001, N'SPAREPC', N'备件PC客户端', N'PC', NULL, NULL)
INSERT [dbo].[TS_PORTAL] ([UID], [PortalCode], [PortalName], [PortalType], [PortalUrl], [Remark]) VALUES (1, N'WMSPC', N'WMSPC客户端', N'PC', NULL, NULL)
INSERT [dbo].[TS_PORTAL] ([UID], [PortalCode], [PortalName], [PortalType], [PortalUrl], [Remark]) VALUES (2, N'WMSPDA', N'WMSPDA客户端', N'PDA', NULL, NULL)
SET IDENTITY_INSERT [dbo].[TS_PORTAL] OFF
/****** Object:  Table [dbo].[TS_OPERATOR]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_OPERATOR](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[OperCode] [nvarchar](50) NOT NULL,
	[OperName] [nvarchar](50) NOT NULL,
	[OperPassword] [nvarchar](200) NOT NULL,
	[DeptCode] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TA_Operator] PRIMARY KEY CLUSTERED 
(
	[OperCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_OPERATOR', @level2type=N'COLUMN',@level2name=N'OperCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_OPERATOR', @level2type=N'COLUMN',@level2name=N'OperName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_OPERATOR', @level2type=N'COLUMN',@level2name=N'OperPassword'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_OPERATOR', @level2type=N'COLUMN',@level2name=N'DeptCode'
GO
SET IDENTITY_INSERT [dbo].[TS_OPERATOR] ON
INSERT [dbo].[TS_OPERATOR] ([UID], [OperCode], [OperName], [OperPassword], [DeptCode]) VALUES (6, N'1002', N'BBB', N'EF0D2F0DD771412E', N'002')
INSERT [dbo].[TS_OPERATOR] ([UID], [OperCode], [OperName], [OperPassword], [DeptCode]) VALUES (7, N'1003', N'CCC', N'5C2DE907DB859810', N'001')
INSERT [dbo].[TS_OPERATOR] ([UID], [OperCode], [OperName], [OperPassword], [DeptCode]) VALUES (1, N'admin', N'超级管理员', N'EF0D2F0DD771412E', N'001')
SET IDENTITY_INSERT [dbo].[TS_OPERATOR] OFF
/****** Object:  Table [dbo].[TS_OPER_ROLE]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_OPER_ROLE](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[OperCode] [nvarchar](50) NOT NULL,
	[RoleCode] [nvarchar](50) NOT NULL,
	[IsBeloneTo] [bit] NOT NULL,
 CONSTRAINT [PK_TS_OperRole] PRIMARY KEY CLUSTERED 
(
	[OperCode] ASC,
	[RoleCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_OPER_ROLE', @level2type=N'COLUMN',@level2name=N'OperCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_OPER_ROLE', @level2type=N'COLUMN',@level2name=N'RoleCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否属于' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_OPER_ROLE', @level2type=N'COLUMN',@level2name=N'IsBeloneTo'
GO
SET IDENTITY_INSERT [dbo].[TS_OPER_ROLE] ON
INSERT [dbo].[TS_OPER_ROLE] ([UID], [OperCode], [RoleCode], [IsBeloneTo]) VALUES (7, N'1002', N'01', 1)
INSERT [dbo].[TS_OPER_ROLE] ([UID], [OperCode], [RoleCode], [IsBeloneTo]) VALUES (4, N'1002', N'02', 1)
INSERT [dbo].[TS_OPER_ROLE] ([UID], [OperCode], [RoleCode], [IsBeloneTo]) VALUES (5, N'1003', N'02', 1)
INSERT [dbo].[TS_OPER_ROLE] ([UID], [OperCode], [RoleCode], [IsBeloneTo]) VALUES (1, N'admin', N'01', 1)
SET IDENTITY_INSERT [dbo].[TS_OPER_ROLE] OFF
/****** Object:  Table [dbo].[TS_DEPT]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_DEPT](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[DeptCode] [nvarchar](50) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
	[ParentCode] [nvarchar](50) NOT NULL,
	[IsLeafNode] [bit] NOT NULL,
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_TA_Dept] PRIMARY KEY CLUSTERED 
(
	[DeptCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_DEPT', @level2type=N'COLUMN',@level2name=N'DeptCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_DEPT', @level2type=N'COLUMN',@level2name=N'DeptName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父级部门编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_DEPT', @level2type=N'COLUMN',@level2name=N'ParentCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否是叶节点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_DEPT', @level2type=N'COLUMN',@level2name=N'IsLeafNode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TS_DEPT', @level2type=N'COLUMN',@level2name=N'Remark'
GO
SET IDENTITY_INSERT [dbo].[TS_DEPT] ON
INSERT [dbo].[TS_DEPT] ([UID], [DeptCode], [DeptName], [ParentCode], [IsLeafNode], [Remark]) VALUES (1, N'001', N'综合管理部', N'003', 1, NULL)
SET IDENTITY_INSERT [dbo].[TS_DEPT] OFF
/****** Object:  Table [dbo].[TS_BUTTON]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_BUTTON](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[ButtonCode] [nvarchar](50) NOT NULL,
	[ButtonName] [nvarchar](50) NOT NULL,
	[ButtonType] [nvarchar](50) NOT NULL,
	[PotralCode] [nvarchar](50) NOT NULL,
	[MenuCode] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](50) NULL,
 CONSTRAINT [PK_TA_Button] PRIMARY KEY CLUSTERED 
(
	[ButtonCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_BASEDATA]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TL_BASEDATA](
	[UID] [bigint] IDENTITY(1,1) NOT NULL,
	[OperName] [nvarchar](80) NOT NULL,
	[LogTime] [datetime] NOT NULL,
	[LogType] [varchar](50) NOT NULL,
	[DataType] [varchar](50) NOT NULL,
	[OldValue] [nvarchar](4000) NOT NULL,
	[NewValue] [nvarchar](4000) NOT NULL,
	[Remark] [nvarchar](500) NULL,
 CONSTRAINT [PK_TL_BASEDATA] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TL_BASEDATA', @level2type=N'COLUMN',@level2name=N'OperName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日志时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TL_BASEDATA', @level2type=N'COLUMN',@level2name=N'LogTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日志级别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TL_BASEDATA', @level2type=N'COLUMN',@level2name=N'DataType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TL_BASEDATA', @level2type=N'COLUMN',@level2name=N'OldValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TL_BASEDATA', @level2type=N'COLUMN',@level2name=N'NewValue'
GO
SET IDENTITY_INSERT [dbo].[TL_BASEDATA] ON
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (1, N'', CAST(0x0000A6A20094A706 AS DateTime), N'Update', N'TS_ROLE', N'UID:3,RoleCode:02,RoleName:测试2,PowerString:,Remark:,', N'UID:3,RoleCode:02,RoleName:PC客户端全功能,PowerString:,Remark:,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (2, N'', CAST(0x0000A6A20094A707 AS DateTime), N'Update', N'TS_ROLE', N'UID:4,RoleCode:03,RoleName:测试3,PowerString:,Remark:,', N'UID:4,RoleCode:03,RoleName:PDA客户端全功能,PowerString:,Remark:,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (3, N'', CAST(0x0000A6A200B8AEB7 AS DateTime), N'Update', N'TA_MENU', N'UID:39,PortalCode:WMSPC,MenuCode:CB40,ParentCode:CB,ControlType:Itm,ControlName:ItmCB40,MenuText:排序发货,NameSpace:ChangKeTec.Wms.WinForm.Bills,ClassName:FormSortedDeliver2,Params:,ImageName:FolderLocked,Remark:,X:0,Y:0,', N'UID:39,PortalCode:WMSPC,MenuCode:CB40,ParentCode:CB,ControlType:Itm,ControlName:ItmCB40,MenuText:排序发货,NameSpace:ChangKeTec.Wms.WinForm.Bills,ClassName:FormSortedDeliver,Params:,ImageName:FolderLocked,Remark:,X:0,Y:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (4, N'', CAST(0x0000A6B40107335D AS DateTime), N'Update', N'TA_MENU', N'UID:80,PortalCode:WMSPC,MenuCode:FA10,ParentCode:FA,ControlType:Itm,MenuText:原料入库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartAdd,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:80,PortalCode:WMSPC,MenuCode:FA10,ParentCode:FA,ControlType:Itm,MenuText:原料入库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartAdd,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (5, N'', CAST(0x0000A6B40107335E AS DateTime), N'Update', N'TA_MENU', N'UID:81,PortalCode:WMSPC,MenuCode:FA20,ParentCode:FA,ControlType:Itm,MenuText:原料出库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartDelete,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:81,PortalCode:WMSPC,MenuCode:FA20,ParentCode:FA,ControlType:Itm,MenuText:原料出库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartDelete,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (6, N'', CAST(0x0000A6B40107335E AS DateTime), N'Update', N'TA_MENU', N'UID:82,PortalCode:WMSPC,MenuCode:FA30,ParentCode:FA,ControlType:Itm,MenuText:原料检验,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartInfo,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:82,PortalCode:WMSPC,MenuCode:FA30,ParentCode:FA,ControlType:Itm,MenuText:原料检验,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartInfo,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (7, N'', CAST(0x0000A6B40107335F AS DateTime), N'Update', N'TA_MENU', N'UID:84,PortalCode:WMSPC,MenuCode:FB10,ParentCode:FB,ControlType:Itm,MenuText:成品入库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartAdd,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:84,PortalCode:WMSPC,MenuCode:FB10,ParentCode:FB,ControlType:Itm,MenuText:成品入库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartAdd,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (8, N'', CAST(0x0000A6B40107335F AS DateTime), N'Update', N'TA_MENU', N'UID:85,PortalCode:WMSPC,MenuCode:FB20,ParentCode:FB,ControlType:Itm,MenuText:成品出库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartYes,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:85,PortalCode:WMSPC,MenuCode:FB20,ParentCode:FB,ControlType:Itm,MenuText:成品出库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartYes,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (9, N'', CAST(0x0000A6B40107335F AS DateTime), N'Update', N'TA_MENU', N'UID:86,PortalCode:WMSPC,MenuCode:FB30,ParentCode:FB,ControlType:Itm,MenuText:客户退货,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartDelete,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:86,PortalCode:WMSPC,MenuCode:FB30,ParentCode:FB,ControlType:Itm,MenuText:客户退货,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:ChartDelete,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (10, N'', CAST(0x0000A6B401073360 AS DateTime), N'Update', N'TA_MENU', N'UID:90,PortalCode:WMSPC,MenuCode:FC10,ParentCode:FC,ControlType:Itm,MenuText:盘点差异,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:DbSearch,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:90,PortalCode:WMSPC,MenuCode:FC10,ParentCode:FC,ControlType:Itm,MenuText:盘点差异,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:DbSearch,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (11, N'', CAST(0x0000A6B401073360 AS DateTime), N'Update', N'TA_MENU', N'UID:91,PortalCode:WMSPC,MenuCode:FC20,ParentCode:FC,ControlType:Itm,MenuText:其它出入库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:DbWarning,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:91,PortalCode:WMSPC,MenuCode:FC20,ParentCode:FC,ControlType:Itm,MenuText:其它出入库,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:DbWarning,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (12, N'', CAST(0x0000A6B401073360 AS DateTime), N'Update', N'TA_MENU', N'UID:92,PortalCode:WMSPC,MenuCode:FC30,ParentCode:FC,ControlType:Itm,MenuText:移库报表,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:DbRight,Remark:,X:0,Y:0,BackColor:,State:1,MenuOrder:0,', N'UID:92,PortalCode:WMSPC,MenuCode:FC30,ParentCode:FC,ControlType:Itm,MenuText:移库报表,NameSpace:ChangKeTec.Wms.WinForm.Report,ClassName:,Params:,ImageName:DbRight,Remark:,X:0,Y:0,BackColor:,State:0,MenuOrder:0,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (13, N'', CAST(0x0000A6E800F1CA0D AS DateTime), N'Update', N'TS_OPERATOR', N'UID:6,OperCode:1002,OperName:BBB,OperPassword:5C2DE907DB859810,DeptCode:001,', N'UID:6,OperCode:1002,OperName:BBB,OperPassword:5C2DE907DB859810,DeptCode:,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (14, N'', CAST(0x0000A6E800F1F4CA AS DateTime), N'Update', N'TS_OPERATOR', N'UID:6,OperCode:1002,OperName:BBB,OperPassword:5C2DE907DB859810,DeptCode:,', N'UID:6,OperCode:1002,OperName:BBB,OperPassword:5C2DE907DB859810,DeptCode:002,', NULL)
INSERT [dbo].[TL_BASEDATA] ([UID], [OperName], [LogTime], [LogType], [DataType], [OldValue], [NewValue], [Remark]) VALUES (15, N'', CAST(0x0000A6E800F2313A AS DateTime), N'Update', N'TS_OPERATOR', N'UID:6,OperCode:1002,OperName:BBB,OperPassword:5C2DE907DB859810,DeptCode:002,', N'UID:6,OperCode:1002,OperName:BBB,OperPassword:EF0D2F0DD771412E,DeptCode:002,', NULL)
SET IDENTITY_INSERT [dbo].[TL_BASEDATA] OFF
/****** Object:  Table [dbo].[TA_MENU]    Script Date: 12/28/2016 14:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TA_MENU](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[PortalCode] [nvarchar](50) NOT NULL,
	[MenuCode] [nvarchar](50) NOT NULL,
	[ParentCode] [nvarchar](50) NOT NULL,
	[ControlType] [nvarchar](50) NOT NULL,
	[MenuText] [nvarchar](50) NOT NULL,
	[NameSpace] [nvarchar](200) NULL,
	[ClassName] [nvarchar](100) NULL,
	[Params] [nvarchar](100) NULL,
	[ImageName] [nvarchar](100) NULL,
	[Remark] [nvarchar](200) NULL,
	[X] [int] NOT NULL,
	[Y] [int] NOT NULL,
	[BackColor] [varchar](50) NULL,
	[State] [int] NOT NULL,
	[MenuOrder] [int] NOT NULL,
 CONSTRAINT [PK_TA_Menu2] PRIMARY KEY CLUSTERED 
(
	[PortalCode] ASC,
	[MenuCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'PortalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'MenuCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父级菜单编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'ParentCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'控件类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'ControlType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'显示文字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'MenuText'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'命名空间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'NameSpace'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'ClassName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'参数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'Params'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图标名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'ImageName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'X坐标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'X'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Y坐标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'Y'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'背景色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'BackColor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排列顺序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TA_MENU', @level2type=N'COLUMN',@level2name=N'MenuOrder'
GO
SET IDENTITY_INSERT [dbo].[TA_MENU] ON
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4136, N'SPAREPC', N'A', N'WMSPC', N'Tab', N'系统', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4137, N'SPAREPC', N'AB', N'A', N'Grp', N'系统信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4138, N'SPAREPC', N'AB10', N'AB', N'Itm', N'单据类型', N'ChangKeTec.Wms.WinForm.Manage', N'FormBillType', N'', N'Warning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4139, N'SPAREPC', N'AB20', N'AB', N'Itm', N'子单据类型', N'ChangKeTec.Wms.WinForm.Manage', N'FormSubBillType', N'', N'GearQuestion', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4140, N'SPAREPC', N'AB30', N'AB', N'Itm', N'系统参数', N'ChangKeTec.Wms.WinForm.Manage', N'FormConfig', N'', N'Global', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4141, N'SPAREPC', N'B', N'WMSPC', N'Tab', N'基础数据', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4142, N'SPAREPC', N'BA', N'B', N'Grp', N'仓库信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4143, N'SPAREPC', N'BA10', N'BA', N'Itm', N'仓库', N'ChangKeTec.Wms.WinForm.BaseData', N'FormStoreWhse', N'', N'House', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4144, N'SPAREPC', N'BA30', N'BA', N'Itm', N'库位组', N'ChangKeTec.Wms.WinForm.BaseData', N'FormStoreGroup', N'', N'Share', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4145, N'SPAREPC', N'BA40', N'BA', N'Itm', N'库位', N'ChangKeTec.Wms.WinForm.BaseData', N'FormStoreLocation', N'', N'Db', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4146, N'SPAREPC', N'BB', N'B', N'Grp', N'备件信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4147, N'SPAREPC', N'BB10', N'BB', N'Itm', N'备件', N'ChangKeTec.Wms.WinForm.BaseData', N'FormPart', N'', N'Gear', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4148, N'SPAREPC', N'BB20', N'BB', N'Itm', N'备件类型', N'ChangKeTec.Wms.WinForm.BaseData', N'FormPartType', N'', N'GearWarning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4149, N'SPAREPC', N'BB30', N'BB', N'Itm', N'供应商', N'ChangKeTec.Wms.WinForm.BaseData', N'FormSupplier', N'', N'GearWarning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4150, N'SPAREPC', N'BB40', N'BB', N'Itm', N'单位', N'ChangKeTec.Wms.WinForm.BaseData', N'FormUnit', N'', N'GearWarning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4151, N'SPAREPC', N'BC', N'B', N'Grp', N'生产信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4152, N'SPAREPC', N'BC10', N'BC', N'Itm', N'设备', N'ChangKeTec.Wms.WinForm.BaseData', N'FormMachine', N'', N'Monitors', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4153, N'SPAREPC', N'BC20', N'BC', N'Itm', N'设备类型', N'ChangKeTec.Wms.WinForm.BaseData', N'FormMachineType', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4154, N'SPAREPC', N'BC30', N'BC', N'Itm', N'部门', N'ChangKeTec.Wms.WinForm.BaseData', N'FormDept', N'', N'UserGroup', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4155, N'SPAREPC', N'BC40', N'BC', N'Itm', N'项目', N'ChangKeTec.Wms.WinForm.BaseData', N'FormProject', N'', N'WIndow', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4156, N'SPAREPC', N'BC50', N'BC', N'Itm', N'生产线', N'ChangKeTec.Wms.WinForm.BaseData', N'FormWorkline', N'', N'GearYes', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4157, N'SPAREPC', N'C', N'WMSPC', N'Tab', N'单据', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4158, N'SPAREPC', N'CA', N'C', N'Grp', N'入库管理', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4159, N'SPAREPC', N'CA10', N'CA', N'Itm', N'采购订单', N'ChangKeTec.Wms.WinForm.Bills', N'FormPo', N'', N'Notebook', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4160, N'SPAREPC', N'CA20', N'CA', N'Itm', N'采购入库单', N'ChangKeTec.Wms.WinForm.Bills', N'FormReceive', N'', N'NotebookAdd', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4161, N'SPAREPC', N'CB', N'C', N'Grp', N'出库管理', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4162, N'SPAREPC', N'CB10', N'CB', N'Itm', N'领用申请', N'ChangKeTec.Wms.WinForm.Bills', N'FormAsk', N'', N'Folder', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4163, N'SPAREPC', N'CB20', N'CB', N'Itm', N'领用出库', N'ChangKeTec.Wms.WinForm.Bills', N'FormOut', N'', N'FolderYes', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4164, N'SPAREPC', N'CB30', N'CB', N'Itm', N'领用还回', N'ChangKeTec.Wms.WinForm.Bills', N'FormReturn', N'', N'FolderDelete', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4165, N'SPAREPC', N'D', N'WMSPC', N'Tab', N'库存', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4166, N'SPAREPC', N'DA', N'D', N'Grp', N'实时库存', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4167, N'SPAREPC', N'DA10', N'DA', N'Itm', N'当前库存', N'ChangKeTec.Wms.WinForm.Report', N'FormStockDetail', N'', N'Db', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4168, N'SPAREPC', N'DB', N'D', N'Grp', N'库存管理', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4169, N'SPAREPC', N'DB10', N'DB', N'Itm', N'库存转移', N'ChangKeTec.Wms.WinForm.Bills', N'FormStockMove', N'', N'DbStop', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4170, N'SPAREPC', N'DB40', N'DB', N'Itm', N'库存盘点', N'ChangKeTec.Wms.WinForm.Bills', N'FormInventoryPlan', N'', N'Phone', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4171, N'SPAREPC', N'DB50', N'DB', N'Itm', N'其它入库', N'ChangKeTec.Wms.WinForm.Bills', N'FormOtherIn', N'', N'DbLeft', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4172, N'SPAREPC', N'DB60', N'DB', N'Itm', N'其它出库', N'ChangKeTec.Wms.WinForm.Bills', N'FormOtherOut', N'', N'Basket', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4173, N'SPAREPC', N'E', N'WMSPC', N'Tab', N'日志', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4174, N'SPAREPC', N'EA', N'E', N'Grp', N'日志查询', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4175, N'SPAREPC', N'EA10', N'EA', N'Itm', N'登录日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormOperLog', N'', N'IdInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4176, N'SPAREPC', N'EA20', N'EA', N'Itm', N'基础数据日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormBaseDataLog', N'', N'AppInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4177, N'SPAREPC', N'EA30', N'EA', N'Itm', N'单据日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormBillLog', N'', N'FileInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4178, N'SPAREPC', N'EA40', N'EA', N'Itm', N'警报日志', N'ChangKeTec.Wms.WinForm.Manage', N'FormNotify', N'', N'DbInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4179, N'SPAREPC', N'EA50', N'EA', N'Itm', N'接口日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormInterface', N'', N'UKey', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4180, N'SPAREPC', N'F', N'WMSPC', N'Tab', N'报表', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4181, N'SPAREPC', N'FA', N'F', N'Grp', N'报表查询', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4182, N'SPAREPC', N'FA10', N'FA', N'Itm', N'下限预警', N'ChangKeTec.Wms.WinForm.Report', N'FormCalSafeQty', N'', N'ChartAdd', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4183, N'SPAREPC', N'FA20', N'FA', N'Itm', N'上限预警', N'ChangKeTec.Wms.WinForm.Report', N'FormCalSafeQty', N'', N'ChartDelete', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4184, N'SPAREPC', N'FA30', N'FA', N'Itm', N'呆滞库存', N'ChangKeTec.Wms.WinForm.Report', N'FormInaction', N'', N'ChartInfo', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4185, N'SPAREPC', N'FA40', N'FA', N'Itm', N'过期预警', N'ChangKeTec.Wms.WinForm.Report', N'FormCalOverduDays', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4186, N'SPAREPC', N'FA50', N'FA', N'Itm', N'库存账龄', N'ChangKeTec.Wms.WinForm.Report', N'FormStockAge', N'', N'ChartAdd', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4187, N'SPAREPC', N'FA60', N'FA', N'Itm', N'盘点差异', N'ChangKeTec.Wms.WinForm.Report', N'FormInventoryDetail', N'', N'ChartYes', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (2131, N'SPAREPC', N'FC90', N'FA', N'Itm', N'收发存汇总表', N'ChangKeTec.Wms.WinForm.Report', N'FormIOSUMMARYByStore', N'', N'Chart', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (1, N'WMSPC', N'A', N'WMSPC', N'Tab', N'系统', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (2, N'WMSPC', N'AB', N'A', N'Grp', N'系统查询', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (3, N'WMSPC', N'AB10', N'AB', N'Itm', N'提示信息', N'ChangKeTec.Wms.WinForm.Manage', N'FormNotify', N'', N'Warning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (4, N'WMSPC', N'AB20', N'AB', N'Itm', N'未知客户零件', N'ChangKeTec.Wms.WinForm.Manage', N'FormUnknowPartCode', N'', N'GearQuestion', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (5, N'WMSPC', N'AB30', N'AB', N'Itm', N'系统参数', N'ChangKeTec.Wms.WinForm.Manage', N'FormConfig', N'', N'Global', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (6, N'WMSPC', N'AB40', N'AB', N'Itm', N'单据类型', N'ChangKeTec.Wms.WinForm.Manage', N'FormBillType', N'', N'App', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (7, N'WMSPC', N'AB50', N'AB', N'Itm', N'账期', N'ChangKeTec.Wms.WinForm.Manage', N'FormPaymentDay', N'', N'Calender', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (8, N'WMSPC', N'B', N'WMSPC', N'Tab', N'基础数据', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (9, N'WMSPC', N'BA', N'B', N'Grp', N'仓库信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (10, N'WMSPC', N'BA10', N'BA', N'Itm', N'仓库', N'ChangKeTec.Wms.WinForm.BaseData', N'FormStoreWhse', N'', N'House', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (11, N'WMSPC', N'BA20', N'BA', N'Itm', N'库区', N'ChangKeTec.Wms.WinForm.BaseData', N'FormStoreArea', N'', N'Stop2', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (12, N'WMSPC', N'BA30', N'BA', N'Itm', N'库位组', N'ChangKeTec.Wms.WinForm.BaseData', N'FormStoreGroup', N'', N'Share', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (13, N'WMSPC', N'BA40', N'BA', N'Itm', N'库位', N'ChangKeTec.Wms.WinForm.BaseData', N'FormStoreLocation', N'', N'Db', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (14, N'WMSPC', N'BB', N'B', N'Grp', N'零件信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (15, N'WMSPC', N'BB10', N'BB', N'Itm', N'零件', N'ChangKeTec.Wms.WinForm.BaseData', N'FormPart', N'', N'Gear', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (16, N'WMSPC', N'BB20', N'BB', N'Itm', N'结算BOM', N'ChangKeTec.Wms.WinForm.BaseData', N'FormCustBom', N'', N'GearWarning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (17, N'WMSPC', N'BB30', N'BB', N'Itm', N'客户零件', N'ChangKeTec.Wms.WinForm.BaseData', N'FormCustPart', N'', N'GearInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (18, N'WMSPC', N'BC', N'B', N'Grp', N'生产信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (19, N'WMSPC', N'BC10', N'BC', N'Itm', N'生产线', N'ChangKeTec.Wms.WinForm.BaseData', N'FormWorkline', N'', N'Monitors', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (20, N'WMSPC', N'BC20', N'BC', N'Itm', N'班组', N'ChangKeTec.Wms.WinForm.BaseData', N'FormTeam', N'', N'UserGroup', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (21, N'WMSPC', N'BC30', N'BC', N'Itm', N'班次', N'ChangKeTec.Wms.WinForm.BaseData', N'FormShift', N'', N'WIndow', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (22, N'WMSPC', N'BC40', N'BC', N'Itm', N'生产BOM', N'ChangKeTec.Wms.WinForm.BaseData', N'FormBom', N'', N'GearYes', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (23, N'WMSPC', N'BD', N'B', N'Grp', N'其它信息', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (24, N'WMSPC', N'BD10', N'BD', N'Itm', N'供应商', N'ChangKeTec.Wms.WinForm.BaseData', N'FormSuperlier', N'', N'UserBlue', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (25, N'WMSPC', N'BD20', N'BD', N'Itm', N'客户', N'ChangKeTec.Wms.WinForm.BaseData', N'FormCustomer', N'', N'UserBlack', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (26, N'WMSPC', N'BD30', N'BD', N'Itm', N'委外加工商', N'ChangKeTec.Wms.WinForm.BaseData', N'FormOutsourcer', N'', N'UserBlueInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (27, N'WMSPC', N'C', N'WMSPC', N'Tab', N'单据', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (28, N'WMSPC', N'CA', N'C', N'Grp', N'原料管理', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (29, N'WMSPC', N'CA10', N'CA', N'Itm', N'按订单收货', N'ChangKeTec.Wms.WinForm.Bills', N'FormMaterialReceive', N'PoReceive', N'Notebook', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (30, N'WMSPC', N'CA20', N'CA', N'Itm', N'按ASN收货', N'ChangKeTec.Wms.WinForm.Bills', N'FormMaterialReceive', N'AsnReceive', N'NotebookAdd', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (31, N'WMSPC', N'CA30', N'CA', N'Itm', N'报检与检验', N'ChangKeTec.Wms.WinForm.Bills', N'FormInspect', N'', N'NotebookYes', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (32, N'WMSPC', N'CA40', N'CA', N'Itm', N'入库上架', N'ChangKeTec.Wms.WinForm.Bills', N'FormMaterialIn', N'', N'NotebookLocked', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (33, N'WMSPC', N'CA50', N'CA', N'Itm', N'原料退货', N'ChangKeTec.Wms.WinForm.Bills', N'FormMaterialReturn', N'', N'Notebook', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (34, N'WMSPC', N'CA60', N'CA', N'Itm', N'生产退库', N'ChangKeTec.Wms.WinForm.Bills', N'FormMaterialBack', N'', N'Notebook', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (35, N'WMSPC', N'CB', N'C', N'Grp', N'成品管理', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (36, N'WMSPC', N'CB10', N'CB', N'Itm', N'收货', N'ChangKeTec.Wms.WinForm.Bills', N'FormProductReceive', N'', N'Folder', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (37, N'WMSPC', N'CB20', N'CB', N'Itm', N'入库上架', N'ChangKeTec.Wms.WinForm.Bills', N'FormProductIn', N'', N'FolderYes', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (38, N'WMSPC', N'CB30', N'CB', N'Itm', N'发货', N'ChangKeTec.Wms.WinForm.Bills', N'FormDeliverPlan', N'', N'FolderDelete', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (39, N'WMSPC', N'CB40', N'CB', N'Itm', N'排序发货', N'ChangKeTec.Wms.WinForm.Bills', N'FormSortedDeliver', N'', N'FolderLocked', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (40, N'WMSPC', N'CB50', N'CB', N'Itm', N'批量销售', N'ChangKeTec.Wms.WinForm.Bills', N'FormProductSell', N'', N'FolderStop', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (41, N'WMSPC', N'CB60', N'CB', N'Itm', N'客户退货', N'ChangKeTec.Wms.WinForm.Bills', N'FormProductReturn', N'', N'Folder', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (3131, N'WMSPC', N'CB70', N'CB', N'Itm', N'成品返修', N'ChangKeTec.Wms.WinForm.Bills', N'FormProductRepair', N'', N'Folder', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (42, N'WMSPC', N'CC', N'C', N'Grp', N'生产管理', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (43, N'WMSPC', N'CC10', N'CC', N'Itm', N'生产计划', N'ChangKeTec.Wms.WinForm.Bills', N'FormProducePlan', N'', N'File', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (44, N'WMSPC', N'CC20', N'CC', N'Itm', N'看板叫料', N'ChangKeTec.Wms.WinForm.Bills', N'FormMaterialAsk', N'', N'FileInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (45, N'WMSPC', N'CC30', N'CC', N'Itm', N'配料备料', N'ChangKeTec.Wms.WinForm.Bills', N'FormPickPlan', N'', N'FileQuestion', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (46, N'WMSPC', N'CC40', N'CC', N'Itm', N'拣料发料', N'ChangKeTec.Wms.WinForm.Bills', N'FormPickFact', N'', N'FileLocked', N'', 0, 0, NULL, 1, 0)
GO
print 'Processed 100 total records'
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (47, N'WMSPC', N'CD', N'C', N'Grp', N'委外管理', N'ChangKeTec.Wms.WinForm.Bills', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (48, N'WMSPC', N'CD10', N'CD', N'Itm', N'委外出库', N'ChangKeTec.Wms.WinForm.Bills', N'', N'', N'File', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (49, N'WMSPC', N'CD20', N'CD', N'Itm', N'委外入库', N'ChangKeTec.Wms.WinForm.Bills', N'', N'', N'File', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (50, N'WMSPC', N'CE', N'C', N'Grp', N'原始单据', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (51, N'WMSPC', N'CE10', N'CE', N'Itm', N'采购订单', N'ChangKeTec.Wms.WinForm.Forms', N'FormPo', N'', N'Mail', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (52, N'WMSPC', N'CE20', N'CE', N'Itm', N'采购发货单', N'ChangKeTec.Wms.WinForm.Forms', N'FormAsn', N'', N'Mail', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (53, N'WMSPC', N'CE30', N'CE', N'Itm', N'销售订单', N'ChangKeTec.Wms.WinForm.Forms', N'FormSo', N'', N'MailOpen', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (54, N'WMSPC', N'D', N'WMSPC', N'Tab', N'库存', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (55, N'WMSPC', N'DA', N'D', N'Grp', N'库存查询', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (56, N'WMSPC', N'DA10', N'DA', N'Itm', N'全部', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'', N'Db', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (57, N'WMSPC', N'DA20', N'DA', N'Itm', N'原料', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'RAW', N'DbAdd', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (58, N'WMSPC', N'DA30', N'DA', N'Itm', N'线边', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'WIP', N'DbGear', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (59, N'WMSPC', N'DA40', N'DA', N'Itm', N'成品', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'FG', N'DbYes', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (60, N'WMSPC', N'DA50', N'DA', N'Itm', N'销售', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'SALE', N'DbRight', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (61, N'WMSPC', N'DA60', N'DA', N'Itm', N'隔离', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'UNDECIDE', N'DbWarning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (62, N'WMSPC', N'DA70', N'DA', N'Itm', N'报废', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'SCRAP', N'DbDelete', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (63, N'WMSPC', N'DA80', N'DA', N'Itm', N'其它', N'ChangKeTec.Wms.WinForm.Stock', N'FormStock', N'OTHER', N'DbQuestion', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (1130, N'WMSPC', N'DA90', N'DA', N'Itm', N'冻结', N'ChangKeTec.Wms.WinForm.Stock', N'FormStockFreeze', N'', N'DbLocked', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (64, N'WMSPC', N'DB', N'D', N'Grp', N'库存管理', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (65, N'WMSPC', N'DB10', N'DB', N'Itm', N'移库', N'ChangKeTec.Wms.WinForm.Bills', N'FormStockMove', N'', N'DbStop', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (66, N'WMSPC', N'DB20', N'DB', N'Itm', N'拆包', N'ChangKeTec.Wms.WinForm.Bills', N'FormUnpack', N'', N'DbUp', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (67, N'WMSPC', N'DB30', N'DB', N'Itm', N'合包', N'ChangKeTec.Wms.WinForm.Bills', N'FormPack', N'', N'DbDown', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (68, N'WMSPC', N'DB40', N'DB', N'Itm', N'盘点', N'ChangKeTec.Wms.WinForm.Bills', N'FormInventoryPlan', N'', N'Phone', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (69, N'WMSPC', N'DB50', N'DB', N'Itm', N'其他出入库', N'ChangKeTec.Wms.WinForm.Bills', N'FormOtherInout', N'', N'DbLeft', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (70, N'WMSPC', N'DB60', N'DB', N'Itm', N'码托', N'ChangKeTec.Wms.WinForm.Bills', N'FormEqptLoad', N'', N'Basket', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (71, N'WMSPC', N'E', N'WMSPC', N'Tab', N'日志', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (72, N'WMSPC', N'EA', N'E', N'Grp', N'日志查询', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (73, N'WMSPC', N'EA10', N'EA', N'Itm', N'登录日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormOperLog', N'', N'IdInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (74, N'WMSPC', N'EA20', N'EA', N'Itm', N'基础数据日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormBaseDataLog', N'', N'AppInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (75, N'WMSPC', N'EA30', N'EA', N'Itm', N'单据日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormBillLog', N'', N'FileInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (76, N'WMSPC', N'EA40', N'EA', N'Itm', N'事务日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormTransactionLog', N'', N'DbInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (77, N'WMSPC', N'EA50', N'EA', N'Itm', N'ERP接口日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormInterface', N'', N'UKey', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (3136, N'WMSPC', N'EA60', N'EA', N'Itm', N'VIN日志', N'ChangKeTec.Wms.WinForm.Logs', N'FormVinLog', N'', N'DbInfo', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (78, N'WMSPC', N'F', N'WMSPC', N'Tab', N'报表', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (79, N'WMSPC', N'FA', N'F', N'Grp', N'原料报表', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (80, N'WMSPC', N'FA10', N'FA', N'Itm', N'原料入库', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'ChartAdd', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (81, N'WMSPC', N'FA20', N'FA', N'Itm', N'原料出库', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'ChartDelete', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (82, N'WMSPC', N'FA30', N'FA', N'Itm', N'原料检验', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'ChartInfo', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (83, N'WMSPC', N'FB', N'F', N'Grp', N'成品报表', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (84, N'WMSPC', N'FB10', N'FB', N'Itm', N'成品入库', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'ChartAdd', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (85, N'WMSPC', N'FB20', N'FB', N'Itm', N'成品出库', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'ChartYes', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (86, N'WMSPC', N'FB30', N'FB', N'Itm', N'客户退货', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'ChartDelete', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (87, N'WMSPC', N'FB40', N'FB', N'Itm', N'VIN入库', N'ChangKeTec.Wms.WinForm.Report', N'FormRptVin', N'VinReceive', N'ChartAdd', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (88, N'WMSPC', N'FB50', N'FB', N'Itm', N'VIN出库', N'ChangKeTec.Wms.WinForm.Report', N'FormRptVin', N'VinDeliver', N'ChartYes', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (89, N'WMSPC', N'FC', N'F', N'Grp', N'其它报表', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (90, N'WMSPC', N'FC10', N'FC', N'Itm', N'盘点差异', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'DbSearch', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (91, N'WMSPC', N'FC20', N'FC', N'Itm', N'其它出入库', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'DbWarning', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (92, N'WMSPC', N'FC30', N'FC', N'Itm', N'移库报表', N'ChangKeTec.Wms.WinForm.Report', N'', N'', N'DbRight', N'', 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (93, N'WMSPC', N'FC40', N'FC', N'Itm', N'出入库汇总', N'ChangKeTec.Wms.WinForm.Report', N'FormRptInOutSummary', N'', N'Chart', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (94, N'WMSPC', N'FC50', N'FC', N'Itm', N'在库库龄', N'ChangKeTec.Wms.WinForm.Report', N'FormRptStockDays', N'', N'Chart', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (95, N'WMSPC', N'FC60', N'FC', N'Itm', N'出入库流水', N'ChangKeTec.Wms.WinForm.Report', N'FormRptInOutList', N'', N'Chart', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (96, N'WMSPC', N'FC70', N'FC', N'Itm', N'过期预警', N'ChangKeTec.Wms.WinForm.Report', N'FormRptCalOverduDays', N'', N'Chart', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (97, N'WMSPC', N'FC80', N'FC', N'Itm', N'安全库存预警', N'ChangKeTec.Wms.WinForm.Report', N'FormRptCalSafeQty', N'', N'Chart', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (98, N'WMSPC', N'G', N'WMSPC', N'Tab', N'标签', N'', N'', N'', NULL, NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (99, N'WMSPC', N'GA', N'G', N'Grp', N'标签打印', N'', N'', N'', NULL, NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (100, N'WMSPC', N'GA10', N'GA', N'Itm', N'原料标签', N'ChangKeTec.Wms.WinForm.Barcode', N'FormMaterialBarcodeCreateAndPrint', N'', N'PrinterInfo', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (101, N'WMSPC', N'GA20', N'GA', N'Itm', N'成品标签', N'ChangKeTec.Wms.WinForm.Barcode', N'FormProductBarcodeCreateAndPrint', N'', N'PrinterYes', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (102, N'WMSPC', N'GA30', N'GA', N'Itm', N'零件标签', N'ChangKeTec.Wms.WinForm.Barcode', NULL, N'', N'PrinterStop', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (103, N'WMSPC', N'GA40', N'GA', N'Itm', N'库位标签', N'ChangKeTec.Wms.WinForm.Barcode', NULL, N'', N'Printer', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (104, N'WMSPC', N'Z', N'WMSPC', N'Tab', N'定制', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (105, N'WMSPC', N'ZA', N'Z', N'Grp', N'结算比对', N'', N'', N'', N'', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (106, N'WMSPC', N'ZA10', N'ZA', N'Itm', N'VIN结算比对', N'ChangKeTec.Wms.WinForm.Bills', N'FormCompare', N'', N'FilesWarning', N'', 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (107, N'WMSPDA', N'A', N'WMSPDA', N'Tab', N'成品', NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (108, N'WMSPDA', N'AA', N'A', N'btn', N'排序发货', N'Wms.CcIntier.PdaForm.Bill.Product', N'FrmSortedDeliver', NULL, NULL, NULL, 1, 1, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (109, N'WMSPDA', N'AB', N'A', N'btn', N'完工收货', N'Wms.CcIntier.PdaForm.Bill.Product', N'FrmProductReceiveWithPlan', NULL, NULL, NULL, 1, 2, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (110, N'WMSPDA', N'AC', N'A', N'btn', N'成品入库', N'Wms.CcIntier.PdaForm.Bill.Product', N'FrmProductIn', NULL, NULL, NULL, 2, 2, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (111, N'WMSPDA', N'AD', N'A', N'btn', N'追溯绑定', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmTraceback', NULL, NULL, NULL, 1, 3, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (112, N'WMSPDA', N'AE', N'A', N'btn', N'委外入库', N'Wms.CcIntier.PdaForm.Bill.Product', N'FrmOSIn', NULL, NULL, NULL, 2, 3, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (113, N'WMSPDA', N'AF', N'A', N'btn', N'成品发货', N'Wms.CcIntier.PdaForm.Bill.Product', N'FrmProductPick', NULL, NULL, NULL, 1, 4, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (3132, N'WMSPDA', N'AG', N'A', N'btn', N'客户退货', N'Wms.CcIntier.PdaForm.Bill.Product', N'FrmProductReturn', NULL, NULL, NULL, 1, 5, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (3133, N'WMSPDA', N'AH', N'A', N'btn', N'成品返修', N'Wms.CcIntier.PdaForm.Bill.Product', N'FrmProductRepair', NULL, NULL, NULL, 2, 5, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (130, N'WMSPDA', N'B', N'WMSPDA', N'Tab', N'原料', NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (114, N'WMSPDA', N'BA', N'B', N'btn', N'订单收货', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmReceiveByBarcode', NULL, NULL, NULL, 1, 1, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (115, N'WMSPDA', N'BB', N'B', N'btn', N'订单收货(码托)', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmReceiveByBarcodewithEqpt', NULL, NULL, NULL, 2, 1, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (116, N'WMSPDA', N'BC', N'B', N'btn', N'ASN收货', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmReceiveByAsn', NULL, NULL, NULL, 1, 2, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (117, N'WMSPDA', N'BD', N'B', N'btn', N'ASN收货(校验)', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmRcvByASNCheck', NULL, NULL, NULL, 2, 2, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (118, N'WMSPDA', N'BE', N'B', N'btn', N'ASN收货(码托)', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmRcvByASNwithEqpt', NULL, NULL, NULL, 3, 2, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (119, N'WMSPDA', N'BF', N'B', N'btn', N'原料入库', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmMaterialIn', NULL, NULL, NULL, 1, 3, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (120, N'WMSPDA', N'BG', N'B', N'btn', N'生产叫料', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmAsk', NULL, NULL, NULL, 1, 4, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (121, N'WMSPDA', N'BH', N'B', N'btn', N'拣料', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmMaterialPick', NULL, NULL, NULL, 2, 4, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (122, N'WMSPDA', N'BI', N'B', N'btn', N'委外出库', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmOSPick', NULL, NULL, NULL, 1, 5, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (3134, N'WMSPDA', N'BJ', N'B', N'btn', N'原料退货', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmMaterialReturn', NULL, NULL, NULL, 2, 5, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (3135, N'WMSPDA', N'BK', N'B', N'btn', N'生产退库', N'Wms.CcIntier.PdaForm.Bill.Material', N'FrmMaterialBack', NULL, NULL, NULL, 3, 5, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (131, N'WMSPDA', N'C', N'WMSPDA', N'Tab', N'管理', NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (123, N'WMSPDA', N'CA', N'C', N'btn', N'拆包', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmUnpack', NULL, NULL, NULL, 1, 1, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (124, N'WMSPDA', N'CB', N'C', N'btn', N'合包', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmPack', NULL, NULL, NULL, 2, 1, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (125, N'WMSPDA', N'CC', N'C', N'btn', N'临时盘点', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmTempCheck', NULL, NULL, NULL, 1, 2, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (126, N'WMSPDA', N'CD', N'C', N'btn', N'计划盘点', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmPlanCheck', NULL, NULL, NULL, 2, 2, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (127, N'WMSPDA', N'CE', N'C', N'btn', N'移库', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmStockMove', NULL, NULL, NULL, 1, 3, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (128, N'WMSPDA', N'CF', N'C', N'btn', N'其他入库', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmOtherIn', NULL, NULL, NULL, 1, 4, NULL, 1, 0)
INSERT [dbo].[TA_MENU] ([UID], [PortalCode], [MenuCode], [ParentCode], [ControlType], [MenuText], [NameSpace], [ClassName], [Params], [ImageName], [Remark], [X], [Y], [BackColor], [State], [MenuOrder]) VALUES (129, N'WMSPDA', N'CG', N'C', N'btn', N'其他出库', N'Wms.CcIntier.PdaForm.Bill.Mange', N'FrmOtherOut', NULL, NULL, NULL, 2, 4, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[TA_MENU] OFF
/****** Object:  StoredProcedure [dbo].[P_GetAllTables]    Script Date: 12/28/2016 14:49:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[P_GetAllTables]
as
begin
SELECT
     表名       = Case When A.colorder=1 Then D.name Else '' End,
     表说明     = Case When A.colorder=1 Then isnull(F.value,'') Else '' End,
     字段序号   = A.colorder,
     字段名     = A.name,
     字段说明   = isnull(G.[value],''),
     自增长       = Case When COLUMNPROPERTY( A.id,A.name,'IsIdentity')=1 Then '●'Else '' End,
     主键       = Case When exists(SELECT 1 FROM sysobjects Where xtype='PK' and parent_obj=A.id and name in (
                      SELECT name FROM sysindexes WHERE indid in( SELECT indid FROM sysindexkeys WHERE id = A.id AND colid=A.colid))) then '●' else '' end,
     类型       = B.name,
     长度       = COLUMNPROPERTY(A.id,A.name,'PRECISION'),
     小数位数   = isnull(COLUMNPROPERTY(A.id,A.name,'Scale'),0),
     允许空     = Case When A.isnullable=1 Then '●'Else '' End,
     默认值     = isnull(E.Text,''),
     占用字节数 = A.Length
 FROM
     syscolumns A
 Left Join
     systypes B
 On
     A.xusertype=B.xusertype
 Inner Join
     sysobjects D
 On
     A.id=D.id  and D.xtype='U' and  D.name<>'dtproperties'
 Left Join
     syscomments E
 on
     A.cdefault=E.id
 Left Join
 sys.extended_properties  G
 on
     A.id=G.major_id and A.colid=G.minor_id
 Left Join

 sys.extended_properties F
 On
     D.id=F.major_id and F.minor_id=0
     --where d.name='OrderInfo'    --如果只查询指定表,加上此条件
 Order By
     A.id,A.colorder
end
GO
/****** Object:  View [dbo].[VS_POWER_MENU]    Script Date: 12/28/2016 14:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VS_POWER_MENU]
AS
SELECT  dbo.TS_ROLE_POWER.UID, dbo.TS_ROLE_POWER.RoleCode, dbo.TS_ROLE_POWER.MenuCode, 
                   dbo.TS_ROLE_POWER.PortalCode, dbo.TS_ROLE_POWER.IsVisible, dbo.TS_ROLE_POWER.IsReadOnly, 
                   dbo.TA_MENU.ParentCode, dbo.TA_MENU.ControlType, dbo.TA_MENU.MenuText, dbo.TA_MENU.NameSpace, 
                   dbo.TA_MENU.ClassName, dbo.TA_MENU.Params, dbo.TA_MENU.ImageName, dbo.TA_MENU.Remark, dbo.TA_MENU.X, 
                   dbo.TA_MENU.Y, dbo.TA_MENU.BackColor, dbo.TA_MENU.State, dbo.TA_MENU.MenuOrder
FROM      dbo.TA_MENU INNER JOIN
                   dbo.TS_ROLE_POWER ON dbo.TA_MENU.MenuCode = dbo.TS_ROLE_POWER.MenuCode AND 
                   dbo.TA_MENU.PortalCode = dbo.TS_ROLE_POWER.PortalCode
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TS_ROLE_POWER"
            Begin Extent = 
               Top = 7
               Left = 289
               Bottom = 277
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TA_MENU"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 297
               Right = 241
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VS_POWER_MENU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VS_POWER_MENU'
GO
/****** Object:  View [dbo].[VS_OPER_ROLE]    Script Date: 12/28/2016 14:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VS_OPER_ROLE]
AS
SELECT   dbo.TS_OPER_ROLE.UID, dbo.TS_OPER_ROLE.OperCode, dbo.TS_OPER_ROLE.RoleCode, 
                dbo.TS_OPER_ROLE.IsBeloneTo, dbo.TS_ROLE.RoleName, dbo.TS_ROLE.Remark
FROM      dbo.TS_OPER_ROLE LEFT OUTER JOIN
                dbo.TS_ROLE ON dbo.TS_OPER_ROLE.RoleCode = dbo.TS_ROLE.RoleCode
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TS_OPER_ROLE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 240
               Right = 192
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TS_ROLE"
            Begin Extent = 
               Top = 6
               Left = 230
               Bottom = 236
               Right = 389
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VS_OPER_ROLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VS_OPER_ROLE'
GO
/****** Object:  Default [DF_TS_POWER_IsVisible]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TS_ROLE_POWER] ADD  CONSTRAINT [DF_TS_POWER_IsVisible]  DEFAULT ((0)) FOR [IsVisible]
GO
/****** Object:  Default [DF_TS_POWER_IsReadOnly]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TS_ROLE_POWER] ADD  CONSTRAINT [DF_TS_POWER_IsReadOnly]  DEFAULT ((0)) FOR [IsReadOnly]
GO
/****** Object:  Default [DF_TS_OPER_ROLE_IsBeloneTo]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TS_OPER_ROLE] ADD  CONSTRAINT [DF_TS_OPER_ROLE_IsBeloneTo]  DEFAULT ((1)) FOR [IsBeloneTo]
GO
/****** Object:  Default [DF_TS_DEPT_IsLeafNode]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TS_DEPT] ADD  CONSTRAINT [DF_TS_DEPT_IsLeafNode]  DEFAULT ((1)) FOR [IsLeafNode]
GO
/****** Object:  Default [DF_TL_BASEDATA_LogTime]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TL_BASEDATA] ADD  CONSTRAINT [DF_TL_BASEDATA_LogTime]  DEFAULT (getdate()) FOR [LogTime]
GO
/****** Object:  Default [DF_TL_BASEDATA_OldValue]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TL_BASEDATA] ADD  CONSTRAINT [DF_TL_BASEDATA_OldValue]  DEFAULT ('') FOR [OldValue]
GO
/****** Object:  Default [DF_TL_BASEDATA_NewValue]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TL_BASEDATA] ADD  CONSTRAINT [DF_TL_BASEDATA_NewValue]  DEFAULT ('') FOR [NewValue]
GO
/****** Object:  Default [DF_TS_MENU2_ParentCode]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TA_MENU] ADD  CONSTRAINT [DF_TS_MENU2_ParentCode]  DEFAULT ('''') FOR [ParentCode]
GO
/****** Object:  Default [DF_TA_MENU_X]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TA_MENU] ADD  CONSTRAINT [DF_TA_MENU_X]  DEFAULT ((0)) FOR [X]
GO
/****** Object:  Default [DF_TA_MENU_Y]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TA_MENU] ADD  CONSTRAINT [DF_TA_MENU_Y]  DEFAULT ((0)) FOR [Y]
GO
/****** Object:  Default [DF_TA_MENU_State]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TA_MENU] ADD  CONSTRAINT [DF_TA_MENU_State]  DEFAULT ((1)) FOR [State]
GO
/****** Object:  Default [DF_TA_MENU_MenuOrder]    Script Date: 12/28/2016 14:49:44 ******/
ALTER TABLE [dbo].[TA_MENU] ADD  CONSTRAINT [DF_TA_MENU_MenuOrder]  DEFAULT ((0)) FOR [MenuOrder]
GO
