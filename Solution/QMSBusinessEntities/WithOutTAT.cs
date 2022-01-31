using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class WithOutTAT
	{
		#region Fields

		private long iD=0;
		private string testName=String.Empty;
		private string testType=String.Empty;
		private string orderable=String.Empty;
		private string tcode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the TestType value.
		/// </summary>
		public string TestType
		{
			get { return testType; }
			set { testType = value; }
		}

		/// <summary>
		/// Gets or sets the Orderable value.
		/// </summary>
		public string Orderable
		{
			get { return orderable; }
			set { orderable = value; }
		}

		/// <summary>
		/// Gets or sets the Tcode value.
		/// </summary>
		public string Tcode
		{
			get { return tcode; }
			set { tcode = value; }
		}


		#endregion
}
}
