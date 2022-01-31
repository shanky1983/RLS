using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BarcodeAttributes
    {
        public string HeaderLine1 { get; set; }
        public string HeaderLine2 { get; set; }
        public string FooterLine1 { get; set; }
        public string FooterLine2 { get; set; }
        public string HeaderLine3 { get; set; }
        public string FooterLine3 { get; set; }
        public string HeaderLine4 { get; set; }
        public string FooterLine4 { get; set; }
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
        public bool IsSecondaryBarCode { get; set; }
        public string RightHeaderLine1 { get; set; }
        public string RightHeaderLine2 { get; set; }
        public string RightHeaderLine3 { get; set; }
        public string RightHeaderLine4 { get; set; }
        public string RightHeaderLine5 { get; set; }
        public string RightHeaderLine6 { get; set; }
        public string RightHeaderLine7 { get; set; }
        public string PrinterName { get; set; }
        public string Status { get; set; }
        public string RightHeaderFontFamily { get; set; }
        public string RightHeaderFontSize { get; set; }
        public string RightHeaderFontStyle { get; set; }
        public string PRNFileText { get; set; }
        private int barcodecount = 1;
        public int BarcodeCount
        {
            get { return barcodecount; }
            set { barcodecount = value; }
        }

    }
}
