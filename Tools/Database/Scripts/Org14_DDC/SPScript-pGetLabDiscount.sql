
/****** Object:  StoredProcedure [dbo].[pGetLabDiscount]    Script Date: 05/12/2009 16:04:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pGetLabDiscount]
(@pOrgID int)
AS
DECLARE @ret bigint
	BEGIN 
	SET @ret = -1
	
	SELECT DiscountName,
	CASE 
	WHEN Discount<=1 THEN 
	Discount*100
	ELSE
	Discount
	END
	as Discount
	FROM DiscountMaster where OrgID=@pOrgID
	
	SET @ret = 0   
	RETURN @ret
	END	
GO
