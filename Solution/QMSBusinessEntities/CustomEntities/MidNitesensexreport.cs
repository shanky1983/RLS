using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class MidNitesensexreport
    {
        #region Fields      
        private int age = 0;
        private string sex = String.Empty;
        private string sexStatus = String.Empty;
        private string visitState = String.Empty;
        private DateTime dischargedDT = DateTime.MaxValue;
        private DateTime dOB = DateTime.MinValue;
        private DateTime dOD = DateTime.MinValue;
        private DateTime visitdate = DateTime.MaxValue;
        private DateTime fromdate = DateTime.MaxValue;
        private DateTime todate = DateTime.MaxValue;
        private string wardName = String.Empty;
        private string status = String.Empty;
        private int orgID = 0;
        private int patientVisitId = 0;
        #endregion

        #region methods
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string SexStatus
        {
            get { return sexStatus; }
            set { sexStatus = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public DateTime DischargedDT
        {
            get { return dischargedDT; }
            set { dischargedDT = value; }
        }
        public DateTime Visitdate
        {
            get { return visitdate; }
            set { visitdate = value; }
        }
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }
        public DateTime Fromdate
        {
            get { return fromdate; }
            set { fromdate = value; }
        }
        public DateTime Todate
        {
            get { return todate; }
            set { todate = value; }
        }
        public DateTime DOD
        {
            get { return dOD; }
            set { dOD = value; }
        }
        public string WardName
        {
            get { return wardName; }
            set { wardName = value; }
        }

        public string VisitState
        {
            get { return visitState; }
            set { visitState = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public int PatientVisitId
        {
            get { return patientVisitId; }
            set { patientVisitId = value; }
        }
        #endregion

    }
}
