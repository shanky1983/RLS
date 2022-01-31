using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HL7Master
	{
		#region Fields

		private long iD=0;
		private string sending_Application=String.Empty;
		private string sending_Facility=String.Empty;
		private string receiving_Application=String.Empty;
		private string receiving_Facility=String.Empty;
		private DateTime message_Date_Time=DateTime.MaxValue;
		private string message_Type=String.Empty;
		private long message_Control_Id=0;
		private long orgID=0;

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
		/// Gets or sets the Sending_Application value.
		/// </summary>
		public string Sending_Application
		{
			get { return sending_Application; }
			set { sending_Application = value; }
		}

		/// <summary>
		/// Gets or sets the Sending_Facility value.
		/// </summary>
		public string Sending_Facility
		{
			get { return sending_Facility; }
			set { sending_Facility = value; }
		}

		/// <summary>
		/// Gets or sets the Receiving_Application value.
		/// </summary>
		public string Receiving_Application
		{
			get { return receiving_Application; }
			set { receiving_Application = value; }
		}

		/// <summary>
		/// Gets or sets the Receiving_Facility value.
		/// </summary>
		public string Receiving_Facility
		{
			get { return receiving_Facility; }
			set { receiving_Facility = value; }
		}

		/// <summary>
		/// Gets or sets the Message_Date_Time value.
		/// </summary>
		public DateTime Message_Date_Time
		{
			get { return message_Date_Time; }
			set { message_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Message_Type value.
		/// </summary>
		public string Message_Type
		{
			get { return message_Type; }
			set { message_Type = value; }
		}

		/// <summary>
		/// Gets or sets the Message_Control_Id value.
		/// </summary>
		public long Message_Control_Id
		{
			get { return message_Control_Id; }
			set { message_Control_Id = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
