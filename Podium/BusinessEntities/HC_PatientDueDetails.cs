using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HC_PatientDueDetails
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


		#endregion
}
}
