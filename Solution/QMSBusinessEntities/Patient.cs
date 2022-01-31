using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		long _patientvisitid;
		public long PatientVisitID
		{
			get { return _patientvisitid; }
			set { _patientvisitid = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		DateTime _visitdate;
		public DateTime VisitDate
		{
			get { return _visitdate; }
			set { _visitdate = value; }
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
		/// Gets or sets the Condition value.
		/// </summary>
		String _condition;
		public String Condition
		{
			get { return _condition; }
			set { _condition = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		String _physicianname;
		public String PhysicianName
		{
			get { return _physicianname; }
			set { _physicianname = value; }
		}

		/// <summary>
		/// Gets or sets the BGColor value.
		/// </summary>
		String _bgcolor;
		public String BGColor
		{
			get { return _bgcolor; }
			set { _bgcolor = value; }
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
		/// Gets or sets the BirthDays value.
		/// </summary>
		string _birthdays;
		public string BirthDays
		{
			get { return _birthdays; }
			set { _birthdays = value; }
		}

		/// <summary>
		/// Gets or sets the NextReviewDate value.
		/// </summary>
		string _nextreviewdate;
		public string NextReviewDate
		{
			get { return _nextreviewdate; }
			set { _nextreviewdate = value; }
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
		/// Gets or sets the MobileNumber value.
		/// </summary>
		string _mobilenumber;
		public string MobileNumber
		{
			get { return _mobilenumber; }
			set { _mobilenumber = value; }
		}

		/// <summary>
		/// Gets or sets the BedDetail value.
		/// </summary>
		string _beddetail;
		public string BedDetail
		{
			get { return _beddetail; }
			set { _beddetail = value; }
		}

		/// <summary>
		/// Gets or sets the SecuredCode value.
		/// </summary>
		string _securedcode;
		public string SecuredCode
		{
			get { return _securedcode; }
			set { _securedcode = value; }
		}

		/// <summary>
		/// Gets or sets the TokenNumber value.
		/// </summary>
		int _tokennumber;
		public int TokenNumber
		{
			get { return _tokennumber; }
			set { _tokennumber = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionSuggested value.
		/// </summary>
		string _admissionsuggested;
		public string AdmissionSuggested
		{
			get { return _admissionsuggested; }
			set { _admissionsuggested = value; }
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
		/// Gets or sets the Add3 value.
		/// </summary>
		string _add3;
		public string Add3
		{
			get { return _add3; }
			set { _add3 = value; }
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
		/// Gets or sets the PurposeOfAdmissionName value.
		/// </summary>
		string _purposeofadmissionname;
		public string PurposeOfAdmissionName
		{
			get { return _purposeofadmissionname; }
			set { _purposeofadmissionname = value; }
		}

		/// <summary>
		/// Gets or sets the DueDetails value.
		/// </summary>
		decimal _duedetails;
		public decimal DueDetails
		{
			get { return _duedetails; }
			set { _duedetails = value; }
		}

		/// <summary>
		/// Gets or sets the CountryName value.
		/// </summary>
		string _countryname;
		public string CountryName
		{
			get { return _countryname; }
			set { _countryname = value; }
		}

		/// <summary>
		/// Gets or sets the StateName value.
		/// </summary>
		string _statename;
		public string StateName
		{
			get { return _statename; }
			set { _statename = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		string _landlinenumber;
		public string LandLineNumber
		{
			get { return _landlinenumber; }
			set { _landlinenumber = value; }
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
		/// Gets or sets the AccompaniedBy value.
		/// </summary>
		string _accompaniedby;
		public string AccompaniedBy
		{
			get { return _accompaniedby; }
			set { _accompaniedby = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipID value.
		/// </summary>
		string _relationshipid;
		public string RelationshipID
		{
			get { return _relationshipid; }
			set { _relationshipid = value; }
		}

		/// <summary>
		/// Gets or sets the RelationContactNo value.
		/// </summary>
		string _relationcontactno;
		public string RelationContactNo
		{
			get { return _relationcontactno; }
			set { _relationcontactno = value; }
		}

		/// <summary>
		/// Gets or sets the ContactNo value.
		/// </summary>
		string _contactno;
		public string ContactNo
		{
			get { return _contactno; }
			set { _contactno = value; }
		}

		/// <summary>
		/// Gets or sets the PrimaryPhysician value.
		/// </summary>
		string _primaryphysician;
		public string PrimaryPhysician
		{
			get { return _primaryphysician; }
			set { _primaryphysician = value; }
		}

		/// <summary>
		/// Gets or sets the ConsultingSurgeon value.
		/// </summary>
		string _consultingsurgeon;
		public string ConsultingSurgeon
		{
			get { return _consultingsurgeon; }
			set { _consultingsurgeon = value; }
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
		/// Gets or sets the KnowledgeOfServiceName value.
		/// </summary>
		string _knowledgeofservicename;
		public string KnowledgeOfServiceName
		{
			get { return _knowledgeofservicename; }
			set { _knowledgeofservicename = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceProviderName value.
		/// </summary>
		string _serviceprovidername;
		public string ServiceProviderName
		{
			get { return _serviceprovidername; }
			set { _serviceprovidername = value; }
		}

		/// <summary>
		/// Gets or sets the InformationBy value.
		/// </summary>
		string _informationby;
		public string InformationBy
		{
			get { return _informationby; }
			set { _informationby = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingPhysicianName value.
		/// </summary>
		string _referingphysicianname;
		public string ReferingPhysicianName
		{
			get { return _referingphysicianname; }
			set { _referingphysicianname = value; }
		}

		/// <summary>
		/// Gets or sets the ReferingSpecialityName value.
		/// </summary>
		string _referingspecialityname;
		public string ReferingSpecialityName
		{
			get { return _referingspecialityname; }
			set { _referingspecialityname = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		string _visittype;
		public string VisitType
		{
			get { return _visittype; }
			set { _visittype = value; }
		}

		/// <summary>
		/// Gets or sets the TPAName value.
		/// </summary>
		string _tpaname;
		public string TPAName
		{
			get { return _tpaname; }
			set { _tpaname = value; }
		}

		/// <summary>
		/// Gets or sets the BillAmount value.
		/// </summary>
		Decimal _billamount;
		public Decimal BillAmount
		{
			get { return _billamount; }
			set { _billamount = value; }
		}

		/// <summary>
		/// Gets or sets the VisitState value.
		/// </summary>
		String _visitstate;
		public String VisitState
		{
			get { return _visitstate; }
			set { _visitstate = value; }
		}

		/// <summary>
		/// Gets or sets the DischargedDT value.
		/// </summary>
		DateTime _dischargeddt;
		public DateTime DischargedDT
		{
			get { return _dischargeddt; }
			set { _dischargeddt = value; }
		}

		/// <summary>
		/// Gets or sets the TPAAmount value.
		/// </summary>
		Decimal _tpaamount;
		public Decimal TPAAmount
		{
			get { return _tpaamount; }
			set { _tpaamount = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		long _finalbillid;
		public long FinalBillID
		{
			get { return _finalbillid; }
			set { _finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the IPNumber value.
		/// </summary>
		string _ipnumber;
		public string IPNumber
		{
			get { return _ipnumber; }
			set { _ipnumber = value; }
		}

		/// <summary>
		/// Gets or sets the DutyOfficer value.
		/// </summary>
		string _dutyofficer;
		public string DutyOfficer
		{
			get { return _dutyofficer; }
			set { _dutyofficer = value; }
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
		/// Gets or sets the TPAAttributes value.
		/// </summary>
		string _tpaattributes;
		public string TPAAttributes
		{
			get { return _tpaattributes; }
			set { _tpaattributes = value; }
		}

		/// <summary>
		/// Gets or sets the BabyName value.
		/// </summary>
		string _babyname;
		public string BabyName
		{
			get { return _babyname; }
			set { _babyname = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureType value.
		/// </summary>
		string _proceduretype;
		public string ProcedureType
		{
			get { return _proceduretype; }
			set { _proceduretype = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryTypeName value.
		/// </summary>
		string _deliverytypename;
		public string DeliveryTypeName
		{
			get { return _deliverytypename; }
			set { _deliverytypename = value; }
		}

		/// <summary>
		/// Gets or sets the Obstretrician value.
		/// </summary>
		string _obstretrician;
		public string Obstretrician
		{
			get { return _obstretrician; }
			set { _obstretrician = value; }
		}

		/// <summary>
		/// Gets or sets the PType value.
		/// </summary>
		int _ptype;
		public int PType
		{
			get { return _ptype; }
			set { _ptype = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettlementDate value.
		/// </summary>
		DateTime _tpasettlementdate;
		public DateTime TPASettlementDate
		{
			get { return _tpasettlementdate; }
			set { _tpasettlementdate = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		Decimal _preauthamount;
		public Decimal PreAuthAmount
		{
			get { return _preauthamount; }
			set { _preauthamount = value; }
		}

		/// <summary>
		/// Gets or sets the RightOff value.
		/// </summary>
		Decimal _rightoff;
		public Decimal RightOff
		{
			get { return _rightoff; }
			set { _rightoff = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		string _iscreditbill;
		public string IsCreditBill
		{
			get { return _iscreditbill; }
			set { _iscreditbill = value; }
		}

		/// <summary>
		/// Gets or sets the PatientCount value.
		/// </summary>
		long _patientcount;
		public long PatientCount
		{
			get { return _patientcount; }
			set { _patientcount = value; }
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
		/// Gets or sets the ComplaintName value.
		/// </summary>
		string _complaintname;
		public string ComplaintName
		{
			get { return _complaintname; }
			set { _complaintname = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		int _clientid;
		public int ClientID
		{
			get { return _clientid; }
			set { _clientid = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		int _rateid;
		public int RateID
		{
			get { return _rateid; }
			set { _rateid = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		string _typename;
		public string TypeName
		{
			get { return _typename; }
			set { _typename = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		int _visitpurposeid;
		public int VisitPurposeID
		{
			get { return _visitpurposeid; }
			set { _visitpurposeid = value; }
		}

		/// <summary>
		/// Gets or sets the RowNumber value.
		/// </summary>
		long _rownumber;
		public long RowNumber
		{
			get { return _rownumber; }
			set { _rownumber = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDepositAmount value.
		/// </summary>
		Decimal _totaldepositamount;
		public Decimal TotalDepositAmount
		{
			get { return _totaldepositamount; }
			set { _totaldepositamount = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDepositUsed value.
		/// </summary>
		Decimal _totaldepositused;
		public Decimal TotalDepositUsed
		{
			get { return _totaldepositused; }
			set { _totaldepositused = value; }
		}

		/// <summary>
		/// Gets or sets the DepositBalance value.
		/// </summary>
		Decimal _depositbalance;
		public Decimal DepositBalance
		{
			get { return _depositbalance; }
			set { _depositbalance = value; }
		}

		/// <summary>
		/// Gets or sets the CliamForwardDate value.
		/// </summary>
		DateTime _cliamforwarddate;
		public DateTime CliamForwardDate
		{
			get { return _cliamforwarddate; }
			set { _cliamforwarddate = value; }
		}

		/// <summary>
		/// Gets or sets the DepositID value.
		/// </summary>
		long _depositid;
		public long DepositID
		{
			get { return _depositid; }
			set { _depositid = value; }
		}

		/// <summary>
		/// Gets or sets the AmtRefund value.
		/// </summary>
		Decimal _amtrefund;
		public Decimal AmtRefund
		{
			get { return _amtrefund; }
			set { _amtrefund = value; }
		}

		/// <summary>
		/// Gets or sets the PatorgName value.
		/// </summary>
		string _patorgname;
		public string PatorgName
		{
			get { return _patorgname; }
			set { _patorgname = value; }
		}

		/// <summary>
		/// Gets or sets the OtherOrgflag value.
		/// </summary>
		string _otherorgflag;
		public string OtherOrgflag
		{
			get { return _otherorgflag; }
			set { _otherorgflag = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDueAmt value.
		/// </summary>
		Decimal _totaldueamt;
		public Decimal TotalDueAmt
		{
			get { return _totaldueamt; }
			set { _totaldueamt = value; }
		}

		/// <summary>
		/// Gets or sets the TDS value.
		/// </summary>
		Decimal _tds;
		public Decimal TDS
		{
			get { return _tds; }
			set { _tds = value; }
		}

		/// <summary>
		/// Gets or sets the TPABillAmount value.
		/// </summary>
		Decimal _tpabillamount;
		public Decimal TPABillAmount
		{
			get { return _tpabillamount; }
			set { _tpabillamount = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentAmount value.
		/// </summary>
		Decimal _copaymentamount;
		public Decimal CoPaymentAmount
		{
			get { return _copaymentamount; }
			set { _copaymentamount = value; }
		}

		/// <summary>
		/// Gets or sets the TPADiscountAmt value.
		/// </summary>
		Decimal _tpadiscountamt;
		public Decimal TPADiscountAmt
		{
			get { return _tpadiscountamt; }
			set { _tpadiscountamt = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettledAmt value.
		/// </summary>
		Decimal _tpasettledamt;
		public Decimal TPASettledAmt
		{
			get { return _tpasettledamt; }
			set { _tpasettledamt = value; }
		}

		/// <summary>
		/// Gets or sets the TPADisallowedAmt value.
		/// </summary>
		Decimal _tpadisallowedamt;
		public Decimal TPADisallowedAmt
		{
			get { return _tpadisallowedamt; }
			set { _tpadisallowedamt = value; }
		}

		/// <summary>
		/// Gets or sets the TPARemarks value.
		/// </summary>
		string _tparemarks;
		public string TPARemarks
		{
			get { return _tparemarks; }
			set { _tparemarks = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverID value.
		/// </summary>
		long _tpaapproverid;
		public long TPAApproverID
		{
			get { return _tpaapproverid; }
			set { _tpaapproverid = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverName value.
		/// </summary>
		string _tpaapprovername;
		public string TPAApproverName
		{
			get { return _tpaapprovername; }
			set { _tpaapprovername = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApprovedDate value.
		/// </summary>
		DateTime _tpaapproveddate;
		public DateTime TPAApprovedDate
		{
			get { return _tpaapproveddate; }
			set { _tpaapproveddate = value; }
		}

		/// <summary>
		/// Gets or sets the GrossAmount value.
		/// </summary>
		Decimal _grossamount;
		public Decimal GrossAmount
		{
			get { return _grossamount; }
			set { _grossamount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDiscountAmount value.
		/// </summary>
		Decimal _orgdiscountamount;
		public Decimal OrgDiscountAmount
		{
			get { return _orgdiscountamount; }
			set { _orgdiscountamount = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmount value.
		/// </summary>
		Decimal _netamount;
		public Decimal NetAmount
		{
			get { return _netamount; }
			set { _netamount = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedAmount value.
		/// </summary>
		Decimal _receivedamount;
		public Decimal ReceivedAmount
		{
			get { return _receivedamount; }
			set { _receivedamount = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffApprover value.
		/// </summary>
		string _writeoffapprover;
		public string WriteOffApprover
		{
			get { return _writeoffapprover; }
			set { _writeoffapprover = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentDetails value.
		/// </summary>
		string _paymentdetails;
		public string PaymentDetails
		{
			get { return _paymentdetails; }
			set { _paymentdetails = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		string _billnumber;
		public string BillNumber
		{
			get { return _billnumber; }
			set { _billnumber = value; }
		}

		/// <summary>
		/// Gets or sets the Ageing value.
		/// </summary>
		string _ageing;
		public string Ageing
		{
			get { return _ageing; }
			set { _ageing = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceAmount value.
		/// </summary>
		decimal _advanceamount;
		public decimal AdvanceAmount
		{
			get { return _advanceamount; }
			set { _advanceamount = value; }
		}

		/// <summary>
		/// Gets or sets the CreditLimit value.
		/// </summary>
		decimal _creditlimit;
		public decimal CreditLimit
		{
			get { return _creditlimit; }
			set { _creditlimit = value; }
		}

		/// <summary>
		/// Gets or sets the CreditLimitRemarks value.
		/// </summary>
		string _creditlimitremarks;
		public string CreditLimitRemarks
		{
			get { return _creditlimitremarks; }
			set { _creditlimitremarks = value; }
		}

		/// <summary>
		/// Gets or sets the IsSurgeryPatient value.
		/// </summary>
		string _issurgerypatient;
		public string IsSurgeryPatient
		{
			get { return _issurgerypatient; }
			set { _issurgerypatient = value; }
		}

		/// <summary>
		/// Gets or sets the ConfigTaxPercent value.
		/// </summary>
		string _configtaxpercent;
		public string ConfigTaxPercent
		{
			get { return _configtaxpercent; }
			set { _configtaxpercent = value; }
		}

		/// <summary>
		/// Gets or sets the PayerID value.
		/// </summary>
		int _payerid;
		public int PayerID
		{
			get { return _payerid; }
			set { _payerid = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureDesc value.
		/// </summary>
		string _proceduredesc;
		public string ProcedureDesc
		{
			get { return _proceduredesc; }
			set { _proceduredesc = value; }
		}

		/// <summary>
		/// Gets or sets the EmployeeNumber value.
		/// </summary>
		string _employeenumber;
		public string EmployeeNumber
		{
			get { return _employeenumber; }
			set { _employeenumber = value; }
		}

		/// <summary>
		/// Gets or sets the NextReview value.
		/// </summary>
		DateTime _nextreview;
		public DateTime NextReview
		{
			get { return _nextreview; }
			set { _nextreview = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		short _countryid;
		public short CountryID
		{
			get { return _countryid; }
			set { _countryid = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		short _stateid;
		public short StateID
		{
			get { return _stateid; }
			set { _stateid = value; }
		}

		/// <summary>
		/// Gets or sets the WardNo value.
		/// </summary>
		string _wardno;
		public string WardNo
		{
			get { return _wardno; }
			set { _wardno = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityID value.
		/// </summary>
		string _priorityid;
		public string PriorityID
		{
			get { return _priorityid; }
			set { _priorityid = value; }
		}

		/// <summary>
		/// Gets or sets the PatientHistory value.
		/// </summary>
		string _patienthistory;
		public string PatientHistory
		{
			get { return _patienthistory; }
			set { _patienthistory = value; }
		}

		/// <summary>
		/// Gets or sets the NeedServiceBill value.
		/// </summary>
		string _needservicebill;
		public string NeedServiceBill
		{
			get { return _needservicebill; }
			set { _needservicebill = value; }
		}

		/// <summary>
		/// Gets or sets the IsCorporatetBill value.
		/// </summary>
		string _iscorporatetbill;
		public string IsCorporatetBill
		{
			get { return _iscorporatetbill; }
			set { _iscorporatetbill = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedHospitalID value.
		/// </summary>
		int _referedhospitalid;
		public int ReferedHospitalID
		{
			get { return _referedhospitalid; }
			set { _referedhospitalid = value; }
		}

		/// <summary>
		/// Gets or sets the ReferedHospitalName value.
		/// </summary>
		string _referedhospitalname;
		public string ReferedHospitalName
		{
			get { return _referedhospitalname; }
			set { _referedhospitalname = value; }
		}

		/// <summary>
		/// Gets or sets the PostalCode value.
		/// </summary>
		string _postalcode;
		public string PostalCode
		{
			get { return _postalcode; }
			set { _postalcode = value; }
		}

		/// <summary>
		/// Gets or sets the RegistrationRemarks value.
		/// </summary>
		string _registrationremarks;
		public string RegistrationRemarks
		{
			get { return _registrationremarks; }
			set { _registrationremarks = value; }
		}

		/// <summary>
		/// Gets or sets the PatientIdentifyID value.
		/// </summary>
		string _patientidentifyid;
		public string PatientIdentifyID
		{
			get { return _patientidentifyid; }
			set { _patientidentifyid = value; }
		}

		/// <summary>
		/// Gets or sets the AgeValue value.
		/// </summary>
		int _agevalue;
		public int AgeValue
		{
			get { return _agevalue; }
			set { _agevalue = value; }
		}

		/// <summary>
		/// Gets or sets the AgeUnit value.
		/// </summary>
		string _ageunit;
		public string AgeUnit
		{
			get { return _ageunit; }
			set { _ageunit = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeVisitId value.
		/// </summary>
		long _episodevisitid;
		public long EpisodeVisitId
		{
			get { return _episodevisitid; }
			set { _episodevisitid = value; }
		}

		/// <summary>
		/// Gets or sets the GUID value.
		/// </summary>
		string _guid;
		public string GUID
		{
			get { return _guid; }
			set { _guid = value; }
		}

		/// <summary>
		/// Gets or sets the ILocationID value.
		/// </summary>
		int _ilocationid;
		public int ILocationID
		{
			get { return _ilocationid; }
			set { _ilocationid = value; }
		}

		/// <summary>
		/// Gets or sets the TaskactionID value.
		/// </summary>
		int _taskactionid;
		public int TaskactionID
		{
			get { return _taskactionid; }
			set { _taskactionid = value; }
		}

		/// <summary>
		/// Gets or sets the VistTypeID value.
		/// </summary>
		int _visttypeid;
		public int VistTypeID
		{
			get { return _visttypeid; }
			set { _visttypeid = value; }
		}

		/// <summary>
		/// Gets or sets the PStatusID value.
		/// </summary>
		int _pstatusid;
		public int PStatusID
		{
			get { return _pstatusid; }
			set { _pstatusid = value; }
		}

		/// <summary>
		/// Gets or sets the EmpDeptCode value.
		/// </summary>
		string _empdeptcode;
		public string EmpDeptCode
		{
			get { return _empdeptcode; }
			set { _empdeptcode = value; }
		}

		/// <summary>
		/// Gets or sets the DetailHistory value.
		/// </summary>
		string _detailhistory;
		public string DetailHistory
		{
			get { return _detailhistory; }
			set { _detailhistory = value; }
		}

		/// <summary>
		/// Gets or sets the DispatchType value.
		/// </summary>
		string _dispatchtype;
		public string DispatchType
		{
			get { return _dispatchtype; }
			set { _dispatchtype = value; }
		}

		/// <summary>
		/// Gets or sets the SamplePickupDate value.
		/// </summary>
		DateTime _samplepickupdate;
		public DateTime SamplePickupDate
		{
			get { return _samplepickupdate; }
			set { _samplepickupdate = value; }
		}

		/// <summary>
		/// Gets or sets the MetaTypeID value.
		/// </summary>
		string _metatypeid;
		public string MetaTypeID
		{
			get { return _metatypeid; }
			set { _metatypeid = value; }
		}

		/// <summary>
		/// Gets or sets the MetaValueID value.
		/// </summary>
		string _metavalueid;
		public string MetaValueID
		{
			get { return _metavalueid; }
			set { _metavalueid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		string _orgname;
		public string OrgName
		{
			get { return _orgname; }
			set { _orgname = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		long _roleid;
		public long RoleID
		{
			get { return _roleid; }
			set { _roleid = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		long _userid;
		public long UserID
		{
			get { return _userid; }
			set { _userid = value; }
		}

		/// <summary>
		/// Gets or sets the NewPassword value.
		/// </summary>
		string _newpassword;
		public string NewPassword
		{
			get { return _newpassword; }
			set { _newpassword = value; }
		}

		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		string _loginname;
		public string LoginName
		{
			get { return _loginname; }
			set { _loginname = value; }
		}

		/// <summary>
		/// Gets or sets the Password value.
		/// </summary>
		string _password;
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitID value.
		/// </summary>
		string _externalvisitid;
		public string ExternalVisitID
		{
			get { return _externalvisitid; }
			set { _externalvisitid = value; }
		}

		/// <summary>
		/// Gets or sets the ZoneID value.
		/// </summary>
		long _zoneid;
		public long ZoneID
		{
			get { return _zoneid; }
			set { _zoneid = value; }
		}


		#endregion
}
}
