using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StockReturn
	{
		#region Fields

		private long stockReturnID=0;
		private long supplierID=0;
		private decimal actualAmount=Decimal.Zero;
		private decimal approvedAmount=Decimal.Zero;
		private string status=String.Empty;
		private string referenceNo=String.Empty;
		private string type=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private int locationID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long stockReferenceId=0;
		private string reasonForStockReturn=String.Empty;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockReturnID value.
		/// </summary>
		public long StockReturnID
		{
			get { return stockReturnID; }
			set { stockReturnID = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierID value.
		/// </summary>
		public long SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
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
		/// Gets or sets the ReferenceNo value.
		/// </summary>
		public string ReferenceNo
		{
			get { return referenceNo; }
			set { referenceNo = value; }
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
		/// Gets or sets the StockReferenceId value.
		/// </summary>
		public long StockReferenceId
		{
			get { return stockReferenceId; }
			set { stockReferenceId = value; }
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


		#endregion
}
}
