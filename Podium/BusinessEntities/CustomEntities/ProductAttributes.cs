using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Attune.Podium.BusinessEntities
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

        int AttrID;

        public int _AttrID
        {
            get { return AttrID; }
            set { AttrID = value; }
        }

        string ControlName;

        public string _ControlName
        {
            get { return ControlName; }
            set { ControlName = value; }
        }
        string ControlId;

        public string _ControlId
        {
            get { return ControlId; }
            set { ControlId = value; }
        }

        string HTMLTAG;

        public string _HTMLTAG
        {
            get { return HTMLTAG; }
            set { HTMLTAG = value; }
        }
        string XMLTAG;

        public string _XMLTAG
        {
            get { return XMLTAG; }
            set { XMLTAG = value; }
        }


    }
}

