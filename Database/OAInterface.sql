USE [master]
GO
/****** Object:  Database [OAInterface]    Script Date: 12/14/2016 18:54:19 ******/
CREATE DATABASE [OAInterface] ON  PRIMARY 
( NAME = N'QADInterface', FILENAME = N'D:\database\QADInterface.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QADInterface_log', FILENAME = N'D:\database\QADInterface_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OAInterface] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OAInterface].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OAInterface] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [OAInterface] SET ANSI_NULLS OFF
GO
ALTER DATABASE [OAInterface] SET ANSI_PADDING OFF
GO
ALTER DATABASE [OAInterface] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [OAInterface] SET ARITHABORT OFF
GO
ALTER DATABASE [OAInterface] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [OAInterface] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [OAInterface] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [OAInterface] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [OAInterface] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [OAInterface] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [OAInterface] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [OAInterface] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [OAInterface] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [OAInterface] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [OAInterface] SET  DISABLE_BROKER
GO
ALTER DATABASE [OAInterface] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [OAInterface] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [OAInterface] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [OAInterface] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [OAInterface] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [OAInterface] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [OAInterface] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [OAInterface] SET  READ_WRITE
GO
ALTER DATABASE [OAInterface] SET RECOVERY FULL
GO
ALTER DATABASE [OAInterface] SET  MULTI_USER
GO
ALTER DATABASE [OAInterface] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [OAInterface] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'OAInterface', N'ON'
GO
USE [OAInterface]
GO
/****** Object:  Table [dbo].[OA_PO_SUB]    Script Date: 12/14/2016 18:54:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OA_PO_SUB](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[prdetailid] [nvarchar](50) NULL,
	[taxval] [money] NULL,
	[itemenname] [nvarchar](200) NULL,
	[tatal1] [money] NULL,
	[namespecification] [nvarchar](200) NULL,
	[no] [nvarchar](50) NULL,
	[itemnumber] [nvarchar](50) NULL,
	[itemname] [nvarchar](100) NULL,
	[specification] [nvarchar](200) NULL,
	[qty] [money] NULL,
	[um] [nvarchar](50) NULL,
	[purcose] [money] NULL,
	[plno] [nvarchar](50) NULL,
	[popurcose] [money] NULL,
	[taxate] [nvarchar](50) NULL,
	[taxamount] [money] NULL,
	[currency] [nvarchar](50) NULL,
	[tatal] [money] NULL,
	[site] [nvarchar](200) NULL,
	[provisonalprice] [bit] NULL,
	[remark] [nvarchar](500) NULL,
	[acct] [nvarchar](100) NULL,
	[subacct] [nvarchar](100) NULL,
	[costcenter] [nvarchar](100) NULL,
	[programcode] [nvarchar](50) NULL,
	[req] [nvarchar](50) NULL,
	[prln] [nvarchar](50) NULL,
	[reqby] [nvarchar](50) NULL,
	[inventoryparts] [nvarchar](50) NULL,
 CONSTRAINT [PK_TB_PO_SUB] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'明细行ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'prdetailid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'税值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'taxval'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'零件英文名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'itemenname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'不含税总价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'tatal1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称+规格型号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'namespecification'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号NO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'no'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'零件号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'itemnumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'零件名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'itemname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格型号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'specification'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'um'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'purcose'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'价格单箱号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'plno'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PO报价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'popurcose'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'税率' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'taxate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'税额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'taxamount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'币种' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'currency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'总价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'tatal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'site'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'临时价格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'provisonalprice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'acct'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分账户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'subacct'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本中心' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'costcenter'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'programcode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请单号REQ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'req'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请单行号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'prln'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'reqby'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'零件类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_SUB', @level2type=N'COLUMN',@level2name=N'inventoryparts'
GO
/****** Object:  Table [dbo].[OA_PO_MAIN]    Script Date: 12/14/2016 18:54:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OA_PO_MAIN](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[supplieradd] [nvarchar](200) NULL,
	[currencydescribe] [nvarchar](50) NULL,
	[engtitle] [nvarchar](100) NULL,
	[subject] [nvarchar](100) NULL,
	[entitychname] [nvarchar](200) NULL,
	[costcenterdecribe] [nvarchar](200) NULL,
	[billtobank] [nvarchar](200) NULL,
	[billtotax] [nvarchar](200) NULL,
	[nontaxable] [money] NULL,
	[orderno] [nvarchar](50) NULL,
	[entityenname] [nvarchar](200) NULL,
	[billtoaccounts] [nvarchar](100) NULL,
	[billtofax] [nvarchar](50) NULL,
	[taxable] [money] NULL,
	[orderate] [date] NULL,
	[entityadd] [nvarchar](200) NULL,
	[billtoadd] [nvarchar](200) NULL,
	[totalfax] [money] NULL,
	[duedate] [date] NULL,
	[entityenadd] [nvarchar](200) NULL,
	[buyer] [nvarchar](50) NULL,
	[entitypostcode] [nvarchar](50) NULL,
	[operator] [nvarchar](50) NULL,
	[entityfax] [nvarchar](50) NULL,
	[entityname] [nvarchar](200) NULL,
	[entitytel] [nvarchar](50) NULL,
	[billto] [nvarchar](50) NULL,
	[suppliercode] [nvarchar](50) NULL,
	[fob] [nvarchar](200) NULL,
	[suppliername] [nvarchar](200) NULL,
	[applicant] [nvarchar](200) NULL,
	[buyername] [nvarchar](50) NULL,
	[shipto] [nvarchar](200) NULL,
	[paymentode] [nvarchar](50) NULL,
	[theapplicantphone] [nvarchar](50) NULL,
	[paymentdescribe] [nvarchar](200) NULL,
	[remark] [nvarchar](500) NULL,
	[printorderdate] [nvarchar](50) NULL,
	[affix] [image] NULL,
	[printduedate] [date] NULL,
	[supplier] [nvarchar](100) NULL,
	[attn] [nvarchar](50) NULL,
	[currency] [nvarchar](50) NULL,
	[paymentterm] [nvarchar](50) NULL,
	[paytax] [bit] NULL,
	[phone] [nvarchar](50) NULL,
	[fax] [nvarchar](50) NULL,
	[bank] [nvarchar](100) NULL,
	[toal] [money] NULL,
	[state] [int] NULL,
	[isinvalid] [int] NULL,
	[construction] [bit] NULL,
	[IsSyn] [int] NULL,
 CONSTRAINT [PK_PO_MAIN] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'supplieradd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'币种描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'currencydescribe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应为标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'engtitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题Subject' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'subject'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entitychname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本中心描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'costcenterdecribe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票至开户行' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'billtobank'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票至税号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'billtotax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'非应纳税' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'nontaxable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'订单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'orderno'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体英文名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entityenname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票至账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'billtoaccounts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票至传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'billtofax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应纳税' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'taxable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'订货日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'orderate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entityadd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票至地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'billtoadd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'税款合计' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'totalfax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'截止日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'duedate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体英文地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entityenadd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'采购员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'buyer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体邮编' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entitypostcode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'operator'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entityfax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entityname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同主体电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'entitytel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票至' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'billto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'suppliercode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'离岸点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'fob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'suppliername'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'applicant'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'采购员姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'buyername'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收货地点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'shipto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支付方式代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'paymentode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请人联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'theapplicantphone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支付方式描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'paymentdescribe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'订货日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'printorderdate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'附件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'affix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'截止日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'printduedate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'supplier'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'attn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'币种' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'currency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支付方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'paymentterm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应付税' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'paytax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'fax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'bank'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合计' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'toal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否归档状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'state'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否作废' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'isinvalid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'现场施工' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PO_MAIN', @level2type=N'COLUMN',@level2name=N'construction'
GO
/****** Object:  Table [dbo].[OA_PART]    Script Date: 12/14/2016 18:54:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OA_PART](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NULL,
	[name] [nvarchar](100) NULL,
	[engname] [nvarchar](100) NULL,
	[model] [nvarchar](100) NULL,
	[partType] [nvarchar](50) NULL,
	[unit] [nvarchar](50) NULL,
	[enabled] [int] NULL,
	[groupcode] [nvarchar](50) NULL,
	[goodcode] [nvarchar](50) NULL,
	[address] [nvarchar](200) NULL,
	[brand] [nvarchar](50) NULL,
	[addtime] [datetime] NULL,
	[annex] [image] NULL,
	[wladdress] [nvarchar](200) NULL,
	[buyer] [nvarchar](50) NULL,
	[drawingnum] [nvarchar](200) NULL,
	[IsSyn] [int] NULL,
 CONSTRAINT [PK_TA_PART] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'英文商品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'engname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格型号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'model'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'零件类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'partType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否可用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'enabled'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品组编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'groupcode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品代码编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'goodcode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'产地' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品牌' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'brand'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'addtime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'附件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'annex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物料使用地' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'wladdress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'采购员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'buyer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图纸号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OA_PART', @level2type=N'COLUMN',@level2name=N'drawingnum'
GO
/****** Object:  Default [DF_PO_MAIN_paytax]    Script Date: 12/14/2016 18:54:20 ******/
ALTER TABLE [dbo].[OA_PO_MAIN] ADD  CONSTRAINT [DF_PO_MAIN_paytax]  DEFAULT ((0)) FOR [paytax]
GO
/****** Object:  Default [DF_TB_PO_MAIN_IsSyn]    Script Date: 12/14/2016 18:54:20 ******/
ALTER TABLE [dbo].[OA_PO_MAIN] ADD  CONSTRAINT [DF_TB_PO_MAIN_IsSyn]  DEFAULT ((0)) FOR [IsSyn]
GO
/****** Object:  Default [DF_TA_PART_enabled]    Script Date: 12/14/2016 18:54:20 ******/
ALTER TABLE [dbo].[OA_PART] ADD  CONSTRAINT [DF_TA_PART_enabled]  DEFAULT ((0)) FOR [enabled]
GO
/****** Object:  Default [DF_TA_PART_state]    Script Date: 12/14/2016 18:54:20 ******/
ALTER TABLE [dbo].[OA_PART] ADD  CONSTRAINT [DF_TA_PART_state]  DEFAULT ((0)) FOR [IsSyn]
GO
