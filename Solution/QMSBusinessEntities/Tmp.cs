using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Tmp
	{
		#region Fields

		private string groupName=String.Empty;
		private string testcode=String.Empty;
		private int count=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
		}

		/// <summary>
		/// Gets or sets the Testcode value.
		/// </summary>
		public string Testcode
		{
			get { return testcode; }
			set { testcode = value; }
		}

		/// <summary>
		/// Gets or sets the Count value.
		/// </summary>
		public int Count
		{
			get { return count; }
			set { count = value; }
		}


		#endregion
}
}
