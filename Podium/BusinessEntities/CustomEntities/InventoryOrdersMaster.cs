using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{ [Serializable ] 
    public class InventoryOrdersMaster
    { 
        #region Fields
        private long orderID = 0;
        private DateTime orderDate = DateTime.MaxValue;
        private string orderNo = String.Empty;
        private int orgID = 0;
        private int supplierID = 0;
        private int branchID = 0;
        private string status = String.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long approvedBy = 0;
        private DateTime approvedAt = DateTime.MaxValue;
        private string comments = String.Empty;
        private string poNo = String.Empty;
        private string supplierName = string.Empty;
        private decimal amount = 0;
        private string invoiceNo = string.Empty;
        private decimal debitAmount = 0;
        private string referenceNo = String.Empty;
        private long purchaseorderid = 0;

        private DateTime stockreceiveddate = DateTime.MaxValue;
        private string dcno = string.Empty;
        private string stockreceivedno = string.Empty;
        private bool _IsRate;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the PoNo value.
        /// </summary>
        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }

        /// <summary>
        /// Gets or sets the PoNo value.
        /// </summary>
        public string PoNo
        {
            get { return poNo; }
            set { poNo = value; }
        }
        /// <summary>
        /// Gets or sets the SupplierName value.
        /// </summary>
        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }
        /// <summary>
        /// Gets or sets the OrderID value.
        /// </summary>
        public long OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        /// <summary>
        /// Gets or sets the OrderDate value.
        /// </summary>
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        /// <summary>
        /// Gets or sets the OrderNo value.
        /// </summary>
        public string OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the SupplierID value.
        /// </summary>
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        /// <summary>
        /// Gets or sets the BranchID value.
        /// </summary>
        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
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
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedAt value.
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }

        /// <summary>
        /// Gets or sets the ApprovedBy value.
        /// </summary>
        public long ApprovedBy
        {
            get { return approvedBy; }
            set { approvedBy = value; }
        }

        /// <summary>
        /// Gets or sets the ApprovedAt value.
        /// </summary>
        public DateTime ApprovedAt
        {
            get { return approvedAt; }
            set { approvedAt = value; }
        }

        /// <summary>
        /// Gets or sets the Comments value.
        /// </summary>
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public decimal DebitAmount
        {
            get { return debitAmount; }
            set { debitAmount = value; }
        }
        public string ReferenceNo
        {
            get { return referenceNo; }
            set { referenceNo = value; }
        }
        public DateTime StockReceivedDate
        {
            get { return stockreceiveddate; }
            set { stockreceiveddate = value; }
        }
      
        public string DCN0
        {
            get { return dcno; }
            set { dcno = value; }
        }
        public string SRDNo
        {
            get { return stockreceivedno; }
            set { stockreceivedno = value; }
        }

        DateTime invoiceDate = DateTime.MaxValue;
        public DateTime  InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }


        /// <summary>
        /// Gets or sets the IsRate value.
        /// </summary>
        public bool IsRate
        {
            get { return _IsRate; }
            set { _IsRate = value; }
        }

        public long PurchaseOrderID
        {
            get { return purchaseorderid; }
            set { purchaseorderid = value; }
        }
        public int _StatusId;
        public int StatusID
        {
            get { return _StatusId; }
            set { _StatusId = value; }
        }
        public int _TaskStatusId;
        public int TaskStatusId
        {
            get { return _TaskStatusId; }
            set { _TaskStatusId = value; }
        }
        #endregion
    }
}
