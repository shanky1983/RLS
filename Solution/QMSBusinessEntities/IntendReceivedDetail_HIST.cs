using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IntendReceivedDetail_HIST
	{
		#region Fields

		private long intendReceivedDetail_HISTID=0;
		private long intendReceivedDetailID=0;
		private long intendReceivedID=0;
		private DateTime intendReceivedDate=DateTime.MaxValue;
		private string status=String.Empty;
		private long productID=0;
		private decimal quantity=Decimal.Zero;
		private int orgID=0;
		private int orgAddressID=0;
		private int fromLocationID=0;
		private int toLocationID=0;
		private string batchNo=String.Empty;
		private int categoryId=0;
		private DateTime expiryDate=DateTime.MaxValue;
		private decimal tax=Decimal.Zero;
		private string sellingUnit=String.Empty;
		private decimal unitPrice=Decimal.Zero;
		private decimal sellingPrice=Decimal.Zero;
		private int invoiceQty=0;
		private decimal issueQty=Decimal.Zero;
		private decimal recdQty=Decimal.Zero;
		private DateTime intendIssuedDate=DateTime.MaxValue;
		private string productKey=String.Empty;
		private int raiseOrgID=0;
		private long parentProductID=0;
		private int raiseOrgAddID=0;
		private string parentProductKey=String.Empty;
		private long createdRole=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IntendReceivedDetail_HISTID value.
		/// </summary>
		public long IntendReceivedDetail_HISTID
		{
			get { return intendReceivedDetail_HISTID; }
			set { intendReceivedDetail_HISTID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendReceivedDetailID value.
		/// </summary>
		public long IntendReceivedDetailID
		{
			get { return intendReceivedDetailID; }
			set { intendReceivedDetailID = value; }
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
		/// Gets or sets the IntendReceivedDate value.
		/// </summary>
		public DateTime IntendReceivedDate
		{
			get { return intendReceivedDate; }
			set { intendReceivedDate = value; }
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
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
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
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryId value.
		/// </summary>
		public int CategoryId
		{
			get { return categoryId; }
			set { categoryId = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return expiryDate; }
			set { expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
		}

		/// <summary>
		/// Gets or sets the SellingUnit value.
		/// </summary>
		public string SellingUnit
		{
			get { return sellingUnit; }
			set { sellingUnit = value; }
		}

		/// <summary>
		/// Gets or sets the UnitPrice value.
		/// </summary>
		public decimal UnitPrice
		{
			get { return unitPrice; }
			set { unitPrice = value; }
		}

		/// <summary>
		/// Gets or sets the SellingPrice value.
		/// </summary>
		public decimal SellingPrice
		{
			get { return sellingPrice; }
			set { sellingPrice = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceQty value.
		/// </summary>
		public int InvoiceQty
		{
			get { return invoiceQty; }
			set { invoiceQty = value; }
		}

		/// <summary>
		/// Gets or sets the IssueQty value.
		/// </summary>
		public decimal IssueQty
		{
			get { return issueQty; }
			set { issueQty = value; }
		}

		/// <summary>
		/// Gets or sets the RecdQty value.
		/// </summary>
		public decimal RecdQty
		{
			get { return recdQty; }
			set { recdQty = value; }
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
		/// Gets or sets the ProductKey value.
		/// </summary>
		public string ProductKey
		{
			get { return productKey; }
			set { productKey = value; }
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
		/// Gets or sets the ParentProductID value.
		/// </summary>
		public long ParentProductID
		{
			get { return parentProductID; }
			set { parentProductID = value; }
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
		/// Gets or sets the ParentProductKey value.
		/// </summary>
		public string ParentProductKey
		{
			get { return parentProductKey; }
			set { parentProductKey = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
