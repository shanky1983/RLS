using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientInvSample
	{
		#region Fields

		private long patientVisitID=0;
		private int sampleID=0;
		private string barcodeNumber=String.Empty;
		private int sampleCode=0;
		private string sampleDesc=String.Empty;
		private long iPInvSampleCollectionMasterID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int sampleContainerID=0;
		private int recSampleLocID=0;
		private int collectedLocID=0;
		private string uID=String.Empty;
		private int recorgid=0;
		private int sampleRelationshipID=0;
		private DateTime collectedDateTime=DateTime.MaxValue;
		private int vmValue=0;
		private int vmUnitID=0;
		private int sampleConditionID=0;
		private string consignmentNo=String.Empty;
		private long pickedby=0;
		private int batchID=0;
		private string isActive=String.Empty;
		private string tissueType=String.Empty;
		private string status=String.Empty;
		private DateTime completionTime=DateTime.MaxValue;
		private long grossCompletedby=0;
		private bool isSecBarCode=false;
		private string caseNumber=String.Empty;
		private long tissueCompletedby=0;
        private string externalBarcode = String.Empty;
        private int barcodecount = 1;
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		public string BarcodeNumber
		{
			get { return barcodeNumber; }
			set { barcodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		public int SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		public string SampleDesc
		{
			get { return sampleDesc; }
			set { sampleDesc = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the SampleContainerID value.
		/// </summary>
		public int SampleContainerID
		{
			get { return sampleContainerID; }
			set { sampleContainerID = value; }
		}

		/// <summary>
		/// Gets or sets the RecSampleLocID value.
		/// </summary>
		public int RecSampleLocID
		{
			get { return recSampleLocID; }
			set { recSampleLocID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedLocID value.
		/// </summary>
		public int CollectedLocID
		{
			get { return collectedLocID; }
			set { collectedLocID = value; }
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
		/// Gets or sets the Recorgid value.
		/// </summary>
		public int Recorgid
		{
			get { return recorgid; }
			set { recorgid = value; }
		}

		/// <summary>
		/// Gets or sets the SampleRelationshipID value.
		/// </summary>
		public int SampleRelationshipID
		{
			get { return sampleRelationshipID; }
			set { sampleRelationshipID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedDateTime value.
		/// </summary>
		public DateTime CollectedDateTime
		{
			get { return collectedDateTime; }
			set { collectedDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the VmValue value.
		/// </summary>
		public int VmValue
		{
			get { return vmValue; }
			set { vmValue = value; }
		}

		/// <summary>
		/// Gets or sets the VmUnitID value.
		/// </summary>
		public int VmUnitID
		{
			get { return vmUnitID; }
			set { vmUnitID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleConditionID value.
		/// </summary>
		public int SampleConditionID
		{
			get { return sampleConditionID; }
			set { sampleConditionID = value; }
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
		/// Gets or sets the Pickedby value.
		/// </summary>
		public long Pickedby
		{
			get { return pickedby; }
			set { pickedby = value; }
		}

		/// <summary>
		/// Gets or sets the BatchID value.
		/// </summary>
		public int BatchID
		{
			get { return batchID; }
			set { batchID = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the TissueType value.
		/// </summary>
		public string TissueType
		{
			get { return tissueType; }
			set { tissueType = value; }
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
		/// Gets or sets the CompletionTime value.
		/// </summary>
		public DateTime CompletionTime
		{
			get { return completionTime; }
			set { completionTime = value; }
		}

		/// <summary>
		/// Gets or sets the GrossCompletedby value.
		/// </summary>
		public long GrossCompletedby
		{
			get { return grossCompletedby; }
			set { grossCompletedby = value; }
		}

		/// <summary>
		/// Gets or sets the IsSecBarCode value.
		/// </summary>
		public bool IsSecBarCode
		{
			get { return isSecBarCode; }
			set { isSecBarCode = value; }
		}

		/// <summary>
		/// Gets or sets the CaseNumber value.
		/// </summary>
		public string CaseNumber
		{
			get { return caseNumber; }
			set { caseNumber = value; }
		}

		/// <summary>
		/// Gets or sets the TissueCompletedby value.
		/// </summary>
		public long TissueCompletedby
		{
			get { return tissueCompletedby; }
			set { tissueCompletedby = value; }
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
		/// Gets or sets the InvSampleStatusDesc value.
		/// </summary>
		private string _invSampleStatusDesc=String.Empty;
		public string InvSampleStatusDesc
		{
			get { return  _invSampleStatusDesc; }
			set { _invSampleStatusDesc = value; }
		}

		/// <summary>
		/// Gets or sets the InvSampleStatusID value.
		/// </summary>
		private long _invSampleStatusID=0;
		public long InvSampleStatusID
		{
			get { return  _invSampleStatusID; }
			set { _invSampleStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleContainerName value.
		/// </summary>
		private string _sampleContainerName=String.Empty;
		public string SampleContainerName
		{
			get { return  _sampleContainerName; }
			set { _sampleContainerName = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		private string _locationName=String.Empty;
		public string LocationName
		{
			get { return  _locationName; }
			set { _locationName = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigtionName value.
		/// </summary>
		private string _investigtionName=String.Empty;
		public string InvestigtionName
		{
			get { return  _investigtionName; }
			set { _investigtionName = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		private string _investigationID=String.Empty;
		public string InvestigationID
		{
			get { return  _investigationID; }
			set { _investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the Action value.
		/// </summary>
		private string _action=String.Empty;
		public string Action
		{
			get { return  _action; }
			set { _action = value; }
		}

		/// <summary>
		/// Gets or sets the Outsource value.
		/// </summary>
		private string _outsource=String.Empty;
		public string Outsource
		{
			get { return  _outsource; }
			set { _outsource = value; }
		}

		/// <summary>
		/// Gets or sets the SampleMappingID value.
		/// </summary>
		private int _sampleMappingID=0;
		public int SampleMappingID
		{
			get { return  _sampleMappingID; }
			set { _sampleMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the IsOutsourcingSample value.
		/// </summary>
		private string _isOutsourcingSample=String.Empty;
		public string IsOutsourcingSample
		{
			get { return  _isOutsourcingSample; }
			set { _isOutsourcingSample = value; }
		}

		/// <summary>
		/// Gets or sets the IsAlicotedSample value.
		/// </summary>
		private string _isAlicotedSample=String.Empty;
		public string IsAlicotedSample
		{
			get { return  _isAlicotedSample; }
			set { _isAlicotedSample = value; }
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
		/// Gets or sets the FeeID value.
		/// </summary>
		private long _feeID=0;
		public long FeeID
		{
			get { return  _feeID; }
			set { _feeID = value; }
		}

		/// <summary>
		/// Gets or sets the SEX value.
		/// </summary>
		private string _sEX=String.Empty;
		public string SEX
		{
			get { return  _sEX; }
			set { _sEX = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		private string _age=String.Empty;
		public string Age
		{
			get { return  _age; }
			set { _age = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionDesc value.
		/// </summary>
		private string _conditionDesc=String.Empty;
		public string ConditionDesc
		{
			get { return  _conditionDesc; }
			set { _conditionDesc = value; }
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
		/// Gets or sets the SampleVolume value.
		/// </summary>
		private int _sampleVolume=0;
		public int SampleVolume
		{
			get { return  _sampleVolume; }
			set { _sampleVolume = value; }
		}

		/// <summary>
		/// Gets or sets the SampleUnit value.
		/// </summary>
		private string _sampleUnit=String.Empty;
		public string SampleUnit
		{
			get { return  _sampleUnit; }
			set { _sampleUnit = value; }
		}

		/// <summary>
		/// Gets or sets the INVID value.
		/// </summary>
		private long _iNVID=0;
		public long INVID
		{
			get { return  _iNVID; }
			set { _iNVID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the TestID value.
		/// </summary>
		private long _testID=0;
		public long TestID
		{
			get { return  _testID; }
			set { _testID = value; }
		}

		/// <summary>
		/// Gets or sets the Testname value.
		/// </summary>
		private string _testname=String.Empty;
		public string Testname
		{
			get { return  _testname; }
			set { _testname = value; }
		}

		/// <summary>
		/// Gets or sets the MeanTime value.
		/// </summary>
		private long _meanTime=0;
		public long MeanTime
		{
			get { return  _meanTime; }
			set { _meanTime = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		private long _patientID=0;
		public long PatientID
		{
			get { return  _patientID; }
			set { _patientID = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalDetailID value.
		/// </summary>
		private long _medicalDetailID=0;
		public long MedicalDetailID
		{
			get { return  _medicalDetailID; }
			set { _medicalDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the IsTimed value.
		/// </summary>
		private string _isTimed=String.Empty;
		public string IsTimed
		{
			get { return  _isTimed; }
			set { _isTimed = value; }
		}

		/// <summary>
		/// Gets or sets the Suffix value.
		/// </summary>
		private string _suffix=String.Empty;
		public string Suffix
		{
			get { return  _suffix; }
			set { _suffix = value; }
		}

		/// <summary>
		/// Gets or sets the AddExtraTube value.
		/// </summary>
		private string _addExtraTube=String.Empty;
		public string AddExtraTube
		{
			get { return  _addExtraTube; }
			set { _addExtraTube = value; }
		}

		/// <summary>
		/// Gets or sets the Param1 value.
		/// </summary>
		private string _param1=String.Empty;
		public string Param1
		{
			get { return  _param1; }
			set { _param1 = value; }
		}

		/// <summary>
		/// Gets or sets the Param2 value.
		/// </summary>
		private string _param2=String.Empty;
		public string Param2
		{
			get { return  _param2; }
			set { _param2 = value; }
		}

		/// <summary>
		/// Gets or sets the Param3 value.
		/// </summary>
		private string _param3=String.Empty;
		public string Param3
		{
			get { return  _param3; }
			set { _param3 = value; }
		}

		/// <summary>
		/// Gets or sets the Param4 value.
		/// </summary>
		private string _param4=String.Empty;
		public string Param4
		{
			get { return  _param4; }
			set { _param4 = value; }
		}

		/// <summary>
		/// Gets or sets the Param5 value.
		/// </summary>
		private string _param5=String.Empty;
		public string Param5
		{
			get { return  _param5; }
			set { _param5 = value; }
		}

		/// <summary>
		/// Gets or sets the Param6 value.
		/// </summary>
		private string _param6=String.Empty;
		public string Param6
		{
			get { return  _param6; }
			set { _param6 = value; }
		}

		/// <summary>
		/// Gets or sets the ID1 value.
		/// </summary>
		private long _iD1=0;
		public long ID1
		{
			get { return  _iD1; }
			set { _iD1 = value; }
		}

		/// <summary>
		/// Gets or sets the ID2 value.
		/// </summary>
		private long _iD2=0;
		public long ID2
		{
			get { return  _iD2; }
			set { _iD2 = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedDateTime value.
		/// </summary>
		private DateTime _receivedDateTime=DateTime.MaxValue;
		public DateTime ReceivedDateTime
		{
			get { return  _receivedDateTime; }
			set { _receivedDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the TransferedDateTime value.
		/// </summary>
		private DateTime _transferedDateTime=DateTime.MaxValue;
		public DateTime TransferedDateTime
		{
			get { return  _transferedDateTime; }
			set { _transferedDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the LocationType value.
		/// </summary>
		private string _locationType=String.Empty;
		public string LocationType
		{
			get { return  _locationType; }
			set { _locationType = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		private int _deptID=0;
		public int DeptID
		{
			get { return  _deptID; }
			set { _deptID = value; }
		}

		/// <summary>
		/// Gets or sets the IsMLNumber value.
		/// </summary>
		private string _isMLNumber=String.Empty;
		public string IsMLNumber
		{
			get { return  _isMLNumber; }
			set { _isMLNumber = value; }
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
		/// Gets or sets the IsHistoPathSample value.
		/// </summary>
		private string _isHistoPathSample=String.Empty;
		public string IsHistoPathSample
		{
			get { return  _isHistoPathSample; }
			set { _isHistoPathSample = value; }
		}

		/// <summary>
		/// Gets or sets the HistoPathSampleCount value.
		/// </summary>
		private int _histoPathSampleCount=0;
		public int HistoPathSampleCount
		{
			get { return  _histoPathSampleCount; }
			set { _histoPathSampleCount = value; }
		}

		/// <summary>
		/// Gets or sets the ReportDateTime value.
		/// </summary>
		private DateTime _reportDateTime=DateTime.MaxValue;
		public DateTime ReportDateTime
		{
			get { return  _reportDateTime; }
			set { _reportDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the RegisteredLocation value.
		/// </summary>
		private string _registeredLocation=String.Empty;
		public string RegisteredLocation
		{
			get { return  _registeredLocation; }
			set { _registeredLocation = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingLocation value.
		/// </summary>
		private string _processingLocation=String.Empty;
		public string ProcessingLocation
		{
			get { return  _processingLocation; }
			set { _processingLocation = value; }
		}

		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		private string _deptName=String.Empty;
		public string DeptName
		{
			get { return  _deptName; }
			set { _deptName = value; }
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
		/// Gets or sets the InvestigationCode value.
		/// </summary>
		private string _investigationCode=String.Empty;
		public string InvestigationCode
		{
			get { return  _investigationCode; }
			set { _investigationCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsSecondaryBarCode value.
		/// </summary>
		private string _isSecondaryBarCode=String.Empty;
		public string IsSecondaryBarCode
		{
			get { return  _isSecondaryBarCode; }
			set { _isSecondaryBarCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsShareAble value.
		/// </summary>
		private bool _isShareAble=false;
		public bool IsShareAble
		{
			get { return  _isShareAble; }
			set { _isShareAble = value; }
		}

		/// <summary>
		/// Gets or sets the Isinte value.
		/// </summary>
		private int _isinte=0;
		public int isinte
		{
			get { return  _isinte; }
			set { _isinte = value; }
		}
        public string ExternalBarcode
        {
            get { return externalBarcode; }
            set { externalBarcode = value; }
        }

        public int BarcodeCount
        {
            get { return barcodecount; }
            set { barcodecount = value; }
        }
		#endregion
}
}
