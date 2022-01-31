using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class LabPatientInvestigation
    {
        private long groupID = 0;
        private long investigationID = 0;
        private string groupName = String.Empty;
        private string investigationName = String.Empty;
        private string type = String.Empty;
        private decimal rate = 0;

        public long GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }


        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

       

    }
}
