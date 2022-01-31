using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
   public class QCMedanSD
    {
        public Decimal TargetMean { get; set; }
        public Decimal CV { get; set; }
        public Decimal SD { get; set; }
        public Decimal p1s { get; set; }
        public Decimal p2s { get; set; }
        public Decimal p3s { get; set; }
        public Decimal m1s { get; set; }
        public Decimal m2s { get; set; }
        public Decimal m3s { get; set; }
    }
}
