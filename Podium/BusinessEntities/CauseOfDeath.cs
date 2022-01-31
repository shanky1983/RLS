using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CauseOfDeath
	{
		#region Fields

		private long causeOfDeathID=0;
		private long patientVisitID=0;
		private long causeOfDeathTypeID=0;
		private string causeOfDeathType=String.Empty;
		private int complaintID=0;
		private string complaintName=String.Empty;
		private string iCDCode=String.Empty;
		private string iCDDescription=String.Empty;
		private string iCDCodeStatus=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CauseOfDeathID value.
		/// </summary>
		public long CauseOfDeathID
		{
			get { return causeOfDeathID; }
			set { causeOfDeathID = value; }
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
		/// Gets or sets the CauseOfDeathTypeID value.
		/// </summary>
		public long CauseOfDeathTypeID
		{
			get { return causeOfDeathTypeID; }
			set { causeOfDeathTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CauseOfDeathType value.
		/// </summary>
		public string CauseOfDeathType
		{
			get { return causeOfDeathType; }
			set { causeOfDeathType = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		public string ComplaintName
		{
			get { return complaintName; }
			set { complaintName = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCode value.
		/// </summary>
		public string ICDCode
		{
			get { return iCDCode; }
			set { iCDCode = value; }
		}

		/// <summary>
		/// Gets or sets the ICDDescription value.
		/// </summary>
		public string ICDDescription
		{
			get { return iCDDescription; }
			set { iCDDescription = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCodeStatus value.
		/// </summary>
		public string ICDCodeStatus
		{
			get { return iCDCodeStatus; }
			set { iCDCodeStatus = value; }
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


		#endregion
}
}
