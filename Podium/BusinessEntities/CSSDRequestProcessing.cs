using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CSSDRequestProcessing
	{
		#region Fields

		private long requestProcessingID=0;
		private long requestID=0;
		private int workflowID=0;
		private string batchID=String.Empty;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RequestProcessingID value.
		/// </summary>
		public long RequestProcessingID
		{
			get { return requestProcessingID; }
			set { requestProcessingID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestID value.
		/// </summary>
		public long RequestID
		{
			get { return requestID; }
			set { requestID = value; }
		}

		/// <summary>
		/// Gets or sets the WorkflowID value.
		/// </summary>
		public int WorkflowID
		{
			get { return workflowID; }
			set { workflowID = value; }
		}

		/// <summary>
		/// Gets or sets the BatchID value.
		/// </summary>
		public string BatchID
		{
			get { return batchID; }
			set { batchID = value; }
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
