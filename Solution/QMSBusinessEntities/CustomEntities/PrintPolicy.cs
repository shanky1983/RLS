using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PrintPolicy
    {
        public Int64 ID { get; set; }
        public String Type { get; set; }
        public String RoleName { get; set; }
        public String LocationName { get; set; }
        public String Value { get; set; }
        public Boolean IsActive { get; set; }
    }
}
