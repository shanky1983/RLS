using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class SoapExaminationMasterEMR
    {
       public int ExaminationID { get; set; }
       public int ParentID { get; set; }
       public string ExaminationName { get; set; }
       public long AttributeID { get; set; }
       public long AttributevalueID { get; set; }
       public string AttributeValueName { get; set; }

    }
}
