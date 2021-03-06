declare @pOrgid int
DECLARE                      
 @pCreatedBy BIGINT, 
 @OrgAddressID INT,                       
 @pStock InventoryItemsMapping ,        
 @LocationID int

SELECT @pOrgid=113
SELECT @pCreatedBy=1
SELECT @OrgAddressID=117


delete FinalBill where FinalBillID in(SELECT BillID FROM StockOutFlow where OrgID=@pOrgid)
delete BillingDetails where FinalBillID in(SELECT BillID FROM StockOutFlow where OrgID=@pOrgid)
delete AmountReceivedDetails where FinalBillID in(SELECT BillID FROM StockOutFlow where OrgID=@pOrgid)
delete AmountRefundDetails where FinalBillID in(SELECT BillID FROM StockOutFlow where OrgID=@pOrgid)
DELETE Products where OrgID=@pOrgid        
DELETE StockReceived where OrgID=@pOrgid
DELETE StockReceivedDetails where OrgID=@pOrgid  
DELETE InventoryIDMaster where OrgID=@pOrgid 
DELETE StockInHand where OrgID=@pOrgid                        
DELETE StockOutFlow where OrgID=@pOrgid         
DELETE StockOutFlowDetails where OrgID=@pOrgid    
DELETE ProductCategories where OrgID=@pOrgid    
DELETE TempStockReceivedDetails where OrgID=@pOrgid  
DELETE Intend where OrgID=@pOrgid  
DELETE IntendDetail where OrgID=@pOrgid  
DELETE IntendReceived where OrgID=@pOrgid  
DELETE IntendReceivedDetail where OrgID=@pOrgid  
DELETE Suppliers where OrgID=@pOrgid  
DELETE ProductSupplierRateMapping where OrgID=@pOrgid  


      
      
          
         
 

DECLARE @pCreatedAt DATETIME                                  
DECLARE @Return as BIGINT                     
DECLARE @pStockReceivedID BIGINT                      
DECLARE @pStockReceivedNo VARCHAR(50)                    
DECLARE @StockReceivedID BIGINT                    
DECLARE @StockInHand TABLE                          
  (CategoryID INT,                      
  ProductID BIGINT NULL,                          
  BatchNo VARCHAR(150),                     
  ExpiryDate DATETIME,                          
  Manufacture varchar(2000),                          
  Quantity  DECIMAL(18,2),                     
  ComplimentQTY  DECIMAL(18,2),                       
  Unit VARCHAR(150),                    
  ProductName VARCHAR(150),                    
  Rate   DECIMAL(18,2),                    
  CategoryName VARCHAR(250),             
  Tax  DECIMAL(18,2),        
  InvoiceQty   DECIMAL(18,2),
  HasExpiryDate  char(1),           
  HasBatchNo  char(1),
  CostPrice DECIMAL(18,2)
  )                    
                                    
BEGIN                                     
 SET @pCreatedAt= GETDATE()                                    
 SET @Return = -1   
 
 insert into @pStock(CategoryName,ProductName,Quantity,Tax,Rate,InvoiceQty,ExpiryDate,BatchNo,UnitPrice,Unit)
 SELECT isnull(Category,'Others'),ItemName,case when  (Quantity is null OR Quantity='') then CONVERT(decimal(18,2), '0') else Quantity end ,
 case when  (Tax is null OR Tax='') then CONVERT(decimal(18,2), '0') else Tax end ,case when  (rate is null OR rate='') then CONVERT(decimal(18,2), '0') else rate end ,1, 
 isnull(ExpiryDate,'01-JAN-1753'),isnull(BatchNo,'*'),ISNULL(UnitPrice,0.00),ISNULL(Units,'Nos') FROM  TempStock 
                       
 -----ProductCategories-----                      
  INSERT INTO ProductCategories (CategoryName,OrgID,CreatedBy,CreatedAt,OrgAddressID)                      
    SELECT  DISTINCT PC.CategoryName,@pOrgID,@pCreatedBy,@pCreatedAt,@OrgAddressID                       
    FROM @pStock PC                       
                     
                             
    INSERT INTO @StockInHand (CategoryName,CategoryID,ProductID, 
    BatchNo,ExpiryDate,Manufacture,Quantity,Unit,ProductName,Rate,Tax,InvoiceQty,HasExpiryDate,HasBatchNo,CostPrice)                    
    SELECT S.CategoryName,NULL,NULL,
    ltrim(rtrim(isnull(S.BatchNo,'*'))),S.ExpiryDate,S.Manufacture,S.Quantity,S.Unit,S.ProductName,S.Rate ,S.Tax,S.InvoiceQty,
    CASE when Convert(varchar,S.ExpiryDate,103)<Convert(varchar,'01-JAN-1950',103) then 'N'
    ELSE 'Y'
    END,Case when s.BatchNo IS null OR s.BatchNo='*' THEN 'N'
    ELSE 'Y' END,UnitPrice  FROM @pStock S                     
                     
                      
                                 
  UPDATE @StockInHand SET CategoryID=P.CategoryID                      
    FROM ProductCategories P INNER JOIN                       
    @StockInHand S on S.CategoryName=P.CategoryName AND OrgID=@pOrgID                  
                
                                
-------Products----------        --AND OrgAddressID=@OrgAddressID                
                               
   INSERT INTO Products (ProductName,CategoryID,OrgID,CreatedBy,CreatedAt,OrgAddressID,HasExpiryDate,TypeID,
   HasBatchNo,HasUsage,HasAttributes,MfgName,LSU,TaxPercent)                  
    SELECT DISTINCT P.ProductName,P.CategoryID ,@pOrgID,@pCreatedBy,@pCreatedAt,@OrgAddressID,HasExpiryDate,1,
        HasBatchNo,'N','N',p.Manufacture,P.Unit,Tax FROM @StockInHand P                    
                 
                       
                          
                             
  UPDATE @StockInHand SET ProductID=P.ProductID                      
    FROM  Products P INNER JOIN                      
    @StockInHand SH on SH.CategoryID=P.CategoryID                       
    WHERE OrgID=@pOrgID AND OrgAddressID=@OrgAddressID AND SH.ProductName = P.ProductName  
    
            
-------StockReceived----------  
DECLARE @cont int
DECLARE @RowID int=1
DECLARE @tempLocations Table(RowID int IDENTITY(1,1) , LocationID int )

--insert into @tempLocations(LocationID)     
SELECT @LocationID=72
EXEC dbo.pGetNextInventoryIDForMaster @pOrgID,'StockReceived',@pStockReceivedID OUTPUT  

SELECT @cont=COUNT(*) FROM @tempLocations
  
--WHILE(@RowID<=@cont)
BEGIN

 SET @pStockReceivedNo = 'SRD'+ CONVERT(varchar,@pStockReceivedID)                  
 --SELECT @LocationID=LocationID FROM @tempLocations WHERE RowID= @RowID
 
                
  INSERT INTO StockReceived(StockReceivedNo,SupplierID,PurchaseOrderNo, StockReceivedDate,OrgID,Status,CreatedBy,CreatedAt,Comments,OrgAddressID,FromLocationID,ToLocationID,StockReceivedTypeID)                       
      VALUES (@pStockReceivedNo,0,'PO1000',@pCreatedAt,@pOrgID,'Approved',@pCreatedBy,@pCreatedAt,'Stock Received In Bulk Load',@OrgAddressID,@LocationID,@LocationID,5)                              
      SET @StockReceivedID  = SCOPE_IDENTITY()         
                      
                       
  INSERT INTO StockReceivedDetails (StockReceivedId, OrgID, CategoryId, ProductId, BatchNo, ExpiryDate, Manufacture,           
   RECQuantity,ComplimentQTY, RECUnit,           
   SellingPrice,OrgAddressID,StockReceivedDate,Tax,SellingUnit,RcvdLSUQty,LocationID,InvoiceQty,UnitPrice)                       
 SELECT @StockReceivedId, @pOrgID,                
    IIM.CategoryID,                 
    IIM.ProductID, REPLACE(IIM.BatchNo,'''',''), IIM.ExpiryDate, null,           
    IIM.Quantity,IIM.ComplimentQTY, IIM.Unit, IIM.Rate ,@OrgAddressID ,@pCreatedAt,IIM.Tax,IIM.Unit,
    IIM.Quantity,@LocationID,IIM.InvoiceQty,CostPrice          
    FROM @StockInHand IIM                    
          
               
                     
-------StockInHand----------                
                           
  INSERT INTO StockInHand(OrgID,ProductID,TotalStockReceived,CreatedBy,CreatedAt,OrgAddressID,BatchNo,
  ExpiryDate,Tax,SellingPrice,SellingUnit ,LocationID,CostPrice      )                       
        SELECT @pOrgID,S.ProductId,sum(S.Quantity),@pCreatedBy,@pCreatedAt ,
        @OrgAddressID,REPLACE(BatchNo,'''',''),S.ExpiryDate,        
       S.Tax,S.Rate,S.Unit ,@LocationID,CostPrice 
       FROM @StockInHand  S   
       GROUP BY ProductID,BatchNo,S.ExpiryDate,S.Tax,S.Rate,S.Unit,CostPrice
        
  --SELECT @RowID=@RowID+1                             
END                           
  SET @Return = 0                                   
  --RETURN @Return                                
                           
                       
END           
          
          
          
          
          
      
      

        


