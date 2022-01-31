using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AnesthesiaDetails
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private string nPODuration=String.Empty;
		private string scoringSystem=String.Empty;
		private string scoreValue=String.Empty;
		private string anesthesiaNotes=String.Empty;
		private string investigationName=String.Empty;
		private string invResult=String.Empty;
		private string anesthesiaModes=String.Empty;
		private DateTime startTime=DateTime.MaxValue;
		private DateTime endTime=DateTime.MaxValue;
		private string anesthesiaType=String.Empty;
		private string complications=String.Empty;

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
		/// Gets or sets the NPODuration value.
		/// </summary>
		public string NPODuration
		{
			get { return nPODuration; }
			set { nPODuration = value; }
		}

		/// <summary>
		/// Gets or sets the ScoringSystem value.
		/// </summary>
		public string ScoringSystem
		{
			get { return scoringSystem; }
			set { scoringSystem = value; }
		}

		/// <summary>
		/// Gets or sets the ScoreValue value.
		/// </summary>
		public string ScoreValue
		{
			get { return scoreValue; }
			set { scoreValue = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiaNotes value.
		/// </summary>
		public string AnesthesiaNotes
		{
			get { return anesthesiaNotes; }
			set { anesthesiaNotes = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the InvResult value.
		/// </summary>
		public string InvResult
		{
			get { return invResult; }
			set { invResult = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiaModes value.
		/// </summary>
		public string AnesthesiaModes
		{
			get { return anesthesiaModes; }
			set { anesthesiaModes = value; }
		}

		/// <summary>
		/// Gets or sets the StartTime value.
		/// </summary>
		public DateTime StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		/// <summary>
		/// Gets or sets the EndTime value.
		/// </summary>
		public DateTime EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiaType value.
		/// </summary>
		public string AnesthesiaType
		{
			get { return anesthesiaType; }
			set { anesthesiaType = value; }
		}

		/// <summary>
		/// Gets or sets the Complications value.
		/// </summary>
		public string Complications
		{
			get { return complications; }
			set { complications = value; }
		}


		#endregion
}
}
