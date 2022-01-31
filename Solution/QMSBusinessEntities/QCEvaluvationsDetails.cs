using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class QCEvaluvationsDetails
    {
        private long investigationID = 0;
        private long instrumentID = 0;
        private long lotID = 0;
        private int orgID = 0;
        private decimal mean = Decimal.Zero;
        private decimal standardDeviation = Decimal.Zero;
        private decimal coVariation = Decimal.Zero;
        private string qcLevel = string.Empty;

        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID=value; }
        }

        public long InstrumentID
        {
            get { return instrumentID; }
            set { instrumentID = value; }
        }

        public long LotID
        {
            get { return lotID; }
            set { lotID = value; }
        }

        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        public decimal Mean
        {
            get { return mean; }
            set { mean = value; }
        }


        public decimal StandardDeviation
        {
            get { return standardDeviation; }
            set { standardDeviation = value; }
        }

        public decimal CoVariation
        {
            get { return coVariation; }
            set { coVariation = value; }
        }

        public string QCLevel
        {
            get { return qcLevel; }
            set { qcLevel = value; }
        }
    }
}
