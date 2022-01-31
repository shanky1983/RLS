
declare @orgid int =112
declare @roleID int =(select Roleid from Role where RoleName='InventoryAdmin' and OrgID=@orgid)
declare @pageid int=0
DECLARE @PageName nvarchar(100)='ReportList'
DECLARE @MenuName nvarchar(100)='Reports'
DECLARE @PageURL nvarchar(100)='/Reports/ViewReportList.aspx'






if not exists (select * from pages where PageURL like '%'+@PageURL+'%')
begin

set @pageid =(select max(PageID)+1 from pages)
Insert into Pages(PageID,PageName,PageURL,CreatedAt)
values(@pageid,@PageName,@PageURL,GETDATE())

end
 
set @pageid =(select PageID from pages where PageURL like '%'+@PageURL+'%')
declare @MenuID int

if not exists(select * from MenuMaster where PageID=@pageid)
begin
set @MenuID=(select MAX(menuid)+1 from MenuMaster)
insert into MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID,LanguageCode,CreatedAt)
values(@MenuID,@MenuName,0,@orgid,@pageid,'en-GB',GETDATE())
end

select @MenuID=MenuID from MenuMaster  where PageID=@pageid and OrgId=@orgid

if not exists(select * from RoleMenu where RoleID=@roleID and MenuID=@MenuID)
begin 

INSERT INTO RoleMenu(MenuID,RoleID,IsMapped,CreatedAt)
values (@MenuID,@roleID,'Y',GETDATE())

end 



