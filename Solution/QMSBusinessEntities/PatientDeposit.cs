using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDeposit
	{
		#region Fields

		private long depositID=0;
		private long patientID=0;
		private int orgID=0;
		private decimal totalDepositAmount=Decimal.Zero;
		private decimal totalDepositUsed=Decimal.Zero;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private decimal amtRefund=Decimal.Zero;
		private int roleID=0;
		private int deptID=0;

		#endregion

		#region Properties
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
		/// Gets or sets the TotalDepositAmount value.
		/// </summary>
		public decimal TotalDepositAmount
		{
			get { return totalDepositAmount; }
			set { totalDepositAmount = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDepositUsed value.
		/// </summary>
		public decimal TotalDepositUsed
		{
			get { return totalDepositUsed; }
			set { totalDepositUsed = value; }
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

		/// <summary>
		/// Gets or sets the AmtRefund value.
		/// </summary>
		public decimal AmtRefund
		{
			get { return amtRefund; }
			set { amtRefund = value; }
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


		#endregion
}
}
