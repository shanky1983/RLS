using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Invoice
	{
		#region Fields

		private long invoiceID=0;
		private int orgID=0;
		private int orgAddID=0;
		private decimal grossValue=Decimal.Zero;
		private string discount=String.Empty;
		private string discountReason=String.Empty;
		private decimal netValue=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime invoiceDate=DateTime.MaxValue;
		private long clientID=0;
		private decimal taxAmount=Decimal.Zero;
		private string status=String.Empty;
		private long apporverID=0;
		private DateTime apporvedDate=DateTime.MaxValue;
		private string comments=String.Empty;
		private string approverRemarks=String.Empty;
		private string invoiceNumber=String.Empty;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime toDate=DateTime.MaxValue;
		private decimal receivedAmt=Decimal.Zero;
		private decimal tTOD=Decimal.Zero;
		private long rateID=0;
		private string clientTax=String.Empty;
		private decimal volumeDiscountAmt=Decimal.Zero;
		private string new_InvoiceNumber=String.Empty;
		private string old_InvoiceNumber=String.Empty;
		private decimal roundOff=Decimal.Zero;
		private string isNotifyComplete=String.Empty;
		private string isPDFComplete=String.Empty;
		private long notifiID=0;
		private string invoiceIdentity=String.Empty;
		private decimal creditAmount=Decimal.Zero;
		private decimal debitAmount=Decimal.Zero;
		private decimal discountPercent=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvoiceID value.
		/// </summary>
		public long InvoiceID
		{
			get { return invoiceID; }
			set { invoiceID = value; }
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
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public int OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the GrossValue value.
		/// </summary>
		public decimal GrossValue
		{
			get { return grossValue; }
			set { grossValue = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		public string Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountReason value.
		/// </summary>
		public string DiscountReason
		{
			get { return discountReason; }
			set { discountReason = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		public decimal NetValue
		{
			get { return netValue; }
			set { netValue = value; }
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
		/// Gets or sets the InvoiceDate value.
		/// </summary>
		public DateTime InvoiceDate
		{
			get { return invoiceDate; }
			set { invoiceDate = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount value.
		/// </summary>
		public decimal TaxAmount
		{
			get { return taxAmount; }
			set { taxAmount = value; }
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
		/// Gets or sets the ApporverID value.
		/// </summary>
		public long ApporverID
		{
			get { return apporverID; }
			set { apporverID = value; }
		}

		/// <summary>
		/// Gets or sets the ApporvedDate value.
		/// </summary>
		public DateTime ApporvedDate
		{
			get { return apporvedDate; }
			set { apporvedDate = value; }
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
		/// Gets or sets the ApproverRemarks value.
		/// </summary>
		public string ApproverRemarks
		{
			get { return approverRemarks; }
			set { approverRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNumber value.
		/// </summary>
		public string InvoiceNumber
		{
			get { return invoiceNumber; }
			set { invoiceNumber = value; }
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
		/// Gets or sets the ReceivedAmt value.
		/// </summary>
		public decimal ReceivedAmt
		{
			get { return receivedAmt; }
			set { receivedAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TTOD value.
		/// </summary>
		public decimal TTOD
		{
			get { return tTOD; }
			set { tTOD = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientTax value.
		/// </summary>
		public string ClientTax
		{
			get { return clientTax; }
			set { clientTax = value; }
		}

		/// <summary>
		/// Gets or sets the VolumeDiscountAmt value.
		/// </summary>
		public decimal VolumeDiscountAmt
		{
			get { return volumeDiscountAmt; }
			set { volumeDiscountAmt = value; }
		}

		/// <summary>
		/// Gets or sets the New_InvoiceNumber value.
		/// </summary>
		public string New_InvoiceNumber
		{
			get { return new_InvoiceNumber; }
			set { new_InvoiceNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Old_InvoiceNumber value.
		/// </summary>
		public string Old_InvoiceNumber
		{
			get { return old_InvoiceNumber; }
			set { old_InvoiceNumber = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOff value.
		/// </summary>
		public decimal RoundOff
		{
			get { return roundOff; }
			set { roundOff = value; }
		}

		/// <summary>
		/// Gets or sets the IsNotifyComplete value.
		/// </summary>
		public string IsNotifyComplete
		{
			get { return isNotifyComplete; }
			set { isNotifyComplete = value; }
		}

		/// <summary>
		/// Gets or sets the IsPDFComplete value.
		/// </summary>
		public string IsPDFComplete
		{
			get { return isPDFComplete; }
			set { isPDFComplete = value; }
		}

		/// <summary>
		/// Gets or sets the NotifiID value.
		/// </summary>
		public long NotifiID
		{
			get { return notifiID; }
			set { notifiID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceIdentity value.
		/// </summary>
		public string InvoiceIdentity
		{
			get { return invoiceIdentity; }
			set { invoiceIdentity = value; }
		}

		/// <summary>
		/// Gets or sets the CreditAmount value.
		/// </summary>
		public decimal CreditAmount
		{
			get { return creditAmount; }
			set { creditAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DebitAmount value.
		/// </summary>
		public decimal DebitAmount
		{
			get { return debitAmount; }
			set { debitAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPercent value.
		/// </summary>
		public decimal DiscountPercent
		{
			get { return discountPercent; }
			set { discountPercent = value; }
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
		/// Gets or sets the FinalBillID value.
		/// </summary>
		long _finalbillid;
		public long FinalBillID
		{
			get { return _finalbillid; }
			set { _finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffAmt value.
		/// </summary>
		Decimal _writeoffamt;
		public Decimal WriteOffAmt
		{
			get { return _writeoffamt; }
			set { _writeoffamt = value; }
		}

		/// <summary>
		/// Gets or sets the RefID value.
		/// </summary>
		long _refid;
		public long RefID
		{
			get { return _refid; }
			set { _refid = value; }
		}

		/// <summary>
		/// Gets or sets the RefType value.
		/// </summary>
		string _reftype;
		public string RefType
		{
			get { return _reftype; }
			set { _reftype = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		string _reason;
		public string Reason
		{
			get { return _reason; }
			set { _reason = value; }
		}

		/// <summary>
		/// Gets or sets the DueAmount value.
		/// </summary>
		Decimal _dueamount;
		public Decimal DueAmount
		{
			get { return _dueamount; }
			set { _dueamount = value; }
		}

		/// <summary>
		/// Gets or sets the ReportTemplateID value.
		/// </summary>
		int _reporttemplateid;
		public int ReportTemplateID
		{
			get { return _reporttemplateid; }
			set { _reporttemplateid = value; }
		}


		#endregion
}
}
