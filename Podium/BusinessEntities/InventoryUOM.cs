using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InventoryUOM
	{
		#region Fields

		private int uOMID=0;
		private string uOMCode=String.Empty;
		private string uOMDescription=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		public string UOMCode
		{
			get { return uOMCode; }
			set { uOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the UOMDescription value.
		/// </summary>
		public string UOMDescription
		{
			get { return uOMDescription; }
			set { uOMDescription = value; }
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


		#endregion
}
}
