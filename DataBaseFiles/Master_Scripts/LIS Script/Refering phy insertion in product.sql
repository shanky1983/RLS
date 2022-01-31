

--insert into referingphysician(PhysicianName,Qualification,OrganizationName,OrgID,Status,Salutation,LoginID,PhysicianCode,IsClient,IsActive,
CreatedBy,CreatedAt,Gender,DOB,Age,RegistrationType,ParentReferingPhysicianID,IsMerged,DiscountLimit,DiscountPeriod,
DiscountValidFrom,DiscountValidTo,RefFeeCategoryid)
select PhysicianName,Qualification,null,77,Status,14,loginid,PhysicianCode,IsClient,IsActive,368,getdate(),Gender,DOB,Age,RegistrationType,ParentReferingPhysicianID,
IsMerged,DiscountLimit,DiscountPeriod,DiscountValidFrom,DiscountValidTo,RefFeeCategoryid from Excel_referingphysician_77

--insert into addressdetails(addresstypeid,referenceid,referencetype,address1,city,countryid,stateid,emailid,phone,mobile,faxnumber,orgid,iscommunication,createdby,createdat,isdcode)
select distinct DRP.addresstypeid,rp.ReferingPhysicianID,'RefPhy',DRP.address1,DRP.city,DRP.countryid,DRP.stateid,DRP.emailid,DRP.phone,DRP.mobile,DRP.faxnumber,77,DRP.iscommunication,368,getdate(),DRP.isdcode
from ReferingPhysician rp
inner join Excel_addressdetails_159 DRP on rp.PhysicianCode=DRP.PhysicianCode 
left join addressdetails AD on rp.ReferingPhysicianID=AD.ReferenceID
where AD.ReferenceID is null 

select * from addressdetails where orgid=159 and referencetype='Refphy'

select * from referingphysician where ReferingPhysicianID=461498 


