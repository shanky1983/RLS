
Create Procedure PgetTestUpdation
(
@Toorgid int
)
As
Begin

Declare @max Bigint
DECLARE @pOrgAddressID INT 
Declare @ToCodeSchemeID Int
Select  @ToCodeSchemeID=CodeTypeid from CodingSchemeOrgMapping where OrgID=@ToOrgid and IsPrimary='Y'

/* InvestigationMaster */
		
	    
		Select @max=0	
		Select  @Max = isnull(MAX(InvestigationID),0) From InvestigationMaster
	
		Insert into InvestigationMaster(InvestigationName,Display,InvestigationID,TestCode,IsParameter)
				Select TestName,CASE When stg.Orderable='Y' then 'Y' ELSE 'N' END Display,
				ROW_NUMBER() over (Order By TestName) + @max as InvestigationID,TCODE ,stg.IsParameter
				from Stage_MHL_T_01_TESTMASTER	stg WITH (NOLOCK)
				Inner Join Codemaster CM On CM.codeName=Stg.Tcode
				Inner Join CodeMapper CP On CM.codeMasterid=CP.Codemasterid and cm.codetype=CP.IdentifyingType
				Inner Join InvestigationorgMapping IOm On Iom.investigationid=CP.IdentifyingId
				Left join InvestigationMaster inv WITH (NOLOCK) on IOM.Investigationid=INv.Investigationid
				Where TestType = 'INV'
				and Inv.Investigationid is null and ISNULL(stg.TCODE ,'')<>''
				And Iom.Orgid=@ToOrgid
				And CP.IdentifyingType='Investigations'
				And Cm.CodeSchemeID=@ToCodeSchemeID
	
				
	    Update M set InvestigationID=T.InvestigationId
				 From Stage_MHL_T_01_TESTMASTER M WITH (NOLOCK)
				 Inner Join InvestigationMaster T WITH (NOLOCK) on T.TestCode=M.TCODE
				 Where M.TestType = 'INV'
		  			
		Update M set InvestigationID=T.InvestigationId
				 From Stage_MHL_T_04_GROUP_TESTS M WITH (NOLOCK)
				 Inner Join InvestigationMaster T WITH (NOLOCK) on T.TestCode=M.Test_Code
				 Where M.TYPE = 'INV'			
				
/* DeptMaster */			
		
			Insert into DeptMaster (DeptName,Code) 
			Select distinct DeptName,'' as SHORTNAME from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)
			       where DeptName NOT IN (SELECT ISNULL(DeptName,'') FROM DeptMaster WITH (NOLOCK))
			       AND ISNULL(DeptName,'')<>''
			
			
			Select @max = 0
			Select @max = isnull(MAX(DeptID),0) From InvDeptMaster WITH (NOLOCK) where OrgID=@ToOrgid
			
            Insert into InvDeptMaster(DeptName,SequenceNo,Display,OrgID,DeptID)		
					Select DeptName,'' as SEQUENCE_REPORT,'Y',@ToOrgid,ROW_NUMBER() over (order by DeptName) + @max as DeptId  from (	   
				           Select DISTINCT DeptName from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) 
				           where DeptName NOT IN ( Select DeptName FROM InvDeptMaster WITH (NOLOCK) where OrgID=@ToOrgid  )
				           AND ISNULL(DeptName,'')<>''
				           ) t
		
			
			Update T set DeptCode=M.DeptCode
			From InvDeptMaster T WITH (NOLOCK)
			Inner Join DeptMaster M WITH (NOLOCK) on M.DeptName=T.DeptName where T.OrgID=@ToOrgid
			
		
							
/* Header(Section) */
						
		Select @max = 0
		Select @max = isnull(MAX(HeaderID),0) From InvestigationHeader WITH (NOLOCK)
      
        Insert into InvestigationHeader(HeaderName,HeaderID)
                   Select  Distinct SECTION,ROW_NUMBER() over (order by SECTION) + @max as HeaderID
                    from (
							Select distinct SECTION_NAME as SECTION from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)  
							Where testType = 'INV' and  isnull(Section_name,'')<> ''
						 ) t where t.SECTION NOT IN ( select HeaderName from InvestigationHeader WITH (NOLOCK) )
					
							      
/* UOM */

		Select @max = 0
		Select @Max = isnull(MAX(UOMID),0) From UOM WITH (NOLOCK)
			
		Insert into UOM(UOMCode,UOMDescription,UOMID)
			        Select Units,Units,ROW_NUMBER() over (order by Units)+ @max as UOMID 
						   From ( Select Distinct Units
										 from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)
								 )t
					       where Units not in ( select UOMDescription from UOM WITH (NOLOCK) ) and isnull(Units,'') <> ''


/* Sample Container */
	
	    select @max = 0
		Select @max = isnull(MAX(SampleContainerID),0) From InvestigationSampleContainer WITH (NOLOCK) where OrgID=@ToOrgid
		
		Insert into InvestigationSampleContainer(ContainerName,orgId,Description,Active,SampleContainerID)
						
					Select Distinct NAME,@ToOrgid,Substring(NAME,1,6) as SHORTNAME,'Y',ROW_NUMBER() over (order by NAME) + @max as SampleContainerID
						   from 
						      ( Select distinct Container as Name from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) Where isnull(Container,'') <> '' ) t 
						        Where
						        NAME Not In ( Select Distinct ContainerName from InvestigationSampleContainer WITH (NOLOCK)
												where OrgID=@ToOrgid ) 					
				
				

/* Sample Master */
							       
	 	select @max = 0
		Select  @Max = isnull(MAX(SampleCode),0) From InvSampleMaster WITH (NOLOCK) where OrgID=@ToOrgid

    		Insert into InvSampleMaster(SampleDesc,OrgID,Active,SampleCode)
				        
				        Select Distinct SAMPLE_DESCRIPTION,@ToOrgid,'Y',ROW_NUMBER() over (order by SAMPLE_DESCRIPTION) + @max as SampleCode 
				              from  
				              ( Select distinct Sample_Type as SAMPLE_DESCRIPTION 
				                       from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) Where isnull(Sample_Type,'') <> ''
				              ) t
						      Where SAMPLE_DESCRIPTION Not In ( Select Distinct SampleDesc from InvSampleMaster WITH (NOLOCK) 
													                  where OrgID=@ToOrgid )
							        
 		
/* Investigation Method */

        select @max = 0
		Select @max = isnull(MAX(MethodID),0) From InvestigationMethod WITH (NOLOCK) where OrgID=@ToOrgid 

		Insert into InvestigationMethod(MethodName,OrgID,CreatedAt,CreatedBy,MethodID)
				    Select Distinct NAME,@ToOrgid,GETDATE(),3366,ROW_NUMBER() over (order by NAME) + @max as MethodID 
				           from 
				           ( select distinct Method as NAME from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) where ISNULL(Method,'') <> '' 
				           ) t
						   Where NAME Not In ( Select Distinct MethodName from InvestigationMethod WITH (NOLOCK) where OrgID=@ToOrgid  )
						  

/* Protocol Group */

		Select @max=0	
		Select  @Max = isnull(MAX(MetaDataID),0) From MetaData

		Set IDENTITY_INSERT MetaData ON

		INSERT INTO MetaData(MetaDataID,Domain,Code,DisplayText,LangCode)

		SELECT ROW_NUMBER() over (Order By DisplayText) + @max as MetaDataID, Domain,ROW_NUMBER() over (Order By DisplayText) + @max as Code,
		DisplayText,LangCode 
		FROM 
		(
			SELECT DISTINCT  'ProtocalGroup_Based' as Domain,ProtocolGroup as DisplayText,'en-GB' as LangCode 
			       FROM Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			
			UNION
			
			SELECT DISTINCT  'ProtocalGroup_Based' as Domain,ProtocolGroup as DisplayText,'en-GB' as LangCode 
			       FROM Stage_MHL_T_02_GROUP_MASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			
			UNION 
			
			SELECT DISTINCT  'ProtocalGroup_Based' as Domain,ProtocolGroup as DisplayText,'en-GB' as LangCode 
			       FROM Stage_MHL_T_03_Package_Master WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			
			EXCEPT 
			SELECT Domain,DisplayText,LangCode FROM MetaData where Domain ='ProtocalGroup_Based'
		)t

		Set IDENTITY_INSERT MetaData OFF
		
	
		INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)

		SELECT DISTINCT  MD.MetaDataID ,@ToOrgid as OrgID,'en-GB' as LangCode,PR.ProtocolGroup as DisplayText
			   FROM 
			       (
			        SELECT ProtocolGroup FROM Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			        UNION
			        SELECT ProtocolGroup FROM Stage_MHL_T_02_GROUP_MASTER WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			        UNION
			        SELECT ProtocolGroup FROM Stage_MHL_T_03_Package_Master WITH (NOLOCK) where ISNULL(ProtocolGroup,'')<>''
			       )PR 
					 INNER JOIN MetaData MD ON PR.ProtocolGroup=MD.DisplayText  
					 WHERE MD.Domain ='ProtocalGroup_Based' AND MD.MetaDataID NOT IN
					(SELECT MetaDataID  FROM MetaDataOrgMapping where OrgID =@ToOrgid)

		   

/* InvestigationID,DeptID,SampleCode,MethodID,SampleContainerID,HeaderId,UomId updation Into Stage_MHL_T_01_TESTMASTER  */
		 	
	Update T set InvestigationID=IM.InvestigationID
			 From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			 Inner Join InvestigationMaster IM WITH (NOLOCK) on T.TCODE=IM.TestCode
			 Where t.testType = 'INV'

	Update T set T.DeptID=IDM.DeptID
		    From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			INNER JOIN DeptMaster DM WITH (NOLOCK) ON DM.DeptName=T.DeptNAme
			Inner Join InvDeptMaster IDM WITH (NOLOCK) on IDM.DeptCode =DM.DeptCode
			Where t.testType = 'INV'
			and IDM.OrgID=@ToOrgid
		
	Update T set SampleCode=ISM.SampleCode
		   From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
		   Inner Join InvSampleMaster ISM WITH (NOLOCK) on T.Sample_Type=ISM.SampleDesc
		   Where t.testType = 'INV' and ISM.OrgID=@ToOrgid
		
	Update T set MethodID=IM.MethodID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join InvestigationMethod IM WITH (NOLOCK) on T.Method=IM.MethodName
			Where t.testType = 'INV'
			and IM.OrgID=@ToOrgid
	
					
	Update T set SampleContainerID=ISC.SampleContainerID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join InvestigationSampleContainer ISC WITH (NOLOCK) on LTRIM(T.Container)=ISC.ContainerName
			Where t.testType = 'INV' and ISC.OrgID=@ToOrgid
		 
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
			Where t.testType = 'INV' AND OrganisationID=@ToOrgid 
			
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
			 	
	INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
	Select Stg.Tcode,'Investigations',@ToCodeSchemeID,Testname
	From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	left join Codemaster CM WITH (NOLOCK) on stg.TCode = Cm.Codename and Cm.Codeschemeid =@ToCodeSchemeID 
	Where stg.TestType = 'INV'
	and isnull(Stg.TCode,'') <> ''
	and CM.Codemasterid is null

/*
	INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
	Select Stg.EDOSCode,'Investigations',2,Testname
	From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	left join Codemaster CM WITH (NOLOCK) on stg.EDOSCode = Cm.Codename and Cm.Codeschemeid = 2 and stg.TestName = CM.CodeDesc
	Where stg.TestType = 'INV'
	and isnull(Stg.EDOSCode,'') <> ''
	and CM.Codemasterid is null
	
	INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
	Select Stg.Test_abbrevation,'Investigations',3,Testname
	From 
	Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	left join Codemaster CM WITH (NOLOCK) on stg.Test_abbrevation = Cm.Codename and Cm.Codeschemeid = 3  and stg.TestName = CM.CodeDesc
	Where stg.TestType = 'INV'
	and isnull(Stg.Test_abbrevation,'') <> ''
	and CM.Codemasterid is null
*/
	INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
	Select 'investigations',Stg.Investigationid,CM.Codemasterid
	From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	Inner join Codemaster CM WITH (NOLOCK) on stg.TCode = Cm.Codename and Cm.Codeschemeid =@ToCodeSchemeID  
	 LEFT JOIN CodeMapper CM2 WITH (NOLOCK) ON CM2.CodeMasterID=CM.CodemasterID AND CM2.IdentifyingID=Stg.Investigationid 
	 AND CM2.IdentifyingType='Investigations'
	Where stg.TestType = 'INV'  AND CM2.CodeMasterID IS NULL
	and isnull(Stg.TCode,'') <> ''

/*	
	INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
	Select 'investigations',Stg.Investigationid,CM.Codemasterid
	From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	inner join Codemaster CM WITH (NOLOCK) on stg.EDOSCode = Cm.Codename and Cm.Codeschemeid = 2 and stg.TestName = CM.CodeDesc
	 LEFT JOIN CodeMapper CM2 WITH (NOLOCK) ON CM2.CodeMasterID=CM.CodemasterID AND CM2.IdentifyingID=Stg.Investigationid 
	 AND CM2.IdentifyingType='Investigations'
	Where stg.TestType = 'INV'  AND CM2.CodeMasterID IS NULL
	and isnull(Stg.EDOSCode,'') <> ''
	
	INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
	Select 'investigations',Stg.Investigationid,CM.Codemasterid
	From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
	inner join Codemaster CM WITH (NOLOCK) on stg.Test_abbrevation = Cm.Codename and Cm.Codeschemeid = 3 and stg.TestName = CM.CodeDesc
	 LEFT JOIN CodeMapper CM2 WITH (NOLOCK) ON CM2.CodeMasterID=CM.CodemasterID AND CM2.IdentifyingID=Stg.Investigationid 
	 AND CM2.IdentifyingType='Investigations'
	Where stg.TestType = 'INV' AND CM2.CodeMasterID IS NULL
	and isnull(Stg.Test_abbrevation,'') <> ''

*/
/* Processing Location Updation Into Stage_MHL_T_01_TESTMASTER */
			
	    Update T
	    set Processing_AddressID=OA.AddressID
	    From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
	    Inner Join OrganizationAddress OA WITH (NOLOCK) on OA.Location=T.PROCESSING_LOCATION 
	    WHERE ISNULL(T.SubCategory,'')<>'OUT'
	    and T.testType = 'INV' and OA.OrganizationID=@ToOrgid 
	   
	   	Update T
	    set Processing_AddressID=LRA.AddressID
	    From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
	    Inner Join LabReferenceORg OA WITH (NOLOCK) on OA.RefOrgName=T.PROCESSING_LOCATION and OA.OrgID =@ToOrgid 
	    INNER JOIN labreforgaddress LRA WITH (NOLOCK) ON LRA.LabRefOrgId=OA.LabRefOrgId
	    WHERE ISNULL(T.SubCategory,'')='OUT'		
		and T.testType = 'INV'

	    
/* InvestigationOrgMapping  */

   /* Update */
  
   
    Update Invmap Set
					Invmap.DisplayText          =   DISPLAY_NAME,
					Invmap.DeptID               =   stg.DeptID,
					Invmap.SampleCode           =   stg.SampleCode,
					Invmap.MethodID             =   stg.MethodID,
					Invmap.SampleContainerID    =   stg.SampleContainerID,
					Invmap.UOMID                =   stg.UOMID,
					Invmap.SubCategory          =   CASE stg.subCategory 
						                                 WHEN 'INH' THEN 'INH'
						                                 WHEN 'InHouse' THEN 'INH'
						                                 WHEN 'OUT' THEN 'OUT'
						                                 WHEN 'OutSourced' THEN 'OUT' END , 
					Invmap.ProcessingAddressID  =   stg.Processing_AddressID, 
					Invmap.AutoApproveLoginID   =   stg.AutoAuthorizationId,
					Invmap.HeaderID             =   stg.HeaderID,
					Invmap.InvestigationCode    =   stg.TCODE,
					Invmap.Display              =   Case when stg.Orderable IS NULL then 'Y' Else Orderable End ,
					Invmap.Interpretation       =   stg.Interpretation, 
					Invmap.IsActive             =   ISNULL(stg.IsActive,''),
					Invmap.IsNonReportable      =   stg.IsNonReportable,
					Invmap.PrintSeparately      =   stg.PrintSeparately,
					Invmap.IsParameter          =   stg.IsParameter,
					Invmap.UOMCode              =   stg.units,
					Invmap.Gender               =   stg.TEST_GENDER,
					Invmap.IsSTAT               =   CASE stg.IS_STAT WHEN '1' THEN 1 ELSE 0 END,
					Invmap.IsDiscountable       =   1,
					Invmap.ReferenceRange       =   stg.REFERENCE_RANGE,
					Invmap.SequenceNo           =   SEQUENCE_No,
					Invmap.PanicRange           =   stg.PANIC_RANGE
				From Stage_MHL_T_01_TESTMASTER stg
				Inner join InvestigationOrgmapping Invmap on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =@ToOrgid 
				Where stg.TestType = 'INV' and stg.InvestigationID is not null
				
				

    /* Insert */
    
    /*
	
	Insert into InvestigationOrgMapping(orgID,DisplayText,InvestigationID,DeptID,SampleCode,MethodID,SampleContainerID,UOMID,SubCategory,
											ProcessingAddressID,AutoApproveLoginID,HeaderID,InvestigationCode,Display,Interpretation,
											IsActive,IsNonReportable,PrintSeparately,IsParameter,UOMCode,Gender,IsSTAT,
											IsDiscountable,ReferenceRange,SequenceNo,PanicRange,ProtocalGroupID	)
			Select	Distinct @ToOrgid,
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
							 stg.IsParameter,
							 stg.units,
							 stg.TEST_GENDER,
							 CASE stg.IS_STAT WHEN '1' THEN 1 ELSE 0 END,
							 1,
							 stg.REFERENCE_RANGE,
							 SEQUENCE_No,
							 stg.PANIC_RANGE,ProtocolGroupID
				From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
				Left join InvestigationOrgmapping Invmap WITH (NOLOCK) on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =@ToOrgid 
				Where stg.TestType = 'INV' and stg.InvestigationID is not null and invmap.investigationid is null and 
				ISNULL(stg.TCODE,'')<>''

*/
/* InvestigationOrgAttributes */

   /* Update */
   
  
     Update Invmap Set
			          Invmap.ResultValueType    =    Case when stg.Values_Type='N' OR stg.Values_Type='Numeric' Then 'NU' 
													      When stg.Values_Type='A' OR stg.Values_Type='Alpha Numeric' Then 'AN'
													           Else Null End,
					  Invmap.DecimalPlaces      =    stg.Decimal_Places,
					  Invmap.IsCAP              =    stg.IS_CAP,
					  Invmap.Classification     =    stg.Classification,
					  Invmap.IsRepeatable       =    stg.[REPEATABLE],
					  Invmap.IsSMS              =    stg.IS_SMS,
					  Invmap.IsSTAT             =    stg.IS_STATISTICAL,
					  Invmap.IsInterfaced       =    stg.IS_MACHINE_INTERFACED,
					  Invmap.IsNABL             =    stg.IS_NABL,
					  Invmap.HasHistory         =    stg.IS_TEST_HISTORY,
					  Invmap.CutOffTimeValue    =    stg.CutOffTimeValue,
					  Invmap.CutOffTimeType     =    stg.CutOffTimeType,
					  Invmap.IsNonReportable    =    stg.IsNonReportable, 
					  Invmap.IsDiscountable     =    'Y'
					  From Stage_MHL_T_01_TESTMASTER stg
					       INNER join InvestigationOrgAttributes Invmap on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =@ToOrgid
					       Where stg.TestType = 'INV' and stg.InvestigationID is not null 



   /* Insert */
/*
	 Insert into InvestigationOrgAttributes(OrgID,InvestigationID,ResultValueType,DecimalPlaces,IsCAP,Classification,IsRepeatable,IsSMS,IsSTAT,
						                       IsInterfaced,IsNABL,HasHistory,CutOffTimeValue,CutOffTimeType,IsNonReportable,IsDiscountable)
		
		Select Distinct @ToOrgid,
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
						stg.IsNonReportable, 
						'Y'
			   From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
			   Left join InvestigationOrgAttributes Invmap WITH (NOLOCK) on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =@ToOrgid
			   Where stg.TestType = 'INV' and stg.InvestigationID is not null and invmap.investigationid is null and 
			   ISNULL(stg.TCODE,'')<>''
														
*/														
/* Insert Input and Output Format */

	INSERT INTO PatternMapping (PatternID,InvestigationID)
	Select Distinct PatternID,InvestigationID
		From
			( 
			select distinct IP.PatternID,T.InvestigationID from Stage_MHL_T_01_TESTMASTER  T  WITH (NOLOCK)
            INNER JOIN InvestigationPattern IP  WITH (NOLOCK) ON IP.DisplayText=T.INPUT_FORMAT  and IP.OrgID=@ToOrgid
            Where t.TestType = 'INV' and isnull(t.input_format,'') <> ''
			Except
			Select PatternID,InvestigationID From PatternMapping  WITH (NOLOCK)	--where Orgid = @Orgid
			)t


  INSERT INTO InvReportMapping (TemplateID,InvestigationID)
	Select Distinct TemplateID,InvestigationID
		From
			( 
			select IP.TemplateID,T.InvestigationID from Stage_MHL_T_01_TESTMASTER  T   WITH (NOLOCK)
            INNER JOIN InvReportMaster IP  WITH (NOLOCK) ON IP.TemplateName=T.OUTPUT_FORMAT  and IP.OrgID=@ToOrgid
            Where t.TestType = 'INV' and isnull(t.OUTPUT_FORMAT,'') <> ''
			Except
			Select TemplateID,InvestigationID From InvReportMapping  WITH (NOLOCK)	--where OrgID=@OrgID
			)t
			
			
 /* Insert OutSource Test */	
 
 
 SELECT @pOrgAddressID=MAX(AddressID) FROM OrganizationAddress WITH (NOLOCK) where OrganizationID=@ToOrgid and ISNULL(IsDefault,'')='Y' 

	INSERT INTO InvestigationLocationMapping (InvestigationID,OrgID,LocationID,ProcessingOrgID,ProcessingAddressID,Type)
	
	SELECT InvestigationID,OrgID,LocationID,ProcessingOrgID,ProcessingAddressID,Type 
		FROM
		(
			SELECT DISTINCT TM.InvestigationID,@ToOrgid AS OrgID,@pOrgAddressID AS LocationID, LRO.LabRefOrgID AS ProcessingOrgID, 
					LRA.AddressID AS ProcessingAddressID,12 AS Type 
					from Stage_MHL_T_01_TESTMASTER TM  WITH (NOLOCK)   
					INNER JOIN LabReferenceORg LRO  WITH (NOLOCK) ON LRO.RefOrgName=TM.PROCESSING_LOCATION AND LRO.OrgID =@ToOrgid
					INNER JOIN labreforgaddress LRA WITH (NOLOCK) ON LRA.LabRefOrgId=LRO.LabRefOrgId
					LEFT JOIN InvestigationLocationMapping ILM WITH (NOLOCK) ON ILM.InvestigationID=TM.InvestigationID 
					AND ILM.ProcessingOrgID= LRO.LabRefOrgID AND ILM.ProcessingAddressID=LRA.AddressID
					AND ILM.OrgID=@ToOrgid AND ILM.LocationID= @pOrgAddressID
					WHERE ILM.InvestigationID IS NULL AND ISNULL(TM.SubCategory,'')='OUT'
						  AND TM.TestType='INV'
		 ) T 



/* GRP - InvGroupMaster */

			Select @max = 0
			Select  @Max = isnull(MAX(GroupID),0) From InvGroupMaster WITH (NOLOCK)

			Insert into InvGroupMaster(GroupName,Type,GroupID,TestCode)
			
			Select stg.GROUPNAME,'GRP',ROW_NUMBER() over (order by stg.GroupName) + @max as GroupID,stg.METRO_COMBINE_CODE
					From Stage_MHL_T_02_GROUP_MASTER Stg WITH (NOLOCK)
					left join Invgroupmaster grp WITH (NOLOCK) on stg.METRO_COMBINE_CODE = grp.TestCode  AND grp.Type='GRP'
					Where  1= 1 and isnull(stg.METRO_COMBINE_CODE,'') <> '' and grp.Groupid is null
			
/* GRP - InvOrgGroup */
  
  
   /* Update */

	  Update GM Set GM.OrgGroupID = IOG.OrgGroupID
                from Stage_MHL_T_02_GROUP_MASTER GM
                     Inner Join CodeMaster CM ON CM.CodeName =GM.METRO_COMBINE_CODE 
                     Inner Join CodeMapper CP ON CM.CodeMasterID =CP.CodeMasterID 
                     and CM.CodeType = CP.IdentifyingType 
                     Inner JOIN InvOrgGroup IOG ON IOG.OrgGroupID = CP.IdentifyingID 
                where isnull(GM.METRO_COMBINE_CODE,'') <> '' and  CM.CodeSchemeID =1 and CP.IdentifyingType ='GRP' and IOG.OrgID =@ToOrgid
		
	  
	  Update Invgrp Set
			   			Invgrp.DisplayText         =   stg.DISPLAY_NAME,
						Invgrp.IsNonOrderable      =   CASE WHEN ISNULL(stg.IS_ORDERABLE,'N')='N' THEN 'Y' ELSE 'N' END,
						Invgrp.Classification      =   stg.CLASSIFICATION,
    					Invgrp.TestCode            =   stg.METRO_COMBINE_CODE,
						Invgrp.ValidationText      =   stg.ValidationText,
						Invgrp.ValidationRule      =   stg.ValidationRule,
						Invgrp.IsDiscountable      =   stg.IsDiscountable,
						Invgrp.IsServicetaxable    =   stg.IsServicetaxable,
						Invgrp.Status              =   stg.Status,
						Invgrp.CutOffTimeValue     =   stg.CutOffTimeValue,
						Invgrp.CutOffTimeType      =   stg.CutOffTimeType,
						Invgrp.SubCategory         =   stg.SubCategory,
						Invgrp.HasHistory          =   stg.HasHistory,
						Invgrp.Remarks             =   stg.Remarks,
						Invgrp.PrintSeparately     =   stg.PrintSeparately,
						Invgrp.Gender              =   stg.Gender,
						Invgrp.groupinterpretation =   stg.groupinterpretation,
						Invgrp.Issummaryworklist   =   stg.Issummaryworklist,
						Invgrp.IsSpecialFormat     =   stg.IsSpecialFormat  
						From Stage_MHL_T_02_GROUP_MASTER stg
						Inner Join InvOrgGroup Invgrp on Invgrp.OrgGroupID =stg.OrgGroupID  
						Where invgrp.OrgID=@ToOrgid
	
		
   /* Insert */	
   
   /*
		Select  @max= 0 
		Select @Max = isnull(MAX(OrgGroupID),0) From InvOrgGroup WITH (NOLOCK)


		Insert into InvOrgGroup(AttGroupID,OrgID,DisplayText,IsNonOrderable,Classification,OrgGroupID,TestCode,ValidationText,
									ValidationRule,IsDiscountable,IsServicetaxable,Status,CutOffTimeValue,CutOffTimeType,
									SubCategory,HasHistory,Remarks,PrintSeparately,Gender,groupinterpretation,Issummaryworklist,
									IsSpecialFormat,SequenceNo,ProtocalGroupID  )
			
			select Distinct igm.Groupid,
							@ToOrgid,
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
							ROW_NUMBER() over (order by stg.DISPLAY_NAME) + @max as SequenceNo,ProtocolGroupID
					From Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					Inner join InvGroupMaster IGM WITH (NOLOCK) on stg.METRO_COMBINE_CODE = IGM.TestCode
					Left Join InvOrgGroup Invgrp WITH (NOLOCK) on IGM.Groupid = invgrp.Attgroupid and invgrp.OrgID=@ToOrgid
					Where 1 = 1 and isnull(stg.METRO_COMBINE_CODE,'') <> '' and invgrp.attgroupid is null
	
	*/		
			
			Update T Set T.OrgGroupID=S.OrgGroupID from Stage_MHL_T_02_GROUP_MASTER T WITH (NOLOCK)
			         Inner JOIN InvGroupMaster I WITH (NOLOCK) ON T.METRO_COMBINE_CODE = I.TestCode 
			         Inner JOIN InvOrgGroup S WITH (NOLOCK) ON S.AttGroupID = I.GroupID 
			         Where S.OrgID =@ToOrgid and I.Type ='GRP'
 	
		
/* Insert GRP - Tcodes,EdosCode and AbbCode Into CodeMaster and CodeMapper */
	 
					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT METRO_COMBINE_CODE AS CodeName,'GRP',@ToCodeSchemeID,GROUPNAME AS CodeDesc 
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.METRO_COMBINE_CODE = CM.Codename and CM.Codeschemeid =@ToCodeSchemeID and Cm.CodeType = 'GRP'
					Where isnull(Stg.METRO_COMBINE_CODE,'') <> ''
					and CM.Codemasterid is null
					
 /*
 					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT EDOSCODE AS CodeName,'GRP',2,GROUPNAME AS CodeDesc 
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.EDOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'GRP'
					AND Stg.GROUPNAME=CM.CodeDesc
					Where isnull(Stg.EDOSCODE,'') <> ''
					and CM.Codemasterid is null
					
					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT ABBREVATION AS CodeName,'GRP',3,GROUPNAME AS CodeDesc 
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'GRP'
					AND Stg.GROUPNAME=CM.CodeDesc
					Where isnull(Stg.ABBREVATION,'') <> ''
					and CM.Codemasterid is null
*/					
	
					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'GRP',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					inner join Codemaster CM WITH (NOLOCK) on Stg.METRO_COMBINE_CODE = CM.Codename and CM.Codeschemeid =@ToCodeSchemeID and Cm.CodeType = 'GRP' 
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'GRP'
			    	Where isnull(Stg.METRO_COMBINE_CODE,'') <> ''
					and CMAP.Codemasterid is null
					
 /*
 					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'GRP',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					inner join Codemaster CM WITH (NOLOCK) on Stg.EDOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'GRP' AND Stg.GROUPNAME=CM.CodeDesc
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'GRP'
					Where isnull(Stg.EDOSCODE,'') <> ''
					and CMAP.Codemasterid is null
					
					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'GRP',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_02_GROUP_MASTER stg WITH (NOLOCK)
					Inner join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'GRP' AND Stg.GROUPNAME=CM.CodeDesc
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'GRP'
					Where isnull(Stg.ABBREVATION,'') <> ''
					and CMAP.Codemasterid is null
*/
/* Update InvestigationId and OrgGroupId Into Stage_MHL_T_04_GROUP_TESTS */					
 
      Update T set OrgGroupID=IOG.OrgGroupId
               From Stage_MHL_T_04_GROUP_TESTS T WITH (NOLOCK)
               Inner Join CodeMaster CM WITH (NOLOCK) ON CM.CodeName = T.GROUP_CODE and CM.CodeSchemeID =@ToCodeSchemeID
               Inner Join CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
               AND CM.CodeType = CP.IdentifyingType 
               Inner Join InvOrgGroup IOG WITH (NOLOCK) on CP.IdentifyingID =IOG.OrgGroupID 
               where IOG.OrgID =@ToOrgid 

      Update M  set InvestigationID=T.OrgGroupID
				From Stage_MHL_T_04_GROUP_TESTS M WITH (NOLOCK)
				Inner Join CodeMaster CM WITH (NOLOCK) ON CM.CodeName = M.TEST_CODE and CM.CodeSchemeID =@ToCodeSchemeID
                Inner Join CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
                AND CM.CodeType = CP.IdentifyingType 
				Inner Join InvOrgGroup T WITH (NOLOCK) on CP.IdentifyingID = T.OrgGroupID 
				WHERE ISNULL(Type,'INV')='GRP' and T.OrgID =@ToOrgid 


/* Delete already Exists Group Contents */

	  Delete from InvGroupMapMaster where GroupID IN
				  (		
				   Select DISTINCT IOG.OrgGroupID  
				          from Stage_MHL_T_04_GROUP_TESTS GT
						  Inner JOIN InvOrgGroup IOG ON GT.OrgGroupID = IOG.OrgGroupID  where IOG.OrgID = @ToOrgid
				  )
	

	
/* Insert Group Contents */

      Insert into InvGroupMapMaster(GroupID,InvestigationID,SequenceNo,Parent,Active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'N','Y' as Active
			From Stage_MHL_T_04_GROUP_TESTS stg WITH (NOLOCK)
			Left join InvGroupMapMaster grp WITH (NOLOCK) on stg.orggroupid = grp.GroupID 
			and stg.investigationid = grp.investigationid and grp.Parent = 'N' and grp.Active ='Y'
			WHERE ISNULL(stg.Type,'INV')='INV'
			and grp.GroupID is null
	
	
	  Insert into InvGroupMapMaster(GroupID,InvestigationID,SequenceNo,Parent,Active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'Y','Y' as Active
			From Stage_MHL_T_04_GROUP_TESTS stg WITH (NOLOCK)
			Left join InvGroupMapMaster grp WITH (NOLOCK) on stg.orggroupid = grp.GroupID 
			and stg.investigationid = grp.investigationid  and grp.Parent = 'Y' and grp.Active ='Y'
			WHERE ISNULL(stg.Type,'INV')='GRP'
			and grp.GroupID is null	
	
			
/*  PKG - InvGroupMaster */	
  
        Select @max = 0
		Select  @Max = isnull(MAX(GroupID),0) From InvGroupMaster WITH (NOLOCK)

		Insert into InvGroupMaster(GroupName,Type,GroupID,TestCode)
		       Select stg.PACKAGE_NAME,'PKG',ROW_NUMBER() over (order by stg.PACKAGE_NAME) + @max as GroupID,
		              stg.METROLAB_PROFILECODE
		              From Stage_MHL_T_03_Package_Master Stg WITH (NOLOCK)
		                   left join Invgroupmaster grp WITH (NOLOCK) on stg.METROLAB_PROFILECODE = grp.TestCode AND grp.Type='PKG'
		                   Where  1= 1 and isnull(stg.METROLAB_PROFILECODE,'') <> '' and grp.Groupid is null
	
		
/*  PKG - InvOrgGroup */	

    /* Update */   
  
   
       Update Invgrp Set
						Invgrp.DisplayText          =   stg.DISPLAY_NAME,
						Invgrp.IsNonOrderable       =   CASE WHEN ISNULL(stg.IS_ORDERABLE,'N')='N' THEN 'Y' ELSE 'N' END,
						Invgrp.Classification       =   stg.CLASSIFICATION,
						Invgrp.TestCode             =   stg.METROLAB_PROFILECODE, 
    					Invgrp.ValidationText       =   stg.ValidationText,
						Invgrp.ValidationRule		=   stg.ValidationRule,
						Invgrp.IsDiscountable		=   stg.IsDiscountable,
						Invgrp.IsServicetaxable		=   stg.IsServicetaxable,
						Invgrp.Status				=   stg.Status,
						Invgrp.CutOffTimeValue		=   stg.CutOffTimeValue,
						Invgrp.CutOffTimeType		=   stg.CutOffTimeType,
						Invgrp.SubCategory			=   stg.SubCategory,
						Invgrp.HasHistory			=   stg.HasHistory,
						Invgrp.Remarks				=   stg.Remarks,
						Invgrp.PrintSeparately		=   stg.PrintSeparately,
						Invgrp.Gender				=   stg.Gender,
						Invgrp.groupinterpretation  =   stg.groupinterpretation,
						Invgrp.Issummaryworklist    =   stg.Issummaryworklist,
						Invgrp.IsSpecialFormat      =   stg.IsSpecialFormat
						From Stage_MHL_T_03_Package_Master stg
						Inner join InvGroupMaster IGM on stg.METROLAB_PROFILECODE = IGM.TestCode
						Inner Join InvOrgGroup Invgrp on IGM.Groupid = invgrp.Attgroupid  
						Where invgrp.OrgID=@ToOrgid and isnull(stg.METROLAB_PROFILECODE,'') <> '' and IGM.Type ='PKG'

       /* Insert */

/*
	    Select  @max= 0 
	    Select @Max = isnull(MAX(OrgGroupID),0) From InvOrgGroup WITH (NOLOCK)
	
		Insert into InvOrgGroup(AttGroupID,OrgID,DisplayText,IsNonOrderable,Classification,OrgGroupID,TestCode,							 
								    	ValidationText,ValidationRule,IsDiscountable,IsServicetaxable,Status,
										CutOffTimeValue,CutOffTimeType,SubCategory,HasHistory,Remarks,PrintSeparately,
										Gender,groupinterpretation,Issummaryworklist,IsSpecialFormat,SequenceNo,ProtocalGroupID  	)
				select Distinct igm.Groupid,
				                @ToOrgid,
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
								ROW_NUMBER() over (order by stg.DISPLAY_NAME) + @max as SequenceNo ,ProtocolGroupID
						From Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
						Inner join InvGroupMaster IGM WITH (NOLOCK) on stg.METROLAB_PROFILECODE = IGM.TestCode
						Left Join InvOrgGroup Invgrp WITH (NOLOCK) on IGM.Groupid = invgrp.Attgroupid and invgrp.OrgID=@ToOrgid
						Where 1 = 1 and isnull(stg.METROLAB_PROFILECODE,'') <> '' and invgrp.attgroupid is null and IGM.Type ='PKG'
			

*/			
			Update T Set T.OrgGroupID=S.OrgGroupID from Stage_MHL_T_03_Package_Master T WITH (NOLOCK)
			         inner join InvGroupMaster I WITH (NOLOCK) ON T.METROLAB_PROFILECODE = I.TestCode 
			         inner join InvOrgGroup S WITH (NOLOCK) ON I.GroupID = S.AttGroupID and S.OrgID =@ToOrgid
     		         where 1= 1 and I.Type='PKG'
			
		         
/* Insert PKG - Tcodes,EdosCode and AbbCode Into CodeMaster and CodeMapper */ 

	 
					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT METROLAB_PROFILECODE AS CodeName,'PKG',@ToCodeSchemeID,PACKAGE_NAME AS CodeDesc 
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.METROLAB_PROFILECODE = CM.Codename and CM.Codeschemeid =@ToCodeSchemeID and Cm.CodeType = 'PKG'
					Where isnull(Stg.METROLAB_PROFILECODE,'') <> ''
					and CM.Codemasterid is null
					
 /*
 					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT  DOSCODE AS CodeName,'PKG',2,PACKAGE_NAME AS CodeDesc 
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.DOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'PKG'
					and Stg.PACKAGE_NAME =CM.CodeDesc 
					Where isnull(Stg.DOSCODE,'') <> ''
					and CM.Codemasterid is null
					
					INSERT INTO CodeMaster(CodeName,CodeType,CodeSchemeID,CodeDesc)
					SELECT ABBREVATION AS CodeName,'PKG',3,PACKAGE_NAME AS CodeDesc 
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					Left join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'PKG'
					and Stg.PACKAGE_NAME =CM.CodeDesc 
					Where isnull(Stg.ABBREVATION,'') <> ''
					and CM.Codemasterid is null
					
	*/
					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'PKG',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					inner join Codemaster CM WITH (NOLOCK) on Stg.METROLAB_PROFILECODE = CM.Codename and CM.Codeschemeid =@ToCodeSchemeID and Cm.CodeType = 'PKG' 
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'PKG'
					Where isnull(Stg.METROLAB_PROFILECODE,'') <> ''
					and CMAP.Codemasterid is null
					
 /*
 					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'PKG',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					inner join Codemaster CM WITH (NOLOCK) on Stg. DOSCODE = CM.Codename and CM.Codeschemeid = 2 and Cm.CodeType = 'PKG' and Stg.PACKAGE_NAME =CM.CodeDesc 
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'PKG'
					Where isnull(Stg.DOSCODE,'') <> ''
					and CMAP.Codemasterid is null
					
					INSERT INTO CodeMapper(IdentifyingType,IdentifyingID,CodeMasterID)
					SELECT 'PKG',Stg.orggroupid,CM.Codemasterid
					FROM Stage_MHL_T_03_Package_Master stg WITH (NOLOCK)
					Inner join Codemaster CM WITH (NOLOCK) on Stg.ABBREVATION = CM.Codename and CM.Codeschemeid = 3 and Cm.CodeType = 'PKG' and Stg.PACKAGE_NAME =CM.CodeDesc 
					Left  join Codemapper CMAP WITH (NOLOCK) on cm.Codemasterid = Cmap.Codemasterid and stg.orggroupid = CMap.identifyingid and CMAP.IdentifyingType = 'PKG'
			    	Where isnull(Stg.ABBREVATION,'') <> ''
					and CMAP.Codemasterid is null

*/
/* Update OrgGroupID and InvestigationID Into Stage_MHL_T_05_PACKAGE_TESTS */ 

				Update T
					set OrgGroupID=IOG.OrgGroupId
					From Stage_MHL_T_05_PACKAGE_TESTS T WITH (NOLOCK)
					Inner Join CodeMaster CM WITH (NOLOCK) ON CM.CodeName = T.PACKAGE_CODE and CM.CodeSchemeID =@ToCodeSchemeID
					Inner JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='PKG'
					AND CM.CodeType = CP.IdentifyingType  
					Inner Join InvOrgGroup IOG WITH (NOLOCK) on CP.IdentifyingID =IOG.OrgGroupID where IOG.OrgID =@ToOrgid 

				Update M
					set InvestigationID=T.OrgGroupID
					From Stage_MHL_T_05_PACKAGE_TESTS M WITH (NOLOCK)
					Inner JOIN CodeMaster CM WITH (NOLOCK) ON CM.CodeName = M.TEST_CODE and CM.CodeSchemeID =@ToCodeSchemeID
					Inner JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='GRP'
					AND CM.CodeType = CP.IdentifyingType 
					Inner JOIN InvOrgGroup T WITH (NOLOCK) ON T.OrgGroupID = CP.IdentifyingID 
					WHERE ISNULL(M.Type,'INV')='GRP' and T.OrgID =@ToOrgid 

				Update M
					set InvestigationID=IOM.InvestigationID
					From Stage_MHL_T_05_PACKAGE_TESTS M WITH (NOLOCK)
					Inner JOIN CodeMaster CM WITH (NOLOCK) ON CM.CodeName = M.TEST_CODE and CM.CodeSchemeID =@ToCodeSchemeID
					Inner JOIN CodeMapper CP WITH (NOLOCK) ON CM.CodeMasterID = CP.CodeMasterID and CP.IdentifyingType ='Investigations'
					AND CM.CodeType = CP.IdentifyingType 
					Inner JOIN InvestigationOrgMapping IOM WITH (NOLOCK) ON IOM.InvestigationID = CP.IdentifyingID and IOM.OrgID =@ToOrgid
					WHERE ISNULL(M.Type,'INV')='INV' 



/* Delete already Exists Package Contents */

	  Delete from InvPackageMapping where PackageID IN
				  (		
				   Select DISTINCT IOG.OrgGroupID  
				          from Stage_MHL_T_05_PACKAGE_TESTS GT
						  Inner JOIN InvOrgGroup IOG ON GT.OrgGroupID = IOG.OrgGroupID  where IOG.OrgID =@ToOrgid
				  )



/* Insert PKG Contents */
	
	  Insert into InvPackageMapping(PackageID,ID,SequenceNo,Type,active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'INV','A' as Active
			From Stage_MHL_T_05_PACKAGE_TESTS stg WITH (NOLOCK)
			Left join InvPackageMapping grp WITH (NOLOCK) on stg.orggroupid = grp.PackageID 
			and stg.investigationid = grp.ID and grp.Type = 'INV' and grp.active ='A'
			WHERE ISNULL(stg.Type,'INV')='INV' AND ISNULL(stg.investigationid,'')<>''
			and grp.PackageID is null
	
	  
	  Insert into InvPackageMapping(PackageID,ID,SequenceNo,Type,active)
		Select stg.OrgGroupID,stg.InvestigationID,stg.test_Sequence_No,'GRP','A' as Active
			From Stage_MHL_T_05_PACKAGE_TESTS stg WITH (NOLOCK)
			Left join InvPackageMapping grp WITH (NOLOCK) on stg.orggroupid = grp.PackageID 
			and stg.investigationid = grp.ID  and grp.Type = 'GRP' and grp.active ='A'
			WHERE ISNULL(stg.Type,'INV')='GRP' AND ISNULL(stg.investigationid,'')<>''
			and grp.PackageID is null	

End