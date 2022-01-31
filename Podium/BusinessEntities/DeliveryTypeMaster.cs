using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DeliveryTypeMaster
	{
		#region Fields

		private long deliveryTypeID=0;
		private string deliveryTypeName=String.Empty;
		private string deliveryType=String.Empty;
		private int orgID=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeliveryTypeID value.
		/// </summary>
		public long DeliveryTypeID
		{
			get { return deliveryTypeID; }
			set { deliveryTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryTypeName value.
		/// </summary>
		public string DeliveryTypeName
		{
			get { return deliveryTypeName; }
			set { deliveryTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryType value.
		/// </summary>
		public string DeliveryType
		{
			get { return deliveryType; }
			set { deliveryType = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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


		#endregion
}
}
