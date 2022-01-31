


select * From Organization where OrgID = 296

select * from OrganizationAddress where OrgID = 296

select * From CodingSchemeOrgMapping where orgid =296


  SELECT *   from invpackagemapping where PackageID in
(
       select        orggroupid
       from        INVORGGROUP iog
                       inner join
                       invgroupmaster igm
                       on        iog.AttGroupID = igm.GroupID
       where        iog.OrgID =296 
       and              igm.Type = 'pkg'
       
)

SELECT *  from invgroupmapmaster where GroupID in
(
       select        OrgGroupID
       from        INVORGGROUP iog
                       inner join
                       invgroupmaster igm
                       on        iog.AttGroupID = igm.GroupID
       where        iog.OrgID =296
       and                igm.Type = 'grp'
       
)


SELECT * from InvestigationOrgMapping where OrgID=296

SELECT *  from InvestigationOrgAttributes where OrgID=296

SELECT *  from invorggroup where OrgID=296

SELECT *   from InvSampleMaster where  OrgID = 296

SELECT *    from InvDeptMaster where  OrgID = 296

SELECT *   from investigationsamplecontainer where  OrgID = 296

SELECT *   From InvestigationMethod where OrgID = 296
