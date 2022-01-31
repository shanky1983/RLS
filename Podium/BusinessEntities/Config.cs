using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Config
	{
		#region Fields

		private long configID=0;
		private string configKey=String.Empty;
		private string configValue=String.Empty;
		private long parentID=0;
		private int orgID=0;

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
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
