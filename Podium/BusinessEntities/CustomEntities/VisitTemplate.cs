using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class VisitTemplate
    {
        private long _PatientVisitID;
        private long _FeeID;
        private string _FeeType;
        private long _TemplateID;
        private string _TemplateData;
        private long _FinalBillID;
        private int _OrgID;
        private long _CreatedBy;
        private DateTime _CreatedAt;
        private long _ModifiedBy;
        private DateTime _ModifiedAt;
       

        public long PatientVisitID 
        { get { return _PatientVisitID; } 
          set { _PatientVisitID = value; }
        }

        public long FeeID { 
            get { return _FeeID; } 
            set { _FeeID = value; }
        }
        public string FeeType {
            get { return _FeeType; }
            set { _FeeType = value; } 
        }
        public long TemplateID { 
            get { return _TemplateID; }
            set { _TemplateID = value; } 
        }
        public string TemplateData {
            get { return _TemplateData; } 
            set { _TemplateData = value; } 
        }
        public long FinalBillID { 
            get { return _FinalBillID; } 
            set { _FinalBillID = value; }
        }
        public int OrgID { 
            get { return _OrgID; }
            set { _OrgID = value; }
        }
        public long CreatedBy { 
            get { return _CreatedBy; } 
            set { _CreatedBy = value; } 
        }
        public DateTime CreatedAt { 
            get { return _CreatedAt; }
            set { _CreatedAt = value; }
        }
        public long ModifiedBy { get
            { return _ModifiedBy; }
            set { _ModifiedBy = value; } 
        }
        public DateTime ModifiedAt {
            get { return _ModifiedAt; } 
            set { _ModifiedAt = value; } 
        }
        
    }
}
