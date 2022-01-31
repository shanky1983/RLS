using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InventoryUOMOrgMapping
	{
		#region Fields

		private long inventoryUOMOrgMappingId=0;
		private long inventoryUOMId=0;
		private long orgId=0;
		private long categoryId=0;
		private long typeId=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InventoryUOMOrgMappingId value.
		/// </summary>
		public long InventoryUOMOrgMappingId
		{
			get { return inventoryUOMOrgMappingId; }
			set { inventoryUOMOrgMappingId = value; }
		}

		/// <summary>
		/// Gets or sets the InventoryUOMId value.
		/// </summary>
		public long InventoryUOMId
		{
			get { return inventoryUOMId; }
			set { inventoryUOMId = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryId value.
		/// </summary>
		public long CategoryId
		{
			get { return categoryId; }
			set { categoryId = value; }
		}

		/// <summary>
		/// Gets or sets the TypeId value.
		/// </summary>
		public long TypeId
		{
			get { return typeId; }
			set { typeId = value; }
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
