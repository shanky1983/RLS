using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class InvIntegrationResult
    {
        private string sampleInstanceID = string.Empty;
        private List<InvIntegrationResultValue> lstIntegrationResultValue = new List<InvIntegrationResultValue>();
        private List<InvIntegrationGroups> lstIntegrationGroups = new List<InvIntegrationGroups>();

        public string SampleInstanceID
        {
            get { return sampleInstanceID; }
            set { sampleInstanceID = value; }
        }

        public List<InvIntegrationResultValue> LstIntegrationResultValue
        {
            get { return lstIntegrationResultValue; }
            set { lstIntegrationResultValue = value; }
        }
        public List<InvIntegrationGroups> LstIntegrationGroups
        {
            get { return lstIntegrationGroups; }
            set { lstIntegrationGroups = value; }
        }
    }
}
