using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class LoginLocation
    {
        public long LocationID { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string CenterTypeCode { get; set; }
        public long OrgID { get; set; }
        public string OrgName { get; set; }
    }

    public class LoginRoleLocation
    {
        public List<LoginLocation> RoleLocationlist { get; set; }
    }
}
