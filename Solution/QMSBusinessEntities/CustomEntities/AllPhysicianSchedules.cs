using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class AllPhysicianSchedules
    {
        private long resourceTemplateID = 0;
        private long scheduleTemplateID = 0;
        private long resourceID = 0;
        private long recurrenceID = 0;
        private long parentRecurrenceCycleID = 0;
        private long recurrenceCycleID = 0;
        private DateTime startTime = DateTime.MaxValue;
        private DateTime endTime = DateTime.MaxValue;
        private int slotDuration = 0;
        private int YEvery = 0;
        private string YDateMonth = string.Empty;
        private int MEvery = 0;
        private int MDayofMonth = 0;
        private int MDayofWeek = 0;
        private int WEvery = 0;
        private string sunday = string.Empty;
        private string monday = string.Empty;
        private string tuesday = string.Empty;
        private string wednesday = string.Empty;
        private string thursday = string.Empty;
        private string friday = string.Empty;
        private string saturday = string.Empty;
        private int locationID = 0;
        private string locationName = string.Empty;
        private DateTime nextoccurance = DateTime.MaxValue;
        
        public long ResourceTemplateID
        {
            get { return resourceTemplateID; }
            set { resourceTemplateID = value; }
        }
        public long ScheduleTemplateID
        {
            get { return scheduleTemplateID; }
            set { scheduleTemplateID = value; }
        }
        public long ResourceID
        {
            get { return resourceID; }
            set { resourceID = value; }
        }
        public long RecurrenceID
        {
            get { return recurrenceID; }
            set { recurrenceID = value; }
        }
        public long ParentRecurrenceCycleID
        {
            get { return parentRecurrenceCycleID; }
            set { parentRecurrenceCycleID = value; }
        }
        public long RecurrenceCycleID
        {
            get { return recurrenceCycleID; }
            set { recurrenceCycleID = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public int SlotDuration
        {
            get { return slotDuration; }
            set { slotDuration = value; }
        }
        public int yEvery
        {
            get { return YEvery; }
            set { YEvery = value; }
        }
        public string yDateMonth
        {
            get { return YDateMonth; }
            set { YDateMonth = value; }
        }
        public int mEvery
        {
            get { return MEvery; }
            set { MEvery = value; }
        }
        public int mDayofWeek
        {
            get { return MDayofWeek; }
            set { MDayofWeek = value; }
        }
        public int mDayofMonth
        {
            get { return MDayofMonth; }
            set { MDayofMonth = value; }
        }
        public int wEvery
        {
            get { return WEvery; }
            set { WEvery = value; }
        }
        public string Sunday
        {
            get { return sunday; }
            set { sunday = value; }
        }
        public string Monday
        {
            get { return monday; }
            set { monday = value; }
        }
        public string Tuesday
        {
            get { return tuesday; }
            set { tuesday = value; }
        }
        public string Wednesday
        {
            get { return wednesday; }
            set { wednesday = value; }
        }
        public string Thursday
        {
            get { return thursday; }
            set { thursday = value; }
        }
        public string Friday
        {
            get { return friday; }
            set { friday = value; }
        }
        public string Saturday
        {
            get { return saturday; }
            set { saturday = value; }
        }
        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }
        public DateTime NextOccurance
        {
            get { return nextoccurance; }
            set { nextoccurance = value; }
        }

        private DateTime endDate = DateTime.MaxValue;
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private string type = string.Empty;
        public string  Type
        {
            get { return type; }
            set { type = value; }
        }

        private string start = string.Empty;
        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        private string end = string.Empty;
        public string End
        {
            get { return end; }
            set { end = value; }
        }
             

        private string starthours = string.Empty;
        public string Starthours
        {
            get { return starthours; }
            set { starthours = value; }
        }
        private string endhours = string.Empty;
        public string Endhours
        {
            get { return endhours; }
            set { endhours = value; }
        }

        private string schedulesType = string.Empty;
        public string SchedulesType
        {
            get { return schedulesType; }
            set { schedulesType = value; }
        }
        private string isActive = string.Empty;
        public string IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        
    }
}
