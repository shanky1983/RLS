using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class PrintBarcode
    {
        public long VisitID { get; set; }
        public int SampleID { get; set; }
        public string BarcodeNumber { get; set; }
        public string MachineID { get; set; }
        public string HeaderLine1 { get; set; }
        public string HeaderLine2 { get; set; }
        public string FooterLine1 { get; set; }
        public string FooterLine2 { get; set; }
        public int RowID { get; set; }
        public int TableSeq { get; set; }
    }
}
