using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RoleMenu
	{
		#region Fields

		private long userMenuID=0;
		private int menuID=0;
		private long roleID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int levelCode=0;
		private string isMapped=String.Empty;
		private string isMenu=String.Empty;

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
		/// Gets or sets the LevelCode value.
		/// </summary>
		public int LevelCode
		{
			get { return levelCode; }
			set { levelCode = value; }
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
		/// Gets or sets the IsMenu value.
		/// </summary>
		public string IsMenu
		{
			get { return isMenu; }
			set { isMenu = value; }
		}


		#endregion
}
}
