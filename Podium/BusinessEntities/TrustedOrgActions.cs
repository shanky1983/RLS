using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TrustedOrgActions
	{
		#region Fields

		private long trustedOrgActionsID=0;
		private long trustedOrgDetailsID=0;
		private string identifyingType=String.Empty;
		private long identifyingActionID=0;
		private long roleID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TrustedOrgActionsID value.
		/// </summary>
		public long TrustedOrgActionsID
		{
			get { return trustedOrgActionsID; }
			set { trustedOrgActionsID = value; }
		}

		/// <summary>
		/// Gets or sets the TrustedOrgDetailsID value.
		/// </summary>
		public long TrustedOrgDetailsID
		{
			get { return trustedOrgDetailsID; }
			set { trustedOrgDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingType value.
		/// </summary>
		public string IdentifyingType
		{
			get { return identifyingType; }
			set { identifyingType = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingActionID value.
		/// </summary>
		public long IdentifyingActionID
		{
			get { return identifyingActionID; }
			set { identifyingActionID = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the DummyString value.
		/// </summary>
		private string _dummyString=String.Empty;
		public string DummyString
		{
			get { return  _dummyString; }
			set { _dummyString = value; }
		}

		/// <summary>
		/// Gets or sets the LoggedOrgID value.
		/// </summary>
		private int _loggedOrgID=0;
		public int LoggedOrgID
		{
			get { return  _loggedOrgID; }
			set { _loggedOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the SharingOrgID value.
		/// </summary>
		private int _sharingOrgID=0;
		public int SharingOrgID
		{
			get { return  _sharingOrgID; }
			set { _sharingOrgID = value; }
		}


		#endregion
}
}
