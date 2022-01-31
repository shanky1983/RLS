Alter table AHPStaff Alter Column OrganizationID int
Alter table AHPStaffType Alter Column OrganizationID int
Alter table ANCPatientObservation Alter Column OrganizationID int
Alter table AnesthesiaType Alter Column OrganizationID int
Alter table BarcodeOrgMapping Alter Column OrganizationId int
Alter table COde_Details Alter Column Organizationid int
Alter table InvestigationProfileMapping Alter Column OrganizationID int
Alter table Login Alter Column OrganisationID int
Alter table Login_HIST Alter Column OrganisationID int
Alter table Nurse Alter Column OrganisationID int
Alter table Nurse_HIST Alter Column OrganisationID int
Alter table OperationComplication Alter Column OrganizationID int
Alter table OperationFinding Alter Column OrganizationID int
Alter table OperationNotes Alter Column OrganizationID int
Alter table OperationStaff Alter Column OrganizationID int
Alter table OperationType Alter Column OrganizationID int
Alter table organizationAdd Alter Column OrganizationID int
Alter table OrganizationAddress Alter Column OrganizationID int
Alter table PatientHistory_Hist Alter Column OrganizationID int
Alter table PatientHistoryExt_Hist Alter Column OrganizationID int
Alter table PatientVisit_HIST Alter Column OrganizationID int
Alter table Physician Alter Column OrganizationID int
Alter table Physician_HIST Alter Column OrganizationID int
Alter table PurposeOfAdmission Alter Column OrganizationID int
Alter table SchedulableResource Alter Column OrganizationID int
Alter table SurgeryType Alter Column OrganizationID int
Alter table Users Alter Column OrganisationID int
Alter table Users_HIST Alter Column OrganisationID int
Alter table Organization Alter Column OrganizationID int
Alter table PhysicianOrganization Alter Column OrganizationID int
Alter table OrganizationSpeciality Alter Column OrganizationID int
Alter table Patient Alter Column OrganizationID int
Alter table Patient_HIST Alter Column OrganizationID int
Alter table PatientHistoryExt Alter Column OrganizationID int
Alter table PatientVisit Alter Column OrganizationID int




exec Sp_rename 'AHPStaff.OrganizationID', 'OrgID'
exec Sp_rename 'AHPStaffType.OrganizationID', 'OrgID'
exec Sp_rename 'ANCPatientObservation.OrganizationID', 'OrgID'
exec Sp_rename 'AnesthesiaType.OrganizationID', 'OrgID'
exec Sp_rename 'BarcodeOrgMapping.OrganizationId', 'OrgID'
exec Sp_rename 'COde_Details.Organizationid', 'OrgID'
exec Sp_rename 'InvestigationProfileMapping.OrganizationID', 'OrgID'
exec Sp_rename 'Login.OrganisationID', 'OrgID'
exec Sp_rename 'Login_HIST.OrganisationID', 'OrgID'
exec Sp_rename 'Nurse.OrganisationID', 'OrgID'
exec Sp_rename 'Nurse_HIST.OrganisationID', 'OrgID'
exec Sp_rename 'OperationComplication.OrganizationID', 'OrgID'
exec Sp_rename 'OperationFinding.OrganizationID', 'OrgID'
exec Sp_rename 'OperationNotes.OrganizationID', 'OrgID'
exec Sp_rename 'OperationStaff.OrganizationID', 'OrgID'
exec Sp_rename 'OperationType.OrganizationID', 'OrgID'
exec Sp_rename 'organizationAdd.OrganizationID', 'OrgID'
exec Sp_rename 'OrganizationAddress.OrganizationID', 'OrgID'
exec Sp_rename 'PatientHistory_Hist.OrganizationID', 'OrgID'
exec Sp_rename 'PatientHistoryExt_Hist.OrganizationID', 'OrgID'
exec Sp_rename 'PatientVisit_HIST.OrganizationID', 'OrgID'
exec Sp_rename 'Physician.OrganizationID', 'OrgID'
exec Sp_rename 'Physician_HIST.OrganizationID', 'OrgID'
exec Sp_rename 'PurposeOfAdmission.OrganizationID', 'OrgID'
exec Sp_rename 'SchedulableResource.OrganizationID', 'OrgID'
exec Sp_rename 'SurgeryType.OrganizationID', 'OrgID'
exec Sp_rename 'Users.OrganisationID', 'OrgID'
exec Sp_rename 'Users_HIST.OrganisationID', 'OrgID'
exec Sp_rename 'Organization.OrganizationID', 'OrgID'
exec Sp_rename 'PhysicianOrganization.OrganizationID', 'OrgID'
exec Sp_rename 'OrganizationSpeciality.OrganizationID', 'OrgID'
exec Sp_rename 'Patient.OrganizationID', 'OrgID'
exec Sp_rename 'Patient_HIST.OrganizationID', 'OrgID'
exec Sp_rename 'PatientHistoryExt.OrganizationID', 'OrgID'
exec Sp_rename 'PatientVisit.OrganizationID', 'OrgID'
