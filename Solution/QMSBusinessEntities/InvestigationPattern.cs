using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationPattern
	{
		#region Fields

		private long patternID=0;
		private string patternName=String.Empty;
		private string displayText=String.Empty;
		private int orgID=0;
		private int iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		public long PatternID
		{
			get { return patternID; }
			set { patternID = value; }
		}

		/// <summary>
		/// Gets or sets the PatternName value.
		/// </summary>
		public string PatternName
		{
			get { return patternName; }
			set { patternName = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
