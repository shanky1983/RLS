using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PageContextkey
    {
        // long PageID,string BtnName ,long RoleID,
        public long PageID { get; set; }
        public string ButtonName { get; set; }
        public string ButtonValue { get; set; }
        public long RoleID { get; set; }
        public long PatientID { get; set; }
        public long PatientVisitID { get; set; }
        public string RedirectURL { get; set; }
        public string Description { get; set; }
        public string ActionType { get; set; }
        public int OrgID { get; set; }
        public long ID { get; set; }
        public string ContextType { get; set; }
        public bool isActionDisabled { get; set; }
        public string OrgTimeZone { get; set; }
        public long FinalBillID { get; set; }
        public string BillNumber { get; set; }
        public int SampleID { get; set; }
        private string ids = String.Empty;
        public string MessageTemplate { get; set; }
        public long IndentNo { get; set; }

        public string AccessionNo { get; set; }
        public long LabNo { get; set; }
        public long RegPatientID { get; set; }
        public string RateType { get; set; }

        public string FeeID { get; set; }
        public string RefundNo { get; set; }
        public string PhoneNo { get; set; }
        public string ReceiptNo { get; set; }
        public decimal Amount { get; set; }
		public string type { get; set; }
        public string SubType { get; set; }

        public string BillType { get; set; }
        public string DiscountType { get; set; }
        public string Reason { get; set; }
        public string PatientNumber { get; set; }
        public string IDS
        {
            get { return ids; }
            set { ids = value; }
        }
        //public string IDS { get; set; }
    }
}
