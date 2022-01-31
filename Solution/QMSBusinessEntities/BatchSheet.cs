using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BatchSheet
	{
		#region Fields

		private long batchID=0;
		private string batchNo=String.Empty;
		private int orgID=0;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime toDate=DateTime.MaxValue;
		private int sourceLocationID=0;
		private int processingLocationID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedat=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BatchID value.
		/// </summary>
		public long BatchID
		{
			get { return batchID; }
			set { batchID = value; }
		}

		/// <summary>
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
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
		/// Gets or sets the FromDate value.
		/// </summary>
		public DateTime FromDate
		{
			get { return fromDate; }
			set { fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the ToDate value.
		/// </summary>
		public DateTime ToDate
		{
			get { return toDate; }
			set { toDate = value; }
		}

		/// <summary>
		/// Gets or sets the SourceLocationID value.
		/// </summary>
		public int SourceLocationID
		{
			get { return sourceLocationID; }
			set { sourceLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingLocationID value.
		/// </summary>
		public int ProcessingLocationID
		{
			get { return processingLocationID; }
			set { processingLocationID = value; }
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
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}


		#endregion
}
}
