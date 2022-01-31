using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class InvestigationSampleResult
    {
        #region Fields
       
        private string Loginname = String.Empty;
        private string StatuS = string.Empty;
        private DateTime Createdby = DateTime.Now;
        private string Investigationname = string.Empty;


        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the InvestigationStatusID value.
        /// </summary>
        public string LoginName
        {
            get { return Loginname; }
            set { Loginname = value; }
        }
        public string Status
        {
            get { return StatuS; }
            set { StatuS = value; }
        }
        public string InvestigationName
        {
            get { return Investigationname; }
            set { Investigationname = value; }
        }
       
        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        public DateTime CreatedBy
        {
            get { return Createdby; }
            set { Createdby = value; }
        }

        /// <summary>
        /// Gets or sets the InvestigationID value.
        /// </summary>        


        #endregion
    }
}
