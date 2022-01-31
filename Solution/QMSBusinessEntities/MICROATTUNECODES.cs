using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MICROATTUNECODES
	{
		#region Fields

		private long testID=0;
		private string testCode=String.Empty;
		private string aBBCode=String.Empty;
		private string testName=String.Empty;
		private string displayName=String.Empty;
		private string type=String.Empty;
		private string iSOrderable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TestID value.
		/// </summary>
		public long TestID
		{
			get { return testID; }
			set { testID = value; }
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
		/// Gets or sets the ABBCode value.
		/// </summary>
		public string ABBCode
		{
			get { return aBBCode; }
			set { aBBCode = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayName value.
		/// </summary>
		public string DisplayName
		{
			get { return displayName; }
			set { displayName = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the ISOrderable value.
		/// </summary>
		public string ISOrderable
		{
			get { return iSOrderable; }
			set { iSOrderable = value; }
		}


		#endregion
}
}
