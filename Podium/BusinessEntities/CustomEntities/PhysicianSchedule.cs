using System;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;

namespace Attune.Podium.BusinessEntities
{
    public class PhysicianSchedule
    {
        private Physician physician = new Physician();
        private Speciality speciality = new Speciality();
        private TimeSpan from;
        private TimeSpan to;
        private long resourceTemplateID;
        private string physicianType = string.Empty;
        private DateTime nextOccurance;
        private int slotDuration;
        private DateTime prevOccurance;
        private long scheduleID;
        private int booked;


        public long  PhysicianID
        {
            get { return physician.PhysicianID; }
            set { physician.PhysicianID = value; }
        }

        public string PhysicianName
        {
            get
            { return physician.PhysicianName;      }
            set
            {
                physician.PhysicianName = value;
            }
        }

        public string SpecialityName
        {
            get
            {
                return speciality.SpecialityName;
            }
            set
            {
                speciality.SpecialityName = value;
            }
        }

        public DateTime NextOccurance
        {
            get
            {
                return nextOccurance;
            }
            set
            {
                nextOccurance = value;
            }
        }

        public TimeSpan From
        {
            get
            {
                return from;
            }
            set
            {
                from = value;
            }
        }

        public TimeSpan To
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }

        public string PhysicianType
        {
            get { return physicianType; }
            set { physicianType = value; }

        }

        public long ResourceTemplateID
        {
            get { return resourceTemplateID; }
            set { resourceTemplateID = value; }
        }

        public int SlotDuration
        {
            get { return slotDuration; }
            set { slotDuration = value; }
        }

        public DateTime PreviousOccurance
        {
            get { return prevOccurance; }
            set { prevOccurance = value; }
        }

        public long ScheduleID
        {
            get { return scheduleID; }
            set { scheduleID = value; }
        }

        int _specialityid;
        public int SpecialityID
        {
            get { return _specialityid; }
            set { _specialityid = value; }
        }
        public int Booked
        {
            get { return booked; }
            set { booked = value; }
        }
        int totalSlots=0;
        public int TotalSlots
        {
            get { return totalSlots; }
            set { totalSlots = value; }
        }
        string resourceType = "";
        public string ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }

    }
}
