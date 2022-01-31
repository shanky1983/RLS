using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class SurgeryReport
    {
        private long id;
        private string name = string.Empty;
        private long chiefSurgeonID;
        private string type = string.Empty;
        private string treatmentName = string.Empty;


        public long ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public long ChiefSurgeonID
        {
            get
            {
                return chiefSurgeonID;
            }
            set
            {
                chiefSurgeonID = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string TreatmentName
        {
            get
            {
                return treatmentName;
            }
            set
            {
                treatmentName = value;
            }
        }    
    }
}
