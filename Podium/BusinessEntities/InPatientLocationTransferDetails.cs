using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InPatientLocationTransferDetails
	{
		#region Fields

		private long transferLocationID=0;
		private int patientID=0;
		private int visitID=0;
		private int fromBedID=0;
		private int toBedID=0;
		private DateTime dateOfTransfer=DateTime.MaxValue;
		private string conditionOnTransfer=String.Empty;
		private string transferInitiatedType=String.Empty;
		private string transferInitiatedBy=String.Empty;
		private int transferPerformedBy=0;
		private string reasonForTransfer=String.Empty;
		private string attendeesAccompanying1=String.Empty;
		private string attendeesAccompanying1Phone=String.Empty;
		private string attendeesAccompanying2=String.Empty;
		private string attendeesAccompanying2Phone=String.Empty;
		private int orgID=0;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TransferLocationID value.
		/// </summary>
		public long TransferLocationID
		{
			get { return transferLocationID; }
			set { transferLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public int PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public int VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the FromBedID value.
		/// </summary>
		public int FromBedID
		{
			get { return fromBedID; }
			set { fromBedID = value; }
		}

		/// <summary>
		/// Gets or sets the ToBedID value.
		/// </summary>
		public int ToBedID
		{
			get { return toBedID; }
			set { toBedID = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfTransfer value.
		/// </summary>
		public DateTime DateOfTransfer
		{
			get { return dateOfTransfer; }
			set { dateOfTransfer = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionOnTransfer value.
		/// </summary>
		public string ConditionOnTransfer
		{
			get { return conditionOnTransfer; }
			set { conditionOnTransfer = value; }
		}

		/// <summary>
		/// Gets or sets the TransferInitiatedType value.
		/// </summary>
		public string TransferInitiatedType
		{
			get { return transferInitiatedType; }
			set { transferInitiatedType = value; }
		}

		/// <summary>
		/// Gets or sets the TransferInitiatedBy value.
		/// </summary>
		public string TransferInitiatedBy
		{
			get { return transferInitiatedBy; }
			set { transferInitiatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the TransferPerformedBy value.
		/// </summary>
		public int TransferPerformedBy
		{
			get { return transferPerformedBy; }
			set { transferPerformedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonForTransfer value.
		/// </summary>
		public string ReasonForTransfer
		{
			get { return reasonForTransfer; }
			set { reasonForTransfer = value; }
		}

		/// <summary>
		/// Gets or sets the AttendeesAccompanying1 value.
		/// </summary>
		public string AttendeesAccompanying1
		{
			get { return attendeesAccompanying1; }
			set { attendeesAccompanying1 = value; }
		}

		/// <summary>
		/// Gets or sets the AttendeesAccompanying1Phone value.
		/// </summary>
		public string AttendeesAccompanying1Phone
		{
			get { return attendeesAccompanying1Phone; }
			set { attendeesAccompanying1Phone = value; }
		}

		/// <summary>
		/// Gets or sets the AttendeesAccompanying2 value.
		/// </summary>
		public string AttendeesAccompanying2
		{
			get { return attendeesAccompanying2; }
			set { attendeesAccompanying2 = value; }
		}

		/// <summary>
		/// Gets or sets the AttendeesAccompanying2Phone value.
		/// </summary>
		public string AttendeesAccompanying2Phone
		{
			get { return attendeesAccompanying2Phone; }
			set { attendeesAccompanying2Phone = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the RateID value.
		/// </summary>
		private int _rateID=0;
		public int RateID
		{
			get { return  _rateID; }
			set { _rateID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private int _clientID=0;
		public int ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}

		/// <summary>
		/// Gets or sets the IsTransferMotherRoom value.
		/// </summary>
		private string _isTransferMotherRoom=String.Empty;
		public string IsTransferMotherRoom
		{
			get { return  _isTransferMotherRoom; }
			set { _isTransferMotherRoom = value; }
		}


		#endregion
}
}
