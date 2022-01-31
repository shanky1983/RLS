using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities.CustomEntities
{
  public  class LJChartValue
    {

        public string ProcessedAt { get; set; }
        public string PDate { get; set; }
      
        public Decimal Value { get; set; }
        public Decimal TargetMean { get; set; }
        public Decimal Deviation { get; set; }
        public string CorrectionAction { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public string FailedRule { get; set; }
        public int InstrumentID { get; set; }
        public int RowNum { get; set; }
        public long InvestigationID { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime ModifiedBy { get; set; }
        public long OrgAddressID { get; set; }
        public long OrgID { get; set; }
        public string PreventiveAction { get; set; }
        public string QCLevel { get; set; }
        public int QcStatus { get; set; }
        public long QCValueID { get; set; }
        public string Reason { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
    }
}
