using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{

   public class PatientAttributeForIOP
    {
        public long SeqID { get; set; }         
        public long ExaminationID { get; set; }
        public long MethodAttributeID { get; set; }
        public long IOPODAttributeID { get; set; }
        public long IOPOSAttributeID { get; set; }
        public long IOPDateAttributeID { get; set; }
        public long IOPHRAttributeID { get; set; }
        public long IOPMinAttributeID { get; set; }



        public long MethodAttributevalueID { get; set; }
        public long IOPODAttributevalueID { get; set; }
        public long IOPOSAttributevalueID { get; set; }
        public long IOPDateAttributevalueID { get; set; }
        public long IOPHRAttributevalueID { get; set; }
        public long IOPMinAttributevalueID { get; set; }

        public string MethodAttributeName { get; set; }
        public string MethodAttributeValueName { get; set; }

        public string IOPODAttributeName { get; set; }
        public string IOPODAttributeValueName { get; set; }

        public string IOPOSAttributeName { get; set; }
        public string IOPOSAttributeValueName { get; set; }

        public string IOPDateAttributeName { get; set; }
        public string IOPDateAttributeValueName { get; set; }

        public string IOPHRAttributeName { get; set; }
        public string IOPHRateAttributeValueName { get; set; }

        public string IOPMinAttributeName { get; set; }
        public string IOPMinateAttributeValueName { get; set; }
  

                
                
 
    }
}
