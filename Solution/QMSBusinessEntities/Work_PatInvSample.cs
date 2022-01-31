using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Work_PatInvSample
	{
		#region Fields

		private long visitID=0;
		private int orgID=0;
		private int sampleID=0;
		private string uID=String.Empty;
		private string barcode=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private int sampleContainerID=0;
		private int recSampleLocID=0;
		private int collectedLocID=0;

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
		/// Gets or sets the SampleContainerID value.
		/// </summary>
		public int SampleContainerID
		{
			get { return sampleContainerID; }
			set { sampleContainerID = value; }
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


		#endregion
}
}
