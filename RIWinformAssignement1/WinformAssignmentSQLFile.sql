USE [RIAssignmentDB]
GO
/****** Object:  Table [dbo].[BillingCompanyTbl]    Script Date: 04-10-2020 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BillingCompanyTbl](
	[BillingCompanyID] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](max) NULL,
	[CompanyAddress] [varchar](max) NULL,
	[EmailID] [varchar](max) NULL,
	[ContactNo] [varchar](max) NULL,
	[CityID] [bigint] NULL,
	[WebsiteUrl] [varchar](max) NULL,
	[PinCode] [varchar](max) NULL,
 CONSTRAINT [PK_BillingCompanyTbl] PRIMARY KEY CLUSTERED 
(
	[BillingCompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BillingCompanyUserTbl]    Script Date: 04-10-2020 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BillingCompanyUserTbl](
	[CompanyUserID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](max) NULL,
	[Password] [varchar](max) NULL,
	[FirstName] [varchar](max) NULL,
	[LastName] [varchar](max) NULL,
	[EmailID] [varchar](max) NULL,
	[MobileNo] [varchar](max) NULL,
	[IsActive] [bit] NULL,
	[BillingCompanyID] [bigint] NULL,
 CONSTRAINT [PK_BillingCompanyUserTbl] PRIMARY KEY CLUSTERED 
(
	[CompanyUserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CityTbl]    Script Date: 04-10-2020 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CityTbl](
	[CityID] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](max) NULL,
	[StateID] [bigint] NULL,
 CONSTRAINT [PK_CityTbl] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CountryTbl]    Script Date: 04-10-2020 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CountryTbl](
	[CountryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](max) NULL,
 CONSTRAINT [PK_CountryTbl] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StateTbl]    Script Date: 04-10-2020 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StateTbl](
	[StateID] [bigint] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](max) NULL,
	[CountryID] [bigint] NULL,
 CONSTRAINT [PK_StateTbl] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BillingCompanyTbl] ON 

GO
INSERT [dbo].[BillingCompanyTbl] ([BillingCompanyID], [CompanyName], [CompanyAddress], [EmailID], [ContactNo], [CityID], [WebsiteUrl], [PinCode]) VALUES (1, N'RI TECH', N'Akurdi Pune', N'contact@ritechpune.com', N'9730010404', 1, N'http://www.ritechpune.com', N'411035')
GO
SET IDENTITY_INSERT [dbo].[BillingCompanyTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[BillingCompanyUserTbl] ON 

GO
INSERT [dbo].[BillingCompanyUserTbl] ([CompanyUserID], [UserName], [Password], [FirstName], [LastName], [EmailID], [MobileNo], [IsActive], [BillingCompanyID]) VALUES (1, N'admin', N'admin', N'Archana', N'Kendre', N'contact@ritechpune.com', N'9730010404', 1, 1)
GO
SET IDENTITY_INSERT [dbo].[BillingCompanyUserTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CityTbl] ON 

GO
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (1, N'Pune', 1)
GO
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (2, N'Mumbai', 1)
GO
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (3, N'Jamnagar', 2)
GO
SET IDENTITY_INSERT [dbo].[CityTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CountryTbl] ON 

GO
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (1, N'India')
GO
SET IDENTITY_INSERT [dbo].[CountryTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[StateTbl] ON 

GO
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (1, N'Maharashtra', 1)
GO
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (2, N'Gujrat', 1)
GO
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (3, N'Delhi', 1)
GO
SET IDENTITY_INSERT [dbo].[StateTbl] OFF
GO
ALTER TABLE [dbo].[BillingCompanyTbl]  WITH CHECK ADD  CONSTRAINT [FK_BillingCompanyTbl_CityTbl] FOREIGN KEY([CityID])
REFERENCES [dbo].[CityTbl] ([CityID])
GO
ALTER TABLE [dbo].[BillingCompanyTbl] CHECK CONSTRAINT [FK_BillingCompanyTbl_CityTbl]
GO
ALTER TABLE [dbo].[BillingCompanyUserTbl]  WITH CHECK ADD  CONSTRAINT [FK_BillingCompanyUserTbl_BillingCompanyTbl] FOREIGN KEY([BillingCompanyID])
REFERENCES [dbo].[BillingCompanyTbl] ([BillingCompanyID])
GO
ALTER TABLE [dbo].[BillingCompanyUserTbl] CHECK CONSTRAINT [FK_BillingCompanyUserTbl_BillingCompanyTbl]
GO
ALTER TABLE [dbo].[CityTbl]  WITH CHECK ADD  CONSTRAINT [FK_CityTbl_StateTbl] FOREIGN KEY([StateID])
REFERENCES [dbo].[StateTbl] ([StateID])
GO
ALTER TABLE [dbo].[CityTbl] CHECK CONSTRAINT [FK_CityTbl_StateTbl]
GO
ALTER TABLE [dbo].[StateTbl]  WITH CHECK ADD  CONSTRAINT [FK_StateTbl_CountryTbl] FOREIGN KEY([CountryID])
REFERENCES [dbo].[CountryTbl] ([CountryID])
GO
ALTER TABLE [dbo].[StateTbl] CHECK CONSTRAINT [FK_StateTbl_CountryTbl]
GO
