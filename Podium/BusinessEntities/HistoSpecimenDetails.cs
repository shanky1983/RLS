using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HistoSpecimenDetails
	{
		#region Fields

		private long histoID=0;
		private long patientVisitID=0;
		private long iD=0;
		private string type=String.Empty;
		private int sampleID=0;
		private string sampleName=String.Empty;
		private int sampleCount=0;
		private string clinicalNotes=String.Empty;
		private string clinicalDiagnosis=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HistoID value.
		/// </summary>
		public long HistoID
		{
			get { return histoID; }
			set { histoID = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleName value.
		/// </summary>
		public string SampleName
		{
			get { return sampleName; }
			set { sampleName = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCount value.
		/// </summary>
		public int SampleCount
		{
			get { return sampleCount; }
			set { sampleCount = value; }
		}

		/// <summary>
		/// Gets or sets the ClinicalNotes value.
		/// </summary>
		public string ClinicalNotes
		{
			get { return clinicalNotes; }
			set { clinicalNotes = value; }
		}

		/// <summary>
		/// Gets or sets the ClinicalDiagnosis value.
		/// </summary>
		public string ClinicalDiagnosis
		{
			get { return clinicalDiagnosis; }
			set { clinicalDiagnosis = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}


		#endregion
}
}
