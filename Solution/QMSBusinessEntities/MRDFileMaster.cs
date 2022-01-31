using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MRDFileMaster
	{
		#region Fields

		private long mRDFileID=0;
		private long patientID=0;
		private long patientVisitId=0;
		private string patientName=String.Empty;
		private string patientNumber=String.Empty;
		private string visitNumber=String.Empty;
		private string specialityName=String.Empty;
		private DateTime visitDate=DateTime.MaxValue;
		private string processedStatus=String.Empty;
		private string cruntStatus=String.Empty;
		private int orgid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MRDFileID value.
		/// </summary>
		public long MRDFileID
		{
			get { return mRDFileID; }
			set { mRDFileID = value; }
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
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		public string PatientNumber
		{
			get { return patientNumber; }
			set { patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityName value.
		/// </summary>
		public string SpecialityName
		{
			get { return specialityName; }
			set { specialityName = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		public DateTime VisitDate
		{
			get { return visitDate; }
			set { visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessedStatus value.
		/// </summary>
		public string ProcessedStatus
		{
			get { return processedStatus; }
			set { processedStatus = value; }
		}

		/// <summary>
		/// Gets or sets the CruntStatus value.
		/// </summary>
		public string CruntStatus
		{
			get { return cruntStatus; }
			set { cruntStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}


		#endregion
}
}
