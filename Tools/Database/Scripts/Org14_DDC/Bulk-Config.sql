delete config  where OrgID=14
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('ReportServerURL','http://Attune3/Reports',0,14)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('InvestigationReportPath','/InvestigationReport/InvestigationValues',0,14)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,14)

