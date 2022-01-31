using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class QuotationSampleScheduling
	{
		#region Fields

		private long iD=0;
		private long quotationID=0;
		private long investigationID=0;
		private string sampleID=String.Empty;
		private DateTime scheduledTime=DateTime.MaxValue;
		private long collectedBy=0;
		private string fieldTest=String.Empty;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string investigationsType=String.Empty;
		private string sampleDescription=String.Empty;
		private string temperature=String.Empty;
		private string location=String.Empty;
		private string visitnumber=String.Empty;
		private long visitID=0;
		private string vendor=String.Empty;
		private string quality=String.Empty;
		private int uniqueID=0;
		private byte[] barcode=new byte[0];

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the QuotationID value.
		/// </summary>
		public long QuotationID
		{
			get { return quotationID; }
			set { quotationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public string SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduledTime value.
		/// </summary>
		public DateTime ScheduledTime
		{
			get { return scheduledTime; }
			set { scheduledTime = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedBy value.
		/// </summary>
		public long CollectedBy
		{
			get { return collectedBy; }
			set { collectedBy = value; }
		}

		/// <summary>
		/// Gets or sets the FieldTest value.
		/// </summary>
		public string FieldTest
		{
			get { return fieldTest; }
			set { fieldTest = value; }
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
		/// Gets or sets the InvestigationsType value.
		/// </summary>
		public string InvestigationsType
		{
			get { return investigationsType; }
			set { investigationsType = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDescription value.
		/// </summary>
		public string SampleDescription
		{
			get { return sampleDescription; }
			set { sampleDescription = value; }
		}

		/// <summary>
		/// Gets or sets the Temperature value.
		/// </summary>
		public string Temperature
		{
			get { return temperature; }
			set { temperature = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
		}

		/// <summary>
		/// Gets or sets the Visitnumber value.
		/// </summary>
		public string Visitnumber
		{
			get { return visitnumber; }
			set { visitnumber = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the Vendor value.
		/// </summary>
		public string Vendor
		{
			get { return vendor; }
			set { vendor = value; }
		}

		/// <summary>
		/// Gets or sets the Quality value.
		/// </summary>
		public string Quality
		{
			get { return quality; }
			set { quality = value; }
		}

		/// <summary>
		/// Gets or sets the UniqueID value.
		/// </summary>
		public int UniqueID
		{
			get { return uniqueID; }
			set { uniqueID = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public byte[] Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}


		#endregion
}
}
