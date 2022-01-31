using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EmergencySeverityOrgMapping
	{
		#region Fields

		private long emergencySeverityOrgMappingID=0;
		private int emergencySerevityID=0;
		private long orgID=0;
		private string displayText=String.Empty;
		private string colorCoding=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EmergencySeverityOrgMappingID value.
		/// </summary>
		public long EmergencySeverityOrgMappingID
		{
			get { return emergencySeverityOrgMappingID; }
			set { emergencySeverityOrgMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the EmergencySerevityID value.
		/// </summary>
		public int EmergencySerevityID
		{
			get { return emergencySerevityID; }
			set { emergencySerevityID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the ColorCoding value.
		/// </summary>
		public string ColorCoding
		{
			get { return colorCoding; }
			set { colorCoding = value; }
		}


		#endregion
}
}
