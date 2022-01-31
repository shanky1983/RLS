using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class CommunicationDetails
    {
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public string PatientName { get; set; }
        public bool IsNotify { get; set; }
        public string DocPassword { get; set; }
        public string OrgName { get; set; }
        public string OrgAddress { get; set; }
        public string Type { get; set; }
    }
}
