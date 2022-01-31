using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    [Serializable()]
    public class DayWiseCollectionRevenueReport
    {
        #region Fields
        private string data = string.Empty;
        private string centername = string.Empty;
        private string circlename = string.Empty;
        private string transactiondate = string.Empty;
        private string visitdate = string.Empty;
        private string visitnumber = string.Empty;
        private string billnumber = string.Empty;
        private string extpatientid = string.Empty;
        private string patientname = string.Empty;
        private decimal grossamount = Decimal.Zero;
        private decimal discount = Decimal.Zero;
        private decimal netamount = Decimal.Zero;
        private decimal due = Decimal.Zero;
        private decimal cash = Decimal.Zero;
        private decimal cheque = Decimal.Zero;
        private decimal card = Decimal.Zero;
        private decimal prepaid = Decimal.Zero;
        private decimal online = Decimal.Zero;
        private decimal demanddraft = Decimal.Zero;
        private decimal adjustmentamount = Decimal.Zero;
        private decimal collection = Decimal.Zero;
        private string refdocname = string.Empty;
        private string specialization = string.Empty;
        private string sourceName = string.Empty;
        private string salespersonname = string.Empty;
        private string disapprovedby = string.Empty;
        private string discountcomment = string.Empty;
        private string transactiontype = string.Empty;
        private string duetype = string.Empty;

        #endregion

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string CenterName
        {
            get { return centername; }
            set { centername = value; }
        }
        public string Transactiondate
        {
            get { return transactiondate; }
            set { transactiondate = value; }
        }
        public string VisitDate
        {
            get { return visitdate; }
            set { visitdate = value; }
        }
        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }
        public string BillNumber
        {
            get { return billnumber; }
            set { billnumber = value; }
        }

        public string ExtPatientID
        {
            get { return extpatientid; }
            set { extpatientid = value; }
        }

        public string PatientName
        {
            get { return patientname; }
            set { patientname = value; }
        }
        public decimal GrossAmount
        {
            get { return grossamount; }
            set { grossamount = value; }
        }
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal NetAmount
        {
            get { return netamount; }
            set { netamount = value; }
        }
        public decimal Due
        {
            get { return due; }
            set { due = value; }
        }
        public decimal Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public decimal Cheque
             {
                 get { return cheque; }
                 set { cheque = value; }
             }

        public decimal Card
             {
                 get { return card; }
                 set { card = value; }
             }
        public decimal Prepaid
        {
            get { return prepaid; }
            set { prepaid = value; }
        }
        public decimal Online
        {
            get { return online; }
            set { online = value; }
        }
        public decimal DemandDraft
        {
            get { return demanddraft; }
            set { demanddraft = value; }
        }
        public decimal AdjustmentAmount
        {
            get { return adjustmentamount; }
            set { adjustmentamount = value; }
        }
        public decimal Collection
        {
            get { return collection; }
            set { collection = value; }
        }
        public string RefDocName
        {
            get { return refdocname; }
            set { refdocname = value; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        public string SourceName
        {
            get { return sourceName; }
            set { sourceName = value; }
        }
        public string SalespersonName
        {
            get { return salespersonname; }
            set { salespersonname = value; }
        }
        public string DisApprovedBy
        {
            get { return disapprovedby; }
            set { disapprovedby = value; }
        }
        public string DiscountComment
        {
            get { return discountcomment; }
            set { discountcomment = value; }
        }
        public string TransactionType
        {
            get { return transactiontype; }
            set { transactiontype = value; }
        }
        public string DueType
        {
            get { return duetype; }
            set { duetype = value; }
        }




    }       
}