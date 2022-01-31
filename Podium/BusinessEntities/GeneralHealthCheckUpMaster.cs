using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class GeneralHealthCheckUpMaster
	{
		#region Fields

		private long generalHealthCheckUpID=0;
		private string generalHealthCheckUpName=String.Empty;
		private string generalHealthCheckUpType=String.Empty;
		private string generalHealthCheckUpDesc=String.Empty;
		private long orgID=0;
		private string isAVisitPurpose=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the GeneralHealthCheckUpID value.
		/// </summary>
		public long GeneralHealthCheckUpID
		{
			get { return generalHealthCheckUpID; }
			set { generalHealthCheckUpID = value; }
		}

		/// <summary>
		/// Gets or sets the GeneralHealthCheckUpName value.
		/// </summary>
		public string GeneralHealthCheckUpName
		{
			get { return generalHealthCheckUpName; }
			set { generalHealthCheckUpName = value; }
		}

		/// <summary>
		/// Gets or sets the GeneralHealthCheckUpType value.
		/// </summary>
		public string GeneralHealthCheckUpType
		{
			get { return generalHealthCheckUpType; }
			set { generalHealthCheckUpType = value; }
		}

		/// <summary>
		/// Gets or sets the GeneralHealthCheckUpDesc value.
		/// </summary>
		public string GeneralHealthCheckUpDesc
		{
			get { return generalHealthCheckUpDesc; }
			set { generalHealthCheckUpDesc = value; }
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
		/// Gets or sets the IsAVisitPurpose value.
		/// </summary>
		public string IsAVisitPurpose
		{
			get { return isAVisitPurpose; }
			set { isAVisitPurpose = value; }
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

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		private String _active=String.Empty;
		public String Active
		{
			get { return  _active; }
			set { _active = value; }
		}


		#endregion
}
}
