using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReportProfile
	{
		#region Fields

		private long reportID=0;
		private string defaultConfigValue=String.Empty;
		private string currentConfigValue=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReportID value.
		/// </summary>
		public long ReportID
		{
			get { return reportID; }
			set { reportID = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultConfigValue value.
		/// </summary>
		public string DefaultConfigValue
		{
			get { return defaultConfigValue; }
			set { defaultConfigValue = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentConfigValue value.
		/// </summary>
		public string CurrentConfigValue
		{
			get { return currentConfigValue; }
			set { currentConfigValue = value; }
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
