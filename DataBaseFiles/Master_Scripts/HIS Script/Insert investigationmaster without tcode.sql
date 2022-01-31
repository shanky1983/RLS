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


		-------------------------------------------------------------------------


		Select * into Stage_MHL_T_02_GROUP_MASTER from [Excel_GRP_193] 
		Select * into Stage_MHL_T_01_TESTMASTER from excel_gunam_193 
		Select * into Stage_MHL_T_04_GROUP_TESTS from [Excel_GRP_Content_193]  
		Select * into Stage_MHL_T_03_Package_Master from [Excel_CARD_193] 
		Select * into Stage_MHL_T_05_PACKAGE_TESTS from [Excel_Card_Content_193] 
		
		Update Stage_MHL_T_02_GROUP_MASTER set Orggroupid = Null
		Update Stage_MHL_T_01_TESTMASTER   set InvestigationID = null
		Update Stage_MHL_T_04_GROUP_TESTS SET InvestigationID=NULL,OrgGroupID=NULL
		Update Stage_MHL_T_03_Package_Master SET OrgGroupID=NULL
		Update Stage_MHL_T_05_PACKAGE_TESTS SET InvestigationID=NULL,OrgGroupID=NULL
		Update Stage_MHL_T_01_TESTMASTER SET PROCESSING_LOCATION='Vadodara' where SubCategory='INH'



		-------------------------------------------------------------------


		Declare @orgid int=193
	    Declare @max Bigint
		Select @max=0	
		Select  @Max = isnull(MAX(InvestigationID),0) From InvestigationMaster
	
		Insert into InvestigationMaster(InvestigationName,InvestigationID)
		
				Select stg.InvestigationName,
				ROW_NUMBER() over (Order By stg.InvestigationName) + @max as InvestigationID 
				from Stage_MHL_T_01_TESTMASTER	stg WITH (NOLOCK)
				Left join InvestigationMaster inv WITH (NOLOCK) on  inv.InvestigationName=stg.InvestigationName
				where  Inv.InvestigationName is null
				
				
	
				
	    Update M set InvestigationID=T.InvestigationId
				 From Stage_MHL_T_01_TESTMASTER M WITH (NOLOCK)
				 Inner Join InvestigationMaster T WITH (NOLOCK) on  T.InvestigationName=M.InvestigationName
				 
--------------------------------------------------------------------

Declare @orgid int=193
	    Declare @max Bigint
			Insert into DeptMaster (DeptName,Code) 
			Select distinct DeptName,'' as SHORTNAME from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)
			       where DeptName NOT IN (SELECT ISNULL(DeptName,'') FROM DeptMaster WITH (NOLOCK))
			       AND ISNULL(DeptName,'')<>''
			
			Declare @orgid int=193
	    Declare @max Bigint
			Select @max = 0
			Select @max = isnull(MAX(DeptID),0) From InvDeptMaster WITH (NOLOCK) where OrgID=@orgID
			
          --Insert into InvDeptMaster(DeptName,SequenceNo,Display,OrgID,DeptID)		
					Select DeptName,'' as SEQUENCE_REPORT,'Y',@OrgID,ROW_NUMBER() over (order by DeptName) + @max as DeptId  from (	   
				           Select DISTINCT DeptName from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK) 
				           where DeptName NOT IN ( Select DeptName FROM InvDeptMaster WITH (NOLOCK) where OrgID=@orgID  )
				           AND ISNULL(DeptName,'')<>''
				           ) t
		
			--select * from InvDeptMaster where orgid=193
			Update T set DeptCode=M.DeptCode
			From InvDeptMaster T WITH (NOLOCK)
			Inner Join DeptMaster M WITH (NOLOCK) on M.DeptName=T.DeptName where T.OrgID=193
					

/* Header(Section) */
		Declare @orgid int=193
	    Declare @max Bigint				
		Select @max = 0
		Select @max = isnull(MAX(HeaderID),0) From InvestigationHeader WITH (NOLOCK)
      
       -- Insert into InvestigationHeader(HeaderName,HeaderID)
                   Select  Distinct SECTION,ROW_NUMBER() over (order by SECTION) + @max as HeaderID
                    from (
							Select distinct SECTION_NAME as SECTION from Stage_MHL_T_01_TESTMASTER WITH (NOLOCK)  Where testType = 'INV' and  isnull(Section_name,'')<> ''
						 ) t where t.SECTION NOT IN ( select HeaderName from InvestigationHeader WITH (NOLOCK) )
					



-----------------


Declare @orgid int=193
	    Declare @max Bigint 	
	Update T set InvestigationID=IM.InvestigationID
			 From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			 Inner Join InvestigationMaster IM WITH (NOLOCK) on T.TCODE=IM.TestCode
			 Where t.testType = 'INV'

	Update T set T.DeptID=IDM.DeptID
		    From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			INNER JOIN DeptMaster DM WITH (NOLOCK) ON DM.DeptName=T.Deptname
			Inner Join InvDeptMaster IDM WITH (NOLOCK) on IDM.DeptCode =DM.DeptCode
			
			where IDM.OrgID=193


			Update T set HeaderId=IH.HeaderID
			From Stage_MHL_T_01_TESTMASTER T WITH (NOLOCK)
			Inner Join InvestigationHeader IH WITH (NOLOCK) on T.SECTION_NAME=IH.HeaderName
			Where t.testType = 'INV'


/* Insert InvestigationOrgMapping  */
	Declare @orgid int=193
	    Declare @max Bigint
	Insert into InvestigationOrgMapping(orgID,DisplayText,InvestigationID,DeptID)
			Select	Distinct @orgID,
					         stg.Investigationname,
					         stg.InvestigationID,
					         stg.DeptID
							 
				From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
				Left join InvestigationOrgmapping Invmap WITH (NOLOCK) on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =193 
				Where stg.InvestigationID is not null and invmap.investigationid is null 

/* Insert InvestigationOrgAttributes */
Declare @orgid int=193
	    Declare @max Bigint
	 Insert into InvestigationOrgAttributes(OrgID,InvestigationID)
		
		Select Distinct @OrgID,
		                stg.InvestigationID
				       
			   From Stage_MHL_T_01_TESTMASTER stg WITH (NOLOCK)
			   Left join InvestigationOrgAttributes Invmap WITH (NOLOCK) on stg.Investigationid  = invmap.Investigationid and Invmap.OrgID =@OrgID
			   Where stg.InvestigationID is not null and invmap.investigationid is null  
			  
												