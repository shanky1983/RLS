using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientInvSample_archival
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


		#endregion
}
}
