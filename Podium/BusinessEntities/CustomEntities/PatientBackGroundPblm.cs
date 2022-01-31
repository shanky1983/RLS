using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientBackGroundPblm
    {
        #region fields

        private string complaintName = string.Empty;
        private string complaintDescription = string.Empty;

        #endregion

        #region Properties

        public string ComplaintName
        {
            get { return complaintName; }
            set { complaintName = value; }
        }


        public string ComplaintDescription
        {
            get { return complaintDescription; }
            set { complaintDescription = value; }
        }

        #endregion
    }
}
