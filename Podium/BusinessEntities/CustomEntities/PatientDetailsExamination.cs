using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientDetailsExamination
    {
        #region fields

        private string examinationName = string.Empty;
        private string description = string.Empty;

        #endregion

        #region Properties

        public string ExaminationName
        {
            get { return examinationName; }
            set { examinationName = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion
    }
}
