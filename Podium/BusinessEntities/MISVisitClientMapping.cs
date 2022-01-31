using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MISVisitClientMapping
	{
		#region Fields

		private long visitClientMappingID=0;
		private long visitID=0;
		private long clientID=0;
		private long finalBillID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long refFinalBillID=0;
		private string isCreditBill=String.Empty;
		private DateTime createddate=DateTime.MaxValue;
		private TimeSpan createdtime=TimeSpan.MinValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitClientMappingID value.
		/// </summary>
		public long VisitClientMappingID
		{
			get { return visitClientMappingID; }
			set { visitClientMappingID = value; }
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
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
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
		/// Gets or sets the RefFinalBillID value.
		/// </summary>
		public long RefFinalBillID
		{
			get { return refFinalBillID; }
			set { refFinalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		public string IsCreditBill
		{
			get { return isCreditBill; }
			set { isCreditBill = value; }
		}

		/// <summary>
		/// Gets or sets the Createddate value.
		/// </summary>
		public DateTime Createddate
		{
			get { return createddate; }
			set { createddate = value; }
		}

		/// <summary>
		/// Gets or sets the Createdtime value.
		/// </summary>
		public TimeSpan Createdtime
		{
			get { return createdtime; }
			set { createdtime = value; }
		}


		#endregion
}
}
