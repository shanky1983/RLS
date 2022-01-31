using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SampleBatchTrackerDetails
	{
		#region Fields

		private long sampleBatchTrackerDetailsID=0;
		private long batchID=0;
		private string batchNo=String.Empty;
		private int sampleID=0;
		private long patientVisitID=0;
		private string barcodeNumber=String.Empty;
		private long investigationID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string batchStatus=String.Empty;
		private int sampleContainerID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SampleBatchTrackerDetailsID value.
		/// </summary>
		public long SampleBatchTrackerDetailsID
		{
			get { return sampleBatchTrackerDetailsID; }
			set { sampleBatchTrackerDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the BatchID value.
		/// </summary>
		public long BatchID
		{
			get { return batchID; }
			set { batchID = value; }
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
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
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
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		public string BarcodeNumber
		{
			get { return barcodeNumber; }
			set { barcodeNumber = value; }
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
		/// Gets or sets the BatchStatus value.
		/// </summary>
		public string BatchStatus
		{
			get { return batchStatus; }
			set { batchStatus = value; }
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
		/// Gets or sets the Category value.
		/// </summary>
		string _category;
		public string Category
		{
			get { return _category; }
			set { _category = value; }
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
		/// Gets or sets the SampleDesc value.
		/// </summary>
		string _sampledesc;
		public string SampleDesc
		{
			get { return _sampledesc; }
			set { _sampledesc = value; }
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


		#endregion
}
}
