using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ANCPatientDetails
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private DateTime lMPDate=DateTime.MaxValue;
		private DateTime eDD=DateTime.MaxValue;
		private int cycleLength=0;
		private byte gravida=0x00;
		private byte para=0x00;
		private byte live=0x00;
		private byte abortus=0x00;
		private int pregTestConfirmedWeek=0;
		private string hasVisitedAnyOtherHospital=String.Empty;
		private string priorUSConfirmation=String.Empty;
		private int priorUSPerformedWeek=0;
		private string pregnancyStatus=String.Empty;
		private string isPrimipara=String.Empty;
		private string isBadObstretic=String.Empty;
		private int multipleGestation=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string admissionSuggested=String.Empty;
		private long admissionSuggestedVisitID=0;
		private string gPLAOthers=String.Empty;
		private string bloodGroup=String.Empty;

		#endregion

		#region Properties
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
		/// Gets or sets the LMPDate value.
		/// </summary>
		public DateTime LMPDate
		{
			get { return lMPDate; }
			set { lMPDate = value; }
		}

		/// <summary>
		/// Gets or sets the EDD value.
		/// </summary>
		public DateTime EDD
		{
			get { return eDD; }
			set { eDD = value; }
		}

		/// <summary>
		/// Gets or sets the CycleLength value.
		/// </summary>
		public int CycleLength
		{
			get { return cycleLength; }
			set { cycleLength = value; }
		}

		/// <summary>
		/// Gets or sets the Gravida value.
		/// </summary>
		public byte Gravida
		{
			get { return gravida; }
			set { gravida = value; }
		}

		/// <summary>
		/// Gets or sets the Para value.
		/// </summary>
		public byte Para
		{
			get { return para; }
			set { para = value; }
		}

		/// <summary>
		/// Gets or sets the Live value.
		/// </summary>
		public byte Live
		{
			get { return live; }
			set { live = value; }
		}

		/// <summary>
		/// Gets or sets the Abortus value.
		/// </summary>
		public byte Abortus
		{
			get { return abortus; }
			set { abortus = value; }
		}

		/// <summary>
		/// Gets or sets the PregTestConfirmedWeek value.
		/// </summary>
		public int PregTestConfirmedWeek
		{
			get { return pregTestConfirmedWeek; }
			set { pregTestConfirmedWeek = value; }
		}

		/// <summary>
		/// Gets or sets the HasVisitedAnyOtherHospital value.
		/// </summary>
		public string HasVisitedAnyOtherHospital
		{
			get { return hasVisitedAnyOtherHospital; }
			set { hasVisitedAnyOtherHospital = value; }
		}

		/// <summary>
		/// Gets or sets the PriorUSConfirmation value.
		/// </summary>
		public string PriorUSConfirmation
		{
			get { return priorUSConfirmation; }
			set { priorUSConfirmation = value; }
		}

		/// <summary>
		/// Gets or sets the PriorUSPerformedWeek value.
		/// </summary>
		public int PriorUSPerformedWeek
		{
			get { return priorUSPerformedWeek; }
			set { priorUSPerformedWeek = value; }
		}

		/// <summary>
		/// Gets or sets the PregnancyStatus value.
		/// </summary>
		public string PregnancyStatus
		{
			get { return pregnancyStatus; }
			set { pregnancyStatus = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrimipara value.
		/// </summary>
		public string IsPrimipara
		{
			get { return isPrimipara; }
			set { isPrimipara = value; }
		}

		/// <summary>
		/// Gets or sets the IsBadObstretic value.
		/// </summary>
		public string IsBadObstretic
		{
			get { return isBadObstretic; }
			set { isBadObstretic = value; }
		}

		/// <summary>
		/// Gets or sets the MultipleGestation value.
		/// </summary>
		public int MultipleGestation
		{
			get { return multipleGestation; }
			set { multipleGestation = value; }
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
		/// Gets or sets the AdmissionSuggested value.
		/// </summary>
		public string AdmissionSuggested
		{
			get { return admissionSuggested; }
			set { admissionSuggested = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionSuggestedVisitID value.
		/// </summary>
		public long AdmissionSuggestedVisitID
		{
			get { return admissionSuggestedVisitID; }
			set { admissionSuggestedVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the GPLAOthers value.
		/// </summary>
		public string GPLAOthers
		{
			get { return gPLAOthers; }
			set { gPLAOthers = value; }
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
		/// Gets or sets the NoOfWeeks value.
		/// </summary>
		private string _noOfWeeks=String.Empty;
		public string NoOfWeeks
		{
			get { return  _noOfWeeks; }
			set { _noOfWeeks = value; }
		}


		#endregion
}
}
