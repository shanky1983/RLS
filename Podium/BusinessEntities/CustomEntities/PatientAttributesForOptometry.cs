using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
public class PatientAttributesForOptometry
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
        public long PatientExaminationAttributeID { get; set; }
        public long SeqID { get; set; }
        public long SNO { get; set; }
   

        #endregion 
    }
}
