using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OutsourcingDetail121
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


		#endregion
}
}
