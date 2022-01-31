
DECLARE @pOrgid int =112
DECLARE @pageRowCount int =0
DECLARE @LoopCount int =1
DECLARE @MenuID bigint 
DECLARE @PageID bigint 
DECLARE @ROLEID BIGINT



IF Not EXISTS(SELECT 1 FROM Role WHERE OrgID =@pOrgid and RoleName ='Inventory') 
BEGIN
	INSERT INTO Role (RoleID,RoleName,Description,OrgID) 
	SELECT isnull(max(RoleID),0)+1,'Inventory','Inventory',@pOrgid FROM Role 
END

IF Not EXISTS(SELECT 1 FROM Role WHERE OrgID =@pOrgid and RoleName ='InventoryAdmin') 
BEGIN
	INSERT INTO Role (RoleID,RoleName,Description,OrgID) 
	SELECT isnull(max(RoleID),0)+1,'InventoryAdmin','Inventory Admin',@pOrgid FROM Role 
END



SELECT @PageID= (select top 1 PageID FROM PAGES where PageURL ='/InventoryCommon/home.aspx')

-------------HOME PAGE MAPPING FOR INVENTORY ROLE---------------------
insert PageMapping(RoleId,PageID,SeqNo)
SELECT RoleID,@PageID,1 FROM Role R WHERE OrgID=@pOrgid AND RoleName='Inventory' 
AND NOT EXISTS(SELECT 1 FROM PageMapping WHERE PageID=@PageID AND RoleId=R.RoleID)


SELECT @MenuID=MAX(MenuID) FROM MenuMaster
SELECT @MenuID=isnull(@MenuID,0)+1

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID,P.DisplayText,P.Parentid,@pOrgid,P.PageID FROM Inventory_Pages p 
LEFT JOIN MenuMaster M ON M.PageID=P.PageID AND OrgId=@pOrgid
WHERE M.PageID IS NULL



SELECT @MenuID=MenuID FROM Inventory_Pages p 
INNER JOIN MenuMaster M ON M.PageID=P.PageID AND OrgId=@pOrgid

INSERT INTO RoleMenu (MenuID,RoleID,IsMapped) 
SELECT @MenuID,R.RoleID,'Y' FROM Role  R
LEFT JOIN RoleMenu RM ON RM.ROLEID=R.RoleID AND RM.MenuID=@MenuID 
WHERE R.OrgID=@pOrgid AND RoleName='Inventory' AND RM.MenuID IS NULL




-------------HOME PAGE MAPPING FOR InventoryAdmin ROLE---------------------
insert PageMapping(RoleId,PageID,SeqNo)
SELECT RoleID,@PageID,1 FROM Role R WHERE OrgID=@pOrgid AND RoleName='InventoryAdmin' 
AND NOT EXISTS(SELECT 1 FROM PageMapping WHERE PageID=@PageID AND RoleId=R.RoleID)


SELECT @MenuID=MAX(MenuID) FROM MenuMaster
SELECT @MenuID=isnull(@MenuID,0)+1

INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
SELECT @MenuID,P.DisplayText,P.Parentid,@pOrgid,P.PageID FROM Inventory_Pages p 
LEFT JOIN MenuMaster M ON M.PageID=P.PageID AND OrgId=@pOrgid
WHERE M.PageID IS NULL



SELECT @MenuID=MenuID FROM Inventory_Pages p 
INNER JOIN MenuMaster M ON M.PageID=P.PageID AND OrgId=@pOrgid

INSERT INTO RoleMenu (MenuID,RoleID,IsMapped) 
SELECT @MenuID,R.RoleID,'Y' FROM Role  R
LEFT JOIN RoleMenu RM ON RM.ROLEID=R.RoleID AND RM.MenuID=@MenuID 
WHERE R.OrgID=@pOrgid AND RoleName='InventoryAdmin' AND RM.MenuID IS NULL
