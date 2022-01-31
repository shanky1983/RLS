using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SampleBatchTracker
	{
		#region Fields

		private long sampleBatchTrackerID=0;
		private long batchID=0;
		private string batchNo=String.Empty;
		private DateTime sendDateTime=DateTime.MaxValue;
		private DateTime receiveDateTime=DateTime.MaxValue;
		private int sendOrgID=0;
		private int receiveOrgID=0;
		private int sendLocationID=0;
		private int receiveLocationID=0;
		private string batchStatus=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isConflict=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SampleBatchTrackerID value.
		/// </summary>
		public long SampleBatchTrackerID
		{
			get { return sampleBatchTrackerID; }
			set { sampleBatchTrackerID = value; }
		}

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
		/// Gets or sets the SendDateTime value.
		/// </summary>
		public DateTime SendDateTime
		{
			get { return sendDateTime; }
			set { sendDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiveDateTime value.
		/// </summary>
		public DateTime ReceiveDateTime
		{
			get { return receiveDateTime; }
			set { receiveDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the SendOrgID value.
		/// </summary>
		public int SendOrgID
		{
			get { return sendOrgID; }
			set { sendOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiveOrgID value.
		/// </summary>
		public int ReceiveOrgID
		{
			get { return receiveOrgID; }
			set { receiveOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the SendLocationID value.
		/// </summary>
		public int SendLocationID
		{
			get { return sendLocationID; }
			set { sendLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiveLocationID value.
		/// </summary>
		public int ReceiveLocationID
		{
			get { return receiveLocationID; }
			set { receiveLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the BatchStatus value.
		/// </summary>
		public string BatchStatus
		{
			get { return batchStatus; }
			set { batchStatus = value; }
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
		/// Gets or sets the IsConflict value.
		/// </summary>
		public string IsConflict
		{
			get { return isConflict; }
			set { isConflict = value; }
		}


		#endregion
}
}
