using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{

    public class HCBookingData
    {
        public int Id { get; set; }
        public string SlNo { get; set; }
        public string OrgName { get; set; }
        public string OrgLocation { get; set; }
        public string BookingDate { get; set; }
        public string CollectionDate { get; set; }
        public string PatientNumber { get; set; }
        public string HealthHubID { get; set; }
        public string EmployeeID { get; set; }
        public string SourceType { get; set; }
        public string Salutation { get; set; }
        public string PatientName { get; set; }
        public string DOB { get; set; }
        public string Age { get; set; }
        public string AgeType { get; set; }
        public string Sex { get; set; }
        public string TestCodes { get; set; }
        public string AmountPaid { get; set; }
        public string AmountDisocunt { get; set; }
        public string ClientCode { get; set; }
        public string Technician { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public string DispatchMode { get; set; }
        public string RefDocName { get; set; }
        public string RefHospName { get; set; }
        public string History { get; set; }
        public string Remarks { get; set; }
        public string BookingID { get; set; }
        public string ExternalRefNo { get; set; }
        public string SampleNumber { get; set; }
        public string Doctor { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public string Pincode { get; set; }
        public string Discount { get; set; }
        public string OrgID { get; set; }
        public string CollectionAddress { get; set; }
        public string Location { get; set; }
        public string RefHospital { get; set; }
        public string Priority { get; set; }

        public string TestRequested { get; set; }
        public decimal Charged { get; set; }

        public decimal AmountDiscount { get; set; }
        public string DiscountReason { get; set; }
        public string DiscountAuthorisedBy { get; set; }

        public bool ErrorStatus { get; set; }

        public string ErrorDesc { get; set; }

        public string TestType { get; set; }

        public string FeeId { get; set; }

        public string TestCode { get; set; }

        public long ClientID { get; set; }

        public long LocationID { get; set; }

        public long OrgLocationID { get; set; }

        public string Title { get; set; }

        public string ValidateData { get; set; }

        public string SCollectedBy { get; set; }

        public long CreatedbyId { get; set; }




        public List<HCTestDetails> TestInformation { get; set; }
    }

    public class HCTestDetails
    {
        public int Id { get; set; }
        public string TestCodes { get; set; }
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
