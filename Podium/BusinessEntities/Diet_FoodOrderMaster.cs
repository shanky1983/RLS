using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Diet_FoodOrderMaster
	{
		#region Fields

		private long foodOrderID=0;
		private long foodID=0;
		private DateTime foodOrderDate=DateTime.MaxValue;
		private long orderBy=0;
		private long wardBy=0;
		private string orderStatus=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long patientDietPlanID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FoodOrderID value.
		/// </summary>
		public long FoodOrderID
		{
			get { return foodOrderID; }
			set { foodOrderID = value; }
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
		/// Gets or sets the FoodOrderDate value.
		/// </summary>
		public DateTime FoodOrderDate
		{
			get { return foodOrderDate; }
			set { foodOrderDate = value; }
		}

		/// <summary>
		/// Gets or sets the OrderBy value.
		/// </summary>
		public long OrderBy
		{
			get { return orderBy; }
			set { orderBy = value; }
		}

		/// <summary>
		/// Gets or sets the WardBy value.
		/// </summary>
		public long WardBy
		{
			get { return wardBy; }
			set { wardBy = value; }
		}

		/// <summary>
		/// Gets or sets the OrderStatus value.
		/// </summary>
		public string OrderStatus
		{
			get { return orderStatus; }
			set { orderStatus = value; }
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
		/// Gets or sets the PatientDietPlanID value.
		/// </summary>
		public long PatientDietPlanID
		{
			get { return patientDietPlanID; }
			set { patientDietPlanID = value; }
		}


		#endregion
}
}
