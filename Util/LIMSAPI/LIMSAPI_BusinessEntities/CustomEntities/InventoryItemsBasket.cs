using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class InventoryItemsBasket
    {

            //private string productCode = String.Empty;
            //private string batchNo = String.Empty;
            //private string recUnit = String.Empty;
            //private int invoiceQty = 0;         
            //private long productID = 0;
            //private string lsunit = String.Empty;
            //private DateTime expiryDate;
            //private DateTime mfDate;

            //public string ProductCode
            //{
            //get { return productCode; }
            //set { productCode = value; }
            //}

            //public long ProductID
            //{
            //    get { return productID; }
            //    set { productID = value; }
            //}
            //public string BatchNo
            //{
            //get { return batchNo; }
            //set { batchNo = value; }
            //}
            //public string RECUnit
            //{
            //get { return recUnit; }
            //set { recUnit = value; }
            //}

            //public int InvoiceQty
            //{
            //    get { return invoiceQty; }
            //    set { invoiceQty = value; }
            //}
            //public string LSUnit
            //{
            //get { return lsunit; }
            //set { lsunit = value; }
            //}
            //public DateTime ExpiryDate
            //{
            //get { return expiryDate; }
            //set { expiryDate = value; }
            //}

            //public DateTime MfDate
            //{
            //    get { return mfDate; }
            //    set { mfDate = value; }
            //}


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
        private decimal toInHandQuantity = 0;
        private long receivedUniqueNumber = 0;
        private string receivedBatchNo = String.Empty;

        public decimal ToInHandQuantity
        {
            get { return toInHandQuantity; }
            set { toInHandQuantity = value; }
        }
        private decimal fromInHandQuantity = 0;

        public decimal FromInHandQuantity
        {
            get { return fromInHandQuantity; }
            set { fromInHandQuantity = value; }
        }
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
        private decimal actualAmount = 0;
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
        public long physicianID = 0;
        private long productReceivedDetailsID = 0;
        private long stockReceivedID = 0;

        private string isTransactionBlock = String.Empty;
        public string receiptNo = String.Empty;
        private decimal taxAmount = 0;

        public decimal TaxAmount
        {
            get { return taxAmount; }
            set { taxAmount = value; }
        }
        private decimal taxPercent = 0;

        public decimal TaxPercent
        {
            get { return taxPercent; }
            set { taxPercent = value; }
        }
        private string isSmsNeeded = String.Empty;

        public string IsSmsNeeded
        {
            get { return isSmsNeeded; }
            set { isSmsNeeded = value; }
        }
        public string ReceiptNo
        {
            get { return receiptNo; }
            set { receiptNo = value; }
        }
        public string laundryStatus = String.Empty;

        public string LaundryStatus
        {
            get { return laundryStatus; }
            set { laundryStatus = value; }
        }

        public string IsTransactionBlock
        {
            get { return isTransactionBlock; }
            set { isTransactionBlock = value; }
        }

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
        public decimal ActualAmount
        {
            get { return actualAmount; }
            set { actualAmount = value; }
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
        private decimal eligibleAmount = 0;
        public decimal EligibleAmount
        {
            get { return eligibleAmount; }
            set { eligibleAmount = value; }
        }
        private long clientFeeRateCustID = 0;
        public long ClientFeeRateCustID
        {
            get { return clientFeeRateCustID; }
            set { clientFeeRateCustID = value; }
        }

        DateTime invoiceDate = DateTime.MaxValue;
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }

        int stockStatus = 0;
        public int StockStatus
        {
            get { return stockStatus; }
            set { stockStatus = value; }
        }


        decimal defectiveQty = 0;
        public decimal DefectiveQty
        {
            get { return defectiveQty; }
            set { defectiveQty = value; }
        }

        string comments = string.Empty;
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private decimal shortage = Decimal.Zero;
        private decimal damage = Decimal.Zero;
        private decimal rejected = Decimal.Zero;
        /// <summary>
        /// Gets or sets the Shortage value.
        /// </summary>
        public decimal Shortage
        {
            get { return shortage; }
            set { shortage = value; }
        }

        /// <summary>
        /// Gets or sets the Damage value.
        /// </summary>
        public decimal Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        /// <summary>
        /// Gets or sets the Rejected value.
        /// </summary>
        public decimal Rejected
        {
            get { return rejected; }
            set { rejected = value; }
        }
        private decimal prepareCharges = 0;
        public decimal PrepareCharges
        {
            get { return prepareCharges; }
            set { prepareCharges = value; }
        }

        private decimal sellingMarginValue = 0;
        public decimal SellingMarginValue
        {
            get { return sellingMarginValue; }
            set { sellingMarginValue = value; }
        }

        private decimal costMarginValue = 0;
        public decimal CostMarginValue
        {
            get { return costMarginValue; }
            set { costMarginValue = value; }
        }
        #region Centralhospital
        /*Added by petchi*/
        public string productCode = String.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        #endregion

        private decimal copayValue = 0;
        public decimal CopayValue
        {
            get { return copayValue; }
            set { copayValue = value; }
        }
        private string copayType = String.Empty;
        public string CopayType
        {
            get { return copayType; }
            set { copayType = value; }
        }
        private decimal actualPrice = Decimal.Zero;
        public decimal ActualPrice
        {
            get { return actualPrice; }
            set { actualPrice = value; }
        }
        private long clientFeeTypeRateCustID = 0;
        public long ClientFeeTypeRateCustID
        {
            get { return clientFeeTypeRateCustID; }
            set { clientFeeTypeRateCustID = value; }
        }
        private string orderedUnit = String.Empty;
        private long orderedConvertUnit = 0;
        /// <summary>
        /// Gets or sets the OrderedUnit value.
        /// </summary>
        public string OrderedUnit
        {
            get { return orderedUnit; }
            set { orderedUnit = value; }
        }

        /// <summary>
        /// Gets or sets the OrderedConvertUnit value.
        /// </summary>
        public long OrderedConvertUnit
        {
            get { return orderedConvertUnit; }
            set { orderedConvertUnit = value; }
        }

        private string _GenericName;

        public string GenericName
        {
            get { return _GenericName; }
            set { _GenericName = value; }
        }
        public long PhysicianID
        {
            get { return physicianID; }
            set { physicianID = value; }
        }

        public long ProductReceivedDetailsID
        {
            get { return productReceivedDetailsID; }
            set { productReceivedDetailsID = value; }
        }

        public string Units
        {
            get;
            set;
        }

        public decimal pDay
        {
            get;
            set;
        }
        public decimal pMonth
        {
            get;
            set;
        }

        public decimal pQuater
        {
            get;
            set;
        }

        public string pNew
        {
            get;
            set;
        }
        public string ProductColour
        {
            get;
            set;
        }
        public string IsStockReceived
        {
            get;
            set;
        }
        public string IsPurchaseOrder
        {
            get;
            set;
        }


        public decimal StockInHand
        {
            get;
            set;
        }
        private decimal purchaseTax = 0;

        public decimal PurchaseTax
        {
            get { return purchaseTax; }
            set { purchaseTax = value; }
        }
        public decimal CostPrice
        {
            get;
            set;
        }

        public decimal ReorderQuantity
        {
            get;
            set;
        }

        public int BarcodeMappingId
        {
            get;
            set;
        }

        public string Barcode
        {
            get;
            set;
        }

        public long IntendDetailID
        {
            get;
            set;
        }

        public long StockInHandID
        {
            get;
            set;

        }

        public decimal SubstoreReturnqty
        {
            get;
            set;

        }
        public string ExpiryProduct
        {
            get;
            set;
        }
        public long GenericID
        {
            get;
            set;

        }

        public decimal DiscountPercent
        {
            get;
            set;

        }

        public string IsNonReimbursable
        {
            get;
            set;
        }
        public string IsAllMedical
        {
            get;
            set;
        }
        public string IsKitType
        {
            get;
            set;
        }
        public string IsDiscountable
        {
            get;
            set;
        }

        public decimal ReimbursableAmount
        {
            get;
            set;
        }

        public decimal NonReimbursableAmount
        {
            get;
            set;
        }

        public decimal Nominal
        {
            get;
            set;
        }
        DateTime stockReceivedDate = DateTime.MaxValue;
        public DateTime StockReceivedDate
        {
            get { return stockReceivedDate; }
            set { stockReceivedDate = value; }
        }
        public string InvoiceNo { get; set; }
        private decimal handlingCharges = 0;

        public decimal HandlingCharges
        {
            get { return handlingCharges; }
            set { handlingCharges = value; }
        }

        public long StockReceivedId
        {
            get { return stockReceivedID; }
            set { stockReceivedID = value; }
        }
        public long ReceivedUniqueNumber
        {
            get { return receivedUniqueNumber; }
            set { receivedUniqueNumber = value; }
        }
        public string ReceivedBatchNo
        {
            get { return receivedBatchNo; }
            set { receivedBatchNo = value; }
        }

        public long KitID { get; set; }
        public long ServiceID { get; set; }
        public DateTime IntendDate { get; set; }
        public string IssuedLocation { get; set; }
        public decimal PendingQty { get; set; }
        public long PODetailsID { get; set; }
        public long POID { get; set; }
        public long POMappingID { get; set; }
        public long PurchaseOrderID { get; set; }
        public long StockReceivedID { get; set; }
        public int ToLocationID { get; set; }
        public int TrustedOrgID { get; set; }
        public int StatusID { get; set; }
        public decimal RaisedQty { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string RaisedLocation { get; set; }
        public string Status { get; set; }
        public string StockReceivedNo { get; set; }
        #region MyRegion
        public long StockReceivedBarcodeDetailsID { get; set; }
        public long StockReceivedBarcodeID { get; set; }
        public string IsUniqueBarcode { get; set; }
        public string BarcodeNo { get; set; }
        #endregion
        private string orderedUnitValues = String.Empty;

        public string OrderedUnitValues
        {
            get { return orderedUnitValues; }
            set { orderedUnitValues = value; }
        }

        private string hasSellingPrice = String.Empty;

        public string HasSellingPrice
        {
            get { return hasSellingPrice; }
            set { hasSellingPrice = value; }
        }

        private string hasCostPrice = String.Empty;

        public string HasCostPrice
        {
            get { return hasCostPrice; }
            set { hasCostPrice = value; }
        }

        decimal _CGSTPercent = decimal.Zero;
        public decimal CGSTPercent
        {
            get { return _CGSTPercent; }
            set { _CGSTPercent = value; }
        }

        decimal _CGSTRate = decimal.Zero;
        public decimal CGSTRate
        {
            get { return _CGSTRate; }
            set { _CGSTRate = value; }
        }

        decimal _SGSTPercent = decimal.Zero;
        public decimal SGSTPercent
        {
            get { return _SGSTPercent; }
            set { _SGSTPercent = value; }
        }

        decimal _SGSTRate = decimal.Zero;
        public decimal SGSTRate
        {
            get { return _SGSTRate; }
            set { _SGSTRate = value; }
        }

        decimal _IGSTPercent = decimal.Zero;
        public decimal IGSTPercent
        {
            get { return _IGSTPercent; }
            set { _IGSTPercent = value; }
        }

        decimal _IGSTRate = decimal.Zero;
        public decimal IGSTRate
        {
            get { return _IGSTRate; }
            set { _IGSTRate = value; }
        }
        private string hSNCode = string.Empty;
        public string HSNCode
        {
            get { return hSNCode; }
            set { hSNCode = value; }
        }

        private string _schemeType = string.Empty;
        public string SchemeType
        {
            get { return _schemeType; }
            set { _schemeType = value; }
        }

        decimal _schemeDiscount = decimal.Zero;
        public decimal SchemeDisc
        {
            get { return _schemeDiscount; }
            set { _schemeDiscount = value; }
        }

        private string _discountType = string.Empty;
        public string DiscountType
        {
            get { return _discountType; }
            set { _discountType = value; }
        }
        private decimal totalDiscount = decimal.Zero;
        public decimal TotalDiscount
        {
            get { return totalDiscount; }
            set { totalDiscount = value; }
        }
        private decimal taxableValue = decimal.Zero;
        public decimal TaxableValue
        {
            get { return taxableValue; }
            set { taxableValue = value; }
        }

        private decimal _totalSchemeDisc = decimal.Zero;
        public decimal TotalSchemeDisc
        {
            get { return _totalSchemeDisc; }
            set { _totalSchemeDisc = value; }
        }

        private decimal _totalNormalDisc = decimal.Zero;
        public decimal TotalNormalDisc
        {
            get { return _totalNormalDisc; }
            set { _totalNormalDisc = value; }
        }
    }
}
