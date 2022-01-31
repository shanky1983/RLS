using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class LocationStockValues
    {
        #region Fields


        private int locationID = 0;
        private string locationName = String.Empty;
        private decimal stockValue = Decimal.Zero;
        private string description = String.Empty;
        private string name = String.Empty;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the locationID value.
        /// </summary>
        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }

        /// <summary>
        /// Gets or sets the LocationName value.
        /// </summary>
        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }


        public decimal StockValue
        {
            get { return stockValue; }
            set { stockValue = value; }
        }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        


        #endregion
    }
}
