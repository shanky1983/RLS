using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Stg_RateMaster
	{
		#region Fields

		private float rateId=0.0F;
		private string rateName=String.Empty;
		private string status=String.Empty;
		private float createdBY=0.0F;
		private DateTime createdAt=DateTime.MaxValue;
		private string modifiedBy=String.Empty;
		private string modifiedAt=String.Empty;
		private float orgid=0.0F;
		private string type=String.Empty;
		private float discountPolicyID=0.0F;
		private string rateCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RateId value.
		/// </summary>
		public float RateId
		{
			get { return rateId; }
			set { rateId = value; }
		}

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		public string RateName
		{
			get { return rateName; }
			set { rateName = value; }
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
		/// Gets or sets the CreatedBY value.
		/// </summary>
		public float CreatedBY
		{
			get { return createdBY; }
			set { createdBY = value; }
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
		public string ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public string ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public float Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPolicyID value.
		/// </summary>
		public float DiscountPolicyID
		{
			get { return discountPolicyID; }
			set { discountPolicyID = value; }
		}

		/// <summary>
		/// Gets or sets the RateCode value.
		/// </summary>
		public string RateCode
		{
			get { return rateCode; }
			set { rateCode = value; }
		}


		#endregion
}
}
