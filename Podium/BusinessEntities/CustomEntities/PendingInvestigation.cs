using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PendingInvestigation
    {
        #region Fields
        private DateTime visitDate = DateTime.MaxValue;
        private string investigationName = String.Empty;
        private string valu = String.Empty;
        private long patientVisitId = 0;
        private string _VisitNumber = String.Empty;
        public string VisitNumber
        {
            get { return _VisitNumber; }
            set { _VisitNumber = value; }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the InvestigationName value.
        /// </summary>
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        /// <summary>
        /// Gets or sets the Valu value.
        /// </summary>
        public string Value
        {
            get { return valu; }
            set { valu = value; }
        }
        /// <summary>
        /// Gets or sets the VisitDate value.
        /// </summary>
        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }
        /// <summary>
        /// Gets or sets the PatientVisitId value.
        /// </summary>
        public long PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }

        #endregion Properties
    }
}
