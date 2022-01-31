using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Inv_Config
	{
		#region Fields

		private int rowID=0;
		private string configKey=String.Empty;
		private string displayText=String.Empty;
		private string isInternal=String.Empty;
		private string controlType=String.Empty;
		private string valueType=String.Empty;
		private string configType=String.Empty;
		private string isAddressBased=String.Empty;
		private string configValue=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public int RowID
		{
			get { return rowID; }
			set { rowID = value; }
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
		/// Gets or sets the ConfigValue value.
		/// </summary>
		public string ConfigValue
		{
			get { return configValue; }
			set { configValue = value; }
		}


		#endregion
}
}
