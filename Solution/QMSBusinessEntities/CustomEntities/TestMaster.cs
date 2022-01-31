using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class TestMaster
    {
        public int OrgID { get; set; }
        public long InvestigationID { get; set; }
        public string InvestigationName { get; set; }
        public string DisplayText { get; set; }
        public string BillingName { get; set; }
        public int DeptID { get; set; }
        public int SampleCode { get; set; }
        public long MethodID { get; set; }
        public long PrincipleID { get; set; }
        public string Interpretation { get; set; }
        public int SampleContainerID { get; set; }
        public int ProcessingAddressID { get; set; }
        public long AutoApproveLoginID { get; set; }
        public long RoleID { get; set; }
        public string ResultValueType { get; set; }
        public decimal CPT { get; set; }
        public decimal CPRT { get; set; }
        public string DecimalPlaces { get; set; }
        public int CutOffTimeValue { get; set; }
        public string CutOffTimeType { get; set; }
        public string Classification { get; set; }
        public string SubCategory { get; set; }
        public string IsOrderable { get; set; }
        public string QCData { get; set; }
        public string IsInterfaced { get; set; }
        public string IsSMS { get; set; }
        public string IsServiceTax { get; set; }
        public string IsNABL { get; set; }
        public string IsCAP { get; set; }
        public string IsDiscountable { get; set; }
        public string IsRepeatable { get; set; }
        public string IsSTAT { get; set; }
        public string IsActive { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string IsNonReportable { get; set; }
        public string PrintSeparately { get; set; }
        public long HeaderID { get; set; }
        public string GetWorkList { get; set; }
        public int IsTATrandom { get; set; }
        public int ProtocalGroupID { get; set; }
			public long  PreSampleConditionID { get; set; }
		public long  PostSampleConditionID { get; set; }
        public string ReferenceRangeString { get; set; }
		public string IsRefundable { get; set; }
    }
}
