drop table #temp
select  * into #temp from (
Select 
IMM.investigationname as TestName,CM.codename as Tcode ,iom.displaytext,'INV' Type,IRM.Rate ,im.RateName
from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvestigationOrgMapping IOM ON IOM.InvestigationID=Cp.IdentifyingID
Left Join InvDeptMaster  IDm (nolock) on Idm.DeptID=IOm.DeptID and Idm.OrgID=iom.OrgID
inner join InvestigationMaster IMM ON IOM.InvestigationID=imm.InvestigationID 
Inner Join RateMaster Im ON IM.orgid=IOm.OrgID 
--inner join RateRefOrgMapping ROm On im.RateId=Rom.RateRefID
Left Join InvRateMaster IRM ON im.rateid=irm.rateid  and  IRM.ID=IOM.InvestigationID and IRM.Type='INV' 

Where CM.CodeSchemeID=6 and isnull(iom.Display,'Y')='Y'
    and   IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='Investigations' )as p
      pivot
(max(rate)
for ratename in ([GENERAL],[FOCUS 18],[RATE CARD D2],[RATE CARD D3],[RATE CARD D4],[DIABETIES],[SUNITA HOSPITAL CAMP],[FOCUS 1],[RATE CARD D5],[DUMMY],[RATE CARD 30],[RAINBOW RATE CARD],[DR. NITA M VISARIYA CAMP],[SREE INFERTILITY],[PRE EMPLOYMENT TEST],[DKL RATE CARD],[PHARMEASY-MUMBAI],[INDO PACKAGE],[PARAS PATHOLOGY],[VITAMIN D3 KHATRI],[SURANAVITB12],[UASP],[CAMP 25.12.15]
,[J.R.MEDICAL 1 HBA1C],
[CYL001 DR SUREKHA],
[DUMMY  ZERO],
[DUMMY 0],
[MARVELS CLINIC  - CAMP],
[MEDICARE - L&T - CAMP],
[COSMOS RATE CARDJAN16],
[ANURAG B CAMP 01FEB16],
[DR. SHILPA CAMP RATES],
[KIMS RATE],
[MEDICARE FLAT 50],
[CAMP CARE MEDI FEB16],
[91 STREET CLIENT],
[91 STREET CLIENT MRP],
[CADILA HEALTHCARE LTD RATES)]
)
)as t


----select * from InvestigationOrgMapping where OrgID=69
--declare @st varchar(max)
--set @st=''
--select @st=Coalesce(@st+quotename(RateName)+',','') from RateMaster where orgid=69
--select @st
----select * from CodingSchemeOrgMapping where OrgID=69

----select * from invratemaster where id=47421 and RateID=43
union all
select  *  from (
Select 
IMM.GroupName as TestName,CM.codename as Tcode ,iom.displaytext,'GRP' Type,IRM.Rate ,im.RateName
from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='GRP'
Inner Join RateMaster Im ON IM.orgid=IOm.OrgID 
--inner join RateRefOrgMapping ROm On im.RateId=Rom.RateRefID
inner Join InvRateMaster IRM ON im.rateid=irm.rateid  and  IRM.ID=IOM.OrgGroupID and IRM.Type='GRP' 

Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='GRP' )as p
      pivot
(max(rate)
for ratename in ([GENERAL],[FOCUS 18],[RATE CARD D2],[RATE CARD D3],[RATE CARD D4],[DIABETIES],[SUNITA HOSPITAL CAMP],[FOCUS 1],[RATE CARD D5],[DUMMY],[RATE CARD 30],[RAINBOW RATE CARD],[DR. NITA M VISARIYA CAMP],[SREE INFERTILITY],[PRE EMPLOYMENT TEST],[DKL RATE CARD],[PHARMEASY-MUMBAI],[INDO PACKAGE],[PARAS PATHOLOGY],[VITAMIN D3 KHATRI],[SURANAVITB12],[UASP],[CAMP 25.12.15]
,[J.R.MEDICAL 1 HBA1C],
[CYL001 DR SUREKHA],
[DUMMY  ZERO],
[DUMMY 0],
[MARVELS CLINIC  - CAMP],
[MEDICARE - L&T - CAMP],
[COSMOS RATE CARDJAN16],
[ANURAG B CAMP 01FEB16],
[DR. SHILPA CAMP RATES],
[KIMS RATE],
[MEDICARE FLAT 50],
[CAMP CARE MEDI FEB16],
[91 STREET CLIENT],
[91 STREET CLIENT MRP],
[CADILA HEALTHCARE LTD RATES)]
)
)as t

union all


select  *  from (
Select 
IMM.GroupName as TestName,CM.codename as Tcode ,iom.displaytext,'PKG' Type,IRM.Rate ,im.RateName
from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='PKG'
Inner Join RateMaster Im ON IM.orgid=IOm.OrgID 
--inner join RateRefOrgMapping ROm On im.RateId=Rom.RateRefID
inner Join InvRateMaster IRM ON im.rateid=irm.rateid  and  IRM.ID=IOM.OrgGroupID and IRM.Type='PKG' 

Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='PKG')as p
      pivot
(max(rate)
for ratename in ([GENERAL],[FOCUS 18],[RATE CARD D2],[RATE CARD D3],[RATE CARD D4],[DIABETIES],[SUNITA HOSPITAL CAMP],[FOCUS 1],[RATE CARD D5],[DUMMY],[RATE CARD 30],[RAINBOW RATE CARD],[DR. NITA M VISARIYA CAMP],[SREE INFERTILITY],[PRE EMPLOYMENT TEST],[DKL RATE CARD],[PHARMEASY-MUMBAI],[INDO PACKAGE],[PARAS PATHOLOGY],[VITAMIN D3 KHATRI],[SURANAVITB12],[UASP],[CAMP 25.12.15]
,[J.R.MEDICAL 1 HBA1C],
[CYL001 DR SUREKHA],
[DUMMY  ZERO],
[DUMMY 0],
[MARVELS CLINIC  - CAMP],
[MEDICARE - L&T - CAMP],
[COSMOS RATE CARDJAN16],
[ANURAG B CAMP 01FEB16],
[DR. SHILPA CAMP RATES],
[KIMS RATE],
[MEDICARE FLAT 50],
[CAMP CARE MEDI FEB16],
[91 STREET CLIENT],
[91 STREET CLIENT MRP],
[CADILA HEALTHCARE LTD RATES)]
)
)as t



select * from #temp
