using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationPattern
	{
		#region Fields

		private long patternID=0;
		private string patternName=String.Empty;
		private string displayText=String.Empty;
		private int orgID=0;
		private int iD=0;
		private string directiveName=String.Empty;
		private string directivePath=String.Empty;

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

		/// <summary>
		/// Gets or sets the DirectiveName value.
		/// </summary>
		public string DirectiveName
		{
			get { return directiveName; }
			set { directiveName = value; }
		}

		/// <summary>
		/// Gets or sets the DirectivePath value.
		/// </summary>
		public string DirectivePath
		{
			get { return directivePath; }
			set { directivePath = value; }
		}


		#endregion
}
}
