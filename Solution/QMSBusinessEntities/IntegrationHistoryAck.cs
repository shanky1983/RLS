using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IntegrationHistoryAck
	{
		#region Fields

		private long iD=0;
		private long integrationHistoryID=0;
		private int orgId=0;
		private int locationId=0;
		private DateTime recDatetime=DateTime.MaxValue;
		private string failureReason=String.Empty;
		private string status=String.Empty;
		private string acknowledgement=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the IntegrationHistoryID value.
		/// </summary>
		public long IntegrationHistoryID
		{
			get { return integrationHistoryID; }
			set { integrationHistoryID = value; }
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
		/// Gets or sets the LocationId value.
		/// </summary>
		public int LocationId
		{
			get { return locationId; }
			set { locationId = value; }
		}

		/// <summary>
		/// Gets or sets the RecDatetime value.
		/// </summary>
		public DateTime RecDatetime
		{
			get { return recDatetime; }
			set { recDatetime = value; }
		}

		/// <summary>
		/// Gets or sets the FailureReason value.
		/// </summary>
		public string FailureReason
		{
			get { return failureReason; }
			set { failureReason = value; }
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
		/// Gets or sets the Acknowledgement value.
		/// </summary>
		public string Acknowledgement
		{
			get { return acknowledgement; }
			set { acknowledgement = value; }
		}


		#endregion
}
}
