using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MISPatientVisit
	{
		#region Fields

		private long patientVisitId=0;
		private long patientID=0;
		private DateTime visitDate=DateTime.MaxValue;
		private long referOrgID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private int visitType=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string visitState=String.Empty;
		private string externalVisitID=String.Empty;
		private long referVisitID=0;
		private string visitNumber=String.Empty;
		private DateTime createdDate=DateTime.MaxValue;
		private TimeSpan createdtime=TimeSpan.MinValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
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
		/// Gets or sets the VisitDate value.
		/// </summary>
		public DateTime VisitDate
		{
			get { return visitDate; }
			set { visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReferOrgID value.
		/// </summary>
		public long ReferOrgID
		{
			get { return referOrgID; }
			set { referOrgID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		public int VisitType
		{
			get { return visitType; }
			set { visitType = value; }
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
		/// Gets or sets the VisitState value.
		/// </summary>
		public string VisitState
		{
			get { return visitState; }
			set { visitState = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitID value.
		/// </summary>
		public string ExternalVisitID
		{
			get { return externalVisitID; }
			set { externalVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferVisitID value.
		/// </summary>
		public long ReferVisitID
		{
			get { return referVisitID; }
			set { referVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedDate value.
		/// </summary>
		public DateTime CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}

		/// <summary>
		/// Gets or sets the Createdtime value.
		/// </summary>
		public TimeSpan Createdtime
		{
			get { return createdtime; }
			set { createdtime = value; }
		}


		#endregion
}
}
