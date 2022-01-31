
insert into SearchTypeMaster (SearchTypeID,SearchTypeName)
select 36,'Quotation'

DECLARE @RoleID BIGINT
SELECT @RoleID=RoleID FROM Role where RoleName ='Administrator' and OrgID=74
SELECT @RoleID
insert into ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
select 2,@RoleID,458,36,'Y' 


 update ActionRoleMapping set RedirectPageID =477 where ActionID = 2 and SearchTypeID =36 
 
 Update Organization set OrgDisplayName = Name where OrgID not in (select OrgID from Organization where Name ='The Hindu')
 
 
 
 --Sureshkumar mohan
 -- Config Script For Inventory Billing & Refund Task Flow for OP Patient (For Kurinji hospital)
 
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ConfigType,IsAddressBased)
	SELECT MAX(ConfigkeyID) + 1,'IsPharmacisitCashier','Is pharmacy Bill Collect By Cashier?','Y','PRM','N' from ConfigKeyMaster 

	INSERT into InventoryConfig(ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID)
	select 'IsPharmacisitCashier','Y',113,0,MAX(ConfigkeyID) from ConfigKeyMaster 
	
	GO
		insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
		values
		(51,'PharmacyOrderService','~\Inventory\InvOpBilling.aspx?pid={PatientID}&vid={PatientVisitID}&ServiceNo={BillID}&IsPay=Y&isBilling=Y',
		'Collect Payment for Order Services {PatientName}({PatientNumber})',0,'Payment',0)

		insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
		values
		(52,'PendingPayment','~\Inventory\InvOpBilling.aspx?pid={PatientID}&vid={PatientVisitID}&ServiceNo={BillID}&isBilling=Y',
		'Edit Pharmacy Order Services {PatientName}({PatientNumber})',0,'Payment',0)

		insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,51,'')
		insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(51,2283,113)


		insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,52,'')
		insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(52,2282,113)
		

	GO
 
	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values
	(53,'RefundPharmacyStock','~\Inventory\UserStockReturn.aspx?pid={PatientID}&vid={PatientVisitID}&Bid={BillID}&IsPay=Y',
	'Refund Pharmacy Items to {PatientName}({PatientNumber})',0,'Payment',0)

	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values
	(54,'EditRefundPharmacyStock','~\Inventory\UserStockReturn.aspx?pid={PatientID}&vid={PatientVisitID}&Bid={BillID}&isBilling=Y',
	'Edit Pharmacy Refunded Items {PatientName}({PatientNumber})',0,'Payment',0)

	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,53,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(53,2283,113)


	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,54,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(54,2282,113)+

	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values
	(55,'IPPharmacyOrderService','~\Inventory\InvIPBilling.aspx?PID={PatientID}&VID={PatientVisitID}&ServiceNo={BillID}&IsPay=Y&pod=N',
	'IP Collect Payment for Order Services {PatientName}({PatientNumber})',0,'Payment',0)

	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values
	(56,'IPPendingPayment','~\Inventory\InvIPBilling.aspx?PID={PatientID}&VID={PatientVisitID}&ServiceNo={BillID}&isBilling=Y&pod=N',
	'IP Edit Pharmacy Order Services {PatientName}({PatientNumber})',0,'Payment',0)

	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,55,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(55,2283,113)


	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,56,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(56,2282,113)
 
	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values
	(57,'IPCashierDueClearance','~\Inventory\DueClearance.aspx?PID={PatientID}&VID={PatientVisitID}&ServiceNo={BillID}&IsPay=Y&vType=IP',
	'IP Cashier Due Clearance {PatientName}({PatientNumber})',0,'Payment',0)

	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values
	(58,'IPPharmaDueClearance','~\Inventory\DueClearance.aspx?PID={PatientID}&VID={PatientVisitID}&ServiceNo={BillID}&isBilling=Y&vType=IP',
	'IP Edit Pharmacy Due Clearance {PatientName}({PatientNumber})',0,'Payment',0)

	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,57,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(57,2283,113)


	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,58,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(58,2282,113)


	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values (59,'IPCashierCreditDueClearance','~\Inventory\CreditInventoryDueClearance.aspx?PID={PatientID}&VID={PatientVisitID}&vType=IP',
	'IP Cashier Due Clearance {PatientName}({PatientNumber})',0,'Payment',0)
	insert into TaskActions(TaskActionID,ActionName,RedirectURL,DisplayTextTemplate,OrgID,Category,RoleID)
	values (60,'IPCreditPharmaDueClearance','~\Inventory\CreditInventoryDueClearance.aspx?PID={PatientID}&VID={PatientVisitID}&vType=IP',
	'IP Edit Due Clearance {PatientName}({PatientNumber})',0,'Payment',0)
	
	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,59,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(59,2283,113)
	insert into TaskActionMapping(OrgID,VisitPurposeID,OtherID,TaskActionID,Description) values (113,12,0,60,'')
	insert into TaskActionOrgMapping(TaskActionID,RoleID,OrgID) values(60,2282,113)
	
	-- END TASK CONFIG
	
	--CONFIG KEY FOR QUOTATION MASTER--
				
		IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='Required_Quotation_Approval')
		BEGIN
		Declare @pOrgID INT
		SELECT @pOrgID=1
		insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		select MAX(ConfigKeyID)+1,'Required_Quotation_Approval','Is Approval step required for Quotation?','N','CHB','PRM','N' from ConfigKeyMaster

		insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
		select 'Required_Quotation_Approval','Y',@pOrgID,0,MAX(ConfigKeyID),GETDATE() from ConfigKeyMaster 
		END
		
	--END CONFIG KEY FOR QUOTATION MASTER--
	
	
	--CONFIG KEY (RECEVIEDUNITCOSTPRICE)--
	declare @OrgID int
	select @OrgID =78 
	if not exists(select ConfigKeyID from ConfigKeyMaster where ConfigKey='ReceviedUnitCostPrice')
	BEGIN 
	insert into ConfigKeyMaster (ConfigKeyID ,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased)
	select MAX(ConfigKeyID)+1,'ReceviedUnitCostPrice','Select the appropriate unit while receiving the stock for calculating the price',
	'N','DDL',NULL,'PRM','N' from ConfigKeyMaster 

	insert into InventoryConfig (ConfigKeyID, ConfigKey,OrgID,OrgAddressId,ConfigValue)
	select ConfigKeyID,ConfigKey,@OrgID,0,'PoUnit' from ConfigKeyMaster where ConfigKey='ReceviedUnitCostPrice' 	
	END 

	IF NOT EXISTS(SELECT ConfigValue from ConfigValueMaster where ConfigKeyID=(select ConfigKeyID from InventoryConfig where ConfigKey='ReceviedUnitCostPrice'))
	BEGIN
	insert into ConfigValueMaster (ConfigValueID,ConfigKeyID,ConfigValue,IsTableReference)
	select (select MAX(ConfigValueID)+1 from ConfigValueMaster),ConfigKeyID,'PoUnit','N' from InventoryConfig where ConfigKey='ReceviedUnitCostPrice'

	insert into ConfigValueMaster (ConfigValueID,ConfigKeyID,ConfigValue,IsTableReference)
	select (select MAX(ConfigValueID)+1 from ConfigValueMaster),ConfigKeyID,'SUnit','N' from InventoryConfig where ConfigKey='ReceviedUnitCostPrice'

	insert into ConfigValueMaster (ConfigValueID,ConfigKeyID,ConfigValue,IsTableReference)
	select (select MAX(ConfigValueID)+1 from ConfigValueMaster),ConfigKeyID,'RPoUnit','N' from InventoryConfig where ConfigKey='ReceviedUnitCostPrice'

	insert into ConfigValueMaster (ConfigValueID,ConfigKeyID,ConfigValue,IsTableReference)
	select (select MAX(ConfigValueID)+1 from ConfigValueMaster),ConfigKeyID,'RLsuSell','N' from InventoryConfig where ConfigKey='ReceviedUnitCostPrice'
	END
	--END--
	
---------------------RatesFreeText(Amount)-------
insert into ConfigKeyMaster(ConfigKeyID, ConfigKey,DisplayText,IsInternal) SELECT MAX(ConfigkeyID) + 1 ,'RatesFreeText','Need RatesFreeText','Y' from ConfigKeyMaster
insert into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)SELECT MAX(ConfigkeyID),'N',67 from ConfigKeyMaster
-------------------------------------------------

--------------------- Print Barcode for Bill & Sample-------
Declare @ConfigKeyID Bigint
Set @OrgID = 67 -- Metropolis
If (Select MAX(ConfigKeyID) FROM ConfigKeyMaster) IS NULL
BEGIN
	SET @ConfigKeyID = 0
END
ELSE
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster

IF NOT EXISTS(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='PrintBillBarcode')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'PrintBillBarcode','Do you want to print bill with barcode?','N','CHB',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PrintBillBarcode' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='PrintBillBarcode'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PrintSampleBarcode')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'PrintSampleBarcode','Do you want to print barcode for sample?','N','CHB',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PrintSampleBarcode' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='PrintSampleBarcode'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
IF NOT EXISTS(SELECT * FROM SmartCardMaster WHERE OrgID =123)
BEGIN
	insert into SmartCardMaster (OrgID,DisplayFormat) values(123,'<table cellspacing="0" id="tblIDCard" cellpadding="3" runat="server"  style="font-family: Arial; font-weight :bold; font-size:11px; width: 100%;border:1;border-color:Red">                                          <tr>                          <td align="left"  valign="top" style="width:30%">                               Reg. No                            </td>                          <td style="font-weight:bold" valign="top">                              :                          </td>                          <td valign="top" style="width:35%;">                              {0}                          </td>                          <td valign="top">                              &nbsp;                          </td>                          <td valign="top" align ="right" style="width:18%;">                              Date                           </td>                          <td valign="top">                              :                          </td>                          <td valign="top">                            {1}                          </td>                      </tr>                      <tr>                          <td align="left" valign="top">                              Name                          </td>                          <td valign="top">                              :                          </td>                          <td valign="top" colspan="5">                            {2}                          </td>                      </tr>                      <tr>                          <td align="left" style="font-weight:bold" valign="top">                               Age / Sex                            </td>                          <td valign="top">                              :                          </td>                          <td valign="top" colspan="5">                             {3}                          </td>                      </tr>                      <tr style="height:3px">                          <td align="left" valign="top" >                              Address                           </td>                          <td valign="top">                              :                          </td>                          <td valign="top" colspan="5">                            {4}                          </td>                      </tr>                      <tr>                          <td align="left" valign="top">                              Ph. No.                           </td>                          <td valign="top">                              :                          </td>                          <td valign="top" colspan="5">                             {5}                          </td>                      </tr>                  </table>')
END

-------------------------------------------------

-------------------------------------------------

-------------------- Validate General Advice as Mandatory only for COSH Hospital ------//By GURUNATH.S
SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE 'COSH'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='General Advice')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'General Advice','Do you want to set General Advice as Mandatatory?','N','CHB')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='General Advice' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END

-----------------------------------------------------------------------------------------

-------------------- Nutrition Advice only for COSH Hospital ------//By GURUNATH.S
SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE 'COSH'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='Nutrition Advice')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'Nutrition Advice','Do you want Nutrition Advice?','N','CHB')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='Nutrition Advice' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END

-----------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
												-------Customers------
 IF NOT EXISTS(SELECT 1 FROM CustomerType WHERE CustomerTypeName IN('Dealer','Non-Dealer'))
 BEGIN
 INSERT INTO CustomerType (CustomerTypeName) SELECT 'Dealer'
 INSERT INTO CustomerType (CustomerTypeName) SELECT 'Non-Dealer'
 END
   
 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  
												 --QuotationMaster-- 

	IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='Show_SellingPrice_MRP')
	BEGIN
	DECLARE @pOrgID INT
	SELECT @pOrgID=1
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
	SELECT MAX(ConfigKeyID)+1,'Show_SellingPrice_MRP','Do you want to enter Selling Price and MRP manually?','N','CHB','PRM','N' FROM ConfigKeyMaster

	INSERT INTO InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
	SELECT 'Show_SellingPrice_MRP','Y',@pOrgID,0,MAX(ConfigKeyID),GETDATE() from ConfigKeyMaster 
	END 
 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 
												-- StockOutFlowTypes  
	IF NOT EXISTS ( Select * From StockOutFlowTypes Where  StockOutFlowType='Sales Issued')
	BEGIN
	INSERT INTO StockOutFlowTypes(StockOutFlowType) values ('Sales Issued')
	END  
	IF NOT EXISTS ( Select * From SearchTypeMaster Where  SearchTypeName='SalesOrder')
	BEGIN
	INSERT INTO SearchTypeMaster( SearchTypeID ,SearchTypeName )
	SELECT MAX(SearchTypeID)+1,'SalesOrder' from SearchTypeMaster 
	END 

----------------------------------------------------------------------------------------------------
						-- DeltaCheck  
IF NOT EXISTS ( SELECT * FROM  ConfigKeyMaster where ConfigKey='IsDeltaCheck')
	BEGIN
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'IsDeltaCheck','Do you want to Show DetaCheck in InvestigationApprovel','Y' FROM  ConfigKeyMaster
	END 
	
	IF EXISTS (SELECT 1 FROM StockStatus WHERE StockStatusName='Cancelled' AND StockTypeID=7)
	BEGIN
	UPDATE StockStatus SET StockStatusName='Closed' WHERE StockStatusName='Cancelled' AND StockTypeID=7  
	END	
	
	IF NOT EXISTS ( SELECT * FROM  ConfigKeyMaster where ConfigKey='PrintbtnInReportViewer')
	BEGIN
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'PrintbtnInReportViewer','Do you want to Audit SSRS Lab Report Printing','Y' FROM  ConfigKeyMaster
	END 
	
	IF NOT EXISTS ( SELECT * FROM  ConfigKeyMaster where ConfigKey='AuditReprintBarcode')
	BEGIN
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'AuditReprintBarcode','Do you want to Audit the ReprintBarcode','Y' FROM  ConfigKeyMaster
	END 
	
	 Update InvClientType set IsInternal='N' where ClientTypeName='CORPORATE'
	 
	 
	 --************* Prescription Action Role Mapping ******************************
    
       DECLARE @pageURL Varchar(max)='/Corporate/ViewPrescription.aspx'
       DECLARE @pageName varchar(MAX)='View Prescription'
       DECLARE @SearchTypeID int=34
       DECLARE @SearchType Varchar(200)='Corporate'
       DECLARE @ActionID INT 
       DECLARE @RoleID int 
       DECLARE @pageid int=0
       DECLARE @Rolename Varchar(200)='Inventory'
       DECLARE @OrgID int=1
     
BEGIN 
    
   SeLECT @RoleID =RoleID  FROM Role where OrgID = @OrgID and RoleName = @Rolename 

  if NOT Exists( SELECT * FROM Pages WHERE PageURL =@pageURL)
   BEGIN 
    INSERT into Pages (PageID ,PageName ,PageURL )
    SELECT MAX(PageID)+1,@pageName, @pageURL FROM Pages 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    ELSE 
    BEGIN 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    
    if NOT Exists(SELECT * FROM SearchTypeMaster Where SearchTypeName =@SearchType)
	BEGIN
	insert into SearchTypeMaster (SearchTypeID ,SearchTypeName )
	select 34,'Corporate'
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType

	END
	ELSE
	BEGIN
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
	
	
	IF NOT EXISTS(SELECT * FROM ActionMaster Where ActionName ='View Prescription' AND ActionCode IS NOT NULL )
	BEGIN 

	insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode )
	select  max(ActionID)+1 ,'View Prescription','../Corporate/ViewPrescription.aspx?IsPopup=Y&VisitID={PatientVisitID}&PatientID={PatientID}','View_Prescription_Corporate_ViewPrescription' from ActionMaster 
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='View Prescription'
	END
	ELSE
	BEGIN
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='View Prescription'
	Update ActionMaster set QueryString = '../Corporate/ViewPrescription.aspx?IsPopup=Y&VisitID={PatientVisitID}&PatientID={PatientID}',ActionCode ='View_Prescription_Corporate_ViewPrescription' Where ActionID =@ActionID AND ActionCode IS NULL
	END
	
	
	
	IF( (@ActionID >0 )and (@RoleID >0) and (@SearchTypeID>0) and( @pageid>0))
	BEGIN
	insert into ActionRoleMapping (ActionID ,RoleID ,SearchTypeID ,RedirectPageID ,IsMapped )
	SELECT @ActionID,@RoleID ,@SearchTypeID ,@pageid ,'Y'
	
	END
	SELECT  *  FROM Pages WHERE PageID =@pageid 
	SELECT * from SearchTypeMaster where   SearchTypeID = @SearchTypeID 
	SELECT *  FROM ActionMaster Where ActionID =@ActionID
	SELECT * FROM ActionRoleMapping where ActionID =@ActionID and RoleID =@RoleID And SearchTypeID = @SearchTypeID 
	
	END
	
	
	-- ********* Issue Prescription **********************************
	
	   DECLARE @pageURL Varchar(max)='/Corporate/CorpInvBilling.aspx'
       DECLARE @pageName varchar(MAX)='Issue Prescription'
       DECLARE @SearchTypeID int=34
       DECLARE @SearchType Varchar(200)='Corporate'
       DECLARE @ActionID INT 
       DECLARE @RoleID int 
       DECLARE @pageid int=0
       DECLARE @Rolename Varchar(200)='Inventory'
       DECLARE @OrgID int=1
     
 BEGIN 
    
   SeLECT @RoleID =RoleID  FROM Role where OrgID = @OrgID and RoleName = @Rolename 

  if NOT Exists( SELECT * FROM Pages WHERE PageURL =@pageURL)
   BEGIN 
    INSERT into Pages (PageID ,PageName ,PageURL )
    SELECT MAX(PageID)+1,@pageName, @pageURL FROM Pages 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    ELSE 
    BEGIN 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    
    if NOT Exists(SELECT * FROM SearchTypeMaster Where SearchTypeName =@SearchType)
	BEGIN
	insert into SearchTypeMaster (SearchTypeID ,SearchTypeName )
	select 34,'Corporate'
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType

	END
	ELSE
	BEGIN
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
	
	
	IF NOT EXISTS(SELECT * FROM ActionMaster Where ActionName ='Issue Prescription' AND ActionCode IS NOT NULL)
	BEGIN 

	insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode )
	select  max(ActionID)+1 ,'Issue Prescription','../Corporate/CorpInvBilling.aspx?vid={PatientVisitID}&pid={PatientID}&phyID={PhysicianID}&tid={TaskID}','Issue_Prescription_Corporate_CorpInvBilling' from ActionMaster 
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='Issue Prescription'

	END
	ELSE
	BEGIN
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='Issue Prescription'
	Update ActionMaster set QueryString = '../Corporate/CorpInvBilling.aspx?vid={PatientVisitID}&pid={PatientID}&phyID={PhysicianID}&tid={TaskID}',ActionCode ='Issue_Prescription_Corporate_CorpInvBilling' Where ActionID =@ActionID AND ActionCode IS NULL
	END
	
	
	
	IF( (@ActionID >0 )and (@RoleID >0) and (@SearchTypeID>0) and( @pageid>0))
	BEGIN
	insert into ActionRoleMapping (ActionID ,RoleID ,SearchTypeID ,RedirectPageID ,IsMapped )
	SELECT @ActionID,@RoleID ,@SearchTypeID ,@pageid ,'Y'
	
	END
	SELECT  *  FROM Pages WHERE PageID =@pageid 
	SELECT * from SearchTypeMaster where   SearchTypeID = @SearchTypeID 
	SELECT *  FROM ActionMaster Where ActionID =@ActionID
	SELECT * FROM ActionRoleMapping where ActionID =@ActionID and RoleID =@RoleID And SearchTypeID = @SearchTypeID 
	
	END
	
	
		-- ********* Refund Prescription **********************************
		
	
	
	   DECLARE @pageURL Varchar(max)='/Corporate/prescriptionStockReturn.aspx'
       DECLARE @pageName varchar(MAX)='Refund Prescription'
       DECLARE @SearchTypeID int=0
       DECLARE @SearchType Varchar(200)='Corporate'
       DECLARE @ActionID INT =0
       DECLARE @RoleID int =0
       DECLARE @pageid int=0
       DECLARE @Rolename Varchar(200)='Inventory'
       DECLARE @OrgID int=1
     
 BEGIN 
    
   SeLECT @RoleID =RoleID  FROM Role where OrgID = @OrgID and RoleName = @Rolename 

  if NOT Exists( SELECT * FROM Pages WHERE PageURL =@pageURL)
   BEGIN 
    INSERT into Pages (PageID ,PageName ,PageURL )
    SELECT MAX(PageID)+1,@pageName, @pageURL FROM Pages 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    ELSE 
    BEGIN 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    
    if NOT Exists(SELECT * FROM SearchTypeMaster Where SearchTypeName =@SearchType)
	BEGIN
	insert into SearchTypeMaster (SearchTypeID ,SearchTypeName )
	select 34,'Corporate'
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType

	END
	ELSE
	BEGIN
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
	
	
	IF NOT EXISTS(SELECT * FROM ActionMaster Where ActionName ='Refund Prescription' and ActionCode is NOT NULL)
	BEGIN 
	insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode )
	select  max(ActionID)+1 ,'Refund Prescription','../Corporate/prescriptionStockReturn.aspx?vid={PatientVisitID}&pid={PatientID}&phyID={PhysicianID}&pNo={PrescriptionNo}','Refund_Prescription_Corporate_prescriptionStockReturn' from ActionMaster 
	
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionCode ='Refund Prescription'
	END
	ELSE
	BEGIN
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='Refund Prescription'  OR ActionCode IS NULL
	
	Update ActionMaster set QueryString = '../Corporate/prescriptionStockReturn.aspx?vid={PatientVisitID}&pid={PatientID}&phyID={PhysicianID}&pNo={PrescriptionNo}',ActionCode ='Refund_Prescription_Corporate_prescriptionStockReturn' Where ActionID =@ActionID AND  ActionCode IS NULL 
	END
	
	
	
	IF( (@ActionID >0 )and (@RoleID >0) and (@SearchTypeID>0) and( @pageid>0))
	BEGIN
	insert into ActionRoleMapping (ActionID ,RoleID ,SearchTypeID ,RedirectPageID ,IsMapped )
	SELECT @ActionID,@RoleID ,@SearchTypeID ,@pageid ,'Y'
	
	END
	SELECT  *  FROM Pages WHERE PageID =@pageid 
	SELECT * from SearchTypeMaster where   SearchTypeID = @SearchTypeID 
	SELECT *  FROM ActionMaster Where ActionID =@ActionID
	SELECT * FROM ActionRoleMapping where ActionID =@ActionID and RoleID =@RoleID And SearchTypeID = @SearchTypeID 
	
	END
	

---KMH----

SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE 'KMH'
DECLARE @OrgID int =78
DECLARE @ConfigKeyID int

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='Client-TpaRateMapping')
    BEGIN   
        SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
        INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'Client-TpaRateMapping','Do You allow Client-TpaRateMapping','Y','CHB')
    END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='Client-TpaRateMapping' AND COM.OrgID=@OrgID)
    BEGIN
        INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
    END
    
    
    ----Hindu Raise PO 
    
    
                 --************* RaisedPurchaseOrder Action Role Mapping ******************************
  
       DECLARE @pageURL Varchar(max)='/Inventory/RaisedPurchaseOrder.aspx'
       DECLARE @pageName varchar(MAX)='RaisePurchaseOrder'
       DECLARE @SearchTypeID int=34
       DECLARE @SearchType Varchar(200)='Purchaserequest'
       DECLARE @ActionID INT 
       DECLARE @RoleID int 
       DECLARE @pageid int=0
       DECLARE @Rolename Varchar(200)='Inventory'
       DECLARE @OrgID int=1
     
BEGIN 
    
   SeLECT @RoleID =RoleID  FROM Role where OrgID = @OrgID and RoleName = @Rolename 

  if NOT Exists( SELECT * FROM Pages WHERE PageURL =@pageURL)
   BEGIN 
    INSERT into Pages (PageID ,PageName ,PageURL )
    SELECT MAX(PageID)+1,@pageName, @pageURL FROM Pages 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    ELSE 
    BEGIN 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    
    if NOT Exists(SELECT * FROM SearchTypeMaster Where SearchTypeName =@SearchType)
	BEGIN
	insert into SearchTypeMaster (SearchTypeID ,SearchTypeName )
	select 35,'Purchaserequest'
	
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	

	END
	ELSE
	BEGIN
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
	
	
	IF NOT EXISTS(SELECT * FROM ActionMaster Where ActionName ='RaisePO' and ActionCode is NOT null)
	BEGIN 

	insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode )
	select  max(ActionID)+1 ,'RaisePO','../Inventory/RaisedPurchaseOrder.aspx?PORID={PORequestID}','RaisePO_Inventory_RaisedPurchaseOrder' from ActionMaster 
   
    SELECT @ActionID =ActionID  FROM ActionMaster Where ActionCode ='RaisePO_Inventory_RaisedPurchaseOrder' AND ActionName ='RaisePO'

	END
	ELSE
	BEGIN
	SELECT   @ActionID =ActionID   FROM ActionMaster Where ActionName ='RaisePO' OR  ActionCode is null
	UPDATE ActionMaster set  QueryString ='../Inventory/RaisedPurchaseOrder.aspx?PORID={PORequestID}',ActionCode ='RaisePO_Inventory_RaisedPurchaseOrder'  WHERE ActionID = @ActionID AND ActionCode IS NULL 
	END
	
	
	
	IF( (@ActionID >0 )and (@RoleID >0) and (@SearchTypeID>0) and( @pageid>0))
	BEGIN
	insert into ActionRoleMapping (ActionID ,RoleID ,SearchTypeID ,RedirectPageID ,IsMapped )
	SELECT @ActionID,@RoleID ,@SearchTypeID ,@pageid ,'Y'
	
	END
	SELECT  *  FROM Pages WHERE PageID =@pageid 
	SELECT * from SearchTypeMaster where   SearchTypeID = @SearchTypeID 
	SELECT *  FROM ActionMaster Where ActionID =@ActionID
	SELECT * FROM ActionRoleMapping where ActionID =@ActionID and RoleID =@RoleID And SearchTypeID = @SearchTypeID 
	
	END
	
	
	 --************* View & Print  PurchaseOrder Action Role Mapping ******************************
  
       DECLARE @pageURL Varchar(max)='/Inventory/PO_RequestPrint.aspx'
       DECLARE @pageName varchar(MAX)='View & Print Order'
       DECLARE @SearchTypeID int=0
       DECLARE @SearchType Varchar(200)='Purchaserequest'
       DECLARE @ActionID INT =0
       DECLARE @RoleID int =0
       DECLARE @pageid int=0
       DECLARE @Rolename Varchar(200)='Inventory'
       DECLARE @OrgID int=1
     
BEGIN 
    
   SeLECT @RoleID =RoleID  FROM Role where OrgID = @OrgID and RoleName = @Rolename 

  if NOT Exists( SELECT * FROM Pages WHERE PageURL =@pageURL)
   BEGIN 
    INSERT into Pages (PageID ,PageName ,PageURL )
    SELECT MAX(PageID)+1,@pageName, @pageURL FROM Pages 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    ELSE 
    BEGIN 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    
    if NOT Exists(SELECT * FROM SearchTypeMaster Where SearchTypeName =@SearchType)
	BEGIN
	insert into SearchTypeMaster (SearchTypeID ,SearchTypeName )
	select 35,'Purchaserequest'
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
	ELSE
	BEGIN
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
	
	
	IF NOT EXISTS(SELECT * FROM ActionMaster Where ActionName='View & Print Order' AND ActionCode IS NOT NULL )
	BEGIN 

	insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode )
	select  max(ActionID)+1 ,'View & Print Order','../Inventory/PO_RequestPrint.aspx?PORID={PORequestID}','View_&_Print Order_Inventory_PO_RequestPrint' from ActionMaster 
    SELECT @ActionID =ActionID  FROM ActionMaster Where ActionCode ='View_&_Print Order_Inventory_PO_RequestPrint'

	END
	ELSE
	BEGIN
		
	SELECT   @ActionID =ActionID   FROM ActionMaster Where ActionName ='View & Print Order' OR  ActionCode is null
	UPDATE ActionMaster set  QueryString ='../Inventory/PO_RequestPrint.aspx?PORID={PORequestID}',ActionCode ='View_&_Print Order_Inventory_PO_RequestPrint'  WHERE ActionID = @ActionID AND ActionCode IS NULL 
	END
	
	
	
	IF( (@ActionID >0 )and (@RoleID >0) and (@SearchTypeID>0) and( @pageid>0))
	BEGIN
	insert into ActionRoleMapping (ActionID ,RoleID ,SearchTypeID ,RedirectPageID ,IsMapped )
	SELECT @ActionID,@RoleID ,@SearchTypeID ,@pageid ,'Y'
	
	END
	SELECT  *  FROM Pages WHERE PageID =@pageid 
	SELECT * from SearchTypeMaster where   SearchTypeID = @SearchTypeID 
	SELECT *  FROM ActionMaster Where ActionID =@ActionID
	SELECT * FROM ActionRoleMapping where ActionID =@ActionID and RoleID =@RoleID And SearchTypeID = @SearchTypeID 
	
	END 
--IF EXISTS(SELECT 1 FROM InvClientType WHERE ClientTypeCode='HOS') 
	--UPDATE InvClientType SET IsInternal='Y' WHERE ClientTypeCode='HOS' 
--GO
---GURUNATH S ,20-Jun-2012
DECLARE @ActionID int
DECLARE @RoleID Bigint
DECLARE @PageID Bigint
DECLARE @SearchTypeID int
DECLARE @OrgID int
IF NOT EXISTS(SELECT ActionCode FROM ActionMaster  WHERE  ActionCode='View_Edit_Procedure_Notes_PhysioCaseSheet')
	BEGIN	
		SELECT @ActionID= MAX(ActionID)+1 from ActionMaster
		INSERT INTO ActionMaster(ActionID,ActionName,CreatedAt,QueryString,ActionCode)
                              VALUES(@ActionID,'View / Edit Procedure Notes',GETDATE(),'../InPatient/PhysiotherapyNotes.aspx?pid={PatientID}&vid={PatientVisitID}&mode=U&Edit=Y&parentVID={PPatientVisitID}&ProcID={ProcedureID}&Show=Y&PhysioCount={CountValue}','View_Edit_Procedure_Notes_PhysioCaseSheet')																															
    END                                                                                                                          
ELSE
	BEGIN 
		PRINT 'View_Edit_Procedure_Notes_PhysioCaseSheet Already Exists'
	END
	
SET @OrgID=1  --OrgID for Hindu
SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionCode='View_Edit_Procedure_Notes_PhysioCaseSheet'
SELECT @RoleID= RoleID FROM Role WHERE RoleName LIKE 'Physiotherapist' AND OrgID=@OrgID
SELECT @PageID=PageID FROM Pages WHERE PageURL LIKE '/InPatient/PhysiotherapyNotes.aspx'
SET @SearchTypeID=19 --This ID for Today's Visit 
IF NOT EXISTS(SELECT ActionID FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END
	
--Begin Config for KMH and Velammal op bill Format--
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey ='ShowFormattedPrint')
BEGIN
	insert into ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,IsAddressBased)
	select Max(ConfigKeyID)+1,'ShowFormattedPrint','Do you want formatted Print?','N','N' from ConfigKeyMaster
END

Declare @billConfigKeyID as bigint
select @billConfigKeyID = ConfigKeyID from ConfigKeyMaster where ConfigKey ='ShowFormattedPrint'
IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID =@billConfigKeyID AND OrgID =123)
BEGIN
	insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,OrgAddressId) values(@billConfigKeyID,'Y',123,128) -- Velammal Clinic
END
IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID =@billConfigKeyID AND OrgID =78)
BEGIN
	insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,OrgAddressId) values(@billConfigKeyID,'Y',78,80) -- KMH
END


IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey ='Show_Pharmacy_Header')
BEGIN
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
	select MAX(ConfigKeyID)+1, 'Show_Pharmacy_Header','Do You Want Header in the Pharmacy Bill?','N','CHB','PRM','N' from ConfigKeyMaster 
END

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey ='Show_EachPage_Pharmacy_Header')
BEGIN
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
	select MAX(ConfigKeyID)+1, 'Show_EachPage_Pharmacy_Header','Do You Want Header in each page of the Pharmacy Bill?','N','CHB','PRM','N' from ConfigKeyMaster 
END

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey ='Show_EachPage_Pharmacy_BillNo')
BEGIN 
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
	select MAX(ConfigKeyID)+1, 'Show_EachPage_Pharmacy_BillNo','Do You Want Bill number detail in each page of the Pharmacy Bill?','N','CHB','PRM','N'from ConfigKeyMaster 
END

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey ='Show_Pharmacy_FooterDetail')
BEGIN
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
	select MAX(ConfigKeyID)+1, 'Show_Pharmacy_FooterDetail','Do You Want show subtotal,vat,gross total in Pharmacy Bill?','N','CHB','PRM','N' from ConfigKeyMaster 
END



Declare @HeaderConfigKeyID as bigint
select @HeaderConfigKeyID = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_Pharmacy_Header'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@HeaderConfigKeyID AND OrgID =78)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_Pharmacy_Header','N',78,0,@HeaderConfigKeyID)
END

Declare @EHeaderConfigKeyID as bigint
select @EHeaderConfigKeyID = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_EachPage_Pharmacy_Header'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@EHeaderConfigKeyID AND OrgID =78)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_EachPage_Pharmacy_Header','N',78,0,@EHeaderConfigKeyID)
END

Declare @EBillConfigKeyID as bigint
select @EBillConfigKeyID = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_EachPage_Pharmacy_BillNo'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@EBillConfigKeyID AND OrgID =78)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_EachPage_Pharmacy_BillNo','Y',78,0,@EBillConfigKeyID)
END


Declare @FooterConfigKeyID as bigint
select @FooterConfigKeyID = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_Pharmacy_FooterDetail'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@FooterConfigKeyID AND OrgID =78)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_Pharmacy_FooterDetail','Y',78,0,@FooterConfigKeyID)
END


Declare @HeaderConfigKeyID1 as bigint
select @HeaderConfigKeyID1 = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_Pharmacy_Header'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@HeaderConfigKeyID1 AND OrgID =123)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_Pharmacy_Header','Y',123,128,@HeaderConfigKeyID1)
END

Declare @EHeaderConfigKeyID1 as bigint
select @EHeaderConfigKeyID1 = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_EachPage_Pharmacy_Header'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@EHeaderConfigKeyID1 AND OrgID =123)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_EachPage_Pharmacy_Header','N',123,128,@EHeaderConfigKeyID1)
END

Declare @EBillConfigKeyID1 as bigint
select @EBillConfigKeyID1 = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_EachPage_Pharmacy_BillNo'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@EBillConfigKeyID1 AND OrgID =123)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_EachPage_Pharmacy_BillNo','N',123,128,@EBillConfigKeyID1)
END


Declare @FooterConfigKeyID1 as bigint
select @FooterConfigKeyID1 = ConfigKeyID from ConfigKeyMaster where ConfigKey ='Show_Pharmacy_FooterDetail'
IF NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKeyID =@FooterConfigKeyID1 AND OrgID =123)
BEGIN
	insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID) values('Show_Pharmacy_FooterDetail','N',123,128,@FooterConfigKeyID1)
END

---End Config for KMH and Velammal op bill Format ----


---GURUNATH.S 01-JUL-2012---------////
---THIS SCRIPT ONLY FOR HINDU.IF YOU WANT TO MAP THIS ACTION NAME TO ANY OTHER ORG PLEASE CHANGE ROLEID(THIS ROLEID CORREPOND TO THAT ORG) 
DECLARE @ActionID int
DECLARE @RoleID Bigint
DECLARE @PageID Bigint
DECLARE @SearchTypeID int
DECLARE @OrgID int
IF NOT EXISTS(SELECT ActionCode FROM ActionMaster  WHERE  ActionCode='View_Edit_Counseling_Psychiatry')
	BEGIN	
		SELECT @ActionID= MAX(ActionID)+1 from ActionMaster
		INSERT INTO ActionMaster(ActionID,ActionName,CreatedAt,QueryString,ActionCode)
                              VALUES(@ActionID,'View / Edit Counseling',GETDATE(),'../Psychologist/Psychiatry.aspx?pid={PatientID}&vid={PatientVisitID}&sid=51&tid={TaskID}&isDoc=Y&mode=U','View_Edit_Counseling_Psychiatry')																															
    END                                                                                                                          
ELSE
	BEGIN 
		PRINT 'View_Edit_Counseling_Psychiatry Already Exists'
	END
	
SET @OrgID=1  --OrgID for Hindu
SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionCode='View_Edit_Counseling_Psychiatry'
SELECT @RoleID= RoleID FROM Role WHERE RoleName LIKE 'Counselor' AND OrgID=@OrgID
SELECT @PageID=PageID FROM Pages WHERE PageURL LIKE '/Psychologist/Psychiatry.aspx'
SET @SearchTypeID=19 --This ID for Today's Visit 
IF NOT EXISTS(SELECT ActionID FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END
	
	IF NOT EXISTS(SELECT ActionCode FROM ActionMaster  WHERE  ActionCode='View_Print_Counseling_Psychiatry')
	BEGIN	
		SELECT @ActionID= MAX(ActionID)+1 from ActionMaster
		INSERT INTO ActionMaster(ActionID,ActionName,CreatedAt,QueryString,ActionCode)
                              VALUES(@ActionID,'View / Print Counseling',GETDATE(),'../Psychologist/PrintViewCounsellingDetails.aspx?pid={PatientID}&vid={PatientVisitID}&tid={TaskID}&sid=51&pSex={Gender}&Show=Y','View_Print_Counseling_Psychiatry')																															
    END                                                                                                                          
ELSE
	BEGIN 
		PRINT 'View_Print_Counseling_Psychiatry Already Exists'
	END
	
SET @OrgID=1  --OrgID for Hindu
SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionCode='View_Print_Counseling_Psychiatry'
SELECT @RoleID= RoleID FROM Role WHERE RoleName LIKE 'Counselor' AND OrgID=@OrgID
SELECT @PageID=PageID FROM Pages WHERE PageURL LIKE '/Psychologist/Psychiatry.aspx'
SET @SearchTypeID=19 --This ID for Today's Visit 
IF NOT EXISTS(SELECT ActionID FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END
	
--------------------------------------------------------------------//
--THIS SCRIPT FOR RECEPTION ACTION ROLE MAPPING AND FOR HINDU ORG  GURUNATH.S

DECLARE @ActionID int
DECLARE @RoleID Bigint
DECLARE @PageID Bigint
DECLARE @SearchTypeID int
DECLARE @OrgID int
set @OrgID=1
SET @SearchTypeID=19
SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionCode='View_Print_Counseling_Psychiatry'
SELECT @RoleID= RoleID FROM Role WHERE RoleName LIKE 'Receptionist' AND OrgID=@OrgID
SELECT @PageID=PageID FROM Pages WHERE PageURL LIKE '/Psychologist/Psychiatry.aspx'
IF NOT EXISTS(SELECT ActionID FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END

SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionCode='Edit_Capture_Case_Sheet_IPCaseRecord'
SELECT @RoleID= RoleID FROM Role WHERE RoleName LIKE 'Receptionist' AND OrgID=@OrgID
SELECT @PageID=PageID FROM Pages WHERE PageURL LIKE '/Physician/IPCaseRecord.aspx'
IF NOT EXISTS(SELECT ActionID FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END
----////////////////////////////////////////////////////////////////



-- Waist Circumference BMP and Hip Circumference  is change the Cm. in kmh org
	Declare @uomid as bigint
	select @uomid=UOMID from UOM where UOMCode ='cm' and UOMDescription ='Centimeters'
	update OrgUOMVitalsMapping set UOMID =@uomid where VitalsID =25 and OrgID =78
	update OrgUOMVitalsMapping set UOMID =@uomid where VitalsID =26 and OrgID =78 
	
	select @uomid=UOMID from UOM where UOMCode ='units' and UOMDescription ='Units'
	update OrgUOMVitalsMapping set UOMID =6 where VitalsID =27 and OrgID =78
--


-- Config for Schedule For Investigation
IF NOT EXISTS(SELECT * FROM ConfigKeyMaster WHERE ConfigKey ='IsScheduleForInv')
BEGIN
	insert into ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ConfigType,IsAddressBased)
	select Max(ConfigKeyID)+1,'IsScheduleForInv','Do you want Schedule For Investigation?','Y','HOS','N' from ConfigKeyMaster
END

-- CustomerCare Role
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='CustomerCare')
BEGIN 
	DECLARE @RoleID bigint
	DECLARE @PageID bigint
	DECLARE @ReportID bigint
	DECLARE @OrgID bigint = 67
	SELECT @RoleID=MAX(RoleID+1) FROM Role
	SELECT @ReportID=ReportID FROM ReportMaster WHERE ReportDisplayText='InvestigationStatusReport'
	
	INSERT INTO Role (RoleID,RoleName,Description,OrgID) 
	SELECT @RoleID,'CustomerCare','Customer Care',@OrgID

	SELECT @PageID=PageID FROM Pages WHERE PageName='InvestigationReport' AND PageURL='/Investigation/InvestigationReport.aspx'

	INSERT INTO RoleMenu (MenuID,RoleID,IsMapped)
	SELECT (SELECT MenuID FROM MenuMaster WHERE PageID=@PageID AND OrgId=@OrgID) AS MenuID,@RoleID,'Y'

	INSERT INTO PageMapping (RoleId,PageID,SeqNo)
	SELECT @RoleID,@PageID,1
	
	SELECT @PageID=PageID FROM Pages WHERE PageName='Sample Search' AND PageURL='/Lab/PendingSampleCollection.aspx'

	INSERT INTO RoleMenu (MenuID,RoleID,IsMapped)
	SELECT (SELECT MenuID FROM MenuMaster WHERE PageID=@PageID AND OrgId=@OrgID) AS MenuID,@RoleID,'Y'
	
	SELECT @PageID=PageID FROM Pages WHERE PageName='ReportList' AND PageURL='/Reports/ViewReportList.aspx'

	INSERT INTO RoleMenu (MenuID,RoleID,IsMapped)
	SELECT (SELECT MenuID FROM MenuMaster WHERE PageID=@PageID AND OrgId=@OrgID) AS MenuID,@RoleID,'Y'
	
	INSERT INTO ReportOrgMapping (ReportID,RoleID,OrgID,IsMapped)
	SELECT @ReportID,@RoleID,@OrgID,'Y'
END

-- Action Role Mapping for Action Code "Show_Report_InvestigationReport" and Role Name "CustomerCare"
IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Show_Report_InvestigationReport')
BEGIN
	DECLARE @PageID INT
	DECLARE @OrgID INT = 67
	DECLARE @CCRoleID BIGINT
	DECLARE @SearchTypeID BIGINT
	
	SELECT @PageID=PageID FROM Pages WHERE PageName='InvestigationReport' AND PageURL='/Investigation/InvestigationReport.aspx'
	SELECT @SearchTypeID=SearchTypeID FROM SearchTypeMaster WHERE SearchTypeName='Lab'
	SELECT @CCRoleID=RoleID FROM Role WHERE RoleName='CustomerCare' AND OrgID=@OrgID
	
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE ActionID=(SELECT ActionID FROM ActionMaster WHERE ActionCode='Show_Report_InvestigationReport') AND RoleID=@CCRoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	BEGIN
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT ActionID FROM ActionMaster WHERE ActionCode='Show_Report_InvestigationReport'),@CCRoleID,@PageID,@SearchTypeID,'Y'
	END
END

-- Action for Dispatch Investigation Report as EMail
IF NOT EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport')
BEGIN
	INSERT INTO ActionMaster (ActionID,ActionName,ActionCode) 
	SELECT (SELECT MAX(ActionID)+1 FROM ActionMaster) AS ActionID,'Email Report','Email_Report_InvestigationReport'
END

-- Action Role Mapping for Action Code "Email_Report_InvestigationReport" and Role Name "Lab Technician, SrLabTech, CustomerCare"
IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport')
BEGIN
	DECLARE @PageID INT
	DECLARE @OrgID INT = 67
	DECLARE @LTRoleID BIGINT
	DECLARE @SLTRoleID BIGINT
	DECLARE @CCRoleID BIGINT
	DECLARE @SearchTypeID BIGINT
	
	SELECT @LTRoleID=RoleID FROM Role WHERE RoleName='Lab Technician' AND OrgID=@OrgID
	SELECT @SLTRoleID=RoleID FROM Role WHERE RoleName='SrLabTech' AND OrgID=@OrgID
	SELECT @CCRoleID=RoleID FROM Role WHERE RoleName='CustomerCare' AND OrgID=@OrgID
	
	SELECT @PageID=PageID FROM Pages WHERE PageName='InvestigationReport' AND PageURL='/Investigation/InvestigationReport.aspx'
	SELECT @SearchTypeID=SearchTypeID FROM SearchTypeMaster WHERE SearchTypeName='Lab'
	
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE ActionID=(SELECT ActionID FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport') AND RoleID=@LTRoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	BEGIN
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT ActionID FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport'),@LTRoleID,@PageID,@SearchTypeID,'Y'
	END
	
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE ActionID=(SELECT ActionID FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport') AND RoleID=@SLTRoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	BEGIN
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT ActionID FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport'),@SLTRoleID,@PageID,@SearchTypeID,'Y'
	END
	
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE ActionID=(SELECT ActionID FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport') AND RoleID=@CCRoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	BEGIN
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT ActionID FROM ActionMaster WHERE ActionCode='Email_Report_InvestigationReport'),@CCRoleID,@PageID,@SearchTypeID,'Y'
	END
END

-- Action and Action Role Mapping for Sample Search Page
IF NOT EXISTS (SELECT 1 FROM Pages WHERE PageName='Print Barcode' AND PageURL='/Admin/PrintBarcode.aspx')
BEGIN
	INSERT INTO Pages (PageID,PageName,PageURL) 
	SELECT (SELECT MAX(PageID)+1 FROM Pages),'Print Barcode','/Admin/PrintBarcode.aspx'
END
IF NOT EXISTS(SELECT 1 FROM SearchTypeMaster WHERE SearchTypeName='SampleSearch')
BEGIN
	INSERT INTO SearchTypeMaster (SearchTypeID,SearchTypeName) VALUES(42,'SampleSearch')
END
IF NOT EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Collect_Sample_SampleSearch')
BEGIN
	INSERT INTO ActionMaster (ActionID,ActionName,ActionCode,QueryString)
	SELECT (SELECT MAX(ActionID)+1 FROM ActionMaster),'Collect Sample','Collect_Sample_SampleSearch','../Lab/InvestigationSample.aspx?vid={PatientVisitID}&gUID={GuId}&tid={TaskID}&ColAgn={SampleCollectAgain}&sid={SampleID}'
END
IF NOT EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Reprint_Barcode_SampleSearch')
BEGIN
	INSERT INTO ActionMaster (ActionID,ActionName,ActionCode,QueryString)
	SELECT (SELECT MAX(ActionID)+1 FROM ActionMaster),'Reprint Barcode','Reprint_Barcode_SampleSearch','../Admin/PrintBarcode.aspx?visitId={PatientVisitID}&sampleId={SampleID}&guId={GuId}&orgId={OrgID}&LID={LoginID}&ILocationID={LocID}&IsReprint={PrintAgain}&categoryCode={CategoryCode}'
END
IF NOT EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Cancel_Sample_SampleSearch')
BEGIN
	INSERT INTO ActionMaster (ActionID,ActionName,ActionCode)
	SELECT (SELECT MAX(ActionID)+1 FROM ActionMaster),'Cancel Sample','Cancel_Sample_SampleSearch'
END
IF NOT EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Aliquot_SampleSearch')
BEGIN
	INSERT INTO ActionMaster (ActionID,ActionName,ActionCode,QueryString)
	SELECT (SELECT MAX(ActionID)+1 FROM ActionMaster),'Aliquot','Aliquot_SampleSearch','../Admin/PrintBarcode.aspx?visitId={PatientVisitID}&sampleId={SampleID}&guId={GuId}&orgId={OrgID}&categoryCode={CategoryCode}'
END
DECLARE @LTRoleID BIGINT
DECLARE @SLTRoleID BIGINT
DECLARE @SearchTypeID INT
DECLARE @OrgID BIGINT=67
SELECT @LTRoleID=RoleID FROM Role WHERE RoleName='Lab Technician' AND OrgID=@OrgID
SELECT @SLTRoleID=RoleID FROM Role WHERE RoleName='SrLabTech' AND OrgID=@OrgID
SELECT @SearchTypeID=SearchTypeID FROM SearchTypeMaster WHERE SearchTypeName='SampleSearch'
IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Collect_Sample_SampleSearch')
BEGIN
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Collect_Sample_SampleSearch') AS ActionID,@LTRoleID,(SELECT PageID FROM Pages WHERE PageName='Collect Sample' AND PageURL='/Lab/InvestigationSample.aspx') AS PageID,@SearchTypeID,'Y'
	
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Collect_Sample_SampleSearch') AS ActionID,@SLTRoleID,(SELECT PageID FROM Pages WHERE PageName='Collect Sample' AND PageURL='/Lab/InvestigationSample.aspx') AS PageID,@SearchTypeID,'Y'

END
IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Reprint_Barcode_SampleSearch')
BEGIN
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Reprint_Barcode_SampleSearch') AS ActionID,@LTRoleID,(SELECT PageID FROM Pages WHERE PageName='Print Barcode' AND PageURL='/Admin/PrintBarcode.aspx') AS PageID,@SearchTypeID,'Y'
	
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Reprint_Barcode_SampleSearch') AS ActionID,@SLTRoleID,(SELECT PageID FROM Pages WHERE PageName='Print Barcode' AND PageURL='/Admin/PrintBarcode.aspx') AS PageID,@SearchTypeID,'Y'
END
IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Cancel_Sample_SampleSearch')
BEGIN
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Cancel_Sample_SampleSearch') AS ActionID,@LTRoleID,(SELECT PageID FROM Pages WHERE PageName='Sample Search' AND PageURL='/Lab/PendingSampleCollection.aspx') AS PageID,@SearchTypeID,'Y'
	
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Cancel_Sample_SampleSearch') AS ActionID,@SLTRoleID,(SELECT PageID FROM Pages WHERE PageName='Sample Search' AND PageURL='/Lab/PendingSampleCollection.aspx') AS PageID,@SearchTypeID,'Y'
END
IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Aliquot_SampleSearch')
BEGIN
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Aliquot_SampleSearch') AS ActionID,@LTRoleID,(SELECT PageID FROM Pages WHERE PageName='Print Barcode' AND PageURL='/Admin/PrintBarcode.aspx') AS PageID,@SearchTypeID,'Y'
	
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Aliquot_SampleSearch') AS ActionID,@SLTRoleID,(SELECT PageID FROM Pages WHERE PageName='Print Barcode' AND PageURL='/Admin/PrintBarcode.aspx') AS PageID,@SearchTypeID,'Y'
END


IF NOT EXISTS(SELECT 1 FROM SearchTypeMaster WHERE SearchTypeName like 'SampleSearch')
BEGIN
	INSERT INTO SearchTypeMaster (SearchTypeID,SearchTypeName)values(42,'SampleSearch')
END
 
BEGIN

	DECLARE @PageID INT
	DECLARE @OrgID INT = 67
	DECLARE @LTRoleID BIGINT
	DECLARE @SLTRoleID BIGINT
	DECLARE @CCRoleID BIGINT
	DECLARE @SearchTypeID BIGINT

	SELECT @LTRoleID=RoleID FROM Role WHERE RoleName='Lab Technician' AND OrgID=@OrgID
	SELECT @SLTRoleID=RoleID FROM Role WHERE RoleName='SrLabTech' AND OrgID=@OrgID
	SELECT @SearchTypeID=SearchTypeID FROM SearchTypeMaster WHERE SearchTypeName='SampleSearch'

	IF NOT EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Reject_Sample_SampleSearch')
	BEGIN
		INSERT INTO ActionMaster (ActionID,ActionName,ActionCode)
		SELECT (SELECT MAX(ActionID)+1 FROM ActionMaster),'Reject Sample','Reject_Sample_SampleSearch'
	END

	IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Reject_Sample_SampleSearch')
	BEGIN
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Reject_Sample_SampleSearch') AS ActionID,@LTRoleID,(SELECT PageID FROM Pages WHERE PageName='Sample Search' AND PageURL='/Lab/PendingSampleCollection.aspx') AS PageID,@SearchTypeID,'Y'
		
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT MAX(ActionID) FROM ActionMaster WHERE ActionCode='Reject_Sample_SampleSearch') AS ActionID,@SLTRoleID,(SELECT PageID FROM Pages WHERE PageName='Sample Search' AND PageURL='/Lab/PendingSampleCollection.aspx') AS PageID,@SearchTypeID,'Y'
	END

END


IF NOT EXISTS(SELECT 1 from Pages where PageURL ='/Admin/TrustedOrgAccessMapping.aspx')
BEGIN
DECLARE @PageID bigint 
DECLARE @Orgid int
DECLARE @RoleID bigint
DECLARE @ReportID bigint
SET @Orgid=67			--Give Orgid which do u want and run the Script
SELECT  @RoleID=RoleID from Role where OrgID=@Orgid and RoleName='Administrator'
INSERT INTO Pages(PageID,PageName,PageURL,CreatedAt)
SELECT MAX(PageID)+1,'Trusted Org Access Mapping','/Admin/TrustedOrgAccessMapping.aspx',GETDATE() FROM Pages 
SELECT @PageID=MAX(PageID) from Pages 
 
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)
SELECT MAX(MenuID)+1,'Trusted Org Access Mapping',0,@Orgid,@PageID FROM MenuMaster
 
INSERT INTO RoleMenu(MenuID,RoleID,IsMapped)
SELECT MAX(MenuID),@RoleID,'Y' from MenuMaster 
END


---------------------------//vijayarajaBy 
DECLARE @pOrgID int
DECLARE @ConfigKeyID BIGINT
SELECT @pOrgID = OrgID FROM Organization WHERE Name LIKE 'METROPOLIS'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='NeedIPManageRates')
BEGIN	
	SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'NeedIPManageRates','Do you want Need IP Mange Rates','N','N')
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='NeedIPMangeRates' AND COM.OrgID=@pOrgID)
BEGIN
	INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@pOrgID,GETDATE())
END


------ Update Script for Sample Search - Actions for Phlebotomist Role - METROPOLIS only --------
BEGIN
	DECLARE @OrgID INT
	DECLARE @LTRoleID BIGINT
	DECLARE @PhRoleID BIGINT
	DECLARE @SearchTypeID INT
	DECLARE @TaskActionID INT

	SELECT @OrgID=OrgID FROM Organization WHERE Name LIKE 'METROPOLIS'
	SELECT @LTRoleID=RoleID FROM Role WHERE RoleName LIKE 'Lab Technician' AND OrgID=@OrgID
	SELECT @PhRoleID=RoleID FROM Role WHERE RoleName LIKE 'Phlebotomist' AND OrgID=@OrgID
	SELECT @SearchTypeID=SearchTypeID FROM SearchTypeMaster WHERE SearchTypeName='SampleSearch'
	SELECT @TaskActionID=TASKACTIONID FROM TaskActions WHERE ActionName='CollectSample'

	IF EXISTS(SELECT 1 FROM TaskActionOrgMapping WHERE OrgID=@OrgID AND TaskActionID=@TaskActionID)
	BEGIN
		UPDATE TaskActionOrgMapping SET RoleID=@PhRoleID WHERE OrgID=@OrgID AND TaskActionID=@TaskActionID
	END

	IF EXISTS(SELECT 1 FROM ActionRoleMapping WHERE RoleID=@LTRoleID AND SearchTypeID=@SearchTypeID 
				AND ActionID IN (SELECT ActionID FROM ActionMaster WHERE ActionName IN ('Collect Sample','Reprint Barcode','Cancel Sample','Aliquot')))
	BEGIN
		UPDATE ActionRoleMapping SET RoleID=@PhRoleID WHERE RoleID=@LTRoleID AND SearchTypeID=@SearchTypeID 
			AND ActionID IN (SELECT ActionID FROM ActionMaster WHERE ActionName IN ('Collect Sample','Reprint Barcode','Cancel Sample','Aliquot'))
	END

	IF EXISTS(SELECT 1 FROM ActionMaster WHERE ActionCode='Collect_Sample_SampleSearch' 
				AND QueryString='../Lab/InvestigationSample.aspx?vid={PatientVisitID}&gUID={GuId}&tid={TaskID}&ColAgn={SampleCollectAgain}&sid={SampleID}')
	BEGIN
		UPDATE ActionMaster
		SET QueryString='../Lab/InvestigationSample.aspx?vid={PatientVisitID}&gUID={GuId}&tid={TaskID}&ColAgn={SampleCollectAgain}&sid={SampleID}&TaskActionID={TaskActionID}'
		WHERE ActionCode='Collect_Sample_SampleSearch'
	END
END
------ Update Script for Sample Search - Actions for Phlebotomist Role - METROPOLIS only --------
DECLARE @rOrgID int
SELECT @rOrgID = OrgID FROM Organization WHERE Name LIKE 'METROPOLIS'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='ShowRateType')
BEGIN
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType) 
	select MAX(configkeyId)+1,'ShowRateType','Do you want to show the Rate Type in Lab Quick Bill','Y','RDO' from ConfigKeyMaster 
END

DECLARE @RConfigKeyID as bigint
select @RConfigKeyID=Configkeyid from ConfigKeyMaster where ConfigKey like 'ShowRateType'
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='ShowRateType' AND COM.OrgID=@rOrgID)
BEGIN
	insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID) 
	select @RConfigKeyID,'Y',@rOrgID 
END


DECLARE @MaOrgID int
SELECT @MaOrgID = OrgID FROM Organization WHERE Name LIKE 'METROPOLIS'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='MinimumDuepayment')
BEGIN
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType) 
	select MAX(configkeyId)+1,'MinimumDuepayment','Do you want to add Minimun Due Payment?','N','RDO' from ConfigKeyMaster 
END

DECLARE @MaConfigKeyID as bigint
select @MaConfigKeyID=Configkeyid from ConfigKeyMaster where ConfigKey like 'MinimumDuepayment'
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='MinimumDuepayment' AND COM.OrgID=@MaOrgID)
BEGIN
	insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID) 
	select @MaConfigKeyID,'Y',@MaOrgID 
END


DECLARE @MpOrgID int
SELECT @MpOrgID = OrgID FROM Organization WHERE Name LIKE 'METROPOLIS'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='MinimumDuePercent')
BEGIN
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType) 
	select MAX(configkeyId)+1,'MinimumDuePercent','Enter the Minimum Due Percent','N','TEXT' from ConfigKeyMaster 
END

DECLARE @MpConfigKeyID as bigint
select @MpConfigKeyID=Configkeyid from ConfigKeyMaster where ConfigKey like 'MinimumDuePercent'
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='MinimumDuePercent' AND COM.OrgID=@MpOrgID)
BEGIN
	insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID) 
	select @MpConfigKeyID,50,@MpOrgID 
END

Go


CREATE
TABLE #TempOrgID 
(
OrgID 
int 
)
INSERT INTO #TempOrgID 
SELECT OrgID from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
DECLARE @MenuID bigint 
DECLARE @PageID bigint 
DECLARE @invpageid bigint
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 
SET @MenuID=(SELECT MAX(MenuID)+1 FROM MenuMaster) 
set @PageID=(SELECT MAX(pageid)+1 FROM Pages) 
set @invpageid=(SELECT MAX(pagemapid)+1 from InventoryPageMap)

INSERT INTO Pages (PageID,PageName,PageURL)VALUES(@PageID,'Investigation Product Mapping','/Admin/InvestigationProductMapping.aspx') 
WHILE @MinValue <= @MaxValue 
BEGIN
IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue) 
BEGIN
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID,'Investigation Product Mapping',2,@MinValue,@PageID 
INSERT INTO RoleMenu (MenuID,RoleID,IsMapped) 
SELECT @MenuID,RoleID,'Y' FROM Role WHERE OrgID=@MinValue AND RoleName='Administrator'  
 
END
SET @MinValue = @MinValue + 1 
SET @MenuID = @MenuID + 1 
END
drop table #TempOrgID 


Go
CREATE
TABLE #TempOrgID 
(
OrgID 
int 
)
INSERT INTO #TempOrgID 
SELECT OrgID from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
DECLARE @MenuID bigint 
DECLARE @PageID bigint 
DECLARE @invpageid bigint
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 
SET @MenuID=(SELECT MAX(MenuID)+1 FROM MenuMaster) 
set @PageID=(SELECT MAX(pageid)+1 FROM Pages) 
set @invpageid=(SELECT MAX(pagemapid)+1 from InventoryPageMap)

INSERT INTO Pages (PageID,PageName,PageURL)VALUES(@PageID,'InvestigationStockUsageReport','/Reports/InvestigationStockUsage.aspx') 
WHILE @MinValue <= @MaxValue 
BEGIN
IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue) 
BEGIN
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID,'Investigation StockUsage Report',0,@MinValue,@PageID 
INSERT INTO RoleMenu (MenuID,RoleID,IsMapped) 
SELECT @MenuID,RoleID,'Y' FROM Role WHERE OrgID=@MinValue AND RoleName='Administrator'  
 
END
SET @MinValue = @MinValue + 1 
SET @MenuID = @MenuID + 1 
END
drop table #TempOrgID 

go



DECLARE @orgid int =67
--select * from MasterCategories
if Not Exists (select * from MasterCategories Where OrgID = @orgid and CategoryName='KitBatchNo')
BEGIN
INSERT into MasterCategories (CategoryName,OrgID ,CategoryCode)
SELECT 'KitBatchNo',@orgid,'KitBatchNo'

END

go
if Not Exists (select * from MasterPatterns Where PatternName ='BatchNo')
BEGIN

insert into MasterPatterns (PatternID ,PatternName ) 
select CategoryId,'ExpDate' from MasterCategories Where OrgID = @orgid and CategoryName='KitBatchNo'
Union
select CategoryId,'BatchNo' from MasterCategories Where OrgID = @orgid and CategoryName='KitBatchNo'
Union
select CategoryId,'AssemblyDate' from MasterCategories Where OrgID = @orgid and CategoryName='KitBatchNo'

END


Go
if Not Exists (select * from BarcodeCategories Where Name ='KitBatchNo')
BEGIN
INSERT into BarcodeCategories (Name ,Code )
SELECT 'KitBatchNo','KitBatchNo'

END
Go
if Not Exists (select * from BarcodePlaceHolders Where Code ='BatchNo')
BEGIN

insert into BarcodePlaceHolders (Name  ,Code  ) 
select 'BatchNo','BatchNo' 

END
go
if Not Exists (select * from BarcodePlaceHolders Where Code ='ExpDate')
BEGIN
insert into BarcodePlaceHolders (Name  ,Code  ) 
select 'Expiry Date','ExpDate'
END
go
if Not Exists (select * from BarcodePlaceHolders Where Code ='AssemblyDate')
BEGIN
insert into BarcodePlaceHolders (Name  ,Code  ) 
select 'Assembly Date','AssemblyDate'
END

go
if Not Exists (select * from BarcodePlaceHolders Where Code ='CreatedDate')
BEGIN
insert into BarcodePlaceHolders (Name  ,Code  ) 
select 'Created Date','CreatedDate'
END

go
if Not Exists (select * from BarcodePlaceHolders Where Name ='ProductID')
BEGIN
INSERT into BarcodePlaceHolders (Name ,Code )
SELECT 'ProductID','ProductID'

END

go

--- for Send SMS menu option for Customer Care role ---
BEGIN

DECLARE @OrgId INT

DECLARE @NewPageId BIGINT

SET @OrgId=67

SELECT @NewPageId=MAX(PageID)+1 FROM Pages

INSERT INTO Pages(PageID,PageName,PageURL)
SELECT @NewPageId,'Send SMS','/Admin/SendSMS.aspx'

DECLARE @NewMenuId INT

SELECT @NewMenuId=MAX(MenuID)+1 FROM MenuMaster

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID)
SELECT @NewMenuId,'Send SMS',0,@OrgId,@NewPageId

DECLARE @RoleId BIGINT

SELECT @RoleId=RoleID FROM Role WHERE RoleName LIKE 'CustomerCare'

INSERT INTO RoleMenu(MenuID,RoleID,IsMapped)
SELECT @NewMenuId,@RoleId,'Y'

END
--- for Send SMS menu option for Customer Care role ---

GO

-- To show Delta Check for Doctor role also - Config Script

BEGIN

	DECLARE @OrgID INT

	SELECT @OrgID=OrgID FROM Organization WHERE Name='Worli' -- 'Thane' -69

	IF EXISTS(SELECT 1 FROM ConfigKeyMaster CK INNER JOIN ConfigOrgMaster CO ON CK.ConfigKeyID=CO.ConfigKeyID
					WHERE CK.ConfigKey='IsDeltaCheck' AND CO.OrgID IN (@OrgID))
	BEGIN
		UPDATE CO SET CO.ConfigValue='SrLabTech,Doctor'
		FROM ConfigKeyMaster CK INNER JOIN ConfigOrgMaster CO ON CK.ConfigKeyID=CO.ConfigKeyID
					WHERE CK.ConfigKey='IsDeltaCheck' AND CO.OrgID IN (@OrgID)
	END

END



-- To show Delta Check for Doctor role also - Config Script

GO
-- Show Summary Report Begin --
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowSummaryReport')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT MAX(ConfigKeyID)+1,'ShowSummaryReport','Do you want summary report?','N','CHB','String' FROM ConfigKeyMaster
END

DECLARE @pOrgID INT
DECLARE @pConfigKeyID BIGINT
SET @pOrgID = 67 --Metropolis
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowSummaryReport')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='ShowSummaryReport' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='ShowSummaryReport'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID,'Y',@pOrgID)
	END
END
-- Show Summary Report End --


Go
if Not Exists (select * from BarcodeCategories Where Name ='IntendNo')
BEGIN
INSERT into BarcodeCategories (Name ,Code )
SELECT 'IndentNo','IndentNo'

END

go
if Not Exists (select * from BarcodePlaceHolders Where Code ='DespatchDate')
BEGIN
insert into BarcodePlaceHolders (Name  ,Code  ) 
select 'Despatch Date','DespatchDate'
END

go
if Not Exists (select * from BarcodePlaceHolders Where Code ='CreatedDate')
BEGIN
insert into BarcodePlaceHolders (Name  ,Code  ) 
select 'Created Date','CreatedDate'
END


Go
if Not Exists (select * from BarcodePlaceHolders Where Name ='IssuedIndentNo')
BEGIN
INSERT into BarcodePlaceHolders (Name ,Code )
SELECT 'Issued IndentNo','IssuedIndentNo'

END

if Not Exists (select * from BarcodePlaceHolders Where Name ='IntendNo')
BEGIN
INSERT into BarcodePlaceHolders (Name ,Code )
SELECT 'IndentNo','IndentNo'

END

go
if Not Exists (select * from BarcodePlaceHolders Where Name ='LocationName')
BEGIN
INSERT into BarcodePlaceHolders (Name ,Code )
SELECT 'LocationName','LocationName'

END


go
DECLARE @ConfigkeyID bigint

DECLARE @pOrgID bigint =69

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode')
		BEGIN
		
		
		insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		select MAX(ConfigKeyID)+1,'Required_Indent_Packing_Slip_Barcode','Is Required_Indent_Packing_Slip_Barcode?','N','CHB','PRM','N' from ConfigKeyMaster
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode' AND OrgID =@pOrgID)
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Required_Indent_Packing_Slip_Barcode','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
       
       
        END
        ELSE
        BEGIN
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode' AND OrgID =@pOrgID AND ConfigKeyID =@ConfigkeyID )
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Required_Indent_Packing_Slip_Barcode','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
		END
		
		
DECLARE @ConfigkeyID bigint

DECLARE @pOrgID bigint =67

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode')
		BEGIN
		
		
		insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		select MAX(ConfigKeyID)+1,'Required_Indent_Packing_Slip_Barcode','Is Required_Indent_Packing_Slip_Barcode?','N','CHB','PRM','N' from ConfigKeyMaster
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode' AND OrgID =@pOrgID)
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Required_Indent_Packing_Slip_Barcode','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
       
       
        END
        ELSE
        BEGIN
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Required_Indent_Packing_Slip_Barcode' AND OrgID =@pOrgID AND ConfigKeyID =@ConfigkeyID )
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Required_Indent_Packing_Slip_Barcode','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
		END
	
	IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='PDFReportViewer')
	BEGIN
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		SELECT MAX(ConfigkeyID) + 1,'PDFReportViewer','Does org needs merged PDFReport viewer?','N','CHB','HOS','N' from ConfigKeyMaster  
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
		SELECT ConfigKeyID,'Y',67,GETDATE() FROM ConfigKeyMaster where ConfigKey ='PDFReportViewer'
	END
	
	
	
	
	
	IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='TrackEMIForCards')
	BEGIN
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		SELECT MAX(ConfigkeyID) + 1,'TrackEMIForCards','Do you want to track EMI for Cards?','N','CHB','HOS','N' from ConfigKeyMaster  
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
		SELECT ConfigKeyID,'Y',78,GETDATE() FROM ConfigKeyMaster where ConfigKey ='TrackEMIForCards'
	END
	
-- Show VisitNumber as Barcode in Bill Begin --
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowVisitNoAsBarcodeInBill')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT MAX(ConfigKeyID)+1,'ShowVisitNoAsBarcodeInBill','Do you want to show visit number as barcode in bill?','N','CHB','String' FROM ConfigKeyMaster
END
GO

DECLARE @pOrgID INT
DECLARE @pConfigKeyID BIGINT
SET @pOrgID = 67 --Metropolis
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowVisitNoAsBarcodeInBill')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='ShowVisitNoAsBarcodeInBill' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='ShowVisitNoAsBarcodeInBill'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID,'Y',@pOrgID)
	END
END
GO
-- Show VisitNumber as Barcode in Bill End --	

-- Config script which won't allow the Lab Tech to edit the Medical Remarks

BEGIN
	DECLARE @ConfigKeyID BIGINT
	DECLARE @OrgID INT

	SET @OrgID=67

	IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='CanLabTechEditMedRem')
	BEGIN
	
		SELECT @ConfigKeyID=MAX(Configkeyid)+1 FROM ConfigKeyMaster

		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'CanLabTechEditMedRem','Do not allow Lab Tech to edit Medical Remarks.','N','CHB')
	END

	IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='CanLabTechEditMedRem')
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID 
						WHERE ConfigKey='CanLabTechEditMedRem' AND OrgID=@OrgID)
		BEGIN

			DECLARE @pConfigKeyID BIGINT

			SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='CanLabTechEditMedRem'

			INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
			VALUES(@pConfigKeyID,'N',@OrgID)
		END
	END

END




---Pharmacy

Go

DECLARE @pOrgID int=131
DECLARE @ConfigkeyID int=0
	IF NOT EXISTS(SELECT * FROM ConfigKeyMaster WHERE ConfigKey='Show_Pharmacy_BillNo_EachReceipt_And_InterimBill')
		BEGIN
		
		
		insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		select MAX(ConfigKeyID)+1,'Show_Pharmacy_BillNo_EachReceipt_And_InterimBill','Do You Want Show Pharmacy BillNo Each Receipt And InterimBill?','N','CHB','PRM','N' from ConfigKeyMaster
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Show_Pharmacy_BillNo_EachReceipt_And_InterimBill'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Show_Pharmacy_BillNo_EachReceipt_And_InterimBill' AND OrgID =@pOrgID)
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Show_Pharmacy_BillNo_EachReceipt_And_InterimBill','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
       
       
        END
        ELSE
        BEGIN
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Show_Pharmacy_BillNo_EachReceipt_And_InterimBill'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Show_Pharmacy_BillNo_EachReceipt_And_InterimBill' AND OrgID =@pOrgID AND ConfigKeyID =@ConfigkeyID )
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Show_Pharmacy_BillNo_EachReceipt_And_InterimBill','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
		END
		
		
		
	Go	
DECLARE @pOrgID int=78
DECLARE @ConfigkeyID int=0
	IF NOT EXISTS(SELECT * FROM ConfigKeyMaster WHERE ConfigKey='Expiry_Product_Do_Not_Allowed_For_Dispensing')
		BEGIN
		
		
		insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		select MAX(ConfigKeyID)+1,'Expiry_Product_Do_Not_Allowed_For_Dispensing','Define the expiry Products  do not Allowed for Dispensing?','N','CHB','PRM','N' from ConfigKeyMaster
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Expiry_Product_Do_Not_Allowed_For_Dispensing'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Expiry_Product_Do_Not_Allowed_For_Dispensing' AND OrgID =@pOrgID)
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Expiry_Product_Do_Not_Allowed_For_Dispensing','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
       
       
        END
        ELSE
        BEGIN
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Expiry_Product_Do_Not_Allowed_For_Dispensing'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Expiry_Product_Do_Not_Allowed_For_Dispensing' AND OrgID =@pOrgID AND ConfigKeyID =@ConfigkeyID )
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Expiry_Product_Do_Not_Allowed_For_Dispensing','Y',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
		END
		
		
	GO
		
DECLARE @pOrgID int=83
DECLARE @ConfigkeyID int=0
	IF NOT EXISTS(SELECT * FROM ConfigKeyMaster WHERE ConfigKey='Print_LineItem_Limit_In_PrintBill')
		BEGIN
		
		
		insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType,IsAddressBased)
		select MAX(ConfigKeyID)+1,'Print_LineItem_Limit_In_PrintBill','Do You Want Set Pharmacy Details LineItem Limit?','N','TEXT','PRM','N' from ConfigKeyMaster
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Print_LineItem_Limit_In_PrintBill'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Print_LineItem_Limit_In_PrintBill' AND OrgID =@pOrgID)
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Print_LineItem_Limit_In_PrintBill','9',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
       
       
        END
        ELSE
        BEGIN
        SET @ConfigkeyID =0
        SELECT top 1 @ConfigkeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Print_LineItem_Limit_In_PrintBill'
			IF NOT EXISTS(SELECT ConfigKey FROM InventoryConfig WHERE ConfigKey='Print_LineItem_Limit_In_PrintBill' AND OrgID =@pOrgID AND ConfigKeyID =@ConfigkeyID )
			BEGIN
			insert into InventoryConfig (ConfigKey,ConfigValue,OrgID,OrgAddressId,ConfigKeyID,CreatedAt)
			select 'Print_LineItem_Limit_In_PrintBill','9',@pOrgID,0,@ConfigkeyID,GETDATE()
			END
		END



------ Bill Time print bills

declare @configkeyid int 
SELECT @configkeyid = MAX(configkeyid)+1 from configkeymaster 
insert into ConfigKeyMaster
select @configkeyid,'ShowDate_WithTime_BillPrint_Ascx','Show Date with Time in Bill print?','N','CHB',NULL,'HOS','N'    

insert into InventoryConfig
select 'ShowDate_WithTime_BillPrint_Ascx','Y',67,@configkeyid,null,NULL,NULL,NULL,NULL


---
update actionTemplate set template ='Dear {Name}, Your test request has been registered successfully with {OrgName} at {MsgedDate},
Please have your report collected at {BlockFrom}. Thank you.' where TemplateID =1

-- Store Report Snapshot Begin --
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='StoreReportSnapshot')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT MAX(ConfigKeyID)+1,'StoreReportSnapshot','Do you want to store report snapshot?','N','CHB','String' FROM ConfigKeyMaster
END
GO

DECLARE @pOrgID INT
DECLARE @pConfigKeyID BIGINT
SET @pOrgID = 67 --Metropolis
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='StoreReportSnapshot')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='StoreReportSnapshot' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='StoreReportSnapshot'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID,'Y',@pOrgID)
	END
END
GO
-- Store Report Snapshot End --

--Action string for Print Consent form -----
   
    
      DECLARE @pageURL Varchar(max)='/Reception/ConsentFormPrint.aspx'
       DECLARE @pageName varchar(MAX)='Print Consent Form'
       DECLARE @SearchTypeID int=0
       DECLARE @SearchType Varchar(200)='OP'
       DECLARE @ActionID INT 
       DECLARE @RoleID int 
       DECLARE @pageid int=0
       DECLARE @Rolename Varchar(200)='Receptionist'
       DECLARE @OrgID int=113
     
BEGIN 
    
   SeLECT @RoleID =RoleID  FROM Role where OrgID = @OrgID and RoleName = @Rolename 

  if NOT Exists( SELECT * FROM Pages WHERE PageURL =@pageURL)
   BEGIN 
    INSERT into Pages (PageID ,PageName ,PageURL )
    SELECT MAX(PageID)+1,@pageName, @pageURL FROM Pages 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    ELSE 
    BEGIN 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    
    if NOT Exists(SELECT * FROM SearchTypeMaster Where SearchTypeName =@SearchType)
	BEGIN
	insert into SearchTypeMaster (SearchTypeID ,SearchTypeName )
	select 0,'OP'
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType

	END
	ELSE
	BEGIN
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
    
  IF NOT EXISTS(SELECT * FROM ActionMaster Where ActionName ='Print Consent Form' AND ActionCode IS NOT NULL )
	BEGIN 

	insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode )
	select  max(ActionID)+1 ,'Print Consent Form','../Reception/ConsentFormPrint.aspx?PID={PatientID}&VID={PatientVisitID}','Consent_Form_Print_ConsentFormPrint' from ActionMaster 
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='Print Consent Form'
	END
	ELSE
	BEGIN
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='Print Consent Form'
	Update ActionMaster set QueryString = '../Reception/ConsentFormPrint.aspx?PID={PatientID}&VID={PatientVisitID}',ActionCode ='Consent_Form_Print_ConsentFormPrint' Where ActionID =@ActionID AND ActionCode IS NULL
	END
	
	
	
	IF( (@ActionID >0 )and (@RoleID >0) and (@SearchTypeID>0) and( @pageid>0))
	BEGIN
	insert into ActionRoleMapping (ActionID ,RoleID ,SearchTypeID ,RedirectPageID ,IsMapped )
	SELECT @ActionID,@RoleID ,@SearchTypeID ,@pageid ,'Y'
	
	END
	END
    
    
---------------------------For InpatientSearch------

       DECLARE @pageURL Varchar(max)='/Reception/ConsentFormPrint.aspx'
       DECLARE @pageName varchar(MAX)='Print Consent Form'
       DECLARE @SearchTypeID int=12
       DECLARE @SearchType Varchar(200)='InPatientSearch'
       DECLARE @ActionID INT 
       DECLARE @RoleID int 
       DECLARE @pageid int=0
       DECLARE @Rolename Varchar(200)='Receptionist'
       DECLARE @OrgID int=113
     
BEGIN 
    
   SeLECT @RoleID =RoleID  FROM Role where OrgID = @OrgID and RoleName = @Rolename 

  if NOT Exists( SELECT * FROM Pages WHERE PageURL =@pageURL)
   BEGIN 
    INSERT into Pages (PageID ,PageName ,PageURL )
    SELECT MAX(PageID)+1,@pageName, @pageURL FROM Pages 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    ELSE 
    BEGIN 
    SELECT  @pageid=PageID  FROM Pages WHERE PageURL =@pageURL
    END
    
    if NOT Exists(SELECT * FROM SearchTypeMaster Where SearchTypeName =@SearchType)
	BEGIN
	insert into SearchTypeMaster (SearchTypeID ,SearchTypeName )
	select 12,'InPatientSearch'
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType

	END
	ELSE
	BEGIN
	SELECT @SearchTypeID=SearchTypeID  from SearchTypeMaster where  SearchTypeName =@SearchType
	END
    
  IF NOT EXISTS(SELECT * FROM ActionMaster Where ActionName ='Print Consent Form' AND ActionCode IS NOT NULL )
	BEGIN 

	insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode )
	select  max(ActionID)+1 ,'Print Consent Form','../Reception/ConsentFormPrint.aspx?PID={PatientID}&VID={PatientVisitID}','Consent_Form_Print_ConsentFormPrint' from ActionMaster 
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='Print Consent Form'
	END
	ELSE
	BEGIN
	SELECT @ActionID =ActionID  FROM ActionMaster Where ActionName ='Print Consent Form'
	Update ActionMaster set QueryString = '../Reception/ConsentFormPrint.aspx?PID={PatientID}&VID={PatientVisitID}',ActionCode ='Consent_Form_Print_ConsentFormPrint' Where ActionID =@ActionID AND ActionCode IS NULL
	END
	
	
	
	IF( (@ActionID >0 )and (@RoleID >0) and (@SearchTypeID>0) and( @pageid>0))
	BEGIN
	insert into ActionRoleMapping (ActionID ,RoleID ,SearchTypeID ,RedirectPageID ,IsMapped )
	SELECT @ActionID,@RoleID ,@SearchTypeID ,@pageid ,'Y'
	
	END
	END
	
	
    
  --End print Consent Form --- 
  
     

---------------------------------------------Daywise Collection Report for LIMS------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------
IF NOT EXISTS(SELECT 1 FROM Pages WHERE PageName ='Daywise Collection Report' AND PageURL='/Reports/CollectionReportLIMS.aspx')
BEGIN
	IF EXISTS(SELECT 1 FROM Pages WHERE PageName ='Daywise Collection Report' AND PageURL='/Reports/CollectionReportOPIPWithFilter.aspx')
	BEGIN 
		UPDATE Pages SET PageURL ='/Reports/CollectionReportLIMS.aspx' WHERE PageID=(SELECT TOP 1 PageID FROM Pages WHERE PageName ='Daywise Collection Report' 
					 AND PageURL='/Reports/CollectionReportOPIPWithFilter.aspx' )
		UPDATE ReportMaster SET ReportPath='../Reports/CollectionReportLIMS.aspx',RedirectURL='../Reports/CollectionReportLIMS.aspx' 
					 WHERE PageID=(SELECT TOP 1 PageID FROM Pages WHERE PageName ='Daywise Collection Report' 
					 AND PageURL='/Reports/CollectionReportOPIPWithFilter.aspx' )
	END
	ELSE
	BEGIN 
		DECLARE @PageID bigint
		SELECT @PageID=MAX(PageID)+1 FROM Pages
		INSERT INTO ReportMaster (ReportID,ReportDisplayText,ReportPath,RedirectURL,ReportGroupID,CreatedAt,CreatedBy,PageID)
		SELECT MAX(ReportID)+1,'Day-wise Collection Reports','../Reports/CollectionReportLIMS.aspx','../Reports/CollectionReportLIMS.aspx',5,GETDATE(),1,@PageID
		FROM ReportMaster
	END
END	   
---------------------------------------------Daywise Collection Report for LIMS----------------------------------------------------

-- Config key for SingleReferenceRange 
BEGIN
	DECLARE @ConfigKeyID BIGINT
	DECLARE @OrgID INT

	SET @OrgID=67

	IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='SingleReferenceRange')
	BEGIN
	
		SELECT @ConfigKeyID=MAX(Configkeyid)+1 FROM ConfigKeyMaster

		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'SingleReferenceRange','Whether to take Reference Range values entered from Ref.Range Management Page. But not the values entered from Test Master.','Y','CHB')
	END

	IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='SingleReferenceRange')
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID 
						WHERE ConfigKey='SingleReferenceRange' AND OrgID=@OrgID)
		BEGIN

			DECLARE @pConfigKeyID BIGINT

			SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='SingleReferenceRange'

			INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
			VALUES(@pConfigKeyID,'Y',@OrgID)
		END
	END

END
--------------------------------------------- Begin Coding Scheme for Investigation----------------------------------------------------
IF NOT EXISTS(SELECT 1 FROM CodingSchemeMaster WHERE CodingSchemaName='AttuneCode')
BEGIN
	INSERT INTO CodingSchemeMaster VALUES('AttuneCode',1)
END
 
IF EXISTS(SELECT 1 FROM CodingSchemeMaster WHERE CodingSchemaName='AttuneCode')
BEGIN
	DECLARE @OrgID INT
	DECLARE @CodeTypeID INT
	
	SET @OrgID = 67
	SELECT @CodeTypeID=CodeTypeID FROM CodingSchemeMaster WHERE CodingSchemaName='AttuneCode'
		
	IF NOT EXISTS(SELECT 1 FROM CodeMaster CM JOIN CodingSchemeMaster CSM ON CM.CodeSchemeID=CSM.CodeTypeID WHERE CSM.CodingSchemaName='AttuneCode')
	BEGIN
		SELECT @CodeTypeID=CodeTypeID FROM CodingSchemeMaster WHERE CodingSchemaName='AttuneCode'

		INSERT INTO CodeMaster
		SELECT 'AT-' + CONVERT(VARCHAR,InvestigationID) AS CodeName,'Investigations',@CodeTypeID,InvestigationName AS CodeDesc FROM InvestigationMaster
	
		INSERT INTO CodeMapper
		SELECT 'Investigations',InvestigationID,@CodeTypeID FROM InvestigationMaster
	END
	IF NOT EXISTS(SELECT 1 FROM CodingSchemeOrgMapping CSOM JOIN CodingSchemeMaster CSM ON CSOM.CodeTypeID=CSM.CodeTypeID WHERE CSM.CodingSchemaName='AttuneCode'
	AND CSOM.OrgID=@OrgID)
	BEGIN
		INSERT INTO CodingSchemeOrgMapping
		SELECT @CodeTypeID,@OrgID,@OrgID,@OrgID,'Y'
	END
END
---------------------------------------------End Coding Scheme for Investigation----------------------------------------------------


DECLARE @pConfigKeyID int
SELECT @pConfigKeyID = MAX(ConfigKeyID)+1 From ConfigKeyMaster
insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT @pConfigKeyID,'NeedTempPatientReg','Patient Temporary Registration allowed for this Org?','Y'  

insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,OrgAddressId)  select @pConfigKeyID,'Y',67,0

DECLARE @pConfigKeyID1 int
SELECT @pConfigKeyID1 = MAX(ConfigKeyID)+1 From ConfigKeyMaster
insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT @pConfigKeyID1,'NeedTempDoctorReg','Refering Physician Temporary Registration allowed for this Org?','Y'  

insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,OrgAddressId)  select @pConfigKeyID1,'Y',67,0

------------------------------------ Need Bill Print for Client --------------------

Declare @configkeyid int
select @configkeyid = MAX(ConfigKeyID)+1 from ConfigKeyMaster
insert into ConfigKeyMaster
select @configkeyid,'NeedPrintForClient','After Generating Bill need Bill Print for Client Bills','N','RDO','','',null
insert into ConfigOrgMaster
select @configkeyid,'N',67,null,null,null,null,null
----------------------------------------------------------------------------------------
--------------------------------------------- Begin Show Lab Report Preview ----------------------------------------------------
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowLabReportPreview')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT MAX(ConfigKeyID)+1,'ShowLabReportPreview','Do you want to show lab report preview?','N','CHB','String' FROM ConfigKeyMaster
END
GO

DECLARE @pOrgID INT
DECLARE @pConfigKeyID BIGINT
SET @pOrgID = 67 --Suburban
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowLabReportPreview')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='ShowLabReportPreview' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='ShowLabReportPreview'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID,'Y',@pOrgID)
	END
END
GO
---------------------------------------------End Show Lab Report Preview ----------------------------------------------------

---------------------------------------------Hide the IP Amount in Manage Rate ----------------------------------------------------

DECLARE @ConfigKeyID BIGINT
--Set the orgid to @MinValue
DECLARE @MinValue BIGINT = 67
DECLARE @MaxValue BIGINT = 69
WHILE @MinValue <= @MaxValue
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='HideIPManageRate')
				BEGIN	
					SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'HideIPManageRate','Do you want Hide IP Mange Rates','N','N')
				END
			SELECT @ConfigKeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='HideIPManageRate'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='HideIPManageRate' AND COM.OrgID=@MinValue)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@MinValue,GETDATE())
				END
		END
	SET @MinValue = @MinValue+1
END
---------------------------------------------End Hide the IP Amount in Manage Rate ----------------------------------------------------

---------------------------------------------Need Bill Investigation with DEPT SRS ----------------------------------------------------
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedBillInvestigationSRS')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT MAX(ConfigKeyID)+1,'NeedBillInvestigationSRS','Do you want Need Bill SRS?','Y' FROM ConfigKeyMaster
END
GO

DECLARE @pOrgID INT
DECLARE @pConfigKeyID BIGINT
SET @pOrgID = 67 --Suburban
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedBillInvestigationSRS')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='NeedBillInvestigationSRS' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedBillInvestigationSRS'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID,'Y',@pOrgID)
	END
END
GO
---------------------------------------------END Need Bill Investigation with DEPT SRS ----------------------------------------------------

--------------------------------------------- Start Action for Dispatch Report in Investigation Report ----------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Dispatch_Report_InvestigationReport')
BEGIN
	INSERT INTO ActionMaster (ActionID,ActionName,ActionCode) 
	SELECT (SELECT MAX(ActionID)+1 FROM ActionMaster) AS ActionID,'Dispatch Report','Dispatch_Report_InvestigationReport'
END
--------------------------------------------- End Action for Dispatch Report in Investigation Report ----------------------------------------------------

--------------------------------------------- Start Action Role Mapping for Action Code "Dispatch_Report_InvestigationReport" and Role Name "Dispatch Controller" ----------------------------------------------------
DECLARE @PageID INT
DECLARE @OrgID INT = 67
DECLARE @RoleID BIGINT
DECLARE @SearchTypeID BIGINT

SELECT @RoleID=RoleID FROM Role WHERE RoleName='Dispatch Controller' AND OrgID=@OrgID

SELECT @PageID=PageID FROM Pages WHERE PageName='InvestigationReport' AND PageURL='/Investigation/InvestigationReport.aspx'
SELECT @SearchTypeID=SearchTypeID FROM SearchTypeMaster WHERE SearchTypeName='Lab'

IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Dispatch_Report_InvestigationReport')
BEGIN
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE ActionID=(SELECT ActionID FROM ActionMaster WHERE ActionCode='Dispatch_Report_InvestigationReport') AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	BEGIN
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT ActionID FROM ActionMaster WHERE ActionCode='Dispatch_Report_InvestigationReport'),@RoleID,@PageID,@SearchTypeID,'Y'
	END
END

IF EXISTS (SELECT 1 FROM ActionMaster WHERE ActionCode='Show_Report_InvestigationReport')
BEGIN
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE ActionID=(SELECT ActionID FROM ActionMaster WHERE ActionCode='Show_Report_InvestigationReport') AND RoleID=@RoleID AND RedirectPageID=@PageID AND SearchTypeID=@SearchTypeID)
	BEGIN
		INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
		SELECT (SELECT ActionID FROM ActionMaster WHERE ActionCode='Show_Report_InvestigationReport'),@RoleID,@PageID,@SearchTypeID,'Y'
	END
END
--------------------------------------------- End Action Role Mapping for Action Code "Dispatch_Report_InvestigationReport" and Role Name "Dispatch Controller" ----------------------------------------------------
---------------------------------------------ConfigKey Setting for show specialty with physician-------------------------------
DECLARE @pConfigKeyID int
SELECT @pConfigKeyID = MAX(ConfigKeyID)+1 From ConfigKeyMaster
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowSpecialtyWithPhysician')
BEGIN
	insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ConfigType ,IsAddressBased)
	SELECT @pConfigKeyID,'ShowSpecialtyWithPhysician','Display Specialty names with Physician names in Consultation Fee Type','N','CHB','HOS','N'
END
---------------------------------------------END----------------------------------------------------------------------------------------

go

--select * from pages Order by pageid desc  
IF NOT EXISTS(select * from pages where PageURL ='/Patient/PatientEMRComplaintHistory.aspx')
BEGIN
insert into Pages (PageID ,PageName ,PageURL ,IsShareable )
select MAX(PageID)+1,'PatientEMR ComplaintHistory','/Patient/PatientEMRComplaintHistory.aspx','N' from Pages 
END
go

IF NOT EXISTS(select * from pages where PageURL ='/Patient/ViewHistory.aspx')
BEGIN
insert into Pages (PageID ,PageName ,PageURL ,IsShareable )
select MAX(PageID)+1,'View History','/Patient/ViewHistory.aspx','N' from Pages 
END

go

--select * from ActionMaster order by ActionID desc 

IF NOT EXISTS(select * from ActionMaster where ActionName  ='Health Screening')
BEGIN
insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode ,IsShareable )
select  MAX(ActionID)+1,'Health Screening', '../Patient/PatientEMRComplaintHistory.aspx?vid={PatientVisitID}&pid={PatientID}&tid=0&invid=0','Health_Screening_ComplaintHistory' , 'N' from ActionMaster

END

go
IF NOT EXISTS(select * from ActionMaster where ActionName  ='View Health Screening')
BEGIN
insert into ActionMaster (ActionID ,ActionName ,QueryString ,ActionCode ,IsShareable )
select  MAX(ActionID)+1,'View Health Screening', '../Patient/ViewHistory.aspx?vid={PatientVisitID}&pid={PatientID}&tid=0&invid=0','ViewHealth_Screening_HealthScreening' , 'N' from ActionMaster

END

---------------------------------------- Payment Type Validation ---------------------------

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='CardValidationInBilling')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT MAX(ConfigKeyID)+1,'CardValidationInBilling','Do you want Need Bill SRS?','Y' FROM ConfigKeyMaster
END
GO


DECLARE @pOrgID INT
DECLARE @pConfigKeyID1 BIGINT
SET @pOrgID = 67 --Suburban
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='CardValidationInBilling')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='CardValidationInBilling' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID1 = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='CardValidationInBilling'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID1,'Y',@pOrgID)
	END
END
GO


------------------------------ Bill Print Option in Billing Screen
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NoNeedBillPrint')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT MAX(ConfigKeyID)+1,'NoNeedBillPrint','Dont Need Bill Print in Billing?','Y' FROM ConfigKeyMaster
END
GO


DECLARE @pOrgID INT
DECLARE @pConfigKeyID1 BIGINT
SET @pOrgID = 96 --Suburban
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NoNeedBillPrint')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='NoNeedBillPrint' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID1 = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NoNeedBillPrint'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID1,'Y',@pOrgID)
	END
END
GO


IF NOT EXISTS (select ConfigKeyID  from ConfigKeyMaster where ConfigKey ='SuburbanPrintBillFormat')
BEGIN

insert into ConfigKeyMaster (ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ,IsAddressBased )
select MAX(ConfigKeyID)+1,'SuburbanPrintBillFormat','Do you need to display Suburban Print Bill Format?','N','CHB','',NULL,NULL from ConfigKeyMaster
Declare @Configkeyid int
select @Configkeyid =ConfigKeyID  from ConfigKeyMaster where ConfigKey ='SuburbanPrintBillFormat'

insert into ConfigOrgMaster (ConfigKeyID ,ConfigValue ,OrgID)
select @Configkeyid,'Y',67 
END
GO
--------------------------------------------- Begin Show Only Delta Graph in Summary Report ----------------------------------------------------
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowOnlyDeltaGraphInSummaryReport')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT MAX(ConfigKeyID)+1,'ShowOnlyDeltaGraphInSummaryReport','Do you want to show only delta graph in summary report?','N','CHB','String' FROM ConfigKeyMaster
END
GO

DECLARE @pOrgID INT
DECLARE @pConfigKeyID BIGINT
SET @pOrgID = 67 --Suburban
IF EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowOnlyDeltaGraphInSummaryReport')
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID WHERE ConfigKey='ShowOnlyDeltaGraphInSummaryReport' AND OrgID=@pOrgID)
	BEGIN
		SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='ShowOnlyDeltaGraphInSummaryReport'
		
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) VALUES(@pConfigKeyID,'Y',@pOrgID)
	END
END
GO

------------------------------------------------------------------------------------------------------------------------------
              DECLARE @OrgID INT
                SELECT @OrgID=OrgID FROM Organization WHERE Name='RS Sanglah'
                        
                       IF  EXISTS(SELECT 1 FROM ConfigKeyMaster CK WHERE CK.ConfigKey='KMHIPViewBilling')
                BEGIN
                       UPDATE CK SET ConfigKey='CustomizedIPViewBilling',DisplayText='Only Customized View Bill',IsInternal='Y',ConfigType='HOS',IsAddressBased='N'
                       FROM ConfigKeyMaster ck WHERE CK.ConfigKey='KMHIPViewBilling'
                END
                ELSE
                BEGIN
                   INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased)
                   SELECT MAX(ConfigKeyID)+1,'CustomizedIPViewBilling','Only Customized View Bill','Y','','','HOS','N' FROM ConfigKeyMaster
                   INSERT ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID) SELECT MAX(ConfigKeyID),'Y',@OrgID  FROM ConfigKeyMaster
                END
 
                GO
--------------------------------------------------------------------------------------------------------------------------------
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='DynamicAddressControl')
BEGIN
insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
select MAX(ConfigKeyID)+1,'DynamicAddressControl','Need Dynamic user AddressControl','Y'  from ConfigKeyMaster

DECLARE @pOrgID INT
DECLARE @pConfigKeyID BIGINT
SET @pOrgID = 1 -- Define the org addrress
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID 
WHERE ConfigKey='DynamicAddressControl' AND OrgID=@pOrgID)
begin
SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='DynamicAddressControl'

insert into ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
select @pConfigKeyID,'Y',@pOrgID 
end
END
GO
----------------END-----------

------------ Performing Physician Mandatory - in Quick Billing -----------------------
BEGIN

	Declare @ConfigKeyID BIGINT
	Declare @OrgID INT

	SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE 'NULIFE  HOSPITAL  (Managed by Irene healthcare)'
	IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PerfPhysicianMand')
	BEGIN	
		SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 FROM ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
			VALUES(@ConfigKeyID,'PerfPhysicianMand','Is Performing Physician Mandatory ?','N','CHB')
	END
	IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PerfPhysicianMand' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END
END
-------------------------------------------------------------------

GO
------------ Visit Number Generation Config -----------------------

INSERT ConfigKeyMaster
SELECT	MAX(ConfigKeyID)+1,'NeedVisitNo','Do you Want Visit Number for Patient Visit''s?','Y',NULL,NULL,NULL,'N' FROM ConfigKeyMaster
INSERT ConfigOrgMaster
SELECT MAX(ConfigKEYID)+1,'Y',1,1,GETDATE(),1,GETDATE(),0 FROM ConfigKeyMaster

---------------------------------------
--------------------------------------- PRINT OP Card to be Checked by Default or Not ------------------------------------
Declare @OrgID int,@ConfigKeyID bigint
SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE '%sanglah%'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PRINT_OP_CARD')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'PRINT_OP_CARD','Do you want to default printing of op card','Y','CHB')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PRINT_OP_CARD' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END
GO
--------------------------------------- PRINT OP Card to be Checked by Default or Not ------------------------------------

--------------------------------------- Redirect PatinetReg To QuickBilling ----------------------------------------------
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PatinetRegToQuickBilling')
BEGIN
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT MAX(ConfigKeyID)+1,'PatinetRegToQuickBilling','Redirect PatinetReg To QuickBilling','Y'  FROM ConfigKeyMaster
	DECLARE @pOrgID INT,@pConfigKeyID BIGINT
	SELECT @pOrgID = OrgID FROM Organization WHERE Name LIKE '%sanglah%'-- Redirect PatinetReg To QuickBilling
 
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID = COM.ConfigKeyID 
WHERE ConfigKey='PatinetRegToQuickBilling' AND OrgID=@pOrgID)
	BEGIN
	SELECT @pConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='PatinetRegToQuickBilling'
	INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID)
	SELECT @pConfigKeyID,'Y',@pOrgID 
	END
END
GO
--------------------------------------- Redirect PatinetReg To QuickBilling ----------------------------------------------

----------------------------------------MRS_Queue Create Task---------------------------------------------
Declare @OrgID int,@ConfigKeyID bigint
SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE '%sanglah%'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='MRD_QUEUEING_SYSTEM_AVAILABLE')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'MRD_QUEUEING_SYSTEM_AVAILABLE','Create Task for Specialty after MRD traces the Patient File?','Y','TEXT')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='MRD_QUEUEING_SYSTEM_AVAILABLE' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END
GO
----------------------------------END-----------------------------------------------------------------



--Dispatch
Go
update ActionManagerType set IsDisplay ='N' where ActionType ='Hand Delivery' 

Go
DECLARE @PID int
select Top 1  @pid =pageid   from Pages where PageURL like '/Investigation/InvestigationReport.aspx'

if Not Exists( select * from PageContext where ButtonName ='btndespatch')
begin

  insert into PageContext (PageID ,ButtonName ,ButtionValue )
  select @PID,'btndespatch','Dispatch'

END

DECLARE @PageContextID int
DECLARE @RoleID bigint
select  @PageContextID=PageContextID  from PageContext where ButtonName ='btndespatch'
select  @RoleID =RoleID  from Role where OrgID =67  and RoleName ='Dispatch Controller'

if (@PageContextID >0 AND @RoleID >0 )
BEGIN
insert into PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,Description)
select @PageContextID,@RoleID,3,3,'DISP',NULL,NULL

insert into PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,Description)
select @PageContextID,@RoleID,1,9,'DISP',NULL,NULL

END

---------------------------------------------------Start SMS & EMail Configuration-----------------------------------------------------------------
DECLARE @pOrgID INT = 0 -- Organization ID
IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID)
BEGIN
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='SMS' AND Name='URL')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'SMS','URL','http://ubaid.tk/sms/sms.aspx?uid={UserName}&pwd={Password}&msg={Message}&phone={MobileNo}&provider={Provider}')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='SMS' AND Name='UserName')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'SMS','UserName','9791035001')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='SMS' AND Name='Password')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'SMS','Password','Bn7qKysZ9q0=')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='SMS' AND Name='Provider')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'SMS','Provider','fullonsms')
	END
	
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='EMail' AND Name='Host')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'EMail','Host','smtp.gmail.com')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='EMail' AND Name='UserName')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'EMail','UserName','DoNotReply@Attunelive.com')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='EMail' AND Name='Password')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'EMail','Password','1NlfyhMkLPhjXD2Sr/M3Sg==')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='EMail' AND Name='Port')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'EMail','Port','587')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='EMail' AND Name='FromAddress')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'EMail','FromAddress','DoNotReply@Attunelive.com')
	END
	IF NOT EXISTS(SELECT 1 FROM CommunicationConfig WHERE OrgID=@pOrgID AND Type='EMail' AND Name='FromDisplayText')
	BEGIN
		INSERT INTO CommunicationConfig(OrgID,Type,Name,Value) VALUES(@pOrgID,'EMail','FromDisplayText','Attune')
	END
END
---------------------------------------------------END SMS & EMail Configuration-----------------------------------------------------------------

Declare @OrgID int,@ConfigKeyID bigint
SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE '%sanglah%'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='COLLECTPAYMENT')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'COLLECTPAYMENT','Need Separate Collect Payment','Y','TEXT')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='COLLECTPAYMENT' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END
GO




---------------------------------------------------STRAT SURGERY BILL CONFIG-----------------------------------------------------------------

Declare @OrgID int,@ConfigKeyID bigint
SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE '%sanglah%'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='SurgeryfeeDefined')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'SurgeryfeeDefined','Is Surgery Fee Defined(Y/N)?','Y','CHB')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='SurgeryfeeDefined' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END
GO

----CONFIG KEY FOR SURGERY BILLING  END----------------------------

Declare @OrgID int,@ConfigKeyID bigint
SELECT @OrgID = OrgID FROM Organization WHERE Name LIKE '%sanglah%'
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='SHOWFEESPLIT')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'SHOWFEESPLIT','Need Show Fee Split','Y','TEXT')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='SHOWFEESPLIT' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END
GO


--------------------- Need Discount on Child Bills --------------------------

DECLARE @OrgID int, @ConfigKeyID int
SELECT @OrgID =1 

SELECT @ConfigKeyID = MAX(ConfigKeyID)+1 FROM ConfigKeyMaster 

INSERT INTO ConfigKeyMaster (ConfigKeyID ,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased)
SELECT				 @ConfigKeyID,'DiscountOnChildBills','Does this Org Need for Discount on Child Bills',
					 'N','','','HOS','N'  
					 
INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)SELECT @ConfigKeyID,'50',@OrgID 
--------------------------END ---------------------------------------------------------

----------------- PRINT BAR CODE FOR PATIENT REGISTRATION AND VISIT BEGINS ---------------------- 
Declare @OrgID int,@ConfigKeyID bigint
SELECT @OrgID = 1 -- Change accordingly 
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PRINT_BARCODE_ON_PATIENT_VISIT_REGISTRATION')
	BEGIN	
		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
		INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
		VALUES(@ConfigKeyID,'PRINT_BARCODE_ON_PATIENT_VISIT_REGISTRATION','Print Patient MRD and Visit Data in Barcode Format','Y','TEXT')
	END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PRINT_BARCODE_ON_PATIENT_VISIT_REGISTRATION' AND COM.OrgID=@OrgID)
	BEGIN
		INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',@OrgID,GETDATE())
	END
GO
----------------- PRINT BAR CODE FOR PATIENT REGISTRATION AND VISIT ENDS ---------------------- 
----------------- DISABLE CONTINUE BUTTON IN RESULT CAPTURE PAGE ---------------------- 
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='DisableResultCaptureContinueButton')
BEGIN
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT ISNULL(MAX(ConfigKeyID),0)+1,'DisableResultCaptureContinueButton','Do you want to disable result capture continue button','N','','' FROM ConfigKeyMaster
END
----------------- DISABLE CONTINUE BUTTON IN RESULT CAPTURE PAGE ---------------------- 


if not exists(select * from ConfigKeyMaster where ConfigKey='SampleStatusAllValidate')
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ConfigType)
	SELECT MAX(ConfigkeyID) + 1,'SampleStatusAllValidate','Is Needed Sample Status AllValidate?','N','CHB' from ConfigKeyMaster 
	
if not exists(select * from ConfigOrgMaster where ConfigKeyID=(select ConfigKeyID from ConfigKeyMaster where ConfigKey='SampleStatusAllValidate'))
	INSERT into ConfigOrgMaster(ConfigValue,OrgID,ConfigKeyID)
	select 'N',67,MAX(ConfigkeyID) from ConfigKeyMaster 
	go
	
 
 if not exists(select * from ConfigKeyMaster where ConfigKey='SampleStatusAllCompleted')
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ConfigType)
	SELECT MAX(ConfigkeyID) + 1,'SampleStatusAllCompleted','Is Needed Sample Status AllCompleted?','N','CHB' from ConfigKeyMaster 
	
if not exists(select * from ConfigOrgMaster where ConfigKeyID=(select ConfigKeyID from ConfigKeyMaster where ConfigKey='SampleStatusAllCompleted'))
	INSERT into ConfigOrgMaster(ConfigValue,OrgID,ConfigKeyID)
	select 'Y',67,MAX(ConfigkeyID) from ConfigKeyMaster 
	go


 if not exists(select ConfigValue from ConfigOrgMaster where ConfigValue='QuatumBillPrint.ascx')
 begin
 update ConfigOrgMaster set ConfigValue='QuatumBillPrint.ascx' where ConfigKeyID=24   
 end
 go
 IF NOT EXISTS(SELECT * FROM ConfigKeyMaster WHERE ConfigKey='NeedTRFBarcode')
BEGIN
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT ISNULL(MAX(ConfigKeyID),0)+1,'NeedTRFBarcode','Do you want to print trf barcode','N','','' FROM ConfigKeyMaster
END
GO
 IF NOT EXISTS(select * from ConfigKeyMaster where ConfigKey='MobileNoFormat')
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ConfigType)
	SELECT MAX(ConfigkeyID) + 1,'MobileNoFormat','Enter MobileNo Country Code','N','TEXT' from ConfigKeyMaster 
GO	
IF NOT EXISTS(select * from ConfigOrgMaster where ConfigKeyID=(select ConfigKeyID from ConfigKeyMaster where ConfigKey='MobileNoFormat'))
	INSERT into ConfigOrgMaster(ConfigValue,OrgID,ConfigKeyID)
	select 'Mobile +63',67,MAX(ConfigkeyID) from ConfigKeyMaster 
GO

-----------------------Added By Sathish.E--------------------------------------------11/09/2013-------------------------

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsOutSourcedTest')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'IsOutSourcedTest','Do you want Enter Result for OutSourced Test?','Y','','','') 
insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@GetconfigId,'N',67)
END

----------------------------------------END----------------------------------------------------
-----------------------Added By Sathish.E--------------------------------------------12/09/2013-------------------------

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsZeroAmountTest')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'IsZeroAmountTest','Do you want Allow to Zero Amount Test?','Y','','','') 
insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@GetconfigId,'N',67)
END

 
----------------------------------------END----------------------------------------------------

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='StatusChangeByOrg')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'StatusChangeByOrg','Do you want to Status Change for Empty textbox','Y','','','') 
insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@GetconfigId,'Y',67)
END

-------------Added by prabakar for Show pdf option in Client-----------------14/09/2013-------------------

DECLARE @ActionID int
DECLARE @RoleID Bigint
DECLARE @PageID Bigint
DECLARE @SearchTypeID int
DECLARE @OrgID int
SET @OrgID=67  -- OrgID for metropolis,suburban and Quantum
SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionCode='Show_PDF'
SELECT @RoleID=RoleID FROM Role WHERE RoleName LIKE 'Credit Controller' AND OrgID=@OrgID
SELECT @PageID=PageID FROM Pages WHERE PageURL LIKE '/Invoice/InvoiceTracker.aspx' order by PageID desc

SET @SearchTypeID=41 --This @SearchTypeID for Invoice
IF NOT EXISTS(SELECT 1 FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END
	--------------------------end--------------------------
-------------Added by prabakar for Show pdf and Resend Email option in Dispatch controller-----------------14/09/2013-------------------

SELECT @RoleID=RoleID FROM Role WHERE RoleName LIKE 'Dispatch Controller' AND OrgID=@OrgID
SELECT @PageID=PageID FROM Pages WHERE PageURL LIKE '/Investigation/InvestigationReport.aspx' order by PageID desc

SET @SearchTypeID=4 --This @SearchTypeID for lab
IF NOT EXISTS(SELECT 1 FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END
	
SELECT @ActionID=ActionID FROM ActionMaster WHERE ActionCode='Resend_Report'

SET @SearchTypeID=4 --This @SearchTypeID for lab
IF NOT EXISTS(SELECT 1 FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID AND RedirectPageID=@PageID AND IsMapped='Y')
	BEGIN
		INSERT INTO ActionRoleMapping(ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)values(@ActionID,@RoleID,@PageID,@SearchTypeID,'Y')
	END
ELSE
	BEGIN
		PRINT 'This ActionID already mapped to this role'
	END

---------------END-----------------

----------------------TAT REPORT DATE CONFIG BASED CHANGED BY PREM----------------------------17/09/2013-----------------------
if not exists(select * from ConfigKeyMaster where ConfigKey='TAT')
begin
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ConfigType)
	SELECT MAX(ConfigkeyID) + 1,'TAT','Is Needed TAT Report DateandTime?','N','CHB' from ConfigKeyMaster
	end
	go 
	
if not exists(select * from ConfigOrgMaster where ConfigKeyID=(select ConfigKeyID from ConfigKeyMaster where ConfigKey='TAT'))
	begin
	INSERT into ConfigOrgMaster(ConfigValue,OrgID,ConfigKeyID)
	select 'N',67,MAX(ConfigkeyID) from ConfigKeyMaster 
	end
	go
	

-----------------------------------------END-----------------------------------------------------------------------------------


/***************************************Added by prabakar for Auto Email Service pagecontextActionmapping Config Script*************/

/******************CONFIGURE FOR DOCTOR ROLE******************/
DECLARE @PageContextID INT
DECLARE @RoleID BIGINT
DECLARE @ActionTypeID INT
DECLARE @TemplateID INT
DECLARE @PageID INT
DECLARE @MinPageContextID INT 
DECLARE @MaxPageContextID INT
DECLARE @ContextType VARCHAR(10)
SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'Doctor'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Investigation/InvestigationApprovel.aspx'

DECLARE @TmpPagecontextID TABLE(PagecontextID int)  
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnSave1','btnSaveToDispatch1','btnSave','btnSaveToDispatch','btnSaveConfirm','Save') AND PageID=@PageID
 
/*********FOR PATIENT****************/
SELECT @ContextType='P'
/*********FOR PATIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
SELECT @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR PATIENT End**************************/

	
/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*********FOR PATIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT SMS End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
/*********FOR CLIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
SELECT @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR CLIENT End**************************/

	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/*********FOR CLIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID=  ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' and ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT SMS End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/


/******************END CONFIGURE FOR DOCTOR ROLE******************/

/******************CONFIGURE FOR Junior Doctor ROLE******************/

SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'Junior Doctor'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Investigation/InvestigationApprovel.aspx'

 
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnSave1','btnSaveToDispatch1','btnSave','btnSaveToDispatch','btnSaveConfirm','Save') AND PageID=@PageID
 
/*********FOR PATIENT****************/
SELECT @ContextType='P'
/*********FOR PATIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
SELECT @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR PATIENT End**************************/

	
/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*********FOR PATIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT SMS End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
/*********FOR CLIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
SELECT @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR CLIENT End**************************/

	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/*********FOR CLIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID=  ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' and ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT SMS End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/


/******************END CONFIGURE FOR JUNIOR DOCTOR ROLE******************/


/******************CONFIGURE FOR Lab Technician ROLE******************/

SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'Lab Technician'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Investigation/InvestigationResultsCapture.aspx'

 
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnShowRR1','btnSave','btnShowRR','btnSaveConfirm','btnApproval1','btnApproval') AND PageID=@PageID
 
/*********FOR PATIENT****************/
SELECT @ContextType='P'
/*********FOR PATIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
SELECT @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR PATIENT End**************************/

	
/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*********FOR PATIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT SMS End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
/*********FOR CLIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
SELECT @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR CLIENT End**************************/

	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/*********FOR CLIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID=  ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' and ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT SMS End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/

/**************************************End LAB TECHNITION*****************************************************************************/


/******************CONFIGURE FOR LabReception(DEO B2C) ROLE******************/

SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'LabReception'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Billing/LabQuickBilling.aspx'
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnGenerate') AND PageID=@PageID

/*********FOR PATIENT****************/
SELECT @ContextType='P'

/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'REmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*********FOR PATIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='RSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'RSms_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT SMS End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'REmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/*********FOR CLIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID=  ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' and ActionCode='RSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'RSms_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT SMS End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/


/******************END CONFIGURE FOR Lab Reception(B2C) ROLE******************/



/******************CONFIGURE FOR ClientBilling(DEO B2B) ROLE******************/

SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'DEO B2B'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Billing/ClientBilling.aspx'

INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnGenerate') AND PageID=@PageID

/*********FOR PATIENT****************/
SELECT @ContextType='P'

/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'REmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*********FOR PATIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='RSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'RSms_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT SMS End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'REmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/*********FOR CLIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID=  ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' and ActionCode='RSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'RSms_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Notify','N',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT SMS End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/


/******************END CONFIGURE FOR Client Billing(B2B) ROLE******************/



/******************CONFIGURE FOR Credit Controller ROLE******************/

SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'Credit Controller'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Reception/LabReceptionHome.aspx'
 
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('GnereateInvoive') AND PageID=@PageID

SELECT @ContextType='INV'
/*********FOR  PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
SELECT @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND 
ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Invoice','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR PDF End**************************/
/*********FOR EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='IEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'INV_Email'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Invoice','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR  EMAIL End*****************/

/*********FOR  SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='ISMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'INV_Sms'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Invoice','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR  SMS End*****************/



/******************END CONFIGURE FOR Credit Controller ROLE******************/

/******************CONFIGURE FOR DOCTOR ROLE Quick Approvel******************/
DECLARE @PageContextID INT
DECLARE @RoleID BIGINT
DECLARE @ActionTypeID INT
DECLARE @TemplateID INT
DECLARE @PageID INT
DECLARE @MinPageContextID INT 
DECLARE @MaxPageContextID INT
DECLARE @ContextType VARCHAR(10)
SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'Doctor'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Investigation/InvestigationQuickApprovel.aspx'

DECLARE @TmpPagecontextID TABLE(PagecontextID int)  
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnApprove') AND PageID=@PageID
 
/*********FOR PATIENT****************/
SELECT @ContextType='P'
/*********FOR PATIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR PATIENT End**************************/

	
/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*********FOR PATIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT SMS End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
/*********FOR CLIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR CLIENT End**************************/

	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/*********FOR CLIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID=  ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' and ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT SMS End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/


/******************END CONFIGURE FOR DOCTOR ROLE Quick Approve DOCTOR ROLE******************/

/*************************************************************End By prabakar********************************************************************************/



/******************CONFIGURE FOR Junior Doctor ROLE Quick Approvel******************/
DECLARE @PageContextID INT
DECLARE @RoleID BIGINT
DECLARE @ActionTypeID INT
DECLARE @TemplateID INT
DECLARE @PageID INT
DECLARE @MinPageContextID INT 
DECLARE @MaxPageContextID INT
DECLARE @ContextType VARCHAR(10)
SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'Junior Doctor'
SELECT @PageID = PageID from Pages WHERE PageURL = '/Investigation/InvestigationQuickApprovel.aspx'

DECLARE @TmpPagecontextID TABLE(PagecontextID int)  
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnApprove') AND PageID=@PageID
 
/*********FOR PATIENT****************/
SELECT @ContextType='P'
/*********FOR PATIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR PATIENT End**************************/

	
/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*********FOR PATIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' AND ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT SMS End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
/*********FOR CLIENT PDF****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID 
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Pdf'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/*********FOR CLIENT End**************************/

	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/*********FOR CLIENT SMS****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID=  ActionTypeID FROM ActionManagerType WHERE ActionType='Sms' and ActionCode='REPSMS'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ValueSms_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT SMS End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/


/******************END CONFIGURE FOR Junior Doctor Quick Approve DOCTOR ROLE******************/

/*************************************************************End By prabakar********************************************************************************/


/***************************************Added by prabakar for Auto Email Service pagecontextActionmapping Config Script*************/
/******************CONFIGURE FOR Dispatch Controller ROLE******************/
DECLARE @PageContextID INT
DECLARE @RoleID BIGINT
DECLARE @ActionTypeID INT
DECLARE @TemplateID INT
DECLARE @PageID INT
DECLARE @MinPageContextID INT 
DECLARE @MaxPageContextID INT
DECLARE @ContextType VARCHAR(10)
SELECT @RoleID=RoleID FROM Role WHERE RoleName = 'Dispatch Controller'
SELECT @PageID =PageID from Pages WHERE PageURL = '/Investigation/InvestigationReport.aspx'

DECLARE @TmpPagecontextID TABLE(PagecontextID int)  
INSERT INTO @TmpPagecontextID(PagecontextID)
SELECT PageContextID from PageContext where ButtonName in ('btnGo') AND PageID=@PageID
 
/*********FOR PATIENT****************/
SELECT @ContextType='P'

/*********FOR PATIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_P'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR PATIENT EMAIL End*****************/

/*******************************************************FOR PATIENT END**************************************************************************************/



/********************************************************FOR START CLIENT************************************************************************************/
SELECT @ContextType='CP'
	
/*********FOR CLIENT EMAIL****************/
SELECT @MinPageContextID= MIN(PageContextID) from @TmpPagecontextID
SELECT @MaxPageContextID= MAX(PageContextID) from @TmpPagecontextID  
SELECT @ActionTypeID= ActionTypeID FROM ActionManagerType WHERE ActionType='Email' AND ActionCode='REPEMAIL'
select @TemplateID=TemplateID from ActionTemplate where TemplateName = 'ReptEmail_C'
WHILE @MinPageContextID <= @MaxPageContextID
BEGIN
	IF EXISTS(SELECT 1 FROM PageContext WHERE PageContextID=@MinPageContextID and PageID=@PageID)
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM PageContextActionMapping WHERE PageContextID=@MinPageContextID AND RoleID=@RoleID AND ActionTypeID=@ActionTypeID AND ContextType=@ContextType)
				BEGIN	
					INSERT INTO PageContextActionMapping(PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Description)
					SELECT @MinPageContextID,@RoleID,@ActionTypeID,@TemplateID,@ContextType,'Report','Y',NULL
				END
		END
	SET @MinPageContextID = @MinPageContextID+1
END
/************FOR CLIENT EMAIL End*****************/

/**************************FOR CLIENT END***************************************************************************************************************/


/******************END CONFIGURE FOR Dispatch Controller ROLE******************/


/*******************************************************ADDED BY PRABAKAR FOR Config LEVEL ONLINE PORTAL***************25/09/2013******/

DECLARE @ConfigKeyID int
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='SummaryPortal')
BEGIN
SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal) VALUES(@ConfigKeyID,'SummaryPortal','Do you want to use SummaryPortal','N')

INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@ConfigKeyID,'N',67)
END
/*****END BY PRABAKAR******/


/*************** Added by Murali for Capturing Clients Receipt Number******/

DECLARE @ConfigKeyID int
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ApprovalNo')
BEGIN
SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal) 
VALUES
(@ConfigKeyID,'ApprovalNo','Do you need to capture clients Receipt bill number?','Y')

INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@ConfigKeyID,'Y',67)
END

/**********End ***********/



------Script added for config based week default search------

DECLARE @ConfikeyID int
SELECT @ConfikeyID = MAX(ConfigkeyID) From ConfigKeyMaster 
IF NOT EXISTS(Select * from ConfigKeyMaster where ConfigKey='SetWeekAsDefaultSearch') 
BEGIN
INSERT INTO ConfigKeyMaster(ConfigkeyID,ConfigKey,DisplayText,IsInternal)
VALUES(@ConfikeyID,'ReportDefaultSearchCriteria','Do You need to set week as default search','Y')

INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@ConfiKeyID,'Y',67)
END
----------------------------------------


/*************** Added by prabakar for CommonValidation in  EnterResult ******/

DECLARE @ConfigKeyID int
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='EnterResultCommonValidation')
BEGIN
SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal) 
VALUES
(@ConfigKeyID,'EnterResultCommonValidation','EnterResultCommonValidation','Y')

INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@ConfigKeyID,'Y',67)
END

/**********End ***********/


/*************** Added by Arivalagan KK for TRF Old Uploaded File Path ******/
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='OLD_TRF_UploadPath')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	VALUES
	(@ConfigKeyID,'OLD_TRF_UploadPath','Enter TRF Image Upload Path','Y','TEXT','String','HOS','N' )

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
	SELECT @MinOrgID= MIN(OrgID) from Organization
	SELECT @MaxOrgID= MAX(OrgID) from Organization  
	WHILE @MinOrgID <= @MaxOrgID
	BEGIN
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
		SELECT 	@ConfigKeyID,'Z:\\ATTUNE_OLD_TRF_UPLOAD_FILES\\',@MinOrgID,NULL	,GETDATE(),	3248,GETDATE(),	NULL
		SET @MinOrgID = @MinOrgID+1
	END										
END

IF NOT EXISTS(SELECT 1 FROM configorgmaster WHERE ConfigValue='Z:\\ATTUNE_UPLOAD_FILES\\')
BEGIN
	SELECT @MinOrgID= MIN(OrgID) from Organization
	SELECT @MaxOrgID= MAX(OrgID) from Organization  
	WHILE @MinOrgID <= @MaxOrgID
	BEGIN
	--select *
	 Update Com set ConfigValue ='Z:\\ATTUNE_UPLOAD_FILES\\'
	 from configorgmaster Com  where configkeyid=44 and orgid=@MinOrgID
		SET @MinOrgID = @MinOrgID+1
	END
END

/**********End ***********/


DECLARE @ConfigKeyID int
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='DisplayServiceTax')
BEGIN
SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal) 
VALUES
(@ConfigKeyID,'DisplayServiceTax','Do you want DisplayServiceTax in BillReceipt?','Y')

INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@ConfigKeyID,'N',94)
END

/********************************************************************/

IF NOT EXISTS( SELECT 1 FROM CONFIGKEYMASTER WHERE CONFIGKEY='RerunRecollect')
BEGIN
INSERT INTO CONFIGKEYMASTER(Configkeyid,configkey,DisplayText,isinternal)
select max(configkeyid)+1,'RerunRecollect','Do you want Reason for Recollect?','Y' from CONFIGKEYMASTER 
END

declare @OrgID int=67
IF NOT EXISTS(SELECT 1 FROM CONFIGORGMASTER WHERE CONFIGKEYID=(select CONFIGKEYID from 
CONFIGKEYMASTER where CONFIGKEY='RerunRecollect') and OrgID=@OrgID)
BEGIN
insert into configorgmaster(Configkeyid,configvalue,Orgid)
select configkeyid,'Y',@OrgID from cONFIGKEYMASTER WHERE CONFIGKEY='RerunRecollect'

END



IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='DisableApprovalSaveContinueButton')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'DisableApprovalSaveContinueButton','DisableApprovalSaveContinueButton','Y','TEXT','String','HOS','N' 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
	SELECT @MinOrgID= MIN(OrgID) from Organization
	SELECT @MaxOrgID= MAX(OrgID) from Organization  
	WHILE @MinOrgID <= @MaxOrgID
	BEGIN
		INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
		SELECT 	@ConfigKeyID,'N',@MinOrgID,13676,GETDATE(),	13676,GETDATE(),	NULL
		SET @MinOrgID = @MinOrgID+1
	END											
END

/**********End ***********/


IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='HealthCardOTP')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'HealthCardOTP','Do you want activate OTP for HealthCard','Y','','',NULL,NULL 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'Y',68,NULL,GETDATE(),	NULL,GETDATE(),	NULL
	SET @MinOrgID = @MinOrgID+1
										
END


IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='HealthcardCoupon')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'HealthcardCoupon','HealthcardCoupon','Y','','',NULL,NULL 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'Y',70,NULL,GETDATE(),	NULL,GETDATE(),	NULL
											
END

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='MyCardActiveDays')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'MyCardActiveDays','MyCardActiveDays','Y','','',NULL,NULL 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'90',70,NULL,GETDATE(),	NULL,GETDATE(),	NULL
											
END

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowAttributes')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'ShowAttributes','Do You Want To Display Additional Attributes','Y','','',NULL,NULL 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'Y',70,NULL,GETDATE(),	NULL,GETDATE(),	NULL
											
END

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='RedeemPointsRatio')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'RedeemPointsRatio','RedeemPointsRatio','Y','','',NULL,NULL 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'1:1',70,NULL,GETDATE(),	NULL,GETDATE(),	NULL
											
END
/**********End ***********/

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='HasMyCard')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'HasMyCard','HasMyCard','Y','','',NULL,NULL 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'Y',68,NULL,GETDATE(),	NULL,GETDATE(),	NULL
											
END
/**********End ***********/

/*For  SSRS Bill receipt configuration */

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='B2CSSRSFILLFORMAT')
BEGIN
	DECLARE @ConfigKeyID int
	SELECT @ConfigKeyID= MAX(ConfigKeyID)+1 from ConfigKeyMaster
	INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType,ConfigType,IsAddressBased) 
	SELECT @ConfigKeyID,'B2CSSRSFILLFORMAT','B2CSSRSFILLFORMAT','Y','','',NULL,NULL 

	DECLARE @MinOrgID int
	DECLARE @MaxOrgID int
 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'Y',68,NULL,GETDATE(),	NULL,GETDATE(),	NULL
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgAddressId)
	SELECT 	@ConfigKeyID,'Y',70,NULL,GETDATE(),	NULL,GETDATE(),	NULL										
END

/****************Added  By Arivalagan.kk*******************/
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='DueBillreport')
BEGIN

INSERT INTO dbo.ConfigKeyMaster
(
    dbo.ConfigKeyMaster.ConfigKeyID,
    dbo.ConfigKeyMaster.ConfigKey,
    dbo.ConfigKeyMaster.DisplayText,
    dbo.ConfigKeyMaster.IsInternal,
    dbo.ConfigKeyMaster.ControlType,
    dbo.ConfigKeyMaster.ValueType,
    dbo.ConfigKeyMaster.ConfigType,
    dbo.ConfigKeyMaster.IsAddressBased
)
VALUES
(
    (SELECT max(ckm.ConfigKeyID)+1 FROM dbo.ConfigKeyMaster ckm), -- ConfigKeyID - bigint
    'DueBillreport', -- ConfigKey - varchar
    'DueBillreport', -- DisplayText - varchar
    'Y', -- IsInternal - char
    NULL, -- ControlType - varchar
    NULL, -- ValueType - varchar
    NULL, -- ConfigType - varchar
    NULL -- IsAddressBased - char
)


INSERT INTO dbo.ConfigOrgMaster
(
    --ConfigID - this column value is auto-generated
    dbo.ConfigOrgMaster.ConfigKeyID,
    dbo.ConfigOrgMaster.ConfigValue,
    dbo.ConfigOrgMaster.OrgID,
    dbo.ConfigOrgMaster.CreatedBy,
    dbo.ConfigOrgMaster.CreatedAt,
    dbo.ConfigOrgMaster.ModifiedBy,
    dbo.ConfigOrgMaster.ModifiedAt,
    dbo.ConfigOrgMaster.OrgAddressId
)
VALUES
(
    -- ConfigID - bigint
    (SELECT max(ckm.ConfigKeyID) FROM dbo.ConfigKeyMaster ckm), -- ConfigKeyID - bigint
    'Y', -- ConfigValue - varchar
    67, -- OrgID - int
    0, -- CreatedBy - bigint
    GETDATE(), -- CreatedAt - datetime
   0, -- ModifiedBy - bigint
    GETDATE(), -- ModifiedAt - datetime
    0 -- OrgAddressId - bigint
)
END
/****************Added  By Arivalagan.kk*******************/

---Deployablity : ManageRates(Copyrate)
---Config Script for "RateDocumentUpload" 
Declare @OrgID int
Declare @ConfigKeyID Bigint
Select @OrgID = OrgID from Organization where Name='Metropolis Vidyavihar'
If (Select MAX(ConfigKeyID) FROM ConfigKeyMaster) IS NULL
	BEGIN
		SET @ConfigKeyID = 0
	END
ELSE
	Select @ConfigKeyID = MAX(ConfigKeyID)+1 FROM ConfigKeyMaster

IF NOT EXISTS(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='RateDocumentUpload')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT @ConfigKeyID,'RateDocumentUpload','Rate Document Upload Details','Y'
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='RateDocumentUpload' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='RateDocumentUpload'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt)
	SELECT @ConfigKeyID,'F:\UploadFileSample',@OrgID,236,GETDATE()
END
/****************Added  By Arivalagan.kk*******************/
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedAberrantQ')
BEGIN
INSERT INTO dbo.ConfigKeyMaster
(
    dbo.ConfigKeyMaster.ConfigKeyID,
    dbo.ConfigKeyMaster.ConfigKey,
    dbo.ConfigKeyMaster.DisplayText,
    dbo.ConfigKeyMaster.IsInternal,
    dbo.ConfigKeyMaster.ControlType,
    dbo.ConfigKeyMaster.ValueType,
    dbo.ConfigKeyMaster.ConfigType,
    dbo.ConfigKeyMaster.IsAddressBased
)
SELECT
    (SELECT max(ckm.ConfigKeyID)+1 FROM dbo.ConfigKeyMaster ckm) , -- ConfigKeyID - bigint
    'NeedAberrantQ', -- ConfigKey - varchar
    'Do You Want to HideShowAberrantQ', -- DisplayText - varchar
    'N', -- IsInternal - char
    'RDO', -- ControlType - varchar
    'String', -- ValueType - varchar
    'HOS', -- ConfigType - varchar
    NULL -- IsAddressBased - char
    
    INSERT INTO dbo.ConfigOrgMaster
    (
        --ConfigID - this column value is auto-generated
        dbo.ConfigOrgMaster.ConfigKeyID,
        dbo.ConfigOrgMaster.ConfigValue,
        dbo.ConfigOrgMaster.OrgID,
        dbo.ConfigOrgMaster.CreatedBy,
        dbo.ConfigOrgMaster.CreatedAt,
        dbo.ConfigOrgMaster.ModifiedBy,
        dbo.ConfigOrgMaster.ModifiedAt,
        dbo.ConfigOrgMaster.OrgAddressId
    )
   SELECT  -- ConfigID - bigint
        (SELECT max(ckm.ConfigKeyID) FROM dbo.ConfigKeyMaster ckm), -- ConfigKeyID - bigint
        'Y', -- ConfigValue - varchar
        70, -- OrgID - int
        NULL, -- CreatedBy - bigint
        NULL, -- CreatedAt - datetime
        NULL, -- ModifiedBy - bigint
        NULL, -- ModifiedAt - datetime
        NULL -- OrgAddressId - bigint
END


IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='DueBillShowHide')
BEGIN	
SELECT max(ConfigKeyID)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
VALUES((SELECT max(ConfigKeyID)+1 from ConfigKeyMaster),'DueBillShowHide','Do you want Hide Due  bill alert','N')
END

IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='DueBillShowHide' AND COM.OrgID=68)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
VALUES((SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='DueBillShowHide'),'Y',68,GETDATE())
END
	

IF EXISTS (SELECT 1 
FROM dbo.ConfigKeyMaster ckm 
INNER JOIN dbo.ConfigOrgMaster com ON com.ConfigKeyID = ckm.ConfigKeyID
WHERE  ckm.ConfigKey ='DecimalAge' AND  com.OrgID=98)
BEGIN
--SELECT * 
UPDATE com SET com.ConfigValue='N'
FROM dbo.ConfigKeyMaster ckm 
INNER JOIN dbo.ConfigOrgMaster com ON com.ConfigKeyID = ckm.ConfigKeyID
WHERE  ckm.ConfigKey ='DecimalAge' AND  com.OrgID=98
END


/****************END Added  By Arivalagan.kk*******************/
------------------------------Karkuzhali----------------------------------
Declare @OrgID int
Declare @ConfigKeyID Bigint
Select @OrgID = 81
If (Select MAX(ConfigKeyID) FROM ConfigKeyMaster) IS NULL
	BEGIN
		SET @ConfigKeyID = 0
	END
ELSE
	Select @ConfigKeyID = MAX(ConfigKeyID)+1 FROM ConfigKeyMaster

IF NOT EXISTS(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='DisableDiscount')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT @ConfigKeyID,'DisableDiscount','DisableDiscount','Y'
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='DisableDiscount' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='DisableDiscount'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedAt)
	SELECT @ConfigKeyID,'Y',@OrgID,GETDATE()
END



Declare @OrgID int
Declare @ConfigKeyID Bigint
Select @OrgID = 81
If (Select MAX(ConfigKeyID) FROM ConfigKeyMaster) IS NULL
	BEGIN
		SET @ConfigKeyID = 0
	END
ELSE
	Select @ConfigKeyID = MAX(ConfigKeyID)+1 FROM ConfigKeyMaster

IF NOT EXISTS(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsPhleboNameMandatory')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT @ConfigKeyID,'IsPhleboNameMandatory','IsPhleboNameMandatory','Y'
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='IsPhleboNameMandatory' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='IsPhleboNameMandatory'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedAt)
	SELECT @ConfigKeyID,'Y',@OrgID,GETDATE()
END
------------------------------End------------------------------------------

/*******************Added for Assession officer role with investigation search********/

declare @Roleid1 bigint
declare @Menuid bigint

select  @Roleid1=roleid from Role where RoleName='LabReception' and OrgID=68
select @Menuid=MenuID from MenuMaster where DisplayText='Investigation Search' and OrgId=68 and PageID=454

if not exists(select 1 from RoleMenu where RoleID=@Roleid1 and MenuID=@Menuid)
begin
  insert into RoleMenu(RoleID,MenuID,IsMapped)
  select @Roleid1,@Menuid,'Y'
end

/*******************Added for Assession officer role with investigation search********/

/*******************Added By Arivalagan For  Billing details Display TCode********/
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='DisplayTextTestName' AND COM.OrgID=69)
BEGIN
INSERT INTO dbo.ConfigKeyMaster
(
    dbo.ConfigKeyMaster.ConfigKeyID,
    dbo.ConfigKeyMaster.ConfigKey,
    dbo.ConfigKeyMaster.DisplayText,
    dbo.ConfigKeyMaster.IsInternal
)
SELECT 
(SELECT max(ckm.ConfigKeyID)+1 FROM dbo.ConfigKeyMaster ckm), -- ConfigKeyID - bigint
'DisplayTextTestName', -- ConfigKey - varchar
'Do you want display TestCode', -- DisplayText - varchar
'Y' -- IsInternal - char
  
INSERT INTO dbo.ConfigOrgMaster
(
--ConfigID - this column value is auto-generated
dbo.ConfigOrgMaster.ConfigKeyID,
dbo.ConfigOrgMaster.ConfigValue,
dbo.ConfigOrgMaster.OrgID
)
SELECT
-- ConfigID - bigint
(SELECT ckm.ConfigKeyID FROM dbo.ConfigKeyMaster ckm WHERE ckm.ConfigKey='DisplayTextTestName'), -- ConfigKeyID - bigint
'Y', -- ConfigValue - varchar
69 -- OrgID - int

END
/*******************End Added By Arivalagan For  Billing details Display TCode********/
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='JqueryDataTable' AND COM.OrgID=69)
BEGIN
INSERT INTO dbo.ConfigKeyMaster
(
    dbo.ConfigKeyMaster.ConfigKeyID,
    dbo.ConfigKeyMaster.ConfigKey,
    dbo.ConfigKeyMaster.DisplayText,
    dbo.ConfigKeyMaster.IsInternal
)
SELECT 
(SELECT max(ckm.ConfigKeyID)+1 FROM dbo.ConfigKeyMaster ckm), -- ConfigKeyID - bigint
'JqueryDataTable', -- ConfigKey - varchar
'Do you want Jquery Data Table', -- DisplayText - varchar
'Y' -- IsInternal - char
  
  
INSERT INTO dbo.ConfigOrgMaster
(
--ConfigID - this column value is auto-generated
dbo.ConfigOrgMaster.ConfigKeyID,
dbo.ConfigOrgMaster.ConfigValue,
dbo.ConfigOrgMaster.OrgID
)
SELECT
-- ConfigID - bigint
(SELECT ckm.ConfigKeyID FROM dbo.ConfigKeyMaster ckm WHERE ckm.ConfigKey='JqueryDataTable'), -- ConfigKeyID - bigint
'Y', -- ConfigValue - varchar
69 -- OrgID - int
END


IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='BlankPageReport' AND COM.OrgID=98)
BEGIN
INSERT INTO dbo.ConfigKeyMaster
(
    dbo.ConfigKeyMaster.ConfigKeyID,
    dbo.ConfigKeyMaster.ConfigKey,
    dbo.ConfigKeyMaster.DisplayText,
    dbo.ConfigKeyMaster.IsInternal
)
SELECT 
(SELECT max(ckm.ConfigKeyID)+1 FROM dbo.ConfigKeyMaster ckm), -- ConfigKeyID - bigint
'BlankPageReport', -- ConfigKey - varchar
'Do you want display the  blank page report', -- DisplayText - varchar
'Y' -- IsInternal - char
  
  
INSERT INTO dbo.ConfigOrgMaster
(
--ConfigID - this column value is auto-generated
dbo.ConfigOrgMaster.ConfigKeyID,
dbo.ConfigOrgMaster.ConfigValue,
dbo.ConfigOrgMaster.OrgID
)
SELECT
-- ConfigID - bigint
(SELECT ckm.ConfigKeyID FROM dbo.ConfigKeyMaster ckm WHERE ckm.ConfigKey='BlankPageReport'), -- ConfigKeyID - bigint
'Y', -- ConfigValue - varchar
98 -- OrgID - int
INSERT INTO dbo.ConfigOrgMaster
(
--ConfigID - this column value is auto-generated
dbo.ConfigOrgMaster.ConfigKeyID,
dbo.ConfigOrgMaster.ConfigValue,
dbo.ConfigOrgMaster.OrgID
)
SELECT
-- ConfigID - bigint
(SELECT ckm.ConfigKeyID FROM dbo.ConfigKeyMaster ckm WHERE ckm.ConfigKey='BlankPageReport'), -- ConfigKeyID - bigint
'Y', -- ConfigValue - varchar
81 -- OrgID - int

END


IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='IsNeedTimedData' AND COM.OrgID=81)
BEGIN
INSERT INTO dbo.ConfigKeyMaster
(
    dbo.ConfigKeyMaster.ConfigKeyID,
    dbo.ConfigKeyMaster.ConfigKey,
    dbo.ConfigKeyMaster.DisplayText,
    dbo.ConfigKeyMaster.IsInternal
)
SELECT 
(SELECT max(ckm.ConfigKeyID)+1 FROM dbo.ConfigKeyMaster ckm), -- ConfigKeyID - bigint
'IsNeedTimedData', -- ConfigKey - varchar
'Do you want display the After 24 Timed Data', -- DisplayText - varchar
'Y' -- IsInternal - char
INSERT INTO dbo.ConfigOrgMaster
(
--ConfigID - this column value is auto-generated
dbo.ConfigOrgMaster.ConfigKeyID,
dbo.ConfigOrgMaster.ConfigValue,
dbo.ConfigOrgMaster.OrgID
)
SELECT
-- ConfigID - bigint
(SELECT ckm.ConfigKeyID FROM dbo.ConfigKeyMaster ckm WHERE ckm.ConfigKey='IsNeedTimedData'), -- ConfigKeyID - bigint
'Y', -- ConfigValue - varchar
81 -- OrgID - int  
END

-------------Vijayalakshmi.M------------------------------------//
DECLARE @ConfigKeyID BIGINT
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=69)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='IsStatusPending/Validate')
				BEGIN	
					SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'IsStatusPending/Validate','Is Needed Sample Status Pending/Validate?','Y','')
				END
			SELECT @ConfigKeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsStatusPending/Validate'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='IsStatusPending/Validate' AND COM.OrgID=69)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',69,GETDATE())
				END
		END
END

DECLARE @ConfigKeyID1 BIGINT
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=69)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='IsNeedJqueryTask')
				BEGIN	
					SELECT @ConfigKeyID1= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID1,'IsNeedJqueryTask','Is Needed Jquery Grid/ASP Grid','Y','')
				END
			SELECT @ConfigKeyID1= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsNeedJqueryTask'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='IsNeedJqueryTask' AND COM.OrgID=69)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID1,'Y',69,GETDATE())
				END
		END
END

------------------------------END------------------------------------------------------------//
/*******************Added By Arivalagan For  Billing details Display TCode********/
DECLARE @KeyID BIGINT
--Set the orgid to @MinValue
DECLARE @MinValue BIGINT 
DECLARE @MaxValue BIGINT 
SELECT @MinValue= MIN(OrgID) FROM Organization
SELECT @MaxValue= MAX(OrgID) FROM Organization
WHILE @MinValue <= @MaxValue
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='NeedHeaderInIPR')
				BEGIN	
					SELECT @KeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO dbo.ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
					SELECT @KeyID, 'NeedHeaderInIPR','Do you Receipt Header','Y' -- IsInternal - char				 
				END
			SELECT @KeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedHeaderInIPR'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM dbo.ConfigOrgMaster com 
			INNER JOIN dbo.ConfigKeyMaster ckm ON CKM.ConfigKeyID=COM.ConfigKeyID 
			WHERE CKM.ConfigKey='NeedHeaderInIPR' AND COM.OrgID=@MinValue)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@KeyID,'Y',@MinValue,GETDATE())
				END
		END
	SET @MinValue = @MinValue+1
END
------------------------------END------------------------------------------------//
-----------------------------------------Vijayalakshmi--------------------------
--Note: Need to run for LISProductDB alone.
DECLARE @ConfigKeyID BIGINT
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=67)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='IsAllowZeroAmount')
				BEGIN	
					SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'IsAllowZeroAmount','IsAllow to add ZeroAmount','Y','')
				END
			SELECT @ConfigKeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsAllowZeroAmount'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='IsAllowZeroAmount' AND COM.OrgID=67)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',67,GETDATE())
				END
		END
END

------------------------------------------End------------------------------------
------------------------------------------Karthick------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT OrgID from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =OrgID FROM Organization WHERE OrgID=@MinValue

If not exists(select 1 from ConfigKeyMaster where ConfigKey='INV_Status_Check')
begin
insert into ConfigKeyMaster (configkeyid,ConfigKey ,DisplayText ,IsInternal )
Select @ConfigKeyId+1,'INV_Status_Check','Need to change invstatus?','N'
end

select @SConfigKeyID=configkeyid from ConfigkeyMaster where configkey='INV_Status_Check'

If not exists(select 1 from ConfigOrgMaster where ConfigKeyID =@SConfigKeyID and OrgID =@Orgid )
begin
insert into ConfigOrgMaster(configkeyid,configvalue,orgid)
Select @SConfigKeyID ,'Y',@Orgid
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO 
------------------------------------------------------------------------------------------------

/*******************Added By sathish For  hide the columns in userwise collection report********/

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='UserWiseReportHide')
BEGIN	
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
VALUES((SELECT max(ConfigKeyID)+1 from ConfigKeyMaster),'UserWiseReportHide','Do you want Hide Report','N')
END

IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='UserWiseReportHide' AND COM.OrgID=99)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
VALUES((SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='UserWiseReportHide'),'Y',99,GETDATE())
END

/*******************END************************************************************************/

/*******************Added By Karthick For  logoRight side********/

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='logoRight')
BEGIN	
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
VALUES((SELECT max(ConfigKeyID)+1 from ConfigKeyMaster),'logoRight','Do u want logo(Anjana billprint) on rightside??','N')
END

IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='logoRight' AND COM.OrgID=109)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
VALUES((SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='logoRight'),'Y',109,GETDATE())
END

/*******************Added By Karthick For  logoRight side********/


--------------------Added by Thillai kapil.T-------------------------------------
DECLARE @ConfigKeyID BIGINT
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=109)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='B2C_Hide_Billingparts')
				BEGIN	
					SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'B2C_Hide_Billingparts','B2C_Hide_Billingparts','Y','')
				END
			SELECT @ConfigKeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='B2C_Hide_Billingparts'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='B2C_Hide_Billingparts' AND COM.OrgID=109)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',109,GETDATE())
				END
		END
END
--------------------End by Thillai kapil.T-------------------------------------



/********************Added By Karthick For  BIlledbySign side********/

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='BIlledbySign')
BEGIN	
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
VALUES((SELECT max(ConfigKeyID)+1 from ConfigKeyMaster),'BIlledbySign','is billed by show default Admin','N')
END

IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='BIlledbySign' AND COM.OrgID=110)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
VALUES((SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='BIlledbySign'),'Y',110,GETDATE())
END


/********************Added By Karthick For  BIlledbySign side********/

-------------------Added By Sree krishna For No. of digits in Mobile number---------------------
Declare @OrgID int
set @OrgID=69 
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='MobilenumberLength')
BEGIN	
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
VALUES((SELECT max(ConfigKeyID)+1 from ConfigKeyMaster),'MobilenumberLength','Mobile Length Setting','N')
END

IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='MobilenumberLength' AND COM.OrgID=@OrgID)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
VALUES((SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='MobilenumberLength'),'N',@OrgID,GETDATE())
END
  
  
--------------------------------End By Sree Krishna--------------------------------------------

--------------------------------Added By Arivalagan.K--------------------------------------------

DECLARE @KeyID BIGINT
--Set the orgid to @MinValue
DECLARE @MinValue BIGINT 
DECLARE @MaxValue BIGINT 
SELECT @MinValue= MIN(OrgID) FROM Organization
SELECT @MaxValue= MAX(OrgID) FROM Organization
WHILE @MinValue <= @MaxValue
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='communicationTAB_hide')
				BEGIN	
					SELECT @KeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO dbo.ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
					SELECT @KeyID, 'communicationTAB_hide','Do you Hide the communication TAB','Y' -- IsInternal - char				 
				END
			SELECT @KeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='communicationTAB_hide'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM dbo.ConfigOrgMaster com 
			INNER JOIN dbo.ConfigKeyMaster ckm ON CKM.ConfigKeyID=COM.ConfigKeyID 
			WHERE CKM.ConfigKey='communicationTAB_hide' AND COM.OrgID=@MinValue)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@KeyID,'Y',@MinValue,GETDATE())
				END
		END
	SET @MinValue = @MinValue+1
END
--------------------------------End Added By Arivalagan.K--------------------------------------------
----------------------------Vijayalakshmi.M for Hl7 Integration---------------------------------------
declare @SConfigKeyID varchar(30)
declare @orgid bigint
set @orgid =69
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster

If not exists(select 1 from ConfigKeyMaster where ConfigKey='HL7OutBoundMessage')
begin
insert into ConfigKeyMaster (configkeyid,ConfigKey ,DisplayText ,IsInternal )
values(@ConfigKeyId+1,'HL7OutBoundMessage','Is Needed HL7OutBoundMessage?','Y')
end

select @SConfigKeyID=configkeyid from ConfigkeyMaster where configkey='HL7OutBoundMessage'

If not exists(select 1 from ConfigOrgMaster where ConfigKeyID =@SConfigKeyID and OrgID =@Orgid and configvalue='Y' )
begin
insert into ConfigOrgMaster(configkeyid,configvalue,orgid)
values(@SConfigKeyID ,'Y',@Orgid)
end

declare @SConfigKeyID varchar(30)
declare @orgid bigint
set @orgid =69
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster

If not exists(select 1 from ConfigKeyMaster where ConfigKey='StatusBasedHL7OutBoundMessage')
begin
insert into ConfigKeyMaster (configkeyid,ConfigKey ,DisplayText ,IsInternal )
values(@ConfigKeyId+1,'StatusBasedHL7OutBoundMessage','Is Needed HL7OutBoundMessage for SampleReceived?','Y')
end

select @SConfigKeyID=configkeyid from ConfigkeyMaster where configkey='StatusBasedHL7OutBoundMessage'

If not exists(select 1 from ConfigOrgMaster where ConfigKeyID =@SConfigKeyID and OrgID =@Orgid and configvalue='N' )
begin
insert into ConfigOrgMaster(configkeyid,configvalue,orgid)
values(@SConfigKeyID ,'N',@Orgid)
end

declare @SConfigKeyID varchar(30)
declare @orgid bigint
set @orgid =69
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster

If not exists(select 1 from ConfigKeyMaster where ConfigKey='Need Utf-8/Utf-16 encoding')
begin
insert into ConfigKeyMaster (configkeyid,ConfigKey ,DisplayText ,IsInternal )
values(@ConfigKeyId+1,'Need Utf-8/Utf-16 encoding','Is Need Utf-8/Utf-16 encoding?','Y')
end

select @SConfigKeyID=configkeyid from ConfigkeyMaster where configkey='Need Utf-8/Utf-16 encoding'

If not exists(select 1 from ConfigOrgMaster where ConfigKeyID =@SConfigKeyID and OrgID =@Orgid and configvalue='Utf-8' )
begin
insert into ConfigOrgMaster(configkeyid,configvalue,orgid)
values(@SConfigKeyID ,'utf-8',@Orgid)
end

declare @SConfigKeyID varchar(30)
declare @orgid bigint
set @orgid =98
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster

If not exists(select 1 from ConfigKeyMaster where ConfigKey='BookingID/TokenID')
begin
insert into ConfigKeyMaster (configkeyid,ConfigKey ,DisplayText ,IsInternal )
values(@ConfigKeyId+1,'BookingID/TokenID','Is Needed BookingID/TokenID search in billing','Y')
end

select @SConfigKeyID=configkeyid from ConfigkeyMaster where configkey='BookingID/TokenID'

If not exists(select 1 from ConfigOrgMaster where ConfigKeyID =@SConfigKeyID and OrgID =@Orgid and configvalue='N' )
begin
insert into ConfigOrgMaster(configkeyid,configvalue,orgid)
values(@SConfigKeyID ,'Y',@Orgid)
end

--------------------------------------------------------------------------------------------------------------------------


DECLARE @KeyID BIGINT
--Set the orgid to @MinValue
DECLARE @MinValue BIGINT 
DECLARE @MaxValue BIGINT 
SELECT @MinValue= MIN(OrgID) FROM Organization
SELECT @MaxValue= MAX(OrgID) FROM Organization
WHILE @MinValue <= @MaxValue
BEGIN
	IF EXISTS(SELECT OrganizationID FROM Organization WHERE OrgID=@MinValue)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='ExternalVisitBarcodeImg')
				BEGIN	
					SELECT @KeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO dbo.ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
					SELECT @KeyID, 'ExternalVisitBarcodeImg','Do you External Visit Barcode Img','Y' -- IsInternal - char				 
				END
			SELECT @KeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='ExternalVisitBarcodeImg'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM dbo.ConfigOrgMaster com 
			INNER JOIN dbo.ConfigKeyMaster ckm ON CKM.ConfigKeyID=COM.ConfigKeyID 
			WHERE CKM.ConfigKey='ExternalVisitBarcodeImg' AND COM.OrgID=@MinValue)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@KeyID,'N',@MinValue,GETDATE())
				END
		END
	SET @MinValue = @MinValue+1
END


DECLARE @KeyID BIGINT
--Set the orgid to @MinValue
DECLARE @MinValue BIGINT 
DECLARE @MaxValue BIGINT 
SELECT @MinValue= MIN(OrgID) FROM Organization
SELECT @MaxValue= MAX(OrgID) FROM Organization
WHILE @MinValue <= @MaxValue
BEGIN
	IF EXISTS(SELECT OrganizationID FROM Organization WHERE OrgID=@MinValue)
		BEGIN
			IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='DofromVisitfreeze')
				BEGIN	
					SELECT @KeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
					INSERT INTO dbo.ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
					SELECT @KeyID, 'DofromVisitfreeze','Do you want Do from Visit freeze ','Y' -- IsInternal - char				 
				END
			SELECT @KeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='DofromVisitfreeze'
			IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM dbo.ConfigOrgMaster com 
			INNER JOIN dbo.ConfigKeyMaster ckm ON CKM.ConfigKeyID=COM.ConfigKeyID 
			WHERE CKM.ConfigKey='DofromVisitfreeze' AND COM.OrgID=@MinValue)
				BEGIN
					INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@KeyID,'Y',@MinValue,GETDATE())
				END
		END
	SET @MinValue = @MinValue+1
END
---------------------------------------------------------------------------------------------------------------------------
-------------------------------------------Karkuzhali---------------------------------------------------------------
Declare @OrgID int
set @OrgID=98
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='DeptwiseLoginRole')
BEGIN	
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
VALUES((SELECT max(ConfigKeyID)+1 from ConfigKeyMaster),'DeptwiseLoginRole','DeptwiseLoginRole','N')
END

IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='DeptwiseLoginRole' AND COM.OrgID=@OrgID)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
VALUES((SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='DeptwiseLoginRole'),'Y',@OrgID,GETDATE())
END
----------------------------------------------End--------------------------------------------------------------------------


DECLARE @configkeyid BIGINT
SET @configkeyid= (select max(ConfigKeyID+1) FROM configkeymaster)

IF  NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedClientLogo')
BEGIN

INSERT INTO dbo.ConfigKeyMaster        
VALUES  (@configkeyid , -- ConfigKeyID - bigint
         N'NeedClientLogo' , -- ConfigKey - nvarchar(50)
         N'Do you want NeedClientLogo' , -- DisplayText - nvarchar(max)
         N'N' , -- IsInternal - nchar(1)
         NULL,NULL,NULL,NULL
        )
INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  77 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  80 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  159 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  161 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  162 ,  NULL , NULL,NULL,NULL,NULL )
 
END
---------------------Config for MRP Bill--------------------------


SET @configkeyid= (select max(ConfigKeyID+1) FROM configkeymaster)

IF  NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='Dummybill')
BEGIN

INSERT INTO dbo.ConfigKeyMaster        
VALUES  (@configkeyid , -- ConfigKeyID - bigint
         N'Dummybill' , -- ConfigKey - nvarchar(50)
         N'Do you want Dummybill' , -- DisplayText - nvarchar(max)
         N'N' , -- IsInternal - nchar(1)
         NULL,NULL,NULL,NULL
        )
INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  77 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  80 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  159 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  161 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  162 ,  NULL , NULL,NULL,NULL,NULL )
 
END
----------------------------------------------


SET @configkeyid= (select max(ConfigKeyID+1) FROM configkeymaster)

IF  NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsPatientLogin')
BEGIN


INSERT INTO dbo.ConfigKeyMaster        
VALUES  (@configkeyid , -- ConfigKeyID - bigint
         N'IsPatientLogin' , -- ConfigKey - nvarchar(50)
         N'Do you want IsPatientLogin' , -- DisplayText - nvarchar(max)
         N'N' , -- IsInternal - nchar(1)
         NULL,NULL,NULL,NULL
        )
INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  77 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  80 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  159 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  161 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  162 ,  NULL , NULL,NULL,NULL,NULL )
 
END
-----------------------------------------Zero Billing-------------------

SET @configkeyid= (select max(ConfigKeyID+1) FROM configkeymaster)

IF  NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsZeroAmountTest')
BEGIN


INSERT INTO dbo.ConfigKeyMaster        
VALUES  (@configkeyid , -- ConfigKeyID - bigint
         N'IsZeroAmountTest' , -- ConfigKey - nvarchar(50)
         N'Do you want IsZeroAmountTest' , -- DisplayText - nvarchar(max)
         N'N' , -- IsInternal - nchar(1)
         NULL,NULL,NULL,NULL
        )
INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  77 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  80 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  159 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  161 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  162 ,  NULL , NULL,NULL,NULL,NULL )
 
END


------------------------Config for hyphenvalidation --------------------

SET @configkeyid= (select max(ConfigKeyID+1) FROM configkeymaster)

IF  NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='hyphenvalidation')
BEGIN


INSERT INTO dbo.ConfigKeyMaster        
VALUES  (@configkeyid , -- ConfigKeyID - bigint
         N'hyphenvalidation' , -- ConfigKey - nvarchar(50)
         N'Do you want hyphenvalidation' , -- DisplayText - nvarchar(max)
         N'N' , -- IsInternal - nchar(1)
         NULL,NULL,NULL,NULL
        )
INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  77 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  80 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  159 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  161 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  162 ,  NULL , NULL,NULL,NULL,NULL )
 
END
go 


DECLARE @configkeyid BIGINT
SET @configkeyid= (select max(ConfigKeyID+1) FROM configkeymaster)

IF  NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='Disableapprovaltask')
BEGIN

--SELECT @configkeyid
INSERT INTO dbo.ConfigKeyMaster        
VALUES  (@configkeyid , -- ConfigKeyID - bigint
         N'Disableapprovaltask' , -- ConfigKey - nvarchar(50)
         N'Do you want to hide approval task for the org' , -- DisplayText - nvarchar(max)
         N'N' , -- IsInternal - nchar(1)
         NULL,NULL,NULL,NULL
        )
INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  77 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  80 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  159 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  161 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  162 ,  NULL , NULL,NULL,NULL,NULL )
 
END
--------------------------------------------------Karkuzhali(Master based Functionality need for Sample Transfer and Sample Receive)------------------------------------------
Declare @OrgID int
Declare @ConfigKeyID Bigint
Select @OrgID = 98
If (Select MAX(ConfigKeyID) FROM ConfigKeyMaster) IS NULL
	BEGIN
		SET @ConfigKeyID = 0
	END
ELSE
	Select @ConfigKeyID = MAX(ConfigKeyID)+1 FROM ConfigKeyMaster

IF NOT EXISTS(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='TransferEnable')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT @ConfigKeyID,'TransferEnable','Y','N'
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='TransferEnable' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='TransferEnable'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedAt)
	SELECT @ConfigKeyID,'Y',@OrgID,GETDATE()
END

-------------------------------------MuthuMani-------------------------------------

Declare @OrgID int
set @OrgID=86
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='TestMasterFieldTest')
BEGIN        
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
VALUES((SELECT max(ConfigKeyID)+1 from ConfigKeyMaster),'TestMasterFieldTest','TestMasterFieldTest','N')
END

IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM 
JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='TestMasterFieldTest' AND COM.OrgID=@OrgID)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)
VALUES((SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='TestMasterFieldTest'),'Y',@OrgID,GETDATE())
END
-----------------------------------------------------End------------------------------------------------------------------------------- *** Added By Jagatheesh For Hotfix (Anderson Lab) *** --------------------------
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='Pendinglist')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'Pendinglist','Do you want to show only group and hide some fields in pendinglist ?','Y','','','RDO') 
 
 insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) 
 select @GetconfigId,'Y',98 
 UNION
select @GetconfigId,'N',OrgID from organization where OrgID !=98

END
------------------------ **** Config Org id for Anderson lab **** -------------------

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ConfigOrgId')
BEGIN
declare @GetconfigorgId int
select @GetconfigorgId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigorgId,'ConfigOrgId','Do you want get Config OrgId for 98 Org ? ','Y','','','RDO') 
 
 insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) 
 select @GetconfigorgId,'Y',98 
 UNION
select @GetconfigorgId,'N',OrgID from organization where OrgID !=98

END

------------------------- **** End Added **** ---------------------------------

------------------------------Added Gowtham Raj R--------------------------
IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='SavePageNo')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'SavePageNo','Do You SavePageNo?','Y','','','RDO') 
 
 insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) 
 select @GetconfigId,'Y',98 
 UNION
select @GetconfigId,'N',OrgID from organization where OrgID !=98

END
----------------------------------End-----------------------------------------------
--------------------------------Karkuzhali.R----------------------------------------------
-------------To Remove Aberrant queue for Anderson org
Declare @OrgID int
Select @OrgID = 98
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='NeedAberrantQ' AND COM.OrgID=@OrgID)
BEGIN				
INSERT INTO dbo.ConfigOrgMaster
    (
        --ConfigID - this column value is auto-generated
        dbo.ConfigOrgMaster.ConfigKeyID,
        dbo.ConfigOrgMaster.ConfigValue,
        dbo.ConfigOrgMaster.OrgID,
        dbo.ConfigOrgMaster.CreatedBy,
        dbo.ConfigOrgMaster.CreatedAt,
        dbo.ConfigOrgMaster.ModifiedBy,
        dbo.ConfigOrgMaster.ModifiedAt,
        dbo.ConfigOrgMaster.OrgAddressId
    )
   SELECT  -- ConfigID - bigint
        (SELECT ckm.ConfigKeyID FROM dbo.ConfigKeyMaster ckm where ConfigKey like 'NeedAberrantQ'), -- ConfigKeyID - bigint
        'Y', -- ConfigValue - varchar
        @OrgID, -- OrgID - int
        NULL, -- CreatedBy - bigint
        NULL, -- CreatedAt - datetime
        NULL, -- ModifiedBy - bigint
        NULL, -- ModifiedAt - datetime
        NULL -- OrgAddressId - bigint
END

-------------To Remove Aberrant queue for Health Plus org
Declare @OrgID int
Select @OrgID = 109
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='NeedAberrantQ' AND COM.OrgID=@OrgID)
BEGIN				
INSERT INTO dbo.ConfigOrgMaster
    (
        --ConfigID - this column value is auto-generated
        dbo.ConfigOrgMaster.ConfigKeyID,
        dbo.ConfigOrgMaster.ConfigValue,
        dbo.ConfigOrgMaster.OrgID,
        dbo.ConfigOrgMaster.CreatedBy,
        dbo.ConfigOrgMaster.CreatedAt,
        dbo.ConfigOrgMaster.ModifiedBy,
        dbo.ConfigOrgMaster.ModifiedAt,
        dbo.ConfigOrgMaster.OrgAddressId
    )
   SELECT  -- ConfigID - bigint
        (SELECT ckm.ConfigKeyID FROM dbo.ConfigKeyMaster ckm where ConfigKey like 'NeedAberrantQ'), -- ConfigKeyID - bigint
        'Y', -- ConfigValue - varchar
        @OrgID, -- OrgID - int
        NULL, -- CreatedBy - bigint
        NULL, -- CreatedAt - datetime
        NULL, -- ModifiedBy - bigint
        NULL, -- ModifiedAt - datetime
        NULL -- OrgAddressId - bigint
END
-------------------------------------End----------------------------------------------------


--------------------------Config script for Capture patient history----------------------
go
DECLARE @configkeyid BIGINT
SET @configkeyid= (select max(ConfigKeyID+1) FROM configkeymaster)

IF  NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsCapturePatientHistory')
BEGIN

INSERT INTO dbo.ConfigKeyMaster        
VALUES  (@configkeyid , 
         N'IsCapturePatientHistory' , 
         N'Do you want CapturePatientHistory' , 
         N'N' , 
         NULL,NULL,NULL,NULL
        )
INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  117 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  122 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  128 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  133 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  135 ,  NULL , NULL,NULL,NULL,NULL )

INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  153 ,  NULL , NULL,NULL,NULL,NULL )


INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  155 ,  NULL , NULL,NULL,NULL,NULL )


INSERT INTO dbo.ConfigOrgMaster
VALUES  (@configkeyid ,   N'Y' ,  157 ,  NULL , NULL,NULL,NULL,NULL )
 
END

-----------------------------------------------------------------------------------


IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsIncompleteRegistration')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'IsIncompleteRegistration','Do you IsIncompleteRegistration','Y','','','')
 
 insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID) values (@GetconfigId,'Y',137)
end


IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsDNSURL')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'IsDNSURL','Do you Need IsDNSURL','Y','','','')
 IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID =(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsDNSURL'))
BEGIN
 insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)  
 
 SELECT @GetconfigId AS ConfigKeyID,'lis.attunelive.net' AS ConfigValue,OrgID  FROM ConfigOrgMaster  WHERE ConfigKeyID=24 AND ConfigValue='AdvanceBillPrint.ascx' AND OrgID NOT IN(SELECT OrgID from dbo.ConfigOrgMaster WHERE ConfigKeyID=155 )
END
END



-----------------------------ramya changes for inventory merge----------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT OrgID from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN
	IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =OrgID FROM Organization WHERE OrgID=@MinValue

If not exists(select 1 from ConfigKeyMaster where ConfigKey='LocationBasedLisProduct')
begin
insert into ConfigKeyMaster (configkeyid,ConfigKey ,DisplayText ,IsInternal )
Select @ConfigKeyId+1,'LocationBasedLisProduct','Need to update location?','N'
end

select @SConfigKeyID=configkeyid from ConfigkeyMaster where configkey='LocationBasedLisProduct'

If not exists(select 1 from ConfigOrgMaster where ConfigKeyID =@SConfigKeyID and OrgID =@Orgid )
begin
insert into ConfigOrgMaster(configkeyid,configvalue,orgid)
Select @SConfigKeyID ,'N',@Orgid
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO 





----------------------------------------------------end-------------------------------------------------------------------------

IF NOT EXISTS(SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='WithoutHomeCollection')
BEGIN
declare @GetconfigId int
select @GetconfigId=MAX(configkeyid)+1 from ConfigKeyMaster 
insert into ConfigKeyMaster(ConfigKeyID ,ConfigKey ,DisplayText ,IsInternal ,ControlType ,ValueType ,ConfigType ) values
 (@GetconfigId,'WithoutHomeCollection','Is WithoutHomeCollection ?','','','','')
 IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID =(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='WithoutHomeCollection'))
BEGIN
 insert Into ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)  
 
 SELECT @GetconfigId AS ConfigKeyID,'Y' AS ConfigValue,189  
END
END

-----------------------------------------------------karthik.p Added Patient Portal Password creation using labnumber or mobile or Ex.patientnumber Start 04/08/2017- ----------------------------------------------------------------------------------------------------
Declare @ConfigKeyID Bigint
declare @OrgID int
set @OrgID=109
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PasswordLabNumber')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'PasswordLabNumber','Do you want to labnumber is password for this visit?','N','CHB',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PasswordLabNumber' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='PasswordLabNumber'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
set @OrgID=159
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PasswordMobile')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'PasswordMobile','Do you want to Mobile number is password for this visit?','N','CHB',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PasswordMobile' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='PasswordMobile'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
set @OrgID=98
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='PasswordExpatientnum')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'PasswordExpatientnum','Do you want to Ex.PatientNumber is password for this visit?','N','CHB',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='PasswordExpatientnum' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='PasswordExpatientnum'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END

-----------------------------------------------------karthik.p End 04/08/2017----------------------------------------------------------------------------------------------------

declare @ConfigKeyID INT
If (Select MAX(ConfigKeyID) FROM ConfigKeyMaster) IS NULL
BEGIN
	SET @ConfigKeyID = 0
END
ELSE
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster

IF NOT EXISTS(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsReportViewable')
BEGIN
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal)
	SELECT @ConfigKeyID+1,'IsReportViewable','Do the Report is Viewable for this Organization ?','N'
END

------------------------------------------------------------------------------------------------------------------------
--------------------------------------Surya.G for Medlife Patient Email id export in Visit Search Page------------------------------------------------------------------------------------------------------------
Declare @ConfigKeyID Bigint
declare @OrgID int
set @OrgID=219
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='ShowPatientEmailID')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'ShowPatientEmailID','Do you want show Patient Email ID in Visit search Excel','N','',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='ShowPatientEmailID' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='ShowPatientEmailID'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
------------------------------------------------ End ------------------------------------------------------------------------------------------------------
<<<<<<< .mine
-------------- Jayaramanan L for Allowing External Barcode field ----------------
Declare @ORGID BIGINT=232
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='AllowExternalBarcode')
BEGIN
SELECT 1
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'AllowExternalBarcode','AllowExternalBarcode','N'	 FROM ConfigKeyMaster 
END

IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster A INNER JOIN ConfigKeyMaster B ON A.ConfigKeyID=B.ConfigKeyID AND A.OrgID=@ORGID
 WHERE B.ConfigKey='AllowExternalBarcode')
 BEGIN
 SELECT 2
 INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
 SELECT ConfigKeyID,'Y',@ORGID FROM ConfigKeyMaster WHERE ConfigKey='AllowExternalBarcode'
 END

---------------------- END ------------------------||||||| .r10512
 

--------------------------------------Surya.G for Hide AmtRcd and In words column for Credit Client------------------------------------------------------------------------------------------------------------
Declare @ConfigKeyID Bigint
declare @OrgID int
set @OrgID=82
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='HideAmtRevdforCredit')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'HideAmtRevdforCredit','Do you want hide amtrevd and in words column for credit client','N','',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='HideAmtRevdforCredit' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='HideAmtRevdforCredit'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
------------------------------------------------ End ------------------------------------------------------------------------------------------------------


--------------------------------------Surya.G for approve date based investigation report------------------------------------------------------------------------------------------------------------
Declare @ConfigKeyID Bigint
declare @OrgID int
set @OrgID=82
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='ApproveBadedInvestigationReport')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'ApproveBadedInvestigationReport','Do you want approve date based investigation report','N','',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='ApproveBadedInvestigationReport' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='ApproveBadedInvestigationReport'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
------------------------------------------------ End ------------------------------------------------------------------------------------------------------

------------------------ Allow External Barcode -------------
 Declare @ORGID BIGINT=232
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='AllowExternalBarcode')
BEGIN
SELECT 1
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'AllowExternalBarcode','AllowExternalBarcode','N'	 FROM ConfigKeyMaster 
END

IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster A INNER JOIN ConfigKeyMaster B ON A.ConfigKeyID=B.ConfigKeyID AND A.OrgID=@ORGID
 WHERE B.ConfigKey='AllowExternalBarcode')
 BEGIN
 SELECT 2
 INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
 SELECT ConfigKeyID,'Y',@ORGID FROM ConfigKeyMaster WHERE ConfigKey='AllowExternalBarcode'
 END
---------------end ------------------------


---------------- IsHealthiAPIWorkOrder ----------
Declare @ORGID BIGINT=220
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsHealthiAPIWorkOrder')
BEGIN
SELECT 1
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'IsHealthiAPIWorkOrder','IsHealthiAPIWorkOrder','N'	 FROM ConfigKeyMaster 
END

IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster A INNER JOIN ConfigKeyMaster B ON A.ConfigKeyID=B.ConfigKeyID AND A.OrgID=@ORGID
 WHERE B.ConfigKey='IsHealthiAPIWorkOrder')
 BEGIN
 SELECT 2
 INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
 SELECT ConfigKeyID,'Y',@ORGID FROM ConfigKeyMaster WHERE ConfigKey='IsHealthiAPIWorkOrder'
 END
--------------end ----------------

---------------------- Hide Field In Edit Bill For Prima-------------
Declare @ORGID BIGINT=220
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='HideFieldInEditBill')
BEGIN
--SELECT 1
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'HideFieldInEditBill','Hide Field in Bill Search','N'	 FROM ConfigKeyMaster 
END

IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster A INNER JOIN ConfigKeyMaster B ON A.ConfigKeyID=B.ConfigKeyID AND A.OrgID=@ORGID
 WHERE B.ConfigKey='HideFieldInEditBill')
 BEGIN
 --SELECT 2
 INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
 SELECT ConfigKeyID,7254,@ORGID FROM ConfigKeyMaster WHERE ConfigKey='HideFieldInEditBill'
 END
------------ End ----------
--------------------------------------Surya.G for allow different sample test for dofromvisit------------------------------------------------------------------------------------------------------------
Declare @ConfigKeyID Bigint
declare @OrgID int
set @OrgID=168
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='AllowDiffSampleTestforDFV')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'AllowDiffSampleTestforDFV','Do you want allow different sample test for dofromvisit','N','',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='AllowDiffSampleTestforDFV' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='AllowDiffSampleTestforDFV'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
GO
------------------------------------------------ End ------------------------------------------------------------------------------------------------------

--------------------------------------Surya.G for edit baby of salutation gender------------------------------------------------------------------------------------------------------------
Declare @ConfigKeyID Bigint
declare @OrgID int
set @OrgID=168
IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='EditGenderforBABYSalutation')
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) from ConfigKeyMaster

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType,ValueType)
	SELECT @ConfigKeyID+1,'EditGenderforBABYSalutation','Do you want edit baby of salutation gender','N','',''
END
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='EditGenderforBABYSalutation' AND COM.OrgID=@OrgID)
BEGIN
	Select @ConfigKeyID = MAX(ConfigKeyID) FROM ConfigKeyMaster WHERE ConfigKey='EditGenderforBABYSalutation'
	
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	SELECT @ConfigKeyID,'Y',@OrgID
END
------------------------------------------------ End ------------------------------------------------------------------------------------------------------

--- START PRIMA CONFIG --
DECLARE @OrgID INT =220
DECLARE @CONFIGID INT 
IF EXISTS (select 1 from configkeymaster CM
inner join configorgmaster COM on COM.ConfigkeyID=CM.ConfigkeyID
where CM.ConfigKey='OPCollectionReportLIMSSoul' and COM.Orgid= @OrgID)
BEGIN
--Select 0
Select @CONFIGID=ConfigKeyID from configkeymaster where Configkey='OPCollectionReportLIMSSoul'
delete from configorgmaster where configkeyid=@CONFIGID  AND Orgid= @OrgID
END

IF Not Exists (select 1 from configkeymaster CM
inner join configorgmaster COM on COM.ConfigkeyID=CM.ConfigkeyID
where CM.ConfigKey='DayWiseCollectionReportFoPrima' and COM.Orgid= @OrgID)
BEGIN
--select 1
Insert Into Configkeymaster (ConfigKeyID,ConfigKey,Displaytext,IsInternal)
Select MAX(ConfigKeyID)+1, 'DayWiseCollectionReportFoPrima','Do you want Prima Daywise Collection Report','N' from Configkeymaster
END
IF Not Exists (select 1 from configkeymaster CM
inner join configorgmaster COM on COM.ConfigkeyID=CM.ConfigkeyID
where CM.ConfigKey='DayWiseCollectionReportFoPrima' and COM.Orgid= @OrgID)
BEGIN
--Select 2
Set @CONFIGID=0;
Select @CONFIGID=ConfigKeyID from configkeymaster where Configkey='DayWiseCollectionReportFoPrima'
Insert into configorgmaster (ConfigKeyID,ConfigValue,OrgID)
Select @CONFIGID,'Y',@OrgID
END
--- END PRIMA CONFIG --


-- Need to create Prima & Mysore Org

Declare @ORGID BIGINT=220
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='TaskAssignedToCreditController')
BEGIN
SELECT 1
--INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'TaskAssignedToCreditController','Do you want to assign task to CreditController ?','N' FROM ConfigKeyMaster 
END

IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster A INNER JOIN ConfigKeyMaster B ON A.ConfigKeyID=B.ConfigKeyID AND A.OrgID=@ORGID
 WHERE B.ConfigKey='TaskAssignedToCreditController')
 BEGIN
 SELECT 2
 --INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
 SELECT ConfigKeyID,'Y',@ORGID FROM ConfigKeyMaster WHERE ConfigKey='TaskAssignedToCreditController'
 END
--------- Set defualt task assigning ---

Declare @ORGID BIGINT=220
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='SetDefaultTaskAssignToCreditController')
BEGIN
SELECT 1
--INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'SetDefaultTaskAssignToCreditController','Do you want to set Default task Assign to CreditController ?','N' FROM ConfigKeyMaster 
END

IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster A INNER JOIN ConfigKeyMaster B ON A.ConfigKeyID=B.ConfigKeyID AND A.OrgID=@ORGID
 WHERE B.ConfigKey='SetDefaultTaskAssignToCreditController')
 BEGIN
 SELECT 2
 --INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
 SELECT ConfigKeyID,'Y',@ORGID FROM ConfigKeyMaster WHERE ConfigKey='SetDefaultTaskAssignToCreditController'
 END
---------------- show payment mode only for Credit controller ------
Declare @ORGID BIGINT=220
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowpaymentmodeforCreditController')
BEGIN
SELECT 1
--INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'ShowpaymentmodeforCreditController','Show payment mode','N' FROM ConfigKeyMaster 
END

IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster A INNER JOIN ConfigKeyMaster B ON A.ConfigKeyID=B.ConfigKeyID AND A.OrgID=@ORGID
 WHERE B.ConfigKey='ShowpaymentmodeforCreditController')
 BEGIN
 SELECT 2
 --INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
 SELECT ConfigKeyID,'7257',@ORGID FROM ConfigKeyMaster WHERE ConfigKey='ShowpaymentmodeforCreditController'
 END
---------

/* BEGIN | NA | Sabari | 06032019 | Created | InvestigationResultDeflagging */
/***************-------------CONFIGINSERT---------*****************************/
go
DECLARE @ConfigKeyID BIGINT, @ConfigKey NVARCHAR(255), @DisplayText NVARCHAR(255), @IsInternal NVARCHAR(2) ='N', 
@CreatedBy BIGINT = 415,@CreatedAt datetime = GetDate(), @ConfigValue NVARCHAR(255), @OrgID BIGINT
SELECT @OrgID=OrgID FROM organization WHERE Name='Attune Demo'  
SELECT @ConfigKeyID = Max(ConfigKeyID)+1 FROM ConfigKeyMaster;
SET @ConfigKey = 'InvestigationResultDeflag'; 
SET @DisplayText ='Need InvestigationResultDeflag for this Org';
-----------------------------------------
IF Not Exists (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey=@ConfigKey and DisplayText=@DisplayText)
BEGIN 
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,CreatedBy,CreatedAt) VALUES (@ConfigKeyID,@ConfigKey,@DisplayText,@IsInternal,@CreatedBy,@CreatedAt)
END
-------------------------------------------------------
SELECT @ConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey=@ConfigKey and DisplayText=@DisplayText 
SET @ConfigValue='Y'
IF Not Exists (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID=@ConfigKeyID and OrgID=@OrgID)
BEGIN 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt) VALUES (@ConfigKeyID,@ConfigValue,@OrgID,@CreatedBy,@CreatedAt)
END
/* END | NA | Sabari | 06032019 | Created | InvestigationResultDeflagging */
GO
/* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
DECLARE @ConfigKeyID BIGINT, @ConfigKey NVARCHAR(255), @DisplayText NVARCHAR(255), @IsInternal NVARCHAR(2) ='N', 
@CreatedBy BIGINT = 415,@CreatedAt datetime = GetDate(), @ConfigValue NVARCHAR(255), @OrgID BIGINT
SELECT @OrgID=OrgID FROM organization WHERE Name='Attune Demo'  
SELECT @ConfigKeyID = Max(ConfigKeyID)+1 FROM ConfigKeyMaster;
SET @ConfigKey = 'ReportonHold'; 
SET @DisplayText ='Need ReportonHold for this Org';
-----------------------------------------
IF Not Exists (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey=@ConfigKey and DisplayText=@DisplayText)
BEGIN 
	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,CreatedBy,CreatedAt) VALUES (@ConfigKeyID,@ConfigKey,@DisplayText,@IsInternal,@CreatedBy,@CreatedAt)
END
-------------------------------------------------------
SELECT @ConfigKeyID = ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey=@ConfigKey and DisplayText=@DisplayText 
SET @ConfigValue='Y'
IF Not Exists (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID=@ConfigKeyID and OrgID=@OrgID)
BEGIN 
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt) VALUES (@ConfigKeyID,@ConfigValue,@OrgID,@CreatedBy,@CreatedAt)
END
/* END | NA | Sabari | 20181202 | Created | HOLD */
go

/* Start   | Surya */
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedtoShowSampleChangedName')
BEGIN
SELECT 1
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'NeedStatusChangeReasonasRemarks','Show InvStatusChange Reason as Technical Remarks','N' FROM ConfigKeyMaster 
END 
/* END  | Surya  */
GO


/******************* TabularPattern Related Start 9/9/2020 **************/
    IF NOT EXISTS(select 1 from ConfigKeyMaster where Configkey = 'TabularPattern_FilePath')
	Begin
		declare @ConfigkeyId int
		select @ConfigkeyId= max(configkeyid)+1 from ConfigKeyMaster
		
		insert into ConfigKeyMaster(configkeyid,ConfigKey,DisplayText,IsInternal)
		select @ConfigkeyId,'TabularPattern_FilePath','Tabular Pattern File Path','N'
	End        
	go

	DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT

	SET @ConfigKeyID=(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='TabularPattern_FilePath')
	SET @OrgID=(SELECT OrgID FROM organization WHERE Name='iGenetic Diagnostics Pvt.Ltd')

	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) 
	AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		VALUES (@ConfigKeyID, 'C:\\Attune\\Lims_Product\\TRFImages\\TabularPattern\\', @OrgID, getdate(), -1)
	End
	go
/******************* TabularPattern Related End **************/



/******************* HomeCollection Related Start **************/

    IF NOT EXISTS(select 1 from ConfigKeyMaster where Configkey = 'IsHCSchedulerWorkflow')
	Begin
		declare @ConfigkeyId int
		select @ConfigkeyId= max(configkeyid)+1 from ConfigKeyMaster
		
		insert into ConfigKeyMaster(configkeyid,ConfigKey,DisplayText,IsInternal)
		select @ConfigkeyId,'IsHCSchedulerWorkflow','HC Technician Scheduler Workflow','N'
	End        
	go

	DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT

	SET @ConfigKeyID=(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsHCSchedulerWorkflow')
	SET @OrgID=(SELECT OrgID FROM organization WHERE Name='Diag')

	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		VALUES (@ConfigKeyID, 'Y', @OrgID, getdate(), -1)
	End
	go
	
	------------ WhatsupIntegration  ------
	IF NOT EXISTS(select 1 from ConfigKeyMaster where Configkey = 'WhatsupIntegration')
	Begin
		declare @ConfigkeyId int
		select @ConfigkeyId= max(configkeyid)+1 from ConfigKeyMaster
		
		insert into ConfigKeyMaster(configkeyid,ConfigKey,DisplayText,IsInternal)
		select @ConfigkeyId,'WhatsupIntegration','whatsup Integration','N'
	End        
	go

	DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT

	SET @ConfigKeyID=(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='WhatsupIntegration')
	SET @OrgID=(SELECT OrgID FROM organization WHERE Name='Diag')

	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		VALUES (@ConfigKeyID, 'Y', @OrgID, getdate(), -1)
	End
	go
	------------ WhatsupIntegration  ------

/******************* HomeCollection Related End **************/


/******************* Stock management API **************/

DECLARE @OrgID INT,@ConfigKeyID INT


SET @OrgID=(SELECT OrgID FROM organization WHERE Name='Diag')

SELECT @ConfigKeyID=MAX(ConfigkeyID)+1 FROM ConfigkeyMaster
IF NOT EXISTS (SELECT 1 FROM ConfigkeyMaster WHERE Configkey='NeedProductIntegaration' )
BEGIN
INSERT INTO ConfigkeyMaster (ConfigkeyID,Configkey,DisplayText,IsInternal,CreatedAt,CreatedBy)
SELECT @ConfigKeyID,'NeedProductIntegaration','Product Integaration Required YN','N',getdate(),182
END
SELECT @ConfigKeyID=ConfigkeyID FROM ConfigkeyMaster WHERE Configkey='NeedProductIntegaration'
 
IF NOT EXISTS (SELECT 1 FROM  ConfigOrgMaster WHERE ConfigkeyID=@ConfigKeyID AND OrgID=@OrgID AND @OrgID>0 )
BEGIN
 INSERT INTO ConfigOrgMaster (ConfigkeyID,OrgID,ConfigValue,CreatedAt)
 SELECT @ConfigKeyID,@OrgID,'Y',GETDATE()
END
 
GO


DECLARE @OrgID INT,@ConfigKeyID INT

SET @OrgID=(SELECT OrgID FROM organization WHERE Name='Diag')

SELECT @ConfigKeyID=MAX(ConfigkeyID)+1 FROM ConfigkeyMaster
IF NOT EXISTS (SELECT 1 FROM ConfigkeyMaster WHERE Configkey='NeedProductConsumptionIntegaration' )
BEGIN
INSERT INTO ConfigkeyMaster (ConfigkeyID,Configkey,DisplayText,IsInternal,CreatedAt,CreatedBy)
SELECT @ConfigKeyID,'NeedProductConsumptionIntegaration','Product Consumption Integaration Required YN','N',getdate(),182
END
SELECT @ConfigKeyID=ConfigkeyID FROM ConfigkeyMaster WHERE Configkey='NeedProductConsumptionIntegaration'
 
IF NOT EXISTS (SELECT 1 FROM  ConfigOrgMaster WHERE ConfigkeyID=@ConfigKeyID AND OrgID=@OrgID AND @OrgID>0 )
BEGIN
 INSERT INTO ConfigOrgMaster (ConfigkeyID,OrgID,ConfigValue,CreatedAt)
 SELECT @ConfigKeyID,@OrgID,'Y',GETDATE()
END
 
GO


IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='DisplayPageNumberInTopRightSide')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'DisplayPageNumberInTopRightSide','Need PageNo in Top of the PDF in PDFMerger','N' FROM ConfigKeyMaster 
END
GO

IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='RestrictReceAmtForCashwithAdvance')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'RestrictReceAmtForCashwithAdvance','Restrict received amt for cash with advance client','N' FROM ConfigKeyMaster 
END
GO
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ShowExternalBarcodeInsteadofBarcode')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'ShowExternalBarcodeInsteadofBarcode','Show External Barcode Instead of Barcode','N' FROM ConfigKeyMaster 
END
GO
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='SampleExpiryDateForExBarcode')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'SampleExpiryDateForExBarcode','In Billing Additional Test, How many days add for Sample Expiry Date','N' FROM ConfigKeyMaster 
END
GO
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedRegisterDateFormatinPerforming')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'NeedRegisterDateFormatinPerforming','Need RegisterDate Format as / in Performing','N' FROM ConfigKeyMaster 
END
GO

IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='RoleForDevice')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'RoleForDevice','RoleForDevice','N' FROM ConfigKeyMaster 
END
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='AutoCertifyWithQC')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'AutoCertifyWithQC','AutoCertifyWithQC','N' FROM ConfigKeyMaster 
END

GO
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='HideDiscountPartinB2B')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'HideDiscountPartinB2B','HideDiscountPartinB2B','N' FROM ConfigKeyMaster 
END
GO
 
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='AllowGreaterAmtfromMrp')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'AllowGreaterAmtfromMrp','Allow greater amount from MRP Test for Billing','N' FROM ConfigKeyMaster 
END	
GO

DECLARE @OrgID INT,@ConfigKeyID INT

SET @OrgID=(SELECT OrgID FROM organization WHERE Name='RLS-Gorakhpur')

SELECT @ConfigKeyID=MAX(ConfigkeyID)+1 FROM ConfigkeyMaster
IF NOT EXISTS (SELECT 1 FROM ConfigkeyMaster WHERE Configkey='Showbarcodeno' )
BEGIN
INSERT INTO ConfigkeyMaster (ConfigkeyID,Configkey,DisplayText,IsInternal,CreatedAt,CreatedBy)
SELECT @ConfigKeyID,'Showbarcodeno','Show barcode no in Enter Result Screen','N',getdate(),182
END
SELECT @ConfigKeyID=ConfigkeyID FROM ConfigkeyMaster WHERE Configkey='Showbarcodeno'
 
IF NOT EXISTS (SELECT 1 FROM  ConfigOrgMaster WHERE ConfigkeyID=@ConfigKeyID AND OrgID=@OrgID AND @OrgID>0 )
BEGIN
 INSERT INTO ConfigOrgMaster (ConfigkeyID,OrgID,ConfigValue,CreatedAt)
 SELECT @ConfigKeyID,@OrgID,'Y',GETDATE()
END
 
GO

IF NOT EXISTS(select 1 from ConfigKeyMaster where Configkey = 'IsMandatoryEmailandRefDr')
	Begin
		declare @ConfigkeyId int
		select @ConfigkeyId= max(configkeyid)+1 from ConfigKeyMaster
		
		insert into ConfigKeyMaster(configkeyid,ConfigKey,DisplayText,IsInternal)
		select @ConfigkeyId,'IsMandatoryEmailandRefDr','Mandatory of EmailID and Ref Doctor','N'
	End        
	go

	DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT

	SET @ConfigKeyID=(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsMandatoryEmailandRefDr')
	SET @OrgID=(SELECT OrgID FROM organization WHERE Name='Attune Demo')

	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		VALUES (@ConfigKeyID, 'Y', @OrgID, getdate(), -1)
	End
	go
	
	
	IF NOT EXISTS(select 1 from ConfigKeyMaster where Configkey = 'IsNotMandatoryCollectionTime')
	Begin
		declare @ConfigkeyId int
		select @ConfigkeyId= max(configkeyid)+1 from ConfigKeyMaster
		
		insert into ConfigKeyMaster(configkeyid,ConfigKey,DisplayText,IsInternal)
		select @ConfigkeyId,'IsNotMandatoryCollectionTime','Not Mandatory of Collection Date and Time','N'
	End        
	go

	DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT

	SET @ConfigKeyID=(SELECT ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsNotMandatoryCollectionTime')
	SET @OrgID=(SELECT OrgID FROM organization WHERE Name='Attune Demo')

	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		VALUES (@ConfigKeyID, 'Y', @OrgID, getdate(), -1)
	End
	go
	 DECLARE @OrgID INT , @ConfigkeyID INT 
 SELECT @OrgID=OrgID FROM Organization WHERE Name like '%Prima Diagnostics%'
 SELECT @ConfigkeyID=MAX(ConfigkeyID)+1 FROM ConfigkeyMaster 
 
 IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE Configkey='UseWardnoAsSRFID' AND DisplayText='Do you want to use wardno as SRFID?')
 BEGIN
    INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,CreatedAt,CreatedBy)
    SELECT @ConfigkeyID,'UseWardnoAsSRFID','Do you want to use wardno as SRFID?','N',GETDATE(),182 
 END

 SELECT @ConfigkeyID=ConfigkeyID FROM   ConfigKeyMaster WHERE Configkey='UseWardnoAsSRFID' AND DisplayText='Do you want to use wardno as SRFID?'
 IF NOT EXISTS (SELECT  1 FROM ConfigOrgMaster WHERE  ConfigkeyID=@ConfigkeyID AND OrgID=@OrgID)
 BEGIN
    INSERT INTO ConfigOrgMaster (ConfigkeyID,Configvalue,orgID,CreatedAT,Createdby)
    SELECT @ConfigkeyID,'Y',@OrgID,GETDATE(),182
 END
 
 


 GO 

 IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedFranchiseeModule')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'NeedFranchiseeModule','Need FranchiseeModule','N' FROM ConfigKeyMaster 
END

GO
-----arunchanges -- rate master labshare amount hide show
DECLARE @ConfigKeyId123 BIGINT

IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey = 'HideLabShareAmnt')
BEGIN
	SET @ConfigKeyId123 = (SELECT COUNT(1) from ConfigKeyMaster) +1

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
	VALUES (@ConfigKeyId123,'HideLabShareAmnt','Lab Franchisee share amount capture','N','CHB')	
END
ELSE
BEGIN
	SET @ConfigKeyId123 = (SELECT ConfigKeyID from ConfigKeyMaster WHERE ConfigKey = 'HideLabShareAmnt')
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyId123 AND OrgID in(202,248,249))
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyId123,'Y',202),(@ConfigKeyId123,'Y',248),(@ConfigKeyId123,'Y',249)
END

Declare @ConfigKeyID bigint

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='AutoCertify')
BEGIN
SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'AutoCertify','Do you want to AutoCertify the report?','N','N')
END
SELECT @ConfigKeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='AutoCertify'
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='AutoCertify' AND COM.OrgID=98)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'N',98,GETDATE())
END
GO


---Config For AutoAuthorization
----------------------------------

Declare @ConfigKeyID bigint

IF NOT EXISTS(SELECT ConfigKey FROM ConfigKeyMaster WHERE ConfigKey='AutoAuthorization')
BEGIN
SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)VALUES(@ConfigKeyID,'AutoAuthorization','Do you want to AutoAuthorization the report?','N','N')
END
SELECT @ConfigKeyID= ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='AutoAuthorization'
IF NOT EXISTS(SELECT CKM.ConfigKeyID FROM ConfigOrgMaster COM JOIN ConfigKeyMaster CKM ON CKM.ConfigKeyID=COM.ConfigKeyID WHERE CKM.ConfigKey='AutoAuthorization' AND COM.OrgID=98)
BEGIN
INSERT INTO ConfigOrgMaster(ConfigKeyID,ConfigValue,OrgID,CreatedAt)VALUES(@ConfigKeyID,'Y',98,GETDATE())
END
GO
 DECLARE @OrgID INT , @ConfigkeyID INT 
 SELECT @OrgID=OrgID FROM Organization WHERE Name like 'One Diagnostics'
 SELECT @ConfigkeyID=MAX(ConfigkeyID)+1 FROM ConfigkeyMaster 
 
 IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE Configkey='BulkSampleNumber' AND DisplayText='Do you want to save customer given sample?')
 BEGIN
    INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,CreatedAt,CreatedBy)
    SELECT @ConfigkeyID,'BulkSampleNumber','Do you want to save customer given sample?','N',GETDATE(),182 
 END

 SELECT @ConfigkeyID=ConfigkeyID FROM   ConfigKeyMaster WHERE Configkey='BulkSampleNumber' AND DisplayText='Do you want to save customer given sample?'
 IF NOT EXISTS (SELECT  1 FROM ConfigOrgMaster WHERE  ConfigkeyID=@ConfigkeyID AND OrgID=@OrgID)
 BEGIN
    INSERT INTO ConfigOrgMaster (ConfigkeyID,Configvalue,orgID,CreatedAT,Createdby)
    SELECT @ConfigkeyID,'Y',@OrgID,GETDATE(),182
 END
 
 GO 
 DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ProcessingCentreAlone')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'ProcessingCentreAlone','Do you want to load processing centre alone?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='ProcessingCentreAlone' 
    IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
    Begin
        INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
        SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
    End

	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
    Begin
        INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
        SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
    End
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
    Begin
        INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
        SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
    End
    go
	 
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='RestrictViewRegistrationForclientRole')
BEGIN 
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT MAX(ConfigKeyID)+1,'RestrictViewRegistrationForclientRole','Resrtict View Registration option for Client Role','N' FROM ConfigKeyMaster 
END
GO

DECLARE @OrgID INT , @ConfigkeyID INT 
 SELECT @OrgID=OrgID FROM Organization WHERE Name like 'RLS-Gorakhpur'
 SELECT @ConfigkeyID=MAX(ConfigkeyID)+1 FROM ConfigkeyMaster 
 
 IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE Configkey='IsTransferForSameSample' AND DisplayText='IsTransferForSameSample')
 BEGIN
    INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,CreatedAt,CreatedBy)
    SELECT @ConfigkeyID,'IsTransferForSameSample','IsTransferForSameSample','N',GETDATE(),182 
 END

  SELECT @ConfigkeyID=ConfigkeyID FROM   ConfigKeyMaster WHERE Configkey='IsTransferForSameSample' AND DisplayText='IsTransferForSameSample'
 IF NOT EXISTS (SELECT  1 FROM ConfigOrgMaster WHERE  ConfigkeyID=@ConfigkeyID AND OrgID=@OrgID)
 BEGIN
    INSERT INTO ConfigOrgMaster (ConfigkeyID,Configvalue,orgID,CreatedAT,Createdby)
    SELECT @ConfigkeyID,'Y',@OrgID,GETDATE(),182
 END 
 
 SELECT @OrgID=OrgID FROM Organization WHERE Name like 'RLS Mumbai'
  IF NOT EXISTS (SELECT  1 FROM ConfigOrgMaster WHERE  ConfigkeyID=@ConfigkeyID AND OrgID=@OrgID)
 BEGIN
    INSERT INTO ConfigOrgMaster (ConfigkeyID,Configvalue,orgID,CreatedAT,Createdby)
    SELECT @ConfigkeyID,'Y',@OrgID,GETDATE(),182
 END

 SELECT @OrgID=OrgID FROM Organization WHERE Name like 'RLS-Covid (Mumbai)'
  IF NOT EXISTS (SELECT  1 FROM ConfigOrgMaster WHERE  ConfigkeyID=@ConfigkeyID AND OrgID=@OrgID)
 BEGIN
    INSERT INTO ConfigOrgMaster (ConfigkeyID,Configvalue,orgID,CreatedAT,Createdby)
    SELECT @ConfigkeyID,'Y',@OrgID,GETDATE(),182
 END
 
 SELECT @OrgID=OrgID FROM Organization WHERE Name like 'RLS Jamnagar'
  IF NOT EXISTS (SELECT  1 FROM ConfigOrgMaster WHERE  ConfigkeyID=@ConfigkeyID AND OrgID=@OrgID)
 BEGIN
    INSERT INTO ConfigOrgMaster (ConfigkeyID,Configvalue,orgID,CreatedAT,Createdby)
    SELECT @ConfigkeyID,'Y',@OrgID,GETDATE(),182
 END

  SELECT @OrgID=OrgID FROM Organization WHERE Name like 'RLS Surat'
  IF NOT EXISTS (SELECT  1 FROM ConfigOrgMaster WHERE  ConfigkeyID=@ConfigkeyID AND OrgID=@OrgID)
 BEGIN
    INSERT INTO ConfigOrgMaster (ConfigkeyID,Configvalue,orgID,CreatedAT,Createdby)
    SELECT @ConfigkeyID,'Y',@OrgID,GETDATE(),182
 END
  
 GO 