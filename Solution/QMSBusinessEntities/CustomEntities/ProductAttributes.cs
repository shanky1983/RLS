using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Attune.Solution.QMSBusinessEntities
{
    public class ProductAttributes
    {
        
        string _ismandatory;
        public string IsMandatory
        {
            get { return _ismandatory; }
            set { _ismandatory = value; }
        }

       
        string attributeName;
        public string AttributeName
        {
            get { return attributeName; }
            set { attributeName = value; }
        }

      
        string attributeID;
        public string AttributeID
        {
            get { return attributeID; }
            set { attributeID = value; }
        }

      
        string attributeValue;
        public string AttributeValue
        {
            get { return attributeValue; }
            set { attributeValue = value; }
        }

        string isSelected;
        public string IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }



    }
}

