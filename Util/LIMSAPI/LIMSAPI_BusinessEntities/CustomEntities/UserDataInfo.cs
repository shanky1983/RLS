using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class UserDataInfo : Paging
    {
        public string OrgCode { get; set; }
        public int OrgID { get; set; }
        public int LocationID { get; set; }
        public string Type { get; set; }
        public List<UsersList> Userinfo { get; set; }
    }
}
