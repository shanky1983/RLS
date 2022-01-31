using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HC_Patient
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
		private string nationality=String.Empty;
		private string uRNO=String.Empty;
		private long loginID=0;
		private long uRNofId=0;
		private long uRNTypeId=0;
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
		private bool isNotify=false;

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
		/// Gets or sets the IsNotify value.
		/// </summary>
		public bool IsNotify
		{
			get { return isNotify; }
			set { isNotify = value; }
		}


		#endregion
}
}
