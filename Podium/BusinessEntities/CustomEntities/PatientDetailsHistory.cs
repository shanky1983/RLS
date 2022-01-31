using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PatientDetailsHistory
    {
        #region fields

        private string histotyName = string.Empty;
        private string description = string.Empty;

        #endregion

        #region Properties

        public string HistoryName
        {
            get { return histotyName; }
            set { histotyName = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion
    }
}
