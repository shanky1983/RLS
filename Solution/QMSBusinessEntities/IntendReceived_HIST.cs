using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IntendReceived_HIST
	{
		#region Fields

		private long intendReceived_HISTID=0;
		private long intendReceivedID=0;
		private long intendID=0;
		private DateTime intendIssuedDate=DateTime.MaxValue;
		private string status=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private int fromLocationID=0;
		private int toLocationID=0;
		private long stockOutFlowID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private string comments=String.Empty;
		private int raiseOrgAddID=0;
		private int raiseOrgID=0;
		private string stockType=String.Empty;
		private int stockReturnReasonType=0;
		private long createdRole=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IntendReceived_HISTID value.
		/// </summary>
		public long IntendReceived_HISTID
		{
			get { return intendReceived_HISTID; }
			set { intendReceived_HISTID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendReceivedID value.
		/// </summary>
		public long IntendReceivedID
		{
			get { return intendReceivedID; }
			set { intendReceivedID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendID value.
		/// </summary>
		public long IntendID
		{
			get { return intendID; }
			set { intendID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendIssuedDate value.
		/// </summary>
		public DateTime IntendIssuedDate
		{
			get { return intendIssuedDate; }
			set { intendIssuedDate = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the FromLocationID value.
		/// </summary>
		public int FromLocationID
		{
			get { return fromLocationID; }
			set { fromLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		public int ToLocationID
		{
			get { return toLocationID; }
			set { toLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowID value.
		/// </summary>
		public long StockOutFlowID
		{
			get { return stockOutFlowID; }
			set { stockOutFlowID = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgAddID value.
		/// </summary>
		public int RaiseOrgAddID
		{
			get { return raiseOrgAddID; }
			set { raiseOrgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgID value.
		/// </summary>
		public int RaiseOrgID
		{
			get { return raiseOrgID; }
			set { raiseOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the StockType value.
		/// </summary>
		public string StockType
		{
			get { return stockType; }
			set { stockType = value; }
		}

		/// <summary>
		/// Gets or sets the StockReturnReasonType value.
		/// </summary>
		public int StockReturnReasonType
		{
			get { return stockReturnReasonType; }
			set { stockReturnReasonType = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}


		#endregion
}
}
