using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Bookings121
	{
		#region Fields

		private long bookingID=0;
		private long resourceTemplateID=0;
		private DateTime startTime=DateTime.MaxValue;
		private DateTime endTime=DateTime.MaxValue;
		private int tokenNumber=0;
		private string description=String.Empty;
		private string bookingStatus=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long scheduleID=0;
		private string patientNumber=String.Empty;
		private string phoneNumber=String.Empty;
		private string patientName=String.Empty;
		private string cancelRemarks=String.Empty;
		private int orgID=0;
		private int bookingOrgID=0;
		private long referalID=0;
		private int remindCount=0;
		private string tokenID=String.Empty;
		private byte tITLECode=0x00;
		private string sEX=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string age=String.Empty;
		private string landLineNumber=String.Empty;
		private string eMail=String.Empty;
		private int clientID=0;
		private string feeType=String.Empty;
		private string sourceType=String.Empty;
		private string collectionAddress2=String.Empty;
		private long patientID=0;
		private long orgAddressID=0;
		private string collectionAddress=String.Empty;
		private long roleID=0;
		private long userID=0;
		private DateTime collectionTime=DateTime.MaxValue;
		private string city=String.Empty;
		private string billDescription=String.Empty;
		private long patientVisitID=0;
		private int createdOrgID=0;
		private string refPhysicianName=String.Empty;
		private string nRICNumber=String.Empty;
		private string nRICType=String.Empty;
		private string externalPatientNo=String.Empty;
		private string state=String.Empty;
		private string pincode=String.Empty;
		private int stateID=0;
		private long cityID=0;
		private string priority=String.Empty;
		private string comments=String.Empty;
		private long uRNTypeID=0;
		private string uRNO=String.Empty;
		private string dispatchValue=String.Empty;
		private long refPhysicianID=0;
		private string referenceType=String.Empty;
		private int parentID=0;
		private int bookingStatusId=0;
		private int bookingPriority=0;
		private int paymentTypeID=0;
		private int visitPurposeID=0;
		private long groupID=0;
		private string remarks=String.Empty;
		private string altmobilenoone=String.Empty;
		private string altmobilenotwo=String.Empty;
		private long countryID=0;
		private int cityCode=0;
		private int districtCode=0;
		private string postalCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BookingID value.
		/// </summary>
		public long BookingID
		{
			get { return bookingID; }
			set { bookingID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceTemplateID value.
		/// </summary>
		public long ResourceTemplateID
		{
			get { return resourceTemplateID; }
			set { resourceTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the StartTime value.
		/// </summary>
		public DateTime StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		/// <summary>
		/// Gets or sets the EndTime value.
		/// </summary>
		public DateTime EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		/// <summary>
		/// Gets or sets the TokenNumber value.
		/// </summary>
		public int TokenNumber
		{
			get { return tokenNumber; }
			set { tokenNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the BookingStatus value.
		/// </summary>
		public string BookingStatus
		{
			get { return bookingStatus; }
			set { bookingStatus = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduleID value.
		/// </summary>
		public long ScheduleID
		{
			get { return scheduleID; }
			set { scheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		public string PatientNumber
		{
			get { return patientNumber; }
			set { patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNumber value.
		/// </summary>
		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the CancelRemarks value.
		/// </summary>
		public string CancelRemarks
		{
			get { return cancelRemarks; }
			set { cancelRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the BookingOrgID value.
		/// </summary>
		public int BookingOrgID
		{
			get { return bookingOrgID; }
			set { bookingOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferalID value.
		/// </summary>
		public long ReferalID
		{
			get { return referalID; }
			set { referalID = value; }
		}

		/// <summary>
		/// Gets or sets the RemindCount value.
		/// </summary>
		public int RemindCount
		{
			get { return remindCount; }
			set { remindCount = value; }
		}

		/// <summary>
		/// Gets or sets the TokenID value.
		/// </summary>
		public string TokenID
		{
			get { return tokenID; }
			set { tokenID = value; }
		}

		/// <summary>
		/// Gets or sets the TITLECode value.
		/// </summary>
		public byte TITLECode
		{
			get { return tITLECode; }
			set { tITLECode = value; }
		}

		/// <summary>
		/// Gets or sets the SEX value.
		/// </summary>
		public string SEX
		{
			get { return sEX; }
			set { sEX = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public DateTime DOB
		{
			get { return dOB; }
			set { dOB = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		public string LandLineNumber
		{
			get { return landLineNumber; }
			set { landLineNumber = value; }
		}

		/// <summary>
		/// Gets or sets the EMail value.
		/// </summary>
		public string EMail
		{
			get { return eMail; }
			set { eMail = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the SourceType value.
		/// </summary>
		public string SourceType
		{
			get { return sourceType; }
			set { sourceType = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionAddress2 value.
		/// </summary>
		public string CollectionAddress2
		{
			get { return collectionAddress2; }
			set { collectionAddress2 = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionAddress value.
		/// </summary>
		public string CollectionAddress
		{
			get { return collectionAddress; }
			set { collectionAddress = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionTime value.
		/// </summary>
		public DateTime CollectionTime
		{
			get { return collectionTime; }
			set { collectionTime = value; }
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
		/// Gets or sets the BillDescription value.
		/// </summary>
		public string BillDescription
		{
			get { return billDescription; }
			set { billDescription = value; }
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
		/// Gets or sets the CreatedOrgID value.
		/// </summary>
		public int CreatedOrgID
		{
			get { return createdOrgID; }
			set { createdOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhysicianName value.
		/// </summary>
		public string RefPhysicianName
		{
			get { return refPhysicianName; }
			set { refPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the NRICNumber value.
		/// </summary>
		public string NRICNumber
		{
			get { return nRICNumber; }
			set { nRICNumber = value; }
		}

		/// <summary>
		/// Gets or sets the NRICType value.
		/// </summary>
		public string NRICType
		{
			get { return nRICType; }
			set { nRICType = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalPatientNo value.
		/// </summary>
		public string ExternalPatientNo
		{
			get { return externalPatientNo; }
			set { externalPatientNo = value; }
		}

		/// <summary>
		/// Gets or sets the State value.
		/// </summary>
		public string State
		{
			get { return state; }
			set { state = value; }
		}

		/// <summary>
		/// Gets or sets the Pincode value.
		/// </summary>
		public string Pincode
		{
			get { return pincode; }
			set { pincode = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		public int StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}

		/// <summary>
		/// Gets or sets the CityID value.
		/// </summary>
		public long CityID
		{
			get { return cityID; }
			set { cityID = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		public string Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the URNTypeID value.
		/// </summary>
		public long URNTypeID
		{
			get { return uRNTypeID; }
			set { uRNTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the URNO value.
		/// </summary>
		public string URNO
		{
			get { return uRNO; }
			set { uRNO = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchValue value.
		/// </summary>
		public string DispatchValue
		{
			get { return dispatchValue; }
			set { dispatchValue = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhysicianID value.
		/// </summary>
		public long RefPhysicianID
		{
			get { return refPhysicianID; }
			set { refPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the BookingStatusId value.
		/// </summary>
		public int BookingStatusId
		{
			get { return bookingStatusId; }
			set { bookingStatusId = value; }
		}

		/// <summary>
		/// Gets or sets the BookingPriority value.
		/// </summary>
		public int BookingPriority
		{
			get { return bookingPriority; }
			set { bookingPriority = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentTypeID value.
		/// </summary>
		public int PaymentTypeID
		{
			get { return paymentTypeID; }
			set { paymentTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		public int VisitPurposeID
		{
			get { return visitPurposeID; }
			set { visitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public long GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the Altmobilenoone value.
		/// </summary>
		public string Altmobilenoone
		{
			get { return altmobilenoone; }
			set { altmobilenoone = value; }
		}

		/// <summary>
		/// Gets or sets the Altmobilenotwo value.
		/// </summary>
		public string Altmobilenotwo
		{
			get { return altmobilenotwo; }
			set { altmobilenotwo = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		public long CountryID
		{
			get { return countryID; }
			set { countryID = value; }
		}

		/// <summary>
		/// Gets or sets the CityCode value.
		/// </summary>
		public int CityCode
		{
			get { return cityCode; }
			set { cityCode = value; }
		}

		/// <summary>
		/// Gets or sets the DistrictCode value.
		/// </summary>
		public int DistrictCode
		{
			get { return districtCode; }
			set { districtCode = value; }
		}

		/// <summary>
		/// Gets or sets the PostalCode value.
		/// </summary>
		public string PostalCode
		{
			get { return postalCode; }
			set { postalCode = value; }
		}


		#endregion
}
}
