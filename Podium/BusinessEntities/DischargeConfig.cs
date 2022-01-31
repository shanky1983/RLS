using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DischargeConfig
	{
		#region Fields

		private long dischargeConfigID=0;
		private string dischargeConfigKey=String.Empty;
		private string dischargeConfigValue=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargeConfigID value.
		/// </summary>
		public long DischargeConfigID
		{
			get { return dischargeConfigID; }
			set { dischargeConfigID = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeConfigKey value.
		/// </summary>
		public string DischargeConfigKey
		{
			get { return dischargeConfigKey; }
			set { dischargeConfigKey = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeConfigValue value.
		/// </summary>
		public string DischargeConfigValue
		{
			get { return dischargeConfigValue; }
			set { dischargeConfigValue = value; }
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
