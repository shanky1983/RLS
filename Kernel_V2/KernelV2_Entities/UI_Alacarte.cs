using System;
using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_Alacarte
    {           
        public long LandingPage { get; set; }        
        public int MenuID { get; set; }
        public string MenuURL{ get; set; }        
        public string MenuName { get; set; }        
        public int ParentID { get; set; }       
        public Int64 PageID { get; set; }        
        public string HeaderText { get; set; }        
        public string HeaderCode{ get; set; }      
        public string LanguageCode { get; set; }               
        public long OrgId { get; set; }         
        public long RoleID { get; set; }        
        public List<UI_Alacarte> SubMenu { get; set; }        
        public string CssClass { get; set; }         
        public string faClass { get; set; }
        public int SequenceId { get; set; }
        public string TemplateUrl { get; set; }
        public string Controller { get; set; }
        public bool IsMenu { get; set; }
        public string Dependencies { get; set; }        
    }
}
