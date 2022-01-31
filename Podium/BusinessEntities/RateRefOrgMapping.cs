using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RateRefOrgMapping
	{
		#region Fields

		private long rateRefID=0;
		private long rateID=0;
		private int orgID=0;
		private long parentID=0;
		private long discountPolicyID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPolicyID value.
		/// </summary>
		public long DiscountPolicyID
		{
			get { return discountPolicyID; }
			set { discountPolicyID = value; }
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
		/// Gets or sets the RateCardName value.
		/// </summary>
		private string _rateCardName=String.Empty;
		public string RateCardName
		{
			get { return  _rateCardName; }
			set { _rateCardName = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationName value.
		/// </summary>
		private string _organizationName=String.Empty;
		public string OrganizationName
		{
			get { return  _organizationName; }
			set { _organizationName = value; }
		}


		#endregion
}
}
