using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockOutFlow
	{
		#region Fields

		private long stockOutFlowID=0;
		private string stockOutFlowNo=String.Empty;
		private int stockOutFlowTypeID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private string status=String.Empty;
		private string description=String.Empty;
		private string consumedBy=String.Empty;
		private long approvedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long billID=0;
		private int locationID=0;
		private string referenceID=String.Empty;
		private string referenceType=String.Empty;
		private string isConsignment=String.Empty;
		private string isInternal=String.Empty;
		private int branchID=0;
		private int supplierID=0;
		private long stockReceivedID=0;
		private int raiseOrgID=0;
		private int raiseOrgAddID=0;
		private string prescriptionNo=String.Empty;
		private string stockOutFlowReason=String.Empty;
		private string dCNo=String.Empty;
		private long customerID=0;
		private long salesOrderID=0;
		private string invoiceNo=String.Empty;
		private decimal tax=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal grandTotal=Decimal.Zero;
		private decimal cSTax=Decimal.Zero;
		private decimal cSTAmount=Decimal.Zero;
		private decimal exciseTaxAmount=Decimal.Zero;
		private decimal vAT=Decimal.Zero;
		private decimal surcharge=Decimal.Zero;
		private decimal roundOfValue=Decimal.Zero;
		private string roundOfType=String.Empty;
		private int cLocationID=0;
		private decimal totalSales=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockOutFlowID value.
		/// </summary>
		public long StockOutFlowID
		{
			get { return stockOutFlowID; }
			set { stockOutFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowNo value.
		/// </summary>
		public string StockOutFlowNo
		{
			get { return stockOutFlowNo; }
			set { stockOutFlowNo = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowTypeID value.
		/// </summary>
		public int StockOutFlowTypeID
		{
			get { return stockOutFlowTypeID; }
			set { stockOutFlowTypeID = value; }
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
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumedBy value.
		/// </summary>
		public string ConsumedBy
		{
			get { return consumedBy; }
			set { consumedBy = value; }
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
		/// Gets or sets the BillID value.
		/// </summary>
		public long BillID
		{
			get { return billID; }
			set { billID = value; }
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
		/// Gets or sets the IsConsignment value.
		/// </summary>
		public string IsConsignment
		{
			get { return isConsignment; }
			set { isConsignment = value; }
		}

		/// <summary>
		/// Gets or sets the IsInternal value.
		/// </summary>
		public string IsInternal
		{
			get { return isInternal; }
			set { isInternal = value; }
		}

		/// <summary>
		/// Gets or sets the BranchID value.
		/// </summary>
		public int BranchID
		{
			get { return branchID; }
			set { branchID = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierID value.
		/// </summary>
		public int SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedID value.
		/// </summary>
		public long StockReceivedID
		{
			get { return stockReceivedID; }
			set { stockReceivedID = value; }
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
		/// Gets or sets the PrescriptionNo value.
		/// </summary>
		public string PrescriptionNo
		{
			get { return prescriptionNo; }
			set { prescriptionNo = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowReason value.
		/// </summary>
		public string StockOutFlowReason
		{
			get { return stockOutFlowReason; }
			set { stockOutFlowReason = value; }
		}

		/// <summary>
		/// Gets or sets the DCNo value.
		/// </summary>
		public string DCNo
		{
			get { return dCNo; }
			set { dCNo = value; }
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
		/// Gets or sets the SalesOrderID value.
		/// </summary>
		public long SalesOrderID
		{
			get { return salesOrderID; }
			set { salesOrderID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		public string InvoiceNo
		{
			get { return invoiceNo; }
			set { invoiceNo = value; }
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
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the GrandTotal value.
		/// </summary>
		public decimal GrandTotal
		{
			get { return grandTotal; }
			set { grandTotal = value; }
		}

		/// <summary>
		/// Gets or sets the CSTax value.
		/// </summary>
		public decimal CSTax
		{
			get { return cSTax; }
			set { cSTax = value; }
		}

		/// <summary>
		/// Gets or sets the CSTAmount value.
		/// </summary>
		public decimal CSTAmount
		{
			get { return cSTAmount; }
			set { cSTAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ExciseTaxAmount value.
		/// </summary>
		public decimal ExciseTaxAmount
		{
			get { return exciseTaxAmount; }
			set { exciseTaxAmount = value; }
		}

		/// <summary>
		/// Gets or sets the VAT value.
		/// </summary>
		public decimal VAT
		{
			get { return vAT; }
			set { vAT = value; }
		}

		/// <summary>
		/// Gets or sets the Surcharge value.
		/// </summary>
		public decimal Surcharge
		{
			get { return surcharge; }
			set { surcharge = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOfValue value.
		/// </summary>
		public decimal RoundOfValue
		{
			get { return roundOfValue; }
			set { roundOfValue = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOfType value.
		/// </summary>
		public string RoundOfType
		{
			get { return roundOfType; }
			set { roundOfType = value; }
		}

		/// <summary>
		/// Gets or sets the CLocationID value.
		/// </summary>
		public int CLocationID
		{
			get { return cLocationID; }
			set { cLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalSales value.
		/// </summary>
		public decimal TotalSales
		{
			get { return totalSales; }
			set { totalSales = value; }
		}


		#endregion
}
}
