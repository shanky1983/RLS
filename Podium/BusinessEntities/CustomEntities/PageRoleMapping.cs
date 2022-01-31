using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PageRoleMapping
    {
        public string PageURL { get; set; }
        public string PageName { get; set; }
        public long RoleID { get; set; }
        public long PageID { get; set; }
    }
     
}
