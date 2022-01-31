using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ClientCreditDebit
    {
        private long id = 0;
        private DateTime date = DateTime.MaxValue;
        private int orgid = 0;
        private string category = string.Empty;
        private DateTime from = DateTime.MaxValue;
        private DateTime to = DateTime.MaxValue;
        private string sourcecode = string.Empty;
        private string subsourcecode = string.Empty;
        private string narration = string.Empty;
        private string barcode = string.Empty;
        private string remarks = string.Empty;
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
        private decimal amount = 0;
        private long createdby = 0;
        private long modifiedby = 0;
        private DateTime createdat = DateTime.MaxValue;
        private DateTime modifiedat = DateTime.MaxValue;
        private int count = 0;
        private string type = string.Empty;

        public long Id
        {
            get { return id ; }
            set { id  = value; }
        }
        public DateTime  Date
        {
            get { return date ; }
            set { date  = value  ; }
        }
        public int OrgID
        {
            get { return orgid ; }
            set { orgid  = value; }
        }
        public string Category
        {
            get { return category; }
            set { category  = value; }
        }
        public string  SourceCode
        {
            get { return sourcecode; }
            set { sourcecode  = value; }
        }
        public string SubSourceCode
        {
            get { return subsourcecode ; }
            set { subsourcecode  = value; }
        }
        public string Narration
        {
            get { return narration; }
            set { narration  = value; }
        }
        public string Barcode
        {
            get { return barcode ; }
            set { barcode  = value; }
        }
        public string Remarks
        {
            get { return remarks ; }
            set { remarks  = value; }
        }
        public string Status
        {
            get { return status; }
            set { status  = value; }
        }
        public string ClientName
        {
            get { return clientname ; }
            set { clientname = value; }
        }
        public string ClientCode
        {
            get { return clientcode ; }
            set { clientcode  = value; }
        }
        public string InCharge
        {
            get { return incharge ; }
            set { incharge  = value; }
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
            get { return city ; }
            set { city  = value; }
        }
        public string Pincode
        {
            get { return pincode ; }
            set { pincode  = value; }
        }
        public string State
        {
            get { return state; }
            set { state  = value; }
        }
        public string Country
        {
            get { return country; }
            set { country  = value; }
        }
        public decimal Amount
        {
            get { return amount ; }
            set { amount  = value; }
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
            set { count  = value; }
        }
        public string Type
        {
            get { return type ; }
            set { type = value; }
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
        
      
    }
}
