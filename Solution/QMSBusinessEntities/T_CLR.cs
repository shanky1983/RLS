using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class T_CLR
	{
		#region Fields

		private string testName=String.Empty;
		private string display=String.Empty;
		private long investigationID=0;
		private string tCODE=String.Empty;
		private string isParameter=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the Display value.
		/// </summary>
		public string Display
		{
			get { return display; }
			set { display = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the IsParameter value.
		/// </summary>
		public string IsParameter
		{
			get { return isParameter; }
			set { isParameter = value; }
		}


		#endregion
}
}
