using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDepositUsage
	{
		#region Fields

		private long depositUasgeID=0;
		private long depositID=0;
		private long patientID=0;
		private int orgID=0;
		private long finalBillID=0;
		private string billNumber=String.Empty;
		private string receiptNo=String.Empty;
		private decimal amountUsed=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int roleID=0;
		private int deptID=0;
		private long parentPatientID=0;
		private string depositTypeID=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DepositUasgeID value.
		/// </summary>
		public long DepositUasgeID
		{
			get { return depositUasgeID; }
			set { depositUasgeID = value; }
		}

		/// <summary>
		/// Gets or sets the DepositID value.
		/// </summary>
		public long DepositID
		{
			get { return depositID; }
			set { depositID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the BillNumber value.
		/// </summary>
		public string BillNumber
		{
			get { return billNumber; }
			set { billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNo value.
		/// </summary>
		public string ReceiptNo
		{
			get { return receiptNo; }
			set { receiptNo = value; }
		}

		/// <summary>
		/// Gets or sets the AmountUsed value.
		/// </summary>
		public decimal AmountUsed
		{
			get { return amountUsed; }
			set { amountUsed = value; }
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
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
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
		/// Gets or sets the ParentPatientID value.
		/// </summary>
		public long ParentPatientID
		{
			get { return parentPatientID; }
			set { parentPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the DepositTypeID value.
		/// </summary>
		public string DepositTypeID
		{
			get { return depositTypeID; }
			set { depositTypeID = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
