using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessageOBRDetails
	{
		#region Fields

		private long hLMessageOBRDetailsID=0;
		private string oBREvent_Type=String.Empty;
		private string set_ID_OBR=String.Empty;
		private string placer_Order_Number=String.Empty;
		private string oBRFiller_Order_Number=String.Empty;
		private string universal_Service_Identifier=String.Empty;
		private string oBRIdentifier=String.Empty;
		private string oBRText=String.Empty;
		private string name_Of_Coding_System=String.Empty;
		private string oBRPriority=String.Empty;
		private DateTime requested_Date_Time=DateTime.MaxValue;
		private DateTime observation_Date_Time=DateTime.MaxValue;
		private DateTime observation_End_Date_Time=DateTime.MaxValue;
		private string collection_Volume=String.Empty;
		private string collector_Identifier=String.Empty;
		private string spicemen_Action_Code=String.Empty;
		private string danger_Code=String.Empty;
		private string relevant_Clinical_Information=String.Empty;
		private DateTime specimen_Received_Date_Time=DateTime.MaxValue;
		private string specimen_Source=String.Empty;
		private string oBROrdering_Provider=String.Empty;
		private string person_Identifier=String.Empty;
		private string oBRFamily_Name=String.Empty;
		private string given_Name=String.Empty;
		private string second_and_Further_Given_Names_or_Initials_There_of=String.Empty;
		private string oBRSuffix=String.Empty;
		private string oBRPrefix=String.Empty;
		private string oBRDegree=String.Empty;
		private string order_Callback_Phone_Number=String.Empty;
		private string placer_Field1=String.Empty;
		private string placer_Field2=String.Empty;
		private string filler_Field1=String.Empty;
		private string filler_Field2=String.Empty;
		private DateTime results_Rpt_Status_Chng_DateTime=DateTime.MaxValue;
		private string change_to_Practice=String.Empty;
		private decimal tasks_Line_Discount=Decimal.Zero;
		private decimal tasks_Line_Amount=Decimal.Zero;
		private decimal tasks_Sales_Price=Decimal.Zero;
		private string tasks_Sales_ID=String.Empty;
		private string diagnostic_Serv_Sect_ID=String.Empty;
		private string result_Status=String.Empty;
		private string parent_Status=String.Empty;
		private string oBRQuantity_Timing=String.Empty;
		private DateTime login_Create_DateTime=DateTime.MaxValue;
		private string login_Priority=String.Empty;
		private string result_Copies_To=String.Empty;
		private string parent_Result_Observation_Identifier=String.Empty;
		private string transporation_Mode=String.Empty;
		private string reason_For_Study=String.Empty;
		private string principal_Result_Interpreter=String.Empty;
		private string assistant_Result_Interpreter=String.Empty;
		private string technician=String.Empty;
		private string transcriptionist=String.Empty;
		private DateTime scheduled_Date_Time=DateTime.MaxValue;
		private string number_Of_Sample_Containers=String.Empty;
		private string transport_Logistics_Of_Collected_Samlpe=String.Empty;
		private string collectors_Comment=String.Empty;
		private string transport_Arrangement_Responsibility=String.Empty;
		private string transport_Arranged=String.Empty;
		private string escort_Required=String.Empty;
		private string planned_Patient_Transport_Comment=String.Empty;
		private string procedure_Code=String.Empty;
		private string procedure_Code_Modifier=String.Empty;
		private string placer_Supplemental_Service_Information=String.Empty;
		private string filler_Supplemental_Service_Information=String.Empty;
		private string medically_Necessary_Duplicate_Procedure_Reason=String.Empty;
		private string result_Handling=String.Empty;
		private string parent_Universal_Service_Identifier=String.Empty;
		private long hLMessageID=0;
		private long orgID=0;
		private long locationID=0;
		private int oBRQuantity_TimingQuantity=0;
		private int oBRQuantity_TimingInterval=0;
		private int oBRQuantity_TimingDuration=0;
		private DateTime oBRQuantity_TimingStartDate=DateTime.MaxValue;
		private DateTime oBRQuantity_TimingEndDate=DateTime.MaxValue;
		private string oBRQuantity_TimingPriority=String.Empty;
		private string locationSource=String.Empty;
		private string hLMessageOBRContent=String.Empty;
		private bool otherFileStatus=false;
		private string folderName=String.Empty;
		private string prePlacer_Field1=String.Empty;
		private bool cancelStatus=false;
		private string currentPlacer_Field1=String.Empty;
		private string previousSet_ID_OBR=String.Empty;
		private long current_HLMessageID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessageOBRDetailsID value.
		/// </summary>
		public long HLMessageOBRDetailsID
		{
			get { return hLMessageOBRDetailsID; }
			set { hLMessageOBRDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the OBREvent_Type value.
		/// </summary>
		public string OBREvent_Type
		{
			get { return oBREvent_Type; }
			set { oBREvent_Type = value; }
		}

		/// <summary>
		/// Gets or sets the Set_ID_OBR value.
		/// </summary>
		public string Set_ID_OBR
		{
			get { return set_ID_OBR; }
			set { set_ID_OBR = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Order_Number value.
		/// </summary>
		public string Placer_Order_Number
		{
			get { return placer_Order_Number; }
			set { placer_Order_Number = value; }
		}

		/// <summary>
		/// Gets or sets the OBRFiller_Order_Number value.
		/// </summary>
		public string OBRFiller_Order_Number
		{
			get { return oBRFiller_Order_Number; }
			set { oBRFiller_Order_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Universal_Service_Identifier value.
		/// </summary>
		public string Universal_Service_Identifier
		{
			get { return universal_Service_Identifier; }
			set { universal_Service_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the OBRIdentifier value.
		/// </summary>
		public string OBRIdentifier
		{
			get { return oBRIdentifier; }
			set { oBRIdentifier = value; }
		}

		/// <summary>
		/// Gets or sets the OBRText value.
		/// </summary>
		public string OBRText
		{
			get { return oBRText; }
			set { oBRText = value; }
		}

		/// <summary>
		/// Gets or sets the Name_Of_Coding_System value.
		/// </summary>
		public string Name_Of_Coding_System
		{
			get { return name_Of_Coding_System; }
			set { name_Of_Coding_System = value; }
		}

		/// <summary>
		/// Gets or sets the OBRPriority value.
		/// </summary>
		public string OBRPriority
		{
			get { return oBRPriority; }
			set { oBRPriority = value; }
		}

		/// <summary>
		/// Gets or sets the Requested_Date_Time value.
		/// </summary>
		public DateTime Requested_Date_Time
		{
			get { return requested_Date_Time; }
			set { requested_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Observation_Date_Time value.
		/// </summary>
		public DateTime Observation_Date_Time
		{
			get { return observation_Date_Time; }
			set { observation_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Observation_End_Date_Time value.
		/// </summary>
		public DateTime Observation_End_Date_Time
		{
			get { return observation_End_Date_Time; }
			set { observation_End_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Collection_Volume value.
		/// </summary>
		public string Collection_Volume
		{
			get { return collection_Volume; }
			set { collection_Volume = value; }
		}

		/// <summary>
		/// Gets or sets the Collector_Identifier value.
		/// </summary>
		public string Collector_Identifier
		{
			get { return collector_Identifier; }
			set { collector_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the Spicemen_Action_Code value.
		/// </summary>
		public string Spicemen_Action_Code
		{
			get { return spicemen_Action_Code; }
			set { spicemen_Action_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Danger_Code value.
		/// </summary>
		public string Danger_Code
		{
			get { return danger_Code; }
			set { danger_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Relevant_Clinical_Information value.
		/// </summary>
		public string Relevant_Clinical_Information
		{
			get { return relevant_Clinical_Information; }
			set { relevant_Clinical_Information = value; }
		}

		/// <summary>
		/// Gets or sets the Specimen_Received_Date_Time value.
		/// </summary>
		public DateTime Specimen_Received_Date_Time
		{
			get { return specimen_Received_Date_Time; }
			set { specimen_Received_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Specimen_Source value.
		/// </summary>
		public string Specimen_Source
		{
			get { return specimen_Source; }
			set { specimen_Source = value; }
		}

		/// <summary>
		/// Gets or sets the OBROrdering_Provider value.
		/// </summary>
		public string OBROrdering_Provider
		{
			get { return oBROrdering_Provider; }
			set { oBROrdering_Provider = value; }
		}

		/// <summary>
		/// Gets or sets the Person_Identifier value.
		/// </summary>
		public string Person_Identifier
		{
			get { return person_Identifier; }
			set { person_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the OBRFamily_Name value.
		/// </summary>
		public string OBRFamily_Name
		{
			get { return oBRFamily_Name; }
			set { oBRFamily_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Given_Name value.
		/// </summary>
		public string Given_Name
		{
			get { return given_Name; }
			set { given_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Second_and_Further_Given_Names_or_Initials_There_of value.
		/// </summary>
		public string Second_and_Further_Given_Names_or_Initials_There_of
		{
			get { return second_and_Further_Given_Names_or_Initials_There_of; }
			set { second_and_Further_Given_Names_or_Initials_There_of = value; }
		}

		/// <summary>
		/// Gets or sets the OBRSuffix value.
		/// </summary>
		public string OBRSuffix
		{
			get { return oBRSuffix; }
			set { oBRSuffix = value; }
		}

		/// <summary>
		/// Gets or sets the OBRPrefix value.
		/// </summary>
		public string OBRPrefix
		{
			get { return oBRPrefix; }
			set { oBRPrefix = value; }
		}

		/// <summary>
		/// Gets or sets the OBRDegree value.
		/// </summary>
		public string OBRDegree
		{
			get { return oBRDegree; }
			set { oBRDegree = value; }
		}

		/// <summary>
		/// Gets or sets the Order_Callback_Phone_Number value.
		/// </summary>
		public string Order_Callback_Phone_Number
		{
			get { return order_Callback_Phone_Number; }
			set { order_Callback_Phone_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Field1 value.
		/// </summary>
		public string Placer_Field1
		{
			get { return placer_Field1; }
			set { placer_Field1 = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Field2 value.
		/// </summary>
		public string Placer_Field2
		{
			get { return placer_Field2; }
			set { placer_Field2 = value; }
		}

		/// <summary>
		/// Gets or sets the Filler_Field1 value.
		/// </summary>
		public string Filler_Field1
		{
			get { return filler_Field1; }
			set { filler_Field1 = value; }
		}

		/// <summary>
		/// Gets or sets the Filler_Field2 value.
		/// </summary>
		public string Filler_Field2
		{
			get { return filler_Field2; }
			set { filler_Field2 = value; }
		}

		/// <summary>
		/// Gets or sets the Results_Rpt_Status_Chng_DateTime value.
		/// </summary>
		public DateTime Results_Rpt_Status_Chng_DateTime
		{
			get { return results_Rpt_Status_Chng_DateTime; }
			set { results_Rpt_Status_Chng_DateTime = value; }
		}

		/// <summary>
		/// Gets or sets the Change_to_Practice value.
		/// </summary>
		public string Change_to_Practice
		{
			get { return change_to_Practice; }
			set { change_to_Practice = value; }
		}

		/// <summary>
		/// Gets or sets the Tasks_Line_Discount value.
		/// </summary>
		public decimal Tasks_Line_Discount
		{
			get { return tasks_Line_Discount; }
			set { tasks_Line_Discount = value; }
		}

		/// <summary>
		/// Gets or sets the Tasks_Line_Amount value.
		/// </summary>
		public decimal Tasks_Line_Amount
		{
			get { return tasks_Line_Amount; }
			set { tasks_Line_Amount = value; }
		}

		/// <summary>
		/// Gets or sets the Tasks_Sales_Price value.
		/// </summary>
		public decimal Tasks_Sales_Price
		{
			get { return tasks_Sales_Price; }
			set { tasks_Sales_Price = value; }
		}

		/// <summary>
		/// Gets or sets the Tasks_Sales_ID value.
		/// </summary>
		public string Tasks_Sales_ID
		{
			get { return tasks_Sales_ID; }
			set { tasks_Sales_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Diagnostic_Serv_Sect_ID value.
		/// </summary>
		public string Diagnostic_Serv_Sect_ID
		{
			get { return diagnostic_Serv_Sect_ID; }
			set { diagnostic_Serv_Sect_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Result_Status value.
		/// </summary>
		public string Result_Status
		{
			get { return result_Status; }
			set { result_Status = value; }
		}

		/// <summary>
		/// Gets or sets the Parent_Status value.
		/// </summary>
		public string Parent_Status
		{
			get { return parent_Status; }
			set { parent_Status = value; }
		}

		/// <summary>
		/// Gets or sets the OBRQuantity_Timing value.
		/// </summary>
		public string OBRQuantity_Timing
		{
			get { return oBRQuantity_Timing; }
			set { oBRQuantity_Timing = value; }
		}

		/// <summary>
		/// Gets or sets the Login_Create_DateTime value.
		/// </summary>
		public DateTime Login_Create_DateTime
		{
			get { return login_Create_DateTime; }
			set { login_Create_DateTime = value; }
		}

		/// <summary>
		/// Gets or sets the Login_Priority value.
		/// </summary>
		public string Login_Priority
		{
			get { return login_Priority; }
			set { login_Priority = value; }
		}

		/// <summary>
		/// Gets or sets the Result_Copies_To value.
		/// </summary>
		public string Result_Copies_To
		{
			get { return result_Copies_To; }
			set { result_Copies_To = value; }
		}

		/// <summary>
		/// Gets or sets the Parent_Result_Observation_Identifier value.
		/// </summary>
		public string Parent_Result_Observation_Identifier
		{
			get { return parent_Result_Observation_Identifier; }
			set { parent_Result_Observation_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the Transporation_Mode value.
		/// </summary>
		public string Transporation_Mode
		{
			get { return transporation_Mode; }
			set { transporation_Mode = value; }
		}

		/// <summary>
		/// Gets or sets the Reason_For_Study value.
		/// </summary>
		public string Reason_For_Study
		{
			get { return reason_For_Study; }
			set { reason_For_Study = value; }
		}

		/// <summary>
		/// Gets or sets the Principal_Result_Interpreter value.
		/// </summary>
		public string Principal_Result_Interpreter
		{
			get { return principal_Result_Interpreter; }
			set { principal_Result_Interpreter = value; }
		}

		/// <summary>
		/// Gets or sets the Assistant_Result_Interpreter value.
		/// </summary>
		public string Assistant_Result_Interpreter
		{
			get { return assistant_Result_Interpreter; }
			set { assistant_Result_Interpreter = value; }
		}

		/// <summary>
		/// Gets or sets the Technician value.
		/// </summary>
		public string Technician
		{
			get { return technician; }
			set { technician = value; }
		}

		/// <summary>
		/// Gets or sets the Transcriptionist value.
		/// </summary>
		public string Transcriptionist
		{
			get { return transcriptionist; }
			set { transcriptionist = value; }
		}

		/// <summary>
		/// Gets or sets the Scheduled_Date_Time value.
		/// </summary>
		public DateTime Scheduled_Date_Time
		{
			get { return scheduled_Date_Time; }
			set { scheduled_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Number_Of_Sample_Containers value.
		/// </summary>
		public string Number_Of_Sample_Containers
		{
			get { return number_Of_Sample_Containers; }
			set { number_Of_Sample_Containers = value; }
		}

		/// <summary>
		/// Gets or sets the Transport_Logistics_Of_Collected_Samlpe value.
		/// </summary>
		public string Transport_Logistics_Of_Collected_Samlpe
		{
			get { return transport_Logistics_Of_Collected_Samlpe; }
			set { transport_Logistics_Of_Collected_Samlpe = value; }
		}

		/// <summary>
		/// Gets or sets the Collectors_Comment value.
		/// </summary>
		public string Collectors_Comment
		{
			get { return collectors_Comment; }
			set { collectors_Comment = value; }
		}

		/// <summary>
		/// Gets or sets the Transport_Arrangement_Responsibility value.
		/// </summary>
		public string Transport_Arrangement_Responsibility
		{
			get { return transport_Arrangement_Responsibility; }
			set { transport_Arrangement_Responsibility = value; }
		}

		/// <summary>
		/// Gets or sets the Transport_Arranged value.
		/// </summary>
		public string Transport_Arranged
		{
			get { return transport_Arranged; }
			set { transport_Arranged = value; }
		}

		/// <summary>
		/// Gets or sets the Escort_Required value.
		/// </summary>
		public string Escort_Required
		{
			get { return escort_Required; }
			set { escort_Required = value; }
		}

		/// <summary>
		/// Gets or sets the Planned_Patient_Transport_Comment value.
		/// </summary>
		public string Planned_Patient_Transport_Comment
		{
			get { return planned_Patient_Transport_Comment; }
			set { planned_Patient_Transport_Comment = value; }
		}

		/// <summary>
		/// Gets or sets the Procedure_Code value.
		/// </summary>
		public string Procedure_Code
		{
			get { return procedure_Code; }
			set { procedure_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Procedure_Code_Modifier value.
		/// </summary>
		public string Procedure_Code_Modifier
		{
			get { return procedure_Code_Modifier; }
			set { procedure_Code_Modifier = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Supplemental_Service_Information value.
		/// </summary>
		public string Placer_Supplemental_Service_Information
		{
			get { return placer_Supplemental_Service_Information; }
			set { placer_Supplemental_Service_Information = value; }
		}

		/// <summary>
		/// Gets or sets the Filler_Supplemental_Service_Information value.
		/// </summary>
		public string Filler_Supplemental_Service_Information
		{
			get { return filler_Supplemental_Service_Information; }
			set { filler_Supplemental_Service_Information = value; }
		}

		/// <summary>
		/// Gets or sets the Medically_Necessary_Duplicate_Procedure_Reason value.
		/// </summary>
		public string Medically_Necessary_Duplicate_Procedure_Reason
		{
			get { return medically_Necessary_Duplicate_Procedure_Reason; }
			set { medically_Necessary_Duplicate_Procedure_Reason = value; }
		}

		/// <summary>
		/// Gets or sets the Result_Handling value.
		/// </summary>
		public string Result_Handling
		{
			get { return result_Handling; }
			set { result_Handling = value; }
		}

		/// <summary>
		/// Gets or sets the Parent_Universal_Service_Identifier value.
		/// </summary>
		public string Parent_Universal_Service_Identifier
		{
			get { return parent_Universal_Service_Identifier; }
			set { parent_Universal_Service_Identifier = value; }
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
		/// Gets or sets the OBRQuantity_TimingQuantity value.
		/// </summary>
		public int OBRQuantity_TimingQuantity
		{
			get { return oBRQuantity_TimingQuantity; }
			set { oBRQuantity_TimingQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the OBRQuantity_TimingInterval value.
		/// </summary>
		public int OBRQuantity_TimingInterval
		{
			get { return oBRQuantity_TimingInterval; }
			set { oBRQuantity_TimingInterval = value; }
		}

		/// <summary>
		/// Gets or sets the OBRQuantity_TimingDuration value.
		/// </summary>
		public int OBRQuantity_TimingDuration
		{
			get { return oBRQuantity_TimingDuration; }
			set { oBRQuantity_TimingDuration = value; }
		}

		/// <summary>
		/// Gets or sets the OBRQuantity_TimingStartDate value.
		/// </summary>
		public DateTime OBRQuantity_TimingStartDate
		{
			get { return oBRQuantity_TimingStartDate; }
			set { oBRQuantity_TimingStartDate = value; }
		}

		/// <summary>
		/// Gets or sets the OBRQuantity_TimingEndDate value.
		/// </summary>
		public DateTime OBRQuantity_TimingEndDate
		{
			get { return oBRQuantity_TimingEndDate; }
			set { oBRQuantity_TimingEndDate = value; }
		}

		/// <summary>
		/// Gets or sets the OBRQuantity_TimingPriority value.
		/// </summary>
		public string OBRQuantity_TimingPriority
		{
			get { return oBRQuantity_TimingPriority; }
			set { oBRQuantity_TimingPriority = value; }
		}

		/// <summary>
		/// Gets or sets the LocationSource value.
		/// </summary>
		public string LocationSource
		{
			get { return locationSource; }
			set { locationSource = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageOBRContent value.
		/// </summary>
		public string HLMessageOBRContent
		{
			get { return hLMessageOBRContent; }
			set { hLMessageOBRContent = value; }
		}

		/// <summary>
		/// Gets or sets the OtherFileStatus value.
		/// </summary>
		public bool OtherFileStatus
		{
			get { return otherFileStatus; }
			set { otherFileStatus = value; }
		}

		/// <summary>
		/// Gets or sets the FolderName value.
		/// </summary>
		public string FolderName
		{
			get { return folderName; }
			set { folderName = value; }
		}

		/// <summary>
		/// Gets or sets the PrePlacer_Field1 value.
		/// </summary>
		public string PrePlacer_Field1
		{
			get { return prePlacer_Field1; }
			set { prePlacer_Field1 = value; }
		}

		/// <summary>
		/// Gets or sets the CancelStatus value.
		/// </summary>
		public bool CancelStatus
		{
			get { return cancelStatus; }
			set { cancelStatus = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentPlacer_Field1 value.
		/// </summary>
		public string CurrentPlacer_Field1
		{
			get { return currentPlacer_Field1; }
			set { currentPlacer_Field1 = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousSet_ID_OBR value.
		/// </summary>
		public string PreviousSet_ID_OBR
		{
			get { return previousSet_ID_OBR; }
			set { previousSet_ID_OBR = value; }
		}

		/// <summary>
		/// Gets or sets the Current_HLMessageID value.
		/// </summary>
		public long Current_HLMessageID
		{
			get { return current_HLMessageID; }
			set { current_HLMessageID = value; }
		}


		#endregion
}
}
