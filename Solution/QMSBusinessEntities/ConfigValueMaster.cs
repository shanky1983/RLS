using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ConfigValueMaster
	{
		#region Fields

		private long configValueID=0;
		private long configKeyID=0;
		private string configValue=String.Empty;
		private string isTableReference=String.Empty;
		private string isActive=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConfigValueID value.
		/// </summary>
		public long ConfigValueID
		{
			get { return configValueID; }
			set { configValueID = value; }
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
		/// Gets or sets the IsTableReference value.
		/// </summary>
		public string IsTableReference
		{
			get { return isTableReference; }
			set { isTableReference = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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


		#endregion
}
}
