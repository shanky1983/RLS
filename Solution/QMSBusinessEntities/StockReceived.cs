using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StockReceived
	{
		#region Fields

		private long stockReceivedID=0;
		private string stockReceivedNo=String.Empty;
		private DateTime stockReceivedDate=DateTime.MaxValue;
		private string purchaseOrderNo=String.Empty;
		private int supplierID=0;
		private int orgID=0;
		private int fromLocationID=0;
		private string status=String.Empty;
		private string comments=String.Empty;
		private long approvedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private string invoiceNo=String.Empty;
		private string paymentStatus=String.Empty;
		private decimal paidAmount=Decimal.Zero;
		private long issuedTO=0;
		private int toLocationID=0;
		private string dCNumber=String.Empty;
		private long indentID=0;
		private decimal tax=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal grandTotal=Decimal.Zero;
		private int stockReceivedTypeID=0;
		private decimal cessOnExciseTax=Decimal.Zero;
		private decimal highterEdCessTax=Decimal.Zero;
		private decimal cSTax=Decimal.Zero;
		private decimal cessOnExciseTaxAmount=Decimal.Zero;
		private decimal highterEdCessTaxAmount=Decimal.Zero;
		private decimal cSTAmount=Decimal.Zero;
		private decimal exciseTaxAmount=Decimal.Zero;
		private decimal roundOfValue=Decimal.Zero;
		private string roundOfType=String.Empty;
		private long billID=0;
		private long outFlowID=0;
		private decimal nominalDiscount=Decimal.Zero;
		private DateTime invoiceDate=DateTime.MaxValue;
		private string netCalcTax=String.Empty;
		private long purchaseOrderID=0;
		private int statusID=0;
		private decimal supServiceTax=Decimal.Zero;
		private decimal pODiscountPer=Decimal.Zero;
		private decimal pODiscountAmount=Decimal.Zero;
		private decimal supServiceTaxAmount=Decimal.Zero;
		private long indentReceivedID=0;
		private string remarks=String.Empty;
		private decimal stampFee=Decimal.Zero;
		private decimal deliveryCharges=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockReceivedID value.
		/// </summary>
		public long StockReceivedID
		{
			get { return stockReceivedID; }
			set { stockReceivedID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedNo value.
		/// </summary>
		public string StockReceivedNo
		{
			get { return stockReceivedNo; }
			set { stockReceivedNo = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedDate value.
		/// </summary>
		public DateTime StockReceivedDate
		{
			get { return stockReceivedDate; }
			set { stockReceivedDate = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseOrderNo value.
		/// </summary>
		public string PurchaseOrderNo
		{
			get { return purchaseOrderNo; }
			set { purchaseOrderNo = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the FromLocationID value.
		/// </summary>
		public int FromLocationID
		{
			get { return fromLocationID; }
			set { fromLocationID = value; }
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
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		public string InvoiceNo
		{
			get { return invoiceNo; }
			set { invoiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentStatus value.
		/// </summary>
		public string PaymentStatus
		{
			get { return paymentStatus; }
			set { paymentStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PaidAmount value.
		/// </summary>
		public decimal PaidAmount
		{
			get { return paidAmount; }
			set { paidAmount = value; }
		}

		/// <summary>
		/// Gets or sets the IssuedTO value.
		/// </summary>
		public long IssuedTO
		{
			get { return issuedTO; }
			set { issuedTO = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		public int ToLocationID
		{
			get { return toLocationID; }
			set { toLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the DCNumber value.
		/// </summary>
		public string DCNumber
		{
			get { return dCNumber; }
			set { dCNumber = value; }
		}

		/// <summary>
		/// Gets or sets the IndentID value.
		/// </summary>
		public long IndentID
		{
			get { return indentID; }
			set { indentID = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the GrandTotal value.
		/// </summary>
		public decimal GrandTotal
		{
			get { return grandTotal; }
			set { grandTotal = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedTypeID value.
		/// </summary>
		public int StockReceivedTypeID
		{
			get { return stockReceivedTypeID; }
			set { stockReceivedTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CessOnExciseTax value.
		/// </summary>
		public decimal CessOnExciseTax
		{
			get { return cessOnExciseTax; }
			set { cessOnExciseTax = value; }
		}

		/// <summary>
		/// Gets or sets the HighterEdCessTax value.
		/// </summary>
		public decimal HighterEdCessTax
		{
			get { return highterEdCessTax; }
			set { highterEdCessTax = value; }
		}

		/// <summary>
		/// Gets or sets the CSTax value.
		/// </summary>
		public decimal CSTax
		{
			get { return cSTax; }
			set { cSTax = value; }
		}

		/// <summary>
		/// Gets or sets the CessOnExciseTaxAmount value.
		/// </summary>
		public decimal CessOnExciseTaxAmount
		{
			get { return cessOnExciseTaxAmount; }
			set { cessOnExciseTaxAmount = value; }
		}

		/// <summary>
		/// Gets or sets the HighterEdCessTaxAmount value.
		/// </summary>
		public decimal HighterEdCessTaxAmount
		{
			get { return highterEdCessTaxAmount; }
			set { highterEdCessTaxAmount = value; }
		}

		/// <summary>
		/// Gets or sets the CSTAmount value.
		/// </summary>
		public decimal CSTAmount
		{
			get { return cSTAmount; }
			set { cSTAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ExciseTaxAmount value.
		/// </summary>
		public decimal ExciseTaxAmount
		{
			get { return exciseTaxAmount; }
			set { exciseTaxAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOfValue value.
		/// </summary>
		public decimal RoundOfValue
		{
			get { return roundOfValue; }
			set { roundOfValue = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOfType value.
		/// </summary>
		public string RoundOfType
		{
			get { return roundOfType; }
			set { roundOfType = value; }
		}

		/// <summary>
		/// Gets or sets the BillID value.
		/// </summary>
		public long BillID
		{
			get { return billID; }
			set { billID = value; }
		}

		/// <summary>
		/// Gets or sets the OutFlowID value.
		/// </summary>
		public long OutFlowID
		{
			get { return outFlowID; }
			set { outFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the NominalDiscount value.
		/// </summary>
		public decimal NominalDiscount
		{
			get { return nominalDiscount; }
			set { nominalDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceDate value.
		/// </summary>
		public DateTime InvoiceDate
		{
			get { return invoiceDate; }
			set { invoiceDate = value; }
		}

		/// <summary>
		/// Gets or sets the NetCalcTax value.
		/// </summary>
		public string NetCalcTax
		{
			get { return netCalcTax; }
			set { netCalcTax = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseOrderID value.
		/// </summary>
		public long PurchaseOrderID
		{
			get { return purchaseOrderID; }
			set { purchaseOrderID = value; }
		}

		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		public int StatusID
		{
			get { return statusID; }
			set { statusID = value; }
		}

		/// <summary>
		/// Gets or sets the SupServiceTax value.
		/// </summary>
		public decimal SupServiceTax
		{
			get { return supServiceTax; }
			set { supServiceTax = value; }
		}

		/// <summary>
		/// Gets or sets the PODiscountPer value.
		/// </summary>
		public decimal PODiscountPer
		{
			get { return pODiscountPer; }
			set { pODiscountPer = value; }
		}

		/// <summary>
		/// Gets or sets the PODiscountAmount value.
		/// </summary>
		public decimal PODiscountAmount
		{
			get { return pODiscountAmount; }
			set { pODiscountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the SupServiceTaxAmount value.
		/// </summary>
		public decimal SupServiceTaxAmount
		{
			get { return supServiceTaxAmount; }
			set { supServiceTaxAmount = value; }
		}

		/// <summary>
		/// Gets or sets the IndentReceivedID value.
		/// </summary>
		public long IndentReceivedID
		{
			get { return indentReceivedID; }
			set { indentReceivedID = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the StampFee value.
		/// </summary>
		public decimal StampFee
		{
			get { return stampFee; }
			set { stampFee = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryCharges value.
		/// </summary>
		public decimal DeliveryCharges
		{
			get { return deliveryCharges; }
			set { deliveryCharges = value; }
		}

		/// <summary>
		/// Gets or sets the UsedCreditAmount value.
		/// </summary>
		Decimal _usedcreditamount;
		public Decimal UsedCreditAmount
		{
			get { return _usedcreditamount; }
			set { _usedcreditamount = value; }
		}

		/// <summary>
		/// Gets or sets the GrandTotalRF value.
		/// </summary>
		Decimal _grandtotalrf;
		public Decimal GrandTotalRF
		{
			get { return _grandtotalrf; }
			set { _grandtotalrf = value; }
		}


		#endregion
}
}
