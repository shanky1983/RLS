using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BloodCollectionDetails
	{
		#region Fields

		private long patientVisitID=0;
		private string bagNumber=String.Empty;
		private string bagType=String.Empty;
		private string bagCapacity=String.Empty;
		private string tubeID=String.Empty;
		private string antiCoagulants=String.Empty;
		private string bloodComponent=String.Empty;
		private string bloodGroup=String.Empty;
		private DateTime collectedDate=DateTime.MaxValue;
		private DateTime seperatedDate=DateTime.MaxValue;
		private DateTime reconstitutedDate=DateTime.MaxValue;
		private DateTime expiryDate=DateTime.MaxValue;
		private string storageSlot=String.Empty;
		private long orgID=0;
		private int parentID=0;
		private string status=String.Empty;

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
		/// Gets or sets the BagNumber value.
		/// </summary>
		public string BagNumber
		{
			get { return bagNumber; }
			set { bagNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BagType value.
		/// </summary>
		public string BagType
		{
			get { return bagType; }
			set { bagType = value; }
		}

		/// <summary>
		/// Gets or sets the BagCapacity value.
		/// </summary>
		public string BagCapacity
		{
			get { return bagCapacity; }
			set { bagCapacity = value; }
		}

		/// <summary>
		/// Gets or sets the TubeID value.
		/// </summary>
		public string TubeID
		{
			get { return tubeID; }
			set { tubeID = value; }
		}

		/// <summary>
		/// Gets or sets the AntiCoagulants value.
		/// </summary>
		public string AntiCoagulants
		{
			get { return antiCoagulants; }
			set { antiCoagulants = value; }
		}

		/// <summary>
		/// Gets or sets the BloodComponent value.
		/// </summary>
		public string BloodComponent
		{
			get { return bloodComponent; }
			set { bloodComponent = value; }
		}

		/// <summary>
		/// Gets or sets the BloodGroup value.
		/// </summary>
		public string BloodGroup
		{
			get { return bloodGroup; }
			set { bloodGroup = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedDate value.
		/// </summary>
		public DateTime CollectedDate
		{
			get { return collectedDate; }
			set { collectedDate = value; }
		}

		/// <summary>
		/// Gets or sets the SeperatedDate value.
		/// </summary>
		public DateTime SeperatedDate
		{
			get { return seperatedDate; }
			set { seperatedDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReconstitutedDate value.
		/// </summary>
		public DateTime ReconstitutedDate
		{
			get { return reconstitutedDate; }
			set { reconstitutedDate = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return expiryDate; }
			set { expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the StorageSlot value.
		/// </summary>
		public string StorageSlot
		{
			get { return storageSlot; }
			set { storageSlot = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
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
		/// Gets or sets the BatchNo value.
		/// </summary>
		string _batchno;
		public string BatchNo
		{
			get { return _batchno; }
			set { _batchno = value; }
		}


		#endregion
}
}
