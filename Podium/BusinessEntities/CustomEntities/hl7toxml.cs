using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HL7toXML_Convert
{
    public  class hl7toxml
    {
        private  Dictionary<string, string> _hl7tags = new Dictionary<string,string>();
   
        public  hl7toxml()
        {
            //For Message Headers
            #region Msg Header
            _hl7tags.Add("MSH.0", "Event_Type");
            _hl7tags.Add("MSH.1", "Encoding_Characters");
            _hl7tags.Add("MSH.2", "Sending_Application");
            _hl7tags.Add("MSH.3", "Sending_Facility");
            _hl7tags.Add("MSH.3.0", "Namespace_ID");
            _hl7tags.Add("MSH.3.1", "Universal_ID");
            _hl7tags.Add("MSH.6", "Message_Date_Time");
            _hl7tags.Add("MSH.7", "Security");
            _hl7tags.Add("MSH.4", "Receiving_Application");
            _hl7tags.Add("MSH.5", "Receiving_Facility");
            //_hl7tags.Add("MSH.6", "Sequence_number");
            _hl7tags.Add("MSH.9", "Message_control_id");
            _hl7tags.Add("MSH.8", "Message_Type");
            _hl7tags.Add("MSH.8.0", "Message_Code");
            _hl7tags.Add("MSH.8.1", "Trigger_Event");
            _hl7tags.Add("MSH.8.2", "Message_Structure");
            //_hl7tags.Add("MSH.9", "Continuation_pointer");
            _hl7tags.Add("MSH.10", "Processing_ID");
            _hl7tags.Add("MSH.11", "Version_ID");
            //_hl7tags.Add("MSH.11", "Application_Acknowledgment_type");
            _hl7tags.Add("MSH.12", "Country_Code");
            _hl7tags.Add("MSH.13", "Character_Set");
            _hl7tags.Add("MSH.14", "Principal_Language_Of_Message");
            _hl7tags.Add("MSH.14.0", "Identifier");
            _hl7tags.Add("MSH.15", "Alternate_Character_Set_Handling_Scheme");
            _hl7tags.Add("MSH.16", "Message_Profile_Identifier");
            _hl7tags.Add("MSH.16.1", "Entity_Identifier");
            _hl7tags.Add("MSH.17", "Sending_Responsible_Organization");
            _hl7tags.Add("MSH.17.0", "Organization_Name");
            _hl7tags.Add("MSH.18", "Receiving_Responsible_Organization");
            _hl7tags.Add("MSH.18.0", "Organization_Name");
            _hl7tags.Add("MSH.19", "Sending_Network_Address");
            _hl7tags.Add("MSH.19.0", "Namespace_ID");
            _hl7tags.Add("MSH.20", "Receiving_Network_Address");
            _hl7tags.Add("MSH.20.0", "Namespace_ID");

            #endregion

            //For EVN Tags
            #region EVN
            _hl7tags.Add("EVN.0", "Event_Type");
            _hl7tags.Add("EVN.1", "Event_Type_Code");
            _hl7tags.Add("EVN.2", "Recorded_Date-time");

            #endregion

            //For Patient Identification
            #region PID
            _hl7tags.Add("PID.0", "Event_Type");
            //_hl7tags.Add("PID.", "Patient_identification");
            _hl7tags.Add("PID.1", "Set_ID_PID");
            _hl7tags.Add("PID.2", "Patient_ID");
            _hl7tags.Add("PID.3", "Patient_Identifier_List");
            _hl7tags.Add("PID.3.0", "ID_Number");
            _hl7tags.Add("PID.3.1", "Identifier_Check_Digit");
            _hl7tags.Add("PID.3.2", "Check_Digit_Scheme");
            _hl7tags.Add("PID.4", "Alteration_Patient_ID_PID");
            _hl7tags.Add("PID.5", "Patient_Name");
            _hl7tags.Add("PID.5.0", "Family_Name");
            _hl7tags.Add("PID.5.1", "Given_Name"); 
            _hl7tags.Add("PID.5.2", "Second_and_further_given_Names_or_Initials_Thereof");
            _hl7tags.Add("PID.5.3", "Suffix");
            _hl7tags.Add("PID.5.4", "Prefix");
            _hl7tags.Add("PID.5.5", "Degree");
            _hl7tags.Add("PID.6", "Mother_Maiden_Name");
            _hl7tags.Add("PID.7", "Date-time_Of_Birth");
            _hl7tags.Add("PID.8", "Date-Administrative_Sex");
            _hl7tags.Add("PID.9", "Patient_Alies");
            _hl7tags.Add("PID.10", "Race");
            _hl7tags.Add("PID.11", "Patient_Address");
            _hl7tags.Add("PID.11.0", "Street_Mailing_Address");
            _hl7tags.Add("PID.11.1", "Other_Designation");
            _hl7tags.Add("PID.11.2", "City");
            _hl7tags.Add("PID.11.3", "State_Of_Province");
            _hl7tags.Add("PID.11.4", "Zip_Or_Postal_Code");
            _hl7tags.Add("PID.11.5", "Country");
                       

            _hl7tags.Add("PID.12", "Country_Code");
            _hl7tags.Add("PID.13", "Phone_Number_home");
            _hl7tags.Add("PID.13.0", "HTelephone_Number");
            _hl7tags.Add("PID.13.1", "HTelecommunication_use_code");
            _hl7tags.Add("PID.13.2", "HTelecommunication_Equipment_Type");
            _hl7tags.Add("PID.13.3", "HCommunication_Address");
            _hl7tags.Add("PID.14", "Phone_Number_Business");
            _hl7tags.Add("PID.14.0", "Telephone_Number");
            _hl7tags.Add("PID.14.1", "Telecommunication_use_code");
            _hl7tags.Add("PID.14.2", "Telecommunication_Equipment_Type");
            _hl7tags.Add("PID.14.3", "Communication_Address");


            _hl7tags.Add("PID.15", "Primary_Language");
            _hl7tags.Add("PID.16", "Marital_Status");
            _hl7tags.Add("PID.17", "Religion");
            _hl7tags.Add("PID.18", "Patient_Account_Number");
            _hl7tags.Add("PID.18.1", "ID_Number");
            _hl7tags.Add("PID.19", "SSN_Number_Patient");
            _hl7tags.Add("PID.20", "Driver_License_Number_Patient");
            _hl7tags.Add("PID.21", "Mother_Identifier");
            _hl7tags.Add("PID.21.0", "ID_Number");
            _hl7tags.Add("PID.22", "Ethnic_Group");
            _hl7tags.Add("PID.22.0", "Identifier");
            _hl7tags.Add("PID.23", "Birth_Place");
            _hl7tags.Add("PID.24", "Multiple_Birth_Indicator");
            _hl7tags.Add("PID.25", "Birth_Order");
            _hl7tags.Add("PID.26", "Citizenship");

            _hl7tags.Add("PID.27", "Veterans_Military_Status");

            _hl7tags.Add("PID.28", "Nationality");
            _hl7tags.Add("PID.29", "Patient_Death_Date_and_Time");
            _hl7tags.Add("PID.30", "Patient_Death_Indicator");
            _hl7tags.Add("PID.31", "Identity_Unknown_Indicator");
            _hl7tags.Add("PID.32", "Identity_reliability_Code");
            _hl7tags.Add("PID.33", "Last_Updated_DateTime");
            _hl7tags.Add("PID.34", "Last_Update_Facility");
            _hl7tags.Add("PID.34.0", "NamespaceID");
            _hl7tags.Add("PID.35", "Species_Code");
            _hl7tags.Add("PID.36", "Breed_Code");
            _hl7tags.Add("PID.37", "Strain");
            _hl7tags.Add("PID.38", "Production_Class_Code");
            _hl7tags.Add("PID.39", "Tribal_Citizenship");
            _hl7tags.Add("PID.39.0", "Identifier");
            _hl7tags.Add("PID.40", "Ward_Code");
            /* Previous Codeing comment it contain Two Phone_Number_Business, so order is changed*/
            /*
            _hl7tags.Add("PID.15", "Phone_Number_Business");
            _hl7tags.Add("PID.15.0", "Telephone_Number");

            _hl7tags.Add("PID.16", "Primary_Language");
            _hl7tags.Add("PID.17", "Marital_Status");
            _hl7tags.Add("PID.18", "Religion");
            _hl7tags.Add("PID.19", "Patient_Account_Number");
            _hl7tags.Add("PID.19.1", "ID_Number");
            _hl7tags.Add("PID.20", "SSN_Number_Patient");
            _hl7tags.Add("PID.21", "Driver_License_Number_Patient");
            _hl7tags.Add("PID.22", "Mother_Identifier");
            _hl7tags.Add("PID.22.0", "ID_Number");
            _hl7tags.Add("PID.23", "Ethnic_Group");
            _hl7tags.Add("PID.23.0", "Identifier");
            _hl7tags.Add("PID.24", "Birth_Place");
            _hl7tags.Add("PID.25", "Multiple_Birth_Indicator");
            _hl7tags.Add("PID.26", "Birth_Order");
            _hl7tags.Add("PID.27", "Citizenship");

            _hl7tags.Add("PID.28", "Veterans_Military_Status");

            _hl7tags.Add("PID.29", "Nationality");
            _hl7tags.Add("PID.30", "Patient_Death_Date_and_Time");
            _hl7tags.Add("PID.31", "Patient_Death_Indicator");
            _hl7tags.Add("PID.32", "Identity_Unknown_Indicator");
            _hl7tags.Add("PID.33", "Identity_reliability_Code");
            _hl7tags.Add("PID.34", "Last_Updated_DateTime");
            _hl7tags.Add("PID.35", "Last_Update_Facility");
            _hl7tags.Add("PID.35.0", "NamespaceID");
            _hl7tags.Add("PID.36", "Species_Code");
            _hl7tags.Add("PID.37", "Breed_Code");
            _hl7tags.Add("PID.38", "Strain");
            _hl7tags.Add("PID.39", "Production_Class_Code");
            _hl7tags.Add("PID.40", "Tribal_Citizenship");
            _hl7tags.Add("PID.40.0", "Identifier");
            _hl7tags.Add("PID.41", "Ward_Code");
             */

            #endregion

            //For Next of Kin
            #region NextOfKin
            _hl7tags.Add("NK1", "NK");
            _hl7tags.Add("NK1.0", "NK1");
            _hl7tags.Add("NK1.1", "Set_ID_NK1");
            _hl7tags.Add("NK1.2", "NK_Name");
            _hl7tags.Add("NK1.3", "Relationship");
            _hl7tags.Add("NK1.4", "Address");
            _hl7tags.Add("NK1.5", "Phone_Number");
            _hl7tags.Add("NK1.6", "Business_Phone_Number");
            _hl7tags.Add("NK1.7", "Contact_Role");
            _hl7tags.Add("NK1.8", "Start_Date");
            #endregion

            //For Patient Visit
            #region PatientVisit

            _hl7tags.Add("PV1.0", "Event_Type");
            _hl7tags.Add("PV1.1", "Set_ID_PV1");
            _hl7tags.Add("PV1.2", "Patient_Class");
            _hl7tags.Add("PV1.3", "Assigned_Patient_Location");
            _hl7tags.Add("PV1.3.0", "Point_Of_Care");
            _hl7tags.Add("PV1.3.1", "Room");
            _hl7tags.Add("PV1.3.2", "Bed");
            _hl7tags.Add("PV1.3.3", "Facility");
            _hl7tags.Add("PV1.3.4", "Location_Status");
            _hl7tags.Add("PV1.4", "Admission_Type");
            _hl7tags.Add("PV1.5", "Preadmit_Number");
            _hl7tags.Add("PV1.6", "Prior_Patient_Location");
            _hl7tags.Add("PV1.6.0", "Point_Of_Care");
            _hl7tags.Add("PV1.6.1", "Room");
            _hl7tags.Add("PV1.6.2", "Bed");
            _hl7tags.Add("PV1.6.3", "Facility");
            _hl7tags.Add("PV1.6.4", "Location_Status");
            _hl7tags.Add("PV1.7", "Attending_Doctor");
            _hl7tags.Add("PV1.7.0", "Person_Identifier");
            _hl7tags.Add("PV1.7.1", "Family_Name");
            _hl7tags.Add("PV1.7.2", "Given_Name");
            _hl7tags.Add("PV1.7.3", "Second_and_Further_Given_Name_or_Initials");
            _hl7tags.Add("PV1.7.4", "Suffix");
            _hl7tags.Add("PV1.7.5", "Prefix");
            _hl7tags.Add("PV1.7.6", "Degree");

            _hl7tags.Add("PV1.8", "Referring_Doctor");
            _hl7tags.Add("PV1.8.0", "Person_Identifier");

            _hl7tags.Add("PV1.9", "Consulting_Doctor");
            _hl7tags.Add("PV1.9.0", "Person_Identifier");
            _hl7tags.Add("PV1.9.1", "Family_Name");
            _hl7tags.Add("PV1.9.2", "Given_Name");
            _hl7tags.Add("PV1.9.3", "Second_and_Further_Given_Name_or_Initials");
            _hl7tags.Add("PV1.9.4", "Suffix");
            _hl7tags.Add("PV1.9.5", "Prefix");
            _hl7tags.Add("PV1.9.6", "Degree");

            _hl7tags.Add("PV1.10", "Hospital_Service");
            _hl7tags.Add("PV1.11", "Temporary_Location");
            _hl7tags.Add("PV1.12", "Preadmit_Test_Indicator");
            _hl7tags.Add("PV1.13", "Re_admission_Indicator");
            _hl7tags.Add("PV1.14", "Admit_Source");
            _hl7tags.Add("PV1.15", "Ambulatory_Status");
            _hl7tags.Add("PV1.16", "VIP_Indicator");

            _hl7tags.Add("PV1.17", "Admitting_Doctor");
            _hl7tags.Add("PV1.17.0", "Person_Identifier");
            _hl7tags.Add("PV1.17.1", "Family_Name");
            _hl7tags.Add("PV1.17.2", "Given_Name");
            _hl7tags.Add("PV1.17.3", "Second_and_Further_Given_Name_or_Initials");
            _hl7tags.Add("PV1.17.4", "Suffix");
            _hl7tags.Add("PV1.17.5", "Prefix");
            _hl7tags.Add("PV1.17.6", "Degree");
            
            _hl7tags.Add("PV1.18", "Patient_Type");
            _hl7tags.Add("PV1.19", "Visit_Number");
            _hl7tags.Add("PV1.19.0", "ID");
            //_hl7tags.Add("PV1.19.1", "Visit_Number");

            _hl7tags.Add("PV1.20", "Financial_Class");
            _hl7tags.Add("PV1.21", "Charge_Price_Indicator");
            _hl7tags.Add("PV1.22", "Courtesy_Code");
            _hl7tags.Add("PV1.23", "Credit_Rating");

            _hl7tags.Add("PV1.24", "Contract_Code");
            _hl7tags.Add("PV1.25", "Contract_Effective_Date");
            _hl7tags.Add("PV1.26", "Contract_Amount");
            _hl7tags.Add("PV1.27", "Contract_Period");
            _hl7tags.Add("PV1.28", "Interest_Code");
            _hl7tags.Add("PV1.29", "Transfer_to_bad_Dept_Code");
            _hl7tags.Add("PV1.30", "Transfer_to_bad_Dept_Code");
            _hl7tags.Add("PV1.31", "Bad_Debt_Agency_Code");
            _hl7tags.Add("PV1.32", "Bad_Debt_Transfer_Amount");
            _hl7tags.Add("PV1.33", "Bad_Debt_Recovery_Amount");
            _hl7tags.Add("PV1.34", "Delete_Account_Indicator");
            _hl7tags.Add("PV1.35", "Delete_Account_Date");
            _hl7tags.Add("PV1.36", "Discharge_Disposition");
            _hl7tags.Add("PV1.37", "Discharge_to_Location");
            _hl7tags.Add("PV1.38", "Diet_Type");
            _hl7tags.Add("PV1.39", "Servicing_Facility");
            _hl7tags.Add("PV1.40", "Bed_Status");
            _hl7tags.Add("PV1.41", "Account_Status");
            _hl7tags.Add("PV1.42", "Pending_Location");
            _hl7tags.Add("PV1.43", "Prior_Temporary_Location");
            _hl7tags.Add("PV1.44", "Admit_Date-Time");
            _hl7tags.Add("PV1.45", "Discharge_Date-Time");
            _hl7tags.Add("PV1.46", "Current_Patient_Balance");
            _hl7tags.Add("PV1.47", "Total_Charges");
            _hl7tags.Add("PV1.48", "Total_adjustments");
            _hl7tags.Add("PV1.49", "Total_Payments");
            _hl7tags.Add("PV1.50", "Alternate_Visit_ID");
            _hl7tags.Add("PV1.51", "Visit_Indicator");
            _hl7tags.Add("PV1.52", "Other_Healthcare_Provider");

            #endregion

            //For Abservation Result
            #region ORC Segment
            _hl7tags.Add("ORC.0", "Event_Type");
            _hl7tags.Add("ORC.1", "Order_Control");
            _hl7tags.Add("ORC.2", "Place_Order_Number");
            _hl7tags.Add("ORC.2.0", "Entity_Identifier");

            _hl7tags.Add("ORC.3", "Filler_Order_Number");
            _hl7tags.Add("ORC.3.0", "Entity_Identifier");
            _hl7tags.Add("ORC.4", "Placer_Group_Number");
            _hl7tags.Add("ORC.4.0", "Enity_Identifier");

            _hl7tags.Add("ORC.5", "Order_Status");
            _hl7tags.Add("ORC.6", "Response_Flag");
            
            _hl7tags.Add("ORC.7", "Quantity-Timing");
            _hl7tags.Add("ORC.7.0", "Quantity");
            _hl7tags.Add("ORC.7.1", "Interval");
            _hl7tags.Add("ORC.7.2", "Duration");
            _hl7tags.Add("ORC.7.3", "Start_Date-Time");
            _hl7tags.Add("ORC.7.4", "End_Date-Time");
            _hl7tags.Add("ORC.7.5", "Priority");            


            _hl7tags.Add("ORC.8", "Parent_Order");
            _hl7tags.Add("ORC.8.0", "Placer_Assigned_Identifier");

            _hl7tags.Add("ORC.9", "Date-Time_Of_Transaction");
            _hl7tags.Add("ORC.10", "Entered_By");
            _hl7tags.Add("ORC.10.0", "Person_Identifier");
            _hl7tags.Add("ORC.10.1", "Family_Name");
            _hl7tags.Add("ORC.10.2", "Given_Name");
            _hl7tags.Add("ORC.10.3", "Second_and_Further_Given_Names_or_Initials_Thereof");

            _hl7tags.Add("ORC.11", "Verified_By");

            _hl7tags.Add("ORC.12", "Ordering_Provider");
            _hl7tags.Add("ORC.12.0", "Person_Identifier");
            _hl7tags.Add("ORC.12.1", "Family_Name");
            _hl7tags.Add("ORC.12.2", "Given_Name");
            _hl7tags.Add("ORC.12.3", "Second_and_Further_Given_Names_or_Initials_Thereof");
            _hl7tags.Add("ORC.12.4", "Suffix");
            _hl7tags.Add("ORC.12.5", "Prefix");
            _hl7tags.Add("ORC.12.6", "Degree");

            _hl7tags.Add("ORC.13", "Enterer_Location");
            _hl7tags.Add("ORC.13.0", "Point_of_Care");
            _hl7tags.Add("ORC.13.1", "Room");
            _hl7tags.Add("ORC.13.2", "Bed");
            _hl7tags.Add("ORC.13.3", "Facility");

            _hl7tags.Add("ORC.14", "Call_Back_Phone_Number");
            _hl7tags.Add("ORC.14.0", "Telephone_number");
            _hl7tags.Add("ORC.15", "Order_Effective_Date-Time");
            _hl7tags.Add("ORC.16", "Order_Control_Code_Reason");
            _hl7tags.Add("ORC.17", "Entering_Organization");
            _hl7tags.Add("ORC.18", "Entering_Device");
            _hl7tags.Add("ORC.19", "Action_By");
            _hl7tags.Add("ORC.20", "Advanced_Beneficiary_Notice_Code");
            _hl7tags.Add("ORC.21", "Ordering_Facility_Name");
            _hl7tags.Add("ORC.22", "Ordering_Facility_Address");
            _hl7tags.Add("ORC.23", "Ordering_Facility_Phone_Number");
            _hl7tags.Add("ORC.24", "Ordering_Provider_Address");
            _hl7tags.Add("ORC.25", "Order_Status_Modifier");
            _hl7tags.Add("ORC.26", "Advanced_Beneficiary_Notice_Override_Reason");
            _hl7tags.Add("ORC.27", "Filler_Expected_Availability_Date-time");
            _hl7tags.Add("ORC.28", "Confidentially_Code");
            _hl7tags.Add("ORC.29", "Order_Type");
            _hl7tags.Add("ORC.30", "Enterer_Authorization_Mode");
            _hl7tags.Add("ORC.31", "Parent_Universal_Service_Identifier");

            #endregion

            //For OBR Segment
            #region OBR Segment
            _hl7tags.Add("OBR.0", "Event_Type");
            _hl7tags.Add("OBR.1", "Set_ID_OBR");
            _hl7tags.Add("OBR.2", "Placer_Order_Number");
            _hl7tags.Add("OBR.3", "Filler_Order_Number");
            _hl7tags.Add("OBR.4", "Universal_Service_Identifier");
            _hl7tags.Add("OBR.4.0", "Identifier");
            _hl7tags.Add("OBR.4.1", "Text");
            _hl7tags.Add("OBR.4.2", "Name_Of_Coding_System");

            _hl7tags.Add("OBR.5", "Priority");
            _hl7tags.Add("OBR.6", "Requested_Date-Time");
            _hl7tags.Add("OBR.7", "Observation_Date-Time");
            _hl7tags.Add("OBR.8", "Observation_End_Date-Time");
            _hl7tags.Add("OBR.9", "Collection_Volume");
            _hl7tags.Add("OBR.10", "Collector_Identifier");
            _hl7tags.Add("OBR.11", "Spicemen_Action_Code");
            _hl7tags.Add("OBR.12", "Danger_Code");
            _hl7tags.Add("OBR.13", "Relevant_Clinical_Information");
            _hl7tags.Add("OBR.14", "Specimen_Received_Date-Time");
            _hl7tags.Add("OBR.15", "Specimen_Source");
            _hl7tags.Add("OBR.16", "Ordering_Provider");
            _hl7tags.Add("OBR.16.0", "Person_Identifier");
            _hl7tags.Add("OBR.16.1", "Family_Name");
            _hl7tags.Add("OBR.16.2", "Given_Name");
            _hl7tags.Add("OBR.16.3", "Second_and_Further_Given_Names_or_Initials_There_of");
            _hl7tags.Add("OBR.16.4", "Suffix");
            _hl7tags.Add("OBR.16.5", "Prefix");
            _hl7tags.Add("OBR.16.6", "Degree");
            _hl7tags.Add("OBR.17", "Order_Callback_Phone_Number");
            _hl7tags.Add("OBR.18", "Placer_Field1");
            _hl7tags.Add("OBR.19", "Placer_Field2");
            _hl7tags.Add("OBR.20", "Filler_Field1");
            _hl7tags.Add("OBR.21", "Filler_Field2");
            _hl7tags.Add("OBR.22", "Results_Rpt-Status_Chng-DateTime");
            _hl7tags.Add("OBR.23", "Change_to_Practice");
            _hl7tags.Add("OBR.24", "Diagnostic_Serv_Sect_ID");
            _hl7tags.Add("OBR.25", "Result_Status");
            _hl7tags.Add("OBR.26", "Parent_Status");
            _hl7tags.Add("OBR.27", "Quantity-Timing");
            _hl7tags.Add("OBR.27.0", "Quantity-Timing_Quantity");
            _hl7tags.Add("OBR.27.1", "Quantity-Timing_Interval");
            _hl7tags.Add("OBR.27.2", "Quantity-Timing_Duration");
            _hl7tags.Add("OBR.27.3", "Quantity-Timing_StartDate");
            _hl7tags.Add("OBR.27.4", "Quantity-Timing_EndDate");
            _hl7tags.Add("OBR.27.5", "Quantity-Timing_Priority");
            _hl7tags.Add("OBR.28", "Result_Copies_To");
            _hl7tags.Add("OBR.29", "Parent_Result_Observation_Identifier");
            _hl7tags.Add("OBR.30", "Transporation_Mode");
            _hl7tags.Add("OBR.31", "Reason_For_Study");
            _hl7tags.Add("OBR.32", "Principal_Result_Interpreter");
            _hl7tags.Add("OBR.33", "Assistant_Result_Interpreter");
            _hl7tags.Add("OBR.34", "Technician");
            _hl7tags.Add("OBR.35", "Transcriptionist");
            _hl7tags.Add("OBR.36", "Scheduled_Date-Time");
            _hl7tags.Add("OBR.37", "Number_Of_Sample_Containers");
            _hl7tags.Add("OBR.38", "Transport_Logistics_Of_Collected_Samlpe");
            _hl7tags.Add("OBR.39", "Collectors_Comment");
            _hl7tags.Add("OBR.40", "Transport_Arrangement_Responsibility");
            _hl7tags.Add("OBR.41", "Transport_Arranged");
            _hl7tags.Add("OBR.42", "Escort_Required");
            _hl7tags.Add("OBR.43", "Planned_Patient_Transport_Comment");
            _hl7tags.Add("OBR.44", "Procedure_Code");
            _hl7tags.Add("OBR.45", "Procedure_Code_Modifier");
            _hl7tags.Add("OBR.46", "Placer_Supplemental_Service_Information");
            _hl7tags.Add("OBR.47", "Filler_Supplemental_Service_Information");
            _hl7tags.Add("OBR.48", "Medically_Necessary_Duplicate_Procedure_Reason");
            _hl7tags.Add("OBR.49", "Result_Handling");
            _hl7tags.Add("OBR.50", "Parent_Universal_Service_Identifier");

            #endregion

            //For OBX Segment
            #region OBX Segment
            _hl7tags.Add("OBX.0", "Event_Type");
            _hl7tags.Add("OBX.1", "Set_ID");
            _hl7tags.Add("OBX.2", "Observation_Value_Type");
            _hl7tags.Add("OBX.3", "Observation_Identifier");
            _hl7tags.Add("OBX.4", "Observation_Value");
            _hl7tags.Add("OBX.5", "Units");
            _hl7tags.Add("OBX.6", "ReferenceRange");
            _hl7tags.Add("OBX.7", "IsAbnormalflag");
            _hl7tags.Add("OBX.8", "MedicalRemarks");
            _hl7tags.Add("OBX.9", "IsAbnormal");
            _hl7tags.Add("OBX.10", "ObservationResultsStatus");
            _hl7tags.Add("OBX.11", "Observation_Date_Time");
            _hl7tags.Add("OBX.12", "Probability");
            _hl7tags.Add("OBX.13", "Nature_Abnormal_Test");

            #endregion

            //For Patient Allergy information
            #region Allergy
            _hl7tags.Add("AL1", "Set_ID_ALI");
            _hl7tags.Add("AL1.0", "Allergen_Type_Code");
            _hl7tags.Add("AL1.1", "Allergen_Code-Mnemonic-Description");
            _hl7tags.Add("AL1.2", "Allergy_Severity_Code");
            _hl7tags.Add("AL1.3", "Allergy_Reaction_Code");
            #endregion

            //For Diagnose
            #region Diagnose
            _hl7tags.Add("DG1.0", "DG1");
            _hl7tags.Add("DG1.1", "Set_ID_DG1");
            _hl7tags.Add("DG1.2", "Diagnosis_Coding_Method");
            _hl7tags.Add("DG1.3", "Diagnosis_Code_DG1");
            _hl7tags.Add("DG1.4", "Diagnosis_Description");
            _hl7tags.Add("DG1.5", "Diagnosis_Date-Time");
            _hl7tags.Add("DG1.6", "Diagnosis_Type");
            _hl7tags.Add("DG1.7", "Major_Diagnostic_Category");
            _hl7tags.Add("DG1.8", "Diagnostic_Related_Group");
            #endregion
            //NOTES AND REASONS
            #region REASONS
            _hl7tags.Add("NTE.0", "NTEComments");
            _hl7tags.Add("NTE.1","Set_ID_NTE");
            _hl7tags.Add("NTE.2","NTE_Source_Of_Comment");
            _hl7tags.Add("NTE.3", "NTE_Comment");

            #endregion 

            #region MRG
            _hl7tags.Add("MRG.1","Prior_Patient_ID");
            _hl7tags.Add("MRG.1.0", "Prior_ID_Number");
            _hl7tags.Add("MRG.1.1", "Check_digit");
            #endregion


        }
      

        public  Dictionary<string, string> hl7tags
        {
            get { return _hl7tags; }
            set { _hl7tags = value; }
        }            

    }
}
