using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BloodReceive
	{
		#region Fields

		private long bloodReceiveID=0;
		private long patientID=0;
		private long patientVisitID=0;
		private DateTime requestDate=DateTime.MaxValue;
		private DateTime transfusionScheduledDate=DateTime.MaxValue;
		private string status=String.Empty;
		private string clinicalIndication=String.Empty;
		private long crossMatchingMethod=0;
		private string hasPreviousTranfusion=String.Empty;
		private long previousTransfusionComponent=0;
		private DateTime previousTransfusionDate=DateTime.MaxValue;
		private string previousTransfusionReaction=String.Empty;
		private string isPregnant=String.Empty;
		private string pregnancyDetails=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BloodReceiveID value.
		/// </summary>
		public long BloodReceiveID
		{
			get { return bloodReceiveID; }
			set { bloodReceiveID = value; }
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
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestDate value.
		/// </summary>
		public DateTime RequestDate
		{
			get { return requestDate; }
			set { requestDate = value; }
		}

		/// <summary>
		/// Gets or sets the TransfusionScheduledDate value.
		/// </summary>
		public DateTime TransfusionScheduledDate
		{
			get { return transfusionScheduledDate; }
			set { transfusionScheduledDate = value; }
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
		/// Gets or sets the ClinicalIndication value.
		/// </summary>
		public string ClinicalIndication
		{
			get { return clinicalIndication; }
			set { clinicalIndication = value; }
		}

		/// <summary>
		/// Gets or sets the CrossMatchingMethod value.
		/// </summary>
		public long CrossMatchingMethod
		{
			get { return crossMatchingMethod; }
			set { crossMatchingMethod = value; }
		}

		/// <summary>
		/// Gets or sets the HasPreviousTranfusion value.
		/// </summary>
		public string HasPreviousTranfusion
		{
			get { return hasPreviousTranfusion; }
			set { hasPreviousTranfusion = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousTransfusionComponent value.
		/// </summary>
		public long PreviousTransfusionComponent
		{
			get { return previousTransfusionComponent; }
			set { previousTransfusionComponent = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousTransfusionDate value.
		/// </summary>
		public DateTime PreviousTransfusionDate
		{
			get { return previousTransfusionDate; }
			set { previousTransfusionDate = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousTransfusionReaction value.
		/// </summary>
		public string PreviousTransfusionReaction
		{
			get { return previousTransfusionReaction; }
			set { previousTransfusionReaction = value; }
		}

		/// <summary>
		/// Gets or sets the IsPregnant value.
		/// </summary>
		public string IsPregnant
		{
			get { return isPregnant; }
			set { isPregnant = value; }
		}

		/// <summary>
		/// Gets or sets the PregnancyDetails value.
		/// </summary>
		public string PregnancyDetails
		{
			get { return pregnancyDetails; }
			set { pregnancyDetails = value; }
		}


		#endregion
}
}
