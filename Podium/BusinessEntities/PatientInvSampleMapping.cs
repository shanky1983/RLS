using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientInvSampleMapping
	{
		#region Fields

		private long visitID=0;
		private int orgID=0;
		private int sampleID=0;
		private long iD=0;
		private string type=String.Empty;
		private int deptID=0;
		private long sampleInstanceID=0;
		private string uID=String.Empty;
		private string barcode=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long sID=0;
		private long sequeceid=0;
		private long seqeuenceid=0;
		private string caseNumber=String.Empty;
		private bool isActive=false;
		private long currentLocationID=0;
        private string externalBarcode = String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
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
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleInstanceID value.
		/// </summary>
		public long SampleInstanceID
		{
			get { return sampleInstanceID; }
			set { sampleInstanceID = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		public string UID
		{
			get { return uID; }
			set { uID = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
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
		/// Gets or sets the SID value.
		/// </summary>
		public long SID
		{
			get { return sID; }
			set { sID = value; }
		}

		/// <summary>
		/// Gets or sets the Sequeceid value.
		/// </summary>
		public long Sequeceid
		{
			get { return sequeceid; }
			set { sequeceid = value; }
		}

		/// <summary>
		/// Gets or sets the Seqeuenceid value.
		/// </summary>
		public long Seqeuenceid
		{
			get { return seqeuenceid; }
			set { seqeuenceid = value; }
		}

		/// <summary>
		/// Gets or sets the CaseNumber value.
		/// </summary>
		public string CaseNumber
		{
			get { return caseNumber; }
			set { caseNumber = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentLocationID value.
		/// </summary>
		public long CurrentLocationID
		{
			get { return currentLocationID; }
			set { currentLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleMappingID value.
		/// </summary>
		private int _sampleMappingID=0;
		public int SampleMappingID
		{
			get { return  _sampleMappingID; }
			set { _sampleMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientIdentifyID value.
		/// </summary>
		private string _patientIdentifyID=String.Empty;
		public string PatientIdentifyID
		{
			get { return  _patientIdentifyID; }
			set { _patientIdentifyID = value; }
		}
        public string ExternalBarcode
        {
            get { return externalBarcode; }
            set { externalBarcode = value; }
        }


		#endregion
}
}
