using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessages
	{
		#region Fields

		private int hLMessagesID=0;
		private string msgControlId=String.Empty;
		private string parentControlId=String.Empty;
		private int orgId=0;
		private string msgType=String.Empty;
		private string sending_App=String.Empty;
		private string sending_Facility=String.Empty;
		private string rec_App=String.Empty;
		private string rec_Facility=String.Empty;
		private DateTime transferDatetime=DateTime.MaxValue;
		private string msg_Content=String.Empty;
		private string status=String.Empty;
		private string errorList=String.Empty;
		private long patientVisitID=0;
		private string pdf_Generation=String.Empty;
		private DateTime pdf_Generation_Date=DateTime.MaxValue;
		private string roundBPdf_Generation=String.Empty;
		private DateTime roundBPdf_Generation_Date=DateTime.MaxValue;
		private DateTime futuredate=DateTime.MaxValue;
		private string patientIdentifier=String.Empty;
		private string statusOfInbound=String.Empty;
		private string xMLERROR=String.Empty;
		private string orderedId=String.Empty;
		private string controlType=String.Empty;
		private DateTime taskDate=DateTime.MaxValue;
		private DateTime pickedAt=DateTime.MaxValue;
		private DateTime completedAt=DateTime.MaxValue;
		private string messageStatus=String.Empty;
		private string errorDescription=String.Empty;
		private string hL7Message=String.Empty;
		private DateTime fileCreatedAt=DateTime.MaxValue;
		private DateTime fileModifiedAt=DateTime.MaxValue;
		private long parentHLMessagesID=0;
		private string fileNames=String.Empty;
		private string exPatientID=String.Empty;
		private string exVisitID=String.Empty;
		private long locationID=0;
		private string locations=String.Empty;
		private string locationSource=String.Empty;
		private bool isVisitDeflag=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessagesID value.
		/// </summary>
		public int HLMessagesID
		{
			get { return hLMessagesID; }
			set { hLMessagesID = value; }
		}

		/// <summary>
		/// Gets or sets the MsgControlId value.
		/// </summary>
		public string MsgControlId
		{
			get { return msgControlId; }
			set { msgControlId = value; }
		}

		/// <summary>
		/// Gets or sets the ParentControlId value.
		/// </summary>
		public string ParentControlId
		{
			get { return parentControlId; }
			set { parentControlId = value; }
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
		/// Gets or sets the MsgType value.
		/// </summary>
		public string MsgType
		{
			get { return msgType; }
			set { msgType = value; }
		}

		/// <summary>
		/// Gets or sets the Sending_App value.
		/// </summary>
		public string Sending_App
		{
			get { return sending_App; }
			set { sending_App = value; }
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
		/// Gets or sets the Rec_App value.
		/// </summary>
		public string Rec_App
		{
			get { return rec_App; }
			set { rec_App = value; }
		}

		/// <summary>
		/// Gets or sets the Rec_Facility value.
		/// </summary>
		public string Rec_Facility
		{
			get { return rec_Facility; }
			set { rec_Facility = value; }
		}

		/// <summary>
		/// Gets or sets the TransferDatetime value.
		/// </summary>
		public DateTime TransferDatetime
		{
			get { return transferDatetime; }
			set { transferDatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Msg_Content value.
		/// </summary>
		public string Msg_Content
		{
			get { return msg_Content; }
			set { msg_Content = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorList value.
		/// </summary>
		public string ErrorList
		{
			get { return errorList; }
			set { errorList = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the Pdf_Generation value.
		/// </summary>
		public string Pdf_Generation
		{
			get { return pdf_Generation; }
			set { pdf_Generation = value; }
		}

		/// <summary>
		/// Gets or sets the Pdf_Generation_Date value.
		/// </summary>
		public DateTime Pdf_Generation_Date
		{
			get { return pdf_Generation_Date; }
			set { pdf_Generation_Date = value; }
		}

		/// <summary>
		/// Gets or sets the RoundBPdf_Generation value.
		/// </summary>
		public string RoundBPdf_Generation
		{
			get { return roundBPdf_Generation; }
			set { roundBPdf_Generation = value; }
		}

		/// <summary>
		/// Gets or sets the RoundBPdf_Generation_Date value.
		/// </summary>
		public DateTime RoundBPdf_Generation_Date
		{
			get { return roundBPdf_Generation_Date; }
			set { roundBPdf_Generation_Date = value; }
		}

		/// <summary>
		/// Gets or sets the Futuredate value.
		/// </summary>
		public DateTime Futuredate
		{
			get { return futuredate; }
			set { futuredate = value; }
		}

		/// <summary>
		/// Gets or sets the PatientIdentifier value.
		/// </summary>
		public string PatientIdentifier
		{
			get { return patientIdentifier; }
			set { patientIdentifier = value; }
		}

		/// <summary>
		/// Gets or sets the StatusOfInbound value.
		/// </summary>
		public string StatusOfInbound
		{
			get { return statusOfInbound; }
			set { statusOfInbound = value; }
		}

		/// <summary>
		/// Gets or sets the XMLERROR value.
		/// </summary>
		public string XMLERROR
		{
			get { return xMLERROR; }
			set { xMLERROR = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedId value.
		/// </summary>
		public string OrderedId
		{
			get { return orderedId; }
			set { orderedId = value; }
		}

		/// <summary>
		/// Gets or sets the ControlType value.
		/// </summary>
		public string ControlType
		{
			get { return controlType; }
			set { controlType = value; }
		}

		/// <summary>
		/// Gets or sets the TaskDate value.
		/// </summary>
		public DateTime TaskDate
		{
			get { return taskDate; }
			set { taskDate = value; }
		}

		/// <summary>
		/// Gets or sets the PickedAt value.
		/// </summary>
		public DateTime PickedAt
		{
			get { return pickedAt; }
			set { pickedAt = value; }
		}

		/// <summary>
		/// Gets or sets the CompletedAt value.
		/// </summary>
		public DateTime CompletedAt
		{
			get { return completedAt; }
			set { completedAt = value; }
		}

		/// <summary>
		/// Gets or sets the MessageStatus value.
		/// </summary>
		public string MessageStatus
		{
			get { return messageStatus; }
			set { messageStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorDescription value.
		/// </summary>
		public string ErrorDescription
		{
			get { return errorDescription; }
			set { errorDescription = value; }
		}

		/// <summary>
		/// Gets or sets the HL7Message value.
		/// </summary>
		public string HL7Message
		{
			get { return hL7Message; }
			set { hL7Message = value; }
		}

		/// <summary>
		/// Gets or sets the FileCreatedAt value.
		/// </summary>
		public DateTime FileCreatedAt
		{
			get { return fileCreatedAt; }
			set { fileCreatedAt = value; }
		}

		/// <summary>
		/// Gets or sets the FileModifiedAt value.
		/// </summary>
		public DateTime FileModifiedAt
		{
			get { return fileModifiedAt; }
			set { fileModifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ParentHLMessagesID value.
		/// </summary>
		public long ParentHLMessagesID
		{
			get { return parentHLMessagesID; }
			set { parentHLMessagesID = value; }
		}

		/// <summary>
		/// Gets or sets the FileNames value.
		/// </summary>
		public string FileNames
		{
			get { return fileNames; }
			set { fileNames = value; }
		}

		/// <summary>
		/// Gets or sets the ExPatientID value.
		/// </summary>
		public string ExPatientID
		{
			get { return exPatientID; }
			set { exPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the ExVisitID value.
		/// </summary>
		public string ExVisitID
		{
			get { return exVisitID; }
			set { exVisitID = value; }
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
		/// Gets or sets the Locations value.
		/// </summary>
		public string Locations
		{
			get { return locations; }
			set { locations = value; }
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
		/// Gets or sets the IsVisitDeflag value.
		/// </summary>
		public bool IsVisitDeflag
		{
			get { return isVisitDeflag; }
			set { isVisitDeflag = value; }
		}

		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		private string _loginName=String.Empty;
		public string LoginName
		{
			get { return  _loginName; }
			set { _loginName = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		private string _roleName=String.Empty;
		public string RoleName
		{
			get { return  _roleName; }
			set { _roleName = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_ID value.
		/// </summary>
		private string _patient_ID=String.Empty;
		public string Patient_ID
		{
			get { return  _patient_ID; }
			set { _patient_ID = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_fname value.
		/// </summary>
		private string _patient_fname=String.Empty;
		public string Patient_fname
		{
			get { return  _patient_fname; }
			set { _patient_fname = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_DOB value.
		/// </summary>
		private DateTime _patient_DOB=DateTime.MaxValue;
		public DateTime Patient_DOB
		{
			get { return  _patient_DOB; }
			set { _patient_DOB = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Sex value.
		/// </summary>
		private string _patient_Sex=String.Empty;
		public string Patient_Sex
		{
			get { return  _patient_Sex; }
			set { _patient_Sex = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Address value.
		/// </summary>
		private string _patient_Address=String.Empty;
		public string Patient_Address
		{
			get { return  _patient_Address; }
			set { _patient_Address = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_HomePhone value.
		/// </summary>
		private string _patient_HomePhone=String.Empty;
		public string Patient_HomePhone
		{
			get { return  _patient_HomePhone; }
			set { _patient_HomePhone = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Businessphone value.
		/// </summary>
		private string _patient_Businessphone=String.Empty;
		public string Patient_Businessphone
		{
			get { return  _patient_Businessphone; }
			set { _patient_Businessphone = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Country value.
		/// </summary>
		private string _patient_Country=String.Empty;
		public string Patient_Country
		{
			get { return  _patient_Country; }
			set { _patient_Country = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_State value.
		/// </summary>
		private string _patient_State=String.Empty;
		public string Patient_State
		{
			get { return  _patient_State; }
			set { _patient_State = value; }
		}

		/// <summary>
		/// Gets or sets the Placer_Order_Number value.
		/// </summary>
		private string _placer_Order_Number=String.Empty;
		public string Placer_Order_Number
		{
			get { return  _placer_Order_Number; }
			set { _placer_Order_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Observation_Identifier value.
		/// </summary>
		private string _observation_Identifier=String.Empty;
		public string Observation_Identifier
		{
			get { return  _observation_Identifier; }
			set { _observation_Identifier = value; }
		}

		/// <summary>
		/// Gets or sets the TitleName value.
		/// </summary>
		private string _titleName=String.Empty;
		public string TitleName
		{
			get { return  _titleName; }
			set { _titleName = value; }
		}

		/// <summary>
		/// Gets or sets the OrderStatus value.
		/// </summary>
		private string _orderStatus=String.Empty;
		public string OrderStatus
		{
			get { return  _orderStatus; }
			set { _orderStatus = value; }
		}

		/// <summary>
		/// Gets or sets the OrderCreatedby value.
		/// </summary>
		private string _orderCreatedby=String.Empty;
		public string OrderCreatedby
		{
			get { return  _orderCreatedby; }
			set { _orderCreatedby = value; }
		}

		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		private string _groupName=String.Empty;
		public string GroupName
		{
			get { return  _groupName; }
			set { _groupName = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitNumber value.
		/// </summary>
		private string _externalVisitNumber=String.Empty;
		public string ExternalVisitNumber
		{
			get { return  _externalVisitNumber; }
			set { _externalVisitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		private short _countryID=0;
		public short CountryID
		{
			get { return  _countryID; }
			set { _countryID = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		private short _stateID=0;
		public short StateID
		{
			get { return  _stateID; }
			set { _stateID = value; }
		}

		/// <summary>
		/// Gets or sets the Nationality value.
		/// </summary>
		private long _nationality=0;
		public long Nationality
		{
			get { return  _nationality; }
			set { _nationality = value; }
		}

		/// <summary>
		/// Gets or sets the Transaction_Date_Time value.
		/// </summary>
		private DateTime _transaction_Date_Time=DateTime.MaxValue;
		public DateTime Transaction_Date_Time
		{
			get { return  _transaction_Date_Time; }
			set { _transaction_Date_Time = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalPatientNumber value.
		/// </summary>
		private string _externalPatientNumber=String.Empty;
		public string ExternalPatientNumber
		{
			get { return  _externalPatientNumber; }
			set { _externalPatientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the DetailHistory value.
		/// </summary>
		private string _detailHistory=String.Empty;
		public string DetailHistory
		{
			get { return  _detailHistory; }
			set { _detailHistory = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		private string _remarks=String.Empty;
		public string Remarks
		{
			get { return  _remarks; }
			set { _remarks = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		private string _referingPhysicianName=String.Empty;
		public string ReferingPhysicianName
		{
			get { return  _referingPhysicianName; }
			set { _referingPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedHospitalName value.
		/// </summary>
		private string _referedHospitalName=String.Empty;
		public string ReferedHospitalName
		{
			get { return  _referedHospitalName; }
			set { _referedHospitalName = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		private string _email=String.Empty;
		public string Email
		{
			get { return  _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Gets or sets the PinCode value.
		/// </summary>
		private string _pinCode=String.Empty;
		public string PinCode
		{
			get { return  _pinCode; }
			set { _pinCode = value; }
		}

		/// <summary>
		/// Gets or sets the MaritalStatus value.
		/// </summary>
		private string _maritalStatus=String.Empty;
		public string MaritalStatus
		{
			get { return  _maritalStatus; }
			set { _maritalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PriorWardDetails value.
		/// </summary>
		private string _priorWardDetails=String.Empty;
		public string PriorWardDetails
		{
			get { return  _priorWardDetails; }
			set { _priorWardDetails = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitId value.
		/// </summary>
		private string _externalVisitId=String.Empty;
		public string ExternalVisitId
		{
			get { return  _externalVisitId; }
			set { _externalVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the MIGRequestNumber value.
		/// </summary>
		private string _mIGRequestNumber=String.Empty;
		public string MIGRequestNumber
		{
			get { return  _mIGRequestNumber; }
			set { _mIGRequestNumber = value; }
		}

		/// <summary>
		/// Gets or sets the AttendingDoctor value.
		/// </summary>
		private string _attendingDoctor=String.Empty;
		public string AttendingDoctor
		{
			get { return  _attendingDoctor; }
			set { _attendingDoctor = value; }
		}

		/// <summary>
		/// Gets or sets the PriorIdNumber value.
		/// </summary>
		private string _priorIdNumber=String.Empty;
		public string PriorIdNumber
		{
			get { return  _priorIdNumber; }
			set { _priorIdNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_firstname value.
		/// </summary>
		private string _patient_firstname=String.Empty;
		public string Patient_firstname
		{
			get { return  _patient_firstname; }
			set { _patient_firstname = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_lastname value.
		/// </summary>
		private string _patient_lastname=String.Empty;
		public string Patient_lastname
		{
			get { return  _patient_lastname; }
			set { _patient_lastname = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_middlename value.
		/// </summary>
		private string _patient_middlename=String.Empty;
		public string Patient_middlename
		{
			get { return  _patient_middlename; }
			set { _patient_middlename = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedLocation value.
		/// </summary>
		private string _orderedLocation=String.Empty;
		public string OrderedLocation
		{
			get { return  _orderedLocation; }
			set { _orderedLocation = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Confidential value.
		/// </summary>
		private string _patient_Confidential=String.Empty;
		public string Patient_Confidential
		{
			get { return  _patient_Confidential; }
			set { _patient_Confidential = value; }
		}

		/// <summary>
		/// Gets or sets the SpeciesName value.
		/// </summary>
		private string _speciesName=String.Empty;
		public string SpeciesName
		{
			get { return  _speciesName; }
			set { _speciesName = value; }
		}

		/// <summary>
		/// Gets or sets the ResultCopies value.
		/// </summary>
		private string _resultCopies=String.Empty;
		public string ResultCopies
		{
			get { return  _resultCopies; }
			set { _resultCopies = value; }
		}

		/// <summary>
		/// Gets or sets the TestPriory value.
		/// </summary>
		private string _testPriory=String.Empty;
		public string TestPriory
		{
			get { return  _testPriory; }
			set { _testPriory = value; }
		}

		/// <summary>
		/// Gets or sets the WardDeatils value.
		/// </summary>
		private string _wardDeatils=String.Empty;
		public string WardDeatils
		{
			get { return  _wardDeatils; }
			set { _wardDeatils = value; }
		}

		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		private int _id=0;
		public int Id
		{
			get { return  _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_Name value.
		/// </summary>
		private string _patient_Name=String.Empty;
		public string Patient_Name
		{
			get { return  _patient_Name; }
			set { _patient_Name = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the LocationCode value.
		/// </summary>
		private string _locationCode=String.Empty;
		public string LocationCode
		{
			get { return  _locationCode; }
			set { _locationCode = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingType value.
		/// </summary>
		private string _processingType=String.Empty;
		public string ProcessingType
		{
			get { return  _processingType; }
			set { _processingType = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		private int _orgAddressID=0;
		public int OrgAddressID
		{
			get { return  _orgAddressID; }
			set { _orgAddressID = value; }
		}


		#endregion
}
}
