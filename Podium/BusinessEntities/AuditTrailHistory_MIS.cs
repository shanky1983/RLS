using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AuditTrailHistory_MIS
	{
		#region Fields

		private int historyID=0;
		private int orgID=0;
		private long patientVisitID=0;
		private string visitNumber=String.Empty;
		private DateTime visitDate=DateTime.MaxValue;
		private DateTime changeDateTime=DateTime.MaxValue;
		private string user=String.Empty;
		private string location=String.Empty;
		private string activity=String.Empty;
		private string oldValue=String.Empty;
		private string currentValue=String.Empty;
		private string reason=String.Empty;
		private string preStatus=String.Empty;
		private string postStatus=String.Empty;
		private string activityState=String.Empty;
		private string deflagType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HistoryID value.
		/// </summary>
		public int HistoryID
		{
			get { return historyID; }
			set { historyID = value; }
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
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		public DateTime VisitDate
		{
			get { return visitDate; }
			set { visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the ChangeDateTime value.
		/// </summary>
		public DateTime ChangeDateTime
		{
			get { return changeDateTime; }
			set { changeDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the User value.
		/// </summary>
		public string User
		{
			get { return user; }
			set { user = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
		}

		/// <summary>
		/// Gets or sets the Activity value.
		/// </summary>
		public string Activity
		{
			get { return activity; }
			set { activity = value; }
		}

		/// <summary>
		/// Gets or sets the OldValue value.
		/// </summary>
		public string OldValue
		{
			get { return oldValue; }
			set { oldValue = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentValue value.
		/// </summary>
		public string CurrentValue
		{
			get { return currentValue; }
			set { currentValue = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the PreStatus value.
		/// </summary>
		public string PreStatus
		{
			get { return preStatus; }
			set { preStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PostStatus value.
		/// </summary>
		public string PostStatus
		{
			get { return postStatus; }
			set { postStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ActivityState value.
		/// </summary>
		public string ActivityState
		{
			get { return activityState; }
			set { activityState = value; }
		}

		/// <summary>
		/// Gets or sets the DeflagType value.
		/// </summary>
		public string DeflagType
		{
			get { return deflagType; }
			set { deflagType = value; }
		}


		#endregion
}
}
