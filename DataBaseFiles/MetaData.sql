
 IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Gender' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES('Gender','M','Male', 'en-GB') ,
		  ('Gender','F','Female', 'en-GB') 
 
  GO
   
   
  
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='MaritalStatus' and LangCode='en-GB')
	   INSERT INTO [dbo].[MetaData]
	   VALUES  ('MaritalStatus','S','Single', 'en-GB'),
				 ('MaritalStatus','M','Married', 'en-GB'),
				 ('MaritalStatus','D','Divorced', 'en-GB'),
				 ('MaritalStatus','W','Widow', 'en-GB') 
  GO 
                         
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='DateAttributes' and LangCode='en-GB')
   INSERT INTO [dbo].[MetaData]
	VALUES('DateAttributes','D','Day(s)', 'en-GB') ,
		 ('DateAttributes','M','Month(s)', 'en-GB'),
		 ('DateAttributes','Y','Year(s)', 'en-GB') ,
		 ('DateAttributes','W','Week(s)', 'en-GB') 
                         
   Go
   
    
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='CustomPeriodRange' and LangCode='en-GB')
	   INSERT INTO [dbo].[MetaData]
		 VALUES ('CustomPeriodRange','0','This Week', 'en-GB'),
				('CustomPeriodRange','1','This Month', 'en-GB'),
				('CustomPeriodRange','2','This Year', 'en-GB'),
				('CustomPeriodRange','3','CustomPeriod', 'en-GB'),
				('CustomPeriodRange','4','Today', 'en-GB') ,
				('CustomPeriodRange','5','Last Week', 'en-GB'),
				('CustomPeriodRange','6','Last Month', 'en-GB'),
				('CustomPeriodRange','7','Last Year', 'en-GB')  
	                        
    GO
    
    
                        
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='PatientSearchType' and LangCode='en-GB')
	   INSERT INTO [dbo].[MetaData]
		 VALUES  ('PatientSearchType','0','Any', 'en-GB') ,
				 ('PatientSearchType','1','Client', 'en-GB') ,
				 ('PatientSearchType','2','Insurance', 'en-GB') 
  GO                                             
                        
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='OtherSearchCriteria' and LangCode='en-GB')
	   INSERT INTO [dbo].[MetaData]
		 VALUES ('OtherSearchCriteria','OCCUPATION','Occupation', 'en-GB'),  
				('OtherSearchCriteria','MOBILE','Mobile', 'en-GB'),  
				('OtherSearchCriteria','LANDLINE','LandLine', 'en-GB') , 
				('OtherSearchCriteria','CITY','City', 'en-GB') 
                    
 GO                         
                         
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='SampleRejectedPeriod' and LangCode='en-GB')
	  INSERT INTO [dbo].[MetaData]
	  VALUES('SampleRejectedPeriod','0','Today', 'en-GB') ,              
		   ('SampleRejectedPeriod','1','This Week', 'en-GB') ,
		   ('SampleRejectedPeriod','2','This Month', 'en-GB') ,
		   ('SampleRejectedPeriod','3','This Year', 'en-GB')     
   
  GO                     
                 
     IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Priority' and LangCode='en-GB')
		 INSERT INTO [dbo].[MetaData]
		 VALUES    ('Priority','1','Normal', 'en-GB'),               
				   ('Priority','2','Emergency', 'en-GB'), 
				   ('Priority','3','VIP', 'en-GB')               

  GO
   
     IF NOT EXISTS (select Domain,LangCode from MetaData where domain='VisitType' and LangCode='en-GB')
		 INSERT INTO [dbo].[MetaData]
		 VALUES   ('VisitType','-1','Both', 'en-GB'),               
				  ('VisitType','0','OP', 'en-GB'), 
				  ('VisitType','1','IP', 'en-GB')         
   GO      
  
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='SampleStatus' and LangCode='en-GB')
		INSERT INTO [dbo].[MetaData]
		 VALUES  ('SampleStatus','SampleCollected','Sample Collected', 'en-GB'),               
				 ('SampleStatus','SampleReceived','Sample Received', 'en-GB') ,
				 ('SampleStatus','Pending','Pending', 'en-GB')                     

    GO      
          
     IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ConditionOnAdmission' and LangCode='en-GB')
		INSERT INTO [dbo].[MetaData]
		 VALUES ('ConditionOnAdmission','0','Normal', 'en-GB') ,
				('ConditionOnAdmission','1','Abnormal', 'en-GB'), 
				('ConditionOnAdmission','2','Unstable', 'en-GB'), 
				('ConditionOnAdmission','3','Unconscious', 'en-GB') ,
				('ConditionOnAdmission','4','Emergency', 'en-GB') 
				         
     GO    
                
    
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='InPatientActions' and LangCode='en-GB')
		INSERT INTO [dbo].[MetaData]
		 VALUES  ('InPatientActions','MAKE_BILL','Make Bill', 'en-GB'),               
				 ('InPatientActions','COLLECT_ADVANCE','Collect Advance', 'en-GB'), 
				 ('InPatientActions','SURGERY_BILL','Surgery Bill', 'en-GB'), 
				 ('InPatientActions','SURGERY_ADVANCE','Collect Surgery Advance', 'en-GB') 

     
   GO    
   
 
   
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='CopaymentLogic' and LangCode='en-GB')
	  INSERT INTO [dbo].[MetaData]
		 VALUES ('CopaymentLogic','0','Lesser of Billed And Pre-Auth', 'en-GB'),               
				('CopaymentLogic','1','Billed Amount', 'en-GB'), 
				('CopaymentLogic','2','Pre-Auth Amount', 'en-GB') 
	      
   GO    
   
   
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ConsultantType' and LangCode='en-GB')
	  INSERT INTO [dbo].[MetaData]
		 VALUES  ('ConsultantType','RP','Referring Physician', 'en-GB'),               
				 ('ConsultantType','VIS','Visiting consultant', 'en-GB'), 
				 ('ConsultantType','RMO','Residential Medical Officer', 'en-GB'), 
				 ('ConsultantType','RC','Regular Consultant', 'en-GB') ,
				 ('ConsultantType','OC','On-call', 'en-GB') 
					   
  
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ClientAttributeType' and LangCode='en-GB')
		  INSERT INTO [dbo].[MetaData]
		  VALUES   ('ClientAttributeType','1','AlphaNumeric', 'en-GB'),
					('ClientAttributeType','2','Numeric', 'en-GB'), 
					('ClientAttributeType','3','DateTime', 'en-GB') 
	               
    GO  
    
    --History Duration Not Captilized b'coz in ip case record shows the value of the selected Item ---      
    IF NOT EXISTS (select Domain,LangCode from MetaData where domain='HistoryDuration' and LangCode='en-GB')
		INSERT INTO [dbo].[MetaData]
				  VALUES   ('HistoryDuration','Second(s)','Second(s)' ,'en-GB'),
						   ('HistoryDuration', 'Minute(s)','Minute(s)','en-GB'),
						   ('HistoryDuration', 'Hour(s)','Hour(s)','en-GB'),
						   ('HistoryDuration','Day(s)','Day(s)' ,'en-GB'),
						   ('HistoryDuration', 'Week(s)','Week(s)','en-GB'),
						   ('HistoryDuration', 'Month(s)','Month(s)','en-GB'),
						   ('HistoryDuration', 'Year(s)','Year(s)','en-GB')
				      
   GO
 
   

    GO
   
    IF NOT EXISTS (select Domain,LangCode from MetaData where domain='PMHStrokeType' and LangCode='en-GB')
		INSERT INTO [dbo].[MetaData]
		VALUES ('PMHStrokeType','Partially Recovered','Partially Recovered' ,'en-GB'),
			   ('PMHStrokeType', 'Fully Recovered','Fully Recovered','en-GB'),
			   ('PMHStrokeType', 'Not Recovered','Not Recovered','en-GB')
     GO
           
     IF NOT EXISTS (select Domain,LangCode from MetaData where domain='BodyPartPosition' and LangCode='en-GB') 
        INSERT INTO [dbo].[MetaData]
        VALUES ('BodyPartPosition','Left','Left' ,'en-GB'),
               ('BodyPartPosition', 'Right','Right','en-GB'),
               ('BodyPartPosition', 'Both','Both','en-GB')
       GO
           
           
        IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Units' and LangCode='en-GB')      
          INSERT INTO [dbo].[MetaData]
          VALUES ('Units','mm','mm' ,'en-GB'),
                 ('Units', 'cm','cm','en-GB')
               
       GO
       IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ReflexPosition' and LangCode='en-GB')      
          INSERT INTO [dbo].[MetaData]
          VALUES ('ReflexPosition','Left','Left' ,'en-GB'),
               ('ReflexPosition', 'Right','Right','en-GB'),
               ('ReflexPosition', 'Both','Both','en-GB')
           GO
      
        
       IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ReflexStatus' and LangCode='en-GB')        
		  INSERT INTO [dbo].[MetaData]
          VALUES ('ReflexStatus','Normal','Normal' ,'en-GB'),
                 ('ReflexStatus', 'Absent','Absent','en-GB'),
                 ('ReflexStatus', 'Exaggerated','1','en-GB'),
                 ('ReflexStatus', 'Sluggish','2','en-GB')
           GO
        IF NOT EXISTS (select Domain,LangCode from MetaData where domain='MusclePower' and LangCode='en-GB')           
          INSERT INTO [dbo].[MetaData]
          VALUES ('MusclePower','Grade I','grade I' ,'en-GB'),
                 ('MusclePower', 'Grade II','grade II','en-GB'),
                 ('MusclePower', 'Grade III','grade III','en-GB'),
                 ('MusclePower', 'Grade IV','grade IV','en-GB'),
                 ('MusclePower', 'Grade V','grade V','en-GB')
                
           GO 
       IF NOT EXISTS (select Domain,LangCode from MetaData where domain='MuscleTone' and LangCode='en-GB')    
         INSERT INTO [dbo].[MetaData]
         VALUES ('MuscleTone','Normal','Normal' ,'en-GB'),
                 ('MuscleTone', 'Increased','Increased','en-GB'),
                 ('MuscleTone', 'Decreased','Decreased','en-GB')
                  
           GO 
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='MuscleWasting' and LangCode='en-GB')        
          INSERT INTO [dbo].[MetaData]
          VALUES  ('MuscleWasting','Present','Present' ,'en-GB'),
                 ('MuscleWasting', 'Absent','Absent','en-GB')
                    
                  
    GO 
   
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ReportFormat' and LangCode='en-GB')
	  INSERT INTO [dbo].[MetaData]
				VALUES ('ReportFormat','1','Detail' ,'en-GB'),
					   ('ReportFormat', '2','Summary','en-GB')
    GO
         
         
         
     IF NOT EXISTS (select Domain,LangCode from MetaData where domain='RoomMaster' and LangCode='en-GB')
	  INSERT INTO [dbo].[MetaData]
				VALUES ('RoomMaster','BUILDING','Building' ,'en-GB'),
					   ('RoomMaster', 'FLOOR','Floor','en-GB'),
					   ('RoomMaster','WARD','Ward' ,'en-GB'),
					   ('RoomMaster', 'ROOM_TYPE','RoomType','en-GB'),
					   ('RoomMaster','ROOMS','Rooms' ,'en-GB'),
					   ('RoomMaster', 'BED','Bed','en-GB')
					   
    GO
    
    
         
     IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Rates' and LangCode='en-GB')
	  INSERT INTO [dbo].[MetaData]
				VALUES 
				     ('Rates','INVESTIGATION_GROUP_FEE','Investigation Group Fee','en-GB'),
									  
					   ('Rates','INVESTIGATION_FEE','Investigation Fee','en-GB'),
					   ('Rates','PROCEDURE_FEE','Procedure Fee','en-GB'),
					   ('Rates','MEDICAL_INDENTS_RATES','Medical Indents Rates','en-GB'),
					   ('Rates','GENERAL_BILLING_ITEMS','General Billing Items','en-GB'),
					   ('Rates','SURGERY_PACKAGE','SurgeryPackage','en-GB'),
					   ('Rates','HEALTH_PACKAGE','Health Packages','en-GB'),
					   ('Rates','PHYSICIAN_FEE','Physician Fee','en-GB')
					   
					  
					   
    GO
    
   
    
    
      IF NOT EXISTS (select Domain,LangCode from MetaData where domain='DiscountType' and LangCode='en-GB')
	  INSERT INTO [dbo].[MetaData]
				VALUES 
					   ('DiscountType','PERCENTAGE','Percentage','en-GB'),
					   ('DiscountType','VALUE','Value','en-GB')
					  
					   
					   GO
IF NOT EXISTS (select Domain,LangCode from MetaData where domain='PatientType' and LangCode='en-GB')
   INSERT INTO [dbo].[MetaData]
	VALUES('PatientType','P','Patient', 'en-GB') ,
		 ('PatientType','S','Staff', 'en-GB'),
		 ('PatientType','SD','Staff-Dependent', 'en-GB') 
                         
   Go
   
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='PatientStatus' and LangCode='en-GB')
   INSERT INTO [dbo].[MetaData]
	VALUES('PatientStatus','NR','Normal', 'en-GB') ,
		 ('PatientStatus','VIP','VIP', 'en-GB') 
                         
   Go
   
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ScheduleType' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES('ScheduleType','1','Physician', 'en-GB') ,
		  ('ScheduleType','2','Invoice To Client', 'en-GB'),
		   ('ScheduleType','3','Investigation', 'en-GB')		   
 
  GO
 
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ClientStatus' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES('ClientStatus','A','Active', 'en-GB') ,
		  ('ClientStatus','T','Terminate', 'en-GB'),
		   ('ClientStatus','S','Suspend', 'en-GB')		   
 
  GO  
  
  
 IF NOT EXISTS (select Domain,LangCode from MetaData where domain='PatientStatusinCollection' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES('PatientStatusinCollection','1','Fasting', 'en-GB') ,
		  ('PatientStatusinCollection','2','Random', 'en-GB'),
		   ('PatientStatusinCollection','3','Post-Prandial', 'en-GB'),		
		   ('PatientStatusinCollection','4','Early Morning', 'en-GB')	
 GO

 
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ReferringType' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES ('ReferringType','0','---SELECT---', 'en-GB'),
				('ReferringType','1','Hospital', 'en-GB') ,
				('ReferringType','2','Clinic', 'en-GB'),
				('ReferringType','3','Lab', 'en-GB')		   
 
  GO   

  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='EpisodeVisitType' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES 
		('EpisodeVisitType','1','Screening','en-GB'),
		('EpisodeVisitType','2','Randomization','en-GB'),
		('EpisodeVisitType','3','Monitoring','en-GB'),
		('EpisodeVisitType','4','End of Study','en-GB')
	   
 
  GO   
    IF NOT EXISTS (select Domain,LangCode from MetaData where domain='CTStudyPhase' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES 
		('CTStudyPhase','1','Phase 1','en-GB'),
		('CTStudyPhase','2','Phase 2','en-GB'),
		('CTStudyPhase','3','Phase 3','en-GB'),
		('CTStudyPhase','4','Phase 4','en-GB')
	   
 
  GO   
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='SubjectAllocation' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES 
		('SubjectAllocation','1','Proportional','en-GB'),
		('SubjectAllocation','2','Variable','en-GB')
	 
 
  GO 
  
 IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ReferringOrgType' and LangCode='en-GB')
 INSERT INTO [dbo].[MetaData]
 VALUES ('ReferringOrgType','0','---SELECT---', 'en-GB'),
			('ReferringOrgType','INH','Inbound', 'en-GB') ,
			('ReferringOrgType','OUT','Outsource', 'en-GB'),
			('ReferringOrgType','BOTH','Both', 'en-GB')		   
GO

   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='SamplesUnits' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES
	  ('SamplesUnits','0','Select','en-GB'),
		('SamplesUnits','1','ml','en-GB'),
		('SamplesUnits','2','mg','en-GB')  
 
  GO 
 
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='ReferenceType' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES
	  ('ReferenceType','0','---Select---','en-GB'),
	  ('ReferenceType','BIL','Bill','en-GB'),
	  ('ReferenceType','INV','Invoice','en-GB'),  
	  ('ReferenceType','SC','ServiceCode','en-GB')  
 
  GO   
 
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='PrintPolicy' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('PrintPolicy','REPORT','Report','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('PrintPolicy','IND','Indent','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('PrintPolicy','KIT','Kit','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('PrintPolicy','PKG','Package','en-GB')
END

IF NOT EXISTS (select Domain,LangCode from MetaData where domain='TOD' and LangCode='en-GB')
BEGIN
	 INSERT INTO [dbo].[MetaData]
	 VALUES('TOD','Rev','Revenue', 'en-GB') ,
		  ('TOD','Vol','Volume', 'en-GB')
		  	   
 END 
 
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Rates' and LangCode='en-GB')
BEGIN
	 INSERT INTO [dbo].[MetaData]
	 VALUES('Rates','SOI_PROCEDURE','SOI Procedure Fee', 'en-GB')  
 END 
 
   IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Direction' and LangCode='en-GB')
 BEGIN
	 INSERT INTO [dbo].[MetaData]
	 VALUES
	  ('Direction','0','---Select---','en-GB'),
	  ('Direction','1','Uni Directional','en-GB'),
	  ('Direction','2','Bi Directional','en-GB')   
 END
  IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Processing Mode' and LangCode='en-GB')
 BEGIN
	 INSERT INTO [dbo].[MetaData]
	 VALUES
	  ('Processing Mode','0','---Select---','en-GB'),
	  ('Processing Mode','1','Random','en-GB'),
	  ('Processing Mode','2','Batch','en-GB')   
 END
GO

IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Study Source' and LangCode='en-GB')
BEGIN
	 INSERT INTO [dbo].[MetaData]
	 VALUES('Study Source','0','National', 'en-GB'),
		  ('Study Source','1','InterNational', 'en-GB')
		  	   
 END
GO

IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Reason Category' and LangCode='en-GB')
BEGIN
	INSERT INTO [dbo].[MetaData]
	VALUES
		('Reason Category','0','---Select---','en-GB'),
		('Reason Category','1','Invoice','en-GB'),
		('Reason Category','2','Sample','en-GB'),
		('Reason Category','3','Bill','en-GB'),
		('Reason Category','4','Investigation','en-GB')
		('Reason Category','6','CreditDebitSummary','en-GB')
END

GO
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='TestClassification' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TestClassification','ADVANCED','Advanced','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TestClassification','BASIC','Basic','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TestClassification','ROUTINE','Routine','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TestClassification','SPECIAL','Special','en-GB')
END
GO
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='RemarksType' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('RemarksType','0','---Select---','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('RemarksType','M','Medical','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('RemarksType','T','Technical','en-GB')
END
GO
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='CutOffTimeType' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('CutOffTimeType','H','Hour(s)','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('CutOffTimeType','D','Day(s)','en-GB')
END
GO
IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Department' and LangCode='en-GB')
 BEGIN
	 INSERT INTO [dbo].[MetaData]
	 VALUES
	  ('Department','CLT','CLIENT','en-GB'),
	  ('Department','PM','PROJECT MANAGER','en-GB'),
	  ('Department','PI','PRINCIPAL INVESTIGATOR','en-GB'),  
	  ('Department','CRC','CLINICAL RESEARCH COORDINATOR','en-GB')   
 END
GO 
IF NOT EXISTS (select Domain,LangCode from MetaData where domain='PaymentType' and LangCode='en-GB')
 BEGIN
	 INSERT INTO [dbo].[MetaData]
	 VALUES
	  ('PaymentType','Completed','Completed','en-GB'),
	  ('PaymentType','Pending','Pending','en-GB')
 END
GO
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='TestReferenceRangeType' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TestReferenceRangeType','0','---Select---','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TestReferenceRangeType','referencerange','Reference Range','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TestReferenceRangeType','panicrange','Panic Range','en-GB')
END
GO 

IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='FileType' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('FileType','Outsource_Docs','Outsource Doc','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('FileType','TRF_Upload','TRF Upload','en-GB')
END

 GO

IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='TypeDiscount' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TypeDiscount','DIS','Discount','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('TypeDiscount','PRE','Premium','en-GB')
END

 GO 
 
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='WriteOffType' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WriteOffType','Billing','Billing','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WriteOffType','Invoice','Invoice','en-GB')
END
GO 

IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='Rates' AND LangCode='en-GB' AND Code='SPECIALITY')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('Rates','SPECIALITY','Speciality','en-GB')
END
GO 

IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='WorkListType' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','Analyzer_Based','Analyzer Based','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','Dept_Based','Department Based','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','Investigation_Based','Investigation Based','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','Sample_Based','Sample Based','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','WorkListID_Based','WorkListID Based','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','Group_Based','Group Based','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','Date_Based','Date Based','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('WorkListType','Visit_Level','Visit Level','en-GB')
END
GO

IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='MRDVIEW' AND LangCode='en-GB')
BEGIN
	Insert Into MetaData(Domain,Code,DisplayText,LangCode)
    SELECT 'MRDVIEW', UPPER('Department'),'Department','en-GB'
    
    Insert Into MetaData(Domain,Code,DisplayText,LangCode)
    SELECT 'MRDVIEW', UPPER('Speciality'),'Speciality','en-GB'
    
    Insert Into MetaData(Domain,Code,DisplayText,LangCode)
    SELECT 'MRDVIEW', UPPER('Wards'),'Rooms/Wards','en-GB'
END
GO

IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='Config' AND LangCode='en-GB')
BEGIN
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('Config','HOS','HOSPITAL','en-GB')
	INSERT INTO MetaData (Domain,Code,DisplayText,LangCode) VALUES('Config','PRM','PHARMACY','en-GB')
END
GO

IF NOT EXISTS (select Domain,LangCode from MetaData where domain='BloodComponent' and LangCode='en-GB')

	  INSERT INTO [dbo].[MetaData]	VALUES ('BloodComponent','0','WholeBlood','en-GB'),
					                       ('BloodComponent','1','Plasma','en-GB'),
					                       ('BloodComponent','2','Platelet','en-GB'),
					                       ('BloodComponent','3','Plasma Factors','en-GB'),
					                       ('BloodComponent','4','Packed Red Cell','en-GB'),	
					                       ('BloodComponent','5','Leukocyte poor red cells','en-GB'),
					                       ('BloodComponent','6','Fresh Frozen Plasma (FFP)','en-GB'),
					                       ('BloodComponent','7','Cryoprecipitated anti hemophilic factor','en-GB'),
					                       ('BloodComponent','8','WBC','en-GB'),  
					                       ('BloodComponent','9','Plasma Protein Fraction','en-GB'),
					                       ('BloodComponent','10','Albumin','en-GB')
      GO
      
      IF NOT EXISTS (select Domain,LangCode from MetaData where domain='BloodGroup' and LangCode='en-GB')

	  INSERT INTO [dbo].[MetaData]	VALUES ('BloodGroup','1','A+','en-GB'),
					                       ('BloodGroup','2','A-','en-GB'),
					                       ('BloodGroup','3','B+','en-GB'),
					                       ('BloodGroup','4','B-','en-GB'),	
					                       ('BloodGroup','5','O+','en-GB'),
					                       ('BloodGroup','6','O-','en-GB'),
					                       ('BloodGroup','7','AB+','en-GB'),
					                       ('BloodGroup','8','AB-','en-GB')
      GO
      
     IF NOT EXISTS (select Domain,LangCode from MetaData where domain='CrossMatchingMethod' and LangCode='en-GB')

	 INSERT INTO [dbo].[MetaData]	VALUES ('CrossMatchingMethod','1','Routine','en-GB'),
					                       ('CrossMatchingMethod','2','Albumin','en-GB'),
					                       ('CrossMatchingMethod','3','Coombs','en-GB'),
					                       ('CrossMatchingMethod','4','Pooled','en-GB')
      GO
    IF NOT EXISTS (select Domain,LangCode from MetaData where domain='PackageStatus' and LangCode='en-GB')
        INSERT INTO [dbo].[MetaData]  VALUES  ('PackageStatus','A','Active', 'en-GB'),
                                              ('PackageStatus','D','In Active', 'en-GB')
      GO 
      
      
      IF NOT EXISTS (select Domain,LangCode from MetaData where domain='BloodComponentUnits' and LangCode='en-GB')

 INSERT INTO [dbo].[MetaData]	VALUES ('BloodComponentUnits','0','500ml','en-GB'),
				                       ('BloodComponentUnits','1','350ml','en-GB'),
				                       ('BloodComponentUnits','2','300ml','en-GB'),
				                       ('BloodComponentUnits','3','60ml','en-GB'),
				                       ('BloodComponentUnits','4','20ml','en-GB')
  GO
 IF NOT EXISTS (select Domain,LangCode from MetaData where domain='' and LangCode='en-GB')
 insert into Metadata(Domain,Code,DisplayText,LangCode)
select 'MRDStatus',0,'CheckedIN','en-GB'
union 
select 'MRDStatus',1,'CheckedOut','en-GB'
union
select 'MRDStatus',2,'Transfer','en-GB'
union
select 'MRDStatus',3,'All','en-GB'
union
select 'MRDStatus',4,'Received','en-GB'
      GO
      
IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='FileType' and DisplayText='UnKnown')
BEGIN  
insert into MetaData (Domain,Code,DisplayText,LangCode)
 select	'FileType1','UnKnown','UnKnown','en-GB'
END
GO
---------------------------------------------------Karkuzhli-----------------------------------
IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='Inv create/update' and DisplayText='Test')
BEGIN  
Insert into MetaData(Domain,Code,DisplayText,LangCode)values('Inv create/update','TestMaster','Test','en-GB')
END
GO
IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='Inv create/update' and DisplayText='Group')
BEGIN  
Insert into MetaData(Domain,Code,DisplayText,LangCode)values('Inv create/update','GroupMaster','Group','en-GB')
END
GO
IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='Inv create/update' and DisplayText='Group Content')
BEGIN  
Insert into MetaData(Domain,Code,DisplayText,LangCode)values('Inv create/update','GroupContentMaster','Group Content','en-GB')
END
GO
IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='Inv create/update' and DisplayText='Package')
BEGIN  
Insert into MetaData(Domain,Code,DisplayText,LangCode)values('Inv create/update','PackageMaster','Package','en-GB')
END
GO
IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='Inv create/update' and DisplayText='Package Content')
BEGIN  
Insert into MetaData(Domain,Code,DisplayText,LangCode)values('Inv create/update','Packagecontent','Package Content','en-GB')
END
GO
-------------------------------------------------End-------------------------------------------
-----------------------------------------------------Karkuzhli-----------------------------------
--IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='Manage Referral Policy' and DisplayText='Billed Amount')
--BEGIN  
--insert into MetaData(Domain,Code,DisplayText,LangCode)values('Manage Referral Policy',1,'Billed Amount','en-GB')
--END
--GO
--IF NOT EXISTS (SELECT 1 FROM MetaData WHERE Domain='Manage Referral Policy' and DisplayText='Net Amount')
--BEGIN  
--insert into MetaData(Domain,Code,DisplayText,LangCode)values('Manage Referral Policy',2,'Net Amount','en-GB')
--END
--GO
---------------------------------------------------End-------------------------------------------
-------------------------------------------------Deployablity Team---------------------------------------------
--Vendor SubType
declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)
Declare @SubTypeCode2 VARCHAR(20)
Declare @SubTypeCode3 VARCHAR(20)
Declare @SubTypeCode4 VARCHAR(20)
Declare @ParentID Bigint
Declare @MetaDataID1 Bigint
Declare @MetaDataID2 Bigint
Declare @MetaDataID3 Bigint
Declare @MetaDataID4 Bigint
select @Orgid=OrganizationID from Organization where OrgDisplayName = 'Metropolis Vidyavihar'
set @LangCode='en-GB'
set @Domain='Vendor Type'
set @Code='Vendor'
set @SubTypeCode1='Agreement'
set @SubTypeCode2='Rate Policy'	
set @SubTypeCode3='System Gap'		
set @SubTypeCode4='Tender'
Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF  EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
	 
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode2,@SubTypeCode2,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID2=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID2 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode2 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID2,@Orgid,@LangCode,@SubTypeCode2)
			END
		 END
	 
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode3,@SubTypeCode3,@LangCode,@ParentID)
		 END
		 
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID3=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID3 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode3 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID3,@Orgid,@LangCode,@SubTypeCode3)
			END
		 END
		
			 
		IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode4,@SubTypeCode4,@LangCode,@ParentID)
		 END
		 
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID4=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID4 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode4 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID4,@Orgid,@LangCode,@SubTypeCode4)
			END
		 END
END		  
GO
--Normal SubType
declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)
Declare @SubTypeCode2 VARCHAR(20)
Declare @SubTypeCode3 VARCHAR(20)
Declare @SubTypeCode4 VARCHAR(20)
Declare @ParentID Bigint
Declare @MetaDataID1 Bigint
Declare @MetaDataID2 Bigint
Declare @MetaDataID3 Bigint
Declare @MetaDataID4 Bigint
select @Orgid=OrganizationID from Organization where OrgDisplayName = 'Metropolis Vidyavihar'
set @LangCode='en-GB'
set @Domain='Vendor Type'
set @Code='Normal'
set @SubTypeCode1='Agreement'
set @SubTypeCode2='Rate Policy'	
set @SubTypeCode3='System Gap'		
set @SubTypeCode4='Tender'
Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF  EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
	 
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode2,@SubTypeCode2,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID2=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID2 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode2 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID2,@Orgid,@LangCode,@SubTypeCode2)
			END
		 END
	 
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode3,@SubTypeCode3,@LangCode,@ParentID)
		 END
		 
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID3=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID3 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode3 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID3,@Orgid,@LangCode,@SubTypeCode3)
			END
		 END
		
			 
		IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode4,@SubTypeCode4,@LangCode,@ParentID)
		 END
		 
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID4=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID4 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode4 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID4,@Orgid,@LangCode,@SubTypeCode4)
			END
		 END
END		  
GO
--Special SubType
declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)
Declare @SubTypeCode2 VARCHAR(20)
Declare @SubTypeCode3 VARCHAR(20)
Declare @SubTypeCode4 VARCHAR(20)
Declare @ParentID Bigint
Declare @MetaDataID1 Bigint
Declare @MetaDataID2 Bigint
Declare @MetaDataID3 Bigint
Declare @MetaDataID4 Bigint
select @Orgid=OrganizationID from Organization where OrgDisplayName = 'Metropolis Vidyavihar'
set @LangCode='en-GB'
set @Domain='Vendor Type'
set @Code='Special'
set @SubTypeCode1='Agreement'
set @SubTypeCode2='Rate Policy'	
set @SubTypeCode3='System Gap'		
set @SubTypeCode4='Tender'
Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF  EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
	 
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode2,@SubTypeCode2,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID2=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode2 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID2 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode2 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID2,@Orgid,@LangCode,@SubTypeCode2)
			END
		 END
	 
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode3,@SubTypeCode3,@LangCode,@ParentID)
		 END
		 
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID3=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode3 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID3 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode3 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID3,@Orgid,@LangCode,@SubTypeCode3)
			END
		 END
		
			 
		IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID)
		 BEGIN
		 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
		 VALUES (@Domain,@SubTypeCode4,@SubTypeCode4,@LangCode,@ParentID)
		 END
		 
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID)
		 BEGIN
			select @MetaDataID4=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode4 and ParentID=@ParentID
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID4 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode4 )
			BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID4,@Orgid,@LangCode,@SubTypeCode4)
			END
		 END
END		  
GO
----------------------------------------------------------------Bulkupload Masters--------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------------------------------------


if not exists(select* from metadata where Domain='Inv create/update' and code='RateMaster')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'Inv create/update','RateMaster','RateMaster','en-GB'



insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrganizationID,m.code,m.LangCode from metadata m,Organization o where Domain='Inv create/update' and code='RateMaster'


end

if not exists(select* from metadata where Domain='Inv create/update' and code='UserMaster')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'Inv create/update','UserMaster','UserMaster','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrganizationID,m.code,m.LangCode from metadata m,Organization o where Domain='Inv create/update' and code='UserMaster'
end

if not exists(select* from metadata where Domain='Inv create/update' and code='InvestigationMaster')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'Inv create/update','InvestigationMaster','InvestigationMaster','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrganizationID,m.code,m.LangCode from metadata m,Organization o where Domain='Inv create/update' and code='InvestigationMaster'
end

if not exists(select* from metadata where Domain='Inv create/update' and code='Group')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'Inv create/update','Group','Group','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrganizationID,m.code,m.LangCode from metadata m,Organization o where Domain='Inv create/update' and code='Group'
end

if not exists(select* from metadata where Domain='Inv create/update' and code='Package')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'Inv create/update','Package','Package','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrganizationID,m.code,m.LangCode from metadata m,Organization o where Domain='Inv create/update' and code='Package'
end


if not exists(select* from metadata where Domain='Inv create/update' and code='Group Content')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'Inv create/update','Group Content','Group Content','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrganizationID,m.code,m.LangCode from metadata m,Organization o where Domain='Inv create/update' and code='Group Content'
end

if not exists(select* from metadata where Domain='Inv create/update' and code='Package Content')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'Inv create/update','Package Content','Package Content','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrganizationID,m.code,m.LangCode from metadata m,Organization o where Domain='Inv create/update' and code='Package Content'
end


--service exclusivity
if not exists(select* from metadata where Domain='ClientMappingService' and code='INV')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'ClientMappingService','INV','Investigations','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrganizationID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='ClientMappingService' and code='INV'
end


if not exists(select* from metadata where Domain='ClientMappingService' and code='PKG')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'ClientMappingService','PKG','Health Packages','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrganizationID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='ClientMappingService' and code='PKG'
end

if not exists(select* from metadata where Domain='ClientMappingService' and code='GRP')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'ClientMappingService','GRP','Investigation Groups','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrganizationID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='ClientMappingService' and code='GRP'
end

if not exists(select* from metadata where Domain='ClientMappingService' and code='GEN')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'ClientMappingService','GEN','General Billing Items','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrganizationID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='ClientMappingService' and code='GEN'
end

if not exists(select* from metadata where Domain='ClientMappingService' and code='LAB')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'ClientMappingService','LAB','Lab Items','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrganizationID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='ClientMappingService' and code='LAB'
end

GO

CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT OrganizationID from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN
	IF EXISTS(SELECT OrganizationID FROM Organization WHERE OrganizationID=@MinValue) 
	BEGIN
	DECLARE @MetaDataID1 bigint
	DECLARE @MetaDataID2 bigint
	DECLARE @MetaDataID3 bigint
--Registration			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyType' and LangCode='en-GB' AND Code='Reg' and DisplayText='Registration')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyType','Reg','Registration','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyType' AND LangCode='en-GB' AND Code='Reg' and DisplayText='Registration'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Registration' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Registration')
		END
--Registration	
--Report			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyType' and LangCode='en-GB' AND Code='Report' and DisplayText='Report')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyType','Report','Report','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyType' AND LangCode='en-GB' AND Code='Report' and DisplayText='Report'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Report' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Report')
		END
--Report
--Advance Threshold			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyType' and LangCode='en-GB' AND Code='AT' and DisplayText='Advance Threshold')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyType','AT','Advance Threshold','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyType' AND LangCode='en-GB' AND Code='AT' and DisplayText='Advance Threshold'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Advance Threshold' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Advance Threshold')
		END
--Advance Threshold	
--Advance Client Bill			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyType' and LangCode='en-GB' AND Code='ACB' and DisplayText='Advance Client Bill')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyType','ACB','Advance Client Bill','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyType' AND LangCode='en-GB' AND Code='ACB' and DisplayText='Advance Client Bill'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Advance Client Bill' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Advance Client Bill')
		END
--Advance Client Bill	
--Advance Collection			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyType' and LangCode='en-GB' AND Code='AC' and DisplayText='Advance Collection')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyType','AC','Advance Collection','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyType' AND LangCode='en-GB' AND Code='AC' and DisplayText='Advance Collection'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Advance Collection' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Advance Collection')
		END
--Advance Collection	
--Advance Refund			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyType' and LangCode='en-GB' AND Code='AR' and DisplayText='Advance Refund')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyType','AR','Advance Refund','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyType' AND LangCode='en-GB' AND Code='AR' and DisplayText='Advance Refund'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Advance Refund' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Advance Refund')
		END
--Advance Refund	
--Acknowledgement/Receipt			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyType' and LangCode='en-GB' AND Code='ACK' and DisplayText='Acknowledgement/Receipt')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyType','ACK','Acknowledgement/Receipt','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyType' AND LangCode='en-GB' AND Code='ACK' and DisplayText='Acknowledgement/Receipt'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Acknowledgement/Receipt' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Acknowledgement/Receipt')
		END
--Acknowledgement/Receipt


--SMS			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyMode' and LangCode='en-GB' AND Code='SMS' and DisplayText='SMS')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyMode','SMS','SMS','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyMode' AND LangCode='en-GB' AND Code='SMS' and DisplayText='SMS'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='SMS' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','SMS')
		END
--SMS
--Email			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyMode' and LangCode='en-GB' AND Code='Mail' and DisplayText='Email')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyMode','Mail','Email','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyMode' AND LangCode='en-GB' AND Code='Mail' and DisplayText='Email'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Email' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Email')
		END
--Email
--Fax			
		IF NOT EXISTS (select * from MetaData where Domain='CMNotifyMode' and LangCode='en-GB' AND Code='Fax' and DisplayText='Fax')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('CMNotifyMode','Fax','Fax','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='CMNotifyMode' AND LangCode='en-GB' AND Code='Fax' and DisplayText='Fax'
		IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Fax' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Fax')
		END
--Fax
	
	
	END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID



if not exists(select * from metadata where Domain='DependentType' and code='AutoComplete')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DependentType','AutoComplete','AutoComplete','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrgID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='DependentType' and code='AutoComplete'
end


if not exists(select * from metadata where Domain='DependentType' and code='AutoApproval')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DependentType','AutoApproval','AutoApproval','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrgID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='DependentType' and code='AutoApproval'
end

if not exists(select * from metadata where Domain='DependentType' and code='AutoValidate')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DependentType','AutoValidate','AutoValidate','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrgID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='DependentType' and code='AutoValidate'
end

if not exists(select * from metadata where Domain='DependentType' and code='Formula')
begin
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DependentType','Formula','Formula','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)
select m.MetaDataID,o.OrgID,m.DisplayText,m.LangCode from metadata m,Organization o where Domain='DependentType' and code='Formula'
end
Go
-----------------------------------Bulk Upload for Physicians,Locations and DeviceIntegrationMap(Deloyability)--------------------------
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT Orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN
	IF EXISTS(SELECT Orgid FROM Organization WHERE Orgid=@MinValue) 
	BEGIN
	DECLARE @MetaDataID1 bigint
--Device Org Map			
		IF NOT EXISTS (select * from MetaData where Domain='Inv create/update' and LangCode='en-GB' AND Code='DeviceTestMap' and DisplayText='Device Org Map')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('Inv create/update','DeviceTestMap','Device Org Map','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='Inv create/update' AND LangCode='en-GB' AND Code='DeviceTestMap' and DisplayText='Device Org Map'
		IF NOT EXISTS (SELECT 1 FROM MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue AND LangCode='en-GB' AND DisplayText='Device Org Map' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Device Org Map')
		END
--Device Org Map	
--Locations
		IF NOT EXISTS (select * from MetaData where Domain='Inv create/update' and LangCode='en-GB' AND Code='LocationMaster' and DisplayText='Location Master')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('Inv create/update','LocationMaster','Location Master','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='Inv create/update' AND LangCode='en-GB' AND Code='LocationMaster' and DisplayText='Location Master'
		IF NOT EXISTS (SELECT 1 FROM MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue AND LangCode='en-GB' AND DisplayText='Location Master' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Location Master')
		END
--Locations
--Physicians
		IF NOT EXISTS (select * from MetaData where Domain='Inv create/update' and LangCode='en-GB' AND Code='PhysicianMaster' and DisplayText='Physician Master')
		BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
					VALUES ('Inv create/update','PhysicianMaster','Physician Master','en-GB',0)
		END		
		SELECT @MetaDataID1=MetaDataID FROM MetaData WHERE Domain='Inv create/update' AND LangCode='en-GB' AND Code='PhysicianMaster' and DisplayText='Physician Master'
		IF NOT EXISTS (SELECT 1 FROM MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@MinValue AND LangCode='en-GB' AND DisplayText='Physician Master' )
		BEGIN
			INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@MinValue,'en-GB','Physician Master')
		END
--Physicians
	END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID
GO
-----------------------------------Bulk Upload for Physicians,Locations and DeviceIntegrationMap--------------------------


-------------------------------------------Test Wise Analyzer Report (MIS REPORT)   (Jagatheesh)------------------------------------------
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='LoadReportType')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('LoadReportType',1,'Summary','en-GB',0),
('LoadReportType',2,'Detailed','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Summary' and Domain='LoadReportType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Summary')
set @metaid= (select metadataid from MetaData where DisplayText ='Detailed' and Domain='LoadReportType')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Detailed')
end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------------------------------------End--------------------------------------------------

-------------------------Added Metadata for Pending List (Jagatheesh)-----------------------------

---***************************** Update Script Run in One time **************************-------------------
-------------------------Only one time run the script-------------------------

IF EXISTS(SELECT * FROM metadata WHERE Domain='Pendinglist')
BEGIN
UPDATE metadata set  Domain='Pendinglist_Old' where Domain='Pendinglist'
END
-----------*****************-----------------------End Script-----------****************-------------------


GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Pendinglist')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Pendinglist','Retest','Recollect','en-GB',0),
('Pendinglist','Recheck','Rerun','en-GB',0),
('Pendinglist','SampleTransferred','Sample Transferred','en-GB',0),
('Pendinglist','SampleReceived','Sample Received','en-GB',0),
('Pendinglist','SampleCollected','Sample Collected','en-GB',0),
('Pendinglist','Pending','Pending','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Recollect' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Recollect')
set @metaid= (select metadataid from MetaData where DisplayText ='Rerun' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Rerun')
set @metaid= (select metadataid from MetaData where DisplayText ='Sample Transferred' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sample Transferred')
set @metaid= (select metadataid from MetaData where DisplayText ='Sample Received' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sample Received')
set @metaid= (select metadataid from MetaData where DisplayText ='Sample Collected' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Sample Collected')
set @metaid= (select metadataid from MetaData where DisplayText ='Pending' and Domain='Pendinglist')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Pending')

END
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO






--Water's Metada By Dhanaselvam --

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='WaterApprovalStatus')
BEGIN	
insert into MetaData (Domain,Code,DisplayText,LangCode)
values ('WaterApprovalStatus','Pending','Pending','en-GB'),
('WaterApprovalStatus','Approved','Approved','en-GB'),
('WaterApprovalStatus','Rejected','Rejected','en-GB'),
('WaterApprovalStatus','Expired','Expired','en-GB')
END


IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='WaterSampleStatus')
BEGIN	
insert into MetaData (Domain,Code,DisplayText,LangCode)
values('WaterSampleStatus','Unassigned','Unassigned','en-GB'),
('WaterSampleStatus','Received','Received','en-GB'),
('WaterSampleStatus','Canceled','Canceled','en-GB'),
('WaterSampleStatus','Assigned','Assigned','en-GB')
end
-----

------------------------------------------End------------------------------------

---------------**********Added by jagatheesh for Home collection *************-------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='PriorityStatusforHomeCollection')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('PriorityStatusforHomeCollection','1','Urgent','en-GB',0),
('PriorityStatusforHomeCollection','2','Fasting','en-GB',0)
END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Urgent' and Domain='PriorityStatusforHomeCollection')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Urgent')
set @metaid= (select metadataid from MetaData where DisplayText ='Fasting' and Domain='PriorityStatusforHomeCollection')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Fasting')
END
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-----------------------------------End---------------------------------
---------------***** URNTYPEOrgmapping added by jagatheesh *****---------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT URNTypeId FROM URNTypes)
BEGIN	
INSERT INTO URNTypes(URNType,URNTypeId)
VALUES('Govt ID Card No','1'),
('Driving Licence','2'),
('Pan Card','3'),
('Voter Id Card','4'),
('Passport No','5'),
('Employee','6'),
('KITAS','7'),
('Internal','8')
END

BEGIN
declare @urnid int

set @urnid= (select URNTypeId from URNTypes where URNType ='Govt ID Card No' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'1','Govt ID Card No','en-GB')
set @urnid= (select URNTypeId from URNTypes where URNType ='Driving Licence' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'2','Driving Licence','en-GB')
set @urnid= (select URNTypeId from URNTypes where URNType ='Pan Card' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'3','Pan Card','en-GB')
set @urnid= (select URNTypeId from URNTypes where URNType ='Voter Id Card' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'4','Voter Id Card','en-GB')
set @urnid= (select URNTypeId from URNTypes where URNType ='Passport No' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'5','Passport No','en-GB')
set @urnid= (select URNTypeId from URNTypes where URNType ='Employee' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'6','Employee','en-GB')
set @urnid= (select URNTypeId from URNTypes where URNType ='KITAS' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'7','KITAS','en-GB')
set @urnid= (select URNTypeId from URNTypes where URNType ='Internal' )
INSERT INTO URNOrgMapping(URNTypeId,OrgID,SeqNo,DisplayText,LangCode)
VALUES(@urnid,@Orgid,'1','Internal','en-GB')
END
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
-------------------***** End Added ************----------------------
---------------------------------------------*************** Karthik Added Audithistory Metadata script Start ***************-------------------------
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Patient Registration')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHPR', 'Patient Registration','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Sample Status')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHSS', 'Sample Status','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Investigation Status')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHIS', 'Investigation Status','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Auto Authorized')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHAA', 'Auto Authorized','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Quick Approval')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHQA', 'Quick Approval','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Outsource Sample')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHOS', 'Outsource Sample','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Patient is having Due')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHPHD', 'Patient is having Due','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Patient is cleared the due')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHPCD', 'Patient is cleared the due','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='BatchSheet Generated (BatchNo')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHBSG', 'BatchSheet Generated (BatchNo','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='AuditHistory' and DisplayText ='Patient Client Name Changed')
BEGIN	
insert into MetaData select 'AuditHistory', 'AHPCNC', 'Patient Client Name Changed','',0,NULL
END
-----------------------------------------------------------------------------------------------------------------------------------------------------
Declare @Orgid int
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 
declare @Metadataid bigint, @LanguageCode nvarchar(20)
WHILE @MinValue <= @MaxValue 
BEGIN
IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
		set @LanguageCode='en-GB'
		SELECT @Orgid =orgid FROM Organization WHERE orgid=@MinValue
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHPR'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Patient Registration')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHSS'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Sample Status')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHIS'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Investigation Status')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHAA'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Auto Authorized')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHQA'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Quick Approval')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHOS'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Outsource Sample')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHPHD'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Patient is having Due')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHPCD'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Patient is cleared the due')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHBSG'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'BatchSheet Generated (BatchNo')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='AuditHistory' and Code='AHPCNC'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Patient Client Name Changed')
	   End
   End
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
---------------------------------------------*************** Karthik Added Audithistory Metadata script End***************-------------------------------

-----------------***********Metadata added by vinothini for DeviceFormula*****----------

if not exists(select* from metadata where Domain='DeviceFormula' and code='Round([InvID],0)')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','Round([InvID],0)','Roundoff Decimal Zero','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Roundoff Decimal Zero'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='Round([InvID],1)')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','Round([InvID],1)','Roundoff Decimal One','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Roundoff Decimal One'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='Round([InvID],2)')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','Round([InvID],2)','Roundoff Decimal Two','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Roundoff Decimal Two'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='Round([InvID],3)')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','Round([InvID],3)','Roundoff Decimal Three','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Roundoff Decimal Three'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='[InvID]*1000')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','[InvID]*1000','Multiply by 1000','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Multiply by 1000'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='[InvID]*100')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','[InvID]*100','Multiply by 100','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Multiply by 100'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='[InvID]*10')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','[InvID]*10','Multiply by 10','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Multiply by 10'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='[InvID]/1000')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','[InvID]/1000','Divided by 1000','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Divided by 1000'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='[InvID]/100')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','[InvID]/100','Divided by 100','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Divided by 100'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='[InvID]/10')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','[InvID]/10','Divided by 10','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Divided by 10'
end

if not exists(select* from metadata where Domain='DeviceFormula' and code='Round([InvID]/100,3)')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'DeviceFormula','Round([InvID]/100,3)','Roundoff Decimal Three and Divided by 100','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='DeviceFormula' and code='Roundoff Decimal Three and Divided by 100'
end


if not exists(select* from metadata where Domain='InvoiceCycle' and code='0.5')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'InvoiceCycle','0.5','15 Days','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='InvoiceCycle' and code='0.5'
end


if not exists(select* from metadata where Domain='InvoiceCycle' and code='1.0')
begin

INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
SELECT 'InvoiceCycle','1.0','1 Month','en-GB'

insert into MetaDataOrgMapping(MetadataID,OrgID,DisplayText,LangCode)

select m.MetaDataID,o.OrgID,m.code,m.LangCode from metadata m,Organization o where Domain='InvoiceCycle' and code='1.0'
end
-----------------***********End**************-------------------------
---------------------------------------------*************** Karthik Added Yes/No Metadata script Start***************-------------------------------
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Yes/No' and DisplayText ='Yes')
BEGIN	
insert into MetaData select 'Yes/No', 'Y', 'Yes','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Yes/No' and DisplayText ='No')
BEGIN	
insert into MetaData select 'Yes/No', 'N', 'No','',0,NULL
END

Declare @Orgid int
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 
declare @Metadataid bigint, @LanguageCode nvarchar(20)
WHILE @MinValue <= @MaxValue 
BEGIN
IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
		set @LanguageCode='en-GB'
		SELECT @Orgid =orgid FROM Organization WHERE orgid=@MinValue
	   select @Metadataid=MetaDataID from Metadata where Domain='Yes/No' and Code='Y'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Yes')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='Yes/No' and Code='N'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'No')
	   End
   End
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

---------------------------------------------*************** Karthik Added Yes/No Metadata script End***************---------------------------------

/******************Added by Gowtham Raj ********************/
IF NOT EXISTS (select Domain,LangCode from MetaData where domain='DateAttributes' AND Code='UnKnown' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES(N'DateAttributes',N'UnKnown',N'UnKnown', N'en-GB',0,NULL) 
  GO
  DECLARE @Metadata INT
  DECLARE @OrgID INT
  SET @OrgID=137
  SELECT @Metadata=(SELECT metadataid from metadata where domain='DateAttributes' and displaytext='UnKnown'AND Code='UnKnown')
   IF NOT EXISTS (select * from MetaDataOrgMapping where displaytext='UnKnown' and metadataid=@Metadata and OrgID=@OrgID)
  INSERT INTO [dbo].[MetaDataOrgMapping]
	 VALUES(@Metadata,@OrgID,'en-GB','UnKnown') 





	 IF NOT EXISTS (select Domain,LangCode from MetaData where domain='Gender' AND Code='U' and LangCode='en-GB')
	 INSERT INTO [dbo].[MetaData]
	 VALUES('Gender','U','UnKnown', 'en-GB',0,NULL) 
  GO
  DECLARE @Metadata INT
  DECLARE @OrgID INT
  SET @OrgID=137
  SELECT @Metadata=(SELECT metadataid from metadata where domain='Gender' and displaytext='UnKnown'AND Code='U' )
   IF NOT EXISTS (select * from MetaDataOrgMapping where displaytext='UnKnown' and metadataid=@Metadata and OrgID=@OrgID)
  INSERT INTO [dbo].[MetaDataOrgMapping]
	 VALUES(@Metadata,@OrgID,'en-GB','UnKnown') 
/***********END**********************/
---------------------------------------------*************** Vijayalakshmi.M Added Metadata script End***************---------------------------------
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='Description')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'Des', 'Description','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='Billed Amt')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'BAMT', 'Billed Amt','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='FeeType')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'FT', 'FeeType','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='MRP Amt')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'MRP', 'MRP Amt','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='Ordered Services')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'OrdS', 'Ordered Services ','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='Status')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'Status', 'Status','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='Refund Amt')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'RAmt', 'Refund Amt','',0,NULL
END
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='BillWiseDeptWise' and DisplayText ='Deposit Amt')
BEGIN	
insert into MetaData select 'BillWiseDeptWise', 'DAmt', 'Deposit Amt','',0,NULL
END
Declare @Orgid int
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 
declare @Metadataid bigint, @LanguageCode nvarchar(20)
WHILE @MinValue <= @MaxValue 
BEGIN
IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
		set @LanguageCode='en-GB'
		SELECT @Orgid =orgid FROM Organization WHERE orgid=@MinValue
	   select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='Des'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Description')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='BAMT'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Billed Amt')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='FT'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'FeeType')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='MRP'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'MRP Amt')
	   End
	    select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='OrdS'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Ordered Services')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='Status'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Status')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='RAmt'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Refund Amt')
	   End
	   select @Metadataid=MetaDataID from Metadata where Domain='BillWiseDeptWise' and Code='DAmt'
	   if not exists(select 1 from MetadataOrgMapping where MetadataID=@Metadataid and orgid=@Orgid and LangCode=@LanguageCode)
	   Begin
			insert into metadataorgmapping (MetadataID,OrgID,LangCode,DisplayText) values(@Metadataid,@Orgid,@LanguageCode,'Deposit Amt')
	   End
	   
	   
   End
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

-----select * from metadata where domain ='BillWiseDeptWise'


-------------------------------------------ramya script for dispatch queue--------------------------------------------
GO
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @SConfigKeyID varchar(30)
declare @orgid bigint
declare @ConfigKeyId bigint
SELECT @ConfigKeyId=MAX(ConfigKeyID ) FROM ConfigKeyMaster
SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Dispatch')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Dispatch','TNOR','Total No. of Reports','en-GB',0),
('Dispatch','DR','Dispatch Reports','en-GB',0),
('Dispatch','PAD','Partial Dispatch','en-GB',0),
('Dispatch','PED','Pending Dispatch','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Total No. of Reports' and Domain='Dispatch')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Total No. of Reports')
set @metaid= (select metadataid from MetaData where DisplayText ='Dispatch Reports' and Domain='Dispatch')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Dispatch Reports')
set @metaid= (select metadataid from MetaData where DisplayText ='Partial Dispatch' and Domain='Dispatch')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Partial Dispatch')
set @metaid= (select metadataid from MetaData where DisplayText ='Pending Dispatch' and Domain='Dispatch')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Pending Dispatch')

end
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO

CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT OrgID from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID)
while(@MinValue<=@MaxValue)
begin
IF EXISTS(SELECT OrgID FROM Organization WHERE OrgID=@MinValue) 
	BEGIN
	DECLARE @MetaDataID1 bigint
	DECLARE @MetaDataID2 bigint
	
		 if exists(select 1 from MetaData where Domain='DespatchType' and LangCode='en-GB' and Code='Doctor' and DisplayText='Doctor/Clinic Delivery')
		 begin
		 
		 select @MetadataID1=metadataID from MetaData where Domain='DespatchType' and LangCode='en-GB' and Code='Doctor' and DisplayText='Doctor/Clinic Delivery'
		 
		 if not exists(select 1 from MetaDataOrgMapping where MetadataID=@MetadataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='Doctor/Clinic Delivery' )
		 begin
		 insert into MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) 
		 select m.MetaDataID,@MinValue,m.code,m.LangCode from metadata m where Domain='DespatchType'  and LangCode='en-GB' and DisplayText='Doctor/Clinic Delivery'
		 end
		 end
		 if exists(select 1 from MetaData where Domain='DespatchType' and LangCode='en-GB' and Code='Home' and DisplayText='HomeDelivery')
		 begin
		 
		 select @MetaDataID2=metadataID from MetaData where Domain='DespatchType' and LangCode='en-GB' and Code='Home' and DisplayText='HomeDelivery'
		 
		 if not exists(select 1 from MetaDataOrgMapping where MetadataID=@MetadataID1 and OrgID=@MinValue and LangCode='en-GB' and DisplayText='HomeDelivery')
		 begin
		 insert into MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values(@MetaDataID2,@MinValue,'en-GB','HomeDelivery')
		 end
		 end
		 
		 end
		
		SET @MinValue = @MinValue + 1 
		 end
		  drop table #TempOrgID

	go
-------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------*************** Karthik Added Manage Referral Policy Metadata script Start***************-------------------------------	
CREATE TABLE #TempOrgID ( OrgID int )
INSERT INTO #TempOrgID 
SELECT orgid from Organization 
DECLARE @MinValue int 
DECLARE @MaxValue int 
SET @MinValue=(SELECT MIN(OrgID) FROM #TempOrgID) 
SET @MaxValue=(SELECT MAX(OrgID) FROM #TempOrgID) 

WHILE @MinValue <= @MaxValue 
BEGIN

IF EXISTS(SELECT orgid FROM Organization WHERE orgid=@MinValue) 
	BEGIN
declare @orgid bigint

SELECT @orgid =orgid FROM Organization WHERE orgid=@MinValue

IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Manage Referral Policy')
BEGIN	
INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
VALUES('Manage Referral Policy',1,'Billed Amount','en-GB',0),
('Manage Referral Policy',2,'Net Amount','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Billed Amount' and Domain='Manage Referral Policy')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Billed Amount')
set @metaid= (select metadataid from MetaData where DisplayText ='Net Amount' and Domain='Manage Referral Policy')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Net Amount')

END
END
SET @MinValue = @MinValue + 1 
END
drop table #TempOrgID  
GO
	
---------------------------------------------*************** Karthik Added Manage Referral Policy Metadata script End***************---------------------------------


--------------------------------------------------Rajesh--------------------------------------------------


IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_EventType' AND CODE='Internal Audit' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_EventType' ,'IA' ,  'Internal Audit','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_EventType' AND CODE='Training Programes' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_EventType' ,'TP' ,  'Training Programes','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_EventType' AND CODE='Management Review Meeting' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_EventType' ,'MRM' ,  'Management Review Meeting','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_PlanStatus' AND CODE='Open' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_PlanStatus' ,'Open' ,  'Open','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_PlanStatus' AND CODE='Close' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_PlanStatus' ,'Close' ,  'Close','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_AuditType' AND CODE='Process' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_AuditType' ,'Process' ,  'Process','en-GB'  )
END

IF NOT EXISTS( SELECT * FROM MetaData WHERE DOMAIN='QMS_AuditType' AND CODE='Staff' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_AuditType' ,'Staff' ,  'Staff','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_AuditType' AND CODE='Equipment' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_AuditType' ,'Equipment' ,  'Equipment','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_Catagory' AND CODE='Recommendation' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_Catagory' ,'Recommendation' ,  'Recommendation','en-GB'  )
END

IF NOT EXISTS( SELECT * FROM MetaData WHERE DOMAIN='QMS_Catagory' AND CODE='Non Conformity' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_Catagory' ,'Non Conformity' ,  'Non Conformity','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_ActionVerified' AND CODE='Yes' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_ActionVerified' ,'Yes' ,  'Yes','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_ActionVerified' AND CODE='No' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_ActionVerified' ,'No' ,  'No','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_AuditProgramType' AND CODE='H' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_AuditProgramType' ,'H' ,  'Horizontal','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_AuditProgramType' AND CODE='V' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_AuditProgramType' ,'V' ,  'Vertical','en-GB'  )
END



IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_P&S_FileType' AND CODE='SP' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_P&S_FileType' ,'SP' ,  'System Procedure','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_NCClassification' AND CODE='Minor NC' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_NCClassification' ,'Minor NC' ,  'Minor NC','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='QMS_NCClassification' AND CODE='Major NC' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'QMS_NCClassification' ,'Major NC' ,  'Major NC','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='ExamType_QMS' AND CODE='PreExam' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'ExamType_QMS' ,'PreExam' ,  'PreExam','en-GB'  )
END

IF NOT EXISTS( SELECT 1 FROM MetaData WHERE DOMAIN='ExamType_QMS' AND CODE='PostExam' )
BEGIN
INSERT INTO dbo.MetaData( Domain , Code ,DisplayText , LangCode )
VALUES  (   'ExamType_QMS' ,'PostExam' ,  'PostExam','en-GB'  )
END


----------------------------------------------------------------------------------------------------------

--Added as part of Delivery Queue START

--Add 'Pending' NotificationStatus into Metadata and MetaDataOrgMapping

if not Exists (select 1 from Metadata where  Domain='NotificationStatus' and Code='Pending')
BEGIN
insert into Metadata(Domain,Code,DisplayText,LangCode,ParentID,SeqNo) values('NotificationStatus','Pending','Pending','en-GB',NULL,NULL)
END
GO

declare @MetadataID1 int
select @MetadataID1=max(MetaDataID) from Metadata

DECLARE @OrgID int
select @OrgID=OrgID from Organization where Name like '%IGENETIC - Ahmedabad%'

if not Exists (select 1 from MetaDataOrgMapping where DisplayText='Pending' and OrgID=@OrgID)
BEGIN
insert into MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values( @MetadataID1,@OrgID,'en-GB','Pending')
END
Go

--Add 'Completed' NotificationStatus into Metadata and MetaDataOrgMapping

if not Exists (select 1 from Metadata where  Domain='NotificationStatus' and Code='Completed')
BEGIN
insert into Metadata(Domain,Code,DisplayText,LangCode,ParentID,SeqNo) values('NotificationStatus','Completed','Completed','en-GB',NULL,NULL)
END
GO

declare @MetadataID1 int
select @MetadataID1=max(MetaDataID) from Metadata

DECLARE @OrgID int
select @OrgID=OrgID from Organization where Name like '%IGENETIC - Ahmedabad%'

if not Exists (select 1 from MetaDataOrgMapping where DisplayText='Completed' and OrgID=@OrgID)
BEGIN
insert into MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values( @MetadataID1,@OrgID,'en-GB','Completed')
END
GO


--Add 'Hold' NotificationStatus into Metadata and MetaDataOrgMapping

if not Exists (select 1 from Metadata where  Domain='NotificationStatus' and Code='Hold')
BEGIN
insert into Metadata(Domain,Code,DisplayText,LangCode,ParentID,SeqNo) values('NotificationStatus','Hold','Hold','en-GB',NULL,NULL)
END
GO

declare @MetadataID1 int
select @MetadataID1=max(MetaDataID) from Metadata

DECLARE @OrgID int
select @OrgID=OrgID from Organization where Name like '%IGENETIC - Ahmedabad%'

if not Exists (select 1 from MetaDataOrgMapping where DisplayText='Hold' and OrgID=@OrgID)
BEGIN
insert into MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values( @MetadataID1,@OrgID,'en-GB','Hold')
END
GO


--Add 'Error' NotificationStatus into Metadata and MetaDataOrgMapping

if not Exists (select 1 from Metadata where  Domain='NotificationStatus' and Code='Error')
BEGIN
insert into Metadata(Domain,Code,DisplayText,LangCode,ParentID,SeqNo) values('NotificationStatus','Error','Error','en-GB',NULL,NULL)
END
GO

declare @MetadataID1 int
select @MetadataID1=max(MetaDataID) from Metadata

DECLARE @OrgID int
select @OrgID=OrgID from Organization where Name like '%IGENETIC - Ahmedabad%'

if not Exists (select 1 from MetaDataOrgMapping where DisplayText='Error' and OrgID=@OrgID)
BEGIN
insert into MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values( @MetadataID1,@OrgID,'en-GB','Error')
END
GO


--Add 'Cancel' NotificationStatus into Metadata and MetaDataOrgMapping

if not Exists (select 1 from Metadata where  Domain='NotificationStatus' and Code='Cancel')
BEGIN
insert into Metadata(Domain,Code,DisplayText,LangCode,ParentID,SeqNo) values('NotificationStatus','Cancel','Cancel','en-GB',NULL,NULL)
END
GO

declare @MetadataID1 int
select @MetadataID1=max(MetaDataID) from Metadata

DECLARE @OrgID int
select @OrgID=OrgID from Organization where Name like '%IGENETIC - Ahmedabad%'

if not Exists (select 1 from MetaDataOrgMapping where DisplayText='Cancel' and OrgID=@OrgID)
BEGIN
insert into MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values( @MetadataID1,@OrgID,'en-GB','Cancel')
END
GO


declare @Orgid int
select @Orgid=OrgID from Organization where Name like '%Strand Life Sciences%'
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='WellnessReportStatus')
BEGIN	
		INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
		VALUES('WellnessReportStatus',1,'Yet To Request','en-GB',0),
		('WellnessReportStatus',2,'Requested','en-GB',0),
		('WellnessReportStatus',3,'Reported','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Yet To Request' and Domain='WellnessReportStatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Yet To Request')
set @metaid= (select metadataid from MetaData where DisplayText ='Requested' and Domain='WellnessReportStatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Requested')
set @metaid= (select metadataid from MetaData where DisplayText ='Reported' and Domain='WellnessReportStatus')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Reported')
END
GO
--Added as part of Delivery Queue END
-------------santhosh for Bulk Approval screen ------------

declare @Orgid int
select @Orgid=OrgID from Organization where Name like '%Narayana Healthcare Enterprise%'
IF NOT EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='QcCheck')
BEGIN	
		INSERT INTO metadata(domain,code,displaytext,langcode,parentid)
		VALUES('QcCheck','0','Fail','en-GB',0),
		('QcCheck','1','Pass','en-GB',0)

END

BEGIN
declare @metaid int
set @metaid= (select metadataid from MetaData where DisplayText ='Fail' and Domain='QcCheck')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Fail')
set @metaid= (select metadataid from MetaData where DisplayText ='Pass' and Domain='QcCheck')
INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText)
VALUES(@metaid,@Orgid,'en-GB','Pass')
END
---------------End----------------------------------------
Go
IF EXISTS(SELECT MetaDataID FROM metadata WHERE Domain='Btc_Type')
Begin
update MetaData set code='1' where Domain ='Btc_Type' and DisplayText='Normal'
update MetaData set code='2' where Domain ='Btc_Type' and DisplayText='Abnormal'
End

/* BEGIN | NA | Sabari | 06032019 | Created | InvestigationResultDeflagging */
go
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='InvestigationResultDeflag_Status' AND Code='ResultDeflag_100' AND DisplayText='ResultDeflag')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('InvestigationResultDeflag_Status','ResultDeflag_100','ResultDeflag','en-GB')
END
/*MetaDataOrgMapping*/
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='InvestigationResultDeflag_Status' and Code='ResultDeflag_100'
SELECT @OrgID=OrgID from organization where Name='Attune Demo' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='ResultDeflag' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','ResultDeflag')
END

GO
/***************************************************************************************************/
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='InvestigationResultDeflag_Role' AND Code='7365' AND DisplayText='Pathologist')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('InvestigationResultDeflag_Role','7365','Pathologist','en-GB')
END
/*MetaDataOrgMapping*/
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='InvestigationResultDeflag_Role' and Code='7365'
SELECT @OrgID=OrgID from organization where Name='Attune Demo' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='Pathologist' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','Pathologist')
END
GO
/* END | NA | Sabari | 06032019 | Created | InvestigationResultDeflagging */
/* BEGIN | NA | Sabari | 20190508 | Created | BulkEnterResult */
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='BulkEnterResultRoleBasedActionName' AND Code='Lab Technician' AND DisplayText='EnterResult')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('BulkEnterResultRoleBasedActionName','Lab Technician','EnterResult','en-GB')
END
/*MetaDataOrgMapping*/
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='BulkEnterResultRoleBasedActionName' and Code='Lab Technician'
SELECT @OrgID=OrgID from organization where Name='Attune Demo' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='EnterResult' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','EnterResult')
END
GO
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='BulkEnterResultRoleBasedActionName' AND Code='SrLabTech' AND DisplayText='Validate')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('BulkEnterResultRoleBasedActionName','SrLabTech','Validate','en-GB')
END
/*MetaDataOrgMapping*/
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='BulkEnterResultRoleBasedActionName' and Code='SrLabTech'
SELECT @OrgID=OrgID from organization where Name='Attune Demo' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='Validate' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','Validate')
END
GO
/* END | NA | Sabari | 20190508 | Created | BulkEnterResult */
/* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
-------********************************* InvestigationApprovelOrHold_Status    ************************************
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='InvestigationApprovelOrHold_Status' AND Code='On Hold & Approve_999' AND DisplayText='On Hold & Approve')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('InvestigationApprovelOrHold_Status','On Hold & Approve_999','On Hold & Approve','en-GB')
END
go
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='InvestigationApprovelOrHold_Status' and Code='On Hold & Approve_999'
SELECT @OrgID=OrgID from organization where Name='Attune Demo' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='On Hold & Approve' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','On Hold & Approve')
END
/*SECOND INSERT FOR SAME DOMAIN*/
GO
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='InvestigationApprovelOrHold_Status' AND Code='On Hold_998' AND DisplayText='On Hold')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('InvestigationApprovelOrHold_Status','On Hold_998','On Hold','en-GB')
END
/*MetaDataOrgMapping*/
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='InvestigationApprovelOrHold_Status' and Code='On Hold_998'
SELECT @OrgID=OrgID from organization where Name='Attune Demo' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='On Hold' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','On Hold')
END
/*FOR UN HOLD*/
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='InvestigationUnHold_Status' AND Code='UnHold_1' AND DisplayText='UnHold')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('InvestigationUnHold_Status','UnHold_1','UnHold','en-GB')
END
go
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='InvestigationUnHold_Status' and Code='UnHold_1'
SELECT @OrgID=OrgID from organization where Name='Attune Demo' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='UnHold' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','UnHold')
END
go
/* END | NA | Sabari | 20181202 | Created | HOLD */

----------------------- HomeCollection Start ------------------------

    declare @Orgid bigint
	declare @LangCode varchar(10)
	Declare @Code VARCHAR(20)
	Declare @Domain VARCHAR(20)
	Declare @SubTypeCode1 VARCHAR(20)

	Declare @ParentID Bigint
	Declare @MetaDataID1 Bigint

	select @Orgid=OrgID from Organization where OrgDisplayName = 'Diag'
	set @LangCode='en-GB'
	set @Domain='SearchType'
	set @Code='5'
	set @SubTypeCode1='Health HubID'

	Select @ParentID=ISNULL(MetaDataID,0) from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
	 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode)
	 BEGIN
			 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code and ParentID=@ParentID)
			 BEGIN
				 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
				 VALUES (@Domain,@Code,@SubTypeCode1,@LangCode,@ParentID)
			 END
			 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
			 BEGIN
				select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code 
				IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
				BEGIN
					INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
				END
			 END
	END
	GO


/******************* HomeCollection Related End **************/
IF NOT EXISTS(SELECT 1 FROM MetaData WHERE Domain='Btc_Type' AND Code='3' AND DisplayText='Critical')
BEGIN
INSERT INTO MetaData(Domain,Code,DisplayText,LangCode)
values('Btc_Type','3','Critical','en-GB')
END
/*MetaDataOrgMapping*/
DECLARE @OrgID int
DECLARE @MetadataID bigint
SELECT @MetadataID=MetaDataID from MetaData where Domain='Btc_Type' and Code='3'
SELECT @OrgID=OrgID from organization where Name='Diag' 
IF NOT EXISTS(SELECT 1 FROM MetaDataOrgMapping WHERE  MetadataID=@MetadataID  and DisplayText='Critical' and LangCode='en-GB' and OrgID=@OrgID)
BEGIN
INSERT INTO MetaDataOrgMapping (MetadataID,OrgID,LangCode,DisplayText)
VALUES(@MetadataID,@OrgID,'en-GB','Critical')
END

Declare @OrgID int,@ConfigKeyID bigint
	select @OrgID=OrgID from organization where Name='Diag'  
	IF not Exists(SELECT 1 FROM ConfigKeyMaster where ConfigKey='WhatsupInvestiationReportlink')
	BEGIN   

		SELECT @ConfigKeyID= max(ConfigKeyID)+1 from ConfigKeyMaster
			INSERT INTO ConfigKeyMaster(ConfigKeyID,ConfigKey,DisplayText) 
	VALUES
	(@ConfigKeyID,'WhatsupInvestiationReportlink','Do you want to send Whatsup Investiation Report link?')
		
	END

		
SELECT * FROM ConfigKeyMaster WHERE ConfigKey='WhatsupInvestiationReportlink'
SELECT @ConfigKeyID=ConfigKeyID FROM ConfigKeyMaster WHERE ConfigKey='WhatsupInvestiationReportlink'
	IF not Exists(SELECT 1 FROM ConfigOrgMaster where ConfigKeyID=@ConfigKeyID AND OrgID=@Orgid)
			BEGIN
		
		 INSERT INTO ConfigOrgMaster (ConfigKeyID,ConfigValue,OrgID,CreatedBy,CreatedAt)
		values(@ConfigKeyID,'Y',@Orgid,NULL	,GETDATE())
			
	GO
	
	/******************* HomeCollection Related Start 31/07/2020 **************/

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'Ashok Laboratory'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Booked'
set @SubTypeCode1='Booked'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'Ashok Laboratory'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Assigned'
set @SubTypeCode1='Assigned'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'Ashok Laboratory'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Cancelled'
set @SubTypeCode1='Cancelled'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO
declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'Ashok Laboratory'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Trip- Started'
set @SubTypeCode1='Trip- Started'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'Ashok Laboratory'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Trip-Canceled'
set @SubTypeCode1='Trip-Canceled'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'Ashok Laboratory'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Reached Destination'
set @SubTypeCode1='Reached Destination'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'Ashok Laboratory'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Completed'
set @SubTypeCode1='Completed'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

/******************* HomeCollection Related Start 31/07/2020 **************/

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'RLS-Gorakhpur'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Booked'
set @SubTypeCode1='Booked'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'RLS-Gorakhpur'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Assigned'
set @SubTypeCode1='Assigned'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'RLS-Gorakhpur'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Cancelled'
set @SubTypeCode1='Cancelled'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO
declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'RLS-Gorakhpur'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Trip- Started'
set @SubTypeCode1='Trip- Started'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'RLS-Gorakhpur'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Trip-Canceled'
set @SubTypeCode1='Trip-Canceled'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'RLS-Gorakhpur'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Reached Destination'
set @SubTypeCode1='Reached Destination'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
Declare @Code VARCHAR(20)
Declare @Domain VARCHAR(20)
Declare @SubTypeCode1 VARCHAR(20)

Declare @ParentID Bigint
Declare @MetaDataID1 Bigint

select @Orgid=OrgID from Organization where OrgDisplayName = 'RLS-Gorakhpur'
set @LangCode='en-GB'
set @Domain='HC-BookingStatus'
set @Code='Completed'
set @SubTypeCode1='Completed'

Select @ParentID=MetaDataID from MetaData Where Domain=@Domain and LangCode=@LangCode AND Code=@Code
IF   NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
 BEGIN
		 IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode 
		 AND Code=@SubTypeCode1 and ParentID=@ParentID)
		 BEGIN
			 INSERT INTO [dbo].[MetaData](Domain,Code,DisplayText,LangCode,ParentID)
			 VALUES (@Domain,@SubTypeCode1,@SubTypeCode1,@LangCode,@ParentID)
		 END
		 IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1)
		 BEGIN
			select @MetaDataID1=MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@SubTypeCode1 
			IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
			BEGIN
				INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText) values (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1)
			END
		 END
END
GO

declare @Orgid bigint
declare @LangCode varchar(10)
declare @Code VARCHAR(20)
declare @Domain VARCHAR(20)
declare @SubTypeCode1 VARCHAR(20)
declare @ParentID Bigint
declare @MetaDataID1 Bigint
SELECT @Orgid=OrgID from Organization where Name = 'RLS-Gorakhpur'
  set @LangCode='en-GB'
  set @Domain='Visit Source'
  set @Code='RLS'
  set @SubTypeCode1='RLS'

IF NOT EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code )
  BEGIN
     INSERT INTO [dbo].[MetaData](Domain, Code, DisplayText, LangCode, CreatedAt, CreatedBy)
	 VALUES (@Domain,@Code,@Code,@LangCode,GETDATE(), 1)
  END

IF EXISTS (select 1 from MetaData where Domain=@Domain and LangCode=@LangCode AND Code=@Code)
  BEGIN
 	SELECT @MetaDataID1 = MetaDataID from MetaData where Domain=@Domain and LangCode=@LangCode AND Code= @SubTypeCode1
    IF NOT EXISTS (select 1 from MetaDataOrgMapping where MetadataID=@MetaDataID1 and OrgID=@Orgid and LangCode=@LangCode and DisplayText=@SubTypeCode1 )
		BEGIN
	    	INSERT INTO MetaDataOrgMapping(MetadataID,OrgID,LangCode,DisplayText, CreatedAt, CreatedBy) 
		    VALUES (@MetaDataID1,@Orgid,@LangCode,@SubTypeCode1, getdate(), 1)
		END
  END
GO