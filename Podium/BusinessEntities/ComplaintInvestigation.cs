using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ComplaintInvestigation
	{
		#region Fields

		private int complaintID=0;
		private int investigationID=0;
		private string isGroup=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public int InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the IsGroup value.
		/// </summary>
		public string IsGroup
		{
			get { return isGroup; }
			set { isGroup = value; }
		}


		#endregion
}
}
