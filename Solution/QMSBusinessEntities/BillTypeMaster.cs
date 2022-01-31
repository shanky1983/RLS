using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BillTypeMaster
	{
		#region Fields

		private long billTypeID=0;
		private int billGroupID=0;
		private string billTypeName=String.Empty;
		private int orgID=0;
		private long orgAddressID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillTypeID value.
		/// </summary>
		public long BillTypeID
		{
			get { return billTypeID; }
			set { billTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the BillGroupID value.
		/// </summary>
		public int BillGroupID
		{
			get { return billGroupID; }
			set { billGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the BillTypeName value.
		/// </summary>
		public string BillTypeName
		{
			get { return billTypeName; }
			set { billTypeName = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
