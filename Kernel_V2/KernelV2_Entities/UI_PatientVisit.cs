using System;

namespace Attune.KernelV2.Entities
{
    public class UI_PatientVisit
    {
        #region Fields

        private long patientVisitId;
        private long patientID;
        private DateTime visitDate = DateTime.MaxValue;
        private long referOrgID;
        private int orgID;
        private long orgAddressID;
        private int physicianID;
        private int conditionId;
        private int visitType;
        private long outVisitID;
        private int visitPurposeID;
        private int specialityID;
        private string visitNotes = String.Empty;
        private long createdBy;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy;
        private DateTime modifiedAt = DateTime.MaxValue;
        private string visitState = String.Empty;
        private string nurseNotes = String.Empty;
        private string accompaniedBy = String.Empty;
        private long parentVisitId;
        private string nextReviewDate = String.Empty;
        private string securedCode = String.Empty;
        private int tokenNumber;
        private string admissionSuggested = String.Empty;
        private string physicianName = String.Empty;
        private int priorityID;
        private int referingPhysicianID;
        private string referingPhysicianName = String.Empty;
        private int hospitalID;
        private string hospitalName = String.Empty;
        private string clientName = String.Empty;
        private int collectionCentreID;
        private string collectionCentreName = String.Empty;
        private int referingSpecialityID;
        private string tPAName = String.Empty;
        private DateTime dischargedDT = DateTime.MaxValue;
        private string iCDCodeStatus = String.Empty;
        private int payerID;
        private string externalVisitID = String.Empty;
        private string wardNo = String.Empty;
        private long referVisitID;
        private decimal creditLimit = Decimal.Zero;
        private string isDayCare = String.Empty;
        private long episodeId;
        private DateTime actual_review_date = DateTime.MaxValue;
        private string versionNo = String.Empty;
        private int roomTypeID;
        private string isAllMedical = String.Empty;
        private string referralType = String.Empty;
        private string isSurgeryPatient = String.Empty;
        private string patientHistory = String.Empty;
        private long patientHistoryID;
        private long mappingClientID;
        private long episodeVisitID;
        private long episodeVisitTrackID;
        private string consignmentNo = String.Empty;
        private int labVisitType;
        private string visitNumber = String.Empty;
        private int patientStatusID;
        private string migrated_Patient_Number = String.Empty;
        private string migrated_Visit_Number = String.Empty;
        private string todaysVisitCount = String.Empty;
        private string isMismatchData = String.Empty;
        private string empDeptCode = String.Empty;
        private string todaysVisitNo = String.Empty;
        private DateTime patientArrivalDate = DateTime.MaxValue;
        private string isSTAT = String.Empty;
        private int isDueBill;
        private string isIntegration = String.Empty;
        private int bookingID;
        private int reasonID;
        private long serviceDiscountMappingID;
        private int knowledgeOfServiceID;
        private byte visitStateMasterID;
        private long old_PatVstID;
        private string isWalkIn = String.Empty;
        private string isIncomplete = String.Empty;
        private int externalVisitType;
        private string physicianPhoneNo = String.Empty;
        private string refdoctorid = String.Empty;
        private string reportMode = String.Empty;
        private string isConfidential = String.Empty;
        private string histoNumber = String.Empty;

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
        /// Gets or sets the IsIncomplete value.
        /// </summary>
        public string IsIncomplete
        {
            get { return isIncomplete; }
            set { isIncomplete = value; }
        }

        /// <summary>
        /// Gets or sets the ExternalVisitType value.
        /// </summary>
        public int ExternalVisitType
        {
            get { return externalVisitType; }
            set { externalVisitType = value; }
        }

        /// <summary>
        /// Gets or sets the PhysicianPhoneNo value.
        /// </summary>
        public string PhysicianPhoneNo
        {
            get { return physicianPhoneNo; }
            set { physicianPhoneNo = value; }
        }

        /// <summary>
        /// Gets or sets the Refdoctorid value.
        /// </summary>
        public string Refdoctorid
        {
            get { return refdoctorid; }
            set { refdoctorid = value; }
        }

        /// <summary>
        /// Gets or sets the ReportMode value.
        /// </summary>
        public string ReportMode
        {
            get { return reportMode; }
            set { reportMode = value; }
        }

        /// <summary>
        /// Gets or sets the IsConfidential value.
        /// </summary>
        public string IsConfidential
        {
            get { return isConfidential; }
            set { isConfidential = value; }
        }

        /// <summary>
        /// Gets or sets the HistoNumber value.
        /// </summary>
        public string HistoNumber
        {
            get { return histoNumber; }
            set { histoNumber = value; }
        }

        /// <summary>
        /// Gets or sets the VisitPurposeName value.
        /// </summary>
        private string _visitPurposeName = String.Empty;
        public string VisitPurposeName
        {
            get { return _visitPurposeName; }
            set { _visitPurposeName = value; }
        }

        /// <summary>
        /// Gets or sets the Location value.
        /// </summary>
        private string _location = String.Empty;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        private string _name = String.Empty;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the PatientName value.
        /// </summary>
        private string _patientName = String.Empty;
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }

        /// <summary>
        /// Gets or sets the TitleName value.
        /// </summary>
        private string _titleName = String.Empty;
        public string TitleName
        {
            get { return _titleName; }
            set { _titleName = value; }
        }

        /// <summary>
        /// Gets or sets the Service value.
        /// </summary>
        private string _service = String.Empty;
        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }

        /// <summary>
        /// Gets or sets the Address value.
        /// </summary>
        private string _address = String.Empty;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Gets or sets the PatientNumber value.
        /// </summary>
        private string _patientNumber = String.Empty;
        public string PatientNumber
        {
            get { return _patientNumber; }
            set { _patientNumber = value; }
        }

        /// <summary>
        /// Gets or sets the PhoneNumber value.
        /// </summary>
        private string _phoneNumber = String.Empty;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        /// <summary>
        /// Gets or sets the PriorityName value.
        /// </summary>
        private string _priorityName = String.Empty;
        public string PriorityName
        {
            get { return _priorityName; }
            set { _priorityName = value; }
        }

        /// <summary>
        /// Gets or sets the PreviousDue value.
        /// </summary>
        private decimal _previousDue = Decimal.Zero;
        public decimal PreviousDue
        {
            get { return _previousDue; }
            set { _previousDue = value; }
        }

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        private string _iD = String.Empty;
        public string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        /// <summary>
        /// Gets or sets the SpecialityName value.
        /// </summary>
        private string _specialityName = String.Empty;
        public string SpecialityName
        {
            get { return _specialityName; }
            set { _specialityName = value; }
        }

        /// <summary>
        /// Gets or sets the PatientAge value.
        /// </summary>
        private string _patientAge = String.Empty;
        public string PatientAge
        {
            get { return _patientAge; }
            set { _patientAge = value; }
        }

        /// <summary>
        /// Gets or sets the Sex value.
        /// </summary>
        private string _sex = String.Empty;
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// Gets or sets the Add1 value.
        /// </summary>
        private string _add1 = String.Empty;
        public string Add1
        {
            get { return _add1; }
            set { _add1 = value; }
        }

        /// <summary>
        /// Gets or sets the Add2 value.
        /// </summary>
        private string _add2 = String.Empty;
        public string Add2
        {
            get { return _add2; }
            set { _add2 = value; }
        }

        /// <summary>
        /// Gets or sets the City value.
        /// </summary>
        private string _city = String.Empty;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        /// <summary>
        /// Gets or sets the AdmissionDate value.
        /// </summary>
        private DateTime _admissionDate = DateTime.MaxValue;
        public DateTime AdmissionDate
        {
            get { return _admissionDate; }
            set { _admissionDate = value; }
        }

        /// <summary>
        /// Gets or sets the ComplaintName value.
        /// </summary>
        private string _complaintName = String.Empty;
        public string ComplaintName
        {
            get { return _complaintName; }
            set { _complaintName = value; }
        }

        /// <summary>
        /// Gets or sets the ICDCode value.
        /// </summary>
        private string _iCDCode = String.Empty;
        public string ICDCode
        {
            get { return _iCDCode; }
            set { _iCDCode = value; }
        }

        /// <summary>
        /// Gets or sets the ICDName value.
        /// </summary>
        private string _iCDName = String.Empty;
        public string ICDName
        {
            get { return _iCDName; }
            set { _iCDName = value; }
        }

        /// <summary>
        /// Gets or sets the URNO value.
        /// </summary>
        private string _uRNO = String.Empty;
        public string URNO
        {
            get { return _uRNO; }
            set { _uRNO = value; }
        }

        /// <summary>
        /// Gets or sets the MobileNumber value.
        /// </summary>
        private string _mobileNumber = String.Empty;
        public string MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }

        /// <summary>
        /// Gets or sets the PerformingPhysicain value.
        /// </summary>
        private string _performingPhysicain = String.Empty;
        public string PerformingPhysicain
        {
            get { return _performingPhysicain; }
            set { _performingPhysicain = value; }
        }

        /// <summary>
        /// Gets or sets the Investigation value.
        /// </summary>
        private string _investigation = String.Empty;
        public string Investigation
        {
            get { return _investigation; }
            set { _investigation = value; }
        }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        private string _status = String.Empty;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Gets or sets the Discount value.
        /// </summary>
        private decimal _discount = Decimal.Zero;
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        /// <summary>
        /// Gets or sets the DiscountType value.
        /// </summary>
        private String _discountType = String.Empty;
        public String DiscountType
        {
            get { return _discountType; }
            set { _discountType = value; }
        }

        /// <summary>
        /// Gets or sets the PreAuthAmount value.
        /// </summary>
        private decimal _preAuthAmount = Decimal.Zero;
        public decimal PreAuthAmount
        {
            get { return _preAuthAmount; }
            set { _preAuthAmount = value; }
        }

        /// <summary>
        /// Gets or sets the URNofId value.
        /// </summary>
        private long _uRNofId;
        public long URNofId
        {
            get { return _uRNofId; }
            set { _uRNofId = value; }
        }

        /// <summary>
        /// Gets or sets the URNTypeId value.
        /// </summary>
        private long _uRNTypeId;
        public long URNTypeId
        {
            get { return _uRNTypeId; }
            set { _uRNTypeId = value; }
        }

        /// <summary>
        /// Gets or sets the Age value.
        /// </summary>
        private string _age = String.Empty;
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// Gets or sets the CopaymentPercent value.
        /// </summary>
        private decimal _copaymentPercent = Decimal.Zero;
        public decimal CopaymentPercent
        {
            get { return _copaymentPercent; }
            set { _copaymentPercent = value; }
        }

        /// <summary>
        /// Gets or sets the OrganizationName value.
        /// </summary>
        private String _organizationName = String.Empty;
        public String OrganizationName
        {
            get { return _organizationName; }
            set { _organizationName = value; }
        }

        /// <summary>
        /// Gets or sets the CoPaymentLogic value.
        /// </summary>
        private int _coPaymentLogic;
        public int CoPaymentLogic
        {
            get { return _coPaymentLogic; }
            set { _coPaymentLogic = value; }
        }

        /// <summary>
        /// Gets or sets the ClaimLogic value.
        /// </summary>
        private long _claimLogic;
        public long ClaimLogic
        {
            get { return _claimLogic; }
            set { _claimLogic = value; }
        }

        /// <summary>
        /// Gets or sets the PreAuthApprovalNumber value.
        /// </summary>
        private String _preAuthApprovalNumber = String.Empty;
        public String PreAuthApprovalNumber
        {
            get { return _preAuthApprovalNumber; }
            set { _preAuthApprovalNumber = value; }
        }

        /// <summary>
        /// Gets or sets the Remarks value.
        /// </summary>
        private String _remarks = String.Empty;
        public String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>
        /// Gets or sets the TPAAttributes value.
        /// </summary>
        private String _tPAAttributes = String.Empty;
        public String TPAAttributes
        {
            get { return _tPAAttributes; }
            set { _tPAAttributes = value; }
        }

        /// <summary>
        /// Gets or sets the EMail value.
        /// </summary>
        private String _eMail = String.Empty;
        public String EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        /// <summary>
        /// Gets or sets the PatientStatus value.
        /// </summary>
        private String _patientStatus = String.Empty;
        public String PatientStatus
        {
            get { return _patientStatus; }
            set { _patientStatus = value; }
        }

        /// <summary>
        /// Gets or sets the ClientMappingDetailsID value.
        /// </summary>
        private long _clientMappingDetailsID;
        public long ClientMappingDetailsID
        {
            get { return _clientMappingDetailsID; }
            set { _clientMappingDetailsID = value; }
        }

        /// <summary>
        /// Gets or sets the TPAID value.
        /// </summary>
        private long _tPAID;
        public long TPAID
        {
            get { return _tPAID; }
            set { _tPAID = value; }
        }

        /// <summary>
        /// Gets or sets the RegistrationRemarks value.
        /// </summary>
        private String _registrationRemarks = String.Empty;
        public String RegistrationRemarks
        {
            get { return _registrationRemarks; }
            set { _registrationRemarks = value; }
        }

        /// <summary>
        /// Gets or sets the DispatchType value.
        /// </summary>
        private String _dispatchType = String.Empty;
        public String DispatchType
        {
            get { return _dispatchType; }
            set { _dispatchType = value; }
        }

        /// <summary>
        /// Gets or sets the DispatchValue value.
        /// </summary>
        private String _dispatchValue = String.Empty;
        public String DispatchValue
        {
            get { return _dispatchValue; }
            set { _dispatchValue = value; }
        }

        /// <summary>
        /// Gets or sets the EmpDeptName value.
        /// </summary>
        private String _empDeptName = String.Empty;
        public String EmpDeptName
        {
            get { return _empDeptName; }
            set { _empDeptName = value; }
        }

        /// <summary>
        /// Gets or sets the DOB value.
        /// </summary>
        private DateTime _dOB = DateTime.MaxValue;
        public DateTime DOB
        {
            get { return _dOB; }
            set { _dOB = value; }
        }

        /// <summary>
        /// Gets or sets the Add3 value.
        /// </summary>
        private string _add3 = String.Empty;
        public string Add3
        {
            get { return _add3; }
            set { _add3 = value; }
        }

        /// <summary>
        /// Gets or sets the PostalCode value.
        /// </summary>
        private string _postalCode = String.Empty;
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        /// <summary>
        /// Gets or sets the CountryCode value.
        /// </summary>
        private int _countryCode;
        public int CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        /// <summary>
        /// Gets or sets the StateCode value.
        /// </summary>
        private int _stateCode;
        public int StateCode
        {
            get { return _stateCode; }
            set { _stateCode = value; }
        }

        /// <summary>
        /// Gets or sets the CityCode value.
        /// </summary>
        private int _cityCode;
        public int CityCode
        {
            get { return _cityCode; }
            set { _cityCode = value; }
        }

        /// <summary>
        /// Gets or sets the AddLevel1 value.
        /// </summary>
        private int _addLevel1;
        public int AddLevel1
        {
            get { return _addLevel1; }
            set { _addLevel1 = value; }
        }

        /// <summary>
        /// Gets or sets the AddLevel2 value.
        /// </summary>
        private int _addLevel2;
        public int AddLevel2
        {
            get { return _addLevel2; }
            set { _addLevel2 = value; }
        }

        /// <summary>
        /// Gets or sets the RoomName value.
        /// </summary>
        private String _roomName = String.Empty;
        public String RoomName
        {
            get { return _roomName; }
            set { _roomName = value; }
        }

        /// <summary>
        /// Gets or sets the IsCreditBill value.
        /// </summary>
        private String _isCreditBill = String.Empty;
        public String IsCreditBill
        {
            get { return _isCreditBill; }
            set { _isCreditBill = value; }
        }

        /// <summary>
        /// Gets or sets the RelationName value.
        /// </summary>
        private String _relationName = String.Empty;
        public String RelationName
        {
            get { return _relationName; }
            set { _relationName = value; }
        }

        /// <summary>
        /// Gets or sets the RelationshipName value.
        /// </summary>
        private String _relationshipName = String.Empty;
        public String RelationshipName
        {
            get { return _relationshipName; }
            set { _relationshipName = value; }
        }

        /// <summary>
        /// Gets or sets the RelAddress value.
        /// </summary>
        private String _relAddress = String.Empty;
        public String RelAddress
        {
            get { return _relAddress; }
            set { _relAddress = value; }
        }

        /// <summary>
        /// Gets or sets the RelLandlineNo value.
        /// </summary>
        private String _relLandlineNo = String.Empty;
        public String RelLandlineNo
        {
            get { return _relLandlineNo; }
            set { _relLandlineNo = value; }
        }

        /// <summary>
        /// Gets or sets the BookingDescription value.
        /// </summary>
        private String _bookingDescription = String.Empty;
        public String BookingDescription
        {
            get { return _bookingDescription; }
            set { _bookingDescription = value; }
        }

        /// <summary>
        /// Gets or sets the Radiologi value.
        /// </summary>
        private String _radiologi = String.Empty;
        public String Radiologi
        {
            get { return _radiologi; }
            set { _radiologi = value; }
        }

        /// <summary>
        /// Gets or sets the ComplaintStaus value.
        /// </summary>
        private String _complaintStaus = String.Empty;
        public String ComplaintStaus
        {
            get { return _complaintStaus; }
            set { _complaintStaus = value; }
        }

        /// <summary>
        /// Gets or sets the PatientVisitCount value.
        /// </summary>
        private int _patientVisitCount;
        public int PatientVisitCount
        {
            get { return _patientVisitCount; }
            set { _patientVisitCount = value; }
        }

        /// <summary>
        /// Gets or sets the ClientID value.
        /// </summary>
        private long _clientID;
        public long ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }

        /// <summary>
        /// Gets or sets the Due value.
        /// </summary>
        private decimal _due = Decimal.Zero;
        public decimal Due
        {
            get { return _due; }
            set { _due = value; }
        }

        /// <summary>
        /// Gets or sets the IsDue value.
        /// </summary>
        private string _isDue = String.Empty;
        public string IsDue
        {
            get { return _isDue; }
            set { _isDue = value; }
        }

        /// <summary>
        /// Gets or sets the FinalBillID value.
        /// </summary>
        private long _finalBillID;
        public long FinalBillID
        {
            get { return _finalBillID; }
            set { _finalBillID = value; }
        }

        /// <summary>
        /// Gets or sets the BillNumber value.
        /// </summary>
        private string _billNumber = String.Empty;
        public string BillNumber
        {
            get { return _billNumber; }
            set { _billNumber = value; }
        }

        /// <summary>
        /// Gets or sets the UserName value.
        /// </summary>
        private string _userName = String.Empty;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// Gets or sets the Zone value.
        /// </summary>
        private string _zone = String.Empty;
        public string Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        /// <summary>
        /// Gets or sets the ReferenceRangeAge value.
        /// </summary>
        private string _referenceRangeAge = String.Empty;
        public string ReferenceRangeAge
        {
            get { return _referenceRangeAge; }
            set { _referenceRangeAge = value; }
        }

        /// <summary>
        /// Gets or sets the AgeDays value.
        /// </summary>
        private string _ageDays = String.Empty;
        public string AgeDays
        {
            get { return _ageDays; }
            set { _ageDays = value; }
        }

        /// <summary>
        /// Gets or sets the ClientAddress value.
        /// </summary>
        private string _clientAddress = String.Empty;
        public string ClientAddress
        {
            get { return _clientAddress; }
            set { _clientAddress = value; }
        }

        /// <summary>
        /// Gets or sets the CollectedDatetime value.
        /// </summary>
        private DateTime _collectedDatetime = DateTime.MaxValue;
        public DateTime CollectedDatetime
        {
            get { return _collectedDatetime; }
            set { _collectedDatetime = value; }
        }

        /// <summary>
        /// Gets or sets the IsOutDoc value.
        /// </summary>
        private String _isOutDoc = String.Empty;
        public String IsOutDoc
        {
            get { return _isOutDoc; }
            set { _isOutDoc = value; }
        }

        /// <summary>
        /// Gets or sets the SpeciesName value.
        /// </summary>
        private String _speciesName = String.Empty;
        public String SpeciesName
        {
            get { return _speciesName; }
            set { _speciesName = value; }
        }


        #endregion
    }

    public class UI_PatientVisitDetails
    {        
        public string AccompaniedBy { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Age { get; set; }
        public decimal AmountReceived { get; set; }
        public string City { get; set; }
        public int ClientID { get; set; }
        public string ComplaintDesc { get; set; }
        public int ComplaintId { get; set; }
        public string ComplaintName { get; set; }
        public int ConditionId { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public long DeptID { get; set; }
        public decimal DueAmount { get; set; }
        public long EmergencyPatientTrackerID { get; set; }
        public long EmergencySeverityOrgMappingID { get; set; }
        public string ExternalVisitID { get; set; }
        public string History { get; set; }
        public long ID { get; set; }
        public int ID1 { get; set; }
        public long ID2 { get; set; }
        public string Labno { get; set; }
        public string MobileNumber { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long ModifiedBy { get; set; }
        public decimal NetAmount { get; set; }
        public string NextReviewDate { get; set; }
        public string NurseNotes { get; set; }
        public long OrgID { get; set; }
        public long OutVisitID { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
        public string Param5 { get; set; }
        public string Param6 { get; set; }
        public long PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientNumber { get; set; }
        public string PatientStatus { get; set; }
        public long PatientVisitID { get; set; }
        public long PatientVisitId { get; set; }
        public string PatientVisitType { get; set; }
        public int PhysicianID { get; set; }
        public string PhysicianName { get; set; }
        public long RateID { get; set; }
        public int ReferingPhysicianID { get; set; }
        public string ReLandline { get; set; }
        public string Remarks { get; set; }
        public string ReMobilenumber { get; set; }
        public DateTime ReportTat { get; set; }
        public string ResultEntryType { get; set; }
        public string Sex { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public int TATStatus { get; set; }
        public int TitleCode { get; set; }
        public string TitleName { get; set; }
        public long TokenNumber { get; set; }
        public string UID { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitNotes { get; set; }
        public string VisitNumber { get; set; }
        public byte VisitPurposeID { get; set; }
        public string VisitState { get; set; }
        public int VisitType { get; set; }
    }
}
