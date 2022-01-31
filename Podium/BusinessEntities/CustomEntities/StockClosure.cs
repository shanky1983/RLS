using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockClosure
	{
		#region Fields

        private int     categoryID = 0;
        private long    productID = 0;

        private string  categoryName = String.Empty;
        private string  productName = String.Empty;
        private string  specification1 = String.Empty;

        private decimal totalStockReceived = 0;
        private decimal totalStockIssued = 0;
        private decimal totalStockDamage = 0;
        private decimal totalStockReturn = 0;
        private decimal closingBalance =0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargeID value.
		/// </summary>
        public int CategoryID
		{
            get { return categoryID; }
            set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeTypeID value.
		/// </summary>
        public long ProductID
		{
            get { return productID; }
            set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
        public string CategoryName
		{
            get { return categoryName; }
            set { categoryName = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulanceRequired value.
		/// </summary>
        public string ProductName
		{
            get { return productName; }
            set { productName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientConditionID value.
		/// </summary>
        public string Specification1
		{
            get { return specification1; }
            set { specification1 = value; }
		}

		/// <summary>
		/// Gets or sets the DateTimeofDischarge value.
		/// </summary>
        public decimal Received
		{
            get { return totalStockReceived; }
            set { totalStockReceived = value; }
		}

		/// <summary>
		/// Gets or sets the AttendeesName value.
		/// </summary>
        public decimal Issued
		{
            get { return totalStockIssued; }
            set { totalStockIssued = value; }
		}

		/// <summary>
		/// Gets or sets the RelationID value.
		/// </summary>
        public decimal Damaged
		{
            get { return totalStockDamage; }
            set { totalStockDamage = value; }
		}

		/// <summary>
		/// Gets or sets the ContactNumber value.
		/// </summary>
        public decimal Returned
		{
            get { return totalStockReturn; }
            set { totalStockReturn = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulanceConfirmed value.
		/// </summary>
        public decimal ClosingBalance
		{
            get { return closingBalance; }
            set { closingBalance = value; }
		}

		 

		#endregion
}
}
