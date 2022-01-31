using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class AppointmentPrintcls
    {
        private long _Sno;
        private string _PatientName;
        private string _PhoneNumber;
        private string _Address;
        private string _Place;
        private string _AppointmentStatus;
        private string _PatientCategory;
        private string _AppointmentDate;
        private string _StartTime;
        private string _EndTime;
        private string _PhysicianName;
        private long _PhysicianID;
        private string _createdby;
        private string _modifiedby;

        public long Sno { get { return _Sno; } set { _Sno = value; } }
        public string PatientName { get { return _PatientName; } set { _PatientName = value; } }
        public string PhoneNumber { get { return _PhoneNumber; } set { _PhoneNumber = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string Place { get { return _Place; } set { _Place = value; } }
        public string AppointmentStatus { get { return _AppointmentStatus; } set { _AppointmentStatus = value; } }
        public string PatientCategory { get { return _PatientCategory; } set { _PatientCategory = value; } }
        public string AppointmentDate { get { return _AppointmentDate; } set { _AppointmentDate = value; } }
        public string StartTime { get { return _StartTime; } set { _StartTime = value; } }
        public string EndTime { get { return _EndTime; } set { _EndTime = value; } }
        public string PhysicanName { get { return _PhysicianName; } set { _PhysicianName = value; } }
        public long PhysicanID { get { return _PhysicianID; } set { _PhysicianID = value; } }
        public string CreatedBy { get { return _createdby; } set { _createdby = value; } }
        public string ModifiedBy { get { return _modifiedby; } set { _modifiedby = value; } }
    }
}
