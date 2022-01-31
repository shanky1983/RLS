using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Intend_HIST
	{
		#region Fields

		private long intend_HISTID=0;
		private long intendID=0;
		private DateTime intendDate=DateTime.MaxValue;
		private string intendNo=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long approvedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private int orgID=0;
		private int orgAddressID=0;
		private int locationID=0;
		private string comments=String.Empty;
		private int toLocationID=0;
		private long stockOutFlowID=0;
		private int raiseOrgID=0;
		private int raiseOrgAddID=0;
		private int stockReturnReasonType=0;
		private string stockType=String.Empty;
		private long createdRole=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Intend_HISTID value.
		/// </summary>
		public long Intend_HISTID
		{
			get { return intend_HISTID; }
			set { intend_HISTID = value; }
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
		/// Gets or sets the IntendDate value.
		/// </summary>
		public DateTime IntendDate
		{
			get { return intendDate; }
			set { intendDate = value; }
		}

		/// <summary>
		/// Gets or sets the IntendNo value.
		/// </summary>
		public string IntendNo
		{
			get { return intendNo; }
			set { intendNo = value; }
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
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
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
		/// Gets or sets the RaiseOrgID value.
		/// </summary>
		public int RaiseOrgID
		{
			get { return raiseOrgID; }
			set { raiseOrgID = value; }
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
		/// Gets or sets the StockReturnReasonType value.
		/// </summary>
		public int StockReturnReasonType
		{
			get { return stockReturnReasonType; }
			set { stockReturnReasonType = value; }
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
