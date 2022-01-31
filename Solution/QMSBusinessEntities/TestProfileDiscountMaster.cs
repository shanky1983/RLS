using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TestProfileDiscountMaster
	{
		#region Fields

		private int detailID=0;
		private int seqID=0;
		private long feeID=0;
		private string feeType=String.Empty;
		private long orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailID value.
		/// </summary>
		public int DetailID
		{
			get { return detailID; }
			set { detailID = value; }
		}

		/// <summary>
		/// Gets or sets the SeqID value.
		/// </summary>
		public int SeqID
		{
			get { return seqID; }
			set { seqID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
