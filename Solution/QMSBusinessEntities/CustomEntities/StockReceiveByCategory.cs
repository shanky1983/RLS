using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class StockReceiveByCategory
    {

        private string attributeName = string.Empty;
        private string controlName = string.Empty;
        private string dataType = string.Empty;
        private string displayText = string.Empty;
        private long categorieMappingID = 0;
        private long productID = 0;
        private string controlValue = string.Empty;
        private bool isMandatory = false;
        private int categoryID = 0;
        private string showColumn = string.Empty;
        public int SeqNo { get; set; }

        /// <summary>
        /// Gets or sets the AttributeName value.
        /// </summary>
        public string AttributeName
        {
            get { return attributeName; }
            set { attributeName = value; }
        }

        /// <summary>
        /// Gets or sets the ControlName value.
        /// </summary>
        public string ControlName
        {
            get { return controlName; }
            set { controlName = value; }
        }


        /// <summary>
        /// Gets or sets the DataType value.
        /// </summary>
        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }

        /// <summary>
        /// Gets or sets the DisplayText value.
        /// </summary>
        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value; }
        }

        /// <summary>
        /// Gets or sets the CategorieMappingID value.
        /// </summary>
        public long CategorieMappingID
        {
            get { return categorieMappingID; }
            set { categorieMappingID = value; }
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
        /// Gets or sets the DataType value.
        /// </summary>
        public string ControlValue
        {
            get { return controlValue; }
            set { controlValue = value; }
        }


        /// <summary>
        /// Gets or sets the isMandatory value.
        /// </summary>
        public bool IsMandatory
        {
            get { return isMandatory; }
            set { isMandatory = value; }
        }


        /// <summary>
        /// Gets or sets the CategoryID value.
        /// </summary>
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }


        /// <summary>
        /// Gets or sets the ShowColumn value.
        /// </summary>
        public string ShowColumn
        {
            get { return showColumn; }
            set { showColumn = value; }
        }

    }
}
