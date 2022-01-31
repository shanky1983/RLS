using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NewInstanceCreationTracker
	{
		#region Fields

		private int newInstanceWaitID=0;
		private int waitingList=0;
		private string status=String.Empty;
		private string defaultLoginName=String.Empty;
		private string defaultPassword=String.Empty;
		private int orgID=0;
		private int noofTries=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime completedAt=DateTime.MaxValue;
		private string isApproved=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NewInstanceWaitID value.
		/// </summary>
		public int NewInstanceWaitID
		{
			get { return newInstanceWaitID; }
			set { newInstanceWaitID = value; }
		}

		/// <summary>
		/// Gets or sets the WaitingList value.
		/// </summary>
		public int WaitingList
		{
			get { return waitingList; }
			set { waitingList = value; }
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
		/// Gets or sets the DefaultLoginName value.
		/// </summary>
		public string DefaultLoginName
		{
			get { return defaultLoginName; }
			set { defaultLoginName = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultPassword value.
		/// </summary>
		public string DefaultPassword
		{
			get { return defaultPassword; }
			set { defaultPassword = value; }
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
		/// Gets or sets the NoofTries value.
		/// </summary>
		public int NoofTries
		{
			get { return noofTries; }
			set { noofTries = value; }
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
		/// Gets or sets the CompletedAt value.
		/// </summary>
		public DateTime CompletedAt
		{
			get { return completedAt; }
			set { completedAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsApproved value.
		/// </summary>
		public string IsApproved
		{
			get { return isApproved; }
			set { isApproved = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		#endregion
}
}
