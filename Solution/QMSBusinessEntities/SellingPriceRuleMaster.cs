using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SellingPriceRuleMaster
	{
		#region Fields

		private int sellingPriceRuleID=0;
		private string description=String.Empty;
		private decimal minimumPrice=Decimal.Zero;
		private decimal maximumPrice=Decimal.Zero;
		private decimal percentage=Decimal.Zero;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SellingPriceRuleID value.
		/// </summary>
		public int SellingPriceRuleID
		{
			get { return sellingPriceRuleID; }
			set { sellingPriceRuleID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the MinimumPrice value.
		/// </summary>
		public decimal MinimumPrice
		{
			get { return minimumPrice; }
			set { minimumPrice = value; }
		}

		/// <summary>
		/// Gets or sets the MaximumPrice value.
		/// </summary>
		public decimal MaximumPrice
		{
			get { return maximumPrice; }
			set { maximumPrice = value; }
		}

		/// <summary>
		/// Gets or sets the Percentage value.
		/// </summary>
		public decimal Percentage
		{
			get { return percentage; }
			set { percentage = value; }
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


		#endregion
}
}
