using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class KitMaster
	{
		#region Fields

		private long masterID=0;
		private long masterKitID=0;
		private long productID=0;
		private int orgID=0;
		private decimal quantity=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string iscommon=String.Empty;
		private string isDelete=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MasterID value.
		/// </summary>
		public long MasterID
		{
			get { return masterID; }
			set { masterID = value; }
		}

		/// <summary>
		/// Gets or sets the MasterKitID value.
		/// </summary>
		public long MasterKitID
		{
			get { return masterKitID; }
			set { masterKitID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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

		/// <summary>
		/// Gets or sets the Iscommon value.
		/// </summary>
		public string Iscommon
		{
			get { return iscommon; }
			set { iscommon = value; }
		}

		/// <summary>
		/// Gets or sets the IsDelete value.
		/// </summary>
		public string IsDelete
		{
			get { return isDelete; }
			set { isDelete = value; }
		}

		/// <summary>
		/// Gets or sets the ProductName value.
		/// </summary>
		private string _productName=String.Empty;
		public string ProductName
		{
			get { return  _productName; }
			set { _productName = value; }
		}


		#endregion
}
}
