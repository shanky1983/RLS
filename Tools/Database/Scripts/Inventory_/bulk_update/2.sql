begin tran
DECLARE @tb1 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
DECLARE @tb2 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
insert @tb1
SELECT ProductID,ProductKey,TotalLocationIssued+TotalStockDamage+TotalStockIssued+TotalStockReturn,LocationID FROM StockInHand 
 
insert @tb2(proID,batchNo,Qty,Locid)
SELECT ProductID,ProductKey,SUM(Quantity),LocationID FROM StockOutFlowDetails where   BatchNo is not null --and Description='AD'
group by ProductID,ProductKey ,LocationID 

DECLARE @tb3 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)

insert @tb3
SELECT  t2.proID,t2.batchNo,t1.Qty-t2.Qty,T1.Locid FROM @tb1 t1 inner join @tb2 t2
on T1.proID=T2.proID and T1.batchNo=T2.batchNo and T1.Locid=T2.Locid
where T1.Qty>T2.Qty  

SELECT * FROM @tb3



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
                        
                  
           
                         
  SELECT @StockOutFlowType ='Adhoc'
  EXEC dbo.pGetNextInventoryIDForMaster @OrgID,@StockOutFlowType,@StockOutFlowId OUTPUT                             
              
  SET @StockOutFlowNo = 'ADC'+ CONVERT(varchar,@StockOutFlowId)                                  
               
   INSERT INTO StockOutFlow( StockOutFlowNo,            
        StockOutFlowTypeID,            
        OrgID, OrgAddressID,            
        Status, SupplierID,            
        ConsumedBy, Description,            
        CreatedBy, CreatedAt,            
        ApprovedBy,ApprovedAt,            
        LocationID)                                  
    SELECT @StockOutFlowNo,6, @OrgID,@orgaddid,'Approved',0,0, 'Adhoc',1, GETDATE()-20,1,GETDATE() -20,@LocationID                  
  
     select @StockRecdID  = SCOPE_IDENTITY()   
     
     
      INSERT INTO StockOutFlowDetails(StockOutFlowID, OrgID,             
     OrgAddressID, ProductID, Quantity,             
     StockOutFlowDate ,LocationID,ProductKey,Description)  
     SELECT @StockRecdID,@OrgID,@orgaddid,S.proID,S.Qty ,GETDATE()-20,Locid,s.batchNo,'Ad'  
       FROM @tb3  S where LOCid=@LocationID
		
      update  S set S.Unit=t.SellingUnit,BatchNo=t.BatchNo,UnitPrice=t.CostPrice
     from StockOutFlowDetails S inner join  StockInHand T on s.ProductID=T.ProductID and s.ProductKey=t.ProductKey
     and s.LocationID=t.LocationID and s.StockOutFlowID=@StockRecdID
		
                                     
   
	 
	 
	SET @RowNo=@RowNo-1
	END
END


rollback 
commit



--DECLARE @tb4 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
--DECLARE @tb5 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT)
--insert @tb5
--SELECT ProductID,BatchNo,TotalLocationIssued+TotalStockDamage+TotalStockIssued+TotalStockReturn,LocationID FROM StockInHand 
 
--insert @tb4(proID,batchNo,Qty,Locid)
--SELECT ProductID,BatchNo,SUM(Quantity),LocationID FROM StockOutFlowDetails where   BatchNo is not null --and Description='AD'
--group by ProductID,BatchNo ,LocationID 

 
--SELECT  t2.proID,t2.batchNo,t1.Qty-t2.Qty,T1.Locid FROM @tb5 t1 inner join @tb4 t2
--on T1.proID=T2.proID and T1.batchNo=T2.batchNo and T1.Locid=T2.Locid
--where T1.Qty>T2.Qty  
 


	 