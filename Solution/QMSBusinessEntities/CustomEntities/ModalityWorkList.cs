using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class ModalityWorkList
    {
        #region Fields

        private string patientname;
        private long patientID;
        private string age = String.Empty;
        private DateTime dOB = DateTime.MaxValue;
        private DateTime schprocstepstartdate = DateTime.MaxValue;
        private string sEX = String.Empty;
        private string referingPhysicianName = String.Empty;
        private long accessionnumber;
        private string modalityname = string.Empty;
        private string reqproceduredescription = string.Empty;
        private string studyInstanceUId = String.Empty;
        #endregion

        /// <summary>
        /// Gets or sets the DOB value.
        /// </summary>
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }


        public string PatientName
        {
            get { return patientname; }
            set { patientname = value; }
        }

        public string SEX
        {
            get { return sEX; }
            set { sEX = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public string ReferingPhysicianName
        {
            get { return referingPhysicianName; }
            set { referingPhysicianName = value; }
        }
        public long AccessionNumber
        {
            get { return accessionnumber; }
            set { accessionnumber = value; }
        }
        public string ModalityName
        {
            get { return modalityname; }
            set { modalityname = value; }
        }
        public string ReqProcedureDescription
        {
            get { return reqproceduredescription; }
            set { reqproceduredescription = value; }
        }

        public DateTime SchProcStepStartDate
        {
            get { return schprocstepstartdate; }
            set { schprocstepstartdate = value; }
        }
        public string StudyInstanceUId
        {
            get { return studyInstanceUId; }
            set { studyInstanceUId = value; }
        }
        private string rISaccessionnumber = String.Empty;
        public string RISAccessionNumber
        {
            get { return rISaccessionnumber; }
            set { rISaccessionnumber = value; }
        }

    }
}
