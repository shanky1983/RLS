using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _iPTreatmentPlanName=String.Empty;
		public string IPTreatmentPlanName
		{
			get { return  _iPTreatmentPlanName; }
			set { _iPTreatmentPlanName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		private string _parentID=String.Empty;
		public string ParentID
		{
			get { return  _parentID; }
			set { _parentID = value; }
		}

		/// <summary>
		/// Gets or sets the Prosthesis value.
		/// </summary>
		private string _prosthesis=String.Empty;
		public string Prosthesis
		{
			get { return  _prosthesis; }
			set { _prosthesis = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		private string _status=String.Empty;
		public string Status
		{
			get { return  _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the ParentName value.
		/// </summary>
		private string _parentName=String.Empty;
		public string ParentName
		{
			get { return  _parentName; }
			set { _parentName = value; }
		}

		/// <summary>
		/// Gets or sets the StagePlanned value.
		/// </summary>
		private string _stagePlanned=String.Empty;
		public string StagePlanned
		{
			get { return  _stagePlanned; }
			set { _stagePlanned = value; }
		}

		/// <summary>
		/// Gets or sets the RoomName value.
		/// </summary>
		private string _roomName=String.Empty;
		public string RoomName
		{
			get { return  _roomName; }
			set { _roomName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the WardName value.
		/// </summary>
		private string _wardName=String.Empty;
		public string WardName
		{
			get { return  _wardName; }
			set { _wardName = value; }
		}

		/// <summary>
		/// Gets or sets the ComplicationName value.
		/// </summary>
		private string _complicationName=String.Empty;
		public string ComplicationName
		{
			get { return  _complicationName; }
			set { _complicationName = value; }
		}

		/// <summary>
		/// Gets or sets the FromTime value.
		/// </summary>
		private DateTime _fromTime=DateTime.MaxValue;
		public DateTime FromTime
		{
			get { return  _fromTime; }
			set { _fromTime = value; }
		}

		/// <summary>
		/// Gets or sets the ToTime value.
		/// </summary>
		private DateTime _toTime=DateTime.MaxValue;
		public DateTime ToTime
		{
			get { return  _toTime; }
			set { _toTime = value; }
		}

		/// <summary>
		/// Gets or sets the PatientArrivalTimeOT value.
		/// </summary>
		private DateTime _patientArrivalTimeOT=DateTime.MaxValue;
		public DateTime PatientArrivalTimeOT
		{
			get { return  _patientArrivalTimeOT; }
			set { _patientArrivalTimeOT = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeonArrivalTime value.
		/// </summary>
		private DateTime _surgeonArrivalTime=DateTime.MaxValue;
		public DateTime SurgeonArrivalTime
		{
			get { return  _surgeonArrivalTime; }
			set { _surgeonArrivalTime = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiaTime value.
		/// </summary>
		private DateTime _anesthesiaTime=DateTime.MaxValue;
		public DateTime AnesthesiaTime
		{
			get { return  _anesthesiaTime; }
			set { _anesthesiaTime = value; }
		}

		/// <summary>
		/// Gets or sets the OperationStartTime value.
		/// </summary>
		private DateTime _operationStartTime=DateTime.MaxValue;
		public DateTime OperationStartTime
		{
			get { return  _operationStartTime; }
			set { _operationStartTime = value; }
		}

		/// <summary>
		/// Gets or sets the OperationEndTime value.
		/// </summary>
		private DateTime _operationEndTime=DateTime.MaxValue;
		public DateTime OperationEndTime
		{
			get { return  _operationEndTime; }
			set { _operationEndTime = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryType value.
		/// </summary>
		private string _surgeryType=String.Empty;
		public string SurgeryType
		{
			get { return  _surgeryType; }
			set { _surgeryType = value; }
		}

		/// <summary>
		/// Gets or sets the AgeText value.
		/// </summary>
		private string _ageText=String.Empty;
		public string AgeText
		{
			get { return  _ageText; }
			set { _ageText = value; }
		}

		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		private long _taskID=0;
		public long TaskID
		{
			get { return  _taskID; }
			set { _taskID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureName value.
		/// </summary>
		private string _procedureName=String.Empty;
		public string ProcedureName
		{
			get { return  _procedureName; }
			set { _procedureName = value; }
		}


		#endregion
}
}
