using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PurchaseOrders
	{
		#region Fields

		private long purchaseOrderID=0;
		private DateTime purchaseOrderDate=DateTime.MaxValue;
		private string purchaseOrderNo=String.Empty;
		private int orgID=0;
		private int supplierID=0;
		private int branchID=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long approvedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private string comments=String.Empty;
		private int orgAddressID=0;
		private int locationID=0;
		private string receivableLocation=String.Empty;
		private decimal charges=Decimal.Zero;
		private decimal poDiscount=Decimal.Zero;
		private decimal grossAmount=Decimal.Zero;
		private decimal netAmount=Decimal.Zero;
		private decimal freightCharges=Decimal.Zero;
		private long quotationID=0;
		private decimal productDiscount=Decimal.Zero;
		private decimal productTax=Decimal.Zero;
		private bool cFormType=false;
		private int statusID=0;
		private bool isRate=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PurchaseOrderID value.
		/// </summary>
		public long PurchaseOrderID
		{
			get { return purchaseOrderID; }
			set { purchaseOrderID = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseOrderDate value.
		/// </summary>
		public DateTime PurchaseOrderDate
		{
			get { return purchaseOrderDate; }
			set { purchaseOrderDate = value; }
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

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivableLocation value.
		/// </summary>
		public string ReceivableLocation
		{
			get { return receivableLocation; }
			set { receivableLocation = value; }
		}

		/// <summary>
		/// Gets or sets the Charges value.
		/// </summary>
		public decimal Charges
		{
			get { return charges; }
			set { charges = value; }
		}

		/// <summary>
		/// Gets or sets the PoDiscount value.
		/// </summary>
		public decimal PoDiscount
		{
			get { return poDiscount; }
			set { poDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the GrossAmount value.
		/// </summary>
		public decimal GrossAmount
		{
			get { return grossAmount; }
			set { grossAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmount value.
		/// </summary>
		public decimal NetAmount
		{
			get { return netAmount; }
			set { netAmount = value; }
		}

		/// <summary>
		/// Gets or sets the FreightCharges value.
		/// </summary>
		public decimal FreightCharges
		{
			get { return freightCharges; }
			set { freightCharges = value; }
		}

		/// <summary>
		/// Gets or sets the QuotationID value.
		/// </summary>
		public long QuotationID
		{
			get { return quotationID; }
			set { quotationID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductDiscount value.
		/// </summary>
		public decimal ProductDiscount
		{
			get { return productDiscount; }
			set { productDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the ProductTax value.
		/// </summary>
		public decimal ProductTax
		{
			get { return productTax; }
			set { productTax = value; }
		}

		/// <summary>
		/// Gets or sets the CFormType value.
		/// </summary>
		public bool CFormType
		{
			get { return cFormType; }
			set { cFormType = value; }
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
		/// Gets or sets the IsRate value.
		/// </summary>
		public bool IsRate
		{
			get { return isRate; }
			set { isRate = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierName value.
		/// </summary>
		private String _supplierName=String.Empty;
		public String SupplierName
		{
			get { return  _supplierName; }
			set { _supplierName = value; }
		}

		/// <summary>
		/// Gets or sets the TinNo value.
		/// </summary>
		private String _tinNo=String.Empty;
		public String TinNo
		{
			get { return  _tinNo; }
			set { _tinNo = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		private Decimal _netValue=Decimal.Zero;
		public Decimal NetValue
		{
			get { return  _netValue; }
			set { _netValue = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		private String _invoiceNo=String.Empty;
		public String InvoiceNo
		{
			get { return  _invoiceNo; }
			set { _invoiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the GrandTotal value.
		/// </summary>
		private Decimal _grandTotal=Decimal.Zero;
		public Decimal GrandTotal
		{
			get { return  _grandTotal; }
			set { _grandTotal = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount4 value.
		/// </summary>
		private Decimal _taxAmount4=Decimal.Zero;
		public Decimal TaxAmount4
		{
			get { return  _taxAmount4; }
			set { _taxAmount4 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount4 value.
		/// </summary>
		private Decimal _taxableAmount4=Decimal.Zero;
		public Decimal TaxableAmount4
		{
			get { return  _taxableAmount4; }
			set { _taxableAmount4 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount12 value.
		/// </summary>
		private Decimal _taxAmount12=Decimal.Zero;
		public Decimal TaxAmount12
		{
			get { return  _taxAmount12; }
			set { _taxAmount12 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount12 value.
		/// </summary>
		private Decimal _taxableAmount12=Decimal.Zero;
		public Decimal TaxableAmount12
		{
			get { return  _taxableAmount12; }
			set { _taxableAmount12 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount0 value.
		/// </summary>
		private Decimal _taxAmount0=Decimal.Zero;
		public Decimal TaxAmount0
		{
			get { return  _taxAmount0; }
			set { _taxAmount0 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount0 value.
		/// </summary>
		private Decimal _taxableAmount0=Decimal.Zero;
		public Decimal TaxableAmount0
		{
			get { return  _taxableAmount0; }
			set { _taxableAmount0 = value; }
		}

		/// <summary>
		/// Gets or sets the Others value.
		/// </summary>
		private Decimal _others=Decimal.Zero;
		public Decimal Others
		{
			get { return  _others; }
			set { _others = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount5 value.
		/// </summary>
		private Decimal _taxAmount5=Decimal.Zero;
		public Decimal TaxAmount5
		{
			get { return  _taxAmount5; }
			set { _taxAmount5 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount5 value.
		/// </summary>
		private Decimal _taxableAmount5=Decimal.Zero;
		public Decimal TaxableAmount5
		{
			get { return  _taxableAmount5; }
			set { _taxableAmount5 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount13 value.
		/// </summary>
		private Decimal _taxAmount13=Decimal.Zero;
		public Decimal TaxAmount13
		{
			get { return  _taxAmount13; }
			set { _taxAmount13 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount13 value.
		/// </summary>
		private Decimal _taxableAmount13=Decimal.Zero;
		public Decimal TaxableAmount13
		{
			get { return  _taxableAmount13; }
			set { _taxableAmount13 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount14 value.
		/// </summary>
		private Decimal _taxAmount14=Decimal.Zero;
		public Decimal TaxAmount14
		{
			get { return  _taxAmount14; }
			set { _taxAmount14 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount14 value.
		/// </summary>
		private Decimal _taxableAmount14=Decimal.Zero;
		public Decimal TaxableAmount14
		{
			get { return  _taxableAmount14; }
			set { _taxableAmount14 = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		private String _locationName=String.Empty;
		public String LocationName
		{
			get { return  _locationName; }
			set { _locationName = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		private Decimal _tax=Decimal.Zero;
		public Decimal Tax
		{
			get { return  _tax; }
			set { _tax = value; }
		}

		/// <summary>
		/// Gets or sets the RoundofValue value.
		/// </summary>
		private Decimal _roundofValue=Decimal.Zero;
		public Decimal RoundofValue
		{
			get { return  _roundofValue; }
			set { _roundofValue = value; }
		}

		/// <summary>
		/// Gets or sets the NetRoundofValue value.
		/// </summary>
		private Decimal _netRoundofValue=Decimal.Zero;
		public Decimal NetRoundofValue
		{
			get { return  _netRoundofValue; }
			set { _netRoundofValue = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOfType value.
		/// </summary>
		private String _roundOfType=String.Empty;
		public String RoundOfType
		{
			get { return  _roundOfType; }
			set { _roundOfType = value; }
		}

		/// <summary>
		/// Gets or sets the ApproveDigitalSign value.
		/// </summary>
		byte[] _approvedigitalsign;
		public byte[] ApproveDigitalSign
		{
			get { return _approvedigitalsign; }
			set { _approvedigitalsign = value; }
		}

		/// <summary>
		/// Gets or sets the CSTAmount value.
		/// </summary>
		private Decimal _cSTAmount=Decimal.Zero;
		public Decimal CSTAmount
		{
			get { return  _cSTAmount; }
			set { _cSTAmount = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceDate value.
		/// </summary>
		private DateTime _invoiceDate=DateTime.MaxValue;
		public DateTime InvoiceDate
		{
			get { return  _invoiceDate; }
			set { _invoiceDate = value; }
		}


		#endregion
}
}
