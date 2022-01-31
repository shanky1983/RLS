using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ActionMaster
	{
		#region Fields

		private int actionID=0;
		private string actionName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string queryString=String.Empty;
		private string actionCode=String.Empty;
		private int moduleID=0;
		private string isShareable=String.Empty;
		private string languageCode=String.Empty;

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
		/// Gets or sets the ActionName value.
		/// </summary>
		public string ActionName
		{
			get { return actionName; }
			set { actionName = value; }
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
		/// Gets or sets the QueryString value.
		/// </summary>
		public string QueryString
		{
			get { return queryString; }
			set { queryString = value; }
		}

		/// <summary>
		/// Gets or sets the ActionCode value.
		/// </summary>
		public string ActionCode
		{
			get { return actionCode; }
			set { actionCode = value; }
		}

		/// <summary>
		/// Gets or sets the ModuleID value.
		/// </summary>
		public int ModuleID
		{
			get { return moduleID; }
			set { moduleID = value; }
		}

		/// <summary>
		/// Gets or sets the IsShareable value.
		/// </summary>
		public string IsShareable
		{
			get { return isShareable; }
			set { isShareable = value; }
		}

		/// <summary>
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the PageURL value.
		/// </summary>
		private string _pageURL=String.Empty;
		public string PageURL
		{
			get { return  _pageURL; }
			set { _pageURL = value; }
		}

		/// <summary>
		/// Gets or sets the MenuID value.
		/// </summary>
		private int _menuID=0;
		public int MenuID
		{
			get { return  _menuID; }
			set { _menuID = value; }
		}

		/// <summary>
		/// Gets or sets the IsMapped value.
		/// </summary>
		private string _isMapped=String.Empty;
		public string IsMapped
		{
			get { return  _isMapped; }
			set { _isMapped = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		private string _description=String.Empty;
		public string Description
		{
			get { return  _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		private int _visitType=0;
		public int VisitType
		{
			get { return  _visitType; }
			set { _visitType = value; }
		}


		#endregion
}
}
