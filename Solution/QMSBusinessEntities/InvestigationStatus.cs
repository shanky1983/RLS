using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationStatus
	{
		#region Fields

		private int investigationStatusID=0;
		private string status=String.Empty;
		private string reason=String.Empty;
		private int orgid=0;
		private string displayText=String.Empty;
		private string aBBR=String.Empty;
		private int sequence=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationStatusID value.
		/// </summary>
		public int InvestigationStatusID
		{
			get { return investigationStatusID; }
			set { investigationStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the ABBR value.
		/// </summary>
		public string ABBR
		{
			get { return aBBR; }
			set { aBBR = value; }
		}

		/// <summary>
		/// Gets or sets the Sequence value.
		/// </summary>
		public int Sequence
		{
			get { return sequence; }
			set { sequence = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		long _investigationid;
		public long InvestigationID
		{
			get { return _investigationid; }
			set { _investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the StatuswithID value.
		/// </summary>
		String _statuswithid;
		public String StatuswithID
		{
			get { return _statuswithid; }
			set { _statuswithid = value; }
		}


		#endregion
}
}
