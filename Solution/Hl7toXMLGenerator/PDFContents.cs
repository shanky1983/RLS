using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.HL7Integration
{
    public class content1
    {
        public PDFDetails MSG = new PDFDetails();
        // public List<PDFDetails> PDF1 = new List<PDFDetails>();
    }
    public class PDFDetails
    {
        string _OBR_Placer_Order_Number = string.Empty;
        public string OBR_Placer_Order_Number
        {
            get { return _OBR_Placer_Order_Number; }
            set { _OBR_Placer_Order_Number = value; }
        }
        string _observation_Date_Time = string.Empty;
        public string Observation_Date_Time
        {
            get { return _observation_Date_Time; }
            set { _observation_Date_Time = value; }
        }

        string _entered_By_ID = string.Empty;
        public string Entered_By_ID
        {
            get { return _entered_By_ID; }
            set { _entered_By_ID = value; }
        }

        byte[] _PDFBytes = new byte[10000];
        public byte[] PDFBytes
        {
            get { return _PDFBytes; }
            set { _PDFBytes = value; }
        }

    }

    public class ContentPDF
    {
        string _OBR_Placer_Order_Number = string.Empty;
        public string OBR_Placer_Order_Number
        {
            get { return _OBR_Placer_Order_Number; }
            set { _OBR_Placer_Order_Number = value; }
        }
        string _observation_Date_Time = string.Empty;
        public string Observation_Date_Time
        {
            get { return _observation_Date_Time; }
            set { _observation_Date_Time = value; }
        }

        string _entered_By_ID = string.Empty;
        public string Entered_By_ID
        {
            get { return _entered_By_ID; }
            set { _entered_By_ID = value; }
        }

        byte[] _PDFBytes;
        public byte[] PDFBytes
        {
            get { return _PDFBytes; }
            set { _PDFBytes = value; }
        }
    }
}
