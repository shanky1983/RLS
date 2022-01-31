using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Pages
	{
		#region Fields

		private long pageID=0;
		private string pageName=String.Empty;
		private string pageURL=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int moduleID=0;
		private string isShareable=String.Empty;

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
		/// Gets or sets the PageName value.
		/// </summary>
		public string PageName
		{
			get { return pageName; }
			set { pageName = value; }
		}

		/// <summary>
		/// Gets or sets the PageURL value.
		/// </summary>
		public string PageURL
		{
			get { return pageURL; }
			set { pageURL = value; }
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


		#endregion
}
}
