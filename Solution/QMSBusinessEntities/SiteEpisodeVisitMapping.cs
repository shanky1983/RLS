using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SiteEpisodeVisitMapping
	{
		#region Fields

		private long siteVisitMapID=0;
		private long episodeVisitId=0;
		private long siteID=0;
		private int noOfSubjects=0;
		private string isDelete=String.Empty;
		private string guid=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SiteVisitMapID value.
		/// </summary>
		public long SiteVisitMapID
		{
			get { return siteVisitMapID; }
			set { siteVisitMapID = value; }
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
		/// Gets or sets the SiteID value.
		/// </summary>
		public long SiteID
		{
			get { return siteID; }
			set { siteID = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfSubjects value.
		/// </summary>
		public int NoOfSubjects
		{
			get { return noOfSubjects; }
			set { noOfSubjects = value; }
		}

		/// <summary>
		/// Gets or sets the IsDelete value.
		/// </summary>
		public string IsDelete
		{
			get { return isDelete; }
			set { isDelete = value; }
		}

		/// <summary>
		/// Gets or sets the Guid value.
		/// </summary>
		public string Guid
		{
			get { return guid; }
			set { guid = value; }
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


		#endregion
}
}
