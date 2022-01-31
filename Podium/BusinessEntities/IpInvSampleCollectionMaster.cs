using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IpInvSampleCollectionMaster
	{
		#region Fields

		private long patientVisitID=0;
		private long iPInvSampleCollectionMasterID=0;
		private string collectedDateTime=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

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
		/// Gets or sets the IPInvSampleCollectionMasterID value.
		/// </summary>
		public long IPInvSampleCollectionMasterID
		{
			get { return iPInvSampleCollectionMasterID; }
			set { iPInvSampleCollectionMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedDateTime value.
		/// </summary>
		public string CollectedDateTime
		{
			get { return collectedDateTime; }
			set { collectedDateTime = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
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


		#endregion
}
}
