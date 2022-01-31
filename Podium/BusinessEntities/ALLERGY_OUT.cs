using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ALLERGY_OUT
	{
		#region Fields

		private string testCode=String.Empty;
		private string testName=String.Empty;
		private string testLocation=String.Empty;
		private string rRUNIT=String.Empty;
		private string dEPT=String.Empty;
		private string method=String.Empty;
		private int aCRPID=0;
		private int aORGID=0;
		private string aTYPE=String.Empty;
		private int pLID=0;

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
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the TestLocation value.
		/// </summary>
		public string TestLocation
		{
			get { return testLocation; }
			set { testLocation = value; }
		}

		/// <summary>
		/// Gets or sets the RRUNIT value.
		/// </summary>
		public string RRUNIT
		{
			get { return rRUNIT; }
			set { rRUNIT = value; }
		}

		/// <summary>
		/// Gets or sets the DEPT value.
		/// </summary>
		public string DEPT
		{
			get { return dEPT; }
			set { dEPT = value; }
		}

		/// <summary>
		/// Gets or sets the Method value.
		/// </summary>
		public string Method
		{
			get { return method; }
			set { method = value; }
		}

		/// <summary>
		/// Gets or sets the ACRPID value.
		/// </summary>
		public int ACRPID
		{
			get { return aCRPID; }
			set { aCRPID = value; }
		}

		/// <summary>
		/// Gets or sets the AORGID value.
		/// </summary>
		public int AORGID
		{
			get { return aORGID; }
			set { aORGID = value; }
		}

		/// <summary>
		/// Gets or sets the ATYPE value.
		/// </summary>
		public string ATYPE
		{
			get { return aTYPE; }
			set { aTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the PLID value.
		/// </summary>
		public int PLID
		{
			get { return pLID; }
			set { pLID = value; }
		}


		#endregion
}
}
