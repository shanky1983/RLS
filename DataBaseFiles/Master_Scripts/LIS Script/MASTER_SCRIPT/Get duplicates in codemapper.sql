
select * from organization


Select distinct codeschemeid from Codemaster 


Select * from CodingSchemeMaster
Select * from CodingSchemeOrgMapping where IsPrimary='Y'

Select IdentifyingType,IdentifyingID,count(1) from CodeMapper 
where IdentifyingType='Investigations' 
Group By IdentifyingType,IdentifyingID
Having Count(1)>1

Select * from codemapper where IdentifyingID=25398 and IdentifyingType='Investigations'

Select * from codemaster Where Codemasterid in(
Select codemasterid from codemapper where IdentifyingID=24915 and IdentifyingType='Investigations'
)
Select * from codemaster Where Codemasterid in
(
23
,935
,2033
,35827
,45329
,54648
)

select * from orderedinvestigations where status='Approve' and orgid=109

select * from notifications where identityid=11255

select visitnumber,* from patientvisit where patientvisitid=11255
update notifications set status='' where notificationid in (
17880,
16848,
16893,
17685,
17844,
17881,
16849,
16894,
17686,
17845) and orgid=109