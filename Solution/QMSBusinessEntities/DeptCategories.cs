using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DeptCategories
	{
		#region Fields

		private int deptCategoriesID=0;
		private int deptID=0;
		private int categoryID=0;
		private string isDeleted=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeptCategoriesID value.
		/// </summary>
		public int DeptCategoriesID
		{
			get { return deptCategoriesID; }
			set { deptCategoriesID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		public int CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the IsDeleted value.
		/// </summary>
		public string IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}


		#endregion
}
}
