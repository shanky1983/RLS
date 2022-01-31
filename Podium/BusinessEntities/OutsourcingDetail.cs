using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OutsourcingDetail
	{
		#region Fields

		private long outsourcingDetailID=0;
		private long sampleTrackerID=0;
		private long sampleID=0;
		private long patientVisitID=0;
		private int orgId=0;
		private string uID=String.Empty;
		private DateTime outsourcedDate=DateTime.MaxValue;
		private DateTime receivedDate=DateTime.MaxValue;
		private string courierDetails=String.Empty;
		private string acknowledgement=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private bool absolute=false;
		private DateTime reachedDate=DateTime.MaxValue;
		private string status=String.Empty;
		private long accessionNumber=0;
		private long investigationID=0;
		private long outSourcingLocationID=0;
		private string type=String.Empty;
		private string refID=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OutsourcingDetailID value.
		/// </summary>
		public long OutsourcingDetailID
		{
			get { return outsourcingDetailID; }
			set { outsourcingDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleTrackerID value.
		/// </summary>
		public long SampleTrackerID
		{
			get { return sampleTrackerID; }
			set { sampleTrackerID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public long SampleID
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the OutsourcedDate value.
		/// </summary>
		public DateTime OutsourcedDate
		{
			get { return outsourcedDate; }
			set { outsourcedDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedDate value.
		/// </summary>
		public DateTime ReceivedDate
		{
			get { return receivedDate; }
			set { receivedDate = value; }
		}

		/// <summary>
		/// Gets or sets the CourierDetails value.
		/// </summary>
		public string CourierDetails
		{
			get { return courierDetails; }
			set { courierDetails = value; }
		}

		/// <summary>
		/// Gets or sets the Acknowledgement value.
		/// </summary>
		public string Acknowledgement
		{
			get { return acknowledgement; }
			set { acknowledgement = value; }
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
		/// Gets or sets the Absolute value.
		/// </summary>
		public bool Absolute
		{
			get { return absolute; }
			set { absolute = value; }
		}

		/// <summary>
		/// Gets or sets the ReachedDate value.
		/// </summary>
		public DateTime ReachedDate
		{
			get { return reachedDate; }
			set { reachedDate = value; }
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
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
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
		/// Gets or sets the OutSourcingLocationID value.
		/// </summary>
		public long OutSourcingLocationID
		{
			get { return outSourcingLocationID; }
			set { outSourcingLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the RefID value.
		/// </summary>
		public string RefID
		{
			get { return refID; }
			set { refID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		private string _sampleDesc=String.Empty;
		public string SampleDesc
		{
			get { return  _sampleDesc; }
			set { _sampleDesc = value; }
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
		/// Gets or sets the InvSampleStatusDesc value.
		/// </summary>
		private string _invSampleStatusDesc=String.Empty;
		public string InvSampleStatusDesc
		{
			get { return  _invSampleStatusDesc; }
			set { _invSampleStatusDesc = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		private string _barcodeNumber=String.Empty;
		public string BarcodeNumber
		{
			get { return  _barcodeNumber; }
			set { _barcodeNumber = value; }
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
		/// Gets or sets the GUID value.
		/// </summary>
		private string _gUID=String.Empty;
		public string GUID
		{
			get { return  _gUID; }
			set { _gUID = value; }
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
		/// Gets or sets the InvSampleStatusID value.
		/// </summary>
		private int _invSampleStatusID=0;
		public int InvSampleStatusID
		{
			get { return  _invSampleStatusID; }
			set { _invSampleStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientStatus value.
		/// </summary>
		private string _patientStatus=String.Empty;
		public string PatientStatus
		{
			get { return  _patientStatus; }
			set { _patientStatus = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedLocationName value.
		/// </summary>
		private string _collectedLocationName=String.Empty;
		public string CollectedLocationName
		{
			get { return  _collectedLocationName; }
			set { _collectedLocationName = value; }
		}

		/// <summary>
		/// Gets or sets the OutSourcedOrgName value.
		/// </summary>
		private string _outSourcedOrgName=String.Empty;
		public string OutSourcedOrgName
		{
			get { return  _outSourcedOrgName; }
			set { _outSourcedOrgName = value; }
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
		/// Gets or sets the TaskID value.
		/// </summary>
		private long _taskID=0;
		public long TaskID
		{
			get { return  _taskID; }
			set { _taskID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		private string _patientNumber=String.Empty;
		public string PatientNumber
		{
			get { return  _patientNumber; }
			set { _patientNumber = value; }
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
		/// Gets or sets the InvestigationName value.
		/// </summary>
		private string _investigationName=String.Empty;
		public string InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		private Decimal _rate=Decimal.Zero;
		public Decimal Rate
		{
			get { return  _rate; }
			set { _rate = value; }
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
		/// Gets or sets the FeeDescription value.
		/// </summary>
		private string _feeDescription=String.Empty;
		public string FeeDescription
		{
			get { return  _feeDescription; }
			set { _feeDescription = value; }
		}

		/// <summary>
		/// Gets or sets the RefOrgName value.
		/// </summary>
		private string _refOrgName=String.Empty;
		public string RefOrgName
		{
			get { return  _refOrgName; }
			set { _refOrgName = value; }
		}


		#endregion
}
}
