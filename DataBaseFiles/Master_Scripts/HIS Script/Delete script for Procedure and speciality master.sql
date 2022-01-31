
/*====Speciality====*/

select *   from OrganizationSpeciality where orgid=296  --242
select *    from OrganizationSpecialityMapping where orgid=296 --92


/*====Procedure====*/
select *     from proceduremaster where orgid=296 and parentid<>0  --147
select *    from procedurefee where orgid=296 --151


/*====General====*/
select *  from GeneralBillingmaster where orgid=296  --117
select *  from GeneralBillingitems where orgid=296  --11173


/*==========Surgery=============*/
select * from SOIOrgMapping where orgid=313
select * from SOIRatemapping where orgid=313


