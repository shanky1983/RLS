using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationValues
	{
		#region Fields

		private long investigationValueID=0;
		private string name=String.Empty;
		private string valu=String.Empty;
		private long investigationID=0;
		private int groupID=0;
		private long patientVisitID=0;
		private int uOMID=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string uOMCode=String.Empty;
		private string groupName=String.Empty;
		private int orgid=0;
		private long iPInvSampleCollectionMasterID=0;
		private int packageID=0;
		private string packageName=String.Empty;
		private int sequenceNo=0;
		private string uID=String.Empty;
		private string dilution=String.Empty;
		private string deviceID=String.Empty;
		private string deviceValue=String.Empty;
		private string precision=String.Empty;
		private string migrated_Request_Number=String.Empty;
		private string migrated_TestCode=String.Empty;
		private string deviceActualValue=String.Empty;
		private string statustype=String.Empty;
		private string convValue=String.Empty;
		private string convUOMCode=String.Empty;
		private string deviceErrorCode=String.Empty;
		private long patientInvID=0;
		private string isAbnormal=String.Empty;
		private string previousStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationValueID value.
		/// </summary>
		public long InvestigationValueID
		{
			get { return investigationValueID; }
			set { investigationValueID = value; }
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
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
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
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
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
		/// Gets or sets the UOMCode value.
		/// </summary>
		public string UOMCode
		{
			get { return uOMCode; }
			set { uOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the IPInvSampleCollectionMasterID value.
		/// </summary>
		public long IPInvSampleCollectionMasterID
		{
			get { return iPInvSampleCollectionMasterID; }
			set { iPInvSampleCollectionMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public int PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageName value.
		/// </summary>
		public string PackageName
		{
			get { return packageName; }
			set { packageName = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		public string UID
		{
			get { return uID; }
			set { uID = value; }
		}

		/// <summary>
		/// Gets or sets the Dilution value.
		/// </summary>
		public string Dilution
		{
			get { return dilution; }
			set { dilution = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceValue value.
		/// </summary>
		public string DeviceValue
		{
			get { return deviceValue; }
			set { deviceValue = value; }
		}

		/// <summary>
		/// Gets or sets the Precision value.
		/// </summary>
		public string Precision
		{
			get { return precision; }
			set { precision = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Request_Number value.
		/// </summary>
		public string Migrated_Request_Number
		{
			get { return migrated_Request_Number; }
			set { migrated_Request_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_TestCode value.
		/// </summary>
		public string Migrated_TestCode
		{
			get { return migrated_TestCode; }
			set { migrated_TestCode = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceActualValue value.
		/// </summary>
		public string DeviceActualValue
		{
			get { return deviceActualValue; }
			set { deviceActualValue = value; }
		}

		/// <summary>
		/// Gets or sets the Statustype value.
		/// </summary>
		public string Statustype
		{
			get { return statustype; }
			set { statustype = value; }
		}

		/// <summary>
		/// Gets or sets the ConvValue value.
		/// </summary>
		public string ConvValue
		{
			get { return convValue; }
			set { convValue = value; }
		}

		/// <summary>
		/// Gets or sets the ConvUOMCode value.
		/// </summary>
		public string ConvUOMCode
		{
			get { return convUOMCode; }
			set { convUOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceErrorCode value.
		/// </summary>
		public string DeviceErrorCode
		{
			get { return deviceErrorCode; }
			set { deviceErrorCode = value; }
		}

		/// <summary>
		/// Gets or sets the PatientInvID value.
		/// </summary>
		public long PatientInvID
		{
			get { return patientInvID; }
			set { patientInvID = value; }
		}

		/// <summary>
		/// Gets or sets the IsAbnormal value.
		/// </summary>
		public string IsAbnormal
		{
			get { return isAbnormal; }
			set { isAbnormal = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousStatus value.
		/// </summary>
		public string PreviousStatus
		{
			get { return previousStatus; }
			set { previousStatus = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		private string _investigationName=String.Empty;
		public string InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicainName value.
		/// </summary>
		private string _performingPhysicainName=String.Empty;
		public string PerformingPhysicainName
		{
			get { return  _performingPhysicainName; }
			set { _performingPhysicainName = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		private long _approvedBy=0;
		public long ApprovedBy
		{
			get { return  _approvedBy; }
			set { _approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		private string _reason=String.Empty;
		public string Reason
		{
			get { return  _reason; }
			set { _reason = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		private string _referenceRange=String.Empty;
		public string ReferenceRange
		{
			get { return  _referenceRange; }
			set { _referenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		private string _visitID=String.Empty;
		public string VisitID
		{
			get { return  _visitID; }
			set { _visitID = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		private long _accessionNumber=0;
		public long AccessionNumber
		{
			get { return  _accessionNumber; }
			set { _accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralID value.
		/// </summary>
		private long _referralID=0;
		public long ReferralID
		{
			get { return  _referralID; }
			set { _referralID = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalRemarks value.
		/// </summary>
		private string _medicalRemarks=String.Empty;
		public string MedicalRemarks
		{
			get { return  _medicalRemarks; }
			set { _medicalRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the GroupMedicalRemarks value.
		/// </summary>
		private string _groupMedicalRemarks=String.Empty;
		public string GroupMedicalRemarks
		{
			get { return  _groupMedicalRemarks; }
			set { _groupMedicalRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the KitName value.
		/// </summary>
		private string _kitName=String.Empty;
		public string KitName
		{
			get { return  _kitName; }
			set { _kitName = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentName value.
		/// </summary>
		private string _instrumentName=String.Empty;
		public string InstrumentName
		{
			get { return  _instrumentName; }
			set { _instrumentName = value; }
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
		/// Gets or sets the DisplayStatus value.
		/// </summary>
		private string _displayStatus=String.Empty;
		public string DisplayStatus
		{
			get { return  _displayStatus; }
			set { _displayStatus = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		private int _sampleCode=0;
		public int SampleCode
		{
			get { return  _sampleCode; }
			set { _sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the SampleContainerID value.
		/// </summary>
		private int _sampleContainerID=0;
		public int SampleContainerID
		{
			get { return  _sampleContainerID; }
			set { _sampleContainerID = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorCode value.
		/// </summary>
		private string _errorCode=String.Empty;
		public string ErrorCode
		{
			get { return  _errorCode; }
			set { _errorCode = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorCategory value.
		/// </summary>
		private string _errorCategory=String.Empty;
		public string ErrorCategory
		{
			get { return  _errorCategory; }
			set { _errorCategory = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorDescription value.
		/// </summary>
		private string _errorDescription=String.Empty;
		public string ErrorDescription
		{
			get { return  _errorDescription; }
			set { _errorDescription = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_Factor value.
		/// </summary>
		private decimal _cONV_Factor=Decimal.Zero;
		public decimal CONV_Factor
		{
			get { return  _cONV_Factor; }
			set { _cONV_Factor = value; }
		}

		/// <summary>
		/// Gets or sets the CONVFactorDecimalPt value.
		/// </summary>
		private int _cONVFactorDecimalPt=0;
		public int CONVFactorDecimalPt
		{
			get { return  _cONVFactorDecimalPt; }
			set { _cONVFactorDecimalPt = value; }
		}

		/// <summary>
		/// Gets or sets the ValidatedAt value.
		/// </summary>
		private DateTime _validatedAt=DateTime.MaxValue;
		public DateTime ValidatedAt
		{
			get { return  _validatedAt; }
			set { _validatedAt = value; }
		}


		#endregion
}
}
