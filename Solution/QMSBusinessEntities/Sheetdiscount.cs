using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Sheetdiscount
	{
		#region Fields

		private float reasonID=0.0F;
		private float reasonTypeID=0.0F;
		private string reason=String.Empty;
		private string reasonCode=String.Empty;
		private string status=String.Empty;
		private float createdBy=0.0F;
		private DateTime createdAt=DateTime.MaxValue;
		private string modifiedBy=String.Empty;
		private string modifiedAt=String.Empty;
		private string sequenceNo=String.Empty;
		private float orgID=0.0F;
		private float discountid=0.0F;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReasonID value.
		/// </summary>
		public float ReasonID
		{
			get { return reasonID; }
			set { reasonID = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonTypeID value.
		/// </summary>
		public float ReasonTypeID
		{
			get { return reasonTypeID; }
			set { reasonTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonCode value.
		/// </summary>
		public string ReasonCode
		{
			get { return reasonCode; }
			set { reasonCode = value; }
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
		public float CreatedBy
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public string SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public float OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Discountid value.
		/// </summary>
		public float Discountid
		{
			get { return discountid; }
			set { discountid = value; }
		}


		#endregion
}
}
