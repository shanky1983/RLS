using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class DashboardContent
    {
        private string displayText = string.Empty;
        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value; }
        }
        private string instrumentName = string.Empty;
        public string InstrumentName
        {
            get { return instrumentName; }
            set { instrumentName = value; }
        }
        private string investigationName = string.Empty;
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        private string tab = string.Empty;
        public string Tab
        {
            get { return tab; }
            set { tab = value; }
        }
        private string header = string.Empty;
        public string Header
        {
            get { return header; }
            set { header = value; }
        }
        private string hasvalue = string.Empty;
        public string HasValue
        {
            get { return hasvalue; }
            set { hasvalue = value; }
        }
        private DateTime dtime = DateTime.Now;
        public DateTime Dtime
        {
            get { return dtime; }
            set { dtime = value; }
        }
    }
}
