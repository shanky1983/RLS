using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvSummaryTrend
	{
		#region Fields

		private long id=0;
		private int orgId=0;
		private long visitId=0;
		private string trendInvId=String.Empty;
		private byte[] content=new byte[0];
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the VisitId value.
		/// </summary>
		public long VisitId
		{
			get { return visitId; }
			set { visitId = value; }
		}

		/// <summary>
		/// Gets or sets the TrendInvId value.
		/// </summary>
		public string TrendInvId
		{
			get { return trendInvId; }
			set { trendInvId = value; }
		}

		/// <summary>
		/// Gets or sets the Content value.
		/// </summary>
		public byte[] Content
		{
			get { return content; }
			set { content = value; }
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


		#endregion
}
}
