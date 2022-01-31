using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RoleMenuInfo
	{
		#region Fields

		private long userMenuID=0;
		private int menuID=0;
		private long roleID=0;
		private string roleName=String.Empty;
		private long parentID=0;
		private string displayText=String.Empty;
		private string menuHeader=String.Empty;
		private string isMapped=String.Empty;
		private string hasAction=String.Empty;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private string description=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the UserMenuID value.
		/// </summary>
		public long UserMenuID
		{
			get { return userMenuID; }
			set { userMenuID = value; }
		}

		/// <summary>
		/// Gets or sets the MenuID value.
		/// </summary>
		public int MenuID
		{
			get { return menuID; }
			set { menuID = value; }
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
		/// Gets or sets the RoleName value.
		/// </summary>
		public string RoleName
		{
			get { return roleName; }
			set { roleName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
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
		/// Gets or sets the MenuHeader value.
		/// </summary>
		public string MenuHeader
		{
			get { return menuHeader; }
			set { menuHeader = value; }
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
		/// Gets or sets the HasAction value.
		/// </summary>
		public string HasAction
		{
			get { return hasAction; }
			set { hasAction = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}


		#endregion
}
}
