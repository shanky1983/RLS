using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvReasonOrgMapping
	{
		#region Fields

		private long statusID=0;
		private long reasonID=0;
		private int orgID=0;
		private int sequenceNo=0;
		private long invOrgReasonID=0;
		private string displaytext=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		public long StatusID
		{
			get { return statusID; }
			set { statusID = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonID value.
		/// </summary>
		public long ReasonID
		{
			get { return reasonID; }
			set { reasonID = value; }
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
		/// Gets or sets the InvOrgReasonID value.
		/// </summary>
		public long InvOrgReasonID
		{
			get { return invOrgReasonID; }
			set { invOrgReasonID = value; }
		}

		/// <summary>
		/// Gets or sets the Displaytext value.
		/// </summary>
		public string Displaytext
		{
			get { return displaytext; }
			set { displaytext = value; }
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
