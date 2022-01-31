using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class HistopathologyTATReport
    {

        private string accessionnumber = string.Empty;
        private string patientname = string.Empty;
        private string dob = string.Empty;
        private string agegender = string.Empty;
        private string nationality = string.Empty;
        private string clientname = string.Empty;
        private string visitnumber = string.Empty;
        private string physician = string.Empty;
        private string specimen = string.Empty;
        private string classification = string.Empty;
        private string examinationcategory = string.Empty;
        private string specialprocedure = string.Empty;
        private string block = string.Empty;
        private string slide = string.Empty;
        private string ismalignent = string.Empty;
        private string diagnosis = string.Empty;
        private string datereceived = string.Empty;
        private string dateofreport = string.Empty;
        private string expectedtat = string.Empty;
        private string grossdonby = string.Empty;
        private string microscopydoneby = string.Empty;
        private string pathaologistname = string.Empty;
        private string datecollected = string.Empty;
        private string datecompleted = string.Empty;
        private string dategrossed = string.Empty;
        private string datetissued=string.Empty;
        private string datelideprepared = string.Empty;
        private string datestatincomplete = string.Empty;
        private string datemicrocomplete=string.Empty;
        private string status = string.Empty;
        private string histopathnumber = string.Empty;
        private string patientnumber = string.Empty;
        private string testname = string.Empty;
        private string actualtat = string.Empty;
        private string orderedtime = string.Empty;

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
        public string OrderedTime
        {
            get
            {
                return orderedtime;
            }
            set
            {
                orderedtime = value;
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

        public string ActualTAT
        {
            get
            {
                return actualtat;
            }
            set
            {
                actualtat = value;
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


        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public string DateCollected
        {
            get
            {
                return datecollected;
            }
            set
            {
                datecollected = value;
            }
        }


        public string DateCompleted
        {
            get
            {
                return datecompleted;
            }
            set
            {
                datecompleted = value;
            }
        }

        public string DateGrossed
        {
            get
            {
                return dategrossed;
            }
            set
            {
                dategrossed = value;
            }
        }

        public string DateTissued
        {
            get
            {
                return datetissued;
            }
            set
            {
                datetissued = value;
            }
        }


        public string DateSlidePrepared
        {
            get
            {
                return datelideprepared;
            }
            set
            {
                datelideprepared = value;
            }
        }

        public string DateStatinComplete
        {
            get
            {
                return datestatincomplete;
            }
            set
            {
                datestatincomplete = value;
            }
        }


        public string DateMicroComplete
        {
            get
            {
                return datemicrocomplete;
            }
            set
            {
                datemicrocomplete = value;
            }
        }

        public string AccessionNumber
        {
            get
            {
                return accessionnumber;
            }
            set
            {
                accessionnumber = value;
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
        public string DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public string AgeGender
        {
            get
            {
                return agegender;
            }
            set
            {
                agegender = value;
            }
        }
        public string Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                nationality = value;
            }
        }
        public string ClientName
        {
            get
            {
                return clientname;
            }
            set
            {
                clientname = value;
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
        public string Physician
        {
            get
            {
                return physician;
            }
            set
            {
                physician = value;
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
       
        public string ExaminationCategory
        {
            get
            {
                return examinationcategory;
            }
            set
            {
                examinationcategory = value;
            }
        }
        public string SpecialProcedure
        {
            get
            {
                return specialprocedure;
            }
            set
            {
                specialprocedure = value;
            }
        }
        public string Block
        {
            get
            {
                return block;
            }
            set
            {
                block = value;
            }
        }
        public string Slide
        {
            get
            {
                return slide;
            }
            set
            {
                slide = value;
            }
        }
        public string IsMalignent
        {
            get
            {
                return ismalignent;
            }
            set
            {
                ismalignent = value;
            }
        }
        public string Diagnosis
        {
            get
            {
                return diagnosis;
            }
            set
            {
                diagnosis = value;
            }
        }

        public string DateReceived
        {
            get
            {
                return datereceived;
            }
            set
            {
                datereceived = value;
            }
        }
        public string DateofReport
        {
            get
            {
                return dateofreport;
            }
            set
            {
                dateofreport = value;
            }
        }
        public string ExpectedTAT
        {
            get
            {
                return expectedtat;
            }
            set
            {
                expectedtat = value;
            }
        }
        public string GrossDoneBy
        {
            get
            {
                return grossdonby;
            }
            set
            {
                grossdonby = value;
            }
        }
        public string MicroscopyDoneBy
        {
            get
            {
                return microscopydoneby;
            }
            set
            {
                microscopydoneby = value;
            }
        }
        public string PathaologistName
        {
            get
            {
                return pathaologistname;
            }
            set
            {
                pathaologistname = value;
            }
        }
    } 
    
}
