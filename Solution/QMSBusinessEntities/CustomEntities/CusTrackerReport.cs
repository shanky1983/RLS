using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class CusTrackerReport
    {
        #region Fields

        public int orgID = 0;
        public string orgName = String.Empty;
        public long orgAddressID = 0;
        public string orgLocName = String.Empty;
        public int oPvisit = 0;
        public int iPvisit = 0;
        public int totvisit = 0;
        public int visitpurposeID = 0;
        public string visitpurposeName = String.Empty;
        public int visitCount = 0;
        public DateTime fDate = DateTime.MaxValue;
        public DateTime tDate = DateTime.MaxValue;
        public int dischargeSummaryCount = 0;
        public int patientsDischarged = 0;

        #endregion

        #region Properties
        
        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the Organization Name value.
        /// </summary>
        public string OrgName
        {
            get { return orgName; }
            set { orgName = value; }
        }

        /// <summary>
        /// Gets or sets the OrgAddressID value.
        /// </summary>
        public long OrgAddressID
        {
            get { return orgAddressID; }
            set { orgAddressID = value; }
        }

        /// <summary>
        /// Gets or sets the OrgLocName value.
        /// </summary>
        public string OrgLocName
        {
            get { return orgLocName; }
            set { orgLocName = value; }
        }

        /// <summary>
        /// Gets or sets the OPvisit value.
        /// </summary>
        public int OPvisit
        {
            get { return oPvisit; }
            set { oPvisit = value; }
        }

        /// <summary>
        /// Gets or sets the IPvisit value.
        /// </summary>
        public int IPvisit
        {
            get { return iPvisit; }
            set { iPvisit = value; }
        }

        /// <summary>
        /// Gets or sets the totvisit value.
        /// </summary>
        public int Totvisit
        {
            get { return totvisit; }
            set { totvisit = value; }
        }

        /// <summary>
        /// Gets or sets the VisitPurposeID.
        /// </summary>
        public int VisitPurposeID
        {
            get { return visitpurposeID; }
            set { visitpurposeID = value; }
        }

        /// <summary>
        /// Gets or sets the VisitPurpose Name value.
        /// </summary>
        public string VisitPurposeName
        {
            get { return visitpurposeName; }
            set { visitpurposeName = value; }
        }

         /// <summary>
        /// Gets or sets the VisitCount.
        /// </summary>
        public int VisitCount
        {
            get { return visitCount; }
            set { visitCount = value; }
        }

        /// <summary>
        /// Gets or sets the FDate value.
        /// </summary>
        public DateTime FDate
        {
            get { return fDate; }
            set { fDate = value; }
        }

        /// <summary>
        /// Gets or sets the TDate value.
        /// </summary>
        public DateTime TDate
        {
            get { return tDate; }
            set { tDate = value; }
        }

        /// <summary>
        /// Gets or sets the DischargeSummaryCount value.
        /// </summary>
        public int DischargeSummaryCount
        {
            get { return dischargeSummaryCount; }
            set { dischargeSummaryCount = value; }
        }

        /// <summary>
        /// Gets or sets the PatientsDischarged value.
        /// </summary>
        public int PatientsDischarged
        {
            get { return patientsDischarged; }
            set { patientsDischarged = value; }
        }

        #endregion
    }
}
