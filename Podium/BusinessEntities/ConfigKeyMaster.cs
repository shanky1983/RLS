using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ConfigKeyMaster
	{
		#region Fields

		private long configKeyID=0;
		private string configKey=String.Empty;
		private string displayText=String.Empty;
		private string isInternal=String.Empty;
		private string controlType=String.Empty;
		private string valueType=String.Empty;
		private string configType=String.Empty;
		private string isAddressBased=String.Empty;
		private long childConfigKeyID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConfigKeyID value.
		/// </summary>
		public long ConfigKeyID
		{
			get { return configKeyID; }
			set { configKeyID = value; }
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
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the IsInternal value.
		/// </summary>
		public string IsInternal
		{
			get { return isInternal; }
			set { isInternal = value; }
		}

		/// <summary>
		/// Gets or sets the ControlType value.
		/// </summary>
		public string ControlType
		{
			get { return controlType; }
			set { controlType = value; }
		}

		/// <summary>
		/// Gets or sets the ValueType value.
		/// </summary>
		public string ValueType
		{
			get { return valueType; }
			set { valueType = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigType value.
		/// </summary>
		public string ConfigType
		{
			get { return configType; }
			set { configType = value; }
		}

		/// <summary>
		/// Gets or sets the IsAddressBased value.
		/// </summary>
		public string IsAddressBased
		{
			get { return isAddressBased; }
			set { isAddressBased = value; }
		}

		/// <summary>
		/// Gets or sets the ChildConfigKeyID value.
		/// </summary>
		public long ChildConfigKeyID
		{
			get { return childConfigKeyID; }
			set { childConfigKeyID = value; }
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
		/// Gets or sets the ConfigID value.
		/// </summary>
		private long _configID=0;
		public long ConfigID
		{
			get { return  _configID; }
			set { _configID = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigValue value.
		/// </summary>
		private string _configValue=String.Empty;
		public string ConfigValue
		{
			get { return  _configValue; }
			set { _configValue = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		private int _orgID=0;
		public int OrgID
		{
			get { return  _orgID; }
			set { _orgID = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		private long _addressID=0;
		public long AddressID
		{
			get { return  _addressID; }
			set { _addressID = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationTypeID value.
		/// </summary>
		private int _organizationTypeID=0;
		public int OrganizationTypeID
		{
			get { return  _organizationTypeID; }
			set { _organizationTypeID = value; }
		}


		#endregion
}
}
