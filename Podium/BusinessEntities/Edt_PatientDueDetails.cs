using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Edt_PatientDueDetails
	{
		#region Fields

		private long edtPatientDueID=0;
		private long edtMasterBillID=0;
		private decimal dueAmount=Decimal.Zero;
		private decimal duePaidAmt=Decimal.Zero;
		private int orgID=0;
		private string isCreditBill=String.Empty;
		private string status=String.Empty;
		private long paidFinalbillID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string versionNo=String.Empty;
		private decimal discountAmt=Decimal.Zero;
		private decimal currentDue=Decimal.Zero;
		private decimal writeOffAmt=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EdtPatientDueID value.
		/// </summary>
		public long EdtPatientDueID
		{
			get { return edtPatientDueID; }
			set { edtPatientDueID = value; }
		}

		/// <summary>
		/// Gets or sets the EdtMasterBillID value.
		/// </summary>
		public long EdtMasterBillID
		{
			get { return edtMasterBillID; }
			set { edtMasterBillID = value; }
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


		#endregion
}
}
