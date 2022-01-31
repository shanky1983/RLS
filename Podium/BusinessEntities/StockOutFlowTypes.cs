using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockOutFlowTypes
	{
		#region Fields

		private int stockOutFlowTypeId=0;
		private string stockOutFlowType=String.Empty;
		private string description=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string isSupplierStockReturn=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockOutFlowTypeId value.
		/// </summary>
		public int StockOutFlowTypeId
		{
			get { return stockOutFlowTypeId; }
			set { stockOutFlowTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowType value.
		/// </summary>
		public string StockOutFlowType
		{
			get { return stockOutFlowType; }
			set { stockOutFlowType = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the IsSupplierStockReturn value.
		/// </summary>
		public string IsSupplierStockReturn
		{
			get { return isSupplierStockReturn; }
			set { isSupplierStockReturn = value; }
		}


		#endregion
}
}
