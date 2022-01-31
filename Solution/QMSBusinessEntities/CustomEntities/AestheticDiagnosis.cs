using System;
using System.Collections.Generic;
using System.Text;


namespace Attune.Solution.QMSBusinessEntities
{
    public class AestheticDiagnosis
    {
        public long ExaminationID
        {
            get;
            set;
        }

        public string IdentifyingType
        {
            get;
            set;
        }

        public string ExaminationName
        {
            get;
            set;
        }

        public string AttributeName
        {
            get;
            set;
        }


        public string AttributeValueName
        {
            get;
            set;
        }

        public long AttributeID
        {
            get;
            set;
        }

        public long AttributevalueID
        {
            get;
            set;
        }


        public string AttributeCode
        {
            get;
            set;
        }

        public int EditMode
        {
            get;
            set;
        }
        public long SeqID
        {
            get;
            set;
        }

        public long PatientExaminationAttributeID
        {
            get;
            set;
        }

        public string PatientName
        {
            get;
            set;
        }

        public string PatientNumber
        {
            get;
            set;
        }


        public string Sex
        {
            get;
            set;
        }

        public string Age
        {
            get;
            set;
        }

        public DateTime VisitDate
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }

        public string CreatedBy
        {
            get;
            set;
        }


    }
}
