using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Diet_FoodMenuDetails
	{
		#region Fields

		private long foodMenuDetailID=0;
		private long foodMenuID=0;
		private long foodID=0;
		private int foodSessionID=0;
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
		/// Gets or sets the FoodMenuDetailID value.
		/// </summary>
		public long FoodMenuDetailID
		{
			get { return foodMenuDetailID; }
			set { foodMenuDetailID = value; }
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
		/// Gets or sets the FoodID value.
		/// </summary>
		public long FoodID
		{
			get { return foodID; }
			set { foodID = value; }
		}

		/// <summary>
		/// Gets or sets the FoodSessionID value.
		/// </summary>
		public int FoodSessionID
		{
			get { return foodSessionID; }
			set { foodSessionID = value; }
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
		/// Gets or sets the FoodMenuName value.
		/// </summary>
		string _foodmenuname;
		public string FoodMenuName
		{
			get { return _foodmenuname; }
			set { _foodmenuname = value; }
		}

		/// <summary>
		/// Gets or sets the FoodSessionName value.
		/// </summary>
		string _foodsessionname;
		public string FoodSessionName
		{
			get { return _foodsessionname; }
			set { _foodsessionname = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		string _uomcode;
		public string UOMCode
		{
			get { return _uomcode; }
			set { _uomcode = value; }
		}


		#endregion
}
}
