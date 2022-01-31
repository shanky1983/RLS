using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IVYInvestigationProductMapping
	{
		#region Fields

		private long investigationProductMapID=0;
		private long investigationID=0;
		private int isManualProcess=0;
		private int methodID=0;
		private int orgID=0;
		private string deviceID=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private int createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationProductMapID value.
		/// </summary>
		public long InvestigationProductMapID
		{
			get { return investigationProductMapID; }
			set { investigationProductMapID = value; }
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
		/// Gets or sets the IsManualProcess value.
		/// </summary>
		public int IsManualProcess
		{
			get { return isManualProcess; }
			set { isManualProcess = value; }
		}

		/// <summary>
		/// Gets or sets the MethodID value.
		/// </summary>
		public int MethodID
		{
			get { return methodID; }
			set { methodID = value; }
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
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
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
		public int CreatedBy
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
		public int ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
