using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PresentIllnessDisplay
    {
        private long _sno;
        private string _historyname;
        private string _duration;
        private string _eyes;
        private int _historyid;
        private long _seqid;
        private long _patientvisitid;

        public long Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }
        public string HistoryName
        {
            get { return _historyname; }
            set { _historyname = value; }
        }
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public string Eyes
        {
            get { return _eyes; }
            set { _eyes = value; }
        }
        public int HistoryID
        {
            get { return _historyid; }
            set { _historyid = value; }
        }
        public long SeqID
        {
            get { return _seqid; }
            set { _seqid = value; }
        }
        public long PatientVisitID { 
            get { return _patientvisitid; }
            set { _patientvisitid = value; }
        }
    }
}
