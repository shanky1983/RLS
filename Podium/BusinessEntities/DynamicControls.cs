using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DynamicControls
	{
		#region Fields

		private long loginID=0;
		private int specialityID=0;
		private string relatedControls=String.Empty;
		private long orgID=0;
		private int historyID=0;
		private int complaintID=0;
		private int patternID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the RelatedControls value.
		/// </summary>
		public string RelatedControls
		{
			get { return relatedControls; }
			set { relatedControls = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the HistoryID value.
		/// </summary>
		public int HistoryID
		{
			get { return historyID; }
			set { historyID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		public int PatternID
		{
			get { return patternID; }
			set { patternID = value; }
		}


		#endregion
}
}
