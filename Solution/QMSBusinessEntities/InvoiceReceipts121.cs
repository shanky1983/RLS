using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvoiceReceipts121
	{
		#region Fields

		private long inVoiceRecID=0;
		private long invoiceID=0;
		private decimal invoiceAmount=Decimal.Zero;
		private decimal receivedAmount=Decimal.Zero;
		private int paymentTypeID=0;
		private string chequeorCardNumber=String.Empty;
		private string bankNameorCardType=String.Empty;
		private int orgID=0;
		private int orgAddID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal tDSAmount=Decimal.Zero;
		private string status=String.Empty;
		private decimal writeOffAmt=Decimal.Zero;
		private decimal roundOffAmt=Decimal.Zero;
		private string writeOffReason=String.Empty;
		private string receiptNumber=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InVoiceRecID value.
		/// </summary>
		public long InVoiceRecID
		{
			get { return inVoiceRecID; }
			set { inVoiceRecID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceID value.
		/// </summary>
		public long InvoiceID
		{
			get { return invoiceID; }
			set { invoiceID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceAmount value.
		/// </summary>
		public decimal InvoiceAmount
		{
			get { return invoiceAmount; }
			set { invoiceAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedAmount value.
		/// </summary>
		public decimal ReceivedAmount
		{
			get { return receivedAmount; }
			set { receivedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentTypeID value.
		/// </summary>
		public int PaymentTypeID
		{
			get { return paymentTypeID; }
			set { paymentTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
		public string ChequeorCardNumber
		{
			get { return chequeorCardNumber; }
			set { chequeorCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		public string BankNameorCardType
		{
			get { return bankNameorCardType; }
			set { bankNameorCardType = value; }
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
		/// Gets or sets the TDSAmount value.
		/// </summary>
		public decimal TDSAmount
		{
			get { return tDSAmount; }
			set { tDSAmount = value; }
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
		/// Gets or sets the WriteOffAmt value.
		/// </summary>
		public decimal WriteOffAmt
		{
			get { return writeOffAmt; }
			set { writeOffAmt = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOffAmt value.
		/// </summary>
		public decimal RoundOffAmt
		{
			get { return roundOffAmt; }
			set { roundOffAmt = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffReason value.
		/// </summary>
		public string WriteOffReason
		{
			get { return writeOffReason; }
			set { writeOffReason = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNumber value.
		/// </summary>
		public string ReceiptNumber
		{
			get { return receiptNumber; }
			set { receiptNumber = value; }
		}


		#endregion
}
}
