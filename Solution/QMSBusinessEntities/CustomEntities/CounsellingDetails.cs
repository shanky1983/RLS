using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class CounsellingDetails
    {
        #region Fields

        private long visitID;
        private DateTime visitDate = DateTime.MaxValue;
        private int counselID;
        private string counselType = String.Empty;
        private string symptoms = String.Empty;
        private string isConfidential = String.Empty;
        private string reviewofsystem = String.Empty;
        private string examination = String.Empty;

        #endregion

        #region Properties

        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }

        public int CounselID
        {
            get { return counselID; }
            set { counselID = value; }
        }

        public string CounselType
        {
            get { return counselType; }
            set { counselType = value; }
        }

        public string Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }

        public string IsConfidential
        {
            get { return isConfidential; }
            set { isConfidential = value; }
        }

        public string ReviewOfSystem
        {
            get { return reviewofsystem; }
            set { reviewofsystem = value; }
        }

        public string Examination
        {
            get { return examination; }
            set { examination = value; }
        }

        #endregion
    }

}
