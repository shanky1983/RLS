using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ScreeningInfo
    {
        #region fields
        private long patientVisitID = 0;
        private DateTime screeningDate = DateTime.MaxValue;
        private DateTime createdAt = DateTime.MaxValue;
        private string screenedComplaintCodes = string.Empty;
        #endregion

        #region properties

        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }

        public DateTime ScreeningDate
        {
            get { return screeningDate; }
            set { screeningDate = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public string ScreenedComplaintCodes
        {
            get { return screenedComplaintCodes; }
            set { screenedComplaintCodes = value; }
        }
        #endregion
    }
}
