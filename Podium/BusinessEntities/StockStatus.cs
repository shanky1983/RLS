using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockStatus
	{
		#region Fields

		private int stockStatusID=0;
		private string stockStatusName=String.Empty;
		private int stockTypeID=0;
		private int orgID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockStatusID value.
		/// </summary>
		public int StockStatusID
		{
			get { return stockStatusID; }
			set { stockStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the StockStatusName value.
		/// </summary>
		public string StockStatusName
		{
			get { return stockStatusName; }
			set { stockStatusName = value; }
		}

		/// <summary>
		/// Gets or sets the StockTypeID value.
		/// </summary>
		public int StockTypeID
		{
			get { return stockTypeID; }
			set { stockTypeID = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
