using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MedicalIndentsClientMapping
	{
		#region Fields

		private long itemID=0;
		private long orgID=0;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long rateID=0;
		private long clientID=0;
		private long tPAID=0;
		private long medicalIndentID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ItemID value.
		/// </summary>
		public long ItemID
		{
			get { return itemID; }
			set { itemID = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the TPAID value.
		/// </summary>
		public long TPAID
		{
			get { return tPAID; }
			set { tPAID = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalIndentID value.
		/// </summary>
		public long MedicalIndentID
		{
			get { return medicalIndentID; }
			set { medicalIndentID = value; }
		}


		#endregion
}
}
