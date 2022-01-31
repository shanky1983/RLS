Declare @OrgID Int=89
Declare @Location varchar(50)='Porur'
Declare @Add1 Varchar(250)='No.4/10, Lakshmi Nagar  Arcot Road, Porur'
Declare @LocationCode Char(3)='PO'
Declare @IsDefault VarChar(3)='Y'
Declare @Landline Varchar(30)='+91 044 24762421'
  
Declare @AddressID bigint=(Select MaX(AddressID)+1 from OrganizationAddress)
Declare @OldAddressID bigint=(Select MIN(AddressID) from OrganizationAddress where  OrgID=@OrgID)
Declare @CurrentAddID bigint


IF not exists(select 1 from OrganizationAddress where Location=@Location and OrgID=@OrgID)
BEGIN
INSERT INTO OrganizationAddress(AddressID,OrgID,Location,LocationCode,Isdefault,CenterTypeCode,
Add1,CountryID,City,StateID,StartDTTM,EndDTTM,Status,IsMappedClients,LandLineNumber)
select @AddressID,@OrgID,@Location,@LocationCode,@IsDefault,CenterTypeCode,@Add1,CountryID,City,StateID,
StartDTTM,EndDTTM,Status,IsMappedClients,@Landline from OrganizationAddress where  OrgID=@OrgID and AddressID=@OldAddressID
END
ELSE
BEGIN
SELECT 'LOCATION ALREADY EXIST'
END

select @CurrentAddID=(select AddressID from OrganizationAddress where Location=@Location and OrgID=@OrgID)
---Visitnumber  Insert 
IF Not Exists (Select 1 from VisitNumberMaster where OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO VISITNUMBERMASter (OrgID,VisitNUmber,OrgAddressID)
select  @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END
---Billnumber in  Insert 
IF Not exists(select 1 from BillIdMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID)
BEGIN
INSERT  INTO BIllIDmaster (OrgID,BillNumber,OrgAddressID)
select @OrgID,0,@CurrentAddID
END
ELSE 
BEGIN
SELECT 'ADDRESSID ALREADY EXIST in VISITNUMBER  Table'
END



-------------------BIll Printing-----------------------

Declare @BilltypeID bigint =(select MAx(BilltypeID) from BillTypeMaster)
IF Not exists (select  * from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')
BEGIN
INSERT  INTO BillTypeMaster(BilltypeID,BillGroupID,BillTypeName,OrgID,OrgAddressID)
SELECT @BilltypeID+1,3,'OPBill',@OrgID,@CurrentAddID
END
ELSE
BEGIN 
 SELECT 'Already exit in BilltypeMaster'
END
Declare @CurBilltypeID bigint =(select  Max(BillTypeID) from BillTypeMaster where  OrgID=@OrgID and OrgAddressID=@CurrentAddID and BillTypeName='OPBill')

IF NOT EXISTS(select  1 from billconfig  where  BillTypeID=@CurBilltypeID)
BEGIN
Declare @billtype bigint=(select Min(BilltypeID) from BillConfig)
INSERT  INTO BillConfig(ConfigKey,ConfigValue,BillTypeID)
select ConfigKey,ConfigValue,@CurBilltypeID from BillConfig where  BillTypeID=@billtype
END

GO





