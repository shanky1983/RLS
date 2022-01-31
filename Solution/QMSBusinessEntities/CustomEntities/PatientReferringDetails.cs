using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
 public  class PatientReferringDetails
    {
    
     public long RefPhysicianID { get; set; }
     public string RefPhyName { get; set; }
     public string ReferenceType { get; set; }
     public string FeeType { get; set; }
     public long FeeID { get; set; }
     public string Description { get; set; }
     public string Status { get; set; }
     public string Comments { get; set; }
     public string Perphyname { get; set; }
     public long PerphyID { get; set; }
    }
}
