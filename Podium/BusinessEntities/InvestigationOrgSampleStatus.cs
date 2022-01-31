using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationOrgSampleStatus
	{
		#region Fields

		private int orgID=0;
		private string sampleStatus=String.Empty;
		private int seqNo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleStatus value.
		/// </summary>
		public string SampleStatus
		{
			get { return sampleStatus; }
			set { sampleStatus = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}


		#endregion
}
}
