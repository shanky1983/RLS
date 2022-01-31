using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class SampleWorkFlow
    {
        public string Name { get; set; }
        public string InstrumentName { get; set; }
        public long ID { get; set; }
        public long AccessionNumber { get; set; }
        public string InvestigationName { get; set; }
        public int GroupSequence { get; set; }
        public int AnalyserSequence { get; set; }
        public int DeptSequence { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string Status { get; set; }
        public long PatientVisitID { get; set; }
        public string UID { get; set; }
        public string ScheduleDateTime { get; set; }
        public string TrayIDs { get; set; }
    }
}
