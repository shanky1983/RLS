using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvoiceBills
	{
		#region Fields

		private long invoiceBillsID=0;
		private long invoiceDetailsID=0;
		private long invoiceId=0;
		private long finalBillID=0;
		private long clientID=0;
		private string patientName=String.Empty;
		private string barcodes=String.Empty;
		private string testDescriptions=String.Empty;
		private decimal billAmount=Decimal.Zero;
		private long orgID=0;
		private string isPaid=String.Empty;
		private DateTime billdate=DateTime.MaxValue;
		private DateTime processedDate=DateTime.MaxValue;
		private DateTime invoiceDate=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private long receiptId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvoiceBillsID value.
		/// </summary>
		public long InvoiceBillsID
		{
			get { return invoiceBillsID; }
			set { invoiceBillsID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceDetailsID value.
		/// </summary>
		public long InvoiceDetailsID
		{
			get { return invoiceDetailsID; }
			set { invoiceDetailsID = value; }
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
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
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
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the Barcodes value.
		/// </summary>
		public string Barcodes
		{
			get { return barcodes; }
			set { barcodes = value; }
		}

		/// <summary>
		/// Gets or sets the TestDescriptions value.
		/// </summary>
		public string TestDescriptions
		{
			get { return testDescriptions; }
			set { testDescriptions = value; }
		}

		/// <summary>
		/// Gets or sets the BillAmount value.
		/// </summary>
		public decimal BillAmount
		{
			get { return billAmount; }
			set { billAmount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsPaid value.
		/// </summary>
		public string IsPaid
		{
			get { return isPaid; }
			set { isPaid = value; }
		}

		/// <summary>
		/// Gets or sets the Billdate value.
		/// </summary>
		public DateTime Billdate
		{
			get { return billdate; }
			set { billdate = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessedDate value.
		/// </summary>
		public DateTime ProcessedDate
		{
			get { return processedDate; }
			set { processedDate = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptId value.
		/// </summary>
		public long ReceiptId
		{
			get { return receiptId; }
			set { receiptId = value; }
		}


		#endregion
}
}
