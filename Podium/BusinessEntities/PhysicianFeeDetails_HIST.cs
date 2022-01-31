using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PhysicianFeeDetails_HIST
	{
		#region Fields

		private long physicianFeeDetailsID=0;
		private long physicianFeeID=0;
		private int orgID=0;
		private string type=String.Empty;
		private int feeTypeAttributesID=0;
		private decimal amount=Decimal.Zero;
		private string status=String.Empty;
		private long physicianID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long histID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PhysicianFeeDetailsID value.
		/// </summary>
		public long PhysicianFeeDetailsID
		{
			get { return physicianFeeDetailsID; }
			set { physicianFeeDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianFeeID value.
		/// </summary>
		public long PhysicianFeeID
		{
			get { return physicianFeeID; }
			set { physicianFeeID = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeAttributesID value.
		/// </summary>
		public int FeeTypeAttributesID
		{
			get { return feeTypeAttributesID; }
			set { feeTypeAttributesID = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
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
		/// Gets or sets the HistID value.
		/// </summary>
		public long HistID
		{
			get { return histID; }
			set { histID = value; }
		}


		#endregion
}
}
