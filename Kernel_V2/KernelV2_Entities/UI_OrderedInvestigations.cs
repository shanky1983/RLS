using System;

namespace Attune.KernelV2.Entities
{
    public class UI_OrderedInvestigations
    {
        private DateTime dateTime = DateTime.MaxValue;
        public int TestSequenceOrder { get; set; }
        public long VisitID { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public long AccessionNumber { get; set; }
        public string StudyInstanceUId { get; set; }
        public string PerformingPhysicain { get; set; }
        public int ComplaintId { get; set; }
        public int OrgID { get; set; }
        public string InvestigationsType { get; set; }
        public long ReferralID { get; set; }
        public string PaymentStatus { get; set; }
        public string UID { get; set; }
        public int ResCaptureLoc { get; set; }
        public int MPPSStatus { get; set; }
        public long ReferredAccessionNo { get; set; }
        public long TaskID { get; set; }
        public string LabNo { get; set; }
        public long RefPhysicianID { get; set; }
        public string RefPhyName { get; set; }
        public string ReferenceType { get; set; }
        public string ReferredType { get; set; }
        public string InvestigationComment { get; set; }
        public int PrintCount { get; set; }
        public string VisitSampleStatus { get; set; }
        public DateTime SamplePickupDate { get { return dateTime; } set { dateTime = value; } }
        public long PkgID { get; set; }
        public string PkgName { get; set; }
        public string IsStat { get; set; }
        public DateTime ReportDateTime { get { return dateTime; } set { dateTime = value; } }
        public DateTime TatDateTime { get { return dateTime; } set { dateTime = value; } }
        public string SortedTask { get; set; }
        public string Print_Task { get; set; }
        public int Print_taskid { get; set; }
        public string IsCoPublish { get; set; }
        public string IsBlindingClient { get; set; }
        public string IsSensitive { get; set; }
        public bool Isarchive { get; set; }
        public long OrderedID { get; set; }
        public long BillingID { get; set; }
        public DateTime ReportCommitTime { get { return dateTime; } set { dateTime = value; } }
        public string RecollectNotify { get; set; }
        public long PhysicianID { get; set; }
        public string OrderType { get; set; }
        public string BarcodeNumber { get; set; }
        public string Updatestauts { get; set; }
        public long OrderID { get; set; }
        public string Deviceid { get; set; }
        public string TestCode { get; set; }
        public long OrderTaskID { get; set; }
        public decimal OrderedQty { get; set; }
        public long PatientVisitAttribID { get; set; }
        public long PerphyID { get; set; }
        public string Perphyname { get; set; }
        public string Performertype { get; set; }
        public string SampleID { get; set; }
        public byte IsIntegrationTest { get; set; }
        public decimal Rate { get; set; }
        public long InvestigationID { get; set; }
        public long GroupID { get; set; }
        public string InvestigationName { get; set; }
        public string GroupName { get; set; }
        public long ReferedToOrgID { get; set; }
        public long ReferedToLocation { get; set; }
        public int SequenceNo { get; set; }
        public string PatientIdentifyID { get; set; }
        public string PrintSeparately { get; set; }
        public string DeptID { get; set; }
        public string DisplayStatus { get; set; }
        public string IsAutoAuthorize { get; set; }
        public string Isbillable { get; set; }
        public string ExcludeVIDlock { get; set; }
        public string LoginName { get; set; }
        public string VisitNumber { get; set; }
        public string PatientNumber { get; set; }
        public string Age { get; set; }
        public string CodeName { get; set; }
        public object CreatedBy { get; set; }
        public object ModifiedBy { get; set; }
    }
}
