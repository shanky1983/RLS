using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class InvIntegrationResultValue
    {
        private string testCode = String.Empty;
        private string resultValue = String.Empty;
        private string resultUOM = String.Empty;
        private string deviceID = String.Empty;
        private string organismName = String.Empty;
        private string organismCode = String.Empty;
        private string drugCode = String.Empty;
        private string drugName = String.Empty;
        private string sensitivity = String.Empty;
        private string micValue = String.Empty;
        private string deviceErrorCode = String.Empty;

        public string MicValue
        {
            get { return micValue; }
            set { micValue = value; }
        }

        public string Sensitivity
        {
            get { return sensitivity; }
            set { sensitivity = value; }
        }

        public string DrugName
        {
            get { return drugName; }
            set { drugName = value; }
        }

        public string DrugCode
        {
            get { return drugCode; }
            set { drugCode = value; }
        }

        public string OrganismName
        {
            get { return organismName; }
            set { organismName = value; }
        }

        public string OrganismCode
        {
            get { return organismCode; }
            set { organismCode = value; }
        }

        public string TestCode
        {
            get { return testCode; }
            set { testCode = value; }
        }

        public string ResultValue
        {
            get { return resultValue; }
            set { resultValue = value; }
        }

        public string ResultUOM
        {
            get { return resultUOM; }
            set { resultUOM = value; }
        }

        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

       
        public string DeviceErrorCode
        {
            get { return deviceErrorCode; }
            set { deviceErrorCode = value; }
        }
    }
}
