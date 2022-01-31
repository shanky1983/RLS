

/****** Object:  UserDefinedFunction [dbo].[GetRate]    Script Date: 05/23/2009 12:09:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetRate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetRate]
GO


/****** Object:  UserDefinedFunction [dbo].[GetRate]    Script Date: 05/23/2009 12:09:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE FUNCTION [dbo].[GetRate] (@ID bigint,@ClientID bigint,@type char(3))
RETURNS decimal(18,2)
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @rate decimal(18,2)
      BEGIN
		SELECT @rate = RM.Rate FROM InvRateMaster RM
		where RM.ClientID = @ClientID AND RM.ID = @ID AND RM.Type = @type   
		SET @rate = ISNULL(@rate,0)
     END
     RETURN(@rate);
END;

GO 

/****** Object:  Index [IDX_IDType]    Script Date: 06/01/2009 13:27:32 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[InvGroupMaster]') AND name = N'IDX_IDType')
DROP INDEX [IDX_IDType] ON [dbo].[InvGroupMaster] WITH ( ONLINE = OFF )
GO


/****** Object:  Index [IDX_IDType]    Script Date: 06/01/2009 13:27:32 ******/
CREATE NONCLUSTERED INDEX [IDX_IDType] ON [dbo].[InvGroupMaster] 
(
	[GroupID] ASC,
	[Type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO


/****** Object:  Index [IDX_IDType]    Script Date: 06/01/2009 13:29:03 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[InvRateMaster]') AND name = N'IDX_IDType')
DROP INDEX [IDX_IDType] ON [dbo].[InvRateMaster] WITH ( ONLINE = OFF )
GO



/****** Object:  Index [IDX_IDType]    Script Date: 06/01/2009 13:29:03 ******/
CREATE NONCLUSTERED INDEX [IDX_IDType] ON [dbo].[InvRateMaster] 
(
	[Type] ASC,
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO




