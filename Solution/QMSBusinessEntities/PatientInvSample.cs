using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		/// Gets or sets the Reason value.
		/// </summary>
		string _reason;
		public string Reason
		{
			get { return _reason; }
			set { _reason = value; }
		}

		/// <summary>
		/// Gets or sets the InvSampleStatusDesc value.
		/// </summary>
		string _invsamplestatusdesc;
		public string InvSampleStatusDesc
		{
			get { return _invsamplestatusdesc; }
			set { _invsamplestatusdesc = value; }
		}

		/// <summary>
		/// Gets or sets the InvSampleStatusID value.
		/// </summary>
		long _invsamplestatusid;
		public long InvSampleStatusID
		{
			get { return _invsamplestatusid; }
			set { _invsamplestatusid = value; }
		}

		/// <summary>
		/// Gets or sets the SampleContainerName value.
		/// </summary>
		string _samplecontainername;
		public string SampleContainerName
		{
			get { return _samplecontainername; }
			set { _samplecontainername = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		string _locationname;
		public string LocationName
		{
			get { return _locationname; }
			set { _locationname = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigtionName value.
		/// </summary>
		string _investigtionname;
		public string InvestigtionName
		{
			get { return _investigtionname; }
			set { _investigtionname = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		string _investigationid;
		public string InvestigationID
		{
			get { return _investigationid; }
			set { _investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the Action value.
		/// </summary>
		string _action;
		public string Action
		{
			get { return _action; }
			set { _action = value; }
		}

		/// <summary>
		/// Gets or sets the Outsource value.
		/// </summary>
		string _outsource;
		public string Outsource
		{
			get { return _outsource; }
			set { _outsource = value; }
		}

		/// <summary>
		/// Gets or sets the SampleMappingID value.
		/// </summary>
		int _samplemappingid;
		public int SampleMappingID
		{
			get { return _samplemappingid; }
			set { _samplemappingid = value; }
		}

		/// <summary>
		/// Gets or sets the IsOutsourcingSample value.
		/// </summary>
		string _isoutsourcingsample;
		public string IsOutsourcingSample
		{
			get { return _isoutsourcingsample; }
			set { _isoutsourcingsample = value; }
		}

		/// <summary>
		/// Gets or sets the IsAlicotedSample value.
		/// </summary>
		string _isalicotedsample;
		public string IsAlicotedSample
		{
			get { return _isalicotedsample; }
			set { _isalicotedsample = value; }
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
		/// Gets or sets the FeeID value.
		/// </summary>
		long _feeid;
		public long FeeID
		{
			get { return _feeid; }
			set { _feeid = value; }
		}

		/// <summary>
		/// Gets or sets the SEX value.
		/// </summary>
		string _sex;
		public string SEX
		{
			get { return _sex; }
			set { _sex = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionDesc value.
		/// </summary>
		string _conditiondesc;
		public string ConditionDesc
		{
			get { return _conditiondesc; }
			set { _conditiondesc = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		string _remarks;
		public string Remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}

		/// <summary>
		/// Gets or sets the SampleVolume value.
		/// </summary>
		int _samplevolume;
		public int SampleVolume
		{
			get { return _samplevolume; }
			set { _samplevolume = value; }
		}

		/// <summary>
		/// Gets or sets the SampleUnit value.
		/// </summary>
		string _sampleunit;
		public string SampleUnit
		{
			get { return _sampleunit; }
			set { _sampleunit = value; }
		}

		/// <summary>
		/// Gets or sets the INVID value.
		/// </summary>
		long _invid;
		public long INVID
		{
			get { return _invid; }
			set { _invid = value; }
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
		/// Gets or sets the TestID value.
		/// </summary>
		long _testid;
		public long TestID
		{
			get { return _testid; }
			set { _testid = value; }
		}

		/// <summary>
		/// Gets or sets the Testname value.
		/// </summary>
		string _testname;
		public string Testname
		{
			get { return _testname; }
			set { _testname = value; }
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
		/// Gets or sets the MeanTime value.
		/// </summary>
		long _meantime;
		public long MeanTime
		{
			get { return _meantime; }
			set { _meantime = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		long _patientid;
		public long PatientID
		{
			get { return _patientid; }
			set { _patientid = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalDetailID value.
		/// </summary>
		long _medicaldetailid;
		public long MedicalDetailID
		{
			get { return _medicaldetailid; }
			set { _medicaldetailid = value; }
		}

		/// <summary>
		/// Gets or sets the IsTimed value.
		/// </summary>
		string _istimed;
		public string IsTimed
		{
			get { return _istimed; }
			set { _istimed = value; }
		}

		/// <summary>
		/// Gets or sets the Suffix value.
		/// </summary>
		string _suffix;
		public string Suffix
		{
			get { return _suffix; }
			set { _suffix = value; }
		}


		#endregion
}
}
