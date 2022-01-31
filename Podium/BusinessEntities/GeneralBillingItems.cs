using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class GeneralBillingItems
	{
		#region Fields

		private int itemID=0;
		private string itemName=String.Empty;
		private decimal rate=Decimal.Zero;
		private long orgID=0;
		private int rateID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal iPAmount=Decimal.Zero;
		private long genBillID=0;
		private long rateRefID=0;
		private string feeSubType=String.Empty;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ItemID value.
		/// </summary>
		public int ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public string ItemName
		{
			get { return itemName; }
			set { itemName = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
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
		/// Gets or sets the IPAmount value.
		/// </summary>
		public decimal IPAmount
		{
			get { return iPAmount; }
			set { iPAmount = value; }
		}

		/// <summary>
		/// Gets or sets the GenBillID value.
		/// </summary>
		public long GenBillID
		{
			get { return genBillID; }
			set { genBillID = value; }
		}

		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeSubType value.
		/// </summary>
		public string FeeSubType
		{
			get { return feeSubType; }
			set { feeSubType = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCommands value.
		/// </summary>
		private string _itemCommands=String.Empty;
		public string ItemCommands
		{
			get { return  _itemCommands; }
			set { _itemCommands = value; }
		}


		#endregion
}
}
