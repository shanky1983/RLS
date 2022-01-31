using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class CSSD
    {
        public long  Sno { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public string ProductName { get; set; }
        public string Status { get; set; }
        public int RaisedQty { get; set; }
        public int RecivedQty { get; set; }
    }
}
