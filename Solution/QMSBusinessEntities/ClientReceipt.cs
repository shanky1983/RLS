using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientReceipt
	{
		#region Fields

		private long receiptID=0;
		private DateTime receiptDate=DateTime.MaxValue;
		private int orgID=0;
		private string sourceCode=String.Empty;
		private string subSourceCode=String.Empty;
		private decimal amount=Decimal.Zero;
		private string mode=String.Empty;
		private string chequeNo=String.Empty;
		private DateTime chequeDate=DateTime.MaxValue;
		private string bankCode=String.Empty;
		private string bankName=String.Empty;
		private string accCode=String.Empty;
		private string remarks=String.Empty;
		private string depositedBy=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string responseCode=String.Empty;
		private string responseMsg=String.Empty;
		private string paymentReceiptNo=String.Empty;
		private string transactionID=String.Empty;
		private string authIDCode=String.Empty;
		private long invoiceId=0;
		private string uploadedImages=String.Empty;
		private string paymentType=String.Empty;
		private string manualRemarks=String.Empty;
		private string paidCurrencyType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReceiptID value.
		/// </summary>
		public long ReceiptID
		{
			get { return receiptID; }
			set { receiptID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptDate value.
		/// </summary>
		public DateTime ReceiptDate
		{
			get { return receiptDate; }
			set { receiptDate = value; }
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
		/// Gets or sets the SourceCode value.
		/// </summary>
		public string SourceCode
		{
			get { return sourceCode; }
			set { sourceCode = value; }
		}

		/// <summary>
		/// Gets or sets the SubSourceCode value.
		/// </summary>
		public string SubSourceCode
		{
			get { return subSourceCode; }
			set { subSourceCode = value; }
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
		/// Gets or sets the Mode value.
		/// </summary>
		public string Mode
		{
			get { return mode; }
			set { mode = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeNo value.
		/// </summary>
		public string ChequeNo
		{
			get { return chequeNo; }
			set { chequeNo = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeDate value.
		/// </summary>
		public DateTime ChequeDate
		{
			get { return chequeDate; }
			set { chequeDate = value; }
		}

		/// <summary>
		/// Gets or sets the BankCode value.
		/// </summary>
		public string BankCode
		{
			get { return bankCode; }
			set { bankCode = value; }
		}

		/// <summary>
		/// Gets or sets the BankName value.
		/// </summary>
		public string BankName
		{
			get { return bankName; }
			set { bankName = value; }
		}

		/// <summary>
		/// Gets or sets the AccCode value.
		/// </summary>
		public string AccCode
		{
			get { return accCode; }
			set { accCode = value; }
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
		/// Gets or sets the DepositedBy value.
		/// </summary>
		public string DepositedBy
		{
			get { return depositedBy; }
			set { depositedBy = value; }
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
		/// Gets or sets the ResponseCode value.
		/// </summary>
		public string ResponseCode
		{
			get { return responseCode; }
			set { responseCode = value; }
		}

		/// <summary>
		/// Gets or sets the ResponseMsg value.
		/// </summary>
		public string ResponseMsg
		{
			get { return responseMsg; }
			set { responseMsg = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentReceiptNo value.
		/// </summary>
		public string PaymentReceiptNo
		{
			get { return paymentReceiptNo; }
			set { paymentReceiptNo = value; }
		}

		/// <summary>
		/// Gets or sets the TransactionID value.
		/// </summary>
		public string TransactionID
		{
			get { return transactionID; }
			set { transactionID = value; }
		}

		/// <summary>
		/// Gets or sets the AuthIDCode value.
		/// </summary>
		public string AuthIDCode
		{
			get { return authIDCode; }
			set { authIDCode = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceId value.
		/// </summary>
		public long InvoiceId
		{
			get { return invoiceId; }
			set { invoiceId = value; }
		}

		/// <summary>
		/// Gets or sets the UploadedImages value.
		/// </summary>
		public string UploadedImages
		{
			get { return uploadedImages; }
			set { uploadedImages = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentType value.
		/// </summary>
		public string PaymentType
		{
			get { return paymentType; }
			set { paymentType = value; }
		}

		/// <summary>
		/// Gets or sets the ManualRemarks value.
		/// </summary>
		public string ManualRemarks
		{
			get { return manualRemarks; }
			set { manualRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the PaidCurrencyType value.
		/// </summary>
		public string PaidCurrencyType
		{
			get { return paidCurrencyType; }
			set { paidCurrencyType = value; }
		}


		#endregion
}
}
