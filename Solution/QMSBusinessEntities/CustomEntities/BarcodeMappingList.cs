using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BarcodeMappingList
    {
        #region Fields

        private int barcodeMappingId = 0;
        private long productID = 0;
        private string productKey = String.Empty;
        private string barcode = String.Empty;
        private int unitSize = 0;
        private string unit = String.Empty;
        private string productname = String.Empty;
        private long purchaseorderid = 0;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the BarcodeMappingId value.
        /// </summary>
        public int BarcodeMappingId
        {
            get { return barcodeMappingId; }
            set { barcodeMappingId = value; }
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
        /// Gets or sets the ProductKey value.
        /// </summary>
        public string ProductKey
        {
            get { return productKey; }
            set { productKey = value; }
        }

        /// <summary>
        /// Gets or sets the Barcode value.
        /// </summary>
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        /// <summary>
        /// Gets or sets the UnitSize value.
        /// </summary>
        public int UnitSize
        {
            get { return unitSize; }
            set { unitSize = value; }
        }

        /// <summary>
        /// Gets or sets the Unit value.
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }
        public long PurchaseOrderID
        {
            get { return purchaseorderid; }
            set { purchaseorderid = value; }
        }
        #endregion
    }
}
