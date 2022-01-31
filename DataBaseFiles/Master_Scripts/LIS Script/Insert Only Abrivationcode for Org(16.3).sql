
DecLare @Orgid Int= 106
Declare @Old_Schemeid Int=24
Declare @New_Schemeid Int=25

Declare @Temp_Table Table 
(
Id Bigint Identity(1,1),
CodemasterID Bigint,
Codename Varchar(100),
Codetype varchar(100),
CodeSchemeid Int,
CodeDesc Varchar(255),
IdentifyingID bigint
)

Insert into @Temp_Table

/***INV***/

Select Cm.Codemasterid,TM.Abbreviation ,cm.Codetype,Cm.CodeSchemeid,cm.CodeDesc, CP.IdentifyingID from CodeMaster CM (Nolock)
INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
INNER Join InvestigationOrgMapping IOM (Nolock) ON IOM.InvestigationID=CP.IdentifyingID 
INNER JOIN InvestigationMaster IM (Nolock) ON IM.InvestigationID =IOM.InvestigationID 
Inner Join Excel_Abbre_Pratham TM On TM.ID=IOm.InvestigationID
WHERE CM.CodeSchemeID =@Old_Schemeid 
AND CP.IdentifyingType ='Investigations' 
AND IOM.OrgID =@Orgid and type='INV'

--Select * from @Temp_Table

--/***GRP***/

--Select CM.*, CP.IdentifyingID from CodeMaster CM (Nolock)
--INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
--INNER Join InvOrgGroup  IOM (Nolock) ON IOM.Orggroupid =CP.IdentifyingID 
--INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  
--inner join Excel_Abbre_Pratham E on E.id=IOM.orggroupid
--WHERE CM.CodeSchemeID =@Old_Schemeid
--AND CP.IdentifyingType ='GRP' 
--AND IOM.OrgID =@OrgID and E.type='GRP'

--/***PKG***/


--Select CM.*, CP.IdentifyingID from CodeMaster CM (Nolock)
--INNER JOIN CodeMapper CP (Nolock) ON CM.CodeMasterID = CP.CodeMasterID AND CM.CodeType =CP.IdentifyingType 
--INNER Join InvOrgGroup  IOM (Nolock) ON IOM.Orggroupid =CP.IdentifyingID 
--INNER JOIN InvGroupMaster IM (Nolock) ON IM.GroupID  =IOM.AttGroupID  
--inner join Excel_Abbre_Pratham E on E.id=IOM.orggroupid
--WHERE CM.CodeSchemeID =@Old_Schemeid
--AND CP.IdentifyingType ='PKG' 
--AND IOM.OrgID =@OrgID and E.type='PKG'


Declare @i Int ,@j Int,@Codemasterid Bigint

Select @i=Min (id),@j=Max(id) from @Temp_Table 


While (@i<=@j)
Begin

Insert into Codemaster 
Select Codename,Codetype,@New_Schemeid,Codedesc from @Temp_Table Where ID=@i

Select @Codemasterid=Scope_identity()

Insert into Codemapper 
Select Codetype,IdentifyingID,@Codemasterid from @Temp_Table Where ID=@i

Set @i=@i+1

End
