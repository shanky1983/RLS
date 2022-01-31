using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AmountApprovalDetails
	{
		#region Fields

		private long billApprovalID=0;
		private long patientId=0;
		private string patientName=String.Empty;
		private int visitPurposeID=0;
		private decimal paymentAmount=Decimal.Zero;
		private string bankName=String.Empty;
		private string paymentCardNo=String.Empty;
		private string cardHolderName=String.Empty;
		private decimal discount=Decimal.Zero;
		private decimal netAmount=Decimal.Zero;
		private string approvalType=String.Empty;
		private string feeDescription=String.Empty;
		private string approvalStatus=String.Empty;
		private long rollID=0;
		private int orgID=0;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string comments=String.Empty;
		private string age=String.Empty;
		private DateTime chequeValidDate=DateTime.MaxValue;
		private long finalBillID=0;
		private decimal billedAmount=Decimal.Zero;
		private decimal buildAmount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillApprovalID value.
		/// </summary>
		public long BillApprovalID
		{
			get { return billApprovalID; }
			set { billApprovalID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientId value.
		/// </summary>
		public long PatientId
		{
			get { return patientId; }
			set { patientId = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		public int VisitPurposeID
		{
			get { return visitPurposeID; }
			set { visitPurposeID = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentAmount value.
		/// </summary>
		public decimal PaymentAmount
		{
			get { return paymentAmount; }
			set { paymentAmount = value; }
		}

		/// <summary>
		/// Gets or sets the BankName value.
		/// </summary>
		public string BankName
		{
			get { return bankName; }
			set { bankName = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentCardNo value.
		/// </summary>
		public string PaymentCardNo
		{
			get { return paymentCardNo; }
			set { paymentCardNo = value; }
		}

		/// <summary>
		/// Gets or sets the CardHolderName value.
		/// </summary>
		public string CardHolderName
		{
			get { return cardHolderName; }
			set { cardHolderName = value; }
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
		/// Gets or sets the NetAmount value.
		/// </summary>
		public decimal NetAmount
		{
			get { return netAmount; }
			set { netAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalType value.
		/// </summary>
		public string ApprovalType
		{
			get { return approvalType; }
			set { approvalType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeDescription value.
		/// </summary>
		public string FeeDescription
		{
			get { return feeDescription; }
			set { feeDescription = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalStatus value.
		/// </summary>
		public string ApprovalStatus
		{
			get { return approvalStatus; }
			set { approvalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the RollID value.
		/// </summary>
		public long RollID
		{
			get { return rollID; }
			set { rollID = value; }
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
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeValidDate value.
		/// </summary>
		public DateTime ChequeValidDate
		{
			get { return chequeValidDate; }
			set { chequeValidDate = value; }
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
		/// Gets or sets the BilledAmount value.
		/// </summary>
		public decimal BilledAmount
		{
			get { return billedAmount; }
			set { billedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the BuildAmount value.
		/// </summary>
		public decimal BuildAmount
		{
			get { return buildAmount; }
			set { buildAmount = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		private string _userName=String.Empty;
		public string UserName
		{
			get { return  _userName; }
			set { _userName = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurpose value.
		/// </summary>
		private string _visitPurpose=String.Empty;
		public string VisitPurpose
		{
			get { return  _visitPurpose; }
			set { _visitPurpose = value; }
		}


		#endregion
}
}
