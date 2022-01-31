begin tran
DECLARE @tb1 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
DECLARE @tb2 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
DECLARE @tb3 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
insert into  @tb1
select ProductID,ProductKey ,sum((RcvdLSUQty)+(ISNULL(ComplimentQTY,0))),LocationID
	from StockReceivedDetails s 
	inner join StockReceived d on d.StockReceivedID=s.StockReceivedId  and d.Status in ('Approved','Received')  
	group by ProductID,ProductKey,LocationID 
 
 --insert @tb3
 select ProductID,s.ProductKey ,t.Qty-s.TotalStockReceived,Locid from StockInHand s 
	inner join @tb1 t  on t.proID=S.ProductID and s.ProductKey=T.BatchNo and LocationID=Locid
	WHERE  s.TotalStockReceived<t.Qty 
 
 
 DECLARE @tbLocation AS TABLE([RowNO] int identity(1,1),          
   LocationID int) 
DECLARE @RowNo INT  
DECLARE @LocationID INT
   

INSERT @tbLocation(LocationID)
SELECT distinct lOCid from @tb3  

-------------------STOCKINHAND-------------------------
 
declare @orgid int ,@orgaddid int

BEGIN     
SELECT @RowNo=COUNT(*) FROM @tbLocation 
	WHILE @RowNo>0 
	 BEGIN
	 SELECT @LocationID=LocationID FROM @tbLocation WHERE RowNO=@RowNo
	 SELECT  @OrgID=orgid, @orgaddid=OrgAddressID FROM Locations where LocationID=@LocationID

	DECLARE @StockOutFlowTypeID bigint                          
	DECLARE @StockOutFlowId bigint                                    
	DECLARE @StockOutFlowType varchar (20)                                    
	DECLARE @StockOutFlowNo varchar (50)                           
	DECLARE @pStockOutFlowID bigint                      
	DECLARE @pStockReceivedID BIGINT                      
	DECLARE @StockRecdID BIGINT                                   
	DECLARE @pStockReceivedNo VARCHAR(50)                         
                        
  --update  S set s.TotalStockReceived=s.TotalStockReceived+Qty,s.TotalStockIssued=s.TotalStockIssued+Qty
  --   from StockInHand S inner join  @tb3 T on s.ProductID=T.proID and s.ProductKey=t.batchNo
  --   and s.LocationID=t.Locid and s.LocationID=@LocationID             
           
                         
  --SELECT @StockOutFlowType ='Adhoc'
  --EXEC dbo.pGetNextInventoryIDForMaster @OrgID,@StockOutFlowType,@StockOutFlowId OUTPUT                             
              
  --SET @StockOutFlowNo = 'ADC'+ CONVERT(varchar,@StockOutFlowId)                                  
               
  -- INSERT INTO StockOutFlow( StockOutFlowNo,            
  --      StockOutFlowTypeID,            
  --      OrgID, OrgAddressID,            
  --      Status, SupplierID,            
  --      ConsumedBy, Description,            
  --      CreatedBy, CreatedAt,            
  --      ApprovedBy,ApprovedAt,            
  --      LocationID)                                  
  --  SELECT @StockOutFlowNo,6, @OrgID,@orgaddid,'Approved',0,0, 'Adhoc',1, GETDATE()-20,1,GETDATE() -20,@LocationID                  
  
  --   select @StockRecdID  = SCOPE_IDENTITY()   
     
     
  --    INSERT INTO StockOutFlowDetails(StockOutFlowID, OrgID,             
  --   OrgAddressID, ProductID, Quantity,             
  --   StockOutFlowDate ,LocationID,ProductKey,Description)  
   SELECT @StockRecdID,@OrgID,@orgaddid,S.proID,S.Qty ,GETDATE()-20,Locid,s.batchNo,'Ad'  
       FROM @tb3  S where LOCid=@LocationID
		
     -- update  S set S.Unit=t.SellingUnit,BatchNo=t.BatchNo,UnitPrice=t.CostPrice
     --from StockOutFlowDetails S inner join  StockInHand T on s.ProductID=T.ProductID and s.ProductKey=t.ProductKey
     --and s.LocationID=t.LocationID and s.StockOutFlowID=@StockRecdID
	 
	SET @RowNo=@RowNo-1
	END
END


rollback 
commit

	 