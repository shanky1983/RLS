using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientProductTypeRuleMapping
	{
		#region Fields

		private long clientProRuleMapID=0;
		private int clientID=0;
		private int productTyeID=0;
		private string isPrescribed=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long modifiedAt=0;
		private string isActive=String.Empty;
		private string type=String.Empty;
		private int categoryID=0;
		private string applyForPrice=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClientProRuleMapID value.
		/// </summary>
		public long ClientProRuleMapID
		{
			get { return clientProRuleMapID; }
			set { clientProRuleMapID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductTyeID value.
		/// </summary>
		public int ProductTyeID
		{
			get { return productTyeID; }
			set { productTyeID = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrescribed value.
		/// </summary>
		public string IsPrescribed
		{
			get { return isPrescribed; }
			set { isPrescribed = value; }
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
		public long ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the ApplyForPrice value.
		/// </summary>
		public string ApplyForPrice
		{
			get { return applyForPrice; }
			set { applyForPrice = value; }
		}


		#endregion
}
}
