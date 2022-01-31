CREATE TABLE #TempOrgID (ID INT IDENTITY(1,1),OrgID INT)
INSERT INTO #TempOrgID
SELECT OrgID from Organization WITH(NOLOCK) ORDER BY OrgID
DECLARE @MinValue int 
DECLARE @MaxValue int
DECLARE @MenuID bigint 
DECLARE @PageID bigint
DECLARE @RoleID bigint
DECLARE @OrgID INT
SET @MinValue=(SELECT MIN(ID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(ID) FROM #TempOrgID) 
SET @MenuID=(SELECT MAX(MenuID)+1 FROM MenuMaster)
SELECT @PageID=PageID FROM Pages WHERE PageURL='/Admin/DepartmentSequenceNumber.aspx'
WHILE @MinValue <= @MaxValue 
BEGIN

SELECT @OrgID=OrgID FROM #TempOrgID WITH(NOLOCK) WHERE ID=@MinValue

SELECT @RoleID=RoleID FROM Role WHERE RoleName='Administrator' AND OrgID=@OrgID

IF EXISTS(SELECT OrgID FROM Organization WITH(NOLOCK) WHERE OrgID=@OrgID) 
BEGIN
	IF EXISTS(SELECT RoleID FROM Role WITH(NOLOCK) WHERE RoleID=@RoleID) 
	BEGIN
		IF EXISTS(SELECT PageID FROM Pages WITH(NOLOCK) WHERE PageID=@PageID) 
		BEGIN
			IF NOT EXISTS(SELECT MenuID FROM MenuMaster WHERE PageID=@PageID AND OrgId=@OrgID)
			BEGIN
				INSERT INTO MenuMaster(MenuID,DisplayText,Parentid,OrgId,PageID) 
				SELECT @MenuID,'Manage Department & Header',2,@OrgID,@PageID
			END
			IF NOT EXISTS(SELECT RoleID FROM RoleMenu RM JOIN MenuMaster MM ON MM.MenuID=RM.MenuID WHERE PageID=@PageID AND MM.OrgId=@OrgID)
			BEGIN
				INSERT INTO RoleMenu(MenuID,RoleID,IsMapped) 
				SELECT @MenuID,@RoleID,'Y'
			END
		END
	END
END
SET @MinValue = @MinValue + 1
SET @MenuID = @MenuID + 1
END
DROP TABLE #TempOrgID
GO
IF EXISTS(SELECT MenuID FROM   MenuMaster MM JOIN Pages P ON MM.PageID = P.PageID WHERE  MM.DisplayText = 'Manage Department' AND P.PageURL = '/Investigation/SequenceArrangement.aspx')
  BEGIN
      UPDATE MenuMaster SET    DisplayText = 'Manage Group & Package Sequence' WHERE  MenuID IN (SELECT MenuID FROM   MenuMaster MM JOIN Pages P ON MM.PageID = P.PageID WHERE  MM.DisplayText = 'Manage Department' AND P.PageURL = '/Investigation/SequenceArrangement.aspx')
  END 
GO
UPDATE RoleMenu SET IsMapped='N' WHERE MenuID IN (
SELECT MenuID FROM MenuMaster WHERE Parentid=25)
GO
UPDATE MenuMaster SET Parentid=0 WHERE Parentid=7
GO