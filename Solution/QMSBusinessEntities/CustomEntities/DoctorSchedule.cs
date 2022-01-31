using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class DoctorSchedule
    {
        private int tokenNumber;
        private string startTime;
        private string endTime;
        private string bookingDescription;
        private int resourceID;
        private string resourceType;
        private string physicianName;
        private int orgID;

        public int TokenNumber
        {
            get
            {
                return tokenNumber;
            }
            set
            {
                tokenNumber = value;
            }
        }
        public string PhysicianName
        {
            get
            {
                return physicianName;
            }
            set
            {
                physicianName = value;
            }
        }
        public string StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }
        public string EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }
        public string BookingDescription
        {
            get
            {
                return bookingDescription;
            }
            set
            {
                bookingDescription = value;
            }
        }

        public int ResourceID
        {
            get
            {
                return resourceID;
            }
            set
            {
                resourceID = value;
            }
        }

        public string ResourceType
        {
            get
            {
                return resourceType;
            }
            set
            {
                resourceType = value;
            }
        }

        public int OrgID
        {
            set { orgID = value; }
            get { return orgID; }
        }

    }
}
