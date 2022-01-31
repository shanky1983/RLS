If Exists(Select 1 From Sys.sysobjects(nolock) Where TYPE = 'U'	And name = 'Stg_Speciality')
		Begin
			Drop table Stg_Speciality
		End
		
		If Exists(Select 1 From Sys.sysobjects(nolock) Where TYPE = 'U'	And name = 'Stg_Procedure')
		Begin
			Drop table Stg_Procedure
		End
		
		If Exists(Select 1 From Sys.sysObjects (nolock) Where Type='U' and name = 'Stg_General')
		Begin
			Drop table Stg_General
		End

		If Exists(Select 1 From Sys.sysObjects (nolock) Where Type='U' and name = 'Stg_Surgery')
		Begin
			Drop table Stg_Surgery
		End
		 

/* Copy Data From Source Template to Intermediate Template Table */		

		Select * into Stg_Speciality from [Excel_Speciality_308] 
		Select * into Stg_Procedure from [Excel_PROCEDURE_313] 
		Select * into Stg_General from [Excel_General_308]
		select * into Stg_Surgery from [Excel_Surgery_313]

/*===========================================SPECIALITY==================================*/
/* Insert data into  Speciality table*/		
		Declare @orgid int=308
	    Declare @max Bigint
		Select @max=0	
		Select  @Max = isnull(MAX(SpecialityID),0) From Speciality
	
		Insert into Speciality(SpecialityName,SpecialityID,CreatedBy,CreatedAt)
		
				Select stg.SPECIALITYNAME,
				ROW_NUMBER() over (Order By stg.SPECIALITYNAME) + @max as SpecialityID,0,getdate()
				from Stg_Speciality	stg WITH (NOLOCK)
				Left join Speciality SP WITH (NOLOCK) on stg.SPECIALITYNAME = SP.SpecialityName
				Where SP.SpecialityName is null and ISNULL(stg.SpecialityName ,'')<>''


	   Update M set M.SpecialityID=T.SpecialityID
	   From Stg_Speciality M WITH (NOLOCK)
	   Inner Join Speciality T WITH (NOLOCK) on T.SpecialityName=M.SPECIALITYNAME
				 

/* Insert data into  OrganizationSpeciality table*/
		
		Declare @orgid int=308
	insert into OrganizationSpeciality(OrgID,SpecialityID,Amount,IPAmount,Rateid,Name,CreatedBy,CreatedAt,IsAmountEditable,IsRefundable,IsDiscountable,IsActive)
	       select @orgid,
	              stg.SpecialityID,
		          0,
				  0.00,
				  144,
		          SPECIALITYNAME,
		          0,
		          getdate(),
		          'Y',
		          'Y',
		          'Y',
		          'Y'
		   from Stg_Speciality stg
		   left join OrganizationSpeciality OS on stg.SPECIALITYNAME=OS.Name and OS.Orgid=@OrgID
		   where OS.Name is null 

	Update Stg set stg.OrgSpecialityID=T.OrgSpecialityID
	From Stg_Speciality Stg WITH (NOLOCK)
	Inner Join OrganizationSpeciality T WITH (NOLOCK) on T.SpecialityID=Stg.SpecialityID 
	where Orgid=@OrgID 



	/* Insert data into  OrganizationSpecialityMapping table*/
	Declare @orgid int=308
	Declare @rateid Bigint
	Declare @raterefid bigint
	Declare @Ratename varchar(50)='ECHS'
	Set @rateid=(select rateid from ratemaster where orgid=@OrgID and ratename=@Ratename)
	Set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)

	Declare  @Rate_Insert_Speciality_Stg Table
(
ItemName Varchar(max),
OrgSpecialityID Bigint,
OrgID BigInt,
RateID bigint,
OPAmount decimal(18,2),
IPAmount decimal(18,2),
RateRefID bigint,
CreatedBy bigint,
CreatedAt Datetime,
SpecialityID Bigint,
VersionID int
)

insert into @Rate_Insert_Speciality_Stg
select  Stg.SPECIALITYNAME,stg.OrgSpecialityID,@OrgID,@rateID,Stg.[ECHS_OP],Stg.[ECHS_IP],@RateRefID,0,getdate(),stg.specialityid,0
from Stg_Speciality Stg 
--inner join OrganizationSpeciality OS on stg.SpecialityID=OS.SpecialityID and stg.OrgSpecialityID=OS.OrgSpecialityID
left join OrganizationSpecialityMapping OSM  on stg.SpecialityID=OSM.SpecialityID and stg.OrgSpecialityID=OSM.OrgSpecialityID and OSM.Orgid=@OrgID and OSM.Rateid=@RateiD and OSM.RaterefID=@raterefid
where OSM.OrgSpecialityID is null  


insert into OrganizationSpecialityMapping(ItemName,OrgSpecialityID,OrgID,RateID,OPAmount,IPAmount,RateRefID,CreatedBy,CreatedAt,SpecialityID,VersionID)
select * from @Rate_Insert_Speciality_Stg



-------------------------

----select *    
--update OSM set OSM.OPAmount=Stg.OPAmount,OSM.IPAmount=IPAmount
--from @Rate_Insert_Speciality_Stg stg
--inner join OrganizationSpecialityMapping OSM with (Nolock) on stg.SpecialityID=OSM.SpecialityID and stg.OrgSpecialityID=OSM.OrgSpecialityID and stg.RateID=OSM.RateID and Stg.RateRefID=OSM.RateRefID
--where OSM.rateid=@rateid and OSM.raterefid=@raterefid and OSM.orgid=@OrgID


/*===========================================PROCEDURE==================================*/

/* Insert data into  ProcedureMaster table*/


Declare @orgid int=308		
insert into ProcedureMaster(ProcedureName,ProcedureType,ProcedureDesc,OrgID,CreatedBy,CreatedAt,ParentID,IsAmountEditable,IsRefundable,IsDiscountable,IsActive,IsAVisitPurpose)
	       select stg.PROCEDURENAME,
		          'Treatment',
	              stg.PROCEDURENAME,
		          @orgid,
		          0,
		          getdate(),
				  9705,
		          'N',
		          'Y',
		          'Y',
		          'Y',
				  'Y'
		   from Stg_Procedure stg
		   left join ProcedureMaster PM on PM.ProcedureName=stg.PROCEDURENAME and PM.Orgid=@OrgID
		   where PM.ProcedureName is null  

	Update Stg set stg.procedureID=T.procedureID
	From Stg_Procedure Stg WITH (NOLOCK)
	Inner Join proceduremaster T WITH (NOLOCK) on T.ProcedureName=Stg.PROCEDURENAME 
	where T.Orgid=@OrgID


/* Insert data into  procedurefee table*/

    Declare @orgid int=308
	Declare @rateid Bigint
	Declare @raterefid bigint
	Declare @Ratename varchar(50)='GENERAL'
	Set @rateid=(select rateid from ratemaster where orgid=@OrgID and ratename=@Ratename)
	Set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)


Declare  @Rate_Insert_Procedure_Stg Table
(
ProcedureID Bigint,	
Amount decimal(18,2),	
CreatedBy bigint,	
CreatedAt datetime,
RateID int,	
OrgID int,	
IPAmount decimal(18,2),	
RateRefID int,
VersionID int,
Isvariable nchar(2)
)


insert into @Rate_Insert_Procedure_Stg
select  Stg.ProcedureID,stg.[General_OP],0,getdate(),@rateID,@OrgID,Stg.[General_IP],@RateRefID,0,'Y'
from Stg_Procedure Stg 
--inner join proceduremaster PM on stg.ProcedureID=PM.ProcedureID and PM.ProcedureName=stg.[Item Name]
left join procedurefee PF  on stg.ProcedureID=PF.ProcedureID and PF.Orgid=@OrgID and PF.Rateid=@RateiD and PF.RaterefID=@raterefid
where  PF.ProcedureID is null  

insert into procedurefee(ProcedureID,Amount,CreatedBy,CreatedAt,RateID,OrgID,IPAmount,RateRefID,VersionID,Isvariable)
select * from @Rate_Insert_Procedure_Stg



/*===========================================GENERAL==================================*/

/* Insert data into  GeneralBillingmaster table*/

Declare @orgid int=308
		
insert into GeneralBillingmaster(GenBillName,OrgID,CreatedAt,CreatedBy,IsDefaultBilling,IsDiscountable,	IsTaxable,FeeSubType,IsVariable,IsAmountEditable,IsRefundable)
	       select GENERALNAME,
		          @orgid,
				  getdate(),
	              0,
		          'Y',
				  'Y',
				  'Y',
				  'GEN',
				  'Y',
				  'N',
				  'Y'
		   from Stg_General stg
		   left join GeneralBillingmaster GBM on GBM.GenBillName=stg.GENERALNAME and GBM.OrgID=@OrgID
		   where GBM.GenBillName is null 

	Update Stg set stg.genbillid=T.genbillid
	From Stg_General Stg WITH (NOLOCK)
	Inner Join GeneralBillingmaster T WITH (NOLOCK) on T.GenBillName=Stg.GENERALNAME 
	where T.Orgid=@OrgID



	/* Insert data into  GeneralBillingitems table*/

	Declare @orgid int=308
	Declare @rateid Bigint
	Declare @raterefid bigint
	Declare @Ratename varchar(50)='General'
	Set @rateid=(select rateid from ratemaster where orgid=@OrgID and ratename=@Ratename)
	Set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)

	Declare @Rate_Insert_General_Stg Table
(
ItemName nvarchar(max),
Rate int,
OrgID int,
RateID int,
CreatedBy bigint,
CreatedAt datetime,
IPAmount decimal,
GenBillID bigint,
RateRefID int,
FeeSubType nvarchar(6),
VersionID int
)



insert into @Rate_Insert_General_Stg
select  Stg.[GENERALNAME],stg.[General_OP],@OrgID,@rateID,0,getdate(),Stg.[General_IP],STG.GenBillID,@RateRefID,'GEN',0
from Stg_General Stg 
--inner join GeneralBillingmaster GBM on stg.GenBillID=GBM.GenBillID and GBM.GenBillName=stg.[Item Name]
left join GeneralBillingitems GBI  on stg.GenBillID=GBI.GenBillID and GBI.Orgid=@OrgID and GBI.Rateid=@RateiD and GBI.RaterefID=@raterefid
where  GBI.GenBillID is null  

insert into GeneralBillingitems(ItemName,Rate,OrgID,RateID,CreatedBy,CreatedAt,IPAmount,GenBillID,RateRefID,FeeSubType,VersionID)
select * from @Rate_Insert_General_Stg




/*===========================================SURGERY==================================*/
/* Insert data into  Iptreatmentplanmaster table*/		
		Declare @orgid int=308
	
		Insert into Iptreatmentplanmaster(IPTreatmentPlanName,IPTreatmentPlanParentID,CreatedBy,CreatedAt)
		
				Select stg.Surgeryname,1,0,getdate()
				from Stg_Surgery stg WITH (NOLOCK)
				left join Iptreatmentplanmaster IPM WITH (NOLOCK) on stg.Surgeryname = IPM.IPTreatmentPlanName
				Where IPM.IPTreatmentPlanName is null and ISNULL(STG.Surgeryname ,'')<>''
				

	   Update M set M.TreatmentPlanID=T.TreatmentPlanID
	   From Stg_Surgery M WITH (NOLOCK)
	   Inner Join Iptreatmentplanmaster T WITH (NOLOCK) on T.IPTreatmentPlanName=M.Surgeryname
				 

/* Insert data into  SOIOrgMapping table*/
		
		Declare @orgid int=308
	insert into SOIOrgMapping(SOIID,OrgID,CreatedAt,CreatedBy,IsActive,DisplayText)
	       select stg.TreatmentPlanID,
	              @OrgID,
		          getdate(),
				  0,
				  'Y',
		          stg.Surgeryname
		          
		   from Stg_Surgery stg
		   left join SOIOrgMapping SOM on stg.Surgeryname=SOM.DisplayText and SOM.Orgid=@OrgID
		   where SOM.DisplayText is null 

	Update Stg set stg.TreatmentPlanID=T.SOIID
	From Stg_Surgery Stg WITH (NOLOCK)
	Inner Join SOIOrgMapping T WITH (NOLOCK) on T.SOIID=Stg.TreatmentPlanID 
	where T.Orgid=@OrgID 



	/* Insert data into  SOIRatemapping table*/
	Declare @orgid int=308
	Declare @rateid Bigint
	Declare @raterefid bigint
	Declare @Ratename varchar(50)='General'
	Set @rateid=(select rateid from ratemaster where orgid=@OrgID and ratename=@Ratename)
	Set @raterefid=(select raterefid from ratereforgmapping where Rateid=@rateid and Orgid=@Orgid)

	Declare  @Rate_Insert_Surgery_Stg Table
(
SOIID bigint,
RateID int,
Amount decimal(18,2),
OrgID INT,
RateRefID int,
CreatedBy bigint,
CreatedAt DATETIME,
VersionID int
)

insert into @Rate_Insert_Surgery_Stg
select  Stg.TreatmentPlanID,@rateID,Stg.[Genreal_IP],@OrgID,@RateRefID,0,getdate(),0
from Stg_Surgery Stg 
--inner join OrganizationSpeciality OS on stg.SpecialityID=OS.SpecialityID and stg.OrgSpecialityID=OS.OrgSpecialityID
left join SOIRatemapping SRM  on stg.TreatmentPlanID=SRM.SOIID and SRM.Orgid=@OrgID and SRM.Rateid=@RateiD and SRM.RaterefID=@raterefid
where SRM.SOIID is null  


insert into SOIRatemapping(SOIID,RateID,Amount,OrgID,RateRefID,CreatedBy,CreatedAt,VersionID)
select * from @Rate_Insert_Surgery_Stg