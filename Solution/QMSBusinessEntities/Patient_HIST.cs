using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Patient_HIST
	{
		#region Fields

		private long patient_HISTID=0;
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
		private string nationality=String.Empty;
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
		private int notifyType=0;
		private bool isNotify=false;
		private string patientType=String.Empty;
		private long createdRole=0;
		private string patientStatus=String.Empty;
		private long approvedBy=0;
		private string alterColumn=String.Empty;
		private string oldValues=String.Empty;
		private string approvalNo=String.Empty;
		private string externalPatientNumber=String.Empty;
		private long patientVisit_HISTID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Patient_HISTID value.
		/// </summary>
		public long Patient_HISTID
		{
			get { return patient_HISTID; }
			set { patient_HISTID = value; }
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
		public string Nationality
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
		/// Gets or sets the NotifyType value.
		/// </summary>
		public int NotifyType
		{
			get { return notifyType; }
			set { notifyType = value; }
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
		/// Gets or sets the PatientType value.
		/// </summary>
		public string PatientType
		{
			get { return patientType; }
			set { patientType = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
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
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the AlterColumn value.
		/// </summary>
		public string AlterColumn
		{
			get { return alterColumn; }
			set { alterColumn = value; }
		}

		/// <summary>
		/// Gets or sets the OldValues value.
		/// </summary>
		public string OldValues
		{
			get { return oldValues; }
			set { oldValues = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalNo value.
		/// </summary>
		public string ApprovalNo
		{
			get { return approvalNo; }
			set { approvalNo = value; }
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
		/// Gets or sets the PatientVisit_HISTID value.
		/// </summary>
		public long PatientVisit_HISTID
		{
			get { return patientVisit_HISTID; }
			set { patientVisit_HISTID = value; }
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
		/// Gets or sets the Address value.
		/// </summary>
		string _address;
		public string Address
		{
			get { return _address; }
			set { _address = value; }
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
		/// Gets or sets the CountryName value.
		/// </summary>
		string _countryname;
		public string CountryName
		{
			get { return _countryname; }
			set { _countryname = value; }
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
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		string _landlinenumber;
		public string LandLineNumber
		{
			get { return _landlinenumber; }
			set { _landlinenumber = value; }
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
		/// Gets or sets the LoginName value.
		/// </summary>
		string _loginname;
		public string LoginName
		{
			get { return _loginname; }
			set { _loginname = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		string _rolename;
		public string RoleName
		{
			get { return _rolename; }
			set { _rolename = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedDate value.
		/// </summary>
		DateTime _modifieddate;
		public DateTime ModifiedDate
		{
			get { return _modifieddate; }
			set { _modifieddate = value; }
		}

		/// <summary>
		/// Gets or sets the MaritalStatus value.
		/// </summary>
		string _maritalstatus;
		public string MaritalStatus
		{
			get { return _maritalstatus; }
			set { _maritalstatus = value; }
		}


		#endregion
}
}
