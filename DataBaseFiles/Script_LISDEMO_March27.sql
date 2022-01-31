-------------------Arun - Save PDF added in Dispatch Controller Start-------------------
DECLARE @ROLEID INT =0,@ActionId INT = 0,@SearchTypeID INT =0,@PageId INT=0

SET @ROLEID = (SELECT TOP 1 RoleId FROM Role WHERE RoleName = 'Dispatch Controller' and OrgID = 220)
SET @SearchTypeID = (SELECT SearchTypeID FROM SearchTypeMaster WHERE SearchTypeName = 'Lab')
SET @PageId = (SELECT TOP 1 Pageid FROM Pages WHERE PageName ='Report Dispatch')
SET @ActionId =(SELECT COUNT(1) FROM ActionMaster)
IF NOT EXISTS (SELECT 1 FROM ActionMaster where ActionName ='Save PDF')
Begin
	INSERT INTO ActionMaster (ActionID,ActionName,ActionCode,IsShareable,LanguageCode)
	VALUES(@ActionId,'Save PDF','Save_PDF','N','en-GB')
	--SET @ActionId = SCOPE_IDENTITY()
END
--select @ROLEID as ROLEID,@SearchTypeID as '@SearchTypeID',@PageId as '@PageId',@ActionId as '@ActionId'
IF NOT EXISTS (SELECT 1 FROM ActionRoleMapping WHERE RoleID = @ROLEID AND ActionID = @ActionId AND SearchTypeID = @SearchTypeID AND RedirectPageID = @PageId)
BEGIN
	INSERT INTO ActionRoleMapping (ActionID,RoleID,RedirectPageID,SearchTypeID,IsMapped)
	VALUES(@ActionId,@ROLEID,@PageId,@SearchTypeID,'Y')
END
-------------------Arun - Save PDF added in Dispatch Controller End-------------------
---------------------------------arun LIS-DEMO Issue fixes start--------------
DECLARE @ActionId INT =0,@RoleId INT =0,@searchtypeid int =0,@RedirectPageId INT= 0

SET @RedirectPageId = (select top 1 Pageid from Pages where PageName = 'Batch wise Enterresult')
SET @searchtypeid =(select top 1 searchtypeid from searchtypemaster where SearchTypeName ='BillSearch')
SET @ActionId = (select top 1 actionid from ActionMaster where actionname = 'Edit Bill')
SET @RoleID = (select top 1 Roleid from Role where orgid = 220 and Rolename = 'LabReception')

IF NOT EXISTS(select * from ActionRoleMapping where actionid =@actionid and roleid = @RoleId and Redirectpageid = @RedirectPageId and Searchtypeid = @searchtypeid)
BEGIN
	INSERT INTO ActionRoleMapping (actionid,roleid,redirectpageid,searchtypeid,IsMapped)
	values(@ActionId,@RoleID,@RedirectPageId,@searchtypeid,'Y')
END
--select * from ActionRoleMapping where actionid =@actionid and roleid = @RoleId  and Redirectpageid = @RedirectPageId and Searchtypeid = @searchtypeid
DECLARE @ReasonTypeId INT =0
SET @ReasonTypeId = (select Top 1 Typeid from ReasonType where displaytext = 'rerun')
--select * from reasonmaster where Reasontypeid = @ReasonTypeId
IF NOT EXISTS(select * from InvReasonOrgMapping where reasonid in(select Reasonid from reasonmaster where Reasontypeid = @ReasonTypeId) and orgid = 98)
BEGIN
	INSERT INTO InvReasonOrgMapping (StatusId,ReasonId,Orgid,DisplayText,LangCode)
	SELECT 0,Reasonid,98,Reason,'en-GB' FROM reasonmaster where Reasontypeid = @ReasonTypeId
END
--update RerunRecollect Config
DECLARE @Configkeyid int=0
set @Configkeyid =(select top 1 configkeyid from configkeymaster where configkey = 'RerunRecollect')
--select * from ConfigOrgMaster where configkeyid = 37 and orgid = 98
--select * from ConfigOrgMaster where configkeyid = @Configkeyid and orgid = 220
Update configorgmaster set configvalue='Y'  where configkeyid = @Configkeyid and orgid = 98

DECLARE @Pageid int = 0,@Pagecontextid int = 0,@actiontypeid int =0,@templateid int =0,@RoleId int =0
SET @Pageid = (select top 1 Pageid from pages where pagename ='New Report Dispatch')
SET @PageContextid = (select top 1 pagecontextid from pagecontext where buttonname = 'REPORTPRINTBTN' and pageid= @Pageid)
SET @RoleId = (select top 1 roleid from Role where rolename = 'Dispatch Controller' and orgid = 220)
SET @actiontypeid= (SELECT TOP 1 Actiontypeid from ActionManagerType where ActionType ='ROUNDBPRINT')
SET @templateid =(SELECT TOP 1 TemplateId FROM ActionTemplate where templatename = 'REPORT_ROUNDBPDF')

IF NOT EXISTS(SELECT 1 FROM pagecontextactionmapping where pagecontextid=@PageContextid and roleid = @RoleId and Actiontypeid = @actiontypeid and templateid = @templateid)
begin
	insert into pagecontextactionmapping (pagecontextid,roleid,actiontypeid,templateid,contexttype,additionalcontext,isattachment)
	values(@PageContextid,@RoleId,@actiontypeid,@templateid,'P','Report','Y'),(@PageContextid,@RoleId,@actiontypeid,@templateid,'CP','Report','Y')
end
IF NOT EXISTS(select 1 from LocationPrintMap where orgid=220)
BEGIN
	INSERT INTO LocationPrintMap (Code,Printername,orgid,orgaddressid,isactive,printertype)
	values(415,'Kiosk Printer',220,415,1,'Kiosk'),(434,'Canon iR3225 UFR II',220,434,1,'')
END
--select * from LocationPrintMap where orgid=220
DECLARE @InvStatusId INT =0,@CurrentStatusID INT =0

SET @InvStatusId = (select top 1 Investigationstatusid from InvestigationStatus where Status = 'Co-authorize')
SET @CurrentStatusID =(select top 1 Investigationstatusid from InvestigationStatus where Status ='Completed')

IF NOT EXISTS(select * from InvStatusmapping where InvestigationStatusid=@CurrentStatusID and Mappingid=@InvStatusId and orgid = 98)
BEGIN
	INSERT INTO InvStatusmapping (investigationstatusid,mappingid,orgid,seqno)
	values(@CurrentStatusID,@InvStatusId,98,19)
END
--select * from InvStatusmapping where InvestigationStatusid=@CurrentStatusID and Mappingid=@InvStatusId and orgid = 98
DECLARE @ConfigKeyId INT =0

SET @ConfigKeyId = (SELECT CONFIGKEYID FROM CONFIGKEYMASTER WHERE CONFIGKEY ='DueBillreport')
IF NOT EXISTS(SELECT 1 FROM configorgmaster WHERE ORGID = 236 AND Configkeyid =@Configkeyid)
BEGIN
	INSERT INTO configorgmaster(Configkeyid,Configvalue,Orgid)
	VALUES(@Configkeyid,'Y',236)
END
---------------------------------arun LIS-DEMO Issue fixes end--------------