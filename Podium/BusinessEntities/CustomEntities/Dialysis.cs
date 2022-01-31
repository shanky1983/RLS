using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class Dialysis
    {
        #region Fields
        private long dialysisOnFlowID = 0;
        private long patientVisitID = 0;
        private DateTime onFlowDateTime = DateTime.MaxValue;
        private string remarks = String.Empty;
        private decimal vitalsValue = Decimal.Zero;
        private string vitalsName = String.Empty;
        private int vitalsID = 0;
        private string uOMCode = String.Empty;
        #endregion


        #region Properties
        /// <summary>
        /// Gets or sets the VitalsID value.
        /// </summary>
        public int VitalsID
        {
            get { return vitalsID; }
            set { vitalsID = value; }
        }

        /// <summary>
        /// Gets or sets the VitalsName value.
        /// </summary>
        public string VitalsName
        {
            get { return vitalsName; }
            set { vitalsName = value; }
        }

        /// <summary>
        /// Gets or sets the UOMCode value.
        /// </summary>
        public string UOMCode
        {
            get { return uOMCode; }
            set { uOMCode = value; }
        }

        /// <summary>
        /// Gets or sets the DialysisOnFlowID value.
        /// </summary>
        public long DialysisOnFlowID
        {
            get { return dialysisOnFlowID; }
            set { dialysisOnFlowID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientVisitID value.
        /// </summary>
        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }

        /// <summary>
        /// Gets or sets the OnFlowDateTime value.
        /// </summary>
        public DateTime OnFlowDateTime
        {
            get { return onFlowDateTime; }
            set { onFlowDateTime = value; }
        }

        /// <summary>
        /// Gets or sets the Remarks value.
        /// </summary>
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        /// <summary>
        /// Gets or sets the VitalsValue value.
        /// </summary>
        public decimal VitalsValue
        {
            get { return vitalsValue; }
            set { vitalsValue = value; }
        }
        #endregion
    }
}
