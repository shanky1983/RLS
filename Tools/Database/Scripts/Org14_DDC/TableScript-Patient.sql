
/****** Object:  Table [dbo].[Patient]    Script Date: 11/27/2009 11:39:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Patient](
	[PatientID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[AliasName] [varchar](20) NULL,
	[RelationName] [varchar](50) NULL,
	[OrgID] [int] NULL,
	[AlternateContact] [varchar](50) NULL,
	[EMail] [nvarchar](100) NULL,
	[TITLECode] [tinyint] NULL,
	[SEX] [char](1) NULL,
	[RegistrationDTTM] [datetime] NULL,
	[DOB] [datetime] NULL,
	[OCCUPATION] [varchar](20) NULL,
	[MartialStatus] [char](1) NULL,
	[Religion] [varchar](25) NULL,
	[BloodGroup] [varchar](20) NULL,
	[Comments] [varchar](255) NULL,
	[PlaceOfBirth] [varchar](30) NULL,
	[IsConfidential] [char](1) NULL,
	[DeathDTTM] [datetime] NULL,
	[PersonalIdentification] [varchar](255) NULL,
	[Status] [char](1) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Age] [varchar](20) NULL,
	[PatientNumber] [nchar](16) NULL,
	[RegistrationFee] [decimal](18, 2) NULL,
	[CompressedName] [varchar](255) NULL,
	[AgeUnit] [varchar](10) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


