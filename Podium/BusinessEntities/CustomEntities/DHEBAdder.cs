using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class DHEBAdder
    {
        #region Fields
            private string dhebDescription = string.Empty;
            private string dhebComments = string.Empty;
            private long patientvisitid = 0;
            private long createdby = 0;
        #endregion

        #region Properties
            /// <summary>
            /// Gets or sets the Description value.
            /// </summary>
            public string Description
            {
                get { return dhebDescription; }
                set { dhebDescription = value; }
            }

            /// <summary>
            /// Gets or sets the Comments value.
            /// </summary>
            public string Comments
            {
                get { return dhebComments; }
                set { dhebComments = value; }
            }

            public long CreatedBy
            {
                get { return createdby; }
                set { createdby = value; }
            }

            public long PatientVisitID
            {
                get { return patientvisitid; }
                set { patientvisitid = value; }
            }
        #endregion
    }
}
