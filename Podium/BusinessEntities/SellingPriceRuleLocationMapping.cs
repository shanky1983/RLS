using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SellingPriceRuleLocationMapping
	{
		#region Fields

		private int mappingID=0;
		private int sellingPriceRuleID=0;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime toDate=DateTime.MaxValue;
		private int locationID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isDiscountAllow=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public int MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the SellingPriceRuleID value.
		/// </summary>
		public int SellingPriceRuleID
		{
			get { return sellingPriceRuleID; }
			set { sellingPriceRuleID = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		public DateTime FromDate
		{
			get { return fromDate; }
			set { fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the ToDate value.
		/// </summary>
		public DateTime ToDate
		{
			get { return toDate; }
			set { toDate = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
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
		/// Gets or sets the IsDiscountAllow value.
		/// </summary>
		public string IsDiscountAllow
		{
			get { return isDiscountAllow; }
			set { isDiscountAllow = value; }
		}


		#endregion
}
}
