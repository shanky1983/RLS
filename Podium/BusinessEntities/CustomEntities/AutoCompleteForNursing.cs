using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class AutoCompleteForNursing
    {
        //Id, DisplayText
        private long _id;
        private string _displayText = String.Empty;
        private long _attributeId;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string DisplayText
        {
            get { return _displayText; }
            set { _displayText = value; }
        }
        public long AttributeID
        {
            get { return _attributeId; }
            set { _attributeId = value; }
        }
    }
}
