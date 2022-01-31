using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class InfectionTestResultInfo
    {
        public long InfTestResultID { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string ClientID { get; set; }
        public string PatientID { get; set; }
        public string TitleName { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBrith { get; set; }
        public string EMailID { get; set; }
        public string Age { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public long ClientCode { get; set; }
        public string ClientName { get; set; }
        public string PhysicianName { get; set; }
        public string PhysicianCode { get; set; }
        public string Hospitalname { get; set; }
        public string HospitalCode { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string Patientcategory { get; set; }
        public string VisitType { get; set; }
        public string BedWardInfo { get; set; }
        public string URNType { get; set; }
        public string URNNo { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string ParameterCode { get; set; }
        public string ParameterName { get; set; }
        public string ResultType { get; set; }
        public string ResultValue { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string IsCritical { get; set; }
        public string Status { get; set; }

      
   
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ISProcessed { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }
    }
    public class InfectTestResultInfo
        {
       public long OrgID { get; set; }
    public long LocationID { get; set; }
    public string ClientID { get; set; }
    public string PatientID { get; set; }
    public string TitleName { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DateofBrith { get; set; }
    public string EMailID { get; set; }
    public string Age { get; set; }
    public string MobileNumber { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public long ClientCode { get; set; }
    public string ClientName { get; set; }
    public string PhysicianName { get; set; }
    public string PhysicianCode { get; set; }
    public string Hospitalname { get; set; }
    public string HospitalCode { get; set; }
    public string ExternalPatientNumber { get; set; }
    public string Patientcategory { get; set; }
    public string VisitType { get; set; }
    public string BedWardInfo { get; set; }
    public string URNType { get; set; }
    public string URNNo { get; set; }
    public string TestCode { get; set; }
    public string TestName { get; set; }
    public string ParameterCode { get; set; }
    public string ResultType { get; set; }
     
    
         public string ResultValue { get; set; }
    public string ReferenceRange { get; set; }
    public string IsAbnormal { get; set; }
    public string IsCritical { get; set; }
    public string Status { get; set; }
    public string ApprovedBy { get; set; }
    public string ApprovedDateTime { get; set; }

    public string InvestigationName { get; set; }
    public string InvestigationID { get; set; }

    public string _Name { get; set; }
    public string _Code { get; set; }
    public string _DrugCode { get; set; }
    public string _DrugName { get; set; }
    public string _Sensitivity { get; set; }
    public string _Zone { get; set; }
        public string Type { get; set; }
}    
        
public class OrderInfo
{
        public string Type { get; set; }
    public string TestCode { get; set; }
public string   TestName  { get; set; }
public string    ParameterCode  { get; set; }
public string    ResultType  { get; set; }
     public List<ResultValue> ResultValue  { get; set; }
public string    ReferenceRange { get; set; }
public string    IsAbnormal { get; set; }
public string    IsCritical  { get; set; }
public string    Status  { get; set; }
public string    ApprovedBy  { get; set; }
public string   ApprovedDateTime  { get; set; }
}
public class ResultValue
{
           public List<InvestigationResults> InvestigationResults { get; set; }
    
    }
public class InvestigationResults
{
  public List<InvestigationDetails> InvestigationDetails { get; set; }
}
public class InvestigationDetails
{
     public string InvestigationName { get; set; }
      public string InvestigationID { get; set; }
        //  public List<OrganDetails> OrganDetails { get;set;}
        public List<Organ> OrganDetails { get; set; }
    }
public class OrganDetails
    {
    
        public List<Organ> Organ { get; set; }
}

public class Organ
{

    public string _Name { get; set; }
    public string _Code { get; set; }
    public string _DrugCode { get; set; }
    public string _DrugName { get; set; }
    public string _Sensitivity { get; set; }
    public string _Zone { get; set; }
}
    public class Investigation
    {

        public long InvestigationID { get; set; }
        public long InvestigationValueID { get; set; }
        public string Name { get; set; }
        public string InvestigationName { get; set; }
        public int Value { get; set; }
        public string GroupName { get; set; }
        public string Comments { get; set; }
        public string UOMCode { get; set; }
        public string ReportStatus { get; set; }
        public string MedicalRemarks { get; set; }
        public string PackageName { get; set; }

    }
}
