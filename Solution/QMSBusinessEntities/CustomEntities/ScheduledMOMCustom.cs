using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities.CustomEntities
{
   public  class ScheduledMOMCustom
    {

        #region Fields

        private long scheduledMOMID = 0;
        private long planScheduleID = 0;
        private int deptID = 0;
        private int orgid = 0;
        private int sno = 0;
        private string pointsDiscussed = String.Empty;
        private string actionProposed = String.Empty;
        private string deptname = String.Empty;
        private string proposedCompletionDate = String.Empty;
        private DateTime proposedCompDate = DateTime.MaxValue;
        private long responsiblePerson = 0;
        private string status = String.Empty;
        private string responsiblePersonName = String.Empty;
       

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ScheduledMOMID value.
        /// </summary>
        /// 

        public string ResponsiblePersonName
        {
            get { return responsiblePersonName; }
            set { responsiblePersonName = value; }
        }

        public long ScheduledMOMID
        {
            get { return scheduledMOMID; }
            set { scheduledMOMID = value; }
        }

        /// <summary>
        /// Gets or sets the PlanScheduleID value.
        /// </summary>
        public long PlanScheduleID
        {
            get { return planScheduleID; }
            set { planScheduleID = value; }
        }

        /// <summary>
        /// Gets or sets the DeptID value.
        /// </summary>
        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        /// <summary>
        /// Gets or sets the PointsDiscussed value.
        /// </summary>
        public string PointsDiscussed
        {
            get { return pointsDiscussed; }
            set { pointsDiscussed = value; }
        }

        /// <summary>
        /// Gets or sets the ActionProposed value.
        /// </summary>
        public string ActionProposed
        {
            get { return actionProposed; }
            set { actionProposed = value; }
        }

        /// <summary>
        /// Gets or sets the ProposedCompDate value.
        /// </summary>
        public DateTime ProposedCompDate
        {
            get { return proposedCompDate; }
            set { proposedCompDate = value; }
        }

        /// <summary>
        /// Gets or sets the ResponsiblePerson value.
        /// </summary>
        public long ResponsiblePerson
        {
            get { return responsiblePerson; }
            set { responsiblePerson = value; }
        }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public int OrgID
        {
            get { return orgid; }
            set { orgid = value; }
        }


        public int SNO
        {
            get { return sno; }
            set { sno = value; }
        }

        public string DeptName
        {
            get { return deptname; }
            set { deptname = value; }
        }

        public string ProposedCompletionDate
        {
            get { return  proposedCompletionDate; }
            set { proposedCompletionDate = value; }
        }




        #endregion
    }
}
