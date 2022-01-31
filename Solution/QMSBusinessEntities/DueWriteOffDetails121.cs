using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DueWriteOffDetails121
	{
		#region Fields

		private long writeOffApprovalID=0;
		private long patientDueID=0;
		private decimal dueAmount=Decimal.Zero;
		private decimal discountAmt=Decimal.Zero;
		private decimal writeOffAmt=Decimal.Zero;
		private decimal approvedAmt=Decimal.Zero;
		private int orgId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long taskID=0;
		private string reason=String.Empty;
		private int authorisedBy=0;
		private string writeOffStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WriteOffApprovalID value.
		/// </summary>
		public long WriteOffApprovalID
		{
			get { return writeOffApprovalID; }
			set { writeOffApprovalID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientDueID value.
		/// </summary>
		public long PatientDueID
		{
			get { return patientDueID; }
			set { patientDueID = value; }
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
		/// Gets or sets the DiscountAmt value.
		/// </summary>
		public decimal DiscountAmt
		{
			get { return discountAmt; }
			set { discountAmt = value; }
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
		/// Gets or sets the ApprovedAmt value.
		/// </summary>
		public decimal ApprovedAmt
		{
			get { return approvedAmt; }
			set { approvedAmt = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the TaskID value.
		/// </summary>
		public long TaskID
		{
			get { return taskID; }
			set { taskID = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorisedBy value.
		/// </summary>
		public int AuthorisedBy
		{
			get { return authorisedBy; }
			set { authorisedBy = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffStatus value.
		/// </summary>
		public string WriteOffStatus
		{
			get { return writeOffStatus; }
			set { writeOffStatus = value; }
		}


		#endregion
}
}
