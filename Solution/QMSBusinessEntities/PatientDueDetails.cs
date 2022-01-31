using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDueDetails
	{
		#region Fields

		private long patientDueID=0;
		private long patientID=0;
		private long visitID=0;
		private long finalBillID=0;
		private decimal dueAmount=Decimal.Zero;
		private decimal duePaidAmt=Decimal.Zero;
		private int orgID=0;
		private string isCreditBill=String.Empty;
		private string status=String.Empty;
		private string billNo=String.Empty;
		private string dueBillNo=String.Empty;
		private long paidFinalbillID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string versionNo=String.Empty;
		private decimal discountAmt=Decimal.Zero;
		private decimal currentDue=Decimal.Zero;
		private decimal writeOffAmt=Decimal.Zero;
		private decimal refundedAmount=Decimal.Zero;
		private int deptID=0;
		private string dueReason=String.Empty;
		private decimal coPaymentDue=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientDueID value.
		/// </summary>
		public long PatientDueID
		{
			get { return patientDueID; }
			set { patientDueID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the DueAmount value.
		/// </summary>
		public decimal DueAmount
		{
			get { return dueAmount; }
			set { dueAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DuePaidAmt value.
		/// </summary>
		public decimal DuePaidAmt
		{
			get { return duePaidAmt; }
			set { duePaidAmt = value; }
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
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		public string IsCreditBill
		{
			get { return isCreditBill; }
			set { isCreditBill = value; }
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
		/// Gets or sets the BillNo value.
		/// </summary>
		public string BillNo
		{
			get { return billNo; }
			set { billNo = value; }
		}

		/// <summary>
		/// Gets or sets the DueBillNo value.
		/// </summary>
		public string DueBillNo
		{
			get { return dueBillNo; }
			set { dueBillNo = value; }
		}

		/// <summary>
		/// Gets or sets the PaidFinalbillID value.
		/// </summary>
		public long PaidFinalbillID
		{
			get { return paidFinalbillID; }
			set { paidFinalbillID = value; }
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
		/// Gets or sets the VersionNo value.
		/// </summary>
		public string VersionNo
		{
			get { return versionNo; }
			set { versionNo = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmt value.
		/// </summary>
		public decimal DiscountAmt
		{
			get { return discountAmt; }
			set { discountAmt = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentDue value.
		/// </summary>
		public decimal CurrentDue
		{
			get { return currentDue; }
			set { currentDue = value; }
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
		/// Gets or sets the RefundedAmount value.
		/// </summary>
		public decimal RefundedAmount
		{
			get { return refundedAmount; }
			set { refundedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the DueReason value.
		/// </summary>
		public string DueReason
		{
			get { return dueReason; }
			set { dueReason = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentDue value.
		/// </summary>
		public decimal CoPaymentDue
		{
			get { return coPaymentDue; }
			set { coPaymentDue = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		string _patientnumber;
		public string PatientNumber
		{
			get { return _patientnumber; }
			set { _patientnumber = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		long _billnumber;
		public long BillNumber
		{
			get { return _billnumber; }
			set { _billnumber = value; }
		}

		/// <summary>
		/// Gets or sets the ExistingDue value.
		/// </summary>
		decimal _existingdue;
		public decimal ExistingDue
		{
			get { return _existingdue; }
			set { _existingdue = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		decimal _servicecharge;
		public decimal ServiceCharge
		{
			get { return _servicecharge; }
			set { _servicecharge = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		decimal _netvalue;
		public decimal NetValue
		{
			get { return _netvalue; }
			set { _netvalue = value; }
		}

		/// <summary>
		/// Gets or sets the DueBillDate value.
		/// </summary>
		DateTime _duebilldate;
		public DateTime DueBillDate
		{
			get { return _duebilldate; }
			set { _duebilldate = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		string _username;
		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		long _invoiceno;
		public long InvoiceNo
		{
			get { return _invoiceno; }
			set { _invoiceno = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceAmount value.
		/// </summary>
		decimal _invoiceamount;
		public decimal InvoiceAmount
		{
			get { return _invoiceamount; }
			set { _invoiceamount = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedAmount value.
		/// </summary>
		decimal _receivedamount;
		public decimal ReceivedAmount
		{
			get { return _receivedamount; }
			set { _receivedamount = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffReason value.
		/// </summary>
		string _writeoffreason;
		public string WriteOffReason
		{
			get { return _writeoffreason; }
			set { _writeoffreason = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptDate value.
		/// </summary>
		DateTime _receiptdate;
		public DateTime ReceiptDate
		{
			get { return _receiptdate; }
			set { _receiptdate = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		string _clientname;
		public string ClientName
		{
			get { return _clientname; }
			set { _clientname = value; }
		}


		#endregion
}
}
