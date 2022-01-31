using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IVYAdditionalConsumption
	{
		#region Fields

		private long additionalConsumptionID=0;
		private long investigationID=0;
		private string deviceID=String.Empty;
		private string consumptionType=String.Empty;
		private int consumptionCount=0;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime testDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AdditionalConsumptionID value.
		/// </summary>
		public long AdditionalConsumptionID
		{
			get { return additionalConsumptionID; }
			set { additionalConsumptionID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionType value.
		/// </summary>
		public string ConsumptionType
		{
			get { return consumptionType; }
			set { consumptionType = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionCount value.
		/// </summary>
		public int ConsumptionCount
		{
			get { return consumptionCount; }
			set { consumptionCount = value; }
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
		/// Gets or sets the TestDate value.
		/// </summary>
		public DateTime TestDate
		{
			get { return testDate; }
			set { testDate = value; }
		}


		#endregion
}
}
