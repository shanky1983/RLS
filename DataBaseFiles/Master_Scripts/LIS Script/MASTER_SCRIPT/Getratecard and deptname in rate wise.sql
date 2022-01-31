
select  * into #temp from (
Select 
CM.Codename,IOM.Investigationid,IMM.investigationname,iom.displaytext,'INV' Type,Idm.deptname ,IRM.Rate ,im.RateName
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
for ratename in ([GENERAL],[FOCUS 18],[RATE CARD D2],[RATE CARD D3],[RATE CARD D4],[DIABETIES],[SUNITA HOSPITAL CAMP],[FOCUS 1],[RATE CARD D5],[DUMMY],[RATE CARD 30],[RAINBOW RATE CARD],[DR. NITA M VISARIYA CAMP],[SREE INFERTILITY],[PRE EMPLOYMENT TEST],[DKL RATE CARD],[PHARMEASY-MUMBAI],[INDO PACKAGE],[PARAS PATHOLOGY],[VITAMIN D3 KHATRI],[SURANAVITB12],[UASP])
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
CM.Codename,IOM.OrgGroupID,IMM.GroupName,iom.displaytext,'GRP' Type,'' deptname ,IRM.Rate ,im.RateName
from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='GRP'
Inner Join RateMaster Im ON IM.orgid=IOm.OrgID 
--inner join RateRefOrgMapping ROm On im.RateId=Rom.RateRefID
Left Join InvRateMaster IRM ON im.rateid=irm.rateid  and  IRM.ID=IOM.OrgGroupID and IRM.Type='GRP' 

Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='GRP' )as p
      pivot
(max(rate)
for ratename in ([GENERAL],[FOCUS 18],[RATE CARD D2],[RATE CARD D3],[RATE CARD D4],[DIABETIES],[SUNITA HOSPITAL CAMP],[FOCUS 1],[RATE CARD D5],[DUMMY],[RATE CARD 30],[RAINBOW RATE CARD],[DR. NITA M VISARIYA CAMP],[SREE INFERTILITY],[PRE EMPLOYMENT TEST],[DKL RATE CARD],[PHARMEASY-MUMBAI],[INDO PACKAGE],[PARAS PATHOLOGY],[VITAMIN D3 KHATRI],[SURANAVITB12],[UASP])
)as t


union all


select  *  from (
Select 
CM.Codename,IOM.OrgGroupID,IMM.GroupName,iom.displaytext,'PKG' type,'' deptname,IRM.Rate ,im.RateName
from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='PKG'
Inner Join RateMaster Im ON IM.orgid=IOm.OrgID 
--inner join RateRefOrgMapping ROm On im.RateId=Rom.RateRefID
Left Join InvRateMaster IRM ON im.rateid=irm.rateid  and  IRM.ID=IOM.OrgGroupID and IRM.Type='PKG' 

Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='PKG')as p
      pivot
(max(rate)
for ratename in ([GENERAL],[FOCUS 18],[RATE CARD D2],[RATE CARD D3],[RATE CARD D4],[DIABETIES],[SUNITA HOSPITAL CAMP],[FOCUS 1],[RATE CARD D5],[DUMMY],[RATE CARD 30],[RAINBOW RATE CARD],[DR. NITA M VISARIYA CAMP],[SREE INFERTILITY],[PRE EMPLOYMENT TEST],[DKL RATE CARD],[PHARMEASY-MUMBAI],[INDO PACKAGE],[PARAS PATHOLOGY],[VITAMIN D3 KHATRI],[SURANAVITB12],[UASP])
)as t






Declare @temp table (deptname varchar(500),OrgGroupID bigint)
Insert Into @temp
select idm.deptname , iom.OrgGroupID from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='GRP'
INner Join InvGroupMapMAster IGMM (nolock) on igmm.GroupID=iom.OrgGroupID and Parent='N'
Inner Join InvestigationOrgMapping iom1 (nolock) on iom1.InvestigationID=igmm.InvestigationID and iom1.OrgID=69
Inner Join InvDeptMaster idm (nolock) on idm.DeptID=iom1.DeptID and idm.OrgID=iom1.OrgID
Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='GRP'
      union 
      select   idm.deptname , iom.OrgGroupID from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='GRP'
INner Join InvGroupMapMAster IGMM (nolock) on igmm.GroupID=iom.OrgGroupID and igmm.Parent='Y'

INner Join InvGroupMapMAster IGMM1 (nolock) on igmm1.GroupID=igmm.InvestigationID and igmm1.Parent='N'
Inner Join InvestigationOrgMapping iom1 (nolock) on iom1.InvestigationID=igmm1.InvestigationID and iom1.OrgID=69
Inner Join InvDeptMaster idm (nolock) on idm.DeptID=iom1.DeptID and idm.OrgID=iom1.OrgID
Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='GRP'
      Union
   select idm.deptname , iom.OrgGroupID from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='PKG'
INner Join InvPackageMapping IGMM (nolock) on igmm.PackageID=iom.OrgGroupID and IGMM.TYPE='INV'
Inner Join InvestigationOrgMapping iom1 (nolock) on iom1.InvestigationID=igmm.ID and iom1.OrgID=69
Inner Join InvDeptMaster idm (nolock) on idm.DeptID=iom1.DeptID and idm.OrgID=iom1.OrgID
Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      
      and 
      Cp.IdentifyingType='PKG'
      union 
      select   idm.deptname , iom.OrgGroupID from   CodeMaster CM 
Inner Join CodeMapper CP On CM.CodeMasterID=CP.CodeMasterID and cm.CodeType=Cp.IdentifyingType
Inner Join InvOrgGroup IOM ON IOM.OrgGroupID=Cp.IdentifyingID
inner join InvGroupMaster IMM ON Imm.GroupID=IOM.AttGroupID  and imm.Type='PKG'
INner Join InvPackageMapping IGMM (nolock) on igmm.PackageID=iom.OrgGroupID and igmm.Type='GRP'

INner Join InvGroupMapMAster IGMM1 (nolock) on igmm1.groupid =igmm.ID and igmm1.Parent='N'
Inner Join InvestigationOrgMapping iom1 (nolock) on iom1.InvestigationID=igmm1.InvestigationID and iom1.OrgID=69
Inner Join InvDeptMaster idm (nolock) on idm.DeptID=iom1.DeptID and idm.OrgID=iom1.OrgID
Where CM.CodeSchemeID=6 and isnull(iom.IsNonOrderable,'N')='N' and 
      IOM.OrgID=69-- and  CM.CodeName='BHM048' 
      and 
      Cp.IdentifyingType='PKG'   
      
      update t set  t.DeptName=t1.DeptName  from #temp t (nolock)
      inner Join @temp t1 On t.Investigationid=t1.OrgGroupID-- and t.Type='GRP'
      select * from #temp  --where TYPE='PKG'
      drop table #temp
      
  -------------------------------------------------------------------
  
      
--   select * from  InvestigationOrgMapping where InvestigationID in(  16413,19409,26874,26875,26876,26901,9498,13283,13863) and OrgID=69
  
   
--   select * from invpackagemapping where packageid=60118

--select * from InvestigationOrgMapping where InvestigationID in(
--select InvestigationID from invgroupmapmaster where groupid in(20611,57269)) and OrgID=69

--select * from InvDeptMaster where DeptID=73

      
      
      
      