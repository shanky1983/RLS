using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrgDetails
    {
        public int OrgID { get; set; }
        public int SampleReceived { get; set; }
        public int Approve { get; set; }
        public int SampleCollected { get; set; }
        public int Completed { get; set; }
        public int Pending { get; set; }
        public int Validate { get; set; }

    }
}
