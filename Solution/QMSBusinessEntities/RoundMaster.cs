using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class RoundMaster
	{
		#region Fields

		private long roundID=0;
		private string roundName=String.Empty;
		private TimeSpan startTime=TimeSpan.MinValue;
		private TimeSpan endTime=TimeSpan.MinValue;
		private string startLocation=String.Empty;
		private string endLocation=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string isActive=String.Empty;
		private string roundRepeatDays=String.Empty;
		private int orgId=0;
		private string logisticEmployee=String.Empty;
		private string roundSheetTime=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RoundID value.
		/// </summary>
		public long RoundID
		{
			get { return roundID; }
			set { roundID = value; }
		}

		/// <summary>
		/// Gets or sets the RoundName value.
		/// </summary>
		public string RoundName
		{
			get { return roundName; }
			set { roundName = value; }
		}

		/// <summary>
		/// Gets or sets the StartTime value.
		/// </summary>
		public TimeSpan StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		/// <summary>
		/// Gets or sets the EndTime value.
		/// </summary>
		public TimeSpan EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		/// <summary>
		/// Gets or sets the StartLocation value.
		/// </summary>
		public string StartLocation
		{
			get { return startLocation; }
			set { startLocation = value; }
		}

		/// <summary>
		/// Gets or sets the EndLocation value.
		/// </summary>
		public string EndLocation
		{
			get { return endLocation; }
			set { endLocation = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the RoundRepeatDays value.
		/// </summary>
		public string RoundRepeatDays
		{
			get { return roundRepeatDays; }
			set { roundRepeatDays = value; }
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
		/// Gets or sets the LogisticEmployee value.
		/// </summary>
		public string LogisticEmployee
		{
			get { return logisticEmployee; }
			set { logisticEmployee = value; }
		}

		/// <summary>
		/// Gets or sets the RoundSheetTime value.
		/// </summary>
		public string RoundSheetTime
		{
			get { return roundSheetTime; }
			set { roundSheetTime = value; }
		}


		#endregion
}
}
