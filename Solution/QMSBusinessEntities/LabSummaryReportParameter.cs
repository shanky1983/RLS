using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LabSummaryReportParameter
	{
		#region Fields

		private string parameterName=String.Empty;
		private int parameterValue=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ParameterName value.
		/// </summary>
		public string ParameterName
		{
			get { return parameterName; }
			set { parameterName = value; }
		}

		/// <summary>
		/// Gets or sets the ParameterValue value.
		/// </summary>
		public int ParameterValue
		{
			get { return parameterValue; }
			set { parameterValue = value; }
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
