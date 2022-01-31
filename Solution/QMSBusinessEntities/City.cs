using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class City
	{
		#region Fields

		private long cityID=0;
		private string cityName=String.Empty;
		private long stateID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isDefault=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CityID value.
		/// </summary>
		public long CityID
		{
			get { return cityID; }
			set { cityID = value; }
		}

		/// <summary>
		/// Gets or sets the CityName value.
		/// </summary>
		public string CityName
		{
			get { return cityName; }
			set { cityName = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		public long StateID
		{
			get { return stateID; }
			set { stateID = value; }
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
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}


		#endregion
}
}
