using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class InvLimsReport
    {
        
        private string orgName = String.Empty;
        private string deptName = String.Empty;
        private string investigationName = String.Empty;
        private string processingOrgName = String.Empty;
        private decimal rate = 0;
        private int numberOfOccurance = 0;
        private decimal billedAmount = 0;
        private decimal myCost = 0;
        private decimal netAmount = 0;
        private string sampleName = String.Empty;
        private string clientName = String.Empty;
        private string location = String.Empty;
        private string referingphysicianname = String.Empty;
        private string referorgname = String.Empty;

        public string ReferOrgName
        {
            get { return referorgname; }
            set { referorgname = value; }
        }

        public string ReferingPhysicianName
        {
            get { return referingphysicianname; }
            set { referingphysicianname = value; }
        }

        public string OrgName
        {
            get { return orgName; }
            set { orgName = value; }
        }
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        public string ProcessingOrgName
        {
            get { return processingOrgName; }
            set { processingOrgName = value; }
        }
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public int NumberOfOccurance
        {
            get { return numberOfOccurance; }
            set { numberOfOccurance = value; }
        }
        public decimal BilledAmount
        {
            get { return billedAmount; }
            set { billedAmount = value; }
        }
        public decimal MyCost
        {
            get { return myCost; }
            set { myCost = value; }
        }
        public decimal NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }
        public string SampleName
        {
            get { return sampleName; }
            set { sampleName = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

    }
}
