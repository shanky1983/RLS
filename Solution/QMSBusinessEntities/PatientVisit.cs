using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientVisit
	{
		#region Fields

		private long patientVisitId=0;
		private long patientID=0;
		private DateTime visitDate=DateTime.MaxValue;
		private long referOrgID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private int physicianID=0;
		private int conditionId=0;
		private int visitType=0;
		private long outVisitID=0;
		private int visitPurposeID=0;
		private int specialityID=0;
		private string visitNotes=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string visitState=String.Empty;
		private string nurseNotes=String.Empty;
		private string accompaniedBy=String.Empty;
		private long parentVisitId=0;
		private string nextReviewDate=String.Empty;
		private string securedCode=String.Empty;
		private int tokenNumber=0;
		private string admissionSuggested=String.Empty;
		private string physicianName=String.Empty;
		private int priorityID=0;
		private int referingPhysicianID=0;
		private string referingPhysicianName=String.Empty;
		private int hospitalID=0;
		private string hospitalName=String.Empty;
		private string clientName=String.Empty;
		private int collectionCentreID=0;
		private string collectionCentreName=String.Empty;
		private int referingSpecialityID=0;
		private string tPAName=String.Empty;
		private DateTime dischargedDT=DateTime.MaxValue;
		private string iCDCodeStatus=String.Empty;
		private int payerID=0;
		private string externalVisitID=String.Empty;
		private string wardNo=String.Empty;
		private long referVisitID=0;
		private decimal creditLimit=Decimal.Zero;
		private string isDayCare=String.Empty;
		private long episodeId=0;
		private DateTime actual_review_date=DateTime.MaxValue;
		private string versionNo=String.Empty;
		private int roomTypeID=0;
		private string isAllMedical=String.Empty;
		private string referralType=String.Empty;
		private string isSurgeryPatient=String.Empty;
		private string patientHistory=String.Empty;
		private long patientHistoryID=0;
		private long mappingClientID=0;
		private long episodeVisitID=0;
		private long episodeVisitTrackID=0;
		private string consignmentNo=String.Empty;
		private int labVisitType=0;
		private string visitNumber=String.Empty;
		private int patientStatusID=0;
		private string migrated_Patient_Number=String.Empty;
		private string migrated_Visit_Number=String.Empty;
		private string todaysVisitCount=String.Empty;
		private string isMismatchData=String.Empty;
		private string empDeptCode=String.Empty;
		private string todaysVisitNo=String.Empty;
		private DateTime patientArrivalDate=DateTime.MaxValue;
		private string isSTAT=String.Empty;
		private int isDueBill=0;
		private string isIntegration=String.Empty;
		private int bookingID=0;
		private int reasonID=0;
		private long serviceDiscountMappingID=0;
		private int knowledgeOfServiceID=0;
		private byte visitStateMasterID=0x00;
		private long old_PatVstID=0;
		private string isWalkIn=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
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
		/// Gets or sets the VisitDate value.
		/// </summary>
		public DateTime VisitDate
		{
			get { return visitDate; }
			set { visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReferOrgID value.
		/// </summary>
		public long ReferOrgID
		{
			get { return referOrgID; }
			set { referOrgID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public int PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionId value.
		/// </summary>
		public int ConditionId
		{
			get { return conditionId; }
			set { conditionId = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		public int VisitType
		{
			get { return visitType; }
			set { visitType = value; }
		}

		/// <summary>
		/// Gets or sets the OutVisitID value.
		/// </summary>
		public long OutVisitID
		{
			get { return outVisitID; }
			set { outVisitID = value; }
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
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNotes value.
		/// </summary>
		public string VisitNotes
		{
			get { return visitNotes; }
			set { visitNotes = value; }
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
		/// Gets or sets the VisitState value.
		/// </summary>
		public string VisitState
		{
			get { return visitState; }
			set { visitState = value; }
		}

		/// <summary>
		/// Gets or sets the NurseNotes value.
		/// </summary>
		public string NurseNotes
		{
			get { return nurseNotes; }
			set { nurseNotes = value; }
		}

		/// <summary>
		/// Gets or sets the AccompaniedBy value.
		/// </summary>
		public string AccompaniedBy
		{
			get { return accompaniedBy; }
			set { accompaniedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ParentVisitId value.
		/// </summary>
		public long ParentVisitId
		{
			get { return parentVisitId; }
			set { parentVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the NextReviewDate value.
		/// </summary>
		public string NextReviewDate
		{
			get { return nextReviewDate; }
			set { nextReviewDate = value; }
		}

		/// <summary>
		/// Gets or sets the SecuredCode value.
		/// </summary>
		public string SecuredCode
		{
			get { return securedCode; }
			set { securedCode = value; }
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
		/// Gets or sets the AdmissionSuggested value.
		/// </summary>
		public string AdmissionSuggested
		{
			get { return admissionSuggested; }
			set { admissionSuggested = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityID value.
		/// </summary>
		public int PriorityID
		{
			get { return priorityID; }
			set { priorityID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		public int ReferingPhysicianID
		{
			get { return referingPhysicianID; }
			set { referingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		public string ReferingPhysicianName
		{
			get { return referingPhysicianName; }
			set { referingPhysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalID value.
		/// </summary>
		public int HospitalID
		{
			get { return hospitalID; }
			set { hospitalID = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalName value.
		/// </summary>
		public string HospitalName
		{
			get { return hospitalName; }
			set { hospitalName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionCentreID value.
		/// </summary>
		public int CollectionCentreID
		{
			get { return collectionCentreID; }
			set { collectionCentreID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionCentreName value.
		/// </summary>
		public string CollectionCentreName
		{
			get { return collectionCentreName; }
			set { collectionCentreName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingSpecialityID value.
		/// </summary>
		public int ReferingSpecialityID
		{
			get { return referingSpecialityID; }
			set { referingSpecialityID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAName value.
		/// </summary>
		public string TPAName
		{
			get { return tPAName; }
			set { tPAName = value; }
		}

		/// <summary>
		/// Gets or sets the DischargedDT value.
		/// </summary>
		public DateTime DischargedDT
		{
			get { return dischargedDT; }
			set { dischargedDT = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCodeStatus value.
		/// </summary>
		public string ICDCodeStatus
		{
			get { return iCDCodeStatus; }
			set { iCDCodeStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PayerID value.
		/// </summary>
		public int PayerID
		{
			get { return payerID; }
			set { payerID = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitID value.
		/// </summary>
		public string ExternalVisitID
		{
			get { return externalVisitID; }
			set { externalVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the WardNo value.
		/// </summary>
		public string WardNo
		{
			get { return wardNo; }
			set { wardNo = value; }
		}

		/// <summary>
		/// Gets or sets the ReferVisitID value.
		/// </summary>
		public long ReferVisitID
		{
			get { return referVisitID; }
			set { referVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the CreditLimit value.
		/// </summary>
		public decimal CreditLimit
		{
			get { return creditLimit; }
			set { creditLimit = value; }
		}

		/// <summary>
		/// Gets or sets the IsDayCare value.
		/// </summary>
		public string IsDayCare
		{
			get { return isDayCare; }
			set { isDayCare = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeId value.
		/// </summary>
		public long EpisodeId
		{
			get { return episodeId; }
			set { episodeId = value; }
		}

		/// <summary>
		/// Gets or sets the Actual_review_date value.
		/// </summary>
		public DateTime Actual_review_date
		{
			get { return actual_review_date; }
			set { actual_review_date = value; }
		}

		/// <summary>
		/// Gets or sets the VersionNo value.
		/// </summary>
		public string VersionNo
		{
			get { return versionNo; }
			set { versionNo = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		public int RoomTypeID
		{
			get { return roomTypeID; }
			set { roomTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the IsAllMedical value.
		/// </summary>
		public string IsAllMedical
		{
			get { return isAllMedical; }
			set { isAllMedical = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralType value.
		/// </summary>
		public string ReferralType
		{
			get { return referralType; }
			set { referralType = value; }
		}

		/// <summary>
		/// Gets or sets the IsSurgeryPatient value.
		/// </summary>
		public string IsSurgeryPatient
		{
			get { return isSurgeryPatient; }
			set { isSurgeryPatient = value; }
		}

		/// <summary>
		/// Gets or sets the PatientHistory value.
		/// </summary>
		public string PatientHistory
		{
			get { return patientHistory; }
			set { patientHistory = value; }
		}

		/// <summary>
		/// Gets or sets the PatientHistoryID value.
		/// </summary>
		public long PatientHistoryID
		{
			get { return patientHistoryID; }
			set { patientHistoryID = value; }
		}

		/// <summary>
		/// Gets or sets the MappingClientID value.
		/// </summary>
		public long MappingClientID
		{
			get { return mappingClientID; }
			set { mappingClientID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeVisitID value.
		/// </summary>
		public long EpisodeVisitID
		{
			get { return episodeVisitID; }
			set { episodeVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeVisitTrackID value.
		/// </summary>
		public long EpisodeVisitTrackID
		{
			get { return episodeVisitTrackID; }
			set { episodeVisitTrackID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsignmentNo value.
		/// </summary>
		public string ConsignmentNo
		{
			get { return consignmentNo; }
			set { consignmentNo = value; }
		}

		/// <summary>
		/// Gets or sets the LabVisitType value.
		/// </summary>
		public int LabVisitType
		{
			get { return labVisitType; }
			set { labVisitType = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PatientStatusID value.
		/// </summary>
		public int PatientStatusID
		{
			get { return patientStatusID; }
			set { patientStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Patient_Number value.
		/// </summary>
		public string Migrated_Patient_Number
		{
			get { return migrated_Patient_Number; }
			set { migrated_Patient_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Visit_Number value.
		/// </summary>
		public string Migrated_Visit_Number
		{
			get { return migrated_Visit_Number; }
			set { migrated_Visit_Number = value; }
		}

		/// <summary>
		/// Gets or sets the TodaysVisitCount value.
		/// </summary>
		public string TodaysVisitCount
		{
			get { return todaysVisitCount; }
			set { todaysVisitCount = value; }
		}

		/// <summary>
		/// Gets or sets the IsMismatchData value.
		/// </summary>
		public string IsMismatchData
		{
			get { return isMismatchData; }
			set { isMismatchData = value; }
		}

		/// <summary>
		/// Gets or sets the EmpDeptCode value.
		/// </summary>
		public string EmpDeptCode
		{
			get { return empDeptCode; }
			set { empDeptCode = value; }
		}

		/// <summary>
		/// Gets or sets the TodaysVisitNo value.
		/// </summary>
		public string TodaysVisitNo
		{
			get { return todaysVisitNo; }
			set { todaysVisitNo = value; }
		}

		/// <summary>
		/// Gets or sets the PatientArrivalDate value.
		/// </summary>
		public DateTime PatientArrivalDate
		{
			get { return patientArrivalDate; }
			set { patientArrivalDate = value; }
		}

		/// <summary>
		/// Gets or sets the IsSTAT value.
		/// </summary>
		public string IsSTAT
		{
			get { return isSTAT; }
			set { isSTAT = value; }
		}

		/// <summary>
		/// Gets or sets the IsDueBill value.
		/// </summary>
		public int IsDueBill
		{
			get { return isDueBill; }
			set { isDueBill = value; }
		}

		/// <summary>
		/// Gets or sets the IsIntegration value.
		/// </summary>
		public string IsIntegration
		{
			get { return isIntegration; }
			set { isIntegration = value; }
		}

		/// <summary>
		/// Gets or sets the BookingID value.
		/// </summary>
		public int BookingID
		{
			get { return bookingID; }
			set { bookingID = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonID value.
		/// </summary>
		public int ReasonID
		{
			get { return reasonID; }
			set { reasonID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceDiscountMappingID value.
		/// </summary>
		public long ServiceDiscountMappingID
		{
			get { return serviceDiscountMappingID; }
			set { serviceDiscountMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the KnowledgeOfServiceID value.
		/// </summary>
		public int KnowledgeOfServiceID
		{
			get { return knowledgeOfServiceID; }
			set { knowledgeOfServiceID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitStateMasterID value.
		/// </summary>
		public byte VisitStateMasterID
		{
			get { return visitStateMasterID; }
			set { visitStateMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the Old_PatVstID value.
		/// </summary>
		public long Old_PatVstID
		{
			get { return old_PatVstID; }
			set { old_PatVstID = value; }
		}

		/// <summary>
		/// Gets or sets the IsWalkIn value.
		/// </summary>
		public string IsWalkIn
		{
			get { return isWalkIn; }
			set { isWalkIn = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeName value.
		/// </summary>
		string _visitpurposename;
		public string VisitPurposeName
		{
			get { return _visitpurposename; }
			set { _visitpurposename = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		string _location;
		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the TitleName value.
		/// </summary>
		string _titlename;
		public string TitleName
		{
			get { return _titlename; }
			set { _titlename = value; }
		}

		/// <summary>
		/// Gets or sets the Service value.
		/// </summary>
		string _service;
		public string Service
		{
			get { return _service; }
			set { _service = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		string _address;
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		string _patientnumber;
		public string PatientNumber
		{
			get { return _patientnumber; }
			set { _patientnumber = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNumber value.
		/// </summary>
		string _phonenumber;
		public string PhoneNumber
		{
			get { return _phonenumber; }
			set { _phonenumber = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityName value.
		/// </summary>
		string _priorityname;
		public string PriorityName
		{
			get { return _priorityname; }
			set { _priorityname = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousDue value.
		/// </summary>
		decimal _previousdue;
		public decimal PreviousDue
		{
			get { return _previousdue; }
			set { _previousdue = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		string _id;
		public string ID
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityName value.
		/// </summary>
		string _specialityname;
		public string SpecialityName
		{
			get { return _specialityname; }
			set { _specialityname = value; }
		}

		/// <summary>
		/// Gets or sets the PatientAge value.
		/// </summary>
		string _patientage;
		public string PatientAge
		{
			get { return _patientage; }
			set { _patientage = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		string _sex;
		public string Sex
		{
			get { return _sex; }
			set { _sex = value; }
		}

		/// <summary>
		/// Gets or sets the Add1 value.
		/// </summary>
		string _add1;
		public string Add1
		{
			get { return _add1; }
			set { _add1 = value; }
		}

		/// <summary>
		/// Gets or sets the Add2 value.
		/// </summary>
		string _add2;
		public string Add2
		{
			get { return _add2; }
			set { _add2 = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		string _city;
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionDate value.
		/// </summary>
		DateTime _admissiondate;
		public DateTime AdmissionDate
		{
			get { return _admissiondate; }
			set { _admissiondate = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		string _complaintname;
		public string ComplaintName
		{
			get { return _complaintname; }
			set { _complaintname = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCode value.
		/// </summary>
		string _icdcode;
		public string ICDCode
		{
			get { return _icdcode; }
			set { _icdcode = value; }
		}

		/// <summary>
		/// Gets or sets the ICDName value.
		/// </summary>
		string _icdname;
		public string ICDName
		{
			get { return _icdname; }
			set { _icdname = value; }
		}

		/// <summary>
		/// Gets or sets the URNO value.
		/// </summary>
		string _urno;
		public string URNO
		{
			get { return _urno; }
			set { _urno = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		string _mobilenumber;
		public string MobileNumber
		{
			get { return _mobilenumber; }
			set { _mobilenumber = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicain value.
		/// </summary>
		string _performingphysicain;
		public string PerformingPhysicain
		{
			get { return _performingphysicain; }
			set { _performingphysicain = value; }
		}

		/// <summary>
		/// Gets or sets the Investigation value.
		/// </summary>
		string _investigation;
		public string Investigation
		{
			get { return _investigation; }
			set { _investigation = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		string _status;
		public string Status
		{
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		decimal _discount;
		public decimal Discount
		{
			get { return _discount; }
			set { _discount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountType value.
		/// </summary>
		String _discounttype;
		public String DiscountType
		{
			get { return _discounttype; }
			set { _discounttype = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		decimal _preauthamount;
		public decimal PreAuthAmount
		{
			get { return _preauthamount; }
			set { _preauthamount = value; }
		}

		/// <summary>
		/// Gets or sets the URNofId value.
		/// </summary>
		long _urnofid;
		public long URNofId
		{
			get { return _urnofid; }
			set { _urnofid = value; }
		}

		/// <summary>
		/// Gets or sets the URNTypeId value.
		/// </summary>
		long _urntypeid;
		public long URNTypeId
		{
			get { return _urntypeid; }
			set { _urntypeid = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		string _age;
		public string Age
		{
			get { return _age; }
			set { _age = value; }
		}

		/// <summary>
		/// Gets or sets the CopaymentPercent value.
		/// </summary>
		decimal _copaymentpercent;
		public decimal CopaymentPercent
		{
			get { return _copaymentpercent; }
			set { _copaymentpercent = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationName value.
		/// </summary>
		String _organizationname;
		public String OrganizationName
		{
			get { return _organizationname; }
			set { _organizationname = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentLogic value.
		/// </summary>
		int _copaymentlogic;
		public int CoPaymentLogic
		{
			get { return _copaymentlogic; }
			set { _copaymentlogic = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimLogic value.
		/// </summary>
		long _claimlogic;
		public long ClaimLogic
		{
			get { return _claimlogic; }
			set { _claimlogic = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthApprovalNumber value.
		/// </summary>
		String _preauthapprovalnumber;
		public String PreAuthApprovalNumber
		{
			get { return _preauthapprovalnumber; }
			set { _preauthapprovalnumber = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		String _remarks;
		public String Remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}

		/// <summary>
		/// Gets or sets the TPAAttributes value.
		/// </summary>
		String _tpaattributes;
		public String TPAAttributes
		{
			get { return _tpaattributes; }
			set { _tpaattributes = value; }
		}

		/// <summary>
		/// Gets or sets the EMail value.
		/// </summary>
		String _email;
		public String EMail
		{
			get { return _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Gets or sets the PatientStatus value.
		/// </summary>
		String _patientstatus;
		public String PatientStatus
		{
			get { return _patientstatus; }
			set { _patientstatus = value; }
		}

		/// <summary>
		/// Gets or sets the ClientMappingDetailsID value.
		/// </summary>
		long _clientmappingdetailsid;
		public long ClientMappingDetailsID
		{
			get { return _clientmappingdetailsid; }
			set { _clientmappingdetailsid = value; }
		}

		/// <summary>
		/// Gets or sets the TPAID value.
		/// </summary>
		long _tpaid;
		public long TPAID
		{
			get { return _tpaid; }
			set { _tpaid = value; }
		}

		/// <summary>
		/// Gets or sets the RegistrationRemarks value.
		/// </summary>
		String _registrationremarks;
		public String RegistrationRemarks
		{
			get { return _registrationremarks; }
			set { _registrationremarks = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchType value.
		/// </summary>
		String _dispatchtype;
		public String DispatchType
		{
			get { return _dispatchtype; }
			set { _dispatchtype = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchValue value.
		/// </summary>
		String _dispatchvalue;
		public String DispatchValue
		{
			get { return _dispatchvalue; }
			set { _dispatchvalue = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitCount value.
		/// </summary>
		int _patientvisitcount;
		public int PatientVisitCount
		{
			get { return _patientvisitcount; }
			set { _patientvisitcount = value; }
		}


		#endregion
}
}
