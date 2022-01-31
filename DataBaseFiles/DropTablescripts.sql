

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_DialysisDetails_isFirstDialysis]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DialysisDetails] DROP CONSTRAINT [DF_DialysisDetails_isFirstDialysis]
END

GO


GO

/****** Object:  Table [dbo].[InventoryProductMapping]    Script Date: 04/29/2011 21:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryProductMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryProductMapping]
GO

/****** Object:  Table [dbo].[AccidentRegistry]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AccidentRegistry]') AND type in (N'U'))
DROP TABLE [dbo].[AccidentRegistry]
GO

/****** Object:  Table [dbo].[Advice]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Advice]') AND type in (N'U'))
DROP TABLE [dbo].[Advice]
GO

/****** Object:  Table [dbo].[Allergy]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Allergy]') AND type in (N'U'))
DROP TABLE [dbo].[Allergy]
GO

/****** Object:  Table [dbo].[BackgroundProblem]    Script Date: 02/26/2009 11:08:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackgroundProblem]') AND type in (N'U'))
DROP TABLE [dbo].[BackgroundProblem]
GO

/****** Object:  Table [dbo].[Bookings]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings]') AND type in (N'U'))
DROP TABLE [dbo].[Bookings]
GO

/****** Object:  Table [dbo].[CaseSheet]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CaseSheet]') AND type in (N'U'))
DROP TABLE [dbo].[CaseSheet]
GO

/****** Object:  Table [dbo].[Complaint]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Complaint]') AND type in (N'U'))
DROP TABLE [dbo].[Complaint]
GO

/****** Object:  Table [dbo].[ComplaintDrug]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintDrug]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintDrug]
GO

/****** Object:  Table [dbo].[ComplaintExamination]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintExamination]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintExamination]
GO

/****** Object:  Table [dbo].[ComplaintHistory]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintHistory]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintHistory]
GO

/****** Object:  Table [dbo].[ComplaintInvestigation]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintInvestigation]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintInvestigation]
GO

/****** Object:  Table [dbo].[Complication]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Complication]') AND type in (N'U'))
DROP TABLE [dbo].[Complication]
GO

/****** Object:  Table [dbo].[Composition]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Composition]') AND type in (N'U'))
DROP TABLE [dbo].[Composition]
GO

/****** Object:  Table [dbo].[Country]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
DROP TABLE [dbo].[Country]
GO

/****** Object:  Table [dbo].[DialysisAccess]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DialysisAccess]') AND type in (N'U'))
DROP TABLE [dbo].[DialysisAccess]
GO

/****** Object:  Table [dbo].[DialysisDetails]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DialysisDetails]') AND type in (N'U'))
DROP TABLE [dbo].[DialysisDetails]
GO

/****** Object:  Table [dbo].[DialysisOnFlow]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DialysisOnFlow]') AND type in (N'U'))
DROP TABLE [dbo].[DialysisOnFlow]
GO

/****** Object:  Table [dbo].[DialysisOnFlowDetails]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DialysisOnFlowDetails]') AND type in (N'U'))
DROP TABLE [dbo].[DialysisOnFlowDetails]
GO

/****** Object:  Table [dbo].[DialysisPatientVitals]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DialysisPatientVitals]') AND type in (N'U'))
DROP TABLE [dbo].[DialysisPatientVitals]
GO

/****** Object:  Table [dbo].[DialysisRecord]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DialysisRecord]') AND type in (N'U'))
DROP TABLE [dbo].[DialysisRecord]
GO

/****** Object:  Table [dbo].[DrugComposition]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugComposition]') AND type in (N'U'))
DROP TABLE [dbo].[DrugComposition]
GO

/****** Object:  Table [dbo].[DrugFrequency]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugFrequency]') AND type in (N'U'))
DROP TABLE [dbo].[DrugFrequency]
GO

/****** Object:  Table [dbo].[Drugs]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Drugs]') AND type in (N'U'))
DROP TABLE [dbo].[Drugs]
GO

/****** Object:  Table [dbo].[DrugType]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugType]') AND type in (N'U'))
DROP TABLE [dbo].[DrugType]
GO

/****** Object:  Table [dbo].[Examination]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Examination]') AND type in (N'U'))
DROP TABLE [dbo].[Examination]
GO

/****** Object:  Table [dbo].[History]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[History]') AND type in (N'U'))
DROP TABLE [dbo].[History]
GO

/****** Object:  Table [dbo].[Investigation]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Investigation]') AND type in (N'U'))
DROP TABLE [dbo].[Investigation]
GO

/****** Object:  Table [dbo].[InvestigationMethod]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationMethod]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationMethod]
GO

/****** Object:  Table [dbo].[InvestigationPrecaution]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationPrecaution]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationPrecaution]
GO

/****** Object:  Table [dbo].[InvestigationProfile]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationProfile]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationProfile]
GO

/****** Object:  Table [dbo].[InvestigationProfileMapping]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationProfileMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationProfileMapping]
GO

/****** Object:  Table [dbo].[InvestigationSampleContainer]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationSampleContainer]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationSampleContainer]
GO

/****** Object:  Table [dbo].[InvestigationSite]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationSite]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationSite]
GO

/****** Object:  Table [dbo].[InvestigationValues]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationValues]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationValues]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Login]') AND type in (N'U'))
DROP TABLE [dbo].[Login]
GO

/****** Object:  Table [dbo].[LoginRole]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginRole]') AND type in (N'U'))
DROP TABLE [dbo].[LoginRole]
GO

/****** Object:  Table [dbo].[MenuMaster]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuMaster]') AND type in (N'U'))
DROP TABLE [dbo].[MenuMaster]
GO

/****** Object:  Table [dbo].[Nurse]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nurse]') AND type in (N'U'))
DROP TABLE [dbo].[Nurse]
GO

/****** Object:  Table [dbo].[NurseAddress]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NurseAddress]') AND type in (N'U'))
DROP TABLE [dbo].[NurseAddress]
GO

/****** Object:  Table [dbo].[NurseSpeciality]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NurseSpeciality]') AND type in (N'U'))
DROP TABLE [dbo].[NurseSpeciality]
GO

/****** Object:  Table [dbo].[Organization]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Organization]') AND type in (N'U'))
DROP TABLE [dbo].[Organization]
GO

/****** Object:  Table [dbo].[OrganizationAddress]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrganizationAddress]') AND type in (N'U'))
DROP TABLE [dbo].[OrganizationAddress]
GO

/****** Object:  Table [dbo].[OrganizationType]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrganizationType]') AND type in (N'U'))
DROP TABLE [dbo].[OrganizationType]
GO

/****** Object:  Table [dbo].[OrgUOMVitalsMapping]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrgUOMVitalsMapping]') AND type in (N'U'))
DROP TABLE [dbo].[OrgUOMVitalsMapping]
GO

/****** Object:  Table [dbo].[PageMapping]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PageMapping]
GO

/****** Object:  Table [dbo].[Pages]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pages]') AND type in (N'U'))
DROP TABLE [dbo].[Pages]
GO

/****** Object:  Table [dbo].[Patient]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Patient]') AND type in (N'U'))
DROP TABLE [dbo].[Patient]
GO

/****** Object:  Table [dbo].[PatientAddress]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientAddress]') AND type in (N'U'))
DROP TABLE [dbo].[PatientAddress]
GO

/****** Object:  Table [dbo].[PatientAdvice]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientAdvice]') AND type in (N'U'))
DROP TABLE [dbo].[PatientAdvice]
GO

/****** Object:  Table [dbo].[PatientAllergy]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientAllergy]') AND type in (N'U'))
DROP TABLE [dbo].[PatientAllergy]
GO

/****** Object:  Table [dbo].[PatientComplaint]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientComplaint]') AND type in (N'U'))
DROP TABLE [dbo].[PatientComplaint]
GO

/****** Object:  Table [dbo].[PatientComplication]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientComplication]') AND type in (N'U'))
DROP TABLE [dbo].[PatientComplication]
GO

/****** Object:  Table [dbo].[PatientCondition]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientCondition]') AND type in (N'U'))
DROP TABLE [dbo].[PatientCondition]
GO

/****** Object:  Table [dbo].[PatientHistory]    Script Date: 03/20/2009 16:14:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientHistory]') AND type in (N'U'))
DROP TABLE [dbo].[PatientHistory]
GO

/****** Object:  Table [dbo].[PatientInvestigation]    Script Date: 03/20/2009 16:15:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvestigation]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvestigation]
GO

/****** Object:  Table [dbo].[PatientPayments]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientPayments]') AND type in (N'U'))
DROP TABLE [dbo].[PatientPayments]
GO

/****** Object:  Table [dbo].[PatientPrescription]    Script Date: 03/20/2009 16:16:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientPrescription]') AND type in (N'U'))
DROP TABLE [dbo].[PatientPrescription]
GO

/****** Object:  Table [dbo].[PatientVisit]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientVisit]') AND type in (N'U'))
DROP TABLE [dbo].[PatientVisit]
GO

/****** Object:  Table [dbo].[PatientVitals]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientVitals]') AND type in (N'U'))
DROP TABLE [dbo].[PatientVitals]
GO

/****** Object:  Table [dbo].[Permission]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Permission]') AND type in (N'U'))
DROP TABLE [dbo].[Permission]
GO

/****** Object:  Table [dbo].[Physician]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Physician]') AND type in (N'U'))
DROP TABLE [dbo].[Physician]
GO

/****** Object:  Table [dbo].[PhysicianAddress]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianAddress]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianAddress]
GO

/****** Object:  Table [dbo].[PhysicianOrganization]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianOrganization]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianOrganization]
GO

/****** Object:  Table [dbo].[PhysicianSpeciality]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianSpeciality]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianSpeciality]
GO

/****** Object:  Table [dbo].[Precaution]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Precaution]') AND type in (N'U'))
DROP TABLE [dbo].[Precaution]
GO

/****** Object:  Table [dbo].[RecurrenceAbsolute]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RecurrenceAbsolute]') AND type in (N'U'))
DROP TABLE [dbo].[RecurrenceAbsolute]
GO

/****** Object:  Table [dbo].[RecurrenceRelative]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RecurrenceRelative]') AND type in (N'U'))
DROP TABLE [dbo].[RecurrenceRelative]
GO

/****** Object:  Table [dbo].[Role]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type in (N'U'))
DROP TABLE [dbo].[Role]
GO

/****** Object:  Table [dbo].[RoleMenu]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleMenu]') AND type in (N'U'))
DROP TABLE [dbo].[RoleMenu]
GO

/****** Object:  Table [dbo].[RolePermission]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RolePermission]') AND type in (N'U'))
DROP TABLE [dbo].[RolePermission]
GO

/****** Object:  Table [dbo].[Salutation]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Salutation]') AND type in (N'U'))
DROP TABLE [dbo].[Salutation]
GO

/****** Object:  Table [dbo].[SchedulableResource]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SchedulableResource]') AND type in (N'U'))
DROP TABLE [dbo].[SchedulableResource]
GO

/****** Object:  Table [dbo].[Schedules]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedules]') AND type in (N'U'))
DROP TABLE [dbo].[Schedules]
GO

/****** Object:  Table [dbo].[ScheduleTemplate]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ScheduleTemplate]') AND type in (N'U'))
DROP TABLE [dbo].[ScheduleTemplate]
GO

--/****** Object:  Table [dbo].[SearchActions]    Script Date: 02/02/2009 19:05:11 ******/
--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchActions]') AND type in (N'U'))
--DROP TABLE [dbo].[SearchActions]
--GO

/****** Object:  Table [dbo].[Speciality]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Speciality]') AND type in (N'U'))
DROP TABLE [dbo].[Speciality]
GO

/****** Object:  Table [dbo].[State]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[State]') AND type in (N'U'))
DROP TABLE [dbo].[State]
GO

/****** Object:  Table [dbo].[TaskActions]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskActions]') AND type in (N'U'))
DROP TABLE [dbo].[TaskActions]
GO

/****** Object:  Table [dbo].[TaskEscalation]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskEscalation]') AND type in (N'U'))
DROP TABLE [dbo].[TaskEscalation]
GO


/****** Object:  Table [dbo].[TaskStatus]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskStatus]') AND type in (N'U'))
DROP TABLE [dbo].[TaskStatus]
GO

/****** Object:  Table [dbo].[UOM]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UOM]') AND type in (N'U'))
DROP TABLE [dbo].[UOM]
GO

/****** Object:  Table [dbo].[UOMVitalsMapping]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UOMVitalsMapping]') AND type in (N'U'))
DROP TABLE [dbo].[UOMVitalsMapping]
GO

/****** Object:  Table [dbo].[UserAddress]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserAddress]') AND type in (N'U'))
DROP TABLE [dbo].[UserAddress]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO

/****** Object:  Table [dbo].[UserType_obselete]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserType_obselete]') AND type in (N'U'))
DROP TABLE [dbo].[UserType_obselete]
GO

/****** Object:  Table [dbo].[VisitPurpose]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitPurpose]') AND type in (N'U'))
DROP TABLE [dbo].[VisitPurpose]
GO

/****** Object:  Table [dbo].[Vitals]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vitals]') AND type in (N'U'))
DROP TABLE [dbo].[Vitals]
GO

/*  Billing Table start */

/****** Object:  Table [dbo].[BillingDetails]    Script Date: 02/03/2009 13:51:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillingDetails]') AND type in (N'U'))
DROP TABLE [dbo].[BillingDetails]
GO
/****** Object:  Table [dbo].[FinalBill]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FinalBill]') AND type in (N'U'))
DROP TABLE [dbo].[FinalBill]
GO
/****** Object:  Table [dbo].[InvestigationFee]    Script Date: 02/03/2009 13:51:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationFee]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationFee]
GO
/****** Object:  Table [dbo].[InvestigationFeeReferenceOrgMapping]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationFeeReferenceOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationFeeReferenceOrgMapping]
GO
/****** Object:  Table [dbo].[PhysicianFee]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianFee]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianFee]
GO
/****** Object:  Table [dbo].[ProcedureFee]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureFee]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureFee]
GO
/****** Object:  Table [dbo].[ProcedureFeeReferenceOrgMapping]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureFeeReferenceOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureFeeReferenceOrgMapping]
GO
/****** Object:  Table [dbo].[ProcedureMaster]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureMaster]
GO
/****** Object:  Table [dbo].[ReferenceOrg]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferenceOrg]') AND type in (N'U'))
DROP TABLE [dbo].[ReferenceOrg]
GO
/****** Object:  Table [dbo].[StandardDeduction]    Script Date: 02/03/2009 13:51:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StandardDeduction]') AND type in (N'U'))
DROP TABLE [dbo].[StandardDeduction]
GO


/*  Billing Table End */


/****** Object:  Table [dbo].[Reminder]    Script Date: 02/03/2009 18:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reminder]') AND type in (N'U'))
DROP TABLE [dbo].[Reminder]
GO

/****** Object:  Table [dbo].[ReminderTemplate]    Script Date: 02/03/2009 18:09:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReminderTemplate]') AND type in (N'U'))
DROP TABLE [dbo].[ReminderTemplate]
GO

/****** Object:  Table [dbo].[DrugBrand]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugBrand]') AND type in (N'U'))
DROP TABLE [dbo].[DrugBrand]
GO

/****** Object:  Table [dbo].[DrugFMROA]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugFMROA]') AND type in (N'U'))
DROP TABLE [dbo].[DrugFMROA]
GO

/****** Object:  Table [dbo].[DrugFormulation]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugFormulation]') AND type in (N'U'))
DROP TABLE [dbo].[DrugFormulation]
GO

/****** Object:  Table [dbo].[DrugGeneric]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugGeneric]') AND type in (N'U'))
DROP TABLE [dbo].[DrugGeneric]
GO

/****** Object:  Table [dbo].[DrugROA]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugROA]') AND type in (N'U'))
DROP TABLE [dbo].[DrugROA]
GO

/****** Object:  Table [dbo].[ProcedureSpeciality]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureSpeciality]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureSpeciality]
GO

/****** Object:  Table [dbo].[TaskActionMapping]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskActionMapping]') AND type in (N'U'))
DROP TABLE [dbo].[TaskActionMapping]
GO

/****** Object:  Table [dbo].[ProcedureComplication]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureComplication]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureComplication]
GO 	

/****** Object:  Table [dbo].[LoggedInUsers]    Script Date: 02/04/2009 18:09:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoggedInUsers]') AND type in (N'U'))
DROP TABLE [dbo].[LoggedInUsers]
GO 	


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvestigationFiles]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvestigationFiles]
GO
 	
 	

/****** Object:  Table [dbo].[TaskProfile]    Script Date: 02/26/2009 18:46:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskProfile]') AND type in (N'U'))
DROP TABLE [dbo].[TaskProfile]
GO


/****** Object:  Table [dbo].[OrganizationSpeciality]    Script Date: 02/27/2009 10:26:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrganizationSpeciality]') AND type in (N'U'))
DROP TABLE [dbo].[OrganizationSpeciality]
GO



/****** Object:  Table [dbo].[InvestigationOrgMapping]    Script Date: 07/20/2009 11:02:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationOrgMapping]
GO



/****** Object:  Table [dbo].[Tasks]    Script Date: 02/28/2009 12:32:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tasks]') AND type in (N'U'))
DROP TABLE [dbo].[Tasks]
GO

/****** Object:  Table [dbo].[DuePaidDetail]    Script Date: 03/02/2009 19:49:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DuePaidDetail]') AND type in (N'U'))
DROP TABLE [dbo].[DuePaidDetail]
GO

/****** Object:  Table [dbo].[BedMaster]    Script Date: 03/02/2009 19:49:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BedMaster]') AND type in (N'U'))
DROP TABLE [dbo].[BedMaster]
GO

/****** Object:  Table [dbo].[FloorMaster]    Script Date: 03/02/2009 19:49:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FloorMaster]') AND type in (N'U'))
DROP TABLE [dbo].[FloorMaster]
GO

/****** Object:  Table [dbo].[RoomMaster]    Script Date: 03/02/2009 19:49:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomMaster]') AND type in (N'U'))
DROP TABLE [dbo].[RoomMaster]
GO

/****** Object:  Table [dbo].[RoomType]    Script Date: 03/02/2009 19:49:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomType]') AND type in (N'U'))
DROP TABLE [dbo].[RoomType]
GO

/****** Object:  Table [dbo].[Config]    Script Date: 03/02/2009 19:49:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Config]') AND type in (N'U'))
DROP TABLE [dbo].[Config]
GO


/****** Object:  Table [dbo].[Investigation]    Script Date: 03/03/2009 12:46:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Investigation]') AND type in (N'U'))
DROP TABLE [dbo].[Investigation]
GO

/****** Object:  Table [dbo].[InvestigationPattern]    Script Date: 03/03/2009 12:46:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationPattern]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationPattern]
GO

/****** Object:  Table [dbo].[PatternMapping]    Script Date: 03/03/2009 12:46:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatternMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PatternMapping]
GO


/****** Object:  Table [dbo].[InvestigationHeader]    Script Date: 03/03/2009 12:48:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationHeader]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationHeader]
GO


/****** Object:  Table [dbo].[InvestigationBulkData]    Script Date: 03/05/2009 10:07:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationBulkData]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationBulkData]
GO


/****** Object:  Table [dbo].[InvestigationValidation]    Script Date: 03/05/2009 10:10:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationValidation]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationValidation]
GO

/****** Object:  Table [dbo].[BedBooking]    Script Date: 03/06/2009 15:09:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BedBooking]') AND type in (N'U'))
DROP TABLE [dbo].[BedBooking]
GO


--/****** Object:  Table [dbo].[VisitSearchActions]    Script Date: 03/12/2009 10:17:06 ******/
--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitSearchActions]') AND type in (N'U'))
--DROP TABLE [dbo].[VisitSearchActions]
--GO


/****** Object:  Table [dbo].[InvestigationDetails]    Script Date: 03/20/2009 12:23:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationDetails]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationDetails]
GO

/****** Object:  Table [dbo].[PatientExamination]    Script Date: 03/20/2009 16:12:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientExamination]') AND type in (N'U'))
DROP TABLE [dbo].[PatientExamination]
GO


/****** Object:  Table [dbo].[TaskActionOrgMapping]    Script Date: 04/01/2009 19:03:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskActionOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[TaskActionOrgMapping]
GO


/****** Object:  Table [dbo].[VisitPurposeOrgMapping]    Script Date: 04/04/2009 16:47:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitPurposeOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[VisitPurposeOrgMapping]
GO


/****** Object:  Table [dbo].[RoleDeptMap]    Script Date: 04/28/2009 11:20:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleDeptMap]') AND type in (N'U'))
DROP TABLE [dbo].[RoleDeptMap]
GO


/****** Object:  Table [dbo].[InvDeptMaster]    Script Date: 04/28/2009 11:24:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvDeptMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvDeptMaster]
GO

/*  Investigation Sample Table Starts */

/****** Object:  Table [dbo].[ComplaintInvestigation]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintInvestigation]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintInvestigation]
GO
/****** Object:  Table [dbo].[InvDeptMaster]    Script Date: 04/23/2009 14:24:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvDeptMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvDeptMaster]
GO

/****** Object:  Table [dbo].[InvestigationMaster]    Script Date: 04/25/2009 12:18:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationMaster]
GO

/****** Object:  Table [dbo].[InvestigationOrgMapping]    Script Date: 04/23/2009 14:24:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationOrgMapping]
GO
/****** Object:  Table [dbo].[InvestigationPattern]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationPattern]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationPattern]
GO
/****** Object:  Table [dbo].[InvGroupMapMaster]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvGroupMapMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvGroupMapMaster]
GO
/****** Object:  Table [dbo].[InvGroupMaster]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvGroupMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvGroupMaster]
GO
/****** Object:  Table [dbo].[InvSampleMaster]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvSampleMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvSampleMaster]
GO
/****** Object:  Table [dbo].[InvSampleStatusmaster]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvSampleStatusmaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvSampleStatusmaster]
GO
/****** Object:  Table [dbo].[PatientInvestigation]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvestigation]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvestigation]
GO
/****** Object:  Table [dbo].[PatientInvSample]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvSample]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvSample]
GO

/****** Object:  Table [dbo].[SampleTracker]    Script Date: 04/23/2009 14:24:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SampleTracker]') AND type in (N'U'))
DROP TABLE [dbo].[SampleTracker]
GO


/****** Object:  Table [dbo].[InvestigationStatus]    Script Date: 04/15/2009 18:01:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationStatus]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationStatus]
GO


/****** Object:  Table [dbo].[RoleDeptMap]    Script Date: 04/15/2009 18:06:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleDeptMap]') AND type in (N'U'))
DROP TABLE [dbo].[RoleDeptMap]
GO

/*  Investigation Sample Table Ends */
/****** Object:  Table [dbo].[InvestigationStatus]    Script Date: 04/16/2009 17:12:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationStatus]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationStatus]
GO


/****** Object:  Table [dbo].[InvestigationOrgSampleStatus]    Script Date: 04/18/2009 12:44:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationOrgSampleStatus]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationOrgSampleStatus]
GO


/****** Object:  Table [dbo].[InvestigationOrgSampleStatus]    Script Date: 04/18/2009 15:42:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationOrgSampleStatus]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationOrgSampleStatus]
GO


/****** Object:  Table [dbo].[VitalsPageOptions]    Script Date: 05/09/2009 16:44:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VitalsPageOptions]') AND type in (N'U'))
DROP TABLE [dbo].[VitalsPageOptions]
GO

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ReportGroupMaster_CreatedAt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ReportGroupMaster] DROP CONSTRAINT [DF_ReportGroupMaster_CreatedAt]
END

GO

/****** Object:  Table [dbo].[ReportGroupMaster]    Script Date: 05/20/2009 11:49:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportGroupMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ReportGroupMaster]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ReportMaster_CreatedAt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ReportMaster] DROP CONSTRAINT [DF_ReportMaster_CreatedAt]
END

GO

/****** Object:  Table [dbo].[ReportMaster]    Script Date: 05/20/2009 11:51:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ReportMaster]
GO

/****** Object:  Table [dbo].[ReportOrgMapping]    Script Date: 05/20/2009 11:51:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ReportOrgMapping]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PatientLocation_PatientLocation]') AND parent_object_id = OBJECT_ID(N'[dbo].[InPatientLocationTransferDetails]'))
ALTER TABLE [dbo].[InPatientLocationTransferDetails] DROP CONSTRAINT [FK_PatientLocation_PatientLocation]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PatientLocation_DateOfTransfer]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InPatientLocationTransferDetails] DROP CONSTRAINT [DF_PatientLocation_DateOfTransfer]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PatientLocation_CreatedAt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InPatientLocationTransferDetails] DROP CONSTRAINT [DF_PatientLocation_CreatedAt]
END

GO

/****** Object:  Table [dbo].[InPatientLocationTransferDetails]    Script Date: 05/27/2009 11:02:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientLocationTransferDetails]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientLocationTransferDetails]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_InPatientConsultantTransferDetails_CreatedAt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InPatientConsultantTransferDetails] DROP CONSTRAINT [DF_InPatientConsultantTransferDetails_CreatedAt]
END

GO

/****** Object:  Table [dbo].[InPatientConsultantTransferDetails]    Script Date: 05/25/2009 18:33:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientConsultantTransferDetails]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientConsultantTransferDetails]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_InPatientDischargeDetails_AmbulanceRequired]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InPatientDischargeDetails] DROP CONSTRAINT [DF_InPatientDischargeDetails_AmbulanceRequired]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_InPatientDischargeDetails_AmbulanceConfirmed]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InPatientDischargeDetails] DROP CONSTRAINT [DF_InPatientDischargeDetails_AmbulanceConfirmed]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_InPatientDischargeDetails_CreatedAt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[InPatientDischargeDetails] DROP CONSTRAINT [DF_InPatientDischargeDetails_CreatedAt]
END

GO

/****** Object:  Table [dbo].[InPatientDischargeDetails]    Script Date: 05/27/2009 11:05:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientDischargeDetails]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientDischargeDetails]
GO

/****** Object:  Table [dbo].[InPatientDischargedWith]    Script Date: 05/27/2009 11:06:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientDischargedWith]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientDischargedWith]
GO


/****** Object:  Table [dbo].[InPatientDischargeType]    Script Date: 05/27/2009 11:07:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientDischargeType]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientDischargeType]
GO

/****** Object:  Table [dbo].[Relationship]    Script Date: 05/27/2009 23:57:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Relationship]') AND type in (N'U'))
DROP TABLE [dbo].[Relationship]
GO


IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_DrugUseInstruction_CreatedAt]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DrugUseInstruction] DROP CONSTRAINT [DF_DrugUseInstruction_CreatedAt]
END

GO

 

/****** Object:  Table [dbo].[DrugUseInstruction]    Script Date: 05/28/2009 16:46:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugUseInstruction]') AND type in (N'U'))
DROP TABLE [dbo].[DrugUseInstruction]
GO

/****** Object:  Table [dbo].[ComplaintGroupOrgMapping]    Script Date: 05/30/2009 19:11:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintGroupOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintGroupOrgMapping]
GO

/****** Object:  Table [dbo].[AmountReceivedDetails]    Script Date: 06/03/2009 00:51:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AmountReceivedDetails]') AND type in (N'U'))
DROP TABLE [dbo].[AmountReceivedDetails]
GO

/****** Object:  Table [dbo].[AmountClosureDetails]    Script Date: 06/03/2009 01:29:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AmountClosureDetails]') AND type in (N'U'))
DROP TABLE [dbo].[AmountClosureDetails]
GO

/****** Object:  Table [dbo].[InvOrgGroup]    Script Date: 06/03/2009 15:55:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvOrgGroup]') AND type in (N'U'))
DROP TABLE [dbo].[InvOrgGroup]
Go

/****** Object:  Table [dbo].[AmountRefundDetails]    Script Date: 06/05/2009 02:19:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AmountRefundDetails]') AND type in (N'U'))
DROP TABLE [dbo].[AmountRefundDetails]
GO

/****** Object:  Table [dbo].[BillSearchActions]    Script Date: 06/10/2009 19:21:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillSearchActions]') AND type in (N'U'))
DROP TABLE [dbo].[BillSearchActions]
GO

/****** Object:  Table [dbo].[PatientInvSampleResults]    Script Date: 06/11/2009 11:04:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvSampleResults]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvSampleResults]
GO

/****** Object:  Table [dbo].[SampleAttributes]    Script Date: 06/11/2009 11:05:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SampleAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[SampleAttributes]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IDMaster_PatientNumber]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IDMaster] DROP CONSTRAINT [DF_IDMaster_PatientNumber]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IDMaster_BillNumber]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IDMaster] DROP CONSTRAINT [DF_IDMaster_BillNumber]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IDMaster_IPNumber]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IDMaster] DROP CONSTRAINT [DF_IDMaster_IPNumber]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_IDMaster_VisitNumber]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[IDMaster] DROP CONSTRAINT [DF_IDMaster_VisitNumber]
END

GO

/****** Object:  Table [dbo].[IDMaster]    Script Date: 06/11/2009 17:20:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[IDMaster]
GO


/****** Object:  Table [dbo].[PaymentType]    Script Date: 06/18/2009 12:22:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaymentType]') AND type in (N'U'))
DROP TABLE [dbo].[PaymentType]
GO

/****** Object:  Table [dbo].[BelongingsHandoverDetails]    Script Date: 06/22/2009 16:44:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BelongingsHandoverDetails]') AND type in (N'U'))
DROP TABLE [dbo].[BelongingsHandoverDetails]
GO

/****** Object:  Table [dbo].[InPatientAdmissionDetails]    Script Date: 06/22/2009 16:45:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientAdmissionDetails]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientAdmissionDetails]
GO


/****** Object:  Table [dbo].[KnowledgeOfService]    Script Date: 06/22/2009 16:46:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KnowledgeOfService]') AND type in (N'U'))
DROP TABLE [dbo].[KnowledgeOfService]
GO


/****** Object:  Table [dbo].[ModeofOxygenDelivery]    Script Date: 06/22/2009 16:47:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModeofOxygenDelivery]') AND type in (N'U'))
DROP TABLE [dbo].[ModeofOxygenDelivery]
GO

/****** Object:  Table [dbo].[Organ]    Script Date: 06/22/2009 16:47:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Organ]') AND type in (N'U'))
DROP TABLE [dbo].[Organ]
GO

/****** Object:  Table [dbo].[OrganRegWithMapping]    Script Date: 06/22/2009 16:48:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrganRegWithMapping]') AND type in (N'U'))
DROP TABLE [dbo].[OrganRegWithMapping]
GO


/****** Object:  Table [dbo].[OrgDietPatternMapping]    Script Date: 06/22/2009 16:48:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrgDietPatternMapping]') AND type in (N'U'))
DROP TABLE [dbo].[OrgDietPatternMapping]
GO


/****** Object:  Table [dbo].[OrgDietPlanMapping]    Script Date: 06/22/2009 16:48:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrgDietPlanMapping]') AND type in (N'U'))
DROP TABLE [dbo].[OrgDietPlanMapping]
GO


/****** Object:  Table [dbo].[OrgDietTypeMapping]    Script Date: 06/22/2009 16:49:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrgDietTypeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[OrgDietTypeMapping]
GO

/****** Object:  Table [dbo].[PatientDietSpecification]    Script Date: 06/22/2009 16:49:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDietSpecification]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDietSpecification]
GO
/****** Object:  Table [dbo].[PatientEmployer]    Script Date: 06/22/2009 16:50:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientEmployer]') AND type in (N'U'))
DROP TABLE [dbo].[PatientEmployer]
GO
/****** Object:  Table [dbo].[PurposeOfAdmission]    Script Date: 06/22/2009 16:50:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurposeOfAdmission]') AND type in (N'U'))
DROP TABLE [dbo].[PurposeOfAdmission]
GO

/****** Object:  Table [dbo].[Vaccination]    Script Date: 06/25/2009 10:33:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vaccination]') AND type in (N'U'))
DROP TABLE [dbo].[Vaccination]
GO

/****** Object:  Table [dbo].[ModeOfDelivery]    Script Date: 06/25/2009 10:34:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModeOfDelivery]') AND type in (N'U'))
DROP TABLE [dbo].[ModeOfDelivery]
GO

/****** Object:  Table [dbo].[BirthMaturity]    Script Date: 06/25/2009 10:34:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BirthMaturity]') AND type in (N'U'))
DROP TABLE [dbo].[BirthMaturity]
GO

/****** Object:  Table [dbo].[PlacentalPositions]    Script Date: 06/25/2009 10:35:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlacentalPositions]') AND type in (N'U'))
DROP TABLE [dbo].[PlacentalPositions]
GO

/****** Object:  Table [dbo].[VitalsPageOptions]    Script Date: 06/25/2009 10:36:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VitalsPageOptions]') AND type in (N'U'))
DROP TABLE [dbo].[VitalsPageOptions]
GO

/****** Object:  Table [dbo].[SpecialityComplication]    Script Date: 06/25/2009 15:03:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialityComplication]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialityComplication]
GO

/****** Object:  Table [dbo].[SpecialityComplaint]    Script Date: 06/25/2009 15:03:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialityComplaint]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialityComplaint]
GO

/****** Object:  Table [dbo].[ComplaintComplication]    Script Date: 06/25/2009 15:07:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintComplication]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintComplication]
GO

/****** Object:  Table [dbo].[FetalPresentations]    Script Date: 06/25/2009 15:30:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FetalPresentations]') AND type in (N'U'))
DROP TABLE [dbo].[FetalPresentations]
GO

/****** Object:  Table [dbo].[FetalPosition]    Script Date: 06/25/2009 15:31:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FetalPosition]') AND type in (N'U'))
DROP TABLE [dbo].[FetalPosition]
GO

/****** Object:  Table [dbo].[FetalMovements]    Script Date: 06/25/2009 15:31:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FetalMovements]') AND type in (N'U'))
DROP TABLE [dbo].[FetalMovements]
GO

/****** Object:  Table [dbo].[FetalFHS]    Script Date: 06/25/2009 15:32:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FetalFHS]') AND type in (N'U'))
DROP TABLE [dbo].[FetalFHS]
GO

/****** Object:  Table [dbo].[AdvancePaidDetails]    Script Date: 06/27/2009 12:10:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AdvancePaidDetails]') AND type in (N'U'))
DROP TABLE [dbo].[AdvancePaidDetails]
GO


/****** Object:  Table [dbo].[MedicalIndents]    Script Date: 06/27/2009 12:11:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalIndents]') AND type in (N'U'))
DROP TABLE [dbo].[MedicalIndents]
GO

/****** Object:  Table [dbo].[PatientConsultation]    Script Date: 06/27/2009 12:12:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientConsultation]') AND type in (N'U'))
DROP TABLE [dbo].[PatientConsultation]
GO

/****** Object:  Table [dbo].[PatientDueChart]    Script Date: 07/13/2009 19:48:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDueChart]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDueChart]
GO

/****** Object:  Table [dbo].[PatientIndents]    Script Date: 06/27/2009 12:13:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientIndents]') AND type in (N'U'))
DROP TABLE [dbo].[PatientIndents]
GO

/****** Object:  Table [dbo].[PatientProcedure]    Script Date: 06/27/2009 12:14:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientProcedure]') AND type in (N'U'))
DROP TABLE [dbo].[PatientProcedure]
GO

/****** Object:  Table [dbo].[IPIntermediatePayments]    Script Date: 07/01/2009 14:36:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IPIntermediatePayments]') AND type in (N'U'))
DROP TABLE [dbo].[IPIntermediatePayments]
GO

/****** Object:  Table [dbo].[IpPayments]    Script Date: 07/02/2009 11:42:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IpPayments]') AND type in (N'U'))
DROP TABLE [dbo].[IpPayments]
GO


/****** Object:  Table [dbo].[IPPaymentsRoleMapping]    Script Date: 07/02/2009 11:52:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IPPaymentsRoleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[IPPaymentsRoleMapping]
GO


/****** Object:  Table [dbo].[InvReportMaster]    Script Date: 07/22/2009 20:16:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvReportMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvReportMaster]
GO

/****** Object:  Table [dbo].[InvReportMapping]    Script Date: 07/22/2009 20:17:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvReportMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvReportMapping]
GO

/****** Object:  Table [dbo].[ScheduleException]    Script Date: 07/27/2009 11:58:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ScheduleException]') AND type in (N'U'))
DROP TABLE [dbo].[ScheduleException]
GO


/****** Object:  Table [dbo].[PhysicianVacationDetails]    Script Date: 07/28/2009 16:21:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianVacationDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianVacationDetails]
GO

/****** Object:  Table [dbo].[GPALDetails]    Script Date: 08/09/2009 16:01:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GPALDetails]') AND type in (N'U'))
DROP TABLE [dbo].[GPALDetails]
GO

/****** Object:  Table [dbo].[ANCPatientDetails]    Script Date: 08/09/2009 16:01:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ANCPatientDetails]') AND type in (N'U'))
DROP TABLE [dbo].[ANCPatientDetails]
GO

/****** Object:  Table [dbo].[PatientUltraSoundData]    Script Date: 08/09/2009 16:02:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientUltraSoundData]') AND type in (N'U'))
DROP TABLE [dbo].[PatientUltraSoundData]
GO

/****** Object:  Table [dbo].[PatientPastComplication]    Script Date: 08/09/2009 16:04:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientPastComplication]') AND type in (N'U'))
DROP TABLE [dbo].[PatientPastComplication]
GO

/****** Object:  Table [dbo].[PatientPastVaccinationHistory]    Script Date: 08/09/2009 16:05:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientPastVaccinationHistory]') AND type in (N'U'))
DROP TABLE [dbo].[PatientPastVaccinationHistory]
GO

/****** Object:  Table [dbo].[PatientVaccinationHistory]    Script Date: 08/09/2009 16:06:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientVaccinationHistory]') AND type in (N'U'))
DROP TABLE [dbo].[PatientVaccinationHistory]
GO

/****** Object:  Table [dbo].[PatientFetalFindings]    Script Date: 08/09/2009 16:07:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientFetalFindings]') AND type in (N'U'))
DROP TABLE [dbo].[PatientFetalFindings]
GO

/****** Object:  Table [dbo].[PatienttoScanforANC]    Script Date: 08/09/2009 16:11:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatienttoScanforANC]') AND type in (N'U'))
DROP TABLE [dbo].[PatienttoScanforANC]
GO

/****** Object:  Table [dbo].[ANCAdvice]    Script Date: 07/28/2009 19:36:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ANCAdvice]') AND type in (N'U'))
DROP TABLE [dbo].[ANCAdvice]
GO

/****** Object:  Table [dbo].[ANCAlerts]    Script Date: 07/28/2009 19:37:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ANCAlerts]') AND type in (N'U'))
DROP TABLE [dbo].[ANCAlerts]
GO

/****** Object:  Table [dbo].[FeeTypeConfig]    Script Date: 07/31/2009 17:25:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FeeTypeConfig]') AND type in (N'U'))
DROP TABLE [dbo].[FeeTypeConfig]
GO

/****** Object:  Table [dbo].[IpInvSampleCollectionMaster]    Script Date: 08/10/2009 22:43:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IpInvSampleCollectionMaster]') AND type in (N'U'))
DROP TABLE [dbo].[IpInvSampleCollectionMaster]
GO

/****** Object:  Table [dbo].[CashOutFlow]    Script Date: 08/03/2009 18:10:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashOutFlow]') AND type in (N'U'))
DROP TABLE [dbo].[CashOutFlow]
GO

/****** Object:  Table [dbo].[RTAMLCDetails]    Script Date: 08/22/2009 16:23:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RTAMLCDetails]') AND type in (N'U'))
DROP TABLE [dbo].[RTAMLCDetails]
GO

/****** Object:  Table [dbo].[IPTreatmentPlan]    Script Date: 08/22/2009 16:24:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IPTreatmentPlan]') AND type in (N'U'))
DROP TABLE [dbo].[IPTreatmentPlan]
GO

/****** Object:  Table [dbo].[IPTreatmentPlanMaster]    Script Date: 08/22/2009 16:25:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IPTreatmentPlanMaster]') AND type in (N'U'))
DROP TABLE [dbo].[IPTreatmentPlanMaster]
GO

/****** Object:  Table [dbo].[IPComplaint]    Script Date: 08/22/2009 16:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IPComplaint]') AND type in (N'U'))
DROP TABLE [dbo].[IPComplaint]
GO

/****** Object:  Table [dbo].[CorporateMaster]    Script Date: 08/24/2009 10:15:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CorporateMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CorporateMaster]
GO

/****** Object:  Table [dbo].[PatientTreatmentProcedure]    Script Date: 08/27/2009 16:43:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientTreatmentProcedure]') AND type in (N'U'))
DROP TABLE [dbo].[PatientTreatmentProcedure]
GO


/****** Object:  Table [dbo].[CashExpenseMaster]    Script Date: 08/29/2009 19:27:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashExpenseMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CashExpenseMaster]
GO


GO

/****** Object:  Table [dbo].[RoomFeeType]    Script Date: 08/29/2009 19:11:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomFeeType]') AND type in (N'U'))
DROP TABLE [dbo].[RoomFeeType]
GO

/****** Object:  Table [dbo].[RoomTypeFeeMapping]    Script Date: 08/29/2009 19:12:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomTypeFeeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[RoomTypeFeeMapping]
GO

/****** Object:  Table [dbo].[ComplaintVaccination]    Script Date: 09/11/2009 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintVaccination]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintVaccination]
GO

/****** Object:  Table [dbo].[PatientBabyVaccination]    Script Date: 09/11/2009 17:32:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientBabyVaccination]') AND type in (N'U'))
DROP TABLE [dbo].[PatientBabyVaccination]
GO

/****** Object:  Table [dbo].[TaskDependency]    Script Date: 10/03/2009 15:41:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskDependency]') AND type in (N'U'))
DROP TABLE [dbo].[TaskDependency]
GO

/****** Object:  Table [dbo].[OperationComplication]    Script Date: 10/09/2009 11:01:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationComplication]') AND type in (N'U'))
DROP TABLE [dbo].[OperationComplication]
GO

/****** Object:  Table [dbo].[OperationFinding]    Script Date: 10/09/2009 11:02:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationFinding]') AND type in (N'U'))
DROP TABLE [dbo].[OperationFinding]
GO

/****** Object:  Table [dbo].[OperationNotes]    Script Date: 10/09/2009 11:02:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationNotes]') AND type in (N'U'))
DROP TABLE [dbo].[OperationNotes]
GO



/****** Object:  Table [dbo].[OperationStaff]    Script Date: 10/09/2009 11:03:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationStaff]') AND type in (N'U'))
DROP TABLE [dbo].[OperationStaff]
GO


/****** Object:  Table [dbo].[OperationType]    Script Date: 10/09/2009 11:03:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OperationType]') AND type in (N'U'))
DROP TABLE [dbo].[OperationType]
GO

/****** Object:  Table [dbo].[AHPStaff]    Script Date: 10/09/2009 11:04:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AHPStaff]') AND type in (N'U'))
DROP TABLE [dbo].[AHPStaff]
GO


/****** Object:  Table [dbo].[AHPStaffType]    Script Date: 10/09/2009 11:04:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AHPStaffType]') AND type in (N'U'))
DROP TABLE [dbo].[AHPStaffType]
GO

/****** Object:  Table [dbo].[AnesthesiaType]    Script Date: 10/09/2009 11:05:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnesthesiaType]') AND type in (N'U'))
DROP TABLE [dbo].[AnesthesiaType]
GO


/****** Object:  Table [dbo].[SurgeryType]    Script Date: 10/09/2009 11:05:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryType]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryType]
GO

/****** Object:  Table [dbo].[DischargeSummary]    Script Date: 10/09/2009 12:32:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DischargeSummary]') AND type in (N'U'))
DROP TABLE [dbo].[DischargeSummary]
GO

/****** Object:  Table [dbo].[Banners]    Script Date: 10/10/2009 15:52:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Banners]') AND type in (N'U'))
DROP TABLE [dbo].[Banners]
GO

/****** Object:  Table [dbo].[BannerRoleMapping]    Script Date: 10/10/2009 15:51:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BannerRoleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[BannerRoleMapping]
GO

/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/23/2009 13:10:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Suppliers]') AND type in (N'U'))
DROP TABLE [dbo].[Suppliers]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductCategories]') AND type in (N'U'))
DROP TABLE [dbo].[ProductCategories]
GO



/****** Object:  Table [dbo].[Products]    Script Date: 10/23/2009 13:15:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO


GO
/****** Object:  Table [dbo].[StockReceived]    Script Date: 10/23/2009 13:16:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceived]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceived]
GO



/****** Object:  Table [dbo].[PurchaseOrders]    Script Date: 10/23/2009 13:17:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrders]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrders]
GO



/****** Object:  Table [dbo].[PurchaseOrderDetails]    Script Date: 10/23/2009 13:18:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrderDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrderDetails]
GO


/****** Object:  Table [dbo].[InventoryIDMaster]    Script Date: 10/23/2009 13:22:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryIDMaster]
GO


/****** Object:  Table [dbo].[InventoryUOM]    Script Date: 10/23/2009 13:23:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryUOM]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryUOM]
GO



IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockReceived]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockReceived]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockIssued]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockIssued]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockReturn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockReturn]
END

GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockInHand_TotalStockDamage]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockInHand] DROP CONSTRAINT [DF_StockInHand_TotalStockDamage]
END

GO


/****** Object:  Table [dbo].[StockInHand]    Script Date: 10/23/2009 13:25:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockInHand]') AND type in (N'U'))
DROP TABLE [dbo].[StockInHand]
GO

/****** Object:  Table [dbo].[StockOutFlow]    Script Date: 10/23/2009 13:27:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutFlow]') AND type in (N'U'))
DROP TABLE [dbo].[StockOutFlow]
GO

/****** Object:  Table [dbo].[StockOutFlowDetails]    Script Date: 10/23/2009 13:28:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutFlowDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockOutFlowDetails]
GO

/****** Object:  Table [dbo].[StockOutFlowTypes]    Script Date: 10/23/2009 13:29:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockOutFlowTypes]') AND type in (N'U'))
DROP TABLE [dbo].[StockOutFlowTypes]
GO

/****** Object:  Table [dbo].[StockReceivedDetails]    Script Date: 10/23/2009 13:31:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedDetails]
GO
/****** Object:  Table [dbo].[StockUsage]    Script Date: 10/23/2009 13:32:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockUsage]') AND type in (N'U'))
DROP TABLE [dbo].[StockUsage]
GO
/****** Object:  Table [dbo].[StockUsageDetails]    Script Date: 10/23/2009 13:33:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockUsageDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockUsageDetails]
GO
/****** Object:  Table [dbo].[DeptCategories]    Script Date: 10/23/2009 15:44:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeptCategories]') AND type in (N'U'))
DROP TABLE [dbo].[DeptCategories]
GO

/****** Object:  Table [dbo].[DrugAdministration]    Script Date: 11/04/2009 16:35:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DrugAdministration]') AND type in (N'U'))
DROP TABLE [dbo].[DrugAdministration]
GO

/****** Object:  Table [dbo].[InvClientMaster]    Script Date: 11/12/2009 20:25:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvClientMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvClientMaster]
GO


/****** Object:  Table [dbo].[TrustedOrgs]    Script Date: 11/17/2009 03:10:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TrustedOrgs]') AND type in (N'U'))
DROP TABLE [dbo].[TrustedOrgs]
GO

/****** Object:  Table [dbo].[TrustedOrgRequest]    Script Date: 11/30/2009 11:23:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TrustedOrgRequest]') AND type in (N'U'))
DROP TABLE [dbo].[TrustedOrgRequest]
GO

/****** Object:  Table [dbo].[TrustedOrgDetails]    Script Date: 11/30/2009 11:24:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TrustedOrgDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TrustedOrgDetails]
GO

/****** Object:  Table [dbo].[SharingType]    Script Date: 11/30/2009 11:24:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SharingType]') AND type in (N'U'))
DROP TABLE [dbo].[SharingType]
GO

/****** Object:  Table [dbo].[RoleSharing]    Script Date: 11/30/2009 11:25:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleSharing]') AND type in (N'U'))
DROP TABLE [dbo].[RoleSharing]
GO

/****** Object:  Table [dbo].[OrderedInvestigations]    Script Date: 11/30/2009 11:58:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderedInvestigations]') AND type in (N'U'))
DROP TABLE [dbo].[OrderedInvestigations]
GO

/****** Object:  Table [dbo].[LabVisitDetails]    Script Date: 11/30/2009 12:13:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabVisitDetails]') AND type in (N'U'))
DROP TABLE [dbo].[LabVisitDetails]
GO

/****** Object:  Table [dbo].[InvDeptSamples]    Script Date: 11/30/2009 12:14:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvDeptSamples]') AND type in (N'U'))
DROP TABLE [dbo].[InvDeptSamples]
GO

/****** Object:  Table [dbo].[PriorityMaster]    Script Date: 11/30/2009 12:20:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriorityMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PriorityMaster]
GO

/****** Object:  Table [dbo].[CollectionCentreMaster]    Script Date: 11/30/2009 12:21:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CollectionCentreMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CollectionCentreMaster]
GO

/****** Object:  Table [dbo].[PatientInvSampleMapping]    Script Date: 11/30/2009 12:48:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvSampleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvSampleMapping]
GO

/****** Object:  Table [dbo].[PerformingPhysician]    Script Date: 11/30/2009 13:04:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PerformingPhysician]') AND type in (N'U'))
DROP TABLE [dbo].[PerformingPhysician]
GO

/****** Object:  Table [dbo].[InvResultTemplate]    Script Date: 11/30/2009 13:05:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvResultTemplate]') AND type in (N'U'))
DROP TABLE [dbo].[InvResultTemplate]
GO

/****** Object:  Table [dbo].[InvKitMaster]    Script Date: 11/30/2009 13:33:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvKitMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvKitMaster]
GO

/****** Object:  Table [dbo].[InvInstrumentMaster]    Script Date: 11/30/2009 13:34:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvInstrumentMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvInstrumentMaster]
GO

/****** Object:  Table [dbo].[URNof]    Script Date: 11/30/2009 19:41:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[URNof]') AND type in (N'U'))
DROP TABLE [dbo].[URNof]
GO

/****** Object:  Table [dbo].[URNTypes]    Script Date: 11/30/2009 19:41:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[URNTypes]') AND type in (N'U'))
DROP TABLE [dbo].[URNTypes]
GO

/****** Object:  Table [dbo].[Referrals]    Script Date: 11/30/2009 19:43:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Referrals]') AND type in (N'U'))
DROP TABLE [dbo].[Referrals]
GO

/****** Object:  Table [dbo].[ReferralActionOption]    Script Date: 11/30/2009 19:46:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferralActionOption]') AND type in (N'U'))
DROP TABLE [dbo].[ReferralActionOption]
GO

/****** Object:  Table [dbo].[SearchTypeMaster]    Script Date: 12/05/2009 18:18:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[SearchTypeMaster]
GO

/****** Object:  Table [dbo].[ActionMaster]    Script Date: 12/05/2009 18:19:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActionMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ActionMaster]
GO

/****** Object:  Table [dbo].[ActionRoleMapping]    Script Date: 12/05/2009 18:20:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActionRoleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ActionRoleMapping]
GO

/****** Object:  Table [dbo].[ReferralDetails]    Script Date: 12/07/2009 15:14:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferralDetails]') AND type in (N'U'))
DROP TABLE [dbo].[ReferralDetails]
GO

/****** Object:  Table [dbo].[PageActionMaster]    Script Date: 12/08/2009 20:04:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageActionMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PageActionMaster]
GO

/****** Object:  Table [dbo].[PageActionMapping]    Script Date: 12/08/2009 20:05:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageActionMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PageActionMapping]
GO

/****** Object:  Table [dbo].[PageViewMapping]    Script Date: 12/08/2009 20:05:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageViewMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PageViewMapping]
GO
GO


/****** Object:  Table [dbo].[SurgeryBillingDetails]    Script Date: 12/08/2009 15:19:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryBillingDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryBillingDetails]
GO

/****** Object:  Table [dbo].[SurgeryBillingMaster]    Script Date: 12/08/2009 15:19:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryBillingMaster]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryBillingMaster]
GO


/****** Object:  Table [dbo].[Blob]    Script Date: 12/08/2009 14:41:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Blob]') AND type in (N'U'))
DROP TABLE [dbo].[Blob]
GO


/****** Object:  Table [dbo].[PatientOldNotes]    Script Date: 12/08/2009 14:41:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientOldNotes]') AND type in (N'U'))
DROP TABLE [dbo].[PatientOldNotes]
GO


/****** Object:  Table [dbo].[PatientOldNotesFileMapping]    Script Date: 12/08/2009 14:41:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientOldNotesFileMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PatientOldNotesFileMapping]
GO

/****** Object:  Table [dbo].[Taxmaster]    Script Date: 12/29/2009 11:34:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Taxmaster]') AND type in (N'U'))
DROP TABLE [dbo].[Taxmaster]
GO

/****** Object:  Table [dbo].[TaxBillDetails]    Script Date: 12/29/2009 11:35:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaxBillDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TaxBillDetails]
GO

/****** Object:  Table [dbo].[KnowledgeOrgMapping]    Script Date: 01/08/2010 11:29:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KnowledgeOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[KnowledgeOrgMapping]
GO

/****** Object:  Table [dbo].[KnowledgeOfServiceAttributes]    Script Date: 01/08/2010 11:29:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KnowledgeOfServiceAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[KnowledgeOfServiceAttributes]
GO

/****** Object:  Table [dbo].[VisitKnowledgeMapping]    Script Date: 01/08/2010 11:30:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitKnowledgeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[VisitKnowledgeMapping]
GO

/****** Object:  Table [dbo].[HistoryAttribute]    Script Date: 01/15/2010 20:01:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistoryAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[HistoryAttribute]
GO

/****** Object:  Table [dbo].[AttributeValues]    Script Date: 01/15/2010 20:02:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeValues]') AND type in (N'U'))
DROP TABLE [dbo].[AttributeValues]
GO

/****** Object:  Table [dbo].[PatientHistoryAttribute]    Script Date: 01/15/2010 20:03:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientHistoryAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[PatientHistoryAttribute]
GO

/****** Object:  Table [dbo].[ComplaintAttribute]    Script Date: 01/11/2010 19:02:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintAttribute]
GO

/****** Object:  Table [dbo].[ComplaintAttributeValues]    Script Date: 01/11/2010 19:03:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComplaintAttributeValues]') AND type in (N'U'))
DROP TABLE [dbo].[ComplaintAttributeValues]
GO

/****** Object:  Table [dbo].[PatientComplaintAttribute]    Script Date: 01/11/2010 19:04:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientComplaintAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[PatientComplaintAttribute]
GO

/****** Object:  Table [dbo].[SurgicalDetail]    Script Date: 01/11/2010 19:06:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgicalDetail]') AND type in (N'U'))
DROP TABLE [dbo].[SurgicalDetail]
GO



/****** Object:  Table [dbo].[VitalsType]    Script Date: 01/23/2010 12:21:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VitalsType]') AND type in (N'U'))
DROP TABLE [dbo].[VitalsType]
GO



/****** Object:  Table [dbo].[InvPrincipleMaster]    Script Date: 01/23/2010 14:41:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvPrincipleMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvPrincipleMaster]
GO


/****** Object:  Table [dbo].[PatientExaminationAttribute]    Script Date: 02/05/2010 19:39:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientExaminationAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[PatientExaminationAttribute]
GO


/****** Object:  Table [dbo].[ExaminationAttribute]    Script Date: 02/05/2010 19:41:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExaminationAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[ExaminationAttribute]
GO


/****** Object:  Table [dbo].[ExaminationAttributeValues]    Script Date: 02/05/2010 19:42:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExaminationAttributeValues]') AND type in (N'U'))
DROP TABLE [dbo].[ExaminationAttributeValues]
GO

/****** Object:  Table [dbo].[InvPackageMapping]    Script Date: 02/05/2010 23:39:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvPackageMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvPackageMapping]
GO

/****** Object:  StoredProcedure [dbo].[pGetPatientHistoryPKGEdit]    Script Date: 02/06/2010 00:01:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetPatientHistoryPKGEdit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetPatientHistoryPKGEdit]
GO

/****** Object:  Table [dbo].[PatientRecommendation]    Script Date: 02/06/2010 12:06:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientRecommendation]') AND type in (N'U'))
DROP TABLE [dbo].[PatientRecommendation]
GO

/****** Object:  Table [dbo].[InventoryConfig]    Script Date: 02/06/2010 12:06:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryConfig]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryConfig]
GO

/****** Object:  Table [dbo].[StockStatus]    Script Date: 02/06/2010 12:06:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockStatus]') AND type in (N'U'))
DROP TABLE [dbo].[StockStatus]
GO


/****** Object:  Table [dbo].[StockType]    Script Date: 02/06/2010 12:06:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockType]') AND type in (N'U'))
DROP TABLE [dbo].[StockType]
GO



/****** Object:  Table [dbo].[InvStatusmapping]    Script Date: 02/11/2010 19:35:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvStatusmapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvStatusmapping]
GO

/****** Object:  Table [dbo].[PatientRecommendationDtls]    Script Date: 02/06/2010 12:06:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientRecommendationDtls]') AND type in (N'U'))
DROP TABLE [dbo].[PatientRecommendationDtls]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientAllergies]') AND type in (N'U'))
DROP TABLE [dbo].[PatientAllergies]
GO


GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[racemaster]') AND type in (N'U'))
DROP TABLE [dbo].[racemaster]
GO


GO


/****** Object:  Table [dbo].[Diagnostics]    Script Date: 02/15/2010 19:39:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diagnostics]') AND type in (N'U'))
DROP TABLE [dbo].[Diagnostics]
GO


/****** Object:  Table [dbo].[DiagnosticsAttribute]    Script Date: 02/15/2010 19:40:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiagnosticsAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[DiagnosticsAttribute]
GO


/****** Object:  Table [dbo].[DiagnosticsAttributeValues]    Script Date: 02/15/2010 19:41:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiagnosticsAttributeValues]') AND type in (N'U'))
DROP TABLE [dbo].[DiagnosticsAttributeValues]
GO


/****** Object:  Table [dbo].[PatientDiagnostics]    Script Date: 02/15/2010 19:42:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDiagnostics]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDiagnostics]
GO


/****** Object:  Table [dbo].[PatientDiagnosticsAttribute]    Script Date: 02/15/2010 19:43:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDiagnosticsAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDiagnosticsAttribute]
GO

/****** Object:  Table [dbo].[PatDtlsVPAction]    Script Date: 02/18/2010 12:25:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatDtlsVPAction]') AND type in (N'U'))
DROP TABLE [dbo].[PatDtlsVPAction]
GO

/****** Object:  Table [dbo].[PatDtlsVPActionMapping]    Script Date: 02/18/2010 12:26:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatDtlsVPActionMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PatDtlsVPActionMapping]
GO

/****** Object:  Table [dbo].[PatientAllergies]   Script Date: 02/18/2010 12:26:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientAllergies]') AND type in (N'U'))
DROP TABLE [dbo].[PatientAllergies]
GO

/****** Object:  Table [dbo].[PayerMaster]    Script Date: 02/20/2010 17:09:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PayerMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PayerMaster]
GO

/****** Object:  Table [dbo].[PCClientMapping]    Script Date: 02/20/2010 17:08:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PCClientMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PCClientMapping]
GO


/****** Object:  Table [dbo].[PCCustomPriceMapping]    Script Date: 02/20/2010 17:08:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PCCustomPriceMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PCCustomPriceMapping]
GO
/****** Object:  Table [dbo].[AllergyMaster]    Script Date: 02/27/2010 12:40:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AllergyMaster]') AND type in (N'U'))
DROP TABLE [dbo].[AllergyMaster]
GO

/****** Object:  Table [dbo].[Religion]    Script Date: 03/02/2010 18:25:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Religion]') AND type in (N'U'))
DROP TABLE [dbo].[Religion]
GO

/****** Object:  Table [dbo].[GeneralHealthCheckUpMaster]    Script Date: 03/03/2010 13:03:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeneralHealthCheckUpMaster]') AND type in (N'U'))
DROP TABLE [dbo].[GeneralHealthCheckUpMaster]
GO

/****** Object:  Table [dbo].[CasualtyCharges]    Script Date: 03/07/2010 21:06:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CasualtyCharges]') AND type in (N'U'))
DROP TABLE [dbo].[CasualtyCharges]
GO


/****** Object:  Table [dbo].[RegistrationFeeDetails]    Script Date: 03/08/2010 20:34:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RegistrationFeeDetails]') AND type in (N'U'))
DROP TABLE [dbo].[RegistrationFeeDetails]
GO


/****** Object:  Table [dbo].[Locations]    Script Date: 03/12/2010 17:18:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Locations]') AND type in (N'U'))
DROP TABLE [dbo].[Locations]
GO

/****** Object:  Table [dbo].[LocationType]    Script Date: 03/12/2010 17:19:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocationType]') AND type in (N'U'))
DROP TABLE [dbo].[LocationType]
GO

/****** Object:  Table [dbo].[BillingDetails_Audit]    Script Date: 03/19/2010 14:43:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillingDetails_Audit]') AND type in (N'U'))
DROP TABLE [dbo].[BillingDetails_Audit]
GO

/****** Object:  Table [dbo].[InvReportTemplateFooter]    Script Date: 03/20/2010 11:57:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvReportTemplateFooter]') AND type in (N'U'))
DROP TABLE [dbo].[InvReportTemplateFooter]


GO


/****** Object:  Table [dbo].[PaymentTypeOrgMapping]    Script Date: 03/23/2010 18:27:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaymentTypeOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PaymentTypeOrgMapping]
GO



/****** Object:  Table [dbo].[TPAMaster]    Script Date: 03/25/2010 18:07:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPAMaster]') AND type in (N'U'))
DROP TABLE [dbo].[TPAMaster]
GO

/****** Object:  Table [dbo].[InventoryPageMap]    Script Date: 03/25/2010 18:07:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryPageMap]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryPageMap]
GO

/****** Object:  Table [dbo].[LocationUserMap]    Script Date: 03/25/2010 18:07:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocationUserMap]') AND type in (N'U'))
DROP TABLE [dbo].[LocationUserMap]
GO



/****** Object:  Table [dbo].[InvestigationDrugBrand]    Script Date: 04/01/2010 16:42:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationDrugBrand]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationDrugBrand]
GO


/****** Object:  Table [dbo].[PatientHistoryExt]    Script Date: 04/03/2010 15:52:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientHistoryExt]') AND type in (N'U'))
DROP TABLE [dbo].[PatientHistoryExt]
GO

/****** Object:  Table [dbo].[InPatientNumber]    Script Date: 04/10/2010 19:37:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InPatientNumber]') AND type in (N'U'))
DROP TABLE [dbo].[InPatientNumber]
GO


/****** Object:  Table [dbo].[LabourAndDeliveryNotes]    Script Date: 04/12/2010 19:02:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabourAndDeliveryNotes]') AND type in (N'U'))
DROP TABLE [dbo].[LabourAndDeliveryNotes]
GO



/****** Object:  Table [dbo].[DeliveryTypeMaster]    Script Date: 04/12/2010 19:03:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeliveryTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DeliveryTypeMaster]
GO


/****** Object:  Table [dbo].[NewBornDetails]    Script Date: 04/12/2010 19:04:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NewBornDetails]') AND type in (N'U'))
DROP TABLE [dbo].[NewBornDetails]
GO


/****** Object:  Table [dbo].[BirthInstructions]    Script Date: 04/12/2010 19:04:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BirthInstructions]') AND type in (N'U'))
DROP TABLE [dbo].[BirthInstructions]
GO

/****** Object:  Table [dbo].[DischargeChkLstMaster]    Script Date: 04/15/2010 16:07:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DischargeChkLstMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DischargeChkLstMaster]
GO

/****** Object:  Table [dbo].[PatientDisChkLstMaster]    Script Date: 04/15/2010 16:08:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDisChkLstMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDisChkLstMaster]
GO

/****** Object:  Table [dbo].[PatientDisChkLstDtl]    Script Date: 04/15/2010 16:08:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDisChkLstDtl]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDisChkLstDtl]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RateMaster]') AND type in (N'U'))
DROP TABLE [dbo].[RateMaster]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RateTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[RateTypeMaster]
GO

/****** Object:  Table [dbo].[NeonatalNotes]    Script Date: 05/01/2010 11:17:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NeonatalNotes]') AND type in (N'U'))
DROP TABLE [dbo].[NeonatalNotes]
GO


/****** Object:  Table [dbo].[ProductType]    Script Date: 04/26/2010 16:01:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductType]') AND type in (N'U'))
DROP TABLE [dbo].[ProductType]
GO


/****** Object:  Table [dbo].[Attributes]    Script Date: 04/26/2010 16:03:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attributes]') AND type in (N'U'))
DROP TABLE [dbo].[Attributes]
GO

/****** Object:  Table [dbo].[InventoryWantedList]    Script Date: 04/26/2010 16:03:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryWantedList]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryWantedList]
GO


/****** Object:  Table [dbo].[PrimaryConsultant]    Script Date: 05/10/2010 15:22:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrimaryConsultant]') AND type in (N'U'))
DROP TABLE [dbo].[PrimaryConsultant]
GO


/****** Object:  Table [dbo].[Intend]    Script Date: 05/10/2010 15:22:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Intend]') AND type in (N'U'))
DROP TABLE [dbo].[Intend]
GO

/****** Object:  Table [dbo].[IntendDetail]    Script Date: 05/10/2010 15:22:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendDetail]') AND type in (N'U'))
DROP TABLE [dbo].[IntendDetail]
GO

/****** Object:  Table [dbo].[ProjectionList]    Script Date: 05/10/2010 15:22:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectionList]') AND type in (N'U'))
DROP TABLE [dbo].[ProjectionList]
GO

/****** Object:  Table [dbo].[LocationProductMaping]    Script Date: 05/20/2010 15:24:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LocationProductMaping]') AND type in (N'U'))
DROP TABLE [dbo].[LocationProductMaping]
GO



/****** Object:  Table [dbo].[DeathRegistration]    Script Date: 05/17/2010 12:15:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeathRegistration]') AND type in (N'U'))
DROP TABLE [dbo].[DeathRegistration]
GO


/****** Object:  Table [dbo].[CauseOfDeath]    Script Date: 05/17/2010 12:17:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CauseOfDeath]') AND type in (N'U'))
DROP TABLE [dbo].[CauseOfDeath]
GO

/****** Object:  Table [dbo].[CauseOfDeathMaster]    Script Date: 05/17/2010 12:18:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CauseOfDeathMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CauseOfDeathMaster]
GO


/****** Object:  Table [dbo].[PlaceOfDeath]    Script Date: 05/17/2010 12:19:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlaceOfDeath]') AND type in (N'U'))
DROP TABLE [dbo].[PlaceOfDeath]
GO

/****** Object:  Table [dbo].[TypeOfDeath]    Script Date: 05/17/2010 12:21:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeOfDeath]') AND type in (N'U'))
DROP TABLE [dbo].[TypeOfDeath]
GO


/****** Object:  Table [dbo].[LifeSupportMaster]    Script Date: 05/17/2010 12:26:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LifeSupportMaster]') AND type in (N'U'))
DROP TABLE [dbo].[LifeSupportMaster]
GO


/****** Object:  Table [dbo].[SurgeryPackageMaster]    Script Date: 05/17/2010 13:18:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryPackageMaster]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryPackageMaster]
GO



/****** Object:  Table [dbo].[SurgeryPackageDetails]    Script Date: 05/17/2010 13:21:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryPackageDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryPackageDetails]
GO

/****** Object:  Table [dbo].[SurgeryPackageTracker]    Script Date: 05/17/2010 13:21:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryPackageTracker]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryPackageTracker]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ambulancedetails]') AND type in (N'U'))
DROP TABLE [dbo].[Ambulancedetails]
GO

/****** Object:  Table [dbo].[TPAPayments]    Script Date: 06/23/2010 19:26:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPAPayments]') AND type in (N'U'))
DROP TABLE [dbo].[TPAPayments]
GO


/****** Object:  Table [dbo].[CashOutFlowDetails]    Script Date: 06/30/2010 18:32:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashOutFlowDetails]') AND type in (N'U'))
DROP TABLE [dbo].[CashOutFlowDetails]
GO



/****** Object:  Table [dbo].[BillTypeMaster]    Script Date: 07/05/2010 18:55:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[BillTypeMaster]
GO

/****** Object:  Table [dbo].[BillConfig]    Script Date: 07/05/2010 18:56:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillConfig]') AND type in (N'U'))
DROP TABLE [dbo].[BillConfig]
GO

/****** Object:  Table [dbo].[PatientConsultingPhysician]    Script Date: 07/13/2010 19:58:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientConsultingPhysician]') AND type in (N'U'))
DROP TABLE [dbo].[PatientConsultingPhysician]
GO

/****** Object:  Table [dbo].[FeeTypeMaster]    Script Date: 07/13/2010 20:00:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FeeTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[FeeTypeMaster]
GO

/****** Object:  Table [dbo].[FeeTypeOrgMapping]    Script Date: 07/13/2010 20:00:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FeeTypeOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[FeeTypeOrgMapping]
GO


/****** Object:  Table [dbo].[OrderedPhysiotherapy]    Script Date: 07/15/2010 10:56:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderedPhysiotherapy]') AND type in (N'U'))
DROP TABLE [dbo].[OrderedPhysiotherapy]
GO


/****** Object:  Table [dbo].[PendingPhysioDetail]    Script Date: 07/15/2010 10:57:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PendingPhysioDetail]') AND type in (N'U'))
DROP TABLE [dbo].[PendingPhysioDetail]
GO

/****** Object:  Table [dbo].[PhysioCompliant]    Script Date: 07/15/2010 10:58:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysioCompliant]') AND type in (N'U'))
DROP TABLE [dbo].[PhysioCompliant]
GO

/****** Object:  Table [dbo].[PatientPhysioDetails]    Script Date: 07/15/2010 14:25:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientPhysioDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientPhysioDetails]
GO

/****** Object:  Table [dbo].[TempStockReceivedDetails]    Script Date: 07/20/2010 17:20:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TempStockReceivedDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TempStockReceivedDetails]
GO

/****** Object:  Table [dbo].[MRDDischargeAnalysis]    Script Date: 07/23/2010 16:38:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MRDDischargeAnalysis]') AND type in (N'U'))
DROP TABLE [dbo].[MRDDischargeAnalysis]
GO

/****** Object:  Table [dbo].[InvQualitativeResultMaster]    Script Date: 07/24/2010 10:24:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvQualitativeResultMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvQualitativeResultMaster]
GO

/****** Object:  Table [dbo].[ICDCodes]    Script Date: 07/31/2010 14:31:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ICDCodes]') AND type in (N'U'))
DROP TABLE [dbo].[ICDCodes]
GO

/****** Object:  Table [dbo].[NewInstanceWaitingCustomers]    Script Date: 08/02/2010 13:04:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NewInstanceWaitingCustomers]') AND type in (N'U'))
DROP TABLE [dbo].[NewInstanceWaitingCustomers]
GO

/****** Object:  Table [dbo].[NewInstanceRoles]    Script Date: 08/02/2010 13:05:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NewInstanceRoles]') AND type in (N'U'))
DROP TABLE [dbo].[NewInstanceRoles]
GO

/****** Object:  Table [dbo].[NewInstanceVisitPurpose]    Script Date: 08/02/2010 13:06:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NewInstanceVisitPurpose]') AND type in (N'U'))
DROP TABLE [dbo].[NewInstanceVisitPurpose]
GO

/****** Object:  Table [dbo].[NewInstanceCreationTracker]    Script Date: 08/02/2010 13:06:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NewInstanceCreationTracker]') AND type in (N'U'))
DROP TABLE [dbo].[NewInstanceCreationTracker]
GO

/****** Object:  Table [dbo].[CommunicableDiseaseMaster]    Script Date: 08/03/2010 16:06:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CommunicableDiseaseMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CommunicableDiseaseMaster]
GO

/****** Object:  Table [dbo].[ConfigOrgMaster]    Script Date: 08/03/2010 16:06:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConfigOrgMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ConfigOrgMaster]
GO


/****** Object:  Table [dbo].[ConfigKeyMaster]    Script Date: 08/03/2010 16:06:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConfigKeyMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ConfigKeyMaster]
GO

/****** Object:  Table [dbo].[ConfigValueMaster]    Script Date: 08/03/2010 16:06:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConfigValueMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ConfigValueMaster]
GO
/****** Object:  Table [dbo].[SearchColumns]    Script Date: 08/03/2010 16:06:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchColumns]') AND type in (N'U'))
DROP TABLE [dbo].[SearchColumns]
GO
/****** Object:  Table [dbo].[DynamicColumnMapping]    Script Date: 08/03/2010 16:06:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DynamicColumnMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DynamicColumnMapping]
GO

/****** Object:  Table [dbo].[PhysicianOrgMapping]    Script Date: 08/03/2010 16:06:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianOrgMapping]
GO


/****** Object:  Table [dbo].[DischargeConfig]    Script Date: 08/12/2010 17:27:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DischargeConfig]') AND type in (N'U'))
DROP TABLE [dbo].[DischargeConfig]
GO


/****** Object:  Table [dbo].[ANCPatientObservation]    Script Date: 08/16/2010 17:53:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ANCPatientObservation]') AND type in (N'U'))
DROP TABLE [dbo].[ANCPatientObservation]
GO

/****** Object:  Table [dbo].[BuildingMaster]    Script Date: 08/16/2010 17:53:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BuildingMaster]') AND type in (N'U'))
DROP TABLE [dbo].[BuildingMaster]
GO

/****** Object:  Table [dbo].[WardMaster]    Script Date: 08/16/2010 17:53:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WardMaster]') AND type in (N'U'))
DROP TABLE [dbo].[WardMaster]
GO


/****** Object:  Table [dbo].[MenuMasterHeader]    Script Date: 09/03/2010 16:50:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MenuMasterHeader]') AND type in (N'U'))
DROP TABLE [dbo].[MenuMasterHeader]
GO

/****** Object:  Table [dbo].[XslBillType]    Script Date: 09/16/2010 15:42:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[XslBillType]') AND type in (N'U'))
DROP TABLE [dbo].[XslBillType]
GO

/****** Object:  Table [dbo].[WriteOffDues]    Script Date: 09/16/2010 15:42:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WriteOffDues]') AND type in (N'U'))
DROP TABLE [dbo].[WriteOffDues]
GO
/****** Object:  Table [dbo].[PatientTPADetails]    Script Date: 09/27/2010 12:29:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientTPADetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientTPADetails]
GO


/****** Object:  Table [dbo].[GeneralAdvice]    Script Date: 09/30/2010 17:41:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeneralAdvice]') AND type in (N'U'))
DROP TABLE [dbo].[GeneralAdvice]
GO

/****** Object:  Table [dbo].[DischargeSummarySeq]    Script Date: 09/30/2010 17:45:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DischargeSummarySeq]') AND type in (N'U'))
DROP TABLE [dbo].[DischargeSummarySeq]
GO

/****** Object:  Table [dbo].[StockReceivedType]    Script Date: 09/30/2010 17:45:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedType]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedType]
GO
/****** Object:  Table [dbo].[ImageServerDetails]    Script Date: 11/06/2010 13:37:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ImageServerDetails]') AND type in (N'U'))
DROP TABLE [dbo].[ImageServerDetails]
GO


/****** Object:  Table [dbo].[NonReimbursableItems]    Script Date: 11/11/2010 11:32:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NonReimbursableItems]') AND type in (N'U'))
DROP TABLE [dbo].[NonReimbursableItems]
GO

/****** Object:  Table [dbo].[CurrencyHistory]    Script Date: 11/18/2010 15:58:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CurrencyHistory]') AND type in (N'U'))
DROP TABLE [dbo].[CurrencyHistory]
GO


/****** Object:  Table [dbo].[CurrencyMaster]    Script Date: 11/18/2010 15:59:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CurrencyMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CurrencyMaster]
GO

/****** Object:  Table [dbo].[CurrencyOrgMapping]    Script Date: 11/18/2010 15:59:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CurrencyOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[CurrencyOrgMapping]
GO

/****** Object:  Table [dbo].[IncomeSourceMaster]    Script Date: 12/08/2010 12:43:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IncomeSourceMaster]') AND type in (N'U'))
DROP TABLE [dbo].[IncomeSourceMaster]
GO

/****** Object:  Table [dbo].[IncSourcePaidDetails]    Script Date: 12/08/2010 12:44:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IncSourcePaidDetails]') AND type in (N'U'))
DROP TABLE [dbo].[IncSourcePaidDetails]
GO


/****** Object:  Table [dbo].[DischargeInvNotes]    Script Date: 12/11/2010 11:57:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DischargeInvNotes]') AND type in (N'U'))
DROP TABLE [dbo].[DischargeInvNotes]
GO

/****** Object:  Table [dbo].[SmartCardHistory]    Script Date: 12/21/2010 20:03:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SmartCardHistory]') AND type in (N'U'))
DROP TABLE [dbo].[SmartCardHistory]
GO

/****** Object:  Table [dbo].[PatientDeposit]    Script Date: 12/23/2010 19:03:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDeposit]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDeposit]
GO

/****** Object:  Table [dbo].[PatientDepositHistory]    Script Date: 12/23/2010 19:38:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDepositHistory]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDepositHistory]
GO


/****** Object:  Table [dbo].[SpecialtyUniqueParts]    Script Date: 12/25/2010 15:13:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialtyUniqueParts]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialtyUniqueParts]
GO

/****** Object:  Table [dbo].[SpecialtyPartMapping]    Script Date: 12/25/2010 15:12:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialtyPartMapping]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialtyPartMapping]
GO

/****** Object:  Table [dbo].[SpecialtyArea]    Script Date: 12/25/2010 15:12:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecialtyArea]') AND type in (N'U'))
DROP TABLE [dbo].[SpecialtyArea]
GO


/****** Object:  Table [dbo].[BodyPartChildItems]    Script Date: 12/25/2010 15:16:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BodyPartChildItems]') AND type in (N'U'))
DROP TABLE [dbo].[BodyPartChildItems]
GO


/****** Object:  Table [dbo].[OrthoPatientDetails]    Script Date: 12/25/2010 15:17:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrthoPatientDetails]') AND type in (N'U'))
DROP TABLE [dbo].[OrthoPatientDetails]
GO


/****** Object:  Table [dbo].[PatientBodyPartDetails]    Script Date: 12/25/2010 15:19:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientBodyPartDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientBodyPartDetails]
GO

/****** Object:  Table [dbo].[PatientOpenWound]    Script Date: 12/25/2010 15:21:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientOpenWound]') AND type in (N'U'))
DROP TABLE [dbo].[PatientOpenWound]
GO

/****** Object:  Table [dbo].[PatientVascularDetails]    Script Date: 12/25/2010 15:22:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientVascularDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientVascularDetails]
GO
/****** Object:  Table [dbo].[PatientNeurologicalDetails]    Script Date: 12/25/2010 15:24:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientNeurologicalDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientNeurologicalDetails]
GO



/****** Object:  Table [dbo].[PatientReflexes]    Script Date: 12/25/2010 15:27:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientReflexes]') AND type in (N'U'))
DROP TABLE [dbo].[PatientReflexes]
GO

/****** Object:  Table [dbo].[PatientMuscleDetail]    Script Date: 12/25/2010 15:29:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientMuscleDetail]') AND type in (N'U'))
DROP TABLE [dbo].[PatientMuscleDetail]
GO

/****** Object:  Table [dbo].[PatientMuscleWasting]    Script Date: 12/25/2010 15:29:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientMuscleWasting]') AND type in (N'U'))
DROP TABLE [dbo].[PatientMuscleWasting]
GO

/****** Object:  Table [dbo].[PatientDepositUsage]    Script Date: 12/28/2010 18:55:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDepositUsage]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDepositUsage]
GO

/****** Object:  Table [dbo].[PaymentBanks]    Script Date: 01/04/2011 14:31:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaymentBanks]') AND type in (N'U'))
DROP TABLE [dbo].[PaymentBanks]
GO

/****** Object:  Table [dbo].[InstrumentationMaster]    Script Date: 01/05/2011 16:21:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstrumentationMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InstrumentationMaster]
GO


/****** Object:  Table [dbo].[InstrumentationOrgMapping]    Script Date: 01/05/2011 16:22:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstrumentationOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InstrumentationOrgMapping]
GO

/****** Object:  Table [dbo].[CommonSurgeryPackage]    Script Date: 01/18/2011 18:12:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CommonSurgeryPackage]') AND type in (N'U'))
DROP TABLE [dbo].[CommonSurgeryPackage]
GO



/****** Object:  Table [dbo].[GeneralBillingMaster]    Script Date: 01/18/2011 18:12:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeneralBillingMaster]') AND type in (N'U'))
DROP TABLE [dbo].[GeneralBillingMaster]
GO
/****** Object:  Table [dbo].[VisitSubType]    Script Date: 01/18/2011 18:12:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitSubType]') AND type in (N'U'))
DROP TABLE [dbo].[VisitSubType]
GO

/****** Object:  Table [dbo].[RateSubTypeMapping]    Script Date: 01/18/2011 18:12:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RateSubTypeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[RateSubTypeMapping]
GO

/****** Object:  Table [dbo].[MedicalIndentMaster]    Script Date: 01/29/2011 13:06:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalIndentMaster]') AND type in (N'U'))
DROP TABLE [dbo].[MedicalIndentMaster]
GO

/****** Object:  Table [dbo].[MedicalIndentMaster]    Script Date: 01/29/2011 13:06:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalIndentMaster]') AND type in (N'U'))
DROP TABLE [dbo].[MedicalIndentMaster]
GO

/****** Object:  Table [dbo].[DueClearanceReference]    Script Date: 01/29/2011 13:06:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DueClearanceReference]') AND type in (N'U'))
DROP TABLE [dbo].[DueClearanceReference]
GO

/****** Object:  Table [dbo].[Theme]    Script Date: 03/08/2011 18:51:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Theme]') AND type in (N'U'))
DROP TABLE [dbo].[Theme]
GO

/****** Object:  Table [dbo].[StockReturn]    Script Date: 03/17/2011 18:51:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReturn]') AND type in (N'U'))
DROP TABLE [dbo].[StockReturn]
GO

/****** Object:  Table [dbo].[StockReturnDetails]    Script Date: 03/17/2011 18:51:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReturnDetails]') AND type in (N'U'))
DROP TABLE [dbo].[StockReturnDetails]
GO

/****** Object:  Table [dbo].[SupplierCreditOrDebitNote]    Script Date: 03/17/2011 18:51:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplierCreditOrDebitNote]') AND type in (N'U'))
DROP TABLE [dbo].[SupplierCreditOrDebitNote]
GO

/****** Object:  Table [dbo].[SupplierCreditOrDebitReference]    Script Date: 03/17/2011 18:51:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplierCreditOrDebitReference]') AND type in (N'U'))
DROP TABLE [dbo].[SupplierCreditOrDebitReference]
GO

/****** Object:  Table [dbo].[PatientDueRefundDetails]    Script Date: 03/22/2011 20:49:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDueRefundDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDueRefundDetails]
GO

/****** Object:  Table [dbo].[DeviceIntegrationOrgMapping]    Script Date: 03/25/2011 18:43:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeviceIntegrationOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DeviceIntegrationOrgMapping]
GO

/******* Object:  Table [dbo].[InvSampleMasterDeviceMapping]    Script Date: 03/25/2011 18:43:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvSampleMasterDeviceMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvSampleMasterDeviceMapping]
GO

/******* Object:  Table [dbo].[CashFlowTransactionDetails]    Script Date: 03/25/2011 18:43:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashFlowTransactionDetails]') AND type in (N'U'))
DROP TABLE [dbo].[CashFlowTransactionDetails]
GO


/****** Object:  Table [dbo].[InvestigationStatusHistory]    Script Date: 05/06/2011 15:10:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationStatusHistory]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationStatusHistory]
GO

/****** Object:  Table [dbo].[GroupInvMappingHistroy]    Script Date: 05/06/2011 15:13:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GroupInvMappingHistroy]') AND type in (N'U'))
DROP TABLE [dbo].[GroupInvMappingHistroy]
GO

/****** Object:  Table [dbo].[PatientDueDetails]    Script Date: 05/07/2011 23:45:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDueDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDueDetails]
GO


/****** Object:  Table [dbo].[CoPaymentDetails]    Script Date: 05/27/2011 19:25:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CoPaymentDetails]') AND type in (N'U'))
DROP TABLE [dbo].[CoPaymentDetails]
GO

/****** Object:  Table [dbo].[ClaimAmountLogic]    Script Date: 05/30/2011 16:30:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClaimAmountLogic]') AND type in (N'U'))
DROP TABLE [dbo].[ClaimAmountLogic]
GO

/****** Object:  Table [dbo].[IntendReceived]    Script Date: 06/23/2011 04:49:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceived]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceived]
GO

/****** Object:  Table [dbo].[IntendReceivedDetail]    Script Date: 06/23/2011 04:49:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceivedDetail]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceivedDetail]
GO
GO

/****** Object:  Table [dbo].[ProductSupplierRateMapping]    Script Date: 07/05/2011 13:26:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductSupplierRateMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ProductSupplierRateMapping]
GO

/****** Object:  Table [dbo].[PurchaseOrderMappingLocation]    Script Date: 07/05/2011 18:01:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrderMappingLocation]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrderMappingLocation]
GO

/****** Object:  Table [dbo].[SOIRateMapping]    Script Date: 07/26/2011 14:17:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SOIRateMapping]') AND type in (N'U'))
DROP TABLE [dbo].[SOIRateMapping]
GO


/****** Object:  Table [dbo].[PatientEpisode]    Script Date: 08/12/2011 09:55:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientEpisode]') AND type in (N'U'))
DROP TABLE [dbo].[PatientEpisode]
GO

/****** Object:  Table [dbo].[Episode]    Script Date: 08/10/2011 16:18:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Episode]') AND type in (N'U'))
DROP TABLE [dbo].[Episode]
GO

/****** Object:  Table [dbo].[EpisodeMapping]    Script Date: 08/11/2011 11:31:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EpisodeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[EpisodeMapping]

GO

/****** Object:  Table [dbo].[ClientFeeTypeRateCustomization]    Script Date: 08/13/2011 13:48:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientFeeTypeRateCustomization]') AND type in (N'U'))
DROP TABLE [dbo].[ClientFeeTypeRateCustomization]
GO



/****** Object:  Table [dbo].[VisitStateChangeLogin]    Script Date: 08/25/2011 17:03:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitStateChangeLogin]') AND type in (N'U'))
DROP TABLE [dbo].[VisitStateChangeLogin]
GO

/****** Object:  Table [dbo].[KitMaster]    Script Date: 08/26/2011 17:41:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitMaster]') AND type in (N'U'))
DROP TABLE [dbo].[KitMaster]
GO


/****** Object:  Table [dbo].[KitPrepMasterDetails]    Script Date: 08/26/2011 18:12:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitPrepMasterDetails]') AND type in (N'U'))
DROP TABLE [dbo].[KitPrepMasterDetails]
GO
/****** Object:  Table [dbo].[KitPrepMaster]    Script Date: 08/26/2011 18:10:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitPrepMaster]') AND type in (N'U'))
DROP TABLE [dbo].[KitPrepMaster]
GO

/****** Object:  Table [dbo].[CashClosureDenominationMaster]    Script Date: 08/29/2011 18:05:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashClosureDenominationMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CashClosureDenominationMaster]
GO

/****** Object:  Table [dbo].[CashClosureDenomination]    Script Date: 08/29/2011 18:05:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashClosureDenomination]') AND type in (N'U'))
DROP TABLE [dbo].[CashClosureDenomination]
GO

/****** Object:  Table [dbo].[UOMSymbols]    Script Date: 09/23/2011 10:57:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UOMSymbols]') AND type in (N'U'))
DROP TABLE [dbo].[UOMSymbols]
GO

/****** Object:  Table [dbo].[CreditLimitHistory]    Script Date: 09/22/2011 12:34:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CreditLimitHistory]') AND type in (N'U'))
DROP TABLE [dbo].[CreditLimitHistory]
GO

/****** Object:  Table [dbo].[DesignationMaster]    Script Date: 11/02/2011 15:37:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DesignationMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DesignationMaster]
GO

/****** Object:  Table [dbo].[RelationshipMaster]    Script Date: 11/02/2011 15:39:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelationshipMaster]') AND type in (N'U'))
DROP TABLE [dbo].[RelationshipMaster]
GO

/****** Object:  Table [dbo].[EmploymentType]    Script Date: 11/02/2011 15:39:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmploymentType]') AND type in (N'U'))
DROP TABLE [dbo].[EmploymentType]
GO

/****** Object:  Table [dbo].[EmployerDeptMaster]    Script Date: 11/02/2011 15:40:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployerDeptMaster]') AND type in (N'U'))
DROP TABLE [dbo].[EmployerDeptMaster]
GO

/****** Object:  Table [dbo].[EmployeeMaster]    Script Date: 11/02/2011 15:42:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeeMaster]
GO

/****** Object:  Table [dbo].[ProcedureMasterMain]    Script Date: 11/26/2011 11:00:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureMasterMain]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureMasterMain]
GO

/****** Object:  Table [dbo].[ProcedureMasterSub]    Script Date: 11/26/2011 11:00:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureMasterSub]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureMasterSub]
GO

/****** Object:  Table [dbo].[RefundAmtDetailsCapture]    Script Date: 11/28/2011 17:08:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RefundAmtDetailsCapture]') AND type in (N'U'))
DROP TABLE [dbo].[RefundAmtDetailsCapture]
GO

/****** Object:  Table [dbo].[SurgeryMaster]    Script Date: 12/06/2011 17:29:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryMaster]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryMaster]
GO

/****** Object:  Table [dbo].[TreatmentPlanName]    Script Date: 12/06/2011 17:28:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TreatmentPlanName]') AND type in (N'U'))
DROP TABLE [dbo].[TreatmentPlanName]
GO

/****** Object:  Table [dbo].[CounsellingName]    Script Date: 12/27/2011 12:28:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CounsellingName]') AND type in (N'U'))
DROP TABLE [dbo].[CounsellingName]
GO

/****** Object:  Table [dbo].[PatientCounselling]    Script Date: 12/27/2011 12:29:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientCounselling]') AND type in (N'U'))
DROP TABLE [dbo].[PatientCounselling]
GO

/****** Object:  Table [dbo].[DiscountReasonMaster]    Script Date: 01/03/2012 17:59:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiscountReasonMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DiscountReasonMaster]
GO

/****** Object:  Table [dbo].[InvestigationOrgMappingHistory]    Script Date: 01/31/2012 12:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationOrgMappingHistory]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationOrgMappingHistory]
GO

/****** Object:  Table [dbo].[PurchaseRequest]    Script Date: 02/13/2012 12:40:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseRequest]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseRequest]
GO
/****** Object:  Table [dbo].[PurchaseRequestDetails]    Script Date: 02/13/2012 12:41:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseRequestDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseRequestDetails]
GO
/****** Object:  Table [dbo].[Audit_ProductSupplierRateMapping]    Script Date: 02/13/2012 13:01:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Audit_ProductSupplierRateMapping]') AND type in (N'U'))
DROP TABLE [dbo].[Audit_ProductSupplierRateMapping]
GO

/****** Object:  Table [dbo].[MasterPatterns]    Script Date: 01/03/2012 17:59:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterPatterns]') AND type in (N'U'))
DROP TABLE [dbo].[MasterPatterns]
GO

/****** Object:  Table [dbo].[MasterCategories]    Script Date: 01/03/2012 17:59:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterCategories]') AND type in (N'U'))
DROP TABLE [dbo].[MasterCategories]
GO

/****** Object:  Table [dbo].[IDPatternMaster]    Script Date: 01/03/2012 17:59:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IDPatternMaster]') AND type in (N'U'))
DROP TABLE [dbo].[IDPatternMaster]
GO

/****** Object:  Table [dbo].[TransBillingDetails]    Script Date: 03/01/2012 11:19:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TransBillingDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TransBillingDetails]
GO
/****** Object:  Table [dbo].[QuotationMaster]    Script Date: 03/20/2012 21:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuotationMaster]') AND type in (N'U'))
DROP TABLE [dbo].[QuotationMaster]
GO
 
 /****** Object:  Table [dbo].[AppearanceMaster]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppearanceMaster]') AND type in (N'U'))
DROP TABLE [dbo].[AppearanceMaster]
GO
/****** Object:  Table [dbo].[BillLineItems]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillLineItems]') AND type in (N'U'))
DROP TABLE [dbo].[BillLineItems]
GO
/****** Object:  Table [dbo].[BillMaster]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillMaster]') AND type in (N'U'))
DROP TABLE [dbo].[BillMaster]
GO
/****** Object:  Table [dbo].[ClientGeneralBillingItemsMapping]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientGeneralBillingItemsMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ClientGeneralBillingItemsMapping]
GO
/****** Object:  Table [dbo].[ColorMaster]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ColorMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ColorMaster]
GO
/****** Object:  Table [dbo].[ColumnListForTables]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ColumnListForTables]') AND type in (N'U'))
DROP TABLE [dbo].[ColumnListForTables]
GO
/****** Object:  Table [dbo].[ConfigOrgMaster_Pulze_Duplicate]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConfigOrgMaster_Pulze_Duplicate]') AND type in (N'U'))
DROP TABLE [dbo].[ConfigOrgMaster_Pulze_Duplicate]
GO
/****** Object:  Table [dbo].[DiscountMaster]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiscountMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DiscountMaster]
GO
/****** Object:  Table [dbo].[EmployerLocationMaster]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployerLocationMaster]') AND type in (N'U'))
DROP TABLE [dbo].[EmployerLocationMaster]
GO
/****** Object:  Table [dbo].[EmployerMaster]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployerMaster]') AND type in (N'U'))
DROP TABLE [dbo].[EmployerMaster]
GO
/****** Object:  Table [dbo].[EmploymentHistory]    Script Date: 03/21/2012 13:05:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmploymentHistory]') AND type in (N'U'))
DROP TABLE [dbo].[EmploymentHistory]
GO
/****** Object:  Table [dbo].[GradeMaster]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GradeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[GradeMaster]
GO
/****** Object:  Table [dbo].[HasErrorLog]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HasErrorLog]') AND type in (N'U'))
DROP TABLE [dbo].[HasErrorLog]
GO
/****** Object:  Table [dbo].[InActiveUsers]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InActiveUsers]') AND type in (N'U'))
DROP TABLE [dbo].[InActiveUsers]
GO
/****** Object:  Table [dbo].[InvClientRateMaster]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvClientRateMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvClientRateMaster]
GO
/****** Object:  Table [dbo].[InvClientType]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvClientType]') AND type in (N'U'))
DROP TABLE [dbo].[InvClientType]
GO
/****** Object:  Table [dbo].[InvestigationImageMaster]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationImageMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationImageMaster]
GO
/****** Object:  Table [dbo].[InvRateMaster]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvRateMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvRateMaster]
GO
/****** Object:  Table [dbo].[KitPatientUsage]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KitPatientUsage]') AND type in (N'U'))
DROP TABLE [dbo].[KitPatientUsage]
GO
/****** Object:  Table [dbo].[Kproducts]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kproducts]') AND type in (N'U'))
DROP TABLE [dbo].[Kproducts]
GO
/****** Object:  Table [dbo].[LabConsumables]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabConsumables]') AND type in (N'U'))
DROP TABLE [dbo].[LabConsumables]
GO
/****** Object:  Table [dbo].[LabReferenceOrg]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabReferenceOrg]') AND type in (N'U'))
DROP TABLE [dbo].[LabReferenceOrg]
GO
/****** Object:  Table [dbo].[LabRefOrgAddress]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabRefOrgAddress]') AND type in (N'U'))
DROP TABLE [dbo].[LabRefOrgAddress]
GO
/****** Object:  Table [dbo].[LabSummaryReportParameter]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabSummaryReportParameter]') AND type in (N'U'))
DROP TABLE [dbo].[LabSummaryReportParameter]
GO
/****** Object:  Table [dbo].[MedicalIndentsClientMapping]    Script Date: 03/21/2012 13:05:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicalIndentsClientMapping]') AND type in (N'U'))
DROP TABLE [dbo].[MedicalIndentsClientMapping]
GO
/****** Object:  Table [dbo].[Modality]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modality]') AND type in (N'U'))
DROP TABLE [dbo].[Modality]
GO
/****** Object:  Table [dbo].[PatientExtendedType]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientExtendedType]') AND type in (N'U'))
DROP TABLE [dbo].[PatientExtendedType]
GO
/****** Object:  Table [dbo].[PatientRelationShip]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientRelationShip]') AND type in (N'U'))
DROP TABLE [dbo].[PatientRelationShip]
GO
/****** Object:  Table [dbo].[PatientTypeMaster]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PatientTypeMaster]
GO
/****** Object:  Table [dbo].[PhysicianClientFee]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhysicianClientFee]') AND type in (N'U'))
DROP TABLE [dbo].[PhysicianClientFee]
GO
/****** Object:  Table [dbo].[ProcedureClientFee]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcedureClientFee]') AND type in (N'U'))
DROP TABLE [dbo].[ProcedureClientFee]
GO
/****** Object:  Table [dbo].[Products_backup]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products_backup]') AND type in (N'U'))
DROP TABLE [dbo].[Products_backup]
GO
/****** Object:  Table [dbo].[PsychiatricReview]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PsychiatricReview]') AND type in (N'U'))
DROP TABLE [dbo].[PsychiatricReview]
GO
/****** Object:  Table [dbo].[PsychiatryAttribute]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PsychiatryAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[PsychiatryAttribute]
GO
/****** Object:  Table [dbo].[PsychiatryExamination]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PsychiatryExamination]') AND type in (N'U'))
DROP TABLE [dbo].[PsychiatryExamination]
GO
/****** Object:  Table [dbo].[PublishingMode]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PublishingMode]') AND type in (N'U'))
DROP TABLE [dbo].[PublishingMode]
GO
/****** Object:  Table [dbo].[Qtb]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Qtb]') AND type in (N'U'))
DROP TABLE [dbo].[Qtb]
GO
/****** Object:  Table [dbo].[ReferingPhysician]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferingPhysician]') AND type in (N'U'))
DROP TABLE [dbo].[ReferingPhysician]
GO
/****** Object:  Table [dbo].[ReferringOrgType]    Script Date: 03/21/2012 13:05:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferringOrgType]') AND type in (N'U'))
DROP TABLE [dbo].[ReferringOrgType]
GO
/****** Object:  Table [dbo].[ResultPublishing]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResultPublishing]') AND type in (N'U'))
DROP TABLE [dbo].[ResultPublishing]
GO
/****** Object:  Table [dbo].[S_MANUFACTURER_MASTER]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[S_MANUFACTURER_MASTER]') AND type in (N'U'))
DROP TABLE [dbo].[S_MANUFACTURER_MASTER]
GO
/****** Object:  Table [dbo].[SearchActions]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SearchActions]') AND type in (N'U'))
DROP TABLE [dbo].[SearchActions]
GO
/****** Object:  Table [dbo].[ShippingAddress]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShippingAddress]') AND type in (N'U'))
DROP TABLE [dbo].[ShippingAddress]
GO
/****** Object:  Table [dbo].[SurgeryOrderedServices]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryOrderedServices]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryOrderedServices]
GO
/****** Object:  Table [dbo].[SurgeryPackageFeeTypeRateMaster]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SurgeryPackageFeeTypeRateMaster]') AND type in (N'U'))
DROP TABLE [dbo].[SurgeryPackageFeeTypeRateMaster]
GO
/****** Object:  Table [dbo].[TablesMigratedWithRecords]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TablesMigratedWithRecords]') AND type in (N'U'))
DROP TABLE [dbo].[TablesMigratedWithRecords]
GO
/****** Object:  Table [dbo].[TablesWithRecords]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TablesWithRecords]') AND type in (N'U'))
DROP TABLE [dbo].[TablesWithRecords]
GO
/****** Object:  Table [dbo].[tblPatientDueMigration]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPatientDueMigration]') AND type in (N'U'))
DROP TABLE [dbo].[tblPatientDueMigration]
GO
/****** Object:  Table [dbo].[TempStock]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TempStock]') AND type in (N'U'))
DROP TABLE [dbo].[TempStock]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Test]') AND type in (N'U'))
DROP TABLE [dbo].[Test]
GO
/****** Object:  Table [dbo].[tproducts]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tproducts]') AND type in (N'U'))
DROP TABLE [dbo].[tproducts]
GO
/****** Object:  Table [dbo].[venkat]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[venkat]') AND type in (N'U'))
DROP TABLE [dbo].[venkat]
GO
/****** Object:  Table [dbo].[VisitIDMaster]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[VisitIDMaster]
GO
/****** Object:  Table [dbo].[VisitSearchActions]    Script Date: 03/21/2012 13:05:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitSearchActions]') AND type in (N'U'))
DROP TABLE [dbo].[VisitSearchActions]
GO
/****** Object:  Table [dbo].[ServiceCodeMapping]    Script Date: 03/21/2012 13:09:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ServiceCodeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ServiceCodeMapping]
GO

/****** Object:  Table [dbo].[TransAmountRefundDetails]    Script Date: 03/21/2012 16:30:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TransAmountRefundDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TransAmountRefundDetails]
GO

/****** Object:  Table [dbo].[TRFfilemanager]    Script Date: 04/04/2012 11:47:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRFfilemanager]') AND type in (N'U'))
DROP TABLE [dbo].[TRFfilemanager]
GO

/****** Object:  Table [dbo].[InvReasonMaster]    Script Date: 06/04/2012 21:47:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvReasonMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvReasonMaster]
GO

/****** Object:  Table [dbo].[InvReasonOrgMapping]    Script Date: 06/04/2012 21:47:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvReasonOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvReasonOrgMapping]
GO

/****** Object:  Table [dbo].[InvStatusOrgPageMapping]    Script Date: 06/04/2012 21:47:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvStatusOrgPageMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvStatusOrgPageMapping]
GO



/****** Object:  Table [dbo].[PatientIdMaster]    Script Date: 04/19/2012 14:48:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PatientIdMaster]
GO

/****** Object:  Table [dbo].[BillIdMaster]    Script Date: 04/19/2012 14:49:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[BillIdMaster]
GO

/****** Object:  Table [dbo].[InpatientIdMaster]    Script Date: 04/19/2012 14:49:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InpatientIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InpatientIdMaster]
GO

/****** Object:  Table [dbo].[VisitNumberMaster]    Script Date: 04/19/2012 14:50:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitNumberMaster]') AND type in (N'U'))
DROP TABLE [dbo].[VisitNumberMaster]
GO

/****** Object:  Table [dbo].[RefundIdMaster]    Script Date: 04/19/2012 14:51:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RefundIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[RefundIdMaster]
GO

/****** Object:  Table [dbo].[ReceiptIdMaster]    Script Date: 04/19/2012 14:51:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReceiptIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ReceiptIdMaster]
GO

/****** Object:  Table [dbo].[VoucherIDMaster]    Script Date: 04/19/2012 14:52:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VoucherIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[VoucherIDMaster]
GO

/****** Object:  Table [dbo].[LabIDMaster]    Script Date: 04/19/2012 14:53:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[LabIDMaster]
GO

/****** Object:  Table [dbo].[RefundvoucherMaster]    Script Date: 04/19/2012 14:54:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RefundvoucherMaster]') AND type in (N'U'))
DROP TABLE [dbo].[RefundvoucherMaster]
GO

/****** Object:  Table [dbo].[URNMaster]    Script Date: 04/19/2012 14:54:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[URNMaster]') AND type in (N'U'))
DROP TABLE [dbo].[URNMaster]
GO

/****** Object:  Table [dbo].[InterimIdMaster]    Script Date: 04/19/2012 14:55:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InterimIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InterimIdMaster]
GO

/****** Object:  Table [dbo].[CopayReceiptIDMaster]    Script Date: 04/19/2012 14:55:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CopayReceiptIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CopayReceiptIDMaster]
GO

/****** Object:  Table [dbo].[CashClosureIdMaster]    Script Date: 04/19/2012 14:56:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CashClosureIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CashClosureIdMaster]
GO

/****** Object:  Table [dbo].[PrescriptionIdMaster]    Script Date: 04/19/2012 14:57:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrescriptionIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PrescriptionIdMaster]
GO

/****** Object:  Table [dbo].[OrderServiceIDMaster]    Script Date: 04/19/2012 14:58:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderServiceIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[OrderServiceIDMaster]
GO

/****** Object:  Table [dbo].[OrderRefundIDMaster]    Script Date: 04/19/2012 14:59:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderRefundIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[OrderRefundIDMaster]
GO

/****** Object:  Table [dbo].[BarcodeIDMaster]    Script Date: 04/19/2012 14:59:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodeIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[BarcodeIDMaster]
GO

/****** Object:  Table [dbo].[BarcodeAttributeMapping]    Script Date: 04/20/2012 20:49:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodeAttributeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[BarcodeAttributeMapping]
GO

/****** Object:  Table [dbo].[BarcodeCategories]    Script Date: 04/20/2012 20:49:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodeCategories]') AND type in (N'U'))
DROP TABLE [dbo].[BarcodeCategories]
GO

/****** Object:  Table [dbo].[BarcodeMainAttributes]    Script Date: 04/20/2012 20:49:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodeMainAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[BarcodeMainAttributes]
GO

/****** Object:  Table [dbo].[BarcodeOrgMapping]    Script Date: 04/20/2012 20:50:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodeOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[BarcodeOrgMapping]
GO

/****** Object:  Table [dbo].[BarcodePlaceHolders]    Script Date: 04/20/2012 20:50:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodePlaceHolders]') AND type in (N'U'))
DROP TABLE [dbo].[BarcodePlaceHolders]
GO

/****** Object:  Table [dbo].[BarcodeSubAttributes]    Script Date: 04/20/2012 20:50:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BarcodeSubAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[BarcodeSubAttributes]
GO

/****** Object:  Table [dbo].[SmartCardMaster]    Script Date: 04/30/2012 14:30:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SmartCardMaster]') AND type in (N'U'))
DROP TABLE [dbo].[SmartCardMaster]
GO
 
/****** Object:  Table [dbo].[CustomerType]    Script Date: 05/02/2012 14:49:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerType]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerType]
GO
 
/****** Object:  Table [dbo].[Customers]    Script Date: 05/02/2012 14:57:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type in (N'U'))
DROP TABLE [dbo].[Customers]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MaritalStatus]') AND type in (N'U'))
DROP TABLE [dbo].[MaritalStatus]
GO
 

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Gender]') AND type in (N'U'))
DROP TABLE [dbo].[Gender]
GO
 

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DateAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[DateAttributes]
GO

/****** Object:  Table [dbo].[CustomPeriodRange]    Script Date: 05/14/2012 13:38:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomPeriodRange]') AND type in (N'U'))
DROP TABLE [dbo].[CustomPeriodRange]
GO



/****** Object:  Table [dbo].[PatientSearchType]    Script Date: 05/14/2012 13:39:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientSearchType]') AND type in (N'U'))
DROP TABLE [dbo].[PatientSearchType]
GO
/****** Object:  Table [dbo].[OtherSearchCriteria]    Script Date: 05/14/2012 13:40:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OtherSearchCriteria]') AND type in (N'U'))
DROP TABLE [dbo].[OtherSearchCriteria]
GO
/****** Object:  Table [dbo].[ClientServiceCodeMapping]    Script Date: 05/15/2012 12:23:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientServiceCodeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ClientServiceCodeMapping]
GO

/****** Object:  Table [dbo].[MetaData]    Script Date: 05/17/2012 11:25:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaData]') AND type in (N'U'))
DROP TABLE [dbo].[MetaData]
GO

/****** Object:  Table [dbo].[InvestigationValueHistory]    Script Date: 05/18/2012 17:49:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationValueHistory]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationValueHistory]
GO

/****** Object:  Table [dbo].[CorporateEmployeeNoMaster]    Script Date: 05/22/2012 14:50:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CorporateEmployeeNoMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CorporateEmployeeNoMaster]
GO


/****** Object:  Table [dbo].[CorporateExternalIDMaster]    Script Date: 05/22/2012 14:50:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CorporateExternalIDMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CorporateExternalIDMaster]
GO

/****** Object:  Table [dbo].[InvestigationLocationMapping]    Script Date: 05/24/2012 14:50:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationLocationMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationLocationMapping]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 05/29/2012 14:10:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type in (N'U'))
DROP TABLE [dbo].[Customers]
GO
/****** Object:  Table [dbo].[CustomerType]    Script Date: 05/29/2012 14:12:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerType]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerType]
GO
/****** Object:  Table [dbo].[SalesOrderOutFlowDetails]    Script Date: 05/29/2012 14:13:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesOrderOutFlowDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SalesOrderOutFlowDetails]
GO



/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 06/01/2012 19:33:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceDetails]') AND type in (N'U'))
DROP TABLE [dbo].[InvoiceDetails]
GO

/****** Object:  Table [dbo].[Invoice]    Script Date: 06/01/2012 19:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__ReportSna__Creat__330913B4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ReportSnapshot] DROP CONSTRAINT [DF__ReportSna__Creat__330913B4]
END
GO

/****** Object:  Table [dbo].[ReportSnapshot]    Script Date: 06/02/2012 20:12:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportSnapshot]') AND type in (N'U'))
DROP TABLE [dbo].[ReportSnapshot]
GO

/****** Object:  Table [dbo].[AuditTransactionDetails]    Script Date: 06/04/2012 11:45:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuditTransactionDetails]') AND type in (N'U'))
DROP TABLE [dbo].[AuditTransactionDetails]
GO

/****** Object:  Table [dbo].[AuditTransaction]    Script Date: 06/04/2012 11:45:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuditTransaction]') AND type in (N'U'))
DROP TABLE [dbo].[AuditTransaction]
GO

/****** Object:  Table [dbo].[PatientInvSampleAliquot]    Script Date: 06/04/2012 11:48:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientInvSampleAliquot]') AND type in (N'U'))
DROP TABLE [dbo].[PatientInvSampleAliquot]
GO

/****** Object:  Table [dbo].[AddressType]    Script Date: 06/16/2012 16:11:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddressType]') AND type in (N'U'))
DROP TABLE [dbo].[AddressType]
GO

/****** Object:  Table [dbo].[DespatchMode]    Script Date: 06/16/2012 16:11:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DespatchMode]') AND type in (N'U'))
DROP TABLE [dbo].[DespatchMode]
GO

/****** Object:  Table [dbo].[SalesReturnDetails]    Script Date: 06/20/2012 19:01:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesReturnDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SalesReturnDetails]
GO
/****** Object:  Table [dbo].[SalesReturn]    Script Date: 06/20/2012 19:01:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalesReturn]') AND type in (N'U'))
DROP TABLE [dbo].[SalesReturn]
GO


/****** Object:  Table [dbo].[PatientProgressive]    Script Date: 06/27/2012 12:41:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientProgressive]') AND type in (N'U'))
DROP TABLE [dbo].[PatientProgressive]
GO

/****** Object:  Table [dbo].[ProgressiveTemplate]    Script Date: 06/27/2012 12:42:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProgressiveTemplate]') AND type in (N'U'))
DROP TABLE [dbo].[ProgressiveTemplate]
GO
/****** Object:  Table [dbo].[Suppliers_HIST]    Script Date: 06/29/2012 19:41:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Suppliers_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[Suppliers_HIST]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails_HIST]    Script Date: 06/29/2012 19:42:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseOrderDetails_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[PurchaseOrderDetails_HIST]
GO
/****** Object:  Table [dbo].[StockInHand_HIST]    Script Date: 06/29/2012 19:42:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockInHand_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[StockInHand_HIST]
GO
/****** Object:  Table [dbo].[StockReceived_HIST]    Script Date: 06/29/2012 19:43:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceived_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceived_HIST]
GO
/****** Object:  Table [dbo].[StockReceivedDetails_HIST]    Script Date: 06/29/2012 19:43:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockReceivedDetails_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[StockReceivedDetails_HIST]
GO

/****** Object:  Table [dbo].[QuotationMaster_HIST]    Script Date: 06/30/2012 01:37:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuotationMaster_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[QuotationMaster_HIST]
GO

/****** Object:  Table [dbo].[ProductSupplierRateMapping_HIST]    Script Date: 06/30/2012 01:37:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductSupplierRateMapping_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[ProductSupplierRateMapping_HIST]
GO

/****** Object:  Table [dbo].[Products_HIST]    Script Date: 06/30/2012 01:37:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[Products_HIST]
GO

/****** Object:  Table [dbo].[EquipmentMaintenanceMaster]    Script Date: 07/02/2012 01:37:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EquipmentMaintenanceMaster]') AND type in (N'U'))
DROP TABLE [dbo].[EquipmentMaintenanceMaster]
GO

/****** Object:  Table [dbo].[ProductMaintenanceRecord]    Script Date: 07/02/2012 01:37:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductMaintenanceRecord]') AND type in (N'U'))
DROP TABLE [dbo].[ProductMaintenanceRecord]
GO


/****** Object:  Table [dbo].[Intend_HIST]    Script Date: 07/02/2012 16:11:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Intend_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[Intend_HIST]
GO
/****** Object:  Table [dbo].[IntendDetail_HIST]    Script Date: 07/02/2012 16:13:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendDetail_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[IntendDetail_HIST]
GO
/****** Object:  Table [dbo].[IntendReceived_HIST]    Script Date: 07/02/2012 16:14:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceived_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceived_HIST]
GO
/****** Object:  Table [dbo].[IntendReceivedDetail_HIST]    Script Date: 07/02/2012 16:14:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntendReceivedDetail_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[IntendReceivedDetail_HIST]
GO

/****** Object:  StoredProcedure [dbo].[pGetAudit_History]    Script Date: 06/29/2012 23:10:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageContext]') AND type in (N'U', N'PC'))
DROP table [dbo].PageContext
GO

/****** Object:  StoredProcedure [dbo].[pGetAudit_History]    Script Date: 06/29/2012 23:10:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PageContextActionMapping]') AND type in (N'U', N'PC'))
DROP table [dbo].PageContextActionMapping
GO

/****** Object:  StoredProcedure [dbo].[ActionManagerType]    Script Date: 06/29/2012 23:10:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActionManagerType]') AND type in (N'U', N'PC'))
DROP table [dbo].[ActionManagerType]
GO


/****** Object:  StoredProcedure [dbo].[ActionManagerTemplateType]    Script Date: 06/29/2012 23:10:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActionManagerTemplateType]') AND type in (N'U', N'PC'))
DROP table [dbo].ActionManagerTemplateType
GO


/****** Object:  StoredProcedure [dbo].[ActionManagerTemplateDetails]    Script Date: 06/29/2012 23:10:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActionTemplateType]') AND type in (N'U', N'PC'))
DROP table [dbo].ActionTemplateType
GO



/****** Object:  StoredProcedure [dbo].[ActionManagerTemplateDetails]    Script Date: 06/29/2012 23:10:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActionTemplate]') AND type in (N'U', N'PC'))
DROP table [dbo].ActionTemplate
GO
/****** Object:  StoredProcedure [dbo].[pSavepatientusagekitproducts]    Script Date: 07/03/2012 20:00:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pSavepatientusagekitproducts]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pSavepatientusagekitproducts]
GO
/****** Object:  StoredProcedure [dbo].[pGetPrintStockusagedetail]    Script Date: 07/03/2012 20:01:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetPrintStockusagedetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[pGetPrintStockusagedetail]
GO


/****** Object:  Table [dbo].[AnesthesiaType]    Script Date: 07/04/2012 10:07:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnesthesiaType]') AND type in (N'U'))
DROP TABLE [dbo].[AnesthesiaType]
GO
/****** Object:  Table [dbo].[AnesthesiaModes]    Script Date: 07/04/2012 10:07:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnesthesiaModes]') AND type in (N'U'))
DROP TABLE [dbo].[AnesthesiaModes]
GO


/****** Object:  Table [dbo].[AnesthesiaDetails]    Script Date: 07/04/2012 10:07:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnesthesiaDetails]') AND type in (N'U'))
DROP TABLE [dbo].[AnesthesiaDetails]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodCapturedDetails]') AND type in (N'U'))
DROP TABLE [dbo].[BloodCapturedDetails]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodGroup]') AND type in (N'U'))
DROP TABLE [dbo].[BloodGroup]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DynamicControls]') AND type in (N'U'))
DROP TABLE [dbo].[DynamicControls]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DonorStatus]') AND type in (N'U'))
DROP TABLE [dbo].[DonorStatus]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodCollectionDetails]') AND type in (N'U'))
DROP TABLE [dbo].[BloodCollectionDetails]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodComponent]') AND type in (N'U'))
DROP TABLE [dbo].[BloodComponent]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodComponentMapping]') AND type in (N'U'))
DROP TABLE [dbo].[BloodComponentMapping]
GO

/****** Object:  Table [dbo].[PasswordPolicy]    Script Date: 07/17/2012 10:22:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PasswordPolicy]') AND type in (N'U'))
DROP TABLE [dbo].[PasswordPolicy]
GO


/****** Object:  Table [dbo].[LoginDeptMap]    Script Date: 07/27/2012 10:59:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginDeptMap]') AND type in (N'U'))
DROP TABLE [dbo].[LoginDeptMap]
GO

/****** Object:  Table [dbo].[LoginLocationMapping]    Script Date: 07/27/2012 10:59:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginLocationMapping]') AND type in (N'U'))
DROP TABLE [dbo].[LoginLocationMapping]
GO

/****** Object:  Table [dbo].[TrustedOrgActions]    Script Date: 07/27/2012 14:48:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TrustedOrgActions]') AND type in (N'U'))
DROP TABLE [dbo].[TrustedOrgActions]
GO

/****** Object:  Table [dbo].[GroupType]    Script Date: 07/31/2012 18:31:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GroupType]') AND type in (N'U'))
DROP TABLE [dbo].[GroupType]
GO
/****** Object:  Table [dbo].[GroupValue]    Script Date: 07/31/2012 18:37:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GroupValue]') AND type in (N'U'))
DROP TABLE [dbo].[GroupValue]
GO

/****** Object:  Table [dbo].[ClientPaymentMode]    Script Date: 07/31/2012 18:41:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientPaymentMode]') AND type in (N'U'))
DROP TABLE [dbo].[ClientPaymentMode]
GO
/****** Object:  Table [dbo].[ClientAttributesDetails]    Script Date: 07/31/2012 18:42:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientAttributesDetails]') AND type in (N'U'))
DROP TABLE [dbo].[ClientAttributesDetails]
GO
/****** Object:  Table [dbo].[ClientAttributes]    Script Date: 07/31/2012 18:43:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[ClientAttributes]
GO
/****** Object:  Table [dbo].[AddressDetails]    Script Date: 07/31/2012 18:45:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddressDetails]') AND type in (N'U'))
DROP TABLE [dbo].[AddressDetails]
GO 
/****** Object:  Table [dbo].[ModuleCategory]    Script Date: 08/07/2012 16:29:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModuleCategory]') AND type in (N'U'))
DROP TABLE [dbo].[ModuleCategory]
GO
/****** Object:  Table [dbo].[Pagesearchtypemapping]    Script Date: 08/07/2012 16:32:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pagesearchtypemapping]') AND type in (N'U'))
DROP TABLE [dbo].[Pagesearchtypemapping]
GO

/****** Object:  Table [dbo].[GroupValueMapping]    Script Date: 08/07/2012 18:13:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GroupValueMapping]') AND type in (N'U'))
DROP TABLE [dbo].[GroupValueMapping]
GO

/****** Object:  Table [dbo].[DiscountPolicy]    Script Date: 08/07/2012 17:24:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiscountPolicy]') AND type in (N'U'))
DROP TABLE [dbo].[DiscountPolicy]
GO

/****** Object:  Table [dbo].[RateRefOrgMapping]    Script Date: 08/08/2012 11:12:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RateRefOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[RateRefOrgMapping]
GO

/****** Object:  Table [dbo].[DeptMaster]    Script Date: 08/10/2012 15:47:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeptMaster]') AND type in (N'U'))
DROP TABLE [dbo].[DeptMaster]
GO

/****** Object:  Table [dbo].[InvestigationProductMapping]    Script Date: 08/31/2012 12:24:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationProductMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationProductMapping]
GO



/****** Object:  Table [dbo].[MetaType_Common]    Script Date: 09/04/2012 10:07:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaType_Common]') AND type in (N'U'))
DROP TABLE [dbo].[MetaType_Common]
GO


/****** Object:  Table [dbo].[MetaValue_Common]    Script Date: 09/04/2012 10:07:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaValue_Common]') AND type in (N'U'))
DROP TABLE [dbo].[MetaValue_Common]
GO


/****** Object:  Table [dbo].[MetaValueMapping]    Script Date: 09/04/2012 10:07:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaValueMapping]') AND type in (N'U'))
DROP TABLE [dbo].[MetaValueMapping]
GO
 
/****** Object:  Table [dbo].[BloodReceive]    Script Date: 09/07/2012 17:12:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodReceive]') AND type in (N'U'))
DROP TABLE [dbo].[BloodReceive]
GO

/****** Object:  Table [dbo].[BloodRequistionDetails]    Script Date: 09/07/2012 17:13:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodRequistionDetails]') AND type in (N'U'))
DROP TABLE [dbo].[BloodRequistionDetails]
GO

/****** Object:  Table [dbo].[PatientDonor]    Script Date: 09/07/2012 17:13:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDonor]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDonor]
GO



/****** Object:  Table [dbo].[InvCodeSchemeMapping]    Script Date: 09/12/2012 15:36:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvCodeSchemeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvCodeSchemeMapping]
GO

/****** Object:  Table [dbo].[CodingSchemeOrgMapping]    Script Date: 09/12/2012 15:36:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CodingSchemeOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[CodingSchemeOrgMapping]
GO


/****** Object:  Table [dbo].[CodingSchemeMaster]    Script Date: 09/12/2012 15:35:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CodingSchemeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CodingSchemeMaster]
GO


/****** Object:  Table [dbo].[EpisodeVisitDetails]    Script Date: 09/15/2012 17:24:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EpisodeVisitDetails]') AND type in (N'U'))
DROP TABLE [dbo].[EpisodeVisitDetails]
GO

 
/****** Object:  Table [dbo].[EpisodeFileManager]    Script Date: 09/15/2012 17:24:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EpisodeFileManager]') AND type in (N'U'))
DROP TABLE [dbo].[EpisodeFileManager]
GO

 
/****** Object:  Table [dbo].[Episode]    Script Date: 09/15/2012 17:24:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Episode]') AND type in (N'U'))
DROP TABLE [dbo].[Episode]
GO

/****** Object:  Table [dbo].[InvSummaryReport]    Script Date: 09/19/2012 12:01:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvSummaryReport]') AND type in (N'U'))
DROP TABLE [dbo].[InvSummaryReport]
GO

/****** Object:  Table [dbo].[InvSummaryTrend]    Script Date: 09/19/2012 12:01:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvSummaryTrend]') AND type in (N'U'))
DROP TABLE [dbo].[InvSummaryTrend]
GO

/****** Object:  Table [dbo].[ReportPrintHistory]    Script Date: 09/19/2012 13:40:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportPrintHistory]') AND type in (N'U'))
DROP TABLE [dbo].[ReportPrintHistory]
GO

/****** Object:  Table [dbo].[EpiContainerTrackingDetails]    Script Date: 09/19/2012 16:06:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EpiContainerTrackingDetails]') AND type in (N'U'))
DROP TABLE [dbo].[EpiContainerTrackingDetails]
GO

 
 
/****** Object:  Table [dbo].[ControlTypeMaster]    Script Date: 09/19/2012 16:03:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ControlTypeMaster]
GO
 
 
/****** Object:  Table [dbo].[TrackingAttributesDetails]    Script Date: 09/19/2012 16:04:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TrackingAttributesDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TrackingAttributesDetails]
GO
 
 
/****** Object:  Table [dbo].[StatusMaster]    Script Date: 09/19/2012 16:06:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StatusMaster]') AND type in (N'U'))
DROP TABLE [dbo].[StatusMaster]
GO
 
  
/****** Object:  Table [dbo].[Statusmapping]    Script Date: 09/19/2012 16:06:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Statusmapping]') AND type in (N'U'))
DROP TABLE [dbo].[Statusmapping]
GO
  
/****** Object:  Table [dbo].[ShippingConditionMaster]    Script Date: 09/19/2012 16:07:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShippingConditionMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ShippingConditionMaster]
GO


/****** Object:  Table [dbo].[EpiContainerTracking]    Script Date: 09/19/2012 16:06:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EpiContainerTracking]') AND type in (N'U'))
DROP TABLE [dbo].[EpiContainerTracking]
GO

 /****** Object:  Table [dbo].[ControlValueMaster]    Script Date: 09/19/2012 16:04:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlValueMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ControlValueMaster]
GO
 
 
/****** Object:  Table [dbo].[ControlOrgMapping]    Script Date: 09/19/2012 16:03:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ControlOrgMapping]
GO

/****** Object:  Table [dbo].[SiteEpisodeVisitMapping]   Script Date: 09/26/2012 16:03:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SiteEpisodeVisitMapping]') AND type in (N'U'))
DROP TABLE [dbo].[SiteEpisodeVisitMapping]
GO

/****** Object:  Table [dbo].[CheckAttributeDetails]    Script Date: 09/26/2012 18:43:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckAttributeDetails]') AND type in (N'U'))
DROP TABLE [dbo].[CheckAttributeDetails]
GO
/****** Object:  Table [dbo].[PatientHistory_Hist]    Script Date: 10/10/2012 17:22:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientHistory_Hist]') AND type in (N'U'))
DROP TABLE [dbo].[PatientHistory_Hist]
GO

/****** Object:  Table [dbo].[ClientMappingService]    Script Date: 10/10/2012 17:48:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientMappingService]') AND type in (N'U'))
DROP TABLE [dbo].[ClientMappingService]
GO
/****** Object:  Table [dbo].[PrintPolicyMaster]    Script Date: 10/12/2012 12:07:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrintPolicyMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PrintPolicyMaster]
GO





/****** Object:  Table [dbo].[ResourceServiceType]    Script Date: 10/16/2012 11:50:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResourceServiceType]') AND type in (N'U'))
DROP TABLE [dbo].[ResourceServiceType]
GO


/****** Object:  Table [dbo].[BillofMaterialDetails]    Script Date: 10/16/2012 11:52:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillofMaterialDetails]') AND type in (N'U'))
DROP TABLE [dbo].[BillofMaterialDetails]
GO



/****** Object:  Table [dbo].[BillOfMaterials]    Script Date: 10/16/2012 11:52:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BillOfMaterials]') AND type in (N'U'))
DROP TABLE [dbo].[BillOfMaterials]
GO



/****** Object:  Table [dbo].[ConsentTypeMaster]    Script Date: 10/16/2012 11:57:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConsentTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ConsentTypeMaster]
GO

/****** Object:  Table [dbo].[ConsentTemplateMaster]    Script Date: 10/16/2012 11:56:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConsentTemplateMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ConsentTemplateMaster]
GO

/****** Object:  Table [dbo].[ConsentTemplateDetails]    Script Date: 10/16/2012 11:56:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConsentTemplateDetails]') AND type in (N'U'))
DROP TABLE [dbo].[ConsentTemplateDetails]
GO

/****** Object:  Table [dbo].[ConsentLetters]    Script Date: 10/16/2012 11:56:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConsentLetters]') AND type in (N'U'))
DROP TABLE [dbo].[ConsentLetters]
GO

/****** Object:  Table [dbo].[InvestigationOrgAttributes]    Script Date: 11/01/2012 11:23:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationOrgAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationOrgAttributes]
GO


/****** Object:  Table [dbo].[PharmacyBillIdMaster]    Script Date: 10/30/2012 17:06:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PharmacyBillIdMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PharmacyBillIdMaster]
GO
/****** Object:  Table [dbo].[InvestigationOrgAttributesHistory]    Script Date: 11/02/2012 12:31:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationOrgAttributesHistory]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationOrgAttributesHistory]
GO

/****** Object:  Table [dbo].[ClientMaster_HIST]    Script Date: 11/02/2012 17:39:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientMaster_HIST]') AND type in (N'U'))
DROP TABLE [dbo].[ClientMaster_HIST]
GO

/****** Object:  Table [dbo].[ResourceConsumption]    Script Date: 11/06/2012 11:37:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResourceConsumption]') AND type in (N'U'))
DROP TABLE [dbo].[ResourceConsumption]
GO

/****** Object:  Table [dbo].[ProductEpisodeVisitMapping]    Script Date: 11/07/2012 19:40:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductEpisodeVisitMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ProductEpisodeVisitMapping]
GO

/****** Object:  Table [dbo].[InvOrgGroup_History]    Script Date: 11/08/2012 15:14:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvOrgGroup_History]') AND type in (N'U'))
DROP TABLE [dbo].[InvOrgGroup_History]
GO


/****** Object:  Table [dbo].[ReportPublishDetails]    Script Date: 11/09/2012 20:08:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportPublishDetails]') AND type in (N'U'))
DROP TABLE [dbo].[ReportPublishDetails]
GO

/****** Object:  Table [dbo].[ReportPublishing]    Script Date: 11/09/2012 20:08:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReportPublishing]') AND type in (N'U'))
DROP TABLE [dbo].[ReportPublishing]
GO
/****** Object:  Table [dbo].[PublishHistory]    Script Date: 11/09/2012 20:09:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PublishHistory]') AND type in (N'U'))
DROP TABLE [dbo].[PublishHistory]
GO
/****** Object:  Table [dbo].[InvOrgReferenceMapping]    Script Date: 11/10/2012 20:28:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvOrgReferenceMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvOrgReferenceMapping]
GO
/****** Object:  Table [dbo].[MasterProducts]    Script Date: 11/17/2012 12:55:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterProducts]') AND type in (N'U'))
DROP TABLE [dbo].[MasterProducts]
GO
/****** Object:  Table [dbo].[MasterProductCategories]    Script Date: 11/17/2012 12:55:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterProductCategories]') AND type in (N'U'))
DROP TABLE [dbo].[MasterProductCategories]
GO

/****** Object:  Table [dbo].[DiscountPolicyMapping]    Script Date: 11/26/2012 19:12:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiscountPolicyMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DiscountPolicyMapping]
GO

/****** Object:  Table [dbo].[PolicyMaster]    Script Date: 11/26/2012 19:12:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PolicyMaster]') AND type in (N'U'))
DROP TABLE [dbo].[PolicyMaster]
GO

/****** Object:  Table [dbo].[MetaDataOrgMapping]    Script Date: 12/12/2012 16:32:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MetaDataOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[MetaDataOrgMapping]
GO

/****** Object:  Table [dbo].[CommunicationConfig]    Script Date: 12/24/2012 19:22:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CommunicationConfig]') AND type in (N'U'))
DROP TABLE [dbo].[CommunicationConfig]
GO

/****** Object:  Table [dbo].[StockStatusMapping]    Script Date: 12/31/2012 14:35:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockStatusMapping]') AND type in (N'U'))
DROP TABLE [dbo].[StockStatusMapping]
GO

/****** Object:  Table [dbo].[StockTypeMapping]    Script Date: 12/31/2012 14:36:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockTypeMapping]') AND type in (N'U'))
DROP TABLE [dbo].[StockTypeMapping]
GO

/****** Object:  Table [dbo].[InvMedicalDetailsMapping]    Script Date: 12/28/2012 17:59:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvMedicalDetailsMapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvMedicalDetailsMapping]
GO

/****** Object:  Table [dbo].[PatientDisPatchDetails]    Script Date: 01/19/2013 18:21:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientDisPatchDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PatientDisPatchDetails]
GO


/****** Object:  Table [dbo].[LabPrintHistory]    Script Date: 01/23/2013 17:24:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LabPrintHistory]') AND type in (N'U'))
DROP TABLE [dbo].[LabPrintHistory]
GO


GO

/****** Object:  Table [dbo].[SOIRateDetails]    Script Date: 02/20/2013 20:10:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SOIRateDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SOIRateDetails]
GO

/****** Object:  Table [dbo].[BloodSeparationDetails]    Script Date: 03/04/2013 19:31:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BloodSeparationDetails]') AND type in (N'U'))
DROP TABLE [dbo].[BloodSeparationDetails]

---------------------------------------------------NRRAJAN-----------------------------------------------------
/****** Object:  Table [dbo].[Diet_FoodCategory]    Script Date: 03/06/2013 19:01:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodCategory]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodCategory]
GO

/****** Object:  Table [dbo].[Diet_FoodList]    Script Date: 03/06/2013 19:02:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodList]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodList]
GO

/****** Object:  Table [dbo].[Diet_FoodIngredients]    Script Date: 03/06/2013 19:02:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodIngredients]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodIngredients]
GO

-----------------------------------------------------END-------------------------------------------------------
                                                ---VIGNESH---
/****** Object:  Table [dbo].[Diet_FoodSessionMaster]    Script Date: 03/06/2013 19:02:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodSessionMaster]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodSessionMaster]
GO

/****** Object:  Table [dbo].[Diet_FoodMenuMaster]    Script Date: 03/06/2013 19:02:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodMenuMaster]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodMenuMaster]
GO

----------------------------------------------------END-------------------------------------------------------------
/****** Object:  Table [dbo].[Diet_FootMenuDetails]    Script Date: 03/08/2013 13:17:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FootMenuDetails]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FootMenuDetails]
GO


/****** Object:  Table [dbo].[Diet_FoodIngredientsMapping]    Script Date: 03/08/2013 13:17:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodIngredientsMapping]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodIngredientsMapping]
GO


----------------------Einstien Castro Starts----------------------------------------------------------------


/****** Object:  Table [dbo].[Diet_FoodMenuDetails]    Script Date: 03/08/2013 13:17:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodMenuDetails]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodMenuDetails]
GO


/****** Object:  Table [dbo].[Diet_PatientDietPlanMaster]    Script Date: 03/08/2013 13:17:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_PatientDietPlanMaster]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_PatientDietPlanMaster]
GO


/****** Object:  Table [dbo].[Diet_FoodOrderMaster]    Script Date: 03/08/2013 13:17:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodOrderMaster]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodOrderMaster]
GO

/****** Object:  Table [dbo].[Diet_FoodOrderDetails]    Script Date: 03/08/2013 13:17:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_FoodOrderDetails]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_FoodOrderDetails]
GO


/****** Object:  Table [dbo].[Diet_PatientDietPlanDetails]    Script Date: 03/08/2013 13:17:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Diet_PatientDietPlanDetails]') AND type in (N'U'))
DROP TABLE [dbo].[Diet_PatientDietPlanDetails]
GO


/****** Object:  Table [dbo].[VisitClientMapping_History]    Script Date: 03/09/2013 17:12:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitClientMapping_History]') AND type in (N'U'))
DROP TABLE [dbo].[VisitClientMapping_History]
GO


/****** Object:  Table [dbo].[EmergencyPatientTracker_History]    Script Date: 03/09/2013 17:15:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmergencyPatientTracker_History]') AND type in (N'U'))
DROP TABLE [dbo].[EmergencyPatientTracker_History]
GO

/****** Object:  Table [dbo].[FeeTypeRoleMapping]    Script Date: 29/03/2013 9:33:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FeeTypeRoleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[FeeTypeRoleMapping]
GO
/****** Object:  Table [dbo].[ErrorLog]    Script Date: 04/02/2013 19:48:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ErrorLog]') AND type in (N'U'))
DROP TABLE [dbo].[ErrorLog]
GO
/****** Object:  Table [dbo].[CampDetail]    Script Date: 04/02/2013 19:48:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CampDetail]') AND type in (N'U'))
DROP TABLE [dbo].[CampDetail]
GO
/****** Object:  Table [dbo].[ReferingPhyCategoryMapping]    Script Date: 13/09/2013 11:58:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReferingPhyCategoryMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ReferingPhyCategoryMapping]
GO

/****** Object:  Table [dbo].[WorklistMaster]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorklistMaster]') AND type in (N'U'))
DROP TABLE [dbo].[WorklistMaster]
GO

/****** Object:  Table [dbo].[WorklistDetail]    Script Date: 02/02/2009 19:05:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorklistDetail]') AND type in (N'U'))
DROP TABLE [dbo].[WorklistDetail]
GO

/****** Object:  Table [dbo].[AuthorisedTypeMaster]    Script Date: 12/02/2014 19:21:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorisedTypeMaster]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorisedTypeMaster]
GO
/****** Object:  Table [dbo].[AuthoriseUserRoleMapping]    Script Date: 12/02/2014 19:22:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthoriseUserRoleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[AuthoriseUserRoleMapping]
GO
/****** Object:  Table [dbo].[DiscountReasonMapping]    Script Date: 12/02/2014 19:22:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiscountReasonMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DiscountReasonMapping]
GO
/****** Object:  Table [dbo].[DiscountSlabMapping]    Script Date: 12/02/2014 19:23:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiscountSlabMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DiscountSlabMapping]
GO
/****** Object:  Table [dbo].[OrgBasedReportstationary]    Script Date: 12/09/2014 16:40:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrgBasedReportstationary]') AND type in (N'U'))
DROP TABLE [dbo].[OrgBasedReportstationary]
GO
/****** Object:  Table [dbo].[OrgBasedReportstationaryMapping]    Script Date: 12/09/2014 16:40:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrgBasedReportstationaryMapping]') AND type in (N'U'))
DROP TABLE [dbo].[OrgBasedReportstationaryMapping]
GO
/****** Object:  Table [dbo].[PatientTRFVerification]    Script Date: 12/16/2014 7:52:03 PM ******/
DROP TABLE [dbo].[PatientTRFVerification]
GO

/****** Object:  Table [dbo].[OrgTransferClientMapping]    Script Date: 31-12-14 4:19:11 PM ******/
DROP TABLE [dbo].[OrgTransferClientMapping]
GO

/****** Object:  Table [dbo].[CurrencyConversionMaster]    Script Date: 31-12-14 4:19:11 PM ******/
DROP TABLE [dbo].[CurrencyConversionMaster]
GO
/****** Object:  Table [dbo].[TaskDefaultSearch]    Script Date: 07/14/2015 11:17:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TaskDefaultSearch]') AND type in (N'U'))
DROP TABLE [dbo].[TaskDefaultSearch]
GO
/****** Object:  Table [dbo].[PhyClientAccessMapping]    Script Date: 07/20/2015 14:34:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhyClientAccessMapping]') AND type in (N'U'))
DROP TABLE [dbo].[PhyClientAccessMapping]
GO
/****** Object:  Table [dbo].[DispatchRuleMapping]    Script Date: 08/07/2015 14:07:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DispatchRuleMapping]') AND type in (N'U'))
DROP TABLE [dbo].[DispatchRuleMapping]
GO

/****** Object:  UserDefinedTableType [dbo].[InvPackageMappingHist]    Script Date: 05/07/2015 12:50:46 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'InvPackageMappingHist' AND ss.name = N'dbo')
DROP TYPE InvPackageMappingHist
GO


--------------------------------------Ramkumar changes---------------------------------

/****** Object:  Table [dbo].[Autoapproveissue]    Script Date: 05/26/2016 15:33:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Autoapproveissue]') AND type in (N'U'))
DROP TABLE [dbo].[Autoapproveissue]
GO
--------------------------------------Krishna Changes-------------------------------------------------

/****** Object:  Table [dbo].[PreQuotationInvestigations]    Script Date: 7/29/2016 12:36:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PreQuotationInvestigations]') AND type in (N'U'))
DROP TABLE [dbo].[PreQuotationInvestigations]
GO


---------------------------------------End-----------------------------------------
-------------------------------Vijayalakshmi.M changes---------------------------------------------------
/****** Object:  Table [dbo].[FloorMaster]    Script Date: 7/29/2016 12:36:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FloorMaster]') AND type in (N'U'))
DROP TABLE [dbo].[FloorMaster]
GO

/****** Object:  Table [dbo].[RoomMaster]    Script Date: 7/29/2016 12:36:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomMaster]') AND type in (N'U'))
DROP TABLE [dbo].[RoomMaster]
GO
----------------------------------------End-----------------------------------------------------------------
/****** Object:  Table [dbo].[HC_Patient]    Script Date: 7/29/2016 12:36:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HC_Patient]') AND type in (N'U'))
DROP TABLE [dbo].[HC_Patient]
GO



--------------------------------ramya changes for common platform merge-------------------------------------

/****** Object:  UserDefinedTableType [dbo].[BannerMaster]    Script Date: 6/11/2016 12:16:09 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'BannerMaster' AND ss.name = N'dbo')
DROP TYPE [dbo].[BannerMaster]
GO


/****** Object:  UserDefinedTableType [dbo].[PageLoginAccess]    Script Date: 6/11/2016 12:16:09 PM ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'PageLoginAccess' AND ss.name = N'dbo')
DROP TYPE [dbo].[PageLoginAccess]
GO
------------------------------------------------end-------------------------------------------------

/****** Object:  Table [dbo].[ThemeOrgMapping]    Script Date: 12/07/2016 04:11:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ThemeOrgMapping]') AND type in (N'U'))
DROP TABLE [dbo].[ThemeOrgMapping]
GO
-----------------------------------------------------------------------------------------------------------------------------
If Object_id('misorderedinvestigations','U') is not null
Begin
	drop table misorderedinvestigations
end
go

If Object_id('misorddept','U') is not null
Begin
	drop table misorddept
end
go
If Object_id('mispatientinvestigation','U') is not null
Begin
	drop table mispatientinvestigation
end
go

If Object_id('misinvestigationvalues','U') is not null
Begin
	drop table misinvestigationvalues
end
go

If Object_id('MISPatientinvsample','U') is not null
Begin
	drop table MISPatientinvsample
end
go

If Object_id('misorddept','U') is not null
Begin
	drop table misorddept
end
go

IF Object_id('OrdTasks') is not null
Begin
	drop table OrdTasks
End
go



/****** Object:  Table [dbo].[ClientAttributesFields]    Script Date: 03/10/2016 04:11:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientAttributesFields]') AND type in (N'U'))
DROP TABLE [dbo].[ClientAttributesFields]
GO



/****** Object:  Table [dbo].[PatientAttributeFields]    Script Date: 03/10/2016 04:11:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientAttributeFields]') AND type in (N'U'))
DROP TABLE [dbo].[PatientAttributeFields]
GO

/****** Object:  Table [dbo].[SampleBatchScanOutDetailsHistory]    Script Date: 03/10/2016 04:11:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SampleBatchScanOutDetailsHistory]') AND type in (N'U'))
DROP TABLE [dbo].[SampleBatchScanOutDetailsHistory]
GO

/****** Object:  Table [dbo].[InvSampleStatusOrgmapping]    Script Date: 03/10/2016 04:11:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvSampleStatusOrgmapping]') AND type in (N'U'))
DROP TABLE [dbo].[InvSampleStatusOrgmapping]
GO


/****** Object:  Table [dbo].[LanguageMaster]    Script Date: 03/10/2016 04:11:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LanguageMaster]') AND type in (N'U'))
DROP TABLE [dbo].[LanguageMaster]
GO
/****** Object:  Table [dbo].[SampleBatchScanOutDetails]    Script Date: 03/10/2016 04:11:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SampleBatchScanOutDetails]') AND type in (N'U'))
DROP TABLE [dbo].[SampleBatchScanOutDetails]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationDrugFamilyMaster]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationDrugFamilyMaster]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationDrugFamilyMasterHistory]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationDrugFamilyMasterHistory]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvestigationDrugBrandHistory]') AND type in (N'U'))
DROP TABLE [dbo].[InvestigationDrugBrandHistory]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrganismMasterHistory]') AND type in (N'U'))
DROP TABLE [dbo].[OrganismMasterHistory]
GO

----------------------- HomeCollection Start ------------------------------

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PreBookingPaymentDetails]') AND type in (N'U'))
DROP TABLE [dbo].[PreBookingPaymentDetails]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings_HIST]') AND type in (N'U'))
  DROP TABLE [dbo].[Bookings_HIST]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PreBookingSample]') AND type in (N'U'))
  DROP TABLE [dbo].[PreBookingSample]
GO

----------------------- HomeCollection End ------------------------------

----------------------- LIMSAPI Start ----------------------------------

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[APIConfiguration]') AND type in (N'U'))
  DROP TABLE [dbo].[APIConfiguration]
GO

/****** Object:  Table [dbo].[TRFFileManager_HC]    Script Date: 04/04/2012 11:47:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRFFileManager_HC]') AND type in (N'U'))
DROP TABLE [dbo].[TRFFileManager_HC]
GO
----------------------- LIMSAPI End ----------------------------------