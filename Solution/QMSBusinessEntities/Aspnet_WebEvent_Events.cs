using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Aspnet_WebEvent_Events
	{
		#region Fields

		private string eventId=String.Empty;
		private DateTime eventTimeUtc=DateTime.MaxValue;
		private DateTime eventTime=DateTime.MaxValue;
		private string eventType=String.Empty;
		private decimal eventSequence=Decimal.Zero;
		private decimal eventOccurrence=Decimal.Zero;
		private int eventCode=0;
		private int eventDetailCode=0;
		private string message=String.Empty;
		private string applicationPath=String.Empty;
		private string applicationVirtualPath=String.Empty;
		private string machineName=String.Empty;
		private string requestUrl=String.Empty;
		private string exceptionType=String.Empty;
		private string details=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EventId value.
		/// </summary>
		public string EventId
		{
			get { return eventId; }
			set { eventId = value; }
		}

		/// <summary>
		/// Gets or sets the EventTimeUtc value.
		/// </summary>
		public DateTime EventTimeUtc
		{
			get { return eventTimeUtc; }
			set { eventTimeUtc = value; }
		}

		/// <summary>
		/// Gets or sets the EventTime value.
		/// </summary>
		public DateTime EventTime
		{
			get { return eventTime; }
			set { eventTime = value; }
		}

		/// <summary>
		/// Gets or sets the EventType value.
		/// </summary>
		public string EventType
		{
			get { return eventType; }
			set { eventType = value; }
		}

		/// <summary>
		/// Gets or sets the EventSequence value.
		/// </summary>
		public decimal EventSequence
		{
			get { return eventSequence; }
			set { eventSequence = value; }
		}

		/// <summary>
		/// Gets or sets the EventOccurrence value.
		/// </summary>
		public decimal EventOccurrence
		{
			get { return eventOccurrence; }
			set { eventOccurrence = value; }
		}

		/// <summary>
		/// Gets or sets the EventCode value.
		/// </summary>
		public int EventCode
		{
			get { return eventCode; }
			set { eventCode = value; }
		}

		/// <summary>
		/// Gets or sets the EventDetailCode value.
		/// </summary>
		public int EventDetailCode
		{
			get { return eventDetailCode; }
			set { eventDetailCode = value; }
		}

		/// <summary>
		/// Gets or sets the Message value.
		/// </summary>
		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		/// <summary>
		/// Gets or sets the ApplicationPath value.
		/// </summary>
		public string ApplicationPath
		{
			get { return applicationPath; }
			set { applicationPath = value; }
		}

		/// <summary>
		/// Gets or sets the ApplicationVirtualPath value.
		/// </summary>
		public string ApplicationVirtualPath
		{
			get { return applicationVirtualPath; }
			set { applicationVirtualPath = value; }
		}

		/// <summary>
		/// Gets or sets the MachineName value.
		/// </summary>
		public string MachineName
		{
			get { return machineName; }
			set { machineName = value; }
		}

		/// <summary>
		/// Gets or sets the RequestUrl value.
		/// </summary>
		public string RequestUrl
		{
			get { return requestUrl; }
			set { requestUrl = value; }
		}

		/// <summary>
		/// Gets or sets the ExceptionType value.
		/// </summary>
		public string ExceptionType
		{
			get { return exceptionType; }
			set { exceptionType = value; }
		}

		/// <summary>
		/// Gets or sets the Details value.
		/// </summary>
		public string Details
		{
			get { return details; }
			set { details = value; }
		}


		#endregion
}
}
