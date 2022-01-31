using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
   
    public class HCBillingClientName
    {       
        public List<PageClientContextkeyModel> PageContextkey { get; set; }
        public ContextDetails ContextInfo { get; set; }
    }
    public class PageClientContextkeyModel
    {
        //public int OrgID { get; set; }
        public string pType  { get; set; }       
        public int refhospid { get; set; }      
       
    }

   


}