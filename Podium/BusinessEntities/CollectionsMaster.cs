using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CollectionsMaster
	{
		#region Fields

		private long collectionID=0;
		private long identificationid=0;
		private int orgID=0;
		private decimal totalDepositAmount=Decimal.Zero;
		private decimal totalDepositUsed=Decimal.Zero;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private decimal amtRefund=Decimal.Zero;
		private string customerType=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private string isRefund=String.Empty;
		private decimal billrefund=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CollectionID value.
		/// </summary>
		public long CollectionID
		{
			get { return collectionID; }
			set { collectionID = value; }
		}

		/// <summary>
		/// Gets or sets the Identificationid value.
		/// </summary>
		public long Identificationid
		{
			get { return identificationid; }
			set { identificationid = value; }
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
		/// Gets or sets the CustomerType value.
		/// </summary>
		public string CustomerType
		{
			get { return customerType; }
			set { customerType = value; }
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
		/// Gets or sets the IsRefund value.
		/// </summary>
		public string IsRefund
		{
			get { return isRefund; }
			set { isRefund = value; }
		}

		/// <summary>
		/// Gets or sets the Billrefund value.
		/// </summary>
		public decimal Billrefund
		{
			get { return billrefund; }
			set { billrefund = value; }
		}


		#endregion
}
}
