using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StockType
	{
		#region Fields

		private int stockTypeID=0;
		private string stockTypeName=String.Empty;
		private int searchTypeID=0;
		private int orgID=0;
		private string isDisplay=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockTypeID value.
		/// </summary>
		public int StockTypeID
		{
			get { return stockTypeID; }
			set { stockTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the StockTypeName value.
		/// </summary>
		public string StockTypeName
		{
			get { return stockTypeName; }
			set { stockTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the SearchTypeID value.
		/// </summary>
		public int SearchTypeID
		{
			get { return searchTypeID; }
			set { searchTypeID = value; }
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
		/// Gets or sets the IsDisplay value.
		/// </summary>
		public string IsDisplay
		{
			get { return isDisplay; }
			set { isDisplay = value; }
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

		/// <summary>
		/// Gets or sets the StockTypeValues value.
		/// </summary>
		string _stocktypevalues;
		public string StockTypeValues
		{
			get { return _stocktypevalues; }
			set { _stocktypevalues = value; }
		}


		#endregion
}
}
