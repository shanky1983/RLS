using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ConfigOrgMaster
	{
		#region Fields

		private long configID=0;
		private long configKeyID=0;
		private string configValue=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long orgAddressId=0;

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
		/// Gets or sets the ConfigKeyID value.
		/// </summary>
		public long ConfigKeyID
		{
			get { return configKeyID; }
			set { configKeyID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the OrgAddressId value.
		/// </summary>
		public long OrgAddressId
		{
			get { return orgAddressId; }
			set { orgAddressId = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigType value.
		/// </summary>
		private string _configType=String.Empty;
		public string ConfigType
		{
			get { return  _configType; }
			set { _configType = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigKey value.
		/// </summary>
		private string _configKey=String.Empty;
		public string ConfigKey
		{
			get { return  _configKey; }
			set { _configKey = value; }
		}


		#endregion
}
}
