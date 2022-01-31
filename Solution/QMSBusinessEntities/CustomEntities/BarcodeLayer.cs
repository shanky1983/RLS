using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Attune.Solution.QMSBusinessEntities
{
    public class BarcodeLayer
    {
        public int id { get; set; }
        public long PatientVisitID { get; set; }
        public int SampleID { get; set; }
        public string  BarcodeNumber { get; set; }
        public int sequenceno { get; set; }
        public int layer { get; set; }
      
    }
}
