using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
        public string HeaderLine3 { get; set; }
        public string HeaderLine4 { get; set; }
        public string FooterLine3 { get; set; }
        public string FooterLine4 { get; set; }
        public string UID { get; set; }
        public string MachineName { get; set; }
		public int RowID { get; set; }
        public int TableSeq { get; set; }
        public string RightHeaderLine1 { get; set; }
        public string RightHeaderLine2 { get; set; }
        public string RightHeaderLine3 { get; set; }
        public string RightHeaderLine4 { get; set; }
        public string RightHeaderLine5 { get; set; }
        public string RightHeaderLine6 { get; set; }
        public string RightHeaderLine7 { get; set; }
        public string IsSecondaryBarCode { get; set; }
        public string BatchNo { get; set; }
        public string RightHeaderFontFamily{ get; set; } 
        public string RightHeaderFontSize{ get; set; }
        public string RightHeaderFontStyle { get; set; }
        public string PrinterName { get; set; }
        public string Status { get; set; } 
    }
}
