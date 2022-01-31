using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class EMRAttributeClass
    {
        private long attributevalueID = 0;
        private string attributeValueName = String.Empty;
        private string attributeName = String.Empty;
        private long attributeID = 0;
      

        public long AttributevalueID
        {
            get { return attributevalueID; }
            set { attributevalueID = value; }
        }
        public long AttributeID
        {
            get { return attributeID; }
            set { attributeID = value; }
        }
        /// <summary>
        /// Gets or sets the AttributeValueName value.
        /// </summary>
        public string AttributeValueName
        {
            get { return attributeValueName; }
            set { attributeValueName = value; }
        }
        public string AttributeName
        {
            get { return attributeName; }
            set { attributeName = value; }
        }
    }
}
