using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities.CustomEntities
{
    public class CampDetails
    {
        #region Fields
        /*BEGIN | 128 | Thiyagu | 20163103 | M | Bulk Registration for camps*/
        public int Id { get; set; }
        public string OrgName { get; set; }
        public int SlNo { get; set; }
        public string PDate { get; set; }
        public string SDate { get; set; }
        public string SCollectedBy { get; set; }
        public string PatId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Age { get; set; }
        public string AgeType { get; set; }
        public string Sex { get; set; }
        public string Location { get; set; }
        public string Doctor { get; set; }
        public string RefHospital { get; set; }
        public string Priority { get; set; }
        public string DispatchMode { get; set; }
        public string TestRequested { get; set; }
        public decimal Charged { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountDiscount { get; set; }
        public string DiscountReason { get; set; }
        public string DiscountAuthorisedBy { get; set; }
        public string History { get; set; }
        public string Remarks { get; set; }
        public string MobileNo { get; set; }
        public string CreatedBy { get; set; }
        public string ClientCode { get; set; }
        public string EmailId { get; set; }
        public string PatientNumber { get; set; }
        public string HealthHubID { get; set; }
        public string EmployeeID { get; set; }
        public string SourceType { get; set; }

        public bool ErrorStatus { get; set; }
        public string ErrorDesc { get; set; }
        public string ValidateData { get; set; }
        public long ClientID { get; set; }
        public long LocationID { get; set; }
        public long TitleID { get; set; }
        public long DoctorID { get; set; }
        public long RefHospitalID { get; set; }
        public string TestCode { get; set; }
        public long SCollectedByID { get; set; }
        public int PriorityID { get; set; }
        public string IsClientPatient { get; set; }
        public long CreatedbyId { get; set; }
        public long RateId { get; set; }
        public string TestType { get; set; }
        public string FeeId { get; set; }
        public int CampId { get; set; }
        public string IsDiscountable { get; set; }
        public decimal DueAmount { get; set; }
        public int OrgId { get; set; }
        public long DiscountAuthorisedByID { get; set; }
        public string HasHealthCoupon { get; set; }
        public string MyCardActiveDays { get; set; }
        public string IsCreditBill { get; set; }

        public string VisitNumber { get; set; }
        public string BillNumber { get; set; }
        public string TestDetails { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }


        public List<TestDetails> TestInformation { get; set; }
	    public string BookingID { get; set; }
        public string ExternalRefNo { get; set; }
        public string SampleNumber { get; set; }
        public string SRFID { get; set; }
        public string TRFID { get; set; }
        public string PassportNo { get; set; } 
        #endregion
    }

    public class TestDetails
    {
        public int Id { get; set; }
        public string TestRequested { get; set; }
        public decimal Charged { get; set; }
        public string ErrorDesc { get; set; }
        public string TestCode { get; set; }
        public long RateId { get; set; }
        public string TestType { get; set; }
        public string FeeId { get; set; }
        public int CampId { get; set; }
        public string IsDiscountable { get; set; }

    }
}
