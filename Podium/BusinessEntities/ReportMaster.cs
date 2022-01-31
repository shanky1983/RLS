using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReportMaster
	{
		#region Fields

		private long reportID=0;
		private string reportDisplayText=String.Empty;
		private string reportPath=String.Empty;
		private string redirectURL=String.Empty;
		private long reportGroupID=0;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long pageID=0;
		private long deploymentOrganizationTypeID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReportID value.
		/// </summary>
		public long ReportID
		{
			get { return reportID; }
			set { reportID = value; }
		}

		/// <summary>
		/// Gets or sets the ReportDisplayText value.
		/// </summary>
		public string ReportDisplayText
		{
			get { return reportDisplayText; }
			set { reportDisplayText = value; }
		}

		/// <summary>
		/// Gets or sets the ReportPath value.
		/// </summary>
		public string ReportPath
		{
			get { return reportPath; }
			set { reportPath = value; }
		}

		/// <summary>
		/// Gets or sets the RedirectURL value.
		/// </summary>
		public string RedirectURL
		{
			get { return redirectURL; }
			set { redirectURL = value; }
		}

		/// <summary>
		/// Gets or sets the ReportGroupID value.
		/// </summary>
		public long ReportGroupID
		{
			get { return reportGroupID; }
			set { reportGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}

		/// <summary>
		/// Gets or sets the DeploymentOrganizationTypeID value.
		/// </summary>
		public long DeploymentOrganizationTypeID
		{
			get { return deploymentOrganizationTypeID; }
			set { deploymentOrganizationTypeID = value; }
		}


		#endregion
}
}
