using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class HCBookingModel
    {
        public Bookings BookingsInfo { get; set; }
        public List<OrderedInvModel> OrderedInvestigationInfo { get; set; }
        public List<PreOrdInvModel> PreOrderedInvestigationInfo { get; set; }
        public ContextDetails ContextInfo { get; set; }
    }
  
    public class OrderedInvModel
    {
        public string Name { get; set; }
        public long ID { get; set; }
        public long VisitID { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int OrgID { get; set; }
        public string StudyInstanceUId { get; set; }
        public int ComplaintId { get; set; }
        public int ReferedToOrgID { get; set; }
        public int ReferedToLocation { get; set; }
        public string InvestigationsType { get; set; }
        public long ReferralID { get; set; }
        public string UID { get; set; }
        public string ReferenceType { get; set; }
        public string RefPhyName { get; set; }
        public long RefPhysicianID { get; set; }
        public int SequenceNo { get; set; }
        public DateTime ReportDateTime { get; set; }
        public DateTime TatDateTime { get; set; }
        public string IsStat { get; set; }
        public string SampleID { get; set; }
        public int TestSequenceOrder { get; set; }
    }
    public class PreOrdInvModel
    {
        public string Name { get; set; }
        public long ID { get; set; }
        public long VisitID { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int OrgID { get; set; }
        public decimal Rate { get; set; }
        public decimal  ActualAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SalesAmount { get; set; }
        public string PkgName { get; set; }
        public long PkgID { get; set; }
    }
    
}