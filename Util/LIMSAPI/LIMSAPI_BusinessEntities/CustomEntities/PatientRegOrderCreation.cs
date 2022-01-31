using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PatientRegOrderCreation: PatientInfo
    {
        public long PatRegOrderID {get;set;}

        public int BookingID  { get; set; }
        public string UserID  { get; set; }
       
  
        public string TRFFile { get; set; }
        public string URNType { get; set; }
        public string URNNo { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string ClientCode { get; set; }
        public string DispatchType { get; set; }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public DateTime SampleCollectionTime { get; set; }
    
        public string SampleStatus { get; set; }
	    public string ReasonSampleCollected { get; set; }
        public string TestName { get; set; }

        public decimal Price  { get; set; }
	    public decimal TotalGrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
	    public decimal ReceivedAmount { get; set; }
 
        public decimal DueAmount { get; set; }

	    public string PaymentStatus { get; set; }
        public string PaymentMode { get; set; }

	    public string CardDetails { get; set; }

	    public string PaymentReferenceNo { get; set; }

        public string ExternalVisitID { get; set; }
    

        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string IsProcessYN { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string ClientID { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }
    }
}
