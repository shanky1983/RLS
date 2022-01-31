using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		String _suppliername;
		public String SupplierName
		{
			get { return _suppliername; }
			set { _suppliername = value; }
		}

		/// <summary>
		/// Gets or sets the TinNo value.
		/// </summary>
		String _tinno;
		public String TinNo
		{
			get { return _tinno; }
			set { _tinno = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		Decimal _netvalue;
		public Decimal NetValue
		{
			get { return _netvalue; }
			set { _netvalue = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		String _invoiceno;
		public String InvoiceNo
		{
			get { return _invoiceno; }
			set { _invoiceno = value; }
		}

		/// <summary>
		/// Gets or sets the GrandTotal value.
		/// </summary>
		Decimal _grandtotal;
		public Decimal GrandTotal
		{
			get { return _grandtotal; }
			set { _grandtotal = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount4 value.
		/// </summary>
		Decimal _taxamount4;
		public Decimal TaxAmount4
		{
			get { return _taxamount4; }
			set { _taxamount4 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount4 value.
		/// </summary>
		Decimal _taxableamount4;
		public Decimal TaxableAmount4
		{
			get { return _taxableamount4; }
			set { _taxableamount4 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount12 value.
		/// </summary>
		Decimal _taxamount12;
		public Decimal TaxAmount12
		{
			get { return _taxamount12; }
			set { _taxamount12 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount12 value.
		/// </summary>
		Decimal _taxableamount12;
		public Decimal TaxableAmount12
		{
			get { return _taxableamount12; }
			set { _taxableamount12 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount0 value.
		/// </summary>
		Decimal _taxamount0;
		public Decimal TaxAmount0
		{
			get { return _taxamount0; }
			set { _taxamount0 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount0 value.
		/// </summary>
		Decimal _taxableamount0;
		public Decimal TaxableAmount0
		{
			get { return _taxableamount0; }
			set { _taxableamount0 = value; }
		}

		/// <summary>
		/// Gets or sets the Others value.
		/// </summary>
		Decimal _others;
		public Decimal Others
		{
			get { return _others; }
			set { _others = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount5 value.
		/// </summary>
		Decimal _taxamount5;
		public Decimal TaxAmount5
		{
			get { return _taxamount5; }
			set { _taxamount5 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount5 value.
		/// </summary>
		Decimal _taxableamount5;
		public Decimal TaxableAmount5
		{
			get { return _taxableamount5; }
			set { _taxableamount5 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount13 value.
		/// </summary>
		Decimal _taxamount13;
		public Decimal TaxAmount13
		{
			get { return _taxamount13; }
			set { _taxamount13 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount13 value.
		/// </summary>
		Decimal _taxableamount13;
		public Decimal TaxableAmount13
		{
			get { return _taxableamount13; }
			set { _taxableamount13 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount14 value.
		/// </summary>
		Decimal _taxamount14;
		public Decimal TaxAmount14
		{
			get { return _taxamount14; }
			set { _taxamount14 = value; }
		}

		/// <summary>
		/// Gets or sets the TaxableAmount14 value.
		/// </summary>
		Decimal _taxableamount14;
		public Decimal TaxableAmount14
		{
			get { return _taxableamount14; }
			set { _taxableamount14 = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		String _locationname;
		public String LocationName
		{
			get { return _locationname; }
			set { _locationname = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		Decimal _tax;
		public Decimal Tax
		{
			get { return _tax; }
			set { _tax = value; }
		}


		#endregion
}
}
