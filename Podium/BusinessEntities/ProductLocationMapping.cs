using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProductLocationMapping
	{
		#region Fields

		private long productLocationMappingID=0;
		private long locationID=0;
		private long productID=0;
		private long reorderQuantity=0;
		private bool status=true;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long maximumQuantity=0;
		private int isIndentLocation=0;
		private string stockFrequency=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductLocationMappingID value.
		/// </summary>
		public long ProductLocationMappingID
		{
			get { return productLocationMappingID; }
			set { productLocationMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the ReorderQuantity value.
		/// </summary>
		public long ReorderQuantity
		{
			get { return reorderQuantity; }
			set { reorderQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the MaximumQuantity value.
		/// </summary>
		public long MaximumQuantity
		{
			get { return maximumQuantity; }
			set { maximumQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the IsIndentLocation value.
		/// </summary>
		public int IsIndentLocation
		{
			get { return isIndentLocation; }
			set { isIndentLocation = value; }
		}

		/// <summary>
		/// Gets or sets the StockFrequency value.
		/// </summary>
		public string StockFrequency
		{
			get { return stockFrequency; }
			set { stockFrequency = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		private long _orgId=0;
		public long OrgId
		{
			get { return  _orgId; }
			set { _orgId = value; }
		}


		#endregion
}
}
