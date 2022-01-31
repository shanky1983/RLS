using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvIntegrationQCResult
    {
        private string sampleInstanceID = string.Empty;
        private List<InvIntegrationQCResultValue> lstIntegrationQCResultValue = new List<InvIntegrationQCResultValue>();
        private List<InvIntegrationGroups> lstIntegrationGroups = new List<InvIntegrationGroups>();

        public string SampleInstanceID
        {
            get { return sampleInstanceID; }
            set { sampleInstanceID = value; }
        }

        public List<InvIntegrationQCResultValue> LstIntegrationQCResultValue
        {
            get { return lstIntegrationQCResultValue; }
            set { lstIntegrationQCResultValue = value; }
        }
        public List<InvIntegrationGroups> LstIntegrationGroups
        {
            get { return lstIntegrationGroups; }
            set { lstIntegrationGroups = value; }
        }
    }
}
