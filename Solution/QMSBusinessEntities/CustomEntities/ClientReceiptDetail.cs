using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ClientReceiptDetail
    {
        private long id = 0;
        private DateTime date = DateTime.MaxValue;
        private int orgid = 0;
        private DateTime from = DateTime.MaxValue;
        private DateTime to = DateTime.MaxValue;
        private string sourcecode = string.Empty;
        private string subsourcecode = string.Empty;
        private decimal amount = 0;
        private string mode = string.Empty;
        private string chequeno = string.Empty;
        private DateTime chequedate = DateTime.MaxValue;
        private string bankcode = string.Empty;
        private string bankname = string.Empty;
        private string acccode = string.Empty;
        private string remarks = string.Empty;
        private string depositedby = string.Empty;
        private string status = string.Empty;
        private string clientname = string.Empty;
        private string clientcode = string.Empty;
        private string incharge = string.Empty;
        private string address1 = string.Empty;
        private string address2 = string.Empty;
        private string city = string.Empty;
        private string pincode = string.Empty;
        private string state = string.Empty;
        private string country = string.Empty;
        private long createdby = 0;
        private long modifiedby = 0;
        private DateTime createdat = DateTime.MaxValue;
        private DateTime modifiedat = DateTime.MaxValue;
        private int count = 0;
        private string responsecode = string.Empty;
        private string responsemsg = string.Empty;
        private string paymentreceiptno = string.Empty;
        private string transactionid = string.Empty;
        private string authidcode = string.Empty;
        private string category = string.Empty;


        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int OrgID
        {
            get { return orgid; }
            set { orgid = value; }
        }

        public DateTime From
        {
            get { return from; }
            set { from = value; }
        }
        public DateTime To
        {
            get { return to; }
            set { to = value; }
        }
        public string SourceCode
        {
            get { return sourcecode; }
            set { sourcecode = value; }
        }
        public string SubSourceCode
        {
            get { return subsourcecode; }
            set { subsourcecode = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        public string ChequeNo
        {
            get { return chequeno; }
            set { chequeno = value; }
        }
        public DateTime ChequeDate
        {
            get { return chequedate; }
            set { chequedate = value; }
        }
        public string BankCode
        {
            get { return bankcode; }
            set { bankcode = value; }
        }
        public string BankName
        {
            get { return bankname; }
            set { bankname = value; }
        }
        public string AccCode
        {
            get { return acccode; }
            set { acccode = value; }
        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        public string DepositedBy
        {
            get { return depositedby; }
            set { depositedby = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string ClientName
        {
            get { return clientname; }
            set { clientname = value; }
        }
        public string ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }
        public string InCharge
        {
            get { return incharge; }
            set { incharge = value; }
        }
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }     
        public long CreatedBy
        {
            get { return createdby; }
            set { createdby = value; }
        }
        public long ModifiedBy
        {
            get { return modifiedby; }
            set { modifiedby = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdat; }
            set { createdat = value; }
        }
        public DateTime ModifiedAt
        {
            get { return modifiedat; }
            set { modifiedat = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public string ResponseCode
        {
            get { return responsecode; }
            set { responsecode = value; }
        }
        public string ResponseMsg
        {
            get { return responsemsg; }
            set { responsemsg = value; }
        }
        public string PaymentReceiptNo
        {
            get { return paymentreceiptno; }
            set { paymentreceiptno = value; }
        }
        public string TransactionID
        {
            get { return transactionid; }
            set { transactionid = value; }
        }
        public string AuthIDCode
        {
            get { return authidcode; }
            set { authidcode = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }


    }
}
