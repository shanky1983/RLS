

DECLARE @FROMROLENAME nvarchar(100)='Administrator' 
DECLARE @TOROLENAME nvarchar(100)='InventoryAdmin'
DECLARE @ORGID INT =112
DECLARE @TOROLEID INT 

IF OBJECT_ID(N'tempdb..#taskactions', N'U') IS NOT NULL 
BEGIN 
DROP TABLE #taskactions;
END

create table #taskactions(ActionName nvarchar(100),Category nvarchar(100))

INSERT INTO #taskactions(ActionName,Category)
SELECT 'StockReceiveApprovel','Approval Mechanism'
UNION SELECT 'PurchaseOrderApprovel','Approval Mechanism'
UNION SELECT 'Indent Approvel','Approval Mechanism'
UNION SELECT 'Quotation','Approval Mechanism'

--select * from TaskActions
--select * from TaskActionOrgMapping where RoleID=3913
--select * from RuleApprovelMaster where RoleID=3913

SELECT @TOROLEID=RoleID FROM ROLE WHERE RoleName=@TOROLENAME

UPDATE TaskActionOrgMapping SET RoleID=@TOROLEID

FROM TaskActionOrgMapping TAO
INNER JOIN ROLE R ON R.RoleName=@FROMROLENAME AND R.RoleID=TAO.RoleID AND R.OrgID=@ORGID
INNER JOIN TaskActions TA ON TA.TaskActionID=TAO.TaskActionID
INNER JOIN #taskactions TTA ON TTA.ActionName=TA.ACTIONNAME 
WHERE TAO.OrgID=@ORGID 

