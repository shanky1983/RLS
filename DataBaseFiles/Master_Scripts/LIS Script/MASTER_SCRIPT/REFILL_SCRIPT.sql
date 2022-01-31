




--select * from organization where orgid=149

--select * from codingschemeorgmapping where orgid=128



/* Template Refill Script */

Declare @orgID int = 69
Declare @CodeSchemeID int=6
Declare @LAbNAme Varchar(100)='Triesta_Banglore'

/* Truncate Stage Tables */

TRUNCATE table   Stage2_MHL_T_02_GROUP_MASTER
TRUNCATE table  Stage2_MHL_T_01_TESTMASTER 
TRUNCATE table Stage2_MHL_T_04_GROUP_TESTS
TRUNCATE table Stage2_MHL_T_03_Package_Master
TRUNCATE table Stage2_MHL_T_05_PACKAGE_TESTS
--Drop Table Stage2_MHL_T_04_GROUP_TESTSS
--Drop Table Stage2_MHL_T_05_PACKAGE_TESTSS

/* Insert Into Input Tcodes In Stage2_MHL_T_01_TESTMASTER Table */

Insert Stage2_MHL_T_01_TESTMASTER(LAB, TCode )


SELECT DISTINCT @LabName as Lab,  CodeName
        FROM CodeMaster WITH (NOLOCK)
        where CodeSchemeID = @CodeSchemeID AND CodeName IN
        (
Select distinct CM.COdeNAme 
           from CodeMaster CM 
     INNER JOIN CodeMapper CP 
             ON CM.CodeMasterID = CP.CodeMasterID 
            AND CM.CodeType =CP.IdentifyingType 
     INNER Join InvestigationOrgMapping IOM 
             ON IOM.InvestigationID=CP.IdentifyingID 
     INNER JOIN InvestigationMaster IM 
             ON IM.InvestigationID =IOM.InvestigationID 
          WHERE CM.CodeSchemeID =@CodeSchemeID 
            AND CP.IdentifyingType ='Investigations' 
            AND IOM.OrgID =@orgID 
            And CM.CodeName not like 'Inactive%'
         
Union All
Select distinct CM.CodeNAme 
           from CodeMaster CM 
     INNER JOIN CodeMapper CP 
             ON CM.CodeMasterID = CP.CodeMasterID 
            AND CM.CodeType =CP.IdentifyingType 
     INNER Join InvOrgGroup  IOM 
             ON IOM.OrgGroupID =CP.IdentifyingID 
     INNER JOIN InvGroupMaster IM 
             ON IM.GroupID  =IOM.AttGroupID  
          WHERE CM.CodeSchemeID =@CodeSchemeID 
            AND CP.IdentifyingType ='GRP' 
            AND IOM.OrgID =@orgID 
            And CM.CodeName not like 'Inactive%'
             
Union All    
Select distinct CM.CodeName 
           from CodeMaster CM 
     INNER JOIN CodeMapper CP 
             ON CM.CodeMasterID = CP.CodeMasterID 
            AND CM.CodeType =CP.IdentifyingType 
     INNER Join InvOrgGroup  IOM 
             ON IOM.OrgGroupID =CP.IdentifyingID 
     INNER JOIN InvGroupMaster IM 
             ON IM.GroupID  =IOM.AttGroupID  
          WHERE CM.CodeSchemeID =@CodeSchemeID 
            AND CP.IdentifyingType ='PKG' 
            AND IOM.OrgID =@orgID 
            And CM.CodeName not like 'Inactive%'
			
         )
            And CodeName <>''



/* Add Missing Columns */

IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'DeptID' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER'))
      Begin
                ALTER TABLE Stage2_MHL_T_01_TESTMASTER ADD DeptID Int
      End
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'SampleCode' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER'))
       Begin
                ALTER TABLE Stage2_MHL_T_01_TESTMASTER ADD SampleCode Bigint  
       End
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'MethodID' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER'))
       Begin
			    Alter table Stage2_MHL_T_01_TESTMASTER add MethodID Int
	   End
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'SampleContainerID' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER'))
	   Begin
				Alter table Stage2_MHL_T_01_TESTMASTER add SampleContainerID Int
		End	
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'HeaderId' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER')) 
	   Begin
				Alter table Stage2_MHL_T_01_TESTMASTER add HeaderId BigInt
	   End
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'InvestigationID' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER')) 
	   Begin
				Alter table Stage2_MHL_T_01_TESTMASTER add InvestigationID BigInt
       End
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'AutoAuthorizationId' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER')) 
       Begin
				Alter table Stage2_MHL_T_01_TESTMASTER add AutoAuthorizationId BigInt
	   End	
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'UOMID' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER')) 
	   Begin
				Alter table Stage2_MHL_T_01_TESTMASTER add UOMID BigInt
	   End	
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'Processing_AddressID' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER'))
		Begin
				Alter Table Stage2_MHL_T_01_TESTMASTER Add Processing_AddressID BigInt
		End
IF NOT EXISTS (SELECT 1 FROM syscolumns WHERE [name] = 'Interpretation' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER'))
		Begin
				alter table Stage2_MHL_T_01_TESTMASTER add [Interpretation] varchar(max)
		End
IF NOT EXISTS ( SELECT 1 FROM syscolumns WHERE [name] = 'ProtocolGroup' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER') )
   Begin
        ALTER TABLE Stage2_MHL_T_01_TESTMASTER ADD ProtocolGroup nvarchar(100)
   End

IF NOT EXISTS ( SELECT 1 FROM syscolumns WHERE [name] = 'ProtocolGroup' AND id = OBJECT_ID('Stage2_MHL_T_02_GROUP_MASTER') )
   Begin
        ALTER TABLE Stage2_MHL_T_02_GROUP_MASTER ADD ProtocolGroup nvarchar(100)
   End
   
IF NOT EXISTS ( SELECT 1 FROM syscolumns WHERE [name] = 'ProtocolGroup' AND id = OBJECT_ID('Stage2_MHL_T_03_Package_Master') )
   Begin
        ALTER TABLE Stage2_MHL_T_03_Package_Master ADD ProtocolGroup nvarchar(100)
   End

IF NOT EXISTS ( SELECT 1 FROM syscolumns WHERE [name] = 'ProtocolGroupID' AND id = OBJECT_ID('Stage2_MHL_T_01_TESTMASTER') )
   Begin
        ALTER TABLE Stage2_MHL_T_01_TESTMASTER ADD ProtocolGroupID int
   End

IF NOT EXISTS ( SELECT 1 FROM syscolumns WHERE [name] = 'ProtocolGroupID' AND id = OBJECT_ID('Stage2_MHL_T_02_GROUP_MASTER') )
   Begin
        ALTER TABLE Stage2_MHL_T_02_GROUP_MASTER ADD ProtocolGroupID int
   End
   
IF NOT EXISTS ( SELECT 1 FROM syscolumns WHERE [name] = 'ProtocolGroupID' AND id = OBJECT_ID('Stage2_MHL_T_03_Package_Master') )
   Begin
        ALTER TABLE Stage2_MHL_T_03_Package_Master ADD ProtocolGroupID int
   End


/* Alter Column Data Type */
		
ALTER table Stage2_MHL_T_01_TESTMASTER alter column [Interpretation] varchar(max)

ALTER table Stage2_MHL_T_01_TESTMASTER alter column REFERENCE_RANGE varchar(MAX)

ALTER table Stage2_MHL_T_01_TESTMASTER alter column PANIC_RANGE varchar(MAX)

ALTER table  Stage2_MHL_T_02_GROUP_MASTER alter column groupinterpretation varchar(max)

ALTER table  Stage2_MHL_T_02_GROUP_MASTER alter column ValidationText varchar(max)

ALTER table  Stage2_MHL_T_02_GROUP_MASTER alter column ValidationRule nvarchar(max)



/* Set TestType : INV,GRP,PKG */

Update Stage2_MHL_T_01_TESTMASTER set TestType = NULL


UPDATE TM SET TM.TESTTYPE ='INV' 
         from Stage2_MHL_T_01_TESTMASTER TM WITH (NOLOCK) 
   INNER Join CodeMaster CM WITH (NOLOCK)  
           ON CM.CodeName =TM.Tcode
   INNER JOIN CodeMapper CP WITH (NOLOCK)  
           ON CM.CodeMasterID = CP.CodeMasterID 
          AND CM.CodeType =CP.IdentifyingType 
   INNER Join InvestigationOrgMapping IOM WITH (NOLOCK)  
           ON IOM.InvestigationID=CP.IdentifyingID 
    --INNER JOIN InvestigationOrgAttributes IOA WITH (NOLOCK)  ON IOM.InvestigationID=IOA.InvestigationID AND IOA.OrgID =IOM.OrgID 
   INNER JOIN InvestigationMaster IM WITH (NOLOCK)  
           ON IM.InvestigationID =IOM.InvestigationID 
        WHERE CM.CodeSchemeID =@CodeSchemeID 
          AND CP.IdentifyingType ='Investigations' 
          AND IOM.OrgID =@orgID


UPDATE TM SET TM.TESTTYPE = 'GRP' 
         from Stage2_MHL_T_01_TESTMASTER TM WITH (NOLOCK) 
   INNER Join CodeMaster CM WITH (NOLOCK)  
           ON CM.CodeName =TM.Tcode
   INNER JOIN CodeMapper CP WITH (NOLOCK)  
           ON CM.CodeMasterID = CP.CodeMasterID 
          AND CM.CodeType =CP.IdentifyingType 
   INNER Join InvOrgGroup  IOM WITH (NOLOCK)  
           ON IOM.OrgGroupID =CP.IdentifyingID 
   INNER JOIN InvGroupMaster IM WITH (NOLOCK)  
           ON IM.GroupID  =IOM.AttGroupID  
        WHERE CM.CodeSchemeID =@CodeSchemeID 
          AND CP.IdentifyingType ='GRP' 
          AND IOM.OrgID =@orgID


UPDATE TM SET TM.TESTTYPE ='PKG' 
         from Stage2_MHL_T_01_TESTMASTER TM WITH (NOLOCK) 
   INNER Join CodeMaster CM WITH (NOLOCK)  
           ON CM.CodeName =TM.Tcode
   INNER JOIN CodeMapper CP WITH (NOLOCK)  
           ON CM.CodeMasterID = CP.CodeMasterID 
          AND CM.CodeType =CP.IdentifyingType 
   INNER Join InvOrgGroup  IOM WITH (NOLOCK)  
           ON IOM.OrgGroupID =CP.IdentifyingID 
   INNER JOIN InvGroupMaster IM WITH (NOLOCK) 
           ON IM.GroupID  =IOM.AttGroupID  
        WHERE CM.CodeSchemeID =@CodeSchemeID 
          AND CP.IdentifyingType ='PKG' 
          AND IOM.OrgID =@orgID


/* Insert GRP TCodes and SubGroup Tcodes In Stage2_MHL_T_02_GROUP_MASTER Table */
 ;
 With GROUPDet  as
 (
	Select 1 AS[NUMBER],cast(tmp.Lab as varchar(100)) as Lab,cast(TCODE as varchar(255)) as TestCode,
	       cast('' as varchar(255)) as EdosCode,cast('' as varchar(255)) as Abb 
	       From Stage2_MHL_T_01_TESTMASTER tmp WITH (NOLOCK)  
	       Where tmp.TestType = 'GRP'
	
	union all
	
	Select NUMBER+1,det.lab as Lab,cast(CM1.CodeName  as varchar(255)) as TestCode,
	       cast('' as varchar(255)) as EdosCode,cast('' as varchar(255)) as Abb 
	       from GROUPDet Det 
	       INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeName = Det.TestCode and CM.CodeSchemeID =@CodeSchemeID
	       INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
	       AND CM.CodeType = CP.IdentifyingType 
	       Inner join InvOrgGroup Invgrp WITH (NOLOCK)  on CP.IdentifyingID  = invgrp.OrgGroupID 
	       Inner join InvGroupMapMaster grpmap WITH (NOLOCK)  on invgrp.OrgGroupID = grpmap.GroupID and grpmap.Parent = 'Y' and grpmap.Active = 'Y'
	       Inner join InvOrgGroup g1 WITH (NOLOCK)  on grpmap.InvestigationID = g1.OrgGroupID
	       INNER JOIN CodeMapper CP1 WITH (NOLOCK)  ON CP1.IdentifyingID = g1.OrgGroupID and CP1.IdentifyingType ='GRP'
	       INNER JOIN CodeMaster CM1 WITH (NOLOCK)  ON CM1.CodeMasterID = CP1.CodeMasterID and CM1.CodeSchemeID =@CodeSchemeID
	       AND CM1.CodeType = CP1.IdentifyingType 
	       WHERE Invgrp.OrgID =@orgID and g1.OrgID =@orgID AND NUMBER<100
	    
	       
 )
 INSERT INTO Stage2_MHL_T_02_GROUP_MASTER(Lab,Metro_Combine_Code,EDOSCODE,Abbrevation)
        select distinct Lab,TestCode,'','' From GROUPDet 
        
        
  
/* Insert PKG Tcodes in Stage2_MHL_T_03_Package_Master Table */

INSERT INTO Stage2_MHL_T_03_Package_Master(Lab,METROLAB_PROFILECODE,DOSCODE,ABBREVATION)
	   select distinct  Lab, TCODE, EdosCode, TEST_ABBREVATION 
			  From Stage2_MHL_T_01_TESTMASTER WITH (NOLOCK) WHERE TESTTYPE='PKG'

 
/* Insert SubGroup Tcodes under PKGs in Stage2_MHL_T_02_GROUP_MASTER Table */
  
Declare @InvpackageMapMaster Table                              
  (                              
   PackageID bigint, 
   PackageCode VARCHAR(20),                            
   ID bigint,                              
   Type varchar(10),
   TestCode VARCHAR(20)
  ) 
  

Insert Into @InvpackageMapMaster                              
       select IGM.GroupID,tmp.TCODE,IPM.ID, IPM.Type ,CM1.CodeName                
              from Stage2_MHL_T_01_TESTMASTER tmp WITH (NOLOCK) 
              INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeName = tmp.TCODE and CM.CodeSchemeID =@CodeSchemeID
              INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='PKG'
              AND CM.CodeType = CP.IdentifyingType 
              INNER JOIN InvOrgGroup IOG WITH (NOLOCK)   ON IOG.OrgGroupID =CP.IdentifyingID AND  IOG.OrgID=@orgID 
	          INNER JOIN InvGroupMaster IGM WITH (NOLOCK)   ON IGM.GroupID =IOG.AttGroupID            
              INNER JOIN InvPackageMapping IPM WITH (NOLOCK)   ON IPM.PackageID=IOG.OrgGroupID AND                     
              IPM.active='A' AND IPM.Type='GRP'
              INNER JOIN InvOrgGroup IOG1 WITH (NOLOCK)  ON IOG1.OrgGroupID=IPM.ID AND IOG1.OrgID=@orgID
              INNER JOIN InvGroupMaster IGM1 WITH (NOLOCK)   ON IGM1.GroupID=IOG1.AttGroupID
              INNER JOIN CodeMapper CP1 WITH (NOLOCK)  ON CP1.IdentifyingID = IOG1.OrgGroupID and CP1.IdentifyingType ='GRP'
              INNER JOIN CodeMaster CM1 WITH (NOLOCK)  ON CM1.CodeMasterID = CP1.CodeMasterID and CM1.CodeSchemeID =@CodeSchemeID
              AND CM1.CodeType = CP1.IdentifyingType 
              Where tmp.TestType = 'PKG'
    
 ;
 With PACKAGEDet  as
 (
	Select cast(@LabName as varchar(100)) as Lab,cast(TestCode as varchar(255)) as TestCode,
	       cast('' as varchar(255)) as EdosCode,cast('' as varchar(255)) as Abb 
	       From @InvpackageMapMaster tmp  
	       Where tmp.Type = 'GRP'
	
	union all
	
	Select det.lab as Lab,cast(CM1.CodeName as varchar(255)) as TestCode,cast('' as varchar(255)) as EdosCode,
	       cast('' as varchar(255)) as Abb 
	       from PACKAGEDet Det
	       INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeName = Det.TestCode and CM.CodeSchemeID =@CodeSchemeID
	       INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
	       AND CM.CodeType = CP.IdentifyingType 
	       Inner join InvOrgGroup Invgrp WITH (NOLOCK)   on CP.IdentifyingID  = invgrp.OrgGroupID  AND Invgrp.OrgID=@orgID
	       Inner join InvGroupMapMaster grpmap WITH (NOLOCK)  on invgrp.OrgGroupID = grpmap.GroupID and grpmap.Parent = 'Y' and grpmap.Active = 'Y'
	       Inner join InvOrgGroup g1 WITH (NOLOCK)  on grpmap.InvestigationID = g1.OrgGroupID and g1.OrgID=@orgID
	       INNER JOIN CodeMapper CP1 WITH (NOLOCK)  ON CP1.IdentifyingID = g1.OrgGroupID and CP1.IdentifyingType ='GRP'
	       INNER join CodeMaster CM1 WITH (NOLOCK)  ON CM1.CodeMasterID = CP1.CodeMasterID and CM1.CodeSchemeID =@CodeSchemeID
	       AND CM1.CodeType = CP1.IdentifyingType 
 )
 
    INSERT INTO Stage2_MHL_T_02_GROUP_MASTER(Lab,Metro_Combine_Code,EDOSCODE,Abbrevation)
    select distinct PkgGrp.Lab,PkgGrp.TestCode,PkgGrp.EdosCode,PkgGrp.abb 
           From PACKAGEDet PkgGrp
           LEFT JOIN Stage2_MHL_T_02_GROUP_MASTER GRP WITH (NOLOCK) ON GRP.METRO_COMBINE_CODE= PkgGrp.TestCode
           WHERE GRP.METRO_COMBINE_CODE IS NULL
    
     
/* Update GRP Details In Stage2_MHL_T_02_GROUP_MASTER Table */     
     
 Update Stg set 
			[GROUPNAME]          =   IGM.GroupName,
    		[DISPLAY_NAME]       =   IOG.DisplayText,
    		[IS_ORDERABLE]       =   CASE ISNULL(IOG.IsNonOrderable,'N') 
							              WHEN 'N' THEN 'Y'
							              WHEN 'Y' THEN 'N' END ,
			[CLASSIFICATION]     =   IOG.Classification ,
			[OrgGroupID]         =   IOG.OrgGroupID,
    		[ValidationText]     =   IOG.ValidationText,
			[ValidationRule]     =	 IOG.ValidationRule,
			[IsDiscountable]     =	 IOG.IsDiscountable,
			[IsServicetaxable]   =	 IOG.IsServicetaxable,
			[Status]             =	 IOG.Status,
			[CutOffTimeValue]    =	 IOG.CutOffTimeValue,
			[CutOffTimeType]     =	 IOG.CutOffTimeType,
			[SubCategory]        =	 IOG.SubCategory,
			[HasHistory]         =	 IOG.HasHistory,
			[Remarks]            =	 IOG.Remarks,
			[PrintSeparately]    =	 IOG.PrintSeparately,
			[Gender]             =	 IOG.Gender,
			[groupinterpretation]=	 IOG.groupinterpretation,
			[Issummaryworklist]  =	 IOG.Issummaryworklist,
			[IsSpecialFormat]    =	 IOG.IsSpecialFormat 
			--[ProtocolGroup]      =   MD.DisplayText  
 From Stage2_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK) 
 INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeName = stg.METRO_COMBINE_CODE and CM.CodeSchemeID =@CodeSchemeID
 INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
 AND CM.CodeType = CP.IdentifyingType 
 INNER JOIN InvOrgGroup IOG WITH (NOLOCK)  ON CP.IdentifyingID  = IOG.OrgGroupID 
 INNER JOIN InvGroupMaster IGM WITH (NOLOCK)  ON IGM.GroupID = IOG.AttGroupID 
 --LEFT JOIN MetaData MD WITH (NOLOCK) ON IOG.ProtocalGroupID = MD.MetaDataID and MD.Domain ='ProtocalGroup_Based'
 where IOG.OrgID =@orgID


/* Insert GRP Contents Into Stage2_MHL_T_04_GROUP_TESTS Table */

 INSERT INTO Stage2_MHL_T_04_GROUP_TESTS( [LAB],[GROUP_CODE],[TEST_CODE],[TEST_SEQUENCE_NO],[Type],ID )
 
  SELECT  @LabName,  T.GROUP_CODE,  T.TEST_CODE,  T.SequenceNo,  T.Type,  T.ID
           FROM 
               (
  				SELECT Distinct T.METRO_COMBINE_CODE as GROUP_CODE,CM.CodeName as TEST_CODE,IGMM.SequenceNo,'INV' Type ,IOM.InvestigationID as ID
				       FROM Stage2_MHL_T_02_GROUP_MASTER T WITH (NOLOCK) 
				       INNER JOIN InvOrgGroup IOG WITH (NOLOCK)  ON IOG.OrgGroupID=T.Orggroupid
				       INNER JOIN InvGroupMapMaster IGMM WITH (NOLOCK)  ON IGMM.GroupID=IOG.OrgGroupID AND IGMM.Parent='N' and IGMM.Active = 'Y'
				       INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CP.IdentifyingID = IGMM.InvestigationID and CP.IdentifyingType ='Investigations'
				       INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CM.CodeSchemeID =@CodeSchemeID
				       AND CM.CodeType = CP.IdentifyingType 
				       Inner join InvestigationOrgMapping  IOM WITH (NOLOCK)  on IGMM.Investigationid = IOM.Investigationid and IOM.OrgID =@orgID
				       WHERE IOG.OrgID=@orgID 
				
				UNION ALL 
				
				SELECT Distinct T.METRO_COMBINE_CODE as GROUP_CODE,CM.CodeName as TEST_CODE,IGMM.SequenceNo,'GRP' Type ,inv.OrgGroupID as ID
				       FROM Stage2_MHL_T_02_GROUP_MASTER T WITH (NOLOCK) 
				       INNER JOIN InvOrgGroup IOG WITH (NOLOCK)  ON IOG.OrgGroupID=T.Orggroupid
				       INNER JOIN InvGroupMapMaster IGMM WITH (NOLOCK)  ON IGMM.GroupID=IOG.OrgGroupID AND IGMM.Parent='Y' and IGMM.Active = 'Y'
				       Inner join InvOrgGroup Inv WITH (NOLOCK)  on IGMM.Investigationid = inv.OrgGroupID and Inv.OrgID =@orgID
				       INNER Join CodeMapper CP WITH (NOLOCK)   ON CP.IdentifyingID = Inv.OrgGroupID and CP.IdentifyingType ='GRP'
				       INNER join CodeMaster CM WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CM.CodeSchemeID =@CodeSchemeID
				       AND CM.CodeType = CP.IdentifyingType 
				       WHERE IOG.OrgID=@orgID  
			   ) T 


/* Insert SubGroup Contents Level INV Into Stage2_MHL_T_01_TESTMASTER Table */

 Insert Stage2_MHL_T_01_TESTMASTER(Lab,TCode,EDOSCode,TEST_ABBREVATION,TESTTYPE)
		Select Distinct t1.Lab,t1.Test_Code,'','','INV' 
		       From Stage2_MHL_T_04_GROUP_TESTS t1 WITH (NOLOCK) 
		       Left join Stage2_MHL_T_01_TESTMASTER t2 WITH (NOLOCK)  on t1.TEST_CODE = t2.TCODE and t2.TESTTYPE = 'INV'
		       where T1.Type = 'INV' and t2.TCODE is null


/* Update PKG details Into Stage2_MHL_T_03_Package_Master table */

 Update Stg set 
 				[PACKAGE_NAME]         =  IGM.GroupName,
				[DISPLAY_NAME]         =  IOG.DisplayText,
				[IS_ORDERABLE]         =  CASE ISNULL(IOG.IsNonOrderable,'N') 
								               WHEN 'N' THEN 'Y'
								               WHEN 'Y' THEN 'N' END ,
				[CLASSIFICATION]       =  IOG.Classification ,
				[OrgGroupID]           =  IOG.OrgGroupID,
				[ValidationText]       =  IOG.ValidationText,
				[ValidationRule]       =  IOG.ValidationRule,
				[IsDiscountable]       =  IOG.IsDiscountable,
				[IsServicetaxable]     =  IOG.IsServicetaxable,
				[Status]               =  IOG.Status,
				[CutOffTimeValue]      =  IOG.CutOffTimeValue,
				[CutOffTimeType]       =  IOG.CutOffTimeType,
				[SubCategory]          =  IOG.SubCategory,
				[HasHistory]           =  IOG.HasHistory,
				[Remarks]              =  IOG.Remarks,
				[PrintSeparately]      =  IOG.PrintSeparately,
				[Gender]               =  IOG.Gender,
				[groupinterpretation]  =  IOG.groupinterpretation,
				[Issummaryworklist]    =  IOG.Issummaryworklist,
				[IsSpecialFormat]      =  IOG.IsSpecialFormat
				--[stg].[ProtocolGroup]  =  MD.DisplayText   
 From Stage2_MHL_T_03_Package_Master stg WITH (NOLOCK)
 INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeName = stg.METROLAB_PROFILECODE and CM.CodeSchemeID =@CodeSchemeID
 INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='PKG'
 AND CM.CodeType = CP.IdentifyingType 
 INNER JOIN InvOrgGroup IOG WITH (NOLOCK)  ON CP.IdentifyingID = IOG.OrgGroupID AND IOG.OrgID=@orgID
 INNER JOIN InvGroupMaster IGM WITH (NOLOCK)  ON IGM.GroupID =IOG.AttGroupID 
 --LEFT JOIN MetaData MD WITH (NOLOCK) ON IOG.ProtocalGroupID = MD.MetaDataID and MD.Domain ='ProtocalGroup_Based'
 
 
 /* Insert PKG Contents Into Stage2_MHL_T_05_PACKAGE_TESTS Table */

 INSERT INTO Stage2_MHL_T_05_PACKAGE_TESTS( [LAB],[PACKAGE_CODE],[TEST_CODE],[TEST_SEQUENCE_NO],[Type],ID )
         
         SELECT @LabName, T.GROUP_CODE, T.TEST_CODE, T.SequenceNo, T.Type, T.ID
                 FROM 
				    (
				     SELECT Distinct T.METROLAB_PROFILECODE as GROUP_CODE,CM.CodeName as TEST_CODE,IPM.SequenceNo,'INV' Type ,IOM.InvestigationID as ID
					        FROM Stage2_MHL_T_03_Package_Master T WITH (NOLOCK) 
					        INNER JOIN InvOrgGroup IOG WITH (NOLOCK)  ON IOG.OrgGroupID=T.Orggroupid
					        INNER JOIN InvPackageMapping IPM WITH (NOLOCK)  ON IPM.PackageID=IOG.OrgGroupID AND IPM.Type='INV' and IPM.active = 'A'
					        INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CP.IdentifyingID = IPM.ID and CP.IdentifyingType ='Investigations'
					        INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID  and CM.CodeSchemeID =@CodeSchemeID
					        AND CM.CodeType = CP.IdentifyingType 
					        Inner join InvestigationOrgMapping  IOM WITH (NOLOCK)  on IPM.ID = IOM.Investigationid and IOM.OrgID =@orgID
					        WHERE IOG.OrgID=@orgID 
					 
					 UNION ALL 
					
					 SELECT Distinct T.METROLAB_PROFILECODE  as GROUP_CODE,CM.CodeName as TEST_CODE,IPM.SequenceNo,'GRP' Type ,inv.OrgGroupID as ID
					        FROM Stage2_MHL_T_03_Package_Master T WITH (NOLOCK) 
					        INNER JOIN InvOrgGroup IOG WITH (NOLOCK)  ON IOG.OrgGroupID=T.Orggroupid
					        INNER JOIN InvPackageMapping IPM WITH (NOLOCK)  ON IPM.PackageID=IOG.OrgGroupID AND IPM.Type='GRP' and IPM.active = 'A'
					        Inner join InvOrgGroup Inv WITH (NOLOCK)  on IPM.ID = inv.OrgGroupID and Inv.OrgId=@orgID
					        INNER Join CodeMapper CP WITH (NOLOCK)  ON CP.IdentifyingID = Inv.OrgGroupID and CP.IdentifyingType ='GRP' 
					        INNER Join CodeMaster CM WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CM.CodeSchemeID =@CodeSchemeID
					        AND CM.CodeType = CP.IdentifyingType 
					        WHERE IOG.OrgID=@orgID  
				    ) T  
 
 
/* Insert PKG Content Level INV Into Stage2_MHL_T_01_TESTMASTER Table */	

Insert Stage2_MHL_T_01_TESTMASTER(Lab,TCode,EDOSCode,TEST_ABBREVATION,TESTTYPE)
	Select Distinct t1.Lab,t1.Test_Code,'','','INV' 
	       From Stage2_MHL_T_05_PACKAGE_TESTS t1 WITH (NOLOCK) 
	            Left join Stage2_MHL_T_01_TESTMASTER t2 WITH (NOLOCK) on t1.TEST_CODE = t2.TCODE and t2.TESTTYPE = 'INV'
	            where T1.Type = 'INV' and t2.TCODE is null


/* Update INV Details Into Stage2_MHL_T_01_TESTMASTER Table */

UPDATE T set 
			[InvestigationID]        =  IOM.InvestigationID,
			[TestName]               =  IM.InvestigationName,
			[TEST_ABBREVATION]       =  T.TEST_ABBREVATION,
			[DISPLAY_NAME]           =  IOM.DisplayText,
			[DeptName]               =  IDM.DeptName,
			[SECTION_NAME]           =  IH.HeaderName, 
			[Values_Type]            =  case IOA.ResultValueType 
						                     WHEN 'NU' THEN 'N'
						                     WHEN 'AN' THEN 'A' ELSE NULL END ,
			[Orderable]              =  CASE ISNULL(IOM.Display,'Y') 
							                 WHEN 'Y' THEN 'Y'
							                 WHEN 'N' THEN 'N' END , 
			[INPUT_FORMAT]           =  '',
			[Sample_Type]            =  ISM.SampleDesc,
			[Method]                 =  IGM.MethodName,
			[Container]              =  ISC.ContainerName,
			[Units]                  =  UOM.UOMCode,
			[SubCategory]            =  IOM.SubCategory ,
			[Decimal_Places]         =  IOA.DecimalPlaces,
			[Classification]         =  IOA.Classification ,
			[IS_MACHINE_INTERFACED]  =  IOA.IsInterfaced ,
			[REPEATABLE]             =  IOA.IsRepeatable,
			[TEST_GENDER]            =  IOM.Gender ,
			[IS_NABL]                =  IOA.IsNABL,
			[IS_CAP]                 =  IOA.IsCAP,
			[IS_STAT]                =  IOA.IsSTAT,
			[IS_SMS]                 =  IOA.IsSMS, 
			[IS_TEST_HISTORY]        =  IOA.HasHistory ,
			[OUTPUT_FORMAT]          =  '',
			[Interpretation]         =  IOM.Interpretation,
     		[CutOffTimeValue]        =	IOA.CutOffTimeValue,
		    [CutOffTimeType]         =	IOA.CutOffTimeType,
		    [IsActive]               =	IOM.IsActive,
		    [IsNonReportable]        =	IOM.IsNonReportable,
		    [PrintSeparately]        =	IOM.PrintSeparately,
		    --[IsParameter]            =	IOM.IsParameter,
		    REFERENCE_RANGE          =  IOM.ReferenceRange,
            SEQUENCE_No              =  IOM.SequenceNo,
            PANIC_RANGE              =  IOM.PanicRange 
            --T.ProtocolGroup          =  MD.DisplayText 
		 FROM Stage2_MHL_T_01_TESTMASTER T WITH (NOLOCK) 
		 INNER JOIN CodeMaster CM WITH (NOLOCK)  ON CM.CodeName = T.TCODE AND CM.CodeSchemeID =@CodeSchemeID
		 INNER JOIN CodeMapper CP WITH (NOLOCK)  ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='Investigations'
		 AND CM.CodeType = CP.IdentifyingType 
		 INNER JOIN InvestigationMaster IM WITH (NOLOCK)  ON CP.IdentifyingID = IM.InvestigationID 
		 INNER JOIN InvestigationOrgMapping IOM WITH (NOLOCK)  ON IOM.InvestigationID=IM.InvestigationID AND IOM.OrgID =@orgID
		 LEFT JOIN InvestigationOrgAttributes IOA WITH (NOLOCK)  ON IOM.InvestigationID=IOA.InvestigationID AND IOM.OrgID=IOA.OrgID
		 LEFT JOIN InvDeptMaster IDM WITH (NOLOCK)  ON IDM.DeptID=IOM.DeptID AND IDM.OrgID=@orgID
		 LEFT JOIN InvestigationHeader IH WITH (NOLOCK)  ON IH.HeaderID=IOM.HeaderID  
		 LEFT JOIN InvestigationSampleContainer ISC WITH (NOLOCK)  ON ISC.SampleContainerID=IOM.SampleContainerID AND ISC.OrgID=@orgID
		 LEFT JOIN InvSampleMaster ISM WITH (NOLOCK)  ON ISM.SampleCode=IOM.SampleCode AND ISM.OrgID=@orgID
		 LEFT JOIN UOM UOM WITH (NOLOCK)  ON UOM.UOMID=IOM.UOMID
		 LEFT JOIN InvestigationMethod IGM WITH (NOLOCK)  ON IGM.MethodID=IOM.MethodID AND IGM.OrgID=@orgID
		 --LEFT JOIN MetaData MD WITH (NOLOCK) ON IOM.ProtocalGroupID = MD.MetaDataID and MD.Domain ='ProtocalGroup_Based'
		 Where T.TestType = 'INV'
		 

/* Update InputFormat Into Stage2_MHL_T_01_TESTMASTER Table */	
	 
UPDATE T1  SET T1.INPUT_FORMAT=T3.DisplayText 
          FROM Stage2_MHL_T_01_TESTMASTER T1 WITH (NOLOCK) 
         INNER JOIN PatternMapping T2 WITH (NOLOCK)  ON T2.InvestigationID=T1.InvestigationID
         INNER JOIN InvestigationPattern T3   ON T3.PatternID=T2.PatternID  
           And T3.OrgID=@orgID 
           AND T1.TESTTYPE ='INV'
	
	
/* Update OutputFormat Into Stage2_MHL_T_01_TESTMASTER Table  */
	
UPDATE T1  SET T1.OUTPUT_FORMAT=T3.TemplateName 
          FROM Stage2_MHL_T_01_TESTMASTER T1 WITH (NOLOCK) 
         INNER JOIN InvReportMapping  T2 WITH (NOLOCK)  ON T2.InvestigationID=T1.InvestigationID
         INNER JOIN InvReportMaster T3 WITH (NOLOCK)  ON T3.TemplateID=T2.TemplateID 
           AND T3.OrgID=@orgID AND T1.TESTTYPE ='INV'

		 

/* Delete Tcodes where TestType Not In INV  */

   Delete from Stage2_MHL_T_01_TESTMASTER  
         where ISNULL(TESTTYPE,'GRP') <>'INV'
    
    
 Update GT Set GT.TEST_NAME=IM.InvestigationName 
          from Stage2_MHL_T_04_GROUP_TESTS GT
    Inner Join Investigationmaster IM 
            On IM.Investigationid=GT.ID
         Where GT.Type='INV'
 
 Update GT Set GT.TEST_NAME=GM.GroupName 
          from Stage2_MHL_T_04_GROUP_TESTS GT
    Inner Join Invorggroup IOG 
            On IOG.OrgGroupID=GT.ID
    Inner Join InvGroupMaster GM 
            ON GM.GroupID=IOG.AttGroupID
         Where IOG.OrgID=@orgID
           And GT.Type='GRP'


 Update PT Set PT.TEST_NAME=IM.InvestigationName 
          from Stage2_MHL_T_05_PACKAGE_TESTS PT
    Inner Join Investigationmaster IM 
            On IM.InvestigationID=PT.ID
         Where PT.Type='INV'


 Update PT Set PT.TEST_NAME=GM.GroupName 
          from Stage2_MHL_T_05_PACKAGE_TESTS PT
    Inner Join Invorggroup IOG 
            On IOG.OrgGroupID=PT.ID
    Inner Join InvGroupMaster GM 
            ON GM.GroupID=IOG.AttGroupID
         Where IOG.OrgID=@orgID
           And PT.Type='GRP'


Select GT.LAB,GT.GROUP_CODE,IM.GroupName,GT.TEST_CODE,GT.TEST_NAME,GT.TEST_SEQUENCE_NO,GT.InvestigationID,
       GT.OrgGroupID,GT.Type,GT.ID 
          Into Stage2_MHL_T_04_GROUP_TESTSS from Stage2_MHL_T_04_GROUP_TESTS GT
    INNER Join CodeMaster CM 
            ON CM.CodeName =GT.Group_code
    INNER JOIN CodeMapper CP 
            ON CM.CodeMasterID = CP.CodeMasterID 
           AND CM.CodeType =CP.IdentifyingType 
    INNER Join InvOrgGroup  IOM 
            ON IOM.OrgGroupID =CP.IdentifyingID 
    INNER JOIN InvGroupMaster IM 
            ON IM.GroupID  =IOM.AttGroupID  
         WHERE CM.CodeSchemeID =@CodeSchemeID 
           AND CP.IdentifyingType ='GRP' 
           AND IOM.OrgID =@orgID
         
         
        
Select PT.LAB,PT.PACKAGE_CODE,IM.GroupName as [PACKAGE_NAME],PT.TEST_CODE,PT.TEST_NAME,PT.TEST_SEQUENCE_NO,pt.InvestigationID,
       PT.OrgGroupID,PT.Type,PT.ID
          Into Stage2_MHL_T_05_PACKAGE_TESTSS from Stage2_MHL_T_05_PACKAGE_TESTS PT
    INNER Join CodeMaster CM 
            ON CM.CodeName =PT.PACKAGE_CODE
    INNER JOIN CodeMapper CP 
            ON CM.CodeMasterID = CP.CodeMasterID 
           AND CM.CodeType =CP.IdentifyingType 
    INNER Join InvOrgGroup  IOM 
            ON IOM.OrgGroupID =CP.IdentifyingID 
    INNER JOIN InvGroupMaster IM 
            ON IM.GroupID  =IOM.AttGroupID  
         WHERE CM.CodeSchemeID =@CodeSchemeID 
           AND CP.IdentifyingType ='PKG' 
           AND IOM.OrgID =@orgID