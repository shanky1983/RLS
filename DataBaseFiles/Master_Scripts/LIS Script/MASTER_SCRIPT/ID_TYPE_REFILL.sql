

Sp_Tables 'Excel%29S'

Select * from CodingSchemeOrgMapping where OrgID=70


Select TM.Type,CP.IdentifyingType,TM.ID,IOM.Investigationid
-- Update TM Set TM.Type='INV',TM.ID=IOM.Investigationid 
from LIMS_QA.. Excel_Rate_29S TM
Inner Join CodeMaster CM (Nolock) On CM.CodeName=TM.Tcode
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvestigationOrgMapping IOM (Nolock) ON IOM.InvestigationID=CP.IdentifyingID 
INNER JOIN InvestigationOrgAttributes IOA (Nolock) ON IOM.InvestigationID=IOA.InvestigationID AND IOA.OrgID =IOM.OrgID 
INNER JOIN InvestigationMaster IM (Nolock) ON IM.InvestigationID =IOM.InvestigationID 
WHERE CM.CodeSchemeID =8 
AND CP.IdentifyingType ='Investigations' 
AND IOM.OrgID =70



Select TM.Type,CP.IdentifyingType,TM.ID,IOM.Orggroupid
-- Update TM Set TM.Type='GRP',TM.ID=IOM.Orggroupid 
from LIMS_QA.. Excel_Rate_29S TM
Inner Join CodeMaster CM (Nolock)On CM.codeName=TM.Tcode
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvOrgGroup  IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 
INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  
WHERE CM.CodeSchemeID =8 
AND CP.IdentifyingType ='GRP' 
AND IOM.OrgID =70





Select TM.Type,CP.IdentifyingType,TM.ID,IOM.Orggroupid
-- Update TM Set TM.Type='PKG',TM.ID=IOM.Orggroupid 
from LIMS_QA.. Excel_Rate_29S TM
Inner Join CodeMaster CM (Nolock)On CM.codeName=TM.Tcode
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvOrgGroup  IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 
INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  
WHERE CM.CodeSchemeID =8 
AND CP.IdentifyingType ='PKG' 
AND IOM.OrgID =70