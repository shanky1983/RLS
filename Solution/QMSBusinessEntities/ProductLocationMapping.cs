using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProductLocationMapping
	{
		#region Fields

		private long productLocationMappingID=0;
		private long locationID=0;
		private long productID=0;
		private long reorderQuantity=0;
		private bool status=false;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long maximumQuantity=0;

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


		#endregion
}
}
