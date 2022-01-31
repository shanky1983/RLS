using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class QCResultDetails
    {
        private string lotNumber = String.Empty;
        private string qcValue = String.Empty;
        private string qcStatus = String.Empty;
        private string qcLevel = String.Empty;
        private string qcRange = String.Empty;
        private string qcRule = String.Empty;
       
        public string LotNumber
        {
            get { return lotNumber; }
            set { lotNumber = value; }
        }

        public string QCValue
        {
            get { return qcValue; }
            set { qcValue = value; }
        }

        public string QCStatus
        {
            get { return qcStatus; }
            set { qcStatus = value; }
        }

        public string QCLevel
        {
            get { return qcLevel; }
            set { qcLevel = value; }
        }

        public string QCRange
        {
            get { return qcRange; }
            set { qcRange = value; }
        }

        public string QCRule
        {
            get { return qcRule; }
            set { qcRule = value; }
        }

    }
}
