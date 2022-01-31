using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Attune.Podium.BusinessEntities
{
    public class AuthenticateUser
    {
        [DataMember(Order = 0)]
        public string AuthToken { get; set; }

        [DataMember(Order = 1)]
        public long LoginID { get; set; }

        [DataMember(Order = 2)]
        public string LoginName { get; set; }

        [DataMember(Order = 3)]
        public string UserName { get; set; }

        //[DataMember(Order = 4)]
        //public long UserID { get; set; }

        [DataMember(Order = 4)]
        public long PhysicianID { get; set; }

        [DataMember(Order = 5)]
        public long TenantID { get; set; }

        [DataMember(Order = 6)]
        public List<Role> LoginRole { get; set; }
    }
}
