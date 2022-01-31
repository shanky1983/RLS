using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DischargeDetails
	{
		#region Fields

		private int dischargeID=0;
		private int dischargeTypeID=0;
		private long visitID=0;
		private string ambulanceRequired=String.Empty;
		private int patientConditionID=0;
        private DateTime dateTimeofDischarge = DateTime.MaxValue;
		private string attendeesName=String.Empty;
		private int relationID=0;
		private string contactNumber=String.Empty;
		private string ambulanceConfirmed=String.Empty;
		private int createdBy=0;
        private DateTime createdAt = DateTime.MaxValue;
		private int modifiedBy=0;
        private DateTime modifiedAt = DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargeID value.
		/// </summary>
		public int DischargeID
		{
			get { return dischargeID; }
			set { dischargeID = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeTypeID value.
		/// </summary>
		public int DischargeTypeID
		{
			get { return dischargeTypeID; }
			set { dischargeTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulanceRequired value.
		/// </summary>
		public string AmbulanceRequired
		{
			get { return ambulanceRequired; }
			set { ambulanceRequired = value; }
		}

		/// <summary>
		/// Gets or sets the PatientConditionID value.
		/// </summary>
		public int PatientConditionID
		{
			get { return patientConditionID; }
			set { patientConditionID = value; }
		}

		/// <summary>
		/// Gets or sets the DateTimeofDischarge value.
		/// </summary>
		public DateTime DateTimeofDischarge
		{
			get { return dateTimeofDischarge; }
			set { dateTimeofDischarge = value; }
		}

		/// <summary>
		/// Gets or sets the AttendeesName value.
		/// </summary>
		public string AttendeesName
		{
			get { return attendeesName; }
			set { attendeesName = value; }
		}

		/// <summary>
		/// Gets or sets the RelationID value.
		/// </summary>
		public int RelationID
		{
			get { return relationID; }
			set { relationID = value; }
		}

		/// <summary>
		/// Gets or sets the ContactNumber value.
		/// </summary>
		public string ContactNumber
		{
			get { return contactNumber; }
			set { contactNumber = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulanceConfirmed value.
		/// </summary>
		public string AmbulanceConfirmed
		{
			get { return ambulanceConfirmed; }
			set { ambulanceConfirmed = value; }
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


		#endregion
}
}
