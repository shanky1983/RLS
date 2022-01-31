using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   
    public class ResultOrder
    {
        public string OrderId { get; set; }
        public string OrgCode { get; set; }
        public string OverAllStatus { get; set; }
        public ResPatientDetails PatientInfo { get; set; }
        public RePatientVisitDetails PatientVisitInfo { get; set; }
        public CorporatePatients CorporatePatient { get; set; }
        public List<TestOrder> OrderInfo { get; set; }
    //    public byte[] ResultAsPdf { get; set; }
     //   public byte[] OutsourceAsPdf { get; set; }
    }
    //public class ResPatientDetails
    //{
    //    public string PatientID { get; set; }
    //    public string PatientNumber { get; set; }
    //    public string SalutationCode { get; set; }
    //    public string FirstName { get; set; }
    //    public string MiddleName { get; set; }
    //    public string LastName { get; set; }
    //    public string Gender { get; set; }
    //    public string Age { get; set; }
    //    public string DOB { get; set; }
    //    public string MobileNumber { get; set; }
    //    public string EmailID { get; set; }
    //    public string URNType { get; set; }
    //    public string URNNumber { get; set; }
    //    public List<PatAddressDetails> AddressDetails { get; set; }
    //}
    //public class RePatientVisitDetails
    //{
    //    public string PatientVisitId { get; set; }
    //    public string ExternalVisitNumber { get; set; }
    //    public string VisitType { get; set; }
    //    public string VisitDate { get; set; }
    //    public string VATRegisterationNo { get; set; }
    //    public string ClientID { get; set; }
    //    public string ClientCode { get; set; }
    //    public string ClientName { get; set; }
    //    public string ReferingDoctorCode { get; set; }
    //    public string ReferingDoctorName { get; set; }
    //    public string ReferingDoctorMobileNumber { get; set; }
    //    public string IsNotification { get; set; }
    //    public string HospitalNameCode { get; set; }
    //    public string HospitalName { get; set; }
    //    public string VisitHistory { get; set; }
    //    public string VisitRemarks { get; set; }
    //    public string RegisterLocation { get; set; }
    //    public string CompanyID { get; set; }
    //}
    //public class ResPatientVisitDetails
    //{
    //    public string PatientVisitId { get; set; }
    //    public string ExternalVisitNumber { get; set; }
    //    public string VisitType { get; set; }
    //    public DateTime VisitDate { get; set; }
    //    public string VATRegisterationNo { get; set; }
    //    public string ClientID { get; set; }
    //    public string ClientCode { get; set; }
    //    public string ClientName { get; set; }
    //    public string ReferingDoctorCode { get; set; }
    //    public string ReferingDoctorName { get; set; }
    //    public string ReferingDoctorMobileNumber { get; set; }
    //    public string IsNotification { get; set; }
    //    public string HospitalNameCode { get; set; }
    //    public string HospitalName { get; set; }
    //    public string VisitHistory { get; set; }
    //    public string VisitRemarks { get; set; }
    //    public string RegisterLocation { get; set; }
    //    public string CompanyID { get; set; }
    //    public DateTime BookedDate { get; set; }
    //    public DateTime CheckinDate { get; set; }
    //    public DateTime CheckOutDate { get; set; }
    //    public string Status { get; set; }
    //}
    //public class PatAddressDetails
    //{
    //    public string Address { get; set; }
    //    public string AddressType { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string Country { get; set; }
    //    public string StateID { get; set; }
    //    public string CountryID { get; set; }
    //    public string ExternalPatientNumber { get; set; }
    //}
    //public class TestOrder
    //{
    //    public long PatientVisitID { get; set; }
    //    public long ExternalVisitID { get; set; }
    //    public string TestID { get; set; }
    //    public string TestCode { get; set; }
    //    public string OrderedDate { get; set; }
    //    public string TestType { get; set; }
    //    public string TestName { get; set; }
    //    public string TestValueType { get; set; }
    //    public string TestValue { get; set; }
    //    public string UOMCode { get; set; }
    //    public string MethodName { get; set; }
    //    public string DepartmentName { get; set; }
    //    public string ReferenceRange { get; set; }
    //    public string IsAbnormal { get; set; }
    //    public string ResultCapturedAt { get; set; }
    //    public string TestStatus { get; set; }
    //    public string MedicalRemarks { get; set; }
    //    public string InterpretationNotes { get; set; }
    //    public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
    //    public string ProcessingLocation { get; set; }
    //    public string DeviceID { get; set; }
    //    public string LotNumber { get; set; }
    //    public string DeltaValue { get; set; }
    //    public string CreatedAt { get; set; }
    //    public string UpdatedAt { get; set; }
    //    public long UserID { get; set; }
    //    public string UserName { get; set; }
    //    public string SampleName { get; set; }
    //    public string ConversionValue { get; set; }
    //    public string ConversionUnit { get; set; }
    //    public string ConversionRange { get; set; }
    //    public string Nonreportable { get; set; }
    //    public string ReportName { get; set; }
    //    public List<TestOrderContentVisit> OrderContentListInfo { get; set; }
    //    //public byte[] ResultAsPdf { get; set; }
    //}
    //public class TestOrderContentVisit
    //{
    //    public string TestCode { get; set; }
    //    public string OrderedDate { get; set; }
    //    public string TestType { get; set; }
    //    public string TestID { get; set; }
    //    public string TestName { get; set; }
    //    public string TestValueType { get; set; }
    //    public string TestValue { get; set; }
    //    public string UOMCode { get; set; }
    //    public string MethodName { get; set; }
    //    public string DepartmentName { get; set; }
    //    public string ReferenceRange { get; set; }
    //    public string IsAbnormal { get; set; }
    //    public string ResultCapturedAt { get; set; }
    //    public string TestStatus { get; set; }
    //    public string MedicalRemarks { get; set; }
    //    public string InterpretationNotes { get; set; }
    //    public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
    //    public string ProcessingLocation { get; set; }
    //    public string DeviceID { get; set; }
    //    public string LotNumber { get; set; }
    //    public string DeltaValue { get; set; }
    //    public string CreatedAt { get; set; }
    //    public string UpdatedAt { get; set; }
    //    public long UserID { get; set; }
    //    public string UserName { get; set; }
    //    public string SampleName { get; set; }
    //    public string ConversionValue { get; set; }
    //    public string ConversionUnit { get; set; }
    //    public string ConversionRange { get; set; }
    //    public string Nonreportable { get; set; }
    //    public string ReportName { get; set; }
    //    public List<TestOrderVisit> ParameterListInfo { get; set; }
    //}
    //public class TestOrderVisit
    //{
    //    public string TestCode { get; set; }
    //    public string OrderedDate { get; set; }
    //    public string TestType { get; set; }
    //    public string TestID { get; set; }
    //    public string TestName { get; set; }
    //    public string TestValueType { get; set; }
    //    public string TestValue { get; set; }
    //    public string UOMCode { get; set; }
    //    public string MethodName { get; set; }
    //    public string DepartmentName { get; set; }
    //    public string ReferenceRange { get; set; }
    //    public string IsAbnormal { get; set; }
    //    public string ResultCapturedAt { get; set; }
    //    public string TestStatus { get; set; }
    //    public string MedicalRemarks { get; set; }
    //    public string InterpretationNotes { get; set; }
    //    public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
    //    public string ProcessingLocation { get; set; }
    //    public string DeviceID { get; set; }
    //    public string LotNumber { get; set; }
    //    public string DeltaValue { get; set; }
    //    public string CreatedAt { get; set; }
    //    public string UpdatedAt { get; set; }
    //    public long UserID { get; set; }
    //    public string UserName { get; set; }
    //    public string SampleName { get; set; }
    //    public string ConversionValue { get; set; }
    //    public string ConversionUnit { get; set; }
    //    public string ConversionRange { get; set; }
    //    public string Nonreportable { get; set; }
    //    public string ReportName { get; set; }
    //}
    //public class TestOrderVisitDetails
    //{
    //    public long PatientVisitID { get; set; }
    //    public long ExternalVisitID { get; set; }
    //    public string TestID { get; set; }
    //    public string TestCode { get; set; }
    //    public DateTime OrderedDate { get; set; }
    //    public string TestType { get; set; }
    //    public string TestName { get; set; }
    //    public string TestValueType { get; set; }
    //    public string TestValue { get; set; }
    //    public string UOMCode { get; set; }
    //    public string MethodName { get; set; }
    //    public string ReferenceRange { get; set; }
    //    public string IsAbnormal { get; set; }
    //    public DateTime ResultCapturedAt { get; set; }
    //    public string TestStatus { get; set; }
    //    public string MedicalRemarks { get; set; }
    //    public string InterpretationNotes { get; set; }
    //    public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
    //    public string ProcessingLocation { get; set; }
    //    public string DeviceID { get; set; }
    //    public string LotNumber { get; set; }
    //    public string PKGID { get; set; }
    //    public string PKGName { get; set; }
    //    public string GroupID { get; set; }
    //    public string GroupName { get; set; }
    //    public string Status { get; set; }
    //    public string SubGroupID { get; set; }
    //    public string SubGroupName { get; set; }
    //    public string GroupCode { get; set; }
    //    public string SubGroupCode { get; set; }
    //    public long AccessionNumber { get; set; }
    //    public string OverAllStatus { get; set; }
    //    public string DeltaValue { get; set; }
    //    public string DepartmentName { get; set; }
    //    public long UserID { get; set; }
    //    public string UserName { get; set; }
    //    public DateTime CreatedAt { get; set; }
    //    public DateTime UpdatedAt { get; set; }
    //    public string SampleName { get; set; }
    //    public string ConversionValue { get; set; }
    //    public string ConversionUnit { get; set; }
    //    public string ConversionRange { get; set; }
    //    public string Nonreportable { get; set; }
    //    public string ReportName { get; set; }

    //}
    // public class ResultPdf { }
}
