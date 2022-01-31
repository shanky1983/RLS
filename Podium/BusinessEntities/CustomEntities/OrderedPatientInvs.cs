using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class OrderedPatientInvs
    {
        private long investigationID =-1;
        string investigationName = string.Empty;
        string patientGender = string.Empty;
        string patientAge = string.Empty;
        string patientAgeType = string.Empty;
        string invValue = string.Empty;
        private long patientVisitID = -1;
        private long accessionNumber =-1;
        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        public string InvValue
        {
            get { return invValue; }
            set { invValue = value; }
        }
        public string PatientGender
        {
            get { return patientGender; }
            set { patientGender = value; }
        }
        public string PatientAge
        {
            get { return patientAge; }
            set { patientAge = value; }
        }
        public string PatientAgeType
        {
            get { return patientAgeType; }
            set { patientAgeType = value; }
        }

        public long InvestigationID
        {
            get { return investigationID; }
            set { investigationID = value; }
        }

        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }

        public long AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
        }
    }
}
