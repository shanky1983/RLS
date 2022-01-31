using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessageORCDetails
	{
		#region Fields

		private long hLMessageORCDetailsID=0;
		private string oRCEvent_Type=String.Empty;
		private string order_Control=String.Empty;
		private string place_Order_Number=String.Empty;
		private string oRCPlEntity_Identifier=String.Empty;
		private string oRCFiller_Order_Number=String.Empty;
		private string oRCFEntity_Identifier=String.Empty;
		private string placer_Group_Number=String.Empty;
		private string oRCPrEntity_Identifier=String.Empty;
		private string order_Status=String.Empty;
		private string response_Flag=String.Empty;
		private string oRCQuantity_Timing=String.Empty;
		private string quantity=String.Empty;
		private string interval=String.Empty;
		private string duration=String.Empty;
		private DateTime start_Date_Time=DateTime.MaxValue;
		private DateTime end_Date_Time=DateTime.MaxValue;
		private string oRCPriority=String.Empty;
		private string parent_Order=String.Empty;
		private string placer_Assigned_Identifier=String.Empty;
		private DateTime date_Time_Of_Transaction=DateTime.MaxValue;
		private string entered_By=String.Empty;
		private string enterPerson_Identifier=String.Empty;
		private string enterFamily_Name=String.Empty;
		private string enterGiven_Name=String.Empty;
		private string enterSecond_and_Further_Given_Names_or_Initials_Thereof=String.Empty;
		private string verified_By=String.Empty;
		private string oRCOrdering_Provider=String.Empty;
		private string orderingPerson_Identifier=String.Empty;
		private string orderingFamily_Name=String.Empty;
		private string orderingGiven_Name=String.Empty;
		private string orderingSecond_and_Further_Given_Names_or_Initials_Thereof=String.Empty;
		private string oRCSuffix=String.Empty;
		private string oRCPrefix=String.Empty;
		private string oRCDegree=String.Empty;
		private string enterer_Location=String.Empty;
		private string point_of_Care=String.Empty;
		private string room=String.Empty;
		private string bed=String.Empty;
		private string facility=String.Empty;
		private string call_Back_Phone_Number=String.Empty;
		private string oRCTelephone_number=String.Empty;
		private DateTime order_Effective_Date_Time=DateTime.MaxValue;
		private string order_Control_Code_Reason=String.Empty;
		private string entering_Organization=String.Empty;
		private string entering_Device=String.Empty;
		private string action_By=String.Empty;
		private string advanced_Beneficiary_Notice_Code=String.Empty;
		private string ordering_Facility_Name=String.Empty;
		private string ordering_Facility_Address=String.Empty;
		private string ordering_Facility_Phone_Number=String.Empty;
		private string ordering_Provider_Address=String.Empty;
		private string order_Status_Modifier=String.Empty;
		private string advanced_Beneficiary_Notice_Override_Reason=String.Empty;
		private DateTime filler_Expected_Availability_Date_time=DateTime.MaxValue;
		private string confidentially_Code=String.Empty;
		private string order_Type=String.Empty;
		private string enterer_Authorization_Mode=String.Empty;
		private string oRCParent_Universal_Service_Identifier=String.Empty;
		private long hLMessageID=0;
		private long orgID=0;
		private long locationID=0;
		private string hLMessageORCContent=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessageORCDetailsID value.
		/// </summary>
		public long HLMessageORCDetailsID
		{
			get { return hLMessageORCDetailsID; }
			set { hLMessageORCDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ORCEvent_Type value.
		/// </summary>
		public string ORCEvent_Type
		{
			get { return oRCEvent_Type; }
			set { oRCEvent_Type = value; }
		}

		/// <summary>
		/// Gets or sets the Order_Control value.
		/// </summary>
		public string Order_Control
		{
			get { return order_Control; }
			set { order_Control = value; }
		}

		/// <summary>
		/// Gets or sets the Place_Order_Number value.
		/// </summary>
		public string Place_Order_Number
		{
			get { return place_Order_Number; }
			set { place_Order_Number = value; }
		}

		/// <summary>
		/// Gets or sets the ORCPlEntity_Identifier value.
		/// </summary>
		public string ORCPlEntity_Identifier
		{
			get { return oRCPlEntity_Identifier; }
			set { oRCPlEntity_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the ORCFiller_Order_Number value.
		/// </summary>
		public string ORCFiller_Order_Number
		{
			get { return oRCFiller_Order_Number; }
			set { oRCFiller_Order_Number = value; }
		}

		/// <summary>
		/// Gets or sets the ORCFEntity_Identifier value.
		/// </summary>
		public string ORCFEntity_Identifier
		{
			get { return oRCFEntity_Identifier; }
			set { oRCFEntity_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Group_Number value.
		/// </summary>
		public string Placer_Group_Number
		{
			get { return placer_Group_Number; }
			set { placer_Group_Number = value; }
		}

		/// <summary>
		/// Gets or sets the ORCPrEntity_Identifier value.
		/// </summary>
		public string ORCPrEntity_Identifier
		{
			get { return oRCPrEntity_Identifier; }
			set { oRCPrEntity_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the Order_Status value.
		/// </summary>
		public string Order_Status
		{
			get { return order_Status; }
			set { order_Status = value; }
		}

		/// <summary>
		/// Gets or sets the Response_Flag value.
		/// </summary>
		public string Response_Flag
		{
			get { return response_Flag; }
			set { response_Flag = value; }
		}

		/// <summary>
		/// Gets or sets the ORCQuantity_Timing value.
		/// </summary>
		public string ORCQuantity_Timing
		{
			get { return oRCQuantity_Timing; }
			set { oRCQuantity_Timing = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public string Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the Interval value.
		/// </summary>
		public string Interval
		{
			get { return interval; }
			set { interval = value; }
		}

		/// <summary>
		/// Gets or sets the Duration value.
		/// </summary>
		public string Duration
		{
			get { return duration; }
			set { duration = value; }
		}

		/// <summary>
		/// Gets or sets the Start_Date_Time value.
		/// </summary>
		public DateTime Start_Date_Time
		{
			get { return start_Date_Time; }
			set { start_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the End_Date_Time value.
		/// </summary>
		public DateTime End_Date_Time
		{
			get { return end_Date_Time; }
			set { end_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the ORCPriority value.
		/// </summary>
		public string ORCPriority
		{
			get { return oRCPriority; }
			set { oRCPriority = value; }
		}

		/// <summary>
		/// Gets or sets the Parent_Order value.
		/// </summary>
		public string Parent_Order
		{
			get { return parent_Order; }
			set { parent_Order = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Assigned_Identifier value.
		/// </summary>
		public string Placer_Assigned_Identifier
		{
			get { return placer_Assigned_Identifier; }
			set { placer_Assigned_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the Date_Time_Of_Transaction value.
		/// </summary>
		public DateTime Date_Time_Of_Transaction
		{
			get { return date_Time_Of_Transaction; }
			set { date_Time_Of_Transaction = value; }
		}

		/// <summary>
		/// Gets or sets the Entered_By value.
		/// </summary>
		public string Entered_By
		{
			get { return entered_By; }
			set { entered_By = value; }
		}

		/// <summary>
		/// Gets or sets the EnterPerson_Identifier value.
		/// </summary>
		public string EnterPerson_Identifier
		{
			get { return enterPerson_Identifier; }
			set { enterPerson_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the EnterFamily_Name value.
		/// </summary>
		public string EnterFamily_Name
		{
			get { return enterFamily_Name; }
			set { enterFamily_Name = value; }
		}

		/// <summary>
		/// Gets or sets the EnterGiven_Name value.
		/// </summary>
		public string EnterGiven_Name
		{
			get { return enterGiven_Name; }
			set { enterGiven_Name = value; }
		}

		/// <summary>
		/// Gets or sets the EnterSecond_and_Further_Given_Names_or_Initials_Thereof value.
		/// </summary>
		public string EnterSecond_and_Further_Given_Names_or_Initials_Thereof
		{
			get { return enterSecond_and_Further_Given_Names_or_Initials_Thereof; }
			set { enterSecond_and_Further_Given_Names_or_Initials_Thereof = value; }
		}

		/// <summary>
		/// Gets or sets the Verified_By value.
		/// </summary>
		public string Verified_By
		{
			get { return verified_By; }
			set { verified_By = value; }
		}

		/// <summary>
		/// Gets or sets the ORCOrdering_Provider value.
		/// </summary>
		public string ORCOrdering_Provider
		{
			get { return oRCOrdering_Provider; }
			set { oRCOrdering_Provider = value; }
		}

		/// <summary>
		/// Gets or sets the OrderingPerson_Identifier value.
		/// </summary>
		public string OrderingPerson_Identifier
		{
			get { return orderingPerson_Identifier; }
			set { orderingPerson_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the OrderingFamily_Name value.
		/// </summary>
		public string OrderingFamily_Name
		{
			get { return orderingFamily_Name; }
			set { orderingFamily_Name = value; }
		}

		/// <summary>
		/// Gets or sets the OrderingGiven_Name value.
		/// </summary>
		public string OrderingGiven_Name
		{
			get { return orderingGiven_Name; }
			set { orderingGiven_Name = value; }
		}

		/// <summary>
		/// Gets or sets the OrderingSecond_and_Further_Given_Names_or_Initials_Thereof value.
		/// </summary>
		public string OrderingSecond_and_Further_Given_Names_or_Initials_Thereof
		{
			get { return orderingSecond_and_Further_Given_Names_or_Initials_Thereof; }
			set { orderingSecond_and_Further_Given_Names_or_Initials_Thereof = value; }
		}

		/// <summary>
		/// Gets or sets the ORCSuffix value.
		/// </summary>
		public string ORCSuffix
		{
			get { return oRCSuffix; }
			set { oRCSuffix = value; }
		}

		/// <summary>
		/// Gets or sets the ORCPrefix value.
		/// </summary>
		public string ORCPrefix
		{
			get { return oRCPrefix; }
			set { oRCPrefix = value; }
		}

		/// <summary>
		/// Gets or sets the ORCDegree value.
		/// </summary>
		public string ORCDegree
		{
			get { return oRCDegree; }
			set { oRCDegree = value; }
		}

		/// <summary>
		/// Gets or sets the Enterer_Location value.
		/// </summary>
		public string Enterer_Location
		{
			get { return enterer_Location; }
			set { enterer_Location = value; }
		}

		/// <summary>
		/// Gets or sets the Point_of_Care value.
		/// </summary>
		public string Point_of_Care
		{
			get { return point_of_Care; }
			set { point_of_Care = value; }
		}

		/// <summary>
		/// Gets or sets the Room value.
		/// </summary>
		public string Room
		{
			get { return room; }
			set { room = value; }
		}

		/// <summary>
		/// Gets or sets the Bed value.
		/// </summary>
		public string Bed
		{
			get { return bed; }
			set { bed = value; }
		}

		/// <summary>
		/// Gets or sets the Facility value.
		/// </summary>
		public string Facility
		{
			get { return facility; }
			set { facility = value; }
		}

		/// <summary>
		/// Gets or sets the Call_Back_Phone_Number value.
		/// </summary>
		public string Call_Back_Phone_Number
		{
			get { return call_Back_Phone_Number; }
			set { call_Back_Phone_Number = value; }
		}

		/// <summary>
		/// Gets or sets the ORCTelephone_number value.
		/// </summary>
		public string ORCTelephone_number
		{
			get { return oRCTelephone_number; }
			set { oRCTelephone_number = value; }
		}

		/// <summary>
		/// Gets or sets the Order_Effective_Date_Time value.
		/// </summary>
		public DateTime Order_Effective_Date_Time
		{
			get { return order_Effective_Date_Time; }
			set { order_Effective_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Order_Control_Code_Reason value.
		/// </summary>
		public string Order_Control_Code_Reason
		{
			get { return order_Control_Code_Reason; }
			set { order_Control_Code_Reason = value; }
		}

		/// <summary>
		/// Gets or sets the Entering_Organization value.
		/// </summary>
		public string Entering_Organization
		{
			get { return entering_Organization; }
			set { entering_Organization = value; }
		}

		/// <summary>
		/// Gets or sets the Entering_Device value.
		/// </summary>
		public string Entering_Device
		{
			get { return entering_Device; }
			set { entering_Device = value; }
		}

		/// <summary>
		/// Gets or sets the Action_By value.
		/// </summary>
		public string Action_By
		{
			get { return action_By; }
			set { action_By = value; }
		}

		/// <summary>
		/// Gets or sets the Advanced_Beneficiary_Notice_Code value.
		/// </summary>
		public string Advanced_Beneficiary_Notice_Code
		{
			get { return advanced_Beneficiary_Notice_Code; }
			set { advanced_Beneficiary_Notice_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Ordering_Facility_Name value.
		/// </summary>
		public string Ordering_Facility_Name
		{
			get { return ordering_Facility_Name; }
			set { ordering_Facility_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Ordering_Facility_Address value.
		/// </summary>
		public string Ordering_Facility_Address
		{
			get { return ordering_Facility_Address; }
			set { ordering_Facility_Address = value; }
		}

		/// <summary>
		/// Gets or sets the Ordering_Facility_Phone_Number value.
		/// </summary>
		public string Ordering_Facility_Phone_Number
		{
			get { return ordering_Facility_Phone_Number; }
			set { ordering_Facility_Phone_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Ordering_Provider_Address value.
		/// </summary>
		public string Ordering_Provider_Address
		{
			get { return ordering_Provider_Address; }
			set { ordering_Provider_Address = value; }
		}

		/// <summary>
		/// Gets or sets the Order_Status_Modifier value.
		/// </summary>
		public string Order_Status_Modifier
		{
			get { return order_Status_Modifier; }
			set { order_Status_Modifier = value; }
		}

		/// <summary>
		/// Gets or sets the Advanced_Beneficiary_Notice_Override_Reason value.
		/// </summary>
		public string Advanced_Beneficiary_Notice_Override_Reason
		{
			get { return advanced_Beneficiary_Notice_Override_Reason; }
			set { advanced_Beneficiary_Notice_Override_Reason = value; }
		}

		/// <summary>
		/// Gets or sets the Filler_Expected_Availability_Date_time value.
		/// </summary>
		public DateTime Filler_Expected_Availability_Date_time
		{
			get { return filler_Expected_Availability_Date_time; }
			set { filler_Expected_Availability_Date_time = value; }
		}

		/// <summary>
		/// Gets or sets the Confidentially_Code value.
		/// </summary>
		public string Confidentially_Code
		{
			get { return confidentially_Code; }
			set { confidentially_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Order_Type value.
		/// </summary>
		public string Order_Type
		{
			get { return order_Type; }
			set { order_Type = value; }
		}

		/// <summary>
		/// Gets or sets the Enterer_Authorization_Mode value.
		/// </summary>
		public string Enterer_Authorization_Mode
		{
			get { return enterer_Authorization_Mode; }
			set { enterer_Authorization_Mode = value; }
		}

		/// <summary>
		/// Gets or sets the ORCParent_Universal_Service_Identifier value.
		/// </summary>
		public string ORCParent_Universal_Service_Identifier
		{
			get { return oRCParent_Universal_Service_Identifier; }
			set { oRCParent_Universal_Service_Identifier = value; }
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
		/// Gets or sets the HLMessageORCContent value.
		/// </summary>
		public string HLMessageORCContent
		{
			get { return hLMessageORCContent; }
			set { hLMessageORCContent = value; }
		}


		#endregion
}
}
