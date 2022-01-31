using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class VisitClientMapping_History
	{
		#region Fields

		private long visitClientHistoryID=0;
		private long visitID=0;
		private long clientID=0;
		private long finalBillID=0;
		private long rateID=0;
		private int orgID=0;
		private decimal preAuthAmount=Decimal.Zero;
		private string preAuthApprovalNumber=String.Empty;
		private decimal claimAmount=Decimal.Zero;
		private int claimLogic=0;
		private decimal coPayment=Decimal.Zero;
		private decimal copaymentPercent=Decimal.Zero;
		private int coPaymentLogic=0;
		private decimal nonMedicalAmount=Decimal.Zero;
		private string clientAttributes=String.Empty;
		private string isAllMedical=String.Empty;
		private string paymentStatus=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitClientHistoryID value.
		/// </summary>
		public long VisitClientHistoryID
		{
			get { return visitClientHistoryID; }
			set { visitClientHistoryID = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		public decimal PreAuthAmount
		{
			get { return preAuthAmount; }
			set { preAuthAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthApprovalNumber value.
		/// </summary>
		public string PreAuthApprovalNumber
		{
			get { return preAuthApprovalNumber; }
			set { preAuthApprovalNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimAmount value.
		/// </summary>
		public decimal ClaimAmount
		{
			get { return claimAmount; }
			set { claimAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimLogic value.
		/// </summary>
		public int ClaimLogic
		{
			get { return claimLogic; }
			set { claimLogic = value; }
		}

		/// <summary>
		/// Gets or sets the CoPayment value.
		/// </summary>
		public decimal CoPayment
		{
			get { return coPayment; }
			set { coPayment = value; }
		}

		/// <summary>
		/// Gets or sets the CopaymentPercent value.
		/// </summary>
		public decimal CopaymentPercent
		{
			get { return copaymentPercent; }
			set { copaymentPercent = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentLogic value.
		/// </summary>
		public int CoPaymentLogic
		{
			get { return coPaymentLogic; }
			set { coPaymentLogic = value; }
		}

		/// <summary>
		/// Gets or sets the NonMedicalAmount value.
		/// </summary>
		public decimal NonMedicalAmount
		{
			get { return nonMedicalAmount; }
			set { nonMedicalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientAttributes value.
		/// </summary>
		public string ClientAttributes
		{
			get { return clientAttributes; }
			set { clientAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the IsAllMedical value.
		/// </summary>
		public string IsAllMedical
		{
			get { return isAllMedical; }
			set { isAllMedical = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentStatus value.
		/// </summary>
		public string PaymentStatus
		{
			get { return paymentStatus; }
			set { paymentStatus = value; }
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


		#endregion
}
}
