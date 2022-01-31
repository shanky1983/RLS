declare @ActionID bigint
declare @Orgid bigint=112
declare @ActionName nvarchar(500)='Issue Intend'
declare @QueryString nvarchar(500)='../StockIntend/IssueStock.aspx?intID={IntendID}&LocationID={LocID}&ReceivedOrgID={RecvOrgID}'
declare @ActionCode nvarchar(500)='Issue Intend'
declare @Pageid bigint
declare @pageurl nvarchar(500)='/StockIntend/IssueStock.aspx'
declare @pagename nvarchar(500)='Issued Stock'
declare @searchTypeID nvarchar(500)=(select SearchTypeID from SearchTypeMaster  where SearchTypeName='StockIssued')
declare @Rolename nvarchar(100) ='InventoryAdmin'
declare @RoleID bigint
set @RoleID=(SELECT RoleID FROM Role WHERE RoleName=@Rolename and OrgID=@Orgid)

IF  exists (select 1 from Pages where PageURL=@pageurl)
BEGIN 
	SET @Pageid=(select max(PageID) from Pages where PageURL=@pageurl)
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

if not exists(select * from ActionMaster where ActionName=@ActionName and QueryString= @QueryString and @ActionCode=@ActionCode)
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


--select * from ActionMaster where  ActionCode like '%Approve Quotation'
	
