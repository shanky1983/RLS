using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.HL7Integration
{
    public class content
    {
        public MSG MSG = new MSG();


    }
    public class MSG
    {
        public List<MSH> MSH11 = new List<MSH>();
        public List<EVN> EVN11 = new List<EVN>();
        public List<PID> PID11 = new List<PID>();
        public List<PV1> PV111 = new List<PV1>();
        public List<ORC> ORC11 = new List<ORC>();
        public Observation_Request Observation_Request = new Observation_Request();
    }
    public class MSH
    {
        string _sending_application = string.Empty;
        public string Sending_Application
        {
            get { return _sending_application; }
            set { _sending_application = value; }
        }

        string _sending_facility = string.Empty;
        public string Sending_Facility
        {
            get { return _sending_facility; }
            set { _sending_facility = value; }
        }

        string _receiving_application = string.Empty;
        public string Receiving_Application
        {
            get { return _receiving_application; }
            set { _receiving_application = value; }
        }

        string _receiving_facility = string.Empty;
        public string Receiving_Facility
        {
            get { return _receiving_facility; }
            set { _receiving_facility = value; }
        }

        string _message_Date_Time = string.Empty;
        public string Message_Date_Time
        {
            get { return _message_Date_Time; }
            set { _message_Date_Time = value; }
        }
        string _message_Type = string.Empty;
        public string Message_Type
        {
            get { return _message_Type; }
            set { _message_Type = value; }
        }

        string _message_Control_Id = string.Empty;
        public string Message_Control_Id
        {
            get { return _message_Control_Id; }
            set { _message_Control_Id = value; }
        }
    }
    public class EVN
    {
        string _event_Type_Code = string.Empty;
        public string Event_Type_Code
        {
            get { return _event_Type_Code; }
            set { _event_Type_Code = value; }
        }

        string _recorded_DateTime = string.Empty;
        public string Recorded_DateTime
        {
            get { return _recorded_DateTime; }
            set { _recorded_DateTime = value; }
        }
    }
    public class PID
    {
        string _patient_Id_Ext = string.Empty;
        public string Patient_Id_Ext
        {
            get { return _patient_Id_Ext; }
            set { _patient_Id_Ext = value; }
        }

        string _patient_Id_Int = string.Empty;
        public string Patient_Id_Int
        {
            get { return _patient_Id_Int; }
            set { _patient_Id_Int = value; }
        }

        string _patient_Id_Type = string.Empty;
        public string Patient_Id_Type
        {
            get { return _patient_Id_Type; }
            set { _patient_Id_Type = value; }
        }

        string _patient_Id_Number = string.Empty;
        public string Patient_Id_Number
        {
            get { return _patient_Id_Number; }
            set { _patient_Id_Number = value; }
        }

        string _patient_Name = string.Empty;
        public string Patient_Name
        {
            get { return _patient_Name; }
            set { _patient_Name = value; }
        }

        string _date_Of_Birth = string.Empty;
        public string Date_Of_Birth
        {
            get { return _date_Of_Birth; }
            set { _date_Of_Birth = value; }
        }

        string _gender_Code = string.Empty;
        public string Gender_Code
        {
            get { return _gender_Code; }
            set { _gender_Code = value; }
        }

        string _race_code = string.Empty;
        public string Race_code
        {
            get { return _race_code; }
            set { _race_code = value; }
        }

        string _address1 = string.Empty;
        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }

        string _address2 = string.Empty;
        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }


        string _address3 = string.Empty;
        public string Address3
        {
            get { return _address3; }
            set { _address3 = value; }
        }

        string _city = string.Empty;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        string _state = string.Empty;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        string _postal_Code = string.Empty;
        public string Postal_Code
        {
            get { return _postal_Code; }
            set { _postal_Code = value; }
        }

        string _country_Code = string.Empty;
        public string Country_Code
        {
            get { return _country_Code; }
            set { _country_Code = value; }
        }

        string _phone_Home = string.Empty;
        public string Phone_Home
        {
            get { return _phone_Home; }
            set { _phone_Home = value; }
        }

        string _phone_Mobile = string.Empty;
        public string Phone_Mobile
        {
            get { return _phone_Mobile; }
            set { _phone_Mobile = value; }
        }

        string _phone_Business = string.Empty;
        public string Phone_Business
        {
            get { return _phone_Business; }
            set { _phone_Business = value; }
        }

        string _primary_Language = string.Empty;
        public string Primary_Language
        {
            get { return _primary_Language; }
            set { _primary_Language = value; }
        }

        string _marital_Status_Code = string.Empty;
        public string Marital_Status_Code
        {
            get { return _marital_Status_Code; }
            set { _marital_Status_Code = value; }
        }

        string _religion_Code = string.Empty;
        public string Religion_Code
        {
            get { return _religion_Code; }
            set { _religion_Code = value; }
        }

        string _nationality_Code = string.Empty;
        public string Nationality_Code
        {
            get { return _nationality_Code; }
            set { _nationality_Code = value; }
        }
    }
    public class PV1
    {
        string _patient_Type_Code = string.Empty;
        public string Patient_Type_Code
        {
            get { return _patient_Type_Code; }
            set { _patient_Type_Code = value; }
        }

        string _ward_Code = string.Empty;
        public string Ward_Code
        {
            get { return _ward_Code; }
            set { _ward_Code = value; }
        }

        string _admission_Type = string.Empty;
        public string Admission_Type
        {
            get { return _admission_Type; }
            set { _admission_Type = value; }
        }

        string _preadmit_Number = string.Empty;
        public string Preadmit_Number
        {
            get { return _preadmit_Number; }
            set { _preadmit_Number = value; }
        }

        string _specialty_Code = string.Empty;
        public string Specialty_Code
        {
            get { return _specialty_Code; }
            set { _specialty_Code = value; }
        }

        string _attending_Doctor_Code = string.Empty;
        public string Attending_Doctor_Code
        {
            get { return _attending_Doctor_Code; }
            set { _attending_Doctor_Code = value; }
        }

        string _attending_Doctor_Desc = string.Empty;
        public string Attending_Doctor_Desc
        {
            get { return _attending_Doctor_Desc; }
            set { _attending_Doctor_Desc = value; }
        }

        string _referring_Doctor_Code = string.Empty;
        public string Referring_Doctor_Code
        {
            get { return _referring_Doctor_Code; }
            set { _referring_Doctor_Code = value; }
        }

        string _referring_Doctor_Desc = string.Empty;
        public string Referring_Doctor_Desc
        {
            get { return _referring_Doctor_Desc; }
            set { _referring_Doctor_Desc = value; }
        }

        string _consulting_Doctor_Code = string.Empty;
        public string Consulting_Doctor_Code
        {
            get { return _consulting_Doctor_Code; }
            set { _consulting_Doctor_Code = value; }
        }

        string _consulting_Doctor_Desc = string.Empty;
        public string Consulting_Doctor_Desc
        {
            get { return _consulting_Doctor_Desc; }
            set { _consulting_Doctor_Desc = value; }
        }



        string _admitting_Doctor_Code = string.Empty;
        public string Admitting_Doctor_Code
        {
            get { return _admitting_Doctor_Code; }
            set { _admitting_Doctor_Code = value; }
        }

        string _admitting_Doctor_Desc = string.Empty;
        public string Admitting_Doctor_Desc
        {
            get { return _admitting_Doctor_Desc; }
            set { _admitting_Doctor_Desc = value; }
        }



        string _patient_Class = string.Empty;
        public string Patient_Class
        {
            get { return _patient_Class; }
            set { _patient_Class = value; }
        }

        string _visit_Number = string.Empty;
        public string Visit_Number
        {
            get { return _visit_Number; }
            set { _visit_Number = value; }
        }


        string _financial_Class_Code = string.Empty;
        public string Financial_Class_Code
        {
            get { return _financial_Class_Code; }
            set { _financial_Class_Code = value; }
        }

        string _admit_DateTime = string.Empty;
        public string Admit_DateTime
        {
            get { return _admit_DateTime; }
            set { _admit_DateTime = value; }
        }
    }
    public class ORC
    {
        string _order_Control = string.Empty;
        public string Order_Control
        {
            get { return _order_Control; }
            set { _order_Control = value; }
        }

        string _orc_Placer_Order_Number = string.Empty;
        public string ORC_Placer_Order_Number
        {
            get { return _orc_Placer_Order_Number; }
            set { _orc_Placer_Order_Number = value; }
        }



        string _orc_Filler_Order_Number = string.Empty;
        public string ORC_Filler_Order_Number
        {
            get { return _orc_Filler_Order_Number; }
            set { _orc_Filler_Order_Number = value; }
        }

        string _placer_Group_Number = string.Empty;
        public string Placer_Group_Number
        {
            get { return _placer_Group_Number; }
            set { _placer_Group_Number = value; }
        }


        string _order_Status_Code = string.Empty;
        public string Order_Status_Code
        {
            get { return _order_Status_Code; }
            set { _order_Status_Code = value; }
        }

        string _response_Flag = string.Empty;
        public string Response_Flag
        {
            get { return _response_Flag; }
            set { _response_Flag = value; }
        }


        string _orc_Quantity_Timing = string.Empty;
        public string ORC_Quantity_Timing
        {
            get { return _orc_Quantity_Timing; }
            set { _orc_Quantity_Timing = value; }
        }

        string _parent = string.Empty;
        public string Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        string _dateTime_Of_Transaction = string.Empty;
        public string DateTime_Of_Transaction
        {
            get { return _dateTime_Of_Transaction; }
            set { _dateTime_Of_Transaction = value; }
        }

        string _entered_By_ID = string.Empty;
        public string Entered_By_ID
        {
            get { return _entered_By_ID; }
            set { _entered_By_ID = value; }
        }


        string _entered_By_Name = string.Empty;
        public string Entered_By_Name
        {
            get { return _entered_By_Name; }
            set { _entered_By_Name = value; }
        }

        string _verified_By_ID = string.Empty;
        public string Verified_By_ID
        {
            get { return _verified_By_ID; }
            set { _verified_By_ID = value; }
        }

        string _verified_By_Name = string.Empty;
        public string Verified_By_Name
        {
            get { return _verified_By_Name; }
            set { _verified_By_Name = value; }
        }

        string _orc_Ordering_Provider_ID = string.Empty;
        public string ORC_Ordering_Provider_ID
        {
            get { return _orc_Ordering_Provider_ID; }
            set { _orc_Ordering_Provider_ID = value; }
        }

        string _orc_Ordering_Provider_Name = string.Empty;
        public string ORC_Ordering_Provider_Name
        {
            get { return _orc_Ordering_Provider_Name; }
            set { _orc_Ordering_Provider_Name = value; }
        }


        string _enter_Location = string.Empty;
        public string Enter_Location
        {
            get { return _enter_Location; }
            set { _enter_Location = value; }
        }

        string _call_Back_Phone_Number = string.Empty;
        public string Call_Back_Phone_Number
        {
            get { return _call_Back_Phone_Number; }
            set { _call_Back_Phone_Number = value; }
        }


        string _order_Effective_DateTime = string.Empty;
        public string Order_Effective_DateTime
        {
            get { return _order_Effective_DateTime; }
            set { _order_Effective_DateTime = value; }
        }


        string _order_Control_Code_Reason = string.Empty;
        public string Order_Control_Code_Reason
        {
            get { return _order_Control_Code_Reason; }
            set { _order_Control_Code_Reason = value; }
        }


        string _entering_Organization = string.Empty;
        public string Entering_Organization
        {
            get { return _entering_Organization; }
            set { _entering_Organization = value; }
        }

        string _entering_Device = string.Empty;
        public string Entering_Device
        {
            get { return _entering_Device; }
            set { _entering_Device = value; }
        }


        string _action_By = string.Empty;
        public string Action_By
        {
            get { return _action_By; }
            set { _action_By = value; }
        }

        string _advanced_Beneficiary_Notice_Code = string.Empty;
        public string Advanced_Beneficiary_Notice_Code
        {
            get { return _advanced_Beneficiary_Notice_Code; }
            set { _advanced_Beneficiary_Notice_Code = value; }
        }

        string _ordering_Facility_Code = string.Empty;
        public string Ordering_Facility_Code
        {
            get { return _ordering_Facility_Code; }
            set { _ordering_Facility_Code = value; }
        }

        string _ordering_Facility_Name = string.Empty;
        public string Ordering_Facility_Name
        {
            get { return _ordering_Facility_Name; }
            set { _ordering_Facility_Name = value; }
        }
    }
    public class Observation_Request
    {
        public List<OBR> OBR11 = new List<OBR>();
        public Observation Observation = new Observation();


    }
    public class Observation
    {
        public List<OBX> OBX11 = new List<OBX>();
    }
    public class OBR
    {
        string _set_Id_OBR = string.Empty;
        public string Set_Id_OBR
        {
            get { return _set_Id_OBR; }
            set { _set_Id_OBR = value; }
        }


        string _obr_Placer_Order_Number = string.Empty;
        public string OBR_Placer_Order_Number
        {
            get { return _obr_Placer_Order_Number; }
            set { _obr_Placer_Order_Number = value; }
        }

        string _obr_Filler_Order_Number = string.Empty;
        public string OBR_Filler_Order_Number
        {
            get { return _obr_Filler_Order_Number; }
            set { _obr_Filler_Order_Number = value; }
        }


        string _package_Code = string.Empty;
        public string Package_Code
        {
            get { return _package_Code; }
            set { _package_Code = value; }
        }


        string _package_Description = string.Empty;
        public string Package_Description
        {
            get { return _package_Description; }
            set { _package_Description = value; }
        }


        string _test_Code = string.Empty;
        public string Test_Code
        {
            get { return _test_Code; }
            set { _test_Code = value; }
        }

        string _test_Name = string.Empty;
        public string Test_Name
        {
            get { return _test_Name; }
            set { _test_Name = value; }
        }


        string _priority_Code = string.Empty;
        public string Priority_Code
        {
            get { return _priority_Code; }
            set { _priority_Code = value; }
        }

        string _requested_DateTime = string.Empty;
        public string Requested_DateTime
        {
            get { return _requested_DateTime; }
            set { _requested_DateTime = value; }
        }

        string _observation_DateTime = string.Empty;
        public string Observation_DateTime
        {
            get { return _observation_DateTime; }
            set { _observation_DateTime = value; }
        }

        string _observation_End_DateTime = string.Empty;
        public string Observation_End_DateTime
        {
            get { return _observation_End_DateTime; }
            set { _observation_End_DateTime = value; }
        }

        string _specimen_Received_DateTime = string.Empty;
        public string Specimen_Received_DateTime
        {
            get { return _specimen_Received_DateTime; }
            set { _specimen_Received_DateTime = value; }
        }

        string _specimen_Source_Code = string.Empty;
        public string Specimen_Source_Code
        {
            get { return _specimen_Source_Code; }
            set { _specimen_Source_Code = value; }
        }

        string _specimen_Source_Desc = string.Empty;
        public string Specimen_Source_Desc
        {
            get { return _specimen_Source_Desc; }
            set { _specimen_Source_Desc = value; }
        }

        string _obr_Ordering_Provider_ID = string.Empty;
        public string OBR_Ordering_Provider_ID
        {
            get { return _obr_Ordering_Provider_ID; }
            set { _obr_Ordering_Provider_ID = value; }
        }

        string _obr_Ordering_Provider_Name = string.Empty;
        public string OBR_Ordering_Provider_Name
        {
            get { return _obr_Ordering_Provider_Name; }
            set { _obr_Ordering_Provider_Name = value; }
        }


        string _placer_Field1 = string.Empty;
        public string Placer_Field1
        {
            get { return _placer_Field1; }
            set { _placer_Field1 = value; }
        }

        string _placer_Field2 = string.Empty;
        public string Placer_Field2
        {
            get { return _placer_Field2; }
            set { _placer_Field2 = value; }
        }


        string _filler_Field1 = string.Empty;
        public string Filler_Field1
        {
            get { return _filler_Field1; }
            set { _filler_Field1 = value; }
        }

        string _filler_Field2 = string.Empty;
        public string Filler_Field2
        {
            get { return _filler_Field2; }
            set { _filler_Field2 = value; }
        }

        string _status_Change_DateTime = string.Empty;
        public string Status_Change_DateTime
        {
            get { return _status_Change_DateTime; }
            set { _status_Change_DateTime = value; }
        }

        string _charge_To_Practice = string.Empty;
        public string Charge_To_Practice
        {
            get { return _status_Change_DateTime; }
            set { _charge_To_Practice = value; }
        }

        string _diagnostic_Serv_Sect_Code = string.Empty;
        public string Diagnostic_Serv_Sect_Code
        {
            get { return _diagnostic_Serv_Sect_Code; }
            set { _diagnostic_Serv_Sect_Code = value; }
        }

        string _diagnostic_Serv_Sect_Desc = string.Empty;
        public string Diagnostic_Serv_Sect_Desc
        {
            get { return _diagnostic_Serv_Sect_Desc; }
            set { _diagnostic_Serv_Sect_Desc = value; }
        }


        string _parent_Result = string.Empty;
        public string Parent_Result
        {
            get { return _parent_Result; }
            set { _parent_Result = value; }
        }

        string _obr_Quantity_Timing = string.Empty;
        public string OBR_Quantity_Timing
        {
            get { return _obr_Quantity_Timing; }
            set { _obr_Quantity_Timing = value; }
        }

        string _unit_Code = string.Empty;
        public string Unit_Code
        {
            get { return _unit_Code; }
            set { _unit_Code = value; }
        }

        string _cancel_Reason_Code = string.Empty;
        public string Cancel_Reason_Code
        {
            get { return _cancel_Reason_Code; }
            set { _cancel_Reason_Code = value; }
        }

        string _cancel_Reason_Desc = string.Empty;
        public string Cancel_Reason_Desc
        {
            get { return _cancel_Reason_Desc; }
            set { _cancel_Reason_Desc = value; }
        }
    }

    public class OBX
    {
        string _set_id = string.Empty;
        public string SET_ID
        {
            get { return _set_id; }
            set { _set_id = value; }
        }

        string _observation_Value_Type = string.Empty;
        public string Observation_Value_Type
        {
            get { return _observation_Value_Type; }
            set { _observation_Value_Type = value; }
        }

        string _observation_Identifier = string.Empty;
        public string Observation_Identifier
        {
            get { return _observation_Identifier; }
            set { _observation_Identifier = value; }
        }

        string _observation_Value = string.Empty;
        public string Observation_Value
        {
            get { return _observation_Value; }
            set { _observation_Value = value; }
        }

        string _observationResultsStatus = string.Empty;
        public string ObservationResultsStatus
        {
            get { return _observationResultsStatus; }
            set { _observationResultsStatus = value; }
        }

        string _observation_Date_Time = string.Empty;
        public string Observation_Date_Time
        {
            get { return _observation_Date_Time; }
            set { _observation_Date_Time = value; }
        }

        string _units = string.Empty;
        public string Units
        {
            get { return _units; }
            set { _units = value; }
        }

        string _referenceRange = string.Empty;
        public string ReferenceRange
        {
            get { return _referenceRange; }
            set { _referenceRange = value; }
        }

        string _medicalremarks = string.Empty;
        public string MedicalRemarks
        {
            get { return _medicalremarks; }
            set { _medicalremarks = value; }
        }

        string _isAbnormalflag = string.Empty;
        public string IsAbnormalflag
        {
            get { return _isAbnormalflag; }
            set { _isAbnormalflag = value; }
        }
    }
}
