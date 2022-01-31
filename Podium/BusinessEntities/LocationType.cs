using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LocationType
	{
		#region Fields

		private int locationTypeID=0;
		private string locationTypeName=String.Empty;
		private string locationTypeCode=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LocationTypeID value.
		/// </summary>
		public int LocationTypeID
		{
			get { return locationTypeID; }
			set { locationTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationTypeName value.
		/// </summary>
		public string LocationTypeName
		{
			get { return locationTypeName; }
			set { locationTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the LocationTypeCode value.
		/// </summary>
		public string LocationTypeCode
		{
			get { return locationTypeCode; }
			set { locationTypeCode = value; }
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
