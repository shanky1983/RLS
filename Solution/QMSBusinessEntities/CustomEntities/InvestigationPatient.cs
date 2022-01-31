using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public  class InvestigationPatient
    {
        #region fields

        private string investigationName = string.Empty;
        private string investigationValue = string.Empty;
        private long investigationID = 0;
        private string filePath = string.Empty;
        
        
        #endregion


        #region Properties

        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }


        public string InvestigationValue
        {
            get { return investigationValue; }
            set { investigationValue = value; }
        }
        /// <summary>
        /// Gets or sets the InvestigationID value.
        /// </summary>
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        #endregion
    }
}
