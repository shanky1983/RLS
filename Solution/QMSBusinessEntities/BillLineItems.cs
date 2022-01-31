using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BillLineItems
	{
		#region Fields

		private long billLineItemID=0;
		private long billID=0;
		private string itemName=String.Empty;
		private long itemID=0;
		private string itemType=String.Empty;
		private decimal quantity=Decimal.Zero;
		private decimal rate=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillLineItemID value.
		/// </summary>
		public long BillLineItemID
		{
			get { return billLineItemID; }
			set { billLineItemID = value; }
		}

		/// <summary>
		/// Gets or sets the BillID value.
		/// </summary>
		public long BillID
		{
			get { return billID; }
			set { billID = value; }
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
		/// Gets or sets the ItemID value.
		/// </summary>
		public long ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemType value.
		/// </summary>
		public string ItemType
		{
			get { return itemType; }
			set { itemType = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
