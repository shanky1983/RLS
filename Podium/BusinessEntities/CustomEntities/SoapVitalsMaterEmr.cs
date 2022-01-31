using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class SoapVitalsMaterEmr
    {
        public int UOMID { get; set; }
        public string UomCode { get; set; }
        public string VitalsName { get; set; }
        public int VitalsID { get; set; }
        public string UOMDescription { get; set; }
        public string VitalsGroup { get; set; }

    }
}
