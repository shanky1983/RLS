using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessageHeaderDetails
	{
		#region Fields

		private long hLMessageHeaderDetailsID=0;
		private string mHEvent_Type=String.Empty;
		private string encoding_Characters=String.Empty;
		private string sending_Application=String.Empty;
		private string sending_Facility=String.Empty;
		private string sFNamespace_ID=String.Empty;
		private string sFUniversal_ID=String.Empty;
		private DateTime message_Date_Time=DateTime.MaxValue;
		private string messageSecurity=String.Empty;
		private string receiving_Application=String.Empty;
		private string receiving_Facility=String.Empty;
		private string sequence_number=String.Empty;
		private string message_control_id=String.Empty;
		private string message_Type=String.Empty;
		private string message_Code=String.Empty;
		private string trigger_Event=String.Empty;
		private string message_Structure=String.Empty;
		private string continuation_pointer=String.Empty;
		private string processing_ID=String.Empty;
		private string version_ID=String.Empty;
		private string application_Acknowledgment_type=String.Empty;
		private string mHCountry_Code=String.Empty;
		private string character_Set=String.Empty;
		private string principal_Language_Of_Message=String.Empty;
		private string mHIdentifier=String.Empty;
		private string alternate_Character_Set_Handling_Scheme=String.Empty;
		private string message_Profile_Identifier=String.Empty;
		private string entity_Identifier=String.Empty;
		private string sending_Responsible_Organization=String.Empty;
		private string sROrganization_Name=String.Empty;
		private string receiving_Responsible_Organization=String.Empty;
		private string rROrganization_Name=String.Empty;
		private string sending_Network_Address=String.Empty;
		private string sNNamespace_ID=String.Empty;
		private string receiving_Network_Address=String.Empty;
		private string rNNamespace_ID=String.Empty;
		private long hLMessageID=0;
		private long orgID=0;
		private long locationID=0;
		private long parentID=0;
		private string hLMessageHeaderContent=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessageHeaderDetailsID value.
		/// </summary>
		public long HLMessageHeaderDetailsID
		{
			get { return hLMessageHeaderDetailsID; }
			set { hLMessageHeaderDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the MHEvent_Type value.
		/// </summary>
		public string MHEvent_Type
		{
			get { return mHEvent_Type; }
			set { mHEvent_Type = value; }
		}

		/// <summary>
		/// Gets or sets the Encoding_Characters value.
		/// </summary>
		public string Encoding_Characters
		{
			get { return encoding_Characters; }
			set { encoding_Characters = value; }
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
		/// Gets or sets the SFNamespace_ID value.
		/// </summary>
		public string SFNamespace_ID
		{
			get { return sFNamespace_ID; }
			set { sFNamespace_ID = value; }
		}

		/// <summary>
		/// Gets or sets the SFUniversal_ID value.
		/// </summary>
		public string SFUniversal_ID
		{
			get { return sFUniversal_ID; }
			set { sFUniversal_ID = value; }
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
		/// Gets or sets the MessageSecurity value.
		/// </summary>
		public string MessageSecurity
		{
			get { return messageSecurity; }
			set { messageSecurity = value; }
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
		/// Gets or sets the Sequence_number value.
		/// </summary>
		public string Sequence_number
		{
			get { return sequence_number; }
			set { sequence_number = value; }
		}

		/// <summary>
		/// Gets or sets the Message_control_id value.
		/// </summary>
		public string Message_control_id
		{
			get { return message_control_id; }
			set { message_control_id = value; }
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
		/// Gets or sets the Message_Code value.
		/// </summary>
		public string Message_Code
		{
			get { return message_Code; }
			set { message_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Trigger_Event value.
		/// </summary>
		public string Trigger_Event
		{
			get { return trigger_Event; }
			set { trigger_Event = value; }
		}

		/// <summary>
		/// Gets or sets the Message_Structure value.
		/// </summary>
		public string Message_Structure
		{
			get { return message_Structure; }
			set { message_Structure = value; }
		}

		/// <summary>
		/// Gets or sets the Continuation_pointer value.
		/// </summary>
		public string Continuation_pointer
		{
			get { return continuation_pointer; }
			set { continuation_pointer = value; }
		}

		/// <summary>
		/// Gets or sets the Processing_ID value.
		/// </summary>
		public string Processing_ID
		{
			get { return processing_ID; }
			set { processing_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Version_ID value.
		/// </summary>
		public string Version_ID
		{
			get { return version_ID; }
			set { version_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Application_Acknowledgment_type value.
		/// </summary>
		public string Application_Acknowledgment_type
		{
			get { return application_Acknowledgment_type; }
			set { application_Acknowledgment_type = value; }
		}

		/// <summary>
		/// Gets or sets the MHCountry_Code value.
		/// </summary>
		public string MHCountry_Code
		{
			get { return mHCountry_Code; }
			set { mHCountry_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Character_Set value.
		/// </summary>
		public string Character_Set
		{
			get { return character_Set; }
			set { character_Set = value; }
		}

		/// <summary>
		/// Gets or sets the Principal_Language_Of_Message value.
		/// </summary>
		public string Principal_Language_Of_Message
		{
			get { return principal_Language_Of_Message; }
			set { principal_Language_Of_Message = value; }
		}

		/// <summary>
		/// Gets or sets the MHIdentifier value.
		/// </summary>
		public string MHIdentifier
		{
			get { return mHIdentifier; }
			set { mHIdentifier = value; }
		}

		/// <summary>
		/// Gets or sets the Alternate_Character_Set_Handling_Scheme value.
		/// </summary>
		public string Alternate_Character_Set_Handling_Scheme
		{
			get { return alternate_Character_Set_Handling_Scheme; }
			set { alternate_Character_Set_Handling_Scheme = value; }
		}

		/// <summary>
		/// Gets or sets the Message_Profile_Identifier value.
		/// </summary>
		public string Message_Profile_Identifier
		{
			get { return message_Profile_Identifier; }
			set { message_Profile_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the Entity_Identifier value.
		/// </summary>
		public string Entity_Identifier
		{
			get { return entity_Identifier; }
			set { entity_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the Sending_Responsible_Organization value.
		/// </summary>
		public string Sending_Responsible_Organization
		{
			get { return sending_Responsible_Organization; }
			set { sending_Responsible_Organization = value; }
		}

		/// <summary>
		/// Gets or sets the SROrganization_Name value.
		/// </summary>
		public string SROrganization_Name
		{
			get { return sROrganization_Name; }
			set { sROrganization_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Receiving_Responsible_Organization value.
		/// </summary>
		public string Receiving_Responsible_Organization
		{
			get { return receiving_Responsible_Organization; }
			set { receiving_Responsible_Organization = value; }
		}

		/// <summary>
		/// Gets or sets the RROrganization_Name value.
		/// </summary>
		public string RROrganization_Name
		{
			get { return rROrganization_Name; }
			set { rROrganization_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Sending_Network_Address value.
		/// </summary>
		public string Sending_Network_Address
		{
			get { return sending_Network_Address; }
			set { sending_Network_Address = value; }
		}

		/// <summary>
		/// Gets or sets the SNNamespace_ID value.
		/// </summary>
		public string SNNamespace_ID
		{
			get { return sNNamespace_ID; }
			set { sNNamespace_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Receiving_Network_Address value.
		/// </summary>
		public string Receiving_Network_Address
		{
			get { return receiving_Network_Address; }
			set { receiving_Network_Address = value; }
		}

		/// <summary>
		/// Gets or sets the RNNamespace_ID value.
		/// </summary>
		public string RNNamespace_ID
		{
			get { return rNNamespace_ID; }
			set { rNNamespace_ID = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageID value.
		/// </summary>
		public long HLMessageID
		{
			get { return hLMessageID; }
			set { hLMessageID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageHeaderContent value.
		/// </summary>
		public string HLMessageHeaderContent
		{
			get { return hLMessageHeaderContent; }
			set { hLMessageHeaderContent = value; }
		}


		#endregion
}
}
