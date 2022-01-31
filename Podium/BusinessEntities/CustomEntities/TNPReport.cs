using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class TNPReport
    {
        public long  Patientvisitid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public string VisitNumber { get; set; }
        public string RegistrationDateTime { get; set; }
        public long ID { get; set; }
        public string TestName { get; set; }
        public string SampleName { get; set; }
        public string CollectedDateTime { get; set; }
        public string SampleReceivedDateTime { get; set; }
        public string ValidateDateTime { get; set; }
        public string ApproveddateTime { get; set; }
        public string InvestigationValues { get; set; }
        public string ClientName { get; set; }
        public string Status { get; set; }
        public decimal AmountReceived { get; set; }
               
    }
}
