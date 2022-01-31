using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Patient
	{
		#region Fields

		private long patientID=0;
		private string name=String.Empty;
		private string aliasName=String.Empty;
		private string relationName=String.Empty;
		private int orgID=0;
		private string alternateContact=String.Empty;
		private string eMail=String.Empty;
		private byte tITLECode=0x00;
		private string sEX=String.Empty;
		private DateTime registrationDTTM=DateTime.MaxValue;
		private DateTime dOB=DateTime.MaxValue;
		private string oCCUPATION=String.Empty;
		private string martialStatus=String.Empty;
		private string religion=String.Empty;
		private string bloodGroup=String.Empty;
		private string comments=String.Empty;
		private string placeOfBirth=String.Empty;
		private string isConfidential=String.Empty;
		private DateTime deathDTTM=DateTime.MaxValue;
		private string personalIdentification=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string age=String.Empty;
		private string patientNumber=String.Empty;
		private decimal registrationFee=Decimal.Zero;
		private string compressedName=String.Empty;
		private string race=String.Empty;
		private long nationality=0;
		private string uRNO=String.Empty;
		private long loginID=0;
		private long uRNofId=0;
		private long uRNTypeId=0;
		private string smartCardNumber=String.Empty;
		private string smartCardIssued=String.Empty;
		private string versionNo=String.Empty;
		private string fileNo=String.Empty;
		private string pictureName=String.Empty;
		private string previousKnownName=String.Empty;
		private long relationTypeId=0;
		private bool isNotify=false;
		private int notifyType=0;
		private string patientType=String.Empty;
		private string patientStatus=String.Empty;
		private string externalPatientNumber=String.Empty;
		private string registrationType=String.Empty;
		private long parentPatientID=0;
		private string migrated_Patient_Number=String.Empty;
		private int inactiveReason=0;
		private DateTime uRNEXPDate=DateTime.MaxValue;
		private string ageValues=String.Empty;
		private byte unknownFlag=0x00;
		private string hasHealthCard=String.Empty;
		private decimal redeemPoints=Decimal.Zero;
		private decimal redeemValue=Decimal.Zero;
		private decimal creditValue=Decimal.Zero;
		private string eMAID=String.Empty;
		private bool useAdvertisement=false;
		private string patientTypeID=String.Empty;
		private short religionID=0;
		private long nationalityID=0;
		private string firstName=String.Empty;
		private string middleName=String.Empty;
		private string lastName=String.Empty;
		private int speciesID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the AliasName value.
		/// </summary>
		public string AliasName
		{
			get { return aliasName; }
			set { aliasName = value; }
		}

		/// <summary>
		/// Gets or sets the RelationName value.
		/// </summary>
		public string RelationName
		{
			get { return relationName; }
			set { relationName = value; }
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
		/// Gets or sets the AlternateContact value.
		/// </summary>
		public string AlternateContact
		{
			get { return alternateContact; }
			set { alternateContact = value; }
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
		/// Gets or sets the RegistrationDTTM value.
		/// </summary>
		public DateTime RegistrationDTTM
		{
			get { return registrationDTTM; }
			set { registrationDTTM = value; }
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
		/// Gets or sets the OCCUPATION value.
		/// </summary>
		public string OCCUPATION
		{
			get { return oCCUPATION; }
			set { oCCUPATION = value; }
		}

		/// <summary>
		/// Gets or sets the MartialStatus value.
		/// </summary>
		public string MartialStatus
		{
			get { return martialStatus; }
			set { martialStatus = value; }
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
		/// Gets or sets the BloodGroup value.
		/// </summary>
		public string BloodGroup
		{
			get { return bloodGroup; }
			set { bloodGroup = value; }
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
		/// Gets or sets the PlaceOfBirth value.
		/// </summary>
		public string PlaceOfBirth
		{
			get { return placeOfBirth; }
			set { placeOfBirth = value; }
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
		/// Gets or sets the DeathDTTM value.
		/// </summary>
		public DateTime DeathDTTM
		{
			get { return deathDTTM; }
			set { deathDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the PersonalIdentification value.
		/// </summary>
		public string PersonalIdentification
		{
			get { return personalIdentification; }
			set { personalIdentification = value; }
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
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
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
		/// Gets or sets the RegistrationFee value.
		/// </summary>
		public decimal RegistrationFee
		{
			get { return registrationFee; }
			set { registrationFee = value; }
		}

		/// <summary>
		/// Gets or sets the CompressedName value.
		/// </summary>
		public string CompressedName
		{
			get { return compressedName; }
			set { compressedName = value; }
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
		/// Gets or sets the Nationality value.
		/// </summary>
		public long Nationality
		{
			get { return nationality; }
			set { nationality = value; }
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
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the URNofId value.
		/// </summary>
		public long URNofId
		{
			get { return uRNofId; }
			set { uRNofId = value; }
		}

		/// <summary>
		/// Gets or sets the URNTypeId value.
		/// </summary>
		public long URNTypeId
		{
			get { return uRNTypeId; }
			set { uRNTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the SmartCardNumber value.
		/// </summary>
		public string SmartCardNumber
		{
			get { return smartCardNumber; }
			set { smartCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the SmartCardIssued value.
		/// </summary>
		public string SmartCardIssued
		{
			get { return smartCardIssued; }
			set { smartCardIssued = value; }
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
		/// Gets or sets the FileNo value.
		/// </summary>
		public string FileNo
		{
			get { return fileNo; }
			set { fileNo = value; }
		}

		/// <summary>
		/// Gets or sets the PictureName value.
		/// </summary>
		public string PictureName
		{
			get { return pictureName; }
			set { pictureName = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousKnownName value.
		/// </summary>
		public string PreviousKnownName
		{
			get { return previousKnownName; }
			set { previousKnownName = value; }
		}

		/// <summary>
		/// Gets or sets the RelationTypeId value.
		/// </summary>
		public long RelationTypeId
		{
			get { return relationTypeId; }
			set { relationTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the IsNotify value.
		/// </summary>
		public bool IsNotify
		{
			get { return isNotify; }
			set { isNotify = value; }
		}

		/// <summary>
		/// Gets or sets the NotifyType value.
		/// </summary>
		public int NotifyType
		{
			get { return notifyType; }
			set { notifyType = value; }
		}

		/// <summary>
		/// Gets or sets the PatientType value.
		/// </summary>
		public string PatientType
		{
			get { return patientType; }
			set { patientType = value; }
		}

		/// <summary>
		/// Gets or sets the PatientStatus value.
		/// </summary>
		public string PatientStatus
		{
			get { return patientStatus; }
			set { patientStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalPatientNumber value.
		/// </summary>
		public string ExternalPatientNumber
		{
			get { return externalPatientNumber; }
			set { externalPatientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the RegistrationType value.
		/// </summary>
		public string RegistrationType
		{
			get { return registrationType; }
			set { registrationType = value; }
		}

		/// <summary>
		/// Gets or sets the ParentPatientID value.
		/// </summary>
		public long ParentPatientID
		{
			get { return parentPatientID; }
			set { parentPatientID = value; }
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
		/// Gets or sets the InactiveReason value.
		/// </summary>
		public int InactiveReason
		{
			get { return inactiveReason; }
			set { inactiveReason = value; }
		}

		/// <summary>
		/// Gets or sets the URNEXPDate value.
		/// </summary>
		public DateTime URNEXPDate
		{
			get { return uRNEXPDate; }
			set { uRNEXPDate = value; }
		}

		/// <summary>
		/// Gets or sets the AgeValues value.
		/// </summary>
		public string AgeValues
		{
			get { return ageValues; }
			set { ageValues = value; }
		}

		/// <summary>
		/// Gets or sets the UnknownFlag value.
		/// </summary>
		public byte UnknownFlag
		{
			get { return unknownFlag; }
			set { unknownFlag = value; }
		}

		/// <summary>
		/// Gets or sets the HasHealthCard value.
		/// </summary>
		public string HasHealthCard
		{
			get { return hasHealthCard; }
			set { hasHealthCard = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemPoints value.
		/// </summary>
		public decimal RedeemPoints
		{
			get { return redeemPoints; }
			set { redeemPoints = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemValue value.
		/// </summary>
		public decimal RedeemValue
		{
			get { return redeemValue; }
			set { redeemValue = value; }
		}

		/// <summary>
		/// Gets or sets the CreditValue value.
		/// </summary>
		public decimal CreditValue
		{
			get { return creditValue; }
			set { creditValue = value; }
		}

		/// <summary>
		/// Gets or sets the EMAID value.
		/// </summary>
		public string EMAID
		{
			get { return eMAID; }
			set { eMAID = value; }
		}

		/// <summary>
		/// Gets or sets the UseAdvertisement value.
		/// </summary>
		public bool UseAdvertisement
		{
			get { return useAdvertisement; }
			set { useAdvertisement = value; }
		}

		/// <summary>
		/// Gets or sets the PatientTypeID value.
		/// </summary>
		public string PatientTypeID
		{
			get { return patientTypeID; }
			set { patientTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReligionID value.
		/// </summary>
		public short ReligionID
		{
			get { return religionID; }
			set { religionID = value; }
		}

		/// <summary>
		/// Gets or sets the NationalityID value.
		/// </summary>
		public long NationalityID
		{
			get { return nationalityID; }
			set { nationalityID = value; }
		}

		/// <summary>
		/// Gets or sets the FirstName value.
		/// </summary>
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		/// <summary>
		/// Gets or sets the MiddleName value.
		/// </summary>
		public string MiddleName
		{
			get { return middleName; }
			set { middleName = value; }
		}

		/// <summary>
		/// Gets or sets the LastName value.
		/// </summary>
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		/// <summary>
		/// Gets or sets the SpeciesID value.
		/// </summary>
		public int SpeciesID
		{
			get { return speciesID; }
			set { speciesID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientAddress value.
		/// </summary>
		List<PatientAddress> _patientaddress;
		public List<PatientAddress> PatientAddress
		{
			get { return _patientaddress; }
			set { _patientaddress = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		private long _patientVisitID=0;
		public long PatientVisitID
		{
			get { return  _patientVisitID; }
			set { _patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		private DateTime _visitDate=DateTime.MaxValue;
		public DateTime VisitDate
		{
			get { return  _visitDate; }
			set { _visitDate = value; }
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
		/// Gets or sets the Condition value.
		/// </summary>
		private String _condition=String.Empty;
		public String Condition
		{
			get { return  _condition; }
			set { _condition = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		private String _physicianName=String.Empty;
		public String PhysicianName
		{
			get { return  _physicianName; }
			set { _physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the BGColor value.
		/// </summary>
		private String _bGColor=String.Empty;
		public String BGColor
		{
			get { return  _bGColor; }
			set { _bGColor = value; }
		}

		/// <summary>
		/// Gets or sets the PatientAge value.
		/// </summary>
		private string _patientAge=String.Empty;
		public string PatientAge
		{
			get { return  _patientAge; }
			set { _patientAge = value; }
		}

		/// <summary>
		/// Gets or sets the BirthDays value.
		/// </summary>
		private string _birthDays=String.Empty;
		public string BirthDays
		{
			get { return  _birthDays; }
			set { _birthDays = value; }
		}

		/// <summary>
		/// Gets or sets the NextReviewDate value.
		/// </summary>
		private string _nextReviewDate=String.Empty;
		public string NextReviewDate
		{
			get { return  _nextReviewDate; }
			set { _nextReviewDate = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		private string _address=String.Empty;
		public string Address
		{
			get { return  _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		private string _mobileNumber=String.Empty;
		public string MobileNumber
		{
			get { return  _mobileNumber; }
			set { _mobileNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BedDetail value.
		/// </summary>
		private string _bedDetail=String.Empty;
		public string BedDetail
		{
			get { return  _bedDetail; }
			set { _bedDetail = value; }
		}

		/// <summary>
		/// Gets or sets the SecuredCode value.
		/// </summary>
		private string _securedCode=String.Empty;
		public string SecuredCode
		{
			get { return  _securedCode; }
			set { _securedCode = value; }
		}

		/// <summary>
		/// Gets or sets the TokenNumber value.
		/// </summary>
		private int _tokenNumber=0;
		public int TokenNumber
		{
			get { return  _tokenNumber; }
			set { _tokenNumber = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionSuggested value.
		/// </summary>
		private string _admissionSuggested=String.Empty;
		public string AdmissionSuggested
		{
			get { return  _admissionSuggested; }
			set { _admissionSuggested = value; }
		}

		/// <summary>
		/// Gets or sets the Add1 value.
		/// </summary>
		private string _add1=String.Empty;
		public string Add1
		{
			get { return  _add1; }
			set { _add1 = value; }
		}

		/// <summary>
		/// Gets or sets the Add2 value.
		/// </summary>
		private string _add2=String.Empty;
		public string Add2
		{
			get { return  _add2; }
			set { _add2 = value; }
		}

		/// <summary>
		/// Gets or sets the Add3 value.
		/// </summary>
		private string _add3=String.Empty;
		public string Add3
		{
			get { return  _add3; }
			set { _add3 = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		private string _city=String.Empty;
		public string City
		{
			get { return  _city; }
			set { _city = value; }
		}

		/// <summary>
		/// Gets or sets the PurposeOfAdmissionName value.
		/// </summary>
		private string _purposeOfAdmissionName=String.Empty;
		public string PurposeOfAdmissionName
		{
			get { return  _purposeOfAdmissionName; }
			set { _purposeOfAdmissionName = value; }
		}

		/// <summary>
		/// Gets or sets the DueDetails value.
		/// </summary>
		private decimal _dueDetails=Decimal.Zero;
		public decimal DueDetails
		{
			get { return  _dueDetails; }
			set { _dueDetails = value; }
		}

		/// <summary>
		/// Gets or sets the CountryName value.
		/// </summary>
		private string _countryName=String.Empty;
		public string CountryName
		{
			get { return  _countryName; }
			set { _countryName = value; }
		}

		/// <summary>
		/// Gets or sets the StateName value.
		/// </summary>
		private string _stateName=String.Empty;
		public string StateName
		{
			get { return  _stateName; }
			set { _stateName = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		private string _landLineNumber=String.Empty;
		public string LandLineNumber
		{
			get { return  _landLineNumber; }
			set { _landLineNumber = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionDate value.
		/// </summary>
		private DateTime _admissionDate=DateTime.MaxValue;
		public DateTime AdmissionDate
		{
			get { return  _admissionDate; }
			set { _admissionDate = value; }
		}

		/// <summary>
		/// Gets or sets the AccompaniedBy value.
		/// </summary>
		private string _accompaniedBy=String.Empty;
		public string AccompaniedBy
		{
			get { return  _accompaniedBy; }
			set { _accompaniedBy = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipID value.
		/// </summary>
		private string _relationshipID=String.Empty;
		public string RelationshipID
		{
			get { return  _relationshipID; }
			set { _relationshipID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationContactNo value.
		/// </summary>
		private string _relationContactNo=String.Empty;
		public string RelationContactNo
		{
			get { return  _relationContactNo; }
			set { _relationContactNo = value; }
		}

		/// <summary>
		/// Gets or sets the ContactNo value.
		/// </summary>
		private string _contactNo=String.Empty;
		public string ContactNo
		{
			get { return  _contactNo; }
			set { _contactNo = value; }
		}

		/// <summary>
		/// Gets or sets the PrimaryPhysician value.
		/// </summary>
		private string _primaryPhysician=String.Empty;
		public string PrimaryPhysician
		{
			get { return  _primaryPhysician; }
			set { _primaryPhysician = value; }
		}

		/// <summary>
		/// Gets or sets the ConsultingSurgeon value.
		/// </summary>
		private string _consultingSurgeon=String.Empty;
		public string ConsultingSurgeon
		{
			get { return  _consultingSurgeon; }
			set { _consultingSurgeon = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityName value.
		/// </summary>
		private string _specialityName=String.Empty;
		public string SpecialityName
		{
			get { return  _specialityName; }
			set { _specialityName = value; }
		}

		/// <summary>
		/// Gets or sets the KnowledgeOfServiceName value.
		/// </summary>
		private string _knowledgeOfServiceName=String.Empty;
		public string KnowledgeOfServiceName
		{
			get { return  _knowledgeOfServiceName; }
			set { _knowledgeOfServiceName = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceProviderName value.
		/// </summary>
		private string _serviceProviderName=String.Empty;
		public string ServiceProviderName
		{
			get { return  _serviceProviderName; }
			set { _serviceProviderName = value; }
		}

		/// <summary>
		/// Gets or sets the InformationBy value.
		/// </summary>
		private string _informationBy=String.Empty;
		public string InformationBy
		{
			get { return  _informationBy; }
			set { _informationBy = value; }
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
		/// Gets or sets the ReferingSpecialityName value.
		/// </summary>
		private string _referingSpecialityName=String.Empty;
		public string ReferingSpecialityName
		{
			get { return  _referingSpecialityName; }
			set { _referingSpecialityName = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		private string _visitType=String.Empty;
		public string VisitType
		{
			get { return  _visitType; }
			set { _visitType = value; }
		}

		/// <summary>
		/// Gets or sets the TPAName value.
		/// </summary>
		private string _tPAName=String.Empty;
		public string TPAName
		{
			get { return  _tPAName; }
			set { _tPAName = value; }
		}

		/// <summary>
		/// Gets or sets the BillAmount value.
		/// </summary>
		private Decimal _billAmount=Decimal.Zero;
		public Decimal BillAmount
		{
			get { return  _billAmount; }
			set { _billAmount = value; }
		}

		/// <summary>
		/// Gets or sets the VisitState value.
		/// </summary>
		private String _visitState=String.Empty;
		public String VisitState
		{
			get { return  _visitState; }
			set { _visitState = value; }
		}

		/// <summary>
		/// Gets or sets the DischargedDT value.
		/// </summary>
		private DateTime _dischargedDT=DateTime.MaxValue;
		public DateTime DischargedDT
		{
			get { return  _dischargedDT; }
			set { _dischargedDT = value; }
		}

		/// <summary>
		/// Gets or sets the TPAAmount value.
		/// </summary>
		private Decimal _tPAAmount=Decimal.Zero;
		public Decimal TPAAmount
		{
			get { return  _tPAAmount; }
			set { _tPAAmount = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		private long _finalBillID=0;
		public long FinalBillID
		{
			get { return  _finalBillID; }
			set { _finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the IPNumber value.
		/// </summary>
		private string _iPNumber=String.Empty;
		public string IPNumber
		{
			get { return  _iPNumber; }
			set { _iPNumber = value; }
		}

		/// <summary>
		/// Gets or sets the DutyOfficer value.
		/// </summary>
		private string _dutyOfficer=String.Empty;
		public string DutyOfficer
		{
			get { return  _dutyOfficer; }
			set { _dutyOfficer = value; }
		}

		/// <summary>
		/// Gets or sets the TPAID value.
		/// </summary>
		private long _tPAID=0;
		public long TPAID
		{
			get { return  _tPAID; }
			set { _tPAID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAAttributes value.
		/// </summary>
		private string _tPAAttributes=String.Empty;
		public string TPAAttributes
		{
			get { return  _tPAAttributes; }
			set { _tPAAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the BabyName value.
		/// </summary>
		private string _babyName=String.Empty;
		public string BabyName
		{
			get { return  _babyName; }
			set { _babyName = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureType value.
		/// </summary>
		private string _procedureType=String.Empty;
		public string ProcedureType
		{
			get { return  _procedureType; }
			set { _procedureType = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryTypeName value.
		/// </summary>
		private string _deliveryTypeName=String.Empty;
		public string DeliveryTypeName
		{
			get { return  _deliveryTypeName; }
			set { _deliveryTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the Obstretrician value.
		/// </summary>
		private string _obstretrician=String.Empty;
		public string Obstretrician
		{
			get { return  _obstretrician; }
			set { _obstretrician = value; }
		}

		/// <summary>
		/// Gets or sets the PType value.
		/// </summary>
		private int _pType=0;
		public int PType
		{
			get { return  _pType; }
			set { _pType = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettlementDate value.
		/// </summary>
		private DateTime _tPASettlementDate=DateTime.MaxValue;
		public DateTime TPASettlementDate
		{
			get { return  _tPASettlementDate; }
			set { _tPASettlementDate = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		private Decimal _preAuthAmount=Decimal.Zero;
		public Decimal PreAuthAmount
		{
			get { return  _preAuthAmount; }
			set { _preAuthAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RightOff value.
		/// </summary>
		private Decimal _rightOff=Decimal.Zero;
		public Decimal RightOff
		{
			get { return  _rightOff; }
			set { _rightOff = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		private string _isCreditBill=String.Empty;
		public string IsCreditBill
		{
			get { return  _isCreditBill; }
			set { _isCreditBill = value; }
		}

		/// <summary>
		/// Gets or sets the PatientCount value.
		/// </summary>
		private long _patientCount=0;
		public long PatientCount
		{
			get { return  _patientCount; }
			set { _patientCount = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCode value.
		/// </summary>
		private string _iCDCode=String.Empty;
		public string ICDCode
		{
			get { return  _iCDCode; }
			set { _iCDCode = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		private string _complaintName=String.Empty;
		public string ComplaintName
		{
			get { return  _complaintName; }
			set { _complaintName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private int _clientID=0;
		public int ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		private int _rateID=0;
		public int RateID
		{
			get { return  _rateID; }
			set { _rateID = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		private string _typeName=String.Empty;
		public string TypeName
		{
			get { return  _typeName; }
			set { _typeName = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		private int _visitPurposeID=0;
		public int VisitPurposeID
		{
			get { return  _visitPurposeID; }
			set { _visitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the RowNumber value.
		/// </summary>
		private long _rowNumber=0;
		public long RowNumber
		{
			get { return  _rowNumber; }
			set { _rowNumber = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDepositAmount value.
		/// </summary>
		private Decimal _totalDepositAmount=Decimal.Zero;
		public Decimal TotalDepositAmount
		{
			get { return  _totalDepositAmount; }
			set { _totalDepositAmount = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDepositUsed value.
		/// </summary>
		private Decimal _totalDepositUsed=Decimal.Zero;
		public Decimal TotalDepositUsed
		{
			get { return  _totalDepositUsed; }
			set { _totalDepositUsed = value; }
		}

		/// <summary>
		/// Gets or sets the DepositBalance value.
		/// </summary>
		private Decimal _depositBalance=Decimal.Zero;
		public Decimal DepositBalance
		{
			get { return  _depositBalance; }
			set { _depositBalance = value; }
		}

		/// <summary>
		/// Gets or sets the CliamForwardDate value.
		/// </summary>
		private DateTime _cliamForwardDate=DateTime.MaxValue;
		public DateTime CliamForwardDate
		{
			get { return  _cliamForwardDate; }
			set { _cliamForwardDate = value; }
		}

		/// <summary>
		/// Gets or sets the DepositID value.
		/// </summary>
		private long _depositID=0;
		public long DepositID
		{
			get { return  _depositID; }
			set { _depositID = value; }
		}

		/// <summary>
		/// Gets or sets the AmtRefund value.
		/// </summary>
		private Decimal _amtRefund=Decimal.Zero;
		public Decimal AmtRefund
		{
			get { return  _amtRefund; }
			set { _amtRefund = value; }
		}

		/// <summary>
		/// Gets or sets the PatorgName value.
		/// </summary>
		private string _patorgName=String.Empty;
		public string PatorgName
		{
			get { return  _patorgName; }
			set { _patorgName = value; }
		}

		/// <summary>
		/// Gets or sets the OtherOrgflag value.
		/// </summary>
		private string _otherOrgflag=String.Empty;
		public string OtherOrgflag
		{
			get { return  _otherOrgflag; }
			set { _otherOrgflag = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDueAmt value.
		/// </summary>
		private Decimal _totalDueAmt=Decimal.Zero;
		public Decimal TotalDueAmt
		{
			get { return  _totalDueAmt; }
			set { _totalDueAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TDS value.
		/// </summary>
		private Decimal _tDS=Decimal.Zero;
		public Decimal TDS
		{
			get { return  _tDS; }
			set { _tDS = value; }
		}

		/// <summary>
		/// Gets or sets the TPABillAmount value.
		/// </summary>
		private Decimal _tPABillAmount=Decimal.Zero;
		public Decimal TPABillAmount
		{
			get { return  _tPABillAmount; }
			set { _tPABillAmount = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentAmount value.
		/// </summary>
		private Decimal _coPaymentAmount=Decimal.Zero;
		public Decimal CoPaymentAmount
		{
			get { return  _coPaymentAmount; }
			set { _coPaymentAmount = value; }
		}

		/// <summary>
		/// Gets or sets the TPADiscountAmt value.
		/// </summary>
		private Decimal _tPADiscountAmt=Decimal.Zero;
		public Decimal TPADiscountAmt
		{
			get { return  _tPADiscountAmt; }
			set { _tPADiscountAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettledAmt value.
		/// </summary>
		private Decimal _tPASettledAmt=Decimal.Zero;
		public Decimal TPASettledAmt
		{
			get { return  _tPASettledAmt; }
			set { _tPASettledAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPADisallowedAmt value.
		/// </summary>
		private Decimal _tPADisallowedAmt=Decimal.Zero;
		public Decimal TPADisallowedAmt
		{
			get { return  _tPADisallowedAmt; }
			set { _tPADisallowedAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPARemarks value.
		/// </summary>
		private string _tPARemarks=String.Empty;
		public string TPARemarks
		{
			get { return  _tPARemarks; }
			set { _tPARemarks = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverID value.
		/// </summary>
		private long _tPAApproverID=0;
		public long TPAApproverID
		{
			get { return  _tPAApproverID; }
			set { _tPAApproverID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverName value.
		/// </summary>
		private string _tPAApproverName=String.Empty;
		public string TPAApproverName
		{
			get { return  _tPAApproverName; }
			set { _tPAApproverName = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApprovedDate value.
		/// </summary>
		private DateTime _tPAApprovedDate=DateTime.MaxValue;
		public DateTime TPAApprovedDate
		{
			get { return  _tPAApprovedDate; }
			set { _tPAApprovedDate = value; }
		}

		/// <summary>
		/// Gets or sets the GrossAmount value.
		/// </summary>
		private Decimal _grossAmount=Decimal.Zero;
		public Decimal GrossAmount
		{
			get { return  _grossAmount; }
			set { _grossAmount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDiscountAmount value.
		/// </summary>
		private Decimal _orgDiscountAmount=Decimal.Zero;
		public Decimal OrgDiscountAmount
		{
			get { return  _orgDiscountAmount; }
			set { _orgDiscountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmount value.
		/// </summary>
		private Decimal _netAmount=Decimal.Zero;
		public Decimal NetAmount
		{
			get { return  _netAmount; }
			set { _netAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedAmount value.
		/// </summary>
		private Decimal _receivedAmount=Decimal.Zero;
		public Decimal ReceivedAmount
		{
			get { return  _receivedAmount; }
			set { _receivedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffApprover value.
		/// </summary>
		private string _writeOffApprover=String.Empty;
		public string WriteOffApprover
		{
			get { return  _writeOffApprover; }
			set { _writeOffApprover = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentDetails value.
		/// </summary>
		private string _paymentDetails=String.Empty;
		public string PaymentDetails
		{
			get { return  _paymentDetails; }
			set { _paymentDetails = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		private string _billNumber=String.Empty;
		public string BillNumber
		{
			get { return  _billNumber; }
			set { _billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Ageing value.
		/// </summary>
		private string _ageing=String.Empty;
		public string Ageing
		{
			get { return  _ageing; }
			set { _ageing = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceAmount value.
		/// </summary>
		private decimal _advanceAmount=Decimal.Zero;
		public decimal AdvanceAmount
		{
			get { return  _advanceAmount; }
			set { _advanceAmount = value; }
		}

		/// <summary>
		/// Gets or sets the CreditLimit value.
		/// </summary>
		private decimal _creditLimit=Decimal.Zero;
		public decimal CreditLimit
		{
			get { return  _creditLimit; }
			set { _creditLimit = value; }
		}

		/// <summary>
		/// Gets or sets the CreditLimitRemarks value.
		/// </summary>
		private string _creditLimitRemarks=String.Empty;
		public string CreditLimitRemarks
		{
			get { return  _creditLimitRemarks; }
			set { _creditLimitRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the IsSurgeryPatient value.
		/// </summary>
		private string _isSurgeryPatient=String.Empty;
		public string IsSurgeryPatient
		{
			get { return  _isSurgeryPatient; }
			set { _isSurgeryPatient = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigTaxPercent value.
		/// </summary>
		private string _configTaxPercent=String.Empty;
		public string ConfigTaxPercent
		{
			get { return  _configTaxPercent; }
			set { _configTaxPercent = value; }
		}

		/// <summary>
		/// Gets or sets the PayerID value.
		/// </summary>
		private int _payerID=0;
		public int PayerID
		{
			get { return  _payerID; }
			set { _payerID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureDesc value.
		/// </summary>
		private string _procedureDesc=String.Empty;
		public string ProcedureDesc
		{
			get { return  _procedureDesc; }
			set { _procedureDesc = value; }
		}

		/// <summary>
		/// Gets or sets the EmployeeNumber value.
		/// </summary>
		private string _employeeNumber=String.Empty;
		public string EmployeeNumber
		{
			get { return  _employeeNumber; }
			set { _employeeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the NextReview value.
		/// </summary>
		private DateTime _nextReview=DateTime.MaxValue;
		public DateTime NextReview
		{
			get { return  _nextReview; }
			set { _nextReview = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		private long _countryID=0;
		public long CountryID
		{
			get { return  _countryID; }
			set { _countryID = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		private long _stateID=0;
		public long StateID
		{
			get { return  _stateID; }
			set { _stateID = value; }
		}

		/// <summary>
		/// Gets or sets the WardNo value.
		/// </summary>
		private string _wardNo=String.Empty;
		public string WardNo
		{
			get { return  _wardNo; }
			set { _wardNo = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityID value.
		/// </summary>
		private string _priorityID=String.Empty;
		public string PriorityID
		{
			get { return  _priorityID; }
			set { _priorityID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientHistory value.
		/// </summary>
		private string _patientHistory=String.Empty;
		public string PatientHistory
		{
			get { return  _patientHistory; }
			set { _patientHistory = value; }
		}

		/// <summary>
		/// Gets or sets the NeedServiceBill value.
		/// </summary>
		private string _needServiceBill=String.Empty;
		public string NeedServiceBill
		{
			get { return  _needServiceBill; }
			set { _needServiceBill = value; }
		}

		/// <summary>
		/// Gets or sets the IsCorporatetBill value.
		/// </summary>
		private string _isCorporatetBill=String.Empty;
		public string IsCorporatetBill
		{
			get { return  _isCorporatetBill; }
			set { _isCorporatetBill = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedHospitalID value.
		/// </summary>
		private int _referedHospitalID=0;
		public int ReferedHospitalID
		{
			get { return  _referedHospitalID; }
			set { _referedHospitalID = value; }
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
		/// Gets or sets the PostalCode value.
		/// </summary>
		private string _postalCode=String.Empty;
		public string PostalCode
		{
			get { return  _postalCode; }
			set { _postalCode = value; }
		}

		/// <summary>
		/// Gets or sets the RegistrationRemarks value.
		/// </summary>
		private string _registrationRemarks=String.Empty;
		public string RegistrationRemarks
		{
			get { return  _registrationRemarks; }
			set { _registrationRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the PatientIdentifyID value.
		/// </summary>
		private string _patientIdentifyID=String.Empty;
		public string PatientIdentifyID
		{
			get { return  _patientIdentifyID; }
			set { _patientIdentifyID = value; }
		}

		/// <summary>
		/// Gets or sets the AgeValue value.
		/// </summary>
		private int _ageValue=0;
		public int AgeValue
		{
			get { return  _ageValue; }
			set { _ageValue = value; }
		}

		/// <summary>
		/// Gets or sets the AgeUnit value.
		/// </summary>
		private string _ageUnit=String.Empty;
		public string AgeUnit
		{
			get { return  _ageUnit; }
			set { _ageUnit = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeVisitId value.
		/// </summary>
		private long _episodeVisitId=0;
		public long EpisodeVisitId
		{
			get { return  _episodeVisitId; }
			set { _episodeVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the GUID value.
		/// </summary>
		private string _gUID=String.Empty;
		public string GUID
		{
			get { return  _gUID; }
			set { _gUID = value; }
		}

		/// <summary>
		/// Gets or sets the ILocationID value.
		/// </summary>
		private int _iLocationID=0;
		public int ILocationID
		{
			get { return  _iLocationID; }
			set { _iLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the TaskactionID value.
		/// </summary>
		private int _taskactionID=0;
		public int TaskactionID
		{
			get { return  _taskactionID; }
			set { _taskactionID = value; }
		}

		/// <summary>
		/// Gets or sets the VistTypeID value.
		/// </summary>
		private int _vistTypeID=0;
		public int VistTypeID
		{
			get { return  _vistTypeID; }
			set { _vistTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the PStatusID value.
		/// </summary>
		private int _pStatusID=0;
		public int PStatusID
		{
			get { return  _pStatusID; }
			set { _pStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the EmpDeptCode value.
		/// </summary>
		private string _empDeptCode=String.Empty;
		public string EmpDeptCode
		{
			get { return  _empDeptCode; }
			set { _empDeptCode = value; }
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
		/// Gets or sets the DispatchType value.
		/// </summary>
		private string _dispatchType=String.Empty;
		public string DispatchType
		{
			get { return  _dispatchType; }
			set { _dispatchType = value; }
		}

		/// <summary>
		/// Gets or sets the SamplePickupDate value.
		/// </summary>
		private DateTime _samplePickupDate=DateTime.MaxValue;
		public DateTime SamplePickupDate
		{
			get { return  _samplePickupDate; }
			set { _samplePickupDate = value; }
		}

		/// <summary>
		/// Gets or sets the MetaTypeID value.
		/// </summary>
		private string _metaTypeID=String.Empty;
		public string MetaTypeID
		{
			get { return  _metaTypeID; }
			set { _metaTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the MetaValueID value.
		/// </summary>
		private string _metaValueID=String.Empty;
		public string MetaValueID
		{
			get { return  _metaValueID; }
			set { _metaValueID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		private string _orgName=String.Empty;
		public string OrgName
		{
			get { return  _orgName; }
			set { _orgName = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		private long _roleID=0;
		public long RoleID
		{
			get { return  _roleID; }
			set { _roleID = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		private long _userID=0;
		public long UserID
		{
			get { return  _userID; }
			set { _userID = value; }
		}

		/// <summary>
		/// Gets or sets the NewPassword value.
		/// </summary>
		private string _newPassword=String.Empty;
		public string NewPassword
		{
			get { return  _newPassword; }
			set { _newPassword = value; }
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
		/// Gets or sets the Password value.
		/// </summary>
		private string _password=String.Empty;
		public string Password
		{
			get { return  _password; }
			set { _password = value; }
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
		/// Gets or sets the ZoneID value.
		/// </summary>
		private long _zoneID=0;
		public long ZoneID
		{
			get { return  _zoneID; }
			set { _zoneID = value; }
		}

		/// <summary>
		/// Gets or sets the RefDocCode value.
		/// </summary>
		private string _refDocCode=String.Empty;
		public string RefDocCode
		{
			get { return  _refDocCode; }
			set { _refDocCode = value; }
		}

		/// <summary>
		/// Gets or sets the RefDocName value.
		/// </summary>
		private string _refDocName=String.Empty;
		public string RefDocName
		{
			get { return  _refDocName; }
			set { _refDocName = value; }
		}

		/// <summary>
		/// Gets or sets the RefDocEmailId value.
		/// </summary>
		private string _refDocEmailId=String.Empty;
		public string RefDocEmailId
		{
			get { return  _refDocEmailId; }
			set { _refDocEmailId = value; }
		}

		/// <summary>
		/// Gets or sets the RefDocMobile value.
		/// </summary>
		private string _refDocMobile=String.Empty;
		public string RefDocMobile
		{
			get { return  _refDocMobile; }
			set { _refDocMobile = value; }
		}

		/// <summary>
		/// Gets or sets the BillNo value.
		/// </summary>
		private string _billNo=String.Empty;
		public string BillNo
		{
			get { return  _billNo; }
			set { _billNo = value; }
		}

		/// <summary>
		/// Gets or sets the DueAmount value.
		/// </summary>
		private decimal _dueAmount=Decimal.Zero;
		public decimal DueAmount
		{
			get { return  _dueAmount; }
			set { _dueAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientMobile value.
		/// </summary>
		private string _clientMobile=String.Empty;
		public string ClientMobile
		{
			get { return  _clientMobile; }
			set { _clientMobile = value; }
		}

		/// <summary>
		/// Gets or sets the ClientEmailId value.
		/// </summary>
		private string _clientEmailId=String.Empty;
		public string ClientEmailId
		{
			get { return  _clientEmailId; }
			set { _clientEmailId = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		private string _clientCode=String.Empty;
		public string ClientCode
		{
			get { return  _clientCode; }
			set { _clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the RoundNo value.
		/// </summary>
		private string _roundNo=String.Empty;
		public string RoundNo
		{
			get { return  _roundNo; }
			set { _roundNo = value; }
		}

		/// <summary>
		/// Gets or sets the PhleboID value.
		/// </summary>
		private int _phleboID=0;
		public int PhleboID
		{
			get { return  _phleboID; }
			set { _phleboID = value; }
		}

		/// <summary>
		/// Gets or sets the LogisticsID value.
		/// </summary>
		private int _logisticsID=0;
		public int LogisticsID
		{
			get { return  _logisticsID; }
			set { _logisticsID = value; }
		}

		/// <summary>
		/// Gets or sets the ExAutoAuthorization value.
		/// </summary>
		private string _exAutoAuthorization=String.Empty;
		public string ExAutoAuthorization
		{
			get { return  _exAutoAuthorization; }
			set { _exAutoAuthorization = value; }
		}

		/// <summary>
		/// Gets or sets the Priority value.
		/// </summary>
		private int _priority=0;
		public int Priority
		{
			get { return  _priority; }
			set { _priority = value; }
		}

		/// <summary>
		/// Gets or sets the ReportStatus value.
		/// </summary>
		private string _reportStatus=String.Empty;
		public string ReportStatus
		{
			get { return  _reportStatus; }
			set { _reportStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PatientArrivalDate value.
		/// </summary>
		private DateTime _patientArrivalDate=DateTime.MaxValue;
		public DateTime PatientArrivalDate
		{
			get { return  _patientArrivalDate; }
			set { _patientArrivalDate = value; }
		}

		/// <summary>
		/// Gets or sets the PatientAllergies value.
		/// </summary>
		List<PatientAllergies> _patientallergies;
		public List<PatientAllergies> PatientAllergies
		{
			get { return _patientallergies; }
			set { _patientallergies = value; }
		}

		/// <summary>
		/// Gets or sets the KnowledgeOfServiceID value.
		/// </summary>
		private int _knowledgeOfServiceID=0;
		public int KnowledgeOfServiceID
		{
			get { return  _knowledgeOfServiceID; }
			set { _knowledgeOfServiceID = value; }
		}

		/// <summary>
		/// Gets or sets the PrimaryPhysicianID value.
		/// </summary>
		private int _primaryPhysicianID=0;
		public int PrimaryPhysicianID
		{
			get { return  _primaryPhysicianID; }
			set { _primaryPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the DepositType value.
		/// </summary>
		private string _depositType=String.Empty;
		public string DepositType
		{
			get { return  _depositType; }
			set { _depositType = value; }
		}

		/// <summary>
		/// Gets or sets the DepositTypeID value.
		/// </summary>
		private string _depositTypeID=String.Empty;
		public string DepositTypeID
		{
			get { return  _depositTypeID; }
			set { _depositTypeID = value; }
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
		/// Gets or sets the IsSurService value.
		/// </summary>
		private string _isSurService=String.Empty;
		public string IsSurService
		{
			get { return  _isSurService; }
			set { _isSurService = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralType value.
		/// </summary>
		private string _referralType=String.Empty;
		public string ReferralType
		{
			get { return  _referralType; }
			set { _referralType = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurpose value.
		/// </summary>
		private int _visitPurpose=0;
		public int VisitPurpose
		{
			get { return  _visitPurpose; }
			set { _visitPurpose = value; }
		}

		/// <summary>
		/// Gets or sets the VisitSubTypeID value.
		/// </summary>
		private int _visitSubTypeID=0;
		public int VisitSubTypeID
		{
			get { return  _visitSubTypeID; }
			set { _visitSubTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		private int _referingPhysicianID=0;
		public int ReferingPhysicianID
		{
			get { return  _referingPhysicianID; }
			set { _referingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the EligibleRoomTypeID value.
		/// </summary>
		private int _eligibleRoomTypeID=0;
		public int EligibleRoomTypeID
		{
			get { return  _eligibleRoomTypeID; }
			set { _eligibleRoomTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingSpecialityID value.
		/// </summary>
		private int _referingSpecialityID=0;
		public int ReferingSpecialityID
		{
			get { return  _referingSpecialityID; }
			set { _referingSpecialityID = value; }
		}

		/// <summary>
		/// Gets or sets the DateofBirth value.
		/// </summary>
		private String _dateofBirth=String.Empty;
		public String DateofBirth
		{
			get { return  _dateofBirth; }
			set { _dateofBirth = value; }
		}

		/// <summary>
		/// Gets or sets the CountryCode value.
		/// </summary>
		private int _countryCode=0;
		public int CountryCode
		{
			get { return  _countryCode; }
			set { _countryCode = value; }
		}

		/// <summary>
		/// Gets or sets the StateCode value.
		/// </summary>
		private int _stateCode=0;
		public int StateCode
		{
			get { return  _stateCode; }
			set { _stateCode = value; }
		}

		/// <summary>
		/// Gets or sets the CityCode value.
		/// </summary>
		private int _cityCode=0;
		public int CityCode
		{
			get { return  _cityCode; }
			set { _cityCode = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel1 value.
		/// </summary>
		private int _addLevel1=0;
		public int AddLevel1
		{
			get { return  _addLevel1; }
			set { _addLevel1 = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel2 value.
		/// </summary>
		private int _addLevel2=0;
		public int AddLevel2
		{
			get { return  _addLevel2; }
			set { _addLevel2 = value; }
		}

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		private string _rateName=String.Empty;
		public string RateName
		{
			get { return  _rateName; }
			set { _rateName = value; }
		}

		/// <summary>
		/// Gets or sets the Allergies value.
		/// </summary>
		private string _allergies=String.Empty;
		public string Allergies
		{
			get { return  _allergies; }
			set { _allergies = value; }
		}

		/// <summary>
		/// Gets or sets the Designation value.
		/// </summary>
		private string _designation=String.Empty;
		public string Designation
		{
			get { return  _designation; }
			set { _designation = value; }
		}

		/// <summary>
		/// Gets or sets the Corps value.
		/// </summary>
		private string _corps=String.Empty;
		public string Corps
		{
			get { return  _corps; }
			set { _corps = value; }
		}

		/// <summary>
		/// Gets or sets the FieldArea value.
		/// </summary>
		private string _fieldArea=String.Empty;
		public string FieldArea
		{
			get { return  _fieldArea; }
			set { _fieldArea = value; }
		}

		/// <summary>
		/// Gets or sets the Position value.
		/// </summary>
		private string _position=String.Empty;
		public string Position
		{
			get { return  _position; }
			set { _position = value; }
		}

		/// <summary>
		/// Gets or sets the Relationship value.
		/// </summary>
		private string _relationship=String.Empty;
		public string Relationship
		{
			get { return  _relationship; }
			set { _relationship = value; }
		}

		/// <summary>
		/// Gets or sets the EmployeeNo value.
		/// </summary>
		private string _employeeNo=String.Empty;
		public string EmployeeNo
		{
			get { return  _employeeNo; }
			set { _employeeNo = value; }
		}

		/// <summary>
		/// Gets or sets the NationalityText value.
		/// </summary>
		private string _nationalityText=String.Empty;
		public string NationalityText
		{
			get { return  _nationalityText; }
			set { _nationalityText = value; }
		}

		/// <summary>
		/// Gets or sets the AgeText value.
		/// </summary>
		private string _ageText=String.Empty;
		public string AgeText
		{
			get { return  _ageText; }
			set { _ageText = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalInfo value.
		/// </summary>
		private string _additionalInfo=String.Empty;
		public string AdditionalInfo
		{
			get { return  _additionalInfo; }
			set { _additionalInfo = value; }
		}

		/// <summary>
		/// Gets or sets the Title value.
		/// </summary>
		private string _title=String.Empty;
		public string Title
		{
			get { return  _title; }
			set { _title = value; }
		}

		/// <summary>
		/// Gets or sets the FieldArmy value.
		/// </summary>
		private string _fieldArmy=String.Empty;
		public string FieldArmy
		{
			get { return  _fieldArmy; }
			set { _fieldArmy = value; }
		}

		/// <summary>
		/// Gets or sets the InsuranceNumber value.
		/// </summary>
		private string _insuranceNumber=String.Empty;
		public string InsuranceNumber
		{
			get { return  _insuranceNumber; }
			set { _insuranceNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PatientRelationship value.
		/// </summary>
		private string _patientRelationship=String.Empty;
		public string PatientRelationship
		{
			get { return  _patientRelationship; }
			set { _patientRelationship = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipAddress value.
		/// </summary>
		private string _relationshipAddress=String.Empty;
		public string RelationshipAddress
		{
			get { return  _relationshipAddress; }
			set { _relationshipAddress = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipLandlineNo value.
		/// </summary>
		private string _relationshipLandlineNo=String.Empty;
		public string RelationshipLandlineNo
		{
			get { return  _relationshipLandlineNo; }
			set { _relationshipLandlineNo = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipMobileNo value.
		/// </summary>
		private string _relationshipMobileNo=String.Empty;
		public string RelationshipMobileNo
		{
			get { return  _relationshipMobileNo; }
			set { _relationshipMobileNo = value; }
		}

		/// <summary>
		/// Gets or sets the Disease value.
		/// </summary>
		private string _disease=String.Empty;
		public string Disease
		{
			get { return  _disease; }
			set { _disease = value; }
		}

		/// <summary>
		/// Gets or sets the Group value.
		/// </summary>
		private string _group=String.Empty;
		public string Group
		{
			get { return  _group; }
			set { _group = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		private string _visitNumber=String.Empty;
		public string VisitNumber
		{
			get { return  _visitNumber; }
			set { _visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Qualification value.
		/// </summary>
		private string _qualification=String.Empty;
		public string Qualification
		{
			get { return  _qualification; }
			set { _qualification = value; }
		}

		/// <summary>
		/// Gets or sets the Radiologi value.
		/// </summary>
		private string _radiologi=String.Empty;
		public string Radiologi
		{
			get { return  _radiologi; }
			set { _radiologi = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentNoOfSitting value.
		/// </summary>
		private int _currentNoOfSitting=0;
		public int CurrentNoOfSitting
		{
			get { return  _currentNoOfSitting; }
			set { _currentNoOfSitting = value; }
		}

		/// <summary>
		/// Gets or sets the AllergyName value.
		/// </summary>
		private string _allergyName=String.Empty;
		public string AllergyName
		{
			get { return  _allergyName; }
			set { _allergyName = value; }
		}

		/// <summary>
		/// Gets or sets the Recid value.
		/// </summary>
		private long _recid=0;
		public long Recid
		{
			get { return  _recid; }
			set { _recid = value; }
		}

		/// <summary>
		/// Gets or sets the BillType value.
		/// </summary>
		private string _billType=String.Empty;
		public string BillType
		{
			get { return  _billType; }
			set { _billType = value; }
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
		/// Gets or sets the SpeciesName value.
		/// </summary>
		private string _speciesName=String.Empty;
		public string SpeciesName
		{
			get { return  _speciesName; }
			set { _speciesName = value; }
		}


		#endregion
}
}
