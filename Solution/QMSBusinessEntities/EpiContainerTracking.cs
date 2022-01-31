using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EpiContainerTracking
	{
		#region Fields

		private long trackID=0;
		private long episodeId=0;
		private long siteID=0;
		private int shippingConditionID=0;
		private int visitNo=0;
		private string additionalInfo=String.Empty;
		private int currentStatusID=0;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string consignmentNo=String.Empty;
		private long regTrackID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TrackID value.
		/// </summary>
		public long TrackID
		{
			get { return trackID; }
			set { trackID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeId value.
		/// </summary>
		public long EpisodeId
		{
			get { return episodeId; }
			set { episodeId = value; }
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
		/// Gets or sets the ShippingConditionID value.
		/// </summary>
		public int ShippingConditionID
		{
			get { return shippingConditionID; }
			set { shippingConditionID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNo value.
		/// </summary>
		public int VisitNo
		{
			get { return visitNo; }
			set { visitNo = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalInfo value.
		/// </summary>
		public string AdditionalInfo
		{
			get { return additionalInfo; }
			set { additionalInfo = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentStatusID value.
		/// </summary>
		public int CurrentStatusID
		{
			get { return currentStatusID; }
			set { currentStatusID = value; }
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

		/// <summary>
		/// Gets or sets the ConsignmentNo value.
		/// </summary>
		public string ConsignmentNo
		{
			get { return consignmentNo; }
			set { consignmentNo = value; }
		}

		/// <summary>
		/// Gets or sets the RegTrackID value.
		/// </summary>
		public long RegTrackID
		{
			get { return regTrackID; }
			set { regTrackID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeName value.
		/// </summary>
		string _episodename;
		public string EpisodeName
		{
			get { return _episodename; }
			set { _episodename = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		string _clientname;
		public string ClientName
		{
			get { return _clientname; }
			set { _clientname = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionDesc value.
		/// </summary>
		string _conditiondesc;
		public string ConditionDesc
		{
			get { return _conditiondesc; }
			set { _conditiondesc = value; }
		}

		/// <summary>
		/// Gets or sets the StatusDesc value.
		/// </summary>
		string _statusdesc;
		public string StatusDesc
		{
			get { return _statusdesc; }
			set { _statusdesc = value; }
		}

		/// <summary>
		/// Gets or sets the EpiStatus value.
		/// </summary>
		string _epistatus;
		public string EpiStatus
		{
			get { return _epistatus; }
			set { _epistatus = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedName value.
		/// </summary>
		string _createdname;
		public string CreatedName
		{
			get { return _createdname; }
			set { _createdname = value; }
		}

		/// <summary>
		/// Gets or sets the TrackDetailsID value.
		/// </summary>
		long _trackdetailsid;
		public long TrackDetailsID
		{
			get { return _trackdetailsid; }
			set { _trackdetailsid = value; }
		}

		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		long _statusid;
		public long StatusID
		{
			get { return _statusid; }
			set { _statusid = value; }
		}

		/// <summary>
		/// Gets or sets the SamplesCount value.
		/// </summary>
		int _samplescount;
		public int SamplesCount
		{
			get { return _samplescount; }
			set { _samplescount = value; }
		}


		#endregion
}
}
