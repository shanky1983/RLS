using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _foodName=String.Empty;
		public string FoodName
		{
			get { return  _foodName; }
			set { _foodName = value; }
		}

		/// <summary>
		/// Gets or sets the FoodMenuName value.
		/// </summary>
		private string _foodMenuName=String.Empty;
		public string FoodMenuName
		{
			get { return  _foodMenuName; }
			set { _foodMenuName = value; }
		}

		/// <summary>
		/// Gets or sets the FoodSessionName value.
		/// </summary>
		private string _foodSessionName=String.Empty;
		public string FoodSessionName
		{
			get { return  _foodSessionName; }
			set { _foodSessionName = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		private string _uOMCode=String.Empty;
		public string UOMCode
		{
			get { return  _uOMCode; }
			set { _uOMCode = value; }
		}


		#endregion
}
}
