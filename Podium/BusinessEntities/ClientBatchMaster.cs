using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientBatchMaster
	{
		#region Fields

		private int pOrderedID=0;
		private string batchid=String.Empty;
		private DateTime fromdate=DateTime.MaxValue;
		private DateTime todate=DateTime.MaxValue;
		private int billingid=0;
		private int clientId=0;
		private int testnameid=0;
		private int orgID=0;
		private string filePath=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifyat=DateTime.MaxValue;
		private long modifyby=0;
		private string reportStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the POrderedID value.
		/// </summary>
		public int POrderedID
		{
			get { return pOrderedID; }
			set { pOrderedID = value; }
		}

		/// <summary>
		/// Gets or sets the Batchid value.
		/// </summary>
		public string Batchid
		{
			get { return batchid; }
			set { batchid = value; }
		}

		/// <summary>
		/// Gets or sets the Fromdate value.
		/// </summary>
		public DateTime Fromdate
		{
			get { return fromdate; }
			set { fromdate = value; }
		}

		/// <summary>
		/// Gets or sets the Todate value.
		/// </summary>
		public DateTime Todate
		{
			get { return todate; }
			set { todate = value; }
		}

		/// <summary>
		/// Gets or sets the Billingid value.
		/// </summary>
		public int Billingid
		{
			get { return billingid; }
			set { billingid = value; }
		}

		/// <summary>
		/// Gets or sets the ClientId value.
		/// </summary>
		public int ClientId
		{
			get { return clientId; }
			set { clientId = value; }
		}

		/// <summary>
		/// Gets or sets the Testnameid value.
		/// </summary>
		public int Testnameid
		{
			get { return testnameid; }
			set { testnameid = value; }
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
		/// Gets or sets the FilePath value.
		/// </summary>
		public string FilePath
		{
			get { return filePath; }
			set { filePath = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the Modifyat value.
		/// </summary>
		public DateTime Modifyat
		{
			get { return modifyat; }
			set { modifyat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifyby value.
		/// </summary>
		public long Modifyby
		{
			get { return modifyby; }
			set { modifyby = value; }
		}

		/// <summary>
		/// Gets or sets the ReportStatus value.
		/// </summary>
		public string ReportStatus
		{
			get { return reportStatus; }
			set { reportStatus = value; }
		}


		#endregion
}
}
