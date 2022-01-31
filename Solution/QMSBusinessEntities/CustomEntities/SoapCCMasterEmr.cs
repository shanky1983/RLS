using System;
using System.Collections.Generic;
using System.Text;
namespace Attune.Solution.QMSBusinessEntities
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
