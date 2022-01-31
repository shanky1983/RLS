using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class QCResultValidationDetails
    {
        private string lotNumber = String.Empty;
        private string qclevel = String.Empty;
        private string testCode = String.Empty;
        private string deviceID = String.Empty;
        private string labMean = String.Empty;
        private string labSD = String.Empty;
        //private List<string> qcValues;

        public string LotNumber
        {
            get { return lotNumber; }
            set { lotNumber = value; }
        }

        public string QClevel
        {
            get { return qclevel; }
            set { qclevel = value; }
        }

        public string TestCode
        {
            get { return testCode; }
            set { testCode = value; }
        }

        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public string LabMean
        {
            get { return labMean; }
            set { labMean = value; }
        }

        public string LabSD
        {
            get { return labSD; }
            set { labSD = value; }
        }

        //public List<string> QCValues
        //{
        //    get { return qcValues; }
        //    set { qcValues = value; }
        //}
    }
}
