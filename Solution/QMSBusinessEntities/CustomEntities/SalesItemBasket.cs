using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class SalesItemBasket
    {
        private int categoryID = 0;
        private long productID = 0;
        private string categoryName = String.Empty;
        private string productName = String.Empty;
        private decimal quantity = 0;
        private int uomID = 0;
        private string description = String.Empty;
        private int locationID = 0;
        private string locationName = String.Empty;
        private string unit = String.Empty;
        private string lsunit = String.Empty;
        private string type = String.Empty;
        private string name = String.Empty;
        private decimal rate = 0;
        private decimal inHandQuantity = 0;
        public decimal stockReceived = 0;
        public decimal stockIssued = 0;
        public decimal stockReturn = 0;
        public decimal stockDamage = 0;
        public decimal amount = 0;
        private DateTime expiryDate = DateTime.MaxValue;
        private long providedby = 0;
        private long iD = 0;
        private string batchNo = String.Empty;
        private DateTime manufacture = DateTime.MaxValue;
        private decimal totalCost = 0;
        private decimal unitPrice = 0;
        private decimal complimentQTY = 0;
        private decimal tax = 0;
        private decimal discount = 0;
        private decimal pOQuantity = 0;
        private string pOUnit = String.Empty;
        private decimal rECQuantity = 0;
        private string rECUnit = String.Empty;
        private int orgAddressID = 0;
        private long orderedQty = 0;
        private string isScheduleHDrug = String.Empty;
        private string sellingUnit = String.Empty;
        private decimal invoiceQty = 0;
        private decimal rcvdLSUQty = 0;
        private long reOrderLevel = 0;
        private string attributes = String.Empty;
        private string attributeDetail = String.Empty;
        private string hasBatchNo = String.Empty;
        private string hasExpiryDate = String.Empty;
        private string hasUsage = String.Empty;
        private int usageCount = 0;
        private string rakNo = String.Empty;
        private decimal mRP = 0;
        private int supplierId = 0;
        private string referenceNo = String.Empty;
        private string supplierName = String.Empty;
        private decimal sellingPrice = 0;
        private decimal tSellingPrice = 0;
        private decimal discOrEnhancePercent = 0;
        private string discOrEnhanceType = String.Empty;
        private string remarks = String.Empty;
        private string feeType = String.Empty;
        public string ProductKey { get; set; }
        public decimal UnitSellingPrice { get; set; }
        public decimal UnitCostPrice { get; set; }
        public long parentProductID = 0;
        public int receivedOrgID = 0;
        public int receivedorgAddID = 0;
        public string ParentProductKey { get; set; }
        public decimal TotalQty { get; set; }
        public decimal IssuedQty { get; set; }
        public string PrescriptionNO { get; set; }
        public string PhysicianName { get; set; }
        public long SalesOrderID { get; set; }
        public int CustomerID { get; set; }
        public long StockOutFlowID { get; set; }
        public long StockReceivedID { get; set; }
        public string InvoiceNo { get; set; }
        public string DCNo { get; set; }
        public long StockInHandID { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal CstTax { get; set; }
        public decimal CsTaxAmount { get; set; }
        public int CustomerLocationID { get; set; }

        public decimal TSellingPrice
        {
            get { return tSellingPrice; }
            set { tSellingPrice = value; }
        }

        public string RakNo
        {
            get { return rakNo; }
            set { rakNo = value; }
        }

        public string HasExpiryDate
        {
            get { return hasExpiryDate; }
            set { hasExpiryDate = value; }
        }



        public string HasBatchNo
        {
            get { return hasBatchNo; }
            set { hasBatchNo = value; }
        }

        public decimal InvoiceQty
        {
            get { return invoiceQty; }
            set { invoiceQty = value; }
        }


        public decimal RcvdLSUQty
        {
            get { return rcvdLSUQty; }
            set { rcvdLSUQty = value; }
        }

        public string SellingUnit
        {
            get { return sellingUnit; }
            set { sellingUnit = value; }
        }



        public int OrgAddressID
        {
            get { return orgAddressID; }
            set { orgAddressID = value; }
        }
        public string POUnit
        {
            get { return pOUnit; }
            set { pOUnit = value; }
        }
        public string RECUnit
        {
            get { return rECUnit; }
            set { rECUnit = value; }
        }

        public decimal POQuantity
        {
            get { return pOQuantity; }
            set { pOQuantity = value; }
        }
        public decimal RECQuantity
        {
            get { return rECQuantity; }
            set { rECQuantity = value; }
        }

        public decimal ComplimentQTY
        {
            get { return complimentQTY; }
            set { complimentQTY = value; }
        }
        public decimal Tax
        {
            get { return tax; }
            set { tax = value; }
        }
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }


        public string BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        public DateTime Manufacture
        {
            get { return manufacture; }
            set { manufacture = value; }
        }


        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public long Providedby
        {
            get { return providedby; }
            set { providedby = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        public long ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int UOMID
        {
            get { return uomID; }
            set { uomID = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public string LSUnit
        {
            get { return lsunit; }
            set { lsunit = value; }
        }
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public decimal InHandQuantity
        {
            get { return inHandQuantity; }
            set { inHandQuantity = value; }
        }
        public decimal StockReceived
        {
            get { return stockReceived; }
            set { stockReceived = value; }
        }
        public decimal StockIssued
        {
            get { return stockIssued; }
            set { stockIssued = value; }
        }
        public decimal StockReturn
        {
            get { return stockReturn; }
            set { stockReturn = value; }
        }
        public decimal StockDamage
        {
            get { return stockDamage; }
            set { stockDamage = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public long OrderedQty
        {
            get { return orderedQty; }
            set { orderedQty = value; }
        }
        // <summary>
        /// Gets or sets the IsScheduleDrug value.
        /// </summary>
        public string IsScheduleHDrug
        {
            get { return isScheduleHDrug; }
            set { isScheduleHDrug = value; }
        }
        public long ReOrderLevel
        {
            get { return reOrderLevel; }
            set { reOrderLevel = value; }
        }
        public string Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }
        public string AttributeDetail
        {
            get { return attributeDetail; }
            set { attributeDetail = value; }
        }
        public string HasUsage
        {
            get { return hasUsage; }
            set { hasUsage = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UsageCount
        {
            get { return usageCount; }
            set { usageCount = value; }
        }
        public decimal MRP
        {
            get { return mRP; }
            set { mRP = value; }
        }
        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }
        public string ReferenceNo
        {
            get { return referenceNo; }
            set { referenceNo = value; }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }
        public decimal SellingPrice
        {
            get { return sellingPrice; }
            set { sellingPrice = value; }
        }
        public decimal ExciseTax { get; set; }
        public decimal DiscOrEnhancePercent
        {
            get { return discOrEnhancePercent; }
            set { discOrEnhancePercent = value; }
        }
        public string DiscOrEnhanceType
        {
            get { return discOrEnhanceType; }
            set { discOrEnhanceType = value; }
        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        public string FeeType
        {
            get { return feeType; }
            set { feeType = value; }
        }
        public long ParentProductID
        {
            get { return parentProductID; }
            set { parentProductID = value; }
        }
        public int ReceivedOrgID
        {
            get { return receivedOrgID; }
            set { receivedOrgID = value; }

        }
        public int ReceivedOrgAddID
        {
            get { return receivedorgAddID; }
            set { receivedorgAddID = value; }
        }




    }
}
