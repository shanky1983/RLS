using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AttuneRptPIS
	{
		#region Fields

		private long sampleid=0;
		private long accessionNumber=0;
		private string barcodeNumber=String.Empty;
		private int sampleCode=0;
		private string sampleDesc=String.Empty;
		private DateTime collectedDateTime=DateTime.MaxValue;
		private int recSampleLocID=0;
		private int collectedLocID=0;
		private long createdby=0;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private int patientVisitID=0;
		private int sampleRelationshipID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Sampleid value.
		/// </summary>
		public long Sampleid
		{
			get { return sampleid; }
			set { sampleid = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
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
		/// Gets or sets the SampleCode value.
		/// </summary>
		public int SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		public string SampleDesc
		{
			get { return sampleDesc; }
			set { sampleDesc = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedDateTime value.
		/// </summary>
		public DateTime CollectedDateTime
		{
			get { return collectedDateTime; }
			set { collectedDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the RecSampleLocID value.
		/// </summary>
		public int RecSampleLocID
		{
			get { return recSampleLocID; }
			set { recSampleLocID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedLocID value.
		/// </summary>
		public int CollectedLocID
		{
			get { return collectedLocID; }
			set { collectedLocID = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public int PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleRelationshipID value.
		/// </summary>
		public int SampleRelationshipID
		{
			get { return sampleRelationshipID; }
			set { sampleRelationshipID = value; }
		}


		#endregion
}
}
