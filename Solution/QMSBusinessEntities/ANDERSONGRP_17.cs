using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ANDERSONGRP_17
	{
		#region Fields

		private string testName=String.Empty;
		private string att_code=String.Empty;
		private string tYPE=String.Empty;
		private int iD=0;

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
		/// Gets or sets the Att_code value.
		/// </summary>
		public string Att_code
		{
			get { return att_code; }
			set { att_code = value; }
		}

		/// <summary>
		/// Gets or sets the TYPE value.
		/// </summary>
		public string TYPE
		{
			get { return tYPE; }
			set { tYPE = value; }
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
