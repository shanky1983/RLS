using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Diet_PatientDietPlanMaster
	{
		#region Fields

		private long patientDietPlanID=0;
		private long visitID=0;
		private long foodMenuID=0;
		private DateTime startDate=DateTime.MaxValue;
		private DateTime enddate=DateTime.MaxValue;
		private long foodSessionID=0;
		private string status=String.Empty;
		private long planedBy=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long foodID=0;
		private long patientID=0;
		private string refType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientDietPlanID value.
		/// </summary>
		public long PatientDietPlanID
		{
			get { return patientDietPlanID; }
			set { patientDietPlanID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the FoodMenuID value.
		/// </summary>
		public long FoodMenuID
		{
			get { return foodMenuID; }
			set { foodMenuID = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		/// <summary>
		/// Gets or sets the Enddate value.
		/// </summary>
		public DateTime Enddate
		{
			get { return enddate; }
			set { enddate = value; }
		}

		/// <summary>
		/// Gets or sets the FoodSessionID value.
		/// </summary>
		public long FoodSessionID
		{
			get { return foodSessionID; }
			set { foodSessionID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PlanedBy value.
		/// </summary>
		public long PlanedBy
		{
			get { return planedBy; }
			set { planedBy = value; }
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
		/// Gets or sets the FoodID value.
		/// </summary>
		public long FoodID
		{
			get { return foodID; }
			set { foodID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the RefType value.
		/// </summary>
		public string RefType
		{
			get { return refType; }
			set { refType = value; }
		}


		#endregion
}
}
