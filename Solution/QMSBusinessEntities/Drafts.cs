using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Drafts
	{
		#region Fields

		private long draftID=0;
		private long orgID=0;
		private long locationId=0;
		private int pageID=0;
		private long loginID=0;
		private string draftType=String.Empty;
		private string draftValue=String.Empty;
		private string data=String.Empty;
		private string draftMasterID=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DraftID value.
		/// </summary>
		public long DraftID
		{
			get { return draftID; }
			set { draftID = value; }
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
		/// Gets or sets the LocationId value.
		/// </summary>
		public long LocationId
		{
			get { return locationId; }
			set { locationId = value; }
		}

		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public int PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the DraftType value.
		/// </summary>
		public string DraftType
		{
			get { return draftType; }
			set { draftType = value; }
		}

		/// <summary>
		/// Gets or sets the DraftValue value.
		/// </summary>
		public string DraftValue
		{
			get { return draftValue; }
			set { draftValue = value; }
		}

		/// <summary>
		/// Gets or sets the Data value.
		/// </summary>
		public string Data
		{
			get { return data; }
			set { data = value; }
		}

		/// <summary>
		/// Gets or sets the DraftMasterID value.
		/// </summary>
		public string DraftMasterID
		{
			get { return draftMasterID; }
			set { draftMasterID = value; }
		}


		#endregion
}
}
