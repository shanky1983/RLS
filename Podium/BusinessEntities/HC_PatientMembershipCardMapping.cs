using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HC_PatientMembershipCardMapping
	{
		#region Fields

		private long membershipCardMappingID=0;
		private long membershipCardTypeID=0;
		private long patientID=0;
		private string membershipCardNo=String.Empty;
		private int orgId=0;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;
		private string oTP=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string mobileNo=String.Empty;
		private decimal totalCreditPoints=Decimal.Zero;
		private decimal totalCreditValue=Decimal.Zero;
		private decimal totalRedemPoints=Decimal.Zero;
		private decimal totalRedemValue=Decimal.Zero;
		private byte[] barcode=new byte[0];

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MembershipCardMappingID value.
		/// </summary>
		public long MembershipCardMappingID
		{
			get { return membershipCardMappingID; }
			set { membershipCardMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardTypeID value.
		/// </summary>
		public long MembershipCardTypeID
		{
			get { return membershipCardTypeID; }
			set { membershipCardTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardNo value.
		/// </summary>
		public string MembershipCardNo
		{
			get { return membershipCardNo; }
			set { membershipCardNo = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the ValidFrom value.
		/// </summary>
		public DateTime ValidFrom
		{
			get { return validFrom; }
			set { validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		public DateTime ValidTo
		{
			get { return validTo; }
			set { validTo = value; }
		}

		/// <summary>
		/// Gets or sets the OTP value.
		/// </summary>
		public string OTP
		{
			get { return oTP; }
			set { oTP = value; }
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
		/// Gets or sets the MobileNo value.
		/// </summary>
		public string MobileNo
		{
			get { return mobileNo; }
			set { mobileNo = value; }
		}

		/// <summary>
		/// Gets or sets the TotalCreditPoints value.
		/// </summary>
		public decimal TotalCreditPoints
		{
			get { return totalCreditPoints; }
			set { totalCreditPoints = value; }
		}

		/// <summary>
		/// Gets or sets the TotalCreditValue value.
		/// </summary>
		public decimal TotalCreditValue
		{
			get { return totalCreditValue; }
			set { totalCreditValue = value; }
		}

		/// <summary>
		/// Gets or sets the TotalRedemPoints value.
		/// </summary>
		public decimal TotalRedemPoints
		{
			get { return totalRedemPoints; }
			set { totalRedemPoints = value; }
		}

		/// <summary>
		/// Gets or sets the TotalRedemValue value.
		/// </summary>
		public decimal TotalRedemValue
		{
			get { return totalRedemValue; }
			set { totalRedemValue = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public byte[] Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}


		#endregion
}
}
