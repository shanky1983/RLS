
declare @ActionID bigint
declare @Orgid bigint=112
declare @ActionName nvarchar(500)='View Quotation'
declare @QueryString nvarchar(500)='../Quotation/ViewQuotation.aspx?QID={IdentityValue}&SID={SupplierValue}&View=Print&IsPopup=Y'
declare @ActionCode nvarchar(500)='View_Print_Order_ViewQuotationOrder'
declare @Pageid bigint
declare @pageurl nvarchar(500)='/Quotation/ViewQuotation.aspx'
declare @pagename nvarchar(500)='ViewQuotation'
declare @searchTypeID nvarchar(500)=(select SearchTypeID from SearchTypeMaster  where SearchTypeName='Quotation')
declare @Rolename nvarchar(100) ='InventoryAdmin'
declare @RoleID bigint

set @RoleID=(SELECT RoleID FROM Role WHERE RoleName=@Rolename and OrgID=@Orgid)


IF  exists (select 1 from Pages where PageURL=@pageurl)
BEGIN 
	SET @Pageid=(select PageID from Pages where PageURL=@pageurl)
END 
	ELSE
		BEGIN 
		SET @Pageid=(select MAX(PageID)+1 from Pages)
		Insert into Pages(PageID,PageName,PageURL,CreatedAt,IsShareable)
		values(@Pageid,@pagename,@pageurl,GETDATE(),'N')
	
		END 
		
set @ActionID=(
select MAX(ActionID)+1 from ActionMaster
)

if not exists(select 1 from ActionMaster where ActionName=@ActionName and QueryString= @QueryString and @ActionCode=@ActionCode)
BEGIN 
Insert into ActionMaster (ActionID,ActionName,QueryString,ActionCode,LanguageCode)
values(@ActionID,@ActionName,@QueryString,@ActionCode,'en-GB')
END 
	ELSE 
		BEGIN 
		SET @ActionID=(select ActionID from ActionMaster where ActionName=@ActionName and QueryString= @QueryString and @ActionCode=@ActionCode)
		END 


Insert into ActionRoleMapping (ActionID,roleid,RedirectPageID,SearchTypeID,CreatedAt,IsMapped)
select @ActionID,@RoleID,@Pageid,@searchTypeID,GETDATE(),'Y'
 where Not exists(select 1 from ActionRoleMapping 
	where ActionID=@ActionID and RedirectPageID=@Pageid and SearchTypeID=@searchTypeID and RoleID=@RoleID)
	
	
	
	
	
	
	