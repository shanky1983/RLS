using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientInvSampleAliquot_History
	{
		#region Fields

		private int iD=0;
		private long patientVisitID=0;
		private int sampleID=0;
		private string barcodeNumber=String.Empty;
		private string sequenceno=String.Empty;
		private int printed=0;
		private int layercount=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string samples=String.Empty;
		private string slidevalues=String.Empty;
		private int orgID=0;
		private string status=String.Empty;
		private DateTime slideCompletionTime=DateTime.MaxValue;
		private DateTime stainCompletionTime=DateTime.MaxValue;
		private DateTime microCompletionTime=DateTime.MaxValue;
		private long slideCompletedby=0;
		private long stainCompletedby=0;
		private long microCompletedby=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		public string BarcodeNumber
		{
			get { return barcodeNumber; }
			set { barcodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Sequenceno value.
		/// </summary>
		public string Sequenceno
		{
			get { return sequenceno; }
			set { sequenceno = value; }
		}

		/// <summary>
		/// Gets or sets the Printed value.
		/// </summary>
		public int Printed
		{
			get { return printed; }
			set { printed = value; }
		}

		/// <summary>
		/// Gets or sets the Layercount value.
		/// </summary>
		public int Layercount
		{
			get { return layercount; }
			set { layercount = value; }
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
		/// Gets or sets the Samples value.
		/// </summary>
		public string Samples
		{
			get { return samples; }
			set { samples = value; }
		}

		/// <summary>
		/// Gets or sets the Slidevalues value.
		/// </summary>
		public string Slidevalues
		{
			get { return slidevalues; }
			set { slidevalues = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the SlideCompletionTime value.
		/// </summary>
		public DateTime SlideCompletionTime
		{
			get { return slideCompletionTime; }
			set { slideCompletionTime = value; }
		}

		/// <summary>
		/// Gets or sets the StainCompletionTime value.
		/// </summary>
		public DateTime StainCompletionTime
		{
			get { return stainCompletionTime; }
			set { stainCompletionTime = value; }
		}

		/// <summary>
		/// Gets or sets the MicroCompletionTime value.
		/// </summary>
		public DateTime MicroCompletionTime
		{
			get { return microCompletionTime; }
			set { microCompletionTime = value; }
		}

		/// <summary>
		/// Gets or sets the SlideCompletedby value.
		/// </summary>
		public long SlideCompletedby
		{
			get { return slideCompletedby; }
			set { slideCompletedby = value; }
		}

		/// <summary>
		/// Gets or sets the StainCompletedby value.
		/// </summary>
		public long StainCompletedby
		{
			get { return stainCompletedby; }
			set { stainCompletedby = value; }
		}

		/// <summary>
		/// Gets or sets the MicroCompletedby value.
		/// </summary>
		public long MicroCompletedby
		{
			get { return microCompletedby; }
			set { microCompletedby = value; }
		}


		#endregion
}
}
