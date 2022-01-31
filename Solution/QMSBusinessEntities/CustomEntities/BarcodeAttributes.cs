using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class BarcodeAttributes
    {
        public string HeaderLine1 { get; set; }
        public string HeaderLine2 { get; set; }
        public string FooterLine1 { get; set; }
        public string FooterLine2 { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string HeaderFontFamily { get; set; }
        public string HeaderFontSize { get; set; }
        public string HeaderFontStyle { get; set; }
        public string FooterFontFamily { get; set; }
        public string FooterFontSize { get; set; }
        public string FooterFontStyle { get; set; }
        public string BarcodeNumber { get; set; }
        public string Font { get; set; }
        public string TextHeight { get; set; }
        public string NoOfPrint { get; set; }
        public string LeftVertical { get; set; }
        public long VisitID { get; set; }
        public int SampleID { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string ImageHeight { get; set; }
        public string ImageWidth { get; set; }
        public string ImageAlignment { get; set; }
	
		public long ID { get; set; }
        public string BatchNo { get; set; }
    }
}
