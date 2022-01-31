using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Schedules
	{
		#region Fields

		private long scheduleID=0;
		private long resourceTemplateID=0;
		private DateTime nextOccurance=DateTime.MaxValue;
		private DateTime previousOccurance=DateTime.MaxValue;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string scheduleStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ScheduleID value.
		/// </summary>
		public long ScheduleID
		{
			get { return scheduleID; }
			set { scheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceTemplateID value.
		/// </summary>
		public long ResourceTemplateID
		{
			get { return resourceTemplateID; }
			set { resourceTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the NextOccurance value.
		/// </summary>
		public DateTime NextOccurance
		{
			get { return nextOccurance; }
			set { nextOccurance = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousOccurance value.
		/// </summary>
		public DateTime PreviousOccurance
		{
			get { return previousOccurance; }
			set { previousOccurance = value; }
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
		/// Gets or sets the ScheduleStatus value.
		/// </summary>
		public string ScheduleStatus
		{
			get { return scheduleStatus; }
			set { scheduleStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		long _clientid;
		public long ClientID
		{
			get { return _clientid; }
			set { _clientid = value; }
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
		/// Gets or sets the ClientType value.
		/// </summary>
		string _clienttype;
		public string ClientType
		{
			get { return _clienttype; }
			set { _clienttype = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		string _clientcode;
		public string ClientCode
		{
			get { return _clientcode; }
			set { _clientcode = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalRequired value.
		/// </summary>
		string _approvalrequired;
		public string ApprovalRequired
		{
			get { return _approvalrequired; }
			set { _approvalrequired = value; }
		}


		#endregion
}
}
