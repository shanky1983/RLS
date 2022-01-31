update Login set OrgID =28 where OrgID =12
update Organization set OrgID  =28 where OrgID =12
update OrganizationAddress set OrgID  =28 where OrgID =12
update OrganizationAddress set AddressID=27 where OrgID =28
update Users set OrgID   =28 where OrgID =12
update Nurse set OrgID  =28 where OrgID =12
update MenuMaster set OrgId   =28 where OrgId =12
update IDMaster set OrgID =28 where OrgID =12
update Config set ConfigValue =27 where ConfigID =51
update Config set ConfigKey ='PharmacyLocation_27' where ConfigID=51
update Config set ConfigKey ='PharmacyName_27' where ConfigID=52
update Role   set OrgID =28 where OrgID =12
update OrgUOMVitalsMapping set OrgId  =28 where OrgId =12
update ProcedureMaster set OrgID   =28 where OrgID =12
update PhysicianOrganization set OrgID  =28 where OrgID =12
update StandardDeduction set OrgID   =28 where OrgID =12
update PhysicianFee set OrgId  =28 where OrgId =12
update TaskActionMapping set OrgID   =28 where OrgID =12
update Config set OrgId  =28 where OrgId =12
update InvestigationFee set OrgID   =28 where OrgID =12
update OrganizationSpeciality set OrgID   =28 where OrgID =12
update TaskEscalation set OrgID   =28 where OrgID =12
update TaskActionOrgMapping set OrgID   =28 where OrgID =12
update VisitPurposeOrgMapping set OrgID   =28 where OrgID =12
update InvDeptMaster set OrgID   =28 where OrgID =12
update InvestigationOrgSampleStatus set OrgID   =28 where OrgID =12
update InvGroupMaster set OrgID =28 where OrgID =12
update ComplaintGroupOrgMapping set OrgID=28 where OrgID =12
update InvClientMaster set OrgID   =28 where OrgID =12
update InvOrgGroup set OrgID   =28 where OrgID =12
update ReportOrgMapping set OrgID   =28 where OrgID =12 

update RoomType set OrgAddID   =28 where OrgAddID =12
update MedicalIndents set OrgID   =28 where OrgID =12
update PurposeOfAdmission set OrgID=28 where OrgID =12
update IPTreatmentPlanMaster set OrgID   =28 where OrgID =12
update CashExpenseMaster set OrgID   =28 where OrgID =12
update TaskDependency set OrgID   =28 where OrgID =12
update SurgeryType set OrgID    =28 where OrgID =12
update OperationType set OrgID   =28 where OrgID =12
update AnesthesiaType set OrgID   =28 where OrgID =12
update AHPStaffType set OrgID   =28 where OrgID =12
update AHPStaff set OrgID    =28 where OrgID =12
update InventoryIDMaster set OrgID   =28 where OrgID =12
update PageActionMapping set OwnerOrgID =28 where OwnerOrgID  =12
update PageActionMapping set SharedOrgID =28 where SharedOrgID  =12
update InvInstrumentMaster set OrgID   =28 where OrgID =12
update InvKitMaster set OrgID   =28 where OrgID =12
update InvestigationMethod set OrgID   =28 where OrgID =12
update InvResultTemplate set OrgID   =28 where OrgID =12
update LabSummaryReportParameter set OrgID   =28 where OrgID =12
update InvPrincipleMaster set OrgID   =28 where OrgID =12
update PatDtlsVPActionMapping set OrgID   =28 where OrgID =12
update DrugBrand set OrgID   =28 where OrgID =12
update InvestigationOrgMapping set OrgID   =28 where OrgID =12
--update InvRateMaster set or   =28 where OrgID =12
update PatientRecommendation set OrgID   =28 where OrgID =12
update InvClientMaster  set ClientID=1800 where ClientID=1001
update InvClientMaster  set ClientID=1801 where ClientID=1101
update InvClientMaster  set ClientID=1802 where ClientID=1102
update TrustedOrgDetails set LoggedOrgID =28,SharingOrgID =28,LoggedOrgAddressID=27,SharingOrgAddressID =27 where LoggedOrgID =12

update Physician set OrgID =28 where OrgID =12
update Nurse set OrgID =28 where OrgID =12
update InventoryConfig set OrgID =28 where OrgID =12
update PhysicianFee set ClientID =1800 where ClientID =1001
update PhysicianFee set ClientID =1801 where ClientID =1101
update PhysicianFee set ClientID =1802 where ClientID =1102
update ProcedureFee set ClientID =1800 where ClientID =1001
update ProcedureFee set ClientID =1801 where ClientID =1101
update ProcedureFee set ClientID =1802 where ClientID =1102
update ProcedureFee set OrgID =28 where OrgID=12
update InvRateMaster set ClientID =1801 where ClientID = 1800
update PayerMaster set OrgID =28 where OrgID =12




