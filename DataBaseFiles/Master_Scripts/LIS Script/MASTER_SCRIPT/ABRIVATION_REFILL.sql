


Select * 
-- Update TM set TEST_ABBREVATION=CM.CodeName
from CodeMaster CM (Nolock)
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvestigationOrgMapping IOM (Nolock) ON IOM.InvestigationID=CP.IdentifyingID 
INNER JOIN InvestigationOrgAttributes IOA (Nolock) ON IOM.InvestigationID=IOA.InvestigationID AND IOA.OrgID =IOM.OrgID 
INNER JOIN InvestigationMaster IM (Nolock) ON IM.InvestigationID =IOM.InvestigationID 
Inner Join Stage2_MHL_T_01_TESTMASTER TM On TM.InvestigationID=IOM.InvestigationID
WHERE CM.CodeSchemeID =27 
AND CP.IdentifyingType ='Investigations' 
AND IOM.OrgID =109

Select * 
-- Update GM Set ABBREVATION=CM.Codename
from CodeMaster CM (Nolock)
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvOrgGroup  IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 
INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID 
Inner Join Stage2_MHL_T_02_GROUP_MASTER GM On GM.OrgGroupID=IOM.OrgGroupID 
WHERE CM.CodeSchemeID =27
AND CP.IdentifyingType ='GRP' 
AND IOM.OrgID =109


Select * 
-- Update GM set ABBREVATION=CM.Codename
from CodeMaster CM (Nolock)
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvOrgGroup  IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 
INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID 
Inner Join Stage2_MHL_T_03_Package_Master GM On GM.OrgGroupID=IOM.OrgGroupID 
WHERE CM.CodeSchemeID =27 
AND CP.IdentifyingType ='PKG' 
AND IOM.OrgID =109