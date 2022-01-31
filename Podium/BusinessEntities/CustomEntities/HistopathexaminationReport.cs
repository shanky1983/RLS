using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class HistopathexaminationReport
    {
        private string patientnumber = string.Empty;
        private string patientname = string.Empty;
        private string visitnumber = string.Empty;
        private string histopathnumber = string.Empty;
        private string testname = string.Empty;
        private string specimen = string.Empty;
        private string whoclassification = string.Empty;
        private string ismalignant = string.Empty;
        private string impression = string.Empty;
        private string staging = string.Empty;
        private string grading = string.Empty;

        private string diagnosis= string.Empty;
        private string tissueType= string.Empty;
        private string technicalRemarks= string.Empty;
        private string icd= string.Empty;
        private string category= string.Empty;

 	public string Diagnosis
        {
            get
            {
                return diagnosis;
            }
            set
            {
                diagnosis= value;
            }
        }

 	public string TissueType
        {
            get
            {
                return tissueType;
            }
            set
            {
                tissueType= value;
            }
        }

 	public string TechnicalRemarks
        {
            get
            {
                return technicalRemarks;
            }
            set
            {
                technicalRemarks= value;
            }
        }

 	public string ICD
        {
            get
            {
                return icd;
            }
            set
            {
                icd = value;
            }
        }

 	public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category= value;
            }
        }

        public string Impression
        {
            get
            {
                return impression;
            }
            set
            {
                impression = value;
            }
        }

        public string WHOClassification
        {
            get
            {
                return whoclassification;
            }
            set
            {
                whoclassification = value;
            }
        }

        public string TestName
        {
            get
            {
                return testname;
            }
            set
            {
                testname = value;
            }
        }
       

        public string PatientNumber
        {
            get
            {
                return patientnumber;
            }
            set
            {
                patientnumber = value;
            }
        }

       


        public string HistopathNumber
        {
            get
            {
                return histopathnumber;
            }
            set
            {
                histopathnumber = value;
            }
        }


       

        
        public string PatientName
        {
            get
            {
                return patientname;
            }
            set
            {
                patientname = value;
            }
        }

        public string Grading
        {
            get
            {
                return grading;
            }
            set
            {
                grading = value;
            }
        }
        public string VisitNumber
        {
            get
            {
                return visitnumber;
            }
            set
            {
                visitnumber = value;
            }
        }
        public string Staging
        {
            get
            {
                return staging;
            }
            set
            {
                staging = value;
            }
        }
        public string Specimen
        {
            get
            {
                return specimen;
            }
            set
            {
                specimen = value;
            }
        }
       
       
        public string IsMalignant
        {
            get
            {
                return ismalignant;
            }
            set
            {
                ismalignant = value;
            }
        }
       
      
    } 
    
}
