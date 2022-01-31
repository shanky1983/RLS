using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BridgingInvestigationValue
    {
        private long orderID = 0;
        private long investigationID = 0;
        private long accessionNumber = 0;
        private DateTime orderDate = DateTime.MaxValue;
        private string visitNumber = String.Empty;
        private string investigationName = String.Empty;
        private string investigationResult = String.Empty;
        private string fileName = String.Empty;

        public long OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }
        public long AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }

        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }

        public string InvestigationResult
        {
            get { return investigationResult; }
            set { investigationResult = value; }
        }

        public string FileName
        {
            get { return fileName ; }
            set { fileName = value; }
        }
    }
}


