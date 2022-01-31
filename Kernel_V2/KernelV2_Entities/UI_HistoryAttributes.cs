using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.KernelV2.Entities
{
  public  class UI_HistoryAttributes
    {
        public long AttributeID { get; set; }
        public string AttributeName { get; set; }
        public long AttributevalueID { get; set; }
        public string AttributeValueName { get; set; }
        public string Description { get; set; }
        public string HasAttribute { get; set; }
        public long HistoryID { get; set; }
        public string HistoryName { get; set; }
        public long InvestigationID { get; set; }
        public long PatientVisitID { get; set; }
        public string Type { get; set; }
    }
}
