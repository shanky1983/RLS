using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BillConfig
	{
		#region Fields

		private long configID=0;
		private string configKey=String.Empty;
		private string configValue=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long billTypeID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConfigID value.
		/// </summary>
		public long ConfigID
		{
			get { return configID; }
			set { configID = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigKey value.
		/// </summary>
		public string ConfigKey
		{
			get { return configKey; }
			set { configKey = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigValue value.
		/// </summary>
		public string ConfigValue
		{
			get { return configValue; }
			set { configValue = value; }
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
		/// Gets or sets the BillTypeID value.
		/// </summary>
		public long BillTypeID
		{
			get { return billTypeID; }
			set { billTypeID = value; }
		}


		#endregion
}
}
