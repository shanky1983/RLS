using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		/// Gets or sets the ConfigID value.
		/// </summary>
		long _configid;
		public long ConfigID
		{
			get { return _configid; }
			set { _configid = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigValue value.
		/// </summary>
		string _configvalue;
		public string ConfigValue
		{
			get { return _configvalue; }
			set { _configvalue = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		int _orgid;
		public int OrgID
		{
			get { return _orgid; }
			set { _orgid = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		long _addressid;
		public long AddressID
		{
			get { return _addressid; }
			set { _addressid = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		string _location;
		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationTypeID value.
		/// </summary>
		int _organizationtypeid;
		public int OrganizationTypeID
		{
			get { return _organizationtypeid; }
			set { _organizationtypeid = value; }
		}


		#endregion
}
}
