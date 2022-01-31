using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IVYInvestigationProductMappingDetails
	{
		#region Fields

		private long investigationProductMapDetailID=0;
		private long investigationProductMapID=0;
		private long productID=0;
		private decimal consumptionQty=Decimal.Zero;
		private int consumptionUOMID=0;
		private decimal calibrationQty=Decimal.Zero;
		private int calibrationUOMID=0;
		private int orgID=0;
		private string isActive=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private int createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationProductMapDetailID value.
		/// </summary>
		public long InvestigationProductMapDetailID
		{
			get { return investigationProductMapDetailID; }
			set { investigationProductMapDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationProductMapID value.
		/// </summary>
		public long InvestigationProductMapID
		{
			get { return investigationProductMapID; }
			set { investigationProductMapID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionQty value.
		/// </summary>
		public decimal ConsumptionQty
		{
			get { return consumptionQty; }
			set { consumptionQty = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionUOMID value.
		/// </summary>
		public int ConsumptionUOMID
		{
			get { return consumptionUOMID; }
			set { consumptionUOMID = value; }
		}

		/// <summary>
		/// Gets or sets the CalibrationQty value.
		/// </summary>
		public decimal CalibrationQty
		{
			get { return calibrationQty; }
			set { calibrationQty = value; }
		}

		/// <summary>
		/// Gets or sets the CalibrationUOMID value.
		/// </summary>
		public int CalibrationUOMID
		{
			get { return calibrationUOMID; }
			set { calibrationUOMID = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
