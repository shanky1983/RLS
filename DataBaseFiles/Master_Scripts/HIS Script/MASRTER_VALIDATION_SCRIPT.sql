


SELECT * FROM ORGANIZATION--109

SELECT * FROM CODINGSCHEMEORGMAPPING WHERE ORGID=90



Select * from Excel_lakotia_INV_Master TM
Inner Join CodeMaster CM (Nolock) On CM.CodeName=TM.Tcode
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvestigationOrgMapping IOM (Nolock) ON IOM.InvestigationID=CP.IdentifyingID 
INNER JOIN InvestigationOrgAttributes IOA (Nolock) ON IOM.InvestigationID=IOA.InvestigationID AND IOA.OrgID =IOM.OrgID 
INNER JOIN InvestigationMaster IM (Nolock) ON IM.InvestigationID =IOM.InvestigationID 
WHERE CM.CodeSchemeID =10 AND
 CP.IdentifyingType ='Investigations' 
AND IOM.OrgID =90
And CM.CodeName not like 'Inactive%'


Select * from Excel_Lakotia_GRP_Master TM
Inner Join CodeMaster CM (Nolock)On CM.codeName=TM.METRO_COMBINE_CODE
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvOrgGroup  IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 
INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  
WHERE CM.CodeSchemeID =10
AND CP.IdentifyingType ='GRP' 
AND IOM.OrgID =90


Select * from Excel_Lakotia_PKG_Master TM
Inner Join CodeMaster CM (Nolock) On CM.CodeName=TM.METROLAB_PROFILECODE
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvOrgGroup IOM (Nolock) ON IOM.OrgGroupID =CP.IdentifyingID 
INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  
WHERE CM.CodeSchemeID =24 
AND CP.IdentifyingType ='PKG' 
AND IOM.OrgID =106


Select DISTINCT  Input_Format FROM Excel_lakotia_INV_Master where Input_Format NOT IN(
select ISNULL(DisplayText,'')  FROM InvestigationPattern where OrgID =106)

Select DISTINCT Output_Format FROM Excel_lakotia_INV_Master where Output_Format NOT IN(
select ISNULL(TemplateName,'')  FROM InvReportMaster where OrgID =106)

GO

Select Tcode from Excel_lakotia_INV_Master group BY Tcode HAVING COUNT(Tcode)>1
Select METRO_COMBINE_CODE from Excel_Lakotia_GRP_Master group BY METRO_COMBINE_CODE HAVING COUNT(METRO_COMBINE_CODE)>1
Select METROLAB_PROFILECODE from Excel_Lakotia_PKG_Master group BY METROLAB_PROFILECODE HAVING COUNT(METROLAB_PROFILECODE)>1

GO
Select TestName,TEST_ABBREVATION from Excel_lakotia_INV_Master group BY TestName,TEST_ABBREVATION HAVING COUNT(1)>1
Select GROUPNAME,ABBREVATION from Excel_Lakotia_GRP_Master group BY GROUPNAME,ABBREVATION HAVING COUNT(1)>1
Select PACKAGE_NAME,ABBREVATION from Excel_Lakotia_PKG_Master group BY PACKAGE_NAME,ABBREVATION HAVING COUNT(1)>1

GO
/* TestMaster With GroupMaster */
Select * from Excel_lakotia_INV_Master TM
         INNER JOIN Excel_Lakotia_GRP_Master GM ON TM.Tcode=GM.METRO_COMBINE_CODE
GO
/* TestMaster With PackageMaster */
Select * from Excel_lakotia_INV_Master TM
         INNER JOIN Excel_Lakotia_PKG_Master GM ON TM.Tcode=GM.METROLAB_PROFILECODE
GO	
/* GroupMaster With PackageMaster */
Select * from Excel_Lakotia_GRP_Master GM
         INNER JOIN Excel_Lakotia_PKG_Master PM ON GM.METRO_COMBINE_CODE=PM.METROLAB_PROFILECODE
GO
/* GroupMaster Don't have Contents */
Select * from Excel_Lakotia_GRP_Master GM
              LEFT JOIN Excel_Lakotia_Grp_Content GT ON GM.METRO_COMBINE_CODE=GT.Group_Code
              WHERE GT.Group_Code IS NULL
GO
/* PackageMaster Don't Have Contents */
Select * from Excel_Lakotia_PKG_Master PM
              LEFT JOIN Excel_Lakotia_PKAG_Content PT ON PM.METROLAB_PROFILECODE=PT.PACKAGE_CODE
              WHERE PT.PACKAGE_CODE IS NULL
GO
/* Groupcode in Group Test Not In Group Master */
Select DISTINCT GT.Group_Code from Excel_Lakotia_Grp_Content GT 
         LEFT JOIN Excel_Lakotia_GRP_Master GM ON GM.METRO_COMBINE_CODE=GT.Group_Code
         WHERE GM.METRO_COMBINE_CODE IS NULL
GO
/* SubGroupCode in Group Test Not In Group Master */
Select * from Excel_Lakotia_Grp_Content GT
         LEFT JOIN Excel_Lakotia_GRP_Master GM ON GM.METRO_COMBINE_CODE=GT.Test_Code
         where Type='GRP' and  GM.METRO_COMBINE_CODE IS NULL  
GO
/* Test In Group Test Not In Test Master */
Select * from Excel_Lakotia_Grp_Content GT
         LEFT JOIN Excel_lakotia_INV_Master TM ON TM.Tcode=GT.Test_Code
         where Type='INV'  and TM.Tcode IS NULL  

GO
/* PackageCode in Package Test Not In Package Master */
SELECT * FROM Excel_Lakotia_PKAG_Content PT
          LEFT JOIN Excel_Lakotia_PKG_Master PM ON PM.METROLAB_PROFILECODE=PT.PACKAGE_CODE
          where PM.METROLAB_PROFILECODE IS NULL
GO
/* SubGroupCode in Package Test Not In GroupMaster */
SELECT * FROM Excel_Lakotia_PKAG_Content PT
         LEFT JOIN Excel_Lakotia_GRP_Master GM ON GM.METRO_COMBINE_CODE=PT.Test_Code
         where Type='GRP' and GM.METRO_COMBINE_CODE IS NULL        
GO
/* Test In Package Test Not In TestMaster */
SELECT * FROM Excel_Lakotia_PKAG_Content PT 
         LEFT JOIN Excel_lakotia_INV_Master TM ON TM.Tcode=PT.Test_Code
         where Type='INV' and TM.Tcode IS NULL