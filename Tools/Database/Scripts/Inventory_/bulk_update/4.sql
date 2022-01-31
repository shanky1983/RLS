
DECLARE @tb1 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
DECLARE @tb2 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
DECLARE @tb3 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)



insert into  @tb1
select ProductID,ProductKey,sum((RcvdLSUQty)+(ISNULL(ComplimentQTY,0))),LocationID
	from StockReceivedDetails s 
	inner join StockReceived d on d.StockReceivedID=s.StockReceivedId  and d.Status in ('Approved','Received')  
	group by ProductID,ProductKey,LocationID 
 
 insert @tb3
 select ProductID,s.ProductKey,s.TotalStockReceived-t.Qty,Locid from StockInHand s 
	inner join @tb1 t  on t.proID=S.ProductID and s.ProductKey=T.BatchNo and LocationID=Locid
	WHERE  s.TotalStockReceived>t.Qty
	
 select ProductID,s.ProductKey,s.TotalStockReceived,t.Qty,Locid from StockInHand s 
	inner join @tb1 t  on t.proID=S.ProductID and s.ProductKey=T.BatchNo and LocationID=Locid
	WHERE  s.TotalStockReceived>t.Qty 



DECLARE @tbLocation AS TABLE([RowNO] int identity(1,1),          
   LocationID int) 
DECLARE @RowNo INT  
DECLARE @LocationID INT
   

INSERT @tbLocation(LocationID)
SELECT distinct LocationID from Locations l inner join @tb3 t on t.Locid=l.LocationID


 
 declare @orgid int ,@orgaddid int

-------------------STOCKINHAND-------------------------
 BEGIN     
SELECT @RowNo=COUNT(*) FROM @tbLocation 
	WHILE @RowNo>0 
	 BEGIN
	 SELECT @LocationID=LocationID FROM @tbLocation WHERE RowNO=@RowNo
	 SELECT  @OrgID=orgid, @orgaddid=OrgAddressID FROM Locations where LocationID=@LocationID

	DECLARE @SrdID BIGINT 

   IF Not EXISTS(SELECT TOP 1 * FROM  StockReceived WHERE Comments='Adhoc Details' AND FromLocationID= @LocationID and OrgID=@OrgID order by CreatedAt desc)
	BEGIN
		INSERT INTO StockReceived(StockReceivedNo,SupplierID,PurchaseOrderNo, StockReceivedDate,OrgID,Status,CreatedBy,CreatedAt,Comments,OrgAddressID,FromLocationID,ToLocationID )                                
		VALUES ('SRD000',0,'0000',GETDATE()-20,@OrgID,'Approved',1,GETDATE()-20,'Adhoc Details',@orgaddid,@LocationID ,@LocationID)                                
		SET @SrdID  = SCOPE_IDENTITY()   
	END
	ELSE
	BEGIN
		SELECT TOP 1 @SrdID= StockReceivedID FROM  StockReceived WHERE Comments='Adhoc Details' AND FromLocationID= @LocationID and OrgID=@OrgID order by CreatedAt desc
	END  
	
	INSERT INTO StockReceivedDetails (StockReceivedId, OrgID, CategoryId, ProductId, BatchNo, ExpiryDate,
	RECQuantity,ComplimentQTY, RECUnit,                   
	SellingPrice,OrgAddressID,Tax,SellingUnit,RcvdLSUQty,InvoiceQty,StockReceivedDate,LocationID,RakNo,ProductKey)
	select @SrdID,OrgID,0,S.ProductID,S.BatchNo,S.ExpiryDate, s.TotalStockReceived-t.Qty aa,0,S.SellingUnit,S.SellingPrice,
	OrgAddressID,S.Tax,S.SellingUnit,s.TotalStockReceived-t.Qty,1,GETDATE()-20,LocationID,S.RakNo,ProductKey from StockInHand s 
	  inner join  @tb1 t  on t.proID=S.ProductID and s.ProductKey=T.BatchNo and LocationID=Locid
	WHERE   s.TotalStockReceived>t.Qty and LocationID=@LocationID
	 
	SET @RowNo=@RowNo-1
	END
END

begin tran

rollback
commit

