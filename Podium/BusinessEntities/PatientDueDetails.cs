using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		private string _patientNumber=String.Empty;
		public string PatientNumber
		{
			get { return  _patientNumber; }
			set { _patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		private long _billNumber=0;
		public long BillNumber
		{
			get { return  _billNumber; }
			set { _billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ExistingDue value.
		/// </summary>
		private decimal _existingDue=Decimal.Zero;
		public decimal ExistingDue
		{
			get { return  _existingDue; }
			set { _existingDue = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		private decimal _serviceCharge=Decimal.Zero;
		public decimal ServiceCharge
		{
			get { return  _serviceCharge; }
			set { _serviceCharge = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		private decimal _netValue=Decimal.Zero;
		public decimal NetValue
		{
			get { return  _netValue; }
			set { _netValue = value; }
		}

		/// <summary>
		/// Gets or sets the DueBillDate value.
		/// </summary>
		private DateTime _dueBillDate=DateTime.MaxValue;
		public DateTime DueBillDate
		{
			get { return  _dueBillDate; }
			set { _dueBillDate = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		private string _userName=String.Empty;
		public string UserName
		{
			get { return  _userName; }
			set { _userName = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		private long _invoiceNo=0;
		public long InvoiceNo
		{
			get { return  _invoiceNo; }
			set { _invoiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceAmount value.
		/// </summary>
		private decimal _invoiceAmount=Decimal.Zero;
		public decimal InvoiceAmount
		{
			get { return  _invoiceAmount; }
			set { _invoiceAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedAmount value.
		/// </summary>
		private decimal _receivedAmount=Decimal.Zero;
		public decimal ReceivedAmount
		{
			get { return  _receivedAmount; }
			set { _receivedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffReason value.
		/// </summary>
		private string _writeOffReason=String.Empty;
		public string WriteOffReason
		{
			get { return  _writeOffReason; }
			set { _writeOffReason = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptDate value.
		/// </summary>
		private DateTime _receiptDate=DateTime.MaxValue;
		public DateTime ReceiptDate
		{
			get { return  _receiptDate; }
			set { _receiptDate = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		private string _visitNumber=String.Empty;
		public string VisitNumber
		{
			get { return  _visitNumber; }
			set { _visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		private string _referingPhysicianName=String.Empty;
		public string ReferingPhysicianName
		{
			get { return  _referingPhysicianName; }
			set { _referingPhysicianName = value; }
		}


		#endregion
}
}
