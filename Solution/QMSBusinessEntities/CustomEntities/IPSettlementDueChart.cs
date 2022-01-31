using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class IPSettlementDueChart
    {
        private long patientID = 0;
        private long visitID = 0;
        private long detailsID = 0;
        private string feeType = String.Empty;       
        private long feeID = 0;
        private string batchNo = String.Empty;
        private DateTime expiryDate = DateTime.MaxValue;
        private string serviceCode = String.Empty;
        private string description = String.Empty;
        private DateTime fromDate = DateTime.MaxValue;
        private DateTime toDate = DateTime.MaxValue;
        private string status = String.Empty;
        private decimal unit = Decimal.Zero;
        private decimal amount = Decimal.Zero;
        private decimal eligibleAmount = Decimal.Zero;
        private decimal coSharing = Decimal.Zero;
        private decimal discountAmount = Decimal.Zero;
        private string isReimbursable = String.Empty;
        private string _fromtable;
        private string _roomtypename;
        private int  rowID = 0;

        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public int  RowID
        {
            get { return rowID; }
            set { rowID = value; }
        }
        
        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        
        /// <summary>
        /// Gets or sets the VisitID value.
        /// </summary>
        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }        

        /// <summary>
        /// Gets or sets the DetailsID value.
        /// </summary>
        public long DetailsID
        {
            get { return detailsID; }
            set { detailsID = value; }
        }      

        /// <summary>
        /// Gets or sets the FeeType value.
        /// </summary>
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }

        /// <summary>
        /// Gets or sets the FeeID value.
        /// </summary>
        public long FeeID
        {
            get { return feeID; }
            set { feeID = value; }
        }
        /// <summary>
        /// Gets or sets the BatchNo value.
        /// </summary>
        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }
        /// <summary>
        /// Gets or sets the ExpiryDate value.
        /// </summary>
        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        /// <summary>
        /// Gets or sets the ServiceCode value.
        /// </summary>
        public string ServiceCode
        {
            get { return serviceCode; }
            set { serviceCode = value; }
        }
        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Gets or sets the FromDate value.
        /// </summary>
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        /// <summary>
        /// Gets or sets the ToDate value.
        /// </summary>
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>
        /// Gets or sets the Unit value.
        /// </summary>
        public decimal Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        /// <summary>
        /// Gets or sets the Amount value.
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Gets or sets the EligibleAmount value.
        /// </summary>
        public decimal EligibleAmount
        {
            get { return eligibleAmount; }
            set { eligibleAmount = value; }
        }

        /// <summary>
        /// Gets or sets the CoSharing value.
        /// </summary>
        public decimal CoSharing
        {
            get { return coSharing; }
            set { coSharing = value; }
        }

        /// <summary>
        /// Gets or sets the DiscountAmount value.
        /// </summary>
        public decimal DiscountAmount
        {
            get { return discountAmount; }
            set { discountAmount = value; }
        }

        /// <summary>
        /// Gets or sets the IsReimbursable value.
        /// </summary>
        public string IsReimbursable
        {
            get { return isReimbursable; }
            set { isReimbursable = value; }
        }

        /// <summary>
        /// Gets or sets the FromTable value.
        /// </summary>
      
        public string FromTable
        {
            get { return _fromtable; }
            set { _fromtable = value; }
        }

        /// <summary>
        /// Gets or sets the RoomTypeName value.
        /// </summary>
      
        public string RoomTypeName
        {
            get { return _roomtypename; }
            set { _roomtypename = value; }
        }

        private int isLineItem = 1;
        public int  IsLineItem
        {
            get { return isLineItem; }
            set { isLineItem = value; }
        }

         private string isadminchargeapplicable = String.Empty;
        public string IsAdminChargeApplicable
        {
            get { return isadminchargeapplicable; }
            set { isadminchargeapplicable = value; }
        }



    }
}
