using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BarcodePattern
    {
        public string BarcodeNumber { get; set; }
        public string PatientName { get; set; }
        public string PatientNumber { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string TestCode { get; set; }
        public DateTime? CollectedDateTime { get; set; }
        public string VisitType { get; set; }
        public string VisitCategory { get; set; }
        public string SampleType { get; set; }
        public string Location { get; set; }
        public DateTime? RegisteredDateTime { get; set; }
        public string DeptCode { get; set; }
        public string BillNumber { get; set; }
        public string VisitNumber { get; set; }
        public string PatientStatus { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ExpDate { get; set; }
        public DateTime? AssemblyDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string IndentNo { get; set; }
        public string IssuedIndentNo { get; set; }
        public DateTime? DespatchDate { get; set; }
        public string LocationName { get; set; }
        public string OrgName { get; set; }
        public string VName { get; set; }
        public string ProtoCol { get; set; }
        public string NoOfprint { get; set; }
        public string VisitCount { get; set; }
        public long VisitID { get; set; }
        public int SampleID { get; set; }
        public string TestStatus { get; set; }
        public long ID { get; set; }
    }
}
