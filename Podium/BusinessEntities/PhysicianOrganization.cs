using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PhysicianOrganization
	{
		#region Fields

		private int physicianID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string chartAccCode=String.Empty;
		private string isAmountEditable=String.Empty;
		private string isRefundable=String.Empty;
		private string isTaxable=String.Empty;
		private string isDiscountable=String.Empty;
		private string status=String.Empty;
		private long feeTypeGroupOrgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public int PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
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
		/// Gets or sets the ChartAccCode value.
		/// </summary>
		public string ChartAccCode
		{
			get { return chartAccCode; }
			set { chartAccCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsAmountEditable value.
		/// </summary>
		public string IsAmountEditable
		{
			get { return isAmountEditable; }
			set { isAmountEditable = value; }
		}

		/// <summary>
		/// Gets or sets the IsRefundable value.
		/// </summary>
		public string IsRefundable
		{
			get { return isRefundable; }
			set { isRefundable = value; }
		}

		/// <summary>
		/// Gets or sets the IsTaxable value.
		/// </summary>
		public string IsTaxable
		{
			get { return isTaxable; }
			set { isTaxable = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public string IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
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
		/// Gets or sets the FeeTypeGroupOrgID value.
		/// </summary>
		public long FeeTypeGroupOrgID
		{
			get { return feeTypeGroupOrgID; }
			set { feeTypeGroupOrgID = value; }
		}


		#endregion
}
}
