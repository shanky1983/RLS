using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EpiContainerTrackingDetails
	{
		#region Fields

		private long trackDetailsID=0;
		private long trackID=0;
		private int statusID=0;
		private int orgID=0;
		private string attributes=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TrackDetailsID value.
		/// </summary>
		public long TrackDetailsID
		{
			get { return trackDetailsID; }
			set { trackDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the TrackID value.
		/// </summary>
		public long TrackID
		{
			get { return trackID; }
			set { trackID = value; }
		}

		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		public int StatusID
		{
			get { return statusID; }
			set { statusID = value; }
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
		/// Gets or sets the Attributes value.
		/// </summary>
		public string Attributes
		{
			get { return attributes; }
			set { attributes = value; }
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


		#endregion
}
}
