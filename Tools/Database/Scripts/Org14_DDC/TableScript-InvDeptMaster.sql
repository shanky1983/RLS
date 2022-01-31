/****** Object:  Table [dbo].[InvDeptMaster]    Script Date: 04/23/2009 14:24:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvDeptMaster](
	[DeptID] [int] NULL,
	[DeptName] [varchar](100) NULL,
	[OrgID] [int] NULL,
	[Display] [char] (1) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO