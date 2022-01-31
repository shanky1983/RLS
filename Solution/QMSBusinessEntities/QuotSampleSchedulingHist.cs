using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class QuotSampleSchedulingHist
	{
		#region Fields

		private long iD=0;
		private long quotSampleSchedulingID=0;
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
		/// Gets or sets the QuotSampleSchedulingID value.
		/// </summary>
		public long QuotSampleSchedulingID
		{
			get { return quotSampleSchedulingID; }
			set { quotSampleSchedulingID = value; }
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


		#endregion
}
}
