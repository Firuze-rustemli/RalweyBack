/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [Ralweys]
GO
/****** Object:  Table [dbo].[Aboutt]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aboutt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Aboutt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](150) NOT NULL,
	[password] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoru]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoru](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Categoru] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[our_skill]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[our_skill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[value] [int] NOT NULL,
 CONSTRAINT [PK_our_skill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partners]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partners](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [nvarchar](250) NOT NULL,
	[link] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Partners] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pay_value]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pay_value](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[orderby] [int] NOT NULL,
	[pricing_plans_id] [int] NOT NULL,
 CONSTRAINT [PK_pay_value] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pricing_plans]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pricing_plans](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[orderby] [int] NOT NULL,
	[Suggest] [bit] NOT NULL,
 CONSTRAINT [PK_pricing_plans] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](250) NOT NULL,
	[icon] [nvarchar](50) NOT NULL,
	[descrip] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[logo] [nvarchar](250) NOT NULL,
	[location] [nvarchar](250) NOT NULL,
	[phone] [nvarchar](250) NOT NULL,
	[email] [nvarchar](520) NOT NULL,
	[work_hours] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Setting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slider]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slider](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [nvarchar](255) NOT NULL,
	[title] [nvarchar](250) NOT NULL,
	[descrip] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Slider] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statistic]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statistic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderby] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[value] [int] NOT NULL,
 CONSTRAINT [PK_Statistic] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terms]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[position] [nvarchar](150) NOT NULL,
	[photo] [nvarchar](250) NOT NULL,
	[facebook] [nvarchar](250) NOT NULL,
	[twitter] [nvarchar](250) NOT NULL,
	[instagram] [nvarchar](250) NOT NULL,
	[dribble] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Terms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Testimonals]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Testimonals](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[postion] [nvarchar](50) NOT NULL,
	[text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Testimonals] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Work]    Script Date: 03.11.2017 16:23:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Work](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[photo] [nvarchar](250) NOT NULL,
	[category_id] [int] NOT NULL,
 CONSTRAINT [PK_Work] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[pay_value]  WITH CHECK ADD  CONSTRAINT [FK_pay_value_pricing_plans] FOREIGN KEY([pricing_plans_id])
REFERENCES [dbo].[pricing_plans] ([id])
GO
ALTER TABLE [dbo].[pay_value] CHECK CONSTRAINT [FK_pay_value_pricing_plans]
GO
ALTER TABLE [dbo].[Work]  WITH CHECK ADD  CONSTRAINT [FK_Work_Categoru] FOREIGN KEY([category_id])
REFERENCES [dbo].[Categoru] ([id])
GO
ALTER TABLE [dbo].[Work] CHECK CONSTRAINT [FK_Work_Categoru]
GO
