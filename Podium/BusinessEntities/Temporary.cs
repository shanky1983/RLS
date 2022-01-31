using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Temporary
	{
		#region Fields

		private long investigationID=0;
		private string valu=String.Empty;
		private string testCode=String.Empty;
		private string testName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}


		#endregion
}
}
