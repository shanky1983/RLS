using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class ClientBasicDetails
    {
       public String ClientCode { get; set; }
       public int ClientType { get; set; }
       public String RegistrationType { get; set; }
       public Boolean HasParent { get; set; }
       public long txtHasparent { get; set; }
       public String CCLabReport { get; set; }
       public int SplPrivileges { get; set; }
       public String OrderableLocation { get; set; }
       public long PrintLocation { get; set; }
       public int NoofPrintCopies { get; set; }
       public long Location { get; set; }
       public long Hub { get; set; }
       public long Zone { get; set; }
       public long Route { get; set; }
       public int TransitTime { get; set; }
       public String ddlTransitTime { get; set; }
       public String ExAutoAuthorization { get; set; }
    }
}
