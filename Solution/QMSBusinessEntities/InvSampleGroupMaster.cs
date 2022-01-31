using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvSampleGroupMaster
	{
		#region Fields

		private long sampleGroupID=0;
		private string sampleGroupName=String.Empty;
		private int orgID=0;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SampleGroupID value.
		/// </summary>
		public long SampleGroupID
		{
			get { return sampleGroupID; }
			set { sampleGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleGroupName value.
		/// </summary>
		public string SampleGroupName
		{
			get { return sampleGroupName; }
			set { sampleGroupName = value; }
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
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}


		#endregion
}
}
