using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TrustedOrgRequest
	{
		#region Fields

		private int requestToOrgID=0;
		private int requestedOrgID=0;
		private string requestStatus=String.Empty;
		private DateTime requestApprovedDate=DateTime.MaxValue;
		private DateTime requestRejectedDate=DateTime.MaxValue;
		private string requestRejectedReason=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RequestToOrgID value.
		/// </summary>
		public int RequestToOrgID
		{
			get { return requestToOrgID; }
			set { requestToOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestedOrgID value.
		/// </summary>
		public int RequestedOrgID
		{
			get { return requestedOrgID; }
			set { requestedOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestStatus value.
		/// </summary>
		public string RequestStatus
		{
			get { return requestStatus; }
			set { requestStatus = value; }
		}

		/// <summary>
		/// Gets or sets the RequestApprovedDate value.
		/// </summary>
		public DateTime RequestApprovedDate
		{
			get { return requestApprovedDate; }
			set { requestApprovedDate = value; }
		}

		/// <summary>
		/// Gets or sets the RequestRejectedDate value.
		/// </summary>
		public DateTime RequestRejectedDate
		{
			get { return requestRejectedDate; }
			set { requestRejectedDate = value; }
		}

		/// <summary>
		/// Gets or sets the RequestRejectedReason value.
		/// </summary>
		public string RequestRejectedReason
		{
			get { return requestRejectedReason; }
			set { requestRejectedReason = value; }
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
