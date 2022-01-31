using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
   
    public class HCBillingItemModel
    {       
        public List<PageContextkeyModel1> PageContextkey { get; set; }
        public ContextDetails ContextInfo { get; set; }
    }
    public class PageContextkeyModel1
    {
        //public int OrgID { get; set; }
        public string FeeType { get; set; }       
        public string Description { get; set; }
        public long ClientID { get; set; }
        public string IS2ped { get; set; }
        public string Remarks { get; set; }
        public string Gender { get; set; }
       
    }

   


}