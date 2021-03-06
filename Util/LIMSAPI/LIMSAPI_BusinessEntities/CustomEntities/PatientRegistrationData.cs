using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   public  class PatientRegistrationData : Paging
   {
        public string OrgCode { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string Type { get; set; }
        public List<PatientRegistrationDetailsInfo> PatientRegistrationInfo { get; set; }
   }
}
