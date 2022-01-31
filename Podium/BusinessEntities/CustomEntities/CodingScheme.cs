using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class CodingScheme
    {
        public string CodingSchemaName { get; set; }
        public string CodeName { get; set; }
        public int IdentifyingID { get; set; }
        public string IsPrimary { get; set; }
        public string IdentifyingType { get; set; }
    }
}
