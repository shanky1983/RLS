 GO
/****** Object:  StoredProcedure [dbo].[ALterStockREcd]    Script Date: 08/31/2011 12:16:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ALterStockREcd]
AS
--BEGIN Tran
DECLARE @tb1 table (RowID INT identity,IntendID BIGINT ,IntendReceivedID BIGINT)
DECLARE @loop int =1 ,@Count Int,@IntendID BIGINT,@IntendReceivedID BIGINT,
@CreatedBy bigint,@pCreatedAt DATETIME,@pRedID BIGINT,@lo1 int=1


insert @tb1 
SELECT  distinct  d.IntendID,D.IntendReceivedID FROM IntendReceived d 
inner join IntendReceivedDetail a on d.IntendReceivedID=a.IntendReceivedID where d.Status='Received'   and Tax is not null and RecdQty<>0
--and IntendID=3584
order by IntendID desc

SELECT @Count=COUNT(*) FROM @tb1 

 






 while(@loop<=@Count)

BEGIN

SELECT @IntendID=IntendID  FROM @tb1 WHERE RowID=@loop
SELECT @pCreatedAt=CreatedAt,@CreatedBy=CreatedBy,@pRedID=StockReceivedID FROM StockReceived where IndentID=@IntendID
DELETE StockReceivedDetails where StockReceivedId=@pRedID

 --SELECT @IntendID

EXEC pUpdateStockIssue11111 @IntendID,@pRedID,@CreatedBy,78,@pCreatedAt

SET @loop=@loop+1
END





DECLARE @tbstock1 table (proID bigint,batchNo varchar(100),Qty decimal)
DECLARE @tbStockinhand table (proID bigint,batchNo varchar(100),RecQty decimal,TotalQty Decimal,ExpiryDate datetime)

DECLARE @tbLocation AS TABLE([RowNO] int identity(1,1),          
   LocationID int) 
DECLARE @RowNo INT  
DECLARE @LocationID INT
   

INSERT @tbLocation(LocationID)
SELECT LocationID from Locations  where LocationID in(19  ,18)



 -------------------STOCKINHAND-------------------------
 BEGIN     
SELECT @RowNo=COUNT(*) FROM @tbLocation 
	WHILE @RowNo>0 
	 BEGIN
	 SELECT @LocationID=LocationID FROM @tbLocation WHERE RowNO=@RowNo

	INSERT @tbstock1
	select ProductID,BatchNo,(SUM(RcvdLSUQty)+SUM(ISNULL(ComplimentQTY,0))) Qty from StockReceivedDetails s 
	inner join StockReceived d on d.StockReceivedID=s.StockReceivedId where LocationID=@LocationID and d.Status='Approved'
	--and ProductId in(3988)
	group by ProductID,BatchNo
	order by BatchNo

	--select * FROM @tb1
	
	--select ProductID,S.BatchNo,TotalStockReceived ,t.Qty   from StockInHand s inner join @tb1 T on T.batchNo=s.BatchNo and T.proID=s.ProductID
	--where LocationID=@LocationID and TotalStockReceived<>Qty
	
	update S set s.TotalStockReceived=t.Qty  from StockInHand s inner join @tbstock1 T on T.batchNo=s.BatchNo and T.proID=s.ProductID
	where LocationID=@LocationID and TotalStockReceived<>Qty
	
	 
	

	
	DELETE @tbStockinhand
	DELETE @tbstock1
	SET @RowNo=@RowNo-1
	END
END











--Commit Tran
--rollback tran
GO
