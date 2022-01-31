using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CSSDRequestItems
	{
		#region Fields

		private long requestItemID=0;
		private long requestID=0;
		private long itemDetailID=0;
		private string itemDetailName=String.Empty;
		private short availableQuantity=0;
		private short damagedQuantity=0;
		private short missingQuantity=0;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RequestItemID value.
		/// </summary>
		public long RequestItemID
		{
			get { return requestItemID; }
			set { requestItemID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestID value.
		/// </summary>
		public long RequestID
		{
			get { return requestID; }
			set { requestID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemDetailID value.
		/// </summary>
		public long ItemDetailID
		{
			get { return itemDetailID; }
			set { itemDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemDetailName value.
		/// </summary>
		public string ItemDetailName
		{
			get { return itemDetailName; }
			set { itemDetailName = value; }
		}

		/// <summary>
		/// Gets or sets the AvailableQuantity value.
		/// </summary>
		public short AvailableQuantity
		{
			get { return availableQuantity; }
			set { availableQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the DamagedQuantity value.
		/// </summary>
		public short DamagedQuantity
		{
			get { return damagedQuantity; }
			set { damagedQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the MissingQuantity value.
		/// </summary>
		public short MissingQuantity
		{
			get { return missingQuantity; }
			set { missingQuantity = value; }
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
