
Select CM.CodeName,CP.IdentifyingTYpe,GM.GroupNAme,IPM.Groupid,IPM.Investigationid,IM.InvestigationName,IPM.PArent from Codemaster CM 
INNER JOIN codemapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType=CP.IdentifyingType
INNER JOIN InvOrgGroup IOG WITH (NOLOCK) ON CP.IdentifyingID=IOG.OrgGroupID
Inner Join Invgroupmaster GM On GM.Groupid=IOG.Attgroupid 
INNER JOIN INVgroupMApmAster IPM WITH(NOLOCK) ON IOG.OrgGroupID=IPM.Groupid and IPM.parent='N'
Inner Join Investigationmaster IM On IPM.Investigationid=IM.Investigationid
Where CM.CodeSchemeID=1
and Cp.IdentifyingTYpe ='GRP'
and IOG.Orgid=75

Union all

Select CM.CodeName,CP.IdentifyingTYpe,GM.GroupNAme,IPM.Groupid,IPM.Investigationid,GMM.GroupName,IPM.Parent from tempdb TM 
Inner Join Codemaster CM On CM.CodeName=TM.Tcode
INNER JOIN codemapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType=CP.IdentifyingType
INNER JOIN InvOrgGroup IOG WITH (NOLOCK) ON CP.IdentifyingID=IOG.OrgGroupID
Inner Join Invgroupmaster GM On GM.Groupid=IOG.Attgroupid 
INNER JOIN INVgroupMApmAster IPM WITH(NOLOCK) ON IOG.OrgGroupID=IPM.Groupid and IPM.parent='Y'
Inner Join Invorggroup IOGG On IOGG.Orggroupid=IPM.Investigationid and IOGG.Orgid=75
Inner Join Invgroupmaster GMM On GMM.Groupid=IOGG.attgroupid
Where CM.CodeSchemeID=1
and Cp.IdentifyingTYpe ='GRP'
and IOG.Orgid=75




Select CM.CodeName,CP.IdentifyingTYpe,GM.GroupNAme,IPM.Packageid,IPM.Id,IM.InvestigationName,IPM.Type,IPM.Active
from Codemaster CM 
INNER JOIN codemapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType=CP.IdentifyingType
INNER JOIN InvOrgGroup IOG WITH (NOLOCK) ON CP.IdentifyingID=IOG.OrgGroupID
Inner Join Invgroupmaster GM On GM.Groupid=IOG.Attgroupid 
INNER JOIN InvPackageMapping IPM WITH(NOLOCK) ON IOG.OrgGroupID=IPM.PackageID and IPM.TYPE='INV'
Inner Join Investigationmaster IM On IPM.Id=IM.Investigationid
Where CM.CodeSchemeID=1
and Cp.IdentifyingTYpe ='PKG'
and IOG.Orgid=75


Union all

Select CM.CodeName,CP.IdentifyingTYpe,GM.GroupNAme,IPM.Packageid,IPM.Id,GMM.GroupName,IPM.Type,IPM.Active
from Codemaster CM 
INNER JOIN codemapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType=CP.IdentifyingType
INNER JOIN InvOrgGroup IOG WITH (NOLOCK) ON CP.IdentifyingID=IOG.OrgGroupID
Inner Join Invgroupmaster GM On GM.Groupid=IOG.Attgroupid 
INNER JOIN InvPackageMapping IPM WITH(NOLOCK) ON IOG.OrgGroupID=IPM.PackageID and IPM.TYPE='GRP'
Inner Join Invorggroup IOGG On IOGG.Orggroupid=IPM.Id and IOGG.Orgid=75
Inner Join Invgroupmaster GMM On GMM.Groupid=IOGG.attgroupid
Where CM.CodeSchemeID=1
and Cp.IdentifyingTYpe ='PKG'
and IOG.Orgid=75
