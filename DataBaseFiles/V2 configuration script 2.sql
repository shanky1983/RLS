ALTER TABLE [dbo].[VendorOrgMapping] DROP CONSTRAINT [DF__VendorOrg__RoleN__4FA74CA4]
GO
ALTER TABLE [dbo].[VendorOrgMapping] DROP CONSTRAINT [DF__VendorOrg__AttGu__4EB3286B]
GO
ALTER TABLE [dbo].[VendorOrgAddressMapping] DROP CONSTRAINT [DF__VendorOrg__AttGu__4DBF0432]
GO
/****** Object:  Table [dbo].[VendorOrgMapping]    Script Date: 13-Feb-18 5:16:24 PM ******/
DROP TABLE [dbo].[VendorOrgMapping]
GO
/****** Object:  Table [dbo].[VendorOrgAddressMapping]    Script Date: 13-Feb-18 5:16:24 PM ******/
DROP TABLE [dbo].[VendorOrgAddressMapping]
GO
/****** Object:  Table [dbo].[VendorMaster]    Script Date: 13-Feb-18 5:16:25 PM ******/
DROP TABLE [dbo].[VendorMaster]
GO
/****** Object:  Table [dbo].[VendorInvestigationMapping]    Script Date: 13-Feb-18 5:16:25 PM ******/
DROP TABLE [dbo].[VendorInvestigationMapping]
GO
/****** Object:  Table [dbo].[VendorInvestigationMapping]    Script Date: 13-Feb-18 5:16:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorInvestigationMapping](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvestigationID] [bigint] NULL,
	[InvestigationName] [nvarchar](255) NULL,
	[VendorDisplayText] [nvarchar](255) NULL,
	[TestCode] [nvarchar](100) NULL,
	[VendorID] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendorMaster]    Script Date: 13-Feb-18 5:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorMaster](
	[VendorID] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](100) NULL,
	[Status] [nchar](1) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[PartnerType] [nvarchar](40) NULL,
	[ModifiedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[VendorApiURL] [nvarchar](1000) NULL,
 CONSTRAINT [PK_VendorMaster] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendorOrgAddressMapping]    Script Date: 13-Feb-18 5:16:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorOrgAddressMapping](
	[MappingID] [bigint] IDENTITY(1,1) NOT NULL,
	[VendorID] [bigint] NULL,
	[AttuneOrgAddressID] [bigint] NULL,
	[VendorOrgAddressID] [bigint] NULL,
	[Status] [bit] NULL,
	[CreatedBy] [bigint] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[ModifiedBy] [bigint] NOT NULL,
	[ModifiedAt] [datetime] NOT NULL,
	[LoginID] [bigint] NULL,
	[RoleID] [int] NULL,
	[LocationID] [bigint] NULL,
	[InvLocationID] [int] NULL,
	[AttGuId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendorOrgMapping]    Script Date: 13-Feb-18 5:16:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorOrgMapping](
	[VendorMappingID] [int] IDENTITY(1,1) NOT NULL,
	[VendorID] [int] NULL,
	[OrgName] [nvarchar](100) NULL,
	[AttuneOrgID] [bigint] NULL,
	[VendorOrgID] [bigint] NULL,
	[IntegrationTypeCode] [nvarchar](50) NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[AuthenticationKey] [nvarchar](510) NULL,
	[AppName] [nvarchar](510) NULL,
	[RefreshTokenLifeTime] [int] NULL,
	[AllowedOrigin] [nvarchar](max) NULL,
	[ApplicationType] [int] NULL,
	[UniqueKey] [uniqueidentifier] NULL,
	[Status] [bit] NULL,
	[SessionTokenLifeTime] [int] NULL,
	[ModifiedBy] [bigint] NULL,
	[VendorApiKey] [nvarchar](max) NULL,
	[VendorSecretKey] [nvarchar](max) NULL,
	[RequiredRefreshToken] [bit] NULL,
	[AttGuId] [uniqueidentifier] NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_VendorOrgMapping] PRIMARY KEY CLUSTERED 
(
	[VendorMappingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[VendorInvestigationMapping] ON 

GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (1, NULL, N'Glycosylated Hemoglobin', N'heamoglobin', N'HGB', 4, 315, CAST(N'2016-12-09T10:25:13.727' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (2, NULL, N'Blood Sugar- Fasting', N'prefood_sugar', N'GLUF', 4, 315, CAST(N'2016-12-09T10:25:13.747' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (3, NULL, N'Glucose (2hr Post Prandial)', N'postfood_sugar', N'GLUP', 4, 315, CAST(N'2016-12-09T10:25:13.750' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (4, NULL, N'HbA1C', N'hba1c', N'HBA1C', 4, 315, CAST(N'2016-12-09T10:25:13.757' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (5, NULL, N'LDL', N'ldl', N'LDL', 4, 315, CAST(N'2016-12-09T10:25:13.760' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (6, NULL, N'HDL', N'hdl', N'HDL', 4, 315, CAST(N'2016-12-09T10:25:13.767' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (7, NULL, N'Total Cholesterol', N'cholestrol', N'TCL', 4, 315, CAST(N'2016-12-09T10:25:13.770' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (8, 3145, N'Triglycerides', N'tryglycerides', N'TGS', 4, 315, CAST(N'2016-12-09T10:25:13.773' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (9, NULL, N'Glycosylated Hemoglobin', N'heamoglobin', N'HGB', 4, 315, CAST(N'2016-12-21T15:32:57.683' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (10, NULL, N'Blood Sugar- Fasting', N'prefood_sugar', N'GLUF', 4, 315, CAST(N'2016-12-21T15:32:57.697' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (11, NULL, N'Glucose (2hr Post Prandial)', N'postfood_sugar', N'GLUP', 4, 315, CAST(N'2016-12-21T15:32:57.700' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (12, NULL, N'HbA1C', N'hba1c', N'HBA1C', 4, 315, CAST(N'2016-12-21T15:32:57.710' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (13, NULL, N'LDL', N'ldl', N'LDL', 4, 315, CAST(N'2016-12-21T15:32:57.713' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (14, NULL, N'HDL', N'hdl', N'HDL', 4, 315, CAST(N'2016-12-21T15:32:57.720' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (15, NULL, N'Total Cholesterol', N'cholestrol', N'TCL', 4, 315, CAST(N'2016-12-21T15:32:57.727' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (16, NULL, N'Glycosylated Hemoglobin', N'heamoglobin', N'HGB', 4, 315, CAST(N'2016-12-23T11:50:03.033' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (17, NULL, N'Blood Sugar- Fasting', N'prefood_sugar', N'GLUF', 4, 315, CAST(N'2016-12-23T11:50:03.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (18, NULL, N'Glucose (2hr Post Prandial)', N'postfood_sugar', N'GLUP', 4, 315, CAST(N'2016-12-23T11:50:03.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (19, NULL, N'HbA1C', N'hba1c', N'HBA1C', 4, 315, CAST(N'2016-12-23T11:50:03.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (20, NULL, N'LDL', N'ldl', N'LDL', 4, 315, CAST(N'2016-12-23T11:50:03.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (21, NULL, N'HDL', N'hdl', N'HDL', 4, 315, CAST(N'2016-12-23T11:50:03.057' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (22, NULL, N'Total Cholesterol', N'cholestrol', N'TCL', 4, 315, CAST(N'2016-12-23T11:50:03.060' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (23, NULL, N'Glycosylated Hemoglobin', N'heamoglobin', N'HGB', 4, 315, CAST(N'2016-12-23T16:06:03.567' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (24, NULL, N'Blood Sugar- Fasting', N'prefood_sugar', N'GLUF', 4, 315, CAST(N'2016-12-23T16:06:03.570' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (25, NULL, N'Glucose (2hr Post Prandial)', N'postfood_sugar', N'GLUP', 4, 315, CAST(N'2016-12-23T16:06:03.580' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (26, NULL, N'HbA1C', N'hba1c', N'HBA1C', 4, 315, CAST(N'2016-12-23T16:06:03.627' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (27, NULL, N'LDL', N'ldl', N'LDL', 4, 315, CAST(N'2016-12-23T16:06:03.630' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (28, NULL, N'HDL', N'hdl', N'HDL', 4, 315, CAST(N'2016-12-23T16:06:03.633' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[VendorInvestigationMapping] ([ID], [InvestigationID], [InvestigationName], [VendorDisplayText], [TestCode], [VendorID], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt]) VALUES (29, NULL, N'Total Cholesterol', N'cholestrol', N'TCL', 4, 315, CAST(N'2016-12-23T16:06:03.647' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[VendorInvestigationMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[VendorMaster] ON 

GO
INSERT [dbo].[VendorMaster] ([VendorID], [VendorName], [Status], [CreatedDate], [CreatedBy], [PartnerType], [ModifiedAt], [ModifiedBy], [VendorApiURL]) VALUES (1, N'LISKernelApp', N'A', NULL, NULL, N'Internal', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[VendorMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[VendorOrgAddressMapping] ON 

GO
INSERT [dbo].[VendorOrgAddressMapping] ([MappingID], [VendorID], [AttuneOrgAddressID], [VendorOrgAddressID], [Status], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt], [LoginID], [RoleID], [LocationID], [InvLocationID], [AttGuId]) VALUES (1, 1, 0, 0, 1, 1, CAST(N'2017-11-30T13:17:04.203' AS DateTime), 1, CAST(N'2017-11-30T13:17:04.203' AS DateTime), NULL, NULL, NULL, NULL, N'769b5378-b46b-4253-8a17-b6652ab6b077')
GO
SET IDENTITY_INSERT [dbo].[VendorOrgAddressMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[VendorOrgMapping] ON 

GO
INSERT [dbo].[VendorOrgMapping] ([VendorMappingID], [VendorID], [OrgName], [AttuneOrgID], [VendorOrgID], [IntegrationTypeCode], [ModifiedAt], [CreatedAt], [CreatedBy], [AuthenticationKey], [AppName], [RefreshTokenLifeTime], [AllowedOrigin], [ApplicationType], [UniqueKey], [Status], [SessionTokenLifeTime], [ModifiedBy], [VendorApiKey], [VendorSecretKey], [RequiredRefreshToken], [AttGuId], [RoleName]) VALUES (1, 1, NULL, 0, 0, N'LISKernelApp', NULL, NULL, NULL, NULL, NULL, 24, N'*', NULL, N'ad820ae2-aae8-44d2-a8d1-194e4e2cf2f6', 1, 24, NULL, NULL, NULL, 1, N'21c649d8-f500-46bb-8ab0-5f88d6b3b88b', N'')
GO
SET IDENTITY_INSERT [dbo].[VendorOrgMapping] OFF
GO
ALTER TABLE [dbo].[VendorOrgAddressMapping] ADD  DEFAULT (newid()) FOR [AttGuId]
GO
ALTER TABLE [dbo].[VendorOrgMapping] ADD  DEFAULT (newid()) FOR [AttGuId]
GO
ALTER TABLE [dbo].[VendorOrgMapping] ADD  DEFAULT ('') FOR [RoleName]
GO
