using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProductCategories
	{
		#region Fields

		private int categoryID=0;
		private string categoryName=String.Empty;
		private int orgID=0;
		private string description=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private string isDeleted=String.Empty;
		private long parentCategorieID=0;
		private decimal tax=Decimal.Zero;
		private long id=0;
		private long tempcategoryID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		public int CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryName value.
		/// </summary>
		public string CategoryName
		{
			get { return categoryName; }
			set { categoryName = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the IsDeleted value.
		/// </summary>
		public string IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}

		/// <summary>
		/// Gets or sets the ParentCategorieID value.
		/// </summary>
		public long ParentCategorieID
		{
			get { return parentCategorieID; }
			set { parentCategorieID = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
		}

		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the TempcategoryID value.
		/// </summary>
		public long TempcategoryID
		{
			get { return tempcategoryID; }
			set { tempcategoryID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		private int _deptID=0;
		public int DeptID
		{
			get { return  _deptID; }
			set { _deptID = value; }
		}

		/// <summary>
		/// Gets or sets the TypeId value.
		/// </summary>
		private int _typeId=0;
		public int TypeId
		{
			get { return  _typeId; }
			set { _typeId = value; }
		}


		#endregion
}
}
