using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HC_MissingReceipts
	{
		#region Fields

		private long pageID=0;
		private string buttonName=String.Empty;
		private long roleID=0;
		private long patientID=0;
		private int orgID=0;
		private long patientVisitID=0;
		private string createdat=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}

		/// <summary>
		/// Gets or sets the ButtonName value.
		/// </summary>
		public string ButtonName
		{
			get { return buttonName; }
			set { buttonName = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public string Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}


		#endregion
}
}
