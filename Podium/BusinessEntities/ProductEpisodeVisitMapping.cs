using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProductEpisodeVisitMapping
	{
		#region Fields

		private long productVisitMapID=0;
		private long episodeVisitId=0;
		private long productID=0;
		private string productType=String.Empty;
		private int valu=0;
		private string guid=String.Empty;
		private string isDelete=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductVisitMapID value.
		/// </summary>
		public long ProductVisitMapID
		{
			get { return productVisitMapID; }
			set { productVisitMapID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeVisitId value.
		/// </summary>
		public long EpisodeVisitId
		{
			get { return episodeVisitId; }
			set { episodeVisitId = value; }
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
		/// Gets or sets the ProductType value.
		/// </summary>
		public string ProductType
		{
			get { return productType; }
			set { productType = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public int Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the Guid value.
		/// </summary>
		public string Guid
		{
			get { return guid; }
			set { guid = value; }
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
		/// Gets or sets the ProductName value.
		/// </summary>
		private string _productName=String.Empty;
		public string ProductName
		{
			get { return  _productName; }
			set { _productName = value; }
		}

		/// <summary>
		/// Gets or sets the KitID value.
		/// </summary>
		private long _kitID=0;
		public long KitID
		{
			get { return  _kitID; }
			set { _kitID = value; }
		}


		#endregion
}
}
