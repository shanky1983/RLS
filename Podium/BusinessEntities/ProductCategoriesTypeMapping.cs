using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProductCategoriesTypeMapping
	{
		#region Fields

		private long productCategoriesTypeMappingId=0;
		private int categoryID=0;
		private int typeID=0;
		private int orgID=0;
		private long isMandatory=0;
		private long status=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductCategoriesTypeMappingId value.
		/// </summary>
		public long ProductCategoriesTypeMappingId
		{
			get { return productCategoriesTypeMappingId; }
			set { productCategoriesTypeMappingId = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		public int CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
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
		/// Gets or sets the IsMandatory value.
		/// </summary>
		public long IsMandatory
		{
			get { return isMandatory; }
			set { isMandatory = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public long Status
		{
			get { return status; }
			set { status = value; }
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
