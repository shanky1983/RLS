using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class QC_AnalyzerMapping
    {
        private  string analyte = string.Empty;
        private  string assayCode = string.Empty;
        private  string devicename = string.Empty;
        private  string devicecode = string.Empty;
        private  string frequencyday = string.Empty;
        private  string frequencytime = string.Empty;
        private  long instrumentID;
        private  long investigationID;
        private  string QCrequired = string.Empty;
        public  string Analyte
        {
            get{return analyte;}
            set { analyte = value; }
        }
        public string AssayCode
        {
            get { return assayCode; }
            set { assayCode = value; }
        }
        public string DeviceName
        {
            get { return devicename; }
            set { devicename = value; }
        }
        public string DeviceCode
        {
            get { return devicecode;}
            set { devicecode = value; }
        }
        public string FrequencyDay
        {
            get { return frequencyday; }
            set { frequencyday = value; }
        }
        public string FrequencyTime
        {
            get { return frequencytime; }
            set { frequencytime = value; }
        }
        public long InstrumentID
        {
            get { return instrumentID; }
            set { instrumentID = value; }
        }
        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }
        public string  QCRequired
        {
            get { return QCrequired; }
            set { QCrequired = value; }
        }
    }
}
