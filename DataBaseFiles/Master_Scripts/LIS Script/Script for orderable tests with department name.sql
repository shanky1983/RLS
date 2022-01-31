Select      

Min(Cmas.Codename)  as Codename,invmap.Orgid,CP.identifyingid as TestId,case when CP.IdentifyingType = 'Investigations' then 'INV' else CP.IdentifyingType end as TestType      

,INVMAP.DisplayText as TestName,isnull(INVmap.Display,'Y') as Isorderable,isnull(invmap.IsSTAT,0) as IsStat,Cmas.CodeSchemeID ,Invmap.investigationid ,
stuff((
							SELECT DISTINCT ',' + Deptname
							FROM VW_TestwithDept TestDept(NOLOCK)
							WHERE testdept.ORgid = INVmap.Orgid
								AND testdept.Testtype = 'INV'
								AND testdept.Investigationid = Invmap.investigationid
							FOR XML path('')
							), 1, 1, '')
				AS Deptname     

From  CodeMaster Cmas With(nolock)       

Inner join CodeMapper CP With(nolock) on CP.CodeMasterID = Cmas.CodeMasterID AND CP.IdentifyingType=Cmas.CodeType      

Inner join investigationorgmapping INVmap(nolock) on CP.Identifyingid = Invmap.investigationid      

Where  CP.IdentifyingType = 'Investigations' and   INVmap.Display='Y' and INVmap.Orgid=69 and Cmas.CodeSchemeID=6

group by invmap.Orgid,CP.Identifyingid,CP.identifyingtype,invmap.DisplayText,invmap.Display,invmap.IsSTAT,Cmas.CodeSchemeID  ,   Invmap.investigationid  

union all      

Select      

min(Cmas.Codename) as Codename ,grporg.orgid as Orgid,grporg.attgroupid as TestId,case when CP.IdentifyingType = 'Investigations' then 'INV' else CP.IdentifyingType end as TestType      

,grporg.DisplayText as TestName,case when isnull(grporg.IsNonOrderable,'N') = 'Y' then 'N' else 'Y' end as Isorderable,0 as Isstat,Cmas.CodeSchemeID   , grporg.AttGroupID,  
stuff((
							SELECT DISTINCT ',' + Deptname
							FROM VW_TestwithDept TestDept(NOLOCK)
							WHERE testdept.ORgid = grporg.Orgid
								AND testdept.Testtype = 'GRP'
								AND testdept.Investigationid = grporg.AttGroupID
							FOR XML path('')
							), 1, 1, '')
				AS Deptname  

From  CodeMaster Cmas With(nolock)       

Inner join CodeMapper CP With(nolock) on CP.CodeMasterID = Cmas.CodeMasterID AND CP.IdentifyingType=Cmas.CodeType      

Inner join invorggroup grporg(nolock) on CP.Identifyingid = grporg.Orggroupid      

Where  CP.IdentifyingType in ('GRP')   and grporg.IsNonOrderable='N' and grporg.Orgid=69 and Cmas.CodeSchemeID=6

group by grporg.Orgid,grporg.attgroupid,CP.IdentifyingType,grporg.DisplayText,grporg.IsNonOrderable,Cmas.CodeSchemeID 

union all

Select      

min(Cmas.Codename) as Codename ,grporg.orgid as Orgid,grporg.attgroupid as TestId,case when CP.IdentifyingType = 'Investigations' then 'INV' else CP.IdentifyingType end as TestType      

,grporg.DisplayText as TestName,case when isnull(grporg.IsNonOrderable,'N') = 'Y' then 'N' else 'Y' end as Isorderable,0 as Isstat,Cmas.CodeSchemeID   ,  grporg.AttGroupID, 
stuff((
							SELECT DISTINCT ',' + Deptname
							FROM VW_TestwithDept TestDept(NOLOCK)
							WHERE testdept.ORgid = grporg.Orgid
								AND testdept.Testtype = 'PKG'
								AND testdept.Investigationid = grporg.AttGroupID
							FOR XML path('')
							), 1, 1, '')
				AS Deptname  

From  CodeMaster Cmas With(nolock)       

Inner join CodeMapper CP With(nolock) on CP.CodeMasterID = Cmas.CodeMasterID AND CP.IdentifyingType=Cmas.CodeType      

Inner join invorggroup grporg(nolock) on CP.Identifyingid = grporg.Orggroupid      

Where  CP.IdentifyingType in ('PKG')   and grporg.IsNonOrderable='N' and grporg.Orgid=69 and Cmas.CodeSchemeID=6

group by grporg.Orgid,grporg.attgroupid,CP.IdentifyingType,grporg.DisplayText,grporg.IsNonOrderable,Cmas.CodeSchemeID ,grporg.AttGroupID