using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AccidentRegistry
	{
		#region Fields

		private long aRID=0;
		private long patientVisitID=0;
		private string placeOfIncident=String.Empty;
		private DateTime timeOfIncident=DateTime.MaxValue;
		private string modeOfIncident=String.Empty;
		private string detailsOfInjury=String.Empty;
		private string patientCondition=String.Empty;
		private string consiousLevel=String.Empty;
		private string isPoliceIntimated=String.Empty;
		private string pSLocation=String.Empty;
		private string pSContactPerson=String.Empty;
		private string pSNumber=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ARID value.
		/// </summary>
		public long ARID
		{
			get { return aRID; }
			set { aRID = value; }
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
		/// Gets or sets the PlaceOfIncident value.
		/// </summary>
		public string PlaceOfIncident
		{
			get { return placeOfIncident; }
			set { placeOfIncident = value; }
		}

		/// <summary>
		/// Gets or sets the TimeOfIncident value.
		/// </summary>
		public DateTime TimeOfIncident
		{
			get { return timeOfIncident; }
			set { timeOfIncident = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOfIncident value.
		/// </summary>
		public string ModeOfIncident
		{
			get { return modeOfIncident; }
			set { modeOfIncident = value; }
		}

		/// <summary>
		/// Gets or sets the DetailsOfInjury value.
		/// </summary>
		public string DetailsOfInjury
		{
			get { return detailsOfInjury; }
			set { detailsOfInjury = value; }
		}

		/// <summary>
		/// Gets or sets the PatientCondition value.
		/// </summary>
		public string PatientCondition
		{
			get { return patientCondition; }
			set { patientCondition = value; }
		}

		/// <summary>
		/// Gets or sets the ConsiousLevel value.
		/// </summary>
		public string ConsiousLevel
		{
			get { return consiousLevel; }
			set { consiousLevel = value; }
		}

		/// <summary>
		/// Gets or sets the IsPoliceIntimated value.
		/// </summary>
		public string IsPoliceIntimated
		{
			get { return isPoliceIntimated; }
			set { isPoliceIntimated = value; }
		}

		/// <summary>
		/// Gets or sets the PSLocation value.
		/// </summary>
		public string PSLocation
		{
			get { return pSLocation; }
			set { pSLocation = value; }
		}

		/// <summary>
		/// Gets or sets the PSContactPerson value.
		/// </summary>
		public string PSContactPerson
		{
			get { return pSContactPerson; }
			set { pSContactPerson = value; }
		}

		/// <summary>
		/// Gets or sets the PSNumber value.
		/// </summary>
		public string PSNumber
		{
			get { return pSNumber; }
			set { pSNumber = value; }
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


		#endregion
}
}
