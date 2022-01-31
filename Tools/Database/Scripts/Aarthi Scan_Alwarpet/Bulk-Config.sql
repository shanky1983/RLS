delete config  where OrgID=17
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('ReportServerURL','http://Attune3/Reports',0,17)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('InvestigationReportPath','/InvestigationReport/InvestigationValues',0,17)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('NormalFlow','True',0,17)
Insert into config (ConfigKey,ConfigValue,ParentID,OrgID)values ('BillPage','CustomizedBill.aspx',0,17)
Insert into Config(ConfigKey,ConfigValue,ParentID,OrgID)  values('UseOrgBasedDrugData','N',  0,17)

