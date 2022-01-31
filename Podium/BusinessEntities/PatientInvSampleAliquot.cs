using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientInvSampleAliquot
	{
		#region Fields

		private int iD=0;
		private long patientVisitID=0;
		private int sampleID=0;
		private string barcodeNumber=String.Empty;
		private string sequenceno=String.Empty;
		private int printed=0;
		private int layercount=0;
		private string samples=String.Empty;
		private string slidevalues=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string primaryBarcode=String.Empty;
		private string blockType=String.Empty;
		private string slideName=String.Empty;
		private string slideComments=String.Empty;
		private string stainType=String.Empty;
		private string status=String.Empty;
		private DateTime completionTime=DateTime.MaxValue;
		private long tissueCompletedby=0;

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
		/// Gets or sets the PrimaryBarcode value.
		/// </summary>
		public string PrimaryBarcode
		{
			get { return primaryBarcode; }
			set { primaryBarcode = value; }
		}

		/// <summary>
		/// Gets or sets the BlockType value.
		/// </summary>
		public string BlockType
		{
			get { return blockType; }
			set { blockType = value; }
		}

		/// <summary>
		/// Gets or sets the SlideName value.
		/// </summary>
		public string SlideName
		{
			get { return slideName; }
			set { slideName = value; }
		}

		/// <summary>
		/// Gets or sets the SlideComments value.
		/// </summary>
		public string SlideComments
		{
			get { return slideComments; }
			set { slideComments = value; }
		}

		/// <summary>
		/// Gets or sets the StainType value.
		/// </summary>
		public string StainType
		{
			get { return stainType; }
			set { stainType = value; }
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
		/// Gets or sets the CompletionTime value.
		/// </summary>
		public DateTime CompletionTime
		{
			get { return completionTime; }
			set { completionTime = value; }
		}

		/// <summary>
		/// Gets or sets the TissueCompletedby value.
		/// </summary>
		public long TissueCompletedby
		{
			get { return tissueCompletedby; }
			set { tissueCompletedby = value; }
		}


		#endregion
}
}
