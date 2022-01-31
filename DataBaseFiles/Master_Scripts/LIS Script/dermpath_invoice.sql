declare @Finalresult table (Billingdetailsid bigint, Finalbillid bigint,BillNumber varchar(30) ,VisitNumber varchar(256),FromDate datetime,Name varchar(255)      
,FEEDESCRIPTION nvarchar(max),BILLEDAMOUNT decimal(18,2),GROSSAMOUNT decimal(18,2),COLLCHRG decimal(18,2),GROSSTOTAL decimal(18,2),AttributeDetail nvarchar(2000),      
ItemType varchar(50),Remarks varchar(max),Zone varchar(100),      
IsTaxable varchar(50), ServiceCode varchar(50),                                                                                                                                        
 Perphyname varchar(100), Code varchar(100),  Rate decimal(18,2),      
ProductKey varchar(1000) ,SAPCODE varchar(50),Priority int,ClientID bigint,      
 
PhysicianName varchar(50))      
insert into @Finalresult
SELECT BD.BillingDetailsID ,F.FinalBillID, F.BillNumber,PV.VisitNumber,F.CreatedAt as FromDate,P.Name AS Name,                                                                                    
 --ISNULL(CMS.SCode+' - ','')+''+            
 BD.FeeDescription AS 'FEEDESCRIPTION',                                                                                   
 SUM(convert(decimal(18,2),BD.Quantity * BD.Amount)) AS 'BILLEDAMOUNT',                                                                                                                                    
 SUM(convert(decimal(18,2),BD.Quantity * BD.ActualAmount)) AS 'GROSSAMOUNT',                                                                                                                      
 Case when SUM(convert(decimal(18,2),BD.Quantity * BD.ActualAmount))>0 --then                                                                                     
 --Case when SUM(convert(decimal(18,2),BD.Quantity * BD.ActualAmount) - convert(decimal(18,2),BD.Quantity * BD.Amount))>0                                                                                    
 Then SUM(convert(decimal(18,2),BD.Quantity * BD.ActualAmount) - convert(decimal(18,2),BD.Quantity * BD.Amount))                                                                
 --  Else 0.00 End                                                                                
 Else 0.00 End AS 'COLLCHRG',                                                                                  
 AVG(convert(decimal(18,2),BD.ActualAmount)) AS 'GROSSTOTAL',                                                                 
 AD.Address1 as AttributeDetail,AD.City as ItemType,CM.Termsconditions as Remarks,MV.Locality_Code AS 'Zone',                        
 CM.ServiceTaxNo IsTaxable,CM.PanNo as ServiceCode,                                                                                                                                        
 CM.ClientName as Perphyname,CM.ClientCode Code, F.NetValue as Rate ,                                                                                          
 AD.EmailID as ProductKey,                                                                                      
 CM.SapCode as SAPCODE,                                              
 0 Priority,VCM.ClientID ClientID,                                                       
                                  
 ISNULL(PV.PhysicianName,'') AS PhysicianName                                   
 --ISNULL(SC.ServiceCode,'') AS Tcode,                                
 --ISNULL(AVD.ApprovalNo,'') as PolicyNo              
 FROM            
 FinalBill F WITH(NOLOCK)          
 INNER JOIN VisitClientMapping VCM WITH(NOLOCK) ON VCM.FinalBillID=F.FinalBillID AND f.OrgID=VCM.OrgID            
 INNER JOIN ClientMaster CM on VCM.ClientID=CM.ClientID AND CM.OrgID=85            
 INNER JOIN BillingDetails BD WITH(NOLOCK) ON BD.FinalBillID=F.FinalBillID AND BD.OrgID=CM.OrgID               
 INNER JOIN PatientVisit PV WITH(NOLOCK) ON F.VisitID = pv.PatientVisitId and Pv.OrganizationID = VCM.OrgID             
 INNER JOIN Patient P WITH(NOLOCK) ON P.PatientID = PV.PatientID AND P.OrganizationID = PV.OrganizationID             
 LEFT JOIN AddressDetails AD  WITH(NOLOCK) ON CM.ClientID=AD.ReferenceID AND AD.OrgID=CM.OrgID AND AD.IsCommunication='Y' AND AD.AddressTypeID in (1,2)             
 LEFT JOIN Localities MV ON MV.Locality_ID = CM.ZonalID and MV.Type='ZONE' AND MV.OrgID=CM.OrgID             
 LEFT JOIN AmountRefundDetails ARD WITH(NOLOCK) ON ARD.BillingDetailsID=BD.BillingDetailsID AND ARD.OrgID=BD.OrgID AND ARD.BillStatus!='CANCELLED'              
 WHERE   VCM.ClientID in(select ClientID from ClientMaster where OrgID=85 and ClientID not in(4143))           
 AND ARD.AmtRefundID IS NULL          and vcm.OrgID=85
 GROUP BY F.FinalBillID,BD.FeeDescription,BD.Quantity,BD.FeeType,Amount ,                                                                                                                 
 F.NetValue ,AD.Address1,AD.City,                                                                                                    
 CM.Termsconditions ,CM.ServiceTaxNo ,CM.PanNo,AD.AddressTypeID ,                                                                                                                                       
 CM.ClientName ,CM.ClientCode,F.NetValue,AD.EmailID,                         
 F.BillNumber,PV.VisitNumber,F.CreatedAt ,P.Name,CM.ZonalID,CM.SapCode,MV.Locality_Code,            
 VCM.ClientID,PV.PhysicianName,BD.BillingDetailsID            
          
 
 DECLARE @FinalResultRow AS  TABLE (Rowid bigint IDENTITY(1,1),cLIENTId bigint,cLIENTName varchar(255))
INSERT INTO @FinalResultRow
 select ClientID,Perphyname from @Finalresult
 group by ClientID,Perphyname
 
DECLARE @Minrefid bigint;  
DECLARE @Maxrefid bigint;  
SELECT @Minrefid=MIN(r.Rowid) FROM @FinalResultRow r    
SELECT @Maxrefid=MAX(r.Rowid) FROM @FinalResultRow r  


 Declare @Result1 as table(  
 ID INT identity(1,1),  
 FeeId BIGINT ,  
 perPhyName varchar(255),  
 RefPhyId BIGINT,  
 GRossamount decimal(18,2),  
 Amount decimal(18,2),  
 FeeDescription varchar(max),  
 visitnumber varchar(500),
 Name varchar(255),
 Remarks varchar(255),
 discountamount decimal(10,2),
 createdat datetime )  
WHILE @Minrefid <= @Maxrefid  
BEGIN  
   IF EXISTS(SELECT 1 FROM @FinalResult r
   INNER JOIN @FinalResultRow rr ON --r.RefPhyName=rr.RefPhyName AND 
   r.ClientID=rr.cLIENTId
    WHERE r.Perphyname<>'' AND rr.Rowid=@Minrefid)  
   BEGIN  
	
	--INSERT INTO @Result1 (perPhyName)  
	--SELECT r.Perphyname
	--FROM @FinalResult r 
	--INNER JOIN @FinalResultRow rr ON --r.RefPhyName=rr.RefPhyName AND
	-- r.ClientID=rr.cLIENTId
 --   WHERE r.Perphyname<>'' AND  ISNULL(r.FeeDescription,'')<>'' AND rr.Rowid=@Minrefid
 --   GROUP BY r.Perphyname 
	
	INSERT INTO @Result1(NAme ,perPhyName,Amount,visitnumber,FEEDESCRIPTION,GRossamount,discountamount,createdat)  
	SELECT r.Name, r.perPhyName,r.BILLEDAMOUNT,r.VisitNumber,r.FEEDESCRIPTION,r.GRossamount,Case when GRossamount>BILLEDAMOUNT then (r.GRossamount-r.BILLEDAMOUNT) 
	when GROSSAMOUNT<BILLEDAMOUNT then  0 end ,r.FromDate
	FROM @FinalResult r 
	INNER JOIN @FinalResultRow rr ON --r.RefPhyName=rr.RefPhyName AND 
	r.ClientID=rr.cLIENTId
    WHERE r.ClientID<>'' AND r.ClientID=rr.cLIENTId AND rr.Rowid=@Minrefid
	and FromDate between '20160401 00:00:000' and '20160430 23:59:000' 
	
	INSERT INTO @Result1 (FeeDescription,Amount,GRossamount,discountamount) 
	SELECT 'SUB TOTAL'AS FeeDescription,suM ( r.BILLEDAMOUNT),SUM(r.grossamount),  sum(r.GRossamount-r.BILLEDAMOUNT)  
	FROM @FinalResult r
	INNER JOIN @FinalResultRow rr ON --r.RefPhyName=rr.RefPhyName AND 
	r.ClientID=rr.cLIENTId
    WHERE r.Perphyname<>'' AND rr.Rowid=@Minrefid  and FromDate between '20160401 00:00:000' and '20160430 23:59:000' 
	GROUP BY r.Perphyname 	
	--select * from @Result1
   END  
   SET @Minrefid = @Minrefid + 1;  
END  
  update r set r.discountamount=0  from @Result1 r  where  FeeDescription='SUB TOTAL' and discountamount<0
   update r set name='' from @Result1 r  where  FeeDescription='SUB TOTAL'  and name is null 
  --return
     SELECT  
 
     ISNULL(convert(varchar ,R.perPhyName),'')AS clientName,  
     R.Name AS PatientName,
     ISNULL(convert(varchar ,r.VisitNumber),'')AS VisitNumber,  
     ISNULL(convert(varchar ,R.FeeDescription),'')AS FeeDescription,  
    ISNULL(convert(varchar ,discountamount),'0.00') as discountamount,
    ISNULL(convert(varchar ,R.grossamount),'')  AS GRossamount,  
     ISNULL(convert(varchar ,Amount),'')AS Billedamount  ,
     createdat as date
     FROM @Result1 R --where createdat between '01/08/2015' and '31/08/2015' --or createdat=''
   ORDER BY r.ID ASC
     
 --select * from @Finalresult where Perphyname='Aesthetics International'