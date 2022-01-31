
DECLARE @tb1 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT   primary key (proID,batchNo,Locid))
DECLARE @tb2 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT   primary key (proID,batchNo,Locid))
DECLARE @tb3 table (proID bigint,batchNo varchar(500),Qty decimal(18,2),Locid INT   primary key (proID,batchNo,Locid))

 	  
 
	

DECLARE @tbLocation AS TABLE([RowNO] int identity(1,1),          
   LocationID int) 
DECLARE @RowNo INT  
DECLARE @LocationID INT
   

INSERT @tbLocation(LocationID)
SELECT LocationID from Locations --where OrgID=29 and LocationID=4

 
 
 declare @orgid int ,@orgaddid int

-------------------STOCKINHAND-------------------------
 BEGIN     
SELECT @RowNo=COUNT(*) FROM @tbLocation 
	WHILE @RowNo>0 
	 BEGIN
 
	 SELECT @LocationID=LocationID FROM @tbLocation WHERE RowNO=@RowNo
	 SELECT  @OrgID=orgid, @orgaddid=OrgAddressID FROM Locations where LocationID=@LocationID
	 


insert into  @tb1
select ProductID,ProductKey,sum(Quantity),LocationID
	from StockOutFlowDetails (nolock) s  where LocationID=@LocationID
	group by ProductID,ProductKey,LocationID 

insert into  @tb2
select ProductID,s.ProductKey ,
s.TotalLocationIssued+s.TotalStockDamage+s.TotalStockIssued+s.TotalStockReturn
,LocationID from StockInHand (nolock) s  where LocationID=@LocationID

	 
----
--	 SELECT distinct t.* FROM @tb1 T Left join @tb2 T1 on T.batchNo=T1.batchNo and t.proID=T1.proID and t.Locid=T1.Locid
--	 where T.Locid=@LocationID and T1.batchNo is null and t.qty>0
	 
	--insert into  @tb3 
	  SELECT distinct  * FROM @tb2 T Left join @tb1 T1 on T.batchNo=T1.batchNo and t.proID=T1.proID and t.Locid=T1.Locid
	 where T.Locid=@LocationID and T1.batchNo is null and t.Qty>0
	   
      
--    DECLARE @StockOutFlowTypeID bigint                          
--	DECLARE @StockOutFlowId bigint                                    
--	DECLARE @StockOutFlowType varchar (20)                                    
--	DECLARE @StockOutFlowNo varchar (50)                           
--	DECLARE @pStockOutFlowID bigint                      
--	DECLARE @pStockReceivedID BIGINT                      
--	DECLARE @StockRecdID BIGINT                                   
--	DECLARE @pStockReceivedNo VARCHAR(50)                         



--SELECT @StockOutFlowType ='Adhoc'
--EXEC dbo.pGetNextInventoryIDForMaster @OrgID,@StockOutFlowType,@StockOutFlowId OUTPUT                             

--SET @StockOutFlowNo = 'ADC'+ CONVERT(varchar,@StockOutFlowId)                                  

--INSERT INTO StockOutFlow( StockOutFlowNo,            
--StockOutFlowTypeID,            
--OrgID, OrgAddressID,            
--Status, SupplierID,            
--ConsumedBy, Description,            
--CreatedBy, CreatedAt,            
--ApprovedBy,ApprovedAt,            
--LocationID)                                  
--SELECT @StockOutFlowNo,6, @OrgID,@orgaddid,'Approved',0,0, 'Adhoc',1, GETDATE()-20,1,GETDATE() -20,@LocationID                  

--select @StockRecdID  = SCOPE_IDENTITY()   


--INSERT INTO StockOutFlowDetails(StockOutFlowID, OrgID,             
--OrgAddressID, ProductID, Quantity,             
--StockOutFlowDate ,LocationID,ProductKey,Description)  
--SELECT @StockRecdID,@OrgID,@orgaddid,S.proID,S.Qty ,GETDATE()-20,Locid,s.batchNo,'Ad'  
--FROM @tb3  S where LOCid=@LocationID

--update  S set S.Unit=t.SellingUnit,BatchNo=t.BatchNo,UnitPrice=t.CostPrice
--from StockOutFlowDetails S inner join  StockInHand T on s.ProductID=T.ProductID and s.ProductKey=t.ProductKey
--and s.LocationID=t.LocationID and s.StockOutFlowID=@StockRecdID and T.LocationID=@LocationID
DELETE @tb1
DELETE @tb2
DELETE @tb3

	SET @RowNo=@RowNo-1
	END
END

	 
	 
  