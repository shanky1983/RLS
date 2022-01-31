using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PageContext
	{
		#region Fields

		private long pageContextID=0;
		private long pageID=0;
		private string buttonName=String.Empty;
		private string buttionValue=String.Empty;
		private string pageName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PageContextID value.
		/// </summary>
		public long PageContextID
		{
			get { return pageContextID; }
			set { pageContextID = value; }
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
		/// Gets or sets the ButtonName value.
		/// </summary>
		public string ButtonName
		{
			get { return buttonName; }
			set { buttonName = value; }
		}

		/// <summary>
		/// Gets or sets the ButtionValue value.
		/// </summary>
		public string ButtionValue
		{
			get { return buttionValue; }
			set { buttionValue = value; }
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


		#endregion
}
}
