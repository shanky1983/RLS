using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IPTreatmentPlanMaster
	{
		#region Fields

		private string iPTreatmentPlanName=String.Empty;
		private int iPTreatmentPlanParentID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private int treatmentPlanID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IPTreatmentPlanName value.
		/// </summary>
		public string IPTreatmentPlanName
		{
			get { return iPTreatmentPlanName; }
			set { iPTreatmentPlanName = value; }
		}

		/// <summary>
		/// Gets or sets the IPTreatmentPlanParentID value.
		/// </summary>
		public int IPTreatmentPlanParentID
		{
			get { return iPTreatmentPlanParentID; }
			set { iPTreatmentPlanParentID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the TreatmentPlanID value.
		/// </summary>
		public int TreatmentPlanID
		{
			get { return treatmentPlanID; }
			set { treatmentPlanID = value; }
		}


		#endregion
}
}
