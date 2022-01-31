using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class EventChart
    {
        #region Fields

        private Int64 visitId = 0;
        private DateTime eventDate = DateTime.MaxValue;
        private string eventName = String.Empty;
        private string physician = String.Empty;
        private string visitNotes = String.Empty;
        private string isQuery = String.Empty;
        private int complaintID = 0;
        private string showOptions = String.Empty;
        private string managementDetails = String.Empty;
        private string organisationname = String.Empty;
        private Int32 orgID = 0;
        private int visitPurposeID = 0;

        #endregion


        #region Properties



        public Int64 VisitId
        {
            get { return visitId; }
            set { visitId = value; }
        }

        public DateTime Date
        {
            get { return eventDate; }
            set { eventDate = value; }
        }

        public string Events
        {
            get { return eventName; }
            set { eventName = value; }
        }


        public string Physician
        {
            get { return physician; }
            set { physician = value; }
        }

        public string VisitNotes
        {
            get { return visitNotes; }
            set { visitNotes = value; }
        }

        public string IsQuery
        {
            get { return isQuery; }
            set { isQuery = value; }
        }
        public int ComplaintID
        {
            get { return complaintID; }
            set { complaintID = value; }
        }
        public string ShowOptions
        {
            get { return showOptions; }
            set { showOptions = value; }
        }

        public string ManagementDetails
        {
            get { return managementDetails; }
            set { managementDetails = value; }
        }
        public string OrganisationName
        {
            get { return organisationname; }
            set { organisationname = value; }
        }

        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the VisitPurposeID value.
        /// </summary>
        public int VisitPurposeID
        {
            get { return visitPurposeID; }
            set { visitPurposeID = value; }
        }
        #endregion

    }
}
