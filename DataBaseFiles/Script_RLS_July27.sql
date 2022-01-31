-----------------Arun - UPI added in PaymentType
 DECLARE @Orgid INT =0, @Paymenttypeid INT=0
SET @Orgid = 202 
IF NOT EXISTS (SELECT 1 FROM PaymentType WHERE PaymentName ='UPI Payments')
BEGIN
	SET @Paymenttypeid = (SELECT COUNT(1) FROM PaymentType)+1
	INSERT INTO PaymentType(PaymentTypeID,PaymentName)
	VALUES(@Paymenttypeid,'UPI Payments')	
END
ELSE
BEGIN
	SET @Paymenttypeid = (SELECT PaymentTypeID FROM PaymentType WHERE PaymentName ='UPI Payments')
END
--SELECT * FROM PaymentTypeOrgMapping WHERE  PaymentTypeID=@Paymenttypeid
IF NOT EXISTS (SELECT 1 FROM PaymentTypeOrgMapping WHERE OrgID = 202 AND PaymentTypeID=@Paymenttypeid)
BEGIN
	INSERT INTO PaymentTypeOrgMapping (PaymentTypeID,OrgID)
	VALUES(@Paymenttypeid,202)
END
IF NOT EXISTS (SELECT 1 FROM PaymentTypeOrgMapping WHERE OrgID = 248 AND PaymentTypeID=@Paymenttypeid)
BEGIN
	INSERT INTO PaymentTypeOrgMapping (PaymentTypeID,OrgID)
	VALUES(@Paymenttypeid,248)
END
IF NOT EXISTS (SELECT 1 FROM PaymentTypeOrgMapping WHERE OrgID = 249 AND PaymentTypeID=@Paymenttypeid)
BEGIN
	INSERT INTO PaymentTypeOrgMapping (PaymentTypeID,OrgID)
	VALUES(@Paymenttypeid,249)
END
 ---------------
 GO
 -------------------------arun changes - credit note page insert start---------
DECLARE @PageID123 BIGINT
DECLARE @MenuID123 INT
DECLARE @RoleID123 BIGINT
DECLARE @OrgID123 INT
SET @OrgID123=249

SELECT @MenuID123=MAX(MenuID) FROM MenuMaster
SELECT @PageID123=MAX(PageID) FROM Pages
set  @RoleID123= (SELECT top 1 RoleID FROM [Role] WHERE OrgID=@OrgID123 and RoleName='Credit Controller')

 --select @RoleID123

IF NOT EXISTS(SELECT PageID FROM Pages WHERE PageURL='/Invoice/CreditNoteUpdation.aspx')
BEGIN
    INSERT INTO Pages(PageID,PageName,PageURL) 
    SELECT @PageID123+1,'Credit Note','/Invoice/CreditNoteUpdation.aspx'
END

IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM JOIN Pages P ON MM.PageID=P.PageID WHERE P.PageURL='/Invoice/CreditNoteUpdation.aspx' AND MM.OrgId=@OrgID123)
BEGIN
    INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
    SELECT @MenuID123+1,'Credit Note',0,@OrgID123,@PageID123+1
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM JOIN MenuMaster MM ON MM.MenuID=RM.MenuID JOIN Pages P ON P.PageID=MM.PageID WHERE P.PageURL='/Invoice/CreditNoteUpdation.aspx' AND MM.OrgId=@OrgID123)
BEGIN
    INSERT INTO RoleMenu(MenuID,RoleID,IsMapped) 
    SELECT @MenuID123+1,@RoleID123,'Y'
END
----------------Credit note page insert end--------------------
GO
---------arun changes -- for credit client apisms should not show the content 'Rs. 0.00' start -----

DECLARE @ConfigKeyId BIGINT

IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey = 'IsCreditClientRsHide')
BEGIN
	SET @ConfigKeyId = (SELECT COUNT(1) from ConfigKeyMaster) +1

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
	VALUES (@ConfigKeyId,'IsCreditClientRsHide','Rs.0 should not show for credit client sms','N','CHB')	
END
ELSE
BEGIN
	SET @ConfigKeyId = (SELECT ConfigKeyID from ConfigKeyMaster WHERE ConfigKey = 'IsCreditClientRsHide')
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyId AND OrgID = 249)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyId,'Y',249)
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyId AND OrgID = 248)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyId,'Y',248)
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyId AND OrgID = 202)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyId,'Y',202)
END
---------arun changes -- for credit client apisms should not show the content 'Rs. 0.00' end -----
GO
--------------arun changes -- password scope changes-config start
DECLARE @ConfigKeyId BIGINT

IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey = 'IsPasswordScope')
BEGIN
	SET @ConfigKeyId = (SELECT COUNT(1) from ConfigKeyMaster) +1

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
	VALUES (@ConfigKeyId,'IsPasswordScope','Pswd new scope validation','N','CHB')	
END
ELSE
BEGIN
	SET @ConfigKeyId = (SELECT ConfigKeyID from ConfigKeyMaster WHERE ConfigKey = 'IsPasswordScope')
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyId AND OrgID = 249)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyId,'Y',249)
END	
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyId AND OrgID = 248)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyId,'Y',248)
END	
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyId AND OrgID = 202)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyId,'Y',202)
END	
--------------arun changes -- password scope changes-config end		
GO	
-------for client billing - patient sms entry insert into patientdispatchdetails table
DECLARE @ConfigKeyIdNew113 BIGINT

IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey = 'IsNotifySMSNeededClientBill')
BEGIN
	SET @ConfigKeyIdNew113 = (SELECT COUNT(1) from ConfigKeyMaster) +1

	INSERT INTO ConfigKeyMaster (ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
	VALUES (@ConfigKeyIdNew113,'IsNotifySMSNeededClientBill','SMS to patient from client billing page','N','CHB')	
END
ELSE
BEGIN
	SET @ConfigKeyIdNew113 = (SELECT ConfigKeyID from ConfigKeyMaster WHERE ConfigKey = 'IsNotifySMSNeededClientBill')
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyIdNew113 AND OrgID = 249)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyIdNew113,'Y',249)
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyIdNew113 AND OrgID = 248)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyIdNew113,'Y',248)
END
IF NOT EXISTS (SELECT 1 FROM ConfigOrgMaster WHERE ConfigKeyID = @ConfigKeyIdNew113 AND OrgID = 202)
BEGIN
	INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID)
	VALUES (@ConfigKeyIdNew113,'Y',202)
END
----
GO
----------From client billing - registration sms not came for TAT and NON-TAT Visits issue fixed
DECLARE @Roleid155 INT, @PageId INT, @PageContextid INT, @ActionTypeId INT, @OrgId INT, @PageContextid1 INT
set @OrgId = 249
SET @Roleid155 = (select top 1 ROLEID from role where rolename = 'DEO B2B' and orgid = 249)
SET @PageId = (select top 1 PageId from pages where pagename = 'Client Billing')
SET @ActionTypeId = (select top 1 ActionTypeID from ActionManagerType where ActionType = 'APISMS')
SET @PageContextid = (select top 1 PagecontextId from Pagecontext where ButtonName = 'btnGenerate' and pageid = @PageId)
IF NOT EXISTS (SELECT 1 FROM Pagecontextactionmapping WHERE actiontypeid = @ActionTypeId and roleid = @Roleid155 AND pagecontextid = @PageContextid and ContextType = 'P')
BEGIN
	INSERT INTO Pagecontextactionmapping(PageContextID,RoleID,ActionTypeID,TemplateId,ContextType,AdditionalContext,Isattachment)
	values(@PageContextid,@Roleid155,@ActionTypeId,54,'P','Notify','N'),
	(@PageContextid,@Roleid155,@ActionTypeId,97,'P','Notify','N')-- in client billing --for non tat visit sms not came issue fixes
	--,(@PageContextid,@Roleid155,@ActionTypeId,103,'P','Notify','N')
END

DECLARE @Roleid133 INT
SET @Roleid133 = (select top 1 ROLEID from role where rolename = 'DEO B2B' and orgid = 248)

IF NOT EXISTS (SELECT 1 FROM Pagecontextactionmapping WHERE actiontypeid = @ActionTypeId and roleid = @Roleid133 AND pagecontextid = @PageContextid and ContextType = 'P')
BEGIN
	INSERT INTO Pagecontextactionmapping(PageContextID,RoleID,ActionTypeID,TemplateId,ContextType,AdditionalContext,Isattachment)
	values(@PageContextid,@Roleid133,@ActionTypeId,54,'P','Notify','N'),
	(@PageContextid,@Roleid133,@ActionTypeId,97,'P','Notify','N')-- in client billing --for non tat visit sms not came issue fixes
	--,(@PageContextid,@Roleid133,@ActionTypeId,103,'P','Notify','N')
END

DECLARE @Roleid1144 INT
SET @Roleid1144 = (select top 1 ROLEID from role where rolename = 'DEO B2B' and orgid = 202)

IF NOT EXISTS (SELECT 1 FROM Pagecontextactionmapping WHERE actiontypeid = @ActionTypeId and roleid = @Roleid1144 AND pagecontextid = @PageContextid and ContextType = 'P')
BEGIN
	INSERT INTO Pagecontextactionmapping(PageContextID,RoleID,ActionTypeID,TemplateId,ContextType,AdditionalContext,Isattachment)
	values(@PageContextid,@Roleid1144,@ActionTypeId,54,'P','Notify','N'),
	(@PageContextid,@Roleid1144,@ActionTypeId,97,'P','Notify','N')-- in client billing --for non tat visit sms not came issue fixes
	--,(@PageContextid,@Roleid1144,@ActionTypeId,103,'P','Notify','N')
END
----------From client billing - registration sms not came for TAT and NON-TAT Visits issue fixed end
GO
---------Arun -- RLS CUSTOMER CARE NUMBER UPDATE Script
IF EXISTS (SELECT 1 FROM ActionTemplate where template like '%1800 889 2444%')
BEGIN
	UPDATE ActionTemplate SET template = REPLACE(template,'1800 889 2444','1800 889 2555') where template like '%1800 889 2444%'
END
--------------------------
GO
----arun ----delete the irrelevant entry of notification,the Template Name as 'rejectionSMS' while client billing
DECLARE @Roleid555 INT, @PageId555 INT, @PageContextid555 INT, @ActionTypeId555 INT, @OrgId555 INT, @templatetypeid555 INT, @templateid555 INT
set @OrgId555 = 202
SET @templatetypeid555 = (select top 1 templatetypeid from Actiontemplatetype where TemplateType = 'SampleRecollectAlert')
SET @Roleid555 = (select top 1 ROLEID from role where rolename = 'DEO B2B' and orgid = 202)
SET @PageId555 = (select top 1 PageId from pages where pagename = 'Client Billing')
SET @templateid555 = (SELECT top 1 TemplateID FROM Actiontemplate where templatetypeid = @templatetypeid555 and TemplateName = 'recollectSMS')
SET @PageContextid555 = (select top 1 PagecontextId from Pagecontext where ButtonName = 'btnGenerate' and pageid = @PageId555)
--select @templateid555 '@templateid555', @Roleid555 '@Roleid555', @PageContextid555 '@PageContextid555'
IF EXISTS (SELECT 1 FROM Pagecontextactionmapping WHERE templateid = @templateid555 and roleid = @Roleid555 AND pagecontextid = @PageContextid555 and ContextType = 'P')
BEGIN
	delete Pagecontextactionmapping where templateid = @templateid555 and roleid = @Roleid555 AND pagecontextid = @PageContextid555 and ContextType = 'P'
END
-------end
GO

-------------------------TaskActionOrgMapping Start
DECLARE @TaskActionID INT,@RoleID BIGINT,@OrgID INT
SELECT @OrgID =OrgID FROM Organization(NOLOCK) WHERE Name='RLS-Covid (Mumbai)'
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT @RoleID=RoleID FROM ROLE(NOLOCK) WHERE OrgID=@OrgID AND RoleName='Sr Credit Controller' AND Description='Sr Credit Controller'
	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformCancel' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END

	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformRefund' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END
END
SELECT @OrgID =OrgID FROM Organization(NOLOCK) WHERE Name='RLS Mumbai'
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT @RoleID=RoleID FROM ROLE(NOLOCK) WHERE OrgID=@OrgID AND RoleName='Sr Credit Controller' AND Description='Sr Credit Controller'
	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformCancel' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END

	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformRefund' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END
END

SELECT @OrgID =OrgID FROM Organization(NOLOCK) WHERE Name='RLS-Gorakhpur'
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT @RoleID=RoleID FROM ROLE(NOLOCK) WHERE OrgID=@OrgID AND RoleName='Sr Credit Controller' AND Description='Sr Credit Controller'
	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformCancel' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END

	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformRefund' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END
END
SELECT @OrgID =OrgID FROM Organization(NOLOCK) WHERE Name='RLS Jamnagar'
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT @RoleID=RoleID FROM ROLE(NOLOCK) WHERE OrgID=@OrgID AND RoleName='Sr Credit Controller' AND Description='Sr Credit Controller'
	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformCancel' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END

	SELECT @TaskActionID=TaskActionID FROM Taskactions(NOLOCK) where ActionName='PerformRefund' AND Category='Payment' 

	IF NOT EXISTS (SELECT 1 FROM TaskActionOrgMapping (NOLOCK) WHERE TaskActionID=@TaskActionID AND OrgID=@OrgID AND RoleID=@RoleID)
	BEGIN
		INSERT INTO TaskActionOrgMapping(TaskActionID,RoleID,OrgID,CreatedAt,CreatedBy)
		SELECT @TaskActionID,@RoleID,@OrgID,GETDATE(),182
	END
END
-------------------------TaskActionOrgMapping End
GO


DECLARE @ReportID INT,@RoleID BIGINT,@OrgID INT,@SpID INT
SELECT @OrgID =OrgID FROM Organization WHERE Name='RLS-Covid (Mumbai)'
SELECT @RoleID =RoleID FROM Role WHERE OrgID=@OrgID AND RoleName='Administrator' AND LangCode='en-GB'

IF NOT EXISTS (SELECT 1 FROM ReportExcelSp WHERE  Name='pGetDumpBeforeInvoice' AND Description='Dump Before Invoice')
BEGIN
 INSERT INTO ReportExcelSp (Name,Description)
 SELECT 'pGetDumpBeforeInvoice','Dump Before Invoice'
END
SELECT @SpID =ID FROM ReportExcelSp WHERE  Name='pGetDumpBeforeInvoice' AND Description='Dump Before Invoice'

IF NOT EXISTS (SELECT 1 FROM ReportExcelMaster (NOLOCK) WHERE ExcelName='Dump Before Invoice' AND SP=@SpID AND ReportName='Dump Before Invoice' AND Parametertype='ShowDateRangePopup')
BEGIN
  INSERT INTO ReportExcelMaster(ExcelName,SP,ReportName,ParameterType,IsActive)
  SELECT 'Dump Before Invoice',@SpID,'Dump Before Invoice','ShowDateRangePopup',1
END

SELECT @ReportID =ID FROM   ReportExcelMaster (NOLOCK) WHERE ExcelName='Dump Before Invoice' AND SP=@SpID AND ReportName='Dump Before Invoice' AND Parametertype='ShowDateRangePopup'

IF NOT EXISTS ( SELECT 1 FROM ReportExcelRoleMapping (NOLOCK) WHERE   Reportid=@ReportID AND RoleID=@RoleID )
BEGIN
	INSERT INTO ReportExcelRoleMapping (Reportid,RoleID,IsActive,Createdat)
	SELECT @ReportID,@RoleID,1,GETDATE()
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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
 IF EXISTS (SELECT 1 FROM reasonMaster R (NOLOCK) INNER JOIN reasontype RT (NOLOCK) ON R.ReasonTypeID=RT.typeID AND TypeCode='RM' AND Displaytext='Audit Reason' AND Status='A')
			 BEGIN
				UPDATE R
				SET R.Status='D'
				FROM reasonMaster R (NOLOCK) INNER JOIN reasontype RT (NOLOCK) ON R.ReasonTypeID=RT.typeID AND TypeCode='RM' AND Displaytext='Audit Reason' AND Status='A'
			 END
			 IF EXISTS (SELECT 1 FROM reasonMaster R (NOLOCK) INNER JOIN reasontype RT (NOLOCK) ON R.ReasonTypeID=RT.typeID AND TypeCode='TM' AND Displaytext='Audit Reason'  AND Status='A')
			 BEGIN
				UPDATE R
				SET R.Status='D'
				FROM reasonMaster R (NOLOCK) INNER JOIN reasontype RT (NOLOCK) ON R.ReasonTypeID=RT.typeID AND TypeCode='CMR' AND Displaytext='Audit Reason'  AND Status='A'
			 END
			 IF EXISTS (SELECT 1 FROM reasonMaster R (NOLOCK) INNER JOIN reasontype RT (NOLOCK) ON R.ReasonTypeID=RT.typeID AND TypeCode='CMR' AND Displaytext='Audit Reason' AND Status='A')
			 BEGIN
				UPDATE R
				SET R.Status='D'
				FROM reasonMaster R (NOLOCK) INNER JOIN reasontype RT (NOLOCK) ON R.ReasonTypeID=RT.typeID AND TypeCode='CMR' AND Displaytext='Audit Reason'
			 END
GO

 DECLARE @MenuID BIGINT,@RoleID BIGINT,@PageID INT,@OrgID INT
 SELECT @PageID=PageID FROM Pages (NOLOCK) where Pageurl='/HomeCollection/homecollection.aspx'
 SELECT @OrgID =OrgID FROM Organization (NOLOCK) WHERE Name='RLS-Covid (Mumbai)'
 SELECT @RoleID=RoleID FROM Role WHERE OrgID=@OrgID AND RoleName='DEO Home Visit'
 SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster
 IF NOT EXISTS (SELECT 1 FROM MenuMaster where DisplayText='Home collection' AND PageID=@PageID AND OrgID=@OrgID And Languagecode='en-GB')
 BEGIN
		INSERT INTO MenuMaster (MenuID,DisplayText,ParentID,OrgID,PageID,Languagecode,Createdat)
		SELECT @MenuID,'Home collection',0,@OrgID,@PageID,'en-GB',GETDATE()
 END

 SELECT @MenuID=MenuID FROM MenuMaster where DisplayText='Home collection' AND PageID=@PageID AND OrgID=@OrgID And Languagecode='en-GB'

 If NOT EXISTS(SELECT 1 FROM RoleMenu WHERE RoleID=@RoleID AND MenuID=@MenuID)
 BEGIN
   INSERT INTO RoleMenu (RoleID,MenuID,Ismapped,Createdat)
   SELECT @RoleID,@MenuID,'Y',GETDATE()
 END 

 SELECT @OrgID =OrgID FROM Organization (NOLOCK) WHERE Name='RLS-Gorakhpur'
 SELECT @RoleID=RoleID FROM Role WHERE OrgID=@OrgID AND RoleName='DEO Home Visit'
 SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster
 IF NOT EXISTS (SELECT 1 FROM MenuMaster where DisplayText='Home collection' AND PageID=@PageID AND OrgID=@OrgID And Languagecode='en-GB')
 BEGIN
		INSERT INTO MenuMaster (MenuID,DisplayText,ParentID,OrgID,PageID,Languagecode,Createdat)
		SELECT @MenuID,'Home collection',0,@OrgID,@PageID,'en-GB',GETDATE()
 END

 SELECT @MenuID=MenuID FROM MenuMaster where DisplayText='Home collection' AND PageID=@PageID AND OrgID=@OrgID And Languagecode='en-GB'

 If NOT EXISTS(SELECT 1 FROM RoleMenu WHERE RoleID=@RoleID AND MenuID=@MenuID)
 BEGIN
   INSERT INTO RoleMenu (RoleID,MenuID,Ismapped,Createdat)
   SELECT @RoleID,@MenuID,'Y',GETDATE()
 END 

 SELECT @OrgID =OrgID FROM Organization (NOLOCK) WHERE Name='RLS Mumbai'
 SELECT @RoleID=RoleID FROM Role WHERE OrgID=@OrgID AND RoleName='DEO Home Visit'
 SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster
 IF NOT EXISTS (SELECT 1 FROM MenuMaster where DisplayText='Home collection' AND PageID=@PageID AND OrgID=@OrgID And Languagecode='en-GB')
 BEGIN
		INSERT INTO MenuMaster (MenuID,DisplayText,ParentID,OrgID,PageID,Languagecode,Createdat)
		SELECT @MenuID,'Home collection',0,@OrgID,@PageID,'en-GB',GETDATE()
 END

 SELECT @MenuID=MenuID FROM MenuMaster where DisplayText='Home collection' AND PageID=@PageID AND OrgID=@OrgID And Languagecode='en-GB'

 If NOT EXISTS(SELECT 1 FROM RoleMenu WHERE RoleID=@RoleID AND MenuID=@MenuID)
 BEGIN
   INSERT INTO RoleMenu (RoleID,MenuID,Ismapped,Createdat)
   SELECT @RoleID,@MenuID,'Y',GETDATE()
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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsNotifySMSNeededClientBill')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'IsNotifySMSNeededClientBill','SMS to patient from client billing page','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsNotifySMSNeededClientBill'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedPassportAsVisitLevel')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'NeedPassportAsVisitLevel','Do you Need to Passport No in Visit Level?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedPassportAsVisitLevel'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsPasswordScope')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'IsPasswordScope','Pswd new scope validation','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsPasswordScope'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsCreditClientRsHide')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'IsCreditClientRsHide','Rs.0 should not show for credit client sms','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsCreditClientRsHide'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='IsdisplayRobotofontonly')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'IsdisplayRobotofontonly','Do you want to display roboto font in testmaster?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='IsdisplayRobotofontonly'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='PKGContentsInBillPrint')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'PKGContentsInBillPrint','PKGContentsInBillPrint','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='PKGContentsInBillPrint'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedFranchiseeModule')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'NeedFranchiseeModule','Need FranchiseeModule','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedFranchiseeModule'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='HideLabShareAmnt')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'HideLabShareAmnt','Lab Franchisee share amount capture','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='HideLabShareAmnt'
    

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

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='PincodeandLocation')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'PincodeandLocation','Do you want to add PincodeandLocation without master','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='PincodeandLocation'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='SetDefaultTaskAssignToCreditController')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'SetDefaultTaskAssignToCreditController','Is SetDefaultTaskAssignToCreditController for Cancel?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='SetDefaultTaskAssignToCreditController'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go

   DECLARE @MetadataID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM metadata WHERE domain='FranchiseeType' AND Code='Own Lab' AND Langcode='en-GB')
   BEGIN
      INSERT INTO metadata (Domain,code,Displaytext,Langcode,createdat)
	  SELECT 'FranchiseeType','Own Lab','Own Lab Franchisee','en-GB',GETDATE()  
   END
    SELECT @MetadataID=  metadataID FROM metadata WHERE domain='FranchiseeType' AND Code='Own Lab' AND Langcode='en-GB'
    

    IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Own Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Own Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
	IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Own Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Own Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
	IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Own Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Own Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
	IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Own Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Own Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	END

	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM metadata WHERE domain='FranchiseeType' AND Code='Third Party Lab' AND Langcode='en-GB')
   BEGIN
      INSERT INTO metadata (Domain,code,Displaytext,Langcode,createdat)
	  SELECT 'FranchiseeType','Third Party Lab','Third Party Lab Franchisee','en-GB',GETDATE()  
   END
    SELECT @MetadataID=  metadataID FROM metadata WHERE domain='FranchiseeType' AND Code='Third Party Lab' AND Langcode='en-GB'
    

    IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Third Party Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Third Party Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
	IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Third Party Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Third Party Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
	IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Third Party Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Third Party Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
	IF NOT EXISTS(SELECT 1 FROM Metadataorgmapping where metadataID=@MetadataID AND OrgID=@OrgID AND Displaytext='Third Party Lab Franchisee') 
    Begin
        INSERT INTO Metadataorgmapping(metadataID, Displaytext, OrgID, CreatedAt, Langcode) 
        SELECT @MetadataID, 'Third Party Lab Franchisee', @OrgID, getdate(), 'en-GB'
    End
	END
    go
  DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedbillofSupplyNoInvoice')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'NeedbillofSupplyNoInvoice','Do you want to add bill of supply number in invoice?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedbillofSupplyNoInvoice'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
  DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='ClientBillCancellationrestriction')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'ClientBillCancellationrestriction','Restrict Cancel bill based on Client invoice cycle?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='ClientBillCancellationrestriction'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
  DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='Showbarcodeno')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'Showbarcodeno','Show barcode no in Enter Result Screen','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='Showbarcodeno'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
  DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='RestrictCreditDebitinInvoice')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'RestrictCreditDebitinInvoice','Resrtict Credit Debit amt in Invoice','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='RestrictCreditDebitinInvoice'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
  DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedModeofPaymentinBillWise')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'NeedModeofPaymentinBillWise','NeedModeofPaymentinBillWise','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedModeofPaymentinBillWise'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
  DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedItemLevelDiscount')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'NeedItemLevelDiscount','Do you need Item level discount?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedItemLevelDiscount'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
  DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='DiscountfromMaterorValue')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'DiscountfromMaterorValue','Do you need Item level discount from MAster or Value?','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='DiscountfromMaterorValue'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
	 
DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedRefPhysicianatPatientLevel')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'NeedRefPhysicianatPatientLevel','Need Ref Physician at Patient Level not at Visit Level','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedRefPhysicianatPatientLevel'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
	
	DECLARE @PageID BIGINT
DECLARE @MenuID INT
DECLARE @RoleID BIGINT
DECLARE @OrgID INT,@CreatedAT DATETIME
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SET @CreatedAT=GETDATE()
SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster
SELECT @PageID=MAX(PageID)+1 FROM Pages
SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='Credit Controller'
 

IF NOT EXISTS(SELECT PageID FROM Pages WHERE PageURL='/Invoice/CreditNoteUpdation.aspx')
BEGIN
    INSERT INTO Pages(PageID,PageName,PageURL,CreatedAt) 
    SELECT @PageID,'Credit Note','/Invoice/CreditNoteUpdation.aspx',GETDATE()
END
SELECT @PageID=PageID FROM Pages WHERE PageURL='/Invoice/CreditNoteUpdation.aspx'
IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Credit Note' AND MM.OrgId=@OrgID)
BEGIN
    INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
    SELECT @MenuID,'Credit Note',0,@OrgID,@PageID,@CreatedAT
END
SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Credit Note' AND MM.OrgId=@OrgID
IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
BEGIN
    INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
    SELECT @MenuID,@RoleID,'Y',@Createdat
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='Credit Controller'
SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster

IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Credit Note' AND MM.OrgId=@OrgID)
BEGIN
    INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
    SELECT @MenuID,'Credit Note',0,@OrgID,@PageID,@CreatedAT
END
SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Credit Note' AND MM.OrgId=@OrgID
IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
BEGIN
    INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
    SELECT @MenuID,@RoleID,'Y',@CreatedAt
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='Credit Controller'
SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster

IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Credit Note' AND MM.OrgId=@OrgID)
BEGIN
    INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
    SELECT @MenuID,'Credit Note',0,@OrgID,@PageID,@CreatedAT
END
SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Credit Note' AND MM.OrgId=@OrgID
IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
BEGIN
    INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
    SELECT @MenuID,@RoleID,'Y',@Createdat
END 

 GO
 DECLARE @ReportID INT,@RoleID BIGINT,@OrgID INT,@SpID INT
SELECT @OrgID =OrgID FROM Organization WHERE Name='RLS-Covid (Mumbai)'
SELECT @RoleID =RoleID FROM Role WHERE OrgID=@OrgID AND RoleName='Administrator' AND LangCode='en-GB'

IF NOT EXISTS (SELECT 1 FROM ReportExcelSp WHERE  Name='pGetCovidIntegrationStatus' AND Description='Covid Integration Status Report')
BEGIN
 INSERT INTO ReportExcelSp (Name,Description)
 SELECT 'pGetCovidIntegrationStatus','Covid Integration Status Report'
END
SELECT @SpID =ID FROM ReportExcelSp WHERE  Name='pGetCovidIntegrationStatus' AND Description='Covid Integration Status Report'

IF NOT EXISTS (SELECT 1 FROM ReportExcelMaster (NOLOCK) WHERE ExcelName='Covid Integration Status Report' AND SP=@SpID AND ReportName='Covid Integration Status Report' AND Parametertype='ShowDateRangePopup')
BEGIN
  INSERT INTO ReportExcelMaster(ExcelName,SP,ReportName,ParameterType,IsActive)
  SELECT 'Covid Integration Status Report',@SpID,'Covid Integration Status Report','ShowDateRangePopup',1
END

SELECT @ReportID =ID FROM   ReportExcelMaster (NOLOCK) WHERE ExcelName='Covid Integration Status Report' AND SP=@SpID AND ReportName='Covid Integration Status Report' AND Parametertype='ShowDateRangePopup'

IF NOT EXISTS ( SELECT 1 FROM ReportExcelRoleMapping (NOLOCK) WHERE   Reportid=@ReportID AND RoleID=@RoleID )
BEGIN
	INSERT INTO ReportExcelRoleMapping (Reportid,RoleID,IsActive,Createdat)
	SELECT @ReportID,@RoleID,1,GETDATE()
END  
GO
/* DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='InvoieGenBasdOnCheckbox')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'InvoieGenBasdOnCheckbox','InvoieGenBasdOnCheckbox','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='InvoieGenBasdOnCheckbox'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go*/
	 DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='AlrtBaseRateNotMappng')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'AlrtBaseRateNotMappng','AlrtForRateCardNtMapngInBilng','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='AlrtBaseRateNotMappng'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
	 DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='AlrtInvoiceCycleMandatory')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'AlrtInvoiceCycleMandatory','AlrtInvoiceCycleMandatory','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='AlrtInvoiceCycleMandatory'
    

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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
	 DECLARE  @OrgID BIGINT
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='PassportNo' AND FieldId='hdnPassportNo' AND ControlId='txtpassportno' AND OrgID=@OrgID)
 BEGIN
	 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
     Select 'PassportNo','N','Y','hdnPassportNo','txtpassportno',@OrgID
 END

 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='PassportNo' AND FieldId='hdnPassportNo' AND ControlId='txtpassportno' AND OrgID=@OrgID)
 BEGIN
	 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
     Select 'PassportNo','N','Y','hdnPassportNo','txtpassportno',@OrgID
 END
   
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='PassportNo' AND FieldId='hdnPassportNo' AND ControlId='txtpassportno' AND OrgID=@OrgID)
 BEGIN
	 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
     Select 'PassportNo','N','Y','hdnPassportNo','txtpassportno',@OrgID
 END
 
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
	 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='ReferringDoctor' AND FieldId='hdnReferringDoctor' AND ControlId='txtInternalExternalPhysician' AND OrgID=@OrgID)
	 BEGIN
		 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
		 Select 'ReferringDoctor','N','Y','hdnReferringDoctor','txtInternalExternalPhysician',@OrgID
	 END
  END
 
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='ReferringDoctor' AND FieldId='hdnReferringDoctor' AND ControlId='txtInternalExternalPhysician' AND OrgID=@OrgID)
 BEGIN
	 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
     Select 'ReferringDoctor','N','Y','hdnReferringDoctor','txtInternalExternalPhysician',@OrgID
 END

 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='ReferringDoctor' AND FieldId='hdnReferringDoctor' AND ControlId='txtInternalExternalPhysician' AND OrgID=@OrgID)
 BEGIN
	 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
     Select 'ReferringDoctor','N','Y','hdnReferringDoctor','txtInternalExternalPhysician',@OrgID
 END
   
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='ReferringDoctor' AND FieldId='hdnReferringDoctor' AND ControlId='txtInternalExternalPhysician' AND OrgID=@OrgID)
 BEGIN
	 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
     Select 'ReferringDoctor','N','Y','hdnReferringDoctor','txtInternalExternalPhysician',@OrgID
 END
 
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
	 IF NOT EXISTS (SELECT 1 FROM  RegistrationRepush WHERE AttributeName='ReferringDoctor' AND FieldId='hdnReferringDoctor' AND ControlId='txtInternalExternalPhysician' AND OrgID=@OrgID)
	 BEGIN
		 Insert Into RegistrationRepush (AttributeName,IsDeflag,IsRepush,FieldId,ControlId,OrgID)
		 Select 'ReferringDoctor','N','Y','hdnReferringDoctor','txtInternalExternalPhysician',@OrgID
	 END
  END
GO 

DECLARE @OrgID INT,@CreatedAt DATETIME,@RoleID BIGINT,@PageID INT 
SET @CreatedAt=GETDATE()
SELECT @PageID=PageID FROM Pages WHERE PageUrl='/Phlebotomist/Home.aspx'
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SELECT @RoleID=MAX(RoleID)+1 FROM Role
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Accession','Accession Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Accession','Accession Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Mumbai'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Accession','Accession Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END

SELECT @RoleID=RoleID FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
IF @OrgID is not null
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
	BEGIN
		INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
		SELECT @RoleID,'Accession','Accession Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
	END

	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Accession' AND Description='Accession Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
	IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
	BEGIN
		INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
		SELECT @pageID,@RoleID,1,@CreatedAt
	END
END
GO
DECLARE @OrgID INT,@CreatedAt DATETIME,@RoleID BIGINT,@PageID INT 
SET @CreatedAt=GETDATE()
SELECT @PageID=PageID FROM Pages WHERE PageUrl='/Phlebotomist/Home.aspx'
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SELECT @RoleID=MAX(RoleID)+1 FROM Role
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Phlebotomist','Phlebotomist Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Phlebotomist','Phlebotomist Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Mumbai'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Phlebotomist','Phlebotomist Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END

SELECT @RoleID=RoleID FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
IF @OrgID is not null
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
	BEGIN
		INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
		SELECT @RoleID,'Phlebotomist','Phlebotomist Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
	END

	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Phlebotomist' AND Description='Phlebotomist Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
	IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
	BEGIN
		INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
		SELECT @pageID,@RoleID,1,@CreatedAt
	END
END
GO
DECLARE @OrgID INT,@CreatedAt DATETIME,@RoleID BIGINT,@PageID INT 
SET @CreatedAt=GETDATE()
SELECT @PageID=MAX(PageID)+1 FROM Pages  
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SELECT @RoleID=MAX(RoleID)+1 FROM Role

IF NOT EXISTS (SELECT 1 FROM Pages where Pageurl='/Billing/FranchiseeBilling.aspx')
BEGIN
	INSERT INTO Pages (PageID,PageName,PageUrl,Createdat)
	SELECT @PageID,'Lab Quick Franchisee Billing','/Billing/FranchiseeBilling.aspx',@CreatedAt
END

SELECT @PageID=PageID FROM Pages where Pageurl='/Billing/FranchiseeBilling.aspx'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'LabReception','LabReception Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'LabReception','LabReception Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Mumbai'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'LabReception','LabReception Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
END

SELECT @RoleID=RoleID FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
IF @OrgID is not null
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y')
	BEGIN
		INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
		SELECT @RoleID,'LabReception','LabReception Franchisee',@CreatedAt,'en-GB',@OrgID,'Y'
	END

	SELECT @RoleID=RoleID FROM Role WHERE RoleName='LabReception' AND Description='LabReception Franchisee' AND Orgid=@OrgID AND IsFranchisee='Y'
	IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
	BEGIN
		INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
		SELECT @pageID,@RoleID,1,@CreatedAt
	END
END
GO
DECLARE @OrgID INT,@CreatedAt DATETIME,@RoleID BIGINT,@PageID INT 
SET @CreatedAt=GETDATE()
SELECT @PageID= PageID  FROM Pages  where pageurl='/Lab/Home.aspx'
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SELECT @RoleID=MAX(RoleID)+1 FROM Role
 
  
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Franchisee','Super Admin',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Franchisee','Super Admin',@CreatedAt,'en-GB',@OrgID,'Y'
END
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Mumbai'
IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y')
BEGIN
    INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
	SELECT @RoleID,'Franchisee','Super Admin',@CreatedAt,'en-GB',@OrgID,'Y'
END

SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y'
IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
BEGIN
	INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
	SELECT @pageID,@RoleID,1,@CreatedAt
END

SELECT @RoleID=MAX(RoleID)+1 FROM Role
SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
IF @OrgID is not null
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y')
	BEGIN
		INSERT INTO Role (RoleID,RoleName,Description,CreatedAt,LangCode,OrgID,IsFranchisee)
		SELECT @RoleID,'Franchisee','Super Admin',@CreatedAt,'en-GB',@OrgID,'Y'
	END

	SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee' AND Description='Super Admin' AND Orgid=@OrgID AND IsFranchisee='Y'
	IF NOT EXISTS (SELECT  1 FROM PageMapping WHERE RoleID=@RoleID AND PageID=@PageID)
	BEGIN
		INSERT INTO PageMapping (PageID,RoleID,SeqNo,CreatedAt)
		SELECT @pageID,@RoleID,1,@CreatedAt
	END
END
GO
------------------Franchisee Page Script Start
DECLARE @PageID BIGINT
DECLARE @MenuID INT
DECLARE @RoleID BIGINT
DECLARE @OrgID INT,@CreatedAT DATETIME
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SET @CreatedAT=GETDATE()
SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster
SELECT @PageID=MAX(PageID)+1 FROM Pages
 
IF NOT EXISTS(SELECT PageID FROM Pages WHERE PageURL='/Billing/FranchiseeBilling.aspx')
BEGIN
    INSERT INTO Pages(PageID,PageName,PageURL,CreatedAt) 
    SELECT @PageID,'Lab Quick Franchisee Billing','/Billing/FranchiseeBilling.aspx',GETDATE()
END
SELECT @PageID=PageID FROM Pages WHERE PageURL='/Billing/FranchiseeBilling.aspx'
--lab reception
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='LabReception' AND Description='LabReception Franchisee'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
--super admin
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='Super Admin' AND Description='Super Admin'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
END
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
SET @CreatedAT=GETDATE()
SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster

--lab reception
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='LabReception' AND Description='LabReception Franchisee'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
--super admin
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='Super Admin' AND Description='Super Admin'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
SET @CreatedAT=GETDATE()
SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster

--lab reception
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='LabReception' AND Description='LabReception Franchisee'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
--super admin
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='Super Admin' AND Description='Super Admin'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
SET @CreatedAT=GETDATE()
SELECT @MenuID=MAX(MenuID)+1 FROM MenuMaster

--lab reception
IF ISNULL(@OrgID,0) > 0
BEGIN
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='LabReception' AND Description='LabReception Franchisee'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
--super admin
	SELECT  @RoleID=  RoleID FROM [Role] WHERE OrgID=@OrgID  and RoleName='Super Admin' AND Description='Super Admin'
	IF ISNULL(@RoleID,0) > 0
	BEGIN
		IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID)
		BEGIN
			INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,CreatedAT) 
			SELECT @MenuID,'Lab Quick Franchisee Billing',0,@OrgID,@PageID,@CreatedAT
		END
		SELECT @MenuID=MenuID FROM MenuMaster MM   WHERE PageId=@PageID AND Displaytext='Lab Quick Franchisee Billing' AND MM.OrgId=@OrgID
		IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM WHERE MenuID=@MenuID AND ROleID=@RoleID  )
		BEGIN
			INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,Createdat) 
			SELECT @MenuID,@RoleID,'Y',@Createdat
		END
	END
END
------------------Franchisee Page Script End
GO
-------------------RestrictCreditDebitinInvoice config start
DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='RestrictCreditDebitinInvoice')
BEGIN
    INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	SELECT MAX(ConfigkeyID)+1,'RestrictCreditDebitinInvoice','Resrtict Credit Debit amt in Invoice','N',GETDATE() FROM ConfigKeyMaster 
END
SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='RestrictCreditDebitinInvoice' 
IF ISNULL(@OrgID,0) > 0
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
	End
END
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
IF ISNULL(@OrgID,0) > 0
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
	End
END
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
IF ISNULL(@OrgID,0) > 0
BEGIN
	IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
	Begin
		INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
		SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
	End
END
-------------------RestrictCreditDebitinInvoice config end
GO

DECLARE @RoleID BIGINT,@PRoleID BIGINT,@OrgID INT
SELECT @OrgID=OrgID FROM Organization where Name='RLS-Gorakhpur'
Select @RoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist Franchisee'
select @PRoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist'

 

if Not Exists(select 1 from RoleDeptMap where RoleID=@RoleID )
BEGIN
Insert into RoleDeptMap (RoleID,DeptID,IsActive,Createdat,CreatedBy)
Select @RoleID,Deptid,ISactive ,Getdate(),405 from RoleDeptMap where RoleID=@PRoleID
END
SELECT @OrgID=OrgID FROM Organization where Name='RLS Mumbai'
Select @RoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist Franchisee'
select @PRoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist'

 

if Not Exists(select 1 from RoleDeptMap where RoleID=@RoleID )
BEGIN
Insert into RoleDeptMap (RoleID,DeptID,IsActive,Createdat,CreatedBy)
Select @RoleID,Deptid,ISactive ,Getdate(),405 from RoleDeptMap where RoleID=@PRoleID
END
SELECT @OrgID=OrgID FROM Organization where Name='RLS-Covid (Mumbai)'
Select @RoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist Franchisee'
select @PRoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist'

 

if Not Exists(select 1 from RoleDeptMap where RoleID=@RoleID )
BEGIN
Insert into RoleDeptMap (RoleID,DeptID,IsActive,Createdat,CreatedBy)
Select @RoleID,Deptid,ISactive ,Getdate(),405 from RoleDeptMap where RoleID=@PRoleID
END
SELECT @OrgID=OrgID FROM Organization where Name='RLS Jamnagar'
Select @RoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist Franchisee'
select @PRoleID=RoleID from Role where OrGId=@OrgID and RoleName='Phlebotomist' and Description='Phlebotomist'

 

if Not Exists(select 1 from RoleDeptMap where RoleID=@RoleID )
BEGIN
Insert into RoleDeptMap (RoleID,DeptID,IsActive,Createdat,CreatedBy)
Select @RoleID,Deptid,ISactive ,Getdate(),405 from RoleDeptMap where RoleID=@PRoleID
END
GO

------------------
--------------------- Surya Script For Franchisee ---------------------
-------------------------------------------------- Need Client Logo against Client-------
   DECLARE @ConfigKeyID BIGINT, @OrgID BIGINT 
	 
 
   IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster WHERE ConfigKey='NeedClientLogo')
   BEGIN
      INSERT INTO ConfigKeyMaster (ConfigkeyID,Configkey,Displaytext,isinternal,createdat)
	  SELECT MAX(ConfigkeyID)+1,'NeedClientLogo','NeedClientLogo','N',GETDATE() FROM ConfigKeyMaster 
   END
    SELECT @ConfigKeyID=  ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='NeedClientLogo'
    
	SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'  
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
	SELECT @OrgID=OrgID FROM organization WHERE Name='RLS Jamnagar'
	IF @OrgID is not null
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@OrgID) AND @ConfigKeyID > 0
		Begin
			INSERT INTO ConfigOrgMaster(ConfigKeyID, ConfigValue, OrgID, CreatedAt, CreatedBy) 
			SELECT @ConfigKeyID, 'Y', @OrgID, getdate(), -1
		End
	END
    go
	-----------------------------------
-------------------------------- Collect Sample Added in Menu Master -------------------
DECLARE @OrgID INT  
DECLARE @MenuID INT

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SELECT @MenuID=MAX(MenuID) FROM MenuMaster
IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM  WHERE MM.DisplayText='Collect Sample' AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID+1,'Collect Sample',0,@OrgID,452 
END 

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
SELECT @MenuID=MAX(MenuID) FROM MenuMaster
IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM  WHERE MM.DisplayText='Collect Sample' AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID+1,'Collect Sample',0,@OrgID,452 
END 

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
SELECT @MenuID=MAX(MenuID) FROM MenuMaster
IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM  WHERE MM.DisplayText='Collect Sample' AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID+1,'Collect Sample',0,@OrgID,452 
END 

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
SELECT @MenuID=MAX(MenuID) FROM MenuMaster
IF NOT EXISTS(SELECT MenuID FROM MenuMaster MM  WHERE MM.DisplayText='Collect Sample' AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID+1,'Collect Sample',0,@OrgID,452 
END 

GO
-------------------------------------------
------------------------------------- Super Admin Menu Master ---------------------
DECLARE @RoleID BIGINT  
DECLARE @OrgID INT
DECLARE @RoleName Varchar(200) ='Franchisee'
DECLARE @DescriptionName Varchar(200) ='Super Admin' 
Declare @DeptID as Table (DeptID bigint)
 
DECLARE @MappedRoleId INT =0 
DECLARE @ActionId INT =0  
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and OrgID=@OrgID and LangCode='en-GB'
 

SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName ='Administrator' and Description='Administrator' and orgid = @OrgID and LangCode = 'en-GB') 
 
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)  
Select Distinct MenuID,@RoleID,435,getdate(),'Y' from (Select MENUID from MenuMaster where orgid=@OrgID and Displaytext in 
('Manage user' ,'BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Lab Quick Franchisee Billing','Collect Sample' ) 
 UNION
Select MENUID from Menumaster where orgid=@OrgID and Pageid in (SELECT PageID FROM PageMapping WHERE RoleId=@RoleID)
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ( 'Visit Search')
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ('Home') and Pageid=14
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T 
END
delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END

----Mumbai
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and OrgID=@OrgID and LangCode='en-GB'
  
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName ='Administrator' and Description='Administrator' and orgid = @OrgID and LangCode = 'en-GB') 
 
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)  
Select Distinct MenuID,@RoleID,435,getdate(),'Y' from (Select MENUID from MenuMaster where orgid=@OrgID and Displaytext in 
('Manage user' ,'BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Lab Quick Franchisee Billing','Collect Sample' ) 
 UNION
Select MENUID from Menumaster where orgid=@OrgID and Pageid in (SELECT PageID FROM PageMapping WHERE RoleId=@RoleID)
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ( 'Visit Search')
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ('Home') and Pageid=14
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T 
END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
-------RLS-Covid (Mumbai)
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and OrgID=@OrgID and LangCode='en-GB'
 
  
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName ='Administrator' and Description='Administrator' and orgid = @OrgID and LangCode = 'en-GB') 
 
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)  
Select Distinct MenuID,@RoleID,435,getdate(),'Y' from (Select MENUID from MenuMaster where orgid=@OrgID and Displaytext in 
('Manage user' ,'BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Lab Quick Franchisee Billing','Collect Sample' ) 
 UNION
Select MENUID from Menumaster where orgid=@OrgID and Pageid in (SELECT PageID FROM PageMapping WHERE RoleId=@RoleID)
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ( 'Visit Search')
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ('Home') and Pageid=14
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T 
END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
END
-----------RLS Jamnagar
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and OrgID=@OrgID and LangCode='en-GB'
  
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName ='Administrator' and Description='Administrator' and orgid = @OrgID and LangCode = 'en-GB') 
 
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)  
Select Distinct MenuID,@RoleID,435,getdate(),'Y' from (Select MENUID from MenuMaster where orgid=@OrgID and Displaytext in 
('Manage user' ,'BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Lab Quick Franchisee Billing','Collect Sample' ) 
 UNION
Select MENUID from Menumaster where orgid=@OrgID and Pageid in (SELECT PageID FROM PageMapping WHERE RoleId=@RoleID)
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ( 'Visit Search')
Union
Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID=@MappedRoleId) and Displaytext in ('Home') and Pageid=14
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T 
END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
GO
-------------------------------------------------------------------------------------------------
 ---------------------------------------LabReception Franchisee Role,Landing Page,RoleMenu,ActionMenu  Create --------------------  
DECLARE @RoleID BIGINT  
DECLARE @OrgID INT 
DECLARE @RoleName Varchar(200) ='LabReception'
DECLARE @DescriptionName Varchar(200) ='LabReception Franchisee'  
Declare @PageID Int
DECLARE @PageUrl varchar(255)='/Billing/FranchiseeBilling.aspx'

DECLARE @MappedRoleId INT =0   
-------------RLS-Gorakhpur
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'

SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')
 Declare @DeptID as Table (DeptID bigint)
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode='en-GB'
  
SELECT @PageID=PageID FROM Pages WHERE PageURL =@PageUrl
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate(),1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID and MM.Displaytext<>'Lab Quick Franchisee Billing')
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID From MenuMaster where orgid=@OrgID  and Displaytext in ('BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Collect Sample'
,'Patient Due Details') 
 UNION
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =(Select RoleID from Role where Description='Administrator' and OrgId=@OrgID and LangCode='en-GB')) and 
Displaytext in ('change password','Visit Search','Cash Closure')
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
-----------------------
-------------RLS Mumbai
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'

SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode='en-GB'
  
SELECT @PageID=PageID FROM Pages WHERE PageURL =@PageUrl
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate(),1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID and MM.Displaytext<>'Lab Quick Franchisee Billing')
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID From MenuMaster where orgid=@OrgID  and Displaytext in ('BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Collect Sample'
,'Patient Due Details') 
 UNION
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =(Select RoleID from Role where Description='Administrator' and OrgId=@OrgID and LangCode='en-GB')) and 
Displaytext in ('change password','Visit Search','Cash Closure')
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
-----------------------
------------- RLS-Covid (Mumbai)
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'

SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode='en-GB'
  
SELECT @PageID=PageID FROM Pages WHERE PageURL =@PageUrl
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate(),1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID and MM.Displaytext<>'Lab Quick Franchisee Billing')
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID From MenuMaster where orgid=@OrgID  and Displaytext in ('BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Collect Sample'
,'Patient Due Details') 
 UNION
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =(Select RoleID from Role where Description='Administrator' and OrgId=@OrgID and LangCode='en-GB')) and 
Displaytext in ('change password','Visit Search','Cash Closure')
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
----------------------- 
------------- RLS Jamnagar
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'

SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')
 
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode='en-GB'
  
SELECT @PageID=PageID FROM Pages WHERE PageURL =@PageUrl
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate(),1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID and MM.Displaytext<>'Lab Quick Franchisee Billing')
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID From MenuMaster where orgid=@OrgID  and Displaytext in ('BatchSheet','Bill Search','View Registration','Investigation Report','Sample search'
,'Sample Transfer','ReportList','Registration Franchisee Billing','Collect Sample'
,'Patient Due Details') 
 UNION
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =(Select RoleID from Role where Description='Administrator' and OrgId=@OrgID and LangCode='en-GB')) and 
Displaytext in ('change password','Visit Search','Cash Closure')
Union
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END 
GO

---------------------------------------End LabReception Franchisee Role,Landing Page,RoleMenu,ActionMenu  Create --------------------  
 ---------------------------------------Accession Franchisee Role,Landing Page,RoleMenu,ActionMenu  Create --------------------  
DECLARE @RoleID BIGINT  
DECLARE @OrgID INT 
DECLARE @RoleName Varchar(200) ='Accession'
DECLARE @DescriptionName Varchar(200) ='Accession Franchisee'  
DECLARE @PageID INT =0 
DECLARE @MappedRoleId INT =0  
Declare @DeptID as Table (DeptID bigint)

-------------RLS-Gorakhpur
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB')
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB'
End 

SELECT Top 1  @PageID=PageID FROM PageMapping WHERE RoleID=@MappedRoleId
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped) 
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From ( 
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext in 
('View Registration','Investigation Report','Sample search'
,'Collect Sample','Sample Transfer','Batchsheet' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search','Home')
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
---------------------------------
------------- RLS Mumbai
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB')
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB'
End 

SELECT Top 1  @PageID=PageID FROM PageMapping WHERE RoleID=@MappedRoleId
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped) 
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From ( 
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext in 
('View Registration','Investigation Report','Sample search'
,'Collect Sample','Sample Transfer','Batchsheet' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search','Home')
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
---------------------------------
------------- RLS-Covid (Mumbai)
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB')
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB'
End 

SELECT Top 1  @PageID=PageID FROM PageMapping WHERE RoleID=@MappedRoleId
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped) 
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From ( 
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext in 
('View Registration','Investigation Report','Sample search'
,'Collect Sample','Sample Transfer','Batchsheet' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search','Home')
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
---------------------------------
------------- RLS Jamnagar
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB')
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID and LangCode = 'en-GB'
End 

SELECT Top 1  @PageID=PageID FROM PageMapping WHERE RoleID=@MappedRoleId
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped) 
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From ( 
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext in 
('View Registration','Investigation Report','Sample search'
,'Collect Sample','Sample Transfer','Batchsheet' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search','Home')
)T

END
 Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
---------------------------------
GO
----------------------------------------------END----------------------------------------------------------------------------------

---------------------------------------Phlebotomist Franchisee Role,Landing Page,RoleMenu,ActionMenu  Create --------------------  
DECLARE @RoleID BIGINT  
DECLARE @OrgID INT 
DECLARE @RoleName Varchar(200) ='Phlebotomist'
DECLARE @DescriptionName Varchar(200) ='Phlebotomist Franchisee' 

DECLARE @MappedRoleId INT =0  
DECLARE @PageID INT =0 
Declare @DeptID as Table (DeptID bigint)
------------ RLS-Gorakhpur
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID)
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID
End 

SELECT Top 1  @PageID=PageID FROM Pages WHERE  PageURL='/Phlebotomist/Home.aspx'
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext 
in ('View Registration','Investigation Report','Sample search'  ,'Collect Sample' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search')
)T
END
Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
-----------------------------
------------ RLS Mumbai
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID)
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID
End 

SELECT Top 1  @PageID=PageID FROM Pages WHERE  PageURL='/Phlebotomist/Home.aspx'
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext 
in ('View Registration','Investigation Report','Sample search'  ,'Collect Sample' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search')
)T
END
Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
------------------------
------------ RLS-Covid (Mumbai)
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID)
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID
End 

SELECT Top 1  @PageID=PageID FROM Pages WHERE  PageURL='/Phlebotomist/Home.aspx'
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext 
in ('View Registration','Investigation Report','Sample search'  ,'Collect Sample' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search')
)T
END
Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END
----------------
------------ RLS Jamnagar
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
SET @MappedRoleId = (SELECT ROLEID FROM role where RoleName =@RoleName and Description=@RoleName and orgid = @OrgID and LangCode = 'en-GB')

IF NOT EXISTS(SELECT RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID)
BEGIN
Insert into Role (RoleID,RoleName,Description,CreatedBy,CreatedAt,OrgID,LangCode,IsFranchisee)
Select @RoleID,@RoleName,@DescriptionName,435,getdate(),@OrgID,'en-GB','Y'
END
else
Begin
SELECT @RoleID=RoleID FROM Role WHERE RoleName =@RoleName and Description=@DescriptionName and orgid = @OrgID
End 

SELECT Top 1  @PageID=PageID FROM Pages WHERE  PageURL='/Phlebotomist/Home.aspx'
IF NOT EXISTS(SELECT RoleID FROM PageMapping WHERE RoleId=@RoleID)
BEGIN
Insert into PageMapping (RoleID,PageID,CreatedBy,CreatedAt,SeqNo)
Select @RoleID,@PageID,435,getdate() ,1
END  
    
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleId = @RoleId)
BEGIN
	INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
	Select Distinct ActionId,@RoleID,Redirectpageid,SearchTypeid,IsMapped From ActionRoleMapping Where RoleID=@MappedRoleId and IsMapped='Y'
END

IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM 
JOIN MenuMaster MM ON MM.MenuID=RM.MenuID 
JOIN Pages P ON P.PageID=MM.PageID 
WHERE RM.RoleID=@RoleID AND MM.OrgId=@OrgID)
BEGIN
INSERT INTO RoleMenu(MenuID,RoleID,CreatedBy,CreatedAt,IsMapped)
Select Distinct MenuID,@RoleID,435,getdate(),'Y' From (
Select MenuID from MenuMaster where orgid=@OrgID and Displaytext 
in ('View Registration','Investigation Report','Sample search'  ,'Collect Sample' )
UNION
Select MenuID from MenuMaster where orgid=@OrgID and   Displaytext='Investigation Search'  and Pageid=454
UNION  
 Select MenuID from MenuMaster where orgid=@OrgID and Menuid in (
select Menuid From RoleMenu Where RoleID =@MappedRoleId) and 
Displaytext in ('change password','Visit Search')
)T
END
Delete from @DeptID
Insert into @DeptID
Select DeptID from InvDeptMaster where OrgID=@OrgID

IF Not Exists( Select 1 from RoleDeptMap where Roleid=@RoleID)
Begin 
Insert into RoleDeptMap (RoleID,DeptID,IsActive,CreatedAt,CreatedBy)
Select @RoleID,DeptID,'Y',Getdate(),435 From @DeptID
Where DeptID Not in (Select DeptID From RoleDeptMap Where ROleID =@RoleID)
END

GO
----------------------------------------------END----------------------------------------------------------------------------------
 ---------------------------------MenuMaster Entry ----------------
  Declare @MenuID BigInt, @OrgID int  ,@DisplayText Varchar(100) ,@PageID int
Set @DisplayText ='Lab Quick Franchisee Billing' 
Select @PageID=PageID from Pages where PageName='Lab Quick Franchisee Billing'

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB'  
END 

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB'  
END 

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB'  
END 

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB'  
END 
 
Set @DisplayText ='Registration Franchisee Billing'
Select @PageID=PageID from Pages where PageName='Registration Franchisee Billing'
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB' 
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB' 
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB' 
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
Select @MenuID=Max(Menuid)+1 from MenuMaster
IF Not Exists (Select * from MenuMaster Where Displaytext=@DisplayText and OrgID=@OrgID and PageID=@PageID)
Begin
Insert into Menumaster
Select @MenuID,@DisplayText,435,getdate(),null,null,0,@OrgID,@PageID,null,'en-GB' 
END

GO
--------------------------------------------------------
----------------------- Bill Pdf Report Insert --------

Declare @TemplateName varchar(200)='/Reliance/RLS/BillReportB2CHealthCouponCPFranchisee',@TemplateID int,@orgid int 
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
Select @TemplateID=Max(TemplateID)+1 From Invreportmaster where Orgid=@orgid 

IF Not Exists (Select 1 From Invreportmaster where Orgid=@orgid  and ReportTemplatename like '%BillReportB2CHealthCouponCPFranchisee')
Begin
Insert into InvReportMaster (TemplateID,ReportTemplateName,Isdefault,OrgID,Isactive,Type,TemplateName,LangCode)
Select @TemplateID,@TemplateName,Isdefault,@orgid,Isactive,Type,TemplateName,LangCode 
From Invreportmaster where Orgid=@orgid and ReportTemplatename='/Reliance/RLS/BillReportB2CHealthCouponCP'
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
Select @TemplateID=Max(TemplateID)+1 From Invreportmaster where Orgid=@orgid 

IF Not Exists (Select 1 From Invreportmaster where Orgid=@orgid  and ReportTemplatename like '%BillReportB2CHealthCouponCPFranchisee')
Begin
Insert into InvReportMaster (TemplateID,ReportTemplateName,Isdefault,OrgID,Isactive,Type,TemplateName,LangCode)
Select @TemplateID,@TemplateName,Isdefault,@orgid,Isactive,Type,TemplateName,LangCode 
From Invreportmaster where Orgid=@orgid and ReportTemplatename='/Reliance/RLS/BillReportB2CHealthCouponCP'
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
Select @TemplateID=Max(TemplateID)+1 From Invreportmaster where Orgid=@orgid 

IF Not Exists (Select 1 From Invreportmaster where Orgid=@orgid  and ReportTemplatename like '%BillReportB2CHealthCouponCPFranchisee')
Begin
Insert into InvReportMaster (TemplateID,ReportTemplateName,Isdefault,OrgID,Isactive,Type,TemplateName,LangCode)
Select @TemplateID,@TemplateName,Isdefault,@orgid,Isactive,Type,TemplateName,LangCode 
From Invreportmaster where Orgid=@orgid and ReportTemplatename='/Reliance/RLS/BillReportB2CHealthCouponCP'
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
Select @TemplateID=Max(TemplateID)+1 From Invreportmaster where Orgid=@orgid 

IF Not Exists (Select 1 From Invreportmaster where Orgid=@orgid  and ReportTemplatename like '%BillReportB2CHealthCouponCPFranchisee')
Begin
Insert into InvReportMaster (TemplateID,ReportTemplateName,Isdefault,OrgID,Isactive,Type,TemplateName,LangCode)
Select @TemplateID,@TemplateName,Isdefault,@orgid,Isactive,Type,TemplateName,LangCode 
From Invreportmaster where Orgid=@orgid and ReportTemplatename='/Reliance/RLS/BillReportB2CHealthCouponCP'
END
GO
------------------------------------------------------------------------------------------------

------------------------ TemplateDetailMaster Table level Bill Pdf Entry ---------

Declare @TemplateName varchar(200)='/Reliance/RLS/BillReportB2CHealthCouponCPFranchisee',@TemplateID int,@orgid int 
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur' 

IF Not Exists (Select 1 From TemplateDetailMaster where Orgid=@orgid  and ReportTemplateName like '%BillReportB2CHealthCouponCPFranchisee')
Begin 
Insert into TemplateDetailMaster (ParentTemplateID,ReportType,ReportTemplateName,OrgID)
Select  TemplateID,'Bill', @TemplateName,@OrgID
From Invreportmaster where Orgid=@orgid and ReportTemplatename like '/Reliance/RLS/BillReportB2CHealthCouponCP'
END
 
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
IF Not Exists (Select 1 From TemplateDetailMaster where Orgid=@orgid  and ReportTemplateName like '%BillReportB2CHealthCouponCPFranchisee')
Begin 
Insert into TemplateDetailMaster (ParentTemplateID,ReportType,ReportTemplateName,OrgID)
Select  TemplateID,'Bill', @TemplateName,@OrgID
From Invreportmaster where Orgid=@orgid and ReportTemplatename like '/Reliance/RLS/BillReportB2CHealthCouponCP'
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
IF Not Exists (Select 1 From TemplateDetailMaster where Orgid=@orgid  and ReportTemplateName like '%BillReportB2CHealthCouponCPFranchisee')
Begin 
Insert into TemplateDetailMaster (ParentTemplateID,ReportType,ReportTemplateName,OrgID)
Select  TemplateID,'Bill', @TemplateName,@OrgID
From Invreportmaster where Orgid=@orgid and ReportTemplatename like '/Reliance/RLS/BillReportB2CHealthCouponCP'
END

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
IF Not Exists (Select 1 From TemplateDetailMaster where Orgid=@orgid  and ReportTemplateName like '%BillReportB2CHealthCouponCPFranchisee')
Begin 
Insert into TemplateDetailMaster (ParentTemplateID,ReportType,ReportTemplateName,OrgID)
Select  TemplateID,'Bill', @TemplateName,@OrgID
From Invreportmaster where Orgid=@orgid and ReportTemplatename like '/Reliance/RLS/BillReportB2CHealthCouponCP'
END  
GO
------------------------------------------------------------------------------------------------
 ----------------------------- TaskActionMapping Entry  ---------------------------
 Declare @RoleID BigInt,@OrgID Int
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Sr Credit Controller' and Description='Sr Credit Controller' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66))
 

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID
  
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66))
 

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Phlebotomist'  and Description='Phlebotomist Franchisee' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (22) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (22))
  

 --- Mumbai
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
SELECT @RoleID = RoleID FROM Role WHERE RoleName='Sr Credit Controller'  and Description='Sr Credit Controller' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66)) 

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID
  
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66))
 

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Phlebotomist'  and Description='Phlebotomist Franchisee' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (22) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (22))
  
--- RLS-Covid (Mumbai)
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
SELECT @RoleID = RoleID FROM Role WHERE RoleName='Sr Credit Controller' and Description='Sr Credit Controller' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66))

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID
  
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66)) 

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Phlebotomist'  and Description='Phlebotomist Franchisee' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (22) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (22))  

 --- RLS Jamnagar
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
SELECT @RoleID = RoleID FROM Role WHERE RoleName='Sr Credit Controller'  and Description='Sr Credit Controller' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66)) 

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID
  
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (43,66) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (43,66)) 

 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Phlebotomist'  and Description='Phlebotomist Franchisee' and OrgID=@OrgID
 
 Insert Into TaskActionOrgMapping (TaskActionID ,RoleID,OrgID,CreatedBy,CreatedAt)
 select TA.TaskactionID,@RoleID,@OrgID,435,Getdate() 
 from Taskactions TA 
 where TA.TaskActionID in (22) and Isnull(@RoleID,0) >0  and TA.TaskActionID Not in (
 Select TaskActionID from TaskActionOrgMapping Where RoleID=@RoleID and OrgID=@OrgID and TaskActionID in (22))
  

 GO
------------------------------------------------------------------------------------------
--------------------------------MIS Mapping Script ----------------
 Declare @RoleID BigInt,@OrgID Int
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID  
  
 Insert Into ReportOrgMapping (ReportID,RoleID,OrgID,IsMapped)
 Select RM.ReportID,@RoleID,@OrgID,Null 
 from ReportMaster RM WITH(NOLOCK) 
 Where  RM.ReportID in (5,7,10,59,60,62,63,73)  and ReportID Not in (
 Select ReportID from ReportOrgMapping Where RoleID=@RoleID)
 
 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID  
  
 Insert Into ReportOrgMapping (ReportID,RoleID,OrgID,IsMapped)
 Select RM.ReportID,@RoleID,@OrgID,Null 
 from ReportMaster RM WITH(NOLOCK) 
 Where  RM.ReportID in (5,7,10,59,60,62,63,73)  and ReportID Not in (
 Select ReportID from ReportOrgMapping Where RoleID=@RoleID)

 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID  
  
 Insert Into ReportOrgMapping (ReportID,RoleID,OrgID,IsMapped)
 Select RM.ReportID,@RoleID,@OrgID,Null 
 from ReportMaster RM WITH(NOLOCK) 
 Where  RM.ReportID in (5,7,10,59,60,62,63,73)  and ReportID Not in (
 Select ReportID from ReportOrgMapping Where RoleID=@RoleID)

 SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
 SELECT @RoleID = RoleID FROM Role WHERE RoleName='Franchisee' and OrgID=@OrgID  
  
 Insert Into ReportOrgMapping (ReportID,RoleID,OrgID,IsMapped)
 Select RM.ReportID,@RoleID,@OrgID,Null 
 from ReportMaster RM WITH(NOLOCK) 
 Where  RM.ReportID in (5,7,10,59,60,62,63,73)  and ReportID Not in (
 Select ReportID from ReportOrgMapping Where RoleID=@RoleID)
----------------------------------------
GO

Declare @OrgID Int 
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
Declare @Location varchar(50)='Franchisee'
Declare @Add1 Varchar(250)='Mumbai'
Declare @LocationCode Char(3)='022'
Declare @IsDefault VarChar(3)='N'
Declare @Landline Varchar(30)=''
  
Declare @AddressID bigint=(Select MaX(AddressID)+1 from OrganizationAddress)
Declare @OldAddressID bigint=(Select MIN(AddressID) from OrganizationAddress where  OrgID=@OrgID)
Declare @CurrentAddID bigint

IF not exists(select 1 from OrganizationAddress where Location=@Location and OrgID=@OrgID)
BEGIN
INSERT INTO OrganizationAddress(AddressID,OrgID,Location,LocationCode,Isdefault,CenterTypeCode,
Add1,CountryID,City,StateID,StartDTTM,EndDTTM,Status,IsMappedClients,LandLineNumber,IsFranchisee,TimeDifference,TimeZone,TimeFormat,DateFormat)
select @AddressID,@OrgID,@Location,@LocationCode,@IsDefault,CenterTypeCode,@Add1,CountryID,City,StateID,
StartDTTM,EndDTTM,Status,IsMappedClients,@Landline ,'Y','05:30:00.0000000','India Standard Time','hh:mm:ss tt','dd/MM/yyyy'
from OrganizationAddress where  OrgID=@OrgID and AddressID=@OldAddressID
END
ELSE
BEGIN
SELECT 'LOCATION ALREADY EXIST'
END

select @CurrentAddID=(select AddressID from OrganizationAddress where Location=@Location and OrgID=@OrgID)
---Visitnumber  Insert 
IF Not Exists (Select 1 from VisitNumberMaster where OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO VISITNUMBERMASter (OrgID,VisitNUmber,OrgAddressID)
select  @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END
---Billnumber in  Insert 
IF Not exists(select 1 from BillIdMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO BIllIDmaster (OrgID,BillNumber,OrgAddressID)
select @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END



-------------------BIll Printing-----------------------

Declare @BilltypeID bigint =(select MAx(BilltypeID) from BillTypeMaster)
IF Not exists (select  * from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')
BEGIN
INSERT  INTO BillTypeMaster(BilltypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)
SELECT @BilltypeID+1,3,'OPBill',@OrgID,@CurrentAddID
END
ELSE
BEGIN 
 SELECT 'Already exit in BilltypeMaster'
END
Declare @CurBilltypeID bigint =(select  Max(BillTypeID) from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')

IF NOT EXISTS(select  1 from billconfig  where  BillTypeID=@CurBilltypeID)
BEGIN
Declare @billtype bigint=(select Min(BilltypeID) from BillConfig)
INSERT  INTO BillConfig(ConfigKey,ConfigValue,BillTypeID)
select ConfigKey,ConfigValue,@CurBilltypeID from BillConfig where  BillTypeID=@billtype
END

GO

Declare @OrgID Int 
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
Declare @Location varchar(50)='Franchisee'
Declare @Add1 Varchar(250)='Mumbai'
Declare @LocationCode Char(3)='023'
Declare @IsDefault VarChar(3)='N'
Declare @Landline Varchar(30)=''
  
Declare @AddressID bigint=(Select MaX(AddressID)+1 from OrganizationAddress)
Declare @OldAddressID bigint=(Select MIN(AddressID) from OrganizationAddress where  OrgID=@OrgID)
Declare @CurrentAddID bigint

IF not exists(select 1 from OrganizationAddress where Location=@Location and OrgID=@OrgID)
BEGIN
INSERT INTO OrganizationAddress(AddressID,OrgID,Location,LocationCode,Isdefault,CenterTypeCode,
Add1,CountryID,City,StateID,StartDTTM,EndDTTM,Status,IsMappedClients,LandLineNumber,IsFranchisee,TimeDifference,TimeZone,TimeFormat,DateFormat)
select @AddressID,@OrgID,@Location,@LocationCode,@IsDefault,CenterTypeCode,@Add1,CountryID,City,StateID,
StartDTTM,EndDTTM,Status,IsMappedClients,@Landline ,'Y','05:30:00.0000000','India Standard Time','hh:mm:ss tt','dd/MM/yyyy'
from OrganizationAddress where  OrgID=@OrgID and AddressID=@OldAddressID
END
ELSE
BEGIN
SELECT 'LOCATION ALREADY EXIST'
END

select @CurrentAddID=(select AddressID from OrganizationAddress where Location=@Location and OrgID=@OrgID)
---Visitnumber  Insert 
IF Not Exists (Select 1 from VisitNumberMaster where OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO VISITNUMBERMASter (OrgID,VisitNUmber,OrgAddressID)
select  @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END
---Billnumber in  Insert 
IF Not exists(select 1 from BillIdMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO BIllIDmaster (OrgID,BillNumber,OrgAddressID)
select @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END



-------------------BIll Printing-----------------------

Declare @BilltypeID bigint =(select MAx(BilltypeID) from BillTypeMaster)
IF Not exists (select  * from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')
BEGIN
INSERT  INTO BillTypeMaster(BilltypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)
SELECT @BilltypeID+1,3,'OPBill',@OrgID,@CurrentAddID
END
ELSE
BEGIN 
 SELECT 'Already exit in BilltypeMaster'
END
Declare @CurBilltypeID bigint =(select  Max(BillTypeID) from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')

IF NOT EXISTS(select  1 from billconfig  where  BillTypeID=@CurBilltypeID)
BEGIN
Declare @billtype bigint=(select Min(BilltypeID) from BillConfig)
INSERT  INTO BillConfig(ConfigKey,ConfigValue,BillTypeID)
select ConfigKey,ConfigValue,@CurBilltypeID from BillConfig where  BillTypeID=@billtype
END

GO

Declare @OrgID Int 
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
Declare @Location varchar(50)='Franchisee'
Declare @Add1 Varchar(250)='Mumbai'
Declare @LocationCode Char(3)='024'
Declare @IsDefault VarChar(3)='N'
Declare @Landline Varchar(30)=''
  
Declare @AddressID bigint=(Select MaX(AddressID)+1 from OrganizationAddress)
Declare @OldAddressID bigint=(Select MIN(AddressID) from OrganizationAddress where  OrgID=@OrgID)
Declare @CurrentAddID bigint

IF not exists(select 1 from OrganizationAddress where Location=@Location and OrgID=@OrgID)
BEGIN
INSERT INTO OrganizationAddress(AddressID,OrgID,Location,LocationCode,Isdefault,CenterTypeCode,
Add1,CountryID,City,StateID,StartDTTM,EndDTTM,Status,IsMappedClients,LandLineNumber,IsFranchisee,TimeDifference,TimeZone,TimeFormat,DateFormat)
select @AddressID,@OrgID,@Location,@LocationCode,@IsDefault,CenterTypeCode,@Add1,CountryID,City,StateID,
StartDTTM,EndDTTM,Status,IsMappedClients,@Landline ,'Y','05:30:00.0000000','India Standard Time','hh:mm:ss tt','dd/MM/yyyy'
from OrganizationAddress where  OrgID=@OrgID and AddressID=@OldAddressID
END
ELSE
BEGIN
SELECT 'LOCATION ALREADY EXIST'
END

select @CurrentAddID=(select AddressID from OrganizationAddress where Location=@Location and OrgID=@OrgID)
---Visitnumber  Insert 
IF Not Exists (Select 1 from VisitNumberMaster where OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO VISITNUMBERMASter (OrgID,VisitNUmber,OrgAddressID)
select  @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END
---Billnumber in  Insert 
IF Not exists(select 1 from BillIdMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO BIllIDmaster (OrgID,BillNumber,OrgAddressID)
select @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END



-------------------BIll Printing-----------------------

Declare @BilltypeID bigint =(select MAx(BilltypeID) from BillTypeMaster)
IF Not exists (select  * from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')
BEGIN
INSERT  INTO BillTypeMaster(BilltypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)
SELECT @BilltypeID+1,3,'OPBill',@OrgID,@CurrentAddID
END
ELSE
BEGIN 
 SELECT 'Already exit in BilltypeMaster'
END
Declare @CurBilltypeID bigint =(select  Max(BillTypeID) from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')

IF NOT EXISTS(select  1 from billconfig  where  BillTypeID=@CurBilltypeID)
BEGIN
Declare @billtype bigint=(select Min(BilltypeID) from BillConfig)
INSERT  INTO BillConfig(ConfigKey,ConfigValue,BillTypeID)
select ConfigKey,ConfigValue,@CurBilltypeID from BillConfig where  BillTypeID=@billtype
END

GO

Declare @OrgID Int 
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar'
Declare @Location varchar(50)='Franchisee'
Declare @Add1 Varchar(250)='Mumbai'
Declare @LocationCode Char(3)='024'
Declare @IsDefault VarChar(3)='N'
Declare @Landline Varchar(30)=''
  
Declare @AddressID bigint=(Select MaX(AddressID)+1 from OrganizationAddress)
Declare @OldAddressID bigint=(Select MIN(AddressID) from OrganizationAddress where  OrgID=@OrgID)
Declare @CurrentAddID bigint

IF not exists(select 1 from OrganizationAddress where Location=@Location and OrgID=@OrgID)
BEGIN
INSERT INTO OrganizationAddress(AddressID,OrgID,Location,LocationCode,Isdefault,CenterTypeCode,
Add1,CountryID,City,StateID,StartDTTM,EndDTTM,Status,IsMappedClients,LandLineNumber,IsFranchisee,TimeDifference,TimeZone,TimeFormat,DateFormat)
select @AddressID,@OrgID,@Location,@LocationCode,@IsDefault,CenterTypeCode,@Add1,CountryID,City,StateID,
StartDTTM,EndDTTM,Status,IsMappedClients,@Landline ,'Y','05:30:00.0000000','India Standard Time','hh:mm:ss tt','dd/MM/yyyy'
from OrganizationAddress where  OrgID=@OrgID and AddressID=@OldAddressID
END
ELSE
BEGIN
SELECT 'LOCATION ALREADY EXIST'
END

select @CurrentAddID=(select AddressID from OrganizationAddress where Location=@Location and OrgID=@OrgID)
---Visitnumber  Insert 
IF Not Exists (Select 1 from VisitNumberMaster where OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
IF (Isnull(@OrgID,0)>0)
Begin
INSERT  INTO VISITNUMBERMASter (OrgID,VisitNUmber,OrgAddressID)
select  @OrgID,0,@CurrentAddID
END
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END
---Billnumber in  Insert 
IF Not exists(select 1 from BillIdMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
IF (Isnull(@OrgID,0)>0)
Begin
INSERT  INTO BIllIDmaster (OrgID,BillNumber,OrgAddressID)
select @OrgID,0,@CurrentAddID
END
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END



-------------------BIll Printing-----------------------

Declare @BilltypeID bigint =(select MAx(BilltypeID) from BillTypeMaster)
IF Not exists (select  * from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')
BEGIN
INSERT  INTO BillTypeMaster(BilltypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)
SELECT @BilltypeID+1,3,'OPBill',@OrgID,@CurrentAddID
END
ELSE
BEGIN 
 SELECT 'Already exit in BilltypeMaster'
END
Declare @CurBilltypeID bigint =(select  Max(BillTypeID) from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')

IF NOT EXISTS(select  1 from billconfig  where  BillTypeID=@CurBilltypeID)
BEGIN
Declare @billtype bigint=(select Min(BilltypeID) from BillConfig)
INSERT  INTO BillConfig(ConfigKey,ConfigValue,BillTypeID)
select ConfigKey,ConfigValue,@CurBilltypeID from BillConfig where  BillTypeID=@billtype
END

GO
-----------------------------------------------------------------
---------------------Remote Registration Role - Sample Transfer - Drop down is missing start
DECLARE @ActionId INT =0,@RoleId INT =0,@PageId INT =0,@OrgId INT =0
SET @ActionId = (SELECT ACTIONID FROM actionmaster where actionname ='TransferSample' and LanguageCode = 'en-GB')
SET @PageId = (SELECT Pageid FROM Pages where Pagename ='Sample Transfer')
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
IF ISNULL(@OrgID,0) > 0
BEGIN	
	SET @RoleId = (SELECT ROLEID FROM role where RoleName ='Remote Registration' and orgid = @OrgID and LangCode = 'en-GB')	
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE Actionid = @ActionId AND RoleId = @RoleId) AND ISNULL(@RoleId,0) > 0
	BEGIN
		INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
		VALUES(@ActionId,@RoleId,@PageId,46,'Y')
	END
END
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
IF ISNULL(@OrgID,0) > 0
BEGIN	
	SET @RoleId = (SELECT ROLEID FROM role where RoleName ='Remote Registration' and orgid = @OrgID and LangCode = 'en-GB')	
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE Actionid = @ActionId AND RoleId = @RoleId) AND ISNULL(@RoleId,0) > 0
	BEGIN
		INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
		VALUES(@ActionId,@RoleId,@PageId,46,'Y')
	END
END
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
IF ISNULL(@OrgID,0) > 0
BEGIN	
	SET @RoleId = (SELECT ROLEID FROM role where RoleName ='Remote Registration' and orgid = @OrgID and LangCode = 'en-GB')	
	IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE Actionid = @ActionId AND RoleId = @RoleId) AND ISNULL(@RoleId,0) > 0
	BEGIN
		INSERT INTO ActionRoleMapping(ActionId,RoleID,Redirectpageid,SearchTypeid,IsMapped)
		VALUES(@ActionId,@RoleId,@PageId,46,'Y')
	END
END
---------------------Remote Registration Role - Sample Transfer - Drop down is missing End
GO
---------------------------
DECLARE @ActionID BIGINT,@RoleID BIGINT,@OrgID INT,@SearchTypeID INT, @PageID INT
SELECT @ActionID=ActionID FROM ActionMaster WHERE Actioncode='Show_Report_InvestigationReport'
SELECT @PageID=PageID FROM Pages where Pageurl ='/Investigation/InvestigationReport.aspx'
select @SearchTypeID=SearchTypeID from searchtypemaster where searchtypeName='Lab'

SELECT @OrgID=OrgID FROM Organization WHERE Name='RLS-Gorakhpur'
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee'  AND OrgID=@OrgID

IF NOT EXISTS(SELECT 1 FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID and SearchTypeID = @SearchTypeID)
BEGIN
   INSERT INTO ActionRoleMapping (ActionID,ROleID,RedirectpageID,SearchTypeID,Createdat,createdby,IsMapped)
   SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,GETDATE(),182,'Y'
END


SELECT @OrgID=OrgID FROM Organization WHERE Name='RLS Mumbai'
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee'  AND OrgID=@OrgID

IF NOT EXISTS(SELECT 1 FROM ActionRoleMapping WHERE ActionID=@actionID AND RoleID=@RoleID  and SearchTypeID = @SearchTypeID)
BEGIN
   INSERT INTO ActionRoleMapping (ActionID,ROleID,RedirectpageID,SearchTypeID,Createdat,createdby,IsMapped)
   SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,GETDATE(),182,'Y'
END

SELECT @OrgID=OrgID FROM Organization WHERE Name='RLS-Covid (Mumbai)'
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee'  AND OrgID=@OrgID

IF NOT EXISTS(SELECT 1 FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID  and SearchTypeID = @SearchTypeID)
BEGIN
   INSERT INTO ActionRoleMapping (ActionID,ROleID,RedirectpageID,SearchTypeID,Createdat,createdby,IsMapped)
   SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,GETDATE(),182,'Y'
END

SELECT @OrgID=OrgID FROM Organization WHERE Name='RLS Jamnagar'
SELECT @RoleID=RoleID FROM Role WHERE RoleName='Franchisee'  AND OrgID=@OrgID

IF NOT EXISTS(SELECT 1 FROM ActionRoleMapping WHERE ActionID=@ActionID AND RoleID=@RoleID  and SearchTypeID = @SearchTypeID)
BEGIN
   INSERT INTO ActionRoleMapping (ActionID,ROleID,RedirectpageID,SearchTypeID,Createdat,createdby,IsMapped)
   SELECT @ActionID,@RoleID,@PageID,@SearchTypeID,GETDATE(),182,'Y'
END

GO

---------------------------------------------------------
---------------PageContextActionMapping Entry For Patient Demography level by Surya.G-----------------
Declare @OrgID Int,@RoleID Bigint
Declare @PageContextID As Table (PageContextID Int,ActionTypeID Int,TemplateID Int,ContextType Varchar(10) )
Insert into @PageContextID
Select 65 ,9,22,'CP'
Union
Select 65 ,17,25,'CP'
Union
Select 65 ,9,21,'P'
Union
Select 65,17,25,'P'
---RLS-Gorakhpur
Select @OrgID=OrgID From Organization Where Name='RLS-Gorakhpur'
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='Super Admin' and RoleName='Franchisee'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)

---RLS Mumbai
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai' 
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='Super Admin' and RoleName='Franchisee'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)

---RLS-Covid (Mumbai)
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)' 
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='Super Admin' and RoleName='Franchisee'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)

---RLS Jamnagar
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar' 
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='Super Admin' and RoleName='Franchisee'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)
----------------
---RLS-Gorakhpur
Select @OrgID=OrgID From Organization Where Name='RLS-Gorakhpur'
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='LabReception' and RoleName='LabReception'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)

---RLS Mumbai
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai' 
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='LabReception' and RoleName='LabReception'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)

---RLS-Covid (Mumbai)
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)' 
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='LabReception' and RoleName='LabReception'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)

---RLS Jamnagar
SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Jamnagar' 
Select @RoleID =RoleID From ROle where OrgID=@OrgID and Description='LabReception' and RoleName='LabReception'

Insert into PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,CreatedBy,Createdat)
Select PageContextID,@RoleID,ActionTypeID,TemplateID,ContextType,'Report','Y',435,Getdate() From @PageContextID Where PageContextID Not in (
Select PageContextID from PageContextActionMapping Where RoleID=@RoleID and PageContextID in (select Pagecontextid from @PageContextID) and ActionTypeID in (9,17)
)
-------------------------------
GO
---------------------------------
/**for RLS-GORAKPUR Start**/
/** Client Billing -- Registration SMS for Client Billing Start**/
DECLARE @PageID INT,@RoleID BIGINT,@OrgID INT,@PageContextID INT,@TypeID INT,@PageUrl NVARCHAR(200),
        @CreatedAt DATETIME,@CreatedBy BIGINT,@ButtonName NVARCHAR(100),@ButtonValue NVARCHAR(100),@ActionTypeID INT,
        @TemplateTypeID INT,@TemplateID INT

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur'
SET @PageUrl='/Billing/ClientBilling.aspx'
SET @CreatedAt=GETDATE()
SET @CreatedBy =182
SET @ButtonName='btnGenerate'
SET @ButtonValue='Generate Bill'
SELECT @PageID =PageID FROM Pages (NOLOCK) WHERE PageURL LIKE ''+@PageUrl+''
--select @PageID,@PageUrl,@ButtonName,@ButtonValue

SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and subject ='TAT'
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='DEO B2B' AND OrgID=@OrgID
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=97 AND ActionTypeID=@ActionTypeID and ContextType = 'CP' and AdditionalContext ='notify')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,97,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and ISNULL(subject,'') =''
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='DEO B2B' AND OrgID=@OrgID
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=54 AND ActionTypeID=@ActionTypeID and ContextType = 'CP' and AdditionalContext ='notify')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,54,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--

/** Client Billing -- Registration SMS for Client Billing End**/
GO
/** Labquick Billing -- Registration SMS for Client Billing Start**/
DECLARE @PageID INT,@RoleID BIGINT,@OrgID INT,@PageContextID INT,@TypeID INT,@PageUrl NVARCHAR(200),
        @CreatedAt DATETIME,@CreatedBy BIGINT,@ButtonName NVARCHAR(100),@ButtonValue NVARCHAR(100),@ActionTypeID INT,
        @TemplateTypeID INT,@TemplateID INT

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Gorakhpur' 
SET @PageUrl='/Billing/LabQuickBilling.aspx'
SET @CreatedAt=GETDATE()
SET @CreatedBy =182
SET @ButtonName='btnGenerate'
SET @ButtonValue='Generate Bill'
SELECT @PageID =PageID FROM Pages (NOLOCK) WHERE PageURL LIKE ''+@PageUrl+''
--select @PageID,@PageUrl,@ButtonName,@ButtonValue
--entry with out TAT template
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and subject ='TAT'
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='LabReception' AND OrgID=@OrgID and Description = 'LabReception'
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=97 AND ActionTypeID=@ActionTypeID  and ContextType = 'CP')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,97,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
--entry with TAT template
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and ISNULL(subject,'') =''
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='LabReception' AND OrgID=@OrgID and Description = 'LabReception'
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=54 AND ActionTypeID=@ActionTypeID  and ContextType = 'CP')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,54,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
/**for RLS-GORAKPUR End**/
GO
/**for RLS Mumbai Start**/
/** Client Billing -- Registration SMS for Client Billing Start**/
DECLARE @PageID INT,@RoleID BIGINT,@OrgID INT,@PageContextID INT,@TypeID INT,@PageUrl NVARCHAR(200),
        @CreatedAt DATETIME,@CreatedBy BIGINT,@ButtonName NVARCHAR(100),@ButtonValue NVARCHAR(100),@ActionTypeID INT,
        @TemplateTypeID INT,@TemplateID INT

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai'
SET @PageUrl='/Billing/ClientBilling.aspx'
SET @CreatedAt=GETDATE()
SET @CreatedBy =182
SET @ButtonName='btnGenerate'
SET @ButtonValue='Generate Bill'
SELECT @PageID =PageID FROM Pages (NOLOCK) WHERE PageURL LIKE ''+@PageUrl+''
--select @PageID,@PageUrl,@ButtonName,@ButtonValue

SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and subject ='TAT'
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='DEO B2B' AND OrgID=@OrgID
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=97 AND ActionTypeID=@ActionTypeID and ContextType = 'CP' and AdditionalContext ='notify')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,97,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and ISNULL(subject,'') =''
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='DEO B2B' AND OrgID=@OrgID
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=54 AND ActionTypeID=@ActionTypeID and ContextType = 'CP' and AdditionalContext ='notify')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,54,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--

/** Client Billing -- Registration SMS for Client Billing End**/
GO
/** Labquick Billing -- Registration SMS for Client Billing Start**/
DECLARE @PageID INT,@RoleID BIGINT,@OrgID INT,@PageContextID INT,@TypeID INT,@PageUrl NVARCHAR(200),
        @CreatedAt DATETIME,@CreatedBy BIGINT,@ButtonName NVARCHAR(100),@ButtonValue NVARCHAR(100),@ActionTypeID INT,
        @TemplateTypeID INT,@TemplateID INT

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS Mumbai' 
SET @PageUrl='/Billing/LabQuickBilling.aspx'
SET @CreatedAt=GETDATE()
SET @CreatedBy =182
SET @ButtonName='btnGenerate'
SET @ButtonValue='Generate Bill'
SELECT @PageID =PageID FROM Pages (NOLOCK) WHERE PageURL LIKE ''+@PageUrl+''
--select @PageID,@PageUrl,@ButtonName,@ButtonValue
--entry with out TAT template
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and subject ='TAT'
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='LabReception' AND OrgID=@OrgID and Description = 'LabReception'
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=97 AND ActionTypeID=@ActionTypeID  and ContextType = 'CP')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,97,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
--entry with TAT template
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and ISNULL(subject,'') =''
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='LabReception' AND OrgID=@OrgID and Description = 'LabReception'
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=54 AND ActionTypeID=@ActionTypeID  and ContextType = 'CP')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,54,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
/**for RLS Mumbai End**/
GO
/**for RLS-Covid (Mumbai) Start**/
/** Client Billing -- Registration SMS for Client Billing Start**/
DECLARE @PageID INT,@RoleID BIGINT,@OrgID INT,@PageContextID INT,@TypeID INT,@PageUrl NVARCHAR(200),
        @CreatedAt DATETIME,@CreatedBy BIGINT,@ButtonName NVARCHAR(100),@ButtonValue NVARCHAR(100),@ActionTypeID INT,
        @TemplateTypeID INT,@TemplateID INT

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)'
SET @PageUrl='/Billing/ClientBilling.aspx'
SET @CreatedAt=GETDATE()
SET @CreatedBy =182
SET @ButtonName='btnGenerate'
SET @ButtonValue='Generate Bill'
SELECT @PageID =PageID FROM Pages (NOLOCK) WHERE PageURL LIKE ''+@PageUrl+''
--select @PageID,@PageUrl,@ButtonName,@ButtonValue
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
--SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and subject ='TAT'
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='DEO B2B' AND OrgID=@OrgID
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=97 AND ActionTypeID=@ActionTypeID and ContextType = 'CP' and AdditionalContext ='notify')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,97,'CP','Notify','N',@CreatedAt,@CreatedBy
END
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and ISNULL(subject,'') =''
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='DEO B2B' AND OrgID=@OrgID
--SELECT * FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=54 AND ActionTypeID=@ActionTypeID and ContextType = 'CP'
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=54 AND ActionTypeID=@ActionTypeID and ContextType = 'CP' and AdditionalContext ='notify')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,54,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--

/** Client Billing -- Registration SMS for Client Billing End**/
GO
/** Labquick Billing -- Registration SMS for Client Billing Start**/
DECLARE @PageID INT,@RoleID BIGINT,@OrgID INT,@PageContextID INT,@TypeID INT,@PageUrl NVARCHAR(200),
        @CreatedAt DATETIME,@CreatedBy BIGINT,@ButtonName NVARCHAR(100),@ButtonValue NVARCHAR(100),@ActionTypeID INT,
        @TemplateTypeID INT,@TemplateID INT

SELECT @OrgID = OrgID FROM organization WHERE Name='RLS-Covid (Mumbai)' 
SET @PageUrl='/Billing/LabQuickBilling.aspx'
SET @CreatedAt=GETDATE()
SET @CreatedBy =182
SET @ButtonName='btnGenerate'
SET @ButtonValue='Generate Bill'
SELECT @PageID =PageID FROM Pages (NOLOCK) WHERE PageURL LIKE ''+@PageUrl+''
--select @PageID,@PageUrl,@ButtonName,@ButtonValue
--entry with out TAT template
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and subject ='TAT'
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='LabReception' AND OrgID=@OrgID and Description = 'LabReception'
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=97 AND ActionTypeID=@ActionTypeID  and ContextType = 'CP')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,97,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
--entry with TAT template
SELECT  @ActionTypeID=ActionTypeID FROM ActionManagerType (NOLOCK) WHERE ActionType='APISMS' AND Type='Notify'
 --SELECT @TemplateID=TemplateID FROM ActionTemplate (NOLOCK) WHERE TemplateName='RSMS_P' and ISNULL(subject,'') =''
SELECT @PageContextID =PageContextID FROM PageContext (NOLOCK) WHERE PageID=@PageID AND ButtonName=@ButtonName AND ButtionValue=@ButtonValue
SELECT @RoleID =RoleID FROM Role WHERE RoleName='LabReception' AND OrgID=@OrgID and Description = 'LabReception'
IF NOT EXISTS (SELECT 1 FROM PageContextActionMapping (NOLOCK) WHERE PageContextID=@PageContextID AND RoleID=@RoleID AND TemplateID=54 AND ActionTypeID=@ActionTypeID  and ContextType = 'CP')
BEGIN
    INSERT INTO PageContextActionMapping (PageContextID,RoleID,ActionTypeID,TemplateID,ContextType,AdditionalContext,IsAttachment,Createdat,CreatedBy)
    SELECT @PageContextID,@RoleID,@ActionTypeID,54,'CP','Notify','N',@CreatedAt,@CreatedBy
END
--
--/***/
/**for RLS-Covid (Mumbai) End**/
