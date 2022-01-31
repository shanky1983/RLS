using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ModeofOxygenDelivery
	{
		#region Fields

		private int modeOfOxygenDeliveryID=0;
		private string modeOfOxygenDeliveryName=String.Empty;
		private string modeOfOxygenDeliveryDescription=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ModeOfOxygenDeliveryID value.
		/// </summary>
		public int ModeOfOxygenDeliveryID
		{
			get { return modeOfOxygenDeliveryID; }
			set { modeOfOxygenDeliveryID = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOfOxygenDeliveryName value.
		/// </summary>
		public string ModeOfOxygenDeliveryName
		{
			get { return modeOfOxygenDeliveryName; }
			set { modeOfOxygenDeliveryName = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOfOxygenDeliveryDescription value.
		/// </summary>
		public string ModeOfOxygenDeliveryDescription
		{
			get { return modeOfOxygenDeliveryDescription; }
			set { modeOfOxygenDeliveryDescription = value; }
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
