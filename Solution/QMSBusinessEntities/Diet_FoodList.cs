using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Diet_FoodList
	{
		#region Fields

		private long foodID=0;
		private string foodName=String.Empty;
		private long foodCategoryID=0;
		private string description=String.Empty;
		private int orgID=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FoodID value.
		/// </summary>
		public long FoodID
		{
			get { return foodID; }
			set { foodID = value; }
		}

		/// <summary>
		/// Gets or sets the FoodName value.
		/// </summary>
		public string FoodName
		{
			get { return foodName; }
			set { foodName = value; }
		}

		/// <summary>
		/// Gets or sets the FoodCategoryID value.
		/// </summary>
		public long FoodCategoryID
		{
			get { return foodCategoryID; }
			set { foodCategoryID = value; }
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

		/// <summary>
		/// Gets or sets the FoodCategoryName value.
		/// </summary>
		string _foodcategoryname;
		public string FoodCategoryName
		{
			get { return _foodcategoryname; }
			set { _foodcategoryname = value; }
		}


		#endregion
}
}
