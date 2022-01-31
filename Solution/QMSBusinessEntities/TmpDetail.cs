using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TmpDetail
	{
		#region Fields

		private int sno=0;
		private int orgid=0;
		private long investigationid=0;
		private string testType=String.Empty;
		private int tAT=0;
		private int recurrenceid=0;
		private int recurrenceCycleid=0;
		private int scheduleTemplateID=0;
		private long resouceTemplateid=0;
		private decimal start=Decimal.Zero;
		private decimal labend=Decimal.Zero;
		private decimal reporttime=Decimal.Zero;
		private bool weeklyProcess=false;
		private string weekdays=String.Empty;
		private bool israndom=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Sno value.
		/// </summary>
		public int Sno
		{
			get { return sno; }
			set { sno = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Investigationid value.
		/// </summary>
		public long Investigationid
		{
			get { return investigationid; }
			set { investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the TestType value.
		/// </summary>
		public string TestType
		{
			get { return testType; }
			set { testType = value; }
		}

		/// <summary>
		/// Gets or sets the TAT value.
		/// </summary>
		public int TAT
		{
			get { return tAT; }
			set { tAT = value; }
		}

		/// <summary>
		/// Gets or sets the Recurrenceid value.
		/// </summary>
		public int Recurrenceid
		{
			get { return recurrenceid; }
			set { recurrenceid = value; }
		}

		/// <summary>
		/// Gets or sets the RecurrenceCycleid value.
		/// </summary>
		public int RecurrenceCycleid
		{
			get { return recurrenceCycleid; }
			set { recurrenceCycleid = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduleTemplateID value.
		/// </summary>
		public int ScheduleTemplateID
		{
			get { return scheduleTemplateID; }
			set { scheduleTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the ResouceTemplateid value.
		/// </summary>
		public long ResouceTemplateid
		{
			get { return resouceTemplateid; }
			set { resouceTemplateid = value; }
		}

		/// <summary>
		/// Gets or sets the Start value.
		/// </summary>
		public decimal Start
		{
			get { return start; }
			set { start = value; }
		}

		/// <summary>
		/// Gets or sets the Labend value.
		/// </summary>
		public decimal Labend
		{
			get { return labend; }
			set { labend = value; }
		}

		/// <summary>
		/// Gets or sets the Reporttime value.
		/// </summary>
		public decimal Reporttime
		{
			get { return reporttime; }
			set { reporttime = value; }
		}

		/// <summary>
		/// Gets or sets the WeeklyProcess value.
		/// </summary>
		public bool WeeklyProcess
		{
			get { return weeklyProcess; }
			set { weeklyProcess = value; }
		}

		/// <summary>
		/// Gets or sets the Weekdays value.
		/// </summary>
		public string Weekdays
		{
			get { return weekdays; }
			set { weekdays = value; }
		}

		/// <summary>
		/// Gets or sets the Israndom value.
		/// </summary>
		public bool Israndom
		{
			get { return israndom; }
			set { israndom = value; }
		}


		#endregion
}
}
