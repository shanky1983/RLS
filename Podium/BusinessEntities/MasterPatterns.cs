using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MasterPatterns
	{
		#region Fields

		private long patternID=0;
		private string patternName=String.Empty;
		private string patternValue=String.Empty;

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
		/// Gets or sets the PatternValue value.
		/// </summary>
		public string PatternValue
		{
			get { return patternValue; }
			set { patternValue = value; }
		}


		#endregion
}
}
