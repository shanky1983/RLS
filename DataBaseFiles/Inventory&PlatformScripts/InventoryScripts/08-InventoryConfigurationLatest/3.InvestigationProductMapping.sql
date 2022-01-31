declare @RoleName nvarchar(100)='InventoryAdmin'
if not exists (select top 1 * from Pages where PageURL like '%/InventoryMaster/InvestigationProductMapping.aspx%')
begin
	insert into Pages(PageID,PageName,PageURL)
	select MAX(PageID)+1,'Investigation Product Mapping','/InventoryMaster/InvestigationProductMapping.aspx' from Pages

	Declare @PageID int
	Declare @OrgID int
	Set @OrgID=112
	Select @PageID=PageID from pages where PageURL='/InventoryMaster/InvestigationProductMapping.aspx'
	
	insert into InventoryPageMap(PageMapID,LocationTypeID,PageID)
    select MAX(PageMapID)+1,1,@PageID from InventoryPageMap

	Insert into Menumaster(DisplayText,Parentid,OrgId,PageID,MenuID,LanguageCode)
	select 'Investigation Product Mapping',3,@OrgID,@PageID,MAX(MenuID)+1,'en-GB' from Menumaster
	
	Declare @MenuID int
	
	Select @MenuID=MenuID from Menumaster where DisplayText='Investigation Product Mapping'
	

	Declare @RoleID int
	
	Select @RoleID=RoleID from Role where OrgID=@OrgID and RoleName=@RoleName
	
	insert into RoleMenu (MenuID,RoleID,IsMapped)
	select @MenuID,@RoleID,'Y'
end