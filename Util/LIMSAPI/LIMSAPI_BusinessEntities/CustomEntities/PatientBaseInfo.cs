using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PatientBaseInfo
    {
        public long PatientID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salutation { get; set; }
        public string Age { get; set; }
        public string PatientNumber { get; set; }
        public string PatientType { get; set; }
        public int ExternalPatientNumber { get; set; }

    }
}