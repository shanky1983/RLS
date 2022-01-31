
declare @Orgid int=112

CREATE TABLE #TEMPCONFIGKEYTABLE (CONFIGKEYNAME NVARCHAR(100),CONFIGVALUE NVARCHAR(4000))

INSERT INTO #TEMPCONFIGKEYTABLE (CONFIGKEYNAME,CONFIGVALUE)
  SELECT 'Attributes_Basedby_Category','Y'
UNION SELECT 'ExpiryDateLevel','3'
UNION SELECT 'HideInhandQty','Y'
UNION SELECT 'Is_change_or_edit_VAT_Rate_Products','Y'
UNION SELECT 'Is_Need_Indent_Approval','Y'
UNION SELECT 'IsBatchNoEdit','Y'
UNION SELECT 'IsCreditBill','Y'
UNION SELECT 'IsMRPPharmacyBill','Y'
UNION SELECT 'Need_Separate_Billno','Y'
UNION SELECT 'NeedTaxValueAddedCostPrice','N'
UNION SELECT 'PHARMA_LiNo','25398-25399'
UNION SELECT 'PHARMA_TinNo','08802710244'
UNION SELECT 'PharmacyAddress','ASG Hospital Pvt.Ltd.<br>D-247, Bihari Marg, Bani Park, Jaipur <br>Phone:0141-2200581, 2200585, 3151300-01 Fax:0141-2200589 <br>E-Mail:jaipur@asgeyehospital.com<br> CIN:U85110RJ2007PTC025459'
UNION SELECT 'QuotationApproval','Y'
UNION SELECT 'ReceviedUnitCostPrice','PoUnit'
UNION SELECT 'Required_CategoryBased_AttributesMapping','N'
UNION SELECT 'Required_Output_Tax_To_Dispensing','N'
UNION SELECT 'Required_Quotation_Approval','Y'
UNION SELECT 'Show_CostPrice','Y'
UNION SELECT 'Show_Pharmacy_Header','Y'
UNION SELECT 'EnablePackSize','N'
UNION SELECT 'Need to Convert Ordered Unit','N'







--DROP TABLE #TEMPCONFIGKEYTABLE



declare @maxConfigkeyid int
SELECT @maxConfigkeyid=isnull(MAX(configkeyid),0)+1 from ConfigKeyMaster
INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText,IsInternal)
SELECT @maxConfigkeyid+ROW_NUMBER() OVER (ORDER BY CONFIGKEYNAME ),CONFIGKEYNAME,CONFIGVALUE,'N' FROM #TEMPCONFIGKEYTABLE T
LEFT JOIN ConfigKeyMaster CM ON CM.ConfigKey=T.CONFIGKEYNAME
WHERE CM.ConfigKeyID IS NULL



INSERT INTO ConfigOrgMaster (ConfigKeyID,CONFIGVALUE,Orgid,CreatedAt)
select C.ConfigKeyID,T.CONFIGVALUE,@Orgid,GETDATE() from ConfigKeyMaster  C
INNER JOIN #TEMPCONFIGKEYTABLE  T ON T.CONFIGKEYNAME=C.ConfigKey
left join ConfigOrgMaster  CM ON CM.ConfigKeyID=C.ConfigKeyID AND CM.OrgID=@Orgid
WHERE CM.ConfigID IS  NULL



INSERT INTO InventoryConfig( [ConfigKey], [ConfigValue], [OrgID], [OrgAddressId], [ConfigKeyID],CreatedAt)
select CONFIGKEYNAME,T.CONFIGVALUE,@Orgid,0,C.ConfigKeyID,GETDATE() from ConfigKeyMaster  C
INNER JOIN #TEMPCONFIGKEYTABLE  T ON T.CONFIGKEYNAME=C.ConfigKey
left join InventoryConfig  CM ON CM.ConfigKey=T.CONFIGKEYNAME AND CM.OrgID=@Orgid
WHERE CM.ConfigID IS  NULL



DROP TABLE #TEMPCONFIGKEYTABLE



