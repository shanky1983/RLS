

/* New INV,GRP,PKG Creation Script */
    
    
Begin Try
	Begin Tran
		Declare @orgID int = 69
		Declare @ProcessingLocation varchar(50) = 'Jabalpur'
				
		Declare @createdby Bigint
		set @createdby=3366
		
		If Exists(Select 1 From Sys.sysobjects(nolock) Where TYPE = 'U'	And name = 'Stage_MHL_T_02_GROUP_MASTER')
		Begin
			Drop table Stage_MHL_T_02_GROUP_MASTER
		End
		
		If Exists(Select 1 From Sys.sysobjects(nolock) Where TYPE = 'U'	And name = 'Stage_MHL_T_01_TESTMASTER')
		Begin
			Drop table Stage_MHL_T_01_TESTMASTER
		End
		
		If Exists(Select 1 From Sys.sysObjects (nolock) Where Type='U' and name = 'Stage_MHL_T_04_GROUP_TESTS')
		Begin
			Drop table Stage_MHL_T_04_GROUP_TESTS
		End
		 
		If Exists (Select 1 From Sys.sysobjects (nolock) Where Type = 'U' and name = 'stage_SubGroup')
		Begin
			Drop table stage_SubGroup
		End
		 
		If Exists(Select 1 From Sys.sysObjects (nolock) Where Type='U' and name = 'Stage_MHL_T_03_Package_Master')
		Begin
			Drop table Stage_MHL_T_03_Package_Master
		End
		 
		If Exists(Select 1 From Sys.sysObjects (nolock) Where Type='U' and name = 'Stage_MHL_T_05_PACKAGE_TESTS')
		Begin
			Drop table Stage_MHL_T_05_PACKAGE_TESTS
		End

/* Copy Data From Source Template to Intermediate Template Table */		

		Select * into Stage_MHL_T_02_GROUP_MASTER from [Excel_GRP_296] 
		Select * into Stage_MHL_T_01_TESTMASTER from [Excel_INV_296] 
		Select * into Stage_MHL_T_04_GROUP_TESTS from [Excel_GRP_Content_296]  
		Select * into Stage_MHL_T_03_Package_Master from [Excel_CARD_296] 
		Select * into Stage_MHL_T_05_PACKAGE_TESTS from [Excel_Card_Content_296] 
		
		Update Stage_MHL_T_02_GROUP_MASTER set Orggroupid = Null
		Update Stage_MHL_T_01_TESTMASTER   set InvestigationID = null
		Update Stage_MHL_T_04_GROUP_TESTS SET InvestigationID=NULL,OrgGroupID=NULL
		Update Stage_MHL_T_03_Package_Master SET OrgGroupID=NULL
		Update Stage_MHL_T_05_PACKAGE_TESTS SET InvestigationID=NULL,OrgGroupID=NULL
		Update Stage_MHL_T_01_TESTMASTER SET PROCESSING_LOCATION='Vadodara' where SubCategory='INH'


/* InvestigationMaster */
		Declare @orgid int=296
	    Declare @max Bigint
		Select @max=0	
		Select  @Max = isnull(MAX(InvestigationID),0) From InvestigationMaster
	
		Insert into InvestigationMaster(InvestigationName,Display,InvestigationID,TestCode,IsParameter)
		
				Select TestName,CASE When stg.Orderable='Y' then 'Y' ELSE 'N' END Display,
				ROW_NUMBER() over (Order By TestName) + @max as InvestigationID,TCODE ,stg.IsParameter
				from Stage_MHL_T_01_TESTMASTER	stg WITH (NOLOCK)
				Left join InvestigationMaster inv WITH (NOLOCK) on stg.TCode = inv.TestCode --and inv.InvestigationName=stg.testname
				Where TestType = 'INV'
				and Inv.TestCode is null and ISNULL(stg.TCODE ,'')<>''
	
				
	    Update M set InvestigationID=T.InvestigationId
				 From Stage_MHL_T_01_TESTMASTER M WITH (NOLOCK)
				 Inner Join InvestigationMaster T WITH (NOLOCK) on T.TestCode=M.TCODE --and T.InvestigationName=M.testname
				 Where M.TestType = 'INV'
		  			
		Update M set InvestigationID=T.InvestigationId
				 From Stage_MHL_T_04_GROUP_TESTS M WITH (NOLOCK)
				 Inner Join InvestigationMaster T WITH (NOLOCK) on T.TestCode=M.Test_Code --and T.InvestigationName=M.testname
				 Where M.TYPE = 'INV'			
				
/* DeptMaster */			
		Declare @orgid int=296
	    Declare @max Bigint
			--Insert into DeptMaster (DeptName,Code) 
			Select distinct DeptName,'' as SHORTNAME from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)
			       where DeptName NOT IN (SELECT ISNULL(DeptName,'') FROM DeptMaster WITH (NOLOCK))
			       AND ISNULL(DeptName,'')<>''
			
			Declare @orgid int=296
	    Declare @max Bigint
			Select @max = 0
			Select @max = isnull(MAX(DeptID),0) From InvDeptMaster WITH (NOLOCK) where OrgID=@orgID
			
          Insert into InvDeptMaster(DeptName,SequenceNo,Display,OrgID,DeptID)		
					Select DeptName,'' as SEQUENCE_REPORT,'Y',@OrgID,ROW_NUMBER() over (order by DeptName) + @max as DeptId  from (	   
				           Select DISTINCT DeptName from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) 
				           where DeptName NOT IN ( Select DeptName FROM InvDeptMaster WITH (NOLOCK) where OrgID=@orgID  )
				           AND ISNULL(DeptName,'')<>''
				           ) t
		
			
			Update T set DeptCode=M.DeptCode
			From InvDeptMaster T WITH (NOLOCK)
			Inner Join DeptMaster M WITH (NOLOCK) on M.DeptName=T.DeptName where T.OrgID=296
			
		
							
/* Header(Section) */
		Declare @orgid int=296
	    Declare @max Bigint				
		Select @max = 0
		Select @max = isnull(MAX(HeaderID),0) From InvestigationHeader WITH (NOLOCK)
      
       -- Insert into InvestigationHeader(HeaderName,HeaderID)
                   Select  Distinct SECTION,ROW_NUMBER() over (order by SECTION) + @max as HeaderID
                    from (
							Select distinct SECTION_NAME as SECTION from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)  Where testType = 'INV' and  isnull(Section_name,'')<> ''
						 ) t where t.SECTION NOT IN ( select HeaderName from InvestigationHeader WITH (NOLOCK) )
					
							      
/* UOM */
        Declare @orgid int=296
	    Declare @max Bigint	
		Select @max = 0
		Select @Max = isnull(MAX(UOMID),0) From UOM WITH (NOLOCK)
			
		--Insert into UOM(UOMCode,UOMDescription,UOMID)
			        Select Units,Units,ROW_NUMBER() over (order by Units)+ @max as UOMID 
						   From ( Select Distinct Units
										 from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)
								 )t
					       where Units not in ( select UOMDescription from UOM WITH (NOLOCK) ) and isnull(Units,'') <> ''



/* Sample Container */
	Declare @orgid int=296
	    Declare @max Bigint
	    select @max = 0
		Select @max = isnull(MAX(SampleContainerID),0) From InvestigationSampleContainer WITH (NOLOCK) where OrgID=@OrgID
		
		Insert into InvestigationSampleContainer(ContainerName,orgId,Description,Active,SampleContainerID)
						
					Select Distinct NAME,@orgId,Substring(NAME,1,6) as SHORTNAME,'Y',ROW_NUMBER() over (order by NAME) + @max as SampleContainerID
						   from 
						      ( Select distinct Container as Name from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) Where isnull(Container,'') <> '' ) t 
						        Where
						        NAME Not In ( Select Distinct ContainerName from InvestigationSampleContainer WITH (NOLOCK)
												where OrgID=@OrgID ) 					
				
				

/* Sample Master */
		Declare @orgid int=296
	    Declare @max Bigint					       
	 	select @max = 0
		Select  @Max = isnull(MAX(SampleCode),0) From InvSampleMaster WITH (NOLOCK) where OrgID=@OrgID

    		Insert into InvSampleMaster(SampleDesc,OrgID,Active,SampleCode)
				        
				        Select Distinct SAMPLE_DESCRIPTION,@orgID,'Y',ROW_NUMBER() over (order by SAMPLE_DESCRIPTION) + @max as SampleCode 
				              from  
				              ( Select distinct Sample_Type as SAMPLE_DESCRIPTION 
				                       from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) Where isnull(Sample_Type,'') <> ''
				              ) t
						      Where SAMPLE_DESCRIPTION Not In ( Select Distinct SampleDesc from InvSampleMaster WITH (NOLOCK) 
													                  where OrgID=@OrgID )
							        
 		
/* Investigation Method */
Declare @orgid int=296
	    Declare @max Bigint
        select @max = 0
		Select @max = isnull(MAX(MethodID),0) From InvestigationMethod WITH (NOLOCK) where OrgID=@orgID 

	Insert into InvestigationMethod(MethodName,OrgID,CreatedAt,CreatedBy,MethodID)
				    Select Distinct NAME,@OrgID,GETDATE(),3366,ROW_NUMBER() over (order by NAME) + @max as MethodID 
				           from 
				           ( select distinct Method as NAME from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) where ISNULL(Method,'') <> '' 
				           ) t
						   Where NAME Not In ( Select Distinct MethodName from InvestigationMethod WITH (NOLOCK) where OrgID=@orgID  )
						  

/* Protocol Group */
Declare @orgid int=296
	    Declare @max Bigint
		Select @max=0	
		Select  @Max = isnull(MAX(MetaDataID),0) From MetaData

		Set IDENTITY_INSERT MetaData ON

		--INSERT INTO MetaData(MetaDataID,Domain,Code,DisplayText,LangCode)

		SELECT ROW_NUMBER() over (Order By DisplayText) + @max as MetaDataID, Domain,ROW_NUMBER() over (Order By DisplayText) + @max as Code,
		DisplayText,LangCode 
		FROM 
		(
			SELECT DISTINCT  'ProtocalGroup_Based' as Domain,ProtocolGroup as DisplayText,'en-GB' as LangCode 
			       FROM Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			
			UNION
			
			SELECT DISTINCT  'ProtocalGroup_Based' as Domain,ProtocolGroup as DisplayText,'en-GB' as LangCode 
			       FROM Stage_MHL_T_02_GROUP_MASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			
			--UNION 
			
			--SELECT DISTINCT  'ProtocalGroup_Based' as Domain,ProtocolGroup as DisplayText,'en-GB' as LangCode 
			--       FROM Stage_MHL_T_03_Package_Master WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			
			EXCEPT 
			SELECT Domain,DisplayText,LangCode FROM MetaData where Domain ='ProtocalGroup_Based'
		)t

		Set IDENTITY_INSERT MetaData OFF
		
	
		--INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)

		SELECT DISTINCT  MD.MetaDataID ,@OrgID as OrgID,'en-GB' as LangCode,PR.ProtocolGroup as DisplayText
			   FROM 
			       (
			        SELECT ProtocolGroup FROM Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			        UNION
			        SELECT ProtocolGroup FROM Stage_MHL_T_02_GROUP_MASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			        --UNION
			        --SELECT ProtocolGroup FROM Stage_MHL_T_03_Package_Master WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			       )PR 
					 INNER JOIN MetaData MD ON PR.ProtocolGroup=MD.DisplayText  
					 WHERE MD.Domain ='ProtocalGroup_Based' AND MD.MetaDataID NOT IN
					(SELECT MetaDataID  FROM MetaDataOrgMapping where OrgID =@OrgID)

		   

/* InvestigationID,DeptID,SampleCode,MethodID,SampleContainerID,HeaderId,UomId updation Into Stage_MHL_T_01_TESTMASTER  */
		Declare @orgid int=296
	    Declare @max Bigint 	
	Update T set InvestigationID=IM.InvestigationID
			 From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			 Inner Join InvestigationMaster IM WITH (NOLOCK) on T.TCODE=IM.TestCode
			 Where t.testType = 'INV'

	Update T set T.DeptID=IDM.DeptID
		    From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			INNER JOIN DeptMaster DM WITH (NOLOCK) ON DM.DeptName=T.DeptNAme
			Inner Join InvDeptMaster IDM WITH (NOLOCK) on IDM.DeptCode =DM.DeptCode
			Where t.testType = 'INV'
			and IDM.OrgID=@OrgID
		
	Update T set SampleCode=ISM.SampleCode
		   From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
		   Inner Join InvSampleMaster ISM WITH (NOLOCK) on T.Sample_Type=ISM.SampleDesc
		   Where t.testType = 'INV' and ISM.OrgID=@OrgID
		
	Update T set MethodID=IM.MethodID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join InvestigationMethod IM WITH (NOLOCK) on T.Method=IM.MethodName
			Where t.testType = 'INV'
			and IM.OrgID=@OrgID
	
					
	Update T set SampleContainerID=ISC.SampleContainerID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join InvestigationSampleContainer ISC WITH (NOLOCK) on LTRIM(T.Container)=ISC.ContainerName
			Where t.testType = 'INV' and ISC.OrgID=@OrgID
		 
	Update T set HeaderId=IH.HeaderID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join InvestigationHeader IH WITH (NOLOCK) on T.SECTION_NAME=IH.HeaderName
			Where t.testType = 'INV'
	
	Update T set UOMID=U.UOMID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join UOM U WITH (NOLOCK) on U.UOMCode=T.Units 
			Where t.testType = 'INV'
				
	Update T set AutoAuthorizationId=U.LoginID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join Users U WITH (NOLOCK) on U.Name=T.AUTORIZATION
			Where t.testType = 'INV' AND OrgID=@orgID 
			
	Update T Set T.ProtocolGroupID = MD.MetaDataID  
	         from Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK) 
	         Inner JOIN MetaData MD WITH (NOLOCK)  ON T.ProtocolGroup = MD.DisplayText 
	         where T.TESTTYPE ='INV' and MD.Domain ='ProtocalGroup_Based' 
	 
	Update T Set T.ProtocolGroupID = MD.MetaDataID  
	         from Stage_MHL_T_02_GROUP_MASTER T WITH (NOLOCK) 
	         Inner JOIN MetaData MD WITH (NOLOCK)  ON T.ProtocolGroup = MD.DisplayText 
	         where  MD.Domain ='ProtocalGroup_Based' 
	         
	Update T Set T.ProtocolGroupID = MD.MetaDataID  
	         from Stage_MHL_T_03_Package_Master T WITH (NOLOCK) 
	         Inner JOIN MetaData MD WITH (NOLOCK)  ON T.ProtocolGroup = MD.DisplayText 
	         where MD.Domain ='ProtocalGroup_Based' 


/* Insert INV - Tcode,EdosCode and AbbCode into CodeMAster and CodeMapper */
			Declare @orgid int=296
	    Declare @max Bigint 	
	INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
	Select Stg.Tcode,'Investigations',5,Testname
	From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	left join Codemaster CM WITH (NOLOCK) on stg.TCode = Cm.Codename and Cm.Codeschemeid = 5 
	Where stg.TestType = 'INV'
	and isnull(Stg.TCode,'') <> ''
	and CM.Codemasterid is null


	--INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
	--Select Stg.EDOSCode,'Investigations',2,Testname
	--From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	--left join Codemaster CM WITH (NOLOCK) on stg.EDOSCode = Cm.Codename and Cm.Codeschemeid = 2 and stg.TestName = CM.CodeDesc
	--Where stg.TestType = 'INV'
	--and isnull(Stg.EDOSCode,'') <> ''
	--and CM.Codemasterid is null
	
	--INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
	--Select Stg.Test_abbrevation,'Investigations',3,Testname
	--From 
	--Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	--left join Codemaster CM WITH (NOLOCK) on stg.Test_abbrevation = Cm.Codename and Cm.Codeschemeid = 3  and stg.TestName = CM.CodeDesc
	--Where stg.TestType = 'INV'
	--and isnull(Stg.Test_abbrevation,'') <> ''
	--and CM.Codemasterid is null

	INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
	Select 'investigations',Stg.Investigationid,CM.Codemasterid
	From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	Inner join Codemaster CM WITH (NOLOCK) on stg.TCode = Cm.Codename and Cm.Codeschemeid = 5  
	 LEFT JOIN CodeMapper CM2 WITH (NOLOCK) ON CM2.CodeMasterID=CM.CodemasterID AND CM2.IdentifyingID=Stg.Investigationid 
	 AND CM2.IdentifyingType='Investigations'
	Where stg.TestType = 'INV'  AND CM2.CodeMasterID IS NULL
	and isnull(Stg.TCode,'') <> ''
	
	--INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
	--Select 'investigations',Stg.Investigationid,CM.Codemasterid
	--From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	--inner join Codemaster CM WITH (NOLOCK) on stg.EDOSCode = Cm.Codename and Cm.Codeschemeid = 2 and stg.TestName = CM.CodeDesc
	-- LEFT JOIN CodeMapper CM2 WITH (NOLOCK) ON CM2.CodeMasterID=CM.CodemasterID AND CM2.IdentifyingID=Stg.Investigationid 
	-- AND CM2.IdentifyingType='Investigations'
	--Where stg.TestType = 'INV'  AND CM2.CodeMasterID IS NULL
	--and isnull(Stg.EDOSCode,'') <> ''
	
	--INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
	--Select 'investigations',Stg.Investigationid,CM.Codemasterid
	--From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	--inner join Codemaster CM WITH (NOLOCK) on stg.Test_abbrevation = Cm.Codename and Cm.Codeschemeid = 3 and stg.TestName = CM.CodeDesc
	-- LEFT JOIN CodeMapper CM2 WITH (NOLOCK) ON CM2.CodeMasterID=CM.CodemasterID AND CM2.IdentifyingID=Stg.Investigationid 
	-- AND CM2.IdentifyingType='Investigations'
	--Where stg.TestType = 'INV' AND CM2.CodeMasterID IS NULL
	--and isnull(Stg.Test_abbrevation,'') <> ''


/* Processing Location Updation Into Stage_MHL_T_01_TESTMASTER */
			Declare @orgid int=296
	    Declare @max Bigint
	    Update T
	    set Processing_AddressID=OA.AddressID
	    From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
	    Inner Join OrganizationAddress OA WITH (NOLOCK) on OA.Location=T.PROCESSING_LOCATION 
	    WHERE ISNULL(T.SubCategory,'')<>'OUT'
	    and T.testType = 'INV' and OA.OrgID=@orgID 
	   
	   	Update T
	    set Processing_AddressID=LRA.AddressID
	    From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
	    Inner Join LabReferenceORg OA WITH (NOLOCK) on OA.RefOrgName=T.PROCESSING_LOCATION and OA.OrgID =@orgID 
	    INNER JOIN labreforgaddress LRA WITH (NOLOCK) ON LRA.LabRefOrgId=OA.LabRefOrgId
	    WHERE ISNULL(T.SubCategory,'')='OUT'		
		and T.testType = 'INV'

	    
/* Insert InvestigationOrgMapping  */
	Declare @orgid int=296
	    Declare @max Bigint
	Insert into InvestigationOrgMapping(orgID,DisplayText,InvestigationID,DeptID,SampleCode,MethodID,SampleContainerID,UOMID,SubCategory,
											ProcessingAddressID,AutoApproveLoginID,HeaderID,InvestigationCode,Display,Interpretation,
											IsActive,IsNonReportable,PrintSeparately,UOMCode,Gender,IsSTAT,
											IsDiscountable,ReferenceRange,SequenceNo,PanicRange)
			Select	Distinct @orgID,
					         DISPLAY_NAME,
					         stg.InvestigationID,
					         stg.DeptID,
							 stg.SampleCode,
							 stg.MethodID,
							 stg.SampleContainerID,
							 stg.UOMID,
							 CASE stg.subCategory WHEN 'INH' THEN 'INH' 
							                      WHEN 'InHouse' THEN 'INH' 
							                      WHEN 'OUT' THEN 'OUT'
							                      WHEN 'OutSourced' THEN 'OUT' END AS subCategory, 
							 stg.Processing_AddressID, 
							 stg.AutoAuthorizationId,
							 stg.HeaderID,
							 stg.TCODE,
							 Case when stg.Orderable IS NULL then 'Y' Else Orderable End Orderable,
							 stg.Interpretation, 
							 ISNULL(stg.IsActive,''),
							 stg.IsNonReportable,
							 stg.PrintSeparately,
							 stg.units,
							 stg.TEST_GENDER,
							 CASE stg.IS_STAT WHEN '1' THEN 1 ELSE 0 END,
							 1,
							 stg.REFERENCE_RANGE,
							 SEQUENCE_No,
							 stg.PANIC_RANGE
				From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
				Left join InvestigationOrgmapping Invmap WITH (NOLOCK) on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =@orgID 
				Where stg.TestType = 'INV' and stg.InvestigationID is not null and invmap.investigationid is null and 
				ISNULL(stg.TCODE,'')<>''


/* Insert InvestigationOrgAttributes */
Declare @orgid int=296
	    Declare @max Bigint
	 Insert into InvestigationOrgAttributes(OrgID,InvestigationID,ResultValueType,DecimalPlaces,IsCAP,Classification,IsRepeatable,IsSMS,IsSTAT,
						                       IsInterfaced,IsNABL,HasHistory,CutOffTimeValue,CutOffTimeType,IsDiscountable)
		
		Select Distinct @OrgID,
		                stg.InvestigationID,
				        Case when stg.Values_Type='N' OR stg.Values_Type='Numeric' Then 'NU' 
					         When stg.Values_Type='A' OR stg.Values_Type='Alpha Numeric' Then 'AN'
						     Else Null End,
					    stg.Decimal_Places,
					    stg.IS_CAP,
					    stg.Classification,
					    stg.[REPEATABLE],
					    stg.IS_SMS,
					    stg.IS_STATISTICAL,
					    stg.IS_MACHINE_INTERFACED,
					    stg.IS_NABL,
					    stg.IS_TEST_HISTORY,
					    stg.CutOffTimeValue,
						stg.CutOffTimeType,
						'Y'
			   From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
			   Left join InvestigationOrgAttributes Invmap WITH (NOLOCK) on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =@OrgID
			   Where stg.TestType = 'INV' and stg.InvestigationID is not null and invmap.investigationid is null and 
			   ISNULL(stg.TCODE,'')<>''
														
														
/* Insert Input and Output Format */
Declare @orgid int=296
	    Declare @max Bigint
	INSERT INTO PatternMapping (PatternID,InvestigationID)
	Select Distinct PatternID,InvestigationID
		From
			( 
			select distinct IP.PatternID,T.InvestigationID from Stage_MHL_T_01_TESTMASTER  T  WITH (NOLOCK)
            INNER JOIN InvestigationPattern IP  WITH (NOLOCK) ON IP.DisplayText=T.INPUT_FORMAT  and IP.OrgID=@OrgID
            Where t.TestType = 'INV' and isnull(t.input_format,'') <> ''
			Except
			Select PatternID,InvestigationID From PatternMapping  WITH (NOLOCK)	--where Orgid = @Orgid
			)t


  INSERT INTO InvReportMapping (TemplateID,InvestigationID)
	Select Distinct TemplateID,InvestigationID
		From
			( 
			select IP.TemplateID,T.InvestigationID from Stage_MHL_T_01_TESTMASTER  T   WITH (NOLOCK)
            INNER JOIN InvReportMaster IP  WITH (NOLOCK) ON IP.TemplateName=T.OUTPUT_FORMAT  and IP.OrgID=@OrgID
            Where t.TestType = 'INV' and isnull(t.OUTPUT_FORMAT,'') <> ''
			Except
			Select TemplateID,InvestigationID From InvReportMapping  WITH (NOLOCK)	--where OrgID=@OrgID
			)t
			
			
 /* Insert OutSource Test */	
 Declare @orgid int=296
	    Declare @max Bigint
 DECLARE @pOrgAddressID INT 
 SELECT @pOrgAddressID=MAX(AddressID) FROM OrganizationAddress WITH (NOLOCK) where OrgID=@OrgID and ISNULL(IsDefault,'')='Y' 

	--INSERT INTO InvestigationLocationMapping (InvestigationID,OrgID,LocationID,ProcessingOrgID,ProcessingAddressID,Type)
	
	SELECT InvestigationID,OrgID,LocationID,ProcessingOrgID,ProcessingAddressID,Type 
		FROM
		(
			SELECT DISTINCT TM.InvestigationID,@OrgID AS OrgID,@pOrgAddressID AS LocationID, LRO.LabRefOrgID AS ProcessingOrgID, 
					LRA.AddressID AS ProcessingAddressID,12 AS Type 
					from Stage_MHL_T_01_TESTMASTER TM  WITH (NOLOCK)   
					INNER JOIN LabReferenceORg LRO  WITH (NOLOCK) ON LRO.RefOrgName=TM.PROCESSING_LOCATION AND LRO.OrgID =@OrgID
					INNER JOIN labreforgaddress LRA WITH (NOLOCK) ON LRA.LabRefOrgId=LRO.LabRefOrgId
					LEFT JOIN InvestigationLocationMapping ILM WITH (NOLOCK) ON ILM.InvestigationID=TM.InvestigationID 
					AND ILM.ProcessingOrgID= LRO.LabRefOrgID AND ILM.ProcessingAddressID=LRA.AddressID
					AND ILM.OrgID=@OrgID AND ILM.LocationID= @pOrgAddressID
					WHERE ILM.InvestigationID IS NULL AND ISNULL(TM.SubCategory,'')='OUT'
						  AND TM.TestType='INV'
		 ) T 



/* Group Insertions */
Declare @orgid int=296
	    Declare @max Bigint
			Select @max = 0
			Select  @Max = isnull(MAX(GroupID),0) From InvGroupMaster WITH (NOLOCK)

			Insert into InvGroupMaster(GroupName,Type,GroupID,TestCode)
			
			Select stg.GROUPNAME,'GRP',ROW_NUMBER() over (order by stg.GroupName) + @max as GroupID,stg.METRO_COMBINE_CODE
					From Stage_MHL_T_02_GROUP_MASTER Stg WITH (NOLOCK)
					left join Invgroupmaster grp WITH (NOLOCK) on stg.METRO_COMBINE_CODE = grp.TestCode  AND grp.Type='GRP' and stg.GROUPNAME=grp.GroupName
					Where  1= 1 and isnull(stg.METRO_COMBINE_CODE,'') <> '' and grp.Groupid is null
			

			
			
		
		    Declare @orgid int=296
	        Declare @max Bigint
			Select  @max= 0 
			Select @Max = isnull(MAX(OrgGroupID),0) From InvOrgGroup WITH (NOLOCK)


	        Insert into InvOrgGroup(AttGroupID,OrgID,DisplayText,IsNonOrderable,Classification,OrgGroupID,TestCode,ValidationText,
										ValidationRule,IsDiscountable,IsServicetaxable,Status,CutOffTimeValue,CutOffTimeType,
										SubCategory,HasHistory,Remarks,PrintSeparately,Gender,groupinterpretation,Issummaryworklist,
										IsSpecialFormat,SequenceNo)
				
				select Distinct igm.Groupid,
				                @OrgID,
				                stg.DISPLAY_NAME,
							    CASE WHEN ISNULL(stg.IS_ORDERABLE,'N')='N' THEN 'Y' ELSE 'N' END,
							    stg.CLASSIFICATION,
							    ROW_NUMBER() over (order by stg.DISPLAY_NAME) + @max as OrgGroupID,
							    IGM.TestCode,
							    stg.ValidationText,
								stg.ValidationRule,
								'Y',
								stg.IsServicetaxable,
								stg.Status,
								stg.CutOffTimeValue,
								stg.CutOffTimeType,
								stg.SubCategory,
								stg.HasHistory,
								stg.Remarks,
								stg.PrintSeparately,
								stg.Gender,
								stg.groupinterpretation,
								'Y',
								stg.IsSpecialFormat , 
								ROW_NUMBER() over (order by stg.DISPLAY_NAME) + @max as SequenceNo
						From Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
						Inner join InvGroupMaster IGM WITH (NOLOCK) on stg.METRO_COMBINE_CODE = IGM.TestCode
						Left Join InvOrgGroup Invgrp WITH (NOLOCK) on IGM.Groupid = invgrp.Attgroupid and invgrp.OrgID=@OrgID  
						Where 1 = 1 and isnull(stg.METRO_COMBINE_CODE,'') <> '' and invgrp.attgroupid is null 
			
			


			Update T Set T.OrgGroupID=S.OrgGroupID  from Stage_MHL_T_02_GROUP_MASTER T WITH (NOLOCK)
			         Inner JOIN InvGroupMaster I WITH (NOLOCK) ON T.METRO_COMBINE_CODE = I.TestCode --and I.GROUPNAME=T.GroupName
			         Inner JOIN InvOrgGroup S WITH (NOLOCK) ON S.AttGroupID = I.GroupID 
			         Where S.OrgID =@OrgID and I.Type ='GRP'
 	
		
/* Insert GRP - Tcodes,EdosCode and AbbCode Into CodeMaster and CodeMapper */
	 Declare @orgid int=296
	    Declare @max Bigint
					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT METRO_COMBINE_CODE AS CodeName,'GRP',5,GROUPNAME AS CodeDesc 
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.METRO_COMBINE_CODE = CM.Codename and CM.Codeschemeid = 5 and Cm.CodeType = 'GRP'
					
					Where isnull(Stg.METRO_COMBINE_CODE,'') <> ''
					and CM.Codemasterid is null
					
 
 				--	INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					--SELECT EDOSCODE AS CodeName,'GRP',2,GROUPNAME AS CodeDesc 
					--FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					--Left join Codemaster CM WITH (NOLOCK) on Stg.EDOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'GRP'
					--AND Stg.GROUPNAME=CM.CodeDesc
					--Where isnull(Stg.EDOSCODE,'') <> ''
					--and CM.Codemasterid is null
					
					--INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					--SELECT ABBREVATION AS CodeName,'GRP',3,GROUPNAME AS CodeDesc 
					--FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					--Left join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'GRP'
					--AND Stg.GROUPNAME=CM.CodeDesc
					--Where isnull(Stg.ABBREVATION,'') <> ''
					--and CM.Codemasterid is null
					
	
					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'GRP',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					inner join Codemaster CM WITH (NOLOCK) on Stg.METRO_COMBINE_CODE = CM.Codename and CM.Codeschemeid = 5 and Cm.CodeType = 'GRP' 
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'GRP'
			    	Where isnull(Stg.METRO_COMBINE_CODE,'') <> ''
					and CMAP.Codemasterid is null
					
 
 				--	INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					--SELECT 'GRP',Stg.orggroupid,CM.Codemasterid
					--FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					--inner join Codemaster CM WITH (NOLOCK) on Stg.EDOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'GRP' AND Stg.GROUPNAME=CM.CodeDesc
					--Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'GRP'
					--Where isnull(Stg.EDOSCODE,'') <> ''
					--and CMAP.Codemasterid is null
					
					--INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					--SELECT 'GRP',Stg.orggroupid,CM.Codemasterid
					--FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					--Inner join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'GRP' AND Stg.GROUPNAME=CM.CodeDesc
					--Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'GRP'
					--Where isnull(Stg.ABBREVATION,'') <> ''
					--and CMAP.Codemasterid is null

/* Update InvestigationId and OrgGroupId Into Stage_MHL_T_04_GROUP_TESTS */					
 Declare @orgid int=296
	    Declare @max Bigint
      Update T set OrgGroupID=IOG.OrgGroupId
               From Stage_MHL_T_04_GROUP_TESTS T WITH (NOLOCK)
               Inner Join CodeMaster CM WITH (NOLOCK) ON CM.CodeName = T.GROUP_CODE and CM.CodeSchemeID =5
               Inner Join CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
               AND CM.CodeType = CP.IdentifyingType 
               Inner Join InvOrgGroup IOG WITH (NOLOCK) on CP.IdentifyingID =IOG.OrgGroupID 
               where IOG.OrgID =@orgID 

      Update M  set InvestigationID=T.OrgGroupID
				From Stage_MHL_T_04_GROUP_TESTS M WITH (NOLOCK)
				Inner Join CodeMaster CM WITH (NOLOCK) ON CM.CodeName = M.TEST_CODE and CM.CodeSchemeID =5
                Inner Join CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
                AND CM.CodeType = CP.IdentifyingType 
				Inner Join InvOrgGroup T WITH (NOLOCK) on CP.IdentifyingID = T.OrgGroupID 
				WHERE ISNULL(Type,'INV')='GRP' and T.OrgID =@orgID 
	
	
/* Insert Group Contents */
Declare @orgid int=296
	    Declare @max Bigint
      Insert into InvGroupMapMaster(GroupID,InvestigationID,SequenceNo,Parent,Active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'N','Y' as Active
			From Stage_MHL_T_04_GROUP_TESTS stg WITH (NOLOCK)
			Left join InvGroupMapMaster grp WITH (NOLOCK) on stg.orggroupid = grp.GroupID 
			and stg.investigationid = grp.investigationid and grp.Parent = 'N'
			WHERE ISNULL(stg.Type,'INV')='INV'
			and grp.GroupID is null
	
	
	  Insert into InvGroupMapMaster(GroupID,InvestigationID,SequenceNo,Parent,Active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'Y','Y' as Active
			From Stage_MHL_T_04_GROUP_TESTS stg WITH (NOLOCK)
			Left join InvGroupMapMaster grp WITH (NOLOCK) on stg.orggroupid = grp.GroupID 
			and stg.investigationid = grp.investigationid  and grp.Parent = 'Y'
			WHERE ISNULL(stg.Type,'INV')='GRP'
			and grp.GroupID is null	
	
			
/*  Packages Insertions */	
  Declare @orgid int=296
	    Declare @max Bigint
        Select @max = 0
		Select  @Max = isnull(MAX(GroupID),0) From InvGroupMaster WITH (NOLOCK)

	--Insert into InvGroupMaster(GroupName,Type,GroupID,TestCode)
		       Select stg.PACKAGE_NAME,'PKG',ROW_NUMBER() over (order by stg.PACKAGE_NAME) + @max as GroupID,
		              stg.METROLAB_PROFILECODE
		              From Stage_MHL_T_03_Package_Master Stg WITH (NOLOCK)
		                   left join Invgroupmaster grp WITH (NOLOCK) on stg.METROLAB_PROFILECODE = grp.TestCode AND grp.Type='PKG'-- and stg.PACKAGE_NAME=grp.GroupName
		                   Where  1= 1 and isnull(stg.METROLAB_PROFILECODE,'') <> '' and grp.Groupid is null
		

	    Declare @orgid int=296
	    Declare @max Bigint
	    Select  @max= 0 
	    Select @Max = isnull(MAX(OrgGroupID),0) From InvOrgGroup WITH (NOLOCK)
	
		Insert into InvOrgGroup(AttGroupID,OrgID,DisplayText,IsNonOrderable,Classification,OrgGroupID,TestCode,							 
								    	ValidationText,ValidationRule,IsDiscountable,IsServicetaxable,Status,
										CutOffTimeValue,CutOffTimeType,SubCategory,HasHistory,Remarks,PrintSeparately,
										Gender,groupinterpretation,Issummaryworklist,IsSpecialFormat,SequenceNo)
				select Distinct igm.Groupid,
				                @orgID,
				                stg.DISPLAY_NAME,
								CASE WHEN ISNULL(stg.IS_ORDERABLE,'N')='N' THEN 'Y' ELSE 'N' END,
								stg.CLASSIFICATION,
								ROW_NUMBER() over (order by stg.DISPLAY_NAME) + @max as OrgGroupID,
								IGM.TestCode, 
								stg.ValidationText,
								stg.ValidationRule,
								'Y',
								stg.IsServicetaxable,
								stg.Status,
								stg.CutOffTimeValue,
								stg.CutOffTimeType,
								stg.SubCategory,
								stg.HasHistory,
								stg.Remarks,
								stg.PrintSeparately,
								stg.Gender,
								stg.groupinterpretation,
								'Y',
								stg.IsSpecialFormat,
								ROW_NUMBER() over (order by stg.DISPLAY_NAME) + @max as SequenceNo 
						From Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
						Inner join InvGroupMaster IGM WITH (NOLOCK) on stg.METROLAB_PROFILECODE = IGM.TestCode
						Left Join InvOrgGroup Invgrp WITH (NOLOCK) on IGM.Groupid = invgrp.Attgroupid and invgrp.OrgID=@orgID
						Where 1 = 1 and isnull(stg.METROLAB_PROFILECODE,'') <> '' and invgrp.attgroupid is null and IGM.Type ='PKG'
			
			
			Update T Set T.OrgGroupID=S.OrgGroupID from Stage_MHL_T_03_Package_Master T WITH (NOLOCK)
			         inner join InvGroupMaster I WITH (NOLOCK) ON T.METROLAB_PROFILECODE = I.TestCode 
			         inner join InvOrgGroup S WITH (NOLOCK) ON I.GroupID = S.AttGroupID and S.OrgID =@orgID
     		         where 1= 1 and I.Type='PKG'
			
		         
/* Insert PKG - Tcodes,EdosCode and AbbCode Into CodeMaster and CodeMapper */ 

	 Declare @orgid int=296
	    Declare @max Bigint
					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT METROLAB_PROFILECODE AS CodeName,'PKG',5,PACKAGE_NAME AS CodeDesc 
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.METROLAB_PROFILECODE = CM.Codename and CM.Codeschemeid = 5 and Cm.CodeType = 'PKG'
					
					Where isnull(Stg.METROLAB_PROFILECODE,'') <> ''
					and CM.Codemasterid is null
					
 
 				--	INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					--SELECT  DOSCODE AS CodeName,'PKG',2,PACKAGE_NAME AS CodeDesc 
					--FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					--Left join Codemaster CM WITH (NOLOCK) on Stg.DOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'PKG'
					--and Stg.PACKAGE_NAME =CM.CodeDesc 
					--Where isnull(Stg.DOSCODE,'') <> ''
					--and CM.Codemasterid is null
					
					--INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					--SELECT ABBREVATION AS CodeName,'PKG',3,PACKAGE_NAME AS CodeDesc 
					--FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					--Left join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'PKG'
					--and Stg.PACKAGE_NAME =CM.CodeDesc 
					--Where isnull(Stg.ABBREVATION,'') <> ''
					--and CM.Codemasterid is null
					
	
					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'PKG',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					inner join Codemaster CM WITH (NOLOCK) on Stg.METROLAB_PROFILECODE = CM.Codename and CM.Codeschemeid = 5 and Cm.CodeType = 'PKG' 
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'PKG'
					Where isnull(Stg.METROLAB_PROFILECODE,'') <> ''
					and CMAP.Codemasterid is null
					
 
 				--	INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					--SELECT 'PKG',Stg.orggroupid,CM.Codemasterid
					--FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					--inner join Codemaster CM WITH (NOLOCK) on Stg. DOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'PKG' and Stg.PACKAGE_NAME =CM.CodeDesc 
					--Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'PKG'
					--Where isnull(Stg.DOSCODE,'') <> ''
					--and CMAP.Codemasterid is null
					
					--INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					--SELECT 'PKG',Stg.orggroupid,CM.Codemasterid
					--FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					--Inner join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'PKG' and Stg.PACKAGE_NAME =CM.CodeDesc 
					--Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'PKG'
			  --  	Where isnull(Stg.ABBREVATION,'') <> ''
					--and CMAP.Codemasterid is null


/* Update OrgGroupID and InvestigationID Into Stage_MHL_T_05_PACKAGE_TESTS */ 
Declare @orgid int=296
	    Declare @max Bigint
				Update T
					set OrgGroupID=IOG.OrgGroupId
					From Stage_MHL_T_05_PACKAGE_TESTS T WITH (NOLOCK)
					Inner Join CodeMaster CM WITH (NOLOCK) ON CM.CodeName = T.PACKAGE_CODE and CM.CodeSchemeID =1
					Inner JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='PKG'
					AND CM.CodeType = CP.IdentifyingType  
					Inner Join InvOrgGroup IOG WITH (NOLOCK) on CP.IdentifyingID =IOG.OrgGroupID where IOG.OrgID =@orgID 

				Update M
					set InvestigationID=T.OrgGroupID
					From Stage_MHL_T_05_PACKAGE_TESTS M WITH (NOLOCK)
					Inner JOIN CodeMaster CM WITH (NOLOCK) ON CM.CodeName = M.TEST_CODE and CM.CodeSchemeID =1
					Inner JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
					AND CM.CodeType = CP.IdentifyingType 
					Inner JOIN InvOrgGroup T WITH (NOLOCK) ON T.OrgGroupID = CP.IdentifyingID 
					WHERE ISNULL(M.Type,'INV')='GRP' and T.OrgID =@orgID 

				Update M
					set InvestigationID=IOM.InvestigationID
					From Stage_MHL_T_05_PACKAGE_TESTS M WITH (NOLOCK)
					Inner JOIN CodeMaster CM WITH (NOLOCK) ON CM.CodeName = M.TEST_CODE and CM.CodeSchemeID = 1
					Inner JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='Investigations'
					AND CM.CodeType = CP.IdentifyingType 
					Inner JOIN InvestigationOrgMapping IOM WITH (NOLOCK) ON IOM.InvestigationID = CP.IdentifyingID and IOM.OrgID =@orgID
					WHERE ISNULL(M.Type,'INV')='INV' 


/* Insert PKG Contents */
	
	  Insert into InvPackageMapping(PackageID,ID,SequenceNo,Type,active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'INV','A' as Active
			From Stage_MHL_T_05_PACKAGE_TESTS stg WITH (NOLOCK)
			Left join InvPackageMapping grp WITH (NOLOCK) on stg.orggroupid = grp.PackageID 
			and stg.investigationid = grp.ID and grp.Type = 'INV'
			WHERE ISNULL(stg.Type,'INV')='INV' AND ISNULL(stg.investigationid,'')<>''
			and grp.PackageID is null
	
	  
		 Insert into InvPackageMapping(PackageID,ID,SequenceNo,Type,active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'GRP','A' as Active
			From Stage_MHL_T_05_PACKAGE_TESTS stg WITH (NOLOCK)
			Left join InvPackageMapping grp WITH (NOLOCK) on stg.orggroupid = grp.PackageID 
			and stg.investigationid = grp.ID  and grp.Type = 'GRP'
			WHERE ISNULL(stg.Type,'INV')='GRP' AND ISNULL(stg.investigationid,'')<>''
			and grp.PackageID is null	
			

/* InvestigationID,OrgGroupId Updation In Source MHL Table */
Declare @orgid int=296
	    Declare @max Bigint
UPDATE SO SET SO.InvestigationID = DS.InvestigationID 
       FROM Stage2_MHL_T_01_TESTMASTER SO WITH (NOLOCK)
         INNER JOIN [Stage_MHL_T_01_TESTMASTER] DS WITH (NOLOCK) ON SO.TCODE=DS.TCODE
       
UPDATE SO SET SO.OrgGroupID = DS.OrgGroupID 
       FROM Stage2_MHL_T_02_GROUP_MASTER SO WITH (NOLOCK)
         INNER JOIN [Stage_MHL_T_02_GROUP_MASTER] DS WITH (NOLOCK) ON SO.METRO_COMBINE_CODE=DS.METRO_COMBINE_CODE
         
UPDATE SO SET SO.InvestigationID = DS.InvestigationID,SO.OrgGroupID = DS.OrgGroupID 
       FROM Stage2_MHL_T_04_GROUP_TESTS SO WITH (NOLOCK)
       INNER JOIN [Stage_MHL_T_04_GROUP_TESTS] DS WITH (NOLOCK) ON SO.GROUP_CODE=DS.GROUP_CODE
       AND SO.TEST_CODE=DS.TEST_CODE
   
UPDATE SO SET SO.OrgGroupID = DS.OrgGroupID 
       FROM Stage2_MHL_T_03_Package_Master SO WITH (NOLOCK)
         INNER JOIN [Stage_MHL_T_03_Package_Master] DS WITH (NOLOCK) ON SO.METROLAB_PROFILECODE=DS.METROLAB_PROFILECODE

UPDATE SO SET SO.InvestigationID = DS.InvestigationID,SO.OrgGroupID = DS.OrgGroupID 
       FROM Stage2_MHL_T_05_PACKAGE_TESTS SO WITH (NOLOCK)
         INNER JOIN [Stage_MHL_T_05_PACKAGE_TESTS] DS WITH (NOLOCK) ON SO.PACKAGE_CODE=DS.PACKAGE_CODE and 
         SO.TEST_CODE=DS.TEST_CODE
		
		  
	Commit tran
End Try
Begin catch
	Rollback tran
	Select Error_Line(),Error_number(),Error_Message()
End Catch


