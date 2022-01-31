delete config  where OrgID=15
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('ReportServerURL','http://Attune3/Reports',0,15)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('InvestigationReportPath','/InvestigationReport/InvestigationValues',0,15)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,15)

