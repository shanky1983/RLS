using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class KitPatientUsage
	{
		#region Fields

		private long kitPatientUsageID=0;
		private long visitID=0;
		private string referenceID=String.Empty;
		private string referenceType=String.Empty;
		private decimal soldPrice=Decimal.Zero;
		private long kitID=0;
		private long masterKitID=0;
		private string kitBatchNo=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int locationID=0;
		private int orgID=0;
		private string status=String.Empty;
		private long stockOutFlowDetailID=0;
		private string isReimbursable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the KitPatientUsageID value.
		/// </summary>
		public long KitPatientUsageID
		{
			get { return kitPatientUsageID; }
			set { kitPatientUsageID = value; }
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
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public string ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the SoldPrice value.
		/// </summary>
		public decimal SoldPrice
		{
			get { return soldPrice; }
			set { soldPrice = value; }
		}

		/// <summary>
		/// Gets or sets the KitID value.
		/// </summary>
		public long KitID
		{
			get { return kitID; }
			set { kitID = value; }
		}

		/// <summary>
		/// Gets or sets the MasterKitID value.
		/// </summary>
		public long MasterKitID
		{
			get { return masterKitID; }
			set { masterKitID = value; }
		}

		/// <summary>
		/// Gets or sets the KitBatchNo value.
		/// </summary>
		public string KitBatchNo
		{
			get { return kitBatchNo; }
			set { kitBatchNo = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowDetailID value.
		/// </summary>
		public long StockOutFlowDetailID
		{
			get { return stockOutFlowDetailID; }
			set { stockOutFlowDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the IsReimbursable value.
		/// </summary>
		public string IsReimbursable
		{
			get { return isReimbursable; }
			set { isReimbursable = value; }
		}


		#endregion
}
}
