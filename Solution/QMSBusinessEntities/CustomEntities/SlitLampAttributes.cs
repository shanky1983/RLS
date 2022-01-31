using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class SlitLampAttributes
    {
        #region Fields

        public long LoginId { get; set; }
        public long PatientVisitID { get; set; }
        public long ExaminationID { get; set; }
        public long ComplaintId { get; set; }
        public string Description { get; set; }
        public long AttributeID { get; set; }
        public long AttributevalueID { get; set; }
        public string AttributeValueName { get; set; }

        #endregion 
    }
}
