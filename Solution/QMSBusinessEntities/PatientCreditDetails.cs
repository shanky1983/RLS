using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientCreditDetails
	{
		#region Fields

		private long membershipCardDetailsID=0;
		private long membershipCardMappingID=0;
		private long patientID=0;
		private long visitID=0;
		private int orgId=0;
		private decimal creditPoints=Decimal.Zero;
		private decimal creditValue=Decimal.Zero;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long finalbillid=0;
		private decimal cancelledValue=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MembershipCardDetailsID value.
		/// </summary>
		public long MembershipCardDetailsID
		{
			get { return membershipCardDetailsID; }
			set { membershipCardDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the MembershipCardMappingID value.
		/// </summary>
		public long MembershipCardMappingID
		{
			get { return membershipCardMappingID; }
			set { membershipCardMappingID = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the CreditPoints value.
		/// </summary>
		public decimal CreditPoints
		{
			get { return creditPoints; }
			set { creditPoints = value; }
		}

		/// <summary>
		/// Gets or sets the CreditValue value.
		/// </summary>
		public decimal CreditValue
		{
			get { return creditValue; }
			set { creditValue = value; }
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
		/// Gets or sets the Finalbillid value.
		/// </summary>
		public long Finalbillid
		{
			get { return finalbillid; }
			set { finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the CancelledValue value.
		/// </summary>
		public decimal CancelledValue
		{
			get { return cancelledValue; }
			set { cancelledValue = value; }
		}


		#endregion
}
}
