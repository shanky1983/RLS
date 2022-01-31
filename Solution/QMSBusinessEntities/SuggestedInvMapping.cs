using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SuggestedInvMapping
	{
		#region Fields

		private long suggestedInvMappingID=0;
		private long invValueRangeMasterID=0;
		private long investigationID=0;
		private int complaintId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SuggestedInvMappingID value.
		/// </summary>
		public long SuggestedInvMappingID
		{
			get { return suggestedInvMappingID; }
			set { suggestedInvMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the InvValueRangeMasterID value.
		/// </summary>
		public long InvValueRangeMasterID
		{
			get { return invValueRangeMasterID; }
			set { invValueRangeMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		public int ComplaintId
		{
			get { return complaintId; }
			set { complaintId = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		string _investigationname;
		public string InvestigationName
		{
			get { return _investigationname; }
			set { _investigationname = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		string _complaintname;
		public string ComplaintName
		{
			get { return _complaintname; }
			set { _complaintname = value; }
		}


		#endregion
}
}
