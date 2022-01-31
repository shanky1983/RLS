using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BillingMIS
	{
		#region Fields

		private long billingMISID=0;
		private long visitID=0;
		private long finalBillID=0;
		private long billingDetailsID=0;
		private long feeID=0;
		private string feeType=String.Empty;
		private long childFeeID=0;
		private string childFeeType=String.Empty;
		private decimal actualAmount=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;
		private decimal redeemAmount=Decimal.Zero;
		private decimal netamount=Decimal.Zero;
		private long clientID=0;
		private int orgID=0;
		private int departmentID=0;
		private int noOfRerun=0;
		private int noOfReflex=0;
		private int noOfRecollect=0;
		private int noOfRun=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillingMISID value.
		/// </summary>
		public long BillingMISID
		{
			get { return billingMISID; }
			set { billingMISID = value; }
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
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the BillingDetailsID value.
		/// </summary>
		public long BillingDetailsID
		{
			get { return billingDetailsID; }
			set { billingDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the ChildFeeID value.
		/// </summary>
		public long ChildFeeID
		{
			get { return childFeeID; }
			set { childFeeID = value; }
		}

		/// <summary>
		/// Gets or sets the ChildFeeType value.
		/// </summary>
		public string ChildFeeType
		{
			get { return childFeeType; }
			set { childFeeType = value; }
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		public decimal DiscountAmount
		{
			get { return discountAmount; }
			set { discountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemAmount value.
		/// </summary>
		public decimal RedeemAmount
		{
			get { return redeemAmount; }
			set { redeemAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Netamount value.
		/// </summary>
		public decimal Netamount
		{
			get { return netamount; }
			set { netamount = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the DepartmentID value.
		/// </summary>
		public int DepartmentID
		{
			get { return departmentID; }
			set { departmentID = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfRerun value.
		/// </summary>
		public int NoOfRerun
		{
			get { return noOfRerun; }
			set { noOfRerun = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfReflex value.
		/// </summary>
		public int NoOfReflex
		{
			get { return noOfReflex; }
			set { noOfReflex = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfRecollect value.
		/// </summary>
		public int NoOfRecollect
		{
			get { return noOfRecollect; }
			set { noOfRecollect = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfRun value.
		/// </summary>
		public int NoOfRun
		{
			get { return noOfRun; }
			set { noOfRun = value; }
		}


		#endregion
}
}
