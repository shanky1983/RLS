using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NonReimbursableItems
	{
		#region Fields

		private long nonReimbursableID=0;
		private string feeType=String.Empty;
		private long feeID=0;
		private string feeDesc=String.Empty;
		private string feeTypeDesc=String.Empty;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long clientID=0;
		private string tPAType=String.Empty;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NonReimbursableID value.
		/// </summary>
		public long NonReimbursableID
		{
			get { return nonReimbursableID; }
			set { nonReimbursableID = value; }
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
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeDesc value.
		/// </summary>
		public string FeeDesc
		{
			get { return feeDesc; }
			set { feeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeDesc value.
		/// </summary>
		public string FeeTypeDesc
		{
			get { return feeTypeDesc; }
			set { feeTypeDesc = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAType value.
		/// </summary>
		public string TPAType
		{
			get { return tPAType; }
			set { tPAType = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
