using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CSSDInventoryDetails
	{
		#region Fields

		private long inventoryDetailsID=0;
		private long inventoryID=0;
		private long identifyingID=0;
		private string identifyingType=String.Empty;
		private int quantity=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InventoryDetailsID value.
		/// </summary>
		public long InventoryDetailsID
		{
			get { return inventoryDetailsID; }
			set { inventoryDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the InventoryID value.
		/// </summary>
		public long InventoryID
		{
			get { return inventoryID; }
			set { inventoryID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingID value.
		/// </summary>
		public long IdentifyingID
		{
			get { return identifyingID; }
			set { identifyingID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingType value.
		/// </summary>
		public string IdentifyingType
		{
			get { return identifyingType; }
			set { identifyingType = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
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
