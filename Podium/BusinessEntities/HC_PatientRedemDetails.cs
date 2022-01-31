using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HC_PatientRedemDetails
	{
		#region Fields

		private long membershipCardDetailsID=0;
		private long membershipCardMappingID=0;
		private long patientID=0;
		private long visitID=0;
		private int orgId=0;
		private decimal redemPoints=Decimal.Zero;
		private decimal redemValue=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long finalbillid=0;
		private decimal cancelledReturnedValue=Decimal.Zero;

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
		/// Gets or sets the RedemPoints value.
		/// </summary>
		public decimal RedemPoints
		{
			get { return redemPoints; }
			set { redemPoints = value; }
		}

		/// <summary>
		/// Gets or sets the RedemValue value.
		/// </summary>
		public decimal RedemValue
		{
			get { return redemValue; }
			set { redemValue = value; }
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
		/// Gets or sets the CancelledReturnedValue value.
		/// </summary>
		public decimal CancelledReturnedValue
		{
			get { return cancelledReturnedValue; }
			set { cancelledReturnedValue = value; }
		}


		#endregion
}
}
