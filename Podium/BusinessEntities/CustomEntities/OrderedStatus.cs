using System;
using System.Collections.Generic;
using System.Text;
namespace Attune.Podium.BusinessEntities
{
  public class OrderedStatus
    {
        #region Fields
         private string status=String.Empty;
        private long investigationid=0 ; 
        private string    name=string.Empty;                       
        private string tcode=string.Empty;
        private string type = string.Empty;
       
        #endregion
        #region Properties
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public long Investigationid
        {
            get { return investigationid; }
            set { investigationid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Tcode
        {
            get { return tcode; }
            set { tcode = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        #endregion
    }
}
