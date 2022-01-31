 declare @orgid int=112
 
 declare @Configkey nvarchar(100)='QuotationApproval'
 declare @ConfigkeyDescription nvarchar(100)='Quotation Approval'
 
 IF NOT EXISTS (SELECT 1 FROM ConfigKeyMaster where ConfigKey=@Configkey)
  BEGIN 
  
  DECLARE @ConfigKeyid bigint=(select MAX(configkeyid)+1 from ConfigKeyMaster)
  Insert into ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal,ControlType)
  select @ConfigKeyid,@Configkey,@ConfigkeyDescription,'N','Text' 
  END
  
  INSERT INTO ConfigOrgMaster (CONFIGKEYID,CONFIGVALUE,OrgID)
  SELECT ConfigKeyID,'Y',@orgid FROM ConfigKeyMaster CK
  WHERE ConfigKey=@Configkey  
  and not Exists(select 1 from ConfigOrgMaster where orgid= @orgid and ConfigKeyID=CK.ConfigKeyID)

Insert into InventoryConfig(ConfigKey,ConfigValue,OrgID,ConfigKeyID,CreatedAt)
select @Configkey,'Y',@orgid, CONFIGKEYID,GETDATE() FROM ConfigKeyMaster WHERE ConfigKey=@Configkey
AND NOT EXISTS(SELECT 1 FROM InventoryConfig WHERE ConfigKey=@Configkey)





