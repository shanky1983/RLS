using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientMembershipCardType
	{
		#region Fields

		private long membershipCardTypeID=0;
		private string membershipCardType=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MembershipCardTypeID value.
		/// </summary>
		public long MembershipCardTypeID
		{
			get { return membershipCardTypeID; }
			set { membershipCardTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardType value.
		/// </summary>
		public string MembershipCardType
		{
			get { return membershipCardType; }
			set { membershipCardType = value; }
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
		/// Gets or sets the CardStatus value.
		/// </summary>
		private string _cardStatus=String.Empty;
		public string CardStatus
		{
			get { return  _cardStatus; }
			set { _cardStatus = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardDetails value.
		/// </summary>
		private string _membershipCardDetails=String.Empty;
		public string MembershipCardDetails
		{
			get { return  _membershipCardDetails; }
			set { _membershipCardDetails = value; }
		}


		#endregion
}
}
