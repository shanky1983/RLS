--BEGIN TRAN
 


DECLARE @tb table (RowID int identity(1,1), PatientID bigint,VisitID bigint)
insert @tb
SELECT		PatientID,PatientVisitId FROM PatientVisit 
WHERE		VisitState='Admitted'  and PatientId=7179
GROUP BY	PatientID,PatientVisitId

declare @pVID bigint,@pid bigint
--order by CreatedAt


DECLARE @minPID bigint,
		@maxPID bigint,
		@rowCount int,
		@rowID int=1, 
		@PatientID bigint,
		@VisitID bigint

SELECT @rowCount=COUNT(*) FROM @tb

DECLARE @patDetails As table 
		(RowID int identity(1,1), 
		PatientID bigint,
		VisitID bigint,
		CreatedAt datetime)


WHILE @rowCount>=@rowID

BEGIN
SELECT @PatientID=PatientID,@VisitID=VisitID FROM @tb where RowID=@rowID

INSERT @patDetails 

SELECT	PatientID,PatientVisitId,CreatedAt 
FROM	PatientVisit 
WHERE	PatientID=@PatientID 
		and PatientVisitId>@VisitID and VisitType=0

SELECT @rowID=@rowID+1

END

--SELECT * FROM @tb
--SELECT * FROM @patDetails
---------------------------------
--SELECT * FROM  PatientVisit where PatientId=4890

SELECT @rowCount =count(*) FROM @patDetails
SELECT @rowID=1,@PatientID=0,@VisitID=0

DECLARE @tbFinal table
(
	  RowID int IDENTITY(1,1) ,
    [FinalBillID] [bigint]  NOT NULL,
	[PatientID] [bigint] NOT NULL,
	[VisitID] [bigint] NOT NULL,
	[NetValue] [decimal](18, 2) NULL,
	[AmountReceived] [decimal](18, 2) NULL,
	[Due] [decimal](18, 2) NULL)
	

WHILE @rowCount>=@rowID
BEGIN
SELECT @PatientID=PatientID,@VisitID=VisitID FROM @patDetails where RowID=@rowID

insert @tbFinal(FinalBillID,PatientID,VisitID,NetValue,AmountReceived,Due)
SELECT FinalBillID,PatientID,VisitID,NetValue,AmountReceived,Due FROM FinalBill where VisitID=@VisitID 


SELECT @rowID=@rowID+1

END

SELECT @rowCount =count(*) FROM @patDetails
SELECT @rowID=1,@PatientID=0,@VisitID=0

SELECT @rowCount=COUNT(*) FROM @tb

--SELECT * FROM @tbFinal order by VisitID



WHILE @rowCount>=@rowID

BEGIN
SELECT @PatientID=PatientID,@VisitID=VisitID FROM @tb where RowID=@rowID

DECLARE @paFinalBillID bigint

SELECT @paFinalBillID=FinalBillID FROM FinalBill where VisitID=@VisitID 

select @pVID=@VisitID,@pid=@PatientID


DECLARE @patFilDetails As table (RowID int identity(1,1), 
PatientID bigint,
VisitID bigint,
CreatedAt datetime)

DECLARE @fnRowCount int, @FinalBillID bigint ,
	@NetValue decimal(18, 2) ,
	@AmountReceived decimal(18, 2) ,
	@Due decimal(18, 2),
	@FnRow int =1
	
DECLARE @ChildFinal table
(
	 RowID int IDENTITY(1,1) ,
    [FinalBillID] [bigint]  NOT NULL,
	[PatientID] [bigint] NOT NULL,
	[VisitID] [bigint] NOT NULL,
	[NetValue] [decimal](18, 2) NULL,
	[AmountReceived] [decimal](18, 2) NULL,
	[Due] [decimal](18, 2) NULL)
	
	--select @PatientID
	
	


insert @ChildFinal 
SELECT FinalBillID,[PatientID],[VisitID],[NetValue],[AmountReceived],[Due] FROM @tbFinal where PatientID=@PatientID

SELECT @fnRowCount=COUNT(*) from @ChildFinal 

--select * from @ChildFinal




while @fnRowCount>=@FnRow 

BEGIN

SELECT @FinalBillID =FinalBillID, @NetValue=NetValue,@AmountReceived=AmountReceived,@Due=Due FROM @ChildFinal where PatientID=@PatientID and RowID=@FnRow 

DECLARE @minFillid BIGINT,
		@maxFillid Bigint,
		@ReceiptNO BIGINT,
		@InterimBillNo BIGINT,
		@CreatedAt datetime,
		@CreatedBy BIGINT
		
SELECT @CreatedAt=CreatedAt,@CreatedBy=CreatedBy FROM FinalBill where FinalBillID=@FinalBillID

--select * from @ChildFinal


--select @FinalBillID,@AmountReceived,@Due,@VisitID,@FinalBillID

if(@AmountReceived=@NetValue and isnull(@AmountReceived,0)<>0)
BEGIN
EXEC dbo.pGetNextID 78,'REC',@ReceiptNO OUTPUT   

 SELECT  @minFillid =MIN(BD.BillingDetailsID) , @maxFillid =MAX(BD.BillingDetailsID)                 
   FROM BillingDetails BD  WHERE FinalBillID  = @FinalBillID 
   
   
 INSERT INTO IPIntermediatePayments(VisitID,AmountReceived,Status,PaidDate,StartBillingDetailID,        
   EndBillingDetaillID,CreatedBy,CreatedAt,ServiceCharge,PayerType,ReceiptNO,BaseCurrencyID,PaidCurrencyID,OtherCurrencyAmount)                  
 VALUES (@VisitID,@AmountReceived,'Paid',        
   @CreatedAt,@minFillid,@maxFillid,@CreatedBy,        
   @CreatedAt,0,        
   'Patient',@ReceiptNO, 63,63,@AmountReceived )          
 
  update AmountReceivedDetails set FinalBillID=@paFinalBillID, ReceiptNO=@ReceiptNO where FinalBillID= @FinalBillID
  
  update BillingDetails set FinalBillID=@paFinalBillID,Status='Paid',ReceiptNO=@ReceiptNO where FinalBillID=@FinalBillID
	
  delete FinalBill where FinalBillID=@FinalBillID
  delete DuePaidDetail where PaidBillNo=	@FinalBillID
  
  update StockOutFlow set BillID=@paFinalBillID,ReferenceID=@ReceiptNO,ReferenceType='REC' where BillID=@FinalBillID
  
  
	
  

END	

if(isnull(@AmountReceived,0)=0 and isnull(@NetValue,0)<>0)
BEGIN
EXEC dbo.pGetNextID 78,'IBN',@InterimBillNo OUTPUT  
INSERT INTO PatientDueChart                
  (VisitID,PatientID,FeeType,FeeID,Description,Comments,FromDate,ToDate,Status,unit,CreatedBy,CreatedAt,
   Amount,PackageID,InterimBillNo)                
  SELECT           
  @VisitID,@PatientID,PDC.FeeType,PDC.FeeID,PDC.FeeDescription,'',                
  PDC.CreatedAt,PDC.CreatedAt,'Pending',PDC.Quantity,@CreatedBy,CreatedAt, PDC.Amount,0,@InterimBillNo 
  FROM BillingDetails PDC where FinalBillID=@FinalBillID  
  
  DELETE BillingDetails where FinalBillID= @FinalBillID
  delete FinalBill where FinalBillID=@FinalBillID
  
                  
END	

--delete FinalBill where FinalBillID=9386



SELECT @FnRow=@FnRow+1
END

DELETE From PatientVisit WHERE PatientVisitId in(SELECT  VisitID FROM @ChildFinal) 



 
SELECT @rowID=@rowID+1
END



--COMMIT TRAN

--ROLLBACK TRAN



--SELECT * from PatientVisit WHERE PatientID=3674

--select * from PatientDueChart WHERE VisitID=5005  ORDER BY InterimBillNo

--SELECT * FROM IPIntermediatePayments where VisitID=5005



--SELECT * FROM @ChildFinal order by Patientid

--SELECT * FROM @tbFinal order by Patientid

--SELECT * FROM IPIntermediatePayments where VisitID=8026
--SELECT * FROM PatientDueChart where VisitID=7811 ORDER BY InterimBillNo
--Select * from PatientVisit Where PatientID=585
--Select * from FinalBill Where PatientID=585
--Select * from FinalBill Where VisitID=8026
--select * from BillingDetails where FinalBillID=10839


--COMMIT TRAN

--ROLLBACK TRAN



--SELECT * from PatientVisit WHERE PatientID=3674

--select * from PatientDueChart WHERE VisitID=5005  ORDER BY InterimBillNo

--SELECT * FROM IPIntermediatePayments where VisitID=5005


