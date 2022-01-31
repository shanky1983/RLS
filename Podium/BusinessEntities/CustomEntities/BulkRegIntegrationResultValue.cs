using System;
using System.Collections.Generic; 
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BulkRegIntegrationResultValue
    {
        #region Fields
        private long _reportId = 0;
        private DateTime _reportDate = DateTime.MaxValue;
        private string _TestCode = string.Empty;
        private string _value = string.Empty;
        private string _unit = string.Empty;
        private string _testmethod = string.Empty;
        private string _normalrange = string.Empty;
        private string _interpretation = string.Empty;
        private string _specimen = string.Empty;
        private string _investigationName = string.Empty;


        #endregion

        #region Properties
        public long reportId
        {
            get { return _reportId; }
            set { _reportId = value; }
        }
        public DateTime reportDate
        {
            get { return _reportDate; }
            set { _reportDate = value; }
        }
        public string TestCode
        {
            get { return _TestCode; }
            set { _TestCode = value; }
        }
        public string value
        {
            get { return _value; }
            set { _value = value; }
        }
        public string unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        public string testmethod
        {
            get { return _testmethod; }
            set { _testmethod = value; }
        }
        public string normalrange
        {
            get { return _normalrange; }
            set { _normalrange = value; }
        }
        public string interpretation
        {
            get { return _interpretation; }
            set { _interpretation = value; }
        }
        public string specimen
        {
            get { return _specimen; }
            set { _specimen = value; }
        }
        public string InvestigationName
        {
            get { return _investigationName; }
            set { _investigationName = value; }
        }
        private string _doctor;
        public string doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }
        private string _spectiality;
        public string Speciality
        {
            get { return _spectiality; }
            set { _spectiality = value; }
        }
        private byte[] _signature;
        public byte[] Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }
        private string filePath = string.Empty;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        private long patientVisitID = -1;
        public long PatientVisitID
        {
            get { return patientVisitID; }
            set { patientVisitID = value; }
        }
        private int orgID = 0;
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        private string _designation = string.Empty;
        public string designation
        {
            get { return _designation; }
            set { _designation = value; }
        }
        private string _TestName = string.Empty;
        public string TestName
        {
            get { return _TestName; }
            set { _TestName = value; }
        }
        private DateTime _ApprovedDate;
        public DateTime ApprovedDate
        {
            get { return _ApprovedDate; }
            set { _ApprovedDate = value; }
        }
        private DateTime _AccessionDate;
        public DateTime AccessionDate
        {
            get { return _AccessionDate; }
            set { _AccessionDate = value; }
        }
        private DateTime _ReportDate ;
        public DateTime ReportDate
        {
            get { return _ReportDate; }
            set { _ReportDate = value; }
        }
        
            
              
        #endregion
    }
}
