using System;
using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_PatientBanner
    {
        private DateTime dateTime = DateTime.MaxValue;

        public long PatientID { get; set; }
        public string PatientName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string PatientNumber { get; set; }
        public string MobileNumber { get; set; }
        public string ExternalVisitID { get; set; }
        public string VisitNumber { get; set; }
        public DateTime VisitDate { get { return dateTime; } set { dateTime = value; } }
        public long VisitID { get; set; }
        public string Location { get; set; }
        public long ClientID { get; set; }
        public string ClientName { get; set; }
        public string ReferingPhysicianName { get; set; }
        public int ReferingPhysicianID { get; set; }
        public DateTime CollectedDate { get { return dateTime; } set { dateTime = value; } }
        public string PatientHistory { get; set; }
        public string Remarks { get; set; }
    }

    public class UI_Patient
    {
        private DateTime dateTime = DateTime.MaxValue;

        public UI_Salutation Salutation { get; set; }
        public long PatientID { get; set; }
        public long PatientVisitID { get; set; }
        public string PatientNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PatientName { get; set; }
        public UI_MetaData Gender { get; set; }
        public string Age { get; set; }
        public DateTime DOB { get; set; }
        public string DOB1 { get; set; }
        public string MartialStatus { get; set; }
        public string PatientStatus { get; set; }
        public string Add1 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
        public string EMail { get; set; }
        public int VisitPurposeID { get; set; }
        public int IsExternelPatient { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string AgeTypeCode { get; set; }
        public int OrgID { get; set; }
        public int OrgAddressID { get; set; }
        public DateTime SamplePickupDate { get { return dateTime; } set { dateTime = value; } }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
    }

    public class UI_PatientHistory
    {
        public long PatientVisitId { get; set; }
        public string PatientHistory { get; set; }
        public string RegistrationRemarks { get; set; }
        public long ReferingPhysicianID { get; set; }
        public string ReferingPhysicianName { get; set; }
        public long HospitalID { get; set; }
        public string HospitalName { get; set; }
    }

    public class UI_PatientAddress
    {
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public int AddLevel1 { get; set; }
        public int AddLevel2 { get; set; }
        public long AddressID { get; set; }
        public string AddressType { get; set; }
        public string City { get; set; }
        public int CityCode { get; set; }
        public int CityID { get; set; }
        public int CountryCode { get; set; }
        public long CountryID { get; set; }
        public string CountryName { get; set; }
        public string District { get; set; }
        public DateTime EndDTTM { get; set; }
        public string LandLineNumber { get; set; }
        public string MobileNumber { get; set; }
        public string OtherCountryName { get; set; }
        public string OtherStateName { get; set; }
        public long PatientID { get; set; }
        public string PostalCode { get; set; }
        public DateTime StartDTTM { get; set; }
        public int StateCode { get; set; }
        public long StateID { get; set; }
        public string StateName { get; set; }
        public int SuburbID { get; set; }
        public string Village { get; set; }
    }
    public class UI_PatientandAddress
    {
        public List<UI_PatientBanner> Patient { get; set; }
        public List<UI_PatientAddress> PatientAddress { get; set; }
    }

    public class UI_GeneralHealthCheckUpMaster
    {
        public long GeneralHealthCheckUpID { get; set; }
        public string GeneralHealthCheckUpName { get; set; }
        public string GeneralHealthCheckUpType { get; set; }
        public string GeneralHealthCheckUpDesc { get; set; }
        public long OrgID { get; set; }
        public string IsAVisitPurpose { get; set; }
        public String Active { get; set; }
    }
    public class UI_HealthPackage
    {
        public List<UI_InvGroupMaster> lstPackages { get; set; }
        public List<UI_InvPackageMapping> lstPackageMapping { get; set; }
        public List<UI_PatientInvestigation> lstPackageContents { get; set; }
        public List<UI_GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster { get; set; }
    }
}
