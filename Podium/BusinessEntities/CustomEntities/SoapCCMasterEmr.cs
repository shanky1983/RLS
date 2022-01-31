using System;
using System.Collections.Generic;
using System.Text;
namespace Attune.Podium.BusinessEntities
{
   public class SoapCCMasterEMR
    {
       public long OrgID { get; set; }
       //public int ReferenceIdentityIdForTable { get; set; }
       public string FieldType { get; set; }
       public long AttributeID { get; set; }
       public long AttributeValueID { get; set; }
       public string AttributeValueName { get; set; }
       public string AttributeName { get; set; }
    }
}
