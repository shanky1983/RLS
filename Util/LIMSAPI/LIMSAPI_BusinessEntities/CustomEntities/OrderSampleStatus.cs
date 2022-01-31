using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrderSampleStatus
    {
        public string OrderId { get; set; }
        public string OrgCode { get; set; }
        public string OverAllStatus { get; set; }
        public ResPatientDetails PatientInfo { get; set; }
        public RePatientVisitDetails PatientVisitInfo { get; set; }
        public CorporatePatients CorporatePatient { get; set; }
        public List<TestOrderSample> OrderInfo { get; set; }
    //    public byte[] ResultAsPdf { get; set; }
     //   public byte[] OutsourceAsPdf { get; set; }
    }
   
    public class TestOrderSample
    {
        public long PatientVisitID { get; set; }
        public long ExternalVisitID { get; set; }
        public string TestID { get; set; }
        public string TestCode { get; set; }
        public string OrderedDate { get; set; }
        public string TestType { get; set; }
        public string TestName { get; set; }
        public string TestValueType { get; set; }
        public string TestValue { get; set; }
        public string UOMCode { get; set; }
        public string MethodName { get; set; }
        public string DepartmentName { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string ResultCapturedAt { get; set; }
        public string TestStatus { get; set; }
        public string MedicalRemarks { get; set; }
        public string InterpretationNotes { get; set; }
        public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
        public string ProcessingLocation { get; set; }
        public string SampleCollectionDateTime { get; set; }
        public string DeviceID { get; set; }
        public string LotNumber { get; set; }
        public string DeltaValue { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string SampleName { get; set; }
        public string ConversionValue { get; set; }
        public string ConversionUnit { get; set; }
        public string ConversionRange { get; set; }
        public string Nonreportable { get; set; }
        public string ReportName { get; set; }
        public List<TestOrderSampleContentVisit> OrderContentListInfo { get; set; }
        //public byte[] ResultAsPdf { get; set; }
    }
    public class TestOrderSampleContentVisit
    {
        public string TestCode { get; set; }
        public string OrderedDate { get; set; }
        public string TestType { get; set; }
        public string TestID { get; set; }
        public string TestName { get; set; }
        public string TestValueType { get; set; }
        public string TestValue { get; set; }
        public string UOMCode { get; set; }
        public string MethodName { get; set; }
        public string DepartmentName { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string ResultCapturedAt { get; set; }
        public string TestStatus { get; set; }
        public string MedicalRemarks { get; set; }
        public string InterpretationNotes { get; set; }
        public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
        public string ProcessingLocation { get; set; }
        public string SampleCollectionDateTime { get; set; }
        public string DeviceID { get; set; }
        public string LotNumber { get; set; }
        public string DeltaValue { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string SampleName { get; set; }
        public string ConversionValue { get; set; }
        public string ConversionUnit { get; set; }
        public string ConversionRange { get; set; }
        public string Nonreportable { get; set; }
        public string ReportName { get; set; }
        public List<TestOrderSampleVisit> ParameterListInfo { get; set; }
    }
    public class TestOrderSampleVisit
    {
        public string TestCode { get; set; }
        public string OrderedDate { get; set; }
        public string TestType { get; set; }
        public string TestID { get; set; }
        public string TestName { get; set; }
        public string TestValueType { get; set; }
        public string TestValue { get; set; }
        public string UOMCode { get; set; }
        public string MethodName { get; set; }
        public string DepartmentName { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string ResultCapturedAt { get; set; }
        public string TestStatus { get; set; }
        public string MedicalRemarks { get; set; }
        public string InterpretationNotes { get; set; }
        public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
        public string ProcessingLocation { get; set; }
        public string SampleCollectionDateTime { get; set; }
        public string DeviceID { get; set; }
        public string LotNumber { get; set; }
        public string DeltaValue { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string SampleName { get; set; }
        public string ConversionValue { get; set; }
        public string ConversionUnit { get; set; }
        public string ConversionRange { get; set; }
        public string Nonreportable { get; set; }
        public string ReportName { get; set; }
    }
    public class TestOrderSampleVisitDetails
    {
        public long PatientVisitID { get; set; }
        public long ExternalVisitID { get; set; }
        public string TestID { get; set; }
        public string TestCode { get; set; }
        public DateTime OrderedDate { get; set; }
        public string TestType { get; set; }
        public string TestName { get; set; }
        public string TestValueType { get; set; }
        public string TestValue { get; set; }
        public string UOMCode { get; set; }
        public string MethodName { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public DateTime ResultCapturedAt { get; set; }
        public string TestStatus { get; set; }
        public string MedicalRemarks { get; set; }
        public string InterpretationNotes { get; set; }
        public string ProcessingType { get; set; }    //IN-Inhouse,OS-OutSource,FOS-ForceOutSource
        public string ProcessingLocation { get; set; }
        public DateTime SampleCollectionDateTime { get; set; }
        public string DeviceID { get; set; }
        public string LotNumber { get; set; }
        public string PKGID { get; set; }
        public string PKGName { get; set; }
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public string Status { get; set; }
        public string SubGroupID { get; set; }
        public string SubGroupName { get; set; }
        public string GroupCode { get; set; }
        public string SubGroupCode { get; set; }
        public long AccessionNumber { get; set; }
        public string OverAllStatus { get; set; }
        public string DeltaValue { get; set; }
        public string DepartmentName { get; set; }
        public long UserID { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string SampleName { get; set; }
        public string ConversionValue { get; set; }
        public string ConversionUnit { get; set; }
        public string ConversionRange { get; set; }
        public string Nonreportable { get; set; }
        public string ReportName { get; set; }

    }
    // public class ResultPdf { }

}
