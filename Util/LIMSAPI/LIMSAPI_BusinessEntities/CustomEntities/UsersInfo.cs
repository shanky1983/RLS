using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class UsersInfo
    {
        public long UserID { get; set; }
        public string Name { get; set; }
        public string LoginID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string ServerName { get; set; }
        public string URL { get; set; }
        public int OrgID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
