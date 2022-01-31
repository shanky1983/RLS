using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class OrderedInvestigationEMR
    {


        public long AccessionNumber { get; set; }
        public string BarcodeNumber { get; set; }
        public int ComplaintId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public string DeptID { get; set; }
        public string Deviceid { get; set; }
        public long GroupID { get; set; }
        public string GroupName { get; set; }
        public long ID { get; set; }
        public string InvestigationComment { get; set; }
        public long InvestigationID { get; set; }
        public string InvestigationName { get; set; }
        public string InvestigationsType { get; set; }
        public string IsStat { get; set; }
        public string LabNo { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long ModifiedBy { get; set; }
        public string Name { get; set; }
        public long OrderID { get; set; }
        public string OrderType { get; set; }
        public int OrgID { get; set; }
        public string PaymentStatus { get; set; }
        public string Performertype { get; set; }
        public string PerformingPhysicain { get; set; }
        public string Perphyname { get; set; }
        public long PhysicianID { get; set; }
        public string Remarks { get; set; }
        public string StudyInstanceUId { get; set; }
        public long TaskID { get; set; }
        public string Type { get; set; }
        public string UID { get; set; }
        public long VisitID { get; set; }
    }
}
