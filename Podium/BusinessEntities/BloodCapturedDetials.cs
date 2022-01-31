using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BloodCapturedDetials
	{
		#region Fields

		private long patientVisitID=0;
		private DateTime capturedTime=DateTime.MaxValue;
		private string heartRate=String.Empty;
		private string bloodPressure=String.Empty;
		private long saturation=0;
		private long volume=0;
		private string condition=String.Empty;
		private long orgID=0;

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
		/// Gets or sets the CapturedTime value.
		/// </summary>
		public DateTime CapturedTime
		{
			get { return capturedTime; }
			set { capturedTime = value; }
		}

		/// <summary>
		/// Gets or sets the HeartRate value.
		/// </summary>
		public string HeartRate
		{
			get { return heartRate; }
			set { heartRate = value; }
		}

		/// <summary>
		/// Gets or sets the BloodPressure value.
		/// </summary>
		public string BloodPressure
		{
			get { return bloodPressure; }
			set { bloodPressure = value; }
		}

		/// <summary>
		/// Gets or sets the Saturation value.
		/// </summary>
		public long Saturation
		{
			get { return saturation; }
			set { saturation = value; }
		}

		/// <summary>
		/// Gets or sets the Volume value.
		/// </summary>
		public long Volume
		{
			get { return volume; }
			set { volume = value; }
		}

		/// <summary>
		/// Gets or sets the Condition value.
		/// </summary>
		public string Condition
		{
			get { return condition; }
			set { condition = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
