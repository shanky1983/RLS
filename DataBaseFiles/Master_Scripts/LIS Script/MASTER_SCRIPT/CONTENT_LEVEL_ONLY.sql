

  select  * from invpackagemapping where PackageID in
(
       select        orggroupid
       from        INVORGGROUP iog
                       inner join
                       invgroupmaster igm
                       on        iog.AttGroupID = igm.GroupID
       where        iog.OrgID = 99
       and                igm.Type = 'pkg'
       
)


select  *  from invgroupmapmaster where GroupID in
(
       select        OrgGroupID
       from        INVORGGROUP iog
                       inner join
                       invgroupmaster igm
                       on        iog.AttGroupID = igm.GroupID
       where        iog.OrgID = 99
       and                igm.Type = 'grp'
       
)