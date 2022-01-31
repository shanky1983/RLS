using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvIntegrationGroups
    {
        private string parentCode = String.Empty;
        private List<InvIntegrationResultValue> lstResultValue = new List<InvIntegrationResultValue>();

        public string ParentCode
        {
            get { return parentCode; }
            set { parentCode = value; }
        }
        public List<InvIntegrationResultValue> LstResultValue
        {
            get { return lstResultValue; }
            set { lstResultValue = value; }
        }
    }
}
