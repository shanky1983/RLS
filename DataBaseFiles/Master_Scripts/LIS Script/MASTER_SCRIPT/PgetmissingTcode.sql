  
--Select * from CodingSchemeOrgMapping Where OrgID in (69,77,80)and IsPrimary='Y'  
  
CREATE PRocedure PGetMissingTcode  
(  
@ParentOrgid Int,  
@ParentCodeSchemeID Int,  
@ChildOrgid Int,  
@ChildCodeSchemeID Int  
)  
As  
Begin  
Set NoCount ON  
  
-- Exec PGetMissingTcode @ParentOrgid=69,@ParentCodeSchemeID=6,@ChildOrgid=77,@ChildCodeSchemeID=6  
  
/************** Investigation missing ****************/  
SELECT TM.CODENAME,TM.CODETYPE from   
  
(  
  
SELECT distinct cm.CodeName,'INV' AS CodeType FROM codemaster cm(nolock)  
inner join CodeMapper cp (nolock)ON cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType  
inner join InvestigationOrgMapping iom (nolock)ON cp.IdentifyingID=iom.InvestigationID  
inner join InvestigationMaster igm (nolock)ON iom.InvestigationID=igm.InvestigationID  
where cp.IdentifyingType='investigations' and cm.CodeSchemeID=@ParentCodeSchemeID and iom.OrgID=@ParentOrgid  
  
) TM  
  
  
LEFT JOIN   
  
(  
  
SELECT distinct cm.CodeName,'INV' AS CodeType FROM codemaster cm (nolock)  
inner join CodeMapper cp (nolock)ON cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType  
inner join InvestigationOrgMapping iom (nolock)ON cp.IdentifyingID=iom.InvestigationID  
inner join InvestigationMaster igm (nolock)ON iom.InvestigationID=igm.InvestigationID  
where cp.IdentifyingType='investigations' and cm.CodeSchemeID=@ChildCodeSchemeID and iom.OrgID=@ChildOrgid  
  
) TT  ON TM.CODENAME=TT.CODENAME  
  
WHERE TT.CODENAME IS NULL  
  
Union all  
  
/************** Grp missing ****************/  
  
SELECT TG.CodeName,TG.IdentifyingType FROM   
  
(  
  
SELECT distinct cm.CodeName,cp.IdentifyingType FROM codemaster cm (nolock)  
inner join CodeMapper cp (nolock)ON cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType  
inner join INVORGGROUP iog (nolock) ON cp.IdentifyingID=iog.OrgGroupID  
inner join InvGroupMaster igm (nolock) ON iog.AttGroupID=igm.GroupID  
WHERE cp.IdentifyingType='grp' and cm.CodeSchemeID=@ParentCodeSchemeID and iog.OrgID=@ParentOrgid   
  
) TG  
  
LEFT JOIN   
  
(  
  
SELECT distinct cm.CodeName,cp.IdentifyingType FROM codemaster cm (nolock)  
inner join CodeMapper cp (nolock) ON cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType  
inner join INVORGGROUP iog (nolock) ON cp.IdentifyingID=iog.OrgGroupID  
inner join InvGroupMaster igm (nolock) ON iog.AttGroupID=igm.GroupID  
WHERE cp.IdentifyingType='grp' and cm.CodeSchemeID=@ChildCodeSchemeID and iog.OrgID=@ChildOrgid  
  
) TR ON TG.CODENAME=TR.CODENAME  
WHERE TR.CODENAME IS NULL  
  
Union all  
/************** PKG missing ****************/  
  
SELECT TP.CodeName,TP.IdentifyingType FROM   
  
(  
  
SELECT distinct cm.CodeName,CP.IdentifyingType FROM codemaster cm (nolock)  
inner join CodeMapper cp (nolock) ON cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType  
inner join INVORGGROUP iog (nolock) ON cp.IdentifyingID=iog.OrgGroupID  
inner join InvGroupMaster igm (nolock) ON iog.AttGroupID=igm.GroupID  
WHERE cp.IdentifyingType='pkg' and cm.CodeSchemeID=@ParentCodeSchemeID and iog.OrgID=@ParentOrgid   
  
) TP  
  
LEFT JOIN  
  
(  
  
SELECT distinct cm.CodeName,CP.IdentifyingType FROM codemaster cm (nolock)  
inner join CodeMapper cp (nolock) ON cm.CodeMasterID=cp.CodeMasterID and cm.CodeType=cp.IdentifyingType  
inner join INVORGGROUP iog (nolock) ON cp.IdentifyingID=iog.OrgGroupID  
inner join InvGroupMaster igm (nolock) ON iog.AttGroupID=igm.GroupID  
WHERE cp.IdentifyingType='pkg' and cm.CodeSchemeID=@ChildCodeSchemeID and iog.OrgID=@ChildOrgid   
  
) TK ON TP.CODENAME=TK.CODENAME   
WHERE TK.CODENAME IS NULL  
  
  
Set Nocount Off  
End