

declare @OrgId bigint=112

declare @pageid bigint
select @pageid=PageID from Pages where PageURL like '%/InvestigationStockUsage.aspx%'

declare @menuid bigint 
if not exists(select 1 from MenuMaster where PageID=@pageid and OrgId=@OrgId)

begin 
set @menuid=(select MAX(menuid)+1 from MenuMaster)
Insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,LanguageCode)
select @menuid,'Investigation Stock Usage',0,@OrgId,@pageid,'en-GB'
end 
	else
		begin 
	set @menuid=	(select MenuID from MenuMaster where PageID=@pageid and OrgId=@OrgId)
		end 


declare @roleid bigint
set @roleid=(select ROLEID from Role where OrgID=@OrgId and RoleName='InventoryAdmin')

Insert into RoleMenu(MenuID,RoleID,IsMapped)
select @menuid,@roleid,'Y' 
WHERE Not EXISTS (SELECT 1 FROM RoleMenu WHERE MenuID=@menuid AND RoleID=@roleid)