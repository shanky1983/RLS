using System;

namespace Attune.KernelV2.Entities
{
    public class UI_InvestigationStatus
    {
        public int InvestigationStatusID { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public int Orgid { get; set; }
        public string DisplayText { get; set; }
        public string ABBR { get; set; }
        public int Sequence { get; set; }
        public long InvestigationID { get; set; }
        public String StatuswithID { get; set; }
        public String IsAutoAuthorize { get; set; }
        public String ExcludeVIDlock { get; set; }
    }
}
