using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Diet_FoodIngredientsMapping
	{
		#region Fields

		private long foodIngredientMappingID=0;
		private long foodID=0;
		private long foodIngredientID=0;
		private decimal quantity=Decimal.Zero;
		private string uOM=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FoodIngredientMappingID value.
		/// </summary>
		public long FoodIngredientMappingID
		{
			get { return foodIngredientMappingID; }
			set { foodIngredientMappingID = value; }
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
		/// Gets or sets the FoodIngredientID value.
		/// </summary>
		public long FoodIngredientID
		{
			get { return foodIngredientID; }
			set { foodIngredientID = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the UOM value.
		/// </summary>
		public string UOM
		{
			get { return uOM; }
			set { uOM = value; }
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
		/// Gets or sets the FoodName value.
		/// </summary>
		string _foodname;
		public string FoodName
		{
			get { return _foodname; }
			set { _foodname = value; }
		}

		/// <summary>
		/// Gets or sets the CombineValue value.
		/// </summary>
		string _combinevalue;
		public string CombineValue
		{
			get { return _combinevalue; }
			set { _combinevalue = value; }
		}

		/// <summary>
		/// Gets or sets the CombineData value.
		/// </summary>
		string _combinedata;
		public string CombineData
		{
			get { return _combinedata; }
			set { _combinedata = value; }
		}


		#endregion
}
}
