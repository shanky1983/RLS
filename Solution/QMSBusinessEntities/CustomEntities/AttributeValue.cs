using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class AttributeValue
    {
        #region Fields

        private string unitNo = String.Empty;
        private string productId = String.Empty;
        private string productNo = String.Empty;
        private string otherValue = String.Empty;
        private string serialNo = String.Empty;
        public string IsIssued { get; set; }
        public string Description { get; set; }
        public string UsedSoFor { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the UnitNo value.
        /// </summary>
        public string UnitNo
        {
            get { return unitNo; }
            set { unitNo = value; }
        }


        /// <summary>
        /// Gets or sets the otherValue value.
        /// </summary>
        public string OtherValue
        {
            get { return otherValue; }
            set { otherValue = value; }
        }


        /// <summary>
        /// Gets or sets the ProductId value.
        /// </summary>
        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        /// <summary>
        /// Gets or sets the ProductNo value.
        /// </summary>
        public string ProductNo
        {
            get { return productNo; }
            set { productNo = value; }
        }
        
        /// <summary>
        /// Gets or sets the SerialNo value.
        /// </summary>
        public string SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }


        #endregion
    }
}
