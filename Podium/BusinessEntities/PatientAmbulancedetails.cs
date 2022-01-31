using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientAmbulancedetails
	{
		#region Fields

		private long ambulancedetailsID=0;
		private long ambulanceID=0;
		private long finalBillID=0;
		private long patientVisitID=0;
		private long driverID=0;
		private long locationID=0;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private DateTime ambulancearrivalFromdate=DateTime.MaxValue;
		private DateTime ambulancearrivalTodate=DateTime.MaxValue;
		private long distancekgm=0;
		private long duration=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AmbulancedetailsID value.
		/// </summary>
		public long AmbulancedetailsID
		{
			get { return ambulancedetailsID; }
			set { ambulancedetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulanceID value.
		/// </summary>
		public long AmbulanceID
		{
			get { return ambulanceID; }
			set { ambulanceID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
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
		/// Gets or sets the DriverID value.
		/// </summary>
		public long DriverID
		{
			get { return driverID; }
			set { driverID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulancearrivalFromdate value.
		/// </summary>
		public DateTime AmbulancearrivalFromdate
		{
			get { return ambulancearrivalFromdate; }
			set { ambulancearrivalFromdate = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulancearrivalTodate value.
		/// </summary>
		public DateTime AmbulancearrivalTodate
		{
			get { return ambulancearrivalTodate; }
			set { ambulancearrivalTodate = value; }
		}

		/// <summary>
		/// Gets or sets the Distancekgm value.
		/// </summary>
		public long Distancekgm
		{
			get { return distancekgm; }
			set { distancekgm = value; }
		}

		/// <summary>
		/// Gets or sets the Duration value.
		/// </summary>
		public long Duration
		{
			get { return duration; }
			set { duration = value; }
		}


		#endregion
}
}
