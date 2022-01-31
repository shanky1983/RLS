using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IPTreatmentPlanDetails
	{
		#region Fields

		private int surgeryPlanID=0;
		private long patientID=0;
		private long patientVisitID=0;
		private int treatmentPlanID=0;
		private string scrubTeam=String.Empty;
		private long surgeonID=0;
		private long anesthesiastID=0;
		private string isProvisional=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private int iPTreatmentPlanID=0;
		private DateTime treatmentPlanDate=DateTime.MaxValue;
		private string surgeonName=String.Empty;
		private string anesthesiastName=String.Empty;
		private string siteOfOperation=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SurgeryPlanID value.
		/// </summary>
		public int SurgeryPlanID
		{
			get { return surgeryPlanID; }
			set { surgeryPlanID = value; }
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
		/// Gets or sets the TreatmentPlanID value.
		/// </summary>
		public int TreatmentPlanID
		{
			get { return treatmentPlanID; }
			set { treatmentPlanID = value; }
		}

		/// <summary>
		/// Gets or sets the ScrubTeam value.
		/// </summary>
		public string ScrubTeam
		{
			get { return scrubTeam; }
			set { scrubTeam = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeonID value.
		/// </summary>
		public long SurgeonID
		{
			get { return surgeonID; }
			set { surgeonID = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiastID value.
		/// </summary>
		public long AnesthesiastID
		{
			get { return anesthesiastID; }
			set { anesthesiastID = value; }
		}

		/// <summary>
		/// Gets or sets the IsProvisional value.
		/// </summary>
		public string IsProvisional
		{
			get { return isProvisional; }
			set { isProvisional = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the IPTreatmentPlanID value.
		/// </summary>
		public int IPTreatmentPlanID
		{
			get { return iPTreatmentPlanID; }
			set { iPTreatmentPlanID = value; }
		}

		/// <summary>
		/// Gets or sets the TreatmentPlanDate value.
		/// </summary>
		public DateTime TreatmentPlanDate
		{
			get { return treatmentPlanDate; }
			set { treatmentPlanDate = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeonName value.
		/// </summary>
		public string SurgeonName
		{
			get { return surgeonName; }
			set { surgeonName = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiastName value.
		/// </summary>
		public string AnesthesiastName
		{
			get { return anesthesiastName; }
			set { anesthesiastName = value; }
		}

		/// <summary>
		/// Gets or sets the SiteOfOperation value.
		/// </summary>
		public string SiteOfOperation
		{
			get { return siteOfOperation; }
			set { siteOfOperation = value; }
		}

		/// <summary>
		/// Gets or sets the IPTreatmentPlanName value.
		/// </summary>
		string _iptreatmentplanname;
		public string IPTreatmentPlanName
		{
			get { return _iptreatmentplanname; }
			set { _iptreatmentplanname = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		string _parentid;
		public string ParentID
		{
			get { return _parentid; }
			set { _parentid = value; }
		}

		/// <summary>
		/// Gets or sets the Prosthesis value.
		/// </summary>
		string _prosthesis;
		public string Prosthesis
		{
			get { return _prosthesis; }
			set { _prosthesis = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		string _status;
		public string Status
		{
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the ParentName value.
		/// </summary>
		string _parentname;
		public string ParentName
		{
			get { return _parentname; }
			set { _parentname = value; }
		}

		/// <summary>
		/// Gets or sets the StagePlanned value.
		/// </summary>
		string _stageplanned;
		public string StagePlanned
		{
			get { return _stageplanned; }
			set { _stageplanned = value; }
		}

		/// <summary>
		/// Gets or sets the RoomName value.
		/// </summary>
		string _roomname;
		public string RoomName
		{
			get { return _roomname; }
			set { _roomname = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}


		#endregion
}
}
