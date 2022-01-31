using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AliqoutBarcodeLayer_History
	{
		#region Fields

		private int id=0;
		private long patientVisitID=0;
		private int sampleID=0;
		private string barcodeNumber=String.Empty;
		private int sequenceno=0;
		private int printed=0;
		private int layer=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string samples=String.Empty;
		private string slidevalues=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
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
		public int Sequenceno
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
		/// Gets or sets the Layer value.
		/// </summary>
		public int Layer
		{
			get { return layer; }
			set { layer = value; }
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


		#endregion
}
}
