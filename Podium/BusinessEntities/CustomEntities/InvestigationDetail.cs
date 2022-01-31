using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvestigationDetail
    {
        private string iD = string.Empty;
        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name = String.Empty;
        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string type = String.Empty;
        /// <summary>
        /// Gets or sets the Type value.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string isStat = String.Empty;
        /// <summary>
        /// Gets or sets the Type value.
        /// </summary>
        public string IsSTAT
        {
            get { return isStat; }
            set { isStat = value; }
        }

        /// <summary>
        /// Gets or sets the HistoryDetails value.
        /// </summary>
        private string _historyDetails = String.Empty;
        public string HistoryDetails
        {
            get { return _historyDetails; }
            set { _historyDetails = value; }
        }

        /// <summary>
        /// Gets or sets the TestSequenceOrder value.
        /// </summary>
        private int _testSequenceOrder = 0;
        public int TestSequenceOrder
        {
            get { return _testSequenceOrder; }
            set { _testSequenceOrder = value; }
        }
        /// <summary>
        /// Gets or sets the TestSequenceOrder value.
        /// </summary>
        private long _VisitID = 0;
        public long VisitID
        {
            get { return _VisitID; }
            set { _VisitID = value; }
        }
    }
}
