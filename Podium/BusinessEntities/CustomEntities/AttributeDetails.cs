using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class AttributeDetails
    {
        #region Fields

        private int _AttributeId = 0;
        private int _AttributevalueID = 0;
        private string _AttributeValueName = String.Empty;

        public int AttributeID
        {
            get { return _AttributeId; }
            set { _AttributeId = value; }
        }


        public int AttributevalueID
        {
            get { return _AttributevalueID; }
            set { _AttributevalueID = value; }
        }


        public string AttributeValueName
        {
            get { return _AttributeValueName; }
            set { _AttributeValueName = value; }
        }

        
        #endregion

        
    }
}
