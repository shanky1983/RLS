using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class AuditTrailReport
    {
        public DateTime DateTime { get; set; }
        public string User { get; set; }
        public string Location { get; set; }
        public string Activity { get; set; }
        public string TestValue { get; set; }
        public string OldValues { get; set; }
        public string CurrentValues { get; set; }
    }
}
