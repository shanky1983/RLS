using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SampleBatchScanOutDetailsHistory
	{
		#region Fields

		private int batchID=0;
		private string labNumber=String.Empty;
		private string labCode=String.Empty;
		private string batchNo=String.Empty;
		private string barcodeNumber=String.Empty;
		private int deptId=0;
		private string status=String.Empty;
		private int sampleId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long visitId=0;
		private int invSampleId=0;
		private string accessionNo=String.Empty;
		private string collectionCenter=String.Empty;
		private DateTime receivedTime=DateTime.MaxValue;
		private string patientRegisterdType=String.Empty;
		private int scanCount=0;
		private long orgId=0;
		private long addressId=0;
		private string sampleStatus=String.Empty;
		private int teamID=0;
		private string teamName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BatchID value.
		/// </summary>
		public int BatchID
		{
			get { return batchID; }
			set { batchID = value; }
		}

		/// <summary>
		/// Gets or sets the LabNumber value.
		/// </summary>
		public string LabNumber
		{
			get { return labNumber; }
			set { labNumber = value; }
		}

		/// <summary>
		/// Gets or sets the LabCode value.
		/// </summary>
		public string LabCode
		{
			get { return labCode; }
			set { labCode = value; }
		}

		/// <summary>
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
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
		/// Gets or sets the DeptId value.
		/// </summary>
		public int DeptId
		{
			get { return deptId; }
			set { deptId = value; }
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
		/// Gets or sets the SampleId value.
		/// </summary>
		public int SampleId
		{
			get { return sampleId; }
			set { sampleId = value; }
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
		/// Gets or sets the VisitId value.
		/// </summary>
		public long VisitId
		{
			get { return visitId; }
			set { visitId = value; }
		}

		/// <summary>
		/// Gets or sets the InvSampleId value.
		/// </summary>
		public int InvSampleId
		{
			get { return invSampleId; }
			set { invSampleId = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNo value.
		/// </summary>
		public string AccessionNo
		{
			get { return accessionNo; }
			set { accessionNo = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionCenter value.
		/// </summary>
		public string CollectionCenter
		{
			get { return collectionCenter; }
			set { collectionCenter = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedTime value.
		/// </summary>
		public DateTime ReceivedTime
		{
			get { return receivedTime; }
			set { receivedTime = value; }
		}

		/// <summary>
		/// Gets or sets the PatientRegisterdType value.
		/// </summary>
		public string PatientRegisterdType
		{
			get { return patientRegisterdType; }
			set { patientRegisterdType = value; }
		}

		/// <summary>
		/// Gets or sets the ScanCount value.
		/// </summary>
		public int ScanCount
		{
			get { return scanCount; }
			set { scanCount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the AddressId value.
		/// </summary>
		public long AddressId
		{
			get { return addressId; }
			set { addressId = value; }
		}

		/// <summary>
		/// Gets or sets the SampleStatus value.
		/// </summary>
		public string SampleStatus
		{
			get { return sampleStatus; }
			set { sampleStatus = value; }
		}

		/// <summary>
		/// Gets or sets the TeamID value.
		/// </summary>
		public int TeamID
		{
			get { return teamID; }
			set { teamID = value; }
		}

		/// <summary>
		/// Gets or sets the TeamName value.
		/// </summary>
		public string TeamName
		{
			get { return teamName; }
			set { teamName = value; }
		}


		#endregion
}
}
