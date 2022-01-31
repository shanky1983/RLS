using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessagePatientIDDetails
	{
		#region Fields

		private long hLMessagePatientIDDetailsID=0;
		private string pIDEvent_Type=String.Empty;
		private string set_ID_PID=String.Empty;
		private string patient_ID=String.Empty;
		private string patient_Identifier_List=String.Empty;
		private string iD_Number=String.Empty;
		private string identifier_Check_Digit=String.Empty;
		private string check_Digit_Scheme=String.Empty;
		private string alteration_Patient_ID_PID=String.Empty;
		private string patient_Name=String.Empty;
		private string pIDFamily_Name=String.Empty;
		private string given_Name=String.Empty;
		private string second_and_further_given_Names_or_Initials_Thereof=String.Empty;
		private string pIDSuffix=String.Empty;
		private string pIDPrefix=String.Empty;
		private string pIDDegree=String.Empty;
		private string mother_Maiden_Name=String.Empty;
		private DateTime date_time_Of_Birth=DateTime.MaxValue;
		private string date_Administrative_Sex=String.Empty;
		private string patient_Alies=String.Empty;
		private string race=String.Empty;
		private string patient_Address=String.Empty;
		private string street_Mailing_Address=String.Empty;
		private string other_Designation=String.Empty;
		private string city=String.Empty;
		private string state_Of_Province=String.Empty;
		private string zip_Or_Postal_Code=String.Empty;
		private string country=String.Empty;
		private string pIDCountry_Code=String.Empty;
		private string phone_Number_home=String.Empty;
		private string hTelephone_Number=String.Empty;
		private string hPhone_Number_Business=String.Empty;
		private string hBTelephone_Number=String.Empty;
		private string telecommunication_use_code=String.Empty;
		private string telecommunication_Equipment_Type=String.Empty;
		private string communication_Address=String.Empty;
		private string phone_Number_Business=String.Empty;
		private string pIDTelephone_Number=String.Empty;
		private string primary_Language=String.Empty;
		private string marital_Status=String.Empty;
		private string religion=String.Empty;
		private string patient_Account_Number=String.Empty;
		private string aCID_Number=String.Empty;
		private string sSN_Number_Patient=String.Empty;
		private string driver_License_Number_Patient=String.Empty;
		private string mother_Identifier=String.Empty;
		private string mID_Number=String.Empty;
		private string ethnic_Group=String.Empty;
		private string eGIdentifier=String.Empty;
		private string birth_Place=String.Empty;
		private string multiple_Birth_Indicator=String.Empty;
		private string birth_Order=String.Empty;
		private string citizenship=String.Empty;
		private string veterans_Military_Status=String.Empty;
		private string nationality=String.Empty;
		private DateTime patient_Death_Date_and_Time=DateTime.MaxValue;
		private string patient_Death_Indicator=String.Empty;
		private string identity_Unknown_Indicator=String.Empty;
		private string identity_reliability_Code=String.Empty;
		private DateTime last_Updated_DateTime=DateTime.MaxValue;
		private string last_Update_Facility=String.Empty;
		private string namespaceID=String.Empty;
		private string species_Code=String.Empty;
		private string breed_Code=String.Empty;
		private string strain=String.Empty;
		private string production_Class_Code=String.Empty;
		private string tribal_Citizenship=String.Empty;
		private string pIDIdentifier=String.Empty;
		private string ward_Code=String.Empty;
		private long hLMessageID=0;
		private long orgID=0;
		private long locationID=0;
		private string hLMessagePatientIDContent=String.Empty;
		private string pIDAssigning_Authority=String.Empty;
		private string pIDIdentifier_Type_Code=String.Empty;
		private string hTelecommunication_use_code=String.Empty;
		private string hTelecommunication_Equipment_Type=String.Empty;
		private string hCommunication_Address=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessagePatientIDDetailsID value.
		/// </summary>
		public long HLMessagePatientIDDetailsID
		{
			get { return hLMessagePatientIDDetailsID; }
			set { hLMessagePatientIDDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the PIDEvent_Type value.
		/// </summary>
		public string PIDEvent_Type
		{
			get { return pIDEvent_Type; }
			set { pIDEvent_Type = value; }
		}

		/// <summary>
		/// Gets or sets the Set_ID_PID value.
		/// </summary>
		public string Set_ID_PID
		{
			get { return set_ID_PID; }
			set { set_ID_PID = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_ID value.
		/// </summary>
		public string Patient_ID
		{
			get { return patient_ID; }
			set { patient_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Identifier_List value.
		/// </summary>
		public string Patient_Identifier_List
		{
			get { return patient_Identifier_List; }
			set { patient_Identifier_List = value; }
		}

		/// <summary>
		/// Gets or sets the ID_Number value.
		/// </summary>
		public string ID_Number
		{
			get { return iD_Number; }
			set { iD_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Identifier_Check_Digit value.
		/// </summary>
		public string Identifier_Check_Digit
		{
			get { return identifier_Check_Digit; }
			set { identifier_Check_Digit = value; }
		}

		/// <summary>
		/// Gets or sets the Check_Digit_Scheme value.
		/// </summary>
		public string Check_Digit_Scheme
		{
			get { return check_Digit_Scheme; }
			set { check_Digit_Scheme = value; }
		}

		/// <summary>
		/// Gets or sets the Alteration_Patient_ID_PID value.
		/// </summary>
		public string Alteration_Patient_ID_PID
		{
			get { return alteration_Patient_ID_PID; }
			set { alteration_Patient_ID_PID = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Name value.
		/// </summary>
		public string Patient_Name
		{
			get { return patient_Name; }
			set { patient_Name = value; }
		}

		/// <summary>
		/// Gets or sets the PIDFamily_Name value.
		/// </summary>
		public string PIDFamily_Name
		{
			get { return pIDFamily_Name; }
			set { pIDFamily_Name = value; }
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
		/// Gets or sets the Second_and_further_given_Names_or_Initials_Thereof value.
		/// </summary>
		public string Second_and_further_given_Names_or_Initials_Thereof
		{
			get { return second_and_further_given_Names_or_Initials_Thereof; }
			set { second_and_further_given_Names_or_Initials_Thereof = value; }
		}

		/// <summary>
		/// Gets or sets the PIDSuffix value.
		/// </summary>
		public string PIDSuffix
		{
			get { return pIDSuffix; }
			set { pIDSuffix = value; }
		}

		/// <summary>
		/// Gets or sets the PIDPrefix value.
		/// </summary>
		public string PIDPrefix
		{
			get { return pIDPrefix; }
			set { pIDPrefix = value; }
		}

		/// <summary>
		/// Gets or sets the PIDDegree value.
		/// </summary>
		public string PIDDegree
		{
			get { return pIDDegree; }
			set { pIDDegree = value; }
		}

		/// <summary>
		/// Gets or sets the Mother_Maiden_Name value.
		/// </summary>
		public string Mother_Maiden_Name
		{
			get { return mother_Maiden_Name; }
			set { mother_Maiden_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Date_time_Of_Birth value.
		/// </summary>
		public DateTime Date_time_Of_Birth
		{
			get { return date_time_Of_Birth; }
			set { date_time_Of_Birth = value; }
		}

		/// <summary>
		/// Gets or sets the Date_Administrative_Sex value.
		/// </summary>
		public string Date_Administrative_Sex
		{
			get { return date_Administrative_Sex; }
			set { date_Administrative_Sex = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Alies value.
		/// </summary>
		public string Patient_Alies
		{
			get { return patient_Alies; }
			set { patient_Alies = value; }
		}

		/// <summary>
		/// Gets or sets the Race value.
		/// </summary>
		public string Race
		{
			get { return race; }
			set { race = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Address value.
		/// </summary>
		public string Patient_Address
		{
			get { return patient_Address; }
			set { patient_Address = value; }
		}

		/// <summary>
		/// Gets or sets the Street_Mailing_Address value.
		/// </summary>
		public string Street_Mailing_Address
		{
			get { return street_Mailing_Address; }
			set { street_Mailing_Address = value; }
		}

		/// <summary>
		/// Gets or sets the Other_Designation value.
		/// </summary>
		public string Other_Designation
		{
			get { return other_Designation; }
			set { other_Designation = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// Gets or sets the State_Of_Province value.
		/// </summary>
		public string State_Of_Province
		{
			get { return state_Of_Province; }
			set { state_Of_Province = value; }
		}

		/// <summary>
		/// Gets or sets the Zip_Or_Postal_Code value.
		/// </summary>
		public string Zip_Or_Postal_Code
		{
			get { return zip_Or_Postal_Code; }
			set { zip_Or_Postal_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Country value.
		/// </summary>
		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		/// <summary>
		/// Gets or sets the PIDCountry_Code value.
		/// </summary>
		public string PIDCountry_Code
		{
			get { return pIDCountry_Code; }
			set { pIDCountry_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Phone_Number_home value.
		/// </summary>
		public string Phone_Number_home
		{
			get { return phone_Number_home; }
			set { phone_Number_home = value; }
		}

		/// <summary>
		/// Gets or sets the HTelephone_Number value.
		/// </summary>
		public string HTelephone_Number
		{
			get { return hTelephone_Number; }
			set { hTelephone_Number = value; }
		}

		/// <summary>
		/// Gets or sets the HPhone_Number_Business value.
		/// </summary>
		public string HPhone_Number_Business
		{
			get { return hPhone_Number_Business; }
			set { hPhone_Number_Business = value; }
		}

		/// <summary>
		/// Gets or sets the HBTelephone_Number value.
		/// </summary>
		public string HBTelephone_Number
		{
			get { return hBTelephone_Number; }
			set { hBTelephone_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Telecommunication_use_code value.
		/// </summary>
		public string Telecommunication_use_code
		{
			get { return telecommunication_use_code; }
			set { telecommunication_use_code = value; }
		}

		/// <summary>
		/// Gets or sets the Telecommunication_Equipment_Type value.
		/// </summary>
		public string Telecommunication_Equipment_Type
		{
			get { return telecommunication_Equipment_Type; }
			set { telecommunication_Equipment_Type = value; }
		}

		/// <summary>
		/// Gets or sets the Communication_Address value.
		/// </summary>
		public string Communication_Address
		{
			get { return communication_Address; }
			set { communication_Address = value; }
		}

		/// <summary>
		/// Gets or sets the Phone_Number_Business value.
		/// </summary>
		public string Phone_Number_Business
		{
			get { return phone_Number_Business; }
			set { phone_Number_Business = value; }
		}

		/// <summary>
		/// Gets or sets the PIDTelephone_Number value.
		/// </summary>
		public string PIDTelephone_Number
		{
			get { return pIDTelephone_Number; }
			set { pIDTelephone_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Primary_Language value.
		/// </summary>
		public string Primary_Language
		{
			get { return primary_Language; }
			set { primary_Language = value; }
		}

		/// <summary>
		/// Gets or sets the Marital_Status value.
		/// </summary>
		public string Marital_Status
		{
			get { return marital_Status; }
			set { marital_Status = value; }
		}

		/// <summary>
		/// Gets or sets the Religion value.
		/// </summary>
		public string Religion
		{
			get { return religion; }
			set { religion = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Account_Number value.
		/// </summary>
		public string Patient_Account_Number
		{
			get { return patient_Account_Number; }
			set { patient_Account_Number = value; }
		}

		/// <summary>
		/// Gets or sets the ACID_Number value.
		/// </summary>
		public string ACID_Number
		{
			get { return aCID_Number; }
			set { aCID_Number = value; }
		}

		/// <summary>
		/// Gets or sets the SSN_Number_Patient value.
		/// </summary>
		public string SSN_Number_Patient
		{
			get { return sSN_Number_Patient; }
			set { sSN_Number_Patient = value; }
		}

		/// <summary>
		/// Gets or sets the Driver_License_Number_Patient value.
		/// </summary>
		public string Driver_License_Number_Patient
		{
			get { return driver_License_Number_Patient; }
			set { driver_License_Number_Patient = value; }
		}

		/// <summary>
		/// Gets or sets the Mother_Identifier value.
		/// </summary>
		public string Mother_Identifier
		{
			get { return mother_Identifier; }
			set { mother_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the MID_Number value.
		/// </summary>
		public string MID_Number
		{
			get { return mID_Number; }
			set { mID_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Ethnic_Group value.
		/// </summary>
		public string Ethnic_Group
		{
			get { return ethnic_Group; }
			set { ethnic_Group = value; }
		}

		/// <summary>
		/// Gets or sets the EGIdentifier value.
		/// </summary>
		public string EGIdentifier
		{
			get { return eGIdentifier; }
			set { eGIdentifier = value; }
		}

		/// <summary>
		/// Gets or sets the Birth_Place value.
		/// </summary>
		public string Birth_Place
		{
			get { return birth_Place; }
			set { birth_Place = value; }
		}

		/// <summary>
		/// Gets or sets the Multiple_Birth_Indicator value.
		/// </summary>
		public string Multiple_Birth_Indicator
		{
			get { return multiple_Birth_Indicator; }
			set { multiple_Birth_Indicator = value; }
		}

		/// <summary>
		/// Gets or sets the Birth_Order value.
		/// </summary>
		public string Birth_Order
		{
			get { return birth_Order; }
			set { birth_Order = value; }
		}

		/// <summary>
		/// Gets or sets the Citizenship value.
		/// </summary>
		public string Citizenship
		{
			get { return citizenship; }
			set { citizenship = value; }
		}

		/// <summary>
		/// Gets or sets the Veterans_Military_Status value.
		/// </summary>
		public string Veterans_Military_Status
		{
			get { return veterans_Military_Status; }
			set { veterans_Military_Status = value; }
		}

		/// <summary>
		/// Gets or sets the Nationality value.
		/// </summary>
		public string Nationality
		{
			get { return nationality; }
			set { nationality = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Death_Date_and_Time value.
		/// </summary>
		public DateTime Patient_Death_Date_and_Time
		{
			get { return patient_Death_Date_and_Time; }
			set { patient_Death_Date_and_Time = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Death_Indicator value.
		/// </summary>
		public string Patient_Death_Indicator
		{
			get { return patient_Death_Indicator; }
			set { patient_Death_Indicator = value; }
		}

		/// <summary>
		/// Gets or sets the Identity_Unknown_Indicator value.
		/// </summary>
		public string Identity_Unknown_Indicator
		{
			get { return identity_Unknown_Indicator; }
			set { identity_Unknown_Indicator = value; }
		}

		/// <summary>
		/// Gets or sets the Identity_reliability_Code value.
		/// </summary>
		public string Identity_reliability_Code
		{
			get { return identity_reliability_Code; }
			set { identity_reliability_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Last_Updated_DateTime value.
		/// </summary>
		public DateTime Last_Updated_DateTime
		{
			get { return last_Updated_DateTime; }
			set { last_Updated_DateTime = value; }
		}

		/// <summary>
		/// Gets or sets the Last_Update_Facility value.
		/// </summary>
		public string Last_Update_Facility
		{
			get { return last_Update_Facility; }
			set { last_Update_Facility = value; }
		}

		/// <summary>
		/// Gets or sets the NamespaceID value.
		/// </summary>
		public string NamespaceID
		{
			get { return namespaceID; }
			set { namespaceID = value; }
		}

		/// <summary>
		/// Gets or sets the Species_Code value.
		/// </summary>
		public string Species_Code
		{
			get { return species_Code; }
			set { species_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Breed_Code value.
		/// </summary>
		public string Breed_Code
		{
			get { return breed_Code; }
			set { breed_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Strain value.
		/// </summary>
		public string Strain
		{
			get { return strain; }
			set { strain = value; }
		}

		/// <summary>
		/// Gets or sets the Production_Class_Code value.
		/// </summary>
		public string Production_Class_Code
		{
			get { return production_Class_Code; }
			set { production_Class_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Tribal_Citizenship value.
		/// </summary>
		public string Tribal_Citizenship
		{
			get { return tribal_Citizenship; }
			set { tribal_Citizenship = value; }
		}

		/// <summary>
		/// Gets or sets the PIDIdentifier value.
		/// </summary>
		public string PIDIdentifier
		{
			get { return pIDIdentifier; }
			set { pIDIdentifier = value; }
		}

		/// <summary>
		/// Gets or sets the Ward_Code value.
		/// </summary>
		public string Ward_Code
		{
			get { return ward_Code; }
			set { ward_Code = value; }
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
		/// Gets or sets the HLMessagePatientIDContent value.
		/// </summary>
		public string HLMessagePatientIDContent
		{
			get { return hLMessagePatientIDContent; }
			set { hLMessagePatientIDContent = value; }
		}

		/// <summary>
		/// Gets or sets the PIDAssigning_Authority value.
		/// </summary>
		public string PIDAssigning_Authority
		{
			get { return pIDAssigning_Authority; }
			set { pIDAssigning_Authority = value; }
		}

		/// <summary>
		/// Gets or sets the PIDIdentifier_Type_Code value.
		/// </summary>
		public string PIDIdentifier_Type_Code
		{
			get { return pIDIdentifier_Type_Code; }
			set { pIDIdentifier_Type_Code = value; }
		}

		/// <summary>
		/// Gets or sets the HTelecommunication_use_code value.
		/// </summary>
		public string HTelecommunication_use_code
		{
			get { return hTelecommunication_use_code; }
			set { hTelecommunication_use_code = value; }
		}

		/// <summary>
		/// Gets or sets the HTelecommunication_Equipment_Type value.
		/// </summary>
		public string HTelecommunication_Equipment_Type
		{
			get { return hTelecommunication_Equipment_Type; }
			set { hTelecommunication_Equipment_Type = value; }
		}

		/// <summary>
		/// Gets or sets the HCommunication_Address value.
		/// </summary>
		public string HCommunication_Address
		{
			get { return hCommunication_Address; }
			set { hCommunication_Address = value; }
		}

		/// <summary>
		/// Gets or sets the MsgControlId value.
		/// </summary>
		private string _msgControlId=String.Empty;
		public string MsgControlId
		{
			get { return  _msgControlId; }
			set { _msgControlId = value; }
		}

		/// <summary>
		/// Gets or sets the MessageType value.
		/// </summary>
		private string _messageType=String.Empty;
		public string MessageType
		{
			get { return  _messageType; }
			set { _messageType = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitID value.
		/// </summary>
		private string _externalVisitID=String.Empty;
		public string ExternalVisitID
		{
			get { return  _externalVisitID; }
			set { _externalVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the Confidential value.
		/// </summary>
		private string _confidential=String.Empty;
		public string Confidential
		{
			get { return  _confidential; }
			set { _confidential = value; }
		}

		/// <summary>
		/// Gets or sets the RegisteredBy value.
		/// </summary>
		private string _registeredBy=String.Empty;
		public string RegisteredBy
		{
			get { return  _registeredBy; }
			set { _registeredBy = value; }
		}


		#endregion
}
}
