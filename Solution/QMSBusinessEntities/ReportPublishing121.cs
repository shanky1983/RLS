using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReportPublishing121
	{
		#region Fields

		private long resultPublishID=0;
		private long patientVisitID=0;
		private long patientID=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private string receiverType=String.Empty;
		private long reportPublishingID=0;
		private long accessionNumber=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ResultPublishID value.
		/// </summary>
		public long ResultPublishID
		{
			get { return resultPublishID; }
			set { resultPublishID = value; }
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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiverType value.
		/// </summary>
		public string ReceiverType
		{
			get { return receiverType; }
			set { receiverType = value; }
		}

		/// <summary>
		/// Gets or sets the ReportPublishingID value.
		/// </summary>
		public long ReportPublishingID
		{
			get { return reportPublishingID; }
			set { reportPublishingID = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}


		#endregion
}
}
