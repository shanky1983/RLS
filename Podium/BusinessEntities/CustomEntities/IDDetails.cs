using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class IDDetails
    {
        #region Fields

        private int typeID = 0;
        private string typeValue = string.Empty;
        
        private long patientId = 0;
        
        #endregion

        #region Properties

        public int TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }

        public string TypeValue
        {
            get { return typeValue; }
            set { typeValue = value; }
        }

        public long PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        

        #endregion

    }
}
