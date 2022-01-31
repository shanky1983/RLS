using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BillSearch
    {
        private long billID = 0;
        private long clientID = 0;
        private DateTime billDate = DateTime.MaxValue;
        private string titleName = String.Empty;
        private string name = String.Empty;
        private string drName = String.Empty;
        private string refOrgName = String.Empty;
        private string clientName = String.Empty;
        private decimal amount = 0;
        private long patientID = -1;
        private long patientVisitId = -1;
        private string status = string.Empty;
        private string billedby = string.Empty;
        private string patientNumber = string.Empty;
        private string RefundStatus;
        private string age =string.Empty;
        private decimal amountreceived = 0;
        private string visitstate = string.Empty;
        private long finalBillID = -1;
        private string Collectiontype = string.Empty;
        private string visitNumber = string.Empty;
        private string barcodeNumber = string.Empty;
        private string isTransfered = string.Empty;
        private string type = string.Empty;
        private int isFranchisee = 0;
        
        //Added by Thamilselvan on 01/31/2015...
        private string membershipCardNo = string.Empty;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public long FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }
        public string VisitState
        {
            get { return visitstate; }
            set { visitstate = value; }
        }

        private int visitType = 0;
        private string isCreditBill = string.Empty;
        public int VisitType
        {
            get { return visitType; }
            set { visitType = value; }
        }
        public string IsCreditBill
        {
            get { return isCreditBill; }
            set { isCreditBill = value; }
        }

    
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }

        public long BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        public DateTime BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string TitleName
        {
            get { return titleName; }
            set { titleName = value; }
        }
        public string DrName
        {
            get { return drName; }
            set { drName = value; }
        }
        public string RefOrgName
        {
            get { return refOrgName; }
            set { refOrgName = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public long PaymentDetailsID { get; set; }
        public string BillNumber { get; set; }
        public string BilledBy
        {
            get { return billedby; }
            set { billedby = value; }
        }
        public string PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }
        public string Refundstatus
        {
            get { return RefundStatus; }
            set { RefundStatus = value; }
        }

        public decimal AmountReceived
        {
            get { return amountreceived; }
            set { amountreceived = value; }
        }
        public string CollectionType
        {
            get { return Collectiontype; }
            set { Collectiontype = value; }
        }
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }
        private String _IsCoPaymentBill;
        public String IsCoPaymentBill
        {
            get { return _IsCoPaymentBill; }
            set { _IsCoPaymentBill = value; }

        }
		 public string BarcodeNumber
        {
            get { return barcodeNumber; }
            set { barcodeNumber = value; }
        }
        public string IsTransfered
        {
            get { return isTransfered; }
            set { isTransfered = value; }
        }

        //Added by Thamilselvan on 01/31/2015...for Bill search...
        public string MembershipCardNo
        {
            get { return membershipCardNo; }
            set { membershipCardNo = value; }
        }
        public int IsFranchisee
        {
            get { return isFranchisee; }
            set { isFranchisee = value; }
        }

    }
}
