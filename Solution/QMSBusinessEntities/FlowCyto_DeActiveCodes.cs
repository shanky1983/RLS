using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FlowCyto_DeActiveCodes
	{
		#region Fields

		private string testCode=String.Empty;
		private string type=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}


		#endregion
}
}
