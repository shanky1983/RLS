using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
  public  class ChiefComplaint
    {



        public long PatientVisitID { get; set; }
        public string Description { get; set; }
        public int HistoryID { get; set; }
        public string HistoryName { get; set; }
        public long AttributeID { get; set; }
        public long AttributevalueID { get; set; }
        public string AttributeValueName { get; set; }
        public long SeqID { get; set; }
        public long PatientHistoryAttributeID { get; set; }


    }
}
