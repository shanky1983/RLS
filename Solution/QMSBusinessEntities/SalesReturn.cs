using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SalesReturn
	{
		#region Fields

		private long saleReturnID=0;
		private long customerID=0;
		private string saleReturnNo=String.Empty;
		private decimal actualAmount=Decimal.Zero;
		private decimal approvedAmount=Decimal.Zero;
		private string status=String.Empty;
		private string type=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private int locationID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private long approvedBy=0;
		private string reasonForStockReturn=String.Empty;
		private int customerLocationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SaleReturnID value.
		/// </summary>
		public long SaleReturnID
		{
			get { return saleReturnID; }
			set { saleReturnID = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerID value.
		/// </summary>
		public long CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}

		/// <summary>
		/// Gets or sets the SaleReturnNo value.
		/// </summary>
		public string SaleReturnNo
		{
			get { return saleReturnNo; }
			set { saleReturnNo = value; }
		}

		/// <summary>
		/// Gets or sets the ActualAmount value.
		/// </summary>
		public decimal ActualAmount
		{
			get { return actualAmount; }
			set { actualAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAmount value.
		/// </summary>
		public decimal ApprovedAmount
		{
			get { return approvedAmount; }
			set { approvedAmount = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
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
		/// Gets or sets the ReasonForStockReturn value.
		/// </summary>
		public string ReasonForStockReturn
		{
			get { return reasonForStockReturn; }
			set { reasonForStockReturn = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerLocationID value.
		/// </summary>
		public int CustomerLocationID
		{
			get { return customerLocationID; }
			set { customerLocationID = value; }
		}


		#endregion
}
}
