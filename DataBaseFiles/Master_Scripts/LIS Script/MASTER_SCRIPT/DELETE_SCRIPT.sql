


select * From Organization where orgid = 105

select * from OrganizationAddress where orgid = 105

select * From CodingSchemeOrgMapping where orgid =105


  SELECT *    from invpackagemapping where PackageID in
(
       select        orggroupid
       from        INVORGGROUP iog
                       inner join
                       invgroupmaster igm
                       on        iog.AttGroupID = igm.GroupID
       where        iog.OrgID =105 
       and              igm.Type = 'pkg'
       
)

SELECT *   from invgroupmapmaster where GroupID in
(
       select        OrgGroupID
       from        INVORGGROUP iog
                       inner join
                       invgroupmaster igm
                       on        iog.AttGroupID = igm.GroupID
       where        iog.OrgID =105
       and                igm.Type = 'grp'
       
)


SELECT *   from InvestigationOrgMapping where OrgID=105

SELECT *   from InvestigationOrgAttributes where OrgID=105

SELECT *   from invorggroup where OrgID=105

SELECT *   from InvSampleMaster where  OrgID = 105

SELECT *   from InvDeptMaster where  OrgID = 105

SELECT *   from investigationsamplecontainer where  OrgID = 105

SELECT *    From InvestigationMethod where OrgID = 105

SELECT *   From  PatternMapping WHERE ORGID =105

SELECT *   From  InvReportMapping WHERE ORGID =105





