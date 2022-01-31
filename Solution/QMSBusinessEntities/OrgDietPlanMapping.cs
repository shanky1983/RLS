using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OrgDietPlanMapping
	{
		#region Fields

		private long orgDietPlanMappingID=0;
		private int dietPlanID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgDietPlanMappingID value.
		/// </summary>
		public long OrgDietPlanMappingID
		{
			get { return orgDietPlanMappingID; }
			set { orgDietPlanMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the DietPlanID value.
		/// </summary>
		public int DietPlanID
		{
			get { return dietPlanID; }
			set { dietPlanID = value; }
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

		/// <summary>
		/// Gets or sets the DietPlanName value.
		/// </summary>
		string _dietplanname;
		public string DietPlanName
		{
			get { return _dietplanname; }
			set { _dietplanname = value; }
		}


		#endregion
}
}
