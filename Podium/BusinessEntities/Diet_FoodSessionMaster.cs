using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Diet_FoodSessionMaster
	{
		#region Fields

		private long foodSessionID=0;
		private string foodSessionName=String.Empty;
		private string description=String.Empty;
		private TimeSpan fromTime=TimeSpan.MinValue;
		private TimeSpan toTime=TimeSpan.MinValue;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FoodSessionID value.
		/// </summary>
		public long FoodSessionID
		{
			get { return foodSessionID; }
			set { foodSessionID = value; }
		}

		/// <summary>
		/// Gets or sets the FoodSessionName value.
		/// </summary>
		public string FoodSessionName
		{
			get { return foodSessionName; }
			set { foodSessionName = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the FromTime value.
		/// </summary>
		public TimeSpan FromTime
		{
			get { return fromTime; }
			set { fromTime = value; }
		}

		/// <summary>
		/// Gets or sets the ToTime value.
		/// </summary>
		public TimeSpan ToTime
		{
			get { return toTime; }
			set { toTime = value; }
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
