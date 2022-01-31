using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Sampletracker_History
	{
		#region Fields

		private int sampleTrackerID=0;
		private long patientVisitID=0;
		private int sampleID=0;
		private int invSampleStatusID=0;
		private int currentOrgID=0;
		private int deptID=0;
		private string reason=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long iPInvSampleCollectionMasterID=0;
		private int orgID=0;
		private int collectedIn=0;
		private string barcode=String.Empty;
		private string remarks=String.Empty;
		private int sampleVolume=0;
		private string sampleUnit=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SampleTrackerID value.
		/// </summary>
		public int SampleTrackerID
		{
			get { return sampleTrackerID; }
			set { sampleTrackerID = value; }
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
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the InvSampleStatusID value.
		/// </summary>
		public int InvSampleStatusID
		{
			get { return invSampleStatusID; }
			set { invSampleStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentOrgID value.
		/// </summary>
		public int CurrentOrgID
		{
			get { return currentOrgID; }
			set { currentOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
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
		/// Gets or sets the CollectedIn value.
		/// </summary>
		public int CollectedIn
		{
			get { return collectedIn; }
			set { collectedIn = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the SampleVolume value.
		/// </summary>
		public int SampleVolume
		{
			get { return sampleVolume; }
			set { sampleVolume = value; }
		}

		/// <summary>
		/// Gets or sets the SampleUnit value.
		/// </summary>
		public string SampleUnit
		{
			get { return sampleUnit; }
			set { sampleUnit = value; }
		}


		#endregion
}
}
