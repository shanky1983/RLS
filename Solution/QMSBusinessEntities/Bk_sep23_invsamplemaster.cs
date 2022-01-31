using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Bk_sep23_invsamplemaster
	{
		#region Fields

		private long sampleCode=0;
		private string sampleDesc=String.Empty;
		private string code=String.Empty;
		private string active=String.Empty;
		private int orgID=0;
		private int sequenceNo=0;
		private string suffix=String.Empty;
		private int iD=0;
		private long sampleGroupID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		public long SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		public string SampleDesc
		{
			get { return sampleDesc; }
			set { sampleDesc = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the Suffix value.
		/// </summary>
		public string Suffix
		{
			get { return suffix; }
			set { suffix = value; }
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
		/// Gets or sets the SampleGroupID value.
		/// </summary>
		public long SampleGroupID
		{
			get { return sampleGroupID; }
			set { sampleGroupID = value; }
		}


		#endregion
}
}
