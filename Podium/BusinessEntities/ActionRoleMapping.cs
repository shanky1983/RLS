using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ActionRoleMapping
	{
		#region Fields

		private int actionID=0;
		private long roleID=0;
		private long redirectPageID=0;
		private int searchTypeID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isMapped=String.Empty;
		private string isSplAuthorize=String.Empty;
		private long iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ActionID value.
		/// </summary>
		public int ActionID
		{
			get { return actionID; }
			set { actionID = value; }
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
		/// Gets or sets the RedirectPageID value.
		/// </summary>
		public long RedirectPageID
		{
			get { return redirectPageID; }
			set { redirectPageID = value; }
		}

		/// <summary>
		/// Gets or sets the SearchTypeID value.
		/// </summary>
		public int SearchTypeID
		{
			get { return searchTypeID; }
			set { searchTypeID = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the IsMapped value.
		/// </summary>
		public string IsMapped
		{
			get { return isMapped; }
			set { isMapped = value; }
		}

		/// <summary>
		/// Gets or sets the IsSplAuthorize value.
		/// </summary>
		public string IsSplAuthorize
		{
			get { return isSplAuthorize; }
			set { isSplAuthorize = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		private string _displayText=String.Empty;
		public string DisplayText
		{
			get { return  _displayText; }
			set { _displayText = value; }
		}

		/// <summary>
		/// Gets or sets the ActionName value.
		/// </summary>
		private string _actionName=String.Empty;
		public string ActionName
		{
			get { return  _actionName; }
			set { _actionName = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		private string _roleName=String.Empty;
		public string RoleName
		{
			get { return  _roleName; }
			set { _roleName = value; }
		}


		#endregion
}
}
