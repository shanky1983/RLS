using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BarcodeIntegrationResults
    {
        #region Fields
        string barcode = string.Empty;
        string samplename = string.Empty;
        string patientname = string.Empty;
        string samplestatus = string.Empty;
        #endregion

        #region Properties
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public string SampleName
        {
            get { return samplename; }
            set { samplename = value; }
        }
        public string PatientName
        {
            get { return patientname ; }
            set { patientname = value; }
        }
        public string SampleStatus
        {
            get { return samplestatus; }
            set { samplestatus = value; }
        }

        #endregion
    }
}
