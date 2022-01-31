using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class KitStudyDetails
	{
		#region Fields

		private long kitstudyID=0;
		private string kitID=String.Empty;
		private string kitBacthNo=String.Empty;
		private long studyID=0;
		private long siteID=0;
		private long episodeVisitId=0;
		private long indentID=0;
		private int actualRaiseQty=0;
		private int raisedQty=0;
		private int orgID=0;
		private int orgAddID=0;
		private int locationID=0;
		private int toLocationID=0;
		private string status=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the KitstudyID value.
		/// </summary>
		public long KitstudyID
		{
			get { return kitstudyID; }
			set { kitstudyID = value; }
		}

		/// <summary>
		/// Gets or sets the KitID value.
		/// </summary>
		public string KitID
		{
			get { return kitID; }
			set { kitID = value; }
		}

		/// <summary>
		/// Gets or sets the KitBacthNo value.
		/// </summary>
		public string KitBacthNo
		{
			get { return kitBacthNo; }
			set { kitBacthNo = value; }
		}

		/// <summary>
		/// Gets or sets the StudyID value.
		/// </summary>
		public long StudyID
		{
			get { return studyID; }
			set { studyID = value; }
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
		/// Gets or sets the EpisodeVisitId value.
		/// </summary>
		public long EpisodeVisitId
		{
			get { return episodeVisitId; }
			set { episodeVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the IndentID value.
		/// </summary>
		public long IndentID
		{
			get { return indentID; }
			set { indentID = value; }
		}

		/// <summary>
		/// Gets or sets the ActualRaiseQty value.
		/// </summary>
		public int ActualRaiseQty
		{
			get { return actualRaiseQty; }
			set { actualRaiseQty = value; }
		}

		/// <summary>
		/// Gets or sets the RaisedQty value.
		/// </summary>
		public int RaisedQty
		{
			get { return raisedQty; }
			set { raisedQty = value; }
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
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public int OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		public int ToLocationID
		{
			get { return toLocationID; }
			set { toLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
