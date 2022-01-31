using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MenuMaster
	{
		#region Fields

		private int menuID=0;
		private string displayText=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int parentid=0;
		private int orgId=0;
		private long pageID=0;
		private string hasAction=String.Empty;
		private string languageCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MenuID value.
		/// </summary>
		public int MenuID
		{
			get { return menuID; }
			set { menuID = value; }
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
		/// Gets or sets the Parentid value.
		/// </summary>
		public int Parentid
		{
			get { return parentid; }
			set { parentid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
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
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}


		#endregion
}
}
