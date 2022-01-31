using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CheckAttributeDetails
	{
		#region Fields

		private long controlAttributeID=0;
		private long controlID=0;
		private string controlKey=String.Empty;
		private string controlValue=String.Empty;
		private long visitID=0;
		private long episodeID=0;
		private long siteID=0;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ControlAttributeID value.
		/// </summary>
		public long ControlAttributeID
		{
			get { return controlAttributeID; }
			set { controlAttributeID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlID value.
		/// </summary>
		public long ControlID
		{
			get { return controlID; }
			set { controlID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlKey value.
		/// </summary>
		public string ControlKey
		{
			get { return controlKey; }
			set { controlKey = value; }
		}

		/// <summary>
		/// Gets or sets the ControlValue value.
		/// </summary>
		public string ControlValue
		{
			get { return controlValue; }
			set { controlValue = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeID value.
		/// </summary>
		public long EpisodeID
		{
			get { return episodeID; }
			set { episodeID = value; }
		}

		/// <summary>
		/// Gets or sets the SiteID value.
		/// </summary>
		public long SiteID
		{
			get { return siteID; }
			set { siteID = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
