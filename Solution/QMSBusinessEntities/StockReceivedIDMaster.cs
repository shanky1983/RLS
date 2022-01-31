using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StockReceivedIDMaster
	{
		#region Fields

		private int stockReceivedIDMasterID=0;
		private long stockReceivedID=0;
		private int orgID=0;
		private int locationID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockReceivedIDMasterID value.
		/// </summary>
		public int StockReceivedIDMasterID
		{
			get { return stockReceivedIDMasterID; }
			set { stockReceivedIDMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedID value.
		/// </summary>
		public long StockReceivedID
		{
			get { return stockReceivedID; }
			set { stockReceivedID = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
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


		#endregion
}
}
